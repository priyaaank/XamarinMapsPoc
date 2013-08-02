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
	public class BankEntityLocator : FragmentActivity, MapUpdateListener, IGooglePlayServicesClientConnectionCallbacks, IGooglePlayServicesClientOnConnectionFailedListener, Android.Gms.Location.ILocationListener
	{
		private BankEntityMapView MapViewFragment;
		private GpsManager GpsManager;
		public LocationClient LocationClient {get; set;}
		public bool LocationClientConnected { get; set; }
	
		const string MapFragmentView        = "mapView";
		const bool   SelectAtms             = true;
		const bool   SelectBranches         = true;
		const bool   DontSelectPartnerAtms  = false;

		public Options UserSelection = new Options(SelectAtms, SelectBranches, DontSelectPartnerAtms);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MapLayout);

			GpsManager = new GpsManager (this);
			GpsManager.PrepareGPS ();

			//LocManager = GetSystemService (Context.LocationService) as LocationManager;
			LocationClient = new LocationClient (this, this, this);

			BindBankEntityOptionsView ();

			MapViewFragment = SupportFragmentManager.FindFragmentById(Resource.Id.map) as BankEntityMapView;
			if (MapViewFragment == null) {
				MapViewFragment = new BankEntityMapView ();
				this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment, MapFragmentView).Commit ();
			}
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

		void BindBankEntityOptionsView ()
		{
			LinearLayout bankEntityOptionsView = FindViewById<LinearLayout> (Resource.Id.BankEntityOptions);
			Button optionsButton = FindViewById<Button> (Resource.Id.OptionsButton);
			optionsButton.Click += (object sender, EventArgs e) => bankEntityOptionsView.Visibility = ViewStates.Visible;

			Button okButton = FindViewById<Button> (Resource.Id.OkButton);
			okButton.Click += (object sender, EventArgs e) => {
				bankEntityOptionsView.Visibility = ViewStates.Gone;
				UpdateMapWithSelectedTypes ();
			};

			Button cancelButton = FindViewById<Button> (Resource.Id.CancelButton);
			cancelButton.Click += (object sender, EventArgs e) => bankEntityOptionsView.Visibility = ViewStates.Gone;
		}

		private void UpdateMapWithSelectedTypes () 
		{
			CheckBox atmCheckBox = FindViewById<CheckBox> (Resource.Id.SelectAtm);
			CheckBox branchCheckBox = FindViewById<CheckBox> (Resource.Id.SelectBranch);
			CheckBox partnerAtmCheckbox = FindViewById<CheckBox> (Resource.Id.SelectPartnerAtms);
			UserSelection = new Options (atmCheckBox.Checked, branchCheckBox.Checked, partnerAtmCheckbox.Checked);
			MapViewFragment.ResetMap ();
			UpdateMapView ();
		}

		public void UpdateMapView()
		{
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

