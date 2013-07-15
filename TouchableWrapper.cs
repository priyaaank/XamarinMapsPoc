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

namespace Mappy
{
	class TouchableWrapper : FrameLayout
	{
		private long LastTouched = 0;
		//Keeping Scroll time very low to account for Double Taps. So this time is 
		//pointless right now.
		private static readonly long SCROLL_TIME = 30L;
		private MapUpdateListener MapUpdateListener;

		public TouchableWrapper(Context context) : base(context)
		{
			MapUpdateListener = (MapUpdateListener) context;
		}

		public override bool DispatchTouchEvent(MotionEvent ev) {
			switch (ev.Action) 
			{
				case MotionEventActions.Down:
					LastTouched = SystemClock.UptimeMillis();
					break;

				case MotionEventActions.Up:
					long now = SystemClock.UptimeMillis();
					if (now - LastTouched > SCROLL_TIME) {
						MapUpdateListener.UpdateMapView();
					}
					break;
			}

			return base.DispatchTouchEvent(ev);
		}
	}
}

