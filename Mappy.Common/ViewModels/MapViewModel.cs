using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mappy.Common
{
	public class MapViewModel
	{
		public BankEntitiesService EntitiesService;

		public MapViewModel ()
		{
			EntitiesService = BankEntitiesService.Instance ();
		}

		public void FetchEntitiesAsync(double latitude, double longitude, int noOfRecords)
		{
			EntitiesService.QueueServiceRequest (latitude, longitude, noOfRecords);
		}

		public void Deregister (CacheChangeListener listener)
		{
			EntitiesService.Deregister (listener);
		}

		public void Register (CacheChangeListener listener)
		{
			EntitiesService.Register (listener);
		}

		public List<BankEntity> Fetch (ViewportFilter viewportFilter, Options userSelection)
		{
			return EntitiesService.Fetch (viewportFilter, userSelection);
		}
	}
}

