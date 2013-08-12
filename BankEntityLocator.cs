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
using Java.Interop;
using Android.Views.Animations;

namespace Mappy
{
	[Activity (Label = "BankEntityLocator", MainLauncher = true)]			
	public class BankEntityLocator : FragmentActivity, IMapActivity, MapUpdateListener, IGooglePlayServicesClientConnectionCallbacks, IGooglePlayServicesClientOnConnectionFailedListener, Android.Gms.Location.ILocationListener
	{
		public BankEntityMapView MapViewFragment;
		private MapEntityListView ListViewFragment;
		private GpsManager GpsManager;
		public LocationClient LocationClient {get; set;}
		public bool LocationClientConnected { get; set; }
	
		const string MapFragmentViewName        = "mapView";
		const string ListFragmentViewName        = "listView";
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
				this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.map, MapViewFragment, MapFragmentViewName).Commit ();
			}

			ListViewFragment = SupportFragmentManager.FindFragmentByTag(ListFragmentViewName) as MapEntityListView;
			if (ListViewFragment == null) {
				ListViewFragment = new MapEntityListView ();
				this.SupportFragmentManager.BeginTransaction ().Add (Resource.Id.entity_list_container, ListViewFragment, ListFragmentViewName).Commit();
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

		public void UpdateMapView()
		{
			MapViewFragment.ResetMap ();
			MapViewFragment.FetchAndUpdate ();
		}

		public void UpdateListView (List<BankEntity> entities, bool userIsInViewport)
		{
			ListViewFragment.UpdateList (entities, userIsInViewport);
		}

		[Export]
		public void Navigate(View v)
		{
			ListViewFragment.Navigate (v);
		}

		[Export]
		public void ToggleState(View v)
		{
		
		}

		#region ILocationListener implementation

		public void OnLocationChanged (Location location)
		{
			MapViewFragment.UserLocationUpdated (location);
		}
		#endregion

		#region IGooglePlayServicesClientConnectionCallbacks implementation

		public void OnConnected (Bundle bundle)
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

		public void CustomAnimate()
		{
			View entityListView = this.FindViewById (Resource.Id.entity_list_container);
			Animation a = new CustomAnimation (entityListView, 300);
//			a.Duration = (int) (300 / mapView.Context.Resources.DisplayMetrics.Density);
			a.Duration = 1000;
			entityListView.StartAnimation (a);
		}

		class CustomAnimation : Animation
		{

			View ViewObject;
			int TargetHeight;

			public CustomAnimation(View v, int targetHeight)
			{
				this.ViewObject = v;
				this.TargetHeight = targetHeight;
			}

			protected override void ApplyTransformation (float interpolatedTime, Transformation t)
			{
				this.ViewObject.LayoutParameters.Height = (int)(interpolatedTime * this.TargetHeight);
				this.ViewObject.RequestLayout ();
			}

			public override bool WillChangeBounds ()
			{
				return true;
			}
		}
	}

	class ToggleStates()
	{

	}
}

