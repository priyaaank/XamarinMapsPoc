using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/GroundOverlay", DoNotGenerateAcw=true)]
	public sealed partial class GroundOverlay : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/GroundOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroundOverlay); }
		}

		internal GroundOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBearing;
		static IntPtr id_setBearing_F;
		public float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler")]
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getBearing);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBearing", "(F)V", "GetSetBearing_FHandler")]
			set {
				if (id_setBearing_F == IntPtr.Zero)
					id_setBearing_F = JNIEnv.GetMethodID (class_ref, "setBearing", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setBearing_F, new JValue (value));
			}
		}

		static IntPtr id_getBounds;
		public global::Android.Gms.Maps.Model.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/google/android/gms/maps/model/LatLngBounds;", "GetGetBoundsHandler")]
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Lcom/google/android/gms/maps/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHeight;
		public float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getHeight);
			}
		}

		static IntPtr id_getId;
		public string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lcom_google_android_gms_maps_model_LatLng_;
		public global::Android.Gms.Maps.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/google/android/gms/maps/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/google/android/gms/maps/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.LatLng']]"
			[Register ("setPosition", "(Lcom/google/android/gms/maps/model/LatLng;)V", "GetSetPosition_Lcom_google_android_gms_maps_model_LatLng_Handler")]
			set {
				if (id_setPosition_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
					id_setPosition_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/google/android/gms/maps/model/LatLng;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setPosition_Lcom_google_android_gms_maps_model_LatLng_, new JValue (value));
			}
		}

		static IntPtr id_getTransparency;
		static IntPtr id_setTransparency_F;
		public float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getTransparency);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setTransparency' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTransparency", "(F)V", "GetSetTransparency_FHandler")]
			set {
				if (id_setTransparency_F == IntPtr.Zero)
					id_setTransparency_F = JNIEnv.GetMethodID (class_ref, "setTransparency", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTransparency_F, new JValue (value));
			}
		}

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static IntPtr id_getWidth;
		public float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
			}
		}

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_F;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler")]
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setZIndex_F, new JValue (value));
			}
		}

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

		static IntPtr id_setDimensions_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDimensions", "(F)V", "")]
		public void SetDimensions (float p0)
		{
			if (id_setDimensions_F == IntPtr.Zero)
				id_setDimensions_F = JNIEnv.GetMethodID (class_ref, "setDimensions", "(F)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDimensions_F, new JValue (p0));
		}

		static IntPtr id_setDimensions_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setDimensions", "(FF)V", "")]
		public void SetDimensions (float p0, float p1)
		{
			if (id_setDimensions_FF == IntPtr.Zero)
				id_setDimensions_FF = JNIEnv.GetMethodID (class_ref, "setDimensions", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDimensions_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setPositionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='GroundOverlay']/method[@name='setPositionFromBounds' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.LatLngBounds']]"
		[Register ("setPositionFromBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;)V", "")]
		public void SetPositionFromBounds (global::Android.Gms.Maps.Model.LatLngBounds p0)
		{
			if (id_setPositionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_ == IntPtr.Zero)
				id_setPositionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "setPositionFromBounds", "(Lcom/google/android/gms/maps/model/LatLngBounds;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setPositionFromBounds_Lcom_google_android_gms_maps_model_LatLngBounds_, new JValue (p0));
		}

	}
}
