using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/VisibleRegion", DoNotGenerateAcw=true)]
	public sealed partial class VisibleRegion : global::Java.Lang.Object {


		static IntPtr farLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/field[@name='farLeft']"
		[Register ("farLeft")]
		public global::Android.Gms.Maps.Model.LatLng FarLeft {
			get {
				if (farLeft_jfieldId == IntPtr.Zero)
					farLeft_jfieldId = JNIEnv.GetFieldID (class_ref, "farLeft", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, farLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (farLeft_jfieldId == IntPtr.Zero)
					farLeft_jfieldId = JNIEnv.GetFieldID (class_ref, "farLeft", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, farLeft_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr farRight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/field[@name='farRight']"
		[Register ("farRight")]
		public global::Android.Gms.Maps.Model.LatLng FarRight {
			get {
				if (farRight_jfieldId == IntPtr.Zero)
					farRight_jfieldId = JNIEnv.GetFieldID (class_ref, "farRight", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, farRight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (farRight_jfieldId == IntPtr.Zero)
					farRight_jfieldId = JNIEnv.GetFieldID (class_ref, "farRight", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, farRight_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr latLngBounds_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/field[@name='latLngBounds']"
		[Register ("latLngBounds")]
		public global::Android.Gms.Maps.Model.LatLngBounds LatLngBounds {
			get {
				if (latLngBounds_jfieldId == IntPtr.Zero)
					latLngBounds_jfieldId = JNIEnv.GetFieldID (class_ref, "latLngBounds", "Lcom/google/android/gms/maps/model/LatLngBounds;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, latLngBounds_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLngBounds> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (latLngBounds_jfieldId == IntPtr.Zero)
					latLngBounds_jfieldId = JNIEnv.GetFieldID (class_ref, "latLngBounds", "Lcom/google/android/gms/maps/model/LatLngBounds;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, latLngBounds_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr nearLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/field[@name='nearLeft']"
		[Register ("nearLeft")]
		public global::Android.Gms.Maps.Model.LatLng NearLeft {
			get {
				if (nearLeft_jfieldId == IntPtr.Zero)
					nearLeft_jfieldId = JNIEnv.GetFieldID (class_ref, "nearLeft", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, nearLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (nearLeft_jfieldId == IntPtr.Zero)
					nearLeft_jfieldId = JNIEnv.GetFieldID (class_ref, "nearLeft", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, nearLeft_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr nearRight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/field[@name='nearRight']"
		[Register ("nearRight")]
		public global::Android.Gms.Maps.Model.LatLng NearRight {
			get {
				if (nearRight_jfieldId == IntPtr.Zero)
					nearRight_jfieldId = JNIEnv.GetFieldID (class_ref, "nearRight", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, nearRight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (nearRight_jfieldId == IntPtr.Zero)
					nearRight_jfieldId = JNIEnv.GetFieldID (class_ref, "nearRight", "Lcom/google/android/gms/maps/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, nearRight_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/VisibleRegion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VisibleRegion); }
		}

		internal VisibleRegion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLngBounds_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/constructor[@name='VisibleRegion' and count(parameter)=5 and parameter[1][@type='com.google.android.gms.maps.model.LatLng'] and parameter[2][@type='com.google.android.gms.maps.model.LatLng'] and parameter[3][@type='com.google.android.gms.maps.model.LatLng'] and parameter[4][@type='com.google.android.gms.maps.model.LatLng'] and parameter[5][@type='com.google.android.gms.maps.model.LatLngBounds']]"
		[Register (".ctor", "(Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLngBounds;)V", "")]
		public VisibleRegion (global::Android.Gms.Maps.Model.LatLng p0, global::Android.Gms.Maps.Model.LatLng p1, global::Android.Gms.Maps.Model.LatLng p2, global::Android.Gms.Maps.Model.LatLng p3, global::Android.Gms.Maps.Model.LatLngBounds p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (VisibleRegion)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLngBounds;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLngBounds_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLng;Lcom/google/android/gms/maps/model/LatLngBounds;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLng_Lcom_google_android_gms_maps_model_LatLngBounds_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_u;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/method[@name='u' and count(parameter)=0]"
		[Register ("u", "()I", "")]
		public int U ()
		{
			if (id_u == IntPtr.Zero)
				id_u = JNIEnv.GetMethodID (class_ref, "u", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_u);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='VisibleRegion']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

	}
}
