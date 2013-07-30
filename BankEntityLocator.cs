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

namespace Mappy
{
	[Activity (Label = "BankEntityLocator", MainLauncher = true)]			
	public class BankEntityLocator : FragmentActivity, MapUpdateListener, ILocationListener
	{
		private BankEntityMapView MapViewFragment;
		private GpsManager GpsManager;
		private LocationManager LocManager;
	
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

			LocManager = GetSystemService (Context.LocationService) as LocationManager;

			BindBankEntityOptionsView ();

			MapViewFragment = SupportFragmentManager.FindFragmentById(Resource.Id.map) as BankEntityMapView;
			if (MapViewFragment == null) {
				MapViewFragment = new BankEntityMapView ();
				this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment, MapFragmentView).Commit ();
			}
		}

		protected override void OnResume ()
       	{
			base.OnResume ();
			LocManager.RequestLocationUpdates (LocationManager.GpsProvider, 2000, 1, this);
       	}
	    
		protected override void OnPause ()
		{
	       base.OnPause ();
	       LocManager.RemoveUpdates (this);
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
			MapViewFragment.UpdateMap (UserSelection);
		}

		#region ILocationListener implementation

		public void OnLocationChanged (Location location)
		{
			MapViewFragment.UserLocationUpdated ();
		}

		public void OnProviderDisabled (string provider)
		{
			//do nothing
		}

		public void OnProviderEnabled (string provider)
		{
			//do nothing
		}

		public void OnStatusChanged (string provider, Availability status, Bundle extras)
		{
			//do nothing
		}

		#endregion
	}

}

