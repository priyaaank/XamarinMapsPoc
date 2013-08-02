using System;
using System.Collections.Generic;
using BankApp.Common.Lib;
using System.Linq;
namespace Mappy.Common
{
	public class BankEntitiesService
	{

		private static readonly string SERVICE_URI = "http://servicelocator.suncorpbank.com.au/api/locate?Longitude={0}&Latitude={1}&RadiusKm=5000&MaxRecords={2}&Types=ATM,Branch";

		private static BankEntitiesService SingleInstance = new BankEntitiesService();
		private EntityCache LocalEntityCache;
		IJsonClient JsonClient;

		private List<CacheChangeListener> Listeners = new List<CacheChangeListener>();

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
			var requestString = string.Format (SERVICE_URI, longitude, latitude, numberOfRecords);
			var responseItems = JsonClient.DoGetRequestSync<List<LocatorResponseItem>> (requestString);
			var entityItems = (from item in responseItems select EntityForResponseItem (item)).ToList ();
			LocalEntityCache.AddAll (entityItems);
			CacheUpdated ();
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
                item.Distance
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
				item.BranchPhone
			);
		}


		public void CacheUpdated()
		{
			foreach (CacheChangeListener listener in Listeners)
				listener.FetchAndUpdate ();
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

//		private List<BankEntity> Filtered (List<BankEntity> bankEntityList)
//		{
//			if (Filters == null || Filters.Count == 0) return bankEntityList;
//
//			List<BankEntity> bankEntityListCopy = new List<BankEntity>(bankEntityList);
//			foreach (Type aEntityFilter in Filters)
//			{
//				bankEntityListCopy = ((EntityFilter)Activator.CreateInstance (aEntityFilter, bankEntityListCopy)).FilteredList ();
//			}
//
//			return bankEntityListCopy;
//		}
	}
}

