using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mappy.Common
{
	public class MapViewModel
	{
		public BankEntitiesService EntitiesService { get; set; }

		public MapViewModel ()
		{
			EntitiesService = new BankEntitiesService ();
		}

		public async Task<List<BankEntity>> FetchEntitiesAsync(double latitude, double longitude, Options selectedOptions)
		{
			var task = new Task<List<BankEntity>> (()=>{
				return EntitiesService.fetch (latitude, longitude, selectedOptions);
			});
			task.Start ();
			return await task;
		}
	}
}

