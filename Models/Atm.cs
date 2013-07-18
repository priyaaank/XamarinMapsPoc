using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mappy
{
	public class Atm : BankEntity
	{

		public string Brand { get; private set; }
		private const string BrandName = "suncorp";

		public Atm(long id, string brand, string name, long locationId, double latitude, double longitude, double distance) : base(id, name, locationId, latitude, longitude, distance, BankEntity.Type.Atm)
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
			return string.Equals (BrandName, Brand, StringComparison.OrdinalIgnoreCase);
		}
	}
}

