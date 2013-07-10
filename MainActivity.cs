using Android.Support.V4.App;

namespace Mappy
{
	using Android.App;
	using Android.Gms.Maps;
	using Android.Gms.Maps.Model;
	using Android.OS;
	using Android.Widget;

	[Activity (Label = "Mappy", MainLauncher = true)]
	public class MainActivity : FragmentActivity
	{
		private SupportMapFragment _mapFragment;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.MapLayout);

			InitMapFragment();
		}

		protected override void OnResume()
		{
			base.OnResume();
		}

		private void InitMapFragment()
		{
			_mapFragment = this.SupportFragmentManager.FindFragmentByTag("map") as SupportMapFragment;
			if (_mapFragment == null)
			{
				GoogleMapOptions mapOptions = new GoogleMapOptions()
					.InvokeMapType(GoogleMap.MapTypeNormal)
						.InvokeZoomControlsEnabled(false)
						.InvokeCompassEnabled(true);

				var fragTx = this.SupportFragmentManager.BeginTransaction();
				_mapFragment = SupportMapFragment.NewInstance(mapOptions);
				fragTx.Add(Resource.Id.map, _mapFragment, "map");
				fragTx.Commit();
			}
		}

	}
}


