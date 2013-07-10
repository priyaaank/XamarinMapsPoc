using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[global::Android.Runtime.Register ("com/google/android/gms/games/GamesClient", DoNotGenerateAcw=true)]
	public sealed partial class GamesClient : global::Java.Lang.Object, global::Android.Gms.Common.IGooglePlayServicesClient {


		[Register ("EXTRA_EXCLUSIVE_BIT_MASK")]
		public const string ExtraExclusiveBitMask = (string) "exclusive_bit_mask";

		[Register ("EXTRA_INVITATION")]
		public const string ExtraInvitation = (string) "invitation";

		[Register ("EXTRA_MAX_AUTOMATCH_PLAYERS")]
		public const string ExtraMaxAutomatchPlayers = (string) "max_automatch_players";

		[Register ("EXTRA_MIN_AUTOMATCH_PLAYERS")]
		public const string ExtraMinAutomatchPlayers = (string) "min_automatch_players";

		[Register ("EXTRA_PLAYERS")]
		public const string ExtraPlayers = (string) "players";

		[Register ("EXTRA_ROOM")]
		public const string ExtraRoom = (string) "room";

		[Register ("MAX_RELIABLE_MESSAGE_LEN")]
		public const int MaxReliableMessageLen = (int) 1400;

		[Register ("MAX_UNRELIABLE_MESSAGE_LEN")]
		public const int MaxUnreliableMessageLen = (int) 1168;

		[Register ("NOTIFICATION_TYPES_ALL")]
		public const int NotificationTypesAll = (int) -1;

		[Register ("NOTIFICATION_TYPES_MULTIPLAYER")]
		public const int NotificationTypesMultiplayer = (int) 1;

		[Register ("NOTIFICATION_TYPE_INVITATION")]
		public const int NotificationTypeInvitation = (int) 1;

		[Register ("STATUS_ACHIEVEMENT_NOT_INCREMENTAL")]
		public const int StatusAchievementNotIncremental = (int) 3002;

		[Register ("STATUS_ACHIEVEMENT_UNKNOWN")]
		public const int StatusAchievementUnknown = (int) 3001;

		[Register ("STATUS_ACHIEVEMENT_UNLOCKED")]
		public const int StatusAchievementUnlocked = (int) 3003;

		[Register ("STATUS_ACHIEVEMENT_UNLOCK_FAILURE")]
		public const int StatusAchievementUnlockFailure = (int) 3000;

		[Register ("STATUS_CLIENT_RECONNECT_REQUIRED")]
		public const int StatusClientReconnectRequired = (int) 2;

		[Register ("STATUS_INTERNAL_ERROR")]
		public const int StatusInternalError = (int) 1;

		[Register ("STATUS_INVALID_REAL_TIME_ROOM_ID")]
		public const int StatusInvalidRealTimeRoomId = (int) 7002;

		[Register ("STATUS_LICENSE_CHECK_FAILED")]
		public const int StatusLicenseCheckFailed = (int) 7;

		[Register ("STATUS_MULTIPLAYER_ERROR_CREATION_NOT_ALLOWED")]
		public const int StatusMultiplayerErrorCreationNotAllowed = (int) 6000;

		[Register ("STATUS_MULTIPLAYER_ERROR_NOT_TRUSTED_TESTER")]
		public const int StatusMultiplayerErrorNotTrustedTester = (int) 6001;

		[Register ("STATUS_NETWORK_ERROR_NO_DATA")]
		public const int StatusNetworkErrorNoData = (int) 4;

		[Register ("STATUS_NETWORK_ERROR_OPERATION_DEFERRED")]
		public const int StatusNetworkErrorOperationDeferred = (int) 5;

		[Register ("STATUS_NETWORK_ERROR_OPERATION_FAILED")]
		public const int StatusNetworkErrorOperationFailed = (int) 6;

		[Register ("STATUS_NETWORK_ERROR_STALE_DATA")]
		public const int StatusNetworkErrorStaleData = (int) 3;

		[Register ("STATUS_OK")]
		public const int StatusOk = (int) 0;

		[Register ("STATUS_PARTICIPANT_NOT_CONNECTED")]
		public const int StatusParticipantNotConnected = (int) 7003;

		[Register ("STATUS_REAL_TIME_CONNECTION_FAILED")]
		public const int StatusRealTimeConnectionFailed = (int) 7000;

		[Register ("STATUS_REAL_TIME_INACTIVE_ROOM")]
		public const int StatusRealTimeInactiveRoom = (int) 7005;

		[Register ("STATUS_REAL_TIME_MESSAGE_FAILED")]
		public const int StatusRealTimeMessageFailed = (int) -1;

		[Register ("STATUS_REAL_TIME_MESSAGE_SEND_FAILED")]
		public const int StatusRealTimeMessageSendFailed = (int) 7001;

		[Register ("STATUS_REAL_TIME_ROOM_NOT_JOINED")]
		public const int StatusRealTimeRoomNotJoined = (int) 7004;
		[global::Android.Runtime.Register ("com/google/android/gms/games/GamesClient$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/games/GamesClient$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
			[Register (".ctor", "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
			public Builder (global::Android.Content.Context p0, global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p1, global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_create;
			[Register ("create", "()Lcom/google/android/gms/games/GamesClient;", "")]
			public global::Android.Gms.Games.GamesClient Create ()
			{
				if (id_create == IntPtr.Zero)
					id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/google/android/gms/games/GamesClient;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.GamesClient> (JNIEnv.CallObjectMethod  (Handle, id_create), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setAccountName_Ljava_lang_String_;
			[Register ("setAccountName", "(Ljava/lang/String;)Lcom/google/android/gms/games/GamesClient$Builder;", "")]
			public global::Android.Gms.Games.GamesClient.Builder SetAccountName (string p0)
			{
				if (id_setAccountName_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccountName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccountName", "(Ljava/lang/String;)Lcom/google/android/gms/games/GamesClient$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Android.Gms.Games.GamesClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.GamesClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAccountName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setGravityForPopups_I;
			[Register ("setGravityForPopups", "(I)Lcom/google/android/gms/games/GamesClient$Builder;", "")]
			public global::Android.Gms.Games.GamesClient.Builder SetGravityForPopups (int p0)
			{
				if (id_setGravityForPopups_I == IntPtr.Zero)
					id_setGravityForPopups_I = JNIEnv.GetMethodID (class_ref, "setGravityForPopups", "(I)Lcom/google/android/gms/games/GamesClient$Builder;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.GamesClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setGravityForPopups_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setScopes_arrayLjava_lang_String_;
			[Register ("setScopes", "([Ljava/lang/String;)Lcom/google/android/gms/games/GamesClient$Builder;", "")]
			public global::Android.Gms.Games.GamesClient.Builder SetScopes (params  string[] p0)
			{
				if (id_setScopes_arrayLjava_lang_String_ == IntPtr.Zero)
					id_setScopes_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScopes", "([Ljava/lang/String;)Lcom/google/android/gms/games/GamesClient$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Android.Gms.Games.GamesClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.GamesClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setScopes_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_setViewForPopups_Landroid_view_View_;
			[Register ("setViewForPopups", "(Landroid/view/View;)Lcom/google/android/gms/games/GamesClient$Builder;", "")]
			public global::Android.Gms.Games.GamesClient.Builder SetViewForPopups (global::Android.Views.View p0)
			{
				if (id_setViewForPopups_Landroid_view_View_ == IntPtr.Zero)
					id_setViewForPopups_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setViewForPopups", "(Landroid/view/View;)Lcom/google/android/gms/games/GamesClient$Builder;");
				global::Android.Gms.Games.GamesClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.GamesClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setViewForPopups_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/GamesClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GamesClient); }
		}

		internal GamesClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAchievementsIntent;
		public global::Android.Content.Intent AchievementsIntent {
			[Register ("getAchievementsIntent", "()Landroid/content/Intent;", "GetGetAchievementsIntentHandler")]
			get {
				if (id_getAchievementsIntent == IntPtr.Zero)
					id_getAchievementsIntent = JNIEnv.GetMethodID (class_ref, "getAchievementsIntent", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getAchievementsIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAllLeaderboardsIntent;
		public global::Android.Content.Intent AllLeaderboardsIntent {
			[Register ("getAllLeaderboardsIntent", "()Landroid/content/Intent;", "GetGetAllLeaderboardsIntentHandler")]
			get {
				if (id_getAllLeaderboardsIntent == IntPtr.Zero)
					id_getAllLeaderboardsIntent = JNIEnv.GetMethodID (class_ref, "getAllLeaderboardsIntent", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getAllLeaderboardsIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAppId;
		public string AppId {
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getCurrentAccountName;
		public string CurrentAccountName {
			[Register ("getCurrentAccountName", "()Ljava/lang/String;", "GetGetCurrentAccountNameHandler")]
			get {
				if (id_getCurrentAccountName == IntPtr.Zero)
					id_getCurrentAccountName = JNIEnv.GetMethodID (class_ref, "getCurrentAccountName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCurrentAccountName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getCurrentPlayer;
		public global::Android.Gms.Games.IPlayer CurrentPlayer {
			[Register ("getCurrentPlayer", "()Lcom/google/android/gms/games/Player;", "GetGetCurrentPlayerHandler")]
			get {
				if (id_getCurrentPlayer == IntPtr.Zero)
					id_getCurrentPlayer = JNIEnv.GetMethodID (class_ref, "getCurrentPlayer", "()Lcom/google/android/gms/games/Player;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentPlayer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getCurrentPlayerId;
		public string CurrentPlayerId {
			[Register ("getCurrentPlayerId", "()Ljava/lang/String;", "GetGetCurrentPlayerIdHandler")]
			get {
				if (id_getCurrentPlayerId == IntPtr.Zero)
					id_getCurrentPlayerId = JNIEnv.GetMethodID (class_ref, "getCurrentPlayerId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCurrentPlayerId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInvitationInboxIntent;
		public global::Android.Content.Intent InvitationInboxIntent {
			[Register ("getInvitationInboxIntent", "()Landroid/content/Intent;", "GetGetInvitationInboxIntentHandler")]
			get {
				if (id_getInvitationInboxIntent == IntPtr.Zero)
					id_getInvitationInboxIntent = JNIEnv.GetMethodID (class_ref, "getInvitationInboxIntent", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getInvitationInboxIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isConnected;
		public bool IsConnected {
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
			}
		}

		static IntPtr id_isConnecting;
		public bool IsConnecting {
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isConnecting);
			}
		}

		static IntPtr id_getSettingsIntent;
		public global::Android.Content.Intent SettingsIntent {
			[Register ("getSettingsIntent", "()Landroid/content/Intent;", "GetGetSettingsIntentHandler")]
			get {
				if (id_getSettingsIntent == IntPtr.Zero)
					id_getSettingsIntent = JNIEnv.GetMethodID (class_ref, "getSettingsIntent", "()Landroid/content/Intent;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getSettingsIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_clearAllNotifications;
		[Register ("clearAllNotifications", "()V", "")]
		public void ClearAllNotifications ()
		{
			if (id_clearAllNotifications == IntPtr.Zero)
				id_clearAllNotifications = JNIEnv.GetMethodID (class_ref, "clearAllNotifications", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clearAllNotifications);
		}

		static IntPtr id_clearNotifications_I;
		[Register ("clearNotifications", "(I)V", "")]
		public void ClearNotifications (int p0)
		{
			if (id_clearNotifications_I == IntPtr.Zero)
				id_clearNotifications_I = JNIEnv.GetMethodID (class_ref, "clearNotifications", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_clearNotifications_I, new JValue (p0));
		}

		static IntPtr id_connect;
		[Register ("connect", "()V", "")]
		public void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_connect);
		}

		static IntPtr id_createRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_;
		[Register ("createRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig;)V", "")]
		public void CreateRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig p0)
		{
			if (id_createRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_ == IntPtr.Zero)
				id_createRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_ = JNIEnv.GetMethodID (class_ref, "createRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig;)V");
			JNIEnv.CallVoidMethod  (Handle, id_createRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_, new JValue (p0));
		}

		static IntPtr id_declineRoomInvitation_Ljava_lang_String_;
		[Register ("declineRoomInvitation", "(Ljava/lang/String;)V", "")]
		public void DeclineRoomInvitation (string p0)
		{
			if (id_declineRoomInvitation_Ljava_lang_String_ == IntPtr.Zero)
				id_declineRoomInvitation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "declineRoomInvitation", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_declineRoomInvitation_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_disconnect;
		[Register ("disconnect", "()V", "")]
		public void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_disconnect);
		}

		static IntPtr id_dismissRoomInvitation_Ljava_lang_String_;
		[Register ("dismissRoomInvitation", "(Ljava/lang/String;)V", "")]
		public void DismissRoomInvitation (string p0)
		{
			if (id_dismissRoomInvitation_Ljava_lang_String_ == IntPtr.Zero)
				id_dismissRoomInvitation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dismissRoomInvitation", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_dismissRoomInvitation_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getLeaderboardIntent_Ljava_lang_String_;
		[Register ("getLeaderboardIntent", "(Ljava/lang/String;)Landroid/content/Intent;", "")]
		public global::Android.Content.Intent GetLeaderboardIntent (string p0)
		{
			if (id_getLeaderboardIntent_Ljava_lang_String_ == IntPtr.Zero)
				id_getLeaderboardIntent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLeaderboardIntent", "(Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboardIntent_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getRealTimeSocketForParticipant_Ljava_lang_String_Ljava_lang_String_;
		[Register ("getRealTimeSocketForParticipant", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/gms/games/RealTimeSocket;", "")]
		public global::Android.Gms.Games.IRealTimeSocket GetRealTimeSocketForParticipant (string p0, string p1)
		{
			if (id_getRealTimeSocketForParticipant_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getRealTimeSocketForParticipant_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRealTimeSocketForParticipant", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/gms/games/RealTimeSocket;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Gms.Games.IRealTimeSocket __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IRealTimeSocket> (JNIEnv.CallObjectMethod  (Handle, id_getRealTimeSocketForParticipant_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getRealTimeWaitingRoomIntent_Lcom_google_android_gms_games_multiplayer_realtime_Room_I;
		[Register ("getRealTimeWaitingRoomIntent", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;I)Landroid/content/Intent;", "")]
		public global::Android.Content.Intent GetRealTimeWaitingRoomIntent (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, int p1)
		{
			if (id_getRealTimeWaitingRoomIntent_Lcom_google_android_gms_games_multiplayer_realtime_Room_I == IntPtr.Zero)
				id_getRealTimeWaitingRoomIntent_Lcom_google_android_gms_games_multiplayer_realtime_Room_I = JNIEnv.GetMethodID (class_ref, "getRealTimeWaitingRoomIntent", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;I)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getRealTimeWaitingRoomIntent_Lcom_google_android_gms_games_multiplayer_realtime_Room_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getSelectPlayersIntent_II;
		[Register ("getSelectPlayersIntent", "(II)Landroid/content/Intent;", "")]
		public global::Android.Content.Intent GetSelectPlayersIntent (int p0, int p1)
		{
			if (id_getSelectPlayersIntent_II == IntPtr.Zero)
				id_getSelectPlayersIntent_II = JNIEnv.GetMethodID (class_ref, "getSelectPlayersIntent", "(II)Landroid/content/Intent;");
			return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getSelectPlayersIntent_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_incrementAchievement_Ljava_lang_String_I;
		[Register ("incrementAchievement", "(Ljava/lang/String;I)V", "")]
		public void IncrementAchievement (string p0, int p1)
		{
			if (id_incrementAchievement_Ljava_lang_String_I == IntPtr.Zero)
				id_incrementAchievement_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "incrementAchievement", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_incrementAchievement_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_incrementAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_I;
		[Register ("incrementAchievementImmediate", "(Lcom/google/android/gms/games/achievement/OnAchievementUpdatedListener;Ljava/lang/String;I)V", "")]
		public void IncrementAchievementImmediate (global::Android.Gms.Games.Achievement.IOnAchievementUpdatedListener p0, string p1, int p2)
		{
			if (id_incrementAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_I == IntPtr.Zero)
				id_incrementAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "incrementAchievementImmediate", "(Lcom/google/android/gms/games/achievement/OnAchievementUpdatedListener;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_incrementAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z", "")]
		public bool IsConnectionCallbacksRegistered (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z", "")]
		public bool IsConnectionFailedListenerRegistered (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_joinRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_;
		[Register ("joinRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig;)V", "")]
		public void JoinRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig p0)
		{
			if (id_joinRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_ == IntPtr.Zero)
				id_joinRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_ = JNIEnv.GetMethodID (class_ref, "joinRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig;)V");
			JNIEnv.CallVoidMethod  (Handle, id_joinRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomConfig_, new JValue (p0));
		}

		static IntPtr id_leaveRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_Ljava_lang_String_;
		[Register ("leaveRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomUpdateListener;Ljava/lang/String;)V", "")]
		public void LeaveRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener p0, string p1)
		{
			if (id_leaveRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_Ljava_lang_String_ == IntPtr.Zero)
				id_leaveRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "leaveRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomUpdateListener;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_leaveRoom_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_loadAchievements_Lcom_google_android_gms_games_achievement_OnAchievementsLoadedListener_;
		[Register ("loadAchievements", "(Lcom/google/android/gms/games/achievement/OnAchievementsLoadedListener;)V", "")]
		public void LoadAchievements (global::Android.Gms.Games.Achievement.IOnAchievementsLoadedListener p0)
		{
			if (id_loadAchievements_Lcom_google_android_gms_games_achievement_OnAchievementsLoadedListener_ == IntPtr.Zero)
				id_loadAchievements_Lcom_google_android_gms_games_achievement_OnAchievementsLoadedListener_ = JNIEnv.GetMethodID (class_ref, "loadAchievements", "(Lcom/google/android/gms/games/achievement/OnAchievementsLoadedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadAchievements_Lcom_google_android_gms_games_achievement_OnAchievementsLoadedListener_, new JValue (p0));
		}

		static IntPtr id_loadGame_Lcom_google_android_gms_games_OnGamesLoadedListener_;
		[Register ("loadGame", "(Lcom/google/android/gms/games/OnGamesLoadedListener;)V", "")]
		public void LoadGame (global::Android.Gms.Games.IOnGamesLoadedListener p0)
		{
			if (id_loadGame_Lcom_google_android_gms_games_OnGamesLoadedListener_ == IntPtr.Zero)
				id_loadGame_Lcom_google_android_gms_games_OnGamesLoadedListener_ = JNIEnv.GetMethodID (class_ref, "loadGame", "(Lcom/google/android/gms/games/OnGamesLoadedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadGame_Lcom_google_android_gms_games_OnGamesLoadedListener_, new JValue (p0));
		}

		static IntPtr id_loadInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_IZ;
		[Register ("loadInvitablePlayers", "(Lcom/google/android/gms/games/OnPlayersLoadedListener;IZ)V", "")]
		public void LoadInvitablePlayers (global::Android.Gms.Games.IOnPlayersLoadedListener p0, int p1, bool p2)
		{
			if (id_loadInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_IZ == IntPtr.Zero)
				id_loadInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_IZ = JNIEnv.GetMethodID (class_ref, "loadInvitablePlayers", "(Lcom/google/android/gms/games/OnPlayersLoadedListener;IZ)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_IZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_loadMoreInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_I;
		[Register ("loadMoreInvitablePlayers", "(Lcom/google/android/gms/games/OnPlayersLoadedListener;I)V", "")]
		public void LoadMoreInvitablePlayers (global::Android.Gms.Games.IOnPlayersLoadedListener p0, int p1)
		{
			if (id_loadMoreInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_I == IntPtr.Zero)
				id_loadMoreInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_I = JNIEnv.GetMethodID (class_ref, "loadMoreInvitablePlayers", "(Lcom/google/android/gms/games/OnPlayersLoadedListener;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadMoreInvitablePlayers_Lcom_google_android_gms_games_OnPlayersLoadedListener_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_loadPlayer_Lcom_google_android_gms_games_OnPlayersLoadedListener_Ljava_lang_String_;
		[Register ("loadPlayer", "(Lcom/google/android/gms/games/OnPlayersLoadedListener;Ljava/lang/String;)V", "")]
		public void LoadPlayer (global::Android.Gms.Games.IOnPlayersLoadedListener p0, string p1)
		{
			if (id_loadPlayer_Lcom_google_android_gms_games_OnPlayersLoadedListener_Ljava_lang_String_ == IntPtr.Zero)
				id_loadPlayer_Lcom_google_android_gms_games_OnPlayersLoadedListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadPlayer", "(Lcom/google/android/gms/games/OnPlayersLoadedListener;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_loadPlayer_Lcom_google_android_gms_games_OnPlayersLoadedListener_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_reconnect;
		[Register ("reconnect", "()V", "")]
		public void Reconnect ()
		{
			if (id_reconnect == IntPtr.Zero)
				id_reconnect = JNIEnv.GetMethodID (class_ref, "reconnect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_reconnect);
		}

		static IntPtr id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "")]
		public void RegisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");
			JNIEnv.CallVoidMethod  (Handle, id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
		}

		static IntPtr id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
		public void RegisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
		}

		static IntPtr id_registerInvitationListener_Lcom_google_android_gms_games_multiplayer_OnInvitationReceivedListener_;
		[Register ("registerInvitationListener", "(Lcom/google/android/gms/games/multiplayer/OnInvitationReceivedListener;)V", "")]
		public void RegisterInvitationListener (global::Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListener p0)
		{
			if (id_registerInvitationListener_Lcom_google_android_gms_games_multiplayer_OnInvitationReceivedListener_ == IntPtr.Zero)
				id_registerInvitationListener_Lcom_google_android_gms_games_multiplayer_OnInvitationReceivedListener_ = JNIEnv.GetMethodID (class_ref, "registerInvitationListener", "(Lcom/google/android/gms/games/multiplayer/OnInvitationReceivedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_registerInvitationListener_Lcom_google_android_gms_games_multiplayer_OnInvitationReceivedListener_, new JValue (p0));
		}

		static IntPtr id_revealAchievement_Ljava_lang_String_;
		[Register ("revealAchievement", "(Ljava/lang/String;)V", "")]
		public void RevealAchievement (string p0)
		{
			if (id_revealAchievement_Ljava_lang_String_ == IntPtr.Zero)
				id_revealAchievement_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "revealAchievement", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_revealAchievement_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_revealAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_;
		[Register ("revealAchievementImmediate", "(Lcom/google/android/gms/games/achievement/OnAchievementUpdatedListener;Ljava/lang/String;)V", "")]
		public void RevealAchievementImmediate (global::Android.Gms.Games.Achievement.IOnAchievementUpdatedListener p0, string p1)
		{
			if (id_revealAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_ == IntPtr.Zero)
				id_revealAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "revealAchievementImmediate", "(Lcom/google/android/gms/games/achievement/OnAchievementUpdatedListener;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_revealAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_sendReliableRealTimeMessage_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeReliableMessageSentListener_arrayBLjava_lang_String_Ljava_lang_String_;
		[Register ("sendReliableRealTimeMessage", "(Lcom/google/android/gms/games/multiplayer/realtime/RealTimeReliableMessageSentListener;[BLjava/lang/String;Ljava/lang/String;)I", "")]
		public int SendReliableRealTimeMessage (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListener p0, byte[] p1, string p2, string p3)
		{
			if (id_sendReliableRealTimeMessage_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeReliableMessageSentListener_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendReliableRealTimeMessage_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeReliableMessageSentListener_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendReliableRealTimeMessage", "(Lcom/google/android/gms/games/multiplayer/realtime/RealTimeReliableMessageSentListener;[BLjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_sendReliableRealTimeMessage_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeReliableMessageSentListener_arrayBLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_lang_String_;
		[Register ("sendUnreliableRealTimeMessage", "([BLjava/lang/String;Ljava/lang/String;)I", "")]
		public int SendUnreliableRealTimeMessage (byte[] p0, string p1, string p2)
		{
			if (id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendUnreliableRealTimeMessage", "([BLjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_util_List_;
		[Register ("sendUnreliableRealTimeMessage", "([BLjava/lang/String;Ljava/util/List;)I", "")]
		public int SendUnreliableRealTimeMessage (byte[] p0, string p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "sendUnreliableRealTimeMessage", "([BLjava/lang/String;Ljava/util/List;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_sendUnreliableRealTimeMessage_arrayBLjava_lang_String_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_sendUnreliableRealTimeMessageToAll_arrayBLjava_lang_String_;
		[Register ("sendUnreliableRealTimeMessageToAll", "([BLjava/lang/String;)I", "")]
		public int SendUnreliableRealTimeMessageToAll (byte[] p0, string p1)
		{
			if (id_sendUnreliableRealTimeMessageToAll_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_sendUnreliableRealTimeMessageToAll_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendUnreliableRealTimeMessageToAll", "([BLjava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_sendUnreliableRealTimeMessageToAll_arrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_setGravityForPopups_I;
		[Register ("setGravityForPopups", "(I)V", "")]
		public void SetGravityForPopups (int p0)
		{
			if (id_setGravityForPopups_I == IntPtr.Zero)
				id_setGravityForPopups_I = JNIEnv.GetMethodID (class_ref, "setGravityForPopups", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setGravityForPopups_I, new JValue (p0));
		}

		static IntPtr id_setUseNewPlayerNotificationsFirstParty_Z;
		[Register ("setUseNewPlayerNotificationsFirstParty", "(Z)V", "")]
		public void SetUseNewPlayerNotificationsFirstParty (bool p0)
		{
			if (id_setUseNewPlayerNotificationsFirstParty_Z == IntPtr.Zero)
				id_setUseNewPlayerNotificationsFirstParty_Z = JNIEnv.GetMethodID (class_ref, "setUseNewPlayerNotificationsFirstParty", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setUseNewPlayerNotificationsFirstParty_Z, new JValue (p0));
		}

		static IntPtr id_setViewForPopups_Landroid_view_View_;
		[Register ("setViewForPopups", "(Landroid/view/View;)V", "")]
		public void SetViewForPopups (global::Android.Views.View p0)
		{
			if (id_setViewForPopups_Landroid_view_View_ == IntPtr.Zero)
				id_setViewForPopups_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setViewForPopups", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setViewForPopups_Landroid_view_View_, new JValue (p0));
		}

		static IntPtr id_signOut;
		[Register ("signOut", "()V", "")]
		public void SignOut ()
		{
			if (id_signOut == IntPtr.Zero)
				id_signOut = JNIEnv.GetMethodID (class_ref, "signOut", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_signOut);
		}

		static IntPtr id_signOut_Lcom_google_android_gms_games_OnSignOutCompleteListener_;
		[Register ("signOut", "(Lcom/google/android/gms/games/OnSignOutCompleteListener;)V", "")]
		public void SignOut (global::Android.Gms.Games.IOnSignOutCompleteListener p0)
		{
			if (id_signOut_Lcom_google_android_gms_games_OnSignOutCompleteListener_ == IntPtr.Zero)
				id_signOut_Lcom_google_android_gms_games_OnSignOutCompleteListener_ = JNIEnv.GetMethodID (class_ref, "signOut", "(Lcom/google/android/gms/games/OnSignOutCompleteListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_signOut_Lcom_google_android_gms_games_OnSignOutCompleteListener_, new JValue (p0));
		}

		static IntPtr id_submitScore_Ljava_lang_String_J;
		[Register ("submitScore", "(Ljava/lang/String;J)V", "")]
		public void SubmitScore (string p0, long p1)
		{
			if (id_submitScore_Ljava_lang_String_J == IntPtr.Zero)
				id_submitScore_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "submitScore", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_submitScore_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_submitScoreImmediate_Lcom_google_android_gms_games_leaderboard_OnScoreSubmittedListener_Ljava_lang_String_J;
		[Register ("submitScoreImmediate", "(Lcom/google/android/gms/games/leaderboard/OnScoreSubmittedListener;Ljava/lang/String;J)V", "")]
		public void SubmitScoreImmediate (global::Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListener p0, string p1, long p2)
		{
			if (id_submitScoreImmediate_Lcom_google_android_gms_games_leaderboard_OnScoreSubmittedListener_Ljava_lang_String_J == IntPtr.Zero)
				id_submitScoreImmediate_Lcom_google_android_gms_games_leaderboard_OnScoreSubmittedListener_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "submitScoreImmediate", "(Lcom/google/android/gms/games/leaderboard/OnScoreSubmittedListener;Ljava/lang/String;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_submitScoreImmediate_Lcom_google_android_gms_games_leaderboard_OnScoreSubmittedListener_Ljava_lang_String_J, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_unlockAchievement_Ljava_lang_String_;
		[Register ("unlockAchievement", "(Ljava/lang/String;)V", "")]
		public void UnlockAchievement (string p0)
		{
			if (id_unlockAchievement_Ljava_lang_String_ == IntPtr.Zero)
				id_unlockAchievement_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unlockAchievement", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_unlockAchievement_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_unlockAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_;
		[Register ("unlockAchievementImmediate", "(Lcom/google/android/gms/games/achievement/OnAchievementUpdatedListener;Ljava/lang/String;)V", "")]
		public void UnlockAchievementImmediate (global::Android.Gms.Games.Achievement.IOnAchievementUpdatedListener p0, string p1)
		{
			if (id_unlockAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_ == IntPtr.Zero)
				id_unlockAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unlockAchievementImmediate", "(Lcom/google/android/gms/games/achievement/OnAchievementUpdatedListener;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_unlockAchievementImmediate_Lcom_google_android_gms_games_achievement_OnAchievementUpdatedListener_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "")]
		public void UnregisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
		}

		static IntPtr id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
		public void UnregisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
		}

		static IntPtr id_unregisterInvitationListener;
		[Register ("unregisterInvitationListener", "()V", "")]
		public void UnregisterInvitationListener ()
		{
			if (id_unregisterInvitationListener == IntPtr.Zero)
				id_unregisterInvitationListener = JNIEnv.GetMethodID (class_ref, "unregisterInvitationListener", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_unregisterInvitationListener);
		}

	}
}
