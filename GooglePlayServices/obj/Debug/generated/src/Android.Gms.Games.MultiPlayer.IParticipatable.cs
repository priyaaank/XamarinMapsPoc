using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.MultiPlayer {

	[Register ("com/google/android/gms/games/multiplayer/Participatable", "", "Android.Gms.Games.MultiPlayer.IParticipatableInvoker")]
	public partial interface IParticipatable : IJavaObject {

		global::System.Collections.Generic.IList<global::Android.Gms.Games.MultiPlayer.IParticipant> Participants {
			[Register ("getParticipants", "()Ljava/util/ArrayList;", "GetGetParticipantsHandler:Android.Gms.Games.MultiPlayer.IParticipatableInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/Participatable", DoNotGenerateAcw=true)]
	internal class IParticipatableInvoker : global::Java.Lang.Object, IParticipatable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/Participatable");
		IntPtr class_ref;

		public static IParticipatable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParticipatable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.Participatable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParticipatableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IParticipatableInvoker); }
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
			global::Android.Gms.Games.MultiPlayer.IParticipatable __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.MultiPlayer.IParticipatable> (native__this, JniHandleOwnership.DoNotTransfer);
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
