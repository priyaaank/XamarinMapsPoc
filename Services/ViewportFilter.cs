using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappy
{
	interface ViewportFilter<B>
	{
		bool CoordinateEnclosed (BankEntity entity);
	}
}

