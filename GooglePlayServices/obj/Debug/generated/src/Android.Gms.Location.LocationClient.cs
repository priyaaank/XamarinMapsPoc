using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	[global::Android.Runtime.Register ("com/google/android/gms/location/LocationClient", DoNotGenerateAcw=true)]
	public partial class LocationClient : global::Java.Lang.Object, global::Android.Gms.Common.IGooglePlayServicesClient {


		[Register ("KEY_LOCATION_CHANGED")]
		public const string KeyLocationChanged = (string) "com.google.android.location.LOCATION";
		[Register ("com/google/android/gms/location/LocationClient$OnAddGeofencesResultListener", "", "Android.Gms.Location.LocationClient/IOnAddGeofencesResultListenerInvoker")]
		public partial interface IOnAddGeofencesResultListener : IJavaObject {

			[Register ("onAddGeofencesResult", "(I[Ljava/lang/String;)V", "GetOnAddGeofencesResult_IarrayLjava_lang_String_Handler:Android.Gms.Location.LocationClient/IOnAddGeofencesResultListenerInvoker, GooglePlayServices")]
			void OnAddGeofencesResult (int p0, string[] p1);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/location/LocationClient$OnAddGeofencesResultListener", DoNotGenerateAcw=true)]
		internal class IOnAddGeofencesResultListenerInvoker : global::Java.Lang.Object, IOnAddGeofencesResultListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/location/LocationClient$OnAddGeofencesResultListener");
			IntPtr class_ref;

			public static IOnAddGeofencesResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAddGeofencesResultListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.location.LocationClient.OnAddGeofencesResultListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAddGeofencesResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAddGeofencesResultListenerInvoker); }
			}

			static Delegate cb_onAddGeofencesResult_IarrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnAddGeofencesResult_IarrayLjava_lang_String_Handler ()
			{
				if (cb_onAddGeofencesResult_IarrayLjava_lang_String_ == null)
					cb_onAddGeofencesResult_IarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnAddGeofencesResult_IarrayLjava_lang_String_);
				return cb_onAddGeofencesResult_IarrayLjava_lang_String_;
			}

			static void n_OnAddGeofencesResult_IarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Gms.Location.LocationClient.IOnAddGeofencesResultListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient.IOnAddGeofencesResultListener> (native__this, JniHandleOwnership.DoNotTransfer);
				string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
				__this.OnAddGeofencesResult (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_onAddGeofencesResult_IarrayLjava_lang_String_;
			public void OnAddGeofencesResult (int p0, string[] p1)
			{
				if (id_onAddGeofencesResult_IarrayLjava_lang_String_ == IntPtr.Zero)
					id_onAddGeofencesResult_IarrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAddGeofencesResult", "(I[Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JNIEnv.CallVoidMethod (Handle, id_onAddGeofencesResult_IarrayLjava_lang_String_, new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		public partial class AddGeofencesResultEventArgs : global::System.EventArgs {

			public AddGeofencesResultEventArgs (int p0, string[] p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			string[] p1;
			public string[] P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/location/LocationClient_OnAddGeofencesResultListenerImplementor")]
		internal sealed class IOnAddGeofencesResultListenerImplementor : global::Java.Lang.Object, IOnAddGeofencesResultListener {

			object sender;

			public IOnAddGeofencesResultListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/location/LocationClient_OnAddGeofencesResultListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AddGeofencesResultEventArgs> Handler;
#pragma warning restore 0649

			public void OnAddGeofencesResult (int p0, string[] p1)
			{
				if (Handler != null)
					Handler (sender, new AddGeofencesResultEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnAddGeofencesResultListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/google/android/gms/location/LocationClient$OnRemoveGeofencesResultListener", "", "Android.Gms.Location.LocationClient/IOnRemoveGeofencesResultListenerInvoker")]
		public partial interface IOnRemoveGeofencesResultListener : IJavaObject {

			[Register ("onRemoveGeofencesByPendingIntentResult", "(ILandroid/app/PendingIntent;)V", "GetOnRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_Handler:Android.Gms.Location.LocationClient/IOnRemoveGeofencesResultListenerInvoker, GooglePlayServices")]
			void OnRemoveGeofencesByPendingIntentResult (int p0, global::Android.App.PendingIntent p1);

			[Register ("onRemoveGeofencesByRequestIdsResult", "(I[Ljava/lang/String;)V", "GetOnRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_Handler:Android.Gms.Location.LocationClient/IOnRemoveGeofencesResultListenerInvoker, GooglePlayServices")]
			void OnRemoveGeofencesByRequestIdsResult (int p0, string[] p1);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/location/LocationClient$OnRemoveGeofencesResultListener", DoNotGenerateAcw=true)]
		internal class IOnRemoveGeofencesResultListenerInvoker : global::Java.Lang.Object, IOnRemoveGeofencesResultListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/location/LocationClient$OnRemoveGeofencesResultListener");
			IntPtr class_ref;

			public static IOnRemoveGeofencesResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRemoveGeofencesResultListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.location.LocationClient.OnRemoveGeofencesResultListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRemoveGeofencesResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnRemoveGeofencesResultListenerInvoker); }
			}

			static Delegate cb_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_;
#pragma warning disable 0169
			static Delegate GetOnRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_Handler ()
			{
				if (cb_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_ == null)
					cb_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_);
				return cb_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_;
			}

			static void n_OnRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.PendingIntent p1 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoveGeofencesByPendingIntentResult (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_;
			public void OnRemoveGeofencesByPendingIntentResult (int p0, global::Android.App.PendingIntent p1)
			{
				if (id_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_ == IntPtr.Zero)
					id_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "onRemoveGeofencesByPendingIntentResult", "(ILandroid/app/PendingIntent;)V");
				JNIEnv.CallVoidMethod (Handle, id_onRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_Handler ()
			{
				if (cb_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_ == null)
					cb_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_);
				return cb_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_;
			}

			static void n_OnRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener> (native__this, JniHandleOwnership.DoNotTransfer);
				string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
				__this.OnRemoveGeofencesByRequestIdsResult (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_;
			public void OnRemoveGeofencesByRequestIdsResult (int p0, string[] p1)
			{
				if (id_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_ == IntPtr.Zero)
					id_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRemoveGeofencesByRequestIdsResult", "(I[Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JNIEnv.CallVoidMethod (Handle, id_onRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_, new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		public partial class RemoveGeofencesByPendingIntentResultEventArgs : global::System.EventArgs {

			public RemoveGeofencesByPendingIntentResultEventArgs (int p0, global::Android.App.PendingIntent p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Android.App.PendingIntent p1;
			public global::Android.App.PendingIntent P1 {
				get { return p1; }
			}
		}

		public partial class RemoveGeofencesByRequestIdsResultEventArgs : global::System.EventArgs {

			public RemoveGeofencesByRequestIdsResultEventArgs (int p0, string[] p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			string[] p1;
			public string[] P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/location/LocationClient_OnRemoveGeofencesResultListenerImplementor")]
		internal sealed class IOnRemoveGeofencesResultListenerImplementor : global::Java.Lang.Object, IOnRemoveGeofencesResultListener {

			object sender;

			public IOnRemoveGeofencesResultListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/location/LocationClient_OnRemoveGeofencesResultListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RemoveGeofencesByPendingIntentResultEventArgs> OnRemoveGeofencesByPendingIntentResultHandler;
#pragma warning restore 0649

			public void OnRemoveGeofencesByPendingIntentResult (int p0, global::Android.App.PendingIntent p1)
			{
				if (OnRemoveGeofencesByPendingIntentResultHandler != null)
					OnRemoveGeofencesByPendingIntentResultHandler (sender, new RemoveGeofencesByPendingIntentResultEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoveGeofencesByRequestIdsResultEventArgs> OnRemoveGeofencesByRequestIdsResultHandler;
#pragma warning restore 0649

			public void OnRemoveGeofencesByRequestIdsResult (int p0, string[] p1)
			{
				if (OnRemoveGeofencesByRequestIdsResultHandler != null)
					OnRemoveGeofencesByRequestIdsResultHandler (sender, new RemoveGeofencesByRequestIdsResultEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnRemoveGeofencesResultListenerImplementor value)
			{
				return value.OnRemoveGeofencesByPendingIntentResultHandler == null && value.OnRemoveGeofencesByRequestIdsResultHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/location/LocationClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationClient); }
		}

		protected LocationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_google_android_gms_common_GooglePlayServicesClient_ConnectionCallbacks_Lcom_google_android_gms_common_GooglePlayServicesClient_OnConnectionFailedListener_;
		[Register (".ctor", "(Landroid/content/Context;Lcom/google/android/gms/common/GooglePlayServicesClient$ConnectionCallbacks;Lcom/google/android/gms/common/GooglePlayServicesClient$OnConnectionFailedListener;)V", "")]
		public LocationClient (global::Android.Content.Context p0, global::Android.Gms.Common.IGooglePlayServicesClientConnectionCallbacks p1, global::Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationClient)) {
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getLastLocation;
#pragma warning disable 0169
		static Delegate GetGetLastLocationHandler ()
		{
			if (cb_getLastLocation == null)
				cb_getLastLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastLocation);
			return cb_getLastLocation;
		}

		static IntPtr n_GetLastLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getLastLocation;
		public virtual global::Android.Locations.Location LastLocation {
			[Register ("getLastLocation", "()Landroid/location/Location;", "GetGetLastLocationHandler")]
			get {
				if (id_getLastLocation == IntPtr.Zero)
					id_getLastLocation = JNIEnv.GetMethodID (class_ref, "getLastLocation", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLastLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLastLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_;
#pragma warning disable 0169
		static Delegate GetAddGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_Handler ()
		{
			if (cb_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_ == null)
				cb_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_);
			return cb_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_;
		}

		static void n_AddGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Gms.Location.IGeofence> p0 = global::Android.Runtime.JavaList<global::Android.Gms.Location.IGeofence>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p1 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.LocationClient.IOnAddGeofencesResultListener p2 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient.IOnAddGeofencesResultListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddGeofences (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_;
		[Register ("addGeofences", "(Ljava/util/List;Landroid/app/PendingIntent;Lcom/google/android/gms/location/LocationClient$OnAddGeofencesResultListener;)V", "GetAddGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_Handler")]
		public virtual void AddGeofences (global::System.Collections.Generic.IList<global::Android.Gms.Location.IGeofence> p0, global::Android.App.PendingIntent p1, global::Android.Gms.Location.LocationClient.IOnAddGeofencesResultListener p2)
		{
			if (id_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_ == IntPtr.Zero)
				id_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_ = JNIEnv.GetMethodID (class_ref, "addGeofences", "(Ljava/util/List;Landroid/app/PendingIntent;Lcom/google/android/gms/location/LocationClient$OnAddGeofencesResultListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Location.IGeofence>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addGeofences_Ljava_util_List_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnAddGeofencesResultListener_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static IntPtr id_getErrorCode_Landroid_content_Intent_;
		[Register ("getErrorCode", "(Landroid/content/Intent;)I", "")]
		public static int GetErrorCode (global::Android.Content.Intent p0)
		{
			if (id_getErrorCode_Landroid_content_Intent_ == IntPtr.Zero)
				id_getErrorCode_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorCode", "(Landroid/content/Intent;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getErrorCode_Landroid_content_Intent_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getGeofenceTransition_Landroid_content_Intent_;
		[Register ("getGeofenceTransition", "(Landroid/content/Intent;)I", "")]
		public static int GetGeofenceTransition (global::Android.Content.Intent p0)
		{
			if (id_getGeofenceTransition_Landroid_content_Intent_ == IntPtr.Zero)
				id_getGeofenceTransition_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getGeofenceTransition", "(Landroid/content/Intent;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getGeofenceTransition_Landroid_content_Intent_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getTriggeringGeofences_Landroid_content_Intent_;
		[Register ("getTriggeringGeofences", "(Landroid/content/Intent;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Android.Gms.Location.IGeofence> GetTriggeringGeofences (global::Android.Content.Intent p0)
		{
			if (id_getTriggeringGeofences_Landroid_content_Intent_ == IntPtr.Zero)
				id_getTriggeringGeofences_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getTriggeringGeofences", "(Landroid/content/Intent;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Gms.Location.IGeofence> __ret = global::Android.Runtime.JavaList<global::Android.Gms.Location.IGeofence>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTriggeringGeofences_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_hasError_Landroid_content_Intent_;
		[Register ("hasError", "(Landroid/content/Intent;)Z", "")]
		public static bool HasError (global::Android.Content.Intent p0)
		{
			if (id_hasError_Landroid_content_Intent_ == IntPtr.Zero)
				id_hasError_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "hasError", "(Landroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasError_Landroid_content_Intent_, new JValue (p0));
			return __ret;
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_;
#pragma warning disable 0169
		static Delegate GetRemoveGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_Handler ()
		{
			if (cb_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ == null)
				cb_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_);
			return cb_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_;
		}

		static void n_RemoveGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGeofences (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_;
		[Register ("removeGeofences", "(Landroid/app/PendingIntent;Lcom/google/android/gms/location/LocationClient$OnRemoveGeofencesResultListener;)V", "GetRemoveGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_Handler")]
		public virtual void RemoveGeofences (global::Android.App.PendingIntent p0, global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener p1)
		{
			if (id_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ == IntPtr.Zero)
				id_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ = JNIEnv.GetMethodID (class_ref, "removeGeofences", "(Landroid/app/PendingIntent;Lcom/google/android/gms/location/LocationClient$OnRemoveGeofencesResultListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeGeofences_Landroid_app_PendingIntent_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_;
#pragma warning disable 0169
		static Delegate GetRemoveGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_Handler ()
		{
			if (cb_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ == null)
				cb_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_);
			return cb_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_;
		}

		static void n_RemoveGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGeofences (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_;
		[Register ("removeGeofences", "(Ljava/util/List;Lcom/google/android/gms/location/LocationClient$OnRemoveGeofencesResultListener;)V", "GetRemoveGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_Handler")]
		public virtual void RemoveGeofences (global::System.Collections.Generic.IList<string> p0, global::Android.Gms.Location.LocationClient.IOnRemoveGeofencesResultListener p1)
		{
			if (id_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ == IntPtr.Zero)
				id_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_ = JNIEnv.GetMethodID (class_ref, "removeGeofences", "(Ljava/util/List;Lcom/google/android/gms/location/LocationClient$OnRemoveGeofencesResultListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeGeofences_Ljava_util_List_Lcom_google_android_gms_location_LocationClient_OnRemoveGeofencesResultListener_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeLocationUpdates_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetRemoveLocationUpdates_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_removeLocationUpdates_Landroid_app_PendingIntent_ == null)
				cb_removeLocationUpdates_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocationUpdates_Landroid_app_PendingIntent_);
			return cb_removeLocationUpdates_Landroid_app_PendingIntent_;
		}

		static void n_RemoveLocationUpdates_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocationUpdates (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeLocationUpdates_Landroid_app_PendingIntent_;
		[Register ("removeLocationUpdates", "(Landroid/app/PendingIntent;)V", "GetRemoveLocationUpdates_Landroid_app_PendingIntent_Handler")]
		public virtual void RemoveLocationUpdates (global::Android.App.PendingIntent p0)
		{
			if (id_removeLocationUpdates_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_removeLocationUpdates_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "removeLocationUpdates", "(Landroid/app/PendingIntent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeLocationUpdates_Landroid_app_PendingIntent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeLocationUpdates_Landroid_app_PendingIntent_, new JValue (p0));
		}

		static Delegate cb_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_;
#pragma warning disable 0169
		static Delegate GetRemoveLocationUpdates_Lcom_google_android_gms_location_LocationListener_Handler ()
		{
			if (cb_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_ == null)
				cb_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocationUpdates_Lcom_google_android_gms_location_LocationListener_);
			return cb_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_;
		}

		static void n_RemoveLocationUpdates_Lcom_google_android_gms_location_LocationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.ILocationListener p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ILocationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocationUpdates (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_;
		[Register ("removeLocationUpdates", "(Lcom/google/android/gms/location/LocationListener;)V", "GetRemoveLocationUpdates_Lcom_google_android_gms_location_LocationListener_Handler")]
		public virtual void RemoveLocationUpdates (global::Android.Gms.Location.ILocationListener p0)
		{
			if (id_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_ == IntPtr.Zero)
				id_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_ = JNIEnv.GetMethodID (class_ref, "removeLocationUpdates", "(Lcom/google/android/gms/location/LocationListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeLocationUpdates_Lcom_google_android_gms_location_LocationListener_, new JValue (p0));
		}

		static Delegate cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetRequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_ == null)
				cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_);
			return cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_;
		}

		static void n_RequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.LocationRequest p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p1 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationUpdates (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_;
		[Register ("requestLocationUpdates", "(Lcom/google/android/gms/location/LocationRequest;Landroid/app/PendingIntent;)V", "GetRequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_Handler")]
		public virtual void RequestLocationUpdates (global::Android.Gms.Location.LocationRequest p0, global::Android.App.PendingIntent p1)
		{
			if (id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "requestLocationUpdates", "(Lcom/google/android/gms/location/LocationRequest;Landroid/app/PendingIntent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Landroid_app_PendingIntent_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_;
#pragma warning disable 0169
		static Delegate GetRequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Handler ()
		{
			if (cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_ == null)
				cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_);
			return cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_;
		}

		static void n_RequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.LocationRequest p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.ILocationListener p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ILocationListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationUpdates (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_;
		[Register ("requestLocationUpdates", "(Lcom/google/android/gms/location/LocationRequest;Lcom/google/android/gms/location/LocationListener;)V", "GetRequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Handler")]
		public virtual void RequestLocationUpdates (global::Android.Gms.Location.LocationRequest p0, global::Android.Gms.Location.ILocationListener p1)
		{
			if (id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_ == IntPtr.Zero)
				id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_ = JNIEnv.GetMethodID (class_ref, "requestLocationUpdates", "(Lcom/google/android/gms/location/LocationRequest;Lcom/google/android/gms/location/LocationListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_;
#pragma warning disable 0169
		static Delegate GetRequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_Handler ()
		{
			if (cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_ == null)
				cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_);
			return cb_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_;
		}

		static void n_RequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.LocationRequest p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Location.ILocationListener p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ILocationListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Looper p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationUpdates (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_;
		[Register ("requestLocationUpdates", "(Lcom/google/android/gms/location/LocationRequest;Lcom/google/android/gms/location/LocationListener;Landroid/os/Looper;)V", "GetRequestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_Handler")]
		public virtual void RequestLocationUpdates (global::Android.Gms.Location.LocationRequest p0, global::Android.Gms.Location.ILocationListener p1, global::Android.OS.Looper p2)
		{
			if (id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_ == IntPtr.Zero)
				id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "requestLocationUpdates", "(Lcom/google/android/gms/location/LocationRequest;Lcom/google/android/gms/location/LocationListener;Landroid/os/Looper;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_requestLocationUpdates_Lcom_google_android_gms_location_LocationRequest_Lcom_google_android_gms_location_LocationListener_Landroid_os_Looper_, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Location.LocationClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationClient> (native__this, JniHandleOwnership.DoNotTransfer);
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

	}
}
