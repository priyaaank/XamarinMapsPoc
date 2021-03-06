using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Mappy.Common;
using Android.Locations;
using Android.Gms.Maps.Model;

namespace Mappy
{
	public class MapEntityListView : Android.Support.V4.App.ListFragment
	{
		private List<BankEntity> BankEntities;

		public MapEntityListView()
		{
			BankEntities = new List<BankEntity> ();
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
		}

		public override void OnResume()
		{
			base.OnResume ();
			InitializeList ();
			HideListView ();
		}
	
		public override void OnListItemClick(ListView l, View v, int position, long id)
		{
			BankEntity bankEntitySelected = (this.ListAdapter as EntityAdapter).GetItem (position);
			(this.Activity as BankEntityLocator).MapViewFragment.BringLocationToCenter (new LatLng(bankEntitySelected.Latitude, bankEntitySelected.Longitude));
		}

		public void Navigate(View navigationView)
		{
			var latlngForDestination = navigationView.Tag as LatLng;
			Intent intent = new Intent(Android.Content.Intent.ActionView, Android.Net.Uri.Parse("google.navigation:q="+latlngForDestination.Latitude +","+latlngForDestination.Longitude+""));
			StartActivity (intent);
		}

		private void InitializeList ()
		{
			this.ListAdapter = new EntityAdapter (Activity,Resource.Layout.EntityListRow, BankEntities);
		}

		public void UpdateList (List<BankEntity> entities, bool userInViewport)
		{

			(this.ListAdapter as EntityAdapter).UpdateData(entities, userInViewport);
		}

		public void ShowListView ()
		{
			this.ListView.Visibility = ViewStates.Visible;
		}

		public void HideListView()
		{
			this.ListView.Visibility = ViewStates.Gone;
		}

		public bool IsVisible ()
		{
			return (this.ListView.Visibility == ViewStates.Visible);
		}
	}														
}

