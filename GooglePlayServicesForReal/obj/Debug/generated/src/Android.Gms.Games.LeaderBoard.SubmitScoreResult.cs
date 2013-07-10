using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Games.LeaderBoard {

	[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/SubmitScoreResult", DoNotGenerateAcw=true)]
	public sealed partial class SubmitScoreResult : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/google/android/gms/games/leaderboard/SubmitScoreResult$Result", DoNotGenerateAcw=true)]
		public sealed partial class Result : global::Java.Lang.Object {


			static IntPtr formattedScore_jfieldId;

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
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V", "")]
		public SubmitScoreResult (int p0, string p1, string p2, global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result>.ToLocalJniHandle (p3);;
			if (GetType () != typeof (SubmitScoreResult)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_util_HashMap_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_;
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
			[Register ("getLeaderboardId", "()Ljava/lang/String;", "GetGetLeaderboardIdHandler")]
			get {
				if (id_getLeaderboardId == IntPtr.Zero)
					id_getLeaderboardId = JNIEnv.GetMethodID (class_ref, "getLeaderboardId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboardId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPlayerId;
		public string PlayerId {
			[Register ("getPlayerId", "()Ljava/lang/String;", "GetGetPlayerIdHandler")]
			get {
				if (id_getPlayerId == IntPtr.Zero)
					id_getPlayerId = JNIEnv.GetMethodID (class_ref, "getPlayerId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPlayerId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStatusCode;
		public int StatusCode {
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
			}
		}

		static IntPtr id_getScoreResult_I;
		[Register ("getScoreResult", "(I)Lcom/google/android/gms/games/leaderboard/SubmitScoreResult$Result;", "")]
		public global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result GetScoreResult (int p0)
		{
			if (id_getScoreResult_I == IntPtr.Zero)
				id_getScoreResult_I = JNIEnv.GetMethodID (class_ref, "getScoreResult", "(I)Lcom/google/android/gms/games/leaderboard/SubmitScoreResult$Result;");
			return global::Java.Lang.Object.GetObject<global::Android.Gms.Games.LeaderBoard.SubmitScoreResult.Result> (JNIEnv.CallObjectMethod  (Handle, id_getScoreResult_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
