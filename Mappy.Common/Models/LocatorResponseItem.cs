using System;

namespace Mappy
{
	public class LocatorResponseItem
	{
		//ATM specific
		public int ATMId { get; set; }
		public string Brand { get; set; }
		public string ATMName { get; set; }

		//Branch specific
		public int BranchId {get; set;}
		public string BranchType { get; set; }
		public string BranchName {get; set;}
		public string BranchPhone { get; set; }
		public string MondayHours { get; set; }
		public string TuesdayHours { get; set; }
		public string WednesdayHours {get; set;}
		public string ThursdayHours { get; set; }
		public string FridayHours { get; set; }
		public string SaturdayHours { get; set; }
		public string SundayHours {get; set; }

		//Common fields
		public int LocationId {get; set;}
		public string LocationType { get; set; }
		public string Street1 { get; set; }
		public string Street2 { get; set; }
		public string Street3 {get; set;}
		public string Suburb { get; set; }
		public string State { get; set; }
		public string Postcode { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public double Distance { get; set; }



		public LocatorResponseItem ()
		{
		}
	}
}

