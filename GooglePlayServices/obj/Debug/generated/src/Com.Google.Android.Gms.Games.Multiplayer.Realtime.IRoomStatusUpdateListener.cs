using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Games.Multiplayer.Realtime {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']"
	[Register ("com/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListener", "", "Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker")]
	public partial interface IRoomStatusUpdateListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onConnectedToRoom' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room']]"
		[Register ("onConnectedToRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V", "GetOnConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnConnectedToRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onDisconnectedFromRoom' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room']]"
		[Register ("onDisconnectedFromRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V", "GetOnDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnDisconnectedFromRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onPeerDeclined' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room'] and parameter[2][@type='java.util.List']]"
		[Register ("onPeerDeclined", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V", "GetOnPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnPeerDeclined (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onPeerInvitedToRoom' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room'] and parameter[2][@type='java.util.List']]"
		[Register ("onPeerInvitedToRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V", "GetOnPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnPeerInvitedToRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onPeerJoined' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room'] and parameter[2][@type='java.util.List']]"
		[Register ("onPeerJoined", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V", "GetOnPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnPeerJoined (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onPeerLeft' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room'] and parameter[2][@type='java.util.List']]"
		[Register ("onPeerLeft", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V", "GetOnPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnPeerLeft (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onPeersConnected' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room'] and parameter[2][@type='java.util.List']]"
		[Register ("onPeersConnected", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V", "GetOnPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnPeersConnected (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onPeersDisconnected' and count(parameter)=2 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room'] and parameter[2][@type='java.util.List']]"
		[Register ("onPeersDisconnected", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V", "GetOnPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnPeersDisconnected (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onRoomAutoMatching' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room']]"
		[Register ("onRoomAutoMatching", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V", "GetOnRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnRoomAutoMatching (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.games.multiplayer.realtime']/interface[@name='RoomStatusUpdateListener']/method[@name='onRoomConnecting' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.games.multiplayer.realtime.Room']]"
		[Register ("onRoomConnecting", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V", "GetOnRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServices")]
		void OnRoomConnecting (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListener", DoNotGenerateAcw=true)]
	internal class IRoomStatusUpdateListenerInvoker : global::Java.Lang.Object, IRoomStatusUpdateListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListener");
		IntPtr class_ref;

		public static IRoomStatusUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomStatusUpdateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.games.multiplayer.realtime.RoomStatusUpdateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomStatusUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRoomStatusUpdateListenerInvoker); }
		}

		static Delegate cb_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
#pragma warning disable 0169
		static Delegate GetOnConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler ()
		{
			if (cb_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == null)
				cb_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_);
			return cb_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		}

		static void n_OnConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectedToRoom (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		public void OnConnectedToRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			if (id_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "onConnectedToRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0));
		}

		static Delegate cb_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
#pragma warning disable 0169
		static Delegate GetOnDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler ()
		{
			if (cb_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == null)
				cb_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_);
			return cb_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		}

		static void n_OnDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnectedFromRoom (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		public void OnDisconnectedFromRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			if (id_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "onDisconnectedFromRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			JNIEnv.CallVoidMethod (Handle, id_onDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0));
		}

		static Delegate cb_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler ()
		{
			if (cb_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == null)
				cb_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_);
			return cb_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		}

		static void n_OnPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerDeclined (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		public void OnPeerDeclined (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == IntPtr.Zero)
				id_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPeerDeclined", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_onPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler ()
		{
			if (cb_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == null)
				cb_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_);
			return cb_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		}

		static void n_OnPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerInvitedToRoom (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		public void OnPeerInvitedToRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == IntPtr.Zero)
				id_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPeerInvitedToRoom", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_onPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler ()
		{
			if (cb_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == null)
				cb_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_);
			return cb_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		}

		static void n_OnPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerJoined (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		public void OnPeerJoined (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == IntPtr.Zero)
				id_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPeerJoined", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_onPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler ()
		{
			if (cb_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == null)
				cb_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_);
			return cb_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		}

		static void n_OnPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerLeft (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		public void OnPeerLeft (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == IntPtr.Zero)
				id_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPeerLeft", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_onPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler ()
		{
			if (cb_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == null)
				cb_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_);
			return cb_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		}

		static void n_OnPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPeersConnected (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		public void OnPeersConnected (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == IntPtr.Zero)
				id_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPeersConnected", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_onPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler ()
		{
			if (cb_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == null)
				cb_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_);
			return cb_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		}

		static void n_OnPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPeersDisconnected (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_;
		public void OnPeersDisconnected (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ == IntPtr.Zero)
				id_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPeersDisconnected", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_onPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
#pragma warning disable 0169
		static Delegate GetOnRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler ()
		{
			if (cb_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == null)
				cb_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_);
			return cb_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		}

		static void n_OnRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomAutoMatching (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		public void OnRoomAutoMatching (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			if (id_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "onRoomAutoMatching", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			JNIEnv.CallVoidMethod (Handle, id_onRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0));
		}

		static Delegate cb_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
#pragma warning disable 0169
		static Delegate GetOnRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler ()
		{
			if (cb_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == null)
				cb_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_);
			return cb_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		}

		static void n_OnRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0 = (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRoomConnecting (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_;
		public void OnRoomConnecting (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			if (id_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_ == IntPtr.Zero)
				id_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_ = JNIEnv.GetMethodID (class_ref, "onRoomConnecting", "(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V");
			JNIEnv.CallVoidMethod (Handle, id_onRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_, new JValue (p0));
		}

	}

	public partial class ConnectedToRoomEventArgs : global::System.EventArgs {

		public ConnectedToRoomEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			this.p0 = p0;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}
	}

	public partial class DisconnectedFromRoomEventArgs : global::System.EventArgs {

		public DisconnectedFromRoomEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			this.p0 = p0;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}
	}

	public partial class PeerDeclinedEventArgs : global::System.EventArgs {

		public PeerDeclinedEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;
		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}
	}

	public partial class PeerInvitedToRoomEventArgs : global::System.EventArgs {

		public PeerInvitedToRoomEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;
		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}
	}

	public partial class PeerJoinedEventArgs : global::System.EventArgs {

		public PeerJoinedEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;
		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}
	}

	public partial class PeerLeftEventArgs : global::System.EventArgs {

		public PeerLeftEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;
		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}
	}

	public partial class PeersConnectedEventArgs : global::System.EventArgs {

		public PeersConnectedEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;
		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}
	}

	public partial class PeersDisconnectedEventArgs : global::System.EventArgs {

		public PeersDisconnectedEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;
		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}
	}

	public partial class RoomAutoMatchingEventArgs : global::System.EventArgs {

		public RoomAutoMatchingEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			this.p0 = p0;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}
	}

	public partial class RoomConnectingEventArgs : global::System.EventArgs {

		public RoomConnectingEventArgs (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			this.p0 = p0;
		}

		global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0;
		public global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListenerImplementor")]
	internal sealed class IRoomStatusUpdateListenerImplementor : global::Java.Lang.Object, IRoomStatusUpdateListener {

		object sender;

		public IRoomStatusUpdateListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/google/android/gms/games/multiplayer/realtime/RoomStatusUpdateListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectedToRoomEventArgs> OnConnectedToRoomHandler;
#pragma warning restore 0649

		public void OnConnectedToRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			var __h = OnConnectedToRoomHandler;
			if (__h != null)
				__h (sender, new ConnectedToRoomEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<DisconnectedFromRoomEventArgs> OnDisconnectedFromRoomHandler;
#pragma warning restore 0649

		public void OnDisconnectedFromRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			var __h = OnDisconnectedFromRoomHandler;
			if (__h != null)
				__h (sender, new DisconnectedFromRoomEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<PeerDeclinedEventArgs> OnPeerDeclinedHandler;
#pragma warning restore 0649

		public void OnPeerDeclined (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			var __h = OnPeerDeclinedHandler;
			if (__h != null)
				__h (sender, new PeerDeclinedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<PeerInvitedToRoomEventArgs> OnPeerInvitedToRoomHandler;
#pragma warning restore 0649

		public void OnPeerInvitedToRoom (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			var __h = OnPeerInvitedToRoomHandler;
			if (__h != null)
				__h (sender, new PeerInvitedToRoomEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<PeerJoinedEventArgs> OnPeerJoinedHandler;
#pragma warning restore 0649

		public void OnPeerJoined (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			var __h = OnPeerJoinedHandler;
			if (__h != null)
				__h (sender, new PeerJoinedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<PeerLeftEventArgs> OnPeerLeftHandler;
#pragma warning restore 0649

		public void OnPeerLeft (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			var __h = OnPeerLeftHandler;
			if (__h != null)
				__h (sender, new PeerLeftEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<PeersConnectedEventArgs> OnPeersConnectedHandler;
#pragma warning restore 0649

		public void OnPeersConnected (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			var __h = OnPeersConnectedHandler;
			if (__h != null)
				__h (sender, new PeersConnectedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<PeersDisconnectedEventArgs> OnPeersDisconnectedHandler;
#pragma warning restore 0649

		public void OnPeersDisconnected (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0, global::System.Collections.Generic.IList<string> p1)
		{
			var __h = OnPeersDisconnectedHandler;
			if (__h != null)
				__h (sender, new PeersDisconnectedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RoomAutoMatchingEventArgs> OnRoomAutoMatchingHandler;
#pragma warning restore 0649

		public void OnRoomAutoMatching (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			var __h = OnRoomAutoMatchingHandler;
			if (__h != null)
				__h (sender, new RoomAutoMatchingEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<RoomConnectingEventArgs> OnRoomConnectingHandler;
#pragma warning restore 0649

		public void OnRoomConnecting (global::Com.Google.Android.Gms.Games.Multiplayer.Realtime.IRoom p0)
		{
			var __h = OnRoomConnectingHandler;
			if (__h != null)
				__h (sender, new RoomConnectingEventArgs (p0));
		}

		internal static bool __IsEmpty (IRoomStatusUpdateListenerImplementor value)
		{
			return value.OnConnectedToRoomHandler == null && value.OnDisconnectedFromRoomHandler == null && value.OnPeerDeclinedHandler == null && value.OnPeerInvitedToRoomHandler == null && value.OnPeerJoinedHandler == null && value.OnPeerLeftHandler == null && value.OnPeersConnectedHandler == null && value.OnPeersDisconnectedHandler == null && value.OnRoomAutoMatchingHandler == null && value.OnRoomConnectingHandler == null;
		}
	}

}
