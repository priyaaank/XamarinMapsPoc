using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	[global::Android.Runtime.Register ("com/google/android/gms/common/AccountPicker", DoNotGenerateAcw=true)]
	public sealed partial class AccountPicker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/AccountPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountPicker); }
		}

		internal AccountPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_Z;
		[Register ("a", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Z)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent A (global::Android.Accounts.Account p0, global::System.Collections.Generic.IList<global::Android.Accounts.Account> p1, string[] p2, bool p3, string p4, string p5, string[] p6, global::Android.OS.Bundle p7, bool p8)
		{
			if (id_a_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_Z == IntPtr.Zero)
				id_a_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_Z = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Z)Landroid/content/Intent;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Accounts.Account>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_Z, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5), new JValue (native_p6), new JValue (p7), new JValue (p8)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static IntPtr id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_;
		[Register ("newChooseAccountIntent", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent NewChooseAccountIntent (global::Android.Accounts.Account p0, global::System.Collections.Generic.IList<global::Android.Accounts.Account> p1, string[] p2, bool p3, string p4, string p5, string[] p6, global::Android.OS.Bundle p7)
		{
			if (id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "newChooseAccountIntent", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Accounts.Account>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5), new JValue (native_p6), new JValue (p7)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

	}
}
