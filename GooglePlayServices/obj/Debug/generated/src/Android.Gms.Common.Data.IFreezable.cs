using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Data {

	[Register ("com/google/android/gms/common/data/Freezable", "", "Android.Gms.Common.Data.IFreezableInvoker")]
	public partial interface IFreezable : IJavaObject {

		[Register ("freeze", "()Ljava/lang/Object;", "GetFreezeHandler:Android.Gms.Common.Data.IFreezableInvoker, GooglePlayServices")]
		global::Java.Lang.Object Freeze ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/Freezable", DoNotGenerateAcw=true)]
	internal class IFreezableInvoker : global::Java.Lang.Object, IFreezable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/data/Freezable");
		IntPtr class_ref;

		public static IFreezable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFreezable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.data.Freezable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFreezableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFreezableInvoker); }
		}

		static Delegate cb_freeze;
#pragma warning disable 0169
		static Delegate GetFreezeHandler ()
		{
			if (cb_freeze == null)
				cb_freeze = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Freeze);
			return cb_freeze;
		}

		static IntPtr n_Freeze (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.Data.IFreezable __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Data.IFreezable> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Freeze ());
		}
#pragma warning restore 0169

		IntPtr id_freeze;
		public global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

	}

}
