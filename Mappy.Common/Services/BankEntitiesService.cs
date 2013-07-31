using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Json;

namespace Mappy
{
	public class BankEntitiesService
	{

		//private static readonly string SERVICE_URI = "http://servicelocatorsuncorpbankdev.int.corp.sun/api/locate?lng={0}&lat={1}&results={2}&RadiusKm=500&checkboxes=ATM,Branch";
		private static readonly string SERVICE_URI = "http://servicelocator.suncorpbank.com.au/Home/GetLocations?lng={0}&lat={1}&results={2}&checkboxes=ATM,Branch";
	//		private List<EntityFilter> Filters;
		private static BankEntitiesService SingleInstance = new BankEntitiesService();
		private EntityCache LocalEntityCache;

		private List<CacheChangeListener> Listeners = new List<CacheChangeListener>();

		private BankEntitiesService()
		{
			LocalEntityCache = new EntityCache (this);
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
			var request = HttpWebRequest.Create(string.Format(SERVICE_URI, longitude, latitude, numberOfRecords));
			request.ContentType = "application/json";
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd();
					if(string.IsNullOrWhiteSpace(content)) {
						Console.Out.WriteLine("Response contained empty body...");
					}
					else {
						SerializeJsonToEntities (content);
					}
				}
			}
		}

		public void CacheUpdated()
		{
			foreach (CacheChangeListener listener in Listeners)
				listener.FetchAndUpdate ();
		}

		private void SerializeJsonToEntities (string content)
		{
			JsonArray bankEntities = JsonObject.Parse (content)["locations"] as JsonArray;

			List<BankEntity> bankEntityList = new List<BankEntity>() ;
			BankEntity entity = null;
			foreach (JsonObject aBankEntity in bankEntities)
			{
				entity = aBankEntity.ContainsKey("ATMId") ? BankEntity.AtmFromJsonObject(aBankEntity) as BankEntity : BankEntity.BranchFromJsonObject(aBankEntity) as BankEntity;
				if (entity != null) bankEntityList.Add (entity);
			}
			LocalEntityCache.AddAll (bankEntityList);
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

