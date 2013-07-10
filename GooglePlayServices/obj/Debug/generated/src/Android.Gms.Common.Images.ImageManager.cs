using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Images {

	[global::Android.Runtime.Register ("com/google/android/gms/common/images/ImageManager", DoNotGenerateAcw=true)]
	public sealed partial class ImageManager : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/google/android/gms/common/images/ImageManager$ImageReceiver", DoNotGenerateAcw=true)]
		public sealed partial class ImageReceiver : global::Android.OS.ResultReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/common/images/ImageManager$ImageReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageReceiver); }
			}

			internal ImageReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getUri;
			public global::Android.Net.Uri Uri {
				[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
				get {
					if (id_getUri == IntPtr.Zero)
						id_getUri = JNIEnv.GetMethodID (class_ref, "getUri", "()Landroid/net/Uri;");
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getUri), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_onReceiveResult_ILandroid_os_Bundle_;
			[Register ("onReceiveResult", "(ILandroid/os/Bundle;)V", "")]
			public void OnReceiveResult (int p0, global::Android.OS.Bundle p1)
			{
				if (id_onReceiveResult_ILandroid_os_Bundle_ == IntPtr.Zero)
					id_onReceiveResult_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onReceiveResult", "(ILandroid/os/Bundle;)V");
				JNIEnv.CallVoidMethod  (Handle, id_onReceiveResult_ILandroid_os_Bundle_, new JValue (p0), new JValue (p1));
			}

		}

		[global::Android.Runtime.Register ("com/google/android/gms/common/images/ImageManager$ListenerHolder", DoNotGenerateAcw=true)]
		public abstract partial class ListenerHolder : global::Java.Lang.Object, global::Android.Gms.Common.Images.ImageManager.IOnImageLoadedListener {


			static IntPtr mDefaultResId_jfieldId;

			[Register ("mDefaultResId")]
			protected int MDefaultResId {
				get {
					if (mDefaultResId_jfieldId == IntPtr.Zero)
						mDefaultResId_jfieldId = JNIEnv.GetFieldID (class_ref, "mDefaultResId", "I");
					return JNIEnv.GetIntField (Handle, mDefaultResId_jfieldId);
				}
				set {
					if (mDefaultResId_jfieldId == IntPtr.Zero)
						mDefaultResId_jfieldId = JNIEnv.GetFieldID (class_ref, "mDefaultResId", "I");
					JNIEnv.SetField (Handle, mDefaultResId_jfieldId, value);
				}
			}

			static IntPtr mHashCode_jfieldId;

			[Register ("mHashCode")]
			protected int MHashCode {
				get {
					if (mHashCode_jfieldId == IntPtr.Zero)
						mHashCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mHashCode", "I");
					return JNIEnv.GetIntField (Handle, mHashCode_jfieldId);
				}
				set {
					if (mHashCode_jfieldId == IntPtr.Zero)
						mHashCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mHashCode", "I");
					JNIEnv.SetField (Handle, mHashCode_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/common/images/ImageManager$ListenerHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ListenerHolder); }
			}

			protected ListenerHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetHandleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == null)
					cb_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_);
				return cb_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
			}

			static void n_HandleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Gms.Common.Images.ImageManager.ListenerHolder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Images.ImageManager.ListenerHolder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.HandleCachedDrawable (p0, p1);
			}
#pragma warning restore 0169

			[Register ("handleCachedDrawable", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V", "GetHandleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler")]
			public abstract void HandleCachedDrawable (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1);

			static Delegate cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetOnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == null)
					cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_);
				return cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
			}

			static void n_OnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Gms.Common.Images.ImageManager.ListenerHolder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Images.ImageManager.ListenerHolder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnImageLoaded (p0, p1);
			}
#pragma warning restore 0169

			[Register ("onImageLoaded", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V", "GetOnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler")]
			public abstract void OnImageLoaded (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1);

			static Delegate cb_shouldLoadImage_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetShouldLoadImage_Landroid_net_Uri_Handler ()
			{
				if (cb_shouldLoadImage_Landroid_net_Uri_ == null)
					cb_shouldLoadImage_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldLoadImage_Landroid_net_Uri_);
				return cb_shouldLoadImage_Landroid_net_Uri_;
			}

			static bool n_ShouldLoadImage_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Common.Images.ImageManager.ListenerHolder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Images.ImageManager.ListenerHolder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ShouldLoadImage (p0);
				return __ret;
			}
