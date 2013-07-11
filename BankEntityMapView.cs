using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;
using Java.Lang;
using Android.Gms.Maps.Model;
using System.Threading;

namespace Mappy
{
	public class BankEntityMapView : SupportMapFragment
	{

		private BankEntitiesService EntitiesService;

		public static BankEntityMapView newInstance() {
			return new BankEntityMapView();
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
			View view = base.OnCreateView(inflater, container, savedInstanceState);
			EntitiesService = new BankEntitiesService ();
			return view;
		}

		public override void OnResume()
		{
			base.OnResume ();
			EntitiesService = new BankEntitiesService ();

			SetupMap ();
		}

		void SetupMap ()
		{
			if (this.Map != null) {
				MarkerOptions mapMarker = null;
				List<BankEntity> bankEntities = EntitiesService.fetch ();

				foreach (BankEntity aEntity in bankEntities) {
					mapMarker = new MarkerOptions ();
					mapMarker.SetPosition (aEntity.Location);
					mapMarker.SetTitle (aEntity.Name);
					this.Map.AddMarker (mapMarker);
				}

			}
		}
	}
}

