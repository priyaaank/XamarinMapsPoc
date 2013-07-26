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
	public abstract class EntityFilter
	{
		protected List<BankEntity> UnfilteredList;

		public EntityFilter(List<BankEntity> unfilteredList)
		{
			this.UnfilteredList = unfilteredList;
		}

		public abstract List<BankEntity> FilteredList();
	}
}

