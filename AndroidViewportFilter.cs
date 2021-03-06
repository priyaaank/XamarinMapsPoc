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
using System.Collections;

namespace Mappy
{
	class AndroidViewportFilter : IViewportFilter
	{
		private LatLngBounds ViewportBounds;

		public AndroidViewportFilter(LatLngBounds viewportBounds)
		{
			this.ViewportBounds = viewportBounds;
		}
	
		public List<BankEntity> FilteredList (IEnumerable<BankEntity> unfilteredList)
		{
			List<BankEntity> filteredList = new List<BankEntity>();
			foreach (BankEntity aEntity in unfilteredList) 
			{
				if (ViewportBounds.Contains (new LatLng (aEntity.Latitude, aEntity.Longitude))) filteredList.Add(aEntity); 
			}
			return filteredList;
		}
	}
}