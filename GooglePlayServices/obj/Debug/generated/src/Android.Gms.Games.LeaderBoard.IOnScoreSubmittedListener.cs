using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.LeaderBoard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='OnScoreSubmittedListener']"
	[Register ("com/google/android/gms/games/leaderboard/OnScoreSubmittedListener", "", "Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListenerInvoker")]
	public partial interface IOnScoreSubmittedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='OnScoreSubmittedListener']/method[@name='onScoreSubmitted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.android.gms.games.leaderboard.SubmitScoreResult']]"
		[Register ("onScoreSubmitted", "(ILcom/google/android/gms/games/leaderboard/SubmitScoreResult;)V", "GetOnScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_Handler:Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListenerInvoker, GooglePlayServices")]
		void OnScoreSubmitted (int p0, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/OnScoreSubmittedListener", DoNotGenerateAcw=true)]
	internal class IOnScoreSubmittedListenerInvoker : global::Java.Lang.Object, IOnScoreSubmittedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/leaderboard/OnScoreSubmittedListener");
		IntPtr class_ref;

		public static IOnScoreSubmittedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnScoreSubmittedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.leaderboard.OnScoreSubmittedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnScoreSubmittedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnScoreSubmittedListenerInvoker); }
		}

		static Delegate cb_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_;
#pragma warning disable 0169
		static Delegate GetOnScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_Handler ()
		{
			if (cb_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_ == null)
				cb_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_);
			return cb_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_;
		}

		static void n_OnScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Games.LeaderBoard.SubmitScoreResult p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.SubmitScoreResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnScoreSubmitted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_;
		public void OnScoreSubmitted (int p0, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult p1)
		{
			if (id_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_ == IntPtr.Zero)
				id_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_ = JNIEnv.GetMethodID (class_ref, "onScoreSubmitted", "(ILcom/google/android/gms/games/leaderboard/SubmitScoreResult;)V");
			JNIEnv.CallVoidMethod (Handle, id_onScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_, new JValue (p0), new JValue (p1));
		}

	}

	public partial class ScoreSubmittedEventArgs : global::System.EventArgs {

		public ScoreSubmittedEventArgs (int p0, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Android.Gms.Games.LeaderBoard.SubmitScoreResult p1;
		public global::Android.Gms.Games.LeaderBoard.SubmitScoreResult P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/leaderboard/OnScoreSubmittedListenerImplementor")]
	internal sealed class IOnScoreSubmittedListenerImplementor : global::Java.Lang.Object, IOnScoreSubmittedListener {

		object sender;

		public IOnScoreSubmittedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/leaderboard/OnScoreSubmittedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ScoreSubmittedEventArgs> Handler;
#pragma warning restore 0649

		public void OnScoreSubmitted (int p0, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ScoreSubmittedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnScoreSubmittedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
