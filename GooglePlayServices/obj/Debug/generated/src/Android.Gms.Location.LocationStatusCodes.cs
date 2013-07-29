using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationStatusCodes']"
	[global::Android.Runtime.Register ("com/google/android/gms/location/LocationStatusCodes", DoNotGenerateAcw=true)]
	public sealed partial class LocationStatusCodes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationStatusCodes']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationStatusCodes']/field[@name='GEOFENCE_NOT_AVAILABLE']"
		[Register ("GEOFENCE_NOT_AVAILABLE")]
		public const int GeofenceNotAvailable = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationStatusCodes']/field[@name='GEOFENCE_TOO_MANY_GEOFENCES']"
		[Register ("GEOFENCE_TOO_MANY_GEOFENCES")]
		public const int GeofenceTooManyGeofences = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationStatusCodes']/field[@name='GEOFENCE_TOO_MANY_PENDING_INTENTS']"
		[Register ("GEOFENCE_TOO_MANY_PENDING_INTENTS")]
		public const int GeofenceTooManyPendingIntents = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationStatusCodes']/field[@name='SUCCESS']"
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

		static IntPtr id_K_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationStatusCodes']/method[@name='K' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("K", "(I)I", "")]
		public static int K (int p0)
		{
			if (id_K_I == IntPtr.Zero)
				id_K_I = JNIEnv.GetStaticMethodID (class_ref, "K", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_K_I, new JValue (p0));
		}

	}
}
