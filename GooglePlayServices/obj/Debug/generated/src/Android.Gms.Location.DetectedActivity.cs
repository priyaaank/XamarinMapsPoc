using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	[global::Android.Runtime.Register ("com/google/android/gms/location/DetectedActivity", DoNotGenerateAcw=true)]
	public partial class DetectedActivity : global::Java.Lang.Object {


		static IntPtr CREATOR_jfieldId;

		[Register ("CREATOR")]
		public static global::Android.Gms.Location.DetectedActivityCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/location/DetectedActivityCreator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivityCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/location/DetectedActivityCreator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		[Register ("IN_VEHICLE")]
		public const int InVehicle = (int) 0;

		[Register ("ON_BICYCLE")]
		public const int OnBicycle = (int) 1;

		[Register ("ON_FOOT")]
		public const int OnFoot = (int) 2;

		[Register ("STILL")]
		public const int Still = (int) 3;

		[Register ("TILTING")]
		public const int Tilting = (int) 5;

		[Register ("UNKNOWN")]
		public const int Unknown = (int) 4;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/location/DetectedActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectedActivity); }
		}

		protected DetectedActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		[Register (".ctor", "(II)V", "")]
		public DetectedActivity (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DetectedActivity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(II)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public DetectedActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DetectedActivity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getConfidence;
#pragma warning disable 0169
		static Delegate GetGetConfidenceHandler ()
		{
			if (cb_getConfidence == null)
				cb_getConfidence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConfidence);
			return cb_getConfidence;
		}

		static int n_GetConfidence (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.DetectedActivity __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Confidence;
		}
#pragma warning restore 0169

		static IntPtr id_getConfidence;
		public virtual int Confidence {
			[Register ("getConfidence", "()I", "GetGetConfidenceHandler")]
			get {
				if (id_getConfidence == IntPtr.Zero)
					id_getConfidence = JNIEnv.GetMethodID (class_ref, "getConfidence", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getConfidence);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getConfidence);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.DetectedActivity __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual int Type {
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getType);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getType);
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
			global::Android.Gms.Location.DetectedActivity __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_describeContents);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Gms.Location.DetectedActivity __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

	}
}
