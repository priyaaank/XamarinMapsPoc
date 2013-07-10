using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.LeaderBoard {

	[Register ("com/google/android/gms/games/leaderboard/Leaderboard")]
	public abstract class Leaderboard {

		internal Leaderboard ()
		{
		}

		[Register ("SCORE_ORDER_LARGER_IS_BETTER")]
		public const int ScoreOrderLargerIsBetter = (int) 1;

		[Register ("SCORE_ORDER_SMALLER_IS_BETTER")]
		public const int ScoreOrderSmallerIsBetter = (int) 0;
	}

	[System.Obsolete ("Use the 'Leaderboard' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class LeaderboardConsts : Leaderboard {

		private LeaderboardConsts ()
		{
		}
	}

	[Register ("com/google/android/gms/games/leaderboard/Leaderboard", "", "Android.Gms.Games.LeaderBoard.ILeaderboardInvoker")]
	public partial interface ILeaderboard : IJavaObject {

		string DisplayName {
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler:Android.Gms.Games.LeaderBoard.ILeaderboardInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri IconImageUri {
			[Register ("getIconImageUri", "()Landroid/net/Uri;", "GetGetIconImageUriHandler:Android.Gms.Games.LeaderBoard.ILeaderboardInvoker, GooglePlayServices")] get;
		}

		string LeaderboardId {
			[Register ("getLeaderboardId", "()Ljava/lang/String;", "GetGetLeaderboardIdHandler:Android.Gms.Games.LeaderBoard.ILeaderboardInvoker, GooglePlayServices")] get;
		}

		int ScoreOrder {
			[Register ("getScoreOrder", "()I", "GetGetScoreOrderHandler:Android.Gms.Games.LeaderBoard.ILeaderboardInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> Variants {
			[Register ("getVariants", "()Ljava/util/ArrayList;", "GetGetVariantsHandler:Android.Gms.Games.LeaderBoard.ILeaderboardInvoker, GooglePlayServices")] get;
		}

		[Register ("getDisplayName", "(Landroid/database/CharArrayBuffer;)V", "GetGetDisplayName_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.LeaderBoard.ILeaderboardInvoker, GooglePlayServices")]
		void GetDisplayName (global::Android.Database.CharArrayBuffer p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/Leaderboard", DoNotGenerateAcw=true)]
	internal class ILeaderboardInvoker : global::Java.Lang.Object, ILeaderboard {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/leaderboard/Leaderboard");
		IntPtr class_ref;

		public static ILeaderboard GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILeaderboard> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.leaderboard.Leaderboard"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILeaderboardInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILeaderboardInvoker); }
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboard> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayName;
		public string DisplayName {
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIconImageUri;
#pragma warning disable 0169
		static Delegate GetGetIconImageUriHandler ()
		{
			if (cb_getIconImageUri == null)
				cb_getIconImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconImageUri);
			return cb_getIconImageUri;
		}

		static IntPtr n_GetIconImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboard> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getIconImageUri;
		public global::Android.Net.Uri IconImageUri {
			get {
				if (id_getIconImageUri == IntPtr.Zero)
					id_getIconImageUri = JNIEnv.GetMethodID (class_ref, "getIconImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getIconImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLeaderboardId;
#pragma warning disable 0169
		static Delegate GetGetLeaderboardIdHandler ()
		{
			if (cb_getLeaderboardId == null)
				cb_getLeaderboardId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeaderboardId);
			return cb_getLeaderboardId;
		}

		static IntPtr n_GetLeaderboardId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboard> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LeaderboardId);
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboardId;
		public string LeaderboardId {
			get {
				if (id_getLeaderboardId == IntPtr.Zero)
					id_getLeaderboardId = JNIEnv.GetMethodID (class_ref, "getLeaderboardId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLeaderboardId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScoreOrder;
#pragma warning disable 0169
		static Delegate GetGetScoreOrderHandler ()
		{
			if (cb_getScoreOrder == null)
				cb_getScoreOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScoreOrder);
			return cb_getScoreOrder;
		}

		static int n_GetScoreOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboard> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScoreOrder;
		}
#pragma warning restore 0169

		IntPtr id_getScoreOrder;
		public int ScoreOrder {
			get {
				if (id_getScoreOrder == IntPtr.Zero)
					id_getScoreOrder = JNIEnv.GetMethodID (class_ref, "getScoreOrder", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getScoreOrder);
			}
		}

		static Delegate cb_getVariants;
#pragma warning disable 0169
		static Delegate GetGetVariantsHandler ()
		{
			if (cb_getVariants == null)
				cb_getVariants = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVariants);
			return cb_getVariants;
		}

		static IntPtr n_GetVariants (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboard> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant>.ToLocalJniHandle (__this.Variants);
		}
#pragma warning restore 0169

		IntPtr id_getVariants;
		public global::System.Collections.Generic.IList<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> Variants {
			get {
				if (id_getVariants == IntPtr.Zero)
					id_getVariants = JNIEnv.GetMethodID (class_ref, "getVariants", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getVariants), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDisplayName_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetDisplayName_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getDisplayName_Landroid_database_CharArrayBuffer_ == null)
				cb_getDisplayName_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDisplayName_Landroid_database_CharArrayBuffer_);
			return cb_getDisplayName_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetDisplayName_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboard> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDisplayName (p0);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayName_Landroid_database_CharArrayBuffer_;
		public void GetDisplayName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDisplayName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDisplayName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getDisplayName_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

	}

}
