using System;

namespace Mappy
{
	public class ZoomPair
	{
		public float ZoomLevel {get; set;}
		public EntityMarker.IconType Icon {get; set;}

		public ZoomPair(float zoomLevel, EntityMarker.IconType icon)
		{
			ZoomLevel = zoomLevel;
			Icon = icon;
		}
	}
}

