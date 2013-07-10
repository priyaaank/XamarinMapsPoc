using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/android/gms/appstate",
						"com/google/android/gms/auth",
						"com/google/android/gms/common",
						"com/google/android/gms/common/data",
						"com/google/android/gms/common/images",
						"com/google/android/gms/games",
						"com/google/android/gms/games/achievement",
						"com/google/android/gms/games/leaderboard",
						"com/google/android/gms/games/multiplayer",
						"com/google/android/gms/gcm",
						"com/google/android/gms/location",
						"com/google/android/gms/maps",
						"com/google/android/gms/maps/model",
						"com/google/android/gms/panorama",
						"com/google/android/gms/plus",
						"com/google/android/gms/plus/model/moments",
						"com/google/android/gms/plus/model/people",
					},
					new Converter<string, Type>[]{
						lookup_com_google_android_gms_appstate_package,
						lookup_com_google_android_gms_auth_package,
						lookup_com_google_android_gms_common_package,
						lookup_com_google_android_gms_common_data_package,
						lookup_com_google_android_gms_common_images_package,
						lookup_com_google_android_gms_games_package,
						lookup_com_google_android_gms_games_achievement_package,
						lookup_com_google_android_gms_games_leaderboard_package,
						lookup_com_google_android_gms_games_multiplayer_package,
						lookup_com_google_android_gms_gcm_package,
						lookup_com_google_android_gms_location_package,
						lookup_com_google_android_gms_maps_package,
						lookup_com_google_android_gms_maps_model_package,
						lookup_com_google_android_gms_panorama_package,
						lookup_com_google_android_gms_plus_package,
						lookup_com_google_android_gms_plus_model_moments_package,
						lookup_com_google_android_gms_plus_model_people_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_android_gms_appstate_mappings;
		static Type lookup_com_google_android_gms_appstate_package (string klass)
		{
			if (package_com_google_android_gms_appstate_mappings == null) {
				package_com_google_android_gms_appstate_mappings = new string[]{
					"com/google/android/gms/appstate/AppStateBuffer:Android.Gms.AppStates.AppStateBuffer",
					"com/google/android/gms/appstate/AppStateClient:Android.Gms.AppStates.AppStateClient",
					"com/google/android/gms/appstate/AppStateClient$Builder:Android.Gms.AppStates.AppStateClient/Builder",
				};
			}

			return Lookup (package_com_google_android_gms_appstate_mappings, klass);
		}

		static string[] package_com_google_android_gms_auth_mappings;
		static Type lookup_com_google_android_gms_auth_package (string klass)
		{
			if (package_com_google_android_gms_auth_mappings == null) {
				package_com_google_android_gms_auth_mappings = new string[]{
					"com/google/android/gms/auth/GoogleAuthException:Android.Gms.Auth.GoogleAuthException",
					"com/google/android/gms/auth/GoogleAuthUtil:Android.Gms.Auth.GoogleAuthUtil",
					"com/google/android/gms/auth/GooglePlayServicesAvailabilityException:Android.Gms.Auth.GooglePlayServicesAvailabilityException",
					"com/google/android/gms/auth/UserRecoverableAuthException:Android.Gms.Auth.UserRecoverableAuthException",
					"com/google/android/gms/auth/UserRecoverableNotifiedException:Android.Gms.Auth.UserRecoverableNotifiedException",
				};
			}

			return Lookup (package_com_google_android_gms_auth_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_mappings;
		static Type lookup_com_google_android_gms_common_package (string klass)
		{
			if (package_com_google_android_gms_common_mappings == null) {
				package_com_google_android_gms_common_mappings = new string[]{
					"com/google/android/gms/common/AccountPicker:Android.Gms.Common.AccountPicker",
					"com/google/android/gms/common/ConnectionResult:Android.Gms.Common.ConnectionResult",
					"com/google/android/gms/common/GooglePlayServicesNotAvailableException:Android.Gms.Common.GooglePlayServicesNotAvailableException",
					"com/google/android/gms/common/GooglePlayServicesUtil:Android.Gms.Common.GooglePlayServicesUtil",
					"com/google/android/gms/common/Scopes:Android.Gms.Common.Scopes",
					"com/google/android/gms/common/SignInButton:Android.Gms.Common.SignInButton",
				};
			}

			return Lookup (package_com_google_android_gms_common_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_data_mappings;
		static Type lookup_com_google_android_gms_common_data_package (string klass)
		{
			if (package_com_google_android_gms_common_data_mappings == null) {
				package_com_google_android_gms_common_data_mappings = new string[]{
					"com/google/android/gms/common/data/DataBuffer:Android.Gms.Common.Data.DataBuffer",
					"com/google/android/gms/common/data/DataBufferUtils:Android.Gms.Common.Data.DataBufferUtils",
				};
			}

			return Lookup (package_com_google_android_gms_common_data_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_images_mappings;
		static Type lookup_com_google_android_gms_common_images_package (string klass)
		{
			if (package_com_google_android_gms_common_images_mappings == null) {
				package_com_google_android_gms_common_images_mappings = new string[]{
					"com/google/android/gms/common/images/ImageManager:Android.Gms.Common.Images.ImageManager",
					"com/google/android/gms/common/images/ImageManager$ImageReceiver:Android.Gms.Common.Images.ImageManager/ImageReceiver",
					"com/google/android/gms/common/images/ImageManager$ListenerHolder:Android.Gms.Common.Images.ImageManager/ListenerHolder",
				};
			}

			return Lookup (package_com_google_android_gms_common_images_mappings, klass);
		}

		static string[] package_com_google_android_gms_games_mappings;
		static Type lookup_com_google_android_gms_games_package (string klass)
		{
			if (package_com_google_android_gms_games_mappings == null) {
				package_com_google_android_gms_games_mappings = new string[]{
					"com/google/android/gms/games/GameBuffer:Android.Gms.Games.GameBuffer",
					"com/google/android/gms/games/GameEntity:Android.Gms.Games.GameEntity",
					"com/google/android/gms/games/GamesActivityResultCodes:Android.Gms.Games.GamesActivityResultCodes",
					"com/google/android/gms/games/GamesClient:Android.Gms.Games.GamesClient",
					"com/google/android/gms/games/GamesClient$Builder:Android.Gms.Games.GamesClient/Builder",
					"com/google/android/gms/games/GamesClientSettings:Android.Gms.Games.GamesClientSettings",
					"com/google/android/gms/games/PageDirection:Android.Gms.Games.PageDirection",
					"com/google/android/gms/games/PlayerBuffer:Android.Gms.Games.PlayerBuffer",
					"com/google/android/gms/games/PlayerEntity:Android.Gms.Games.PlayerEntity",
				};
			}

			return Lookup (package_com_google_android_gms_games_mappings, klass);
		}

		static string[] package_com_google_android_gms_games_achievement_mappings;
		static Type lookup_com_google_android_gms_games_achievement_package (string klass)
		{
			if (package_com_google_android_gms_games_achievement_mappings == null) {
				package_com_google_android_gms_games_achievement_mappings = new string[]{
					"com/google/android/gms/games/achievement/AchievementBuffer:Android.Gms.Games.Achievement.AchievementBuffer",
				};
			}

			return Lookup (package_com_google_android_gms_games_achievement_mappings, klass);
		}

		static string[] package_com_google_android_gms_games_leaderboard_mappings;
		static Type lookup_com_google_android_gms_games_leaderboard_package (string klass)
		{
			if (package_com_google_android_gms_games_leaderboard_mappings == null) {
				package_com_google_android_gms_games_leaderboard_mappings = new string[]{
					"com/google/android/gms/games/leaderboard/LeaderboardScoreBuffer:Android.Gms.Games.LeaderBoard.LeaderboardScoreBuffer",
					"com/google/android/gms/games/leaderboard/SubmitScoreResult:Android.Gms.Games.LeaderBoard.SubmitScoreResult",
					"com/google/android/gms/games/leaderboard/SubmitScoreResult$Result:Android.Gms.Games.LeaderBoard.SubmitScoreResult/Result",
				};
			}

			return Lookup (package_com_google_android_gms_games_leaderboard_mappings, klass);
		}

		static string[] package_com_google_android_gms_games_multiplayer_mappings;
		static Type lookup_com_google_android_gms_games_multiplayer_package (string klass)
		{
			if (package_com_google_android_gms_games_multiplayer_mappings == null) {
				package_com_google_android_gms_games_multiplayer_mappings = new string[]{
					"com/google/android/gms/games/multiplayer/InvitationEntity:Android.Gms.Games.MultiPlayer.InvitationEntity",
					"com/google/android/gms/games/multiplayer/ParticipantBuffer:Android.Gms.Games.MultiPlayer.ParticipantBuffer",
					"com/google/android/gms/games/multiplayer/ParticipantEntity:Android.Gms.Games.MultiPlayer.ParticipantEntity",
					"com/google/android/gms/games/multiplayer/ParticipantUtils:Android.Gms.Games.MultiPlayer.ParticipantUtils",
				};
			}

			return Lookup (package_com_google_android_gms_games_multiplayer_mappings, klass);
		}

		static string[] package_com_google_android_gms_gcm_mappings;
		static Type lookup_com_google_android_gms_gcm_package (string klass)
		{
			if (package_com_google_android_gms_gcm_mappings == null) {
				package_com_google_android_gms_gcm_mappings = new string[]{
					"com/google/android/gms/gcm/GoogleCloudMessaging:Android.Gms.Gcm.GoogleCloudMessaging",
				};
			}

			return Lookup (package_com_google_android_gms_gcm_mappings, klass);
		}

		static string[] package_com_google_android_gms_location_mappings;
		static Type lookup_com_google_android_gms_location_package (string klass)
		{
			if (package_com_google_android_gms_location_mappings == null) {
				package_com_google_android_gms_location_mappings = new string[]{
					"com/google/android/gms/location/ActivityRecognitionClient:Android.Gms.Location.ActivityRecognitionClient",
					"com/google/android/gms/location/ActivityRecognitionResult:Android.Gms.Location.ActivityRecognitionResult",
					"com/google/android/gms/location/ActivityRecognitionResultCreator:Android.Gms.Location.ActivityRecognitionResultCreator",
					"com/google/android/gms/location/DetectedActivity:Android.Gms.Location.DetectedActivity",
					"com/google/android/gms/location/DetectedActivityCreator:Android.Gms.Location.DetectedActivityCreator",
					"com/google/android/gms/location/Geofence$Builder:Android.Gms.Location.GeofenceBuilder",
					"com/google/android/gms/location/LocationClient:Android.Gms.Location.LocationClient",
					"com/google/android/gms/location/LocationRequest:Android.Gms.Location.LocationRequest",
					"com/google/android/gms/location/LocationRequestCreator:Android.Gms.Location.LocationRequestCreator",
					"com/google/android/gms/location/LocationStatusCodes:Android.Gms.Location.LocationStatusCodes",
				};
			}

			return Lookup (package_com_google_android_gms_location_mappings, klass);
		}

		static string[] package_com_google_android_gms_maps_mappings;
		static Type lookup_com_google_android_gms_maps_package (string klass)
		{
			if (package_com_google_android_gms_maps_mappings == null) {
				package_com_google_android_gms_maps_mappings = new string[]{
					"com/google/android/gms/maps/CameraUpdate:Android.Gms.Maps.CameraUpdate",
					"com/google/android/gms/maps/CameraUpdateFactory:Android.Gms.Maps.CameraUpdateFactory",
					"com/google/android/gms/maps/GoogleMap:Android.Gms.Maps.GoogleMap",
					"com/google/android/gms/maps/GoogleMapOptions:Android.Gms.Maps.GoogleMapOptions",
					"com/google/android/gms/maps/MapsInitializer:Android.Gms.Maps.MapsInitializer",
					"com/google/android/gms/maps/MapView:Android.Gms.Maps.MapView",
					"com/google/android/gms/maps/Projection:Android.Gms.Maps.Projection",
					"com/google/android/gms/maps/SupportMapFragment:Android.Gms.Maps.SupportMapFragment",
					"com/google/android/gms/maps/UiSettings:Android.Gms.Maps.UiSettings",
				};
			}

			return Lookup (package_com_google_android_gms_maps_mappings, klass);
		}

		static string[] package_com_google_android_gms_maps_model_mappings;
		static Type lookup_com_google_android_gms_maps_model_package (string klass)
		{
			if (package_com_google_android_gms_maps_model_mappings == null) {
				package_com_google_android_gms_maps_model_mappings = new string[]{
					"com/google/android/gms/maps/model/BitmapDescriptor:Android.Gms.Maps.Model.BitmapDescriptor",
					"com/google/android/gms/maps/model/BitmapDescriptorFactory:Android.Gms.Maps.Model.BitmapDescriptorFactory",
					"com/google/android/gms/maps/model/CameraPosition:Android.Gms.Maps.Model.CameraPosition",
					"com/google/android/gms/maps/model/CameraPosition$Builder:Android.Gms.Maps.Model.CameraPosition/Builder",
					"com/google/android/gms/maps/model/Circle:Android.Gms.Maps.Model.Circle",
					"com/google/android/gms/maps/model/CircleOptions:Android.Gms.Maps.Model.CircleOptions",
					"com/google/android/gms/maps/model/GroundOverlay:Android.Gms.Maps.Model.GroundOverlay",
					"com/google/android/gms/maps/model/GroundOverlayOptions:Android.Gms.Maps.Model.GroundOverlayOptions",
					"com/google/android/gms/maps/model/LatLng:Android.Gms.Maps.Model.LatLng",
					"com/google/android/gms/maps/model/LatLngBounds:Android.Gms.Maps.Model.LatLngBounds",
					"com/google/android/gms/maps/model/LatLngBounds$Builder:Android.Gms.Maps.Model.LatLngBounds/Builder",
					"com/google/android/gms/maps/model/Marker:Android.Gms.Maps.Model.Marker",
					"com/google/android/gms/maps/model/MarkerOptions:Android.Gms.Maps.Model.MarkerOptions",
					"com/google/android/gms/maps/model/Polygon:Android.Gms.Maps.Model.Polygon",
					"com/google/android/gms/maps/model/PolygonOptions:Android.Gms.Maps.Model.PolygonOptions",
					"com/google/android/gms/maps/model/Polyline:Android.Gms.Maps.Model.Polyline",
					"com/google/android/gms/maps/model/PolylineOptions:Android.Gms.Maps.Model.PolylineOptions",
					"com/google/android/gms/maps/model/RuntimeRemoteException:Android.Gms.Maps.Model.RuntimeRemoteException",
					"com/google/android/gms/maps/model/Tile:Android.Gms.Maps.Model.Tile",
					"com/google/android/gms/maps/model/TileOverlay:Android.Gms.Maps.Model.TileOverlay",
					"com/google/android/gms/maps/model/TileOverlayOptions:Android.Gms.Maps.Model.TileOverlayOptions",
					"com/google/android/gms/maps/model/UrlTileProvider:Android.Gms.Maps.Model.UrlTileProvider",
					"com/google/android/gms/maps/model/VisibleRegion:Android.Gms.Maps.Model.VisibleRegion",
				};
			}

			return Lookup (package_com_google_android_gms_maps_model_mappings, klass);
		}

		static string[] package_com_google_android_gms_panorama_mappings;
		static Type lookup_com_google_android_gms_panorama_package (string klass)
		{
			if (package_com_google_android_gms_panorama_mappings == null) {
				package_com_google_android_gms_panorama_mappings = new string[]{
					"com/google/android/gms/panorama/PanoramaClient:Android.Gms.Panorama.PanoramaClient",
				};
			}

			return Lookup (package_com_google_android_gms_panorama_mappings, klass);
		}

		static string[] package_com_google_android_gms_plus_mappings;
		static Type lookup_com_google_android_gms_plus_package (string klass)
		{
			if (package_com_google_android_gms_plus_mappings == null) {
				package_com_google_android_gms_plus_mappings = new string[]{
					"com/google/android/gms/plus/GooglePlusUtil:Android.Gms.Plus.GooglePlusUtil",
					"com/google/android/gms/plus/PlusClient:Android.Gms.Plus.PlusClient",
					"com/google/android/gms/plus/PlusClient$Builder:Android.Gms.Plus.PlusClient/Builder",
					"com/google/android/gms/plus/PlusOneButton:Android.Gms.Plus.PlusOneButton",
					"com/google/android/gms/plus/PlusShare:Android.Gms.Plus.PlusShare",
					"com/google/android/gms/plus/PlusShare$Builder:Android.Gms.Plus.PlusShare/Builder",
				};
			}

			return Lookup (package_com_google_android_gms_plus_mappings, klass);
		}

		static string[] package_com_google_android_gms_plus_model_moments_mappings;
		static Type lookup_com_google_android_gms_plus_model_moments_package (string klass)
		{
			if (package_com_google_android_gms_plus_model_moments_mappings == null) {
				package_com_google_android_gms_plus_model_moments_mappings = new string[]{
					"com/google/android/gms/plus/model/moments/ItemScope$Builder:Android.Gms.Plus.Model.Moments.ItemScopeBuilder",
					"com/google/android/gms/plus/model/moments/Moment$Builder:Android.Gms.Plus.Model.Moments.MomentBuilder",
					"com/google/android/gms/plus/model/moments/MomentBuffer:Android.Gms.Plus.Model.Moments.MomentBuffer",
				};
			}

			return Lookup (package_com_google_android_gms_plus_model_moments_mappings, klass);
		}

		static string[] package_com_google_android_gms_plus_model_people_mappings;
		static Type lookup_com_google_android_gms_plus_model_people_package (string klass)
		{
			if (package_com_google_android_gms_plus_model_people_mappings == null) {
				package_com_google_android_gms_plus_model_people_mappings = new string[]{
					"com/google/android/gms/plus/model/people/Person$Cover$Layout:Android.Gms.Plus.Model.People.PersonCoverLayout",
					"com/google/android/gms/plus/model/people/Person$Emails$Type:Android.Gms.Plus.Model.People.PersonEmailsType",
					"com/google/android/gms/plus/model/people/Person$Gender:Android.Gms.Plus.Model.People.PersonGender",
					"com/google/android/gms/plus/model/people/Person$ObjectType:Android.Gms.Plus.Model.People.PersonObjectType",
					"com/google/android/gms/plus/model/people/Person$Organizations$Type:Android.Gms.Plus.Model.People.PersonOrganizationsType",
					"com/google/android/gms/plus/model/people/Person$RelationshipStatus:Android.Gms.Plus.Model.People.PersonRelationshipStatus",
					"com/google/android/gms/plus/model/people/Person$Urls$Type:Android.Gms.Plus.Model.People.PersonUrlsType",
					"com/google/android/gms/plus/model/people/PersonBuffer:Android.Gms.Plus.Model.People.PersonBuffer",
				};
			}

			return Lookup (package_com_google_android_gms_plus_model_people_mappings, klass);
		}
	}
}
