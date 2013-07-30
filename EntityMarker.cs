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
using Mappy.Common;

namespace Mappy
{
	public class EntityMarker
	{
		private static readonly Dictionary<IconType, int> AtmIcons = new Dictionary<IconType, int>{
			{ IconType.Micro, Resource.Drawable.atm_micro },
			{ IconType.Small, Resource.Drawable.atm_small },
			{ IconType.Medium, Resource.Drawable.atm_medium }
		};

		private static readonly Dictionary<IconType, int> BranchIcons = new Dictionary<IconType, int>{
			{ IconType.Micro, Resource.Drawable.branch_micro },
			{ IconType.Small, Resource.Drawable.branch_small },
			{ IconType.Medium, Resource.Drawable.branch_medium }
		};

		private MarkerOptions MapMarker;
		private BankEntity Entity;

		public EntityMarker(BankEntity entity, IconType iconSize, LatLng position)
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

		public void ChangeIcon(IconType changeIconTo)
		{
			this.MapMarker.InvokeIcon (BitmapDescriptorFactory.FromResource(EntityIconForZoomLevel(changeIconTo)));
		}

		private int EntityIconForZoomLevel (IconType changeIconTo)
		{
			return Entity.IsAtm () ? AtmIcons[changeIconTo] : BranchIcons[changeIconTo];
		}
	}
}

