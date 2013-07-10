using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.AppStates {

	[Register ("com/google/android/gms/appstate/OnStateDeletedListener", "", "Android.Gms.AppStates.IOnStateDeletedListenerInvoker")]
	public partial interface IOnStateDeletedListener : IJavaObject {

		[Register ("onStateDeleted", "(II)V", "GetOnStateDeleted_IIHandler:Android.Gms.AppStates.IOnStateDeletedListenerInvoker, GooglePlayServicesForReal")]
		void OnStateDeleted (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/appstate/OnStateDeletedListener", DoNotGenerateAcw=true)]
	internal class IOnStateDeletedListenerInvoker : global::Java.Lang.Object, IOnStateDeletedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/appstate/OnStateDeletedListener");
		IntPtr class_ref;

		public static IOnStateDeletedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnStateDeletedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.appstate.OnStateDeletedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnStateDeletedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnStateDeletedListenerInvoker); }
		}

		static Delegate cb_onStateDeleted_II;
#pragma warning disable 0169
		static Delegate GetOnStateDeleted_IIHandler ()
		{
			if (cb_onStateDeleted_II == null)
				cb_onStateDeleted_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnStateDeleted_II);
			return cb_onStateDeleted_II;
		}

		static void n_OnStateDeleted_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Gms.AppStates.IOnStateDeletedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IOnStateDeletedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStateDeleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onStateDeleted_II;
		public void OnStateDeleted (int p0, int p1)
		{
			if (id_onStateDeleted_II == IntPtr.Zero)
				id_onStateDeleted_II = JNIEnv.GetMethodID (class_ref, "onStateDeleted", "(II)V");
			JNIEnv.CallVoidMethod (Handle, id_onStateDeleted_II, new JValue (p0), new JValue (p1));
		}

	}

	public partial class StateDeletedEventArgs : global::System.EventArgs {

		public StateDeletedEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/appstate/OnStateDeletedListenerImplementor")]
	internal sealed class IOnStateDeletedListenerImplementor : global::Java.Lang.Object, IOnStateDeletedListener {

		object sender;

		public IOnStateDeletedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/appstate/OnStateDeletedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<StateDeletedEventArgs> Handler;
#pragma warning restore 0649

		public void OnStateDeleted (int p0, int p1)
		{
			if (Handler != null)
				Handler (sender, new StateDeletedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnStateDeletedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
