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
using Android.Content.PM;
using Android.Locations;
using Android.Provider;

namespace Mappy
{
	class GpsManager
	{
		private Context ApplicationContext;

		public GpsManager(Context context)
		{
			ApplicationContext = context;
		}

		public void PrepareGPS()
		{
			if ( GPSPresent () && DontHave(GPSEnabled ()) ) 
			{
				AlertDialog.Builder dialog = new AlertDialog.Builder (ApplicationContext);
				dialog.SetTitle ("Location Manager");
				dialog.SetMessage ("Would you like to enable GPS?");
				dialog.SetPositiveButton ("Yes", delegate { ShowGPSSettings(); });
				dialog.SetNegativeButton ("No", delegate {  });
				dialog.Create ().Show ();
			}
		}

		private void ShowGPSSettings ()
		{
			Intent intent = new Intent(Settings.ActionLocationSourceSettings);
			ApplicationContext.StartActivity (intent);
		}

		private bool GPSEnabled()
		{
			LocationManager manager = (LocationManager) ApplicationContext.GetSystemService(Context.LocationService);
			return manager.IsProviderEnabled (LocationManager.GpsProvider);
		}

		private bool GPSPresent()
		{
			PackageManager packageManager = ApplicationContext.PackageManager;
			return packageManager.HasSystemFeature (PackageManager.FeatureLocationGps);
		}

		private bool DontHave (bool condition)
		{
			return !condition;
		}
	}
}

