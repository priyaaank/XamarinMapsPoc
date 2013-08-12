using System;
using System.Collections.Generic;
using BankApp.Common.Lib;
using System.Linq;
using System.Collections.Concurrent;


namespace Mappy.Common
{
	public class BankEntitiesService
	{

		private static readonly string SERVICE_URI = "http://servicelocator.suncorpbank.com.au/api/locate?Longitude={0}&Latitude={1}&RadiusKm=5000&MaxRecords={2}&Types={3}";

		private static BankEntitiesService SingleInstance = new BankEntitiesService();
		private EntityCache LocalEntityCache;
		IJsonClient JsonClient;

		private List<CacheChangeListener> Listeners = new List<CacheChangeListener>();
		private ConcurrentDictionary<BankEntity.Type, BankEntity> EntitiesClosestToUser = new ConcurrentDictionary<BankEntity.Type, BankEntity>();

		private BankEntitiesService()
		{
			LocalEntityCache = new EntityCache (this);
			JsonClient = new JsonClientImpl ();
		}

		public static BankEntitiesService Instance()
		{
			return SingleInstance;
		}

		public void Register(CacheChangeListener listener)
		{
			if(!Listeners.Contains(listener)) Listeners.Add (listener);
		}

		public void Deregister(CacheChangeListener listener)
		{
			if(Listeners.Contains(listener)) Listeners.Remove(listener);
		}

		public void QueueServiceRequest(double latitude, double longitude, int numberOfRecords)
		{
			var requestString = ServiceURIForBoth(longitude, latitude, numberOfRecords);
			var responseItems = JsonClient.DoGetRequestSync<List<LocatorResponseItem>> (requestString);
			var entityItems = (from item in responseItems select EntityForResponseItem (item)).ToList ();
			LocalEntityCache.AddAll (entityItems);
			CacheUpdated ();
		}

		public void QueueServiceRequestForClosestLocations (double latitude, double longitude)
		{
			foreach (BankEntity.Type entityType in Enum.GetValues(typeof(BankEntity.Type)))
			{
				var requestString = ServiceURIFor(longitude, latitude, 1, entityType);
				var responseItems = JsonClient.DoGetRequestSync<List<LocatorResponseItem>> (requestString);
				var entityItems = (from item in responseItems select EntityForResponseItem (item)).ToList ();
				EntitiesClosestToUser [entityType] = entityItems [0];
			}
			ClosestEntitiesUpdated ();
		}

		BankEntity EntityForResponseItem(LocatorResponseItem item)
		{
			if (item.LocationType == "ATM")
				return AtmFromLocatorResponseItem (item);
			else
				return BranchFromLocatorResponseItem (item);
		}

		Atm AtmFromLocatorResponseItem(LocatorResponseItem item)
		{
			return new Atm (
				item.ATMId,
                item.Brand,
                item.ATMName,
                item.LocationId,
                item.Latitude,
                item.Longitude,
                item.Distance,
				item.LocationType
			);
		}

		Branch BranchFromLocatorResponseItem(LocatorResponseItem item)
		{
			return new Branch (
				item.BranchId,
				item.BranchName,
				item.LocationId,
				item.Latitude,
				item.Longitude,
				item.Distance,
				item.BranchPhone,
				item.LocationType			
			);
		}


		public void CacheUpdated()
		{
			foreach (CacheChangeListener listener in Listeners)
				listener.FetchAndUpdate ();
		}

		void ClosestEntitiesUpdated ()
		{
			foreach (CacheChangeListener listener in Listeners)
				listener.FetchAndUpdateClosest ();
		}

		public BankEntity ClosestEntity (Options userSelection)
		{
			if (userSelection.SelectAnyEntity () || userSelection.SelectAnySuncorpEntity() ) return NearestEntity ();
			if (userSelection.SelectOwnBranches) return EntitiesClosestToUser[BankEntity.Type.Branch];
			if (userSelection.SelectAnyAtm ()) return EntitiesClosestToUser[BankEntity.Type.Atm];
			return null;
		}

		private BankEntity NearestEntity ()
		{
			BankEntity atm = EntitiesClosestToUser [BankEntity.Type.Atm];
			BankEntity branch = EntitiesClosestToUser [BankEntity.Type.Branch];
			return atm.Distance < branch.Distance ? atm : branch;
		}

		public List<BankEntity> Fetch(IViewportFilter filter, Options filterOptions)
		{
			var filteredEntities = LocalEntityCache.FilteredEntities (filter);

			List<BankEntity> filteredEntitiesCopy = new List<BankEntity>(filteredEntities);
			foreach (Type aEntityFilter in filterOptions.FiltersForSelection())
			{
				filteredEntitiesCopy = ((EntityFilter)Activator.CreateInstance (aEntityFilter, filteredEntitiesCopy)).FilteredList ();
			}

			return filteredEntitiesCopy;
		}

		private string ServiceURIFor (double longitude, double latitude, int maxRecords, BankEntity.Type type)
		{
			return (type == BankEntity.Type.Atm) ? string.Format (SERVICE_URI, longitude, latitude, maxRecords, @"ATM") : string.Format (SERVICE_URI, longitude, latitude, maxRecords, @"Branch");
		}

		private string ServiceURIForBoth (double longitude, double latitude, int maxRecords)
		{
			return string.Format (SERVICE_URI, longitude, latitude, maxRecords, @"ATM,Branch");
		}


	}
}

