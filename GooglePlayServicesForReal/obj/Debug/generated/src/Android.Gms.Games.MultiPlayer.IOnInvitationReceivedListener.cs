using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.MultiPlayer {

	[Register ("com/google/android/gms/games/multiplayer/OnInvitationReceivedListener", "", "Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListenerInvoker")]
	public partial interface IOnInvitationReceivedListener : IJavaObject {

		[Register ("onInvitationReceived", "(Lcom/google/android/gms/games/multiplayer/Invitation;)V", "GetOnInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_Handler:Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListenerInvoker, GooglePlayServicesForReal")]
		void OnInvitationReceived (global::Android.Gms.Games.MultiPlayer.IInvitation p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/OnInvitationReceivedListener", DoNotGenerateAcw=true)]
	internal class IOnInvitationReceivedListenerInvoker : global::Java.Lang.Object, IOnInvitationReceivedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/OnInvitationReceivedListener");
		IntPtr class_ref;

		public static IOnInvitationReceivedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnInvitationReceivedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.OnInvitationReceivedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnInvitationReceivedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnInvitationReceivedListenerInvoker); }
		}

		static Delegate cb_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_;
#pragma warning disable 0169
		static Delegate GetOnInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_Handler ()
		{
			if (cb_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_ == null)
				cb_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_);
			return cb_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_;
		}

		static void n_OnInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Games.MultiPlayer.IInvitation p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInvitationReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_;
		public void OnInvitationReceived (global::Android.Gms.Games.MultiPlayer.IInvitation p0)
		{
			if (id_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_ == IntPtr.Zero)
				id_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_ = JNIEnv.GetMethodID (class_ref, "onInvitationReceived", "(Lcom/google/android/gms/games/multiplayer/Invitation;)V");
			JNIEnv.CallVoidMethod (Handle, id_onInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_, new JValue (p0));
		}

	}

	public partial class InvitationReceivedEventArgs : global::System.EventArgs {

		public InvitationReceivedEventArgs (global::Android.Gms.Games.MultiPlayer.IInvitation p0)
		{
			this.p0 = p0;
		}

		global::Android.Gms.Games.MultiPlayer.IInvitation p0;
		public global::Android.Gms.Games.MultiPlayer.IInvitation P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/multiplayer/OnInvitationReceivedListenerImplementor")]
	internal sealed class IOnInvitationReceivedListenerImplementor : global::Java.Lang.Object, IOnInvitationReceivedListener {

		object sender;

		public IOnInvitationReceivedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/multiplayer/OnInvitationReceivedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<InvitationReceivedEventArgs> Handler;
#pragma warning restore 0649

		public void OnInvitationReceived (global::Android.Gms.Games.MultiPlayer.IInvitation p0)
		{
			if (Handler != null)
				Handler (sender, new InvitationReceivedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnInvitationReceivedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
