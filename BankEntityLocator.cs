using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Android.Locations;
using Android.Gms.Location;
using Android.Gms.Common;

namespace Mappy
{
	[Activity (Label = "BankEntityLocator", MainLauncher = true)]			
	public class BankEntityLocator : FragmentActivity, IMapActivity, MapUpdateListener, IGooglePlayServicesClientConnectionCallbacks, IGooglePlayServicesClientOnConnectionFailedListener, Android.Gms.Location.ILocationListener
	{
		private BankEntityMapView MapViewFragment;
		private GpsManager GpsManager;
		public LocationClient LocationClient {get; set;}
		public bool LocationClientConnected { get; set; }
	
		const string MapFragmentView        = "mapView";
		const bool   SelectAtms             = true;
		const bool   SelectBranches         = true;
		const bool   DontSelectPartnerAtms  = false;

		Options mapOptions;
		public Options MapOptions {
			get {
				return mapOptions;
			}
			set {
				mapOptions = value;
				UpdateMapView ();
			}
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MapLayout);

			GpsManager = new GpsManager (this);
			GpsManager.PrepareGPS ();

			LocationClient = new LocationClient (this, this, this);

			MapViewFragment = SupportFragmentManager.FindFragmentById(Resource.Id.map) as BankEntityMapView;
			if (MapViewFragment == null) {
				MapViewFragment = new BankEntityMapView ();
				this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment, MapFragmentView).Commit ();
			}
			MapOptions = new Options(SelectAtms, SelectBranches, DontSelectPartnerAtms);
		}

		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.map_menu, menu);
			return true;
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			if (item.ItemId == Resource.Id.MapOptions) {
				MapOptionsDialog.NewInstance ().Show (SupportFragmentManager, "dialog");
				return true;
			}
			return base.OnOptionsItemSelected (item);
		}

		protected override void OnStart ()
		{
			base.OnStart ();
			LocationClient.Connect ();
		}

		protected override void OnStop ()
		{
			base.OnStop ();
			LocationClient.Disconnect ();
		}

		protected override void OnResume ()
       	{
			base.OnResume ();
       	}
	    
		protected override void OnPause ()
		{
	       base.OnPause ();
		}

//		private void UpdateMapWithSelectedTypes () 
//		{
//			CheckBox atmCheckBox = FindViewById<CheckBox> (Resource.Id.SelectAtm);
//			CheckBox branchCheckBox = FindViewById<CheckBox> (Resource.Id.SelectBranch);
//			CheckBox partnerAtmCheckbox = FindViewById<CheckBox> (Resource.Id.SelectPartnerAtms);
//			UserSelection = new Options (atmCheckBox.Checked, branchCheckBox.Checked, partnerAtmCheckbox.Checked);
//			MapViewFragment.ResetMap ();
//			UpdateMapView ();
//		}

		public void UpdateMapView()
		{
			MapViewFragment.ResetMap ();
			MapViewFragment.FetchAndUpdate ();
		}

		#region ILocationListener implementation

		public void OnLocationChanged (Location location)
		{
			MapViewFragment.UserLocationUpdated ();
		}
		#endregion

		#region IGooglePlayServicesClientConnectionCallbacks implementation

		public void OnConnected (Bundle p0)
		{
			LocationClientConnected = true;
			var locationRequest = new LocationRequest ();
			locationRequest.SetInterval (5000);
			locationRequest.SetFastestInterval (1000);
			LocationClient.RequestLocationUpdates (locationRequest, this);
			if (MapViewFragment != null)
				MapViewFragment.FlyDownToMyLocation ();
		}

		public void OnDisconnected ()
		{
			LocationClientConnected = false;
		}

		#endregion

		#region IGooglePlayServicesClientOnConnectionFailedListener implementation

		public void OnConnectionFailed (ConnectionResult p0)
		{
			LocationClientConnected = false;
		}

		#endregion
	}

}

