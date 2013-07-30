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
	public class BankEntityMapView : SupportMapFragment
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
				LatLng myLocation = new LatLng (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude); 
				CameraPosition position = new CameraPosition.Builder ().Target (myLocation).Zoom (MapViewModel.DEFAULT_ZOOM_LEVEL).Build();
				CameraUpdate camUpdate = CameraUpdateFactory.NewCameraPosition(position);
				this.Map.AnimateCamera (camUpdate);
			}
		}

		public void UpdateMap (Options userSelection)
		{
			var zoomLevel = this.Map.CameraPosition.Zoom;
			Activity.FindViewById<TextView> (Resource.Id.zoomLevel).Text = zoomLevel.ToString();

			if (ViewModel.ShouldIconChange (CurrentZoomLevel)) {
				UpdateMapBasedOnZoomThreshold ();
			} 
			if (zoomLevel > MapViewModel.MAX_SUPPORTED_ZOOM_LEVEL) {
				LatLng coordinates = this.Map.CameraPosition.Target;
				ShowEntitiesOnMap (coordinates, userSelection);
			} else {
				Toast.MakeText(this.Activity, "Zoom in to view more locations", ToastLength.Short).Show();
			}

			ViewModel.LastZoomLevel = CurrentZoomLevel;
		}

		//Currently behaves a lot better just by clearing hte app. Otherwise locations stack. Maybe better to reenable this when service is better.
		private void UpdateMapBasedOnZoomThreshold ()
		{
			this.Map.Clear ();
//			EntityMarker.IconType icon = IconForCurrentZoomLevel ();
//			if (icon != EntityMarker.IconType.None) {
//				foreach (EntityMarker location in LocationsPlottedOnMap) {
//					location.ChangeIcon (icon);
//					location.AddMarkerTo (this.Map);
//				}
//			}
		}

		public void ResetMap()
		{
			this.Map.Clear ();
		}

		async void ShowEntitiesOnMap (LatLng coordinates, Options userSelection)
		{
			List<BankEntity> bankEntities = await ViewModel.FetchEntitiesAsync (coordinates.Latitude, coordinates.Longitude, userSelection);

			var iconSize = ViewModel.IconForCurrentZoomLevel (CurrentZoomLevel);
			if(iconSize == IconType.None) return;

			foreach (BankEntity aEntity in bankEntities) {
				var marker = new EntityMarker(aEntity, iconSize, new LatLng(aEntity.Latitude, aEntity.Longitude));
				marker.AddMarkerTo(this.Map);
				LocationsPlottedOnMap.Add(marker);
			}
		}

		void ConfigureMapUiSettings ()
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

		float CurrentZoomLevel {
			get {
				return this.Map.CameraPosition.Zoom;
			}
		}
	}
}