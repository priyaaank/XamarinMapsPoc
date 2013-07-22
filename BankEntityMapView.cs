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

namespace Mappy
{
	public class BankEntityMapView : SupportMapFragment
	{
		private BankEntitiesService EntitiesService = new BankEntitiesService ();

		private TouchableWrapper WrapperView;
		private const float MaxSupportedZoomLevel = 3.5f;
		private List<EntityMarker> LocationsPlottedOnMap = new List<EntityMarker>();
		private float LastZoomLevel = 0;

		public static readonly float SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL = 10;
		public static readonly float MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL = 15;

		public static BankEntityMapView newInstance() {
			return new BankEntityMapView();
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
			var view = base.OnCreateView(inflater, container, savedInstanceState);

			WrapperView = new TouchableWrapper(this.Activity);
			WrapperView.AddView(view);

			return WrapperView;
		}

		public override void OnResume()
		{
			base.OnResume ();
			InitializeMap ();
		}

		void InitializeMap ()
		{
			if (this.Map != null) {
				ConfigureMapUiSettings ();
				UpdateMap ((this.Activity as BankEntityLocator).UserSelection);
				FlyDownToMyLocation ();
			}
		}

		private void FlyDownToMyLocation ()
		{
			if(this.Map.MyLocation != null)
			{
				LatLng myLocation = new LatLng (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude); 
				CameraPosition position = new CameraPosition.Builder ().Target (myLocation).Zoom (MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL).Build();
				CameraUpdate camUpdate = CameraUpdateFactory.NewCameraPosition(position);
				this.Map.AnimateCamera (camUpdate);
			}
		}

		public void UpdateMap (Options userSelection)
		{
			var zoomLevel = this.Map.CameraPosition.Zoom;

			if (ShouldIconChange ()) {
				UpdateMapBasedOnZoomThreshold ();
			} 
			if (zoomLevel > MaxSupportedZoomLevel) {
				LatLng coordinates = this.Map.CameraPosition.Target;
				ThreadPool.QueueUserWorkItem (o => ShowEntitiesOnMap (coordinates, userSelection));
			} else {
				Toast.MakeText(this.Activity, "Zoom in to view more locations", ToastLength.Short).Show();
			}

			LastZoomLevel = CurrentZoomLevel();
		}

		private void UpdateMapBasedOnZoomThreshold ()
		{
			this.Map.Clear ();
			EntityMarker.IconType icon = IconForCurrentZoomLevel ();
			if (icon != EntityMarker.IconType.None) {
				foreach (EntityMarker location in LocationsPlottedOnMap) {
					location.ChangeIcon (icon);
					location.AddMarkerTo (this.Map);
				}
			}
		}

		public void ResetMap()
		{
			this.Map.Clear ();
		}

		void ShowEntitiesOnMap (LatLng coordinates, Options userSelection)
		{
			List<BankEntity> bankEntities = EntitiesService.fetch (coordinates.Latitude, coordinates.Longitude, userSelection);

			var parentActivity = this.Activity as Activity;
			parentActivity.RunOnUiThread( () => {
				if(IconForCurrentZoomLevel() == EntityMarker.IconType.None) return;
				foreach (BankEntity aEntity in bankEntities) {
					var marker = new EntityMarker(aEntity, IconForCurrentZoomLevel(), new LatLng(aEntity.Latitude, aEntity.Longitude));
					marker.AddMarkerTo(this.Map);
					LocationsPlottedOnMap.Add(marker);
				}
			});
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

		float CurrentZoomLevel ()
		{
			return this.Map.CameraPosition.Zoom;
		}


		EntityMarker.IconType IconForCurrentZoomLevel ()
		{
			float currentZoomLevel = CurrentZoomLevel ();
			if (currentZoomLevel < MaxSupportedZoomLevel) return EntityMarker.IconType.None;
			if (currentZoomLevel > MaxSupportedZoomLevel && currentZoomLevel <= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return EntityMarker.IconType.Small;
			if (currentZoomLevel > SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return EntityMarker.IconType.Medium;
			if (currentZoomLevel > MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return EntityMarker.IconType.Large;
			return EntityMarker.IconType.Small;
		}

		bool ShouldIconChange () {
			var currentZoomLevel = CurrentZoomLevel ();
			if (LastZoomLevel < MaxSupportedZoomLevel && currentZoomLevel >= MaxSupportedZoomLevel) return true;
			if (LastZoomLevel < SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel >= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return true;
			if (LastZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL && currentZoomLevel >= MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return true;
			if (LastZoomLevel > MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL && currentZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return true;
			if (LastZoomLevel > SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel <= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return true;
			if (LastZoomLevel > MaxSupportedZoomLevel && currentZoomLevel < MaxSupportedZoomLevel) return true;
			return false;
		}
	}
}