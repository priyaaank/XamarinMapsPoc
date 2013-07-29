using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using Android.Gms.Maps.Model;

namespace Mappy
{
	class EntityCache
	{
		private const int MaxQueueSize = 1000;

		private ConcurrentQueue<BankEntity> BankEntities = new ConcurrentQueue<BankEntity>();
		private BankEntitiesService Service;

		public EntityCache(BankEntitiesService service)
		{
			this.Service = service;
		}

		public List<BankEntity> FilteredEntities(ViewportFilter<LatLngBounds> filter)
		{
			List<BankEntity> matchingEntities = new List<BankEntity> ();

			foreach (BankEntity entity in BankEntities)
			{
				if (filter.CoordinateEnclosed (entity)) matchingEntities.Add(entity);
			}

			return matchingEntities;
		}

		public void AddAll(List<BankEntity> entities)
		{
			bool modificationsMade = false;
			foreach (BankEntity entity in entities) 
			{
				if (!BankEntities.Contains (entity)) {
					modificationsMade = true;
					BankEntities.Enqueue (entity);
				}
			}

			RemoveStaleElements ();

			if (modificationsMade) CacheUpdated ();
		}

		void CacheUpdated ()
		{
			Service.CacheUpdated ();
		}

		private void RemoveStaleElements ()
		{
			if (BankEntities.Count > MaxQueueSize) 
			{
				BankEntity o = null;
				var excessElementsCount = BankEntities.Count - MaxQueueSize;
				for (int index = 0; index < excessElementsCount; index++) 
				{
					BankEntities.TryDequeue (out o);
				}
			}
		}
	}
}

