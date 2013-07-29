using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/GoogleMapOptions", DoNotGenerateAcw=true)]
	public sealed partial class GoogleMapOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/GoogleMapOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GoogleMapOptions); }
		}

		internal GoogleMapOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/constructor[@name='GoogleMapOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GoogleMapOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GoogleMapOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getCamera;
		public global::Android.Gms.Maps.Model.CameraPosition Camera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getCamera' and count(parameter)=0]"
			[Register ("getCamera", "()Lcom/google/android/gms/maps/model/CameraPosition;", "GetGetCameraHandler")]
			get {
				if (id_getCamera == IntPtr.Zero)
					id_getCamera = JNIEnv.GetMethodID (class_ref, "getCamera", "()Lcom/google/android/gms/maps/model/CameraPosition;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.CameraPosition> (JNIEnv.CallObjectMethod  (Handle, id_getCamera), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getCompassEnabled;
		public global::Java.Lang.Boolean CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getCompassEnabled' and count(parameter)=0]"
			[Register ("getCompassEnabled", "()Ljava/lang/Boolean;", "GetGetCompassEnabledHandler")]
			get {
				if (id_getCompassEnabled == IntPtr.Zero)
					id_getCompassEnabled = JNIEnv.GetMethodID (class_ref, "getCompassEnabled", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getCompassEnabled), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getMapType;
		public int MapType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getMapType' and count(parameter)=0]"
			[Register ("getMapType", "()I", "GetGetMapTypeHandler")]
			get {
				if (id_getMapType == IntPtr.Zero)
					id_getMapType = JNIEnv.GetMethodID (class_ref, "getMapType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMapType);
			}
		}

		static IntPtr id_getRotateGesturesEnabled;
		public global::Java.Lang.Boolean RotateGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getRotateGesturesEnabled' and count(parameter)=0]"
			[Register ("getRotateGesturesEnabled", "()Ljava/lang/Boolean;", "GetGetRotateGesturesEnabledHandler")]
			get {
				if (id_getRotateGesturesEnabled == IntPtr.Zero)
					id_getRotateGesturesEnabled = JNIEnv.GetMethodID (class_ref, "getRotateGesturesEnabled", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getRotateGesturesEnabled), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getScrollGesturesEnabled;
		public global::Java.Lang.Boolean ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("getScrollGesturesEnabled", "()Ljava/lang/Boolean;", "GetGetScrollGesturesEnabledHandler")]
			get {
				if (id_getScrollGesturesEnabled == IntPtr.Zero)
					id_getScrollGesturesEnabled = JNIEnv.GetMethodID (class_ref, "getScrollGesturesEnabled", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getScrollGesturesEnabled), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTiltGesturesEnabled;
		public global::Java.Lang.Boolean TiltGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getTiltGesturesEnabled' and count(parameter)=0]"
			[Register ("getTiltGesturesEnabled", "()Ljava/lang/Boolean;", "GetGetTiltGesturesEnabledHandler")]
			get {
				if (id_getTiltGesturesEnabled == IntPtr.Zero)
					id_getTiltGesturesEnabled = JNIEnv.GetMethodID (class_ref, "getTiltGesturesEnabled", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getTiltGesturesEnabled), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getUseViewLifecycleInFragment;
		public global::Java.Lang.Boolean UseViewLifecycleInFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getUseViewLifecycleInFragment' and count(parameter)=0]"
			[Register ("getUseViewLifecycleInFragment", "()Ljava/lang/Boolean;", "GetGetUseViewLifecycleInFragmentHandler")]
			get {
				if (id_getUseViewLifecycleInFragment == IntPtr.Zero)
					id_getUseViewLifecycleInFragment = JNIEnv.GetMethodID (class_ref, "getUseViewLifecycleInFragment", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getUseViewLifecycleInFragment), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getZoomControlsEnabled;
		public global::Java.Lang.Boolean ZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getZoomControlsEnabled' and count(parameter)=0]"
			[Register ("getZoomControlsEnabled", "()Ljava/lang/Boolean;", "GetGetZoomControlsEnabledHandler")]
			get {
				if (id_getZoomControlsEnabled == IntPtr.Zero)
					id_getZoomControlsEnabled = JNIEnv.GetMethodID (class_ref, "getZoomControlsEnabled", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getZoomControlsEnabled), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getZoomGesturesEnabled;
		public global::Java.Lang.Boolean ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("getZoomGesturesEnabled", "()Ljava/lang/Boolean;", "GetGetZoomGesturesEnabledHandler")]
			get {
				if (id_getZoomGesturesEnabled == IntPtr.Zero)
					id_getZoomGesturesEnabled = JNIEnv.GetMethodID (class_ref, "getZoomGesturesEnabled", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getZoomGesturesEnabled), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getZOrderOnTop;
		public global::Java.Lang.Boolean ZOrderOnTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='getZOrderOnTop' and count(parameter)=0]"
			[Register ("getZOrderOnTop", "()Ljava/lang/Boolean;", "GetGetZOrderOnTopHandler")]
			get {
				if (id_getZOrderOnTop == IntPtr.Zero)
					id_getZOrderOnTop = JNIEnv.GetMethodID (class_ref, "getZOrderOnTop", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getZOrderOnTop), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_aH;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aH' and count(parameter)=0]"
		[Register ("aH", "()B", "")]
		public sbyte AH ()
		{
			if (id_aH == IntPtr.Zero)
				id_aH = JNIEnv.GetMethodID (class_ref, "aH", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aH);
		}

		static IntPtr id_aI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aI' and count(parameter)=0]"
		[Register ("aI", "()B", "")]
		public sbyte AI ()
		{
			if (id_aI == IntPtr.Zero)
				id_aI = JNIEnv.GetMethodID (class_ref, "aI", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aI);
		}

		static IntPtr id_aJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aJ' and count(parameter)=0]"
		[Register ("aJ", "()B", "")]
		public sbyte AJ ()
		{
			if (id_aJ == IntPtr.Zero)
				id_aJ = JNIEnv.GetMethodID (class_ref, "aJ", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aJ);
		}

		static IntPtr id_aK;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aK' and count(parameter)=0]"
		[Register ("aK", "()B", "")]
		public sbyte AK ()
		{
			if (id_aK == IntPtr.Zero)
				id_aK = JNIEnv.GetMethodID (class_ref, "aK", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aK);
		}

		static IntPtr id_aL;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aL' and count(parameter)=0]"
		[Register ("aL", "()B", "")]
		public sbyte AL ()
		{
			if (id_aL == IntPtr.Zero)
				id_aL = JNIEnv.GetMethodID (class_ref, "aL", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aL);
		}

		static IntPtr id_aM;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aM' and count(parameter)=0]"
		[Register ("aM", "()B", "")]
		public sbyte AM ()
		{
			if (id_aM == IntPtr.Zero)
				id_aM = JNIEnv.GetMethodID (class_ref, "aM", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aM);
		}

		static IntPtr id_aN;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aN' and count(parameter)=0]"
		[Register ("aN", "()B", "")]
		public sbyte AN ()
		{
			if (id_aN == IntPtr.Zero)
				id_aN = JNIEnv.GetMethodID (class_ref, "aN", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aN);
		}

		static IntPtr id_aO;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='aO' and count(parameter)=0]"
		[Register ("aO", "()B", "")]
		public sbyte AO ()
		{
			if (id_aO == IntPtr.Zero)
				id_aO = JNIEnv.GetMethodID (class_ref, "aO", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_aO);
		}

		static IntPtr id_camera_Lcom_google_android_gms_maps_model_CameraPosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='camera' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.CameraPosition']]"
		[Register ("camera", "(Lcom/google/android/gms/maps/model/CameraPosition;)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeCamera (global::Android.Gms.Maps.Model.CameraPosition p0)
		{
			if (id_camera_Lcom_google_android_gms_maps_model_CameraPosition_ == IntPtr.Zero)
				id_camera_Lcom_google_android_gms_maps_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "camera", "(Lcom/google/android/gms/maps/model/CameraPosition;)Lcom/google/android/gms/maps/GoogleMapOptions;");
			global::Android.Gms.Maps.GoogleMapOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_camera_Lcom_google_android_gms_maps_model_CameraPosition_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_compassEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='compassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("compassEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeCompassEnabled (bool p0)
		{
			if (id_compassEnabled_Z == IntPtr.Zero)
				id_compassEnabled_Z = JNIEnv.GetMethodID (class_ref, "compassEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_compassEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='createFromAttributes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("createFromAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public static global::Android.Gms.Maps.GoogleMapOptions CreateFromAttributes (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
		{
			if (id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetStaticMethodID (class_ref, "createFromAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/google/android/gms/maps/GoogleMapOptions;");
			global::Android.Gms.Maps.GoogleMapOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromAttributes_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_mapType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='mapType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mapType", "(I)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeMapType (int p0)
		{
			if (id_mapType_I == IntPtr.Zero)
				id_mapType_I = JNIEnv.GetMethodID (class_ref, "mapType", "(I)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_mapType_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_rotateGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='rotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rotateGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeRotateGesturesEnabled (bool p0)
		{
			if (id_rotateGesturesEnabled_Z == IntPtr.Zero)
				id_rotateGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "rotateGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_rotateGesturesEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_scrollGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='scrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeScrollGesturesEnabled (bool p0)
		{
			if (id_scrollGesturesEnabled_Z == IntPtr.Zero)
				id_scrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "scrollGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_scrollGesturesEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_tiltGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='tiltGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("tiltGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeTiltGesturesEnabled (bool p0)
		{
			if (id_tiltGesturesEnabled_Z == IntPtr.Zero)
				id_tiltGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "tiltGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_tiltGesturesEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_u;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='u' and count(parameter)=0]"
		[Register ("u", "()I", "")]
		public int U ()
		{
			if (id_u == IntPtr.Zero)
				id_u = JNIEnv.GetMethodID (class_ref, "u", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_u);
		}

		static IntPtr id_useViewLifecycleInFragment_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='useViewLifecycleInFragment' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("useViewLifecycleInFragment", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeUseViewLifecycleInFragment (bool p0)
		{
			if (id_useViewLifecycleInFragment_Z == IntPtr.Zero)
				id_useViewLifecycleInFragment_Z = JNIEnv.GetMethodID (class_ref, "useViewLifecycleInFragment", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_useViewLifecycleInFragment_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_zOrderOnTop_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='zOrderOnTop' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zOrderOnTop", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeZOrderOnTop (bool p0)
		{
			if (id_zOrderOnTop_Z == IntPtr.Zero)
				id_zOrderOnTop_Z = JNIEnv.GetMethodID (class_ref, "zOrderOnTop", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_zOrderOnTop_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zoomControlsEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='zoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomControlsEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeZoomControlsEnabled (bool p0)
		{
			if (id_zoomControlsEnabled_Z == IntPtr.Zero)
				id_zoomControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "zoomControlsEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_zoomControlsEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zoomGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='GoogleMapOptions']/method[@name='zoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;", "")]
		public global::Android.Gms.Maps.GoogleMapOptions InvokeZoomGesturesEnabled (bool p0)
		{
			if (id_zoomGesturesEnabled_Z == IntPtr.Zero)
				id_zoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "zoomGesturesEnabled", "(Z)Lcom/google/android/gms/maps/GoogleMapOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_zoomGesturesEnabled_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
