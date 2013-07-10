package mono.com.google.android.gms.plus;


public class PlusClient_OnPersonLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.plus.PlusClient.OnPersonLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPersonLoaded:(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/people/Person;)V:GetOnPersonLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_Person_Handler:Android.Gms.Plus.PlusClient/IOnPersonLoadedListenerInvoker, GooglePlayServices\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Plus.PlusClient/IOnPersonLoadedListenerImplementor, GooglePlayServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PlusClient_OnPersonLoadedListenerImplementor.class, __md_methods);
	}


	public PlusClient_OnPersonLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == PlusClient_OnPersonLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Plus.PlusClient/IOnPersonLoadedListenerImplementor, GooglePlayServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPersonLoaded (com.google.android.gms.common.ConnectionResult p0, com.google.android.gms.plus.model.people.Person p1)
	{
		n_onPersonLoaded (p0, p1);
	}

	private native void n_onPersonLoaded (com.google.android.gms.common.ConnectionResult p0, com.google.android.gms.plus.model.people.Person p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
