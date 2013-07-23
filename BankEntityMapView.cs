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
		private EntityMarker ClosestBankEntityMarker;

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
				FlyDownToMyLocation ();
				SetClosestBankEntityMarker ();
				UpdateMap ((this.Activity as BankEntityLocator).UserSelection);
			}
		}

		private void FlyDownToMyLocation ()
		{
			if(this.Map.MyLocation != null)
			{
				LatLng myLocation = new LatLng (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude); 
				CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (myLocation, MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL + 1);
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
					location.SetIcon (icon);
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
			List<BankEntity> bankEntities = EntitiesService.fetch (coordinates.Latitude, coordinates.Longitude, 20, userSelection);

			var parentActivity = this.Activity as Activity;
			parentActivity.RunOnUiThread( () => {
				if(IconForCurrentZoomLevel() == EntityMarker.IconType.None) return;
				foreach (BankEntity aEntity in bankEntities) {
					var marker = (ClosestBankEntityMarker != null && aEntity.Name == ClosestBankEntityMarker.Entity.Name) ? ClosestBankEntityMarker :new EntityMarker(aEntity, IconForCurrentZoomLevel());
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
			if (LastZoomLevel < MaxSupportedZoomLevel && currentZoomLevel >= MaxSupportedZoomLevel) return true; // no icon to small
			if (LastZoomLevel < SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel >= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return true; //small to medium
			if (LastZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL && currentZoomLevel >= MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return true; //medium to large
			if (LastZoomLevel > MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL && currentZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return true; // large to medium
			if (LastZoomLevel > SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel <= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return true; // medium to small
			if (LastZoomLevel > MaxSupportedZoomLevel && currentZoomLevel < MaxSupportedZoomLevel) return true; // small to no icon
			return false; // no change
		}

		void SetClosestBankEntityMarker ()
		{
			if (this.Map.MyLocation != null) {
				BankEntity closestBankEntity = (EntitiesService.fetch (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude, 1, (this.Activity as BankEntityLocator).UserSelection)).First ();
				ClosestBankEntityMarker = new EntityMarker (closestBankEntity, EntityMarker.IconType.Closest);
			}
		}
	}
}