using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Incasbo.Web.WFI;

public class Frogger : WFIPage
{
	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameGame")]
	protected virtual HtmlGenericControl IFrameGame
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Frogger()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
