using System.Runtime.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIUserMessage
{
	public enum MessageBoxImage
	{
		NotSet,
		Critical,
		Info,
		Exclamation,
		Question
	}

	public enum MessageUserChoice
	{
		Undefined,
		Conferma,
		Annulla,
		Ok,
		Yes,
		No
	}

	public enum TipoMessageBox
	{
		ConfermaAnnulla,
		OkOnly,
		YesNo
	}

	public enum WFIMessageBoxState
	{
		Idle,
		Active
	}

	public enum CallBackTypeEnum
	{
		StandardDelegate,
		DelegateWithParameters,
		CallByNameFunction
	}

	protected string _Message1;

	protected string _Message2;

	protected string _Title;

	protected string _CssClass;

	protected MessageUserChoice _UserChoice;

	protected bool _NeedToRefresh;

	protected FuncToCallAfterConfirm _DelegateCallBack;

	protected FuncToCallAfterConfirmWithParameters _DelegateCallBackWithParameters;

	protected object _Parameters;

	protected TipoMessageBox _TipoMessageBox;

	protected string _Funzione;

	protected string _Tag;

	protected WFIMessageBoxState _State;

	protected MessageBoxImage _MessageBoxImage;

	protected string _CallBackFunctionName;

	protected string _CallBackCancelFunctionName;

	protected CallBackTypeEnum _CallBackType;

	public int Height { get; set; }

	public int Width { get; set; }

	public bool ShowAsNotification { get; set; }

	public MessageBoxImage MessageBoxImageType
	{
		get
		{
			return _MessageBoxImage;
		}
		set
		{
			_MessageBoxImage = value;
		}
	}

	public string Message1
	{
		get
		{
			return _Message1;
		}
		set
		{
			_Message1 = value;
		}
	}

	public string Message2
	{
		get
		{
			return _Message2;
		}
		set
		{
			_Message2 = value;
		}
	}

	public string Title
	{
		get
		{
			return _Title;
		}
		set
		{
			_Title = value;
		}
	}

	public string CssClass
	{
		get
		{
			return _CssClass;
		}
		set
		{
			_CssClass = value;
		}
	}

	public string Funzione
	{
		get
		{
			return _Funzione;
		}
		set
		{
			_Funzione = value;
		}
	}

	public MessageUserChoice UserChoice
	{
		get
		{
			return _UserChoice;
		}
		set
		{
			_UserChoice = value;
		}
	}

	public bool NeedToRefresh
	{
		get
		{
			return _NeedToRefresh;
		}
		set
		{
			_NeedToRefresh = value;
		}
	}

	public TipoMessageBox Tipo
	{
		get
		{
			return _TipoMessageBox;
		}
		set
		{
			_TipoMessageBox = value;
		}
	}

	public string Tag
	{
		get
		{
			return _Tag;
		}
		set
		{
			_Tag = value;
		}
	}

	public FuncToCallAfterConfirm DelegateCallBack
	{
		get
		{
			return _DelegateCallBack;
		}
		set
		{
			_DelegateCallBack = value;
			CallBackType = CallBackTypeEnum.StandardDelegate;
		}
	}

	public CallBackTypeEnum CallBackType
	{
		get
		{
			return _CallBackType;
		}
		set
		{
			_CallBackType = value;
		}
	}

	public FuncToCallAfterConfirmWithParameters DelegateCallBackWithParameters
	{
		get
		{
			return _DelegateCallBackWithParameters;
		}
		set
		{
			_DelegateCallBackWithParameters = value;
			CallBackType = CallBackTypeEnum.DelegateWithParameters;
		}
	}

	public string CallBackFunctionName
	{
		get
		{
			return _CallBackFunctionName;
		}
		set
		{
			_CallBackFunctionName = value;
			CallBackType = CallBackTypeEnum.CallByNameFunction;
		}
	}

	public string CallBackCancelFunctionName
	{
		get
		{
			return _CallBackCancelFunctionName;
		}
		set
		{
			_CallBackCancelFunctionName = value;
		}
	}

	public object Parameters
	{
		get
		{
			return _Parameters;
		}
		set
		{
			_Parameters = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public WFIMessageBoxState State
	{
		get
		{
			return _State;
		}
		set
		{
			_State = value;
		}
	}

	public WFIUserMessage()
	{
		_Message1 = "";
		_Message2 = "";
		_Title = "";
		_CssClass = "";
		_UserChoice = MessageUserChoice.Undefined;
		_NeedToRefresh = false;
		_Parameters = null;
		_TipoMessageBox = TipoMessageBox.OkOnly;
		_Funzione = "";
		_Tag = "";
		_State = WFIMessageBoxState.Idle;
		_MessageBoxImage = MessageBoxImage.NotSet;
		_CallBackFunctionName = "";
		_CallBackCancelFunctionName = "";
		_CallBackType = CallBackTypeEnum.StandardDelegate;
		Height = 0;
		Width = 0;
		ShowAsNotification = false;
	}

	public void Reset()
	{
		_Message1 = "";
		_Message2 = "";
		_UserChoice = MessageUserChoice.Undefined;
		_Title = "";
		_NeedToRefresh = false;
		_TipoMessageBox = TipoMessageBox.OkOnly;
		_DelegateCallBack = null;
		_DelegateCallBackWithParameters = null;
		_Parameters = null;
		_State = WFIMessageBoxState.Idle;
		_MessageBoxImage = MessageBoxImage.NotSet;
		_CallBackFunctionName = "";
		_Tag = "";
		_CssClass = "";
	}
}
