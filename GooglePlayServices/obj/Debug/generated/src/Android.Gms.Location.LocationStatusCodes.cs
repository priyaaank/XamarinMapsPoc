using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	[global::Android.Runtime.Register ("com/google/android/gms/location/LocationStatusCodes", DoNotGenerateAcw=true)]
	public sealed partial class LocationStatusCodes : global::Java.Lang.Object {


		[Register ("ERROR")]
		public const int Error = (int) 1;

		[Register ("GEOFENCE_NOT_AVAILABLE")]
		public const int GeofenceNotAvailable = (int) 1000;

		[Register ("GEOFENCE_TOO_MANY_GEOFENCES")]
		public const int GeofenceTooManyGeofences = (int) 1001;

		[Register ("GEOFENCE_TOO_MANY_PENDING_INTENTS")]
		public const int GeofenceTooManyPendingIntents = (int) 1002;

		[Register ("SUCCESS")]
		public const int Success = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/location/LocationStatusCodes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationStatusCodes); }
		}

		internal LocationStatusCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_J_I;
		[Register ("J", "(I)I", "")]
		public static int J (int p0)
		{
			if (id_J_I == IntPtr.Zero)
				id_J_I = JNIEnv.GetStaticMethodID (class_ref, "J", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_J_I, new JValue (p0));
		}

	}
}
