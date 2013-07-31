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

namespace Mappy
{
	public class BankEntityMapView : SupportMapFragment, CacheChangeListener
	{
		MapViewModel ViewModel;

		private List<EntityMarker> LocationsPlottedOnMap = new List<EntityMarker>();

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
		}

		void InitializeMap ()
		{
			if (this.Map != null) {
				//this.Map.CameraChange += (sender, e) => UpdateMap ((this.Activity as BankEntityLocator).UserSelection);
				ConfigureMapUiSettings ();
				UpdateMap ((this.Activity as BankEntityLocator).UserSelection);
				FlyDownToMyLocation ();
				UpdateClosestEntityMarker ();
			}
		}

		void FlyDownInitially (object sender, GoogleMap.MyLocationChangeEventArgs e)
		{
			FlyDownToMyLocation ();
			this.Map.MyLocationChange -= FlyDownInitially;
		}

		private void FlyDownToMyLocation ()
		{
			if(this.Map.MyLocation != null)
			{
				CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (GetMyLocation (), MapViewModel.DEFAULT_ZOOM_LEVEL);
				this.Map.AnimateCamera (camUpdate);
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

		public async void UpdateMap (Options userSelection)
		{
			Activity.FindViewById<TextView> (Resource.Id.zoomLevel).Text = CurrentZoomLevel.ToString();

			if (ViewModel.ShouldIconChange (CurrentZoomLevel)) {
				UpdateMapBasedOnZoomThreshold ();
			} 
			if (CurrentZoomLevel > MapViewModel.MAX_SUPPORTED_ZOOM_LEVEL) {
				LatLng coordinates = this.Map.CameraPosition.Target;
				await ViewModel.FetchEntitiesAsync (coordinates.Latitude, coordinates.Longitude, 1000);
				FetchAndUpdate ();
			} else {
				Toast.MakeText(this.Activity, "Zoom in to view more locations", ToastLength.Short).Show();
			}

			ViewModel.LastZoomLevel = CurrentZoomLevel;
		}

		//Currently behaves a lot better just by clearing hte app. Otherwise locations stack. Maybe better to reenable this when service is better.
		private void UpdateMapBasedOnZoomThreshold ()
		{
			IconType icon = ViewModel.IconForCurrentZoomLevel (CurrentZoomLevel);
			if (icon != IconType.None) {
				foreach (EntityMarker location in LocationsPlottedOnMap) {
					location.UpdateIcon (icon);				}
			}
		}

		public void ResetMap()
		{
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

		private float CurrentZoomLevel {
			get {
				return this.Map.CameraPosition.Zoom;
			}
		}

		private LatLng GetMyLocation ()
       	{
	       return new LatLng (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude);
       	}

		private void UpdateClosestEntityMarker ()
		{
//			if (this.Map.MyLocation != null) {
//				var allEntities = EntitiesService.fetch (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude, 1, (this.Activity as BankEntityLocator).UserSelection);
//				if (allEntities != null && allEntities.Count > 0) {
//					if(ClosestBankEntityMarker != null) ClosestBankEntityMarker.ResetIconFromClosest (IconForCurrentZoomLevel ());
//					BankEntity closestBankEntity = allEntities.First ();
//					ClosestBankEntityMarker = new EntityMarker (closestBankEntity, EntityMarker.IconType.Closest, EntityMarker.MarkerType.Nearest);
//					ClosestBankEntityMarker.AddMarkerTo (this.Map);
//				}
//			}
		}

		public void FetchAndUpdate()
		{
			Activity.RunOnUiThread (() => {
				LatLngBounds viewBounds = this.Map.Projection.VisibleRegion.LatLngBounds;
				List<BankEntity> entities = ViewModel.Fetch (new AndroidViewportFilter (viewBounds), (Activity as BankEntityLocator).UserSelection);

				UpdateViewWithEntities (entities);
			});
		}

		void UpdateViewWithEntities (List<BankEntity> entities)
		{
			var iconType = ViewModel.IconForCurrentZoomLevel(CurrentZoomLevel);
			if(iconType == IconType.None) return;

			List<BankEntity> plottedEntities = (from marker in LocationsPlottedOnMap select marker.Entity).ToList ();
			var entitiesToPlot = entities.Except (plottedEntities);

			foreach (BankEntity aEntity in entitiesToPlot) {
				var marker = new EntityMarker (aEntity, iconType);
				marker.AddMarkerTo(this.Map);
				LocationsPlottedOnMap.Add(marker);
			}
		}

		public void UserLocationUpdated ()
		{
			UpdateClosestEntityMarker ();
		}
	}
}