using System;
using Android.Gms.Location;

namespace Mappy
{
	public interface IMapActivity
	{
		Options MapOptions { get; set; }
		LocationClient LocationClient { get; }
		bool LocationClientConnected { get; }
	}
}

