using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using Mappy.Common;
using System.Collections.Generic;
using Google.Maps;
using System.Threading.Tasks;

namespace Mappy.iOS
{
	public partial class Mappy_iOSViewController : UIViewController
	{
		UIBarButtonItem OptionsButton;
		MapView MapView;
		MapViewModel ViewModel;
		List<Marker> Markers;
		Options MapOptions;

		const int AlertMarginX = 20;
		const int AlertY = 60;
		const int AlertHeight = 240;
		const int AlertPaddingX = 20;
		const int AlertPaddingY = 10;

		public Mappy_iOSViewController () : base ()
		{
			ViewModel = new MapViewModel ();
			Markers = new List<Marker> ();
			MapOptions = new Options (true, true, true);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			MapView = new MapView ();
			InitUI ();
			View = MapView;
		}

		void InitUI ()
		{
			MapView.MyLocationEnabled = true;
			MapView.Settings.MyLocationButton = true;
			NavigationItem.RightBarButtonItem = new UIBarButtonItem ("Options", UIBarButtonItemStyle.Plain, OptionsButtonPressed);
		}

		void OptionsButtonPressed (object sender, EventArgs e)
		{
			var alert = BuildOptionsView ();

			View.AddSubview (alert);
		}

		UIView BuildOptionsView ()
		{

			var screenWidth = UIScreen.MainScreen.Bounds.Width;

			var alert = new UIView(new RectangleF(AlertMarginX, AlertY, screenWidth - 2*AlertMarginX, AlertHeight));
			alert.BackgroundColor = UIColor.White;
			var title = new UILabel(new RectangleF(AlertPaddingX, AlertPaddingY, alert.Bounds.Width - 2*AlertPaddingX, 40));
			title.Text = "Options";
			alert.AddSubview(title);

			var atmsCheckbox = BuildCheckboxOption (alert, "ATMs", 60);
			var branchesCheckbox = BuildCheckboxOption (alert, "Branches", 100);
			var partnerCheckbox = BuildCheckboxOption (alert, "Patner ATMs", 140);

			atmsCheckbox.Selected = MapOptions.SelectOwnAtms;
			branchesCheckbox.Selected = MapOptions.SelectOwnBranches;
			partnerCheckbox.Selected = MapOptions.SelectPartnerAtms;

			var okButton = new UIButton (UIButtonType.RoundedRect) {
				Frame = new RectangleF(AlertPaddingX, AlertHeight - AlertPaddingY - 44, alert.Bounds.Width - 2*AlertPaddingX, 44),
			};
			okButton.SetTitle ("OK", UIControlState.Normal);
			okButton.TouchUpInside += (object sender, EventArgs e) => {
				MapOptions = new Options(atmsCheckbox.Selected, branchesCheckbox.Selected, partnerCheckbox.Selected);
				alert.RemoveFromSuperview();
				ShowEntitiesOnMap();
			};
			alert.AddSubview (okButton);

			return alert;
		}

		UIButton BuildCheckboxOption(UIView container, string labelText, int y)
		{
			var label = new UILabel (new RectangleF(AlertPaddingX, y, 160, 40)) {
				Text = labelText
			};
			var checkbox = new UIButton (UIButtonType.RoundedRect) {
				Frame = new RectangleF(AlertPaddingX + 160, y, 60, 40)
			};
			checkbox.SetTitle (labelText, UIControlState.Normal);
			checkbox.TouchUpInside += (object sender, EventArgs e) => {
				checkbox.Selected = !checkbox.Selected;
			};

			container.AddSubview (label);
			container.AddSubview (checkbox);
			return checkbox;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			MapView.StartRendering ();
			LoadMap ();
			//MapView.CameraPositionChanged += (sender, e) => ShowEntitiesOnMap();
			//MapView.RegionChanged += (sender, e) => ShowEntitiesOnMap ();
		}

		async void LoadMap ()
		{
			await Task.Delay (4000);
			ShowEntitiesOnMap ();
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			MapView.StopRendering ();
		}

		void GetLocation ()
		{
			var locationManager = new CLLocationManager ();
			locationManager.LocationsUpdated += (object sender, CLLocationsUpdatedEventArgs e) => {
				var coordinate = e.Locations[e.Locations.Length-1].Coordinate;
				MapView.Camera = new CameraPosition(coordinate, MapViewModel.DEFAULT_ZOOM_LEVEL, 0.0d, 0.0d);
				locationManager.StopUpdatingLocation();
			};
			locationManager.StartUpdatingLocation ();
		}

		async void ShowEntitiesOnMap ()
		{
			MapView.Clear ();
			var entities = await ViewModel.FetchEntitiesAsync (MapView.Camera.Target.Latitude, MapView.Camera.Target.Longitude, MapOptions);
			foreach (var entity in entities) {
				var marker = new Marker () {
					Position = new CLLocationCoordinate2D(entity.Latitude, entity.Longitude),
					Title = entity.Name,
					Map = MapView
				};
				Markers.Add (marker);
			}
		}


		void CenterOnUser()
		{
		}

		public override void ViewDidAppear (bool animated)
		{
			GetLocation ();
		}

	}
}

