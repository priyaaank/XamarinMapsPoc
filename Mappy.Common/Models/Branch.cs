using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappy
{
	public class Branch : BankEntity
	{
		public string PhoneNumber { get; private set;}

		public Branch(long id, string name, long locationId, double latitude, double longitude, double distance, string locationType) : base(id, name, locationId, latitude, longitude, distance, BankEntity.Type.Branch, locationType)
		{

		}

		public override bool IsBranch()
		{
			return true;
		}

		public override bool IsAtm()
		{
			return false;
		}

		public override bool IsOwnBrand()
		{
			return true;
		}

		#region implemented abstract members of BankEntity

		public override string BrandName ()
		{
			return "Suncorp";
		}

		#endregion
	}
}

