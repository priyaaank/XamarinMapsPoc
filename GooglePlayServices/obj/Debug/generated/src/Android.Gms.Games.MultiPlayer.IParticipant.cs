using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.MultiPlayer {

	[Register ("com/google/android/gms/games/multiplayer/Participant")]
	public abstract class Participant {

		internal Participant ()
		{
		}

		[Register ("STATUS_DECLINED")]
		public const int StatusDeclined = (int) 3;

		[Register ("STATUS_INVITED")]
		public const int StatusInvited = (int) 1;

		[Register ("STATUS_JOINED")]
		public const int StatusJoined = (int) 2;

		[Register ("STATUS_LEFT")]
		public const int StatusLeft = (int) 4;

		// The following are fields from: android.os.Parcelable

		// The following are fields from: System.IDisposable

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: com.google.android.gms.common.data.Freezable
	}

	[System.Obsolete ("Use the 'Participant' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class ParticipantConsts : Participant {

		private ParticipantConsts ()
		{
		}
	}

	[Register ("com/google/android/gms/games/multiplayer/Participant", "", "Android.Gms.Games.MultiPlayer.IParticipantInvoker")]
	public partial interface IParticipant : global::Android.OS.IParcelable, global::Android.Gms.Common.Data.IFreezable {

		string ClientAddress {
			[Register ("getClientAddress", "()Ljava/lang/String;", "GetGetClientAddressHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		string DisplayName {
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri HiResImageUri {
			[Register ("getHiResImageUri", "()Landroid/net/Uri;", "GetGetHiResImageUriHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri IconImageUri {
			[Register ("getIconImageUri", "()Landroid/net/Uri;", "GetGetIconImageUriHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		bool IsConnectedToRoom {
			[Register ("isConnectedToRoom", "()Z", "GetIsConnectedToRoomHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		string ParticipantId {
			[Register ("getParticipantId", "()Ljava/lang/String;", "GetGetParticipantIdHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Games.IPlayer Player {
			[Register ("getPlayer", "()Lcom/google/android/gms/games/Player;", "GetGetPlayerHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		int Status {
			[Register ("getStatus", "()I", "GetGetStatusHandler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")] get;
		}

		[Register ("getDisplayName", "(Landroid/database/CharArrayBuffer;)V", "GetGetDisplayName_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.MultiPlayer.IParticipantInvoker, GooglePlayServices")]
		void GetDisplayName (global::Android.Database.CharArrayBuffer p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/Participant", DoNotGenerateAcw=true)]
	internal class IParticipantInvoker : global::Java.Lang.Object, IParticipant {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/Participant");
		IntPtr class_ref;

		public static IParticipant GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParticipant> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.Participant"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParticipantInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IParticipantInvoker); }
		}

		static Delegate cb_getClientAddress;
#pragma warning disable 0169
		static Delegate GetGetClientAddressHandler ()
		{
			if (cb_getClientAddress == null)
				cb_getClientAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientAddress);
			return cb_getClientAddress;
		}

		static IntPtr n_GetClientAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientAddress);
		}
#pragma warning restore 0169

		IntPtr id_getClientAddress;
		public string ClientAddress {
			get {
				if (id_getClientAddress == IntPtr.Zero)
					id_getClientAddress = JNIEnv.GetMethodID (class_ref, "getClientAddress", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getClientAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayName;
		public string DisplayName {
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHiResImageUri;
#pragma warning disable 0169
		static Delegate GetGetHiResImageUriHandler ()
		{
			if (cb_getHiResImageUri == null)
				cb_getHiResImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHiResImageUri);
			return cb_getHiResImageUri;
		}

		static IntPtr n_GetHiResImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HiResImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getHiResImageUri;
		public global::Android.Net.Uri HiResImageUri {
			get {
				if (id_getHiResImageUri == IntPtr.Zero)
					id_getHiResImageUri = JNIEnv.GetMethodID (class_ref, "getHiResImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getHiResImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIconImageUri;
#pragma warning disable 0169
		static Delegate GetGetIconImageUriHandler ()
		{
			if (cb_getIconImageUri == null)
				cb_getIconImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconImageUri);
			return cb_getIconImageUri;
		}

		static IntPtr n_GetIconImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getIconImageUri;
		public global::Android.Net.Uri IconImageUri {
			get {
				if (id_getIconImageUri == IntPtr.Zero)
					id_getIconImageUri = JNIEnv.GetMethodID (class_ref, "getIconImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getIconImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isConnectedToRoom;
#pragma warning disable 0169
		static Delegate GetIsConnectedToRoomHandler ()
		{
			if (cb_isConnectedToRoom == null)
				cb_isConnectedToRoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnectedToRoom);
			return cb_isConnectedToRoom;
		}

		static bool n_IsConnectedToRoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnectedToRoom;
		}
#pragma warning restore 0169

		IntPtr id_isConnectedToRoom;
		public bool IsConnectedToRoom {
			get {
				if (id_isConnectedToRoom == IntPtr.Zero)
					id_isConnectedToRoom = JNIEnv.GetMethodID (class_ref, "isConnectedToRoom", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isConnectedToRoom);
			}
		}

		static Delegate cb_getParticipantId;
#pragma warning disable 0169
		static Delegate GetGetParticipantIdHandler ()
		{
			if (cb_getParticipantId == null)
				cb_getParticipantId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParticipantId);
			return cb_getParticipantId;
		}

		static IntPtr n_GetParticipantId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParticipantId);
		}
#pragma warning restore 0169

		IntPtr id_getParticipantId;
		public string ParticipantId {
			get {
				if (id_getParticipantId == IntPtr.Zero)
					id_getParticipantId = JNIEnv.GetMethodID (class_ref, "getParticipantId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getParticipantId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlayer;
#pragma warning disable 0169
		static Delegate GetGetPlayerHandler ()
		{
			if (cb_getPlayer == null)
				cb_getPlayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayer);
			return cb_getPlayer;
		}

		static IntPtr n_GetPlayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Player);
		}
#pragma warning restore 0169

		IntPtr id_getPlayer;
		public global::Android.Gms.Games.IPlayer Player {
			get {
				if (id_getPlayer == IntPtr.Zero)
					id_getPlayer = JNIEnv.GetMethodID (class_ref, "getPlayer", "()Lcom/google/android/gms/games/Player;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (JNIEnv.CallObjectMethod (Handle, id_getPlayer), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getDisplayName_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetDisplayName_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getDisplayName_Landroid_database_CharArrayBuffer_ == null)
				cb_getDisplayName_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDisplayName_Landroid_database_CharArrayBuffer_);
			return cb_getDisplayName_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetDisplayName_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDisplayName (p0);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayName_Landroid_database_CharArrayBuffer_;
		public void GetDisplayName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDisplayName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDisplayName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getDisplayName_Landroid_database_CharArrayBuffer_, new JValue (p0));
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
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.MultiPlayer.IParticipant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
