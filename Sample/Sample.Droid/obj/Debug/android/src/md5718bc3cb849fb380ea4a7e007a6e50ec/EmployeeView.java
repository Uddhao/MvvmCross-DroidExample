package md5718bc3cb849fb380ea4a7e007a6e50ec;


public class EmployeeView
	extends md5204979768ea66d3a79201c4efd7c602a.MvxAppCompatActivity_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Sample.Droid.Views.EmployeeView, Sample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EmployeeView.class, __md_methods);
	}


	public EmployeeView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == EmployeeView.class)
			mono.android.TypeManager.Activate ("Sample.Droid.Views.EmployeeView, Sample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
