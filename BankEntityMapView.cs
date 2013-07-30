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

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
			InitializeMap ();
		}

		void InitializeMap ()
		{
			if (this.Map != null) {
				this.Map.CameraChange += (sender, e) => UpdateMap ((this.Activity as BankEntityLocator).UserSelection);
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
				CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (GetMyLocation (), SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL + 1);
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

		public void UpdateMap (Options userSelection)
		{
			var zoomLevel = CurrentZoomLevel;
			Activity.FindViewById<TextView> (Resource.Id.zoomLevel).Text = zoomLevel.ToString();

			if (ShouldIconChange ()) {
				UpdateMapBasedOnZoomThreshold ();
			} 
			if (zoomLevel > MaxSupportedZoomLevel) {
				LatLng coordinates = this.Map.CameraPosition.Target;
				ThreadPool.QueueUserWorkItem (o => ShowEntitiesOnMap (coordinates, 300));
				FetchAndUpdate ();
			} else {
				Toast.MakeText(this.Activity, "Zoom in to view more locations", ToastLength.Short).Show();
			}

			LastZoomLevel = CurrentZoomLevel;
		}

		//Currently behaves a lot better just by clearing hte app. Otherwise locations stack. Maybe better to reenable this when service is better.
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
			this.LocationsPlottedOnMap.Clear ();
		}

		void ShowEntitiesOnMap (LatLng coordinates, int noOfRecords)
		{
			ThreadPool.QueueUserWorkItem (o =>  ViewModel.FetchEntitiesAsync (coordinates.Latitude, coordinates.Longitude, noOfRecords));
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


		private EntityMarker.IconType IconForCurrentZoomLevel ()
		{
			foreach (var zoomPair in ZoomPairs) {
				if (CurrentZoomLevel >= zoomPair.ZoomLevel) {
					return zoomPair.Icon;
				}
			}

			return EntityMarker.IconType.None;
		}

		private bool ShouldIconChange () {
			foreach (var zoomPair in ZoomPairs) {
				if (LastZoomLevel < zoomPair.ZoomLevel && CurrentZoomLevel >= zoomPair.ZoomLevel
					|| LastZoomLevel > zoomPair.ZoomLevel && CurrentZoomLevel <= zoomPair.ZoomLevel)
					return true;
			}

			return false;
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
			BankEntityLocator parentActivity = this.Activity as BankEntityLocator;
			parentActivity.RunOnUiThread (() => {
				LatLngBounds viewBounds = this.Map.Projection.VisibleRegion.LatLngBounds;
				List<BankEntity> entities = ViewModel.Fetch (new AndroidViewportFilter (viewBounds), parentActivity.UserSelection);

				UpdateViewWithEntities (entities);
			});
		}

		void UpdateViewWithEntities (List<BankEntity> entities)
		{
			var iconType = IconForCurrentZoomLevel ();
			if(iconType == EntityMarker.IconType.None) return;

			List<BankEntity> plottedEntities = new List<BankEntity>();

			foreach (EntityMarker marker in LocationsPlottedOnMap) {
				plottedEntities.Add (marker.Entity);
			}

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