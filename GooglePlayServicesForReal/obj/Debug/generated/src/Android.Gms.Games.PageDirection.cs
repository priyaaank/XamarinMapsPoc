using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[global::Android.Runtime.Register ("com/google/android/gms/games/PageDirection", DoNotGenerateAcw=true)]
	public sealed partial class PageDirection : global::Java.Lang.Object {


		[Register ("NEXT")]
		public const int Next = (int) 0;

		[Register ("NONE")]
		public const int None = (int) -1;

		[Register ("PREV")]
		public const int Prev = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/PageDirection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PageDirection); }
		}

		internal PageDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
