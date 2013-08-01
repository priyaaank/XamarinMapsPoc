using System;
using Google.Maps;
using Mappy.Common;
using MonoTouch.CoreLocation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace Mappy.iOS
{
	public class EntityMarker
	{
		static readonly Dictionary<BankEntity.Type, Dictionary<IconType, UIImage>> Icons = new Dictionary<BankEntity.Type, Dictionary<IconType, UIImage>> {
			{BankEntity.Type.Atm,
				new Dictionary<IconType, UIImage> {
					{ IconType.None, new UIImage() },
					{ IconType.Micro, UIImage.FromBundle("atm_micro")},
					{ IconType.Small,  UIImage.FromBundle("atm_small")},
					{ IconType.Medium,  UIImage.FromBundle("atm_medium")}
				}
			}, {BankEntity.Type.Branch,
				new Dictionary<IconType, UIImage> {
					{ IconType.None, new UIImage() },
					{ IconType.Micro, UIImage.FromBundle("branch_micro")},
					{ IconType.Small, UIImage.FromBundle("branch_small")},
					{ IconType.Medium, UIImage.FromBundle("branch_medium")}
				}
			}
		};

		MarkerBundle MarkerBundle;
		Marker Marker;
		IconType iconType;

		public BankEntity Entity { get; set; }




		public EntityMarker (BankEntity entity, IconType iconType, MarkerBundle markerBundle)
		{
			Entity = entity;
			IconType = iconType;
			MarkerBundle = markerBundle;
		}

		public IconType IconType {
			get {
				return iconType;
			}
			set {
				iconType = value;
				if (Marker != null) {
					Marker.Icon = IconForCurrentIconType;
				}
			}
		}

		public void AddMarkerTo (MapView map)
		{
			Marker = new Marker () {
				Position = new CLLocationCoordinate2D(Entity.Latitude, Entity.Longitude),
				Title = Entity.Name,
				Snippet = Entity.EntityType.ToString (),
				Map = map,
				Icon = IconForCurrentIconType
			};
		}

		UIImage IconForCurrentIconType {
			get {
				return MarkerBundle.IconFor(Entity.EntityType, IconType);
				//return Icons [Entity.EntityType] [IconType];
			}
		}
	}
}

