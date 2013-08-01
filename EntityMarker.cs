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
		static readonly Dictionary<BankEntity.Type, Dictionary<IconType, int>> Icons = new Dictionary<BankEntity.Type, Dictionary<IconType, int>> {
			{BankEntity.Type.Atm,
				new Dictionary<IconType, int> {
					{ IconType.Micro, Resource.Drawable.atm_micro},
					{ IconType.Small,  Resource.Drawable.atm_small},
					{ IconType.Medium,  Resource.Drawable.atm_medium}
				}
			}, {BankEntity.Type.Branch,
				new Dictionary<IconType, int> {
					{ IconType.Micro, Resource.Drawable.branch_micro},
					{ IconType.Small, Resource.Drawable.branch_small},
					{ IconType.Medium, Resource.Drawable.branch_medium}
				}
			}
		};

		private MarkerOptions MarkerOptions;
		private Marker Marker;
		public BankEntity Entity {get; set;}
		private MarkerType Type;
		private IconType iconType;

		public EntityMarker(BankEntity entity, IconType iconType)
		{
			this.Entity = entity;
			this.MarkerOptions = new MarkerOptions ();
			this.MarkerOptions.SetTitle (entity.Description());
			this.MarkerOptions.SetPosition (new LatLng(entity.Latitude, entity.Longitude));
			this.Type = MarkerType.Regular;
			IconType = iconType;
		}

		public EntityMarker(BankEntity entity, IconType iconType, MarkerType markerType) : this(entity, iconType)
		{
			this.Type = markerType;
			IconType = IconType.Closest;
		}

		public void AddMarkerTo(GoogleMap map)
		{
			Marker = map.AddMarker (this.MarkerOptions);
		}

		public IconType IconType {
			get {
				return iconType;
			}
			set {
				iconType = value;
				UpdateIconFromType();
			}
		}

		void UpdateIconFromType ()
		{
			if (iconType == IconType.None) {
				MarkerOptions.Visible (false);
				if (Marker != null)
					Marker.Visible = false;
			} else {
				var icon = EntityIconForIconType;
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

		BitmapDescriptor EntityIconForIconType
		{
			get {
				if (IconType == IconType.Closest)
					return BitmapDescriptorFactory.DefaultMarker ();
				else
					return BitmapDescriptorFactory.FromResource(Icons [Entity.EntityType] [IconType]);
			}
		}
	}
}

