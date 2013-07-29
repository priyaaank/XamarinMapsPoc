using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.AppStates {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.appstate']/interface[@name='OnStateLoadedListener']"
	[Register ("com/google/android/gms/appstate/OnStateLoadedListener", "", "Android.Gms.AppStates.IOnStateLoadedListenerInvoker")]
	public partial interface IOnStateLoadedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.appstate']/interface[@name='OnStateLoadedListener']/method[@name='onStateConflict' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("onStateConflict", "(ILjava/lang/String;[B[B)V", "GetOnStateConflict_ILjava_lang_String_arrayBarrayBHandler:Android.Gms.AppStates.IOnStateLoadedListenerInvoker, GooglePlayServices")]
		void OnStateConflict (int p0, string p1, byte[] p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.appstate']/interface[@name='OnStateLoadedListener']/method[@name='onStateLoaded' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("onStateLoaded", "(II[B)V", "GetOnStateLoaded_IIarrayBHandler:Android.Gms.AppStates.IOnStateLoadedListenerInvoker, GooglePlayServices")]
		void OnStateLoaded (int p0, int p1, byte[] p2);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/appstate/OnStateLoadedListener", DoNotGenerateAcw=true)]
	internal class IOnStateLoadedListenerInvoker : global::Java.Lang.Object, IOnStateLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/appstate/OnStateLoadedListener");
		IntPtr class_ref;

		public static IOnStateLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnStateLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.appstate.OnStateLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnStateLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnStateLoadedListenerInvoker); }
		}

		static Delegate cb_onStateConflict_ILjava_lang_String_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetOnStateConflict_ILjava_lang_String_arrayBarrayBHandler ()
		{
			if (cb_onStateConflict_ILjava_lang_String_arrayBarrayB == null)
				cb_onStateConflict_ILjava_lang_String_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_OnStateConflict_ILjava_lang_String_arrayBarrayB);
			return cb_onStateConflict_ILjava_lang_String_arrayBarrayB;
		}

		static void n_OnStateConflict_ILjava_lang_String_arrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Gms.AppStates.IOnStateLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IOnStateLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnStateConflict (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onStateConflict_ILjava_lang_String_arrayBarrayB;
		public void OnStateConflict (int p0, string p1, byte[] p2, byte[] p3)
		{
			if (id_onStateConflict_ILjava_lang_String_arrayBarrayB == IntPtr.Zero)
				id_onStateConflict_ILjava_lang_String_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "onStateConflict", "(ILjava/lang/String;[B[B)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_onStateConflict_ILjava_lang_String_arrayBarrayB, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onStateLoaded_IIarrayB;
#pragma warning disable 0169
		static Delegate GetOnStateLoaded_IIarrayBHandler ()
		{
			if (cb_onStateLoaded_IIarrayB == null)
				cb_onStateLoaded_IIarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnStateLoaded_IIarrayB);
			return cb_onStateLoaded_IIarrayB;
		}

		static void n_OnStateLoaded_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Android.Gms.AppStates.IOnStateLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.AppStates.IOnStateLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnStateLoaded (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onStateLoaded_IIarrayB;
		public void OnStateLoaded (int p0, int p1, byte[] p2)
		{
			if (id_onStateLoaded_IIarrayB == IntPtr.Zero)
				id_onStateLoaded_IIarrayB = JNIEnv.GetMethodID (class_ref, "onStateLoaded", "(II[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod (Handle, id_onStateLoaded_IIarrayB, new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	public partial class StateConflictEventArgs : global::System.EventArgs {

		public StateConflictEventArgs (int p0, string p1, byte[] p2, byte[] p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}

		byte[] p3;
		public byte[] P3 {
			get { return p3; }
		}
	}

	public partial class StateLoadedEventArgs : global::System.EventArgs {

		public StateLoadedEventArgs (int p0, int p1, byte[] p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/appstate/OnStateLoadedListenerImplementor")]
	internal sealed class IOnStateLoadedListenerImplementor : global::Java.Lang.Object, IOnStateLoadedListener {

		object sender;

		public IOnStateLoadedListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/appstate/OnStateLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<StateConflictEventArgs> OnStateConflictHandler;
#pragma warning restore 0649

		public void OnStateConflict (int p0, string p1, byte[] p2, byte[] p3)
		{
			var __h = OnStateConflictHandler;
			if (__h != null)
				__h (sender, new StateConflictEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<StateLoadedEventArgs> OnStateLoadedHandler;
#pragma warning restore 0649

		public void OnStateLoaded (int p0, int p1, byte[] p2)
		{
			var __h = OnStateLoadedHandler;
			if (__h != null)
				__h (sender, new StateLoadedEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IOnStateLoadedListenerImplementor value)
		{
			return value.OnStateConflictHandler == null && value.OnStateLoadedHandler == null;
		}
	}

}
