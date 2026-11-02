using System;

namespace Incasbo.Web.Components;

public class IboWebToolbarEventArgs : EventArgs
{
	public string ButtonId { get; set; }

	public string CommandName { get; set; }

	public string CommandArguments { get; set; }

	public bool Managed { get; set; }

	protected IboWebToolbarEventArgs()
	{
		ButtonId = "";
		CommandName = "";
		CommandArguments = "";
		Managed = false;
	}

	public IboWebToolbarEventArgs(string sButtonId, string sCommandName, string sCommandArguments)
	{
		ButtonId = "";
		CommandName = "";
		CommandArguments = "";
		Managed = false;
		ButtonId = sButtonId;
		CommandName = sCommandName;
		CommandArguments = sCommandArguments;
	}
}
