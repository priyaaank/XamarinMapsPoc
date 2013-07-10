using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.MultiPlayer {

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/ParticipantEntity", DoNotGenerateAcw=true)]
	public sealed partial class ParticipantEntity : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Android.Gms.Games.MultiPlayer.IParticipant {


		static IntPtr CREATOR_jfieldId;

		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.google.android.gms.games.multiplayer.Participant

			[Register ("STATUS_DECLINED")]
			public const int StatusDeclined = (int) 3;

			[Register ("STATUS_INVITED")]
			public const int StatusInvited = (int) 1;

			[Register ("STATUS_JOINED")]
			public const int StatusJoined = (int) 2;

			[Register ("STATUS_LEFT")]
			public const int StatusLeft = (int) 4;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/ParticipantEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParticipantEntity); }
		}

		internal ParticipantEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_games_multiplayer_Participant_;
		[Register (".ctor", "(Lcom/google/android/gms/games/multiplayer/Participant;)V", "")]
		public ParticipantEntity (global::Android.Gms.Games.MultiPlayer.IParticipant p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParticipantEntity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/games/multiplayer/Participant;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_games_multiplayer_Participant_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_games_multiplayer_Participant_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/games/multiplayer/Participant;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_games_multiplayer_Participant_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getClientAddress;
		public string ClientAddress {
			[Register ("getClientAddress", "()Ljava/lang/String;", "GetGetClientAddressHandler")]
			get {
				if (id_getClientAddress == IntPtr.Zero)
					id_getClientAddress = JNIEnv.GetMethodID (class_ref, "getClientAddress", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDisplayName;
		public string DisplayName {
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHiResImageUri;
		public global::Android.Net.Uri HiResImageUri {
			[Register ("getHiResImageUri", "()Landroid/net/Uri;", "GetGetHiResImageUriHandler")]
			get {
				if (id_getHiResImageUri == IntPtr.Zero)
					id_getHiResImageUri = JNIEnv.GetMethodID (class_ref, "getHiResImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getHiResImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getIconImageUri;
		public global::Android.Net.Uri IconImageUri {
			[Register ("getIconImageUri", "()Landroid/net/Uri;", "GetGetIconImageUriHandler")]
			get {
				if (id_getIconImageUri == IntPtr.Zero)
					id_getIconImageUri = JNIEnv.GetMethodID (class_ref, "getIconImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getIconImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isConnectedToRoom;
		public bool IsConnectedToRoom {
			[Register ("isConnectedToRoom", "()Z", "GetIsConnectedToRoomHandler")]
			get {
				if (id_isConnectedToRoom == IntPtr.Zero)
					id_isConnectedToRoom = JNIEnv.GetMethodID (class_ref, "isConnectedToRoom", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isConnectedToRoom);
			}
		}

		static IntPtr id_getParticipantId;
		public string ParticipantId {
			[Register ("getParticipantId", "()Ljava/lang/String;", "GetGetParticipantIdHandler")]
			get {
				if (id_getParticipantId == IntPtr.Zero)
					id_getParticipantId = JNIEnv.GetMethodID (class_ref, "getParticipantId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParticipantId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPlayer;
		public global::Android.Gms.Games.IPlayer Player {
			[Register ("getPlayer", "()Lcom/google/android/gms/games/Player;", "GetGetPlayerHandler")]
			get {
				if (id_getPlayer == IntPtr.Zero)
					id_getPlayer = JNIEnv.GetMethodID (class_ref, "getPlayer", "()Lcom/google/android/gms/games/Player;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (JNIEnv.CallObjectMethod  (Handle, id_getPlayer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStatus;
		public int Status {
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStatus);
			}
		}

		static IntPtr id_a_Lcom_google_android_gms_games_multiplayer_Participant_;
		[Register ("a", "(Lcom/google/android/gms/games/multiplayer/Participant;)I", "")]
		public static int A (global::Android.Gms.Games.MultiPlayer.IParticipant p0)
		{
			if (id_a_Lcom_google_android_gms_games_multiplayer_Participant_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_multiplayer_Participant_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/multiplayer/Participant;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Lcom_google_android_gms_games_multiplayer_Participant_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_Lcom_google_android_gms_games_multiplayer_Participant_Ljava_lang_Object_;
		[Register ("a", "(Lcom/google/android/gms/games/multiplayer/Participant;Ljava/lang/Object;)Z", "")]
		public static bool A (global::Android.Gms.Games.MultiPlayer.IParticipant p0, global::Java.Lang.Object p1)
		{
			if (id_a_Lcom_google_android_gms_games_multiplayer_Participant_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_multiplayer_Participant_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/multiplayer/Participant;Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Lcom_google_android_gms_games_multiplayer_Participant_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b_Lcom_google_android_gms_games_multiplayer_Participant_;
		[Register ("b", "(Lcom/google/android/gms/games/multiplayer/Participant;)Ljava/lang/String;", "")]
		public static string B (global::Android.Gms.Games.MultiPlayer.IParticipant p0)
		{
			if (id_b_Lcom_google_android_gms_games_multiplayer_Participant_ == IntPtr.Zero)
				id_b_Lcom_google_android_gms_games_multiplayer_Participant_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lcom/google/android/gms/games/multiplayer/Participant;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Lcom_google_android_gms_games_multiplayer_Participant_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_freeze;
		[Register ("freeze", "()Lcom/google/android/gms/games/multiplayer/Participant;", "")]
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Lcom/google/android/gms/games/multiplayer/Participant;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getDisplayName_Landroid_database_CharArrayBuffer_;
		[Register ("getDisplayName", "(Landroid/database/CharArrayBuffer;)V", "")]
		public void GetDisplayName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDisplayName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDisplayName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_getDisplayName_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
		}

	}
}
