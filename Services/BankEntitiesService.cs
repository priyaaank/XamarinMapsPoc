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
		private static readonly string SERVICE_URI = "http://10.12.25.3:8889/Home/GetLocations?lng={0}&lat={1}&results=10&checkboxes={2}";

		public BankEntitiesService ()
		{

		}

		public List<BankEntity> fetch(double latitude, double longitude, List<string> selectionType) 
		{
			string selectionCriteria = string.Join (",", selectionType.ToArray());
			var request = HttpWebRequest.Create(string.Format(SERVICE_URI, longitude, latitude, selectionCriteria));
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

		List<BankEntity> SerializeJsonToEntities (string content)
		{
			JsonArray bankEntities = JsonObject.Parse (content)["locations"] as JsonArray;

			List<BankEntity> bankEntityList = new List<BankEntity>() ; 
			BankEntity entity = null;
			foreach (JsonObject aBankEntity in bankEntities) 
			{
				entity = aBankEntity.ContainsKey("ATMId") ? BankEntity.AtmFromJsonObject(aBankEntity) as BankEntity : BankEntity.BranchFromJsonObject(aBankEntity) as BankEntity;
				if (entity != null) bankEntityList.Add (entity);
			}

			return bankEntityList;
		}
	}
}

