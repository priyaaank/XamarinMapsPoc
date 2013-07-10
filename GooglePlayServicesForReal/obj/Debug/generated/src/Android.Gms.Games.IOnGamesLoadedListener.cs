using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[Register ("com/google/android/gms/games/OnGamesLoadedListener", "", "Android.Gms.Games.IOnGamesLoadedListenerInvoker")]
	public partial interface IOnGamesLoadedListener : IJavaObject {

		[Register ("onGamesLoaded", "(ILcom/google/android/gms/games/GameBuffer;)V", "GetOnGamesLoaded_ILcom_google_android_gms_games_GameBuffer_Handler:Android.Gms.Games.IOnGamesLoadedListenerInvoker, GooglePlayServicesForReal")]
		void OnGamesLoaded (int p0, global::Android.Gms.Games.GameBuffer p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/OnGamesLoadedListener", DoNotGenerateAcw=true)]
	internal class IOnGamesLoadedListenerInvoker : global::Java.Lang.Object, IOnGamesLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/OnGamesLoadedListener");
		IntPtr class_ref;

		public static IOnGamesLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGamesLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.OnGamesLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGamesLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnGamesLoadedListenerInvoker); }
		}

		static Delegate cb_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_;
#pragma warning disable 0169
		static Delegate GetOnGamesLoaded_ILcom_google_android_gms_games_GameBuffer_Handler ()
		{
			if (cb_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_ == null)
				cb_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnGamesLoaded_ILcom_google_android_gms_games_GameBuffer_);
			return cb_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_;
		}

		static void n_OnGamesLoaded_ILcom_google_android_gms_games_GameBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Gms.Games.IOnGamesLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IOnGamesLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Games.GameBuffer p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.GameBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGamesLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_;
		public void OnGamesLoaded (int p0, global::Android.Gms.Games.GameBuffer p1)
		{
			if (id_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_ == IntPtr.Zero)
				id_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_ = JNIEnv.GetMethodID (class_ref, "onGamesLoaded", "(ILcom/google/android/gms/games/GameBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_onGamesLoaded_ILcom_google_android_gms_games_GameBuffer_, new JValue (p0), new JValue (p1));
		}

	}

	public partial class GamesLoadedEventArgs : global::System.EventArgs {

		public GamesLoadedEventArgs (int p0, global::Android.Gms.Games.GameBuffer p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Android.Gms.Games.GameBuffer p1;
		public global::Android.Gms.Games.GameBuffer P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/OnGamesLoadedListenerImplementor")]
	internal sealed class IOnGamesLoadedListenerImplementor : global::Java.Lang.Object, IOnGamesLoadedListener {

		object sender;

		public IOnGamesLoadedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/OnGamesLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GamesLoadedEventArgs> Handler;
#pragma warning restore 0649

		public void OnGamesLoaded (int p0, global::Android.Gms.Games.GameBuffer p1)
		{
			if (Handler != null)
				Handler (sender, new GamesLoadedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnGamesLoadedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
