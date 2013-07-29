using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/PolygonOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolygonOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/PolygonOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolygonOptions); }
		}

		internal PolygonOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/constructor[@name='PolygonOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PolygonOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PolygonOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getFillColor;
		public int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
			}
		}

		static IntPtr id_getHoles;
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng>> Holes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='getHoles' and count(parameter)=0]"
			[Register ("getHoles", "()Ljava/util/List;", "GetGetHolesHandler")]
			get {
				if (id_getHoles == IntPtr.Zero)
					id_getHoles = JNIEnv.GetMethodID (class_ref, "getHoles", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHoles), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isGeodesic;
		public bool IsGeodesic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='isGeodesic' and count(parameter)=0]"
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler")]
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isGeodesic);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getPoints;
		public global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Maps.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStrokeColor;
		public int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
			}
		}

		static IntPtr id_getStrokeWidth;
		public float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
			}
		}

		static IntPtr id_getZIndex;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
		}

		static IntPtr id_add_Lcom_google_android_gms_maps_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.LatLng']]"
		[Register ("add", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions Add (global::Android.Gms.Maps.Model.LatLng p0)
		{
			if (id_add_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_add_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolygonOptions;");
			global::Android.Gms.Maps.Model.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_Lcom_google_android_gms_maps_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_add_arrayLcom_google_android_gms_maps_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.LatLng[]']]"
		[Register ("add", "([Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions Add (params global:: Android.Gms.Maps.Model.LatLng[] p0)
		{
			if (id_add_arrayLcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
				id_add_arrayLcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "([Lcom/google/android/gms/maps/model/LatLng;)Lcom/google/android/gms/maps/model/PolygonOptions;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Android.Gms.Maps.Model.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_arrayLcom_google_android_gms_maps_model_LatLng_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_addAll_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("addAll", "(Ljava/lang/Iterable;)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions AddAll (global::Java.Lang.IIterable p0)
		{
			if (id_addAll_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_addAll_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/lang/Iterable;)Lcom/google/android/gms/maps/model/PolygonOptions;");
			global::Android.Gms.Maps.Model.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_addAll_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_addHole_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='addHole' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("addHole", "(Ljava/lang/Iterable;)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions AddHole (global::Java.Lang.IIterable p0)
		{
			if (id_addHole_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_addHole_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "addHole", "(Ljava/lang/Iterable;)Lcom/google/android/gms/maps/model/PolygonOptions;");
			global::Android.Gms.Maps.Model.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_addHole_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_ba;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='ba' and count(parameter)=0]"
		[Register ("ba", "()Ljava/util/List;", "")]
		public global::System.Collections.IList Ba ()
		{
			if (id_ba == IntPtr.Zero)
				id_ba = JNIEnv.GetMethodID (class_ref, "ba", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_ba), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_fillColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillColor", "(I)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions InvokeFillColor (int p0)
		{
			if (id_fillColor_I == IntPtr.Zero)
				id_fillColor_I = JNIEnv.GetMethodID (class_ref, "fillColor", "(I)Lcom/google/android/gms/maps/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_fillColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_geodesic_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='geodesic' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("geodesic", "(Z)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions Geodesic (bool p0)
		{
			if (id_geodesic_Z == IntPtr.Zero)
				id_geodesic_Z = JNIEnv.GetMethodID (class_ref, "geodesic", "(Z)Lcom/google/android/gms/maps/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_geodesic_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='strokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("strokeColor", "(I)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions InvokeStrokeColor (int p0)
		{
			if (id_strokeColor_I == IntPtr.Zero)
				id_strokeColor_I = JNIEnv.GetMethodID (class_ref, "strokeColor", "(I)Lcom/google/android/gms/maps/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='strokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("strokeWidth", "(F)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions InvokeStrokeWidth (float p0)
		{
			if (id_strokeWidth_F == IntPtr.Zero)
				id_strokeWidth_F = JNIEnv.GetMethodID (class_ref, "strokeWidth", "(F)Lcom/google/android/gms/maps/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeWidth_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_u;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='u' and count(parameter)=0]"
		[Register ("u", "()I", "")]
		public int U ()
		{
			if (id_u == IntPtr.Zero)
				id_u = JNIEnv.GetMethodID (class_ref, "u", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_u);
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/google/android/gms/maps/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_zIndex_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='PolygonOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/google/android/gms/maps/model/PolygonOptions;", "")]
		public global::Android.Gms.Maps.Model.PolygonOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/google/android/gms/maps/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
