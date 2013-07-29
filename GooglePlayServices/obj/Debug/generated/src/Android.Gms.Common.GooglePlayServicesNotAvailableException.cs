using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesNotAvailableException']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/GooglePlayServicesNotAvailableException", DoNotGenerateAcw=true)]
	public sealed partial class GooglePlayServicesNotAvailableException : global::Java.Lang.Exception {


		static IntPtr errorCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesNotAvailableException']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
				return JNIEnv.GetIntField (Handle, errorCode_jfieldId);
			}
			set {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
				JNIEnv.SetField (Handle, errorCode_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/GooglePlayServicesNotAvailableException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GooglePlayServicesNotAvailableException); }
		}

		internal GooglePlayServicesNotAvailableException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesNotAvailableException']/constructor[@name='GooglePlayServicesNotAvailableException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public GooglePlayServicesNotAvailableException (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GooglePlayServicesNotAvailableException)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(I)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
