using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']"
	[global::Android.Runtime.Register ("com/google/android/gms/location/ActivityRecognitionResult", DoNotGenerateAcw=true)]
	public partial class ActivityRecognitionResult : global::Java.Lang.Object {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.Gms.Location.ActivityRecognitionResultCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/location/ActivityRecognitionResultCreator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResultCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/location/ActivityRecognitionResultCreator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/field[@name='EXTRA_ACTIVITY_RESULT']"
		[Register ("EXTRA_ACTIVITY_RESULT")]
		public const string ExtraActivityResult = (string) "com.google.android.location.internal.EXTRA_ACTIVITY_RESULT";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/location/ActivityRecognitionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActivityRecognitionResult); }
		}

		protected ActivityRecognitionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/constructor[@name='ActivityRecognitionResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ActivityRecognitionResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActivityRecognitionResult)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Lcom_google_android_gms_location_DetectedActivity_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/constructor[@name='ActivityRecognitionResult' and count(parameter)=3 and parameter[1][@type='com.google.android.gms.location.DetectedActivity'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Lcom/google/android/gms/location/DetectedActivity;JJ)V", "")]
		public ActivityRecognitionResult (global::Android.Gms.Location.DetectedActivity p0, long p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActivityRecognitionResult)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/location/DetectedActivity;JJ)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_location_DetectedActivity_JJ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_location_DetectedActivity_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/location/DetectedActivity;JJ)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_location_DetectedActivity_JJ, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Ljava_util_List_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/constructor[@name='ActivityRecognitionResult' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/util/List;JJ)V", "")]
		public ActivityRecognitionResult (global::System.Collections.Generic.IList<global::Android.Gms.Location.DetectedActivity> p0, long p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Location.DetectedActivity>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ActivityRecognitionResult)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/util/List;JJ)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_JJ == IntPtr.Zero)
				id_ctor_Ljava_util_List_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;JJ)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_util_List_JJ, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getElapsedRealtimeMillis;
#pragma warning disable 0169
		static Delegate GetGetElapsedRealtimeMillisHandler ()
		{
			if (cb_getElapsedRealtimeMillis == null)
				cb_getElapsedRealtimeMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetElapsedRealtimeMillis);
			return cb_getElapsedRealtimeMillis;
		}

		static long n_GetElapsedRealtimeMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.ActivityRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedRealtimeMillis;
		}
#pragma warning restore 0169

		static IntPtr id_getElapsedRealtimeMillis;
		public virtual long ElapsedRealtimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='getElapsedRealtimeMillis' and count(parameter)=0]"
			[Register ("getElapsedRealtimeMillis", "()J", "GetGetElapsedRealtimeMillisHandler")]
			get {
				if (id_getElapsedRealtimeMillis == IntPtr.Zero)
					id_getElapsedRealtimeMillis = JNIEnv.GetMethodID (class_ref, "getElapsedRealtimeMillis", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getElapsedRealtimeMillis);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getElapsedRealtimeMillis);
			}
		}

		static Delegate cb_getMostProbableActivity;
#pragma warning disable 0169
		static Delegate GetGetMostProbableActivityHandler ()
		{
			if (cb_getMostProbableActivity == null)
				cb_getMostProbableActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMostProbableActivity);
			return cb_getMostProbableActivity;
		}

		static IntPtr n_GetMostProbableActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.ActivityRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MostProbableActivity);
		}
#pragma warning restore 0169

		static IntPtr id_getMostProbableActivity;
		public virtual global::Android.Gms.Location.DetectedActivity MostProbableActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='getMostProbableActivity' and count(parameter)=0]"
			[Register ("getMostProbableActivity", "()Lcom/google/android/gms/location/DetectedActivity;", "GetGetMostProbableActivityHandler")]
			get {
				if (id_getMostProbableActivity == IntPtr.Zero)
					id_getMostProbableActivity = JNIEnv.GetMethodID (class_ref, "getMostProbableActivity", "()Lcom/google/android/gms/location/DetectedActivity;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivity> (JNIEnv.CallObjectMethod  (Handle, id_getMostProbableActivity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Location.DetectedActivity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMostProbableActivity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProbableActivities;
#pragma warning disable 0169
		static Delegate GetGetProbableActivitiesHandler ()
		{
			if (cb_getProbableActivities == null)
				cb_getProbableActivities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProbableActivities);
			return cb_getProbableActivities;
		}

		static IntPtr n_GetProbableActivities (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.ActivityRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Location.DetectedActivity>.ToLocalJniHandle (__this.ProbableActivities);
		}
#pragma warning restore 0169

		static IntPtr id_getProbableActivities;
		public virtual global::System.Collections.Generic.IList<global::Android.Gms.Location.DetectedActivity> ProbableActivities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='getProbableActivities' and count(parameter)=0]"
			[Register ("getProbableActivities", "()Ljava/util/List;", "GetGetProbableActivitiesHandler")]
			get {
				if (id_getProbableActivities == IntPtr.Zero)
					id_getProbableActivities = JNIEnv.GetMethodID (class_ref, "getProbableActivities", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Android.Gms.Location.DetectedActivity>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getProbableActivities), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Android.Gms.Location.DetectedActivity>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProbableActivities), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTime);
			return cb_getTime;
		}

		static long n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.ActivityRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Time;
		}
#pragma warning restore 0169

		static IntPtr id_getTime;
		public virtual long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()J", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getTime);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Location.ActivityRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_describeContents);
		}

		static IntPtr id_extractResult_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='extractResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("extractResult", "(Landroid/content/Intent;)Lcom/google/android/gms/location/ActivityRecognitionResult;", "")]
		public static global::Android.Gms.Location.ActivityRecognitionResult ExtractResult (global::Android.Content.Intent p0)
		{
			if (id_extractResult_Landroid_content_Intent_ == IntPtr.Zero)
				id_extractResult_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "extractResult", "(Landroid/content/Intent;)Lcom/google/android/gms/location/ActivityRecognitionResult;");
			global::Android.Gms.Location.ActivityRecognitionResult __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractResult_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getActivityConfidence_I;
#pragma warning disable 0169
		static Delegate GetGetActivityConfidence_IHandler ()
		{
			if (cb_getActivityConfidence_I == null)
				cb_getActivityConfidence_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetActivityConfidence_I);
			return cb_getActivityConfidence_I;
		}

		static int n_GetActivityConfidence_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Gms.Location.ActivityRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetActivityConfidence (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getActivityConfidence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='getActivityConfidence' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getActivityConfidence", "(I)I", "GetGetActivityConfidence_IHandler")]
		public virtual int GetActivityConfidence (int p0)
		{
			if (id_getActivityConfidence_I == IntPtr.Zero)
				id_getActivityConfidence_I = JNIEnv.GetMethodID (class_ref, "getActivityConfidence", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getActivityConfidence_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getActivityConfidence_I, new JValue (p0));
		}

		static IntPtr id_hasResult_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='hasResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("hasResult", "(Landroid/content/Intent;)Z", "")]
		public static bool HasResult (global::Android.Content.Intent p0)
		{
			if (id_hasResult_Landroid_content_Intent_ == IntPtr.Zero)
				id_hasResult_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "hasResult", "(Landroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasResult_Landroid_content_Intent_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Gms.Location.ActivityRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Location.ActivityRecognitionResult> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.location']/class[@name='ActivityRecognitionResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

	}
}
