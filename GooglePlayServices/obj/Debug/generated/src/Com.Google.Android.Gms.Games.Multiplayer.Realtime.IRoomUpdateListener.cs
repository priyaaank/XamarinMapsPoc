using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	[Register ("com/google/android/gms/games/multiplayer/realtime/RoomUpdateListener", "", "Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker")]
	public partial interface IRoomUpdateListener : IJavaObject {

		[Register ("onJoinedRoom", "(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V", "GetOnJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServices")]
		void OnJoinedRoom (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1);

		[Register ("onLeftRoom", "(ILjava/lang/String;)V", "GetOnLeftRoom_ILjava_lang_String_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServices")]
		void OnLeftRoom (int p0, string p1);

		[Register ("onRoomConnected", "(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V", "GetOnRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServices")]
		void OnRoomConnected (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1);

		[Register ("onRoomCreated", "(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V", "GetOnRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServices")]
		void OnRoomCreated (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RoomUpdateListener", DoNotGenerateAcw=true)]
	internal class IRoomUpdateListenerInvoker : global::Java.Lang.Object, IRoomUpdateListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RoomUpdateListener");
		IntPtr class_ref;

		public static IRoomUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomUpdateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.realtime.RoomUpdateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRoomUpdateListenerInvoker); }
		}

		static Delegate cb_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
#pragma warning disable 0169
		static Delegate GetOnJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler ()
		{
			if (cb_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_ == null)
				cb_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_);
			return cb_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
		}

		static void n_OnJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnJoinedRoom (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
		public void OnJoinedRoom (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			if (id_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "onJoinedRoom", "(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			JNIEnv.CallVoidMethod (Handle, id_onJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onLeftRoom_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnLeftRoom_ILjava_lang_String_Handler ()
		{
			if (cb_onLeftRoom_ILjava_lang_String_ == null)
				cb_onLeftRoom_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnLeftRoom_ILjava_lang_String_);
			return cb_onLeftRoom_ILjava_lang_String_;
		}

		static void n_OnLeftRoom_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLeftRoom (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLeftRoom_ILjava_lang_String_;
		public void OnLeftRoom (int p0, string p1)
		{
			if (id_onLeftRoom_ILjava_lang_String_ == IntPtr.Zero)
				id_onLeftRoom_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLeftRoom", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_onLeftRoom_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
#pragma warning disable 0169
		static Delegate GetOnRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler ()
		{
			if (cb_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_ == null)
				cb_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_);
			return cb_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
		}

		static void n_OnRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomConnected (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
		public void OnRoomConnected (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			if (id_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "onRoomConnected", "(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			JNIEnv.CallVoidMethod (Handle, id_onRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
#pragma warning disable 0169
		static Delegate GetOnRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler ()
		{
			if (cb_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_ == null)
				cb_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_);
			return cb_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
		}

		static void n_OnRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomCreated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_;
		public void OnRoomCreated (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			if (id_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "onRoomCreated", "(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			JNIEnv.CallVoidMethod (Handle, id_onRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0), new JValue (p1));
		}

	}

	public partial class JoinedRoomEventArgs : global::System.EventArgs {

		public JoinedRoomEventArgs (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P1 {
			get { return p1; }
		}
	}

	public partial class LeftRoomEventArgs : global::System.EventArgs {

		public LeftRoomEventArgs (int p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class RoomConnectedEventArgs : global::System.EventArgs {

		public RoomConnectedEventArgs (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P1 {
			get { return p1; }
		}
	}

	public partial class RoomCreatedEventArgs : global::System.EventArgs {

		public RoomCreatedEventArgs (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/multiplayer/realtime/RoomUpdateListenerImplementor")]
	internal sealed class IRoomUpdateListenerImplementor : global::Java.Lang.Object, IRoomUpdateListener {

		object sender;

		public IRoomUpdateListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/multiplayer/realtime/RoomUpdateListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<JoinedRoomEventArgs> OnJoinedRoomHandler;
#pragma warning restore 0649

		public void OnJoinedRoom (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			if (OnJoinedRoomHandler != null)
				OnJoinedRoomHandler (sender, new JoinedRoomEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<LeftRoomEventArgs> OnLeftRoomHandler;
#pragma warning restore 0649

		public void OnLeftRoom (int p0, string p1)
		{
			if (OnLeftRoomHandler != null)
				OnLeftRoomHandler (sender, new LeftRoomEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RoomConnectedEventArgs> OnRoomConnectedHandler;
#pragma warning restore 0649

		public void OnRoomConnected (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			if (OnRoomConnectedHandler != null)
				OnRoomConnectedHandler (sender, new RoomConnectedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RoomCreatedEventArgs> OnRoomCreatedHandler;
#pragma warning restore 0649

		public void OnRoomCreated (int p0, global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p1)
		{
			if (OnRoomCreatedHandler != null)
				OnRoomCreatedHandler (sender, new RoomCreatedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IRoomUpdateListenerImplementor value)
		{
			return value.OnJoinedRoomHandler == null && value.OnLeftRoomHandler == null && value.OnRoomConnectedHandler == null && value.OnRoomCreatedHandler == null;
		}
	}

}
