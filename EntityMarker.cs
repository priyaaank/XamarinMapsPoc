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
using Android.Gms.Maps;
using System.Collections;

namespace Mappy
{
	class EntityMarker
	{
		public enum IconType {Small, Medium, Large, None, Closest};

		private static readonly Dictionary<EntityMarker.IconType, int> AtmIcons = new Dictionary<EntityMarker.IconType, int>{
			{ EntityMarker.IconType.Small, Resource.Drawable.atm_small },
			{ EntityMarker.IconType.Medium, Resource.Drawable.atm_medium },
			{ EntityMarker.IconType.Large, Resource.Drawable.atm }
		};

		private static readonly Dictionary<EntityMarker.IconType, int> BranchIcons = new Dictionary<EntityMarker.IconType, int>{
			{ EntityMarker.IconType.Small, Resource.Drawable.branch_small },
			{ EntityMarker.IconType.Medium, Resource.Drawable.branch_medium },
			{ EntityMarker.IconType.Large, Resource.Drawable.branch }
		};

		private MarkerOptions MapMarker;
		public BankEntity Entity;
		private IconType CurrentIconType;

		public EntityMarker(BankEntity entity, EntityMarker.IconType iconType)
		{
			this.Entity = entity;
			this.MapMarker = new MarkerOptions ();
			this.MapMarker.SetTitle (entity.Description());
			this.MapMarker.SetPosition (new LatLng(entity.Latitude, entity.Longitude));
			this.CurrentIconType = iconType;
			this.SetIcon ( this.CurrentIconType);
		}

		public void AddMarkerTo(GoogleMap map)
		{
			map.AddMarker (this.MapMarker);
		}

		public void SetIcon(IconType iconType)
		{
			var icon = (this.CurrentIconType == IconType.Closest) ? BitmapDescriptorFactory.DefaultMarker() : BitmapDescriptorFactory.FromResource(EntityIconForZoomLevel(iconType));
			this.MapMarker.InvokeIcon (icon);
		}

		public void SetDefaultIcon()
		{
			this.MapMarker.InvokeIcon (BitmapDescriptorFactory.DefaultMarker());
		}

		private int EntityIconForZoomLevel (EntityMarker.IconType changeIconTo)
		{
			return Entity.IsAtm () ? AtmIcons[changeIconTo] : BranchIcons[changeIconTo];
		}
	}
}

