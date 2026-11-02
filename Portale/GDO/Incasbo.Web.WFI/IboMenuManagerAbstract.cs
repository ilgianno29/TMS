using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public abstract class IboMenuManagerAbstract : IDisposable
{
	protected class WFIMenuNodeTree
	{
		public DataRow NodeDataRow { get; set; }

		public DataRow[] ChildsDataRow { get; set; }

		public List<WFIMenuNodeTree> Childs { get; set; }

		public WFIMenuNodeTree()
		{
			Childs = new List<WFIMenuNodeTree>();
		}
	}

	protected class WFIMenuTree
	{
		public WFIMenuNodeTree ParentTreeNode { get; set; }

		public bool Initialized { get; set; }

		public WFIMenuTree()
		{
			ParentTreeNode = new WFIMenuNodeTree();
			Initialized = false;
		}
	}

	protected DataTable _dt;

	protected DataTable _dtDeskTop;

	protected DataTable _dtFunctionList;

	protected DataTable _dtMostUsed;

	protected DataTable _dtElencoFiliali;

	protected IboAppCallStackHandling _objCallStackHandler;

	protected DBConnection _objDbConnection;

	protected IboAppLogHandling _objLogHandling;

	protected IboWebUserInfo _objWebUserInfo;

	protected IboWebParam _objParam;

	protected bool _ViewShortcut;

	protected IncasTranslator _Translator;

	protected WebSessionEnvironment _SessionEnvironment;

	protected WFIMenuTree _MenuTree;

	protected char kTipoNodoFunzione;

	protected char kTipoNodoParent;

	protected char kTipoNodoNavigate;

	protected char kTipoNodoExtended;

	protected char kTipoNodoLink;

	protected char kTipoNodoCaption;

	private bool disposedValue;

	[SpecialName]
	private int _0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init;

	[SpecialName]
	private int _0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init;

	[SpecialName]
	private int _0024STATIC_0024BuildMenu_00242021180A91012848910E_0024iCount;

	protected string ImagesPath => "~/WFI/images/";

	public DataTable FunctionListDatatable => _dtFunctionList;

	protected IboMenuManagerAbstract(ref WebSessionEnvironment rObjSessionEnvironment)
	{
		_dt = null;
		_dtDeskTop = null;
		_dtFunctionList = null;
		_dtMostUsed = null;
		_dtElencoFiliali = null;
		_ViewShortcut = false;
		kTipoNodoFunzione = 'F';
		kTipoNodoParent = 'P';
		kTipoNodoNavigate = 'N';
		kTipoNodoExtended = 'X';
		kTipoNodoLink = 'L';
		kTipoNodoCaption = 'C';
		disposedValue = false;
		_SessionEnvironment = rObjSessionEnvironment;
		_objDbConnection = _SessionEnvironment.DbConn;
		_objLogHandling = _SessionEnvironment.LogHandling;
		_objCallStackHandler = _SessionEnvironment.CallStackHandler;
		_objWebUserInfo = _SessionEnvironment.WebUser.WebUserInfo;
		_objParam = _SessionEnvironment.Parametrica;
		_Translator = _SessionEnvironment.Translator;
		_ViewShortcut = true;
	}

	public static IboMenuManagerAbstract GetMenuManagerInstance(ref WebSessionEnvironment rObjSessionEnvironment)
	{
		if (Operators.CompareString(rObjSessionEnvironment.WFIConfig.MenuManagerConfig.UseVersion, "2", false) == 0)
		{
			return new IboMenuManagerV2(ref rObjSessionEnvironment);
		}
		return new IboMenuManager(ref rObjSessionEnvironment);
	}

	public virtual FXRETURN LoadFromDatabase(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Invalid comparison between Unknown and I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Invalid comparison between Unknown and I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Invalid comparison between Unknown and I4
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Invalid comparison between Unknown and I4
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Invalid comparison between Unknown and I4
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Invalid comparison between Unknown and I4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		string text3 = "";
		string text4 = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM (";
			text += "SELECT UT.CODICE UTENTE, ";
			text += "CASE WHEN (UT.TIPO='U' AND UT.CODICE<>'XXX') THEN 1 ";
			text += "WHEN (UT.TIPO='G' AND UT.CODICE<>'XXX') THEN 2 ";
			text += "WHEN (UT.TIPO='O' AND UT.CODICE<>'XXX') THEN 3 ";
			text += "WHEN (UT.TIPO='T' AND UT.CODICE<>'XXX') THEN 4 ";
			text += "ELSE 5 END PESO ";
			text += "FROM WFI_MENU_UTENTE UU INNER JOIN WFI_MENU_VOCI VV ON UU.VOCE = VV.VOCE ";
			text += "INNER JOIN WFI_UTENTI UT ON UT.CODICE=UU.UTENTE ";
			text += "WHERE UU.VISIBILE='S' ";
			text += "AND VV.VISIBILE='S' ";
			text += "AND UU.UTENTE IN (<%XXX%>, <%UTENTE%>, <%GRUPPO%>, <%ORGANIZZAZIONE%>, <%TIPOORGANIZZAZIONE%>) ";
			text += "GROUP BY UT.CODICE, UT.TIPO, PESO) T ";
			text += "ORDER BY PESO";
			text = text.Replace("<%UTENTE%>", _objDbConnection.SQLFormatString(_objWebUserInfo.Codice));
			text = text.Replace("<%GRUPPO%>", _objDbConnection.SQLFormatString(_objWebUserInfo.Gruppo));
			text = text.Replace("<%ORGANIZZAZIONE%>", _objDbConnection.SQLFormatString(_objWebUserInfo.Organizzazione));
			text = text.Replace("<%TIPOORGANIZZAZIONE%>", _objDbConnection.SQLFormatString(_objWebUserInfo.OrganizzazioneTipoSoggetto));
			text = ((Operators.CompareString(_objWebUserInfo.OrganizzazioneInternaEsterna, "I", false) != 0) ? text.Replace("<%XXX%>", _objDbConnection.SQLFormatString("YYY")) : text.Replace("<%XXX%>", _objDbConnection.SQLFormatString("XXX")));
			text2 = text;
			val2 = _objDbConnection.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dataTable.Rows.Count == 0)
			{
				rsMess = _Translator.TranslateMessage("XXX", "Menu non configurato per l'utente {0} ", new string[1] { _objWebUserInfo.Codice });
				val = (FXRETURN)16;
			}
			else
			{
				text3 = dataTable.Rows[0]["Utente"].ToString();
				text = "SELECT VV.VOCE AS MNUCODICE, UU.PROGRESSIVO AS MNUID, UU.PARENT AS MNUPARENT, UU.ORDINE, ";
				text += "VV.DESCRIZIONE, VV.TEXT, VV.FUNZIONE, VV.TIPONODO, ";
				text += "VV.IMMAGINE, VV.TOOLTIP, VV.ACTIONCODE, UU.SEPARA, VV.CSSCLASS ";
				text += "FROM WFI_MENU_UTENTE UU INNER JOIN WFI_MENU_VOCI VV ON UU.VOCE = VV.VOCE ";
				text += "WHERE UU.VISIBILE='S' ";
				text += "AND VV.VISIBILE='S' ";
				text = text + "AND UU.UTENTE=" + _objDbConnection.SQLFormatString(text3);
				text2 = text;
				val2 = _objDbConnection.OpenDataTable(text2, ref _dt, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = TranslateMenuItems(ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						text = "SELECT * FROM (";
						text += "SELECT UT.CODICE UTENTE, ";
						text += "CASE WHEN (UT.TIPO='U' AND UT.CODICE<>'XXX') THEN 1 ";
						text += "WHEN (UT.TIPO='G' AND UT.CODICE<>'XXX') THEN 2 ";
						text += "WHEN (UT.TIPO='O' AND UT.CODICE<>'XXX') THEN 3 ";
						text += "WHEN (UT.TIPO='T' AND UT.CODICE<>'XXX') THEN 4 ";
						text += "ELSE 5 END PESO ";
						text += "FROM WFI_DESKTOP_UTENTE UU INNER JOIN WFI_MENU_VOCI VV ON UU.VOCE = VV.VOCE ";
						text += "INNER JOIN WFI_UTENTI UT ON UT.CODICE=UU.UTENTE ";
						text += "WHERE UU.VISIBILE='S' ";
						text += "AND VV.VISIBILE='S' ";
						text += "AND UU.UTENTE IN (<%XXX%>, <%UTENTE%>, <%GRUPPO%>, <%ORGANIZZAZIONE%>, <%TIPOORGANIZZAZIONE%>) ";
						text += "GROUP BY UT.CODICE, UT.TIPO, PESO) T ";
						text += "ORDER BY PESO";
						text = text.Replace("<%UTENTE%>", _objDbConnection.SQLFormatString(_objWebUserInfo.Codice));
						text = text.Replace("<%GRUPPO%>", _objDbConnection.SQLFormatString(_objWebUserInfo.Gruppo));
						text = text.Replace("<%ORGANIZZAZIONE%>", _objDbConnection.SQLFormatString(_objWebUserInfo.Organizzazione));
						text = text.Replace("<%TIPOORGANIZZAZIONE%>", _objDbConnection.SQLFormatString(_objWebUserInfo.OrganizzazioneTipoSoggetto));
						text = ((Operators.CompareString(_objWebUserInfo.OrganizzazioneInternaEsterna, "I", false) != 0) ? text.Replace("<%XXX%>", _objDbConnection.SQLFormatString("YYY")) : text.Replace("<%XXX%>", _objDbConnection.SQLFormatString("XXX")));
						text2 = text;
						val2 = _objDbConnection.OpenDataTable(text2, ref dataTable, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							text4 = ((dataTable.Rows.Count != 0) ? dataTable.Rows[0]["Utente"].ToString() : "---");
							text = "SELECT VV.VOCE AS MNUCODICE, UU.PROGRESSIVO AS MNUID, ";
							text += "UU.PARENT AS MNUPARENT, UU.ORDINE, ";
							text += "VV.DESCRIZIONE, VV.TEXT, ";
							text += "VV.FUNZIONE, VV.TIPONODO, ";
							text += "VV.IMMAGINE, VV.TOOLTIP, ";
							text += "VV.AdditionalText, VV.DesktopImage, ";
							text += "VV.ACTIONCODE, UU.SEPARA, ";
							text += "UU.AdditionalTextFormula ";
							text += "FROM WFI_DESKTOP_UTENTE UU INNER JOIN WFI_MENU_VOCI VV ON UU.VOCE = VV.VOCE ";
							text += "WHERE UU.VISIBILE='S' ";
							text += "AND VV.VISIBILE='S' ";
							text = text + "AND UU.UTENTE=" + _objDbConnection.SQLFormatString(text4);
							text2 = text;
							val2 = _objDbConnection.OpenDataTable(text2, ref _dtDeskTop, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								val2 = TranslateDesktopItems(ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else
								{
									text = "SELECT * ";
									text += "FROM WFI_FUNCTIONLIST ";
									text += "WHERE 1=1 ";
									text = text + "AND UTENTE=" + _objDbConnection.SQLFormatString(text3);
									text2 = text;
									val2 = _objDbConnection.OpenDataTable(text2, ref _dtFunctionList, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else
									{
										val2 = TranslateFunctionListItems(ref rsMess);
										val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN TranslateMenuItems(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_dt != null)
			{
				foreach (DataRow row in _dt.Rows)
				{
					if (Operators.CompareString(row["Text"].ToString(), "", false) != 0)
					{
						string value = _Translator.TranslateMessage("MenuItem", row["Text"].ToString(), new string[0]);
						row["Text"] = value;
					}
					if (Operators.CompareString(row["Tooltip"].ToString(), "", false) != 0)
					{
						string value2 = _Translator.TranslateMessage("MenuItem", row["Tooltip"].ToString(), new string[0]);
						row["Tooltip"] = value2;
					}
				}
				_dt.AcceptChanges();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN TranslateDesktopItems(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_dtDeskTop != null)
			{
				foreach (DataRow row in _dtDeskTop.Rows)
				{
					if (Operators.CompareString(row["Text"].ToString(), "", false) != 0)
					{
						string value = _Translator.TranslateMessage("DesktopItem", row["Text"].ToString(), new string[0]);
						row["Text"] = value;
					}
					if (Operators.CompareString(row["Tooltip"].ToString(), "", false) != 0)
					{
						string value2 = _Translator.TranslateMessage("DesktopItem", row["Tooltip"].ToString(), new string[0]);
						row["Tooltip"] = value2;
					}
				}
				_dtDeskTop.AcceptChanges();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN TranslateFunctionListItems(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_dtFunctionList != null)
			{
				foreach (DataRow row in _dtFunctionList.Rows)
				{
					if (Operators.CompareString(row["Descrizione"].ToString(), "", false) != 0)
					{
						string value = _Translator.TranslateMessage("FunctionList", row["Descrizione"].ToString(), new string[0]);
						row["Descrizione"] = value;
					}
					if (Operators.CompareString(row["Tooltip"].ToString(), "", false) != 0)
					{
						string value2 = _Translator.TranslateMessage("FunctionList", row["Tooltip"].ToString(), new string[0]);
						row["Tooltip"] = value2;
					}
					if (Operators.CompareString(row["SearchTag"].ToString(), "", false) != 0)
					{
						string value3 = _Translator.TranslateMessage("FunctionList", row["SearchTag"].ToString(), new string[0]);
						row["SearchTag"] = value3;
					}
				}
				_dtFunctionList.AcceptChanges();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN LoadMostUsedFromDatabase(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Invalid comparison between Unknown and I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		if (_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init, ref lockTaken);
			if (_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init.State == 0)
			{
				_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init.State = 2;
				_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount = 0;
			}
			else if (_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount_0024Init);
			}
		}
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			checked
			{
				_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount++;
				if (_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount != 1)
				{
					goto IL_0253;
				}
				if (_dtMostUsed != null)
				{
					_dtMostUsed.Dispose();
					_dtMostUsed = null;
				}
				text2 = "SELECT\tU.VOCE " + _objDbConnection.StringConcatenateOperator() + " '#99' AS MNUCODICE, 0 MNUID, ";
				text2 += "'SYS.MOSTUSED' AS MNUPARENT, ";
				text2 += "(999999-COUNT(*)) AS ORDINE, ";
				text2 += "MAX(V.DESCRIZIONE) AS DESCRIZIONE, ";
				text2 += "MAX(V.TEXT) AS TEXT, ";
				text2 += "MAX(V.FUNZIONE) AS FUNZIONE, ";
				text2 += "MAX(V.TIPONODO) AS TIPONODO, ";
				text2 += "MAX(V.IMMAGINE) AS IMMAGINE, ";
				text2 += "MAX(V.TOOLTIP) AS TOOLTIP, ";
				text2 += "MAX(V.AdditionalText) AS AdditionalText, ";
				text2 += "MAX(V.DesktopImage) AS DesktopImage, ";
				text2 += "'N' SEPARA, 'MostUsedMenuItems' CSSCLASS, 0 PESO ";
				text2 += "FROM WFI_MENU_UTILIZZO2 U INNER JOIN WFI_MENU_VOCI V ON U.VOCE=V.VOCE ";
				text2 = text2 + "WHERE U.UTENTE=" + _objDbConnection.SQLFormatString(_objWebUserInfo.Codice) + " ";
				text2 = text2 + "AND U.DATINS>=" + _objDbConnection.GetDate() + "-15 ";
				text2 += "AND V.VISIBILE='S' ";
				text2 += "AND V.TIPONODO IN ('F','N') ";
				text2 += "GROUP BY U.VOCE ";
				text2 += "ORDER BY COUNT(*) DESC ";
				val2 = _objDbConnection.OpenDataTable(text2, ref _dtMostUsed, ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				goto IL_0253;
			}
			val = val2;
			goto end_IL_0093;
			IL_0253:
			if (_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount == 1)
			{
				_0024STATIC_0024LoadMostUsedFromDatabase_00242011180A910E_0024iCount = 0;
			}
			val = (FXRETURN)0;
			end_IL_0093:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN LoadFilialiFromDatabase(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Invalid comparison between Unknown and I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		if (_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init, ref lockTaken);
			if (_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init.State == 0)
			{
				_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init.State = 2;
				_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount = 0;
			}
			else if (_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount_0024Init);
			}
		}
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount != 0)
			{
				goto IL_018c;
			}
			text2 = "SELECT\t'CHANGE_FILIALE_' + FILIALE AS MNUCODICE, 0 MNUID, ";
			text2 += "'SYS.ELENCOFILIALI' AS MNUPARENT, ";
			text2 += "1 AS ORDINE, ";
			text2 += "'CAMBIO FILIALE ' + FILIALE AS DESCRIZIONE, ";
			text2 += "'FILIALE ' + FILIALE + '(' + DESCRIZIONE + ')' AS TEXT, ";
			text2 += "'FUNZIONE' AS FUNZIONE, 'N' AS TIPONODO, ";
			text2 += "NULL AS IMMAGINE, NULL AS TOOLTIP, ";
			text2 += "'N' SEPARA, 'FilialiMenuItems' CSSCLASS, FILIALE, 0 PESO ";
			text2 += " FROM ";
			text2 = text2 + "(SELECT UF.FILIALE, F.DESCRIZIONE FROM WFI_UTENTIFILIALI UF INNER JOIN FILIALI F ON F.CODICE=UF.FILIALE WHERE UF.UTENTE=" + _objDbConnection.SQLFormatString(_objWebUserInfo.Codice) + ") T ";
			val2 = _objDbConnection.OpenDataTable(text2, ref _dtElencoFiliali, ref rsMess);
			if ((int)val2 <= 0)
			{
				checked
				{
					_0024STATIC_0024LoadFilialiFromDatabase_00242011180A910E_0024iCount++;
					goto IL_018c;
				}
			}
			val = val2;
			goto end_IL_0093;
			IL_018c:
			val = (FXRETURN)0;
			end_IL_0093:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN BuildMenu(ref IboWebMenu objMenu, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		MenuItem val3 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			((Menu)objMenu).Items.Clear();
			DataRow[] array = _dt.Select("MNUPARENT IS NULL", "ORDINE ASC");
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					val3 = new MenuItem();
					val2 = MenuItemFromDataRow(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					((Menu)objMenu).Items.Add(val3);
					if (Operators.CompareString(val3.Value, "SYS.MOSTUSED", false) == 0)
					{
						val2 = LoadMostUsedFromDatabase(ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						val2 = LoadMostUsedMenuItems(ref val3, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
					}
					else if (Operators.CompareString(val3.Value, "SYS.ELENCOFILIALI", false) == 0)
					{
						val2 = LoadFilialiFromDatabase(ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						val2 = LoadFilialiMenuItems(ref val3, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
					}
					else
					{
						val2 = LoadMenuItems(ref val3, ref array[num], ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN BuildDesktop(string sParent, ref DataTable dtDestopItems, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int num = 0;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataTable dataTable = _dtDeskTop.Clone();
			DataRow[] array = ((Operators.CompareString(sParent, "", false) == 0) ? _dtDeskTop.Select("MNUPARENT IS NULL", "ORDINE ASC") : _dtDeskTop.Select("MNUPARENT = '" + sParent + "'", "ORDINE ASC"));
			DataRow[] array2 = array;
			foreach (DataRow dataRow in array2)
			{
				if (Conversions.ToInteger(dataRow["PESO"]) <= _objWebUserInfo.Peso)
				{
					dataTable.ImportRow(dataRow);
				}
			}
			if (Operators.CompareString(sParent, "SYS.MOSTUSED", false) != 0)
			{
				goto IL_016c;
			}
			val2 = LoadMostUsedFromDatabase(ref rsMess);
			if ((int)val2 <= 0)
			{
				foreach (DataRow row in _dtMostUsed.Rows)
				{
					num = checked(num + 1);
					dataTable.ImportRow(row);
					if (num > 10)
					{
						break;
					}
				}
				goto IL_016c;
			}
			val = val2;
			goto end_IL_0008;
			IL_016c:
			dtDestopItems = dataTable;
			val = (FXRETURN)0;
			end_IL_0008:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN BuildMenu(ref IboWebMenuTlk objMenu, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Invalid comparison between Unknown and I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Invalid comparison between Unknown and I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Invalid comparison between Unknown and I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Invalid comparison between Unknown and I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		RadMenuItem val3 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array;
			checked
			{
				_0024STATIC_0024BuildMenu_00242021180A91012848910E_0024iCount++;
				((StateManagedCollection)((RadMenu)objMenu).Items).Clear();
				if (_0024STATIC_0024BuildMenu_00242021180A91012848910E_0024iCount > 20)
				{
					_0024STATIC_0024BuildMenu_00242021180A91012848910E_0024iCount = 0;
					_MenuTree = null;
				}
				if (_MenuTree == null)
				{
					_MenuTree = new WFIMenuTree();
				}
				if (_MenuTree.Initialized)
				{
					array = _MenuTree.ParentTreeNode.ChildsDataRow;
				}
				else
				{
					array = _dt.Select("MNUPARENT IS NULL", "ORDINE ASC");
					_MenuTree.ParentTreeNode.ChildsDataRow = array;
					_MenuTree.ParentTreeNode.NodeDataRow = null;
				}
			}
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					WFIMenuNodeTree Node;
					if (!_MenuTree.Initialized)
					{
						Node = new WFIMenuNodeTree();
						Node.NodeDataRow = array[num];
						_MenuTree.ParentTreeNode.Childs.Add(Node);
					}
					else
					{
						Node = _MenuTree.ParentTreeNode.Childs[num];
					}
					val3 = new RadMenuItem();
					val2 = MenuItemFromDataRowTlk(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					((RadMenu)objMenu).Items.Add(val3);
					if (Operators.CompareString(val3.Value, "SYS.MOSTUSED", false) == 0)
					{
						if (!_MenuTree.Initialized)
						{
							val2 = LoadMostUsedFromDatabase(ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
								break;
							}
						}
						val2 = LoadMostUsedMenuItemsTlk(ref val3, ref Node, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
					}
					else if (Operators.CompareString(val3.Value, "SYS.ELENCOFILIALI", false) == 0)
					{
						val2 = LoadFilialiFromDatabase(ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						val2 = LoadFilialiMenuItemsTlk(ref val3, ref Node, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
					}
					else
					{
						val2 = LoadMenuItemsTlk(ref val3, ref array[num], ref Node, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
					}
					num = checked(num + 1);
					continue;
				}
				_MenuTree.Initialized = true;
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN LoadMenuItems(ref MenuItem objMenuItem, ref DataRow drParent, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		MenuItem val3 = null;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array = _dt.Select("MNUPARENT='" + drParent["MNUCODICE"].ToString() + "'", "ORDINE ASC");
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					text = array[num]["SEPARA"].ToString();
					if (Operators.CompareString(text, "S", false) == 0)
					{
						val3 = new MenuItem();
						val2 = MenuItemFromDataRow(ref val3, ref array[num], ref rsMess);
						if ((int)val2 > 0)
						{
							break;
						}
						objMenuItem.ChildItems.Add(val3);
					}
					val3 = new MenuItem();
					array[num]["SEPARA"] = "N";
					array[num].AcceptChanges();
					val2 = MenuItemFromDataRow(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					objMenuItem.ChildItems.Add(val3);
					array[num]["SEPARA"] = text;
					array[num].AcceptChanges();
					val2 = LoadMenuItems(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN LoadMenuItemsTlk(ref RadMenuItem objMenuItem, ref DataRow drParent, ref WFIMenuNodeTree Node, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		RadMenuItem val3 = null;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array;
			if (_MenuTree.Initialized)
			{
				array = Node.ChildsDataRow;
			}
			else
			{
				array = _dt.Select("MNUPARENT='" + drParent["MNUCODICE"].ToString() + "'", "ORDINE ASC");
				Node.ChildsDataRow = array;
			}
			if (array.Length == 0)
			{
				objMenuItem.PostBack = true;
			}
			else
			{
				objMenuItem.PostBack = false;
			}
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					WFIMenuNodeTree Node2;
					if (!_MenuTree.Initialized)
					{
						Node2 = new WFIMenuNodeTree();
						Node2.NodeDataRow = array[num];
						Node.Childs.Add(Node2);
					}
					else
					{
						Node2 = Node.Childs[num];
					}
					text = array[num]["SEPARA"].ToString();
					if (Operators.CompareString(text, "S", false) == 0)
					{
						val3 = new RadMenuItem();
						val2 = MenuItemFromDataRowTlk(ref val3, ref array[num], ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						objMenuItem.Items.Add(val3);
					}
					val3 = new RadMenuItem();
					array[num]["SEPARA"] = "N";
					val2 = MenuItemFromDataRowTlk(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					if (_ViewShortcut)
					{
						string text2 = "<span class=\"Shortcut\"><%Text%></span>";
						text2 = Strings.Replace(text2, "<%Text%>", array[num]["ACTIONCODE"].ToString(), 1, -1, (CompareMethod)0);
						RadMenuItem val4;
						(val4 = val3).Text = val4.Text + text2;
					}
					objMenuItem.Items.Add(val3);
					array[num]["SEPARA"] = text;
					val2 = LoadMenuItemsTlk(ref val3, ref array[num], ref Node2, ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN LoadMostUsedMenuItems(ref MenuItem objMenuItem, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		MenuItem val3 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array = _dtMostUsed.Select("1=1", "ORDINE ASC");
			int num = default(int);
			while (true)
			{
				if (num < array.Length && num != 10)
				{
					val3 = new MenuItem();
					val2 = MenuItemFromDataRow(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					objMenuItem.ChildItems.Add(val3);
					val2 = LoadMenuItems(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN LoadMostUsedMenuItemsTlk(ref RadMenuItem objMenuItem, ref WFIMenuNodeTree Node, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between Unknown and I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		RadMenuItem val3 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array;
			if (_MenuTree.Initialized)
			{
				array = Node.ChildsDataRow;
			}
			else
			{
				array = _dtMostUsed.Select("1=1", "ORDINE ASC");
				Node.ChildsDataRow = array;
			}
			int num = default(int);
			while (true)
			{
				if (num < array.Length && num != 10)
				{
					WFIMenuNodeTree Node2;
					if (!_MenuTree.Initialized)
					{
						Node2 = new WFIMenuNodeTree();
						Node2.NodeDataRow = array[num];
						Node.Childs.Add(Node2);
					}
					else
					{
						Node2 = Node.Childs[num];
					}
					val3 = new RadMenuItem();
					val2 = MenuItemFromDataRowTlk(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					objMenuItem.Items.Add(val3);
					val2 = LoadMenuItemsTlk(ref val3, ref array[num], ref Node2, ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN LoadFilialiMenuItems(ref MenuItem objMenuItem, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		MenuItem val3 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array = _dtElencoFiliali.Select("1=1", "DESCRIZIONE ASC");
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					val3 = new MenuItem();
					val2 = MenuItemFromDataRow(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					if (Operators.CompareString(array[num]["FILIALE"].ToString(), _objWebUserInfo.FilialeDefault, false) == 0)
					{
						val3.Text = "X - " + val3.Text;
						val3.Selectable = false;
					}
					objMenuItem.ChildItems.Add(val3);
					val2 = LoadMenuItems(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN LoadFilialiMenuItemsTlk(ref RadMenuItem objMenuItem, ref WFIMenuNodeTree Node, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		RadMenuItem val3 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array;
			if (_MenuTree.Initialized)
			{
				array = Node.ChildsDataRow;
			}
			else
			{
				array = _dtElencoFiliali.Select("1=1", "DESCRIZIONE ASC");
				Node.ChildsDataRow = array;
			}
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					WFIMenuNodeTree Node2;
					if (!_MenuTree.Initialized)
					{
						Node2 = new WFIMenuNodeTree();
						Node2.NodeDataRow = array[num];
						Node.Childs.Add(Node2);
					}
					else
					{
						Node2 = Node.Childs[num];
					}
					val3 = new RadMenuItem();
					val2 = MenuItemFromDataRowTlk(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					if (Operators.CompareString(array[num]["FILIALE"].ToString(), _objWebUserInfo.FilialeDefault, false) == 0)
					{
						val3.Text = "X - " + val3.Text;
						val3.PostBack = false;
					}
					objMenuItem.Items.Add(val3);
					val2 = LoadMenuItemsTlk(ref val3, ref array[num], ref Node2, ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN MenuItemFromDataRow(ref MenuItem objMenuItem, ref DataRow objDataRow, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		MenuItem val3 = null;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			objMenuItem.Enabled = Conversions.ToInteger(objDataRow["PESO"]) <= _objWebUserInfo.Peso;
			objMenuItem.Text = objDataRow["TEXT"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(objDataRow["IMMAGINE"])))
			{
				objMenuItem.ImageUrl = objDataRow["IMMAGINE"].ToString();
			}
			objMenuItem.ToolTip = objDataRow["TOOLTIP"].ToString();
			text = "";
			string text2 = objDataRow["TIPONODO"].ToString();
			if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoExtended), false) == 0)
			{
				text = objDataRow["FUNZIONE"].ToString();
				objMenuItem.Selectable = true;
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoFunzione), false) == 0)
			{
				text = objDataRow["FUNZIONE"].ToString();
				objMenuItem.Selectable = true;
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoCaption), false) == 0)
			{
				objMenuItem.Selectable = false;
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoNavigate), false) == 0)
			{
				text = ((Operators.CompareString(objDataRow["FUNZIONE"].ToString(), "", false) == 0) ? "" : ((Operators.CompareString(Strings.Left(objDataRow["FUNZIONE"].ToString(), 6).ToUpper(), "GOTPAG", false) == 0) ? objDataRow["FUNZIONE"].ToString() : ("GOTPAG;" + objDataRow["FUNZIONE"].ToString())));
				objMenuItem.NavigateUrl = null;
				objMenuItem.Selectable = true;
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoParent), false) == 0)
			{
				objMenuItem.Selectable = false;
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoLink), false) == 0)
			{
				text = objDataRow["FUNZIONE"].ToString();
				objMenuItem.NavigateUrl = text;
				objMenuItem.Target = "_blank";
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				objMenuItem.Value = objDataRow["MNUCODICE"].ToString() + "ç" + text;
			}
			else if (Operators.CompareString(objDataRow["MNUCODICE"].ToString(), "SYS.MOSTUSED", false) == 0)
			{
				objMenuItem.Value = objDataRow["MNUCODICE"].ToString();
			}
			else if (Operators.CompareString(objDataRow["MNUCODICE"].ToString(), "SYS.ELENCOFILIALI", false) == 0)
			{
				objMenuItem.Value = objDataRow["MNUCODICE"].ToString();
			}
			if (Operators.CompareString(objDataRow["SEPARA"].ToString(), "S", false) == 0)
			{
				objMenuItem.SeparatorImageUrl = ImagesPath + "mnusep.jpg";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN MenuItemFromDataRowTlk(ref RadMenuItem objMenuItem, ref DataRow objDataRow, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		MenuItem val3 = null;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			((ControlItem)objMenuItem).Visible = Conversions.ToInteger(objDataRow["PESO"]) <= _objWebUserInfo.Peso;
			objMenuItem.Text = objDataRow["TEXT"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(objDataRow["IMMAGINE"])) && Operators.CompareString(objDataRow["SEPARA"].ToString(), "S", false) != 0)
			{
				objMenuItem.ImageUrl = objDataRow["IMMAGINE"].ToString();
			}
			((WebControl)objMenuItem).ToolTip = objDataRow["TOOLTIP"].ToString();
			((WebControl)objMenuItem).CssClass = objDataRow["CSSCLASS"].ToString();
			text = "";
			string text2 = objDataRow["TIPONODO"].ToString();
			if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoExtended), false) == 0)
			{
				text = objDataRow["FUNZIONE"].ToString();
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoFunzione), false) == 0)
			{
				text = objDataRow["FUNZIONE"].ToString();
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoCaption), false) == 0)
			{
				objMenuItem.PostBack = false;
				RadMenuItem val4;
				((WebControl)(val4 = objMenuItem)).CssClass = ((WebControl)val4).CssClass + " CaptionMenuItem";
				((WebControl)objMenuItem).CssClass = ((WebControl)objMenuItem).CssClass.Trim();
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoNavigate), false) == 0)
			{
				text = ((Operators.CompareString(objDataRow["FUNZIONE"].ToString(), "", false) == 0) ? "" : ((Operators.CompareString(Strings.Left(objDataRow["FUNZIONE"].ToString(), 6).ToUpper(), "GOTPAG", false) == 0) ? objDataRow["FUNZIONE"].ToString() : ("GOTPAG;" + objDataRow["FUNZIONE"].ToString())));
				objMenuItem.NavigateUrl = null;
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoParent), false) == 0)
			{
				objMenuItem.PostBack = false;
				if (Operators.CompareString(objDataRow["MNUPARENT"].ToString(), "", false) == 0)
				{
					RadMenuItem val4;
					((WebControl)(val4 = objMenuItem)).CssClass = ((WebControl)val4).CssClass + " RootMenuItem";
				}
				else
				{
					RadMenuItem val4;
					((WebControl)(val4 = objMenuItem)).CssClass = ((WebControl)val4).CssClass + " ParentMenuItem";
				}
			}
			else if (Operators.CompareString(text2, Conversions.ToString(kTipoNodoLink), false) == 0)
			{
				text = objDataRow["FUNZIONE"].ToString();
				objMenuItem.NavigateUrl = text;
				objMenuItem.Target = "_blank";
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				objMenuItem.Value = objDataRow["MNUCODICE"].ToString() + "ç" + text;
			}
			else if (Operators.CompareString(objDataRow["MNUCODICE"].ToString(), "SYS.MOSTUSED", false) == 0)
			{
				objMenuItem.Value = objDataRow["MNUCODICE"].ToString();
			}
			else if (Operators.CompareString(objDataRow["MNUCODICE"].ToString(), "SYS.ELENCOFILIALI", false) == 0)
			{
				objMenuItem.Value = objDataRow["MNUCODICE"].ToString();
			}
			if ((Operators.CompareString(objDataRow["SEPARA"].ToString(), "S", false) == 0) & (Operators.CompareString(objDataRow["MNUPARENT"].ToString(), "", false) != 0))
			{
				objMenuItem.IsSeparator = true;
				((WebControl)objMenuItem).CssClass = "SeparatorItems";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN UpdateMenuUsage(string sVoceMenu, string sUtente, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			sVoceMenu = Strings.Replace(sVoceMenu, "#99", "", 1, -1, (CompareMethod)0);
			text = "INSERT INTO WFI_MENU_UTILIZZO(VOCE, UTENTE, UTILIZZO) ";
			text = text + "SELECT " + _objDbConnection.SQLFormatString(sVoceMenu) + ", ";
			text = text + _objDbConnection.SQLFormatString(sUtente) + ", 0 ";
			if ((int)_objDbConnection.ServerTypeConnection == 1)
			{
				text += "FROM DUAL ";
			}
			text += "WHERE NOT EXISTS (SELECT 1 FROM WFI_MENU_UTILIZZO ";
			text = text + "WHERE VOCE=" + _objDbConnection.SQLFormatString(sVoceMenu) + " ";
			text = text + "AND UTENTE=" + _objDbConnection.SQLFormatString(sUtente) + "); ";
			text = text + "UPDATE WFI_MENU_UTILIZZO SET UTILIZZO=UTILIZZO+1, DATAULTIMOUTILIZZO=" + _objDbConnection.GetDate() + " ";
			text = text + "WHERE VOCE=" + _objDbConnection.SQLFormatString(sVoceMenu) + " ";
			text = text + "AND UTENTE=" + _objDbConnection.SQLFormatString(sUtente) + "; ";
			text += "INSERT INTO WFI_MENU_UTILIZZO2(VOCE, UTENTE) VALUES (";
			text = text + _objDbConnection.SQLFormatString(sVoceMenu) + ", ";
			text = text + _objDbConnection.SQLFormatString(sUtente) + "); ";
			text = text + "UPDATE WFI_UTENTI SET LastActivity=" + _objDbConnection.GetDate() + ", IsLoggedOn='S' WHERE CODICE=" + _objDbConnection.SQLFormatString(_SessionEnvironment.WebUser.WebUserInfo.Codice) + ";";
			_SessionEnvironment.AddAsyncQueryToApply(text);
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			_objDbConnection = null;
			_objLogHandling = null;
			_objCallStackHandler = null;
			_objWebUserInfo = null;
			_objParam = null;
			_SessionEnvironment = null;
		}
		disposedValue = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
