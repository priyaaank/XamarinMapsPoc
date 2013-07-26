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

namespace Mappy
{
	class AndroidViewportFilter<B> : ViewportFilter<B>
	{

		private LatLngBounds viewportBounds;

		public AndroidViewportFilter(B viewportBounds)
		{
			this.viewportBounds = viewportBounds as LatLngBounds;
		}

		public bool CoordinateEnclosed (BankEntity entity)
		{
			return viewportBounds.Contains (new LatLng(entity.Latitude, entity.Longitude));
		}
	}
}

