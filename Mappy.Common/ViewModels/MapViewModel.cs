using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mappy.Common
{
	public class MapViewModel
	{
		public BankEntitiesService EntitiesService;

		public static readonly float MAX_SUPPORTED_ZOOM_LEVEL = 3.5f;
		public static readonly float MICRO_TO_SMALL_THRESHOLD_ZOOM_LEVEL = 14.0f;
		public static readonly float SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL = 17.0f;
		public static readonly float DEFAULT_ZOOM_LEVEL = 15.0f;

		public float LastZoomLevel { get; set; }

		static List<ZoomPair> ZoomPairs = new List<ZoomPair> () {
			new ZoomPair(SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL, IconType.Medium),
			new ZoomPair(MICRO_TO_SMALL_THRESHOLD_ZOOM_LEVEL, IconType.Small),
			new ZoomPair(MAX_SUPPORTED_ZOOM_LEVEL, IconType.Micro)

		};

		public MapViewModel ()
		{
			EntitiesService = BankEntitiesService.Instance ();
		}

		public async Task FetchEntitiesAsync(double latitude, double longitude, int noOfRecords)
		{
			await Task.Factory.StartNew(()=>EntitiesService.QueueServiceRequest (latitude, longitude, noOfRecords));
		}

		public void Deregister (CacheChangeListener listener)
		{
			EntitiesService.Deregister (listener);
		}

		public void Register (CacheChangeListener listener)
		{
			EntitiesService.Register (listener);
		}

		public List<BankEntity> Fetch (ViewportFilter viewportFilter, Options userSelection)
		{
			return EntitiesService.Fetch (viewportFilter, userSelection);
		}

		public IconType IconForCurrentZoomLevel (float currentZoomLevel)
		{
			foreach (var zoomPair in ZoomPairs) {
				if (currentZoomLevel >= zoomPair.ZoomLevel) {
					return zoomPair.Icon;
				}
			}

			return IconType.None;
		}

		public bool ShouldIconChange (float currentZoomLevel) {
			foreach (var zoomPair in ZoomPairs) {
				if (LastZoomLevel < zoomPair.ZoomLevel && currentZoomLevel >= zoomPair.ZoomLevel
				    || LastZoomLevel > zoomPair.ZoomLevel && currentZoomLevel <= zoomPair.ZoomLevel)
					return true;
			}

			return false;
		}
	}
}

