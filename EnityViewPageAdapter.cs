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
using Android.Gms.Maps.Model;

namespace Mappy
{
	public class EntityViewPageAdapter: FragmentStatePagerAdapter
	{
		private List<BankEntity> BankEntities;
		bool IsRelativeToUserLocation;

		public EntityViewPageAdapter(Android.Support.V4.App.FragmentManager fragmentManager): base(fragmentManager)
		{
			this.BankEntities = new List<BankEntity> ();
		}

		public override int Count 
		{
			get 
			{
				return this.BankEntities.Count;
			}
		}

		public void UpdateList (List<BankEntity> entities, bool userIsInViewport)
		{
			this.BankEntities.Clear ();
			this.IsRelativeToUserLocation = userIsInViewport;
			foreach (BankEntity entity in entities.OrderBy (e => e.Distance)) {
				this.BankEntities.Add (entity);
			}

			this.NotifyDataSetChanged ();
		}

		public override Android.Support.V4.App.Fragment GetItem (int position)
		{
			return EntityViewFragment.NewInstance(BankEntities[position], IsRelativeToUserLocation);
		}

		public override int GetItemPosition (Java.Lang.Object @object)
		{
			return FragmentPagerAdapter.PositionNone;
		}

	}

	 class EntityViewFragment: Android.Support.V4.App.Fragment
	 {

		private BankEntity BankEntity;
		private bool IsRelativeToUserLocation;

		public static EntityViewFragment NewInstance(BankEntity bankEntity, bool IsRelativeToUserLocation)
		{
			EntityViewFragment entityViewFragment = new EntityViewFragment ();
			Bundle args = new Bundle();
			args.PutDouble ("Distance", bankEntity.Distance);
			args.PutString ("Name", bankEntity.Name);
			args.PutDouble ("Latitude", bankEntity.Latitude);
			args.PutDouble ("Longitude", bankEntity.Longitude);
			args.PutString ("LocationType", bankEntity.LocationType);
			args.PutLong ("LocationId", bankEntity.LocationId);
			args.PutLong ("Id", bankEntity.Id);
			args.PutString ("Brand", bankEntity.BrandName ());
			args.PutBoolean ("IsRelativeToUserLocation", IsRelativeToUserLocation);

			entityViewFragment.Arguments =  args;
			return entityViewFragment;
		}

	
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			if (Arguments != null) 
			{
				long id = Arguments.GetLong("Id");
				string name = Arguments.GetString("Name");
				long locationId = Arguments.GetLong ("LocationId");
				double latitude = Arguments.GetDouble("Latitude");
				double longitude = Arguments.GetDouble ("Longitude");
				double distance = Arguments.GetDouble("Distance");
				string locationType = Arguments.GetString("LocationType");
				string brand = Arguments.GetString ("Brand");
				IsRelativeToUserLocation = Arguments.GetBoolean ("IsRelativeToUserLocation");


				BankEntity = locationType == "ATM" ? 
					new Atm (id, brand, name, locationId, latitude, longitude, distance, locationType) as BankEntity : 
					new Branch (id, name, locationId, latitude, longitude, distance, locationType) as BankEntity;
			}
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view;
			view = inflater.Inflate (Resource.Layout.EntityListRow, container, false);
			((TextView)view.FindViewById (Resource.Id.distance)).Text = BankEntity.FormattedDistance();
			((TextView)view.FindViewById (Resource.Id.entity_name)).Text = BankEntity.Name;
			((TextView)view.FindViewById (Resource.Id.entity_type)).Text = BankEntity.EntityType.ToString ();
			((TextView)view.FindViewById (Resource.Id.entity_address)).Text = BankEntity.Description();
			((ImageView)view.FindViewById (Resource.Id.navigation)).Tag = new LatLng (BankEntity.Latitude, BankEntity.Longitude);

			ViewStates currentState = IsRelativeToUserLocation ? ViewStates.Visible : ViewStates.Invisible;
			view.FindViewById(Resource.Id.navigation).Visibility = currentState;
			view.FindViewById(Resource.Id.distance).Visibility = currentState;

			return view;
		}

	}
}

