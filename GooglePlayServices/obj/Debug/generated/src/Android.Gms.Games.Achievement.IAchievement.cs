using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.Achievement {

	[Register ("com/google/android/gms/games/achievement/Achievement")]
	public abstract class Achievement {

		internal Achievement ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/field[@name='STATE_HIDDEN']"
		[Register ("STATE_HIDDEN")]
		public const int StateHidden = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/field[@name='STATE_REVEALED']"
		[Register ("STATE_REVEALED")]
		public const int StateRevealed = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/field[@name='STATE_UNLOCKED']"
		[Register ("STATE_UNLOCKED")]
		public const int StateUnlocked = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/field[@name='TYPE_INCREMENTAL']"
		[Register ("TYPE_INCREMENTAL")]
		public const int TypeIncremental = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/field[@name='TYPE_STANDARD']"
		[Register ("TYPE_STANDARD")]
		public const int TypeStandard = (int) 0;
	}

	[System.Obsolete ("Use the 'Achievement' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class AchievementConsts : Achievement {

		private AchievementConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']"
	[Register ("com/google/android/gms/games/achievement/Achievement", "", "Android.Gms.Games.Achievement.IAchievementInvoker")]
	public partial interface IAchievement : IJavaObject {

		string AchievementId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getAchievementId' and count(parameter)=0]"
			[Register ("getAchievementId", "()Ljava/lang/String;", "GetGetAchievementIdHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		int CurrentSteps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getCurrentSteps' and count(parameter)=0]"
			[Register ("getCurrentSteps", "()I", "GetGetCurrentStepsHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		string FormattedCurrentSteps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getFormattedCurrentSteps' and count(parameter)=0]"
			[Register ("getFormattedCurrentSteps", "()Ljava/lang/String;", "GetGetFormattedCurrentStepsHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		string FormattedTotalSteps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getFormattedTotalSteps' and count(parameter)=0]"
			[Register ("getFormattedTotalSteps", "()Ljava/lang/String;", "GetGetFormattedTotalStepsHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		long LastUpdatedTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getLastUpdatedTimestamp' and count(parameter)=0]"
			[Register ("getLastUpdatedTimestamp", "()J", "GetGetLastUpdatedTimestampHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Games.IPlayer Player {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getPlayer' and count(parameter)=0]"
			[Register ("getPlayer", "()Lcom/google/android/gms/games/Player;", "GetGetPlayerHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri RevealedImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getRevealedImageUri' and count(parameter)=0]"
			[Register ("getRevealedImageUri", "()Landroid/net/Uri;", "GetGetRevealedImageUriHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		int TotalSteps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getTotalSteps' and count(parameter)=0]"
			[Register ("getTotalSteps", "()I", "GetGetTotalStepsHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		global::Android.Net.Uri UnlockedImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getUnlockedImageUri' and count(parameter)=0]"
			[Register ("getUnlockedImageUri", "()Landroid/net/Uri;", "GetGetUnlockedImageUriHandler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getDescription' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getDescription", "(Landroid/database/CharArrayBuffer;)V", "GetGetDescription_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")]
		void GetDescription (global::Android.Database.CharArrayBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getFormattedCurrentSteps' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getFormattedCurrentSteps", "(Landroid/database/CharArrayBuffer;)V", "GetGetFormattedCurrentSteps_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")]
		void GetFormattedCurrentSteps (global::Android.Database.CharArrayBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getFormattedTotalSteps' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getFormattedTotalSteps", "(Landroid/database/CharArrayBuffer;)V", "GetGetFormattedTotalSteps_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")]
		void GetFormattedTotalSteps (global::Android.Database.CharArrayBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.achievement']/interface[@name='Achievement']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getName", "(Landroid/database/CharArrayBuffer;)V", "GetGetName_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.Achievement.IAchievementInvoker, GooglePlayServices")]
		void GetName (global::Android.Database.CharArrayBuffer p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/achievement/Achievement", DoNotGenerateAcw=true)]
	internal class IAchievementInvoker : global::Java.Lang.Object, IAchievement {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/achievement/Achievement");
		IntPtr class_ref;

		public static IAchievement GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAchievement> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.achievement.Achievement"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAchievementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAchievementInvoker); }
		}

		static Delegate cb_getAchievementId;
#pragma warning disable 0169
		static Delegate GetGetAchievementIdHandler ()
		{
			if (cb_getAchievementId == null)
				cb_getAchievementId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAchievementId);
			return cb_getAchievementId;
		}

		static IntPtr n_GetAchievementId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AchievementId);
		}
#pragma warning restore 0169

		IntPtr id_getAchievementId;
		public string AchievementId {
			get {
				if (id_getAchievementId == IntPtr.Zero)
					id_getAchievementId = JNIEnv.GetMethodID (class_ref, "getAchievementId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAchievementId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentSteps;
#pragma warning disable 0169
		static Delegate GetGetCurrentStepsHandler ()
		{
			if (cb_getCurrentSteps == null)
				cb_getCurrentSteps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentSteps);
			return cb_getCurrentSteps;
		}

		static int n_GetCurrentSteps (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSteps;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentSteps;
		public int CurrentSteps {
			get {
				if (id_getCurrentSteps == IntPtr.Zero)
					id_getCurrentSteps = JNIEnv.GetMethodID (class_ref, "getCurrentSteps", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCurrentSteps);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		public string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFormattedCurrentSteps;
#pragma warning disable 0169
		static Delegate GetGetFormattedCurrentStepsHandler ()
		{
			if (cb_getFormattedCurrentSteps == null)
				cb_getFormattedCurrentSteps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormattedCurrentSteps);
			return cb_getFormattedCurrentSteps;
		}

		static IntPtr n_GetFormattedCurrentSteps (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormattedCurrentSteps);
		}
#pragma warning restore 0169

		IntPtr id_getFormattedCurrentSteps;
		public string FormattedCurrentSteps {
			get {
				if (id_getFormattedCurrentSteps == IntPtr.Zero)
					id_getFormattedCurrentSteps = JNIEnv.GetMethodID (class_ref, "getFormattedCurrentSteps", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getFormattedCurrentSteps), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFormattedTotalSteps;
#pragma warning disable 0169
		static Delegate GetGetFormattedTotalStepsHandler ()
		{
			if (cb_getFormattedTotalSteps == null)
				cb_getFormattedTotalSteps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormattedTotalSteps);
			return cb_getFormattedTotalSteps;
		}

		static IntPtr n_GetFormattedTotalSteps (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormattedTotalSteps);
		}
#pragma warning restore 0169

		IntPtr id_getFormattedTotalSteps;
		public string FormattedTotalSteps {
			get {
				if (id_getFormattedTotalSteps == IntPtr.Zero)
					id_getFormattedTotalSteps = JNIEnv.GetMethodID (class_ref, "getFormattedTotalSteps", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getFormattedTotalSteps), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLastUpdatedTimestamp;
#pragma warning disable 0169
		static Delegate GetGetLastUpdatedTimestampHandler ()
		{
			if (cb_getLastUpdatedTimestamp == null)
				cb_getLastUpdatedTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastUpdatedTimestamp);
			return cb_getLastUpdatedTimestamp;
		}

		static long n_GetLastUpdatedTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastUpdatedTimestamp;
		}
#pragma warning restore 0169

		IntPtr id_getLastUpdatedTimestamp;
		public long LastUpdatedTimestamp {
			get {
				if (id_getLastUpdatedTimestamp == IntPtr.Zero)
					id_getLastUpdatedTimestamp = JNIEnv.GetMethodID (class_ref, "getLastUpdatedTimestamp", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getLastUpdatedTimestamp);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlayer;
#pragma warning disable 0169
		static Delegate GetGetPlayerHandler ()
		{
			if (cb_getPlayer == null)
				cb_getPlayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayer);
			return cb_getPlayer;
		}

		static IntPtr n_GetPlayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Player);
		}
#pragma warning restore 0169

		IntPtr id_getPlayer;
		public global::Android.Gms.Games.IPlayer Player {
			get {
				if (id_getPlayer == IntPtr.Zero)
					id_getPlayer = JNIEnv.GetMethodID (class_ref, "getPlayer", "()Lcom/google/android/gms/games/Player;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IPlayer> (JNIEnv.CallObjectMethod (Handle, id_getPlayer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRevealedImageUri;
#pragma warning disable 0169
		static Delegate GetGetRevealedImageUriHandler ()
		{
			if (cb_getRevealedImageUri == null)
				cb_getRevealedImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRevealedImageUri);
			return cb_getRevealedImageUri;
		}

		static IntPtr n_GetRevealedImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RevealedImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getRevealedImageUri;
		public global::Android.Net.Uri RevealedImageUri {
			get {
				if (id_getRevealedImageUri == IntPtr.Zero)
					id_getRevealedImageUri = JNIEnv.GetMethodID (class_ref, "getRevealedImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getRevealedImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetState);
			return cb_getState;
		}

		static int n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public int State {
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getState);
			}
		}

		static Delegate cb_getTotalSteps;
#pragma warning disable 0169
		static Delegate GetGetTotalStepsHandler ()
		{
			if (cb_getTotalSteps == null)
				cb_getTotalSteps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalSteps);
			return cb_getTotalSteps;
		}

		static int n_GetTotalSteps (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalSteps;
		}
#pragma warning restore 0169

		IntPtr id_getTotalSteps;
		public int TotalSteps {
			get {
				if (id_getTotalSteps == IntPtr.Zero)
					id_getTotalSteps = JNIEnv.GetMethodID (class_ref, "getTotalSteps", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getTotalSteps);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public int Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getType);
			}
		}

		static Delegate cb_getUnlockedImageUri;
#pragma warning disable 0169
		static Delegate GetGetUnlockedImageUriHandler ()
		{
			if (cb_getUnlockedImageUri == null)
				cb_getUnlockedImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnlockedImageUri);
			return cb_getUnlockedImageUri;
		}

		static IntPtr n_GetUnlockedImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnlockedImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getUnlockedImageUri;
		public global::Android.Net.Uri UnlockedImageUri {
			get {
				if (id_getUnlockedImageUri == IntPtr.Zero)
					id_getUnlockedImageUri = JNIEnv.GetMethodID (class_ref, "getUnlockedImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getUnlockedImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDescription_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetDescription_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getDescription_Landroid_database_CharArrayBuffer_ == null)
				cb_getDescription_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDescription_Landroid_database_CharArrayBuffer_);
			return cb_getDescription_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetDescription_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDescription (p0);
		}
#pragma warning restore 0169

		IntPtr id_getDescription_Landroid_database_CharArrayBuffer_;
		public void GetDescription (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDescription_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDescription_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDescription", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getDescription_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static Delegate cb_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetFormattedCurrentSteps_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_ == null)
				cb_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetFormattedCurrentSteps_Landroid_database_CharArrayBuffer_);
			return cb_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetFormattedCurrentSteps_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetFormattedCurrentSteps (p0);
		}
#pragma warning restore 0169

		IntPtr id_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_;
		public void GetFormattedCurrentSteps (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getFormattedCurrentSteps", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getFormattedCurrentSteps_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static Delegate cb_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetFormattedTotalSteps_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_ == null)
				cb_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetFormattedTotalSteps_Landroid_database_CharArrayBuffer_);
			return cb_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetFormattedTotalSteps_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetFormattedTotalSteps (p0);
		}
#pragma warning restore 0169

		IntPtr id_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_;
		public void GetFormattedTotalSteps (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getFormattedTotalSteps", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getFormattedTotalSteps_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static Delegate cb_getName_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetName_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getName_Landroid_database_CharArrayBuffer_ == null)
				cb_getName_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetName_Landroid_database_CharArrayBuffer_);
			return cb_getName_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetName_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.Achievement.IAchievement __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.Achievement.IAchievement> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetName (p0);
		}
#pragma warning restore 0169

		IntPtr id_getName_Landroid_database_CharArrayBuffer_;
		public void GetName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getName_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

	}

}
