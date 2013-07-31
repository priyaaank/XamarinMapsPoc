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
		private static readonly Dictionary<IconType, int> AtmIcons = new Dictionary<IconType, int> {
			{ IconType.Micro, Resource.Drawable.atm_micro },
			{ IconType.Small, Resource.Drawable.atm_small },
			{ IconType.Medium, Resource.Drawable.atm_medium }
		};

		private static readonly Dictionary<IconType, int> BranchIcons = new Dictionary<IconType, int>{
			{ IconType.Micro, Resource.Drawable.branch_micro },
			{ IconType.Small, Resource.Drawable.branch_small },
			{ IconType.Medium, Resource.Drawable.branch_medium }
		};

		private MarkerOptions MarkerOptions;
		private Marker Marker;
		public BankEntity Entity {get; set;}
		private MarkerType Type;

		public EntityMarker(BankEntity entity, IconType iconType)
		{
			this.Entity = entity;
			this.MarkerOptions = new MarkerOptions ();
			this.MarkerOptions.SetTitle (entity.Description());
			this.MarkerOptions.SetPosition (new LatLng(entity.Latitude, entity.Longitude));
			this.UpdateIcon (iconType);
			this.Type = MarkerType.Regular;
		}

		public EntityMarker(BankEntity entity, IconType iconType, MarkerType markerType) : this(entity, iconType)
		{
			this.Type = markerType;
			this.UpdateIcon (IconType.Closest);
		}

		public void AddMarkerTo(GoogleMap map)
		{
			Marker = map.AddMarker (this.MarkerOptions);
		}

		public void UpdateIcon(IconType iconType)
		{
			if (iconType == IconType.None && Marker != null)
				Marker.Visible = false;
			else {
				var icon = (iconType == IconType.Closest) ? BitmapDescriptorFactory.DefaultMarker() : BitmapDescriptorFactory.FromResource(EntityIconForZoomLevel(iconType));
				MarkerOptions.InvokeIcon (icon);

				if (Marker != null) {
					Marker.Visible = true;
					Marker.SetIcon (icon);
				}
			}
		}

		public bool IsNearestToUser()
		{
			return this.Type == MarkerType.Nearest;
		}

		public void ResetIconFromClosest (IconType iconType)
		{
			UpdateIcon (iconType);
		}

		private int EntityIconForZoomLevel (IconType changeIconTo)
		{
			return Entity.IsAtm () ? AtmIcons[changeIconTo] : BranchIcons[changeIconTo];
		}
	}
}

