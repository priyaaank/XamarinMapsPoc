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
		public string LocationType{get; private set;}

		const int MetersPerKm = 1000;
		const string MeterSymbol = "m";
		const string KilometerSymbol = "Kms";

		public BankEntity(long id, string name, long locationId, double latitude, double longitude, double distance, Type entityType, string locationType)
		{
			this.Id = id;
			this.Name = name;
			this.LocationId = locationId;
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Distance = distance;
			this.EntityType = entityType;
			this.LocationType = locationType;
		}

		public string Description ()
		{
			return BrandName () + this.LocationType;
		}

		public abstract bool IsBranch();

		public abstract bool IsAtm ();

		public abstract bool IsOwnBrand ();

		public abstract string BrandName ();
	

		public string FormattedDistance()
		{
			return DistanceIsLessThanAKm() ? DistanceInMeters() : DistanceInKms();
		}

		private string DistanceInMeters ()
		{
			return (RoundedDistance() * MetersPerKm).ToString () + MeterSymbol;
		}

		private string DistanceInKms ()
		{
			return RoundedDistance() + KilometerSymbol;
		}

		private bool DistanceIsLessThanAKm ()
		{
			return RoundedDistance() < 1;
		}

		private double RoundedDistance()
		{
			return Math.Round (this.Distance, 2);
		}

		public override int GetHashCode()
		{
			return (int) LocationId;
		}

		public override bool Equals(System.Object obj)
		{
			if (obj == null)
				return false;

			BankEntity anotherBankEntity = obj as BankEntity;
			if ((System.Object)anotherBankEntity == null)
				return false;

			return (LocationId == anotherBankEntity.LocationId);
		}
	}
}

