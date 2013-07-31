using System;
using Google.Maps;
using System.Collections.Generic;
using Mappy.Common;
using System.Linq;

namespace Mappy.iOS
{
	public class iOSViewportFilter : IViewportFilter
	{
		private VisibleRegion ViewportBounds;

		public iOSViewportFilter (VisibleRegion viewportBounds)
		{
			ViewportBounds = viewportBounds;
		}

		public List<BankEntity> FilteredList (IEnumerable<BankEntity> unfilteredList)
		{
			return (from entity in unfilteredList where (entity.Latitude < ViewportBounds.FarLeft.Latitude && entity.Latitude > ViewportBounds.NearLeft.Latitude && entity.Longitude > ViewportBounds.FarLeft.Longitude && entity.Longitude < ViewportBounds.FarRight.Longitude) select entity).ToList();
		}
	}
}

