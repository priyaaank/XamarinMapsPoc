using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[global::Android.Runtime.Register ("com/google/android/gms/games/GameEntity", DoNotGenerateAcw=true)]
	public sealed partial class GameEntity : global::Java.Lang.Object, global::Android.Gms.Games.IGame {


		static IntPtr CREATOR_jfieldId;

		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/GameEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameEntity); }
		}

		internal GameEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_games_Game_;
		[Register (".ctor", "(Lcom/google/android/gms/games/Game;)V", "")]
		public GameEntity (global::Android.Gms.Games.IGame p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GameEntity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/games/Game;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_games_Game_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_games_Game_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/games/Game;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_games_Game_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getAchievementTotalCount;
		public int AchievementTotalCount {
			[Register ("getAchievementTotalCount", "()I", "GetGetAchievementTotalCountHandler")]
			get {
				if (id_getAchievementTotalCount == IntPtr.Zero)
					id_getAchievementTotalCount = JNIEnv.GetMethodID (class_ref, "getAchievementTotalCount", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getAchievementTotalCount);
			}
		}

		static IntPtr id_getApplicationId;
		public string ApplicationId {
			[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler")]
			get {
				if (id_getApplicationId == IntPtr.Zero)
					id_getApplicationId = JNIEnv.GetMethodID (class_ref, "getApplicationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDescription;
		public string Description {
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDeveloperName;
		public string DeveloperName {
			[Register ("getDeveloperName", "()Ljava/lang/String;", "GetGetDeveloperNameHandler")]
			get {
				if (id_getDeveloperName == IntPtr.Zero)
					id_getDeveloperName = JNIEnv.GetMethodID (class_ref, "getDeveloperName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeveloperName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDisplayName;
		public string DisplayName {
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getFeaturedImageUri;
		public global::Android.Net.Uri FeaturedImageUri {
			[Register ("getFeaturedImageUri", "()Landroid/net/Uri;", "GetGetFeaturedImageUriHandler")]
			get {
				if (id_getFeaturedImageUri == IntPtr.Zero)
					id_getFeaturedImageUri = JNIEnv.GetMethodID (class_ref, "getFeaturedImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getFeaturedImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getGameplayAclStatus;
		public int GameplayAclStatus {
			[Register ("getGameplayAclStatus", "()I", "GetGetGameplayAclStatusHandler")]
			get {
				if (id_getGameplayAclStatus == IntPtr.Zero)
					id_getGameplayAclStatus = JNIEnv.GetMethodID (class_ref, "getGameplayAclStatus", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getGameplayAclStatus);
			}
		}

		static IntPtr id_getHiResImageUri;
		public global::Android.Net.Uri HiResImageUri {
			[Register ("getHiResImageUri", "()Landroid/net/Uri;", "GetGetHiResImageUriHandler")]
			get {
				if (id_getHiResImageUri == IntPtr.Zero)
					id_getHiResImageUri = JNIEnv.GetMethodID (class_ref, "getHiResImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getHiResImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getIconImageUri;
		public global::Android.Net.Uri IconImageUri {
			[Register ("getIconImageUri", "()Landroid/net/Uri;", "GetGetIconImageUriHandler")]
			get {
				if (id_getIconImageUri == IntPtr.Zero)
					id_getIconImageUri = JNIEnv.GetMethodID (class_ref, "getIconImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getIconImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInstancePackageName;
		public string InstancePackageName {
			[Register ("getInstancePackageName", "()Ljava/lang/String;", "GetGetInstancePackageNameHandler")]
			get {
				if (id_getInstancePackageName == IntPtr.Zero)
					id_getInstancePackageName = JNIEnv.GetMethodID (class_ref, "getInstancePackageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInstancePackageName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isInstanceInstalled;
		public bool IsInstanceInstalled {
			[Register ("isInstanceInstalled", "()Z", "GetIsInstanceInstalledHandler")]
			get {
				if (id_isInstanceInstalled == IntPtr.Zero)
					id_isInstanceInstalled = JNIEnv.GetMethodID (class_ref, "isInstanceInstalled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isInstanceInstalled);
			}
		}

		static IntPtr id_isPlayEnabledGame;
		public bool IsPlayEnabledGame {
			[Register ("isPlayEnabledGame", "()Z", "GetIsPlayEnabledGameHandler")]
			get {
				if (id_isPlayEnabledGame == IntPtr.Zero)
					id_isPlayEnabledGame = JNIEnv.GetMethodID (class_ref, "isPlayEnabledGame", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isPlayEnabledGame);
			}
		}

		static IntPtr id_getLeaderboardCount;
		public int LeaderboardCount {
			[Register ("getLeaderboardCount", "()I", "GetGetLeaderboardCountHandler")]
			get {
				if (id_getLeaderboardCount == IntPtr.Zero)
					id_getLeaderboardCount = JNIEnv.GetMethodID (class_ref, "getLeaderboardCount", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getLeaderboardCount);
			}
		}

		static IntPtr id_getPrimaryCategory;
		public string PrimaryCategory {
			[Register ("getPrimaryCategory", "()Ljava/lang/String;", "GetGetPrimaryCategoryHandler")]
			get {
				if (id_getPrimaryCategory == IntPtr.Zero)
					id_getPrimaryCategory = JNIEnv.GetMethodID (class_ref, "getPrimaryCategory", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrimaryCategory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSecondaryCategory;
		public string SecondaryCategory {
			[Register ("getSecondaryCategory", "()Ljava/lang/String;", "GetGetSecondaryCategoryHandler")]
			get {
				if (id_getSecondaryCategory == IntPtr.Zero)
					id_getSecondaryCategory = JNIEnv.GetMethodID (class_ref, "getSecondaryCategory", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSecondaryCategory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_a_Lcom_google_android_gms_games_Game_;
		[Register ("a", "(Lcom/google/android/gms/games/Game;)I", "")]
		public static int A (global::Android.Gms.Games.IGame p0)
		{
			if (id_a_Lcom_google_android_gms_games_Game_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_Game_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/Game;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Lcom_google_android_gms_games_Game_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_Lcom_google_android_gms_games_Game_Ljava_lang_Object_;
		[Register ("a", "(Lcom/google/android/gms/games/Game;Ljava/lang/Object;)Z", "")]
		public static bool A (global::Android.Gms.Games.IGame p0, global::Java.Lang.Object p1)
		{
			if (id_a_Lcom_google_android_gms_games_Game_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_Game_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/Game;Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Lcom_google_android_gms_games_Game_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b_Lcom_google_android_gms_games_Game_;
		[Register ("b", "(Lcom/google/android/gms/games/Game;)Ljava/lang/String;", "")]
		public static string B (global::Android.Gms.Games.IGame p0)
		{
			if (id_b_Lcom_google_android_gms_games_Game_ == IntPtr.Zero)
				id_b_Lcom_google_android_gms_games_Game_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lcom/google/android/gms/games/Game;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Lcom_google_android_gms_games_Game_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_freeze;
		[Register ("freeze", "()Lcom/google/android/gms/games/Game;", "")]
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Lcom/google/android/gms/games/Game;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getDescription_Landroid_database_CharArrayBuffer_;
		[Register ("getDescription", "(Landroid/database/CharArrayBuffer;)V", "")]
		public void GetDescription (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDescription_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDescription_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDescription", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_getDescription_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static IntPtr id_getDeveloperName_Landroid_database_CharArrayBuffer_;
		[Register ("getDeveloperName", "(Landroid/database/CharArrayBuffer;)V", "")]
		public void GetDeveloperName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDeveloperName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDeveloperName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDeveloperName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_getDeveloperName_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static IntPtr id_getDisplayName_Landroid_database_CharArrayBuffer_;
		[Register ("getDisplayName", "(Landroid/database/CharArrayBuffer;)V", "")]
		public void GetDisplayName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDisplayName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDisplayName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_getDisplayName_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
		}

	}
}
