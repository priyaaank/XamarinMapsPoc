using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[Register ("com/google/android/gms/games/OnSignOutCompleteListener", "", "Android.Gms.Games.IOnSignOutCompleteListenerInvoker")]
	public partial interface IOnSignOutCompleteListener : IJavaObject {

		[Register ("onSignOutComplete", "()V", "GetOnSignOutCompleteHandler:Android.Gms.Games.IOnSignOutCompleteListenerInvoker, GooglePlayServicesForReal")]
		void OnSignOutComplete ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/OnSignOutCompleteListener", DoNotGenerateAcw=true)]
	internal class IOnSignOutCompleteListenerInvoker : global::Java.Lang.Object, IOnSignOutCompleteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/OnSignOutCompleteListener");
		IntPtr class_ref;

		public static IOnSignOutCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSignOutCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.OnSignOutCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSignOutCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnSignOutCompleteListenerInvoker); }
		}

		static Delegate cb_onSignOutComplete;
#pragma warning disable 0169
		static Delegate GetOnSignOutCompleteHandler ()
		{
			if (cb_onSignOutComplete == null)
				cb_onSignOutComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSignOutComplete);
			return cb_onSignOutComplete;
		}

		static void n_OnSignOutComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IOnSignOutCompleteListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IOnSignOutCompleteListener> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSignOutComplete ();
		}
#pragma warning restore 0169

		IntPtr id_onSignOutComplete;
		public void OnSignOutComplete ()
		{
			if (id_onSignOutComplete == IntPtr.Zero)
				id_onSignOutComplete = JNIEnv.GetMethodID (class_ref, "onSignOutComplete", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onSignOutComplete);
		}

	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/OnSignOutCompleteListenerImplementor")]
	internal sealed class IOnSignOutCompleteListenerImplementor : global::Java.Lang.Object, IOnSignOutCompleteListener {

		object sender;

		public IOnSignOutCompleteListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/OnSignOutCompleteListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnSignOutComplete ()
		{
			if (Handler != null)
				Handler (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnSignOutCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
