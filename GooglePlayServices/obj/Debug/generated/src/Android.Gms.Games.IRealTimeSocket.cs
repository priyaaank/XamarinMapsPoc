using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games {

	[Register ("com/google/android/gms/games/RealTimeSocket", "", "Android.Gms.Games.IRealTimeSocketInvoker")]
	public partial interface IRealTimeSocket : IJavaObject {

		global::System.IO.Stream InputStream {
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler:Android.Gms.Games.IRealTimeSocketInvoker, GooglePlayServices")] get;
		}

		bool IsClosed {
			[Register ("isClosed", "()Z", "GetIsClosedHandler:Android.Gms.Games.IRealTimeSocketInvoker, GooglePlayServices")] get;
		}

		global::System.IO.Stream OutputStream {
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler:Android.Gms.Games.IRealTimeSocketInvoker, GooglePlayServices")] get;
		}

		global::Android.OS.ParcelFileDescriptor ParcelFileDescriptor {
			[Register ("getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", "GetGetParcelFileDescriptorHandler:Android.Gms.Games.IRealTimeSocketInvoker, GooglePlayServices")] get;
		}

		[Register ("close", "()V", "GetCloseHandler:Android.Gms.Games.IRealTimeSocketInvoker, GooglePlayServices")]
		void Close ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/RealTimeSocket", DoNotGenerateAcw=true)]
	internal class IRealTimeSocketInvoker : global::Java.Lang.Object, IRealTimeSocket {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/RealTimeSocket");
		IntPtr class_ref;

		public static IRealTimeSocket GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRealTimeSocket> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.RealTimeSocket"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRealTimeSocketInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRealTimeSocketInvoker); }
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IRealTimeSocket __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IRealTimeSocket> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		IntPtr id_getInputStream;
		public global::System.IO.Stream InputStream {
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IRealTimeSocket __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IRealTimeSocket> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		IntPtr id_isClosed;
		public bool IsClosed {
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isClosed);
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IRealTimeSocket __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IRealTimeSocket> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		IntPtr id_getOutputStream;
		public global::System.IO.Stream OutputStream {
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getParcelFileDescriptor;
#pragma warning disable 0169
		static Delegate GetGetParcelFileDescriptorHandler ()
		{
			if (cb_getParcelFileDescriptor == null)
				cb_getParcelFileDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParcelFileDescriptor);
			return cb_getParcelFileDescriptor;
		}

		static IntPtr n_GetParcelFileDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IRealTimeSocket __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IRealTimeSocket> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParcelFileDescriptor);
		}
#pragma warning restore 0169

		IntPtr id_getParcelFileDescriptor;
		public global::Android.OS.ParcelFileDescriptor ParcelFileDescriptor {
			get {
				if (id_getParcelFileDescriptor == IntPtr.Zero)
					id_getParcelFileDescriptor = JNIEnv.GetMethodID (class_ref, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (JNIEnv.CallObjectMethod (Handle, id_getParcelFileDescriptor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Games.IRealTimeSocket __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Games.IRealTimeSocket> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

	}

}
