using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	[global::Android.Runtime.Register ("com/google/android/gms/common/SignInButton", DoNotGenerateAcw=true)]
	public sealed partial class SignInButton : global::Android.Widget.FrameLayout, global::Android.Views.View.IOnClickListener {


		[Register ("COLOR_DARK")]
		public const int ColorDark = (int) 0;

		[Register ("COLOR_LIGHT")]
		public const int ColorLight = (int) 1;

		[Register ("SIZE_ICON_ONLY")]
		public const int SizeIconOnly = (int) 2;

		[Register ("SIZE_STANDARD")]
		public const int SizeStandard = (int) 0;

		[Register ("SIZE_WIDE")]
		public const int SizeWide = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/SignInButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignInButton); }
		}

		internal SignInButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public SignInButton (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SignInButton)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public SignInButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SignInButton)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public SignInButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SignInButton)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_onClick_Landroid_view_View_;
		[Register ("onClick", "(Landroid/view/View;)V", "")]
		public void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_view_View_, new JValue (p0));
		}

		static IntPtr id_setColorScheme_I;
		[Register ("setColorScheme", "(I)V", "")]
		public void SetColorScheme (int p0)
		{
			if (id_setColorScheme_I == IntPtr.Zero)
				id_setColorScheme_I = JNIEnv.GetMethodID (class_ref, "setColorScheme", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setColorScheme_I, new JValue (p0));
		}

		static IntPtr id_setSize_I;
		[Register ("setSize", "(I)V", "")]
		public void SetSize (int p0)
		{
			if (id_setSize_I == IntPtr.Zero)
				id_setSize_I = JNIEnv.GetMethodID (class_ref, "setSize", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setSize_I, new JValue (p0));
		}

		static IntPtr id_setStyle_II;
		[Register ("setStyle", "(II)V", "")]
		public void SetStyle (int p0, int p1)
		{
			if (id_setStyle_II == IntPtr.Zero)
				id_setStyle_II = JNIEnv.GetMethodID (class_ref, "setStyle", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setStyle_II, new JValue (p0), new JValue (p1));
		}

	}
}
