using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	[Register ("com/google/android/gms/location/LocationListener", "", "Android.Gms.Location.ILocationListenerInvoker")]
	public partial interface ILocationListener : IJavaObject {

		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler:Android.Gms.Location.ILocationListenerInvoker, GooglePlayServicesForReal")]
		void OnLocationChanged (global::Android.Locations.Location p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/location/LocationListener", DoNotGenerateAcw=true)]
	internal class ILocationListenerInvoker : global::Java.Lang.Object, ILocationListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/location/LocationListener");
		IntPtr class_ref;

		public static ILocationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.location.LocationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILocationListenerInvoker); }
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Location.ILocationListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ILocationListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationChanged_Landroid_location_Location_;
		public void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			JNIEnv.CallVoidMethod (Handle, id_onLocationChanged_Landroid_location_Location_, new JValue (p0));
		}

	}

	public partial class LocationEventArgs : global::System.EventArgs {

		public LocationEventArgs (global::Android.Locations.Location p0)
		{
			this.p0 = p0;
		}

		global::Android.Locations.Location p0;
		public global::Android.Locations.Location P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/location/LocationListenerImplementor")]
	internal sealed class ILocationListenerImplementor : global::Java.Lang.Object, ILocationListener {

		object sender;

		public ILocationListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/location/LocationListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LocationEventArgs> Handler;
#pragma warning restore 0649

		public void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (Handler != null)
				Handler (sender, new LocationEventArgs (p0));
		}

		internal static bool __IsEmpty (ILocationListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
