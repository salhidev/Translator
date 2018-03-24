package md5e2b9a9cbe06c9a1410535964ab41d943;


public class App_OnPrimaryClipChangedListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.content.ClipboardManager.OnPrimaryClipChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPrimaryClipChanged:()V:GetOnPrimaryClipChangedHandler:Android.Content.ClipboardManager/IOnPrimaryClipChangedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("App1.App+OnPrimaryClipChangedListener, App1.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", App_OnPrimaryClipChangedListener.class, __md_methods);
	}


	public App_OnPrimaryClipChangedListener ()
	{
		super ();
		if (getClass () == App_OnPrimaryClipChangedListener.class)
			mono.android.TypeManager.Activate ("App1.App+OnPrimaryClipChangedListener, App1.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPrimaryClipChanged ()
	{
		n_onPrimaryClipChanged ();
	}

	private native void n_onPrimaryClipChanged ();

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
