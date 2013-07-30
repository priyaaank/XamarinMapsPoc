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
	public class EntityMarker
	{
		public enum MarkerType { Regular, Nearest };
		public enum IconType { Micro, Small, Medium, None, Closest};

		private static readonly Dictionary<EntityMarker.IconType, int> AtmIcons = new Dictionary<EntityMarker.IconType, int>{
			{ EntityMarker.IconType.Micro, Resource.Drawable.atm_micro },
			{ EntityMarker.IconType.Small, Resource.Drawable.atm_small },
			{ EntityMarker.IconType.Medium, Resource.Drawable.atm_medium }
		};

		private static readonly Dictionary<EntityMarker.IconType, int> BranchIcons = new Dictionary<EntityMarker.IconType, int>{
			{ EntityMarker.IconType.Micro, Resource.Drawable.branch_micro },
			{ EntityMarker.IconType.Small, Resource.Drawable.branch_small },
			{ EntityMarker.IconType.Medium, Resource.Drawable.branch_medium }
		};

		private MarkerOptions MapMarker;
		private BankEntity Entity;
		private MarkerType Type;

		public EntityMarker(BankEntity entity, EntityMarker.IconType iconType)
		{
			this.Entity = entity;
			this.MapMarker = new MarkerOptions ();
			this.MapMarker.SetTitle (entity.Description());
			this.MapMarker.SetPosition (new LatLng(entity.Latitude, entity.Longitude));
			this.UpdateIcon (iconType);
			this.Type = MarkerType.Regular;
		}

		public EntityMarker(BankEntity entity, EntityMarker.IconType iconType, MarkerType markerType) : this(entity, iconType)
		{
			this.Type = markerType;
			this.UpdateIcon (IconType.Closest);
		}

		public void AddMarkerTo(GoogleMap map)
		{
			map.AddMarker (this.MapMarker);
		}

		public void UpdateIcon(IconType iconType)
		{
			var icon = (iconType == IconType.Closest) ? BitmapDescriptorFactory.DefaultMarker() : BitmapDescriptorFactory.FromResource(EntityIconForZoomLevel(iconType));
			this.MapMarker.InvokeIcon (icon);
		}

		public bool IsNearestToUser()
		{
			return this.Type == MarkerType.Nearest;
		}

		public void ResetIconFromClosest (IconType iconType)
		{
			UpdateIcon (iconType);
		}

		private int EntityIconForZoomLevel (EntityMarker.IconType changeIconTo)
		{
			return Entity.IsAtm () ? AtmIcons[changeIconTo] : BranchIcons[changeIconTo];
		}
	}
}

