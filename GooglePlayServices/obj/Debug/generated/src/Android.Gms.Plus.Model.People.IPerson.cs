using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Plus.Model.People {

	[Register ("com/google/android/gms/plus/model/people/Person$AgeRange", "", "Android.Gms.Plus.Model.People.IPersonAgeRangeInvoker")]
	public partial interface IPersonAgeRange : global::Android.Gms.Common.Data.IFreezable {

		bool HasMax {
			[Register ("hasMax", "()Z", "GetHasMaxHandler:Android.Gms.Plus.Model.People.IPersonAgeRangeInvoker, GooglePlayServices")] get;
		}

		bool HasMin {
			[Register ("hasMin", "()Z", "GetHasMinHandler:Android.Gms.Plus.Model.People.IPersonAgeRangeInvoker, GooglePlayServices")] get;
		}

		int Max {
			[Register ("getMax", "()I", "GetGetMaxHandler:Android.Gms.Plus.Model.People.IPersonAgeRangeInvoker, GooglePlayServices")] get;
		}

		int Min {
			[Register ("getMin", "()I", "GetGetMinHandler:Android.Gms.Plus.Model.People.IPersonAgeRangeInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$AgeRange", DoNotGenerateAcw=true)]
	internal class IPersonAgeRangeInvoker : global::Java.Lang.Object, IPersonAgeRange {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$AgeRange");
		IntPtr class_ref;

		public static IPersonAgeRange GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonAgeRange> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.AgeRange"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonAgeRangeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonAgeRangeInvoker); }
		}

		static Delegate cb_hasMax;
#pragma warning disable 0169
		static Delegate GetHasMaxHandler ()
		{
			if (cb_hasMax == null)
				cb_hasMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasMax);
			return cb_hasMax;
		}

		static bool n_HasMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonAgeRange __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonAgeRange> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMax;
		}
#pragma warning restore 0169

		IntPtr id_hasMax;
		public bool HasMax {
			get {
				if (id_hasMax == IntPtr.Zero)
					id_hasMax = JNIEnv.GetMethodID (class_ref, "hasMax", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasMax);
			}
		}

		static Delegate cb_hasMin;
#pragma warning disable 0169
		static Delegate GetHasMinHandler ()
		{
			if (cb_hasMin == null)
				cb_hasMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasMin);
			return cb_hasMin;
		}

		static bool n_HasMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonAgeRange __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonAgeRange> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMin;
		}
#pragma warning restore 0169

		IntPtr id_hasMin;
		public bool HasMin {
			get {
				if (id_hasMin == IntPtr.Zero)
					id_hasMin = JNIEnv.GetMethodID (class_ref, "hasMin", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasMin);
			}
		}

		static Delegate cb_getMax;
#pragma warning disable 0169
		static Delegate GetGetMaxHandler ()
		{
			if (cb_getMax == null)
				cb_getMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax);
			return cb_getMax;
		}

		static int n_GetMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonAgeRange __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonAgeRange> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max;
		}
#pragma warning restore 0169

		IntPtr id_getMax;
		public int Max {
			get {
				if (id_getMax == IntPtr.Zero)
					id_getMax = JNIEnv.GetMethodID (class_ref, "getMax", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getMax);
			}
		}

		static Delegate cb_getMin;
#pragma warning disable 0169
		static Delegate GetGetMinHandler ()
		{
			if (cb_getMin == null)
				cb_getMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMin);
			return cb_getMin;
		}

		static int n_GetMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonAgeRange __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonAgeRange> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Min;
		}
#pragma warning restore 0169

		IntPtr id_getMin;
		public int Min {
			get {
				if (id_getMin == IntPtr.Zero)
					id_getMin = JNIEnv.GetMethodID (class_ref, "getMin", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getMin);
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
			global::Android.Gms.Plus.Model.People.IPersonAgeRange __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonAgeRange> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[Register ("com/google/android/gms/plus/model/people/Person$Collection")]
	public abstract class PersonCollection {

		internal PersonCollection ()
		{
		}

		[Register ("VISIBLE")]
		public const int Visible = (int) 0;
	}

	[System.Obsolete ("Use the 'PersonCollection' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class PersonCollectionConsts : PersonCollection {

		private PersonCollectionConsts ()
		{
		}
	}


	[Register ("com/google/android/gms/plus/model/people/Person$Cover$CoverInfo", "", "Android.Gms.Plus.Model.People.IPersonCoverCoverInfoInvoker")]
	public partial interface IPersonCoverCoverInfo : global::Android.Gms.Common.Data.IFreezable {

		bool HasLeftImageOffset {
			[Register ("hasLeftImageOffset", "()Z", "GetHasLeftImageOffsetHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverInfoInvoker, GooglePlayServices")] get;
		}

		bool HasTopImageOffset {
			[Register ("hasTopImageOffset", "()Z", "GetHasTopImageOffsetHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverInfoInvoker, GooglePlayServices")] get;
		}

		int LeftImageOffset {
			[Register ("getLeftImageOffset", "()I", "GetGetLeftImageOffsetHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverInfoInvoker, GooglePlayServices")] get;
		}

		int TopImageOffset {
			[Register ("getTopImageOffset", "()I", "GetGetTopImageOffsetHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverInfoInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Cover$CoverInfo", DoNotGenerateAcw=true)]
	internal class IPersonCoverCoverInfoInvoker : global::Java.Lang.Object, IPersonCoverCoverInfo {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Cover$CoverInfo");
		IntPtr class_ref;

		public static IPersonCoverCoverInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonCoverCoverInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Cover.CoverInfo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonCoverCoverInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonCoverCoverInfoInvoker); }
		}

		static Delegate cb_hasLeftImageOffset;
#pragma warning disable 0169
		static Delegate GetHasLeftImageOffsetHandler ()
		{
			if (cb_hasLeftImageOffset == null)
				cb_hasLeftImageOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasLeftImageOffset);
			return cb_hasLeftImageOffset;
		}

		static bool n_HasLeftImageOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLeftImageOffset;
		}
#pragma warning restore 0169

		IntPtr id_hasLeftImageOffset;
		public bool HasLeftImageOffset {
			get {
				if (id_hasLeftImageOffset == IntPtr.Zero)
					id_hasLeftImageOffset = JNIEnv.GetMethodID (class_ref, "hasLeftImageOffset", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasLeftImageOffset);
			}
		}

		static Delegate cb_hasTopImageOffset;
#pragma warning disable 0169
		static Delegate GetHasTopImageOffsetHandler ()
		{
			if (cb_hasTopImageOffset == null)
				cb_hasTopImageOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTopImageOffset);
			return cb_hasTopImageOffset;
		}

		static bool n_HasTopImageOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTopImageOffset;
		}
#pragma warning restore 0169

		IntPtr id_hasTopImageOffset;
		public bool HasTopImageOffset {
			get {
				if (id_hasTopImageOffset == IntPtr.Zero)
					id_hasTopImageOffset = JNIEnv.GetMethodID (class_ref, "hasTopImageOffset", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasTopImageOffset);
			}
		}

		static Delegate cb_getLeftImageOffset;
#pragma warning disable 0169
		static Delegate GetGetLeftImageOffsetHandler ()
		{
			if (cb_getLeftImageOffset == null)
				cb_getLeftImageOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeftImageOffset);
			return cb_getLeftImageOffset;
		}

		static int n_GetLeftImageOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftImageOffset;
		}
#pragma warning restore 0169

		IntPtr id_getLeftImageOffset;
		public int LeftImageOffset {
			get {
				if (id_getLeftImageOffset == IntPtr.Zero)
					id_getLeftImageOffset = JNIEnv.GetMethodID (class_ref, "getLeftImageOffset", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLeftImageOffset);
			}
		}

		static Delegate cb_getTopImageOffset;
#pragma warning disable 0169
		static Delegate GetGetTopImageOffsetHandler ()
		{
			if (cb_getTopImageOffset == null)
				cb_getTopImageOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTopImageOffset);
			return cb_getTopImageOffset;
		}

		static int n_GetTopImageOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopImageOffset;
		}
