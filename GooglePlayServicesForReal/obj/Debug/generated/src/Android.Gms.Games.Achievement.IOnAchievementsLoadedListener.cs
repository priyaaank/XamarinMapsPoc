using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.Achievement {

	[Register ("com/google/android/gms/games/achievement/OnAchievementsLoadedListener", "", "Android.Gms.Games.Achievement.IOnAchievementsLoadedListenerInvoker")]
	public partial interface IOnAchievementsLoadedListener : IJavaObject {

		[Register ("onAchievementsLoaded", "(ILcom/google/android/gms/games/achievement/AchievementBuffer;)V", "GetOnAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_Handler:Android.Gms.Games.Achievement.IOnAchievementsLoadedListenerInvoker, GooglePlayServicesForReal")]
		void OnAchievementsLoaded (int p0, global::Android.Gms.Games.Achievement.AchievementBuffer p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/achievement/OnAchievementsLoadedListener", DoNotGenerateAcw=true)]
	internal class IOnAchievementsLoadedListenerInvoker : global::Java.Lang.Object, IOnAchievementsLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/achievement/OnAchievementsLoadedListener");
		IntPtr class_ref;

		public static IOnAchievementsLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnAchievementsLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.achievement.OnAchievementsLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnAchievementsLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnAchievementsLoadedListenerInvoker); }
		}

		static Delegate cb_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_;
#pragma warning disable 0169
		static Delegate GetOnAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_Handler ()
		{
			if (cb_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_ == null)
				cb_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_);
			return cb_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_;
		}

		static void n_OnAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Gms.Games.Achievement.IOnAchievementsLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IOnAchievementsLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Games.Achievement.AchievementBuffer p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.AchievementBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAchievementsLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_;
		public void OnAchievementsLoaded (int p0, global::Android.Gms.Games.Achievement.AchievementBuffer p1)
		{
			if (id_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_ == IntPtr.Zero)
				id_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_ = JNIEnv.GetMethodID (class_ref, "onAchievementsLoaded", "(ILcom/google/android/gms/games/achievement/AchievementBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_onAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_, new JValue (p0), new JValue (p1));
		}

	}

	public partial class AchievementsLoadedEventArgs : global::System.EventArgs {

		public AchievementsLoadedEventArgs (int p0, global::Android.Gms.Games.Achievement.AchievementBuffer p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Android.Gms.Games.Achievement.AchievementBuffer p1;
		public global::Android.Gms.Games.Achievement.AchievementBuffer P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/achievement/OnAchievementsLoadedListenerImplementor")]
	internal sealed class IOnAchievementsLoadedListenerImplementor : global::Java.Lang.Object, IOnAchievementsLoadedListener {

		object sender;

		public IOnAchievementsLoadedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/achievement/OnAchievementsLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AchievementsLoadedEventArgs> Handler;
#pragma warning restore 0649

		public void OnAchievementsLoaded (int p0, global::Android.Gms.Games.Achievement.AchievementBuffer p1)
		{
			if (Handler != null)
				Handler (sender, new AchievementsLoadedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnAchievementsLoadedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
