using System;
using System.Json;

namespace Mappy
{
	public abstract class BankEntity
	{
		public enum Type { Atm, Branch }

		public long Id { get; private set;}
		public string Name { get; private set;}
		public long LocationId { get; private set;}
		public double Latitude { get; private set;}
		public double Longitude { get; private set;}
		public double Distance { get; private set;}
		public Type EntityType { get; private set;}

		public BankEntity(long id, string name, long locationId, double latitude, double longitude, double distance, Type entityType)
		{
			this.Id = id;
			this.Name = name;
			this.LocationId = locationId;
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Distance = distance;
			this.EntityType = entityType;
		}

		public static Atm AtmFromJsonObject(JsonObject jsonObject)
		{
			if (jsonObject == null)
				return null;
			return new Atm (jsonObject["ATMId"], jsonObject["Brand"], jsonObject["ATMName"], jsonObject["LocationId"], jsonObject["Latitude"], jsonObject["Longitude"], jsonObject["Distance"]);
		}

		public static Branch BranchFromJsonObject(JsonObject jsonObject)
		{
			if (jsonObject == null)
				return null;
			return new Branch (jsonObject["BranchId"], jsonObject["BranchName"], jsonObject["LocationId"], jsonObject["Latitude"], jsonObject["Longitude"], jsonObject["Distance"], jsonObject["BranchPhone"]);
		}

		public string Description ()
		{
			var type = this.IsBranch() ? "Branch" : "Atm";
			var brand = this.IsOwnBrand () ? "Suncorp" : "Other";
			return type + " " + brand + " " + this.Name;
		}

		public abstract bool IsBranch();

		public abstract bool IsAtm ();

		public abstract bool IsOwnBrand ();
	}
}

