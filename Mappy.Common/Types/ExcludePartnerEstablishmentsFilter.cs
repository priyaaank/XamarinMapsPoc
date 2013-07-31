using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappy
{
	class ExcludePartnerEstablishmentsFilter : EntityFilter
	{

		public ExcludePartnerEstablishmentsFilter(List<BankEntity> unfilteredList) : base(unfilteredList)
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
			return aBankEntity.IsOwnBrand ();
		}

	}
}

