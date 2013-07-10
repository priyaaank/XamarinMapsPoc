using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus {

	[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusClient", DoNotGenerateAcw=true)]
	public partial class PlusClient : global::Java.Lang.Object, global::Android.Gms.Common.IGooglePlayServicesClient {


		[Register ("KEY_REQUEST_VISIBLE_ACTIVITIES")]
		public const string KeyRequestVisibleActivities = (string) "request_visible_actions";
		[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusClient$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/plus/PlusClient$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
			[Register (".ctor", "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
			public Builder (global::Android.Content.Context p0, global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p1, global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Gms.Plus.PlusClient.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			[Register ("build", "()Lcom/google/android/gms/plus/PlusClient;", "GetBuildHandler")]
			public virtual global::Android.Gms.Plus.PlusClient Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/android/gms/plus/PlusClient;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_clearScopes;
#pragma warning disable 0169
			static Delegate GetClearScopesHandler ()
			{
				if (cb_clearScopes == null)
					cb_clearScopes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearScopes);
				return cb_clearScopes;
			}

			static IntPtr n_ClearScopes (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Gms.Plus.PlusClient.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ClearScopes ());
			}
#pragma warning restore 0169

			static IntPtr id_clearScopes;
			[Register ("clearScopes", "()Lcom/google/android/gms/plus/PlusClient$Builder;", "GetClearScopesHandler")]
			public virtual global::Android.Gms.Plus.PlusClient.Builder ClearScopes ()
			{
				if (id_clearScopes == IntPtr.Zero)
					id_clearScopes = JNIEnv.GetMethodID (class_ref, "clearScopes", "()Lcom/google/android/gms/plus/PlusClient$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearScopes), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clearScopes), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_setAccountName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAccountName_Ljava_lang_String_Handler ()
			{
				if (cb_setAccountName_Ljava_lang_String_ == null)
					cb_setAccountName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccountName_Ljava_lang_String_);
				return cb_setAccountName_Ljava_lang_String_;
			}

			static IntPtr n_SetAccountName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusClient.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccountName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAccountName_Ljava_lang_String_;
			[Register ("setAccountName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/PlusClient$Builder;", "GetSetAccountName_Ljava_lang_String_Handler")]
			public virtual global::Android.Gms.Plus.PlusClient.Builder SetAccountName (string p0)
			{
				if (id_setAccountName_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccountName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccountName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/PlusClient$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Android.Gms.Plus.PlusClient.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAccountName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAccountName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setScopes_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetScopes_arrayLjava_lang_String_Handler ()
			{
				if (cb_setScopes_arrayLjava_lang_String_ == null)
					cb_setScopes_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetScopes_arrayLjava_lang_String_);
				return cb_setScopes_arrayLjava_lang_String_;
			}

			static IntPtr n_SetScopes_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusClient.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetScopes (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setScopes_arrayLjava_lang_String_;
			[Register ("setScopes", "([Ljava/lang/String;)Lcom/google/android/gms/plus/PlusClient$Builder;", "GetSetScopes_arrayLjava_lang_String_Handler")]
			public virtual global::Android.Gms.Plus.PlusClient.Builder SetScopes (params  string[] p0)
			{
				if (id_setScopes_arrayLjava_lang_String_ == IntPtr.Zero)
					id_setScopes_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScopes", "([Ljava/lang/String;)Lcom/google/android/gms/plus/PlusClient$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Android.Gms.Plus.PlusClient.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setScopes_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setScopes_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_setVisibleActivities_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetVisibleActivities_arrayLjava_lang_String_Handler ()
			{
				if (cb_setVisibleActivities_arrayLjava_lang_String_ == null)
					cb_setVisibleActivities_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVisibleActivities_arrayLjava_lang_String_);
				return cb_setVisibleActivities_arrayLjava_lang_String_;
			}

			static IntPtr n_SetVisibleActivities_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusClient.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVisibleActivities (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setVisibleActivities_arrayLjava_lang_String_;
			[Register ("setVisibleActivities", "([Ljava/lang/String;)Lcom/google/android/gms/plus/PlusClient$Builder;", "GetSetVisibleActivities_arrayLjava_lang_String_Handler")]
			public virtual global::Android.Gms.Plus.PlusClient.Builder SetVisibleActivities (params  string[] p0)
			{
				if (id_setVisibleActivities_arrayLjava_lang_String_ == IntPtr.Zero)
					id_setVisibleActivities_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVisibleActivities", "([Ljava/lang/String;)Lcom/google/android/gms/plus/PlusClient$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Android.Gms.Plus.PlusClient.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setVisibleActivities_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setVisibleActivities_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

		}

		[Register ("com/google/android/gms/plus/PlusClient$OnAccessRevokedListener", "", "Android.Gms.Plus.PlusClient/IOnAccessRevokedListenerInvoker")]
		public partial interface IOnAccessRevokedListener : IJavaObject {

			[Register ("onAccessRevoked", "(Lcom/google/android/gms/common/ConnectionResult;)V", "GetOnAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_Handler:Android.Gms.Plus.PlusClient/IOnAccessRevokedListenerInvoker, GooglePlayServices")]
			void OnAccessRevoked (global::Android.Gms.Common.ConnectionResult p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusClient$OnAccessRevokedListener", DoNotGenerateAcw=true)]
		internal class IOnAccessRevokedListenerInvoker : global::Java.Lang.Object, IOnAccessRevokedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/PlusClient$OnAccessRevokedListener");
			IntPtr class_ref;

			public static IOnAccessRevokedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAccessRevokedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.PlusClient.OnAccessRevokedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAccessRevokedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAccessRevokedListenerInvoker); }
			}

			static Delegate cb_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_;
#pragma warning disable 0169
			static Delegate GetOnAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_Handler ()
			{
				if (cb_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_ == null)
					cb_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_);
				return cb_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_;
			}

			static void n_OnAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusClient.IOnAccessRevokedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnAccessRevokedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAccessRevoked (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_;
			public void OnAccessRevoked (global::Android.Gms.Common.ConnectionResult p0)
			{
				if (id_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_ == IntPtr.Zero)
					id_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_ = JNIEnv.GetMethodID (class_ref, "onAccessRevoked", "(Lcom/google/android/gms/common/ConnectionResult;)V");
				JNIEnv.CallVoidMethod (Handle, id_onAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_, new JValue (p0));
			}

		}

		public partial class AccessRevokedEventArgs : global::System.EventArgs {

			public AccessRevokedEventArgs (global::Android.Gms.Common.ConnectionResult p0)
			{
				this.p0 = p0;
			}

			global::Android.Gms.Common.ConnectionResult p0;
			public global::Android.Gms.Common.ConnectionResult P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/plus/PlusClient_OnAccessRevokedListenerImplementor")]
		internal sealed class IOnAccessRevokedListenerImplementor : global::Java.Lang.Object, IOnAccessRevokedListener {

			object sender;

			public IOnAccessRevokedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/plus/PlusClient_OnAccessRevokedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AccessRevokedEventArgs> Handler;
#pragma warning restore 0649

			public void OnAccessRevoked (global::Android.Gms.Common.ConnectionResult p0)
			{
				if (Handler != null)
					Handler (sender, new AccessRevokedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnAccessRevokedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/plus/PlusClient$OnMomentsLoadedListener", "", "Android.Gms.Plus.PlusClient/IOnMomentsLoadedListenerInvoker")]
		public partial interface IOnMomentsLoadedListener : IJavaObject {

			[Register ("onMomentsLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/moments/MomentBuffer;Ljava/lang/String;Ljava/lang/String;)V", "GetOnMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_Handler:Android.Gms.Plus.PlusClient/IOnMomentsLoadedListenerInvoker, GooglePlayServices")]
			void OnMomentsLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.Moments.MomentBuffer p1, string p2, string p3);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusClient$OnMomentsLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnMomentsLoadedListenerInvoker : global::Java.Lang.Object, IOnMomentsLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/PlusClient$OnMomentsLoadedListener");
			IntPtr class_ref;

			public static IOnMomentsLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMomentsLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.PlusClient.OnMomentsLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMomentsLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMomentsLoadedListenerInvoker); }
			}

			static Delegate cb_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_);
				return cb_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_OnMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Plus.Model.Moments.MomentBuffer p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnMomentsLoaded (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_;
			public void OnMomentsLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.Moments.MomentBuffer p1, string p2, string p3)
			{
				if (id_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMomentsLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/moments/MomentBuffer;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				JNIEnv.CallVoidMethod (Handle, id_onMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}

		}

		public partial class MomentsLoadedEventArgs : global::System.EventArgs {

			public MomentsLoadedEventArgs (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.Moments.MomentBuffer p1, string p2, string p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Android.Gms.Common.ConnectionResult p0;
			public global::Android.Gms.Common.ConnectionResult P0 {
				get { return p0; }
			}

			global::Android.Gms.Plus.Model.Moments.MomentBuffer p1;
			public global::Android.Gms.Plus.Model.Moments.MomentBuffer P1 {
				get { return p1; }
			}

			string p2;
			public string P2 {
				get { return p2; }
			}

			string p3;
			public string P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/plus/PlusClient_OnMomentsLoadedListenerImplementor")]
		internal sealed class IOnMomentsLoadedListenerImplementor : global::Java.Lang.Object, IOnMomentsLoadedListener {

			object sender;

			public IOnMomentsLoadedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/plus/PlusClient_OnMomentsLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MomentsLoadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnMomentsLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.Moments.MomentBuffer p1, string p2, string p3)
			{
				if (Handler != null)
					Handler (sender, new MomentsLoadedEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnMomentsLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/plus/PlusClient$OnPeopleLoadedListener", "", "Android.Gms.Plus.PlusClient/IOnPeopleLoadedListenerInvoker")]
		public partial interface IOnPeopleLoadedListener : IJavaObject {

			[Register ("onPeopleLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/people/PersonBuffer;Ljava/lang/String;)V", "GetOnPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_Handler:Android.Gms.Plus.PlusClient/IOnPeopleLoadedListenerInvoker, GooglePlayServices")]
			void OnPeopleLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.PersonBuffer p1, string p2);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusClient$OnPeopleLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnPeopleLoadedListenerInvoker : global::Java.Lang.Object, IOnPeopleLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/PlusClient$OnPeopleLoadedListener");
			IntPtr class_ref;

			public static IOnPeopleLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPeopleLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.PlusClient.OnPeopleLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPeopleLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPeopleLoadedListenerInvoker); }
			}

			static Delegate cb_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_Handler ()
			{
				if (cb_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_ == null)
					cb_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_);
				return cb_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_;
			}

			static void n_OnPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Plus.Model.People.PersonBuffer p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.PersonBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnPeopleLoaded (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_;
			public void OnPeopleLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.PersonBuffer p1, string p2)
			{
				if (id_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_ == IntPtr.Zero)
					id_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPeopleLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/people/PersonBuffer;Ljava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JNIEnv.CallVoidMethod (Handle, id_onPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		public partial class PeopleLoadedEventArgs : global::System.EventArgs {

			public PeopleLoadedEventArgs (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.PersonBuffer p1, string p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Android.Gms.Common.ConnectionResult p0;
			public global::Android.Gms.Common.ConnectionResult P0 {
				get { return p0; }
			}

			global::Android.Gms.Plus.Model.People.PersonBuffer p1;
			public global::Android.Gms.Plus.Model.People.PersonBuffer P1 {
				get { return p1; }
			}

			string p2;
			public string P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/plus/PlusClient_OnPeopleLoadedListenerImplementor")]
		internal sealed class IOnPeopleLoadedListenerImplementor : global::Java.Lang.Object, IOnPeopleLoadedListener {

			object sender;

			public IOnPeopleLoadedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/plus/PlusClient_OnPeopleLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PeopleLoadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnPeopleLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.PersonBuffer p1, string p2)
			{
				if (Handler != null)
					Handler (sender, new PeopleLoadedEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnPeopleLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/plus/PlusClient$OnPersonLoadedListener", "", "Android.Gms.Plus.PlusClient/IOnPersonLoadedListenerInvoker")]
		public partial interface IOnPersonLoadedListener : IJavaObject {

			[Register ("onPersonLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/people/Person;)V", "GetOnPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_Handler:Android.Gms.Plus.PlusClient/IOnPersonLoadedListenerInvoker, GooglePlayServices")]
			void OnPersonLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.IPerson p1);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusClient$OnPersonLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnPersonLoadedListenerInvoker : global::Java.Lang.Object, IOnPersonLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/PlusClient$OnPersonLoadedListener");
			IntPtr class_ref;

			public static IOnPersonLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPersonLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.PlusClient.OnPersonLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPersonLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPersonLoadedListenerInvoker); }
			}

			static Delegate cb_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_;
#pragma warning disable 0169
			static Delegate GetOnPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_Handler ()
			{
				if (cb_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_ == null)
					cb_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_);
				return cb_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_;
			}

			static void n_OnPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Gms.Plus.PlusClient.IOnPersonLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnPersonLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Plus.Model.People.IPerson p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPersonLoaded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_;
			public void OnPersonLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.IPerson p1)
			{
				if (id_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_ == IntPtr.Zero)
					id_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_ = JNIEnv.GetMethodID (class_ref, "onPersonLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/people/Person;)V");
				JNIEnv.CallVoidMethod (Handle, id_onPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class PersonLoadedEventArgs : global::System.EventArgs {

			public PersonLoadedEventArgs (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.IPerson p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Gms.Common.ConnectionResult p0;
			public global::Android.Gms.Common.ConnectionResult P0 {
				get { return p0; }
			}

			global::Android.Gms.Plus.Model.People.IPerson p1;
			public global::Android.Gms.Plus.Model.People.IPerson P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/plus/PlusClient_OnPersonLoadedListenerImplementor")]
		internal sealed class IOnPersonLoadedListenerImplementor : global::Java.Lang.Object, IOnPersonLoadedListener {

			object sender;

			public IOnPersonLoadedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/plus/PlusClient_OnPersonLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PersonLoadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnPersonLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Gms.Plus.Model.People.IPerson p1)
			{
				if (Handler != null)
					Handler (sender, new PersonLoadedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnPersonLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/PlusClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlusClient); }
		}

		protected PlusClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAccountName;
#pragma warning disable 0169
		static Delegate GetGetAccountNameHandler ()
		{
			if (cb_getAccountName == null)
				cb_getAccountName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountName);
			return cb_getAccountName;
		}

		static IntPtr n_GetAccountName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountName);
		}
#pragma warning restore 0169

		static IntPtr id_getAccountName;
		public virtual string AccountName {
			[Register ("getAccountName", "()Ljava/lang/String;", "GetGetAccountNameHandler")]
			get {
				if (id_getAccountName == IntPtr.Zero)
					id_getAccountName = JNIEnv.GetMethodID (class_ref, "getAccountName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccountName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAccountName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentPerson;
#pragma warning disable 0169
		static Delegate GetGetCurrentPersonHandler ()
		{
			if (cb_getCurrentPerson == null)
				cb_getCurrentPerson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentPerson);
			return cb_getCurrentPerson;
		}

		static IntPtr n_GetCurrentPerson (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentPerson);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPerson;
		public virtual global::Android.Gms.Plus.Model.People.IPerson CurrentPerson {
			[Register ("getCurrentPerson", "()Lcom/google/android/gms/plus/model/people/Person;", "GetGetCurrentPersonHandler")]
			get {
				if (id_getCurrentPerson == IntPtr.Zero)
					id_getCurrentPerson = JNIEnv.GetMethodID (class_ref, "getCurrentPerson", "()Lcom/google/android/gms/plus/model/people/Person;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentPerson), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCurrentPerson), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual bool IsConnected {
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isConnected);
			}
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		static IntPtr id_isConnecting;
		public virtual bool IsConnecting {
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isConnecting);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isConnecting);
			}
		}

		static Delegate cb_A_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_A_Ljava_lang_String_ == null)
				cb_A_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_A_Ljava_lang_String_);
			return cb_A_Ljava_lang_String_;
		}

		static bool n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_A_Ljava_lang_String_;
		[Register ("A", "(Ljava/lang/String;)Z", "GetA_Ljava_lang_String_Handler")]
		public virtual bool A (string p0)
		{
			if (id_A_Ljava_lang_String_ == IntPtr.Zero)
				id_A_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "A", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_A_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_A_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_clearDefaultAccount;
#pragma warning disable 0169
		static Delegate GetClearDefaultAccountHandler ()
		{
			if (cb_clearDefaultAccount == null)
				cb_clearDefaultAccount = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearDefaultAccount);
			return cb_clearDefaultAccount;
		}

		static void n_ClearDefaultAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearDefaultAccount ();
		}
#pragma warning restore 0169

		static IntPtr id_clearDefaultAccount;
		[Register ("clearDefaultAccount", "()V", "GetClearDefaultAccountHandler")]
		public virtual void ClearDefaultAccount ()
		{
			if (id_clearDefaultAccount == IntPtr.Zero)
				id_clearDefaultAccount = JNIEnv.GetMethodID (class_ref, "clearDefaultAccount", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearDefaultAccount);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clearDefaultAccount);
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connect);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_connect);
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disconnect);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_disconnect);
		}

		static Delegate cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetIsConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler ()
		{
			if (cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == null)
				cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_);
			return cb_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		}

		static bool n_IsConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnectionCallbacksRegistered (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z", "GetIsConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler")]
		public virtual bool IsConnectionCallbacksRegistered (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetIsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == null)
				cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_);
			return cb_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		}

		static bool n_IsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnectionFailedListenerRegistered (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z", "GetIsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler")]
		public virtual bool IsConnectionFailedListenerRegistered (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_;
#pragma warning disable 0169
		static Delegate GetLoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_Handler ()
		{
			if (cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ == null)
				cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_);
			return cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_;
		}

		static void n_LoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadMoments (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_;
		[Register ("loadMoments", "(Lcom/google/android/gms/plus/PlusClient$OnMomentsLoadedListener;)V", "GetLoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_Handler")]
		public virtual void LoadMoments (global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener p0)
		{
			if (id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ == IntPtr.Zero)
				id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ = JNIEnv.GetMethodID (class_ref, "loadMoments", "(Lcom/google/android/gms/plus/PlusClient$OnMomentsLoadedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_, new JValue (p0));
		}

		static Delegate cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_);
			return cb_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_LoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p3 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.LoadMoments (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_;
		[Register ("loadMoments", "(Lcom/google/android/gms/plus/PlusClient$OnMomentsLoadedListener;ILjava/lang/String;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)V", "GetLoadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void LoadMoments (global::Android.Gms.Plus.PlusClient.IOnMomentsLoadedListener p0, int p1, string p2, global::Android.Net.Uri p3, string p4, string p5)
		{
			if (id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadMoments", "(Lcom/google/android/gms/plus/PlusClient$OnMomentsLoadedListener;ILjava/lang/String;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadMoments_Lcom_google_android_gms_plus_PlusClient_OnMomentsLoadedListener_ILjava_lang_String_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I;
#pragma warning disable 0169
		static Delegate GetLoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IHandler ()
		{
			if (cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I == null)
				cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_LoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I);
			return cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I;
		}

		static void n_LoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadPeople (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I;
		[Register ("loadPeople", "(Lcom/google/android/gms/plus/PlusClient$OnPeopleLoadedListener;I)V", "GetLoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IHandler")]
		public virtual void LoadPeople (global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener p0, int p1)
		{
			if (id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I == IntPtr.Zero)
				id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I = JNIEnv.GetMethodID (class_ref, "loadPeople", "(Lcom/google/android/gms/plus/PlusClient$OnPeopleLoadedListener;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_I, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_Handler ()
		{
			if (cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_ == null)
				cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_LoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_);
			return cb_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_;
		}

		static void n_LoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.LoadPeople (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_;
		[Register ("loadPeople", "(Lcom/google/android/gms/plus/PlusClient$OnPeopleLoadedListener;IIILjava/lang/String;)V", "GetLoadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_Handler")]
		public virtual void LoadPeople (global::Android.Gms.Plus.PlusClient.IOnPeopleLoadedListener p0, int p1, int p2, int p3, string p4)
		{
			if (id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_ == IntPtr.Zero)
				id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadPeople", "(Lcom/google/android/gms/plus/PlusClient$OnPeopleLoadedListener;IIILjava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewString (p4);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadPeople_Lcom_google_android_gms_plus_PlusClient_OnPeopleLoadedListener_IIILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_Handler ()
		{
			if (cb_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_ == null)
				cb_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_);
			return cb_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_;
		}

		static void n_LoadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.PlusClient.IOnPersonLoadedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnPersonLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadPerson (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_;
		[Register ("loadPerson", "(Lcom/google/android/gms/plus/PlusClient$OnPersonLoadedListener;Ljava/lang/String;)V", "GetLoadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_Handler")]
		public virtual void LoadPerson (global::Android.Gms.Plus.PlusClient.IOnPersonLoadedListener p0, string p1)
		{
			if (id_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_ == IntPtr.Zero)
				id_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadPerson", "(Lcom/google/android/gms/plus/PlusClient$OnPersonLoadedListener;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadPerson_Lcom_google_android_gms_plus_PlusClient_OnPersonLoadedListener_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetRegisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler ()
		{
			if (cb_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == null)
				cb_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_);
			return cb_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		}

		static void n_RegisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "GetRegisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler")]
		public virtual void RegisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
		}

		static Delegate cb_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetRegisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == null)
				cb_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_);
			return cb_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		}

		static void n_RegisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "GetRegisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler")]
		public virtual void RegisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
		}

		static Delegate cb_removeMoment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMoment_Ljava_lang_String_Handler ()
		{
			if (cb_removeMoment_Ljava_lang_String_ == null)
				cb_removeMoment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveMoment_Ljava_lang_String_);
			return cb_removeMoment_Ljava_lang_String_;
		}

		static void n_RemoveMoment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMoment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeMoment_Ljava_lang_String_;
		[Register ("removeMoment", "(Ljava/lang/String;)V", "GetRemoveMoment_Ljava_lang_String_Handler")]
		public virtual void RemoveMoment (string p0)
		{
			if (id_removeMoment_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMoment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMoment", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeMoment_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeMoment_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_;
#pragma warning disable 0169
		static Delegate GetRevokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_Handler ()
		{
			if (cb_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_ == null)
				cb_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RevokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_);
			return cb_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_;
		}

		static void n_RevokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.PlusClient.IOnAccessRevokedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient.IOnAccessRevokedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RevokeAccessAndDisconnect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_;
		[Register ("revokeAccessAndDisconnect", "(Lcom/google/android/gms/plus/PlusClient$OnAccessRevokedListener;)V", "GetRevokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_Handler")]
		public virtual void RevokeAccessAndDisconnect (global::Android.Gms.Plus.PlusClient.IOnAccessRevokedListener p0)
		{
			if (id_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_ == IntPtr.Zero)
				id_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_ = JNIEnv.GetMethodID (class_ref, "revokeAccessAndDisconnect", "(Lcom/google/android/gms/plus/PlusClient$OnAccessRevokedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_revokeAccessAndDisconnect_Lcom_google_android_gms_plus_PlusClient_OnAccessRevokedListener_, new JValue (p0));
		}

		static Delegate cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetUnregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler ()
		{
			if (cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == null)
				cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_);
			return cb_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		}

		static void n_UnregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "GetUnregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler")]
		public virtual void UnregisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
		}

		static Delegate cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == null)
				cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_);
			return cb_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		}

		static void n_UnregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "GetUnregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler")]
		public virtual void UnregisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
		}

		static Delegate cb_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_;
#pragma warning disable 0169
		static Delegate GetWriteMoment_Lcom_google_android_gms_plus_model_moments_Moment_Handler ()
		{
			if (cb_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_ == null)
				cb_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteMoment_Lcom_google_android_gms_plus_model_moments_Moment_);
			return cb_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_;
		}

		static void n_WriteMoment_Lcom_google_android_gms_plus_model_moments_Moment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.PlusClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IMoment p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteMoment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_;
		[Register ("writeMoment", "(Lcom/google/android/gms/plus/model/moments/Moment;)V", "GetWriteMoment_Lcom_google_android_gms_plus_model_moments_Moment_Handler")]
		public virtual void WriteMoment (global::Android.Gms.Plus.Model.Moments.IMoment p0)
		{
			if (id_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_ == IntPtr.Zero)
				id_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_ = JNIEnv.GetMethodID (class_ref, "writeMoment", "(Lcom/google/android/gms/plus/model/moments/Moment;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_writeMoment_Lcom_google_android_gms_plus_model_moments_Moment_, new JValue (p0));
		}

	}
}
