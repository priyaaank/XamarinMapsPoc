using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[Register ("com/google/android/gms/games/Game", "", "Android.Gms.Games.IGameInvoker")]
	public partial interface IGame : global::Android.OS.IParcelable, global::Android.Gms.Common.Data.IFreezable {

		int AchievementTotalCount {
			[Register ("getAchievementTotalCount", "()I", "GetGetAchievementTotalCountHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		string ApplicationId {
			[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		string Description {
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		string DeveloperName {
			[Register ("getDeveloperName", "()Ljava/lang/String;", "GetGetDeveloperNameHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		string DisplayName {
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		global::Android.Net.Uri FeaturedImageUri {
			[Register ("getFeaturedImageUri", "()Landroid/net/Uri;", "GetGetFeaturedImageUriHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		int GameplayAclStatus {
			[Register ("getGameplayAclStatus", "()I", "GetGetGameplayAclStatusHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		global::Android.Net.Uri HiResImageUri {
			[Register ("getHiResImageUri", "()Landroid/net/Uri;", "GetGetHiResImageUriHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		global::Android.Net.Uri IconImageUri {
			[Register ("getIconImageUri", "()Landroid/net/Uri;", "GetGetIconImageUriHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		string InstancePackageName {
			[Register ("getInstancePackageName", "()Ljava/lang/String;", "GetGetInstancePackageNameHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		bool IsInstanceInstalled {
			[Register ("isInstanceInstalled", "()Z", "GetIsInstanceInstalledHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		bool IsPlayEnabledGame {
			[Register ("isPlayEnabledGame", "()Z", "GetIsPlayEnabledGameHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		int LeaderboardCount {
			[Register ("getLeaderboardCount", "()I", "GetGetLeaderboardCountHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		string PrimaryCategory {
			[Register ("getPrimaryCategory", "()Ljava/lang/String;", "GetGetPrimaryCategoryHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		string SecondaryCategory {
			[Register ("getSecondaryCategory", "()Ljava/lang/String;", "GetGetSecondaryCategoryHandler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")] get;
		}

		[Register ("getDescription", "(Landroid/database/CharArrayBuffer;)V", "GetGetDescription_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")]
		void GetDescription (global::Android.Database.CharArrayBuffer p0);

		[Register ("getDeveloperName", "(Landroid/database/CharArrayBuffer;)V", "GetGetDeveloperName_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")]
		void GetDeveloperName (global::Android.Database.CharArrayBuffer p0);

		[Register ("getDisplayName", "(Landroid/database/CharArrayBuffer;)V", "GetGetDisplayName_Landroid_database_CharArrayBuffer_Handler:Android.Gms.Games.IGameInvoker, GooglePlayServicesForReal")]
		void GetDisplayName (global::Android.Database.CharArrayBuffer p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/Game", DoNotGenerateAcw=true)]
	internal class IGameInvoker : global::Java.Lang.Object, IGame {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/Game");
		IntPtr class_ref;

		public static IGame GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGame> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.Game"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGameInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGameInvoker); }
		}

		static Delegate cb_getAchievementTotalCount;
#pragma warning disable 0169
		static Delegate GetGetAchievementTotalCountHandler ()
		{
			if (cb_getAchievementTotalCount == null)
				cb_getAchievementTotalCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAchievementTotalCount);
			return cb_getAchievementTotalCount;
		}

		static int n_GetAchievementTotalCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AchievementTotalCount;
		}
#pragma warning restore 0169

		IntPtr id_getAchievementTotalCount;
		public int AchievementTotalCount {
			get {
				if (id_getAchievementTotalCount == IntPtr.Zero)
					id_getAchievementTotalCount = JNIEnv.GetMethodID (class_ref, "getAchievementTotalCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getAchievementTotalCount);
			}
		}

		static Delegate cb_getApplicationId;
#pragma warning disable 0169
		static Delegate GetGetApplicationIdHandler ()
		{
			if (cb_getApplicationId == null)
				cb_getApplicationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationId);
			return cb_getApplicationId;
		}

		static IntPtr n_GetApplicationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationId);
		}
#pragma warning restore 0169

		IntPtr id_getApplicationId;
		public string ApplicationId {
			get {
				if (id_getApplicationId == IntPtr.Zero)
					id_getApplicationId = JNIEnv.GetMethodID (class_ref, "getApplicationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getApplicationId), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getDeveloperName;
#pragma warning disable 0169
		static Delegate GetGetDeveloperNameHandler ()
		{
			if (cb_getDeveloperName == null)
				cb_getDeveloperName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeveloperName);
			return cb_getDeveloperName;
		}

		static IntPtr n_GetDeveloperName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeveloperName);
		}
#pragma warning restore 0169

		IntPtr id_getDeveloperName;
		public string DeveloperName {
			get {
				if (id_getDeveloperName == IntPtr.Zero)
					id_getDeveloperName = JNIEnv.GetMethodID (class_ref, "getDeveloperName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDeveloperName), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getFeaturedImageUri;
#pragma warning disable 0169
		static Delegate GetGetFeaturedImageUriHandler ()
		{
			if (cb_getFeaturedImageUri == null)
				cb_getFeaturedImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFeaturedImageUri);
			return cb_getFeaturedImageUri;
		}

		static IntPtr n_GetFeaturedImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FeaturedImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getFeaturedImageUri;
		public global::Android.Net.Uri FeaturedImageUri {
			get {
				if (id_getFeaturedImageUri == IntPtr.Zero)
					id_getFeaturedImageUri = JNIEnv.GetMethodID (class_ref, "getFeaturedImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getFeaturedImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGameplayAclStatus;
#pragma warning disable 0169
		static Delegate GetGetGameplayAclStatusHandler ()
		{
			if (cb_getGameplayAclStatus == null)
				cb_getGameplayAclStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGameplayAclStatus);
			return cb_getGameplayAclStatus;
		}

		static int n_GetGameplayAclStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GameplayAclStatus;
		}
#pragma warning restore 0169

		IntPtr id_getGameplayAclStatus;
		public int GameplayAclStatus {
			get {
				if (id_getGameplayAclStatus == IntPtr.Zero)
					id_getGameplayAclStatus = JNIEnv.GetMethodID (class_ref, "getGameplayAclStatus", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getGameplayAclStatus);
			}
		}

		static Delegate cb_getHiResImageUri;
#pragma warning disable 0169
		static Delegate GetGetHiResImageUriHandler ()
		{
			if (cb_getHiResImageUri == null)
				cb_getHiResImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHiResImageUri);
			return cb_getHiResImageUri;
		}

		static IntPtr n_GetHiResImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HiResImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getHiResImageUri;
		public global::Android.Net.Uri HiResImageUri {
			get {
				if (id_getHiResImageUri == IntPtr.Zero)
					id_getHiResImageUri = JNIEnv.GetMethodID (class_ref, "getHiResImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getHiResImageUri), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getInstancePackageName;
#pragma warning disable 0169
		static Delegate GetGetInstancePackageNameHandler ()
		{
			if (cb_getInstancePackageName == null)
				cb_getInstancePackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstancePackageName);
			return cb_getInstancePackageName;
		}

		static IntPtr n_GetInstancePackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InstancePackageName);
		}
#pragma warning restore 0169

		IntPtr id_getInstancePackageName;
		public string InstancePackageName {
			get {
				if (id_getInstancePackageName == IntPtr.Zero)
					id_getInstancePackageName = JNIEnv.GetMethodID (class_ref, "getInstancePackageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getInstancePackageName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isInstanceInstalled;
#pragma warning disable 0169
		static Delegate GetIsInstanceInstalledHandler ()
		{
			if (cb_isInstanceInstalled == null)
				cb_isInstanceInstalled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInstanceInstalled);
			return cb_isInstanceInstalled;
		}

		static bool n_IsInstanceInstalled (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInstanceInstalled;
		}
#pragma warning restore 0169

		IntPtr id_isInstanceInstalled;
		public bool IsInstanceInstalled {
			get {
				if (id_isInstanceInstalled == IntPtr.Zero)
					id_isInstanceInstalled = JNIEnv.GetMethodID (class_ref, "isInstanceInstalled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isInstanceInstalled);
			}
		}

		static Delegate cb_isPlayEnabledGame;
#pragma warning disable 0169
		static Delegate GetIsPlayEnabledGameHandler ()
		{
			if (cb_isPlayEnabledGame == null)
				cb_isPlayEnabledGame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlayEnabledGame);
			return cb_isPlayEnabledGame;
		}

		static bool n_IsPlayEnabledGame (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlayEnabledGame;
		}
#pragma warning restore 0169

		IntPtr id_isPlayEnabledGame;
		public bool IsPlayEnabledGame {
			get {
				if (id_isPlayEnabledGame == IntPtr.Zero)
					id_isPlayEnabledGame = JNIEnv.GetMethodID (class_ref, "isPlayEnabledGame", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPlayEnabledGame);
			}
		}

		static Delegate cb_getLeaderboardCount;
#pragma warning disable 0169
		static Delegate GetGetLeaderboardCountHandler ()
		{
			if (cb_getLeaderboardCount == null)
				cb_getLeaderboardCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeaderboardCount);
			return cb_getLeaderboardCount;
		}

		static int n_GetLeaderboardCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeaderboardCount;
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboardCount;
		public int LeaderboardCount {
			get {
				if (id_getLeaderboardCount == IntPtr.Zero)
					id_getLeaderboardCount = JNIEnv.GetMethodID (class_ref, "getLeaderboardCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLeaderboardCount);
			}
		}

		static Delegate cb_getPrimaryCategory;
#pragma warning disable 0169
		static Delegate GetGetPrimaryCategoryHandler ()
		{
			if (cb_getPrimaryCategory == null)
				cb_getPrimaryCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrimaryCategory);
			return cb_getPrimaryCategory;
		}

		static IntPtr n_GetPrimaryCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrimaryCategory);
		}
#pragma warning restore 0169

		IntPtr id_getPrimaryCategory;
		public string PrimaryCategory {
			get {
				if (id_getPrimaryCategory == IntPtr.Zero)
					id_getPrimaryCategory = JNIEnv.GetMethodID (class_ref, "getPrimaryCategory", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPrimaryCategory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSecondaryCategory;
#pragma warning disable 0169
		static Delegate GetGetSecondaryCategoryHandler ()
		{
			if (cb_getSecondaryCategory == null)
				cb_getSecondaryCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecondaryCategory);
			return cb_getSecondaryCategory;
		}

		static IntPtr n_GetSecondaryCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecondaryCategory);
		}
#pragma warning restore 0169

		IntPtr id_getSecondaryCategory;
		public string SecondaryCategory {
			get {
				if (id_getSecondaryCategory == IntPtr.Zero)
					id_getSecondaryCategory = JNIEnv.GetMethodID (class_ref, "getSecondaryCategory", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getSecondaryCategory), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getDeveloperName_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetGetDeveloperName_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_getDeveloperName_Landroid_database_CharArrayBuffer_ == null)
				cb_getDeveloperName_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDeveloperName_Landroid_database_CharArrayBuffer_);
			return cb_getDeveloperName_Landroid_database_CharArrayBuffer_;
		}

		static void n_GetDeveloperName_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDeveloperName (p0);
		}
#pragma warning restore 0169

		IntPtr id_getDeveloperName_Landroid_database_CharArrayBuffer_;
		public void GetDeveloperName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDeveloperName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDeveloperName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDeveloperName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod (Handle, id_getDeveloperName_Landroid_database_CharArrayBuffer_, new JValue (p0));
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
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		IntPtr id_describeContents;
		public global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod (Handle, id_describeContents);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		public void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (dest), new JValue ((int) flags));
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
			global::Android.Gms.Games.IGame __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (native__this, JniHandleOwnership.DoNotTransfer);
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
