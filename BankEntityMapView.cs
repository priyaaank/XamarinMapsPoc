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

namespace Mappy
{
	public class BankEntityMapView : SupportMapFragment
	{
		MapViewModel ViewModel;
		//private BankEntitiesService EntitiesService = new BankEntitiesService ();

		private TouchableWrapper WrapperView;
		private const float MaxSupportedZoomLevel = 3.5f;
		private List<EntityMarker> LocationsPlottedOnMap = new List<EntityMarker>();
		private float LastZoomLevel = 0;

		public static readonly float MICRO_TO_SMALL_THRESHOLD_ZOOM_LEVEL = 14.0f;
		public static readonly float SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL = 17.0f;

		static List<ZoomPair> ZoomPairs = new List<ZoomPair> () {
			new ZoomPair(SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL, EntityMarker.IconType.Medium),
			new ZoomPair(MICRO_TO_SMALL_THRESHOLD_ZOOM_LEVEL, EntityMarker.IconType.Small),
			new ZoomPair(MaxSupportedZoomLevel, EntityMarker.IconType.Micro)

		};

		public static BankEntityMapView newInstance() {
			return new BankEntityMapView();
		}

		public BankEntityMapView()
		{
			ViewModel = new MapViewModel ();
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
				this.Map.MyLocationChange += FlyDownInitially;
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
				CameraPosition position = new CameraPosition.Builder ().Target (myLocation).Zoom (SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL).Build();
				CameraUpdate camUpdate = CameraUpdateFactory.NewCameraPosition(position);
				this.Map.AnimateCamera (camUpdate);
			}
		}

		public void UpdateMap (Options userSelection)
		{
			var zoomLevel = this.Map.CameraPosition.Zoom;
			Activity.FindViewById<TextView> (Resource.Id.zoomLevel).Text = zoomLevel.ToString();

			if (ShouldIconChange ()) {
				UpdateMapBasedOnZoomThreshold ();
			} 
			if (zoomLevel > MaxSupportedZoomLevel) {
				LatLng coordinates = this.Map.CameraPosition.Target;
				ShowEntitiesOnMap (coordinates, userSelection);
			} else {
				Toast.MakeText(this.Activity, "Zoom in to view more locations", ToastLength.Short).Show();
			}

			LastZoomLevel = CurrentZoomLevel;
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

			if(IconForCurrentZoomLevel() == EntityMarker.IconType.None) return;
			foreach (BankEntity aEntity in bankEntities) {
				var marker = new EntityMarker(aEntity, IconForCurrentZoomLevel(), new LatLng(aEntity.Latitude, aEntity.Longitude));
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


		EntityMarker.IconType IconForCurrentZoomLevel ()
		{
			foreach (var zoomPair in ZoomPairs) {
				if (CurrentZoomLevel >= zoomPair.ZoomLevel) {
					return zoomPair.Icon;
				}
			}

			return EntityMarker.IconType.None;
		}

		bool ShouldIconChange () {
			foreach (var zoomPair in ZoomPairs) {
				if (LastZoomLevel < zoomPair.ZoomLevel && CurrentZoomLevel >= zoomPair.ZoomLevel
					|| LastZoomLevel > zoomPair.ZoomLevel && CurrentZoomLevel <= zoomPair.ZoomLevel)
					return true;
			}

			return false;
		}
	}
}