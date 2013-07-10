using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.AppStates {

	[global::Android.Runtime.Register ("com/google/android/gms/appstate/AppStateClient", DoNotGenerateAcw=true)]
	public sealed partial class AppStateClient : global::Java.Lang.Object, global::Android.Gms.Common.IGooglePlayServicesClient {


		[Register ("STATUS_CLIENT_RECONNECT_REQUIRED")]
		public const int StatusClientReconnectRequired = (int) 2;

		[Register ("STATUS_DEVELOPER_ERROR")]
		public const int StatusDeveloperError = (int) 7;

		[Register ("STATUS_INTERNAL_ERROR")]
		public const int StatusInternalError = (int) 1;

		[Register ("STATUS_NETWORK_ERROR_NO_DATA")]
		public const int StatusNetworkErrorNoData = (int) 4;

		[Register ("STATUS_NETWORK_ERROR_OPERATION_DEFERRED")]
		public const int StatusNetworkErrorOperationDeferred = (int) 5;

		[Register ("STATUS_NETWORK_ERROR_OPERATION_FAILED")]
		public const int StatusNetworkErrorOperationFailed = (int) 6;

		[Register ("STATUS_NETWORK_ERROR_STALE_DATA")]
		public const int StatusNetworkErrorStaleData = (int) 3;

		[Register ("STATUS_OK")]
		public const int StatusOk = (int) 0;

		[Register ("STATUS_STATE_KEY_LIMIT_EXCEEDED")]
		public const int StatusStateKeyLimitExceeded = (int) 2003;

		[Register ("STATUS_STATE_KEY_NOT_FOUND")]
		public const int StatusStateKeyNotFound = (int) 2002;

		[Register ("STATUS_WRITE_OUT_OF_DATE_VERSION")]
		public const int StatusWriteOutOfDateVersion = (int) 2000;

		[Register ("STATUS_WRITE_SIZE_EXCEEDED")]
		public const int StatusWriteSizeExceeded = (int) 2001;
		[global::Android.Runtime.Register ("com/google/android/gms/appstate/AppStateClient$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/appstate/AppStateClient$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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

			static IntPtr id_create;
			[Register ("create", "()Lcom/google/android/gms/appstate/AppStateClient;", "")]
			public global::Android.Gms.AppStates.AppStateClient Create ()
			{
				if (id_create == IntPtr.Zero)
					id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/google/android/gms/appstate/AppStateClient;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.AppStateClient> (JNIEnv.CallObjectMethod  (Handle, id_create), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setAccountName_Ljava_lang_String_;
			[Register ("setAccountName", "(Ljava/lang/String;)Lcom/google/android/gms/appstate/AppStateClient$Builder;", "")]
			public global::Android.Gms.AppStates.AppStateClient.Builder SetAccountName (string p0)
			{
				if (id_setAccountName_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccountName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccountName", "(Ljava/lang/String;)Lcom/google/android/gms/appstate/AppStateClient$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Android.Gms.AppStates.AppStateClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.AppStateClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAccountName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setScopes_arrayLjava_lang_String_;
			[Register ("setScopes", "([Ljava/lang/String;)Lcom/google/android/gms/appstate/AppStateClient$Builder;", "")]
			public global::Android.Gms.AppStates.AppStateClient.Builder SetScopes (params  string[] p0)
			{
				if (id_setScopes_arrayLjava_lang_String_ == IntPtr.Zero)
					id_setScopes_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScopes", "([Ljava/lang/String;)Lcom/google/android/gms/appstate/AppStateClient$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Android.Gms.AppStates.AppStateClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.AppStateClient.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setScopes_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/appstate/AppStateClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppStateClient); }
		}

		internal AppStateClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isConnected;
		public bool IsConnected {
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
			}
		}

		static IntPtr id_isConnecting;
		public bool IsConnecting {
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isConnecting);
			}
		}

		static IntPtr id_getMaxNumKeys;
		public int MaxNumKeys {
			[Register ("getMaxNumKeys", "()I", "GetGetMaxNumKeysHandler")]
			get {
				if (id_getMaxNumKeys == IntPtr.Zero)
					id_getMaxNumKeys = JNIEnv.GetMethodID (class_ref, "getMaxNumKeys", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMaxNumKeys);
			}
		}

		static IntPtr id_getMaxStateSize;
		public int MaxStateSize {
			[Register ("getMaxStateSize", "()I", "GetGetMaxStateSizeHandler")]
			get {
				if (id_getMaxStateSize == IntPtr.Zero)
					id_getMaxStateSize = JNIEnv.GetMethodID (class_ref, "getMaxStateSize", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMaxStateSize);
			}
		}

		static IntPtr id_connect;
		[Register ("connect", "()V", "")]
		public void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_connect);
		}

		static IntPtr id_deleteState_Lcom_google_android_gms_appstate_OnStateDeletedListener_I;
		[Register ("deleteState", "(Lcom/google/android/gms/appstate/OnStateDeletedListener;I)V", "")]
		public void DeleteState (global::Android.Gms.AppStates.IOnStateDeletedListener p0, int p1)
		{
			if (id_deleteState_Lcom_google_android_gms_appstate_OnStateDeletedListener_I == IntPtr.Zero)
				id_deleteState_Lcom_google_android_gms_appstate_OnStateDeletedListener_I = JNIEnv.GetMethodID (class_ref, "deleteState", "(Lcom/google/android/gms/appstate/OnStateDeletedListener;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteState_Lcom_google_android_gms_appstate_OnStateDeletedListener_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_disconnect;
		[Register ("disconnect", "()V", "")]
		public void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_disconnect);
		}

		static IntPtr id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z", "")]
		public bool IsConnectionCallbacksRegistered (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "isConnectionCallbacksRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isConnectionCallbacksRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z", "")]
		public bool IsConnectionFailedListenerRegistered (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "isConnectionFailedListenerRegistered", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isConnectionFailedListenerRegistered_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_listStates_Lcom_google_android_gms_appstate_OnStateListLoadedListener_;
		[Register ("listStates", "(Lcom/google/android/gms/appstate/OnStateListLoadedListener;)V", "")]
		public void ListStates (global::Android.Gms.AppStates.IOnStateListLoadedListener p0)
		{
			if (id_listStates_Lcom_google_android_gms_appstate_OnStateListLoadedListener_ == IntPtr.Zero)
				id_listStates_Lcom_google_android_gms_appstate_OnStateListLoadedListener_ = JNIEnv.GetMethodID (class_ref, "listStates", "(Lcom/google/android/gms/appstate/OnStateListLoadedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_listStates_Lcom_google_android_gms_appstate_OnStateListLoadedListener_, new JValue (p0));
		}

		static IntPtr id_loadState_Lcom_google_android_gms_appstate_OnStateLoadedListener_I;
		[Register ("loadState", "(Lcom/google/android/gms/appstate/OnStateLoadedListener;I)V", "")]
		public void LoadState (global::Android.Gms.AppStates.IOnStateLoadedListener p0, int p1)
		{
			if (id_loadState_Lcom_google_android_gms_appstate_OnStateLoadedListener_I == IntPtr.Zero)
				id_loadState_Lcom_google_android_gms_appstate_OnStateLoadedListener_I = JNIEnv.GetMethodID (class_ref, "loadState", "(Lcom/google/android/gms/appstate/OnStateLoadedListener;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadState_Lcom_google_android_gms_appstate_OnStateLoadedListener_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_reconnect;
		[Register ("reconnect", "()V", "")]
		public void Reconnect ()
		{
			if (id_reconnect == IntPtr.Zero)
				id_reconnect = JNIEnv.GetMethodID (class_ref, "reconnect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_reconnect);
		}

		static IntPtr id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "")]
		public void RegisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "registerConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");
			JNIEnv.CallVoidMethod  (Handle, id_registerConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
		}

		static IntPtr id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
		public void RegisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "registerConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_registerConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
		}

		static IntPtr id_resolveState_Lcom_google_android_gms_appstate_OnStateLoadedListener_ILjava_lang_String_arrayB;
		[Register ("resolveState", "(Lcom/google/android/gms/appstate/OnStateLoadedListener;ILjava/lang/String;[B)V", "")]
		public void ResolveState (global::Android.Gms.AppStates.IOnStateLoadedListener p0, int p1, string p2, byte[] p3)
		{
			if (id_resolveState_Lcom_google_android_gms_appstate_OnStateLoadedListener_ILjava_lang_String_arrayB == IntPtr.Zero)
				id_resolveState_Lcom_google_android_gms_appstate_OnStateLoadedListener_ILjava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "resolveState", "(Lcom/google/android/gms/appstate/OnStateLoadedListener;ILjava/lang/String;[B)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod  (Handle, id_resolveState_Lcom_google_android_gms_appstate_OnStateLoadedListener_ILjava_lang_String_arrayB, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_signOut;
		[Register ("signOut", "()V", "")]
		public void SignOut ()
		{
			if (id_signOut == IntPtr.Zero)
				id_signOut = JNIEnv.GetMethodID (class_ref, "signOut", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_signOut);
		}

		static IntPtr id_signOut_Lcom_google_android_gms_appstate_OnSignOutCompleteListener_;
		[Register ("signOut", "(Lcom/google/android/gms/appstate/OnSignOutCompleteListener;)V", "")]
		public void SignOut (global::Android.Gms.AppStates.IOnSignOutCompleteListener p0)
		{
			if (id_signOut_Lcom_google_android_gms_appstate_OnSignOutCompleteListener_ == IntPtr.Zero)
				id_signOut_Lcom_google_android_gms_appstate_OnSignOutCompleteListener_ = JNIEnv.GetMethodID (class_ref, "signOut", "(Lcom/google/android/gms/appstate/OnSignOutCompleteListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_signOut_Lcom_google_android_gms_appstate_OnSignOutCompleteListener_, new JValue (p0));
		}

		static IntPtr id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_;
		[Register ("unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V", "")]
		public void UnregisterConnectionCallbacks (global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p0)
		{
			if (id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ == IntPtr.Zero)
				id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionCallbacks", "(Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unregisterConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_, new JValue (p0));
		}

		static IntPtr id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register ("unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
		public void UnregisterConnectionFailedListener (global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p0)
		{
			if (id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ == IntPtr.Zero)
				id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_ = JNIEnv.GetMethodID (class_ref, "unregisterConnectionFailedListener", "(Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unregisterConnectionFailedListener_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_, new JValue (p0));
		}

		static IntPtr id_updateState_IarrayB;
		[Register ("updateState", "(I[B)V", "")]
		public void UpdateState (int p0, byte[] p1)
		{
			if (id_updateState_IarrayB == IntPtr.Zero)
				id_updateState_IarrayB = JNIEnv.GetMethodID (class_ref, "updateState", "(I[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod  (Handle, id_updateState_IarrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_updateStateImmediate_Lcom_google_android_gms_appstate_OnStateLoadedListener_IarrayB;
		[Register ("updateStateImmediate", "(Lcom/google/android/gms/appstate/OnStateLoadedListener;I[B)V", "")]
		public void UpdateStateImmediate (global::Android.Gms.AppStates.IOnStateLoadedListener p0, int p1, byte[] p2)
		{
			if (id_updateStateImmediate_Lcom_google_android_gms_appstate_OnStateLoadedListener_IarrayB == IntPtr.Zero)
				id_updateStateImmediate_Lcom_google_android_gms_appstate_OnStateLoadedListener_IarrayB = JNIEnv.GetMethodID (class_ref, "updateStateImmediate", "(Lcom/google/android/gms/appstate/OnStateLoadedListener;I[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod  (Handle, id_updateStateImmediate_Lcom_google_android_gms_appstate_OnStateLoadedListener_IarrayB, new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
