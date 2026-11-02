using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Incasbo.Web.WFI;

public class Tetris : WFIPage
{
	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Tetris()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
