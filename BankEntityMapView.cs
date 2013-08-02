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
				UpdateClosestEntityMarker ();
			}
		}

		public void FlyDownToMyLocation ()
		{
			if ((this.Activity as IMapActivity).LocationClientConnected) {
				CameraUpdate camUpdate = CameraUpdateFactory.NewLatLngZoom (MyLocation, MapViewModel.DEFAULT_ZOOM_LEVEL);
				this.Map.MoveCamera (camUpdate);
			}
		}

		LatLng MyLocation {
			get {
				var location = (Activity as IMapActivity).LocationClient.LastLocation;
				return new LatLng (location.Latitude, location.Longitude);
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
			if (Activity != null) {
				Activity.RunOnUiThread (() => {
					LatLngBounds viewBounds = this.Map.Projection.VisibleRegion.LatLngBounds;
					List<BankEntity> entities = ViewModel.Fetch (new AndroidViewportFilter (viewBounds), (Activity as IMapActivity).MapOptions);

					UpdateViewWithEntities (entities);
				});
			}
		}

		void UpdateViewWithEntities (List<BankEntity> entities)
		{
		//	if(iconType == IconType.None) return;

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

		public void UserLocationUpdated ()
		{
			UpdateClosestEntityMarker ();
		}
	}
}