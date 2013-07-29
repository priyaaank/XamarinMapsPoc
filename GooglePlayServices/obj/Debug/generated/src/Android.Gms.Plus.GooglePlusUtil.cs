using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']"
	[global::Android.Runtime.Register ("com/google/android/gms/plus/GooglePlusUtil", DoNotGenerateAcw=true)]
	public partial class GooglePlusUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/field[@name='APP_DISABLED']"
		[Register ("APP_DISABLED")]
		public const int AppDisabled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/field[@name='APP_MISSING']"
		[Register ("APP_MISSING")]
		public const int AppMissing = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/field[@name='APP_UPDATE_REQUIRED']"
		[Register ("APP_UPDATE_REQUIRED")]
		public const int AppUpdateRequired = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/field[@name='GOOGLE_PLUS_PACKAGE']"
		[Register ("GOOGLE_PLUS_PACKAGE")]
		public const string GooglePlusPackage = (string) "com.google.android.apps.plus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/field[@name='PLATFORM_LOGGING_TAG']"
		[Register ("PLATFORM_LOGGING_TAG")]
		public const string PlatformLoggingTag = (string) "GooglePlusPlatform";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/GooglePlusUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GooglePlusUtil); }
		}

		protected GooglePlusUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkGooglePlusApp_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/method[@name='checkGooglePlusApp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkGooglePlusApp", "(Landroid/content/Context;)I", "")]
		public static int CheckGooglePlusApp (global::Android.Content.Context p0)
		{
			if (id_checkGooglePlusApp_Landroid_content_Context_ == IntPtr.Zero)
				id_checkGooglePlusApp_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkGooglePlusApp", "(Landroid/content/Context;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_checkGooglePlusApp_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getErrorDialog_ILandroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.plus']/class[@name='GooglePlusUtil']/method[@name='getErrorDialog' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int']]"
		[Register ("getErrorDialog", "(ILandroid/app/Activity;I)Landroid/app/Dialog;", "")]
		public static global::Android.App.Dialog GetErrorDialog (int p0, global::Android.App.Activity p1, int p2)
		{
			if (id_getErrorDialog_ILandroid_app_Activity_I == IntPtr.Zero)
				id_getErrorDialog_ILandroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "getErrorDialog", "(ILandroid/app/Activity;I)Landroid/app/Dialog;");
			global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorDialog_ILandroid_app_Activity_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
