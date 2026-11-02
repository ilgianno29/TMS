using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Incasbo.Web.WFI;

public class Racer : WFIPage
{
	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameSpaceRacer")]
	protected virtual HtmlGenericControl IFrameSpaceRacer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Racer()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
