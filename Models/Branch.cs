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
	public class Branch : BankEntity
	{
		public string PhoneNumber { get; private set;}

		public Branch(long id, string name, long locationId, double latitude, double longitude, double distance, string phoneNumber) : base(id, name, locationId, latitude, longitude, distance, BankEntity.Type.Branch)
		{
			this.PhoneNumber = phoneNumber;
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

	}
}

