using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Panorama {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']"
	[global::Android.Runtime.Register ("com/google/android/gms/panorama/PanoramaClient", DoNotGenerateAcw=true)]
	public partial class PanoramaClient : global::Java.Lang.Object, global::Android.Gms.Common.IGooglePlayServicesClient {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.panorama']/interface[@name='PanoramaClient.OnPanoramaInfoLoadedListener']"
		[Register ("com/google/android/gms/panorama/PanoramaClient$OnPanoramaInfoLoadedListener", "", "Android.Gms.Panorama.PanoramaClient/IOnPanoramaInfoLoadedListenerInvoker")]
		public partial interface IOnPanoramaInfoLoadedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/interface[@name='PanoramaClient.OnPanoramaInfoLoadedListener']/method[@name='onPanoramaInfoLoaded' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.common.ConnectionResult'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onPanoramaInfoLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Landroid/content/Intent;)V", "GetOnPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_Handler:Android.Gms.Panorama.PanoramaClient/IOnPanoramaInfoLoadedListenerInvoker, GooglePlayServices")]
			void OnPanoramaInfoLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Content.Intent p1);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/panorama/PanoramaClient$OnPanoramaInfoLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnPanoramaInfoLoadedListenerInvoker : global::Java.Lang.Object, IOnPanoramaInfoLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/panorama/PanoramaClient$OnPanoramaInfoLoadedListener");
			IntPtr class_ref;

			public static IOnPanoramaInfoLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPanoramaInfoLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.panorama.PanoramaClient.OnPanoramaInfoLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPanoramaInfoLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPanoramaInfoLoadedListenerInvoker); }
			}

			static Delegate cb_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_Handler ()
			{
				if (cb_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_ == null)
					cb_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_);
				return cb_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_;
			}

			static void n_OnPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPanoramaInfoLoaded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_;
			public void OnPanoramaInfoLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Content.Intent p1)
			{
				if (id_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_ == IntPtr.Zero)
					id_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onPanoramaInfoLoaded", "(Lcom/google/android/gms/common/ConnectionResult;Landroid/content/Intent;)V");
				JNIEnv.CallVoidMethod (Handle, id_onPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class PanoramaInfoLoadedEventArgs : global::System.EventArgs {

			public PanoramaInfoLoadedEventArgs (global::Android.Gms.Common.ConnectionResult p0, global::Android.Content.Intent p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Gms.Common.ConnectionResult p0;
			public global::Android.Gms.Common.ConnectionResult P0 {
				get { return p0; }
			}

			global::Android.Content.Intent p1;
			public global::Android.Content.Intent P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/panorama/PanoramaClient_OnPanoramaInfoLoadedListenerImplementor")]
		internal sealed class IOnPanoramaInfoLoadedListenerImplementor : global::Java.Lang.Object, IOnPanoramaInfoLoadedListener {

			object sender;

			public IOnPanoramaInfoLoadedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/panorama/PanoramaClient_OnPanoramaInfoLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PanoramaInfoLoadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnPanoramaInfoLoaded (global::Android.Gms.Common.ConnectionResult p0, global::Android.Content.Intent p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PanoramaInfoLoadedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnPanoramaInfoLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/panorama/PanoramaClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PanoramaClient); }
		}

		protected PanoramaClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/constructor[@name='PanoramaClient' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks'] and parameter[3][@type='com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
		public PanoramaClient (global::Android.Content.Context p0, global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p1, global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PanoramaClient)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='isConnected' and count(parameter)=0]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		static IntPtr id_isConnecting;
		public virtual bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='isConnecting' and count(parameter)=0]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='connect' and count(parameter)=0]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='disconnect' and count(parameter)=0]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnectionCallbacksRegistered (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='isConnectionCallbacksRegistered' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks']]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnectionFailedListenerRegistered (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='isConnectionFailedListenerRegistered' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener']]"
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

		static Delegate cb_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetLoadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_Handler ()
		{
			if (cb_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ == null)
				cb_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_);
			return cb_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_;
		}

		static void n_LoadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener p0 = (global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadPanoramaInfo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='loadPanoramaInfo' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.panorama.PanoramaClient.OnPanoramaInfoLoadedListener'] and parameter[2][@type='android.net.Uri']]"
		[Register ("loadPanoramaInfo", "(Lcom/google/android/gms/panorama/PanoramaClient$OnPanoramaInfoLoadedListener;Landroid/net/Uri;)V", "GetLoadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_Handler")]
		public virtual void LoadPanoramaInfo (global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener p0, global::Android.Net.Uri p1)
		{
			if (id_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ == IntPtr.Zero)
				id_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "loadPanoramaInfo", "(Lcom/google/android/gms/panorama/PanoramaClient$OnPanoramaInfoLoadedListener;Landroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadPanoramaInfo_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetLoadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_Handler ()
		{
			if (cb_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ == null)
				cb_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_);
			return cb_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_;
		}

		static void n_LoadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener p0 = (global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadPanoramaInfoAndGrantAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='loadPanoramaInfoAndGrantAccess' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.panorama.PanoramaClient.OnPanoramaInfoLoadedListener'] and parameter[2][@type='android.net.Uri']]"
		[Register ("loadPanoramaInfoAndGrantAccess", "(Lcom/google/android/gms/panorama/PanoramaClient$OnPanoramaInfoLoadedListener;Landroid/net/Uri;)V", "GetLoadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_Handler")]
		public virtual void LoadPanoramaInfoAndGrantAccess (global::Android.Gms.Panorama.PanoramaClient.IOnPanoramaInfoLoadedListener p0, global::Android.Net.Uri p1)
		{
			if (id_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ == IntPtr.Zero)
				id_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "loadPanoramaInfoAndGrantAccess", "(Lcom/google/android/gms/panorama/PanoramaClient$OnPanoramaInfoLoadedListener;Landroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadPanoramaInfoAndGrantAccess_Lcom_google_android_gms_panorama_PanoramaClient_OnPanoramaInfoLoadedListener_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='registerConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks']]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='registerConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener']]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='unregisterConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks']]"
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
			global::Android.Gms.Panorama.PanoramaClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Panorama.PanoramaClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.panorama']/class[@name='PanoramaClient']/method[@name='unregisterConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener']]"
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

	}
}
