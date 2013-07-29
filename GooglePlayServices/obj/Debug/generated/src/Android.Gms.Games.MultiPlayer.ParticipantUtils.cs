using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.MultiPlayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='ParticipantUtils']"
	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/ParticipantUtils", DoNotGenerateAcw=true)]
	public sealed partial class ParticipantUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/ParticipantUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParticipantUtils); }
		}

		internal ParticipantUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getParticipantId_Ljava_util_ArrayList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='ParticipantUtils']/method[@name='getParticipantId' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='java.lang.String']]"
		[Register ("getParticipantId", "(Ljava/util/ArrayList;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetParticipantId (global::System.Collections.Generic.IList<global::Android.Gms.Games.MultiPlayer.IParticipant> p0, string p1)
		{
			if (id_getParticipantId_Ljava_util_ArrayList_Ljava_lang_String_ == IntPtr.Zero)
				id_getParticipantId_Ljava_util_ArrayList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getParticipantId", "(Ljava/util/ArrayList;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Gms.Games.MultiPlayer.IParticipant>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getParticipantId_Ljava_util_ArrayList_Ljava_lang_String_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer']/class[@name='ParticipantUtils']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)Z", "")]
		public static bool V (string p0)
		{
			if (id_v_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_v_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
