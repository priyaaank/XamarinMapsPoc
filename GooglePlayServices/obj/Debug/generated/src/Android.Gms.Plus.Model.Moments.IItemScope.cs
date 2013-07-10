using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus.Model.Moments {

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/moments/ItemScope$Builder", DoNotGenerateAcw=true)]
	public partial class ItemScopeBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/moments/ItemScope$Builder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemScopeBuilder); }
		}

		protected ItemScopeBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public ItemScopeBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ItemScopeBuilder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		[Register ("build", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetBuildHandler")]
		public virtual global::Android.Gms.Plus.Model.Moments.IItemScope Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAbout (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setAbout", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAbout (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setAbout", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAbout_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setAdditionalName_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAdditionalName_Ljava_util_List_Handler ()
		{
			if (cb_setAdditionalName_Ljava_util_List_ == null)
				cb_setAdditionalName_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAdditionalName_Ljava_util_List_);
			return cb_setAdditionalName_Ljava_util_List_;
		}

		static IntPtr n_SetAdditionalName_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAdditionalName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAdditionalName_Ljava_util_List_;
		[Register ("setAdditionalName", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAdditionalName_Ljava_util_List_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAdditionalName (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_setAdditionalName_Ljava_util_List_ == IntPtr.Zero)
				id_setAdditionalName_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAdditionalName", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAdditionalName_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAdditionalName_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setAddress", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAddress (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAddress_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setAddressCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddressCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setAddressCountry_Ljava_lang_String_ == null)
				cb_setAddressCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAddressCountry_Ljava_lang_String_);
			return cb_setAddressCountry_Ljava_lang_String_;
		}

		static IntPtr n_SetAddressCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAddressCountry (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAddressCountry_Ljava_lang_String_;
		[Register ("setAddressCountry", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAddressCountry_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAddressCountry (string p0)
		{
			if (id_setAddressCountry_Ljava_lang_String_ == IntPtr.Zero)
				id_setAddressCountry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddressCountry", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAddressCountry_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAddressCountry_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setAddressLocality_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddressLocality_Ljava_lang_String_Handler ()
		{
			if (cb_setAddressLocality_Ljava_lang_String_ == null)
				cb_setAddressLocality_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAddressLocality_Ljava_lang_String_);
			return cb_setAddressLocality_Ljava_lang_String_;
		}

		static IntPtr n_SetAddressLocality_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAddressLocality (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAddressLocality_Ljava_lang_String_;
		[Register ("setAddressLocality", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAddressLocality_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAddressLocality (string p0)
		{
			if (id_setAddressLocality_Ljava_lang_String_ == IntPtr.Zero)
				id_setAddressLocality_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddressLocality", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAddressLocality_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAddressLocality_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setAddressRegion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddressRegion_Ljava_lang_String_Handler ()
		{
			if (cb_setAddressRegion_Ljava_lang_String_ == null)
				cb_setAddressRegion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAddressRegion_Ljava_lang_String_);
			return cb_setAddressRegion_Ljava_lang_String_;
		}

		static IntPtr n_SetAddressRegion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAddressRegion (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAddressRegion_Ljava_lang_String_;
		[Register ("setAddressRegion", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAddressRegion_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAddressRegion (string p0)
		{
			if (id_setAddressRegion_Ljava_lang_String_ == IntPtr.Zero)
				id_setAddressRegion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddressRegion", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAddressRegion_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAddressRegion_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setAssociated_media_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAssociated_media_Ljava_util_List_Handler ()
		{
			if (cb_setAssociated_media_Ljava_util_List_ == null)
				cb_setAssociated_media_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAssociated_media_Ljava_util_List_);
			return cb_setAssociated_media_Ljava_util_List_;
		}

		static IntPtr n_SetAssociated_media_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Gms.Plus.Model.Moments.IItemScope> p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAssociated_media (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAssociated_media_Ljava_util_List_;
		[Register ("setAssociated_media", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAssociated_media_Ljava_util_List_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAssociated_media (global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> p0)
		{
			if (id_setAssociated_media_Ljava_util_List_ == IntPtr.Zero)
				id_setAssociated_media_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAssociated_media", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAssociated_media_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAssociated_media_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setAttendeeCount_I;
#pragma warning disable 0169
		static Delegate GetSetAttendeeCount_IHandler ()
		{
			if (cb_setAttendeeCount_I == null)
				cb_setAttendeeCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAttendeeCount_I);
			return cb_setAttendeeCount_I;
		}

		static IntPtr n_SetAttendeeCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAttendeeCount (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setAttendeeCount_I;
		[Register ("setAttendeeCount", "(I)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAttendeeCount_IHandler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAttendeeCount (int p0)
		{
			if (id_setAttendeeCount_I == IntPtr.Zero)
				id_setAttendeeCount_I = JNIEnv.GetMethodID (class_ref, "setAttendeeCount", "(I)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAttendeeCount_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAttendeeCount_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setAttendees_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAttendees_Ljava_util_List_Handler ()
		{
			if (cb_setAttendees_Ljava_util_List_ == null)
				cb_setAttendees_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAttendees_Ljava_util_List_);
			return cb_setAttendees_Ljava_util_List_;
		}

		static IntPtr n_SetAttendees_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Gms.Plus.Model.Moments.IItemScope> p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAttendees (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAttendees_Ljava_util_List_;
		[Register ("setAttendees", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAttendees_Ljava_util_List_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAttendees (global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> p0)
		{
			if (id_setAttendees_Ljava_util_List_ == IntPtr.Zero)
				id_setAttendees_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAttendees", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAttendees_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAttendees_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudio (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setAudio", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAudio (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setAudio", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAudio_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setAuthor_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAuthor_Ljava_util_List_Handler ()
		{
			if (cb_setAuthor_Ljava_util_List_ == null)
				cb_setAuthor_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAuthor_Ljava_util_List_);
			return cb_setAuthor_Ljava_util_List_;
		}

		static IntPtr n_SetAuthor_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Gms.Plus.Model.Moments.IItemScope> p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAuthor_Ljava_util_List_;
		[Register ("setAuthor", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetAuthor_Ljava_util_List_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetAuthor (global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> p0)
		{
			if (id_setAuthor_Ljava_util_List_ == IntPtr.Zero)
				id_setAuthor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAuthor", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAuthor_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAuthor_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setBestRating_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBestRating_Ljava_lang_String_Handler ()
		{
			if (cb_setBestRating_Ljava_lang_String_ == null)
				cb_setBestRating_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBestRating_Ljava_lang_String_);
			return cb_setBestRating_Ljava_lang_String_;
		}

		static IntPtr n_SetBestRating_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBestRating (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBestRating_Ljava_lang_String_;
		[Register ("setBestRating", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetBestRating_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetBestRating (string p0)
		{
			if (id_setBestRating_Ljava_lang_String_ == IntPtr.Zero)
				id_setBestRating_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBestRating", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setBestRating_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setBestRating_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setBirthDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBirthDate_Ljava_lang_String_Handler ()
		{
			if (cb_setBirthDate_Ljava_lang_String_ == null)
				cb_setBirthDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBirthDate_Ljava_lang_String_);
			return cb_setBirthDate_Ljava_lang_String_;
		}

		static IntPtr n_SetBirthDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBirthDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBirthDate_Ljava_lang_String_;
		[Register ("setBirthDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetBirthDate_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetBirthDate (string p0)
		{
			if (id_setBirthDate_Ljava_lang_String_ == IntPtr.Zero)
				id_setBirthDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBirthDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setBirthDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setBirthDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetByArtist (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setByArtist", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetByArtist (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setByArtist", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setByArtist_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setCaption_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCaption_Ljava_lang_String_Handler ()
		{
			if (cb_setCaption_Ljava_lang_String_ == null)
				cb_setCaption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCaption_Ljava_lang_String_);
			return cb_setCaption_Ljava_lang_String_;
		}

		static IntPtr n_SetCaption_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCaption (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCaption_Ljava_lang_String_;
		[Register ("setCaption", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetCaption_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetCaption (string p0)
		{
			if (id_setCaption_Ljava_lang_String_ == IntPtr.Zero)
				id_setCaption_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCaption", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setCaption_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setCaption_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setContentSize_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentSize_Ljava_lang_String_Handler ()
		{
			if (cb_setContentSize_Ljava_lang_String_ == null)
				cb_setContentSize_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentSize_Ljava_lang_String_);
			return cb_setContentSize_Ljava_lang_String_;
		}

		static IntPtr n_SetContentSize_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentSize (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setContentSize_Ljava_lang_String_;
		[Register ("setContentSize", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetContentSize_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetContentSize (string p0)
		{
			if (id_setContentSize_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentSize_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentSize", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setContentSize_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setContentSize_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setContentUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setContentUrl_Ljava_lang_String_ == null)
				cb_setContentUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentUrl_Ljava_lang_String_);
			return cb_setContentUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetContentUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setContentUrl_Ljava_lang_String_;
		[Register ("setContentUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetContentUrl_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetContentUrl (string p0)
		{
			if (id_setContentUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setContentUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setContentUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setContributor_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetContributor_Ljava_util_List_Handler ()
		{
			if (cb_setContributor_Ljava_util_List_ == null)
				cb_setContributor_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContributor_Ljava_util_List_);
			return cb_setContributor_Ljava_util_List_;
		}

		static IntPtr n_SetContributor_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Gms.Plus.Model.Moments.IItemScope> p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContributor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setContributor_Ljava_util_List_;
		[Register ("setContributor", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetContributor_Ljava_util_List_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetContributor (global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> p0)
		{
			if (id_setContributor_Ljava_util_List_ == IntPtr.Zero)
				id_setContributor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setContributor", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setContributor_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setContributor_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setDateCreated_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateCreated_Ljava_lang_String_Handler ()
		{
			if (cb_setDateCreated_Ljava_lang_String_ == null)
				cb_setDateCreated_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDateCreated_Ljava_lang_String_);
			return cb_setDateCreated_Ljava_lang_String_;
		}

		static IntPtr n_SetDateCreated_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDateCreated (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDateCreated_Ljava_lang_String_;
		[Register ("setDateCreated", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetDateCreated_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetDateCreated (string p0)
		{
			if (id_setDateCreated_Ljava_lang_String_ == IntPtr.Zero)
				id_setDateCreated_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateCreated", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDateCreated_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setDateCreated_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setDateModified_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateModified_Ljava_lang_String_Handler ()
		{
			if (cb_setDateModified_Ljava_lang_String_ == null)
				cb_setDateModified_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDateModified_Ljava_lang_String_);
			return cb_setDateModified_Ljava_lang_String_;
		}

		static IntPtr n_SetDateModified_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDateModified (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDateModified_Ljava_lang_String_;
		[Register ("setDateModified", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetDateModified_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetDateModified (string p0)
		{
			if (id_setDateModified_Ljava_lang_String_ == IntPtr.Zero)
				id_setDateModified_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateModified", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDateModified_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setDateModified_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setDatePublished_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDatePublished_Ljava_lang_String_Handler ()
		{
			if (cb_setDatePublished_Ljava_lang_String_ == null)
				cb_setDatePublished_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDatePublished_Ljava_lang_String_);
			return cb_setDatePublished_Ljava_lang_String_;
		}

		static IntPtr n_SetDatePublished_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDatePublished (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDatePublished_Ljava_lang_String_;
		[Register ("setDatePublished", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetDatePublished_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetDatePublished (string p0)
		{
			if (id_setDatePublished_Ljava_lang_String_ == IntPtr.Zero)
				id_setDatePublished_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDatePublished", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDatePublished_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setDatePublished_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static IntPtr n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDescription (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDescription_Ljava_lang_String_;
		[Register ("setDescription", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetDescription_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetDescription (string p0)
		{
			if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDescription_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setDescription_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setDuration_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDuration_Ljava_lang_String_Handler ()
		{
			if (cb_setDuration_Ljava_lang_String_ == null)
				cb_setDuration_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDuration_Ljava_lang_String_);
			return cb_setDuration_Ljava_lang_String_;
		}

		static IntPtr n_SetDuration_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDuration_Ljava_lang_String_;
		[Register ("setDuration", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetDuration_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetDuration (string p0)
		{
			if (id_setDuration_Ljava_lang_String_ == IntPtr.Zero)
				id_setDuration_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDuration", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setDuration_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setEmbedUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmbedUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setEmbedUrl_Ljava_lang_String_ == null)
				cb_setEmbedUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEmbedUrl_Ljava_lang_String_);
			return cb_setEmbedUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetEmbedUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEmbedUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setEmbedUrl_Ljava_lang_String_;
		[Register ("setEmbedUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetEmbedUrl_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetEmbedUrl (string p0)
		{
			if (id_setEmbedUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setEmbedUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmbedUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setEmbedUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setEmbedUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setEndDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEndDate_Ljava_lang_String_Handler ()
		{
			if (cb_setEndDate_Ljava_lang_String_ == null)
				cb_setEndDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEndDate_Ljava_lang_String_);
			return cb_setEndDate_Ljava_lang_String_;
		}

		static IntPtr n_SetEndDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEndDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setEndDate_Ljava_lang_String_;
		[Register ("setEndDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetEndDate_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetEndDate (string p0)
		{
			if (id_setEndDate_Ljava_lang_String_ == IntPtr.Zero)
				id_setEndDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEndDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setEndDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setEndDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setFamilyName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFamilyName_Ljava_lang_String_Handler ()
		{
			if (cb_setFamilyName_Ljava_lang_String_ == null)
				cb_setFamilyName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFamilyName_Ljava_lang_String_);
			return cb_setFamilyName_Ljava_lang_String_;
		}

		static IntPtr n_SetFamilyName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFamilyName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFamilyName_Ljava_lang_String_;
		[Register ("setFamilyName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetFamilyName_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetFamilyName (string p0)
		{
			if (id_setFamilyName_Ljava_lang_String_ == IntPtr.Zero)
				id_setFamilyName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFamilyName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setFamilyName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setFamilyName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setGender_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGender_Ljava_lang_String_Handler ()
		{
			if (cb_setGender_Ljava_lang_String_ == null)
				cb_setGender_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGender_Ljava_lang_String_);
			return cb_setGender_Ljava_lang_String_;
		}

		static IntPtr n_SetGender_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGender (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setGender_Ljava_lang_String_;
		[Register ("setGender", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetGender_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetGender (string p0)
		{
			if (id_setGender_Ljava_lang_String_ == IntPtr.Zero)
				id_setGender_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGender", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setGender_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setGender_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGeo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setGeo", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetGeo (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setGeo", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setGeo_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setGivenName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGivenName_Ljava_lang_String_Handler ()
		{
			if (cb_setGivenName_Ljava_lang_String_ == null)
				cb_setGivenName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGivenName_Ljava_lang_String_);
			return cb_setGivenName_Ljava_lang_String_;
		}

		static IntPtr n_SetGivenName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGivenName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setGivenName_Ljava_lang_String_;
		[Register ("setGivenName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetGivenName_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetGivenName (string p0)
		{
			if (id_setGivenName_Ljava_lang_String_ == IntPtr.Zero)
				id_setGivenName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGivenName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setGivenName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setGivenName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setHeight_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHeight_Ljava_lang_String_Handler ()
		{
			if (cb_setHeight_Ljava_lang_String_ == null)
				cb_setHeight_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeight_Ljava_lang_String_);
			return cb_setHeight_Ljava_lang_String_;
		}

		static IntPtr n_SetHeight_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHeight (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHeight_Ljava_lang_String_;
		[Register ("setHeight", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetHeight_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetHeight (string p0)
		{
			if (id_setHeight_Ljava_lang_String_ == IntPtr.Zero)
				id_setHeight_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeight", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setHeight_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setHeight_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static IntPtr n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setId_Ljava_lang_String_;
		[Register ("setId", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetId_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetId (string p0)
		{
			if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
				id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImage_Ljava_lang_String_Handler ()
		{
			if (cb_setImage_Ljava_lang_String_ == null)
				cb_setImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImage_Ljava_lang_String_);
			return cb_setImage_Ljava_lang_String_;
		}

		static IntPtr n_SetImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Ljava_lang_String_;
		[Register ("setImage", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetImage_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetImage (string p0)
		{
			if (id_setImage_Ljava_lang_String_ == IntPtr.Zero)
				id_setImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setImage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setImage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInAlbum (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setInAlbum", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetInAlbum (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setInAlbum", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setInAlbum_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetLatitude_DHandler ()
		{
			if (cb_setLatitude_D == null)
				cb_setLatitude_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetLatitude_D);
			return cb_setLatitude_D;
		}

		static IntPtr n_SetLatitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLatitude (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setLatitude_D;
		[Register ("setLatitude", "(D)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetLatitude_DHandler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetLatitude (double p0)
		{
			if (id_setLatitude_D == IntPtr.Zero)
				id_setLatitude_D = JNIEnv.GetMethodID (class_ref, "setLatitude", "(D)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setLatitude_D, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setLatitude_D, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setLocation", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetLocation (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setLocation_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetLongitude_DHandler ()
		{
			if (cb_setLongitude_D == null)
				cb_setLongitude_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetLongitude_D);
			return cb_setLongitude_D;
		}

		static IntPtr n_SetLongitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLongitude (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setLongitude_D;
		[Register ("setLongitude", "(D)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetLongitude_DHandler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetLongitude (double p0)
		{
			if (id_setLongitude_D == IntPtr.Zero)
				id_setLongitude_D = JNIEnv.GetMethodID (class_ref, "setLongitude", "(D)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setLongitude_D, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setLongitude_D, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setName_Ljava_lang_String_;
		[Register ("setName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetName (string p0)
		{
			if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
				id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPartOfTVSeries (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setPartOfTVSeries", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetPartOfTVSeries (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setPartOfTVSeries", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setPartOfTVSeries_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setPerformers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPerformers_Ljava_util_List_Handler ()
		{
			if (cb_setPerformers_Ljava_util_List_ == null)
				cb_setPerformers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPerformers_Ljava_util_List_);
			return cb_setPerformers_Ljava_util_List_;
		}

		static IntPtr n_SetPerformers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Gms.Plus.Model.Moments.IItemScope> p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPerformers (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPerformers_Ljava_util_List_;
		[Register ("setPerformers", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetPerformers_Ljava_util_List_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetPerformers (global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> p0)
		{
			if (id_setPerformers_Ljava_util_List_ == IntPtr.Zero)
				id_setPerformers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPerformers", "(Ljava/util/List;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setPerformers_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setPerformers_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPlayerType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlayerType_Ljava_lang_String_Handler ()
		{
			if (cb_setPlayerType_Ljava_lang_String_ == null)
				cb_setPlayerType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlayerType_Ljava_lang_String_);
			return cb_setPlayerType_Ljava_lang_String_;
		}

		static IntPtr n_SetPlayerType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlayerType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPlayerType_Ljava_lang_String_;
		[Register ("setPlayerType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetPlayerType_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetPlayerType (string p0)
		{
			if (id_setPlayerType_Ljava_lang_String_ == IntPtr.Zero)
				id_setPlayerType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlayerType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setPlayerType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setPlayerType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPostOfficeBoxNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPostOfficeBoxNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setPostOfficeBoxNumber_Ljava_lang_String_ == null)
				cb_setPostOfficeBoxNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPostOfficeBoxNumber_Ljava_lang_String_);
			return cb_setPostOfficeBoxNumber_Ljava_lang_String_;
		}

		static IntPtr n_SetPostOfficeBoxNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostOfficeBoxNumber (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPostOfficeBoxNumber_Ljava_lang_String_;
		[Register ("setPostOfficeBoxNumber", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetPostOfficeBoxNumber_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetPostOfficeBoxNumber (string p0)
		{
			if (id_setPostOfficeBoxNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_setPostOfficeBoxNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPostOfficeBoxNumber", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setPostOfficeBoxNumber_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setPostOfficeBoxNumber_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPostalCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPostalCode_Ljava_lang_String_Handler ()
		{
			if (cb_setPostalCode_Ljava_lang_String_ == null)
				cb_setPostalCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPostalCode_Ljava_lang_String_);
			return cb_setPostalCode_Ljava_lang_String_;
		}

		static IntPtr n_SetPostalCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostalCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPostalCode_Ljava_lang_String_;
		[Register ("setPostalCode", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetPostalCode_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetPostalCode (string p0)
		{
			if (id_setPostalCode_Ljava_lang_String_ == IntPtr.Zero)
				id_setPostalCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPostalCode", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setPostalCode_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setPostalCode_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setRatingValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRatingValue_Ljava_lang_String_Handler ()
		{
			if (cb_setRatingValue_Ljava_lang_String_ == null)
				cb_setRatingValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRatingValue_Ljava_lang_String_);
			return cb_setRatingValue_Ljava_lang_String_;
		}

		static IntPtr n_SetRatingValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRatingValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setRatingValue_Ljava_lang_String_;
		[Register ("setRatingValue", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetRatingValue_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetRatingValue (string p0)
		{
			if (id_setRatingValue_Ljava_lang_String_ == IntPtr.Zero)
				id_setRatingValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRatingValue", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setRatingValue_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setRatingValue_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReviewRating (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setReviewRating", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetReviewRating (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setReviewRating", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setReviewRating_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setStartDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStartDate_Ljava_lang_String_Handler ()
		{
			if (cb_setStartDate_Ljava_lang_String_ == null)
				cb_setStartDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStartDate_Ljava_lang_String_);
			return cb_setStartDate_Ljava_lang_String_;
		}

		static IntPtr n_SetStartDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStartDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setStartDate_Ljava_lang_String_;
		[Register ("setStartDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetStartDate_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetStartDate (string p0)
		{
			if (id_setStartDate_Ljava_lang_String_ == IntPtr.Zero)
				id_setStartDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStartDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setStartDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setStartDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setStreetAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setStreetAddress_Ljava_lang_String_ == null)
				cb_setStreetAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStreetAddress_Ljava_lang_String_);
			return cb_setStreetAddress_Ljava_lang_String_;
		}

		static IntPtr n_SetStreetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStreetAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setStreetAddress_Ljava_lang_String_;
		[Register ("setStreetAddress", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetStreetAddress_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetStreetAddress (string p0)
		{
			if (id_setStreetAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_setStreetAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreetAddress", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setStreetAddress_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setStreetAddress_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static IntPtr n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetText (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setText_Ljava_lang_String_;
		[Register ("setText", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetText_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetText (string p0)
		{
			if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
				id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setText_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setText_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetThumbnail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setThumbnail", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetThumbnail (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setThumbnail", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setThumbnail_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setThumbnailUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetThumbnailUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setThumbnailUrl_Ljava_lang_String_ == null)
				cb_setThumbnailUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetThumbnailUrl_Ljava_lang_String_);
			return cb_setThumbnailUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetThumbnailUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetThumbnailUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setThumbnailUrl_Ljava_lang_String_;
		[Register ("setThumbnailUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetThumbnailUrl_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetThumbnailUrl (string p0)
		{
			if (id_setThumbnailUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setThumbnailUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setThumbnailUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setThumbnailUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setThumbnailUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setTickerSymbol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTickerSymbol_Ljava_lang_String_Handler ()
		{
			if (cb_setTickerSymbol_Ljava_lang_String_ == null)
				cb_setTickerSymbol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTickerSymbol_Ljava_lang_String_);
			return cb_setTickerSymbol_Ljava_lang_String_;
		}

		static IntPtr n_SetTickerSymbol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTickerSymbol (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTickerSymbol_Ljava_lang_String_;
		[Register ("setTickerSymbol", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetTickerSymbol_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetTickerSymbol (string p0)
		{
			if (id_setTickerSymbol_Ljava_lang_String_ == IntPtr.Zero)
				id_setTickerSymbol_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTickerSymbol", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setTickerSymbol_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setTickerSymbol_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static IntPtr n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setType_Ljava_lang_String_;
		[Register ("setType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetType_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetType (string p0)
		{
			if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
				id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setUrl_Ljava_lang_String_;
		[Register ("setUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetUrl_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetUrl (string p0)
		{
			if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setWidth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWidth_Ljava_lang_String_Handler ()
		{
			if (cb_setWidth_Ljava_lang_String_ == null)
				cb_setWidth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetWidth_Ljava_lang_String_);
			return cb_setWidth_Ljava_lang_String_;
		}

		static IntPtr n_SetWidth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetWidth (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setWidth_Ljava_lang_String_;
		[Register ("setWidth", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetWidth_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetWidth (string p0)
		{
			if (id_setWidth_Ljava_lang_String_ == IntPtr.Zero)
				id_setWidth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWidth", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setWidth_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setWidth_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setWorstRating_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWorstRating_Ljava_lang_String_Handler ()
		{
			if (cb_setWorstRating_Ljava_lang_String_ == null)
				cb_setWorstRating_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetWorstRating_Ljava_lang_String_);
			return cb_setWorstRating_Ljava_lang_String_;
		}

		static IntPtr n_SetWorstRating_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetWorstRating (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setWorstRating_Ljava_lang_String_;
		[Register ("setWorstRating", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;", "GetSetWorstRating_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder SetWorstRating (string p0)
		{
			if (id_setWorstRating_Ljava_lang_String_ == IntPtr.Zero)
				id_setWorstRating_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWorstRating", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/ItemScope$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setWorstRating_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.ItemScopeBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setWorstRating_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

	[Register ("com/google/android/gms/plus/model/moments/ItemScope", "", "Android.Gms.Plus.Model.Moments.IItemScopeInvoker")]
	public partial interface IItemScope : global::Android.Gms.Common.Data.IFreezable {

		global::Android.Gms.Plus.Model.Moments.IItemScope About {
			[Register ("getAbout", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetAboutHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<string> AdditionalName {
			[Register ("getAdditionalName", "()Ljava/util/List;", "GetGetAdditionalNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope Address {
			[Register ("getAddress", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetAddressHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string AddressCountry {
			[Register ("getAddressCountry", "()Ljava/lang/String;", "GetGetAddressCountryHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string AddressLocality {
			[Register ("getAddressLocality", "()Ljava/lang/String;", "GetGetAddressLocalityHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string AddressRegion {
			[Register ("getAddressRegion", "()Ljava/lang/String;", "GetGetAddressRegionHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Associated_media {
			[Register ("getAssociated_media", "()Ljava/util/List;", "GetGetAssociated_mediaHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		int AttendeeCount {
			[Register ("getAttendeeCount", "()I", "GetGetAttendeeCountHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Attendees {
			[Register ("getAttendees", "()Ljava/util/List;", "GetGetAttendeesHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope Audio {
			[Register ("getAudio", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetAudioHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Author {
			[Register ("getAuthor", "()Ljava/util/List;", "GetGetAuthorHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string BestRating {
			[Register ("getBestRating", "()Ljava/lang/String;", "GetGetBestRatingHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string BirthDate {
			[Register ("getBirthDate", "()Ljava/lang/String;", "GetGetBirthDateHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope ByArtist {
			[Register ("getByArtist", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetByArtistHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Caption {
			[Register ("getCaption", "()Ljava/lang/String;", "GetGetCaptionHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string ContentSize {
			[Register ("getContentSize", "()Ljava/lang/String;", "GetGetContentSizeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string ContentUrl {
			[Register ("getContentUrl", "()Ljava/lang/String;", "GetGetContentUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Contributor {
			[Register ("getContributor", "()Ljava/util/List;", "GetGetContributorHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string DateCreated {
			[Register ("getDateCreated", "()Ljava/lang/String;", "GetGetDateCreatedHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string DateModified {
			[Register ("getDateModified", "()Ljava/lang/String;", "GetGetDateModifiedHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string DatePublished {
			[Register ("getDatePublished", "()Ljava/lang/String;", "GetGetDatePublishedHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Description {
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Duration {
			[Register ("getDuration", "()Ljava/lang/String;", "GetGetDurationHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string EmbedUrl {
			[Register ("getEmbedUrl", "()Ljava/lang/String;", "GetGetEmbedUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string EndDate {
			[Register ("getEndDate", "()Ljava/lang/String;", "GetGetEndDateHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string FamilyName {
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Gender {
			[Register ("getGender", "()Ljava/lang/String;", "GetGetGenderHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope Geo {
			[Register ("getGeo", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetGeoHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string GivenName {
			[Register ("getGivenName", "()Ljava/lang/String;", "GetGetGivenNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAbout {
			[Register ("hasAbout", "()Z", "GetHasAboutHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAdditionalName {
			[Register ("hasAdditionalName", "()Z", "GetHasAdditionalNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAddress {
			[Register ("hasAddress", "()Z", "GetHasAddressHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAddressCountry {
			[Register ("hasAddressCountry", "()Z", "GetHasAddressCountryHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAddressLocality {
			[Register ("hasAddressLocality", "()Z", "GetHasAddressLocalityHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAddressRegion {
			[Register ("hasAddressRegion", "()Z", "GetHasAddressRegionHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAssociated_media {
			[Register ("hasAssociated_media", "()Z", "GetHasAssociated_mediaHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAttendeeCount {
			[Register ("hasAttendeeCount", "()Z", "GetHasAttendeeCountHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAttendees {
			[Register ("hasAttendees", "()Z", "GetHasAttendeesHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAudio {
			[Register ("hasAudio", "()Z", "GetHasAudioHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasAuthor {
			[Register ("hasAuthor", "()Z", "GetHasAuthorHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasBestRating {
			[Register ("hasBestRating", "()Z", "GetHasBestRatingHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasBirthDate {
			[Register ("hasBirthDate", "()Z", "GetHasBirthDateHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasByArtist {
			[Register ("hasByArtist", "()Z", "GetHasByArtistHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasCaption {
			[Register ("hasCaption", "()Z", "GetHasCaptionHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasContentSize {
			[Register ("hasContentSize", "()Z", "GetHasContentSizeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasContentUrl {
			[Register ("hasContentUrl", "()Z", "GetHasContentUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasContributor {
			[Register ("hasContributor", "()Z", "GetHasContributorHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasDateCreated {
			[Register ("hasDateCreated", "()Z", "GetHasDateCreatedHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasDateModified {
			[Register ("hasDateModified", "()Z", "GetHasDateModifiedHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasDatePublished {
			[Register ("hasDatePublished", "()Z", "GetHasDatePublishedHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasDescription {
			[Register ("hasDescription", "()Z", "GetHasDescriptionHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasDuration {
			[Register ("hasDuration", "()Z", "GetHasDurationHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasEmbedUrl {
			[Register ("hasEmbedUrl", "()Z", "GetHasEmbedUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasEndDate {
			[Register ("hasEndDate", "()Z", "GetHasEndDateHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasFamilyName {
			[Register ("hasFamilyName", "()Z", "GetHasFamilyNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasGender {
			[Register ("hasGender", "()Z", "GetHasGenderHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasGeo {
			[Register ("hasGeo", "()Z", "GetHasGeoHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasGivenName {
			[Register ("hasGivenName", "()Z", "GetHasGivenNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasHeight {
			[Register ("hasHeight", "()Z", "GetHasHeightHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasId {
			[Register ("hasId", "()Z", "GetHasIdHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasImage {
			[Register ("hasImage", "()Z", "GetHasImageHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasInAlbum {
			[Register ("hasInAlbum", "()Z", "GetHasInAlbumHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasLatitude {
			[Register ("hasLatitude", "()Z", "GetHasLatitudeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasLocation {
			[Register ("hasLocation", "()Z", "GetHasLocationHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasLongitude {
			[Register ("hasLongitude", "()Z", "GetHasLongitudeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasName {
			[Register ("hasName", "()Z", "GetHasNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasPartOfTVSeries {
			[Register ("hasPartOfTVSeries", "()Z", "GetHasPartOfTVSeriesHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasPerformers {
			[Register ("hasPerformers", "()Z", "GetHasPerformersHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasPlayerType {
			[Register ("hasPlayerType", "()Z", "GetHasPlayerTypeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasPostalCode {
			[Register ("hasPostalCode", "()Z", "GetHasPostalCodeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasPostOfficeBoxNumber {
			[Register ("hasPostOfficeBoxNumber", "()Z", "GetHasPostOfficeBoxNumberHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasRatingValue {
			[Register ("hasRatingValue", "()Z", "GetHasRatingValueHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasReviewRating {
			[Register ("hasReviewRating", "()Z", "GetHasReviewRatingHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasStartDate {
			[Register ("hasStartDate", "()Z", "GetHasStartDateHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasStreetAddress {
			[Register ("hasStreetAddress", "()Z", "GetHasStreetAddressHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasText {
			[Register ("hasText", "()Z", "GetHasTextHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasThumbnail {
			[Register ("hasThumbnail", "()Z", "GetHasThumbnailHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasThumbnailUrl {
			[Register ("hasThumbnailUrl", "()Z", "GetHasThumbnailUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasTickerSymbol {
			[Register ("hasTickerSymbol", "()Z", "GetHasTickerSymbolHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasType {
			[Register ("hasType", "()Z", "GetHasTypeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasUrl {
			[Register ("hasUrl", "()Z", "GetHasUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasWidth {
			[Register ("hasWidth", "()Z", "GetHasWidthHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		bool HasWorstRating {
			[Register ("hasWorstRating", "()Z", "GetHasWorstRatingHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Height {
			[Register ("getHeight", "()Ljava/lang/String;", "GetGetHeightHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Id {
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Image {
			[Register ("getImage", "()Ljava/lang/String;", "GetGetImageHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope InAlbum {
			[Register ("getInAlbum", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetInAlbumHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		double Latitude {
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope Location {
			[Register ("getLocation", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetLocationHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		double Longitude {
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Name {
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope PartOfTVSeries {
			[Register ("getPartOfTVSeries", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetPartOfTVSeriesHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Performers {
			[Register ("getPerformers", "()Ljava/util/List;", "GetGetPerformersHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string PlayerType {
			[Register ("getPlayerType", "()Ljava/lang/String;", "GetGetPlayerTypeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string PostalCode {
			[Register ("getPostalCode", "()Ljava/lang/String;", "GetGetPostalCodeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string PostOfficeBoxNumber {
			[Register ("getPostOfficeBoxNumber", "()Ljava/lang/String;", "GetGetPostOfficeBoxNumberHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string RatingValue {
			[Register ("getRatingValue", "()Ljava/lang/String;", "GetGetRatingValueHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope ReviewRating {
			[Register ("getReviewRating", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetReviewRatingHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string StartDate {
			[Register ("getStartDate", "()Ljava/lang/String;", "GetGetStartDateHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string StreetAddress {
			[Register ("getStreetAddress", "()Ljava/lang/String;", "GetGetStreetAddressHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Text {
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope Thumbnail {
			[Register ("getThumbnail", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetThumbnailHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string ThumbnailUrl {
			[Register ("getThumbnailUrl", "()Ljava/lang/String;", "GetGetThumbnailUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string TickerSymbol {
			[Register ("getTickerSymbol", "()Ljava/lang/String;", "GetGetTickerSymbolHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Type {
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Url {
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string Width {
			[Register ("getWidth", "()Ljava/lang/String;", "GetGetWidthHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

		string WorstRating {
			[Register ("getWorstRating", "()Ljava/lang/String;", "GetGetWorstRatingHandler:Android.Gms.Plus.Model.Moments.IItemScopeInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/moments/ItemScope", DoNotGenerateAcw=true)]
	internal class IItemScopeInvoker : global::Java.Lang.Object, IItemScope {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/moments/ItemScope");
		IntPtr class_ref;

		public static IItemScope GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IItemScope> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.moments.ItemScope"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IItemScopeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IItemScopeInvoker); }
		}

		static Delegate cb_getAbout;
#pragma warning disable 0169
		static Delegate GetGetAboutHandler ()
		{
			if (cb_getAbout == null)
				cb_getAbout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAbout);
			return cb_getAbout;
		}

		static IntPtr n_GetAbout (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.About);
		}
#pragma warning restore 0169

		IntPtr id_getAbout;
		public global::Android.Gms.Plus.Model.Moments.IItemScope About {
			get {
				if (id_getAbout == IntPtr.Zero)
					id_getAbout = JNIEnv.GetMethodID (class_ref, "getAbout", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getAbout), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdditionalName;
#pragma warning disable 0169
		static Delegate GetGetAdditionalNameHandler ()
		{
			if (cb_getAdditionalName == null)
				cb_getAdditionalName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdditionalName);
			return cb_getAdditionalName;
		}

		static IntPtr n_GetAdditionalName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AdditionalName);
		}
#pragma warning restore 0169

		IntPtr id_getAdditionalName;
		public global::System.Collections.Generic.IList<string> AdditionalName {
			get {
				if (id_getAdditionalName == IntPtr.Zero)
					id_getAdditionalName = JNIEnv.GetMethodID (class_ref, "getAdditionalName", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAdditionalName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Address);
		}
#pragma warning restore 0169

		IntPtr id_getAddress;
		public global::Android.Gms.Plus.Model.Moments.IItemScope Address {
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAddressCountry;
#pragma warning disable 0169
		static Delegate GetGetAddressCountryHandler ()
		{
			if (cb_getAddressCountry == null)
				cb_getAddressCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddressCountry);
			return cb_getAddressCountry;
		}

		static IntPtr n_GetAddressCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddressCountry);
		}
#pragma warning restore 0169

		IntPtr id_getAddressCountry;
		public string AddressCountry {
			get {
				if (id_getAddressCountry == IntPtr.Zero)
					id_getAddressCountry = JNIEnv.GetMethodID (class_ref, "getAddressCountry", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAddressCountry), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAddressLocality;
#pragma warning disable 0169
		static Delegate GetGetAddressLocalityHandler ()
		{
			if (cb_getAddressLocality == null)
				cb_getAddressLocality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddressLocality);
			return cb_getAddressLocality;
		}

		static IntPtr n_GetAddressLocality (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddressLocality);
		}
#pragma warning restore 0169

		IntPtr id_getAddressLocality;
		public string AddressLocality {
			get {
				if (id_getAddressLocality == IntPtr.Zero)
					id_getAddressLocality = JNIEnv.GetMethodID (class_ref, "getAddressLocality", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAddressLocality), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAddressRegion;
#pragma warning disable 0169
		static Delegate GetGetAddressRegionHandler ()
		{
			if (cb_getAddressRegion == null)
				cb_getAddressRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddressRegion);
			return cb_getAddressRegion;
		}

		static IntPtr n_GetAddressRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddressRegion);
		}
#pragma warning restore 0169

		IntPtr id_getAddressRegion;
		public string AddressRegion {
			get {
				if (id_getAddressRegion == IntPtr.Zero)
					id_getAddressRegion = JNIEnv.GetMethodID (class_ref, "getAddressRegion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAddressRegion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAssociated_media;
#pragma warning disable 0169
		static Delegate GetGetAssociated_mediaHandler ()
		{
			if (cb_getAssociated_media == null)
				cb_getAssociated_media = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssociated_media);
			return cb_getAssociated_media;
		}

		static IntPtr n_GetAssociated_media (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (__this.Associated_media);
		}
#pragma warning restore 0169

		IntPtr id_getAssociated_media;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Associated_media {
			get {
				if (id_getAssociated_media == IntPtr.Zero)
					id_getAssociated_media = JNIEnv.GetMethodID (class_ref, "getAssociated_media", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAssociated_media), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAttendeeCount;
#pragma warning disable 0169
		static Delegate GetGetAttendeeCountHandler ()
		{
			if (cb_getAttendeeCount == null)
				cb_getAttendeeCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAttendeeCount);
			return cb_getAttendeeCount;
		}

		static int n_GetAttendeeCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttendeeCount;
		}
#pragma warning restore 0169

		IntPtr id_getAttendeeCount;
		public int AttendeeCount {
			get {
				if (id_getAttendeeCount == IntPtr.Zero)
					id_getAttendeeCount = JNIEnv.GetMethodID (class_ref, "getAttendeeCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getAttendeeCount);
			}
		}

		static Delegate cb_getAttendees;
#pragma warning disable 0169
		static Delegate GetGetAttendeesHandler ()
		{
			if (cb_getAttendees == null)
				cb_getAttendees = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttendees);
			return cb_getAttendees;
		}

		static IntPtr n_GetAttendees (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (__this.Attendees);
		}
#pragma warning restore 0169

		IntPtr id_getAttendees;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Attendees {
			get {
				if (id_getAttendees == IntPtr.Zero)
					id_getAttendees = JNIEnv.GetMethodID (class_ref, "getAttendees", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAttendees), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAudio;
#pragma warning disable 0169
		static Delegate GetGetAudioHandler ()
		{
			if (cb_getAudio == null)
				cb_getAudio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudio);
			return cb_getAudio;
		}

		static IntPtr n_GetAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Audio);
		}
#pragma warning restore 0169

		IntPtr id_getAudio;
		public global::Android.Gms.Plus.Model.Moments.IItemScope Audio {
			get {
				if (id_getAudio == IntPtr.Zero)
					id_getAudio = JNIEnv.GetMethodID (class_ref, "getAudio", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getAudio), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAuthor;
#pragma warning disable 0169
		static Delegate GetGetAuthorHandler ()
		{
			if (cb_getAuthor == null)
				cb_getAuthor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthor);
			return cb_getAuthor;
		}

		static IntPtr n_GetAuthor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (__this.Author);
		}
#pragma warning restore 0169

		IntPtr id_getAuthor;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Author {
			get {
				if (id_getAuthor == IntPtr.Zero)
					id_getAuthor = JNIEnv.GetMethodID (class_ref, "getAuthor", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAuthor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBestRating;
#pragma warning disable 0169
		static Delegate GetGetBestRatingHandler ()
		{
			if (cb_getBestRating == null)
				cb_getBestRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBestRating);
			return cb_getBestRating;
		}

		static IntPtr n_GetBestRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BestRating);
		}
#pragma warning restore 0169

		IntPtr id_getBestRating;
		public string BestRating {
			get {
				if (id_getBestRating == IntPtr.Zero)
					id_getBestRating = JNIEnv.GetMethodID (class_ref, "getBestRating", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getBestRating), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBirthDate;
#pragma warning disable 0169
		static Delegate GetGetBirthDateHandler ()
		{
			if (cb_getBirthDate == null)
				cb_getBirthDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBirthDate);
			return cb_getBirthDate;
		}

		static IntPtr n_GetBirthDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BirthDate);
		}
#pragma warning restore 0169

		IntPtr id_getBirthDate;
		public string BirthDate {
			get {
				if (id_getBirthDate == IntPtr.Zero)
					id_getBirthDate = JNIEnv.GetMethodID (class_ref, "getBirthDate", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getBirthDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getByArtist;
#pragma warning disable 0169
		static Delegate GetGetByArtistHandler ()
		{
			if (cb_getByArtist == null)
				cb_getByArtist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetByArtist);
			return cb_getByArtist;
		}

		static IntPtr n_GetByArtist (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ByArtist);
		}
#pragma warning restore 0169

		IntPtr id_getByArtist;
		public global::Android.Gms.Plus.Model.Moments.IItemScope ByArtist {
			get {
				if (id_getByArtist == IntPtr.Zero)
					id_getByArtist = JNIEnv.GetMethodID (class_ref, "getByArtist", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getByArtist), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCaption;
#pragma warning disable 0169
		static Delegate GetGetCaptionHandler ()
		{
			if (cb_getCaption == null)
				cb_getCaption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCaption);
			return cb_getCaption;
		}

		static IntPtr n_GetCaption (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Caption);
		}
#pragma warning restore 0169

		IntPtr id_getCaption;
		public string Caption {
			get {
				if (id_getCaption == IntPtr.Zero)
					id_getCaption = JNIEnv.GetMethodID (class_ref, "getCaption", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCaption), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentSize;
#pragma warning disable 0169
		static Delegate GetGetContentSizeHandler ()
		{
			if (cb_getContentSize == null)
				cb_getContentSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentSize);
			return cb_getContentSize;
		}

		static IntPtr n_GetContentSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentSize);
		}
#pragma warning restore 0169

		IntPtr id_getContentSize;
		public string ContentSize {
			get {
				if (id_getContentSize == IntPtr.Zero)
					id_getContentSize = JNIEnv.GetMethodID (class_ref, "getContentSize", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getContentSize), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentUrl;
#pragma warning disable 0169
		static Delegate GetGetContentUrlHandler ()
		{
			if (cb_getContentUrl == null)
				cb_getContentUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentUrl);
			return cb_getContentUrl;
		}

		static IntPtr n_GetContentUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentUrl);
		}
#pragma warning restore 0169

		IntPtr id_getContentUrl;
		public string ContentUrl {
			get {
				if (id_getContentUrl == IntPtr.Zero)
					id_getContentUrl = JNIEnv.GetMethodID (class_ref, "getContentUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getContentUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContributor;
#pragma warning disable 0169
		static Delegate GetGetContributorHandler ()
		{
			if (cb_getContributor == null)
				cb_getContributor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContributor);
			return cb_getContributor;
		}

		static IntPtr n_GetContributor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (__this.Contributor);
		}
#pragma warning restore 0169

		IntPtr id_getContributor;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Contributor {
			get {
				if (id_getContributor == IntPtr.Zero)
					id_getContributor = JNIEnv.GetMethodID (class_ref, "getContributor", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getContributor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDateCreated;
#pragma warning disable 0169
		static Delegate GetGetDateCreatedHandler ()
		{
			if (cb_getDateCreated == null)
				cb_getDateCreated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateCreated);
			return cb_getDateCreated;
		}

		static IntPtr n_GetDateCreated (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateCreated);
		}
#pragma warning restore 0169

		IntPtr id_getDateCreated;
		public string DateCreated {
			get {
				if (id_getDateCreated == IntPtr.Zero)
					id_getDateCreated = JNIEnv.GetMethodID (class_ref, "getDateCreated", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDateCreated), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDateModified;
#pragma warning disable 0169
		static Delegate GetGetDateModifiedHandler ()
		{
			if (cb_getDateModified == null)
				cb_getDateModified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateModified);
			return cb_getDateModified;
		}

		static IntPtr n_GetDateModified (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateModified);
		}
#pragma warning restore 0169

		IntPtr id_getDateModified;
		public string DateModified {
			get {
				if (id_getDateModified == IntPtr.Zero)
					id_getDateModified = JNIEnv.GetMethodID (class_ref, "getDateModified", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDateModified), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDatePublished;
#pragma warning disable 0169
		static Delegate GetGetDatePublishedHandler ()
		{
			if (cb_getDatePublished == null)
				cb_getDatePublished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDatePublished);
			return cb_getDatePublished;
		}

		static IntPtr n_GetDatePublished (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DatePublished);
		}
#pragma warning restore 0169

		IntPtr id_getDatePublished;
		public string DatePublished {
			get {
				if (id_getDatePublished == IntPtr.Zero)
					id_getDatePublished = JNIEnv.GetMethodID (class_ref, "getDatePublished", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDatePublished), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		public string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDuration);
			return cb_getDuration;
		}

		static IntPtr n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Duration);
		}
#pragma warning restore 0169

		IntPtr id_getDuration;
		public string Duration {
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDuration), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEmbedUrl;
#pragma warning disable 0169
		static Delegate GetGetEmbedUrlHandler ()
		{
			if (cb_getEmbedUrl == null)
				cb_getEmbedUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmbedUrl);
			return cb_getEmbedUrl;
		}

		static IntPtr n_GetEmbedUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmbedUrl);
		}
#pragma warning restore 0169

		IntPtr id_getEmbedUrl;
		public string EmbedUrl {
			get {
				if (id_getEmbedUrl == IntPtr.Zero)
					id_getEmbedUrl = JNIEnv.GetMethodID (class_ref, "getEmbedUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getEmbedUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEndDate;
#pragma warning disable 0169
		static Delegate GetGetEndDateHandler ()
		{
			if (cb_getEndDate == null)
				cb_getEndDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndDate);
			return cb_getEndDate;
		}

		static IntPtr n_GetEndDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndDate);
		}
#pragma warning restore 0169

		IntPtr id_getEndDate;
		public string EndDate {
			get {
				if (id_getEndDate == IntPtr.Zero)
					id_getEndDate = JNIEnv.GetMethodID (class_ref, "getEndDate", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getEndDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFamilyName;
#pragma warning disable 0169
		static Delegate GetGetFamilyNameHandler ()
		{
			if (cb_getFamilyName == null)
				cb_getFamilyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFamilyName);
			return cb_getFamilyName;
		}

		static IntPtr n_GetFamilyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyName);
		}
#pragma warning restore 0169

		IntPtr id_getFamilyName;
		public string FamilyName {
			get {
				if (id_getFamilyName == IntPtr.Zero)
					id_getFamilyName = JNIEnv.GetMethodID (class_ref, "getFamilyName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getFamilyName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGender;
#pragma warning disable 0169
		static Delegate GetGetGenderHandler ()
		{
			if (cb_getGender == null)
				cb_getGender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGender);
			return cb_getGender;
		}

		static IntPtr n_GetGender (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Gender);
		}
#pragma warning restore 0169

		IntPtr id_getGender;
		public string Gender {
			get {
				if (id_getGender == IntPtr.Zero)
					id_getGender = JNIEnv.GetMethodID (class_ref, "getGender", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getGender), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGeo;
#pragma warning disable 0169
		static Delegate GetGetGeoHandler ()
		{
			if (cb_getGeo == null)
				cb_getGeo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeo);
			return cb_getGeo;
		}

		static IntPtr n_GetGeo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Geo);
		}
#pragma warning restore 0169

		IntPtr id_getGeo;
		public global::Android.Gms.Plus.Model.Moments.IItemScope Geo {
			get {
				if (id_getGeo == IntPtr.Zero)
					id_getGeo = JNIEnv.GetMethodID (class_ref, "getGeo", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getGeo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGivenName;
#pragma warning disable 0169
		static Delegate GetGetGivenNameHandler ()
		{
			if (cb_getGivenName == null)
				cb_getGivenName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGivenName);
			return cb_getGivenName;
		}

		static IntPtr n_GetGivenName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GivenName);
		}
#pragma warning restore 0169

		IntPtr id_getGivenName;
		public string GivenName {
			get {
				if (id_getGivenName == IntPtr.Zero)
					id_getGivenName = JNIEnv.GetMethodID (class_ref, "getGivenName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getGivenName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasAbout;
#pragma warning disable 0169
		static Delegate GetHasAboutHandler ()
		{
			if (cb_hasAbout == null)
				cb_hasAbout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAbout);
			return cb_hasAbout;
		}

		static bool n_HasAbout (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAbout;
		}
#pragma warning restore 0169

		IntPtr id_hasAbout;
		public bool HasAbout {
			get {
				if (id_hasAbout == IntPtr.Zero)
					id_hasAbout = JNIEnv.GetMethodID (class_ref, "hasAbout", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAbout);
			}
		}

		static Delegate cb_hasAdditionalName;
#pragma warning disable 0169
		static Delegate GetHasAdditionalNameHandler ()
		{
			if (cb_hasAdditionalName == null)
				cb_hasAdditionalName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAdditionalName);
			return cb_hasAdditionalName;
		}

		static bool n_HasAdditionalName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAdditionalName;
		}
#pragma warning restore 0169

		IntPtr id_hasAdditionalName;
		public bool HasAdditionalName {
			get {
				if (id_hasAdditionalName == IntPtr.Zero)
					id_hasAdditionalName = JNIEnv.GetMethodID (class_ref, "hasAdditionalName", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAdditionalName);
			}
		}

		static Delegate cb_hasAddress;
#pragma warning disable 0169
		static Delegate GetHasAddressHandler ()
		{
			if (cb_hasAddress == null)
				cb_hasAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAddress);
			return cb_hasAddress;
		}

		static bool n_HasAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAddress;
		}
#pragma warning restore 0169

		IntPtr id_hasAddress;
		public bool HasAddress {
			get {
				if (id_hasAddress == IntPtr.Zero)
					id_hasAddress = JNIEnv.GetMethodID (class_ref, "hasAddress", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAddress);
			}
		}

		static Delegate cb_hasAddressCountry;
#pragma warning disable 0169
		static Delegate GetHasAddressCountryHandler ()
		{
			if (cb_hasAddressCountry == null)
				cb_hasAddressCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAddressCountry);
			return cb_hasAddressCountry;
		}

		static bool n_HasAddressCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAddressCountry;
		}
#pragma warning restore 0169

		IntPtr id_hasAddressCountry;
		public bool HasAddressCountry {
			get {
				if (id_hasAddressCountry == IntPtr.Zero)
					id_hasAddressCountry = JNIEnv.GetMethodID (class_ref, "hasAddressCountry", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAddressCountry);
			}
		}

		static Delegate cb_hasAddressLocality;
#pragma warning disable 0169
		static Delegate GetHasAddressLocalityHandler ()
		{
			if (cb_hasAddressLocality == null)
				cb_hasAddressLocality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAddressLocality);
			return cb_hasAddressLocality;
		}

		static bool n_HasAddressLocality (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAddressLocality;
		}
#pragma warning restore 0169

		IntPtr id_hasAddressLocality;
		public bool HasAddressLocality {
			get {
				if (id_hasAddressLocality == IntPtr.Zero)
					id_hasAddressLocality = JNIEnv.GetMethodID (class_ref, "hasAddressLocality", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAddressLocality);
			}
		}

		static Delegate cb_hasAddressRegion;
#pragma warning disable 0169
		static Delegate GetHasAddressRegionHandler ()
		{
			if (cb_hasAddressRegion == null)
				cb_hasAddressRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAddressRegion);
			return cb_hasAddressRegion;
		}

		static bool n_HasAddressRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAddressRegion;
		}
#pragma warning restore 0169

		IntPtr id_hasAddressRegion;
		public bool HasAddressRegion {
			get {
				if (id_hasAddressRegion == IntPtr.Zero)
					id_hasAddressRegion = JNIEnv.GetMethodID (class_ref, "hasAddressRegion", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAddressRegion);
			}
		}

		static Delegate cb_hasAssociated_media;
#pragma warning disable 0169
		static Delegate GetHasAssociated_mediaHandler ()
		{
			if (cb_hasAssociated_media == null)
				cb_hasAssociated_media = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAssociated_media);
			return cb_hasAssociated_media;
		}

		static bool n_HasAssociated_media (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAssociated_media;
		}
#pragma warning restore 0169

		IntPtr id_hasAssociated_media;
		public bool HasAssociated_media {
			get {
				if (id_hasAssociated_media == IntPtr.Zero)
					id_hasAssociated_media = JNIEnv.GetMethodID (class_ref, "hasAssociated_media", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAssociated_media);
			}
		}

		static Delegate cb_hasAttendeeCount;
#pragma warning disable 0169
		static Delegate GetHasAttendeeCountHandler ()
		{
			if (cb_hasAttendeeCount == null)
				cb_hasAttendeeCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAttendeeCount);
			return cb_hasAttendeeCount;
		}

		static bool n_HasAttendeeCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAttendeeCount;
		}
#pragma warning restore 0169

		IntPtr id_hasAttendeeCount;
		public bool HasAttendeeCount {
			get {
				if (id_hasAttendeeCount == IntPtr.Zero)
					id_hasAttendeeCount = JNIEnv.GetMethodID (class_ref, "hasAttendeeCount", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAttendeeCount);
			}
		}

		static Delegate cb_hasAttendees;
#pragma warning disable 0169
		static Delegate GetHasAttendeesHandler ()
		{
			if (cb_hasAttendees == null)
				cb_hasAttendees = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAttendees);
			return cb_hasAttendees;
		}

		static bool n_HasAttendees (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAttendees;
		}
#pragma warning restore 0169

		IntPtr id_hasAttendees;
		public bool HasAttendees {
			get {
				if (id_hasAttendees == IntPtr.Zero)
					id_hasAttendees = JNIEnv.GetMethodID (class_ref, "hasAttendees", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAttendees);
			}
		}

		static Delegate cb_hasAudio;
#pragma warning disable 0169
		static Delegate GetHasAudioHandler ()
		{
			if (cb_hasAudio == null)
				cb_hasAudio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAudio);
			return cb_hasAudio;
		}

		static bool n_HasAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAudio;
		}
#pragma warning restore 0169

		IntPtr id_hasAudio;
		public bool HasAudio {
			get {
				if (id_hasAudio == IntPtr.Zero)
					id_hasAudio = JNIEnv.GetMethodID (class_ref, "hasAudio", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAudio);
			}
		}

		static Delegate cb_hasAuthor;
#pragma warning disable 0169
		static Delegate GetHasAuthorHandler ()
		{
			if (cb_hasAuthor == null)
				cb_hasAuthor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAuthor);
			return cb_hasAuthor;
		}

		static bool n_HasAuthor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAuthor;
		}
#pragma warning restore 0169

		IntPtr id_hasAuthor;
		public bool HasAuthor {
			get {
				if (id_hasAuthor == IntPtr.Zero)
					id_hasAuthor = JNIEnv.GetMethodID (class_ref, "hasAuthor", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAuthor);
			}
		}

		static Delegate cb_hasBestRating;
#pragma warning disable 0169
		static Delegate GetHasBestRatingHandler ()
		{
			if (cb_hasBestRating == null)
				cb_hasBestRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBestRating);
			return cb_hasBestRating;
		}

		static bool n_HasBestRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBestRating;
		}
#pragma warning restore 0169

		IntPtr id_hasBestRating;
		public bool HasBestRating {
			get {
				if (id_hasBestRating == IntPtr.Zero)
					id_hasBestRating = JNIEnv.GetMethodID (class_ref, "hasBestRating", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasBestRating);
			}
		}

		static Delegate cb_hasBirthDate;
#pragma warning disable 0169
		static Delegate GetHasBirthDateHandler ()
		{
			if (cb_hasBirthDate == null)
				cb_hasBirthDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBirthDate);
			return cb_hasBirthDate;
		}

		static bool n_HasBirthDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBirthDate;
		}
#pragma warning restore 0169

		IntPtr id_hasBirthDate;
		public bool HasBirthDate {
			get {
				if (id_hasBirthDate == IntPtr.Zero)
					id_hasBirthDate = JNIEnv.GetMethodID (class_ref, "hasBirthDate", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasBirthDate);
			}
		}

		static Delegate cb_hasByArtist;
#pragma warning disable 0169
		static Delegate GetHasByArtistHandler ()
		{
			if (cb_hasByArtist == null)
				cb_hasByArtist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasByArtist);
			return cb_hasByArtist;
		}

		static bool n_HasByArtist (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasByArtist;
		}
#pragma warning restore 0169

		IntPtr id_hasByArtist;
		public bool HasByArtist {
			get {
				if (id_hasByArtist == IntPtr.Zero)
					id_hasByArtist = JNIEnv.GetMethodID (class_ref, "hasByArtist", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasByArtist);
			}
		}

		static Delegate cb_hasCaption;
#pragma warning disable 0169
		static Delegate GetHasCaptionHandler ()
		{
			if (cb_hasCaption == null)
				cb_hasCaption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCaption);
			return cb_hasCaption;
		}

		static bool n_HasCaption (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCaption;
		}
#pragma warning restore 0169

		IntPtr id_hasCaption;
		public bool HasCaption {
			get {
				if (id_hasCaption == IntPtr.Zero)
					id_hasCaption = JNIEnv.GetMethodID (class_ref, "hasCaption", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasCaption);
			}
		}

		static Delegate cb_hasContentSize;
#pragma warning disable 0169
		static Delegate GetHasContentSizeHandler ()
		{
			if (cb_hasContentSize == null)
				cb_hasContentSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasContentSize);
			return cb_hasContentSize;
		}

		static bool n_HasContentSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasContentSize;
		}
#pragma warning restore 0169

		IntPtr id_hasContentSize;
		public bool HasContentSize {
			get {
				if (id_hasContentSize == IntPtr.Zero)
					id_hasContentSize = JNIEnv.GetMethodID (class_ref, "hasContentSize", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasContentSize);
			}
		}

		static Delegate cb_hasContentUrl;
#pragma warning disable 0169
		static Delegate GetHasContentUrlHandler ()
		{
			if (cb_hasContentUrl == null)
				cb_hasContentUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasContentUrl);
			return cb_hasContentUrl;
		}

		static bool n_HasContentUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasContentUrl;
		}
#pragma warning restore 0169

		IntPtr id_hasContentUrl;
		public bool HasContentUrl {
			get {
				if (id_hasContentUrl == IntPtr.Zero)
					id_hasContentUrl = JNIEnv.GetMethodID (class_ref, "hasContentUrl", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasContentUrl);
			}
		}

		static Delegate cb_hasContributor;
#pragma warning disable 0169
		static Delegate GetHasContributorHandler ()
		{
			if (cb_hasContributor == null)
				cb_hasContributor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasContributor);
			return cb_hasContributor;
		}

		static bool n_HasContributor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasContributor;
		}
#pragma warning restore 0169

		IntPtr id_hasContributor;
		public bool HasContributor {
			get {
				if (id_hasContributor == IntPtr.Zero)
					id_hasContributor = JNIEnv.GetMethodID (class_ref, "hasContributor", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasContributor);
			}
		}

		static Delegate cb_hasDateCreated;
#pragma warning disable 0169
		static Delegate GetHasDateCreatedHandler ()
		{
			if (cb_hasDateCreated == null)
				cb_hasDateCreated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDateCreated);
			return cb_hasDateCreated;
		}

		static bool n_HasDateCreated (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDateCreated;
		}
#pragma warning restore 0169

		IntPtr id_hasDateCreated;
		public bool HasDateCreated {
			get {
				if (id_hasDateCreated == IntPtr.Zero)
					id_hasDateCreated = JNIEnv.GetMethodID (class_ref, "hasDateCreated", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasDateCreated);
			}
		}

		static Delegate cb_hasDateModified;
#pragma warning disable 0169
		static Delegate GetHasDateModifiedHandler ()
		{
			if (cb_hasDateModified == null)
				cb_hasDateModified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDateModified);
			return cb_hasDateModified;
		}

		static bool n_HasDateModified (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDateModified;
		}
#pragma warning restore 0169

		IntPtr id_hasDateModified;
		public bool HasDateModified {
			get {
				if (id_hasDateModified == IntPtr.Zero)
					id_hasDateModified = JNIEnv.GetMethodID (class_ref, "hasDateModified", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasDateModified);
			}
		}

		static Delegate cb_hasDatePublished;
#pragma warning disable 0169
		static Delegate GetHasDatePublishedHandler ()
		{
			if (cb_hasDatePublished == null)
				cb_hasDatePublished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDatePublished);
			return cb_hasDatePublished;
		}

		static bool n_HasDatePublished (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDatePublished;
		}
#pragma warning restore 0169

		IntPtr id_hasDatePublished;
		public bool HasDatePublished {
			get {
				if (id_hasDatePublished == IntPtr.Zero)
					id_hasDatePublished = JNIEnv.GetMethodID (class_ref, "hasDatePublished", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasDatePublished);
			}
		}

		static Delegate cb_hasDescription;
#pragma warning disable 0169
		static Delegate GetHasDescriptionHandler ()
		{
			if (cb_hasDescription == null)
				cb_hasDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDescription);
			return cb_hasDescription;
		}

		static bool n_HasDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDescription;
		}
#pragma warning restore 0169

		IntPtr id_hasDescription;
		public bool HasDescription {
			get {
				if (id_hasDescription == IntPtr.Zero)
					id_hasDescription = JNIEnv.GetMethodID (class_ref, "hasDescription", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasDescription);
			}
		}

		static Delegate cb_hasDuration;
#pragma warning disable 0169
		static Delegate GetHasDurationHandler ()
		{
			if (cb_hasDuration == null)
				cb_hasDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDuration);
			return cb_hasDuration;
		}

		static bool n_HasDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDuration;
		}
#pragma warning restore 0169

		IntPtr id_hasDuration;
		public bool HasDuration {
			get {
				if (id_hasDuration == IntPtr.Zero)
					id_hasDuration = JNIEnv.GetMethodID (class_ref, "hasDuration", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasDuration);
			}
		}

		static Delegate cb_hasEmbedUrl;
#pragma warning disable 0169
		static Delegate GetHasEmbedUrlHandler ()
		{
			if (cb_hasEmbedUrl == null)
				cb_hasEmbedUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasEmbedUrl);
			return cb_hasEmbedUrl;
		}

		static bool n_HasEmbedUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasEmbedUrl;
		}
#pragma warning restore 0169

		IntPtr id_hasEmbedUrl;
		public bool HasEmbedUrl {
			get {
				if (id_hasEmbedUrl == IntPtr.Zero)
					id_hasEmbedUrl = JNIEnv.GetMethodID (class_ref, "hasEmbedUrl", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasEmbedUrl);
			}
		}

		static Delegate cb_hasEndDate;
#pragma warning disable 0169
		static Delegate GetHasEndDateHandler ()
		{
			if (cb_hasEndDate == null)
				cb_hasEndDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasEndDate);
			return cb_hasEndDate;
		}

		static bool n_HasEndDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasEndDate;
		}
#pragma warning restore 0169

		IntPtr id_hasEndDate;
		public bool HasEndDate {
			get {
				if (id_hasEndDate == IntPtr.Zero)
					id_hasEndDate = JNIEnv.GetMethodID (class_ref, "hasEndDate", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasEndDate);
			}
		}

		static Delegate cb_hasFamilyName;
#pragma warning disable 0169
		static Delegate GetHasFamilyNameHandler ()
		{
			if (cb_hasFamilyName == null)
				cb_hasFamilyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasFamilyName);
			return cb_hasFamilyName;
		}

		static bool n_HasFamilyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFamilyName;
		}
#pragma warning restore 0169

		IntPtr id_hasFamilyName;
		public bool HasFamilyName {
			get {
				if (id_hasFamilyName == IntPtr.Zero)
					id_hasFamilyName = JNIEnv.GetMethodID (class_ref, "hasFamilyName", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasFamilyName);
			}
		}

		static Delegate cb_hasGender;
#pragma warning disable 0169
		static Delegate GetHasGenderHandler ()
		{
			if (cb_hasGender == null)
				cb_hasGender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasGender);
			return cb_hasGender;
		}

		static bool n_HasGender (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasGender;
		}
#pragma warning restore 0169

		IntPtr id_hasGender;
		public bool HasGender {
			get {
				if (id_hasGender == IntPtr.Zero)
					id_hasGender = JNIEnv.GetMethodID (class_ref, "hasGender", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasGender);
			}
		}

		static Delegate cb_hasGeo;
#pragma warning disable 0169
		static Delegate GetHasGeoHandler ()
		{
			if (cb_hasGeo == null)
				cb_hasGeo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasGeo);
			return cb_hasGeo;
		}

		static bool n_HasGeo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasGeo;
		}
#pragma warning restore 0169

		IntPtr id_hasGeo;
		public bool HasGeo {
			get {
				if (id_hasGeo == IntPtr.Zero)
					id_hasGeo = JNIEnv.GetMethodID (class_ref, "hasGeo", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasGeo);
			}
		}

		static Delegate cb_hasGivenName;
#pragma warning disable 0169
		static Delegate GetHasGivenNameHandler ()
		{
			if (cb_hasGivenName == null)
				cb_hasGivenName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasGivenName);
			return cb_hasGivenName;
		}

		static bool n_HasGivenName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasGivenName;
		}
#pragma warning restore 0169

		IntPtr id_hasGivenName;
		public bool HasGivenName {
			get {
				if (id_hasGivenName == IntPtr.Zero)
					id_hasGivenName = JNIEnv.GetMethodID (class_ref, "hasGivenName", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasGivenName);
			}
		}

		static Delegate cb_hasHeight;
#pragma warning disable 0169
		static Delegate GetHasHeightHandler ()
		{
			if (cb_hasHeight == null)
				cb_hasHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHeight);
			return cb_hasHeight;
		}

		static bool n_HasHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHeight;
		}
#pragma warning restore 0169

		IntPtr id_hasHeight;
		public bool HasHeight {
			get {
				if (id_hasHeight == IntPtr.Zero)
					id_hasHeight = JNIEnv.GetMethodID (class_ref, "hasHeight", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasHeight);
			}
		}

		static Delegate cb_hasId;
#pragma warning disable 0169
		static Delegate GetHasIdHandler ()
		{
			if (cb_hasId == null)
				cb_hasId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasId);
			return cb_hasId;
		}

		static bool n_HasId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasId;
		}
#pragma warning restore 0169

		IntPtr id_hasId;
		public bool HasId {
			get {
				if (id_hasId == IntPtr.Zero)
					id_hasId = JNIEnv.GetMethodID (class_ref, "hasId", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasId);
			}
		}

		static Delegate cb_hasImage;
#pragma warning disable 0169
		static Delegate GetHasImageHandler ()
		{
			if (cb_hasImage == null)
				cb_hasImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasImage);
			return cb_hasImage;
		}

		static bool n_HasImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasImage;
		}
#pragma warning restore 0169

		IntPtr id_hasImage;
		public bool HasImage {
			get {
				if (id_hasImage == IntPtr.Zero)
					id_hasImage = JNIEnv.GetMethodID (class_ref, "hasImage", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasImage);
			}
		}

		static Delegate cb_hasInAlbum;
#pragma warning disable 0169
		static Delegate GetHasInAlbumHandler ()
		{
			if (cb_hasInAlbum == null)
				cb_hasInAlbum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasInAlbum);
			return cb_hasInAlbum;
		}

		static bool n_HasInAlbum (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasInAlbum;
		}
#pragma warning restore 0169

		IntPtr id_hasInAlbum;
		public bool HasInAlbum {
			get {
				if (id_hasInAlbum == IntPtr.Zero)
					id_hasInAlbum = JNIEnv.GetMethodID (class_ref, "hasInAlbum", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasInAlbum);
			}
		}

		static Delegate cb_hasLatitude;
#pragma warning disable 0169
		static Delegate GetHasLatitudeHandler ()
		{
			if (cb_hasLatitude == null)
				cb_hasLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasLatitude);
			return cb_hasLatitude;
		}

		static bool n_HasLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLatitude;
		}
#pragma warning restore 0169

		IntPtr id_hasLatitude;
		public bool HasLatitude {
			get {
				if (id_hasLatitude == IntPtr.Zero)
					id_hasLatitude = JNIEnv.GetMethodID (class_ref, "hasLatitude", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasLatitude);
			}
		}

		static Delegate cb_hasLocation;
#pragma warning disable 0169
		static Delegate GetHasLocationHandler ()
		{
			if (cb_hasLocation == null)
				cb_hasLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasLocation);
			return cb_hasLocation;
		}

		static bool n_HasLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLocation;
		}
#pragma warning restore 0169

		IntPtr id_hasLocation;
		public bool HasLocation {
			get {
				if (id_hasLocation == IntPtr.Zero)
					id_hasLocation = JNIEnv.GetMethodID (class_ref, "hasLocation", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasLocation);
			}
		}

		static Delegate cb_hasLongitude;
#pragma warning disable 0169
		static Delegate GetHasLongitudeHandler ()
		{
			if (cb_hasLongitude == null)
				cb_hasLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasLongitude);
			return cb_hasLongitude;
		}

		static bool n_HasLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLongitude;
		}
#pragma warning restore 0169

		IntPtr id_hasLongitude;
		public bool HasLongitude {
			get {
				if (id_hasLongitude == IntPtr.Zero)
					id_hasLongitude = JNIEnv.GetMethodID (class_ref, "hasLongitude", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasLongitude);
			}
		}

		static Delegate cb_hasName;
#pragma warning disable 0169
		static Delegate GetHasNameHandler ()
		{
			if (cb_hasName == null)
				cb_hasName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasName);
			return cb_hasName;
		}

		static bool n_HasName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasName;
		}
#pragma warning restore 0169

		IntPtr id_hasName;
		public bool HasName {
			get {
				if (id_hasName == IntPtr.Zero)
					id_hasName = JNIEnv.GetMethodID (class_ref, "hasName", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasName);
			}
		}

		static Delegate cb_hasPartOfTVSeries;
#pragma warning disable 0169
		static Delegate GetHasPartOfTVSeriesHandler ()
		{
			if (cb_hasPartOfTVSeries == null)
				cb_hasPartOfTVSeries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPartOfTVSeries);
			return cb_hasPartOfTVSeries;
		}

		static bool n_HasPartOfTVSeries (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPartOfTVSeries;
		}
#pragma warning restore 0169

		IntPtr id_hasPartOfTVSeries;
		public bool HasPartOfTVSeries {
			get {
				if (id_hasPartOfTVSeries == IntPtr.Zero)
					id_hasPartOfTVSeries = JNIEnv.GetMethodID (class_ref, "hasPartOfTVSeries", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPartOfTVSeries);
			}
		}

		static Delegate cb_hasPerformers;
#pragma warning disable 0169
		static Delegate GetHasPerformersHandler ()
		{
			if (cb_hasPerformers == null)
				cb_hasPerformers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPerformers);
			return cb_hasPerformers;
		}

		static bool n_HasPerformers (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPerformers;
		}
#pragma warning restore 0169

		IntPtr id_hasPerformers;
		public bool HasPerformers {
			get {
				if (id_hasPerformers == IntPtr.Zero)
					id_hasPerformers = JNIEnv.GetMethodID (class_ref, "hasPerformers", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPerformers);
			}
		}

		static Delegate cb_hasPlayerType;
#pragma warning disable 0169
		static Delegate GetHasPlayerTypeHandler ()
		{
			if (cb_hasPlayerType == null)
				cb_hasPlayerType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPlayerType);
			return cb_hasPlayerType;
		}

		static bool n_HasPlayerType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPlayerType;
		}
#pragma warning restore 0169

		IntPtr id_hasPlayerType;
		public bool HasPlayerType {
			get {
				if (id_hasPlayerType == IntPtr.Zero)
					id_hasPlayerType = JNIEnv.GetMethodID (class_ref, "hasPlayerType", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPlayerType);
			}
		}

		static Delegate cb_hasPostalCode;
#pragma warning disable 0169
		static Delegate GetHasPostalCodeHandler ()
		{
			if (cb_hasPostalCode == null)
				cb_hasPostalCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPostalCode);
			return cb_hasPostalCode;
		}

		static bool n_HasPostalCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPostalCode;
		}
#pragma warning restore 0169

		IntPtr id_hasPostalCode;
		public bool HasPostalCode {
			get {
				if (id_hasPostalCode == IntPtr.Zero)
					id_hasPostalCode = JNIEnv.GetMethodID (class_ref, "hasPostalCode", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPostalCode);
			}
		}

		static Delegate cb_hasPostOfficeBoxNumber;
#pragma warning disable 0169
		static Delegate GetHasPostOfficeBoxNumberHandler ()
		{
			if (cb_hasPostOfficeBoxNumber == null)
				cb_hasPostOfficeBoxNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPostOfficeBoxNumber);
			return cb_hasPostOfficeBoxNumber;
		}

		static bool n_HasPostOfficeBoxNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPostOfficeBoxNumber;
		}
#pragma warning restore 0169

		IntPtr id_hasPostOfficeBoxNumber;
		public bool HasPostOfficeBoxNumber {
			get {
				if (id_hasPostOfficeBoxNumber == IntPtr.Zero)
					id_hasPostOfficeBoxNumber = JNIEnv.GetMethodID (class_ref, "hasPostOfficeBoxNumber", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPostOfficeBoxNumber);
			}
		}

		static Delegate cb_hasRatingValue;
#pragma warning disable 0169
		static Delegate GetHasRatingValueHandler ()
		{
			if (cb_hasRatingValue == null)
				cb_hasRatingValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasRatingValue);
			return cb_hasRatingValue;
		}

		static bool n_HasRatingValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRatingValue;
		}
#pragma warning restore 0169

		IntPtr id_hasRatingValue;
		public bool HasRatingValue {
			get {
				if (id_hasRatingValue == IntPtr.Zero)
					id_hasRatingValue = JNIEnv.GetMethodID (class_ref, "hasRatingValue", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasRatingValue);
			}
		}

		static Delegate cb_hasReviewRating;
#pragma warning disable 0169
		static Delegate GetHasReviewRatingHandler ()
		{
			if (cb_hasReviewRating == null)
				cb_hasReviewRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasReviewRating);
			return cb_hasReviewRating;
		}

		static bool n_HasReviewRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasReviewRating;
		}
#pragma warning restore 0169

		IntPtr id_hasReviewRating;
		public bool HasReviewRating {
			get {
				if (id_hasReviewRating == IntPtr.Zero)
					id_hasReviewRating = JNIEnv.GetMethodID (class_ref, "hasReviewRating", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasReviewRating);
			}
		}

		static Delegate cb_hasStartDate;
#pragma warning disable 0169
		static Delegate GetHasStartDateHandler ()
		{
			if (cb_hasStartDate == null)
				cb_hasStartDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasStartDate);
			return cb_hasStartDate;
		}

		static bool n_HasStartDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasStartDate;
		}
#pragma warning restore 0169

		IntPtr id_hasStartDate;
		public bool HasStartDate {
			get {
				if (id_hasStartDate == IntPtr.Zero)
					id_hasStartDate = JNIEnv.GetMethodID (class_ref, "hasStartDate", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasStartDate);
			}
		}

		static Delegate cb_hasStreetAddress;
#pragma warning disable 0169
		static Delegate GetHasStreetAddressHandler ()
		{
			if (cb_hasStreetAddress == null)
				cb_hasStreetAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasStreetAddress);
			return cb_hasStreetAddress;
		}

		static bool n_HasStreetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasStreetAddress;
		}
#pragma warning restore 0169

		IntPtr id_hasStreetAddress;
		public bool HasStreetAddress {
			get {
				if (id_hasStreetAddress == IntPtr.Zero)
					id_hasStreetAddress = JNIEnv.GetMethodID (class_ref, "hasStreetAddress", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasStreetAddress);
			}
		}

		static Delegate cb_hasText;
#pragma warning disable 0169
		static Delegate GetHasTextHandler ()
		{
			if (cb_hasText == null)
				cb_hasText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasText);
			return cb_hasText;
		}

		static bool n_HasText (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasText;
		}
#pragma warning restore 0169

		IntPtr id_hasText;
		public bool HasText {
			get {
				if (id_hasText == IntPtr.Zero)
					id_hasText = JNIEnv.GetMethodID (class_ref, "hasText", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasText);
			}
		}

		static Delegate cb_hasThumbnail;
#pragma warning disable 0169
		static Delegate GetHasThumbnailHandler ()
		{
			if (cb_hasThumbnail == null)
				cb_hasThumbnail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasThumbnail);
			return cb_hasThumbnail;
		}

		static bool n_HasThumbnail (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasThumbnail;
		}
#pragma warning restore 0169

		IntPtr id_hasThumbnail;
		public bool HasThumbnail {
			get {
				if (id_hasThumbnail == IntPtr.Zero)
					id_hasThumbnail = JNIEnv.GetMethodID (class_ref, "hasThumbnail", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasThumbnail);
			}
		}

		static Delegate cb_hasThumbnailUrl;
#pragma warning disable 0169
		static Delegate GetHasThumbnailUrlHandler ()
		{
			if (cb_hasThumbnailUrl == null)
				cb_hasThumbnailUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasThumbnailUrl);
			return cb_hasThumbnailUrl;
		}

		static bool n_HasThumbnailUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasThumbnailUrl;
		}
#pragma warning restore 0169

		IntPtr id_hasThumbnailUrl;
		public bool HasThumbnailUrl {
			get {
				if (id_hasThumbnailUrl == IntPtr.Zero)
					id_hasThumbnailUrl = JNIEnv.GetMethodID (class_ref, "hasThumbnailUrl", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasThumbnailUrl);
			}
		}

		static Delegate cb_hasTickerSymbol;
#pragma warning disable 0169
		static Delegate GetHasTickerSymbolHandler ()
		{
			if (cb_hasTickerSymbol == null)
				cb_hasTickerSymbol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTickerSymbol);
			return cb_hasTickerSymbol;
		}

		static bool n_HasTickerSymbol (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTickerSymbol;
		}
#pragma warning restore 0169

		IntPtr id_hasTickerSymbol;
		public bool HasTickerSymbol {
			get {
				if (id_hasTickerSymbol == IntPtr.Zero)
					id_hasTickerSymbol = JNIEnv.GetMethodID (class_ref, "hasTickerSymbol", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasTickerSymbol);
			}
		}

		static Delegate cb_hasType;
#pragma warning disable 0169
		static Delegate GetHasTypeHandler ()
		{
			if (cb_hasType == null)
				cb_hasType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasType);
			return cb_hasType;
		}

		static bool n_HasType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasType;
		}
#pragma warning restore 0169

		IntPtr id_hasType;
		public bool HasType {
			get {
				if (id_hasType == IntPtr.Zero)
					id_hasType = JNIEnv.GetMethodID (class_ref, "hasType", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasType);
			}
		}

		static Delegate cb_hasUrl;
#pragma warning disable 0169
		static Delegate GetHasUrlHandler ()
		{
			if (cb_hasUrl == null)
				cb_hasUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasUrl);
			return cb_hasUrl;
		}

		static bool n_HasUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUrl;
		}
#pragma warning restore 0169

		IntPtr id_hasUrl;
		public bool HasUrl {
			get {
				if (id_hasUrl == IntPtr.Zero)
					id_hasUrl = JNIEnv.GetMethodID (class_ref, "hasUrl", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasUrl);
			}
		}

		static Delegate cb_hasWidth;
#pragma warning disable 0169
		static Delegate GetHasWidthHandler ()
		{
			if (cb_hasWidth == null)
				cb_hasWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasWidth);
			return cb_hasWidth;
		}

		static bool n_HasWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasWidth;
		}
#pragma warning restore 0169

		IntPtr id_hasWidth;
		public bool HasWidth {
			get {
				if (id_hasWidth == IntPtr.Zero)
					id_hasWidth = JNIEnv.GetMethodID (class_ref, "hasWidth", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasWidth);
			}
		}

		static Delegate cb_hasWorstRating;
#pragma warning disable 0169
		static Delegate GetHasWorstRatingHandler ()
		{
			if (cb_hasWorstRating == null)
				cb_hasWorstRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasWorstRating);
			return cb_hasWorstRating;
		}

		static bool n_HasWorstRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasWorstRating;
		}
#pragma warning restore 0169

		IntPtr id_hasWorstRating;
		public bool HasWorstRating {
			get {
				if (id_hasWorstRating == IntPtr.Zero)
					id_hasWorstRating = JNIEnv.GetMethodID (class_ref, "hasWorstRating", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasWorstRating);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeight);
			return cb_getHeight;
		}

		static IntPtr n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Height);
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public string Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getHeight), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Image);
		}
#pragma warning restore 0169

		IntPtr id_getImage;
		public string Image {
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInAlbum;
#pragma warning disable 0169
		static Delegate GetGetInAlbumHandler ()
		{
			if (cb_getInAlbum == null)
				cb_getInAlbum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInAlbum);
			return cb_getInAlbum;
		}

		static IntPtr n_GetInAlbum (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InAlbum);
		}
#pragma warning restore 0169

		IntPtr id_getInAlbum;
		public global::Android.Gms.Plus.Model.Moments.IItemScope InAlbum {
			get {
				if (id_getInAlbum == IntPtr.Zero)
					id_getInAlbum = JNIEnv.GetMethodID (class_ref, "getInAlbum", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getInAlbum), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		IntPtr id_getLatitude;
		public double Latitude {
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				return JNIEnv.CallDoubleMethod (Handle, id_getLatitude);
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		IntPtr id_getLocation;
		public global::Android.Gms.Plus.Model.Moments.IItemScope Location {
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		IntPtr id_getLongitude;
		public double Longitude {
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				return JNIEnv.CallDoubleMethod (Handle, id_getLongitude);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPartOfTVSeries;
#pragma warning disable 0169
		static Delegate GetGetPartOfTVSeriesHandler ()
		{
			if (cb_getPartOfTVSeries == null)
				cb_getPartOfTVSeries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPartOfTVSeries);
			return cb_getPartOfTVSeries;
		}

		static IntPtr n_GetPartOfTVSeries (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PartOfTVSeries);
		}
#pragma warning restore 0169

		IntPtr id_getPartOfTVSeries;
		public global::Android.Gms.Plus.Model.Moments.IItemScope PartOfTVSeries {
			get {
				if (id_getPartOfTVSeries == IntPtr.Zero)
					id_getPartOfTVSeries = JNIEnv.GetMethodID (class_ref, "getPartOfTVSeries", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getPartOfTVSeries), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPerformers;
#pragma warning disable 0169
		static Delegate GetGetPerformersHandler ()
		{
			if (cb_getPerformers == null)
				cb_getPerformers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPerformers);
			return cb_getPerformers;
		}

		static IntPtr n_GetPerformers (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.ToLocalJniHandle (__this.Performers);
		}
#pragma warning restore 0169

		IntPtr id_getPerformers;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.Moments.IItemScope> Performers {
			get {
				if (id_getPerformers == IntPtr.Zero)
					id_getPerformers = JNIEnv.GetMethodID (class_ref, "getPerformers", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.Moments.IItemScope>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getPerformers), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlayerType;
#pragma warning disable 0169
		static Delegate GetGetPlayerTypeHandler ()
		{
			if (cb_getPlayerType == null)
				cb_getPlayerType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerType);
			return cb_getPlayerType;
		}

		static IntPtr n_GetPlayerType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerType);
		}
#pragma warning restore 0169

		IntPtr id_getPlayerType;
		public string PlayerType {
			get {
				if (id_getPlayerType == IntPtr.Zero)
					id_getPlayerType = JNIEnv.GetMethodID (class_ref, "getPlayerType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPlayerType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPostalCode;
#pragma warning disable 0169
		static Delegate GetGetPostalCodeHandler ()
		{
			if (cb_getPostalCode == null)
				cb_getPostalCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostalCode);
			return cb_getPostalCode;
		}

		static IntPtr n_GetPostalCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PostalCode);
		}
#pragma warning restore 0169

		IntPtr id_getPostalCode;
		public string PostalCode {
			get {
				if (id_getPostalCode == IntPtr.Zero)
					id_getPostalCode = JNIEnv.GetMethodID (class_ref, "getPostalCode", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPostalCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPostOfficeBoxNumber;
#pragma warning disable 0169
		static Delegate GetGetPostOfficeBoxNumberHandler ()
		{
			if (cb_getPostOfficeBoxNumber == null)
				cb_getPostOfficeBoxNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostOfficeBoxNumber);
			return cb_getPostOfficeBoxNumber;
		}

		static IntPtr n_GetPostOfficeBoxNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PostOfficeBoxNumber);
		}
#pragma warning restore 0169

		IntPtr id_getPostOfficeBoxNumber;
		public string PostOfficeBoxNumber {
			get {
				if (id_getPostOfficeBoxNumber == IntPtr.Zero)
					id_getPostOfficeBoxNumber = JNIEnv.GetMethodID (class_ref, "getPostOfficeBoxNumber", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPostOfficeBoxNumber), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRatingValue;
#pragma warning disable 0169
		static Delegate GetGetRatingValueHandler ()
		{
			if (cb_getRatingValue == null)
				cb_getRatingValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRatingValue);
			return cb_getRatingValue;
		}

		static IntPtr n_GetRatingValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RatingValue);
		}
#pragma warning restore 0169

		IntPtr id_getRatingValue;
		public string RatingValue {
			get {
				if (id_getRatingValue == IntPtr.Zero)
					id_getRatingValue = JNIEnv.GetMethodID (class_ref, "getRatingValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRatingValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReviewRating;
#pragma warning disable 0169
		static Delegate GetGetReviewRatingHandler ()
		{
			if (cb_getReviewRating == null)
				cb_getReviewRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReviewRating);
			return cb_getReviewRating;
		}

		static IntPtr n_GetReviewRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReviewRating);
		}
#pragma warning restore 0169

		IntPtr id_getReviewRating;
		public global::Android.Gms.Plus.Model.Moments.IItemScope ReviewRating {
			get {
				if (id_getReviewRating == IntPtr.Zero)
					id_getReviewRating = JNIEnv.GetMethodID (class_ref, "getReviewRating", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getReviewRating), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStartDate;
#pragma warning disable 0169
		static Delegate GetGetStartDateHandler ()
		{
			if (cb_getStartDate == null)
				cb_getStartDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartDate);
			return cb_getStartDate;
		}

		static IntPtr n_GetStartDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartDate);
		}
#pragma warning restore 0169

		IntPtr id_getStartDate;
		public string StartDate {
			get {
				if (id_getStartDate == IntPtr.Zero)
					id_getStartDate = JNIEnv.GetMethodID (class_ref, "getStartDate", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getStartDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStreetAddress;
#pragma warning disable 0169
		static Delegate GetGetStreetAddressHandler ()
		{
			if (cb_getStreetAddress == null)
				cb_getStreetAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreetAddress);
			return cb_getStreetAddress;
		}

		static IntPtr n_GetStreetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreetAddress);
		}
#pragma warning restore 0169

		IntPtr id_getStreetAddress;
		public string StreetAddress {
			get {
				if (id_getStreetAddress == IntPtr.Zero)
					id_getStreetAddress = JNIEnv.GetMethodID (class_ref, "getStreetAddress", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getStreetAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		IntPtr id_getText;
		public string Text {
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThumbnail;
#pragma warning disable 0169
		static Delegate GetGetThumbnailHandler ()
		{
			if (cb_getThumbnail == null)
				cb_getThumbnail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbnail);
			return cb_getThumbnail;
		}

		static IntPtr n_GetThumbnail (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Thumbnail);
		}
#pragma warning restore 0169

		IntPtr id_getThumbnail;
		public global::Android.Gms.Plus.Model.Moments.IItemScope Thumbnail {
			get {
				if (id_getThumbnail == IntPtr.Zero)
					id_getThumbnail = JNIEnv.GetMethodID (class_ref, "getThumbnail", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getThumbnail), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThumbnailUrl;
#pragma warning disable 0169
		static Delegate GetGetThumbnailUrlHandler ()
		{
			if (cb_getThumbnailUrl == null)
				cb_getThumbnailUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbnailUrl);
			return cb_getThumbnailUrl;
		}

		static IntPtr n_GetThumbnailUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThumbnailUrl);
		}
#pragma warning restore 0169

		IntPtr id_getThumbnailUrl;
		public string ThumbnailUrl {
			get {
				if (id_getThumbnailUrl == IntPtr.Zero)
					id_getThumbnailUrl = JNIEnv.GetMethodID (class_ref, "getThumbnailUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getThumbnailUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTickerSymbol;
#pragma warning disable 0169
		static Delegate GetGetTickerSymbolHandler ()
		{
			if (cb_getTickerSymbol == null)
				cb_getTickerSymbol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTickerSymbol);
			return cb_getTickerSymbol;
		}

		static IntPtr n_GetTickerSymbol (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TickerSymbol);
		}
#pragma warning restore 0169

		IntPtr id_getTickerSymbol;
		public string TickerSymbol {
			get {
				if (id_getTickerSymbol == IntPtr.Zero)
					id_getTickerSymbol = JNIEnv.GetMethodID (class_ref, "getTickerSymbol", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTickerSymbol), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public string Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		IntPtr id_getUrl;
		public string Url {
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWidth);
			return cb_getWidth;
		}

		static IntPtr n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Width);
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public string Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getWidth), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWorstRating;
#pragma warning disable 0169
		static Delegate GetGetWorstRatingHandler ()
		{
			if (cb_getWorstRating == null)
				cb_getWorstRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWorstRating);
			return cb_getWorstRating;
		}

		static IntPtr n_GetWorstRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WorstRating);
		}
#pragma warning restore 0169

		IntPtr id_getWorstRating;
		public string WorstRating {
			get {
				if (id_getWorstRating == IntPtr.Zero)
					id_getWorstRating = JNIEnv.GetMethodID (class_ref, "getWorstRating", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getWorstRating), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Android.Gms.Plus.Model.Moments.IItemScope __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native__this, JniHandleOwnership.DoNotTransfer);
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
