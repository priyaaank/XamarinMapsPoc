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

namespace Mappy
{
	[Activity (Label = "BankEntityLocator", MainLauncher = true)]			
	public class BankEntityLocator : FragmentActivity, MapUpdateListener
	{
		private BankEntityMapView MapViewFragment;
		private GpsManager GpsManager;

		const string MAP_FRAGMENT_TAG = "mapView";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MapLayout);

			GpsManager = new GpsManager (this);
			GpsManager.PrepareGPS ();

			MapViewFragment = new BankEntityMapView ();

			BindBankEntityOptionsView ();
			this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment, MAP_FRAGMENT_TAG).Commit ();
		}

		void BindBankEntityOptionsView ()
		{
			LinearLayout bankEntityOptionsView = FindViewById<LinearLayout> (Resource.Id.BankEntityOptions);
			Button optionsButton = FindViewById<Button> (Resource.Id.OptionsButton);
			optionsButton.Click += (object sender, EventArgs e) => bankEntityOptionsView.Visibility = ViewStates.Visible;

			Button okButton = FindViewById<Button> (Resource.Id.OkButton);
			okButton.Click += (object sender, EventArgs e) => {
				bankEntityOptionsView.Visibility = ViewStates.Gone;
				UpdateBankEntityType ();
			};

			Button cancelButton = FindViewById<Button> (Resource.Id.CancelButton);
			cancelButton.Click += (object sender, EventArgs e) => bankEntityOptionsView.Visibility = ViewStates.Gone;


		}

		private BankEntityType GetBankEntityType (bool isAtmSelected, bool isBranchSelected)
		{
			if (isAtmSelected && isBranchSelected)
				return BankEntityType.AtmAndBranch;
			else if (isAtmSelected)
				return BankEntityType.ATM;
			else if (isBranchSelected)
				return BankEntityType.Branch;
			else
				return BankEntityType.ATM;
		}

		private void UpdateBankEntityType () 
		{
			CheckBox atmCheckBox = FindViewById<CheckBox> (Resource.Id.SelectAtm);
			CheckBox branchCheckBox = FindViewById<CheckBox> (Resource.Id.SelectBranch);
			BankEntityType type = GetBankEntityType (atmCheckBox.Checked, branchCheckBox.Checked);
			MapViewFragment.UpdateBankEntityType (type);
		}

		public void UpdateMapView()
		{
			BankEntityMapView mapViewFragment = (BankEntityMapView) this.SupportFragmentManager.FindFragmentByTag (MAP_FRAGMENT_TAG);
			mapViewFragment.UpdateMap ();
		}
	}

}

