using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Dynamic {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']"
	[Register ("com/google/android/gms/dynamic/LifecycleDelegate", "", "Android.Gms.Dynamic.ILifecycleDelegateInvoker")]
	public partial interface ILifecycleDelegate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnCreate (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onCreateView' and count(parameter)=3 and parameter[1][@type='android.view.LayoutInflater'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;", "GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		global::Android.Views.View OnCreateView (global::Android.Views.LayoutInflater p0, global::Android.Views.ViewGroup p1, global::Android.OS.Bundle p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnDestroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onDestroyView' and count(parameter)=0]"
		[Register ("onDestroyView", "()V", "GetOnDestroyViewHandler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnDestroyView ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onInflate' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onInflate", "(Landroid/app/Activity;Landroid/os/Bundle;Landroid/os/Bundle;)V", "GetOnInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_Handler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnInflate (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Android.OS.Bundle p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onLowMemory' and count(parameter)=0]"
		[Register ("onLowMemory", "()V", "GetOnLowMemoryHandler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnLowMemory ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnPause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnResume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.dynamic']/interface[@name='LifecycleDelegate']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler:Android.Gms.Dynamic.ILifecycleDelegateInvoker, GooglePlayServices")]
		void OnSaveInstanceState (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/dynamic/LifecycleDelegate", DoNotGenerateAcw=true)]
	internal class ILifecycleDelegateInvoker : global::Java.Lang.Object, ILifecycleDelegate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/dynamic/LifecycleDelegate");
		IntPtr class_ref;

		public static ILifecycleDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILifecycleDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.dynamic.LifecycleDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILifecycleDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILifecycleDelegateInvoker); }
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreate_Landroid_os_Bundle_;
		public void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ == null)
				cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_);
			return cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;
		}

		static IntPtr n_OnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.LayoutInflater p0 = global::Java.Lang.Object.GetObject<global::Android.Views.LayoutInflater> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;
		public global::Android.Views.View OnCreateView (global::Android.Views.LayoutInflater p0, global::Android.Views.ViewGroup p1, global::Android.OS.Bundle p2)
		{
			if (id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;");
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroy;
		public void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onDestroy);
		}

		static Delegate cb_onDestroyView;
#pragma warning disable 0169
		static Delegate GetOnDestroyViewHandler ()
		{
			if (cb_onDestroyView == null)
				cb_onDestroyView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroyView);
			return cb_onDestroyView;
		}

		static void n_OnDestroyView (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroyView ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroyView;
		public void OnDestroyView ()
		{
			if (id_onDestroyView == IntPtr.Zero)
				id_onDestroyView = JNIEnv.GetMethodID (class_ref, "onDestroyView", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onDestroyView);
		}

		static Delegate cb_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_ == null)
				cb_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_);
			return cb_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_;
		}

		static void n_OnInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnInflate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_;
		public void OnInflate (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Android.OS.Bundle p2)
		{
			if (id_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onInflate", "(Landroid/app/Activity;Landroid/os/Bundle;Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_onInflate_Landroid_app_Activity_Landroid_os_Bundle_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_onLowMemory;
#pragma warning disable 0169
		static Delegate GetOnLowMemoryHandler ()
		{
			if (cb_onLowMemory == null)
				cb_onLowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLowMemory);
			return cb_onLowMemory;
		}

		static void n_OnLowMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLowMemory ();
		}
#pragma warning restore 0169

		IntPtr id_onLowMemory;
		public void OnLowMemory ()
		{
			if (id_onLowMemory == IntPtr.Zero)
				id_onLowMemory = JNIEnv.GetMethodID (class_ref, "onLowMemory", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onLowMemory);
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		IntPtr id_onPause;
		public void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onPause);
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		IntPtr id_onResume;
		public void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onResume);
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Dynamic.ILifecycleDelegate __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Dynamic.ILifecycleDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		public void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_onSaveInstanceState_Landroid_os_Bundle_, new JValue (p0));
		}

	}

}
