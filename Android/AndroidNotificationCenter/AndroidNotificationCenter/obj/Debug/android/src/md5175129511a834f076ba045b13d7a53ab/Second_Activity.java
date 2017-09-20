package md5175129511a834f076ba045b13d7a53ab;


public class Second_Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AndroidNotificationCenter.Second_Activity, AndroidNotificationCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Second_Activity.class, __md_methods);
	}


	public Second_Activity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Second_Activity.class)
			mono.android.TypeManager.Activate ("AndroidNotificationCenter.Second_Activity, AndroidNotificationCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
