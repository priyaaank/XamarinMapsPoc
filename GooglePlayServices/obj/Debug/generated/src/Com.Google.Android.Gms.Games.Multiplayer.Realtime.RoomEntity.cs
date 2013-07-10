using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RoomEntity", DoNotGenerateAcw=true)]
	public sealed partial class RoomEntity : global::Java.Lang.Object, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom {


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

			// The following are fields from: com.google.android.gms.games.multiplayer.realtime.Room

			[Register ("ROOM_STATUS_ACTIVE")]
			public const int RoomStatusActive = (int) 3;

			[Register ("ROOM_STATUS_AUTO_MATCHING")]
			public const int RoomStatusAutoMatching = (int) 1;

			[Register ("ROOM_STATUS_CONNECTING")]
			public const int RoomStatusConnecting = (int) 2;

			[Register ("ROOM_STATUS_INVITING")]
			public const int RoomStatusInviting = (int) 0;

			[Register ("ROOM_VARIANT_ANY")]
			public const int RoomVariantAny = (int) -1;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RoomEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoomEntity); }
		}

		internal RoomEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		[Register (".ctor", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V", "")]
		public RoomEntity (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RoomEntity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getAutoMatchCriteria;
		public global::Android.OS.Bundle AutoMatchCriteria {
			[Register ("getAutoMatchCriteria", "()Landroid/os/Bundle;", "GetGetAutoMatchCriteriaHandler")]
			get {
				if (id_getAutoMatchCriteria == IntPtr.Zero)
					id_getAutoMatchCriteria = JNIEnv.GetMethodID (class_ref, "getAutoMatchCriteria", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getAutoMatchCriteria), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getCreationTimestamp;
		public long CreationTimestamp {
			[Register ("getCreationTimestamp", "()J", "GetGetCreationTimestampHandler")]
			get {
				if (id_getCreationTimestamp == IntPtr.Zero)
					id_getCreationTimestamp = JNIEnv.GetMethodID (class_ref, "getCreationTimestamp", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getCreationTimestamp);
			}
		}

		static IntPtr id_getCreatorId;
		public string CreatorId {
			[Register ("getCreatorId", "()Ljava/lang/String;", "GetGetCreatorIdHandler")]
			get {
				if (id_getCreatorId == IntPtr.Zero)
					id_getCreatorId = JNIEnv.GetMethodID (class_ref, "getCreatorId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCreatorId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDescription;
		public string Description {
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getParticipantIds;
		public global::System.Collections.Generic.IList<string> ParticipantIds {
			[Register ("getParticipantIds", "()Ljava/util/ArrayList;", "GetGetParticipantIdsHandler")]
			get {
				if (id_getParticipantIds == IntPtr.Zero)
					id_getParticipantIds = JNIEnv.GetMethodID (class_ref, "getParticipantIds", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParticipantIds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getParticipants;
		public global::System.Collections.Generic.IList<global::Android.Gms.Games.MultiPlayer.IParticipant> Participants {
			[Register ("getParticipants", "()Ljava/util/ArrayList;", "GetGetParticipantsHandler")]
			get {
				if (id_getParticipants == IntPtr.Zero)
					id_getParticipants = JNIEnv.GetMethodID (class_ref, "getParticipants", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Games.MultiPlayer.IParticipant>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParticipants), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRoomId;
		public string RoomId {
			[Register ("getRoomId", "()Ljava/lang/String;", "GetGetRoomIdHandler")]
			get {
				if (id_getRoomId == IntPtr.Zero)
					id_getRoomId = JNIEnv.GetMethodID (class_ref, "getRoomId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRoomId), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_getVariant;
		public int Variant {
			[Register ("getVariant", "()I", "GetGetVariantHandler")]
			get {
				if (id_getVariant == IntPtr.Zero)
					id_getVariant = JNIEnv.GetMethodID (class_ref, "getVariant", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getVariant);
			}
		}

		static IntPtr id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		[Register ("a", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)I", "")]
		public static int A (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			if (id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_lang_Object_;
		[Register ("a", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/lang/Object;)Z", "")]
		public static bool A (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::Java.Lang.Object p1)
		{
			if (id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		[Register ("b", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)Ljava/lang/String;", "")]
		public static string B (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			if (id_b_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_b_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Lcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
		[Register ("freeze", "()Lcom/google/android/gms/games/multiplayer/realtime/Room;", "")]
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Lcom/google/android/gms/games/multiplayer/realtime/Room;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getDescription_Landroid_database_CharArrayBuffer_;
		[Register ("getDescription", "(Landroid/database/CharArrayBuffer;)V", "")]
		public void GetDescription (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDescription_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDescription_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDescription", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_getDescription_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static IntPtr id_getParticipantId_Ljava_lang_String_;
		[Register ("getParticipantId", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public string GetParticipantId (string p0)
		{
			if (id_getParticipantId_Ljava_lang_String_ == IntPtr.Zero)
				id_getParticipantId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParticipantId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParticipantId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getParticipantStatus_Ljava_lang_String_;
		[Register ("getParticipantStatus", "(Ljava/lang/String;)I", "")]
		public int GetParticipantStatus (string p0)
		{
			if (id_getParticipantStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_getParticipantStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParticipantStatus", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_getParticipantStatus_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
