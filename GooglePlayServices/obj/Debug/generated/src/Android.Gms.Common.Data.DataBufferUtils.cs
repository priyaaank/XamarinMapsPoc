using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.data']/class[@name='DataBufferUtils']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataBufferUtils", DoNotGenerateAcw=true)]
	public sealed partial class DataBufferUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/data/DataBufferUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBufferUtils); }
		}

		internal DataBufferUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_freezeAndClose_Lcom_google_android_gms_common_data_DataBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.data']/class[@name='DataBufferUtils']/method[@name='freezeAndClose' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.data.DataBuffer']]"
		[Register ("freezeAndClose", "(Lcom/google/android/gms/common/data/DataBuffer;)Ljava/util/ArrayList;", "")]
		public static global::System.Collections.IList FreezeAndClose (global::Android.Gms.Common.Data.DataBuffer p0)
		{
			if (id_freezeAndClose_Lcom_google_android_gms_common_data_DataBuffer_ == IntPtr.Zero)
				id_freezeAndClose_Lcom_google_android_gms_common_data_DataBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "freezeAndClose", "(Lcom/google/android/gms/common/data/DataBuffer;)Ljava/util/ArrayList;");
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_freezeAndClose_Lcom_google_android_gms_common_data_DataBuffer_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
