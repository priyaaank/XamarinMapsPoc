using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Images {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.images']/class[@name='ImageManager']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/images/ImageManager", DoNotGenerateAcw=true)]
	public sealed partial class ImageManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common.images']/interface[@name='ImageManager.OnImageLoadedListener']"
		[Register ("com/google/android/gms/common/images/ImageManager$OnImageLoadedListener", "", "Android.Gms.Common.Images.ImageManager/IOnImageLoadedListenerInvoker")]
		public partial interface IOnImageLoadedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.images']/interface[@name='ImageManager.OnImageLoadedListener']/method[@name='onImageLoaded' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
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
				var __h = Handler;
				if (__h != null)
					__h (sender, new ImageLoadedEventArgs (p0, p1));
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.images']/class[@name='ImageManager']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("create", "(Landroid/content/Context;)Lcom/google/android/gms/common/images/ImageManager;", "")]
		public static global::Android.Gms.Common.Images.ImageManager Create (global::Android.Content.Context p0)
		{
			if (id_create_Landroid_content_Context_ == IntPtr.Zero)
				id_create_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Landroid/content/Context;)Lcom/google/android/gms/common/images/ImageManager;");
			global::Android.Gms.Common.Images.ImageManager __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Images.ImageManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.images']/class[@name='ImageManager']/method[@name='loadImage' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='android.net.Uri']]"
		[Register ("loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;)V", "")]
		public void LoadImage (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1)
		{
			if (id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_ == IntPtr.Zero)
				id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.images']/class[@name='ImageManager']/method[@name='loadImage' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;I)V", "")]
		public void LoadImage (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1, int p2)
		{
			if (id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I == IntPtr.Zero)
				id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "loadImage", "(Landroid/widget/ImageView;Landroid/net/Uri;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Landroid_widget_ImageView_Landroid_net_Uri_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_loadImage_Landroid_widget_ImageView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.images']/class[@name='ImageManager']/method[@name='loadImage' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Register ("loadImage", "(Landroid/widget/ImageView;I)V", "")]
		public void LoadImage (global::Android.Widget.ImageView p0, int p1)
		{
			if (id_loadImage_Landroid_widget_ImageView_I == IntPtr.Zero)
				id_loadImage_Landroid_widget_ImageView_I = JNIEnv.GetMethodID (class_ref, "loadImage", "(Landroid/widget/ImageView;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Landroid_widget_ImageView_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.images']/class[@name='ImageManager']/method[@name='loadImage' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.common.images.ImageManager.OnImageLoadedListener'] and parameter[2][@type='android.net.Uri']]"
		[Register ("loadImage", "(Lcom/google/android/gms/common/images/ImageManager$OnImageLoadedListener;Landroid/net/Uri;)V", "")]
		public void LoadImage (global::Android.Gms.Common.Images.ImageManager.IOnImageLoadedListener p0, global::Android.Net.Uri p1)
		{
			if (id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_ == IntPtr.Zero)
				id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Lcom/google/android/gms/common/images/ImageManager$OnImageLoadedListener;Landroid/net/Uri;)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.images']/class[@name='ImageManager']/method[@name='loadImage' and count(parameter)=3 and parameter[1][@type='com.google.android.gms.common.images.ImageManager.OnImageLoadedListener'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("loadImage", "(Lcom/google/android/gms/common/images/ImageManager$OnImageLoadedListener;Landroid/net/Uri;I)V", "")]
		public void LoadImage (global::Android.Gms.Common.Images.ImageManager.IOnImageLoadedListener p0, global::Android.Net.Uri p1, int p2)
		{
			if (id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_I == IntPtr.Zero)
				id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "loadImage", "(Lcom/google/android/gms/common/images/ImageManager$OnImageLoadedListener;Landroid/net/Uri;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_loadImage_Lcom_google_android_gms_common_images_ImageManager_OnImageLoadedListener_Landroid_net_Uri_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
