using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

