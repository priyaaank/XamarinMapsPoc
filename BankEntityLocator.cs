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
	public class BankEntityLocator : FragmentActivity
	{
		private BankEntityMapView MapViewFragment;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MapLayout);

			MapViewFragment = new BankEntityMapView ();
			this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment).Commit ();
		}
	}
}

