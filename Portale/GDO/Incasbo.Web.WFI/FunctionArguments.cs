using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using Incasbo.Web.WFI.ObjectManager;

namespace Incasbo.Web.WFI;

public class FunctionArguments
{
	protected string _Context;

	protected string _Name;

	protected DataKeyFieldCollection _Data;

	protected DataKeyFieldValues[] _Keys;

	protected bool _Handled;

	protected string _CallerPath;

	protected string _CallerQueryString;

	protected string _QueryStringToAddWhenReturning;

	protected string _SqlFilter;

	protected object _Argomento1;

	protected object _Argomento2;

	protected object _Argomento3;

	protected object _Argomento4;

	protected object _Argomento5;

	protected object _Argomento6;

	protected object _Argomento7;

	protected AbstractObjectManager _ObjectManager;

	protected Hashtable _Parameters;

	protected bool _OpenInIFrame;

	protected string _IFrameTag;

	protected WFIPage _WFIPage;

	public string Target { get; set; }

	public DataKeyFieldValues[] Keys
	{
		get
		{
			return _Keys;
		}
		set
		{
			_Keys = value;
		}
	}

	public int FieldValuesCount
	{
		get
		{
			if (_Data.Count > 0)
			{
				return _Data[0].FieldValuesCount;
			}
			int result = default(int);
			return result;
		}
	}

	public string CallerPath
	{
		get
		{
			return _CallerPath;
		}
		set
		{
			_CallerPath = value;
		}
	}

	public bool OpenInIFrame
	{
		get
		{
			return _OpenInIFrame;
		}
		set
		{
			_OpenInIFrame = value;
		}
	}

	public string IFrameTag
	{
		get
		{
			return _IFrameTag;
		}
		set
		{
			_IFrameTag = value;
		}
	}

	public string SqlFilter
	{
		get
		{
			return _SqlFilter;
		}
		set
		{
			_SqlFilter = value;
		}
	}

	public string CallerQueryString
	{
		get
		{
			return _CallerQueryString;
		}
		set
		{
			_CallerQueryString = value;
		}
	}

	public string QueryStringToAddWhenReturning
	{
		get
		{
			return _QueryStringToAddWhenReturning;
		}
		set
		{
			_QueryStringToAddWhenReturning = value;
		}
	}

