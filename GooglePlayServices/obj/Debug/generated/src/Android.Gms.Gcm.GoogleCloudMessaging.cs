using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Gcm {

	[global::Android.Runtime.Register ("com/google/android/gms/gcm/GoogleCloudMessaging", DoNotGenerateAcw=true)]
	public partial class GoogleCloudMessaging : global::Java.Lang.Object {


		[Register ("ERROR_MAIN_THREAD")]
		public const string ErrorMainThread = (string) "MAIN_THREAD";

		[Register ("ERROR_SERVICE_NOT_AVAILABLE")]
		public const string ErrorServiceNotAvailable = (string) "SERVICE_NOT_AVAILABLE";

		[Register ("MESSAGE_TYPE_DELETED")]
		public const string MessageTypeDeleted = (string) "deleted_messages";

		[Register ("MESSAGE_TYPE_MESSAGE")]
		public const string MessageTypeMessage = (string) "gcm";

		[Register ("MESSAGE_TYPE_SEND_ERROR")]
		public const string MessageTypeSendError = (string) "send_error";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/gcm/GoogleCloudMessaging", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GoogleCloudMessaging); }
		}

		protected GoogleCloudMessaging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public GoogleCloudMessaging () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GoogleCloudMessaging)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Gcm.GoogleCloudMessaging __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Gcm.GoogleCloudMessaging> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_close);
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/google/android/gms/gcm/GoogleCloudMessaging;", "")]
		public static global::Android.Gms.Gcm.GoogleCloudMessaging GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/google/android/gms/gcm/GoogleCloudMessaging;");
			global::Android.Gms.Gcm.GoogleCloudMessaging __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Gcm.GoogleCloudMessaging> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getMessageType_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetGetMessageType_Landroid_content_Intent_Handler ()
		{
			if (cb_getMessageType_Landroid_content_Intent_ == null)
				cb_getMessageType_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageType_Landroid_content_Intent_);
			return cb_getMessageType_Landroid_content_Intent_;
		}

		static IntPtr n_GetMessageType_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Gcm.GoogleCloudMessaging __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Gcm.GoogleCloudMessaging> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessageType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType_Landroid_content_Intent_;
		[Register ("getMessageType", "(Landroid/content/Intent;)Ljava/lang/String;", "GetGetMessageType_Landroid_content_Intent_Handler")]
		public virtual string GetMessageType (global::Android.Content.Intent p0)
		{
			if (id_getMessageType_Landroid_content_Intent_ == IntPtr.Zero)
				id_getMessageType_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "getMessageType", "(Landroid/content/Intent;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageType_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessageType_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_register_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegister_arrayLjava_lang_String_Handler ()
		{
			if (cb_register_arrayLjava_lang_String_ == null)
				cb_register_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_arrayLjava_lang_String_);
			return cb_register_arrayLjava_lang_String_;
		}

		static IntPtr n_Register_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Gcm.GoogleCloudMessaging __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Gcm.GoogleCloudMessaging> (native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewString (__this.Register (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_register_arrayLjava_lang_String_;
		[Register ("register", "([Ljava/lang/String;)Ljava/lang/String;", "GetRegister_arrayLjava_lang_String_Handler")]
		public virtual string Register (params  string[] p0)
		{
			if (id_register_arrayLjava_lang_String_ == IntPtr.Zero)
				id_register_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "register", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_register_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_register_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_Send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Gms.Gcm.GoogleCloudMessaging __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Gcm.GoogleCloudMessaging> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", "GetSend_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual void Send (string p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_send_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_Handler ()
		{
			if (cb_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_ == null)
				cb_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_);
			return cb_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_;
		}

		static void n_Send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, IntPtr native_p3)
		{
			global::Android.Gms.Gcm.GoogleCloudMessaging __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Gcm.GoogleCloudMessaging> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_;
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;JLandroid/os/Bundle;)V", "GetSend_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_Handler")]
		public virtual void Send (string p0, string p1, long p2, global::Android.OS.Bundle p3)
		{
			if (id_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;Ljava/lang/String;JLandroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_send_Ljava_lang_String_Ljava_lang_String_JLandroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_unregister;
#pragma warning disable 0169
		static Delegate GetUnregisterHandler ()
		{
			if (cb_unregister == null)
				cb_unregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unregister);
			return cb_unregister;
		}

		static void n_Unregister (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Gcm.GoogleCloudMessaging __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Gcm.GoogleCloudMessaging> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unregister ();
		}
#pragma warning restore 0169

		static IntPtr id_unregister;
		[Register ("unregister", "()V", "GetUnregisterHandler")]
		public virtual void Unregister ()
		{
			if (id_unregister == IntPtr.Zero)
				id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unregister);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_unregister);
		}

	}
}
