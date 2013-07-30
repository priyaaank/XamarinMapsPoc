using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='MapFragment']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/MapFragment", DoNotGenerateAcw=true)]
	public partial class MapFragment : global::Android.App.Fragment {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/MapFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapFragment); }
		}

		protected MapFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='MapFragment']/constructor[@name='MapFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MapFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapFragment)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getMap;
		public global::Android.Gms.Maps.GoogleMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='MapFragment']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/google/android/gms/maps/GoogleMap;", "GetGetMapHandler")]
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Lcom/google/android/gms/maps/GoogleMap;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap> (JNIEnv.CallObjectMethod  (Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='MapFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/google/android/gms/maps/MapFragment;", "")]
		public static global::Android.Gms.Maps.MapFragment NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/google/android/gms/maps/MapFragment;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.MapFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newInstance_Lcom_google_android_gms_maps_GoogleMapOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='MapFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.GoogleMapOptions']]"
		[Register ("newInstance", "(Lcom/google/android/gms/maps/GoogleMapOptions;)Lcom/google/android/gms/maps/MapFragment;", "")]
		public static global::Android.Gms.Maps.MapFragment NewInstance (global::Android.Gms.Maps.GoogleMapOptions p0)
		{
			if (id_newInstance_Lcom_google_android_gms_maps_GoogleMapOptions_ == IntPtr.Zero)
				id_newInstance_Lcom_google_android_gms_maps_GoogleMapOptions_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/google/android/gms/maps/GoogleMapOptions;)Lcom/google/android/gms/maps/MapFragment;");
			global::Android.Gms.Maps.MapFragment __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.MapFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_google_android_gms_maps_GoogleMapOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
