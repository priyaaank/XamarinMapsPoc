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
		private const float MaxSupportedZoomLevel = 5;

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
				UpdateMap ((this.Activity as BankEntityLocator).SelectedEntityTypes);
			}
		}

		public void UpdateMap (List<string> selectedEntityTypes)
		{
			var zoomLevel = this.Map.CameraPosition.Zoom;
			if(zoomLevel < MaxSupportedZoomLevel)
			{
				Toast.MakeText(this.Activity, "Zoom in to view more locations", ToastLength.Short).Show();
			}
			else
			{
				LatLng coordinates = this.Map.CameraPosition.Target;
				ThreadPool.QueueUserWorkItem (o => ShowEntitiesOnMap (coordinates, selectedEntityTypes));
			}
		}

		public void ResetMap()
		{
			this.Map.Clear ();
		}

		void ShowEntitiesOnMap (LatLng coordinates, List<string> selectedEntityTypes)
		{
			List<BankEntity> bankEntities = EntitiesService.fetch (coordinates.Latitude, coordinates.Longitude, selectedEntityTypes);

			var parentActivity = this.Activity as Activity;
			parentActivity.RunOnUiThread( () => {
				MarkerOptions mapMarker = null;
				foreach (BankEntity aEntity in bankEntities) {
					var image = aEntity.IsAtm() ?  Resource.Drawable.atm : Resource.Drawable.branch;
					mapMarker = new MarkerOptions().InvokeIcon(BitmapDescriptorFactory.FromResource (image));
					mapMarker.SetPosition (new LatLng(aEntity.Latitude, aEntity.Longitude));
					mapMarker.SetTitle (aEntity.Description());
					this.Map.AddMarker (mapMarker);
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
	}
}