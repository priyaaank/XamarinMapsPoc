using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;


namespace Mappy
{
	class SortedConcurrentDictionary
	{
		private ConcurrentDictionary<long, BankEntity> BankEntity = new ConcurrentDictionary<long, BankEntity>();
		private ConcurrentQueue<long> LocationQueue = new ConcurrentQueue<long> ();
		private int Size;

		public SortedConcurrentDictionary(int size)
		{
			Size = size;
		}

		public BankEntity RetriveEntityBasedOnKey(long key)
		{
			BankEntity value = null;
			BankEntity.TryGetValue (key, out value);
			return value;
		}

		public IList<BankEntity> GetListOfAllEntitities()
		{
			return (IList<BankEntity>)BankEntity.Values;
		}

		public bool AddEntities(List<BankEntity> entities)
		{
			bool modificationsMade = false;
			foreach (BankEntity aEntity in entities) 
			{
				modificationsMade = (InsertEntity (aEntity.LocationId, aEntity) & modificationsMade);
			}
			ManageFrequencyListSize ();
			return modificationsMade;
		}

		private bool InsertEntity(long id, BankEntity entity)
		{
			bool isAdded = false;
			if (!BankEntity.ContainsKey (id)) isAdded = true;
			BankEntity [id] = entity;
			AddToQueue (id);
			return isAdded;
		}

		private void AddToQueue(long locationId)
		{
			if (!LocationQueue.Contains (locationId))
				LocationQueue.Enqueue (locationId);
		}


		public void ManageFrequencyListSize ()
		{
			long removedId = 0;
			int elementCountToBeRemoved = 0;
			if (LocationQueue.Count > Size) {
				elementCountToBeRemoved = LocationQueue.Count - Size;
				for (int index = 0; index < elementCountToBeRemoved; index++) {
					LocationQueue.TryDequeue (out removedId);
				}
			}
		}
	}
}

