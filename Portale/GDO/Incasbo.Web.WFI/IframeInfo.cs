using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Incasbo.Web.WFI;

public class IframeInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _IFrameObjectReturn;

	public string IFrameTag { get; set; }

	public object IFrameObjectReturn
	{
		[CompilerGenerated]
		get
		{
			return _IFrameObjectReturn;
		}
		[CompilerGenerated]
		set
		{
			_IFrameObjectReturn = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string IFrameTitle { get; set; }

	public WFIMaster.IFrameDimension IFrameDimension { get; set; }

	public string IFrameDimensionCustomCssClass { get; set; }

	public string IframeBodyClass { get; set; }

	public string IFrameUrl { get; set; }

	public bool IFrameCloseButtonVisible { get; set; }

	public string IFrameCaller { get; set; }

	public string IFrameContext { get; set; }

	public string IFrameModalita { get; set; }

	public Dictionary<string, object> Params { get; set; }

	public bool AutomaticVerticalResizing { get; set; }

	public bool IFrameClosed { get; set; }

	public bool ResetSessionVariable { get; set; }

	public bool Draggable { get; set; }

	public bool IFrameAlwaysRaiseCloseEvent { get; set; }

	public IframeInfo()
	{
		IFrameTag = "";
		IFrameObjectReturn = null;
		IFrameTitle = "";
		IFrameDimension = WFIMaster.IFrameDimension.Standard;
		IFrameDimensionCustomCssClass = "";
		IframeBodyClass = "";
		IFrameUrl = "";
		IFrameCloseButtonVisible = false;
		IFrameCaller = "";
		IFrameContext = "";
		IFrameModalita = "";
		Params = new Dictionary<string, object>();
		AutomaticVerticalResizing = false;
		IFrameClosed = false;
		ResetSessionVariable = false;
		Draggable = false;
		IFrameAlwaysRaiseCloseEvent = false;
	}
}
