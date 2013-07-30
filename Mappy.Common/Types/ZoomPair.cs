using System;

namespace Mappy.Common
{
	public class ZoomPair
	{
		public float ZoomLevel {get; set;}
		public IconType Icon {get; set;}

		public ZoomPair(float zoomLevel, IconType icon)
		{
			ZoomLevel = zoomLevel;
			Icon = icon;
		}
	}
}

