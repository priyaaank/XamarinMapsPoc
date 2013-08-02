using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mappy.Common
{
	public class MapViewModel
	{
		public event EventHandler IconTypeChanged;

		public BankEntitiesService EntitiesService;

		public static readonly float MAX_SUPPORTED_ZOOM_LEVEL = 10.0f;
		public static readonly float MICRO_TO_SMALL_THRESHOLD_ZOOM_LEVEL = 14.0f;
		public static readonly float SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL = 16.0f;
		public static readonly float DEFAULT_ZOOM_LEVEL = 15.0f;


		static List<ZoomPair> ZoomPairs = new List<ZoomPair> () {
			new ZoomPair(SMALL_TO_MEDIUM_THRESHOLD_ZOOM_LEVEL, IconType.Medium),
			new ZoomPair(MICRO_TO_SMALL_THRESHOLD_ZOOM_LEVEL, IconType.Small),
			new ZoomPair(MAX_SUPPORTED_ZOOM_LEVEL, IconType.Micro),
			new ZoomPair(0.0f, IconType.None)

		};

		public float zoomLevel;

		public float ZoomLevel {
			get {
				return zoomLevel;
			}
			set {
				zoomLevel = value;
				if (IconForCurrentZoomLevel != IconType)
					IconType = IconForCurrentZoomLevel;
			}
		}

		IconType iconType;
		public IconType IconType {
			get {
				return iconType;
			}
			set {
				iconType = value;
				if (IconTypeChanged != null)
					IconTypeChanged (this, null);
			}
		}

		public MapViewModel ()
		{
			EntitiesService = BankEntitiesService.Instance ();
		}

		public Task FetchEntitiesAsync(double latitude, double longitude, int noOfRecords)
		{
			return Task.Factory.StartNew(()=>EntitiesService.QueueServiceRequest (latitude, longitude, noOfRecords));
		}

		public Task FetchEntitiesClosestToLocationAsync (double latitude, double longitude)
		{
			return Task.Factory.StartNew(()=>EntitiesService.QueueServiceRequestForClosestLocations (latitude, longitude));
		}

		public void Deregister (CacheChangeListener listener)
		{
			EntitiesService.Deregister (listener);
		}

		public void Register (CacheChangeListener listener)
		{
			EntitiesService.Register (listener);
		}

		public List<BankEntity> Fetch (IViewportFilter viewportFilter, Options userSelection)
		{
			return EntitiesService.Fetch (viewportFilter, userSelection);
		}

		public IconType IconForCurrentZoomLevel
		{
			get {
				foreach (var zoomPair in ZoomPairs) {
					if (ZoomLevel >= zoomPair.ZoomLevel) {
						return zoomPair.Icon;
					}
				}

				return IconType.None;
			}
		}

		public BankEntity ClosestEntity (Options userSelection)
		{
			return EntitiesService.ClosestEntity (userSelection);
		}

	}
}

