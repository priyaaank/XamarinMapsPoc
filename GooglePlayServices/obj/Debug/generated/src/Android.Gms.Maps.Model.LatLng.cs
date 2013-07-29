using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='LatLng']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/LatLng", DoNotGenerateAcw=true)]
	public sealed partial class LatLng : global::Java.Lang.Object {


		static IntPtr latitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='LatLng']/field[@name='latitude']"
		[Register ("latitude")]
		public double Latitude {
			get {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				return JNIEnv.GetDoubleField (Handle, latitude_jfieldId);
			}
			set {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				JNIEnv.SetField (Handle, latitude_jfieldId, value);
			}
		}

		static IntPtr longitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='LatLng']/field[@name='longitude']"
		[Register ("longitude")]
		public double Longitude {
			get {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				return JNIEnv.GetDoubleField (Handle, longitude_jfieldId);
			}
			set {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				JNIEnv.SetField (Handle, longitude_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/LatLng", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLng); }
		}

		internal LatLng (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public LatLng (double p0, double p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LatLng)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(DD)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_DD, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='LatLng']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_u;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='LatLng']/method[@name='u' and count(parameter)=0]"
		[Register ("u", "()I", "")]
		public int U ()
		{
			if (id_u == IntPtr.Zero)
				id_u = JNIEnv.GetMethodID (class_ref, "u", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_u);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='LatLng']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

	}
}
