using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/CameraUpdateFactory", DoNotGenerateAcw=true)]
	public sealed partial class CameraUpdateFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/CameraUpdateFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraUpdateFactory); }
		}

		internal CameraUpdateFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_newCameraPosition_Lcom_google_android_gms_maps_model_CameraPosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='newCameraPosition' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.CameraPosition']]"
		[Register ("newCameraPosition", "(Lcom/google/android/gms/maps/model/CameraPosition;)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate NewCameraPosition (global::Android.Gms.Maps.Model.CameraPosition p0)
		{
			if (id_newCameraPosition_Lcom_google_android_gms_maps_model_CameraPosition_ == IntPtr.Zero)
				id_newCameraPosition_Lcom_google_android_gms_maps_model_CameraPosition_ = JNIEnv.GetStaticMethodID (class_ref, "newCameraPosition", "(Lcom/google/android/gms/maps/model/CameraPosition;)Lcom/google/android/gms/maps/CameraUpdate;");
			global::Android.Gms.Maps.CameraUpdate __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newCameraPosition_Lcom_google_android_gms_maps_model_CameraPosition_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newLatLng_Lcom_google_android_gms_maps_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='newLatLng' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.LatLng']]"
		[Register ("newLatLng", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate NewLatLng (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_newLatLng_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_newLatLng_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "newLatLng", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/CameraUpdate;");
			global::Android.Gms.Maps.CameraUpdate __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLng_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.maps.model.LatLngBounds'] and parameter[2][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;I)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate NewLatLngBounds (global::Android.Gms.Maps.Model.LatLngBounds p0, int p1)
		{
			if (id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_I == IntPtr.Zero)
				id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_I = JNIEnv.GetStaticMethodID (class_ref, "newLatLngBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;I)Lcom/google/android/gms/maps/CameraUpdate;");
			global::Android.Gms.Maps.CameraUpdate __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=4 and parameter[1][@type='com.google.android.gms.maps.model.LatLngBounds'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;III)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate NewLatLngBounds (global::Android.Gms.Maps.Model.LatLngBounds p0, int p1, int p2, int p3)
		{
			if (id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_III == IntPtr.Zero)
				id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_III = JNIEnv.GetStaticMethodID (class_ref, "newLatLngBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;III)Lcom/google/android/gms/maps/CameraUpdate;");
			global::Android.Gms.Maps.CameraUpdate __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLngBounds_Lcom_google_android_gms_maps_model_LatLngBounds_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='newLatLngZoom' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.maps.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("newLatLngZoom", "(Lcom/google/android/gms/maps/model/LatLng;F)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate NewLatLngZoom (global::Android.Gms.Maps.Model.LatLng p0, float p1)
		{
			if (id_newLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F == IntPtr.Zero)
				id_newLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F = JNIEnv.GetStaticMethodID (class_ref, "newLatLngZoom", "(Lcom/google/android/gms/maps/model/LatLng;F)Lcom/google/android/gms/maps/CameraUpdate;");
			global::Android.Gms.Maps.CameraUpdate __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLngZoom_Lcom_google_android_gms_maps_model_LatLng_F, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_scrollBy_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("scrollBy", "(FF)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate ScrollBy (float p0, float p1)
		{
			if (id_scrollBy_FF == IntPtr.Zero)
				id_scrollBy_FF = JNIEnv.GetStaticMethodID (class_ref, "scrollBy", "(FF)Lcom/google/android/gms/maps/CameraUpdate;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_scrollBy_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zoomBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='zoomBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomBy", "(F)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate ZoomBy (float p0)
		{
			if (id_zoomBy_F == IntPtr.Zero)
				id_zoomBy_F = JNIEnv.GetStaticMethodID (class_ref, "zoomBy", "(F)Lcom/google/android/gms/maps/CameraUpdate;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomBy_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zoomBy_FLandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='zoomBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("zoomBy", "(FLandroid/graphics/Point;)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate ZoomBy (float p0, global::Android.Graphics.Point p1)
		{
			if (id_zoomBy_FLandroid_graphics_Point_ == IntPtr.Zero)
				id_zoomBy_FLandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "zoomBy", "(FLandroid/graphics/Point;)Lcom/google/android/gms/maps/CameraUpdate;");
			global::Android.Gms.Maps.CameraUpdate __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomBy_FLandroid_graphics_Point_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_zoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetStaticMethodID (class_ref, "zoomIn", "()Lcom/google/android/gms/maps/CameraUpdate;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomIn), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetStaticMethodID (class_ref, "zoomOut", "()Lcom/google/android/gms/maps/CameraUpdate;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomOut), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zoomTo_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='CameraUpdateFactory']/method[@name='zoomTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomTo", "(F)Lcom/google/android/gms/maps/CameraUpdate;", "")]
		public static global::Android.Gms.Maps.CameraUpdate ZoomTo (float p0)
		{
			if (id_zoomTo_F == IntPtr.Zero)
				id_zoomTo_F = JNIEnv.GetStaticMethodID (class_ref, "zoomTo", "(F)Lcom/google/android/gms/maps/CameraUpdate;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.CameraUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomTo_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
