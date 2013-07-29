using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using Mappy.Common;

namespace Mappy.iOS
{
	public partial class Mappy_iOSViewController : UIViewController
	{
		MapViewModel ViewModel;

		public Mappy_iOSViewController () : base ("Mappy_iOSViewController", null)
		{
			ViewModel = new MapViewModel ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			MapView.ShowsUserLocation = true;
		}

		void CenterOnUser()
		{
			MapView.Region = new MKCoordinateRegion(MapView.UserLocation.Coordinate, new MKCoordinateSpan(20, 20));
		}

		public override void ViewDidAppear (bool animated)
		{
			CenterOnUser ();

			//var bankEntities = EntitiesService.fetch (coordinates.Latitude, coordinates.Longitude, userSelection);
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

