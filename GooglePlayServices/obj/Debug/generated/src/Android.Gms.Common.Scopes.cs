using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/Scopes", DoNotGenerateAcw=true)]
	public sealed partial class Scopes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='APP_STATE']"
		[Register ("APP_STATE")]
		public const string AppState = (string) "https://www.googleapis.com/auth/appstate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='GAMES']"
		[Register ("GAMES")]
		public const string Games = (string) "https://www.googleapis.com/auth/games";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='PLUS_LOGIN']"
		[Register ("PLUS_LOGIN")]
		public const string PlusLogin = (string) "https://www.googleapis.com/auth/plus.login";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='PLUS_PROFILE']"
		[Register ("PLUS_PROFILE")]
		public const string PlusProfile = (string) "https://www.googleapis.com/auth/plus.me";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/Scopes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Scopes); }
		}

		internal Scopes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
