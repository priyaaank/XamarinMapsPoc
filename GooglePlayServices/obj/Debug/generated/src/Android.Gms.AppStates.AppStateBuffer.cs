using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.AppStates {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.appstate']/class[@name='AppStateBuffer']"
	[global::Android.Runtime.Register ("com/google/android/gms/appstate/AppStateBuffer", DoNotGenerateAcw=true)]
	public sealed partial class AppStateBuffer : global::Android.Gms.Common.Data.DataBuffer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/appstate/AppStateBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppStateBuffer); }
		}

		internal AppStateBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.appstate']/class[@name='AppStateBuffer']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/google/android/gms/appstate/AppState;", "")]
		public override global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lcom/google/android/gms/appstate/AppState;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
