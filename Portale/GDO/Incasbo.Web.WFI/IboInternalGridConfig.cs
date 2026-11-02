using System;
using System.Collections;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class IboInternalGridConfig
{
	protected string _Id;

	protected string _NomRif;

	protected string _SqlStatement;

	protected string _LastSortedSqlStatement;

	protected string _SqlOriginalStatement;

	protected Hashtable _SqlStatementVariables;

	protected string _OrderByField;

	protected string _OrderByDirection;

	protected string _ToolbarId;

	protected string _Title;

	protected string _ActionControlId;

	protected IboWebGridConfig _GridConfig;

	protected IboGridInfo _GridInfo;

	protected IboGridView _gridView;

	protected RadGrid _gridViewTlk;

	protected IboWebToolbar _Toolbar;

	protected DataTable _dtDati;

	protected IboWebLabel _lblTitle;

	public IboWebToolbarInfo ToolbarInfo;

	public IboWebToolbarConfig ToolbarConfig;

	public bool Attivo { get; set; }

	public IboInternalGridSourceType SourceType { get; set; }

	public IboInternalGridGridType GridType { get; set; }

	public bool VisibleInDupMode { get; set; }

	public bool ForceEnableInVisMode { get; set; }

	public IboGridView GridView
	{
		get
		{
			return _gridView;
		}
		set
		{
			_gridView = value;
		}
	}

	public RadGrid GridViewTlk
	{
		get
		{
			return _gridViewTlk;
		}
		set
		{
			_gridViewTlk = value;
		}
	}

	public IboWebLabel lblTitle => _lblTitle;

	public Hashtable SqlStatementVariables
	{
		get
		{
			return _SqlStatementVariables;
		}
		set
		{
			_SqlStatementVariables = value;
		}
	}

	public IboGridInfo GridInfo
	{
		get
		{
			return _GridInfo;
		}
		set
		{
			_GridInfo = value;
		}
	}

	public IboWebGridConfig GridConfig
	{
		get
		{
			return _GridConfig;
		}
		set
		{
			_GridConfig = value;
		}
	}

	public DataTable DataTable
	{
		get
		{
			return _dtDati;
		}
		set
		{
			_dtDati = value;
		}
	}

	public string NomRif
	{
		get
		{
			return _NomRif;
		}
		set
		{
			_NomRif = value;
		}
	}

	public string Id
	{
		get
		{
			return _Id;
		}
		set
		{
			_Id = value;
		}
	}

	public string ToolbarId
	{
		get
		{
			return _ToolbarId;
		}
		set
		{
			_ToolbarId = value;
		}
	}

	public string SqlOriginalStatement
	{
		get
		{
			return _SqlOriginalStatement;
		}
		set
		{
			_SqlOriginalStatement = value;
			if (Operators.CompareString(SqlStatement, "", false) == 0)
			{
				SqlStatement = value;
			}
		}
	}

	public string SqlStatement
	{
		get
		{
			return _SqlStatement;
		}
		set
		{
			_SqlStatement = value;
		}
	}

	public string LastSortedSqlStatement
	{
		get
		{
			return (Operators.CompareString(_LastSortedSqlStatement, "", false) != 0) ? _LastSortedSqlStatement : _SqlStatement;
		}
		set
		{
			_LastSortedSqlStatement = value;
		}
	}

	public string OrderByField
	{
		get
		{
			return _OrderByField;
		}
		set
		{
			_OrderByField = value;
		}
	}

	public string OrderByDirection
	{
		get
		{
			return _OrderByDirection;
		}
		set
		{
			_OrderByDirection = value;
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

	public string ActionControlId
	{
		get
		{
			return _ActionControlId;
		}
		set
		{
			_ActionControlId = value;
		}
	}

	public string RedirectTo
	{
		get
		{
			string result;
			try
			{
				result = ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).ObjManagerFactory.GetManager(GridInfo.ObjectManagerName).RedirectTo;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string RedirectToIns
	{
		get
		{
			string result;
			try
			{
				result = ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).ObjManagerFactory.GetManager(GridInfo.ObjectManagerName).RedirectToIns;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string RedirectToMod
	{
		get
		{
			string result;
			try
			{
				result = ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).ObjManagerFactory.GetManager(GridInfo.ObjectManagerName).RedirectToMod;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string RedirectToDup
	{
		get
		{
			string result;
			try
			{
				result = ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).ObjManagerFactory.GetManager(GridInfo.ObjectManagerName).RedirectToDup;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string RedirectToDel
	{
		get
		{
			string result;
			try
			{
				result = ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).ObjManagerFactory.GetManager(GridInfo.ObjectManagerName).RedirectToDel;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string RedirectToVis
	{
		get
		{
			string result;
			try
			{
				result = ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).ObjManagerFactory.GetManager(GridInfo.ObjectManagerName).RedirectToVis;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string RedirectToOnlyAspxPageName
	{
		get
		{
			string result;
			try
			{
				string text = Strings.Replace(RedirectTo, "/", "\\", 1, -1, (CompareMethod)0);
				if (Strings.InStrRev(text, "\\", -1, (CompareMethod)0) >= 0)
				{
					text = Strings.Mid(text, checked(Strings.InStrRev(text, "\\", -1, (CompareMethod)0) + 1));
				}
				result = text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

// Proprieta' VB con parametro, convertita in metodi
	public string get_RedirectToOnlyAspxPageName(string Modalita)
	{
		string result;
		try
		{
			string text = "";
			if (Operators.CompareString(Modalita.ToUpper(), "INSERIMENTO".ToUpper(), false) == 0)
			{
				text = RedirectToIns;
			}
			else if (Operators.CompareString(Modalita.ToUpper(), "MODIFICA".ToUpper(), false) == 0)
			{
				text = RedirectToMod;
			}
			else if (Operators.CompareString(Modalita.ToUpper(), "DUPLICAZIONE".ToUpper(), false) == 0)
			{
				text = RedirectToDup;
			}
			else if (Operators.CompareString(Modalita.ToUpper(), "VISUALIZZAZIONE".ToUpper(), false) == 0)
			{
				text = RedirectToVis;
			}
			else if (Operators.CompareString(Modalita.ToUpper(), "CANCELLAZIONE".ToUpper(), false) == 0)
			{
				text = RedirectToDel;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				text = RedirectTo;
			}
			string text2 = Strings.Replace(text, "/", "\\", 1, -1, (CompareMethod)0);
			if (Strings.InStrRev(text2, "\\", -1, (CompareMethod)0) >= 0)
			{
				text2 = Strings.Mid(text2, checked(Strings.InStrRev(text2, "\\", -1, (CompareMethod)0) + 1));
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}


	public IboInternalGridConfig()
	{
		_Id = "";
		_NomRif = "";
		_SqlStatement = "";
		_LastSortedSqlStatement = "";
		_SqlOriginalStatement = "";
		_OrderByField = "";
		_OrderByDirection = "";
		_ToolbarId = "";
		_Title = "";
		_ActionControlId = "";
		_GridConfig = null;
		_GridInfo = null;
		_gridView = null;
		_gridViewTlk = null;
		_dtDati = null;
		_lblTitle = null;
		ToolbarInfo = null;
		ToolbarConfig = null;
		Attivo = true;
		SourceType = IboInternalGridSourceType.FromSql;
		GridType = IboInternalGridGridType.Microsoft;
		VisibleInDupMode = false;
		ForceEnableInVisMode = false;
	}

	public virtual void Build(string sNomRif, ref DataTable objDataTable, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar, string sTitle, string sActionControlId)
	{
		Build(sNomRif, "", sOrderByField, sOrderByDirection, sIdGrid, sIdToolBar, sTitle, sActionControlId);
		DataTable = objDataTable;
		SourceType = IboInternalGridSourceType.FromDataTable;
	}

	public virtual void Build(string sNomRif, string sSqlOriginalStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar, string sTitle, string sActionControlId)
	{
		_NomRif = sNomRif.ToUpper();
		_SqlStatement = sSqlOriginalStatement;
		_SqlOriginalStatement = sSqlOriginalStatement;
		_OrderByField = sOrderByField;
		_OrderByDirection = sOrderByDirection;
		_Id = sIdGrid;
		_ToolbarId = sIdToolBar;
		_Title = sTitle;
		_ActionControlId = sActionControlId;
		WebControl val = null;
		if (_gridView != null)
		{
			val = (WebControl)(object)_gridView;
			GridType = IboInternalGridGridType.Microsoft;
		}
		else
		{
			val = (WebControl)(object)_gridViewTlk;
			GridType = IboInternalGridGridType.Telerik;
		}
	}

	public virtual void Build(string sNomRif, string sSqlOriginalStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar, string sTitle)
	{
		Build(sNomRif, sSqlOriginalStatement, sOrderByField, sOrderByDirection, sIdGrid, sIdToolBar, sTitle, "");
	}

	public virtual void Build(string sNomRif, string sSqlStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar)
	{
		Build(sNomRif, sSqlStatement, sOrderByField, sOrderByDirection, sIdGrid, sIdToolBar, "");
	}

	public void InitUi(StateBag ObjViewState, ref IboGridView objGridView, ref IboWebLabel objTitle)
	{
		_gridView = objGridView;
		_gridViewTlk = null;
		_lblTitle = objTitle;
	}

	public void InitUi(StateBag ObjViewState, ref RadGrid objGridViewTlk, ref IboWebLabel objTitle)
	{
		_gridViewTlk = objGridViewTlk;
		_gridView = null;
		_lblTitle = objTitle;
	}

	public void InitUi(StateBag ObjViewState, ref IboGridView objGridView)
	{
		IboWebLabel objTitle = null;
		InitUi(ObjViewState, ref objGridView, ref objTitle);
	}

	public void InitUi(StateBag ObjViewState, ref RadGrid objGridViewTlk)
	{
		IboWebLabel objTitle = null;
		InitUi(ObjViewState, ref objGridViewTlk, ref objTitle);
	}
}
