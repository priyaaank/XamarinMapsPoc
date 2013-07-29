using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.LeaderBoard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']"
	[Register ("com/google/android/gms/games/leaderboard/LeaderboardScore", "", "Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker")]
	public partial interface ILeaderboardScore : global::Android.Gms.Common.Data.IFreezable {

		string DisplayRank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getDisplayRank' and count(parameter)=0]"
			[Register ("getDisplayRank", "()Ljava/lang/String;", "GetGetDisplayRankHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		string DisplayScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getDisplayScore' and count(parameter)=0]"
			[Register ("getDisplayScore", "()Ljava/lang/String;", "GetGetDisplayScoreHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		long Rank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getRank' and count(parameter)=0]"
			[Register ("getRank", "()J", "GetGetRankHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		long RawScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getRawScore' and count(parameter)=0]"
			[Register ("getRawScore", "()J", "GetGetRawScoreHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Games.IPlayer ScoreHolder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getScoreHolder' and count(parameter)=0]"
			[Register ("getScoreHolder", "()Lcom/google/android/gms/games/Player;", "GetGetScoreHolderHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		string ScoreHolderDisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getScoreHolderDisplayName' and count(parameter)=0]"
			[Register ("getScoreHolderDisplayName", "()Ljava/lang/String;", "GetGetScoreHolderDisplayNameHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri ScoreHolderHiResImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getScoreHolderHiResImageUri' and count(parameter)=0]"
			[Register ("getScoreHolderHiResImageUri", "()Landroid/net/Uri;", "GetGetScoreHolderHiResImageUriHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri ScoreHolderIconImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getScoreHolderIconImageUri' and count(parameter)=0]"
			[Register ("getScoreHolderIconImageUri", "()Landroid/net/Uri;", "GetGetScoreHolderIconImageUriHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		long TimestampMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getTimestampMillis' and count(parameter)=0]"
			[Register ("getTimestampMillis", "()J", "GetGetTimestampMillisHandler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getDisplayRank' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getDisplayRank", "(Landroid/database/CharArrayBuffer;)V", "GetGetDisplayRank_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")]
		void GetDisplayRank (global::Android.Database.CharArrayBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getDisplayScore' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getDisplayScore", "(Landroid/database/CharArrayBuffer;)V", "GetGetDisplayScore_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")]
		void GetDisplayScore (global::Android.Database.CharArrayBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardScore']/method[@name='getScoreHolderDisplayName' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getScoreHolderDisplayName", "(Landroid/database/CharArrayBuffer;)V", "GetGetScoreHolderDisplayName_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.LeaderBoard.ILeaderboardScoreInvoker, GooglePlayServices")]
		void GetScoreHolderDisplayName (global::Android.Database.CharArrayBuffer p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/LeaderboardScore", DoNotGenerateAcw=true)]
	internal class ILeaderboardScoreInvoker : global::Java.Lang.Object, ILeaderboardScore {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/leaderboard/LeaderboardScore");
		IntPtr class_ref;

		public static ILeaderboardScore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILeaderboardScore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.leaderboard.LeaderboardScore"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILeaderboardScoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILeaderboardScoreInvoker); }
		}

		static Delegate cb_getDisplayRank;
#pragma warning disable 0169
		static Delegate GetGetDisplayRankHandler ()
		{
			if (cb_getDisplayRank == null)
				cb_getDisplayRank = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayRank);
			return cb_getDisplayRank;
		}

		static IntPtr n_GetDisplayRank (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayRank);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayRank;
		public string DisplayRank {
			get {
				if (id_getDisplayRank == IntPtr.Zero)
					id_getDisplayRank = JNIEnv.GetMethodID (class_ref, "getDisplayRank", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayRank), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDisplayScore;
#pragma warning disable 0169
		static Delegate GetGetDisplayScoreHandler ()
		{
			if (cb_getDisplayScore == null)
				cb_getDisplayScore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayScore);
			return cb_getDisplayScore;
		}

		static IntPtr n_GetDisplayScore (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayScore);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayScore;
		public string DisplayScore {
			get {
				if (id_getDisplayScore == IntPtr.Zero)
					id_getDisplayScore = JNIEnv.GetMethodID (class_ref, "getDisplayScore", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayScore), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRank;
#pragma warning disable 0169
		static Delegate GetGetRankHandler ()
		{
			if (cb_getRank == null)
				cb_getRank = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRank);
			return cb_getRank;
		}

		static long n_GetRank (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rank;
		}
#pragma warning restore 0169

		IntPtr id_getRank;
		public long Rank {
			get {
				if (id_getRank == IntPtr.Zero)
					id_getRank = JNIEnv.GetMethodID (class_ref, "getRank", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getRank);
			}
		}

		static Delegate cb_getRawScore;
#pragma warning disable 0169
		static Delegate GetGetRawScoreHandler ()
		{
			if (cb_getRawScore == null)
				cb_getRawScore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRawScore);
			return cb_getRawScore;
		}

		static long n_GetRawScore (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawScore;
		}
#pragma warning restore 0169

		IntPtr id_getRawScore;
		public long RawScore {
			get {
				if (id_getRawScore == IntPtr.Zero)
					id_getRawScore = JNIEnv.GetMethodID (class_ref, "getRawScore", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getRawScore);
			}
		}

		static Delegate cb_getScoreHolder;
#pragma warning disable 0169
		static Delegate GetGetScoreHolderHandler ()
		{
			if (cb_getScoreHolder == null)
				cb_getScoreHolder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScoreHolder);
			return cb_getScoreHolder;
		}

		static IntPtr n_GetScoreHolder (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScoreHolder);
		}
#pragma warning restore 0169

		IntPtr id_getScoreHolder;
		public global::Android.Gms.Games.IPlayer ScoreHolder {
			get {
				if (id_getScoreHolder == IntPtr.Zero)
					id_getScoreHolder = JNIEnv.GetMethodID (class_ref, "getScoreHolder", "()Lcom/google/android/gms/games/Player;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (JNIEnv.CallObjectMethod (Handle, id_getScoreHolder), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScoreHolderDisplayName;
#pragma warning disable 0169
		static Delegate GetGetScoreHolderDisplayNameHandler ()
		{
			if (cb_getScoreHolderDisplayName == null)
				cb_getScoreHolderDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScoreHolderDisplayName);
			return cb_getScoreHolderDisplayName;
		}

		static IntPtr n_GetScoreHolderDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScoreHolderDisplayName);
		}
#pragma warning restore 0169

		IntPtr id_getScoreHolderDisplayName;
		public string ScoreHolderDisplayName {
			get {
				if (id_getScoreHolderDisplayName == IntPtr.Zero)
					id_getScoreHolderDisplayName = JNIEnv.GetMethodID (class_ref, "getScoreHolderDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getScoreHolderDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScoreHolderHiResImageUri;
#pragma warning disable 0169
		static Delegate GetGetScoreHolderHiResImageUriHandler ()
		{
			if (cb_getScoreHolderHiResImageUri == null)
				cb_getScoreHolderHiResImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScoreHolderHiResImageUri);
			return cb_getScoreHolderHiResImageUri;
		}

		static IntPtr n_GetScoreHolderHiResImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScoreHolderHiResImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getScoreHolderHiResImageUri;
		public global::Android.Net.Uri ScoreHolderHiResImageUri {
			get {
				if (id_getScoreHolderHiResImageUri == IntPtr.Zero)
					id_getScoreHolderHiResImageUri = JNIEnv.GetMethodID (class_ref, "getScoreHolderHiResImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getScoreHolderHiResImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScoreHolderIconImageUri;
#pragma warning disable 0169
		static Delegate GetGetScoreHolderIconImageUriHandler ()
		{
			if (cb_getScoreHolderIconImageUri == null)
				cb_getScoreHolderIconImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScoreHolderIconImageUri);
			return cb_getScoreHolderIconImageUri;
		}

		static IntPtr n_GetScoreHolderIconImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScoreHolderIconImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getScoreHolderIconImageUri;
		public global::Android.Net.Uri ScoreHolderIconImageUri {
			get {
				if (id_getScoreHolderIconImageUri == IntPtr.Zero)
					id_getScoreHolderIconImageUri = JNIEnv.GetMethodID (class_ref, "getScoreHolderIconImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getScoreHolderIconImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTimestampMillis;
#pragma warning disable 0169
		static Delegate GetGetTimestampMillisHandler ()
		{
			if (cb_getTimestampMillis == null)
				cb_getTimestampMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestampMillis);
			return cb_getTimestampMillis;
		}

		static long n_GetTimestampMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimestampMillis;
		}
#pragma warning restore 0169

		IntPtr id_getTimestampMillis;
		public long TimestampMillis {
			get {
				if (id_getTimestampMillis == IntPtr.Zero)
					id_getTimestampMillis = JNIEnv.GetMethodID (class_ref, "getTimestampMillis", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getTimestampMillis);
			}
		}

		static Delegate cb_getDisplayRank_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetDisplayRank_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getDisplayRank_Landroid_database_CharArrayBuffer_ == null)
				cb_getDisplayRank_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDisplayRank_Landroid_database_CharArrayBuffer_);
			return cb_getDisplayRank_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetDisplayRank_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDisplayRank (p0);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayRank_Landroid_database_CharArrayBuffer_;
		public void GetDisplayRank (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDisplayRank_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDisplayRank_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDisplayRank", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getDisplayRank_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static Delegate cb_getDisplayScore_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetDisplayScore_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getDisplayScore_Landroid_database_CharArrayBuffer_ == null)
				cb_getDisplayScore_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDisplayScore_Landroid_database_CharArrayBuffer_);
			return cb_getDisplayScore_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetDisplayScore_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDisplayScore (p0);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayScore_Landroid_database_CharArrayBuffer_;
		public void GetDisplayScore (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDisplayScore_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDisplayScore_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDisplayScore", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getDisplayScore_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static Delegate cb_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetScoreHolderDisplayName_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_ == null)
				cb_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetScoreHolderDisplayName_Landroid_database_CharArrayBuffer_);
			return cb_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetScoreHolderDisplayName_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetScoreHolderDisplayName (p0);
		}
#pragma warning restore 0169

		IntPtr id_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_;
		public void GetScoreHolderDisplayName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getScoreHolderDisplayName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getScoreHolderDisplayName_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static Delegate cb_freeze;
#pragma warning disable 0169
		static Delegate GetFreezeHandler ()
		{
			if (cb_freeze == null)
				cb_freeze = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Freeze);
			return cb_freeze;
		}

		static IntPtr n_Freeze (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardScore __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardScore> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Freeze ());
		}
#pragma warning restore 0169

		IntPtr id_freeze;
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

	}

}
