using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RealTimeMessage", DoNotGenerateAcw=true)]
	public sealed partial class RealTimeMessage : global::Java.Lang.Object, global::Android.OS.IParcelable {


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

		[Register ("RELIABLE")]
		public const int Reliable = (int) 1;

		[Register ("UNRELIABLE")]
		public const int Unreliable = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RealTimeMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RealTimeMessage); }
		}

		internal RealTimeMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayBI;
		[Register (".ctor", "(Ljava/lang/String;[BI)V", "")]
		public RealTimeMessage (string p0, byte[] p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (RealTimeMessage)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;[BI)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Ljava_lang_String_arrayBI == IntPtr.Zero)
				id_ctor_Ljava_lang_String_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[BI)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_arrayBI, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isReliable;
		public bool IsReliable {
			[Register ("isReliable", "()Z", "GetIsReliableHandler")]
			get {
				if (id_isReliable == IntPtr.Zero)
					id_isReliable = JNIEnv.GetMethodID (class_ref, "isReliable", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isReliable);
			}
		}

		static IntPtr id_getSenderParticipantId;
		public string SenderParticipantId {
			[Register ("getSenderParticipantId", "()Ljava/lang/String;", "GetGetSenderParticipantIdHandler")]
			get {
				if (id_getSenderParticipantId == IntPtr.Zero)
					id_getSenderParticipantId = JNIEnv.GetMethodID (class_ref, "getSenderParticipantId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSenderParticipantId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_getMessageData;
		[Register ("getMessageData", "()[B", "")]
		public byte[] GetMessageData ()
		{
			if (id_getMessageData == IntPtr.Zero)
				id_getMessageData = JNIEnv.GetMethodID (class_ref, "getMessageData", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMessageData), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
