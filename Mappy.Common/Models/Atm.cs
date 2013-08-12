using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappy
{
	public class Atm : BankEntity
	{

		public string Brand { get; private set; }
		private const string SunCorpBrandName = "suncorp";

		public Atm(long id, string brand, string name, long locationId, double latitude, double longitude, double distance, string locationType) : base(id, name, locationId, latitude, longitude, distance, BankEntity.Type.Atm,locationType )
		{
			this.Brand = brand;
		}

		public override bool IsBranch()
		{
			return false;
		}

		public override bool IsAtm()
		{
			return true;
		}

		public override bool IsOwnBrand ()
		{
			if (Brand == null)
				return true;
			return string.Equals (SunCorpBrandName, Brand, StringComparison.OrdinalIgnoreCase);
		}


		#region implemented abstract members of BankEntity
		public override string BrandName ()
		{
			return this.Brand;
		}
		#endregion
	}
}

