using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Maps.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']"
	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/BitmapDescriptorFactory", DoNotGenerateAcw=true)]
	public sealed partial class BitmapDescriptorFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_AZURE']"
		[Register ("HUE_AZURE")]
		public const float HueAzure = (float) 210.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_BLUE']"
		[Register ("HUE_BLUE")]
		public const float HueBlue = (float) 240.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_CYAN']"
		[Register ("HUE_CYAN")]
		public const float HueCyan = (float) 180.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_GREEN']"
		[Register ("HUE_GREEN")]
		public const float HueGreen = (float) 120.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_MAGENTA']"
		[Register ("HUE_MAGENTA")]
		public const float HueMagenta = (float) 300.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_ORANGE']"
		[Register ("HUE_ORANGE")]
		public const float HueOrange = (float) 30.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_RED']"
		[Register ("HUE_RED")]
		public const float HueRed = (float) 0.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_ROSE']"
		[Register ("HUE_ROSE")]
		public const float HueRose = (float) 330.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_VIOLET']"
		[Register ("HUE_VIOLET")]
		public const float HueViolet = (float) 270.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_YELLOW']"
		[Register ("HUE_YELLOW")]
		public const float HueYellow = (float) 60.000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/maps/model/BitmapDescriptorFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapDescriptorFactory); }
		}

		internal BitmapDescriptorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_defaultMarker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/method[@name='defaultMarker' and count(parameter)=0]"
		[Register ("defaultMarker", "()Lcom/google/android/gms/maps/model/BitmapDescriptor;", "")]
		public static global::Android.Gms.Maps.Model.BitmapDescriptor DefaultMarker ()
		{
			if (id_defaultMarker == IntPtr.Zero)
				id_defaultMarker = JNIEnv.GetStaticMethodID (class_ref, "defaultMarker", "()Lcom/google/android/gms/maps/model/BitmapDescriptor;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultMarker), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_defaultMarker_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/method[@name='defaultMarker' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("defaultMarker", "(F)Lcom/google/android/gms/maps/model/BitmapDescriptor;", "")]
		public static global::Android.Gms.Maps.Model.BitmapDescriptor DefaultMarker (float p0)
		{
			if (id_defaultMarker_F == IntPtr.Zero)
				id_defaultMarker_F = JNIEnv.GetStaticMethodID (class_ref, "defaultMarker", "(F)Lcom/google/android/gms/maps/model/BitmapDescriptor;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultMarker_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fromAsset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/BitmapDescriptor;", "")]
		public static global::Android.Gms.Maps.Model.BitmapDescriptor FromAsset (string p0)
		{
			if (id_fromAsset_Ljava_lang_String_ == IntPtr.Zero)
				id_fromAsset_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromAsset", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Gms.Maps.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAsset_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fromBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/google/android/gms/maps/model/BitmapDescriptor;", "")]
		public static global::Android.Gms.Maps.Model.BitmapDescriptor FromBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_fromBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_fromBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/google/android/gms/maps/model/BitmapDescriptor;");
			global::Android.Gms.Maps.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBitmap_Landroid_graphics_Bitmap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_fromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromFile", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/BitmapDescriptor;", "")]
		public static global::Android.Gms.Maps.Model.BitmapDescriptor FromFile (string p0)
		{
			if (id_fromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_fromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromFile", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Gms.Maps.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fromPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromPath", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/BitmapDescriptor;", "")]
		public static global::Android.Gms.Maps.Model.BitmapDescriptor FromPath (string p0)
		{
			if (id_fromPath_Ljava_lang_String_ == IntPtr.Zero)
				id_fromPath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromPath", "(Ljava/lang/String;)Lcom/google/android/gms/maps/model/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Gms.Maps.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromPath_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fromResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.maps.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/google/android/gms/maps/model/BitmapDescriptor;", "")]
		public static global::Android.Gms.Maps.Model.BitmapDescriptor FromResource (int p0)
		{
			if (id_fromResource_I == IntPtr.Zero)
				id_fromResource_I = JNIEnv.GetStaticMethodID (class_ref, "fromResource", "(I)Lcom/google/android/gms/maps/model/BitmapDescriptor;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromResource_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
