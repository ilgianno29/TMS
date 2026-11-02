using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Incasbo.Web.WFI;

public class SpaceInvaders : WFIPage
{
	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameSpaceInvaders")]
	protected virtual HtmlGenericControl IFrameSpaceInvaders
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SpaceInvaders()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
