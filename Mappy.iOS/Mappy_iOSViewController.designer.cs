// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Mappy.iOS
{
	[Register ("Mappy_iOSViewController")]
	partial class Mappy_iOSViewController
	{
		[Outlet]
		MonoTouch.MapKit.MKMapView MapView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton OptionsButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MapView != null) {
				MapView.Dispose ();
				MapView = null;
			}

			if (OptionsButton != null) {
				OptionsButton.Dispose ();
				OptionsButton = null;
			}
		}
	}
}
