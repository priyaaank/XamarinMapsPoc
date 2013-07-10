using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus.Model.Moments {

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/moments/Moment$Builder", DoNotGenerateAcw=true)]
	public partial class MomentBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/moments/Moment$Builder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MomentBuilder); }
		}

		protected MomentBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public MomentBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MomentBuilder)) {
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
			global::Android.Gms.Plus.Model.Moments.MomentBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		[Register ("build", "()Lcom/google/android/gms/plus/model/moments/Moment;", "GetBuildHandler")]
		public virtual global::Android.Gms.Plus.Model.Moments.IMoment Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/android/gms/plus/model/moments/Moment;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.Moments.MomentBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setId_Ljava_lang_String_;
		[Register ("setId", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;", "GetSetId_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.MomentBuilder SetId (string p0)
		{
			if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
				id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.MomentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetResult_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetResult_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetResult_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.MomentBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setResult", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;", "GetSetResult_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.MomentBuilder SetResult (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setResult", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;");

			global::Android.Gms.Plus.Model.Moments.MomentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setResult_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.Moments.MomentBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStartDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setStartDate_Ljava_lang_String_;
		[Register ("setStartDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;", "GetSetStartDate_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.MomentBuilder SetStartDate (string p0)
		{
			if (id_setStartDate_Ljava_lang_String_ == IntPtr.Zero)
				id_setStartDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStartDate", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.MomentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setStartDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setStartDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler ()
		{
			if (cb_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_ == null)
				cb_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_);
			return cb_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		}

		static IntPtr n_SetTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Plus.Model.Moments.MomentBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Plus.Model.Moments.IItemScope p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTarget (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_;
		[Register ("setTarget", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;", "GetSetTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.MomentBuilder SetTarget (global::Android.Gms.Plus.Model.Moments.IItemScope p0)
		{
			if (id_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_ == IntPtr.Zero)
				id_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_ = JNIEnv.GetMethodID (class_ref, "setTarget", "(Lcom/google/android/gms/plus/model/moments/ItemScope;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;");

			global::Android.Gms.Plus.Model.Moments.MomentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setTarget_Lcom_google_android_gms_plus_model_moments_ItemScope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.Moments.MomentBuilder __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setType_Ljava_lang_String_;
		[Register ("setType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;", "GetSetType_Ljava_lang_String_Handler")]
		public virtual global::Android.Gms.Plus.Model.Moments.MomentBuilder SetType (string p0)
		{
			if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
				id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)Lcom/google/android/gms/plus/model/moments/Moment$Builder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Gms.Plus.Model.Moments.MomentBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.MomentBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setType_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

	[Register ("com/google/android/gms/plus/model/moments/Moment", "", "Android.Gms.Plus.Model.Moments.IMomentInvoker")]
	public partial interface IMoment : global::Android.Gms.Common.Data.IFreezable {

		bool HasId {
			[Register ("hasId", "()Z", "GetHasIdHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		bool HasResult {
			[Register ("hasResult", "()Z", "GetHasResultHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		bool HasStartDate {
			[Register ("hasStartDate", "()Z", "GetHasStartDateHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		bool HasTarget {
			[Register ("hasTarget", "()Z", "GetHasTargetHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		bool HasType {
			[Register ("hasType", "()Z", "GetHasTypeHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		string Id {
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope Result {
			[Register ("getResult", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetResultHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		string StartDate {
			[Register ("getStartDate", "()Ljava/lang/String;", "GetGetStartDateHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		global::Android.Gms.Plus.Model.Moments.IItemScope Target {
			[Register ("getTarget", "()Lcom/google/android/gms/plus/model/moments/ItemScope;", "GetGetTargetHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

		string Type {
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler:Android.Gms.Plus.Model.Moments.IMomentInvoker, GooglePlayServicesForReal")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/moments/Moment", DoNotGenerateAcw=true)]
	internal class IMomentInvoker : global::Java.Lang.Object, IMoment {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/moments/Moment");
		IntPtr class_ref;

		public static IMoment GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMoment> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.moments.Moment"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMomentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMomentInvoker); }
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
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasResult;
#pragma warning disable 0169
		static Delegate GetHasResultHandler ()
		{
			if (cb_hasResult == null)
				cb_hasResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasResult);
			return cb_hasResult;
		}

		static bool n_HasResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasResult;
		}
#pragma warning restore 0169

		IntPtr id_hasResult;
		public bool HasResult {
			get {
				if (id_hasResult == IntPtr.Zero)
					id_hasResult = JNIEnv.GetMethodID (class_ref, "hasResult", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasResult);
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
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasTarget;
#pragma warning disable 0169
		static Delegate GetHasTargetHandler ()
		{
			if (cb_hasTarget == null)
				cb_hasTarget = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTarget);
			return cb_hasTarget;
		}

		static bool n_HasTarget (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTarget;
		}
#pragma warning restore 0169

		IntPtr id_hasTarget;
		public bool HasTarget {
			get {
				if (id_hasTarget == IntPtr.Zero)
					id_hasTarget = JNIEnv.GetMethodID (class_ref, "hasTarget", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasTarget);
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
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		IntPtr id_getResult;
		public global::Android.Gms.Plus.Model.Moments.IItemScope Result {
			get {
				if (id_getResult == IntPtr.Zero)
					id_getResult = JNIEnv.GetMethodID (class_ref, "getResult", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getResult), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Target);
		}
#pragma warning restore 0169

		IntPtr id_getTarget;
		public global::Android.Gms.Plus.Model.Moments.IItemScope Target {
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Lcom/google/android/gms/plus/model/moments/ItemScope;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IItemScope> (JNIEnv.CallObjectMethod (Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.Moments.IMoment __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.Moments.IMoment> (native__this, JniHandleOwnership.DoNotTransfer);
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
