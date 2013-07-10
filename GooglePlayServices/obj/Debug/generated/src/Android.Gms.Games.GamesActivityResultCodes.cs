using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[global::Android.Runtime.Register ("com/google/android/gms/games/GamesActivityResultCodes", DoNotGenerateAcw=true)]
	public sealed partial class GamesActivityResultCodes : global::Java.Lang.Object {


		[Register ("RESULT_APP_MISCONFIGURED")]
		public const int ResultAppMisconfigured = (int) 10004;

		[Register ("RESULT_LEFT_ROOM")]
		public const int ResultLeftRoom = (int) 10005;

		[Register ("RESULT_LICENSE_FAILED")]
		public const int ResultLicenseFailed = (int) 10003;

		[Register ("RESULT_RECONNECT_REQUIRED")]
		public const int ResultReconnectRequired = (int) 10001;

		[Register ("RESULT_SIGN_IN_FAILED")]
		public const int ResultSignInFailed = (int) 10002;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/GamesActivityResultCodes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GamesActivityResultCodes); }
		}

		internal GamesActivityResultCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
