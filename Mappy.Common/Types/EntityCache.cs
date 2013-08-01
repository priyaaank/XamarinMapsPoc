using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Collections;

namespace Mappy.Common
{
	public class EntityCache
	{
		private const int MaxQueueSize = 5000;

		private SortedConcurrentDictionary BankEntities = new SortedConcurrentDictionary(MaxQueueSize);
		private BankEntitiesService Service;

		public EntityCache(BankEntitiesService service)
		{
			this.Service = service;
		}

		public List<BankEntity> FilteredEntities(IViewportFilter filter)
		{
			return filter.FilteredList (BankEntities.GetListOfAllEntitities() as IEnumerable<BankEntity>);
		}

		public void AddAll(List<BankEntity> entities)
		{

			if (BankEntities.AddEntities(entities)) CacheUpdated ();
		}

		void CacheUpdated ()
		{
			Service.CacheUpdated ();
		}
	}
}