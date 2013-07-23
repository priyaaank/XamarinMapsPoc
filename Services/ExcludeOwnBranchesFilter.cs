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
	class ExcludeOwnBranchesFilter : EntityFilter
	{
		public ExcludeOwnBranchesFilter(List<BankEntity> unfilteredList) : base(unfilteredList)
		{

		}

		public override List<BankEntity> FilteredList()
		{
			List<BankEntity> filteredList = new List<BankEntity>();

			foreach (BankEntity aBankEntity in this.UnfilteredList) 
			{
				if (Include (aBankEntity)) filteredList.Add (aBankEntity);
			}

			return filteredList;
		}

		private bool Include (BankEntity aBankEntity)
		{
			return (!aBankEntity.IsBranch());
		}
	}
}
