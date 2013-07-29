using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.MultiPlayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']"
	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/InvitationEntity", DoNotGenerateAcw=true)]
	public sealed partial class InvitationEntity : global::Java.Lang.Object, global::Android.Gms.Games.MultiPlayer.IInvitation {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/InvitationEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InvitationEntity); }
		}

		internal InvitationEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_games_multiplayer_Invitation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/constructor[@name='InvitationEntity' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.Invitation']]"
		[Register (".ctor", "(Lcom/google/android/gms/games/multiplayer/Invitation;)V", "")]
		public InvitationEntity (global::Android.Gms.Games.MultiPlayer.IInvitation p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InvitationEntity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/games/multiplayer/Invitation;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_games_multiplayer_Invitation_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_games_multiplayer_Invitation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/games/multiplayer/Invitation;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_games_multiplayer_Invitation_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getCreationTimestamp;
		public long CreationTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='getCreationTimestamp' and count(parameter)=0]"
			[Register ("getCreationTimestamp", "()J", "GetGetCreationTimestampHandler")]
			get {
				if (id_getCreationTimestamp == IntPtr.Zero)
					id_getCreationTimestamp = JNIEnv.GetMethodID (class_ref, "getCreationTimestamp", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getCreationTimestamp);
			}
		}

		static IntPtr id_getGame;
		public global::Android.Gms.Games.IGame Game {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='getGame' and count(parameter)=0]"
			[Register ("getGame", "()Lcom/google/android/gms/games/Game;", "GetGetGameHandler")]
			get {
				if (id_getGame == IntPtr.Zero)
					id_getGame = JNIEnv.GetMethodID (class_ref, "getGame", "()Lcom/google/android/gms/games/Game;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (JNIEnv.CallObjectMethod  (Handle, id_getGame), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInvitationId;
		public string InvitationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='getInvitationId' and count(parameter)=0]"
			[Register ("getInvitationId", "()Ljava/lang/String;", "GetGetInvitationIdHandler")]
			get {
				if (id_getInvitationId == IntPtr.Zero)
					id_getInvitationId = JNIEnv.GetMethodID (class_ref, "getInvitationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInvitationId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInvitationType;
		public int InvitationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='getInvitationType' and count(parameter)=0]"
			[Register ("getInvitationType", "()I", "GetGetInvitationTypeHandler")]
			get {
				if (id_getInvitationType == IntPtr.Zero)
					id_getInvitationType = JNIEnv.GetMethodID (class_ref, "getInvitationType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getInvitationType);
			}
		}

		static IntPtr id_getInviter;
		public global::Android.Gms.Games.MultiPlayer.IParticipant Inviter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='getInviter' and count(parameter)=0]"
			[Register ("getInviter", "()Lcom/google/android/gms/games/multiplayer/Participant;", "GetGetInviterHandler")]
			get {
				if (id_getInviter == IntPtr.Zero)
					id_getInviter = JNIEnv.GetMethodID (class_ref, "getInviter", "()Lcom/google/android/gms/games/multiplayer/Participant;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (JNIEnv.CallObjectMethod  (Handle, id_getInviter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getParticipants;
		public global::System.Collections.Generic.IList<global::Android.Gms.Games.MultiPlayer.IParticipant> Participants {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='getParticipants' and count(parameter)=0]"
			[Register ("getParticipants", "()Ljava/util/ArrayList;", "GetGetParticipantsHandler")]
			get {
				if (id_getParticipants == IntPtr.Zero)
					id_getParticipants = JNIEnv.GetMethodID (class_ref, "getParticipants", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Games.MultiPlayer.IParticipant>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParticipants), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_a_Lcom_google_android_gms_games_multiplayer_Invitation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.Invitation']]"
		[Register ("a", "(Lcom/google/android/gms/games/multiplayer/Invitation;)I", "")]
		public static int A (global::Android.Gms.Games.MultiPlayer.IInvitation p0)
		{
			if (id_a_Lcom_google_android_gms_games_multiplayer_Invitation_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_multiplayer_Invitation_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/multiplayer/Invitation;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Lcom_google_android_gms_games_multiplayer_Invitation_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_Lcom_google_android_gms_games_multiplayer_Invitation_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.multiplayer.Invitation'] and parameter[2][@type='java.lang.Object']]"
		[Register ("a", "(Lcom/google/android/gms/games/multiplayer/Invitation;Ljava/lang/Object;)Z", "")]
		public static bool A (global::Android.Gms.Games.MultiPlayer.IInvitation p0, global::Java.Lang.Object p1)
		{
			if (id_a_Lcom_google_android_gms_games_multiplayer_Invitation_Ljava_lang_Object_ == IntPtr.Zero)
				id_a_Lcom_google_android_gms_games_multiplayer_Invitation_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/google/android/gms/games/multiplayer/Invitation;Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Lcom_google_android_gms_games_multiplayer_Invitation_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b_Lcom_google_android_gms_games_multiplayer_Invitation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.Invitation']]"
		[Register ("b", "(Lcom/google/android/gms/games/multiplayer/Invitation;)Ljava/lang/String;", "")]
		public static string B (global::Android.Gms.Games.MultiPlayer.IInvitation p0)
		{
			if (id_b_Lcom_google_android_gms_games_multiplayer_Invitation_ == IntPtr.Zero)
				id_b_Lcom_google_android_gms_games_multiplayer_Invitation_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lcom/google/android/gms/games/multiplayer/Invitation;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Lcom_google_android_gms_games_multiplayer_Invitation_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_freeze;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='freeze' and count(parameter)=0]"
		[Register ("freeze", "()Lcom/google/android/gms/games/multiplayer/Invitation;", "")]
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Lcom/google/android/gms/games/multiplayer/Invitation;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='InvitationEntity']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
		}

	}
}
