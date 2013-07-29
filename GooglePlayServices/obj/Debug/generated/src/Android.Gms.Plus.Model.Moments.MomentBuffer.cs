using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus.Model.Moments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.plus.model.moments']/class[@name='MomentBuffer']"
	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/moments/MomentBuffer", DoNotGenerateAcw=true)]
	public sealed partial class MomentBuffer : global::Android.Gms.Common.Data.DataBuffer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/moments/MomentBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MomentBuffer); }
		}

		internal MomentBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.plus.model.moments']/class[@name='MomentBuffer']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/google/android/gms/plus/model/moments/Moment;", "")]
		public override global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lcom/google/android/gms/plus/model/moments/Moment;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
