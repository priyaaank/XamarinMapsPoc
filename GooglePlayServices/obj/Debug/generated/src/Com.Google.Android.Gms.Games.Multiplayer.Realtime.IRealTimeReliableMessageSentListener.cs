using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	[Register ("com/google/android/gms/games/multiplayer/realtime/RealTimeReliableMessageSentListener", "", "Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListenerInvoker")]
	public partial interface IRealTimeReliableMessageSentListener : IJavaObject {

		[Register ("onRealTimeMessageSent", "(IILjava/lang/String;)V", "GetOnRealTimeMessageSent_IILjava_lang_String_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListenerInvoker, GooglePlayServices")]
		void OnRealTimeMessageSent (int p0, int p1, string p2);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RealTimeReliableMessageSentListener", DoNotGenerateAcw=true)]
	internal class IRealTimeReliableMessageSentListenerInvoker : global::Java.Lang.Object, IRealTimeReliableMessageSentListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RealTimeReliableMessageSentListener");
		IntPtr class_ref;

		public static IRealTimeReliableMessageSentListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRealTimeReliableMessageSentListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.realtime.RealTimeReliableMessageSentListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRealTimeReliableMessageSentListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRealTimeReliableMessageSentListenerInvoker); }
		}

		static Delegate cb_onRealTimeMessageSent_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRealTimeMessageSent_IILjava_lang_String_Handler ()
		{
			if (cb_onRealTimeMessageSent_IILjava_lang_String_ == null)
				cb_onRealTimeMessageSent_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnRealTimeMessageSent_IILjava_lang_String_);
			return cb_onRealTimeMessageSent_IILjava_lang_String_;
		}

		static void n_OnRealTimeMessageSent_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListener> (native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRealTimeMessageSent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onRealTimeMessageSent_IILjava_lang_String_;
		public void OnRealTimeMessageSent (int p0, int p1, string p2)
		{
			if (id_onRealTimeMessageSent_IILjava_lang_String_ == IntPtr.Zero)
				id_onRealTimeMessageSent_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRealTimeMessageSent", "(IILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod (Handle, id_onRealTimeMessageSent_IILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	public partial class RealTimeReliableMessageSentEventArgs : global::System.EventArgs {

		public RealTimeReliableMessageSentEventArgs (int p0, int p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/multiplayer/realtime/RealTimeReliableMessageSentListenerImplementor")]
	internal sealed class IRealTimeReliableMessageSentListenerImplementor : global::Java.Lang.Object, IRealTimeReliableMessageSentListener {

		object sender;

		public IRealTimeReliableMessageSentListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/multiplayer/realtime/RealTimeReliableMessageSentListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RealTimeReliableMessageSentEventArgs> Handler;
#pragma warning restore 0649

		public void OnRealTimeMessageSent (int p0, int p1, string p2)
		{
			if (Handler != null)
				Handler (sender, new RealTimeReliableMessageSentEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IRealTimeReliableMessageSentListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
