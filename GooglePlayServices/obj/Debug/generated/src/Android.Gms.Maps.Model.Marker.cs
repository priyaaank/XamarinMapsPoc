using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/Marker", DoNotGenerateAcw=true)]
	public sealed partial class Marker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/Marker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Marker); }
		}

		internal Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isDraggable;
		static IntPtr id_setDraggable_Z;
		public bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDraggable);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set {
				if (id_setDraggable_Z == IntPtr.Zero)
					id_setDraggable_Z = JNIEnv.GetMethodID (class_ref, "setDraggable", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setDraggable_Z, new JValue (value));
			}
		}

		static IntPtr id_getId;
		public string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isInfoWindowShown;
		public bool IsInfoWindowShown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='isInfoWindowShown' and count(parameter)=0]"
			[Register ("isInfoWindowShown", "()Z", "GetIsInfoWindowShownHandler")]
			get {
				if (id_isInfoWindowShown == IntPtr.Zero)
					id_isInfoWindowShown = JNIEnv.GetMethodID (class_ref, "isInfoWindowShown", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isInfoWindowShown);
			}
		}

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lcom_google_android_gms_maps_model_LatLng_;
		public global::Android.Gms.Maps.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/google/android/gms/maps/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/google/android/gms/maps/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.LatLng']]"
			[Register ("setPosition", "(Lcom/google/android/gms/maps/model/LatLng;)V", "GetSetPosition_Lcom_google_android_gms_maps_model_LatLng_Handler")]
			set {
				if (id_setPosition_Lcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
					id_setPosition_Lcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/google/android/gms/maps/model/LatLng;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setPosition_Lcom_google_android_gms_maps_model_LatLng_, new JValue (value));
			}
		}

		static IntPtr id_getSnippet;
		static IntPtr id_setSnippet_Ljava_lang_String_;
		public string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSnippet", "(Ljava/lang/String;)V", "GetSetSnippet_Ljava_lang_String_Handler")]
			set {
				if (id_setSnippet_Ljava_lang_String_ == IntPtr.Zero)
					id_setSnippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSnippet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setSnippet_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static IntPtr id_hideInfoWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "")]
		public void HideInfoWindow ()
		{
			if (id_hideInfoWindow == IntPtr.Zero)
				id_hideInfoWindow = JNIEnv.GetMethodID (class_ref, "hideInfoWindow", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_hideInfoWindow);
		}

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

		static IntPtr id_setAnchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "")]
		public void SetAnchor (float p0, float p1)
		{
			if (id_setAnchor_FF == IntPtr.Zero)
				id_setAnchor_FF = JNIEnv.GetMethodID (class_ref, "setAnchor", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_setAnchor_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setIcon_Lcom_google_android_gms_maps_model_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.BitmapDescriptor']]"
		[Register ("setIcon", "(Lcom/google/android/gms/maps/model/BitmapDescriptor;)V", "")]
		public void SetIcon (global::Android.Gms.Maps.Model.BitmapDescriptor p0)
		{
			if (id_setIcon_Lcom_google_android_gms_maps_model_BitmapDescriptor_ == IntPtr.Zero)
				id_setIcon_Lcom_google_android_gms_maps_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Lcom/google/android/gms/maps/model/BitmapDescriptor;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setIcon_Lcom_google_android_gms_maps_model_BitmapDescriptor_, new JValue (p0));
		}

		static IntPtr id_showInfoWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='Marker']/method[@name='showInfoWindow' and count(parameter)=0]"
		[Register ("showInfoWindow", "()V", "")]
		public void ShowInfoWindow ()
		{
			if (id_showInfoWindow == IntPtr.Zero)
				id_showInfoWindow = JNIEnv.GetMethodID (class_ref, "showInfoWindow", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_showInfoWindow);
		}

	}
}
