using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	[global::Android.Runtime.Register ("com/google/android/gms/common/ConnectionResult", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionResult : global::Java.Lang.Object {


		static IntPtr B_jfieldId;

		[Register ("B")]
		public static global::Android.Gms.Common.ConnectionResult B {
			get {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "B", "Lcom/google/android/gms/common/ConnectionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, B_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "B", "Lcom/google/android/gms/common/ConnectionResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, B_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		[Register ("DEVELOPER_ERROR")]
		public const int DeveloperError = (int) 10;

		[Register ("INTERNAL_ERROR")]
		public const int InternalError = (int) 8;

		[Register ("INVALID_ACCOUNT")]
		public const int InvalidAccount = (int) 5;

		[Register ("LICENSE_CHECK_FAILED")]
		public const int LicenseCheckFailed = (int) 11;

		[Register ("NETWORK_ERROR")]
		public const int NetworkError = (int) 7;

		[Register ("RESOLUTION_REQUIRED")]
		public const int ResolutionRequired = (int) 6;

		[Register ("SERVICE_DISABLED")]
		public const int ServiceDisabled = (int) 3;

		[Register ("SERVICE_INVALID")]
		public const int ServiceInvalid = (int) 9;

		[Register ("SERVICE_MISSING")]
		public const int ServiceMissing = (int) 1;

		[Register ("SERVICE_VERSION_UPDATE_REQUIRED")]
		public const int ServiceVersionUpdateRequired = (int) 2;

		[Register ("SIGN_IN_REQUIRED")]
		public const int SignInRequired = (int) 4;

		[Register ("SUCCESS")]
		public const int Success = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/ConnectionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionResult); }
		}

		internal ConnectionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILandroid_app_PendingIntent_;
		[Register (".ctor", "(ILandroid/app/PendingIntent;)V", "")]
		public ConnectionResult (int p0, global::Android.App.PendingIntent p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConnectionResult)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(ILandroid/app/PendingIntent;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_ILandroid_app_PendingIntent_ == IntPtr.Zero)
				id_ctor_ILandroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/app/PendingIntent;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_ILandroid_app_PendingIntent_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getErrorCode;
		public int ErrorCode {
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
			}
		}

		static IntPtr id_hasResolution;
		public bool HasResolution {
			[Register ("hasResolution", "()Z", "GetHasResolutionHandler")]
			get {
				if (id_hasResolution == IntPtr.Zero)
					id_hasResolution = JNIEnv.GetMethodID (class_ref, "hasResolution", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_hasResolution);
			}
		}

		static IntPtr id_isSuccess;
		public bool IsSuccess {
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isSuccess);
			}
		}

		static IntPtr id_getResolution;
		public global::Android.App.PendingIntent Resolution {
			[Register ("getResolution", "()Landroid/app/PendingIntent;", "GetGetResolutionHandler")]
			get {
				if (id_getResolution == IntPtr.Zero)
					id_getResolution = JNIEnv.GetMethodID (class_ref, "getResolution", "()Landroid/app/PendingIntent;");
				return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallObjectMethod  (Handle, id_getResolution), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_startResolutionForResult_Landroid_app_Activity_I;
		[Register ("startResolutionForResult", "(Landroid/app/Activity;I)V", "")]
		public void StartResolutionForResult (global::Android.App.Activity p0, int p1)
		{
			if (id_startResolutionForResult_Landroid_app_Activity_I == IntPtr.Zero)
				id_startResolutionForResult_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "startResolutionForResult", "(Landroid/app/Activity;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_startResolutionForResult_Landroid_app_Activity_I, new JValue (p0), new JValue (p1));
		}

	}
}
