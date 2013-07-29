using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='DetectedActivityCreator']"
	[global::Android.Runtime.Register ("com/google/android/gms/location/DetectedActivityCreator", DoNotGenerateAcw=true)]
	public partial class DetectedActivityCreator : global::Java.Lang.Object, global::Android.OS.IParcelableCreator {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='DetectedActivityCreator']/field[@name='CONTENT_DESCRIPTION']"
		[Register ("CONTENT_DESCRIPTION")]
		public const int ContentDescription = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/location/DetectedActivityCreator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectedActivityCreator); }
		}

		protected DetectedActivityCreator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='DetectedActivityCreator']/constructor[@name='DetectedActivityCreator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DetectedActivityCreator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DetectedActivityCreator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_createFromParcel_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetCreateFromParcel_Landroid_os_Parcel_Handler ()
		{
			if (cb_createFromParcel_Landroid_os_Parcel_ == null)
				cb_createFromParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateFromParcel_Landroid_os_Parcel_);
			return cb_createFromParcel_Landroid_os_Parcel_;
		}

		static IntPtr n_CreateFromParcel_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Location.DetectedActivityCreator __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivityCreator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFromParcel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='DetectedActivityCreator']/method[@name='createFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("createFromParcel", "(Landroid/os/Parcel;)Lcom/google/android/gms/location/DetectedActivity;", "GetCreateFromParcel_Landroid_os_Parcel_Handler")]
		public virtual global::Java.Lang.Object CreateFromParcel (global::Android.OS.Parcel p0)
		{
			if (id_createFromParcel_Landroid_os_Parcel_ == IntPtr.Zero)
				id_createFromParcel_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "createFromParcel", "(Landroid/os/Parcel;)Lcom/google/android/gms/location/DetectedActivity;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_createFromParcel_Landroid_os_Parcel_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createFromParcel_Landroid_os_Parcel_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_newArray_I;
#pragma warning disable 0169
		static Delegate GetNewArray_IHandler ()
		{
			if (cb_newArray_I == null)
				cb_newArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NewArray_I);
			return cb_newArray_I;
		}

		static IntPtr n_NewArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Gms.Location.DetectedActivityCreator __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivityCreator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.NewArray (p0));
		}
#pragma warning restore 0169

		static IntPtr id_newArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='DetectedActivityCreator']/method[@name='newArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newArray", "(I)[Lcom/google/android/gms/location/DetectedActivity;", "GetNewArray_IHandler")]
		public virtual global::Java.Lang.Object[] NewArray (int p0)
		{
			if (id_newArray_I == IntPtr.Zero)
				id_newArray_I = JNIEnv.GetMethodID (class_ref, "newArray", "(I)[Lcom/google/android/gms/location/DetectedActivity;");

			if (GetType () == ThresholdType)
				return (global::Android.Gms.Location.DetectedActivity[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_newArray_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Gms.Location.DetectedActivity));
			else
				return (global::Android.Gms.Location.DetectedActivity[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newArray_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Gms.Location.DetectedActivity));
		}

	}
}
