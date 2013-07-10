using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[global::Android.Runtime.Register ("com/google/android/gms/games/PlayerBuffer", DoNotGenerateAcw=true)]
	public sealed partial class PlayerBuffer : global::Android.Gms.Common.Data.DataBuffer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/PlayerBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerBuffer); }
		}

		internal PlayerBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get_I;
		[Register ("get", "(I)Lcom/google/android/gms/games/Player;", "")]
		public override global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lcom/google/android/gms/games/Player;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
