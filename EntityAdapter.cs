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

namespace Mappy
{
	public class EntityAdapter: ArrayAdapter<BankEntity>
	{
		private int ResourceLayoutId;

		public EntityAdapter(Context context, int layoutId, List<BankEntity> entities): base (context,layoutId,entities)
		{
			this.ResourceLayoutId = layoutId;
		}

		public void UpdateData (List<BankEntity> entities)
		{
			this.Clear ();
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

				holder = new BankEntityHolder ();
				holder.EntityDistance = (TextView)row.FindViewById (Resource.Id.distance);
				holder.EntityName = (TextView)row.FindViewById (Resource.Id.entity_name);
				holder.EntityType = (TextView)row.FindViewById (Resource.Id.entity_type);
				holder.EntityAddress = (TextView)row.FindViewById (Resource.Id.entity_address);
				holder.EntityNotes = (TextView)row.FindViewById (Resource.Id.entity_notes);
				holder.EntityNavigation = (ImageView)row.FindViewById (Resource.Id.navigation);

				row.Tag = holder;
			} else {
				holder = row.Tag as BankEntityHolder;
			}

			currentEntity = this.GetItem (position);
			holder.EntityName.Text = currentEntity.Name;
			holder.EntityType.Text = currentEntity.EntityType.ToString();
			holder.EntityAddress.Text = currentEntity.Description();
			holder.EntityDistance.Text = currentEntity.Distance.ToString();

			return row;
		}

		public class BankEntityHolder : Java.Lang.Object
		{
			public ImageView EntityNavigation { get; set;}
			public TextView EntityDistance { get; set;}
			public TextView EntityName { get; set;}
			public TextView EntityType { get; set;}
			public TextView EntityAddress { get; set;}
			public TextView EntityNotes { get; set;}
		}
	}
}

