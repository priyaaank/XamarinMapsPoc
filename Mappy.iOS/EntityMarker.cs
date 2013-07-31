using System;
using Google.Maps;
using Mappy.Common;
using MonoTouch.CoreLocation;

namespace Mappy.iOS
{
	public class EntityMarker
	{
		Marker Marker;
		IconType IconType;
		public BankEntity Entity { get; set; }


		public EntityMarker (BankEntity entity, IconType iconType)
		{
			Entity = entity;
			iconType = iconType;
		}

		public void UpdateIcon (IconType icon)
		{
		}

		public void AddMarkerTo (MapView map)
		{
			Marker = new Marker () {
				Position = new CLLocationCoordinate2D(Entity.Latitude, Entity.Longitude),
				Title = Entity.Name,
				Snippet = Entity.EntityType.ToString (),
				Map = map
			};
		}
	}
}