	public string Context
	{
		get
		{
			return _Context;
		}
		set
		{
			_Context = value;
		}
	}

	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value;
		}
	}

	public DataKeyFieldCollection Data
	{
		get
		{
			return _Data;
		}
		set
		{
			_Data = value;
		}
	}

	public bool Handled
	{
		get
		{
			return _Handled;
		}
		set
		{
			_Handled = value;
		}
	}

	public object Argomento1
	{
		get
		{
			return _Argomento1;
		}
		set
		{
			_Argomento1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Argomento2
	{
		get
		{
			return _Argomento2;
		}
		set
		{
			_Argomento2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Argomento3
	{
		get
		{
			return _Argomento3;
		}
		set
		{
			_Argomento3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Argomento4
	{
		get
		{
			return _Argomento4;
		}
		set
		{
			_Argomento4 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Argomento5
	{
		get
		{
			return _Argomento5;
		}
		set
		{
			_Argomento5 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Argomento6
	{
		get
		{
			return _Argomento6;
		}
		set
		{
			_Argomento6 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Argomento7
	{
		get
		{
			return _Argomento7;
		}
		set
		{
			_Argomento7 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public AbstractObjectManager ObjectManager
	{
		get
		{
			return _ObjectManager;
		}
		set
		{
			_ObjectManager = value;
		}
	}

	public Hashtable Parameters => _Parameters;

	public WFIPage WFIPage
	{
		get
		{
			return _WFIPage;
		}
		set
		{
			_WFIPage = value;
		}
	}

	public FunctionArguments(string vsContext, string vsFunction)
	{
		_Data = new DataKeyFieldCollection();
		_CallerPath = "";
		_CallerQueryString = "";
		_QueryStringToAddWhenReturning = "";
		_SqlFilter = "";
		_Argomento1 = null;
		_Argomento2 = null;
		_Argomento3 = null;
		_Argomento4 = null;
		_Argomento5 = null;
		_Argomento6 = null;
		_Argomento7 = null;
		_ObjectManager = null;
		_Parameters = new Hashtable();
		_OpenInIFrame = false;
		_IFrameTag = "";
		_WFIPage = null;
		Target = "";
		_Context = vsContext;
		_Name = vsFunction;
		Reset();
	}

	public FunctionArguments(string vsContext, string vsFunction, DataKeyFieldCollection robjData)
	{
		_Data = new DataKeyFieldCollection();
		_CallerPath = "";
		_CallerQueryString = "";
		_QueryStringToAddWhenReturning = "";
		_SqlFilter = "";
		_Argomento1 = null;
		_Argomento2 = null;
		_Argomento3 = null;
		_Argomento4 = null;
		_Argomento5 = null;
		_Argomento6 = null;
		_Argomento7 = null;
		_ObjectManager = null;
		_Parameters = new Hashtable();
		_OpenInIFrame = false;
		_IFrameTag = "";
		_WFIPage = null;
		Target = "";
		_Context = vsContext;
		_Name = vsFunction;
		_Data = robjData;
		Reset();
	}

	public FunctionArguments(string vsContext, DataKeyFieldCollection robjData)
	{
		_Data = new DataKeyFieldCollection();
		_CallerPath = "";
		_CallerQueryString = "";
		_QueryStringToAddWhenReturning = "";
		_SqlFilter = "";
		_Argomento1 = null;
		_Argomento2 = null;
		_Argomento3 = null;
		_Argomento4 = null;
		_Argomento5 = null;
		_Argomento6 = null;
		_Argomento7 = null;
		_ObjectManager = null;
		_Parameters = new Hashtable();
		_OpenInIFrame = false;
		_IFrameTag = "";
		_WFIPage = null;
		Target = "";
		_Data = robjData;
		_Context = vsContext;
		Reset();
	}

	public FunctionArguments(DataKeyFieldCollection robjData)
	{
		_Data = new DataKeyFieldCollection();
		_CallerPath = "";
		_CallerQueryString = "";
		_QueryStringToAddWhenReturning = "";
		_SqlFilter = "";
		_Argomento1 = null;
		_Argomento2 = null;
		_Argomento3 = null;
		_Argomento4 = null;
		_Argomento5 = null;
		_Argomento6 = null;
		_Argomento7 = null;
		_ObjectManager = null;
		_Parameters = new Hashtable();
		_OpenInIFrame = false;
		_IFrameTag = "";
		_WFIPage = null;
		Target = "";
		_Data = robjData;
		Reset();
	}

	public FunctionArguments(DataKeyFieldCollection robjData, DataKeyFieldValues[] rKeys)
	{
		_Data = new DataKeyFieldCollection();
		_CallerPath = "";
		_CallerQueryString = "";
		_QueryStringToAddWhenReturning = "";
		_SqlFilter = "";
		_Argomento1 = null;
		_Argomento2 = null;
		_Argomento3 = null;
		_Argomento4 = null;
		_Argomento5 = null;
		_Argomento6 = null;
		_Argomento7 = null;
		_ObjectManager = null;
		_Parameters = new Hashtable();
		_OpenInIFrame = false;
		_IFrameTag = "";
		_WFIPage = null;
		Target = "";
		_Data = robjData;
		_Keys = rKeys;
		Reset();
	}

	public void Reset()
	{
		_Handled = false;
		_CallerPath = HttpContext.Current.Request.Path;
		_CallerQueryString = HttpContext.Current.Request.QueryString.ToString();
		if (_CallerPath.ToUpper().Contains("WFFUNCTIONMANAGER.ASPX") && HttpContext.Current.Handler is WFIPage)
		{
			Queue<string> source = HttpContext.Current.Session["LastWfiPages"] as Queue<string>;
			string text = source.LastOrDefault();
			string[] array = text.Split(new char[1] { '?' });
			_CallerPath = array[0];
			if (array.Count() > 1)
			{
				_CallerQueryString = array[1];
			}
			else
			{
				_CallerQueryString = "";
			}
		}
	}
}
