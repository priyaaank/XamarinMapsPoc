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

		const string MAP_FRAGMENT_TAG = "mapView";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MapLayout);

			MapViewFragment = new BankEntityMapView ();
			this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment, MAP_FRAGMENT_TAG).Commit ();
		}

		public void UpdateMapView()
		{
			BankEntityMapView mapViewFragment = (BankEntityMapView) this.SupportFragmentManager.FindFragmentByTag (MAP_FRAGMENT_TAG);
			mapViewFragment.UpdateMap ();
		}
	}

}

