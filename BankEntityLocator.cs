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
		public List<string> SelectedEntityTypes = new List<string>();
	
		const string MapFragmentView = "mapView";
		const bool   SelectAtms      = true;
		const bool   SelectBranches  = true;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MapLayout);

			UpdateSelectedEntityTypes (SelectAtms, SelectBranches);

			GpsManager = new GpsManager (this);
			GpsManager.PrepareGPS ();

			MapViewFragment = new BankEntityMapView ();

			BindBankEntityOptionsView ();
			this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment, MapFragmentView).Commit ();
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

		private void UpdateSelectedEntityTypes (bool isAtmSelected, bool isBranchSelected)
		{
			SelectedEntityTypes.Clear();
			if (isAtmSelected) SelectedEntityTypes.Add ("ATM");
			if (isBranchSelected) SelectedEntityTypes.Add ("Branch");
		}

		private void UpdateMapWithSelectedTypes () 
		{
			CheckBox atmCheckBox = FindViewById<CheckBox> (Resource.Id.SelectAtm);
			CheckBox branchCheckBox = FindViewById<CheckBox> (Resource.Id.SelectBranch);
			UpdateSelectedEntityTypes (atmCheckBox.Checked, branchCheckBox.Checked);
			MapViewFragment.ResetMap ();
			UpdateMapView ();
		}

		public void UpdateMapView()
		{
			MapViewFragment.UpdateMap (SelectedEntityTypes);
		}
	}

}

