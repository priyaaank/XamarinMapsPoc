using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.MultiPlayer {

	[Register ("com/google/android/gms/games/multiplayer/Invitation", "", "Android.Gms.Games.MultiPlayer.IInvitationInvoker")]
	public partial interface IInvitation : global::Android.OS.IParcelable, global::Android.Gms.Common.Data.IFreezable, global::Android.Gms.Games.MultiPlayer.IParticipatable {

		long CreationTimestamp {
			[Register ("getCreationTimestamp", "()J", "GetGetCreationTimestampHandler:Android.Gms.Games.MultiPlayer.IInvitationInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Games.IGame Game {
			[Register ("getGame", "()Lcom/google/android/gms/games/Game;", "GetGetGameHandler:Android.Gms.Games.MultiPlayer.IInvitationInvoker, GooglePlayServices")] get;
		}

		string InvitationId {
			[Register ("getInvitationId", "()Ljava/lang/String;", "GetGetInvitationIdHandler:Android.Gms.Games.MultiPlayer.IInvitationInvoker, GooglePlayServices")] get;
		}

		int InvitationType {
			[Register ("getInvitationType", "()I", "GetGetInvitationTypeHandler:Android.Gms.Games.MultiPlayer.IInvitationInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Games.MultiPlayer.IParticipant Inviter {
			[Register ("getInviter", "()Lcom/google/android/gms/games/multiplayer/Participant;", "GetGetInviterHandler:Android.Gms.Games.MultiPlayer.IInvitationInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/Invitation", DoNotGenerateAcw=true)]
	internal class IInvitationInvoker : global::Java.Lang.Object, IInvitation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/Invitation");
		IntPtr class_ref;

		public static IInvitation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInvitation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.Invitation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInvitationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInvitationInvoker); }
		}

		static Delegate cb_getCreationTimestamp;
#pragma warning disable 0169
		static Delegate GetGetCreationTimestampHandler ()
		{
			if (cb_getCreationTimestamp == null)
				cb_getCreationTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCreationTimestamp);
			return cb_getCreationTimestamp;
		}

		static long n_GetCreationTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreationTimestamp;
		}
#pragma warning restore 0169

		IntPtr id_getCreationTimestamp;
		public long CreationTimestamp {
			get {
				if (id_getCreationTimestamp == IntPtr.Zero)
					id_getCreationTimestamp = JNIEnv.GetMethodID (class_ref, "getCreationTimestamp", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getCreationTimestamp);
			}
		}

		static Delegate cb_getGame;
#pragma warning disable 0169
		static Delegate GetGetGameHandler ()
		{
			if (cb_getGame == null)
				cb_getGame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGame);
			return cb_getGame;
		}

		static IntPtr n_GetGame (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Game);
		}
#pragma warning restore 0169

		IntPtr id_getGame;
		public global::Android.Gms.Games.IGame Game {
			get {
				if (id_getGame == IntPtr.Zero)
					id_getGame = JNIEnv.GetMethodID (class_ref, "getGame", "()Lcom/google/android/gms/games/Game;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IGame> (JNIEnv.CallObjectMethod (Handle, id_getGame), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInvitationId;
#pragma warning disable 0169
		static Delegate GetGetInvitationIdHandler ()
		{
			if (cb_getInvitationId == null)
				cb_getInvitationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInvitationId);
			return cb_getInvitationId;
		}

		static IntPtr n_GetInvitationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InvitationId);
		}
#pragma warning restore 0169

		IntPtr id_getInvitationId;
		public string InvitationId {
			get {
				if (id_getInvitationId == IntPtr.Zero)
					id_getInvitationId = JNIEnv.GetMethodID (class_ref, "getInvitationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getInvitationId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInvitationType;
#pragma warning disable 0169
		static Delegate GetGetInvitationTypeHandler ()
		{
			if (cb_getInvitationType == null)
				cb_getInvitationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInvitationType);
			return cb_getInvitationType;
		}

		static int n_GetInvitationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvitationType;
		}
#pragma warning restore 0169

		IntPtr id_getInvitationType;
		public int InvitationType {
			get {
				if (id_getInvitationType == IntPtr.Zero)
					id_getInvitationType = JNIEnv.GetMethodID (class_ref, "getInvitationType", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getInvitationType);
			}
		}

		static Delegate cb_getInviter;
#pragma warning disable 0169
		static Delegate GetGetInviterHandler ()
		{
			if (cb_getInviter == null)
				cb_getInviter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInviter);
			return cb_getInviter;
		}

		static IntPtr n_GetInviter (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inviter);
		}
#pragma warning restore 0169

		IntPtr id_getInviter;
		public global::Android.Gms.Games.MultiPlayer.IParticipant Inviter {
			get {
				if (id_getInviter == IntPtr.Zero)
					id_getInviter = JNIEnv.GetMethodID (class_ref, "getInviter", "()Lcom/google/android/gms/games/multiplayer/Participant;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipant> (JNIEnv.CallObjectMethod (Handle, id_getInviter), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getParticipants;
#pragma warning disable 0169
		static Delegate GetGetParticipantsHandler ()
		{
			if (cb_getParticipants == null)
				cb_getParticipants = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParticipants);
			return cb_getParticipants;
		}

		static IntPtr n_GetParticipants (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.MultiPlayer.IInvitation __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IInvitation> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Games.MultiPlayer.IParticipant>.ToLocalJniHandle (__this.Participants);
		}
#pragma warning restore 0169

		IntPtr id_getParticipants;
		public global::System.Collections.Generic.IList<global::Android.Gms.Games.MultiPlayer.IParticipant> Participants {
			get {
				if (id_getParticipants == IntPtr.Zero)
					id_getParticipants = JNIEnv.GetMethodID (class_ref, "getParticipants", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Games.MultiPlayer.IParticipant>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getParticipants), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
