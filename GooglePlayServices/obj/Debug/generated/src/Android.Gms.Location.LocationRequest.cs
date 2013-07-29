using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']"
	[global::Android.Runtime.Register ("com/google/android/gms/location/LocationRequest", DoNotGenerateAcw=true)]
	public sealed partial class LocationRequest : global::Java.Lang.Object {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.Gms.Location.LocationRequestCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/location/LocationRequestCreator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequestCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/location/LocationRequestCreator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/field[@name='PRIORITY_BALANCED_POWER_ACCURACY']"
		[Register ("PRIORITY_BALANCED_POWER_ACCURACY")]
		public const int PriorityBalancedPowerAccuracy = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/field[@name='PRIORITY_HIGH_ACCURACY']"
		[Register ("PRIORITY_HIGH_ACCURACY")]
		public const int PriorityHighAccuracy = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/field[@name='PRIORITY_NO_POWER']"
		[Register ("PRIORITY_NO_POWER")]
		public const int PriorityNoPower = (int) 105;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/location/LocationRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationRequest); }
		}

		internal LocationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/constructor[@name='LocationRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LocationRequest () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationRequest)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getExpirationTime;
		public long ExpirationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='getExpirationTime' and count(parameter)=0]"
			[Register ("getExpirationTime", "()J", "GetGetExpirationTimeHandler")]
			get {
				if (id_getExpirationTime == IntPtr.Zero)
					id_getExpirationTime = JNIEnv.GetMethodID (class_ref, "getExpirationTime", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getExpirationTime);
			}
		}

		static IntPtr id_getFastestInterval;
		public long FastestInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='getFastestInterval' and count(parameter)=0]"
			[Register ("getFastestInterval", "()J", "GetGetFastestIntervalHandler")]
			get {
				if (id_getFastestInterval == IntPtr.Zero)
					id_getFastestInterval = JNIEnv.GetMethodID (class_ref, "getFastestInterval", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getFastestInterval);
			}
		}

		static IntPtr id_getInterval;
		public long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()J", "GetGetIntervalHandler")]
			get {
				if (id_getInterval == IntPtr.Zero)
					id_getInterval = JNIEnv.GetMethodID (class_ref, "getInterval", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getInterval);
			}
		}

		static IntPtr id_getNumUpdates;
		public int NumUpdates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='getNumUpdates' and count(parameter)=0]"
			[Register ("getNumUpdates", "()I", "GetGetNumUpdatesHandler")]
			get {
				if (id_getNumUpdates == IntPtr.Zero)
					id_getNumUpdates = JNIEnv.GetMethodID (class_ref, "getNumUpdates", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getNumUpdates);
			}
		}

		static IntPtr id_getPriority;
		public int Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()I", "GetGetPriorityHandler")]
			get {
				if (id_getPriority == IntPtr.Zero)
					id_getPriority = JNIEnv.GetMethodID (class_ref, "getPriority", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getPriority);
			}
		}

		static IntPtr id_getSmallestDisplacement;
		public float SmallestDisplacement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='getSmallestDisplacement' and count(parameter)=0]"
			[Register ("getSmallestDisplacement", "()F", "GetGetSmallestDisplacementHandler")]
			get {
				if (id_getSmallestDisplacement == IntPtr.Zero)
					id_getSmallestDisplacement = JNIEnv.GetMethodID (class_ref, "getSmallestDisplacement", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getSmallestDisplacement);
			}
		}

		static IntPtr id_J_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='J' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("J", "(I)Ljava/lang/String;", "")]
		public static string J (int p0)
		{
			if (id_J_I == IntPtr.Zero)
				id_J_I = JNIEnv.GetStaticMethodID (class_ref, "J", "(I)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_J_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/google/android/gms/location/LocationRequest;", "")]
		public static global::Android.Gms.Location.LocationRequest Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_setExpirationDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='setExpirationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setExpirationDuration", "(J)Lcom/google/android/gms/location/LocationRequest;", "")]
		public global::Android.Gms.Location.LocationRequest SetExpirationDuration (long p0)
		{
			if (id_setExpirationDuration_J == IntPtr.Zero)
				id_setExpirationDuration_J = JNIEnv.GetMethodID (class_ref, "setExpirationDuration", "(J)Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallObjectMethod  (Handle, id_setExpirationDuration_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setExpirationTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='setExpirationTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setExpirationTime", "(J)Lcom/google/android/gms/location/LocationRequest;", "")]
		public global::Android.Gms.Location.LocationRequest SetExpirationTime (long p0)
		{
			if (id_setExpirationTime_J == IntPtr.Zero)
				id_setExpirationTime_J = JNIEnv.GetMethodID (class_ref, "setExpirationTime", "(J)Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallObjectMethod  (Handle, id_setExpirationTime_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setFastestInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='setFastestInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setFastestInterval", "(J)Lcom/google/android/gms/location/LocationRequest;", "")]
		public global::Android.Gms.Location.LocationRequest SetFastestInterval (long p0)
		{
			if (id_setFastestInterval_J == IntPtr.Zero)
				id_setFastestInterval_J = JNIEnv.GetMethodID (class_ref, "setFastestInterval", "(J)Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallObjectMethod  (Handle, id_setFastestInterval_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='setInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInterval", "(J)Lcom/google/android/gms/location/LocationRequest;", "")]
		public global::Android.Gms.Location.LocationRequest SetInterval (long p0)
		{
			if (id_setInterval_J == IntPtr.Zero)
				id_setInterval_J = JNIEnv.GetMethodID (class_ref, "setInterval", "(J)Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallObjectMethod  (Handle, id_setInterval_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setNumUpdates_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='setNumUpdates' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNumUpdates", "(I)Lcom/google/android/gms/location/LocationRequest;", "")]
		public global::Android.Gms.Location.LocationRequest SetNumUpdates (int p0)
		{
			if (id_setNumUpdates_I == IntPtr.Zero)
				id_setNumUpdates_I = JNIEnv.GetMethodID (class_ref, "setNumUpdates", "(I)Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallObjectMethod  (Handle, id_setNumUpdates_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setPriority_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='setPriority' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPriority", "(I)Lcom/google/android/gms/location/LocationRequest;", "")]
		public global::Android.Gms.Location.LocationRequest SetPriority (int p0)
		{
			if (id_setPriority_I == IntPtr.Zero)
				id_setPriority_I = JNIEnv.GetMethodID (class_ref, "setPriority", "(I)Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallObjectMethod  (Handle, id_setPriority_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setSmallestDisplacement_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='setSmallestDisplacement' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSmallestDisplacement", "(F)Lcom/google/android/gms/location/LocationRequest;", "")]
		public global::Android.Gms.Location.LocationRequest SetSmallestDisplacement (float p0)
		{
			if (id_setSmallestDisplacement_F == IntPtr.Zero)
				id_setSmallestDisplacement_F = JNIEnv.GetMethodID (class_ref, "setSmallestDisplacement", "(F)Lcom/google/android/gms/location/LocationRequest;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.LocationRequest> (JNIEnv.CallObjectMethod  (Handle, id_setSmallestDisplacement_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='LocationRequest']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

	}
}
