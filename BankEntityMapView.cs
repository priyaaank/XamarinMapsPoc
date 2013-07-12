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

namespace Mappy
{
	public class BankEntityMapView : SupportMapFragment
	{
		private BankEntitiesService EntitiesService = new BankEntitiesService ();;

		public static BankEntityMapView newInstance() {
			return new BankEntityMapView();

		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
			View view = base.OnCreateView(inflater, container, savedInstanceState);
			return view;
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
				ThreadPool.QueueUserWorkItem (o => ShowEntitiesOnMap ());
			}
		}

		void ShowEntitiesOnMap ()
		{
			List<BankEntity> bankEntities = EntitiesService.fetch ();

			var parentActivity = this.Activity as Activity;
			parentActivity.RunOnUiThread( () => {
				MarkerOptions mapMarker = null;
				foreach (BankEntity aEntity in bankEntities) {
					mapMarker = new MarkerOptions ();
					mapMarker.SetPosition (aEntity.Location);
					mapMarker.SetTitle (aEntity.Name);
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

