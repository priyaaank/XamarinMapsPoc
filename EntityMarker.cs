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
		public enum IconType {Small, Medium, Large, None};

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

		public static readonly float SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL = 10;
//		public static readonly float MEDIUM_TO_LARGE_THRESHOLD_ZOOM_LEVEL = 12;

		private MarkerOptions MapMarker;
		private BankEntity Entity;

		public EntityMarker(BankEntity entity, EntityMarker.IconType iconSize, LatLng position)
		{
			this.Entity = entity;
			this.MapMarker = new MarkerOptions ();
			this.MapMarker.SetTitle (entity.Description());
			this.MapMarker.SetPosition (position);
			this.ChangeIcon (iconSize);
		}

		public void AddMarkerTo(GoogleMap map)
		{
			map.AddMarker (this.MapMarker);
		}

		public void ChangeIcon(EntityMarker.IconType changeIconTo)
		{
			this.MapMarker.InvokeIcon (BitmapDescriptorFactory.FromResource(EntityIconForZoomLevel(changeIconTo)));
		}

		private int EntityIconForZoomLevel (EntityMarker.IconType changeIconTo)
		{
			return Entity.IsAtm () ? AtmIcons[changeIconTo] : BranchIcons[changeIconTo];
		}
	}
}

