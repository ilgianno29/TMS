using System.Web.UI.WebControls;

namespace Incasbo.Web.WFI;

public class InternalPageDetailViewMessage
{
	public enum MessageUserChoice
	{
		Undefined,
		Conferma,
		Annulla,
		Ok,
		Yes,
		No
	}

	protected string _Title;

	protected MessageUserChoice _UserChoice;

	protected bool _NeedToRefresh;

	protected FuncToCallAfterConfirm _DelegateCallBack;

	protected string _Funzione;

	protected WebControl _ChildControls;

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

	public WebControl ChildControl
	{
		get
		{
			return _ChildControls;
		}
		set
		{
			_ChildControls = value;
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
		}
	}

	public InternalPageDetailViewMessage()
	{
		_Title = "";
		_UserChoice = MessageUserChoice.Undefined;
		_NeedToRefresh = false;
		_Funzione = "";
		_ChildControls = null;
	}

	public void Reset()
	{
		_UserChoice = MessageUserChoice.Undefined;
		_Title = "";
		_NeedToRefresh = false;
		_DelegateCallBack = null;
		_ChildControls = null;
	}
}
