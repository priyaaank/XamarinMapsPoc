using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient.ConnectionCallbacks']"
	[Register ("com/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks", "", "Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacksInvoker")]
	public partial interface IGooglePlayServicesClientConnectionCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient.ConnectionCallbacks']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onConnected", "(Landroid/os/Bundle;)V", "GetOnConnected_Landroid_os_Bundle_Handler:Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacksInvoker, GooglePlayServices")]
		void OnConnected (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient.ConnectionCallbacks']/method[@name='onDisconnected' and count(parameter)=0]"
		[Register ("onDisconnected", "()V", "GetOnDisconnectedHandler:Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacksInvoker, GooglePlayServices")]
		void OnDisconnected ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks", DoNotGenerateAcw=true)]
	internal class IGooglePlayServicesClientConnectionCallbacksInvoker : global::Java.Lang.Object, IGooglePlayServicesClientConnectionCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks");
		IntPtr class_ref;

		public static IGooglePlayServicesClientConnectionCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGooglePlayServicesClientConnectionCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGooglePlayServicesClientConnectionCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGooglePlayServicesClientConnectionCallbacksInvoker); }
		}

		static Delegate cb_onConnected_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Landroid_os_Bundle_Handler ()
		{
			if (cb_onConnected_Landroid_os_Bundle_ == null)
				cb_onConnected_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Landroid_os_Bundle_);
			return cb_onConnected_Landroid_os_Bundle_;
		}

		static void n_OnConnected_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnected_Landroid_os_Bundle_;
		public void OnConnected (global::Android.OS.Bundle p0)
		{
			if (id_onConnected_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onConnected_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnected_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_onDisconnected;
#pragma warning disable 0169
		static Delegate GetOnDisconnectedHandler ()
		{
			if (cb_onDisconnected == null)
				cb_onDisconnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDisconnected);
			return cb_onDisconnected;
		}

		static void n_OnDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_onDisconnected;
		public void OnDisconnected ()
		{
			if (id_onDisconnected == IntPtr.Zero)
				id_onDisconnected = JNIEnv.GetMethodID (class_ref, "onDisconnected", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onDisconnected);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient.OnConnectionFailedListener']"
	[Register ("com/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener", "", "Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListenerInvoker")]
	public partial interface IGooglePlayServicesClientOnConnectionFailedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient.OnConnectionFailedListener']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.ConnectionResult']]"
		[Register ("onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V", "GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler:Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListenerInvoker, GooglePlayServices")]
		void OnConnectionFailed (global::Android.Gms.Common.ConnectionResult p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener", DoNotGenerateAcw=true)]
	internal class IGooglePlayServicesClientOnConnectionFailedListenerInvoker : global::Java.Lang.Object, IGooglePlayServicesClientOnConnectionFailedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener");
		IntPtr class_ref;

		public static IGooglePlayServicesClientOnConnectionFailedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGooglePlayServicesClientOnConnectionFailedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGooglePlayServicesClientOnConnectionFailedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGooglePlayServicesClientOnConnectionFailedListenerInvoker); }
		}

		static Delegate cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler ()
		{
			if (cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == null)
				cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_);
			return cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		}

		static void n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		public void OnConnectionFailed (global::Android.Gms.Common.ConnectionResult p0)
		{
			if (id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == IntPtr.Zero)
				id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_, new JValue (p0));
		}

	}

	public partial class GooglePlayServicesClientOnConnectionFailedEventArgs : global::System.EventArgs {

		public GooglePlayServicesClientOnConnectionFailedEventArgs (global::Android.Gms.Common.ConnectionResult p0)
		{
			this.p0 = p0;
		}

		global::Android.Gms.Common.ConnectionResult p0;
		public global::Android.Gms.Common.ConnectionResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/common/GooglePlayServicesClient_OnConnectionFailedListenerImplementor")]
	internal sealed class IGooglePlayServicesClientOnConnectionFailedListenerImplementor : global::Java.Lang.Object, IGooglePlayServicesClientOnConnectionFailedListener {

		object sender;

		public IGooglePlayServicesClientOnConnectionFailedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/common/GooglePlayServicesClient_OnConnectionFailedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GooglePlayServicesClientOnConnectionFailedEventArgs> Handler;
#pragma warning restore 0649

		public void OnConnectionFailed (global::Android.Gms.Common.ConnectionResult p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GooglePlayServicesClientOnConnectionFailedEventArgs (p0));
		}

		internal static bool __IsEmpty (IGooglePlayServicesClientOnConnectionFailedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']"
	[Register ("com/google/android/gms/common/GooglePlayServicesClient", "", "Android.Gms.Common.IGooglePlayServicesClientInvoker")]
	public partial interface IGooglePlayServicesClient : IJavaObject {

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")] get;
		}

		bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		void Connect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		void Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='isConnectionCallbacksRegistered' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks']]"
		[Register ("isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z", "GetIsConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		bool IsConnectionCallbacksRegistered (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='isConnectionFailedListenerRegistered' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener']]"
		[Register ("isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z", "GetIsConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		bool IsConnectionFailedListenerRegistered (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='registerConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks']]"
		[Register ("registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "GetRegisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		void RegisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='registerConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener']]"
		[Register ("registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "GetRegisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		void RegisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='unregisterConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.ConnectionCallbacks']]"
		[Register ("unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "GetUnregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Handler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		void UnregisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/interface[@name='GooglePlayServicesClient']/method[@name='unregisterConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener']]"
		[Register ("unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "GetUnregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_Handler:Android.Gms.Common.IGooglePlayServicesClientInvoker, GooglePlayServices")]
		void UnregisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/GooglePlayServicesClient", DoNotGenerateAcw=true)]
	internal class IGooglePlayServicesClientInvoker : global::Java.Lang.Object, IGooglePlayServicesClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/GooglePlayServicesClient");
		IntPtr class_ref;

		public static IGooglePlayServicesClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGooglePlayServicesClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.GooglePlayServicesClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGooglePlayServicesClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGooglePlayServicesClientInvoker); }
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		IntPtr id_isConnected;
		public bool IsConnected {
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isConnected);
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		IntPtr id_isConnecting;
		public bool IsConnecting {
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isConnecting);
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		IntPtr id_connect;
		public void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			JNIEnv.CallVoidMethod (Handle, id_connect);
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod (Handle, id_disconnect);
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnectionCallbacksRegistered (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		public bool IsConnectionCallbacksRegistered (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnectionFailedListenerRegistered (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		public bool IsConnectionFailedListenerRegistered (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
			return __ret;
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		public void RegisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");
			JNIEnv.CallVoidMethod (Handle, id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		public void RegisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0 = (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		public void UnregisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");
			JNIEnv.CallVoidMethod (Handle, id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
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
			global::Android.Gms.Common.IGooglePlayServicesClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0 = (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		public void UnregisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
		}

	}

}
