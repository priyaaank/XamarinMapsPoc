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
				UpdateClosestEntityMarker ();
				UpdateMap ((this.Activity as BankEntityLocator).UserSelection);
			}
		}

		private LatLng GetMyLocation ()
		{
			return new LatLng (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude);
		}

		private void FlyDownToMyLocation ()
		{
			if(this.Map.MyLocation != null)
			{
				CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (GetMyLocation (), MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL + 1);
				this.Map.AnimateCamera (camUpdate);
			}
		}

		public void UpdateMap (Options userSelection)
		{
			var zoomLevel = CurrentZoomLevel();

			if (ShouldIconChange ()) {
				UpdateMapBasedOnZoomThreshold ();
			} 
			if (zoomLevel > MaxSupportedZoomLevel) {
				LatLng coordinates = this.Map.CameraPosition.Target;
				ThreadPool.QueueUserWorkItem (o => ShowEntitiesOnMap (coordinates, userSelection, 20));
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
					location.UpdateIcon (icon);
					location.AddMarkerTo (this.Map);
				}
			}
		}

		public void ResetMap()
		{
			this.Map.Clear ();
		}

		private void ShowEntitiesOnMap (LatLng coordinates, Options userSelection, int noOfRecords)
		{
			List<BankEntity> bankEntities = EntitiesService.fetch (coordinates.Latitude, coordinates.Longitude, noOfRecords, userSelection);

			var parentActivity = this.Activity as Activity;
			parentActivity.RunOnUiThread( () => {
				var iconType = IconForCurrentZoomLevel ();
				if(iconType == EntityMarker.IconType.None) return;
				foreach (BankEntity aEntity in bankEntities) {
					var marker = new EntityMarker (aEntity, iconType);
					marker.AddMarkerTo(this.Map);
					LocationsPlottedOnMap.Add(marker);
				}
			});
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

		private float CurrentZoomLevel ()
		{
			return this.Map.CameraPosition.Zoom;
		}

		private EntityMarker.IconType IconForCurrentZoomLevel ()
		{
			float currentZoomLevel = CurrentZoomLevel ();
			if (currentZoomLevel < MaxSupportedZoomLevel) return EntityMarker.IconType.None;
			if (currentZoomLevel > MaxSupportedZoomLevel && currentZoomLevel <= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return EntityMarker.IconType.Small;
			if (currentZoomLevel > SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return EntityMarker.IconType.Medium;
			if (currentZoomLevel > MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return EntityMarker.IconType.Large;
			return EntityMarker.IconType.Small;
		}

		private bool ShouldIconChange () {
			var currentZoomLevel = CurrentZoomLevel ();
			if (LastZoomLevel < MaxSupportedZoomLevel && currentZoomLevel >= MaxSupportedZoomLevel) return true; // no icon to small
			if (LastZoomLevel < SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel >= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return true; //small to medium
			if (LastZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL && currentZoomLevel >= MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return true; //medium to large
			if (LastZoomLevel > MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL && currentZoomLevel < MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL) return true; // large to medium
			if (LastZoomLevel > SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL && currentZoomLevel <= SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL) return true; // medium to small
			if (LastZoomLevel > MaxSupportedZoomLevel && currentZoomLevel < MaxSupportedZoomLevel) return true; // small to no icon
			return false; // no change
		}

		private void UpdateClosestEntityMarker ()
		{
			if (this.Map.MyLocation != null) {
				var allEntities = EntitiesService.fetch (this.Map.MyLocation.Latitude, this.Map.MyLocation.Longitude, 1, (this.Activity as BankEntityLocator).UserSelection);
				if (allEntities != null && allEntities.Count > 0) {
					if(ClosestBankEntityMarker != null) ClosestBankEntityMarker.ResetIconFromClosest (IconForCurrentZoomLevel ());
					BankEntity closestBankEntity = allEntities.First ();
					ClosestBankEntityMarker = new EntityMarker (closestBankEntity, EntityMarker.IconType.Closest, EntityMarker.MarkerType.Nearest);
					ClosestBankEntityMarker.AddMarkerTo (this.Map);
				}
			}
		}

		public void UserLocationUpdated ()
		{
			UpdateClosestEntityMarker ();
		}
	}
}