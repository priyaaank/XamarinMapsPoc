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
using Mappy.Common;

namespace Mappy
{
	public class MapEntityListView : Android.Support.V4.App.ListFragment
	{
		private List<BankEntity> BankEntities;

		public MapEntityListView()
		{
			BankEntities = new List<BankEntity> ();
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
		}

		public override void OnResume()
		{
			base.OnResume ();
			InitializeList ();
		}

		public override void OnPause()
		{
			base.OnPause ();
		}

		void InitializeList ()
		{
			this.ListAdapter = new EntityAdapter (Activity,Resource.Layout.EntityListRow, BankEntities);
		}

		public void UpdateList (List<BankEntity> entities)
		{
			(this.ListAdapter as EntityAdapter).UpdateData(entities);
		}

	}
}

