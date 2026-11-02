using System;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIUserSelect
{
	public enum SelectUserDialogResult
	{
		Undefined,
		Conferma,
		Annulla
	}

	public enum SelectUserDialogType
	{
		RadioButtonList,
		DropDownList
	}

	public enum CallBackTypeEnum
	{
		StandardDelegate,
		DelegateWithParameters,
		CallByNameFunction
	}

	protected string _Title;

	protected string _Subtitle;

	protected string _Text;

	protected SelectUserDialogResult _UserDialogResult;

	protected bool _NeedToRefresh;

	protected FuncToCallAfterSelectConfirm _DelegateCallBack;

	protected string _Funzione;

	protected string _Values;

	protected SelectUserDialogType _Type;

	protected string _Selected;

	protected string _Default;

	protected string _Tag;

	protected FuncToCallAfterSelectConfirmWithParameters _DelegateCallBackWithParameters;

	protected object _Parameters;

	protected string _CallBackFunctionName;

	protected CallBackTypeEnum _CallBackType;

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

	public string Subtitle
	{
		get
		{
			return _Subtitle;
		}
		set
		{
			_Subtitle = value;
		}
	}

	public string Text
	{
		get
		{
			return _Text;
		}
		set
		{
			_Text = value;
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

	public string Values
	{
		get
		{
			return _Values;
		}
		set
		{
			_Values = value;
		}
	}

	public SelectUserDialogResult UserDialogResult
	{
		get
		{
			return _UserDialogResult;
		}
		set
		{
			_UserDialogResult = value;
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

	public FuncToCallAfterSelectConfirm DelegateCallBack
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

	public FuncToCallAfterSelectConfirmWithParameters DelegateCallBackWithParameters
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

	public SelectUserDialogType Type
	{
		get
		{
			return _Type;
		}
		set
		{
			_Type = value;
		}
	}

	public string Selected
	{
		get
		{
			return _Selected;
		}
		set
		{
			_Selected = value;
		}
	}

	public string DefaultSelected
	{
		get
		{
			return _Default;
		}
		set
		{
			_Default = value;
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

	public WFIUserSelect()
	{
		_Title = "";
		_Subtitle = "";
		_Text = "";
		_UserDialogResult = SelectUserDialogResult.Undefined;
		_NeedToRefresh = false;
		_Funzione = "";
		_Values = "";
		_Type = SelectUserDialogType.DropDownList;
		_Selected = "";
		_Default = "";
		_Tag = "";
		_Parameters = null;
		_CallBackFunctionName = "";
		_CallBackType = CallBackTypeEnum.StandardDelegate;
	}

	public void Reset()
	{
		_UserDialogResult = SelectUserDialogResult.Undefined;
		_Title = "";
		_NeedToRefresh = false;
		_DelegateCallBack = null;
		_Subtitle = "";
		_Text = "";
		_Funzione = "";
		_Values = "";
		_Type = SelectUserDialogType.DropDownList;
		_Selected = "";
		_Default = "";
		_Tag = "";
		_DelegateCallBackWithParameters = null;
		_Parameters = null;
		_CallBackFunctionName = "";
		_CallBackType = CallBackTypeEnum.StandardDelegate;
	}

	public void PopulateList(ref IboDropDownList robjDropDownList)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		string[] array = null;
		bool flag = false;
		string text = "";
		checked
		{
			try
			{
				array = _Values.Split(new char[1] { ';' });
				((ListControl)robjDropDownList).Items.Clear();
				int i = default(int);
				for (; i < array.Length; i += 2)
				{
					if (Operators.CompareString(text, "", false) == 0)
					{
						text = array[i + 1];
					}
					((ListControl)robjDropDownList).Items.Add(new ListItem(array[i], array[i + 1]));
				}
				if (Operators.CompareString(_Default, "", false) != 0)
				{
					robjDropDownList.ObjValue = _Default;
				}
				if (Operators.CompareString(robjDropDownList.ObjValue.ToString(), "", false) == 0)
				{
					robjDropDownList.ObjValue = text;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (!flag)
				{
					((ListControl)robjDropDownList).Items.Clear();
					robjDropDownList.Enabled = false;
				}
			}
		}
	}

	public void PopulateList(ref IboWebRadioButtonList robjRadioButtonList)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		string[] array = null;
		bool flag = false;
		string text = "";
		checked
		{
			try
			{
				array = _Values.Split(new char[1] { ';' });
				((ListControl)robjRadioButtonList).Items.Clear();
				int i = default(int);
				for (; i < array.Length; i += 2)
				{
					if (Operators.CompareString(text, "", false) == 0)
					{
						text = array[i + 1];
					}
					((ListControl)robjRadioButtonList).Items.Add(new ListItem(array[i], array[i + 1]));
				}
				if (Operators.CompareString(_Default, "", false) != 0)
				{
					robjRadioButtonList.ObjValue = _Default;
				}
				if (Operators.CompareString(robjRadioButtonList.ObjValue.ToString(), "", false) == 0)
				{
					robjRadioButtonList.ObjValue = text;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (!flag)
				{
					((ListControl)robjRadioButtonList).Items.Clear();
					robjRadioButtonList.Enabled = false;
				}
			}
		}
	}
}
