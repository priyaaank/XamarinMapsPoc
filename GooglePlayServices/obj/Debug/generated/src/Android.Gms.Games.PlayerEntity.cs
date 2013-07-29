using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']"
	[global::Android.Runtime.Register ("com/google/android/gms/games/PlayerEntity", DoNotGenerateAcw=true)]
	public sealed partial class PlayerEntity : global::Java.Lang.Object, global::Android.Gms.Games.IPlayer {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/google/android/gms/games/PlayerEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerEntity); }
		}

		internal PlayerEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_games_Player_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/constructor[@name='PlayerEntity' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.Player']]"
		[Register (".ctor", "(Lcom/google/android/gms/games/Player;)V", "")]
		public PlayerEntity (global::Android.Gms.Games.IPlayer p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PlayerEntity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/games/Player;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_games_Player_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_games_Player_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/games/Player;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_games_Player_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getDisplayName;
		public string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_hasHiResImage;
		public bool HasHiResImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='hasHiResImage' and count(parameter)=0]"
			[Register ("hasHiResImage", "()Z", "GetHasHiResImageHandler")]
			get {
				if (id_hasHiResImage == IntPtr.Zero)
					id_hasHiResImage = JNIEnv.GetMethodID (class_ref, "hasHiResImage", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_hasHiResImage);
			}
		}

		static IntPtr id_hasIconImage;
		public bool HasIconImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='hasIconImage' and count(parameter)=0]"
			[Register ("hasIconImage", "()Z", "GetHasIconImageHandler")]
			get {
				if (id_hasIconImage == IntPtr.Zero)
					id_hasIconImage = JNIEnv.GetMethodID (class_ref, "hasIconImage", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_hasIconImage);
			}
		}

		static IntPtr id_getHiResImageUri;
		public global::Android.Net.Uri HiResImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='getHiResImageUri' and count(parameter)=0]"
			[Register ("getHiResImageUri", "()Landroid/net/Uri;", "GetGetHiResImageUriHandler")]
			get {
				if (id_getHiResImageUri == IntPtr.Zero)
					id_getHiResImageUri = JNIEnv.GetMethodID (class_ref, "getHiResImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getHiResImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getIconImageUri;
		public global::Android.Net.Uri IconImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='getIconImageUri' and count(parameter)=0]"
			[Register ("getIconImageUri", "()Landroid/net/Uri;", "GetGetIconImageUriHandler")]
			get {
				if (id_getIconImageUri == IntPtr.Zero)
					id_getIconImageUri = JNIEnv.GetMethodID (class_ref, "getIconImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getIconImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPlayerId;
		public string PlayerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='getPlayerId' and count(parameter)=0]"
			[Register ("getPlayerId", "()Ljava/lang/String;", "GetGetPlayerIdHandler")]
			get {
				if (id_getPlayerId == IntPtr.Zero)
					id_getPlayerId = JNIEnv.GetMethodID (class_ref, "getPlayerId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPlayerId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRetrievedTimestamp;
		public long RetrievedTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='getRetrievedTimestamp' and count(parameter)=0]"
			[Register ("getRetrievedTimestamp", "()J", "GetGetRetrievedTimestampHandler")]
			get {
				if (id_getRetrievedTimestamp == IntPtr.Zero)
					id_getRetrievedTimestamp = JNIEnv.GetMethodID (class_ref, "getRetrievedTimestamp", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getRetrievedTimestamp);
			}
		}

		static IntPtr id_a_Lcom_google_android_gms_games_Player_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.Player']]"
		[Register ("a", "(Lcom/google/android/gms/games/Player;)I", "")]
		public static int A (global::Android.Gms.Games.IPlayer p0)
		{
			if (id_a_Lcom_google_android_gms_games_Player_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_Player_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/Player;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Lcom_google_android_gms_games_Player_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_Lcom_google_android_gms_games_Player_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.Player'] and parameter[2][@type='java.lang.Object']]"
		[Register ("a", "(Lcom/google/android/gms/games/Player;Ljava/lang/Object;)Z", "")]
		public static bool A (global::Android.Gms.Games.IPlayer p0, global::Java.Lang.Object p1)
		{
			if (id_a_Lcom_google_android_gms_games_Player_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_Player_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/Player;Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Lcom_google_android_gms_games_Player_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b_Lcom_google_android_gms_games_Player_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.Player']]"
		[Register ("b", "(Lcom/google/android/gms/games/Player;)Ljava/lang/String;", "")]
		public static string B (global::Android.Gms.Games.IPlayer p0)
		{
			if (id_b_Lcom_google_android_gms_games_Player_ == IntPtr.Zero)
				id_b_Lcom_google_android_gms_games_Player_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lcom/google/android/gms/games/Player;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Lcom_google_android_gms_games_Player_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_freeze;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='freeze' and count(parameter)=0]"
		[Register ("freeze", "()Lcom/google/android/gms/games/Player;", "")]
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Lcom/google/android/gms/games/Player;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getDisplayName_Landroid_database_CharArrayBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='getDisplayName' and count(parameter)=1 and parameter[1][@type='android.database.CharArrayBuffer']]"
		[Register ("getDisplayName", "(Landroid/database/CharArrayBuffer;)V", "")]
		public void GetDisplayName (global::Android.Database.CharArrayBuffer p0)
		{
			if (id_getDisplayName_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_getDisplayName_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Landroid/database/CharArrayBuffer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_getDisplayName_Landroid_database_CharArrayBuffer_, new JValue (p0));
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games']/class[@name='PlayerEntity']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
		}

	}
}
