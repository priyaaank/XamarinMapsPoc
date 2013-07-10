using System;
using Android.Gms.Maps.Model;

namespace Mappy
{
	public class BankEntity
	{
		public LatLng Location { get; private set; } 

		public string Name {
			get;
			private set;
		}

		public BankEntity (LatLng location, string name)
		{
			this.Location = location;
			this.Name = name;
		}
	}
}

