using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Incasbo.Web.WFI;

public class InitialControl
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _ObjValue;

	public string Id { get; set; }

	public object ObjValue
	{
		[CompilerGenerated]
		get
		{
			return _ObjValue;
		}
		[CompilerGenerated]
		set
		{
			_ObjValue = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public bool Enabled { get; set; }

	public bool ReadOnly { get; set; }

	public bool Visible { get; set; }

	public InitialControl()
	{
		Id = "";
		ObjValue = null;
		Enabled = false;
		ReadOnly = false;
		Visible = false;
	}
}
