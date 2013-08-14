using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Gms.Common;
using Android.Gms.Location;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Java.Util;
using Mappy.Common;

namespace Mappy
{
	public class BankEntityMapView : SupportMapFragment, CacheChangeListener
	{
		private MapViewModel ViewModel;
		private List<EntityMarker> LocationsPlottedOnMap = new List<EntityMarker>();
		private EntityMarker EntityClosestToUser;
		private const int LocationBatchSize = 200;

		public static BankEntityMapView newInstance() {
			return new BankEntityMapView();
		}

		public BankEntityMapView()
		{
			ViewModel = new MapViewModel ();
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
			InitializeMap ();
			ViewModel.IconTypeChanged += UpdateIcons;
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
			ViewModel.IconTypeChanged -= UpdateIcons;
		}

		private void InitializeMap ()
		{
			if (this.Map != null) {
				this.Map.CameraChange += (sender, e) => UpdateMap ();
				ConfigureMapUiSettings ();
				UpdateMap ();
			}
		}

		public void FlyDownToMyLocation ()
		{
			if ((this.Activity as BankEntityLocator).LocationClientConnected) {
				if(MyLocation != null)
				{
					Location myLocation = MyLocation;
					CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (new LatLng (myLocation.Latitude, myLocation.Longitude), MapViewModel.DEFAULT_ZOOM_LEVEL);
					this.Map.MoveCamera (camUpdate);
				}
			}
		}

		public void UserLocationUpdated (Location userLocation)
		{
			if (userLocation != null) 
			{
				FetchClosestAtmOrBranch (userLocation.Latitude, userLocation.Longitude);
				if (MyLocationIsWithinViewPort (userLocation))
					UpdateMap ();
			}
		}

		private bool MyLocationIsWithinViewPort (Location userLocation)
		{
			if (userLocation == null) return false;
			LatLngBounds viewBounds = this.Map.Projection.VisibleRegion.LatLngBounds;
			return viewBounds.Contains (new LatLng (userLocation.Latitude, userLocation.Longitude));
		}
			
		private Location MyLocation {
			get {
				return (Activity as IMapActivity).LocationClient.LastLocation;
			}
		}

		public override void OnResume()
		{
			base.OnResume ();
			ViewModel.Register (this);
		}


		public override void OnPause()
		{
			base.OnPause ();
			ViewModel.Deregister (this);
		}

		public void UpdateMap ()
		{
			ViewModel.ZoomLevel = Map.CameraPosition.Zoom;

			if (ViewModel.ZoomLevel > MapViewModel.MAX_SUPPORTED_ZOOM_LEVEL) {
				LatLng coordinates = ReferenceLocationToFetchEntities ();
				ViewModel.FetchEntitiesAsync (coordinates.Latitude, coordinates.Longitude, LocationBatchSize);
			}
		}

		private LatLng ReferenceLocationToFetchEntities ()
		{
			return (MyLocation != null  && MyLocationIsWithinViewPort(MyLocation)) ? new LatLng(MyLocation.Latitude, MyLocation.Longitude) : this.Map.CameraPosition.Target;
		}

		public void BringLocationToCenter (LatLng selectedLocation)
		{
			CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (selectedLocation, ViewModel.ZoomLevel);
			this.Map.MoveCamera (camUpdate);
		}

		private void UpdateIcons (object sender, EventArgs e)
		{
			foreach (EntityMarker location in LocationsPlottedOnMap)
				location.IconType = ViewModel.IconType;
		}

		public void ResetMap()
		{
			if (this.Map != null)
				this.Map.Clear ();
			this.LocationsPlottedOnMap.Clear ();
		}

		private void ConfigureMapUiSettings ()
		{
			this.Map.MapType = GoogleMap.MapTypeNormal;
			this.Map.MyLocationEnabled = true;
			UiSettings mapUISettings = this.Map.UiSettings;
			mapUISettings.CompassEnabled = false;
			mapUISettings.MyLocationButtonEnabled = true;
			mapUISettings.ZoomControlsEnabled = false;
			mapUISettings.ScrollGesturesEnabled = true;
			mapUISettings.SetAllGesturesEnabled (true);
		}

		public void FetchAndUpdate()
		{
			if (Activity != null && this.Map != null) {
				Activity.RunOnUiThread (() => {
					LatLngBounds viewBounds = this.Map.Projection.VisibleRegion.LatLngBounds;
					List<BankEntity> entities = ViewModel.Fetch (new AndroidViewportFilter (viewBounds), (Activity as IMapActivity).MapOptions);
					UpdateViewWithEntities (entities);
					(Activity as BankEntityLocator).UpdateListView(entities, MyLocationIsWithinViewPort(MyLocation));
				});
			}
		}

		public void FetchAndUpdateClosest()
		{
			BankEntity closestBankEntity = ViewModel.ClosestEntity ((this.Activity as BankEntityLocator).MapOptions);
			if (EntityClosestToUser != null && closestBankEntity.Equals (EntityClosestToUser)) return;
			if (closestBankEntity != null) {
				Activity.RunOnUiThread (() => {
					if(EntityClosestToUser != null) EntityClosestToUser.IconType = ViewModel.IconType;
					EntityMarker plottedEntity = LocationsPlottedOnMap.Find (e => e.Entity.LocationId == closestBankEntity.LocationId);
					if (plottedEntity != null) {
						EntityClosestToUser = plottedEntity;
						plottedEntity.IconType = IconType.Closest;
					} else {
						var marker = new EntityMarker (closestBankEntity, IconType.Closest);
						marker.AddMarkerTo (this.Map);
						EntityClosestToUser = marker;
						LocationsPlottedOnMap.Add (marker);
					}
				});
			}
		}

		private void UpdateViewWithEntities (List<BankEntity> entities)
		{
			List<BankEntity> plottedEntities = (from marker in LocationsPlottedOnMap select marker.Entity).ToList ();
			var entitiesToPlot = entities.Except (plottedEntities);

			Activity.RunOnUiThread (() => {
				foreach (BankEntity aEntity in entitiesToPlot) {
					var marker = new EntityMarker (aEntity, ViewModel.IconType);
					marker.AddMarkerTo (this.Map);
					LocationsPlottedOnMap.Add (marker);
				}
			});
		}

		private void FetchClosestAtmOrBranch (double latitude, double longitude)
		{
			ViewModel.FetchEntitiesClosestToLocationAsync (latitude, longitude);
		}
	}
}