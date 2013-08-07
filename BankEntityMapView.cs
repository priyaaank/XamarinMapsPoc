using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;
using Java.Lang;
using Android.Gms.Maps.Model;
using System.Threading;
using Java.Util;
using Mappy.Common;
using Android.Gms.Location;
using Android.Gms.Common;
using Android.Locations;

namespace Mappy
{
	public class BankEntityMapView : SupportMapFragment, CacheChangeListener
	{
		MapViewModel ViewModel;

		private List<EntityMarker> LocationsPlottedOnMap = new List<EntityMarker>();
		private EntityMarker EntityClosestToUser;

		const int LocationBatchSize = 200;

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

		void InitializeMap ()
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
					CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (MyLocation, MapViewModel.DEFAULT_ZOOM_LEVEL);
					this.Map.MoveCamera (camUpdate);
				}
			}
		}

		public void UserLocationUpdated (Location userLocation)
		{
			FetchClosestAtmOrBranch (userLocation.Latitude, userLocation.Longitude);
			if (MyLocationIsWithinViewPort (userLocation)) UpdateMap ();
		}

		private bool MyLocationIsWithinViewPort (Location userLocation)
		{
			LatLngBounds viewBounds = this.Map.Projection.VisibleRegion.LatLngBounds;
			return viewBounds.Contains (new LatLng (userLocation.Latitude, userLocation.Longitude));
		}
			
		LatLng MyLocation {
			get {
				var location = (Activity as IMapActivity).LocationClient.LastLocation;
				if(location != null)
				{
					return new LatLng (location.Latitude, location.Longitude);
				}
				return null;
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
			Activity.FindViewById<TextView> (Resource.Id.zoomLevel).Text = ViewModel.ZoomLevel.ToString();

			if (ViewModel.ZoomLevel > MapViewModel.MAX_SUPPORTED_ZOOM_LEVEL) {
				LatLng coordinates = this.Map.CameraPosition.Target;
				ViewModel.FetchEntitiesAsync (coordinates.Latitude, coordinates.Longitude, LocationBatchSize);
			}
		}

		void UpdateIcons (object sender, EventArgs e)
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
					(Activity as BankEntityLocator).UpdateListView(entities);
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

		void UpdateViewWithEntities (List<BankEntity> entities)
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