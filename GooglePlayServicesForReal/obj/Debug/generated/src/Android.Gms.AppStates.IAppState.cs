using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.AppStates {

	[Register ("com/google/android/gms/appstate/AppState", "", "Android.Gms.AppStates.IAppStateInvoker")]
	public partial interface IAppState : global::Android.Gms.Common.Data.IFreezable {

		string ConflictVersion {
			[Register ("getConflictVersion", "()Ljava/lang/String;", "GetGetConflictVersionHandler:Android.Gms.AppStates.IAppStateInvoker, GooglePlayServicesForReal")] get;
		}

		bool HasConflict {
			[Register ("hasConflict", "()Z", "GetHasConflictHandler:Android.Gms.AppStates.IAppStateInvoker, GooglePlayServicesForReal")] get;
		}

		int Key {
			[Register ("getKey", "()I", "GetGetKeyHandler:Android.Gms.AppStates.IAppStateInvoker, GooglePlayServicesForReal")] get;
		}

		string LocalVersion {
			[Register ("getLocalVersion", "()Ljava/lang/String;", "GetGetLocalVersionHandler:Android.Gms.AppStates.IAppStateInvoker, GooglePlayServicesForReal")] get;
		}

		[Register ("getConflictData", "()[B", "GetGetConflictDataHandler:Android.Gms.AppStates.IAppStateInvoker, GooglePlayServicesForReal")]
		byte[] GetConflictData ();

		[Register ("getLocalData", "()[B", "GetGetLocalDataHandler:Android.Gms.AppStates.IAppStateInvoker, GooglePlayServicesForReal")]
		byte[] GetLocalData ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/appstate/AppState", DoNotGenerateAcw=true)]
	internal class IAppStateInvoker : global::Java.Lang.Object, IAppState {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/appstate/AppState");
		IntPtr class_ref;

		public static IAppState GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppState> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.appstate.AppState"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAppStateInvoker); }
		}

		static Delegate cb_getConflictVersion;
#pragma warning disable 0169
		static Delegate GetGetConflictVersionHandler ()
		{
			if (cb_getConflictVersion == null)
				cb_getConflictVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConflictVersion);
			return cb_getConflictVersion;
		}

		static IntPtr n_GetConflictVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.AppStates.IAppState __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IAppState> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConflictVersion);
		}
#pragma warning restore 0169

		IntPtr id_getConflictVersion;
		public string ConflictVersion {
			get {
				if (id_getConflictVersion == IntPtr.Zero)
					id_getConflictVersion = JNIEnv.GetMethodID (class_ref, "getConflictVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getConflictVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasConflict;
#pragma warning disable 0169
		static Delegate GetHasConflictHandler ()
		{
			if (cb_hasConflict == null)
				cb_hasConflict = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasConflict);
			return cb_hasConflict;
		}

		static bool n_HasConflict (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.AppStates.IAppState __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IAppState> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasConflict;
		}
#pragma warning restore 0169

		IntPtr id_hasConflict;
		public bool HasConflict {
			get {
				if (id_hasConflict == IntPtr.Zero)
					id_hasConflict = JNIEnv.GetMethodID (class_ref, "hasConflict", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasConflict);
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKey);
			return cb_getKey;
		}

		static int n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.AppStates.IAppState __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IAppState> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Key;
		}
#pragma warning restore 0169

		IntPtr id_getKey;
		public int Key {
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getKey);
			}
		}

		static Delegate cb_getLocalVersion;
#pragma warning disable 0169
		static Delegate GetGetLocalVersionHandler ()
		{
			if (cb_getLocalVersion == null)
				cb_getLocalVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalVersion);
			return cb_getLocalVersion;
		}

		static IntPtr n_GetLocalVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.AppStates.IAppState __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IAppState> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalVersion);
		}
#pragma warning restore 0169

		IntPtr id_getLocalVersion;
		public string LocalVersion {
			get {
				if (id_getLocalVersion == IntPtr.Zero)
					id_getLocalVersion = JNIEnv.GetMethodID (class_ref, "getLocalVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLocalVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getConflictData;
#pragma warning disable 0169
		static Delegate GetGetConflictDataHandler ()
		{
			if (cb_getConflictData == null)
				cb_getConflictData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConflictData);
			return cb_getConflictData;
		}

		static IntPtr n_GetConflictData (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.AppStates.IAppState __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IAppState> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetConflictData ());
		}
#pragma warning restore 0169

		IntPtr id_getConflictData;
		public byte[] GetConflictData ()
		{
			if (id_getConflictData == IntPtr.Zero)
				id_getConflictData = JNIEnv.GetMethodID (class_ref, "getConflictData", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getConflictData), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getLocalData;
#pragma warning disable 0169
		static Delegate GetGetLocalDataHandler ()
		{
			if (cb_getLocalData == null)
				cb_getLocalData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalData);
			return cb_getLocalData;
		}

		static IntPtr n_GetLocalData (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.AppStates.IAppState __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IAppState> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocalData ());
		}
#pragma warning restore 0169

		IntPtr id_getLocalData;
		public byte[] GetLocalData ()
		{
			if (id_getLocalData == IntPtr.Zero)
				id_getLocalData = JNIEnv.GetMethodID (class_ref, "getLocalData", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getLocalData), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Android.Gms.AppStates.IAppState __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IAppState> (native__this, JniHandleOwnership.DoNotTransfer);
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
