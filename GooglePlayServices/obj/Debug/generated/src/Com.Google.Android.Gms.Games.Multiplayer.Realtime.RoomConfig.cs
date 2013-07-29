using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']"
	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RoomConfig", DoNotGenerateAcw=true)]
	public sealed partial class RoomConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']"
		[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_addPlayersToInvite_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='addPlayersToInvite' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("addPlayersToInvite", "([Ljava/lang/String;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder AddPlayersToInvite (params  string[] p0)
			{
				if (id_addPlayersToInvite_arrayLjava_lang_String_ == IntPtr.Zero)
					id_addPlayersToInvite_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPlayersToInvite", "([Ljava/lang/String;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addPlayersToInvite_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_addPlayersToInvite_Ljava_util_ArrayList_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='addPlayersToInvite' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
			[Register ("addPlayersToInvite", "(Ljava/util/ArrayList;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder AddPlayersToInvite (global::System.Collections.Generic.IList<string> p0)
			{
				if (id_addPlayersToInvite_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_addPlayersToInvite_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "addPlayersToInvite", "(Ljava/util/ArrayList;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addPlayersToInvite_Ljava_util_ArrayList_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setAutoMatchCriteria_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='setAutoMatchCriteria' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setAutoMatchCriteria", "(Landroid/os/Bundle;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder SetAutoMatchCriteria (global::Android.OS.Bundle p0)
			{
				if (id_setAutoMatchCriteria_Landroid_os_Bundle_ == IntPtr.Zero)
					id_setAutoMatchCriteria_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setAutoMatchCriteria", "(Landroid/os/Bundle;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAutoMatchCriteria_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setInvitationIdToAccept_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='setInvitationIdToAccept' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInvitationIdToAccept", "(Ljava/lang/String;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder SetInvitationIdToAccept (string p0)
			{
				if (id_setInvitationIdToAccept_Ljava_lang_String_ == IntPtr.Zero)
					id_setInvitationIdToAccept_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInvitationIdToAccept", "(Ljava/lang/String;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setInvitationIdToAccept_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setMessageReceivedListener_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessageReceivedListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='setMessageReceivedListener' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.RealTimeMessageReceivedListener']]"
			[Register ("setMessageReceivedListener", "(Lcom/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListener;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder SetMessageReceivedListener (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeMessageReceivedListener p0)
			{
				if (id_setMessageReceivedListener_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessageReceivedListener_ == IntPtr.Zero)
					id_setMessageReceivedListener_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessageReceivedListener_ = JNIEnv.GetMethodID (class_ref, "setMessageReceivedListener", "(Lcom/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListener;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessageReceivedListener_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessageReceivedListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setRoomStatusUpdateListener_Lcom_google_android_gms_games_multiplayer_realtime_RoomStatusUpdateListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='setRoomStatusUpdateListener' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.RoomStatusUpdateListener']]"
			[Register ("setRoomStatusUpdateListener", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListener;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder SetRoomStatusUpdateListener (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener p0)
			{
				if (id_setRoomStatusUpdateListener_Lcom_google_android_gms_games_multiplayer_realtime_RoomStatusUpdateListener_ == IntPtr.Zero)
					id_setRoomStatusUpdateListener_Lcom_google_android_gms_games_multiplayer_realtime_RoomStatusUpdateListener_ = JNIEnv.GetMethodID (class_ref, "setRoomStatusUpdateListener", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListener;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRoomStatusUpdateListener_Lcom_google_android_gms_games_multiplayer_realtime_RoomStatusUpdateListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setSocketCommunicationEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='setSocketCommunicationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSocketCommunicationEnabled", "(Z)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder SetSocketCommunicationEnabled (bool p0)
			{
				if (id_setSocketCommunicationEnabled_Z == IntPtr.Zero)
					id_setSocketCommunicationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSocketCommunicationEnabled", "(Z)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setSocketCommunicationEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setVariant_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig.Builder']/method[@name='setVariant' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVariant", "(I)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
			public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder SetVariant (int p0)
			{
				if (id_setVariant_I == IntPtr.Zero)
					id_setVariant_I = JNIEnv.GetMethodID (class_ref, "setVariant", "(I)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setVariant_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RoomConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoomConfig); }
		}

		internal RoomConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAutoMatchCriteria;
		public global::Android.OS.Bundle AutoMatchCriteria {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='getAutoMatchCriteria' and count(parameter)=0]"
			[Register ("getAutoMatchCriteria", "()Landroid/os/Bundle;", "GetGetAutoMatchCriteriaHandler")]
			get {
				if (id_getAutoMatchCriteria == IntPtr.Zero)
					id_getAutoMatchCriteria = JNIEnv.GetMethodID (class_ref, "getAutoMatchCriteria", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getAutoMatchCriteria), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInvitationId;
		public string InvitationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='getInvitationId' and count(parameter)=0]"
			[Register ("getInvitationId", "()Ljava/lang/String;", "GetGetInvitationIdHandler")]
			get {
				if (id_getInvitationId == IntPtr.Zero)
					id_getInvitationId = JNIEnv.GetMethodID (class_ref, "getInvitationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInvitationId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isSocketEnabled;
		public bool IsSocketEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='isSocketEnabled' and count(parameter)=0]"
			[Register ("isSocketEnabled", "()Z", "GetIsSocketEnabledHandler")]
			get {
				if (id_isSocketEnabled == IntPtr.Zero)
					id_isSocketEnabled = JNIEnv.GetMethodID (class_ref, "isSocketEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isSocketEnabled);
			}
		}

		static IntPtr id_getMessageReceivedListener;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeMessageReceivedListener MessageReceivedListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='getMessageReceivedListener' and count(parameter)=0]"
			[Register ("getMessageReceivedListener", "()Lcom/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListener;", "GetGetMessageReceivedListenerHandler")]
			get {
				if (id_getMessageReceivedListener == IntPtr.Zero)
					id_getMessageReceivedListener = JNIEnv.GetMethodID (class_ref, "getMessageReceivedListener", "()Lcom/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListener;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeMessageReceivedListener> (JNIEnv.CallObjectMethod  (Handle, id_getMessageReceivedListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRoomStatusUpdateListener;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener RoomStatusUpdateListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='getRoomStatusUpdateListener' and count(parameter)=0]"
			[Register ("getRoomStatusUpdateListener", "()Lcom/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListener;", "GetGetRoomStatusUpdateListenerHandler")]
			get {
				if (id_getRoomStatusUpdateListener == IntPtr.Zero)
					id_getRoomStatusUpdateListener = JNIEnv.GetMethodID (class_ref, "getRoomStatusUpdateListener", "()Lcom/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListener;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (JNIEnv.CallObjectMethod  (Handle, id_getRoomStatusUpdateListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRoomUpdateListener;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener RoomUpdateListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='getRoomUpdateListener' and count(parameter)=0]"
			[Register ("getRoomUpdateListener", "()Lcom/google/android/gms/games/multiplayer/realtime/RoomUpdateListener;", "GetGetRoomUpdateListenerHandler")]
			get {
				if (id_getRoomUpdateListener == IntPtr.Zero)
					id_getRoomUpdateListener = JNIEnv.GetMethodID (class_ref, "getRoomUpdateListener", "()Lcom/google/android/gms/games/multiplayer/realtime/RoomUpdateListener;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener> (JNIEnv.CallObjectMethod  (Handle, id_getRoomUpdateListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getVariant;
		public int Variant {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='getVariant' and count(parameter)=0]"
			[Register ("getVariant", "()I", "GetGetVariantHandler")]
			get {
				if (id_getVariant == IntPtr.Zero)
					id_getVariant = JNIEnv.GetMethodID (class_ref, "getVariant", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getVariant);
			}
		}

		static IntPtr id_builder_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.RoomUpdateListener']]"
		[Register ("builder", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomUpdateListener;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;", "")]
		public static global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder InvokeBuilder (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener p0)
		{
			if (id_builder_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_ == IntPtr.Zero)
				id_builder_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_ = JNIEnv.GetStaticMethodID (class_ref, "builder", "(Lcom/google/android/gms/games/multiplayer/realtime/RoomUpdateListener;)Lcom/google/android/gms/games/multiplayer/realtime/RoomConfig$Builder;");
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RoomConfig.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder_Lcom_google_android_gms_games_multiplayer_realtime_RoomUpdateListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createAutoMatchCriteria_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='createAutoMatchCriteria' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("createAutoMatchCriteria", "(IIJ)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle CreateAutoMatchCriteria (int p0, int p1, long p2)
		{
			if (id_createAutoMatchCriteria_IIJ == IntPtr.Zero)
				id_createAutoMatchCriteria_IIJ = JNIEnv.GetStaticMethodID (class_ref, "createAutoMatchCriteria", "(IIJ)Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createAutoMatchCriteria_IIJ, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getInvitedPlayerIds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/class[@name='RoomConfig']/method[@name='getInvitedPlayerIds' and count(parameter)=0]"
		[Register ("getInvitedPlayerIds", "()[Ljava/lang/String;", "")]
		public string[] GetInvitedPlayerIds ()
		{
			if (id_getInvitedPlayerIds == IntPtr.Zero)
				id_getInvitedPlayerIds = JNIEnv.GetMethodID (class_ref, "getInvitedPlayerIds", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getInvitedPlayerIds), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

	}
}
