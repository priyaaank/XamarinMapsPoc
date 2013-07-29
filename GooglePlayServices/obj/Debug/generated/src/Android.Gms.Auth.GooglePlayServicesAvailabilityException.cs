using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.auth']/class[@name='GooglePlayServicesAvailabilityException']"
	[global::Android.Runtime.Register ("com/google/android/gms/auth/GooglePlayServicesAvailabilityException", DoNotGenerateAcw=true)]
	public partial class GooglePlayServicesAvailabilityException : global::Android.Gms.Auth.UserRecoverableAuthException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/auth/GooglePlayServicesAvailabilityException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GooglePlayServicesAvailabilityException); }
		}

		protected GooglePlayServicesAvailabilityException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConnectionStatusCode;
#pragma warning disable 0169
		static Delegate GetGetConnectionStatusCodeHandler ()
		{
			if (cb_getConnectionStatusCode == null)
				cb_getConnectionStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectionStatusCode);
			return cb_getConnectionStatusCode;
		}

		static int n_GetConnectionStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Auth.GooglePlayServicesAvailabilityException __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Auth.GooglePlayServicesAvailabilityException> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionStatusCode;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionStatusCode;
		public virtual int ConnectionStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.auth']/class[@name='GooglePlayServicesAvailabilityException']/method[@name='getConnectionStatusCode' and count(parameter)=0]"
			[Register ("getConnectionStatusCode", "()I", "GetGetConnectionStatusCodeHandler")]
			get {
				if (id_getConnectionStatusCode == IntPtr.Zero)
					id_getConnectionStatusCode = JNIEnv.GetMethodID (class_ref, "getConnectionStatusCode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getConnectionStatusCode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getConnectionStatusCode);
			}
		}

	}
}