#pragma warning restore 0169

			[Register ("shouldLoadImage", "(Landroid/net/Uri;)Z", "GetShouldLoadImage_Landroid_net_Uri_Handler")]
			public abstract bool ShouldLoadImage (global::Android.Net.Uri p0);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/common/images/ImageManager$ListenerHolder", DoNotGenerateAcw=true)]
		internal partial class ListenerHolderInvoker : ListenerHolder {

			public ListenerHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ListenerHolderInvoker); }
			}

			static IntPtr id_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
			[Register ("handleCachedDrawable", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V", "GetHandleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler")]
			public override void HandleCachedDrawable (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1)
			{
				if (id_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "handleCachedDrawable", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V");
				JNIEnv.CallVoidMethod  (Handle, id_handleCachedDrawable_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
			[Register ("onImageLoaded", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V", "GetOnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler")]
			public override void OnImageLoaded (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1)
			{
				if (id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onImageLoaded", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V");
				JNIEnv.CallVoidMethod  (Handle, id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_shouldLoadImage_Landroid_net_Uri_;
			[Register ("shouldLoadImage", "(Landroid/net/Uri;)Z", "GetShouldLoadImage_Landroid_net_Uri_Handler")]
			public override bool ShouldLoadImage (global::Android.Net.Uri p0)
			{
				if (id_shouldLoadImage_Landroid_net_Uri_ == IntPtr.Zero)
					id_shouldLoadImage_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "shouldLoadImage", "(Landroid/net/Uri;)Z");
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_shouldLoadImage_Landroid_net_Uri_, new JValue (p0));
				return __ret;
			}

		}


		[Register ("com/google/android/gms/common/images/ImageManager$OnImageLoadedListener", "", "Android.Gms.Common.Images.ImageManager/IOnImageLoadedListenerInvoker")]
		public partial interface IOnImageLoadedListener : IJavaObject {

			[Register ("onImageLoaded", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V", "GetOnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler:Android.Gms.Common.Images.ImageManager/IOnImageLoadedListenerInvoker, GooglePlayServices")]
			void OnImageLoaded (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1);

		}

		[global::Android.Runtime.Register ("com/google/android/gms/common/images/ImageManager$OnImageLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnImageLoadedListenerInvoker : global::Java.Lang.Object, IOnImageLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/images/ImageManager$OnImageLoadedListener");
			IntPtr class_ref;

			public static IOnImageLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnImageLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.images.ImageManager.OnImageLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnImageLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnImageLoadedListenerInvoker); }
			}

			static Delegate cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetOnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == null)
					cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_);
				return cb_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
			}

			static void n_OnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Gms.Common.Images.ImageManager.IOnImageLoadedListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Images.ImageManager.IOnImageLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnImageLoaded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
			public void OnImageLoaded (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1)
			{
				if (id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onImageLoaded", "(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V");
				JNIEnv.CallVoidMethod (Handle, id_onImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class ImageLoadedEventArgs : global::System.EventArgs {

			public ImageLoadedEventArgs (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Net.Uri p0;
			public global::Android.Net.Uri P0 {
				get { return p0; }
			}

			global::Android.Graphics.Drawables.Drawable p1;
			public global::Android.Graphics.Drawables.Drawable P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/common/images/ImageManager_OnImageLoadedListenerImplementor")]
		internal sealed class IOnImageLoadedListenerImplementor : global::Java.Lang.Object, IOnImageLoadedListener {

			object sender;

			public IOnImageLoadedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/common/images/ImageManager_OnImageLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ImageLoadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnImageLoaded (global::Android.Net.Uri p0, global::Android.Graphics.Drawables.Drawable p1)
			{
				if (Handler != null)
					Handler (sender, new ImageLoadedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnImageLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/images/ImageManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageManager); }
		}

		internal ImageManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create_Landroid_content_Context_;
		[Register ("create", "(Landroid/content/Context;)Lcom/google/android/gms/common/images/ImageManager;", "")]
		public static global::Android.Gms.Common.Images.ImageManager Create (global::Android.Content.Context p0)
		{
			if (id_create_Landroid_content_Context_ == IntPtr.Zero)
				id_create_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Landroid/content/Context;)Lcom/google/android/gms/common/images/ImageManager;");
			global::Android.Gms.Common.Images.ImageManager __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Images.ImageManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_;
		[Register ("loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;)V", "")]
		public void LoadImage (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1)
		{
			if (id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_ == IntPtr.Zero)
				id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I;
		[Register ("loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;I)V", "")]
		public void LoadImage (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1, int p2)
		{
			if (id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I == IntPtr.Zero)
				id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_loadImage_Landroid_widget_ImageView_I;
		[Register ("loadImage", "(Landroid/widget/ImageView;I)V", "")]
		public void LoadImage (global::Android.Widget.ImageView p0, int p1)
		{
			if (id_loadImage_Landroid_widget_ImageView_I == IntPtr.Zero)
				id_loadImage_Landroid_widget_ImageView_I = JNIEnv.GetMethodID (class_ref, "loadImage", "(Landroid/widget/ImageView;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Landroid_widget_ImageView_I, new JValue (p0), new JValue (p1));
		}

	}
}
