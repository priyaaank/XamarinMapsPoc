using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[global::Android.Runtime.Register ("com/google/android/gms/games/GamesClientSettings", DoNotGenerateAcw=true)]
	public sealed partial class GamesClientSettings : global::Java.Lang.Object {


		[Register ("POPUP_POSITION_BOTTOM")]
		public const int PopupPositionBottom = (int) 2;

		[Register ("POPUP_POSITION_TOP")]
		public const int PopupPositionTop = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/GamesClientSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GamesClientSettings); }
		}

		internal GamesClientSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
