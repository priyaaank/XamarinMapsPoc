using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Mappy
{
	public interface IViewportFilter
	{
		List<BankEntity> FilteredList (IEnumerable<BankEntity> unfilteredList);
	}
}