using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Json;
using Android.Gms.Maps.Model;

namespace Mappy
{
	public class BankEntitiesService
	{
		private static readonly string SERVICE_URI = "http://servicelocator.suncorpbank.com.au/Home/GetLocations?lng={0}&lat={1}&results={2}&checkboxes={3}";
		private List<Type> Filters; 

		public BankEntitiesService ()
		{
			Filters = new List<Type> ();
		}

		public List<BankEntity> fetch(double latitude, double longitude, int numberOfRecords, Options selectedOptions) 
		{
			Filters = selectedOptions.FiltersForSelection ();

			var request = HttpWebRequest.Create(string.Format(SERVICE_URI, longitude, latitude, numberOfRecords, selectedOptions.SelectionCriteria()));
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
						return SerializeJsonToEntities (content);
					}
				}
				return null;
			}
		}

		private List<BankEntity> SerializeJsonToEntities (string content)
		{
			JsonArray bankEntities = JsonObject.Parse (content)["locations"] as JsonArray;

			List<BankEntity> bankEntityList = new List<BankEntity>() ; 
			BankEntity entity = null;
			foreach (JsonObject aBankEntity in bankEntities) 
			{
				entity = aBankEntity.ContainsKey("ATMId") ? BankEntity.AtmFromJsonObject(aBankEntity) as BankEntity : BankEntity.BranchFromJsonObject(aBankEntity) as BankEntity;
				if (entity != null) bankEntityList.Add (entity);
			}

			return Filtered( bankEntityList );
		}

		private List<BankEntity> Filtered (List<BankEntity> bankEntityList)
		{
			if (Filters == null || Filters.Count == 0) return bankEntityList;

			List<BankEntity> bankEntityListCopy = new List<BankEntity>(bankEntityList);
			foreach (Type aEntityFilter in Filters) 
			{
				bankEntityListCopy = ((EntityFilter)Activator.CreateInstance (aEntityFilter, bankEntityListCopy)).FilteredList ();
			}

			return bankEntityListCopy;
		}
	}
}

