using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Auth {

	[global::Android.Runtime.Register ("com/google/android/gms/auth/GoogleAuthUtil", DoNotGenerateAcw=true)]
	public sealed partial class GoogleAuthUtil : global::Java.Lang.Object {


		[Register ("GOOGLE_ACCOUNT_TYPE")]
		public const string GoogleAccountType = (string) "com.google";

		[Register ("KEY_HANDLE_NOTIFICATION")]
		public const string KeyHandleNotification = (string) "handle_notification";

		[Register ("KEY_REQUEST_VISIBLE_ACTIVITIES")]
		public const string KeyRequestVisibleActivities = (string) "request_visible_actions";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/auth/GoogleAuthUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GoogleAuthUtil); }
		}

		internal GoogleAuthUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		[Register ("getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetToken (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		[Register ("getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static string GetToken (global::Android.Content.Context p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		[Register ("getTokenWithNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static string GetTokenWithNotification (global::Android.Content.Context p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getTokenWithNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_Intent_;
		[Register ("getTokenWithNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/content/Intent;)Ljava/lang/String;", "")]
		public static string GetTokenWithNotification (global::Android.Content.Context p0, string p1, string p2, global::Android.OS.Bundle p3, global::Android.Content.Intent p4)
		{
			if (id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_Intent_ == IntPtr.Zero)
				id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getTokenWithNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/content/Intent;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_Intent_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_os_Bundle_;
		[Register ("getTokenWithNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static string GetTokenWithNotification (global::Android.Content.Context p0, string p1, string p2, global::Android.OS.Bundle p3, string p4, global::Android.OS.Bundle p5)
		{
			if (id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getTokenWithNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTokenWithNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_invalidateToken_Landroid_content_Context_Ljava_lang_String_;
		[Register ("invalidateToken", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void InvalidateToken (global::Android.Content.Context p0, string p1)
		{
			if (id_invalidateToken_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_invalidateToken_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "invalidateToken", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_invalidateToken_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
