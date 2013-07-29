using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.AppStates {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.appstate']/interface[@name='OnStateListLoadedListener']"
	[Register ("com/google/android/gms/appstate/OnStateListLoadedListener", "", "Android.Gms.AppStates.IOnStateListLoadedListenerInvoker")]
	public partial interface IOnStateListLoadedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.appstate']/interface[@name='OnStateListLoadedListener']/method[@name='onStateListLoaded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.android.gms.appstate.AppStateBuffer']]"
		[Register ("onStateListLoaded", "(ILcom/google/android/gms/appstate/AppStateBuffer;)V", "GetOnStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_Handler:Android.Gms.AppStates.IOnStateListLoadedListenerInvoker, GooglePlayServices")]
		void OnStateListLoaded (int p0, global::Android.Gms.AppStates.AppStateBuffer p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/appstate/OnStateListLoadedListener", DoNotGenerateAcw=true)]
	internal class IOnStateListLoadedListenerInvoker : global::Java.Lang.Object, IOnStateListLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/appstate/OnStateListLoadedListener");
		IntPtr class_ref;

		public static IOnStateListLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnStateListLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.appstate.OnStateListLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnStateListLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnStateListLoadedListenerInvoker); }
		}

		static Delegate cb_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_;
#pragma warning disable 0169
		static Delegate GetOnStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_Handler ()
		{
			if (cb_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_ == null)
				cb_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_);
			return cb_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_;
		}

		static void n_OnStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Gms.AppStates.IOnStateListLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IOnStateListLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.AppStates.AppStateBuffer p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.AppStateBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnStateListLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_;
		public void OnStateListLoaded (int p0, global::Android.Gms.AppStates.AppStateBuffer p1)
		{
			if (id_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_ == IntPtr.Zero)
				id_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_ = JNIEnv.GetMethodID (class_ref, "onStateListLoaded", "(ILcom/google/android/gms/appstate/AppStateBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_onStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_, new JValue (p0), new JValue (p1));
		}

	}

	public partial class StateListLoadedEventArgs : global::System.EventArgs {

		public StateListLoadedEventArgs (int p0, global::Android.Gms.AppStates.AppStateBuffer p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Android.Gms.AppStates.AppStateBuffer p1;
		public global::Android.Gms.AppStates.AppStateBuffer P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/appstate/OnStateListLoadedListenerImplementor")]
	internal sealed class IOnStateListLoadedListenerImplementor : global::Java.Lang.Object, IOnStateListLoadedListener {

		object sender;

		public IOnStateListLoadedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/appstate/OnStateListLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<StateListLoadedEventArgs> Handler;
#pragma warning restore 0649

		public void OnStateListLoaded (int p0, global::Android.Gms.AppStates.AppStateBuffer p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new StateListLoadedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnStateListLoadedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