#pragma warning restore 0169

		IntPtr id_getTopImageOffset;
		public int TopImageOffset {
			get {
				if (id_getTopImageOffset == IntPtr.Zero)
					id_getTopImageOffset = JNIEnv.GetMethodID (class_ref, "getTopImageOffset", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getTopImageOffset);
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
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[Register ("com/google/android/gms/plus/model/people/Person$Cover$CoverPhoto", "", "Android.Gms.Plus.Model.People.IPersonCoverCoverPhotoInvoker")]
	public partial interface IPersonCoverCoverPhoto : global::Android.Gms.Common.Data.IFreezable {

		bool HasHeight {
			[Register ("hasHeight", "()Z", "GetHasHeightHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverPhotoInvoker, GooglePlayServices")] get;
		}

		bool HasUrl {
			[Register ("hasUrl", "()Z", "GetHasUrlHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverPhotoInvoker, GooglePlayServices")] get;
		}

		bool HasWidth {
			[Register ("hasWidth", "()Z", "GetHasWidthHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverPhotoInvoker, GooglePlayServices")] get;
		}

		int Height {
			[Register ("getHeight", "()I", "GetGetHeightHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverPhotoInvoker, GooglePlayServices")] get;
		}

		string Url {
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverPhotoInvoker, GooglePlayServices")] get;
		}

		int Width {
			[Register ("getWidth", "()I", "GetGetWidthHandler:Android.Gms.Plus.Model.People.IPersonCoverCoverPhotoInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Cover$CoverPhoto", DoNotGenerateAcw=true)]
	internal class IPersonCoverCoverPhotoInvoker : global::Java.Lang.Object, IPersonCoverCoverPhoto {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Cover$CoverPhoto");
		IntPtr class_ref;

		public static IPersonCoverCoverPhoto GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonCoverCoverPhoto> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Cover.CoverPhoto"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonCoverCoverPhotoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonCoverCoverPhotoInvoker); }
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
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getHeight);
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
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getWidth);
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
			global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Cover$Layout", DoNotGenerateAcw=true)]
	public sealed partial class PersonCoverLayout : global::Java.Lang.Object {


		[Register ("BANNER")]
		public const int Banner = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Cover$Layout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonCoverLayout); }
		}

		internal PersonCoverLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[Register ("com/google/android/gms/plus/model/people/Person$Cover", "", "Android.Gms.Plus.Model.People.IPersonCoverInvoker")]
	public partial interface IPersonCover : global::Android.Gms.Common.Data.IFreezable {

		global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo CoverInfo {
			[Register ("getCoverInfo", "()Lcom/google/android/gms/plus/model/people/Person$Cover$CoverInfo;", "GetGetCoverInfoHandler:Android.Gms.Plus.Model.People.IPersonCoverInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto CoverPhoto {
			[Register ("getCoverPhoto", "()Lcom/google/android/gms/plus/model/people/Person$Cover$CoverPhoto;", "GetGetCoverPhotoHandler:Android.Gms.Plus.Model.People.IPersonCoverInvoker, GooglePlayServices")] get;
		}

		bool HasCoverInfo {
			[Register ("hasCoverInfo", "()Z", "GetHasCoverInfoHandler:Android.Gms.Plus.Model.People.IPersonCoverInvoker, GooglePlayServices")] get;
		}

		bool HasCoverPhoto {
			[Register ("hasCoverPhoto", "()Z", "GetHasCoverPhotoHandler:Android.Gms.Plus.Model.People.IPersonCoverInvoker, GooglePlayServices")] get;
		}

		bool HasLayout {
			[Register ("hasLayout", "()Z", "GetHasLayoutHandler:Android.Gms.Plus.Model.People.IPersonCoverInvoker, GooglePlayServices")] get;
		}

		int Layout {
			[Register ("getLayout", "()I", "GetGetLayoutHandler:Android.Gms.Plus.Model.People.IPersonCoverInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Cover", DoNotGenerateAcw=true)]
	internal class IPersonCoverInvoker : global::Java.Lang.Object, IPersonCover {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Cover");
		IntPtr class_ref;

		public static IPersonCover GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonCover> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Cover"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonCoverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonCoverInvoker); }
		}

		static Delegate cb_getCoverInfo;
#pragma warning disable 0169
		static Delegate GetGetCoverInfoHandler ()
		{
			if (cb_getCoverInfo == null)
				cb_getCoverInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCoverInfo);
			return cb_getCoverInfo;
		}

		static IntPtr n_GetCoverInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCover __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CoverInfo);
		}
#pragma warning restore 0169

		IntPtr id_getCoverInfo;
		public global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo CoverInfo {
			get {
				if (id_getCoverInfo == IntPtr.Zero)
					id_getCoverInfo = JNIEnv.GetMethodID (class_ref, "getCoverInfo", "()Lcom/google/android/gms/plus/model/people/Person$Cover$CoverInfo;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverInfo> (JNIEnv.CallObjectMethod (Handle, id_getCoverInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCoverPhoto;
#pragma warning disable 0169
		static Delegate GetGetCoverPhotoHandler ()
		{
			if (cb_getCoverPhoto == null)
				cb_getCoverPhoto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCoverPhoto);
			return cb_getCoverPhoto;
		}

		static IntPtr n_GetCoverPhoto (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCover __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CoverPhoto);
		}
#pragma warning restore 0169

		IntPtr id_getCoverPhoto;
		public global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto CoverPhoto {
			get {
				if (id_getCoverPhoto == IntPtr.Zero)
					id_getCoverPhoto = JNIEnv.GetMethodID (class_ref, "getCoverPhoto", "()Lcom/google/android/gms/plus/model/people/Person$Cover$CoverPhoto;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCoverCoverPhoto> (JNIEnv.CallObjectMethod (Handle, id_getCoverPhoto), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasCoverInfo;
#pragma warning disable 0169
		static Delegate GetHasCoverInfoHandler ()
		{
			if (cb_hasCoverInfo == null)
				cb_hasCoverInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCoverInfo);
			return cb_hasCoverInfo;
		}

		static bool n_HasCoverInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCover __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCoverInfo;
		}
#pragma warning restore 0169

		IntPtr id_hasCoverInfo;
		public bool HasCoverInfo {
			get {
				if (id_hasCoverInfo == IntPtr.Zero)
					id_hasCoverInfo = JNIEnv.GetMethodID (class_ref, "hasCoverInfo", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasCoverInfo);
			}
		}

		static Delegate cb_hasCoverPhoto;
#pragma warning disable 0169
		static Delegate GetHasCoverPhotoHandler ()
		{
			if (cb_hasCoverPhoto == null)
				cb_hasCoverPhoto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCoverPhoto);
			return cb_hasCoverPhoto;
		}

		static bool n_HasCoverPhoto (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCover __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCoverPhoto;
		}
#pragma warning restore 0169

		IntPtr id_hasCoverPhoto;
		public bool HasCoverPhoto {
			get {
				if (id_hasCoverPhoto == IntPtr.Zero)
					id_hasCoverPhoto = JNIEnv.GetMethodID (class_ref, "hasCoverPhoto", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasCoverPhoto);
			}
		}

		static Delegate cb_hasLayout;
#pragma warning disable 0169
		static Delegate GetHasLayoutHandler ()
		{
			if (cb_hasLayout == null)
				cb_hasLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasLayout);
			return cb_hasLayout;
		}

		static bool n_HasLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCover __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLayout;
		}
#pragma warning restore 0169

		IntPtr id_hasLayout;
		public bool HasLayout {
			get {
				if (id_hasLayout == IntPtr.Zero)
					id_hasLayout = JNIEnv.GetMethodID (class_ref, "hasLayout", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasLayout);
			}
		}

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayout);
			return cb_getLayout;
		}

		static int n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonCover __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		IntPtr id_getLayout;
		public int Layout {
			get {
				if (id_getLayout == IntPtr.Zero)
					id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLayout);
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
			global::Android.Gms.Plus.Model.People.IPersonCover __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Emails$Type", DoNotGenerateAcw=true)]
	public sealed partial class PersonEmailsType : global::Java.Lang.Object {


		[Register ("HOME")]
		public const int Home = (int) 0;

		[Register ("OTHER")]
		public const int Other = (int) 2;

		[Register ("WORK")]
		public const int Work = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Emails$Type", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonEmailsType); }
		}

		internal PersonEmailsType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[Register ("com/google/android/gms/plus/model/people/Person$Emails", "", "Android.Gms.Plus.Model.People.IPersonEmailsInvoker")]
	public partial interface IPersonEmails : global::Android.Gms.Common.Data.IFreezable {

		bool HasPrimary {
			[Register ("hasPrimary", "()Z", "GetHasPrimaryHandler:Android.Gms.Plus.Model.People.IPersonEmailsInvoker, GooglePlayServices")] get;
		}

		bool HasType {
			[Register ("hasType", "()Z", "GetHasTypeHandler:Android.Gms.Plus.Model.People.IPersonEmailsInvoker, GooglePlayServices")] get;
		}

		bool HasValue {
			[Register ("hasValue", "()Z", "GetHasValueHandler:Android.Gms.Plus.Model.People.IPersonEmailsInvoker, GooglePlayServices")] get;
		}

		bool IsPrimary {
			[Register ("isPrimary", "()Z", "GetIsPrimaryHandler:Android.Gms.Plus.Model.People.IPersonEmailsInvoker, GooglePlayServices")] get;
		}

		int Type {
			[Register ("getType", "()I", "GetGetTypeHandler:Android.Gms.Plus.Model.People.IPersonEmailsInvoker, GooglePlayServices")] get;
		}

		string Value {
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler:Android.Gms.Plus.Model.People.IPersonEmailsInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Emails", DoNotGenerateAcw=true)]
	internal class IPersonEmailsInvoker : global::Java.Lang.Object, IPersonEmails {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Emails");
		IntPtr class_ref;

		public static IPersonEmails GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonEmails> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Emails"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonEmailsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonEmailsInvoker); }
		}

		static Delegate cb_hasPrimary;
#pragma warning disable 0169
		static Delegate GetHasPrimaryHandler ()
		{
			if (cb_hasPrimary == null)
				cb_hasPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPrimary);
			return cb_hasPrimary;
		}

		static bool n_HasPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonEmails __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonEmails> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrimary;
		}
#pragma warning restore 0169

		IntPtr id_hasPrimary;
		public bool HasPrimary {
			get {
				if (id_hasPrimary == IntPtr.Zero)
					id_hasPrimary = JNIEnv.GetMethodID (class_ref, "hasPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPrimary);
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
			global::Android.Gms.Plus.Model.People.IPersonEmails __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonEmails> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasValue;
#pragma warning disable 0169
		static Delegate GetHasValueHandler ()
		{
			if (cb_hasValue == null)
				cb_hasValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasValue);
			return cb_hasValue;
		}

		static bool n_HasValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonEmails __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonEmails> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValue;
		}
#pragma warning restore 0169

		IntPtr id_hasValue;
		public bool HasValue {
			get {
				if (id_hasValue == IntPtr.Zero)
					id_hasValue = JNIEnv.GetMethodID (class_ref, "hasValue", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasValue);
			}
		}

		static Delegate cb_isPrimary;
#pragma warning disable 0169
		static Delegate GetIsPrimaryHandler ()
		{
			if (cb_isPrimary == null)
				cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrimary);
			return cb_isPrimary;
		}

		static bool n_IsPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonEmails __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonEmails> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimary;
		}
