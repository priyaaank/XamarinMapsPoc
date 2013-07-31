using System;
using Google.Maps;
using System.Collections.Generic;

namespace Mappy.iOS
{
	public class iOSViewportFilter
	{
		private VisibleRegion viewportBounds;

		public iOSViewportFilter ()
		{
			this.viewportBounds = viewportBounds;
		}

		public List<BankEntity> FilteredList (IEnumerable<BankEntity> unfilteredList)
		{
			List<BankEntity> filteredList = new List<BankEntity>();
			foreach (BankEntity aEntity in unfilteredList) 
			{
				if (viewportBounds
				//if (viewportBounds.Contains (new LatLng (aEntity.Latitude, aEntity.Longitude))) filteredList.Add(aEntity); 
			}
			return filteredList;
		}
	}
}

