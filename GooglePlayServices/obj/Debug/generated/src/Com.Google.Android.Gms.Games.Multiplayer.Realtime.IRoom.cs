using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	[Register ("com/google/android/gms/games/multiplayer/realtime/Room")]
	public abstract class Room {

		internal Room ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/field[@name='ROOM_STATUS_ACTIVE']"
		[Register ("ROOM_STATUS_ACTIVE")]
		public const int RoomStatusActive = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/field[@name='ROOM_STATUS_AUTO_MATCHING']"
		[Register ("ROOM_STATUS_AUTO_MATCHING")]
		public const int RoomStatusAutoMatching = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/field[@name='ROOM_STATUS_CONNECTING']"
		[Register ("ROOM_STATUS_CONNECTING")]
		public const int RoomStatusConnecting = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/field[@name='ROOM_STATUS_INVITING']"
		[Register ("ROOM_STATUS_INVITING")]
		public const int RoomStatusInviting = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/field[@name='ROOM_VARIANT_ANY']"
		[Register ("ROOM_VARIANT_ANY")]
		public const int RoomVariantAny = (int) -1;

		// The following are fields from: android.os.Parcelable

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable

		// The following are fields from: com.google.android.gms.common.data.Freezable

		// The following are fields from: com.google.android.gms.games.multiplayer.Participatable
	}

	[System.Obsolete ("Use the 'Room' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class RoomConsts : Room {

		private RoomConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']"
	[Register ("com/google/android/gms/games/multiplayer/realtime/Room", "", "Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker")]
	public partial interface IRoom : global::Android.OS.IParcelable, global::Android.Gms.Common.Data.IFreezable, global::Android.Gms.Games.MultiPlayer.IParticipatable {

		global::Android.OS.Bundle AutoMatchCriteria {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getAutoMatchCriteria' and count(parameter)=0]"
			[Register ("getAutoMatchCriteria", "()Landroid/os/Bundle;", "GetGetAutoMatchCriteriaHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		long CreationTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getCreationTimestamp' and count(parameter)=0]"
			[Register ("getCreationTimestamp", "()J", "GetGetCreationTimestampHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		string CreatorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getCreatorId' and count(parameter)=0]"
			[Register ("getCreatorId", "()Ljava/lang/String;", "GetGetCreatorIdHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<string> ParticipantIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getParticipantIds' and count(parameter)=0]"
			[Register ("getParticipantIds", "()Ljava/util/ArrayList;", "GetGetParticipantIdsHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		string RoomId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getRoomId' and count(parameter)=0]"
			[Register ("getRoomId", "()Ljava/lang/String;", "GetGetRoomIdHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		int Variant {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getVariant' and count(parameter)=0]"
			[Register ("getVariant", "()I", "GetGetVariantHandler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getDescription' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getDescription", "(Landroid/database/CharArrayBuffer;)V", "GetGetDescription_Landroid_database_CharArrayBuffer_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")]
		void GetDescription (global::Android.Database.CharArrayBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getParticipantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParticipantId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParticipantId_Ljava_lang_String_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")]
		string GetParticipantId (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='Room']/method[@name='getParticipantStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParticipantStatus", "(Ljava/lang/String;)I", "GetGetParticipantStatus_Ljava_lang_String_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomInvoker, GooglePlayServices")]
		int GetParticipantStatus (string p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/Room", DoNotGenerateAcw=true)]
	internal class IRoomInvoker : global::Java.Lang.Object, IRoom {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/Room");
		IntPtr class_ref;

		public static IRoom GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoom> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.realtime.Room"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRoomInvoker); }
		}

		static Delegate cb_getAutoMatchCriteria;
#pragma warning disable 0169
		static Delegate GetGetAutoMatchCriteriaHandler ()
		{
			if (cb_getAutoMatchCriteria == null)
				cb_getAutoMatchCriteria = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAutoMatchCriteria);
			return cb_getAutoMatchCriteria;
		}

		static IntPtr n_GetAutoMatchCriteria (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AutoMatchCriteria);
		}
#pragma warning restore 0169

		IntPtr id_getAutoMatchCriteria;
		public global::Android.OS.Bundle AutoMatchCriteria {
			get {
				if (id_getAutoMatchCriteria == IntPtr.Zero)
					id_getAutoMatchCriteria = JNIEnv.GetMethodID (class_ref, "getAutoMatchCriteria", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (Handle, id_getAutoMatchCriteria), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCreationTimestamp;
#pragma warning disable 0169
		static Delegate GetGetCreationTimestampHandler ()
		{
			if (cb_getCreationTimestamp == null)
				cb_getCreationTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCreationTimestamp);
			return cb_getCreationTimestamp;
		}

		static long n_GetCreationTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreationTimestamp;
		}
#pragma warning restore 0169

		IntPtr id_getCreationTimestamp;
		public long CreationTimestamp {
			get {
				if (id_getCreationTimestamp == IntPtr.Zero)
					id_getCreationTimestamp = JNIEnv.GetMethodID (class_ref, "getCreationTimestamp", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getCreationTimestamp);
			}
		}

		static Delegate cb_getCreatorId;
#pragma warning disable 0169
		static Delegate GetGetCreatorIdHandler ()
		{
			if (cb_getCreatorId == null)
				cb_getCreatorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatorId);
			return cb_getCreatorId;
		}

		static IntPtr n_GetCreatorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatorId);
		}
#pragma warning restore 0169

		IntPtr id_getCreatorId;
		public string CreatorId {
			get {
				if (id_getCreatorId == IntPtr.Zero)
					id_getCreatorId = JNIEnv.GetMethodID (class_ref, "getCreatorId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCreatorId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		public string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getParticipantIds;
#pragma warning disable 0169
		static Delegate GetGetParticipantIdsHandler ()
		{
			if (cb_getParticipantIds == null)
				cb_getParticipantIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParticipantIds);
			return cb_getParticipantIds;
		}

		static IntPtr n_GetParticipantIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ParticipantIds);
		}
#pragma warning restore 0169

		IntPtr id_getParticipantIds;
		public global::System.Collections.Generic.IList<string> ParticipantIds {
			get {
				if (id_getParticipantIds == IntPtr.Zero)
					id_getParticipantIds = JNIEnv.GetMethodID (class_ref, "getParticipantIds", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getParticipantIds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRoomId;
#pragma warning disable 0169
		static Delegate GetGetRoomIdHandler ()
		{
			if (cb_getRoomId == null)
				cb_getRoomId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoomId);
			return cb_getRoomId;
		}

		static IntPtr n_GetRoomId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RoomId);
		}
#pragma warning restore 0169

		IntPtr id_getRoomId;
		public string RoomId {
			get {
				if (id_getRoomId == IntPtr.Zero)
					id_getRoomId = JNIEnv.GetMethodID (class_ref, "getRoomId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRoomId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		IntPtr id_getStatus;
		public int Status {
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getStatus);
			}
		}

		static Delegate cb_getVariant;
#pragma warning disable 0169
		static Delegate GetGetVariantHandler ()
		{
			if (cb_getVariant == null)
				cb_getVariant = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVariant);
			return cb_getVariant;
		}

		static int n_GetVariant (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Variant;
		}
#pragma warning restore 0169

		IntPtr id_getVariant;
		public int Variant {
			get {
				if (id_getVariant == IntPtr.Zero)
					id_getVariant = JNIEnv.GetMethodID (class_ref, "getVariant", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getVariant);
			}
		}

		static Delegate cb_getDescription_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetDescription_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getDescription_Landroid_database_CharArrayBuffer_ == null)
				cb_getDescription_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDescription_Landroid_database_CharArrayBuffer_);
			return cb_getDescription_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetDescription_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDescription (p0);
		}
#pragma warning restore 0169

		IntPtr id_getDescription_Landroid_database_CharArrayBuffer_;
		public void GetDescription (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDescription_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDescription_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDescription", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getDescription_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static Delegate cb_getParticipantId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParticipantId_Ljava_lang_String_Handler ()
		{
			if (cb_getParticipantId_Ljava_lang_String_ == null)
				cb_getParticipantId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParticipantId_Ljava_lang_String_);
			return cb_getParticipantId_Ljava_lang_String_;
		}

		static IntPtr n_GetParticipantId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParticipantId (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParticipantId_Ljava_lang_String_;
		public string GetParticipantId (string p0)
		{
			if (id_getParticipantId_Ljava_lang_String_ == IntPtr.Zero)
				id_getParticipantId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParticipantId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getParticipantId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getParticipantStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParticipantStatus_Ljava_lang_String_Handler ()
		{
			if (cb_getParticipantStatus_Ljava_lang_String_ == null)
				cb_getParticipantStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetParticipantStatus_Ljava_lang_String_);
			return cb_getParticipantStatus_Ljava_lang_String_;
		}

		static int n_GetParticipantStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetParticipantStatus (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParticipantStatus_Ljava_lang_String_;
		public int GetParticipantStatus (string p0)
		{
			if (id_getParticipantStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_getParticipantStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParticipantStatus", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod (Handle, id_getParticipantStatus_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		IntPtr id_describeContents;
		public global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod (Handle, id_describeContents);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		public void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (dest), new JValue ((int) flags));
		}

		static Delegate cb_freeze;
#pragma warning disable 0169
		static Delegate GetFreezeHandler ()
		{
			if (cb_freeze == null)
				cb_freeze = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Freeze);
			return cb_freeze;
		}

		static IntPtr n_Freeze (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Freeze ());
		}
#pragma warning restore 0169

		IntPtr id_freeze;
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getParticipants;
#pragma warning disable 0169
		static Delegate GetGetParticipantsHandler ()
		{
			if (cb_getParticipants == null)
				cb_getParticipants = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParticipants);
			return cb_getParticipants;
		}

		static IntPtr n_GetParticipants (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Games.MultiPlayer.IParticipant>.ToLocalJniHandle (__this.Participants);
		}
#pragma warning restore 0169

		IntPtr id_getParticipants;
		public global::System.Collections.Generic.IList<global::Android.Gms.Games.MultiPlayer.IParticipant> Participants {
			get {
				if (id_getParticipants == IntPtr.Zero)
					id_getParticipants = JNIEnv.GetMethodID (class_ref, "getParticipants", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Games.MultiPlayer.IParticipant>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getParticipants), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