#pragma warning restore 0169

		IntPtr id_isPrimary;
		public bool IsPrimary {
			get {
				if (id_isPrimary == IntPtr.Zero)
					id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPrimary);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonEmails __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonEmails> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public int Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getType);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonEmails __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonEmails> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		public string Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPersonEmails __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonEmails> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Gender", DoNotGenerateAcw=true)]
	public sealed partial class PersonGender : global::Java.Lang.Object {


		[Register ("FEMALE")]
		public const int Female = (int) 1;

		[Register ("MALE")]
		public const int Male = (int) 0;

		[Register ("OTHER")]
		public const int Other = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Gender", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonGender); }
		}

		internal PersonGender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[Register ("com/google/android/gms/plus/model/people/Person$Image", "", "Android.Gms.Plus.Model.People.IPersonImageInvoker")]
	public partial interface IPersonImage : global::Android.Gms.Common.Data.IFreezable {

		bool HasUrl {
			[Register ("hasUrl", "()Z", "GetHasUrlHandler:Android.Gms.Plus.Model.People.IPersonImageInvoker, GooglePlayServices")] get;
		}

		string Url {
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler:Android.Gms.Plus.Model.People.IPersonImageInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Image", DoNotGenerateAcw=true)]
	internal class IPersonImageInvoker : global::Java.Lang.Object, IPersonImage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Image");
		IntPtr class_ref;

		public static IPersonImage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonImage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Image"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonImageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonImageInvoker); }
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
			global::Android.Gms.Plus.Model.People.IPersonImage __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonImage> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonImage __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonImage> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonImage __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonImage> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[Register ("com/google/android/gms/plus/model/people/Person$Name", "", "Android.Gms.Plus.Model.People.IPersonNameInvoker")]
	public partial interface IPersonName : global::Android.Gms.Common.Data.IFreezable {

		string FamilyName {
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		string Formatted {
			[Register ("getFormatted", "()Ljava/lang/String;", "GetGetFormattedHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		string GivenName {
			[Register ("getGivenName", "()Ljava/lang/String;", "GetGetGivenNameHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		bool HasFamilyName {
			[Register ("hasFamilyName", "()Z", "GetHasFamilyNameHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		bool HasFormatted {
			[Register ("hasFormatted", "()Z", "GetHasFormattedHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		bool HasGivenName {
			[Register ("hasGivenName", "()Z", "GetHasGivenNameHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		bool HasHonorificPrefix {
			[Register ("hasHonorificPrefix", "()Z", "GetHasHonorificPrefixHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		bool HasHonorificSuffix {
			[Register ("hasHonorificSuffix", "()Z", "GetHasHonorificSuffixHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		bool HasMiddleName {
			[Register ("hasMiddleName", "()Z", "GetHasMiddleNameHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		string HonorificPrefix {
			[Register ("getHonorificPrefix", "()Ljava/lang/String;", "GetGetHonorificPrefixHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		string HonorificSuffix {
			[Register ("getHonorificSuffix", "()Ljava/lang/String;", "GetGetHonorificSuffixHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

		string MiddleName {
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler:Android.Gms.Plus.Model.People.IPersonNameInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Name", DoNotGenerateAcw=true)]
	internal class IPersonNameInvoker : global::Java.Lang.Object, IPersonName {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Name");
		IntPtr class_ref;

		public static IPersonName GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonName> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Name"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonNameInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonNameInvoker); }
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
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getFormatted;
#pragma warning disable 0169
		static Delegate GetGetFormattedHandler ()
		{
			if (cb_getFormatted == null)
				cb_getFormatted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormatted);
			return cb_getFormatted;
		}

		static IntPtr n_GetFormatted (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Formatted);
		}
#pragma warning restore 0169

		IntPtr id_getFormatted;
		public string Formatted {
			get {
				if (id_getFormatted == IntPtr.Zero)
					id_getFormatted = JNIEnv.GetMethodID (class_ref, "getFormatted", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getFormatted), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasFormatted;
#pragma warning disable 0169
		static Delegate GetHasFormattedHandler ()
		{
			if (cb_hasFormatted == null)
				cb_hasFormatted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasFormatted);
			return cb_hasFormatted;
		}

		static bool n_HasFormatted (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFormatted;
		}
#pragma warning restore 0169

		IntPtr id_hasFormatted;
		public bool HasFormatted {
			get {
				if (id_hasFormatted == IntPtr.Zero)
					id_hasFormatted = JNIEnv.GetMethodID (class_ref, "hasFormatted", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasFormatted);
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
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasHonorificPrefix;
#pragma warning disable 0169
		static Delegate GetHasHonorificPrefixHandler ()
		{
			if (cb_hasHonorificPrefix == null)
				cb_hasHonorificPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHonorificPrefix);
			return cb_hasHonorificPrefix;
		}

		static bool n_HasHonorificPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHonorificPrefix;
		}
#pragma warning restore 0169

		IntPtr id_hasHonorificPrefix;
		public bool HasHonorificPrefix {
			get {
				if (id_hasHonorificPrefix == IntPtr.Zero)
					id_hasHonorificPrefix = JNIEnv.GetMethodID (class_ref, "hasHonorificPrefix", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasHonorificPrefix);
			}
		}

		static Delegate cb_hasHonorificSuffix;
#pragma warning disable 0169
		static Delegate GetHasHonorificSuffixHandler ()
		{
			if (cb_hasHonorificSuffix == null)
				cb_hasHonorificSuffix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHonorificSuffix);
			return cb_hasHonorificSuffix;
		}

		static bool n_HasHonorificSuffix (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHonorificSuffix;
		}
#pragma warning restore 0169

		IntPtr id_hasHonorificSuffix;
		public bool HasHonorificSuffix {
			get {
				if (id_hasHonorificSuffix == IntPtr.Zero)
					id_hasHonorificSuffix = JNIEnv.GetMethodID (class_ref, "hasHonorificSuffix", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasHonorificSuffix);
			}
		}

		static Delegate cb_hasMiddleName;
#pragma warning disable 0169
		static Delegate GetHasMiddleNameHandler ()
		{
			if (cb_hasMiddleName == null)
				cb_hasMiddleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasMiddleName);
			return cb_hasMiddleName;
		}

		static bool n_HasMiddleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMiddleName;
		}
#pragma warning restore 0169

		IntPtr id_hasMiddleName;
		public bool HasMiddleName {
			get {
				if (id_hasMiddleName == IntPtr.Zero)
					id_hasMiddleName = JNIEnv.GetMethodID (class_ref, "hasMiddleName", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasMiddleName);
			}
		}

		static Delegate cb_getHonorificPrefix;
#pragma warning disable 0169
		static Delegate GetGetHonorificPrefixHandler ()
		{
			if (cb_getHonorificPrefix == null)
				cb_getHonorificPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHonorificPrefix);
			return cb_getHonorificPrefix;
		}

		static IntPtr n_GetHonorificPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HonorificPrefix);
		}
#pragma warning restore 0169

		IntPtr id_getHonorificPrefix;
		public string HonorificPrefix {
			get {
				if (id_getHonorificPrefix == IntPtr.Zero)
					id_getHonorificPrefix = JNIEnv.GetMethodID (class_ref, "getHonorificPrefix", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getHonorificPrefix), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHonorificSuffix;
#pragma warning disable 0169
		static Delegate GetGetHonorificSuffixHandler ()
		{
			if (cb_getHonorificSuffix == null)
				cb_getHonorificSuffix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHonorificSuffix);
			return cb_getHonorificSuffix;
		}

		static IntPtr n_GetHonorificSuffix (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HonorificSuffix);
		}
#pragma warning restore 0169

		IntPtr id_getHonorificSuffix;
		public string HonorificSuffix {
			get {
				if (id_getHonorificSuffix == IntPtr.Zero)
					id_getHonorificSuffix = JNIEnv.GetMethodID (class_ref, "getHonorificSuffix", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getHonorificSuffix), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMiddleName;
#pragma warning disable 0169
		static Delegate GetGetMiddleNameHandler ()
		{
			if (cb_getMiddleName == null)
				cb_getMiddleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiddleName);
			return cb_getMiddleName;
		}

		static IntPtr n_GetMiddleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleName);
		}
#pragma warning restore 0169

		IntPtr id_getMiddleName;
		public string MiddleName {
			get {
				if (id_getMiddleName == IntPtr.Zero)
					id_getMiddleName = JNIEnv.GetMethodID (class_ref, "getMiddleName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMiddleName), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPersonName __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$ObjectType", DoNotGenerateAcw=true)]
	public sealed partial class PersonObjectType : global::Java.Lang.Object {


		[Register ("PAGE")]
		public const int Page = (int) 1;

		[Register ("PERSON")]
		public const int Person = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$ObjectType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonObjectType); }
		}

		internal PersonObjectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[Register ("com/google/android/gms/plus/model/people/Person$OrderBy")]
	public abstract class PersonOrderBy {

		internal PersonOrderBy ()
		{
		}

		[Register ("ALPHABETICAL")]
		public const int Alphabetical = (int) 0;

		[Register ("BEST")]
		public const int Best = (int) 1;
	}

	[System.Obsolete ("Use the 'PersonOrderBy' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class PersonOrderByConsts : PersonOrderBy {

		private PersonOrderByConsts ()
		{
		}
	}


	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Organizations$Type", DoNotGenerateAcw=true)]
	public sealed partial class PersonOrganizationsType : global::Java.Lang.Object {


		[Register ("SCHOOL")]
		public const int School = (int) 1;

		[Register ("WORK")]
		public const int Work = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Organizations$Type", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonOrganizationsType); }
		}

		internal PersonOrganizationsType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[Register ("com/google/android/gms/plus/model/people/Person$Organizations", "", "Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker")]
	public partial interface IPersonOrganizations : global::Android.Gms.Common.Data.IFreezable {

		string Department {
			[Register ("getDepartment", "()Ljava/lang/String;", "GetGetDepartmentHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		string Description {
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		string EndDate {
			[Register ("getEndDate", "()Ljava/lang/String;", "GetGetEndDateHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasDepartment {
			[Register ("hasDepartment", "()Z", "GetHasDepartmentHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasDescription {
			[Register ("hasDescription", "()Z", "GetHasDescriptionHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasEndDate {
			[Register ("hasEndDate", "()Z", "GetHasEndDateHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasLocation {
			[Register ("hasLocation", "()Z", "GetHasLocationHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasName {
			[Register ("hasName", "()Z", "GetHasNameHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasPrimary {
			[Register ("hasPrimary", "()Z", "GetHasPrimaryHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasStartDate {
			[Register ("hasStartDate", "()Z", "GetHasStartDateHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasTitle {
			[Register ("hasTitle", "()Z", "GetHasTitleHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool HasType {
			[Register ("hasType", "()Z", "GetHasTypeHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		bool IsPrimary {
			[Register ("isPrimary", "()Z", "GetIsPrimaryHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		string Location {
			[Register ("getLocation", "()Ljava/lang/String;", "GetGetLocationHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		string Name {
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		string StartDate {
			[Register ("getStartDate", "()Ljava/lang/String;", "GetGetStartDateHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		string Title {
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

		int Type {
			[Register ("getType", "()I", "GetGetTypeHandler:Android.Gms.Plus.Model.People.IPersonOrganizationsInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Organizations", DoNotGenerateAcw=true)]
	internal class IPersonOrganizationsInvoker : global::Java.Lang.Object, IPersonOrganizations {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Organizations");
		IntPtr class_ref;

		public static IPersonOrganizations GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonOrganizations> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Organizations"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonOrganizationsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonOrganizationsInvoker); }
		}

		static Delegate cb_getDepartment;
#pragma warning disable 0169
		static Delegate GetGetDepartmentHandler ()
		{
			if (cb_getDepartment == null)
				cb_getDepartment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDepartment);
			return cb_getDepartment;
		}

		static IntPtr n_GetDepartment (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Department);
		}
#pragma warning restore 0169

		IntPtr id_getDepartment;
		public string Department {
			get {
				if (id_getDepartment == IntPtr.Zero)
					id_getDepartment = JNIEnv.GetMethodID (class_ref, "getDepartment", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDepartment), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasDepartment;
#pragma warning disable 0169
		static Delegate GetHasDepartmentHandler ()
		{
			if (cb_hasDepartment == null)
				cb_hasDepartment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDepartment);
			return cb_hasDepartment;
		}

		static bool n_HasDepartment (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDepartment;
		}
#pragma warning restore 0169

		IntPtr id_hasDepartment;
		public bool HasDepartment {
			get {
				if (id_hasDepartment == IntPtr.Zero)
					id_hasDepartment = JNIEnv.GetMethodID (class_ref, "hasDepartment", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasDepartment);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasPrimary;
#pragma warning disable 0169
		static Delegate GetHasPrimaryHandler ()
		{
			if (cb_hasPrimary == null)
				cb_hasPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPrimary);
			return cb_hasPrimary;
		}

		static bool n_HasPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrimary;
		}
#pragma warning restore 0169

		IntPtr id_hasPrimary;
		public bool HasPrimary {
			get {
				if (id_hasPrimary == IntPtr.Zero)
					id_hasPrimary = JNIEnv.GetMethodID (class_ref, "hasPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPrimary);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasTitle;
#pragma warning disable 0169
		static Delegate GetHasTitleHandler ()
		{
			if (cb_hasTitle == null)
				cb_hasTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTitle);
			return cb_hasTitle;
		}

		static bool n_HasTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTitle;
		}
#pragma warning restore 0169

		IntPtr id_hasTitle;
		public bool HasTitle {
			get {
				if (id_hasTitle == IntPtr.Zero)
					id_hasTitle = JNIEnv.GetMethodID (class_ref, "hasTitle", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasTitle);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_isPrimary;
#pragma warning disable 0169
		static Delegate GetIsPrimaryHandler ()
		{
			if (cb_isPrimary == null)
				cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrimary);
			return cb_isPrimary;
		}

		static bool n_IsPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimary;
		}
#pragma warning restore 0169

		IntPtr id_isPrimary;
		public bool IsPrimary {
			get {
				if (id_isPrimary == IntPtr.Zero)
					id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPrimary);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Location);
		}
#pragma warning restore 0169

		IntPtr id_getLocation;
		public string Location {
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public int Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getType);
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
			global::Android.Gms.Plus.Model.People.IPersonOrganizations __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonOrganizations> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[Register ("com/google/android/gms/plus/model/people/Person$PlacesLived", "", "Android.Gms.Plus.Model.People.IPersonPlacesLivedInvoker")]
	public partial interface IPersonPlacesLived : global::Android.Gms.Common.Data.IFreezable {

		bool HasPrimary {
			[Register ("hasPrimary", "()Z", "GetHasPrimaryHandler:Android.Gms.Plus.Model.People.IPersonPlacesLivedInvoker, GooglePlayServices")] get;
		}

		bool HasValue {
			[Register ("hasValue", "()Z", "GetHasValueHandler:Android.Gms.Plus.Model.People.IPersonPlacesLivedInvoker, GooglePlayServices")] get;
		}

		bool IsPrimary {
			[Register ("isPrimary", "()Z", "GetIsPrimaryHandler:Android.Gms.Plus.Model.People.IPersonPlacesLivedInvoker, GooglePlayServices")] get;
		}

		string Value {
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler:Android.Gms.Plus.Model.People.IPersonPlacesLivedInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$PlacesLived", DoNotGenerateAcw=true)]
	internal class IPersonPlacesLivedInvoker : global::Java.Lang.Object, IPersonPlacesLived {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$PlacesLived");
		IntPtr class_ref;

		public static IPersonPlacesLived GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonPlacesLived> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.PlacesLived"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonPlacesLivedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonPlacesLivedInvoker); }
		}

		static Delegate cb_hasPrimary;
#pragma warning disable 0169
		static Delegate GetHasPrimaryHandler ()
		{
			if (cb_hasPrimary == null)
				cb_hasPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPrimary);
			return cb_hasPrimary;
		}

		static bool n_HasPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonPlacesLived __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonPlacesLived> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrimary;
		}
#pragma warning restore 0169

		IntPtr id_hasPrimary;
		public bool HasPrimary {
			get {
				if (id_hasPrimary == IntPtr.Zero)
					id_hasPrimary = JNIEnv.GetMethodID (class_ref, "hasPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPrimary);
			}
		}

		static Delegate cb_hasValue;
#pragma warning disable 0169
		static Delegate GetHasValueHandler ()
		{
			if (cb_hasValue == null)
				cb_hasValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasValue);
			return cb_hasValue;
		}

		static bool n_HasValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonPlacesLived __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonPlacesLived> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValue;
		}
#pragma warning restore 0169

		IntPtr id_hasValue;
		public bool HasValue {
			get {
				if (id_hasValue == IntPtr.Zero)
					id_hasValue = JNIEnv.GetMethodID (class_ref, "hasValue", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasValue);
			}
		}

		static Delegate cb_isPrimary;
#pragma warning disable 0169
		static Delegate GetIsPrimaryHandler ()
		{
			if (cb_isPrimary == null)
				cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrimary);
			return cb_isPrimary;
		}

		static bool n_IsPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonPlacesLived __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonPlacesLived> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimary;
		}
#pragma warning restore 0169

		IntPtr id_isPrimary;
		public bool IsPrimary {
			get {
				if (id_isPrimary == IntPtr.Zero)
					id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPrimary);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonPlacesLived __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonPlacesLived> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		public string Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPersonPlacesLived __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonPlacesLived> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$RelationshipStatus", DoNotGenerateAcw=true)]
	public sealed partial class PersonRelationshipStatus : global::Java.Lang.Object {


		[Register ("ENGAGED")]
		public const int Engaged = (int) 2;

		[Register ("IN_A_RELATIONSHIP")]
		public const int InARelationship = (int) 1;

		[Register ("IN_CIVIL_UNION")]
		public const int InCivilUnion = (int) 8;

		[Register ("IN_DOMESTIC_PARTNERSHIP")]
		public const int InDomesticPartnership = (int) 7;

		[Register ("ITS_COMPLICATED")]
		public const int ItsComplicated = (int) 4;

		[Register ("MARRIED")]
		public const int Married = (int) 3;

		[Register ("OPEN_RELATIONSHIP")]
		public const int OpenRelationship = (int) 5;

		[Register ("SINGLE")]
		public const int Single = (int) 0;

		[Register ("WIDOWED")]
		public const int Widowed = (int) 6;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$RelationshipStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonRelationshipStatus); }
		}

		internal PersonRelationshipStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Urls$Type", DoNotGenerateAcw=true)]
	public sealed partial class PersonUrlsType : global::Java.Lang.Object {


		[Register ("BLOG")]
		public const int Blog = (int) 2;

		[Register ("HOME")]
		public const int Home = (int) 0;

		[Register ("OTHER")]
		public const int Other = (int) 4;

		[Register ("PROFILE")]
		public const int Profile = (int) 3;

		[Register ("WORK")]
		public const int Work = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Urls$Type", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonUrlsType); }
		}

		internal PersonUrlsType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[Register ("com/google/android/gms/plus/model/people/Person$Urls", "", "Android.Gms.Plus.Model.People.IPersonUrlsInvoker")]
	public partial interface IPersonUrls : global::Android.Gms.Common.Data.IFreezable {

		bool HasPrimary {
			[Register ("hasPrimary", "()Z", "GetHasPrimaryHandler:Android.Gms.Plus.Model.People.IPersonUrlsInvoker, GooglePlayServices")] get;
		}

		bool HasType {
			[Register ("hasType", "()Z", "GetHasTypeHandler:Android.Gms.Plus.Model.People.IPersonUrlsInvoker, GooglePlayServices")] get;
		}

		bool HasValue {
			[Register ("hasValue", "()Z", "GetHasValueHandler:Android.Gms.Plus.Model.People.IPersonUrlsInvoker, GooglePlayServices")] get;
		}

		bool IsPrimary {
			[Register ("isPrimary", "()Z", "GetIsPrimaryHandler:Android.Gms.Plus.Model.People.IPersonUrlsInvoker, GooglePlayServices")] get;
		}

		int Type {
			[Register ("getType", "()I", "GetGetTypeHandler:Android.Gms.Plus.Model.People.IPersonUrlsInvoker, GooglePlayServices")] get;
		}

		string Value {
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler:Android.Gms.Plus.Model.People.IPersonUrlsInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person$Urls", DoNotGenerateAcw=true)]
	internal class IPersonUrlsInvoker : global::Java.Lang.Object, IPersonUrls {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person$Urls");
		IntPtr class_ref;

		public static IPersonUrls GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersonUrls> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person.Urls"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonUrlsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonUrlsInvoker); }
		}

		static Delegate cb_hasPrimary;
#pragma warning disable 0169
		static Delegate GetHasPrimaryHandler ()
		{
			if (cb_hasPrimary == null)
				cb_hasPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPrimary);
			return cb_hasPrimary;
		}

		static bool n_HasPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonUrls __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonUrls> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrimary;
		}
#pragma warning restore 0169

		IntPtr id_hasPrimary;
		public bool HasPrimary {
			get {
				if (id_hasPrimary == IntPtr.Zero)
					id_hasPrimary = JNIEnv.GetMethodID (class_ref, "hasPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPrimary);
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
			global::Android.Gms.Plus.Model.People.IPersonUrls __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonUrls> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasValue;
#pragma warning disable 0169
		static Delegate GetHasValueHandler ()
		{
			if (cb_hasValue == null)
				cb_hasValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasValue);
			return cb_hasValue;
		}

		static bool n_HasValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonUrls __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonUrls> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValue;
		}
#pragma warning restore 0169

		IntPtr id_hasValue;
		public bool HasValue {
			get {
				if (id_hasValue == IntPtr.Zero)
					id_hasValue = JNIEnv.GetMethodID (class_ref, "hasValue", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasValue);
			}
		}

		static Delegate cb_isPrimary;
#pragma warning disable 0169
		static Delegate GetIsPrimaryHandler ()
		{
			if (cb_isPrimary == null)
				cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrimary);
			return cb_isPrimary;
		}

		static bool n_IsPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonUrls __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonUrls> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimary;
		}
#pragma warning restore 0169

		IntPtr id_isPrimary;
		public bool IsPrimary {
			get {
				if (id_isPrimary == IntPtr.Zero)
					id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPrimary);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonUrls __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonUrls> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public int Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getType);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPersonUrls __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonUrls> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		public string Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPersonUrls __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonUrls> (native__this, JniHandleOwnership.DoNotTransfer);
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


	[Register ("com/google/android/gms/plus/model/people/Person", "", "Android.Gms.Plus.Model.People.IPersonInvoker")]
	public partial interface IPerson : global::Android.Gms.Common.Data.IFreezable {

		string AboutMe {
			[Register ("getAboutMe", "()Ljava/lang/String;", "GetGetAboutMeHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.People.IPersonAgeRange AgeRange {
			[Register ("getAgeRange", "()Lcom/google/android/gms/plus/model/people/Person$AgeRange;", "GetGetAgeRangeHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string Birthday {
			[Register ("getBirthday", "()Ljava/lang/String;", "GetGetBirthdayHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string BraggingRights {
			[Register ("getBraggingRights", "()Ljava/lang/String;", "GetGetBraggingRightsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		int CircledByCount {
			[Register ("getCircledByCount", "()I", "GetGetCircledByCountHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.People.IPersonCover Cover {
			[Register ("getCover", "()Lcom/google/android/gms/plus/model/people/Person$Cover;", "GetGetCoverHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string CurrentLocation {
			[Register ("getCurrentLocation", "()Ljava/lang/String;", "GetGetCurrentLocationHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string DisplayName {
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonEmails> Emails {
			[Register ("getEmails", "()Ljava/util/List;", "GetGetEmailsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		int Gender {
			[Register ("getGender", "()I", "GetGetGenderHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasAboutMe {
			[Register ("hasAboutMe", "()Z", "GetHasAboutMeHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasAgeRange {
			[Register ("hasAgeRange", "()Z", "GetHasAgeRangeHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasBirthday {
			[Register ("hasBirthday", "()Z", "GetHasBirthdayHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasBraggingRights {
			[Register ("hasBraggingRights", "()Z", "GetHasBraggingRightsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasCircledByCount {
			[Register ("hasCircledByCount", "()Z", "GetHasCircledByCountHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasCover {
			[Register ("hasCover", "()Z", "GetHasCoverHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasCurrentLocation {
			[Register ("hasCurrentLocation", "()Z", "GetHasCurrentLocationHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasDisplayName {
			[Register ("hasDisplayName", "()Z", "GetHasDisplayNameHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasEmails {
			[Register ("hasEmails", "()Z", "GetHasEmailsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasGender {
			[Register ("hasGender", "()Z", "GetHasGenderHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasHasApp {
			[Register ("hasHasApp", "()Z", "GetHasHasAppHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasId {
			[Register ("hasId", "()Z", "GetHasIdHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasImage {
			[Register ("hasImage", "()Z", "GetHasImageHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasIsPlusUser {
			[Register ("hasIsPlusUser", "()Z", "GetHasIsPlusUserHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasLanguage {
			[Register ("hasLanguage", "()Z", "GetHasLanguageHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasName {
			[Register ("hasName", "()Z", "GetHasNameHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasNickname {
			[Register ("hasNickname", "()Z", "GetHasNicknameHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasObjectType {
			[Register ("hasObjectType", "()Z", "GetHasObjectTypeHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasOrganizations {
			[Register ("hasOrganizations", "()Z", "GetHasOrganizationsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasPlacesLived {
			[Register ("hasPlacesLived", "()Z", "GetHasPlacesLivedHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasPlusOneCount {
			[Register ("hasPlusOneCount", "()Z", "GetHasPlusOneCountHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasRelationshipStatus {
			[Register ("hasRelationshipStatus", "()Z", "GetHasRelationshipStatusHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasTagline {
			[Register ("hasTagline", "()Z", "GetHasTaglineHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasUrl {
			[Register ("hasUrl", "()Z", "GetHasUrlHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasUrls {
			[Register ("hasUrls", "()Z", "GetHasUrlsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool HasVerified {
			[Register ("hasVerified", "()Z", "GetHasVerifiedHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string Id {
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.People.IPersonImage Image {
			[Register ("getImage", "()Lcom/google/android/gms/plus/model/people/Person$Image;", "GetGetImageHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool IsHasApp {
			[Register ("isHasApp", "()Z", "GetIsHasAppHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool IsPlusUser {
			[Register ("isPlusUser", "()Z", "GetIsPlusUserHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		bool IsVerified {
			[Register ("isVerified", "()Z", "GetIsVerifiedHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string Language {
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::Android.Gms.Plus.Model.People.IPersonName Name {
			[Register ("getName", "()Lcom/google/android/gms/plus/model/people/Person$Name;", "GetGetNameHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string Nickname {
			[Register ("getNickname", "()Ljava/lang/String;", "GetGetNicknameHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		int ObjectType {
			[Register ("getObjectType", "()I", "GetGetObjectTypeHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonOrganizations> Organizations {
			[Register ("getOrganizations", "()Ljava/util/List;", "GetGetOrganizationsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonPlacesLived> PlacesLived {
			[Register ("getPlacesLived", "()Ljava/util/List;", "GetGetPlacesLivedHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		int PlusOneCount {
			[Register ("getPlusOneCount", "()I", "GetGetPlusOneCountHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		int RelationshipStatus {
			[Register ("getRelationshipStatus", "()I", "GetGetRelationshipStatusHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string Tagline {
			[Register ("getTagline", "()Ljava/lang/String;", "GetGetTaglineHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		string Url {
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonUrls> Urls {
			[Register ("getUrls", "()Ljava/util/List;", "GetGetUrlsHandler:Android.Gms.Plus.Model.People.IPersonInvoker, GooglePlayServices")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/people/Person", DoNotGenerateAcw=true)]
	internal class IPersonInvoker : global::Java.Lang.Object, IPerson {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/plus/model/people/Person");
		IntPtr class_ref;

		public static IPerson GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPerson> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.plus.model.people.Person"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPersonInvoker); }
		}

		static Delegate cb_getAboutMe;
#pragma warning disable 0169
		static Delegate GetGetAboutMeHandler ()
		{
			if (cb_getAboutMe == null)
				cb_getAboutMe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAboutMe);
			return cb_getAboutMe;
		}

		static IntPtr n_GetAboutMe (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AboutMe);
		}
#pragma warning restore 0169

		IntPtr id_getAboutMe;
		public string AboutMe {
			get {
				if (id_getAboutMe == IntPtr.Zero)
					id_getAboutMe = JNIEnv.GetMethodID (class_ref, "getAboutMe", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAboutMe), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAgeRange;
#pragma warning disable 0169
		static Delegate GetGetAgeRangeHandler ()
		{
			if (cb_getAgeRange == null)
				cb_getAgeRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAgeRange);
			return cb_getAgeRange;
		}

		static IntPtr n_GetAgeRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AgeRange);
		}
#pragma warning restore 0169

		IntPtr id_getAgeRange;
		public global::Android.Gms.Plus.Model.People.IPersonAgeRange AgeRange {
			get {
				if (id_getAgeRange == IntPtr.Zero)
					id_getAgeRange = JNIEnv.GetMethodID (class_ref, "getAgeRange", "()Lcom/google/android/gms/plus/model/people/Person$AgeRange;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonAgeRange> (JNIEnv.CallObjectMethod (Handle, id_getAgeRange), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBirthday;
#pragma warning disable 0169
		static Delegate GetGetBirthdayHandler ()
		{
			if (cb_getBirthday == null)
				cb_getBirthday = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBirthday);
			return cb_getBirthday;
		}

		static IntPtr n_GetBirthday (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Birthday);
		}
#pragma warning restore 0169

		IntPtr id_getBirthday;
		public string Birthday {
			get {
				if (id_getBirthday == IntPtr.Zero)
					id_getBirthday = JNIEnv.GetMethodID (class_ref, "getBirthday", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getBirthday), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBraggingRights;
#pragma warning disable 0169
		static Delegate GetGetBraggingRightsHandler ()
		{
			if (cb_getBraggingRights == null)
				cb_getBraggingRights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBraggingRights);
			return cb_getBraggingRights;
		}

		static IntPtr n_GetBraggingRights (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BraggingRights);
		}
#pragma warning restore 0169

		IntPtr id_getBraggingRights;
		public string BraggingRights {
			get {
				if (id_getBraggingRights == IntPtr.Zero)
					id_getBraggingRights = JNIEnv.GetMethodID (class_ref, "getBraggingRights", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getBraggingRights), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCircledByCount;
#pragma warning disable 0169
		static Delegate GetGetCircledByCountHandler ()
		{
			if (cb_getCircledByCount == null)
				cb_getCircledByCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCircledByCount);
			return cb_getCircledByCount;
		}

		static int n_GetCircledByCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircledByCount;
		}
#pragma warning restore 0169

		IntPtr id_getCircledByCount;
		public int CircledByCount {
			get {
				if (id_getCircledByCount == IntPtr.Zero)
					id_getCircledByCount = JNIEnv.GetMethodID (class_ref, "getCircledByCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCircledByCount);
			}
		}

		static Delegate cb_getCover;
#pragma warning disable 0169
		static Delegate GetGetCoverHandler ()
		{
			if (cb_getCover == null)
				cb_getCover = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCover);
			return cb_getCover;
		}

		static IntPtr n_GetCover (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cover);
		}
#pragma warning restore 0169

		IntPtr id_getCover;
		public global::Android.Gms.Plus.Model.People.IPersonCover Cover {
			get {
				if (id_getCover == IntPtr.Zero)
					id_getCover = JNIEnv.GetMethodID (class_ref, "getCover", "()Lcom/google/android/gms/plus/model/people/Person$Cover;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonCover> (JNIEnv.CallObjectMethod (Handle, id_getCover), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentLocation;
#pragma warning disable 0169
		static Delegate GetGetCurrentLocationHandler ()
		{
			if (cb_getCurrentLocation == null)
				cb_getCurrentLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentLocation);
			return cb_getCurrentLocation;
		}

		static IntPtr n_GetCurrentLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentLocation);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentLocation;
		public string CurrentLocation {
			get {
				if (id_getCurrentLocation == IntPtr.Zero)
					id_getCurrentLocation = JNIEnv.GetMethodID (class_ref, "getCurrentLocation", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCurrentLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayName;
		public string DisplayName {
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEmails;
#pragma warning disable 0169
		static Delegate GetGetEmailsHandler ()
		{
			if (cb_getEmails == null)
				cb_getEmails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmails);
			return cb_getEmails;
		}

		static IntPtr n_GetEmails (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonEmails>.ToLocalJniHandle (__this.Emails);
		}
#pragma warning restore 0169

		IntPtr id_getEmails;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonEmails> Emails {
			get {
				if (id_getEmails == IntPtr.Zero)
					id_getEmails = JNIEnv.GetMethodID (class_ref, "getEmails", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonEmails>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getEmails), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGender;
#pragma warning disable 0169
		static Delegate GetGetGenderHandler ()
		{
			if (cb_getGender == null)
				cb_getGender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGender);
			return cb_getGender;
		}

		static int n_GetGender (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Gender;
		}
#pragma warning restore 0169

		IntPtr id_getGender;
		public int Gender {
			get {
				if (id_getGender == IntPtr.Zero)
					id_getGender = JNIEnv.GetMethodID (class_ref, "getGender", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getGender);
			}
		}

		static Delegate cb_hasAboutMe;
#pragma warning disable 0169
		static Delegate GetHasAboutMeHandler ()
		{
			if (cb_hasAboutMe == null)
				cb_hasAboutMe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAboutMe);
			return cb_hasAboutMe;
		}

		static bool n_HasAboutMe (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAboutMe;
		}
#pragma warning restore 0169

		IntPtr id_hasAboutMe;
		public bool HasAboutMe {
			get {
				if (id_hasAboutMe == IntPtr.Zero)
					id_hasAboutMe = JNIEnv.GetMethodID (class_ref, "hasAboutMe", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAboutMe);
			}
		}

		static Delegate cb_hasAgeRange;
#pragma warning disable 0169
		static Delegate GetHasAgeRangeHandler ()
		{
			if (cb_hasAgeRange == null)
				cb_hasAgeRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAgeRange);
			return cb_hasAgeRange;
		}

		static bool n_HasAgeRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAgeRange;
		}
#pragma warning restore 0169

		IntPtr id_hasAgeRange;
		public bool HasAgeRange {
			get {
				if (id_hasAgeRange == IntPtr.Zero)
					id_hasAgeRange = JNIEnv.GetMethodID (class_ref, "hasAgeRange", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasAgeRange);
			}
		}

		static Delegate cb_hasBirthday;
#pragma warning disable 0169
		static Delegate GetHasBirthdayHandler ()
		{
			if (cb_hasBirthday == null)
				cb_hasBirthday = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBirthday);
			return cb_hasBirthday;
		}

		static bool n_HasBirthday (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBirthday;
		}
#pragma warning restore 0169

		IntPtr id_hasBirthday;
		public bool HasBirthday {
			get {
				if (id_hasBirthday == IntPtr.Zero)
					id_hasBirthday = JNIEnv.GetMethodID (class_ref, "hasBirthday", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasBirthday);
			}
		}

		static Delegate cb_hasBraggingRights;
#pragma warning disable 0169
		static Delegate GetHasBraggingRightsHandler ()
		{
			if (cb_hasBraggingRights == null)
				cb_hasBraggingRights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBraggingRights);
			return cb_hasBraggingRights;
		}

		static bool n_HasBraggingRights (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBraggingRights;
		}
#pragma warning restore 0169

		IntPtr id_hasBraggingRights;
		public bool HasBraggingRights {
			get {
				if (id_hasBraggingRights == IntPtr.Zero)
					id_hasBraggingRights = JNIEnv.GetMethodID (class_ref, "hasBraggingRights", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasBraggingRights);
			}
		}

		static Delegate cb_hasCircledByCount;
#pragma warning disable 0169
		static Delegate GetHasCircledByCountHandler ()
		{
			if (cb_hasCircledByCount == null)
				cb_hasCircledByCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCircledByCount);
			return cb_hasCircledByCount;
		}

		static bool n_HasCircledByCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCircledByCount;
		}
#pragma warning restore 0169

		IntPtr id_hasCircledByCount;
		public bool HasCircledByCount {
			get {
				if (id_hasCircledByCount == IntPtr.Zero)
					id_hasCircledByCount = JNIEnv.GetMethodID (class_ref, "hasCircledByCount", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasCircledByCount);
			}
		}

		static Delegate cb_hasCover;
#pragma warning disable 0169
		static Delegate GetHasCoverHandler ()
		{
			if (cb_hasCover == null)
				cb_hasCover = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCover);
			return cb_hasCover;
		}

		static bool n_HasCover (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCover;
		}
#pragma warning restore 0169

		IntPtr id_hasCover;
		public bool HasCover {
			get {
				if (id_hasCover == IntPtr.Zero)
					id_hasCover = JNIEnv.GetMethodID (class_ref, "hasCover", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasCover);
			}
		}

		static Delegate cb_hasCurrentLocation;
#pragma warning disable 0169
		static Delegate GetHasCurrentLocationHandler ()
		{
			if (cb_hasCurrentLocation == null)
				cb_hasCurrentLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCurrentLocation);
			return cb_hasCurrentLocation;
		}

		static bool n_HasCurrentLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCurrentLocation;
		}
#pragma warning restore 0169

		IntPtr id_hasCurrentLocation;
		public bool HasCurrentLocation {
			get {
				if (id_hasCurrentLocation == IntPtr.Zero)
					id_hasCurrentLocation = JNIEnv.GetMethodID (class_ref, "hasCurrentLocation", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasCurrentLocation);
			}
		}

		static Delegate cb_hasDisplayName;
#pragma warning disable 0169
		static Delegate GetHasDisplayNameHandler ()
		{
			if (cb_hasDisplayName == null)
				cb_hasDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDisplayName);
			return cb_hasDisplayName;
		}

		static bool n_HasDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDisplayName;
		}
#pragma warning restore 0169

		IntPtr id_hasDisplayName;
		public bool HasDisplayName {
			get {
				if (id_hasDisplayName == IntPtr.Zero)
					id_hasDisplayName = JNIEnv.GetMethodID (class_ref, "hasDisplayName", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasDisplayName);
			}
		}

		static Delegate cb_hasEmails;
#pragma warning disable 0169
		static Delegate GetHasEmailsHandler ()
		{
			if (cb_hasEmails == null)
				cb_hasEmails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasEmails);
			return cb_hasEmails;
		}

		static bool n_HasEmails (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasEmails;
		}
#pragma warning restore 0169

		IntPtr id_hasEmails;
		public bool HasEmails {
			get {
				if (id_hasEmails == IntPtr.Zero)
					id_hasEmails = JNIEnv.GetMethodID (class_ref, "hasEmails", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasEmails);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasHasApp;
#pragma warning disable 0169
		static Delegate GetHasHasAppHandler ()
		{
			if (cb_hasHasApp == null)
				cb_hasHasApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHasApp);
			return cb_hasHasApp;
		}

		static bool n_HasHasApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHasApp;
		}
#pragma warning restore 0169

		IntPtr id_hasHasApp;
		public bool HasHasApp {
			get {
				if (id_hasHasApp == IntPtr.Zero)
					id_hasHasApp = JNIEnv.GetMethodID (class_ref, "hasHasApp", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasHasApp);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasIsPlusUser;
#pragma warning disable 0169
		static Delegate GetHasIsPlusUserHandler ()
		{
			if (cb_hasIsPlusUser == null)
				cb_hasIsPlusUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasIsPlusUser);
			return cb_hasIsPlusUser;
		}

		static bool n_HasIsPlusUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIsPlusUser;
		}
#pragma warning restore 0169

		IntPtr id_hasIsPlusUser;
		public bool HasIsPlusUser {
			get {
				if (id_hasIsPlusUser == IntPtr.Zero)
					id_hasIsPlusUser = JNIEnv.GetMethodID (class_ref, "hasIsPlusUser", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasIsPlusUser);
			}
		}

		static Delegate cb_hasLanguage;
#pragma warning disable 0169
		static Delegate GetHasLanguageHandler ()
		{
			if (cb_hasLanguage == null)
				cb_hasLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasLanguage);
			return cb_hasLanguage;
		}

		static bool n_HasLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLanguage;
		}
#pragma warning restore 0169

		IntPtr id_hasLanguage;
		public bool HasLanguage {
			get {
				if (id_hasLanguage == IntPtr.Zero)
					id_hasLanguage = JNIEnv.GetMethodID (class_ref, "hasLanguage", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasLanguage);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasNickname;
#pragma warning disable 0169
		static Delegate GetHasNicknameHandler ()
		{
			if (cb_hasNickname == null)
				cb_hasNickname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNickname);
			return cb_hasNickname;
		}

		static bool n_HasNickname (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNickname;
		}
#pragma warning restore 0169

		IntPtr id_hasNickname;
		public bool HasNickname {
			get {
				if (id_hasNickname == IntPtr.Zero)
					id_hasNickname = JNIEnv.GetMethodID (class_ref, "hasNickname", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasNickname);
			}
		}

		static Delegate cb_hasObjectType;
#pragma warning disable 0169
		static Delegate GetHasObjectTypeHandler ()
		{
			if (cb_hasObjectType == null)
				cb_hasObjectType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasObjectType);
			return cb_hasObjectType;
		}

		static bool n_HasObjectType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasObjectType;
		}
#pragma warning restore 0169

		IntPtr id_hasObjectType;
		public bool HasObjectType {
			get {
				if (id_hasObjectType == IntPtr.Zero)
					id_hasObjectType = JNIEnv.GetMethodID (class_ref, "hasObjectType", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasObjectType);
			}
		}

		static Delegate cb_hasOrganizations;
#pragma warning disable 0169
		static Delegate GetHasOrganizationsHandler ()
		{
			if (cb_hasOrganizations == null)
				cb_hasOrganizations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasOrganizations);
			return cb_hasOrganizations;
		}

		static bool n_HasOrganizations (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasOrganizations;
		}
#pragma warning restore 0169

		IntPtr id_hasOrganizations;
		public bool HasOrganizations {
			get {
				if (id_hasOrganizations == IntPtr.Zero)
					id_hasOrganizations = JNIEnv.GetMethodID (class_ref, "hasOrganizations", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasOrganizations);
			}
		}

		static Delegate cb_hasPlacesLived;
#pragma warning disable 0169
		static Delegate GetHasPlacesLivedHandler ()
		{
			if (cb_hasPlacesLived == null)
				cb_hasPlacesLived = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPlacesLived);
			return cb_hasPlacesLived;
		}

		static bool n_HasPlacesLived (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPlacesLived;
		}
#pragma warning restore 0169

		IntPtr id_hasPlacesLived;
		public bool HasPlacesLived {
			get {
				if (id_hasPlacesLived == IntPtr.Zero)
					id_hasPlacesLived = JNIEnv.GetMethodID (class_ref, "hasPlacesLived", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPlacesLived);
			}
		}

		static Delegate cb_hasPlusOneCount;
#pragma warning disable 0169
		static Delegate GetHasPlusOneCountHandler ()
		{
			if (cb_hasPlusOneCount == null)
				cb_hasPlusOneCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPlusOneCount);
			return cb_hasPlusOneCount;
		}

		static bool n_HasPlusOneCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPlusOneCount;
		}
#pragma warning restore 0169

		IntPtr id_hasPlusOneCount;
		public bool HasPlusOneCount {
			get {
				if (id_hasPlusOneCount == IntPtr.Zero)
					id_hasPlusOneCount = JNIEnv.GetMethodID (class_ref, "hasPlusOneCount", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPlusOneCount);
			}
		}

		static Delegate cb_hasRelationshipStatus;
#pragma warning disable 0169
		static Delegate GetHasRelationshipStatusHandler ()
		{
			if (cb_hasRelationshipStatus == null)
				cb_hasRelationshipStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasRelationshipStatus);
			return cb_hasRelationshipStatus;
		}

		static bool n_HasRelationshipStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRelationshipStatus;
		}
#pragma warning restore 0169

		IntPtr id_hasRelationshipStatus;
		public bool HasRelationshipStatus {
			get {
				if (id_hasRelationshipStatus == IntPtr.Zero)
					id_hasRelationshipStatus = JNIEnv.GetMethodID (class_ref, "hasRelationshipStatus", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasRelationshipStatus);
			}
		}

		static Delegate cb_hasTagline;
#pragma warning disable 0169
		static Delegate GetHasTaglineHandler ()
		{
			if (cb_hasTagline == null)
				cb_hasTagline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTagline);
			return cb_hasTagline;
		}

		static bool n_HasTagline (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTagline;
		}
#pragma warning restore 0169

		IntPtr id_hasTagline;
		public bool HasTagline {
			get {
				if (id_hasTagline == IntPtr.Zero)
					id_hasTagline = JNIEnv.GetMethodID (class_ref, "hasTagline", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasTagline);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hasUrls;
#pragma warning disable 0169
		static Delegate GetHasUrlsHandler ()
		{
			if (cb_hasUrls == null)
				cb_hasUrls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasUrls);
			return cb_hasUrls;
		}

		static bool n_HasUrls (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUrls;
		}
#pragma warning restore 0169

		IntPtr id_hasUrls;
		public bool HasUrls {
			get {
				if (id_hasUrls == IntPtr.Zero)
					id_hasUrls = JNIEnv.GetMethodID (class_ref, "hasUrls", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasUrls);
			}
		}

		static Delegate cb_hasVerified;
#pragma warning disable 0169
		static Delegate GetHasVerifiedHandler ()
		{
			if (cb_hasVerified == null)
				cb_hasVerified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasVerified);
			return cb_hasVerified;
		}

		static bool n_HasVerified (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasVerified;
		}
#pragma warning restore 0169

		IntPtr id_hasVerified;
		public bool HasVerified {
			get {
				if (id_hasVerified == IntPtr.Zero)
					id_hasVerified = JNIEnv.GetMethodID (class_ref, "hasVerified", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasVerified);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		IntPtr id_getImage;
		public global::Android.Gms.Plus.Model.People.IPersonImage Image {
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/google/android/gms/plus/model/people/Person$Image;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonImage> (JNIEnv.CallObjectMethod (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isHasApp;
#pragma warning disable 0169
		static Delegate GetIsHasAppHandler ()
		{
			if (cb_isHasApp == null)
				cb_isHasApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHasApp);
			return cb_isHasApp;
		}

		static bool n_IsHasApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHasApp;
		}
#pragma warning restore 0169

		IntPtr id_isHasApp;
		public bool IsHasApp {
			get {
				if (id_isHasApp == IntPtr.Zero)
					id_isHasApp = JNIEnv.GetMethodID (class_ref, "isHasApp", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isHasApp);
			}
		}

		static Delegate cb_isPlusUser;
#pragma warning disable 0169
		static Delegate GetIsPlusUserHandler ()
		{
			if (cb_isPlusUser == null)
				cb_isPlusUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlusUser);
			return cb_isPlusUser;
		}

		static bool n_IsPlusUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlusUser;
		}
#pragma warning restore 0169

		IntPtr id_isPlusUser;
		public bool IsPlusUser {
			get {
				if (id_isPlusUser == IntPtr.Zero)
					id_isPlusUser = JNIEnv.GetMethodID (class_ref, "isPlusUser", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPlusUser);
			}
		}

		static Delegate cb_isVerified;
#pragma warning disable 0169
		static Delegate GetIsVerifiedHandler ()
		{
			if (cb_isVerified == null)
				cb_isVerified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVerified);
			return cb_isVerified;
		}

		static bool n_IsVerified (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVerified;
		}
#pragma warning restore 0169

		IntPtr id_isVerified;
		public bool IsVerified {
			get {
				if (id_isVerified == IntPtr.Zero)
					id_isVerified = JNIEnv.GetMethodID (class_ref, "isVerified", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isVerified);
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		IntPtr id_getLanguage;
		public string Language {
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public global::Android.Gms.Plus.Model.People.IPersonName Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/google/android/gms/plus/model/people/Person$Name;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPersonName> (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNickname;
#pragma warning disable 0169
		static Delegate GetGetNicknameHandler ()
		{
			if (cb_getNickname == null)
				cb_getNickname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNickname);
			return cb_getNickname;
		}

		static IntPtr n_GetNickname (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nickname);
		}
#pragma warning restore 0169

		IntPtr id_getNickname;
		public string Nickname {
			get {
				if (id_getNickname == IntPtr.Zero)
					id_getNickname = JNIEnv.GetMethodID (class_ref, "getNickname", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getNickname), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getObjectType;
#pragma warning disable 0169
		static Delegate GetGetObjectTypeHandler ()
		{
			if (cb_getObjectType == null)
				cb_getObjectType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetObjectType);
			return cb_getObjectType;
		}

		static int n_GetObjectType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectType;
		}
#pragma warning restore 0169

		IntPtr id_getObjectType;
		public int ObjectType {
			get {
				if (id_getObjectType == IntPtr.Zero)
					id_getObjectType = JNIEnv.GetMethodID (class_ref, "getObjectType", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getObjectType);
			}
		}

		static Delegate cb_getOrganizations;
#pragma warning disable 0169
		static Delegate GetGetOrganizationsHandler ()
		{
			if (cb_getOrganizations == null)
				cb_getOrganizations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrganizations);
			return cb_getOrganizations;
		}

		static IntPtr n_GetOrganizations (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonOrganizations>.ToLocalJniHandle (__this.Organizations);
		}
#pragma warning restore 0169

		IntPtr id_getOrganizations;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonOrganizations> Organizations {
			get {
				if (id_getOrganizations == IntPtr.Zero)
					id_getOrganizations = JNIEnv.GetMethodID (class_ref, "getOrganizations", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonOrganizations>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getOrganizations), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlacesLived;
#pragma warning disable 0169
		static Delegate GetGetPlacesLivedHandler ()
		{
			if (cb_getPlacesLived == null)
				cb_getPlacesLived = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlacesLived);
			return cb_getPlacesLived;
		}

		static IntPtr n_GetPlacesLived (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonPlacesLived>.ToLocalJniHandle (__this.PlacesLived);
		}
#pragma warning restore 0169

		IntPtr id_getPlacesLived;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonPlacesLived> PlacesLived {
			get {
				if (id_getPlacesLived == IntPtr.Zero)
					id_getPlacesLived = JNIEnv.GetMethodID (class_ref, "getPlacesLived", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonPlacesLived>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getPlacesLived), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlusOneCount;
#pragma warning disable 0169
		static Delegate GetGetPlusOneCountHandler ()
		{
			if (cb_getPlusOneCount == null)
				cb_getPlusOneCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPlusOneCount);
			return cb_getPlusOneCount;
		}

		static int n_GetPlusOneCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlusOneCount;
		}
#pragma warning restore 0169

		IntPtr id_getPlusOneCount;
		public int PlusOneCount {
			get {
				if (id_getPlusOneCount == IntPtr.Zero)
					id_getPlusOneCount = JNIEnv.GetMethodID (class_ref, "getPlusOneCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPlusOneCount);
			}
		}

		static Delegate cb_getRelationshipStatus;
#pragma warning disable 0169
		static Delegate GetGetRelationshipStatusHandler ()
		{
			if (cb_getRelationshipStatus == null)
				cb_getRelationshipStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRelationshipStatus);
			return cb_getRelationshipStatus;
		}

		static int n_GetRelationshipStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RelationshipStatus;
		}
#pragma warning restore 0169

		IntPtr id_getRelationshipStatus;
		public int RelationshipStatus {
			get {
				if (id_getRelationshipStatus == IntPtr.Zero)
					id_getRelationshipStatus = JNIEnv.GetMethodID (class_ref, "getRelationshipStatus", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getRelationshipStatus);
			}
		}

		static Delegate cb_getTagline;
#pragma warning disable 0169
		static Delegate GetGetTaglineHandler ()
		{
			if (cb_getTagline == null)
				cb_getTagline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTagline);
			return cb_getTagline;
		}

		static IntPtr n_GetTagline (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tagline);
		}
#pragma warning restore 0169

		IntPtr id_getTagline;
		public string Tagline {
			get {
				if (id_getTagline == IntPtr.Zero)
					id_getTagline = JNIEnv.GetMethodID (class_ref, "getTagline", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTagline), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getUrls;
#pragma warning disable 0169
		static Delegate GetGetUrlsHandler ()
		{
			if (cb_getUrls == null)
				cb_getUrls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrls);
			return cb_getUrls;
		}

		static IntPtr n_GetUrls (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonUrls>.ToLocalJniHandle (__this.Urls);
		}
#pragma warning restore 0169

		IntPtr id_getUrls;
		public global::System.Collections.Generic.IList<global::Android.Gms.Plus.Model.People.IPersonUrls> Urls {
			get {
				if (id_getUrls == IntPtr.Zero)
					id_getUrls = JNIEnv.GetMethodID (class_ref, "getUrls", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Android.Gms.Plus.Model.People.IPersonUrls>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getUrls), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Gms.Plus.Model.People.IPerson __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Plus.Model.People.IPerson> (native__this, JniHandleOwnership.DoNotTransfer);
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
