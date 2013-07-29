using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='OnPlayersLoadedListener']"
	[Register ("com/google/android/gms/games/OnPlayersLoadedListener", "", "Android.Gms.Games.IOnPlayersLoadedListenerInvoker")]
	public partial interface IOnPlayersLoadedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/interface[@name='OnPlayersLoadedListener']/method[@name='onPlayersLoaded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.android.gms.games.PlayerBuffer']]"
		[Register ("onPlayersLoaded", "(ILcom/google/android/gms/games/PlayerBuffer;)V", "GetOnPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_Handler:Android.Gms.Games.IOnPlayersLoadedListenerInvoker, GooglePlayServices")]
		void OnPlayersLoaded (int p0, global::Android.Gms.Games.PlayerBuffer p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/OnPlayersLoadedListener", DoNotGenerateAcw=true)]
	internal class IOnPlayersLoadedListenerInvoker : global::Java.Lang.Object, IOnPlayersLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/OnPlayersLoadedListener");
		IntPtr class_ref;

		public static IOnPlayersLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPlayersLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.OnPlayersLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPlayersLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnPlayersLoadedListenerInvoker); }
		}

		static Delegate cb_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_;
#pragma warning disable 0169
		static Delegate GetOnPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_Handler ()
		{
			if (cb_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_ == null)
				cb_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_);
			return cb_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_;
		}

		static void n_OnPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Gms.Games.IOnPlayersLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IOnPlayersLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Games.PlayerBuffer p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.PlayerBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPlayersLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_;
		public void OnPlayersLoaded (int p0, global::Android.Gms.Games.PlayerBuffer p1)
		{
			if (id_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_ == IntPtr.Zero)
				id_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_ = JNIEnv.GetMethodID (class_ref, "onPlayersLoaded", "(ILcom/google/android/gms/games/PlayerBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_onPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_, new JValue (p0), new JValue (p1));
		}

	}

	public partial class PlayersLoadedEventArgs : global::System.EventArgs {

		public PlayersLoadedEventArgs (int p0, global::Android.Gms.Games.PlayerBuffer p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Android.Gms.Games.PlayerBuffer p1;
		public global::Android.Gms.Games.PlayerBuffer P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/OnPlayersLoadedListenerImplementor")]
	internal sealed class IOnPlayersLoadedListenerImplementor : global::Java.Lang.Object, IOnPlayersLoadedListener {

		object sender;

		public IOnPlayersLoadedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/OnPlayersLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PlayersLoadedEventArgs> Handler;
#pragma warning restore 0649

		public void OnPlayersLoaded (int p0, global::Android.Gms.Games.PlayerBuffer p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PlayersLoadedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnPlayersLoadedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
