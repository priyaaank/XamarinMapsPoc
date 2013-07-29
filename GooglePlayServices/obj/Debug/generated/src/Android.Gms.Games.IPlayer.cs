using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']"
	[Register ("com/google/android/gms/games/Player", "", "Android.Gms.Games.IPlayerInvoker")]
	public partial interface IPlayer : global::Android.OS.IParcelable, global::Android.Gms.Common.Data.IFreezable {

		string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")] get;
		}

		bool HasHiResImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='hasHiResImage' and count(parameter)=0]"
			[Register ("hasHiResImage", "()Z", "GetHasHiResImageHandler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")] get;
		}

		bool HasIconImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='hasIconImage' and count(parameter)=0]"
			[Register ("hasIconImage", "()Z", "GetHasIconImageHandler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri HiResImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='getHiResImageUri' and count(parameter)=0]"
			[Register ("getHiResImageUri", "()Landroid/net/Uri;", "GetGetHiResImageUriHandler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri IconImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='getIconImageUri' and count(parameter)=0]"
			[Register ("getIconImageUri", "()Landroid/net/Uri;", "GetGetIconImageUriHandler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")] get;
		}

		string PlayerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='getPlayerId' and count(parameter)=0]"
			[Register ("getPlayerId", "()Ljava/lang/String;", "GetGetPlayerIdHandler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")] get;
		}

		long RetrievedTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='getRetrievedTimestamp' and count(parameter)=0]"
			[Register ("getRetrievedTimestamp", "()J", "GetGetRetrievedTimestampHandler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='Player']/method[@name='getDisplayName' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getDisplayName", "(Landroid/database/CharArrayBuffer;)V", "GetGetDisplayName_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.IPlayerInvoker, GooglePlayServices")]
		void GetDisplayName (global::Android.Database.CharArrayBuffer p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/Player", DoNotGenerateAcw=true)]
	internal class IPlayerInvoker : global::Java.Lang.Object, IPlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/Player");
		IntPtr class_ref;

		public static IPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.Player"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPlayerInvoker); }
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
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasHiResImage;
#pragma warning disable 0169
		static Delegate GetHasHiResImageHandler ()
		{
			if (cb_hasHiResImage == null)
				cb_hasHiResImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHiResImage);
			return cb_hasHiResImage;
		}

		static bool n_HasHiResImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHiResImage;
		}
#pragma warning restore 0169

		IntPtr id_hasHiResImage;
		public bool HasHiResImage {
			get {
				if (id_hasHiResImage == IntPtr.Zero)
					id_hasHiResImage = JNIEnv.GetMethodID (class_ref, "hasHiResImage", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasHiResImage);
			}
		}

		static Delegate cb_hasIconImage;
#pragma warning disable 0169
		static Delegate GetHasIconImageHandler ()
		{
			if (cb_hasIconImage == null)
				cb_hasIconImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasIconImage);
			return cb_hasIconImage;
		}

		static bool n_HasIconImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIconImage;
		}
#pragma warning restore 0169

		IntPtr id_hasIconImage;
		public bool HasIconImage {
			get {
				if (id_hasIconImage == IntPtr.Zero)
					id_hasIconImage = JNIEnv.GetMethodID (class_ref, "hasIconImage", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasIconImage);
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
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getPlayerId;
#pragma warning disable 0169
		static Delegate GetGetPlayerIdHandler ()
		{
			if (cb_getPlayerId == null)
				cb_getPlayerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerId);
			return cb_getPlayerId;
		}

		static IntPtr n_GetPlayerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerId);
		}
#pragma warning restore 0169

		IntPtr id_getPlayerId;
		public string PlayerId {
			get {
				if (id_getPlayerId == IntPtr.Zero)
					id_getPlayerId = JNIEnv.GetMethodID (class_ref, "getPlayerId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPlayerId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRetrievedTimestamp;
#pragma warning disable 0169
		static Delegate GetGetRetrievedTimestampHandler ()
		{
			if (cb_getRetrievedTimestamp == null)
				cb_getRetrievedTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRetrievedTimestamp);
			return cb_getRetrievedTimestamp;
		}

		static long n_GetRetrievedTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetrievedTimestamp;
		}
#pragma warning restore 0169

		IntPtr id_getRetrievedTimestamp;
		public long RetrievedTimestamp {
			get {
				if (id_getRetrievedTimestamp == IntPtr.Zero)
					id_getRetrievedTimestamp = JNIEnv.GetMethodID (class_ref, "getRetrievedTimestamp", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getRetrievedTimestamp);
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
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.IPlayer __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (native__this, JniHandleOwnership.DoNotTransfer);
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
