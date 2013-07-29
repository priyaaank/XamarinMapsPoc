using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RealTimeMessageReceivedListener']"
	[Register ("com/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListener", "", "Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeMessageReceivedListenerInvoker")]
	public partial interface IRealTimeMessageReceivedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RealTimeMessageReceivedListener']/method[@name='onRealTimeMessageReceived' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.RealTimeMessage']]"
		[Register ("onRealTimeMessageReceived", "(Lcom/google/android/gms/games/multiplayer/realtime/RealTimeMessage;)V", "GetOnRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeMessageReceivedListenerInvoker, GooglePlayServices")]
		void OnRealTimeMessageReceived (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListener", DoNotGenerateAcw=true)]
	internal class IRealTimeMessageReceivedListenerInvoker : global::Java.Lang.Object, IRealTimeMessageReceivedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListener");
		IntPtr class_ref;

		public static IRealTimeMessageReceivedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRealTimeMessageReceivedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.realtime.RealTimeMessageReceivedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRealTimeMessageReceivedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRealTimeMessageReceivedListenerInvoker); }
		}

		static Delegate cb_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_;
#pragma warning disable 0169
		static Delegate GetOnRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_Handler ()
		{
			if (cb_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_ == null)
				cb_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_);
			return cb_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_;
		}

		static void n_OnRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeMessageReceivedListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRealTimeMessageReceivedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRealTimeMessageReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_;
		public void OnRealTimeMessageReceived (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage p0)
		{
			if (id_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_ == IntPtr.Zero)
				id_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_ = JNIEnv.GetMethodID (class_ref, "onRealTimeMessageReceived", "(Lcom/google/android/gms/games/multiplayer/realtime/RealTimeMessage;)V");
			JNIEnv.CallVoidMethod (Handle, id_onRealTimeMessageReceived_Lcom_google_android_gms_games_multiplayer_realtime_RealTimeMessage_, new JValue (p0));
		}

	}

	public partial class RealTimeMessageReceivedEventArgs : global::System.EventArgs {

		public RealTimeMessageReceivedEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage p0)
		{
			this.p0 = p0;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListenerImplementor")]
	internal sealed class IRealTimeMessageReceivedListenerImplementor : global::Java.Lang.Object, IRealTimeMessageReceivedListener {

		object sender;

		public IRealTimeMessageReceivedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/multiplayer/realtime/RealTimeMessageReceivedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RealTimeMessageReceivedEventArgs> Handler;
#pragma warning restore 0649

		public void OnRealTimeMessageReceived (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.RealTimeMessage p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new RealTimeMessageReceivedEventArgs (p0));
		}

		internal static bool __IsEmpty (IRealTimeMessageReceivedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
