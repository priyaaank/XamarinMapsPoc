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
		private BankEntityType bankEntityType = BankEntityType.ATM;

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
				UpdateMap ();
			}
		}

		public void UpdateMap ()
		{
			LatLng coordinates = this.Map.CameraPosition.Target;
			ThreadPool.QueueUserWorkItem (o => ShowEntitiesOnMap (coordinates));
		}

		BankEntityType GetRandomBankEntityType ()
		{
			Array values = System.Enum.GetValues (typeof(BankEntityType));
			System.Random random = new System.Random ();
			return (BankEntityType)values.GetValue (random.Next (values.Length));
		}

		public void ToggleBankEntityType () {
			bankEntityType = GetRandomBankEntityType ();
			this.Map.Clear ();
			Toast.MakeText(this.Activity, "Is an atm: "+ bankEntityType, ToastLength.Short).Show ();
			UpdateMap ();
		}

		void ShowEntitiesOnMap (LatLng coordinates)
		{
			List<BankEntity> bankEntities = EntitiesService.fetch (coordinates.Latitude, coordinates.Longitude, bankEntityType);

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

