using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	[global::Android.Runtime.Register ("com/google/android/gms/location/Geofence$Builder", DoNotGenerateAcw=true)]
	public sealed partial class GeofenceBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/location/Geofence$Builder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeofenceBuilder); }
		}

		internal GeofenceBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public GeofenceBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeofenceBuilder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_build;
		[Register ("build", "()Lcom/google/android/gms/location/Geofence;", "")]
		public global::Android.Gms.Location.IGeofence Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/android/gms/location/Geofence;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.IGeofence> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setCircularRegion_DDF;
		[Register ("setCircularRegion", "(DDF)Lcom/google/android/gms/location/Geofence$Builder;", "")]
		public global::Android.Gms.Location.GeofenceBuilder SetCircularRegion (double p0, double p1, float p2)
		{
			if (id_setCircularRegion_DDF == IntPtr.Zero)
				id_setCircularRegion_DDF = JNIEnv.GetMethodID (class_ref, "setCircularRegion", "(DDF)Lcom/google/android/gms/location/Geofence$Builder;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.GeofenceBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setCircularRegion_DDF, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setExpirationDuration_J;
		[Register ("setExpirationDuration", "(J)Lcom/google/android/gms/location/Geofence$Builder;", "")]
		public global::Android.Gms.Location.GeofenceBuilder SetExpirationDuration (long p0)
		{
			if (id_setExpirationDuration_J == IntPtr.Zero)
				id_setExpirationDuration_J = JNIEnv.GetMethodID (class_ref, "setExpirationDuration", "(J)Lcom/google/android/gms/location/Geofence$Builder;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.GeofenceBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setExpirationDuration_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setRequestId_Ljava_lang_String_;
		[Register ("setRequestId", "(Ljava/lang/String;)Lcom/google/android/gms/location/Geofence$Builder;", "")]
		public global::Android.Gms.Location.GeofenceBuilder SetRequestId (string p0)
		{
			if (id_setRequestId_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestId", "(Ljava/lang/String;)Lcom/google/android/gms/location/Geofence$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Gms.Location.GeofenceBuilder __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.GeofenceBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setRequestId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_setTransitionTypes_I;
		[Register ("setTransitionTypes", "(I)Lcom/google/android/gms/location/Geofence$Builder;", "")]
		public global::Android.Gms.Location.GeofenceBuilder SetTransitionTypes (int p0)
		{
			if (id_setTransitionTypes_I == IntPtr.Zero)
				id_setTransitionTypes_I = JNIEnv.GetMethodID (class_ref, "setTransitionTypes", "(I)Lcom/google/android/gms/location/Geofence$Builder;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.GeofenceBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setTransitionTypes_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}

	[Register ("com/google/android/gms/location/Geofence")]
	public abstract class Geofence {

		internal Geofence ()
		{
		}

		[Register ("GEOFENCE_TRANSITION_ENTER")]
		public const int GeofenceTransitionEnter = (int) 1;

		[Register ("GEOFENCE_TRANSITION_EXIT")]
		public const int GeofenceTransitionExit = (int) 2;

		[Register ("NEVER_EXPIRE")]
		public const long NeverExpire = (long) -1L;
	}

	[System.Obsolete ("Use the 'Geofence' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class GeofenceConsts : Geofence {

		private GeofenceConsts ()
		{
		}
	}

	[Register ("com/google/android/gms/location/Geofence", "", "Android.Gms.Location.IGeofenceInvoker")]
	public partial interface IGeofence : IJavaObject {

		string RequestId {
			[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler:Android.Gms.Location.IGeofenceInvoker, GooglePlayServicesForReal")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/location/Geofence", DoNotGenerateAcw=true)]
	internal class IGeofenceInvoker : global::Java.Lang.Object, IGeofence {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/location/Geofence");
		IntPtr class_ref;

		public static IGeofence GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGeofence> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.location.Geofence"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGeofenceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGeofenceInvoker); }
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestId);
			return cb_getRequestId;
		}

		static IntPtr n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.IGeofence __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.IGeofence> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

		IntPtr id_getRequestId;
		public string RequestId {
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
