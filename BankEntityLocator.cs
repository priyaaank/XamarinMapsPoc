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
using Android.Support.V4.View;
using Android.Gms.Maps.Model; 

namespace Mappy
{
	[Activity (Label = "BankEntityLocator", MainLauncher = true)]			
	public class BankEntityLocator : FragmentActivity, IMapActivity, MapUpdateListener, IGooglePlayServicesClientConnectionCallbacks, IGooglePlayServicesClientOnConnectionFailedListener, Android.Gms.Location.ILocationListener
	{
		public BankEntityMapView MapViewFragment;
		private MapEntityListView ListViewFragment;
		private Android.Support.V4.View.ViewPager EntityListSlider;
		private int EntityListSliderId = 66;
		private GpsManager GpsManager;
		public LocationClient LocationClient {get; set;}
		public bool LocationClientConnected { get; set; }

	
		private const string MapFragmentViewName        = "mapView";
		private const string ListFragmentViewName        = "listView";
		private const bool   SelectAtms             = true;
		private const bool   SelectBranches         = true;
		private const bool   DontSelectPartnerAtms  = false;

		public static int ClickNum = 0;

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

			FrameLayout parent = (FrameLayout)this.FindViewById (Resource.Id.entity_list_container);

			EntityListSlider = new ViewPager (this);
			EntityListSlider.LayoutParameters = new ViewGroup.LayoutParams (ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
			EntityListSlider.Id = EntityListSliderId;
			EntityListSlider.Adapter = new EntityViewPageAdapter (this.SupportFragmentManager);
			parent.AddView (EntityListSlider);

			((TextView)this.FindViewById (Resource.Id.state_button)).Click += delegate { ToggleState(); };

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
			if(EntityListSlider.Visibility == ViewStates.Visible) ((EntityViewPageAdapter)EntityListSlider.Adapter).UpdateList (entities, userIsInViewport);
			if(ListViewFragment.IsVisible()) ListViewFragment.UpdateList (entities, userIsInViewport);
		}

		[Export]
		public void Navigate(View v)
		{
			ListViewFragment.Navigate (v);
		}


		public void CenterMapOnSelectedEntity (View view)
		{
			var latlngForDestination = view.Tag as LatLng;
			MapViewFragment.BringLocationToCenter (latlngForDestination);
		}

		[Export]
		public void ToggleState()
		{
			var matchParent = LinearLayout.LayoutParams.MatchParent;
			ClickNum++;
			int mapViewWeight = 33;
			int listContainerViewWeight = 7;

			if (ClickNum == 1) {
				EntityListSlider.Visibility = ViewStates.Gone;
				ListViewFragment.ShowListView ();
				mapViewWeight = 10;
				listContainerViewWeight = 30;
			} else if (ClickNum == 2) {
				ListViewFragment.HideListView ();
				listContainerViewWeight = 0;
				mapViewWeight = 40;
			} else if (ClickNum == 3) {
				EntityListSlider.Visibility = ViewStates.Visible;
				listContainerViewWeight = 7;
				mapViewWeight = 33;
				ClickNum = 0;
			} 

			var listingContainer = (FrameLayout)this.FindViewById (Resource.Id.entity_list_container);
			var map = (FrameLayout)this.FindViewById (Resource.Id.map);
			map.LayoutParameters = new LinearLayout.LayoutParams (matchParent, 0, mapViewWeight);
			listingContainer.LayoutParameters = new LinearLayout.LayoutParams (matchParent, 0, listContainerViewWeight);
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

	}
}

