using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/GooglePlayServicesUtil", DoNotGenerateAcw=true)]
	public sealed partial class GooglePlayServicesUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/field[@name='GOOGLE_PLAY_SERVICES_PACKAGE']"
		[Register ("GOOGLE_PLAY_SERVICES_PACKAGE")]
		public const string GooglePlayServicesPackage = (string) "com.google.android.gms";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/field[@name='GOOGLE_PLAY_SERVICES_VERSION_CODE']"
		[Register ("GOOGLE_PLAY_SERVICES_VERSION_CODE")]
		public const int GooglePlayServicesVersionCode = (int) 3159100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/field[@name='GOOGLE_PLAY_STORE_PACKAGE']"
		[Register ("GOOGLE_PLAY_STORE_PACKAGE")]
		public const string GooglePlayStorePackage = (string) "com.android.vending";

		static IntPtr H_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/field[@name='H']"
		[Register ("H")]
		public static bool H {
			get {
				if (H_jfieldId == IntPtr.Zero)
					H_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "H", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, H_jfieldId);
			}
			set {
				if (H_jfieldId == IntPtr.Zero)
					H_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "H", "Z");
				JNIEnv.SetStaticField (class_ref, H_jfieldId, value);
			}
		}

		static IntPtr I_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/field[@name='I']"
		[Register ("I")]
		public static bool I {
			get {
				if (I_jfieldId == IntPtr.Zero)
					I_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "I", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, I_jfieldId);
			}
			set {
				if (I_jfieldId == IntPtr.Zero)
					I_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "I", "Z");
				JNIEnv.SetStaticField (class_ref, I_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/GooglePlayServicesUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GooglePlayServicesUtil); }
		}

		internal GooglePlayServicesUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("a", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static string A (global::Android.Content.Context p0, int p1)
		{
			if (id_a_Landroid_content_Context_I == IntPtr.Zero)
				id_a_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;I)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("a", "(Landroid/content/Context;II)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent A (global::Android.Content.Context p0, int p1, int p2)
		{
			if (id_a_Landroid_content_Context_II == IntPtr.Zero)
				id_a_Landroid_content_Context_II = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;II)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_II, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_content_res_Resources_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources']]"
		[Register ("a", "(Landroid/content/res/Resources;)Z", "")]
		public static bool A (global::Android.Content.Res.Resources p0)
		{
			if (id_a_Landroid_content_res_Resources_ == IntPtr.Zero)
				id_a_Landroid_content_res_Resources_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/res/Resources;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_res_Resources_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='a' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener'] and parameter[5][@type='int']]"
		[Register ("a", "(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;I)Landroid/app/Dialog;", "")]
		public static global::Android.App.Dialog A (int p0, global::Android.App.Activity p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3, int p4)
		{
			if (id_a_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_I == IntPtr.Zero)
				id_a_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;I)Landroid/app/Dialog;");
			global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Landroid_content_Context_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='b' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("b", "(Landroid/content/Context;II)Ljava/lang/String;", "")]
		public static string B (global::Android.Content.Context p0, int p1, int p2)
		{
			if (id_b_Landroid_content_Context_II == IntPtr.Zero)
				id_b_Landroid_content_Context_II = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;II)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_content_Context_II, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorDialog_ILandroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='getErrorDialog' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int']]"
		[Register ("getErrorDialog", "(ILandroid/app/Activity;I)Landroid/app/Dialog;", "")]
		public static global::Android.App.Dialog GetErrorDialog (int p0, global::Android.App.Activity p1, int p2)
		{
			if (id_getErrorDialog_ILandroid_app_Activity_I == IntPtr.Zero)
				id_getErrorDialog_ILandroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "getErrorDialog", "(ILandroid/app/Activity;I)Landroid/app/Dialog;");
			global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorDialog_ILandroid_app_Activity_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorDialog_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='getErrorDialog' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("getErrorDialog", "(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;", "")]
		public static global::Android.App.Dialog GetErrorDialog (int p0, global::Android.App.Activity p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3)
		{
			if (id_getErrorDialog_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_ == IntPtr.Zero)
				id_getErrorDialog_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorDialog", "(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;");
			global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorDialog_ILandroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorPendingIntent_ILandroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='getErrorPendingIntent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int']]"
		[Register ("getErrorPendingIntent", "(ILandroid/content/Context;I)Landroid/app/PendingIntent;", "")]
		public static global::Android.App.PendingIntent GetErrorPendingIntent (int p0, global::Android.Content.Context p1, int p2)
		{
			if (id_getErrorPendingIntent_ILandroid_content_Context_I == IntPtr.Zero)
				id_getErrorPendingIntent_ILandroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getErrorPendingIntent", "(ILandroid/content/Context;I)Landroid/app/PendingIntent;");
			global::Android.App.PendingIntent __ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorPendingIntent_ILandroid_content_Context_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='getErrorString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorString", "(I)Ljava/lang/String;", "")]
		public static string GetErrorString (int p0)
		{
			if (id_getErrorString_I == IntPtr.Zero)
				id_getErrorString_I = JNIEnv.GetStaticMethodID (class_ref, "getErrorString", "(I)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='getOpenSourceSoftwareLicenseInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetOpenSourceSoftwareLicenseInfo (global::Android.Content.Context p0)
		{
			if (id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRemoteContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='getRemoteContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteContext", "(Landroid/content/Context;)Landroid/content/Context;", "")]
		public static global::Android.Content.Context GetRemoteContext (global::Android.Content.Context p0)
		{
			if (id_getRemoteContext_Landroid_content_Context_ == IntPtr.Zero)
				id_getRemoteContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteContext", "(Landroid/content/Context;)Landroid/content/Context;");
			global::Android.Content.Context __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteContext_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRemoteResource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='getRemoteResource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteResource", "(Landroid/content/Context;)Landroid/content/res/Resources;", "")]
		public static global::Android.Content.Res.Resources GetRemoteResource (global::Android.Content.Context p0)
		{
			if (id_getRemoteResource_Landroid_content_Context_ == IntPtr.Zero)
				id_getRemoteResource_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteResource", "(Landroid/content/Context;)Landroid/content/res/Resources;");
			global::Android.Content.Res.Resources __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteResource_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_isGooglePlayServicesAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='isGooglePlayServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isGooglePlayServicesAvailable", "(Landroid/content/Context;)I", "")]
		public static int IsGooglePlayServicesAvailable (global::Android.Content.Context p0)
		{
			if (id_isGooglePlayServicesAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isGooglePlayServicesAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isGooglePlayServicesAvailable", "(Landroid/content/Context;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_isGooglePlayServicesAvailable_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isUserRecoverableError_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='GooglePlayServicesUtil']/method[@name='isUserRecoverableError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUserRecoverableError", "(I)Z", "")]
		public static bool IsUserRecoverableError (int p0)
		{
			if (id_isUserRecoverableError_I == IntPtr.Zero)
				id_isUserRecoverableError_I = JNIEnv.GetStaticMethodID (class_ref, "isUserRecoverableError", "(I)Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUserRecoverableError_I, new JValue (p0));
		}

	}
}
