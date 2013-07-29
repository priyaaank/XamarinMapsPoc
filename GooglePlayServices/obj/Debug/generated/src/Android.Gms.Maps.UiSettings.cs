using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/UiSettings", DoNotGenerateAcw=true)]
	public sealed partial class UiSettings : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/UiSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UiSettings); }
		}

		internal UiSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isCompassEnabled;
		static IntPtr id_setCompassEnabled_Z;
		public bool CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler")]
			get {
				if (id_isCompassEnabled == IntPtr.Zero)
					id_isCompassEnabled = JNIEnv.GetMethodID (class_ref, "isCompassEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isCompassEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setCompassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompassEnabled", "(Z)V", "GetSetCompassEnabled_ZHandler")]
			set {
				if (id_setCompassEnabled_Z == IntPtr.Zero)
					id_setCompassEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCompassEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setCompassEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_isMyLocationButtonEnabled;
		static IntPtr id_setMyLocationButtonEnabled_Z;
		public bool MyLocationButtonEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='isMyLocationButtonEnabled' and count(parameter)=0]"
			[Register ("isMyLocationButtonEnabled", "()Z", "GetIsMyLocationButtonEnabledHandler")]
			get {
				if (id_isMyLocationButtonEnabled == IntPtr.Zero)
					id_isMyLocationButtonEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationButtonEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isMyLocationButtonEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setMyLocationButtonEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationButtonEnabled", "(Z)V", "GetSetMyLocationButtonEnabled_ZHandler")]
			set {
				if (id_setMyLocationButtonEnabled_Z == IntPtr.Zero)
					id_setMyLocationButtonEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMyLocationButtonEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setMyLocationButtonEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_isRotateGesturesEnabled;
		static IntPtr id_setRotateGesturesEnabled_Z;
		public bool RotateGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='isRotateGesturesEnabled' and count(parameter)=0]"
			[Register ("isRotateGesturesEnabled", "()Z", "GetIsRotateGesturesEnabledHandler")]
			get {
				if (id_isRotateGesturesEnabled == IntPtr.Zero)
					id_isRotateGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isRotateGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isRotateGesturesEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setRotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRotateGesturesEnabled", "(Z)V", "GetSetRotateGesturesEnabled_ZHandler")]
			set {
				if (id_setRotateGesturesEnabled_Z == IntPtr.Zero)
					id_setRotateGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setRotateGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setRotateGesturesEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_isScrollGesturesEnabled;
		static IntPtr id_setScrollGesturesEnabled_Z;
		public bool ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler")]
			get {
				if (id_isScrollGesturesEnabled == IntPtr.Zero)
					id_isScrollGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isScrollGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isScrollGesturesEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler")]
			set {
				if (id_setScrollGesturesEnabled_Z == IntPtr.Zero)
					id_setScrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScrollGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setScrollGesturesEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_isTiltGesturesEnabled;
		static IntPtr id_setTiltGesturesEnabled_Z;
		public bool TiltGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='isTiltGesturesEnabled' and count(parameter)=0]"
			[Register ("isTiltGesturesEnabled", "()Z", "GetIsTiltGesturesEnabledHandler")]
			get {
				if (id_isTiltGesturesEnabled == IntPtr.Zero)
					id_isTiltGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isTiltGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isTiltGesturesEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setTiltGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTiltGesturesEnabled", "(Z)V", "GetSetTiltGesturesEnabled_ZHandler")]
			set {
				if (id_setTiltGesturesEnabled_Z == IntPtr.Zero)
					id_setTiltGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTiltGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTiltGesturesEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_isZoomControlsEnabled;
		static IntPtr id_setZoomControlsEnabled_Z;
		public bool ZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='isZoomControlsEnabled' and count(parameter)=0]"
			[Register ("isZoomControlsEnabled", "()Z", "GetIsZoomControlsEnabledHandler")]
			get {
				if (id_isZoomControlsEnabled == IntPtr.Zero)
					id_isZoomControlsEnabled = JNIEnv.GetMethodID (class_ref, "isZoomControlsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isZoomControlsEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setZoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomControlsEnabled", "(Z)V", "GetSetZoomControlsEnabled_ZHandler")]
			set {
				if (id_setZoomControlsEnabled_Z == IntPtr.Zero)
					id_setZoomControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomControlsEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setZoomControlsEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_isZoomGesturesEnabled;
		static IntPtr id_setZoomGesturesEnabled_Z;
		public bool ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler")]
			get {
				if (id_isZoomGesturesEnabled == IntPtr.Zero)
					id_isZoomGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isZoomGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isZoomGesturesEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomGesturesEnabled", "(Z)V", "GetSetZoomGesturesEnabled_ZHandler")]
			set {
				if (id_setZoomGesturesEnabled_Z == IntPtr.Zero)
					id_setZoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setZoomGesturesEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_setAllGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps']/class[@name='UiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "")]
		public void SetAllGesturesEnabled (bool p0)
		{
			if (id_setAllGesturesEnabled_Z == IntPtr.Zero)
				id_setAllGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAllGesturesEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setAllGesturesEnabled_Z, new JValue (p0));
		}

	}
}
