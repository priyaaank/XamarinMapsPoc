using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus {

	[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusOneButton", DoNotGenerateAcw=true)]
	public sealed partial class PlusOneButton : global::Android.Views.ViewGroup {


		[Register ("ANNOTATION_BUBBLE")]
		public const int AnnotationBubble = (int) 1;

		[Register ("ANNOTATION_INLINE")]
		public const int AnnotationInline = (int) 2;

		[Register ("ANNOTATION_NONE")]
		public const int AnnotationNone = (int) 0;

		[Register ("SIZE_MEDIUM")]
		public const int SizeMedium = (int) 1;

		[Register ("SIZE_SMALL")]
		public const int SizeSmall = (int) 0;

		[Register ("SIZE_STANDARD")]
		public const int SizeStandard = (int) 3;

		[Register ("SIZE_TALL")]
		public const int SizeTall = (int) 2;
		[Register ("com/google/android/gms/plus/PlusOneButton$OnPlusOneClickListener", "", "Android.Gms.Plus.PlusOneButton/IOnPlusOneClickListenerInvoker")]
		public partial interface IOnPlusOneClickListener : IJavaObject {

			[Register ("onPlusOneClick", "(Landroid/content/Intent;)V", "GetOnPlusOneClick_Landroid_content_Intent_Handler:Android.Gms.Plus.PlusOneButton/IOnPlusOneClickListenerInvoker, GooglePlayServices")]
			void OnPlusOneClick (global::Android.Content.Intent p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/plus/PlusOneButton$OnPlusOneClickListener", DoNotGenerateAcw=true)]
		internal class IOnPlusOneClickListenerInvoker : global::Java.Lang.Object, IOnPlusOneClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/PlusOneButton$OnPlusOneClickListener");
			IntPtr class_ref;

			public static IOnPlusOneClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPlusOneClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.PlusOneButton.OnPlusOneClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPlusOneClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPlusOneClickListenerInvoker); }
			}

			static Delegate cb_onPlusOneClick_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnPlusOneClick_Landroid_content_Intent_Handler ()
			{
				if (cb_onPlusOneClick_Landroid_content_Intent_ == null)
					cb_onPlusOneClick_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPlusOneClick_Landroid_content_Intent_);
				return cb_onPlusOneClick_Landroid_content_Intent_;
			}

			static void n_OnPlusOneClick_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPlusOneClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPlusOneClick_Landroid_content_Intent_;
			public void OnPlusOneClick (global::Android.Content.Intent p0)
			{
				if (id_onPlusOneClick_Landroid_content_Intent_ == IntPtr.Zero)
					id_onPlusOneClick_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onPlusOneClick", "(Landroid/content/Intent;)V");
				JNIEnv.CallVoidMethod (Handle, id_onPlusOneClick_Landroid_content_Intent_, new JValue (p0));
			}

		}

		public partial class PlusOneClickEventArgs : global::System.EventArgs {

			public PlusOneClickEventArgs (global::Android.Content.Intent p0)
			{
				this.p0 = p0;
			}

			global::Android.Content.Intent p0;
			public global::Android.Content.Intent P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/plus/PlusOneButton_OnPlusOneClickListenerImplementor")]
		internal sealed class IOnPlusOneClickListenerImplementor : global::Java.Lang.Object, IOnPlusOneClickListener {

			object sender;

			public IOnPlusOneClickListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/plus/PlusOneButton_OnPlusOneClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PlusOneClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnPlusOneClick (global::Android.Content.Intent p0)
			{
				if (Handler != null)
					Handler (sender, new PlusOneClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnPlusOneClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/PlusOneButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlusOneButton); }
		}

		internal PlusOneButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public PlusOneButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PlusOneButton)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public PlusOneButton (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PlusOneButton)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_;
		[Register ("initialize", "(Lcom/google/android/gms/plus/PlusClient;Ljava/lang/String;Lcom/google/android/gms/plus/PlusOneButton$OnPlusOneClickListener;)V", "")]
		public void Initialize (global::Android.Gms.Plus.PlusClient p0, string p1, global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListener p2)
		{
			if (id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_ == IntPtr.Zero)
				id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lcom/google/android/gms/plus/PlusClient;Ljava/lang/String;Lcom/google/android/gms/plus/PlusOneButton$OnPlusOneClickListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_I;
		[Register ("initialize", "(Lcom/google/android/gms/plus/PlusClient;Ljava/lang/String;I)V", "")]
		public void Initialize (global::Android.Gms.Plus.PlusClient p0, string p1, int p2)
		{
			if (id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_I == IntPtr.Zero)
				id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "initialize", "(Lcom/google/android/gms/plus/PlusClient;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_initialize_Lcom_google_android_gms_plus_PlusClient_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_onLayout_ZIIII;
		[Register ("onLayout", "(ZIIII)V", "")]
		protected override void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_setAnnotation_I;
		[Register ("setAnnotation", "(I)V", "")]
		public void SetAnnotation (int p0)
		{
			if (id_setAnnotation_I == IntPtr.Zero)
				id_setAnnotation_I = JNIEnv.GetMethodID (class_ref, "setAnnotation", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setAnnotation_I, new JValue (p0));
		}

		static IntPtr id_setOnPlusOneClickListener_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_;
		[Register ("setOnPlusOneClickListener", "(Lcom/google/android/gms/plus/PlusOneButton$OnPlusOneClickListener;)V", "")]
		public void SetOnPlusOneClickListener (global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListener p0)
		{
			if (id_setOnPlusOneClickListener_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_ == IntPtr.Zero)
				id_setOnPlusOneClickListener_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnPlusOneClickListener", "(Lcom/google/android/gms/plus/PlusOneButton$OnPlusOneClickListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOnPlusOneClickListener_Lcom_google_android_gms_plus_PlusOneButton_OnPlusOneClickListener_, new JValue (p0));
		}

		static IntPtr id_setSize_I;
		[Register ("setSize", "(I)V", "")]
		public void SetSize (int p0)
		{
			if (id_setSize_I == IntPtr.Zero)
				id_setSize_I = JNIEnv.GetMethodID (class_ref, "setSize", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setSize_I, new JValue (p0));
		}

#region "Event implementation for Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListener"
		public event EventHandler<global::Android.Gms.Plus.PlusOneButton.PlusOneClickEventArgs> PlusOneClick {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListener, global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListenerImplementor>(
						ref weak_implementor_SetOnPlusOneClickListener,
						__CreateIOnPlusOneClickListenerImplementor,
						SetOnPlusOneClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListener, global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListenerImplementor>(
						ref weak_implementor_SetOnPlusOneClickListener,
						global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListenerImplementor.__IsEmpty,
						SetOnPlusOneClickListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPlusOneClickListener;

		global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListenerImplementor __CreateIOnPlusOneClickListenerImplementor ()
		{
			return new global::Android.Gms.Plus.PlusOneButton.IOnPlusOneClickListenerImplementor (this);
		}
#endregion
	}
}
