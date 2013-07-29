using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.LeaderBoard {

	[Register ("com/google/android/gms/games/leaderboard/LeaderboardVariant")]
	public abstract class LeaderboardVariant {

		internal LeaderboardVariant ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='COLLECTION_PUBLIC']"
		[Register ("COLLECTION_PUBLIC")]
		public const int CollectionPublic = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='COLLECTION_SOCIAL']"
		[Register ("COLLECTION_SOCIAL")]
		public const int CollectionSocial = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='NUM_SCORES_UNKNOWN']"
		[Register ("NUM_SCORES_UNKNOWN")]
		public const int NumScoresUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='NUM_TIME_SPANS']"
		[Register ("NUM_TIME_SPANS")]
		public const int NumTimeSpans = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='PLAYER_RANK_UNKNOWN']"
		[Register ("PLAYER_RANK_UNKNOWN")]
		public const int PlayerRankUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='PLAYER_SCORE_UNKNOWN']"
		[Register ("PLAYER_SCORE_UNKNOWN")]
		public const int PlayerScoreUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='TIME_SPAN_ALL_TIME']"
		[Register ("TIME_SPAN_ALL_TIME")]
		public const int TimeSpanAllTime = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='TIME_SPAN_DAILY']"
		[Register ("TIME_SPAN_DAILY")]
		public const int TimeSpanDaily = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/field[@name='TIME_SPAN_WEEKLY']"
		[Register ("TIME_SPAN_WEEKLY")]
		public const int TimeSpanWeekly = (int) 1;
	}

	[System.Obsolete ("Use the 'LeaderboardVariant' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class LeaderboardVariantConsts : LeaderboardVariant {

		private LeaderboardVariantConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']"
	[Register ("com/google/android/gms/games/leaderboard/LeaderboardVariant", "", "Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker")]
	public partial interface ILeaderboardVariant : IJavaObject {

		int Collection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='getCollection' and count(parameter)=0]"
			[Register ("getCollection", "()I", "GetGetCollectionHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

		string DisplayPlayerRank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='getDisplayPlayerRank' and count(parameter)=0]"
			[Register ("getDisplayPlayerRank", "()Ljava/lang/String;", "GetGetDisplayPlayerRankHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

		string DisplayPlayerScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='getDisplayPlayerScore' and count(parameter)=0]"
			[Register ("getDisplayPlayerScore", "()Ljava/lang/String;", "GetGetDisplayPlayerScoreHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

		bool HasPlayerInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='hasPlayerInfo' and count(parameter)=0]"
			[Register ("hasPlayerInfo", "()Z", "GetHasPlayerInfoHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

		long NumScores {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='getNumScores' and count(parameter)=0]"
			[Register ("getNumScores", "()J", "GetGetNumScoresHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

		long PlayerRank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='getPlayerRank' and count(parameter)=0]"
			[Register ("getPlayerRank", "()J", "GetGetPlayerRankHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

		long RawPlayerScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='getRawPlayerScore' and count(parameter)=0]"
			[Register ("getRawPlayerScore", "()J", "GetGetRawPlayerScoreHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

		int TimeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/interface[@name='LeaderboardVariant']/method[@name='getTimeSpan' and count(parameter)=0]"
			[Register ("getTimeSpan", "()I", "GetGetTimeSpanHandler:Android.Gms.Games.LeaderBoard.ILeaderboardVariantInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/LeaderboardVariant", DoNotGenerateAcw=true)]
	internal class ILeaderboardVariantInvoker : global::Java.Lang.Object, ILeaderboardVariant {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/leaderboard/LeaderboardVariant");
		IntPtr class_ref;

		public static ILeaderboardVariant GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILeaderboardVariant> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.leaderboard.LeaderboardVariant"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILeaderboardVariantInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILeaderboardVariantInvoker); }
		}

		static Delegate cb_getCollection;
#pragma warning disable 0169
		static Delegate GetGetCollectionHandler ()
		{
			if (cb_getCollection == null)
				cb_getCollection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCollection);
			return cb_getCollection;
		}

		static int n_GetCollection (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Collection;
		}
#pragma warning restore 0169

		IntPtr id_getCollection;
		public int Collection {
			get {
				if (id_getCollection == IntPtr.Zero)
					id_getCollection = JNIEnv.GetMethodID (class_ref, "getCollection", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCollection);
			}
		}

		static Delegate cb_getDisplayPlayerRank;
#pragma warning disable 0169
		static Delegate GetGetDisplayPlayerRankHandler ()
		{
			if (cb_getDisplayPlayerRank == null)
				cb_getDisplayPlayerRank = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayPlayerRank);
			return cb_getDisplayPlayerRank;
		}

		static IntPtr n_GetDisplayPlayerRank (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayPlayerRank);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayPlayerRank;
		public string DisplayPlayerRank {
			get {
				if (id_getDisplayPlayerRank == IntPtr.Zero)
					id_getDisplayPlayerRank = JNIEnv.GetMethodID (class_ref, "getDisplayPlayerRank", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayPlayerRank), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDisplayPlayerScore;
#pragma warning disable 0169
		static Delegate GetGetDisplayPlayerScoreHandler ()
		{
			if (cb_getDisplayPlayerScore == null)
				cb_getDisplayPlayerScore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayPlayerScore);
			return cb_getDisplayPlayerScore;
		}

		static IntPtr n_GetDisplayPlayerScore (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayPlayerScore);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayPlayerScore;
		public string DisplayPlayerScore {
			get {
				if (id_getDisplayPlayerScore == IntPtr.Zero)
					id_getDisplayPlayerScore = JNIEnv.GetMethodID (class_ref, "getDisplayPlayerScore", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayPlayerScore), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasPlayerInfo;
#pragma warning disable 0169
		static Delegate GetHasPlayerInfoHandler ()
		{
			if (cb_hasPlayerInfo == null)
				cb_hasPlayerInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPlayerInfo);
			return cb_hasPlayerInfo;
		}

		static bool n_HasPlayerInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPlayerInfo;
		}
#pragma warning restore 0169

		IntPtr id_hasPlayerInfo;
		public bool HasPlayerInfo {
			get {
				if (id_hasPlayerInfo == IntPtr.Zero)
					id_hasPlayerInfo = JNIEnv.GetMethodID (class_ref, "hasPlayerInfo", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPlayerInfo);
			}
		}

		static Delegate cb_getNumScores;
#pragma warning disable 0169
		static Delegate GetGetNumScoresHandler ()
		{
			if (cb_getNumScores == null)
				cb_getNumScores = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNumScores);
			return cb_getNumScores;
		}

		static long n_GetNumScores (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumScores;
		}
#pragma warning restore 0169

		IntPtr id_getNumScores;
		public long NumScores {
			get {
				if (id_getNumScores == IntPtr.Zero)
					id_getNumScores = JNIEnv.GetMethodID (class_ref, "getNumScores", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getNumScores);
			}
		}

		static Delegate cb_getPlayerRank;
#pragma warning disable 0169
		static Delegate GetGetPlayerRankHandler ()
		{
			if (cb_getPlayerRank == null)
				cb_getPlayerRank = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPlayerRank);
			return cb_getPlayerRank;
		}

		static long n_GetPlayerRank (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlayerRank;
		}
#pragma warning restore 0169

		IntPtr id_getPlayerRank;
		public long PlayerRank {
			get {
				if (id_getPlayerRank == IntPtr.Zero)
					id_getPlayerRank = JNIEnv.GetMethodID (class_ref, "getPlayerRank", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getPlayerRank);
			}
		}

		static Delegate cb_getRawPlayerScore;
#pragma warning disable 0169
		static Delegate GetGetRawPlayerScoreHandler ()
		{
			if (cb_getRawPlayerScore == null)
				cb_getRawPlayerScore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRawPlayerScore);
			return cb_getRawPlayerScore;
		}

		static long n_GetRawPlayerScore (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawPlayerScore;
		}
#pragma warning restore 0169

		IntPtr id_getRawPlayerScore;
		public long RawPlayerScore {
			get {
				if (id_getRawPlayerScore == IntPtr.Zero)
					id_getRawPlayerScore = JNIEnv.GetMethodID (class_ref, "getRawPlayerScore", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getRawPlayerScore);
			}
		}

		static Delegate cb_getTimeSpan;
#pragma warning disable 0169
		static Delegate GetGetTimeSpanHandler ()
		{
			if (cb_getTimeSpan == null)
				cb_getTimeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeSpan);
			return cb_getTimeSpan;
		}

		static int n_GetTimeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.ILeaderboardVariant> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeSpan;
		}
#pragma warning restore 0169

		IntPtr id_getTimeSpan;
		public int TimeSpan {
			get {
				if (id_getTimeSpan == IntPtr.Zero)
					id_getTimeSpan = JNIEnv.GetMethodID (class_ref, "getTimeSpan", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getTimeSpan);
			}
		}

	}

}
