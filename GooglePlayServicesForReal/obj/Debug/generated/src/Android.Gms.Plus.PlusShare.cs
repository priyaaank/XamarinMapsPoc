using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus {

	[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusShare", DoNotGenerateAcw=true)]
	public sealed partial class PlusShare : global::Java.Lang.Object {


		[Register ("EXTRA_CALL_TO_ACTION")]
		public const string ExtraCallToAction = (string) "com.google.android.apps.plus.CALL_TO_ACTION";

		[Register ("EXTRA_CONTENT_DEEP_LINK_ID")]
		public const string ExtraContentDeepLinkId = (string) "com.google.android.apps.plus.CONTENT_DEEP_LINK_ID";

		[Register ("EXTRA_CONTENT_DEEP_LINK_METADATA")]
		public const string ExtraContentDeepLinkMetadata = (string) "com.google.android.apps.plus.CONTENT_DEEP_LINK_METADATA";

		[Register ("EXTRA_CONTENT_URL")]
		public const string ExtraContentUrl = (string) "com.google.android.apps.plus.CONTENT_URL";

		[Register ("EXTRA_IS_INTERACTIVE_POST")]
		public const string ExtraIsInteractivePost = (string) "com.google.android.apps.plus.GOOGLE_INTERACTIVE_POST";

		[Register ("EXTRA_SENDER_ID")]
		public const string ExtraSenderId = (string) "com.google.android.apps.plus.SENDER_ID";

		[Register ("KEY_CALL_TO_ACTION_DEEP_LINK_ID")]
		public const string KeyCallToActionDeepLinkId = (string) "deepLinkId";

		[Register ("KEY_CALL_TO_ACTION_LABEL")]
		public const string KeyCallToActionLabel = (string) "label";

		[Register ("KEY_CALL_TO_ACTION_URL")]
		public const string KeyCallToActionUrl = (string) "url";

		[Register ("KEY_CONTENT_DEEP_LINK_METADATA_DESCRIPTION")]
		public const string KeyContentDeepLinkMetadataDescription = (string) "description";

		[Register ("KEY_CONTENT_DEEP_LINK_METADATA_THUMBNAIL_URL")]
		public const string KeyContentDeepLinkMetadataThumbnailUrl = (string) "thumbnailUrl";

		[Register ("KEY_CONTENT_DEEP_LINK_METADATA_TITLE")]
		public const string KeyContentDeepLinkMetadataTitle = (string) "title";

		[Register ("PARAM_CONTENT_DEEP_LINK_ID")]
		public const string ParamContentDeepLinkId = (string) "deep_link_id";
		[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusShare$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/plus/PlusShare$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			public Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_Ljava_lang_String_;
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			protected Builder (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_ComponentName_;
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ComponentName;)V", "")]
			protected Builder (string p0, string p1, global::Android.Content.ComponentName p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ComponentName;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_ComponentName_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ComponentName;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_ComponentName_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static IntPtr id_ctor_Landroid_app_Activity_;
			[Register (".ctor", "(Landroid/app/Activity;)V", "")]
			public Builder (global::Android.App.Activity p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/app/Activity;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_Landroid_app_Activity_Lcom_google_android_gms_plus_PlusClient_;
			[Register (".ctor", "(Landroid/app/Activity;Lcom/google/android/gms/plus/PlusClient;)V", "")]
			public Builder (global::Android.App.Activity p0, global::Android.Gms.Plus.PlusClient p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/app/Activity;Lcom/google/android/gms/plus/PlusClient;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_google_android_gms_plus_PlusClient_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_google_android_gms_plus_PlusClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/google/android/gms/plus/PlusClient;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_app_Activity_Lcom_google_android_gms_plus_PlusClient_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getIntent;
#pragma warning disable 0169
			static Delegate GetGetIntentHandler ()
			{
				if (cb_getIntent == null)
					cb_getIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntent);
				return cb_getIntent;
			}

			static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Intent);
			}
#pragma warning restore 0169

			static IntPtr id_getIntent;
			public virtual global::Android.Content.Intent Intent {
				[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler")]
				get {
					if (id_getIntent == IntPtr.Zero)
						id_getIntent = JNIEnv.GetMethodID (class_ref, "getIntent", "()Landroid/content/Intent;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getIntent), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_Handler ()
			{
				if (cb_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_ == null)
					cb_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_);
				return cb_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_;
			}

			static IntPtr n_AddCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCallToAction (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_;
			[Register ("addCallToAction", "(Ljava/lang/String;Landroid/net/Uri;Ljava/lang/String;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetAddCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder AddCallToAction (string p0, global::Android.Net.Uri p1, string p2)
			{
				if (id_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
					id_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addCallToAction", "(Ljava/lang/String;Landroid/net/Uri;Ljava/lang/String;)Lcom/google/android/gms/plus/PlusShare$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = JNIEnv.NewString (p2);

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addCallToAction_Ljava_lang_String_Landroid_net_Uri_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

			static Delegate cb_addStream_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetAddStream_Landroid_net_Uri_Handler ()
			{
				if (cb_addStream_Landroid_net_Uri_ == null)
					cb_addStream_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddStream_Landroid_net_Uri_);
				return cb_addStream_Landroid_net_Uri_;
			}

			static IntPtr n_AddStream_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddStream (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addStream_Landroid_net_Uri_;
			[Register ("addStream", "(Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetAddStream_Landroid_net_Uri_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder AddStream (global::Android.Net.Uri p0)
			{
				if (id_addStream_Landroid_net_Uri_ == IntPtr.Zero)
					id_addStream_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "addStream", "(Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;");

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addStream_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addStream_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_setContentDeepLinkId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetContentDeepLinkId_Ljava_lang_String_Handler ()
			{
				if (cb_setContentDeepLinkId_Ljava_lang_String_ == null)
					cb_setContentDeepLinkId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentDeepLinkId_Ljava_lang_String_);
				return cb_setContentDeepLinkId_Ljava_lang_String_;
			}

			static IntPtr n_SetContentDeepLinkId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentDeepLinkId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setContentDeepLinkId_Ljava_lang_String_;
			[Register ("setContentDeepLinkId", "(Ljava/lang/String;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetSetContentDeepLinkId_Ljava_lang_String_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder SetContentDeepLinkId (string p0)
			{
				if (id_setContentDeepLinkId_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentDeepLinkId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentDeepLinkId", "(Ljava/lang/String;)Lcom/google/android/gms/plus/PlusShare$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setContentDeepLinkId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setContentDeepLinkId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetSetContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_Handler ()
			{
				if (cb_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_ == null)
					cb_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_);
				return cb_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_;
			}

			static IntPtr n_SetContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p3 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p3, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentDeepLinkId (p0, p1, p2, p3));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_;
			[Register ("setContentDeepLinkId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetSetContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder SetContentDeepLinkId (string p0, string p1, string p2, global::Android.Net.Uri p3)
			{
				if (id_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_ == IntPtr.Zero)
					id_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setContentDeepLinkId", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setContentDeepLinkId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

			static Delegate cb_setContentUrl_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetSetContentUrl_Landroid_net_Uri_Handler ()
			{
				if (cb_setContentUrl_Landroid_net_Uri_ == null)
					cb_setContentUrl_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentUrl_Landroid_net_Uri_);
				return cb_setContentUrl_Landroid_net_Uri_;
			}

			static IntPtr n_SetContentUrl_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setContentUrl_Landroid_net_Uri_;
			[Register ("setContentUrl", "(Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetSetContentUrl_Landroid_net_Uri_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder SetContentUrl (global::Android.Net.Uri p0)
			{
				if (id_setContentUrl_Landroid_net_Uri_ == IntPtr.Zero)
					id_setContentUrl_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setContentUrl", "(Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;");

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setContentUrl_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setContentUrl_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_setRecipients_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetRecipients_Ljava_util_List_Handler ()
			{
				if (cb_setRecipients_Ljava_util_List_ == null)
					cb_setRecipients_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRecipients_Ljava_util_List_);
				return cb_setRecipients_Ljava_util_List_;
			}

			static IntPtr n_SetRecipients_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<Android.Gms.Plus.Model.People.IPerson> p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPerson>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRecipients (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setRecipients_Ljava_util_List_;
			[Register ("setRecipients", "(Ljava/util/List;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetSetRecipients_Ljava_util_List_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder SetRecipients (global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPerson> p0)
			{
				if (id_setRecipients_Ljava_util_List_ == IntPtr.Zero)
					id_setRecipients_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setRecipients", "(Ljava/util/List;)Lcom/google/android/gms/plus/PlusShare$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPerson>.ToLocalJniHandle (p0);

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRecipients_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setRecipients_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setStream_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetSetStream_Landroid_net_Uri_Handler ()
			{
				if (cb_setStream_Landroid_net_Uri_ == null)
					cb_setStream_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStream_Landroid_net_Uri_);
				return cb_setStream_Landroid_net_Uri_;
			}

			static IntPtr n_SetStream_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStream (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setStream_Landroid_net_Uri_;
			[Register ("setStream", "(Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetSetStream_Landroid_net_Uri_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder SetStream (global::Android.Net.Uri p0)
			{
				if (id_setStream_Landroid_net_Uri_ == IntPtr.Zero)
					id_setStream_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setStream", "(Landroid/net/Uri;)Lcom/google/android/gms/plus/PlusShare$Builder;");

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setStream_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setStream_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_setText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetText_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setText_Ljava_lang_CharSequence_ == null)
					cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_CharSequence_);
				return cb_setText_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetText (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setText_Ljava_lang_CharSequence_;
			[Register ("setText", "(Ljava/lang/CharSequence;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder SetText (global::Java.Lang.ICharSequence p0)
			{
				if (id_setText_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setText_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/CharSequence;)Lcom/google/android/gms/plus/PlusShare$Builder;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setText_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setText_Ljava_lang_CharSequence_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			public global::Android.Gms.Plus.PlusShare.Builder SetText (string p0)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Gms.Plus.PlusShare.Builder __result = SetText (jls_p0);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetType_Ljava_lang_String_Handler ()
			{
				if (cb_setType_Ljava_lang_String_ == null)
					cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
				return cb_setType_Ljava_lang_String_;
			}

			static IntPtr n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusShare.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setType_Ljava_lang_String_;
			[Register ("setType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/PlusShare$Builder;", "GetSetType_Ljava_lang_String_Handler")]
			public virtual global::Android.Gms.Plus.PlusShare.Builder SetType (string p0)
			{
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/PlusShare$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Android.Gms.Plus.PlusShare.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusShare.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/PlusShare", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlusShare); }
		}

		internal PlusShare (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_;
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle A (string p0, string p1, global::Android.Net.Uri p2)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_Landroid_net_Uri_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createPerson_Ljava_lang_String_Ljava_lang_String_;
		[Register ("createPerson", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/gms/plus/model/people/Person;", "")]
		public static global::Android.Gms.Plus.Model.People.IPerson CreatePerson (string p0, string p1)
		{
			if (id_createPerson_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createPerson_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createPerson", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/gms/plus/model/people/Person;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Gms.Plus.Model.People.IPerson __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPerson_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getDeepLinkId_Landroid_content_Intent_;
		[Register ("getDeepLinkId", "(Landroid/content/Intent;)Ljava/lang/String;", "")]
		public static string GetDeepLinkId (global::Android.Content.Intent p0)
		{
			if (id_getDeepLinkId_Landroid_content_Intent_ == IntPtr.Zero)
				id_getDeepLinkId_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getDeepLinkId", "(Landroid/content/Intent;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeepLinkId_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
