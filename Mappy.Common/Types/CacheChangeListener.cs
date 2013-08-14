using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappy
{
	public interface CacheChangeListener
	{
		void FetchAndUpdate();
		void FetchAndUpdateClosest();
	}
}
