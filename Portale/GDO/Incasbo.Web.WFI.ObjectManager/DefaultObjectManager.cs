using System;
using System.Collections;
using System.Data;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI.ObjectManager;

public class DefaultObjectManager : GenericObjectManager
{
	public void SetRedirectTo(string RedirectTo)
	{
		_RedirectTo = RedirectTo;
	}

	public void SetRedirectToIns(string RedirectToIns)
	{
		_RedirectToIns = RedirectToIns;
	}

	public void SetRedirectToMod(string RedirectToMod)
	{
		_RedirectToMod = RedirectToMod;
	}

	public void SetRedirectToDup(string RedirectToDup)
	{
		_RedirectToDup = RedirectToDup;
	}

	public void SetRedirectToDel(string RedirectToDel)
	{
		_RedirectToDel = RedirectToDel;
	}

	public void SetRedirectToVis(string RedirectToVis)
	{
		_RedirectToVis = RedirectToVis;
	}

	public void SetFilterPage(string FilterPage)
	{
		_FilterPage = FilterPage;
	}

	public void SetFilterPageParameters(string FilterPageParameters)
	{
		_FilterPageParameters = FilterPageParameters;
	}

	public void SetObjectTableName(string ObjectTableName)
	{
		_ObjectTableName = ObjectTableName;
	}

	public DefaultObjectManager()
	{
		_ObjectManagerName = "Default";
		_RedirectTo = "";
	}

	public DefaultObjectManager(string vsObjectManagerName)
	{
		_ObjectManagerName = vsObjectManagerName.ToUpper();
	}

	public override void Init(ref IboSessionEnvironment robjSessionEnvironment)
	{
		IboAppCallStackHandling rObjCallStackHandler = robjSessionEnvironment.CallStackHandler;
		IboAppLogHandling rObjIboAppLogHandling = robjSessionEnvironment.LogHandling;
		DBConnection rObjDbMain = robjSessionEnvironment.DbConn;
		IncasTranslator rObjTranslator = robjSessionEnvironment.Translator;
		IboWebUserInfo rObjWebUserInfo = robjSessionEnvironment.WebUser.WebUserInfo;
		Init(ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo);
	}

	public override void Init(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Invalid comparison between Unknown and I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Invalid comparison between Unknown and I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		DataTable dataTable = null;
		string message = "";
		base.Init(ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo);
		text = "SELECT * FROM WFI_OBJECTMANAGER WHERE CODICE=" + _ObjDbMain.SQLFormatString(_ObjectManagerName.ToUpper());
		if ((int)_ObjDbMain.OpenDataTable(text, ref dataTable, ref message) > 0)
		{
			throw new Exception(message);
		}
		if (dataTable.Rows.Count > 0)
		{
			_RedirectTo = dataTable.Rows[0]["REDIRECT_TO"].ToString();
			_RedirectToIns = dataTable.Rows[0]["REDIRECT_TO_INS"].ToString();
			_RedirectToDup = dataTable.Rows[0]["REDIRECT_TO_DUP"].ToString();
			_RedirectToMod = dataTable.Rows[0]["REDIRECT_TO_MOD"].ToString();
			_RedirectToVis = dataTable.Rows[0]["REDIRECT_TO_VIS"].ToString();
			_RedirectToDel = dataTable.Rows[0]["REDIRECT_TO_DEL"].ToString();
			_ObjectTableName = dataTable.Rows[0]["TABLENAME"].ToString();
			_Description = dataTable.Rows[0]["DESCRIZIONE"].ToString();
			_FilterPage = dataTable.Rows[0]["FILTERPAGE"].ToString();
			_FilterPageParameters = dataTable.Rows[0]["FilterPageParameters"].ToString();
			_EntityName = dataTable.Rows[0]["EntityName"].ToString();
			if (dataTable.Columns.Contains("Options"))
			{
				_Options = dataTable.Rows[0]["Options"].ToString();
			}
			if (Operators.CompareString(_Options, "", false) != 0)
			{
				string options = _Options;
				ref Hashtable optionsCollection = ref _OptionsCollection;
				string rsMess = "";
				StandardParser(options, ref optionsCollection, ref rsMess);
			}
		}
		bool flag = false;
		if ((int)_ObjDbMain.TableOrViewExists("WFI_OBJECTMANAGER_CONDITIONS", ref flag, ref message) > 0)
		{
			throw new Exception(message);
		}
		if (flag)
		{
			text = "SELECT * FROM WFI_OBJECTMANAGER_CONDITIONS WHERE CODICE=" + _ObjDbMain.SQLFormatString(_ObjectManagerName.ToUpper());
			if ((int)_ObjDbMain.OpenDataTable(text, ref _dtObjectManagerConditions, ref message) > 0)
			{
				throw new Exception(message);
			}
		}
	}
}
