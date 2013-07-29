using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.LeaderBoard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult']"
	[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/SubmitScoreResult", DoNotGenerateAcw=true)]
	public sealed partial class SubmitScoreResult : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult.Result']"
		[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/SubmitScoreResult$Result", DoNotGenerateAcw=true)]
		public sealed partial class Result : global::Java.Lang.Object {


			static IntPtr formattedScore_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult.Result']/field[@name='formattedScore']"
			[Register ("formattedScore")]
			public string FormattedScore {
				get {
					if (formattedScore_jfieldId == IntPtr.Zero)
						formattedScore_jfieldId = JNIEnv.GetFieldID (class_ref, "formattedScore", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, formattedScore_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (formattedScore_jfieldId == IntPtr.Zero)
						formattedScore_jfieldId = JNIEnv.GetFieldID (class_ref, "formattedScore", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, formattedScore_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr newBest_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult.Result']/field[@name='newBest']"
			[Register ("newBest")]
			public bool NewBest {
				get {
					if (newBest_jfieldId == IntPtr.Zero)
						newBest_jfieldId = JNIEnv.GetFieldID (class_ref, "newBest", "Z");
					return JNIEnv.GetBooleanField (Handle, newBest_jfieldId);
				}
				set {
					if (newBest_jfieldId == IntPtr.Zero)
						newBest_jfieldId = JNIEnv.GetFieldID (class_ref, "newBest", "Z");
					JNIEnv.SetField (Handle, newBest_jfieldId, value);
				}
			}

			static IntPtr rawScore_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult.Result']/field[@name='rawScore']"
			[Register ("rawScore")]
			public long RawScore {
				get {
					if (rawScore_jfieldId == IntPtr.Zero)
						rawScore_jfieldId = JNIEnv.GetFieldID (class_ref, "rawScore", "J");
					return JNIEnv.GetLongField (Handle, rawScore_jfieldId);
				}
				set {
					if (rawScore_jfieldId == IntPtr.Zero)
						rawScore_jfieldId = JNIEnv.GetFieldID (class_ref, "rawScore", "J");
					JNIEnv.SetField (Handle, rawScore_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/games/leaderboard/SubmitScoreResult$Result", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Result); }
			}

			internal Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_JLjava_lang_String_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult.Result']/constructor[@name='SubmitScoreResult.Result' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
			[Register (".ctor", "(JLjava/lang/String;Z)V", "")]
			public Result (long p0, string p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (Result)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(JLjava/lang/String;Z)V", new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_JLjava_lang_String_Z == IntPtr.Zero)
					id_ctor_JLjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(JLjava/lang/String;Z)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_JLjava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/games/leaderboard/SubmitScoreResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubmitScoreResult); }
		}

		internal SubmitScoreResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult']/constructor[@name='SubmitScoreResult' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.HashMap']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V", "")]
		public SubmitScoreResult (int p0, string p1, string p2, global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result>.ToLocalJniHandle (p3);;
			if (GetType () != typeof (SubmitScoreResult)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3))), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_util_HashMap_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3))), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult']/constructor[@name='SubmitScoreResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public SubmitScoreResult (int p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (SubmitScoreResult)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_getLeaderboardId;
		public string LeaderboardId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult']/method[@name='getLeaderboardId' and count(parameter)=0]"
			[Register ("getLeaderboardId", "()Ljava/lang/String;", "GetGetLeaderboardIdHandler")]
			get {
				if (id_getLeaderboardId == IntPtr.Zero)
					id_getLeaderboardId = JNIEnv.GetMethodID (class_ref, "getLeaderboardId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboardId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPlayerId;
		public string PlayerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult']/method[@name='getPlayerId' and count(parameter)=0]"
			[Register ("getPlayerId", "()Ljava/lang/String;", "GetGetPlayerIdHandler")]
			get {
				if (id_getPlayerId == IntPtr.Zero)
					id_getPlayerId = JNIEnv.GetMethodID (class_ref, "getPlayerId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPlayerId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStatusCode;
		public int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
			}
		}

		static IntPtr id_getScoreResult_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.leaderboard']/class[@name='SubmitScoreResult']/method[@name='getScoreResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getScoreResult", "(I)Lcom/google/android/gms/games/leaderboard/SubmitScoreResult$Result;", "")]
		public global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result GetScoreResult (int p0)
		{
			if (id_getScoreResult_I == IntPtr.Zero)
				id_getScoreResult_I = JNIEnv.GetMethodID (class_ref, "getScoreResult", "(I)Lcom/google/android/gms/games/leaderboard/SubmitScoreResult$Result;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result> (JNIEnv.CallObjectMethod  (Handle, id_getScoreResult_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
