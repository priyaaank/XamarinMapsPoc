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
using Android.Gms.Maps.Model;

namespace Mappy
{
	public class EntityAdapter: ArrayAdapter<BankEntity>
	{
		private int ResourceLayoutId;
		private bool IsRelativeToUserLocation;

		public EntityAdapter(Context context, int layoutId, List<BankEntity> entities): base (context,layoutId,entities)
		{
			this.ResourceLayoutId = layoutId;
			this.IsRelativeToUserLocation = true;
		}

		public void UpdateData (List<BankEntity> entities, bool userPresentInView)
		{
			this.Clear ();
			this.IsRelativeToUserLocation = userPresentInView;
			foreach (BankEntity entity in entities.OrderBy (e => e.Distance)) {
				this.Add (entity);
			}
			this.NotifyDataSetChanged ();
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View row = convertView;
			BankEntityHolder holder = null;
			BankEntity currentEntity;

			if (row == null) {
				LayoutInflater inflater = ((Activity)Context).LayoutInflater;
				row = inflater.Inflate (ResourceLayoutId, parent, false);
				holder = PopulateEntityHolder (row);
				row.Tag = holder;
			} else {
				holder = row.Tag as BankEntityHolder;
			}

			currentEntity = this.GetItem (position);
			holder.SetPropertyValues (currentEntity);

			ViewStates currentState = IsRelativeToUserLocation ? ViewStates.Visible : ViewStates.Invisible;
			holder.EntityNavigation.Visibility = currentState;
			holder.EntityDistance.Visibility = currentState;

			return row;
		}

		private BankEntityHolder PopulateEntityHolder (View row)
		{
			BankEntityHolder  holder = new BankEntityHolder ();
			holder.EntityDistance = (TextView)row.FindViewById (Resource.Id.distance);
			holder.EntityName = (TextView)row.FindViewById (Resource.Id.entity_name);
			holder.EntityType = (TextView)row.FindViewById (Resource.Id.entity_type);
			holder.EntityAddress = (TextView)row.FindViewById (Resource.Id.entity_address);
			holder.EntityNavigation = (ImageView)row.FindViewById (Resource.Id.navigation);
			return holder;
		}

		public class BankEntityHolder : Java.Lang.Object
		{
			public ImageView EntityNavigation { get; set;}
			public TextView EntityDistance { get; set;}
			public TextView EntityName { get; set;}
			public TextView EntityType { get; set;}
			public TextView EntityAddress { get; set;}

			public void SetPropertyValues(BankEntity currentEntity)
			{
				this.EntityName.Text = currentEntity.Name;
				this.EntityType.Text = currentEntity.Description ();
				this.EntityAddress.Text = currentEntity.Address;
				this.EntityDistance.Text = currentEntity.FormattedDistance ();
				this.EntityNavigation.Tag = new LatLng (currentEntity.Latitude, currentEntity.Longitude);
			}
		}
	}
}

