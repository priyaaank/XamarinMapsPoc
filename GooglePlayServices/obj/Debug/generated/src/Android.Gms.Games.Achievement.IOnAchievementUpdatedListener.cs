using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.Achievement {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='OnAchievementUpdatedListener']"
	[Register ("com/google/android/gms/games/achievement/OnAchievementUpdatedListener", "", "Android.Gms.Games.Achievement.IOnAchievementUpdatedListenerInvoker")]
	public partial interface IOnAchievementUpdatedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='OnAchievementUpdatedListener']/method[@name='onAchievementUpdated' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAchievementUpdated", "(ILjava/lang/String;)V", "GetOnAchievementUpdated_ILjava_lang_String_Handler:Android.Gms.Games.Achievement.IOnAchievementUpdatedListenerInvoker, GooglePlayServices")]
		void OnAchievementUpdated (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/achievement/OnAchievementUpdatedListener", DoNotGenerateAcw=true)]
	internal class IOnAchievementUpdatedListenerInvoker : global::Java.Lang.Object, IOnAchievementUpdatedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/achievement/OnAchievementUpdatedListener");
		IntPtr class_ref;

		public static IOnAchievementUpdatedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnAchievementUpdatedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.achievement.OnAchievementUpdatedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnAchievementUpdatedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnAchievementUpdatedListenerInvoker); }
		}

		static Delegate cb_onAchievementUpdated_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAchievementUpdated_ILjava_lang_String_Handler ()
		{
			if (cb_onAchievementUpdated_ILjava_lang_String_ == null)
				cb_onAchievementUpdated_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnAchievementUpdated_ILjava_lang_String_);
			return cb_onAchievementUpdated_ILjava_lang_String_;
		}

		static void n_OnAchievementUpdated_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Gms.Games.Achievement.IOnAchievementUpdatedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IOnAchievementUpdatedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAchievementUpdated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAchievementUpdated_ILjava_lang_String_;
		public void OnAchievementUpdated (int p0, string p1)
		{
			if (id_onAchievementUpdated_ILjava_lang_String_ == IntPtr.Zero)
				id_onAchievementUpdated_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAchievementUpdated", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_onAchievementUpdated_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class AchievementUpdatedEventArgs : global::System.EventArgs {

		public AchievementUpdatedEventArgs (int p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/achievement/OnAchievementUpdatedListenerImplementor")]
	internal sealed class IOnAchievementUpdatedListenerImplementor : global::Java.Lang.Object, IOnAchievementUpdatedListener {

		object sender;

		public IOnAchievementUpdatedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/achievement/OnAchievementUpdatedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AchievementUpdatedEventArgs> Handler;
#pragma warning restore 0649

		public void OnAchievementUpdated (int p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AchievementUpdatedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnAchievementUpdatedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
