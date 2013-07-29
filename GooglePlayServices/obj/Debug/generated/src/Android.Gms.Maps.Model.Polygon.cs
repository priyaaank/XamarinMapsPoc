using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/Polygon", DoNotGenerateAcw=true)]
	public sealed partial class Polygon : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/Polygon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polygon); }
		}

		internal Polygon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setFillColor_I, new JValue (value));
			}
		}

		static IntPtr id_isGeodesic;
		static IntPtr id_setGeodesic_Z;
		public bool Geodesic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='isGeodesic' and count(parameter)=0]"
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler")]
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isGeodesic);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setGeodesic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGeodesic", "(Z)V", "GetSetGeodesic_ZHandler")]
			set {
				if (id_setGeodesic_Z == IntPtr.Zero)
					id_setGeodesic_Z = JNIEnv.GetMethodID (class_ref, "setGeodesic", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setGeodesic_Z, new JValue (value));
			}
		}

		static IntPtr id_getHoles;
		static IntPtr id_setHoles_Ljava_util_List_;
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng>> Holes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='getHoles' and count(parameter)=0]"
			[Register ("getHoles", "()Ljava/util/List;", "GetGetHolesHandler")]
			get {
				if (id_getHoles == IntPtr.Zero)
					id_getHoles = JNIEnv.GetMethodID (class_ref, "getHoles", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHoles), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setHoles' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setHoles", "(Ljava/util/List;)V", "GetSetHoles_Ljava_util_List_Handler")]
			set {
				if (id_setHoles_Ljava_util_List_ == IntPtr.Zero)
					id_setHoles_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setHoles", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng>>.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod  (Handle, id_setHoles_Ljava_util_List_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (value)));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getId;
		public string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPoints;
		static IntPtr id_setPoints_Ljava_util_List_;
		public global::System.Collections.Generic.IList<global::Android.Gms.Maps.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Maps.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Gms.Maps.Model.LatLng>.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod  (Handle, id_setPoints_Ljava_util_List_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (value)));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getStrokeColor;
		static IntPtr id_setStrokeColor_I;
		public int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
			set {
				if (id_setStrokeColor_I == IntPtr.Zero)
					id_setStrokeColor_I = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setStrokeColor_I, new JValue (value));
			}
		}

		static IntPtr id_getStrokeWidth;
		static IntPtr id_setStrokeWidth_F;
		public float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler")]
			set {
				if (id_setStrokeWidth_F == IntPtr.Zero)
					id_setStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setStrokeWidth_F, new JValue (value));
			}
		}

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_F;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler")]
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setZIndex_F, new JValue (value));
			}
		}

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Polygon']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

	}
}
