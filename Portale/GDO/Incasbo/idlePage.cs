using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Incasbo;

public class idlePage : Page
{
	[field: AccessedThroughProperty("Head1")]
	protected virtual HtmlHead Head1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("form1")]
	protected virtual HtmlForm form1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public idlePage()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
