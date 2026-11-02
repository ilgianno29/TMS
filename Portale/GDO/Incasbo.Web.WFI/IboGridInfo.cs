using System;
using System.Data;
using System.Linq;
using System.Text;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboGridInfo : IDisposable
{
	protected string _NomRif;

	protected string _Utente;

	protected string _ObjectManagerName;

	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IboWebUserInfo _ObjWebUserInfo;

	protected DBConnection _dbMain;

	protected IboWebGridConfig _objGridConfig;

	protected DataTable dtAllgrd;

	protected DataTable dtTabGrd;

	protected DataTable dtHeaderStyle;

	protected DataTable dtHighLightStyle;

	protected DataTable dtPagerStyle;

	protected DataTable dtRowStyle;

	protected DataTable dtAlternatingRowStyle;

	protected DataTable dtSelectedRowStyle;

	protected DataTable dtAllGrdStyleset;

	protected DataTable _dtGridFilter;

	protected DataTable _dtUserFilter;

	protected DataTable dtGroupHeaderItemStyle;

	protected IncasTranslator _Translator;

	protected string _WhereAggiuntiva;

	protected string _WhereAggiuntivaReadable;

	protected sqlSelect _SqlOriginalStatement;

	protected sqlSelect _sqlStatement;

	protected sqlSelect _SqlExportStatement;

	protected bool disposedValue;

	protected string _CampoAttivo;

	protected string _CampoAttivoDescrizione;

	protected bool _AutoUpdate;

	protected bool _AutoUpdateVisible;

	protected int _TopClauseUI;

	protected string kMsg0001;

	protected string kMsg0002;

	private static string _WFI_Tabgrd = "";

	private static bool? _WFI_AllGrd_UserFilter_Exists;

	public FunctionArguments FunctionArgs { get; set; }

	public int GridPage { get; set; }

	public IboWebGridConfig GridConfig
	{
		get
		{
			return _objGridConfig;
		}
		set
		{
			_objGridConfig = value;
		}
	}

	public bool AutoUpdate
	{
		get
		{
			return _AutoUpdate;
		}
		set
		{
			_AutoUpdate = value;
		}
	}

	public bool MaxRecordSelectorVisible => Operators.CompareString(AllGrd["MaxRecordVisible"].ToString(), "S", false) == 0;

	public decimal FontSize => Conversions.ToDecimal(AllGrd["FontSize"]);

	public decimal CaptionFontSize => Conversions.ToDecimal(AllGrd["CaptionFontSize"]);

	public int TopClause
	{
		get
		{
			if (TopClauseUI >= 0)
			{
				return TopClauseUI;
			}
			return Conversions.ToInteger(AllGrd["MaxRecord"]);
		}
	}

	public int TopClauseUI
	{
		get
		{
			return _TopClauseUI;
		}
		set
		{
			_TopClauseUI = value;
		}
	}

	public bool AutoUpdateVisible
	{
		get
		{
			return _AutoUpdateVisible;
		}
		set
		{
			_AutoUpdateVisible = value;
		}
	}

	public bool AllowPaging => Operators.CompareString(dtAllgrd.Rows[0]["CANPAGE"].ToString(), "S", false) == 0;

	public bool AllowGrouping => (Operators.CompareString(dtAllgrd.Rows[0]["CANGROUP"].ToString(), "S", false) == 0) | (Operators.CompareString(dtAllgrd.Rows[0]["CANGROUP"].ToString(), "A", false) == 0);

	public bool GroupExpanded => Operators.CompareString(dtAllgrd.Rows[0]["GROUPEXPANDED"].ToString(), "S", false) == 0;

	public bool ShowGroupFooter => (Operators.CompareString(dtAllgrd.Rows[0]["SHOWGROUPFOOTER"].ToString(), "S", false) == 0) | (Operators.CompareString(dtAllgrd.Rows[0]["SHOWGROUPFOOTER"].ToString(), "A", false) == 0);

	public bool GroupFooterAlwaysVisible => Operators.CompareString(dtAllgrd.Rows[0]["SHOWGROUPFOOTER"].ToString(), "A", false) == 0;

	public bool ShowFooter => Operators.CompareString(dtAllgrd.Rows[0]["ShowFooter"].ToString(), "S", false) == 0;

	public string GroupType => dtAllgrd.Rows[0]["CANGROUP"].ToString();

	public bool AllowSorting => Operators.CompareString(dtAllgrd.Rows[0]["CANSORT"].ToString(), "S", false) == 0;

	public bool AutoGenerateCheckBoxColumn => (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "S", false) == 0) | (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "M", false) == 0) | (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "C", false) == 0);

	public bool CanSelect => (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "S", false) == 0) | (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "M", false) == 0) | (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "C", false) == 0);

	public bool SelectionColumnVisible => Operators.CompareString(dtAllgrd.Rows[0]["SELCOLVISIBLE"].ToString(), "S", false) == 0;

	public bool EnableMultiSelection => (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "M", false) == 0) | (Operators.CompareString(dtAllgrd.Rows[0]["CANSEL"].ToString(), "C", false) == 0);

	public string MultiSelectionType
	{
		get
		{
			if (EnableMultiSelection)
			{
				return dtAllgrd.Rows[0]["CANSEL"].ToString();
			}
			return "";
		}
	}

	public bool Prefiltro => Operators.CompareString(dtAllgrd.Rows[0]["PREFILTRO"].ToString(), "S", false) == 0;

	public bool FiltroUtenteObbligatorio => Operators.CompareString(dtAllgrd.Rows[0]["FILTROUTENTEOBBLIGATORIO"].ToString(), "S", false) == 0;

	public bool PrefiltroImpostato
	{
		get
		{
			checked
			{
				for (int num = _SqlOriginalStatement.WhereConditions.Count - 1; num >= 0; num--)
				{
					if (_SqlOriginalStatement.WhereConditions.ToList()[num].Value.CanBeDeleted)
					{
						return true;
					}
				}
				bool result = default(bool);
				return result;
			}
		}
	}

	public string CampoAttivo
	{
		get
		{
			if (Operators.CompareString(_CampoAttivo, "", false) == 0)
			{
				_CampoAttivo = dtTabGrd.Rows[0]["NOMCAM"].ToString();
				try
				{
					CampoAttivoDescrizione = dtTabGrd.Select("NOMCAM='" + _CampoAttivo + "'")[0]["DESCAM"].ToString();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			return _CampoAttivo;
		}
		set
		{
			_CampoAttivo = value;
			try
			{
				CampoAttivoDescrizione = dtTabGrd.Select("NOMCAM='" + _CampoAttivo + "'")[0]["DESCAM"].ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public string CampoAttivoDescrizione
	{
		get
		{
			if (Operators.CompareString(_CampoAttivoDescrizione, "", false) == 0)
			{
				_CampoAttivoDescrizione = dtTabGrd.Rows[0]["DESCAM"].ToString();
			}
			return _CampoAttivoDescrizione;
		}
		set
		{
			_CampoAttivoDescrizione = value;
		}
	}

	public string CampoAttivoTipo
	{
		get
		{
			string result;
			try
			{
				DataRow dataRow = dtTabGrd.Select("NOMCAM='" + CampoAttivo + "'")[0];
				result = dataRow["INTERNAL_USE_DATATYPE"].ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "String";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

// Proprieta' VB con parametro, convertita in metodi
	public string get_CampoTipo(string vsNomeCampo)
	{
		DataRow dataRow = dtTabGrd.Select("NOMCAM='" + vsNomeCampo + "'")[0];
		return dataRow["INTERNAL_USE_DATATYPE"].ToString();
	}


	public string CampiOrdinantiIniziali { get; set; }

	public string CampiOrdinantiInizialiDirezione { get; set; }

	public string CampiOrdinantiAttuali { get; set; }

	public string CampiOrdinantiAttualiDirezione { get; set; }

	public string NomRif => _NomRif;

	public string Utente => _Utente;

	public int Width => Conversions.ToInteger(dtAllgrd.Rows[0]["WIDTH"]);

	public string FastFilterType => dtAllgrd.Rows[0]["FastFilterType"].ToString();

	public string ObjectManagerName => _ObjectManagerName;

	public DataRow AllGrd => dtAllgrd.Rows[0];

	public DataRowCollection TabGrd => dtTabGrd.Rows;

	public DataTable GridFilterTable => _dtGridFilter;

	public DataTable UserFilterTable => _dtUserFilter;

	public DataRow[] GetSortingFields
	{
		get
		{
			DataRow[] result;
			try
			{
				DataRow[] array = dtTabGrd.Select("ORDCAM > 0", "ORDCAM");
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string GetSortingSqlClause
	{
		get
		{
			string result;
			try
			{
				string text = "";
				DataRow[] getSortingFields = GetSortingFields;
				foreach (DataRow dataRow in getSortingFields)
				{
					if (Operators.CompareString(text, "", false) != 0)
					{
						text += ",";
					}
					text = text + dataRow["NOMCAM"].ToString() + " " + dataRow["ORDDIR"].ToString();
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

	public DataTable TabGrdTable => dtTabGrd;

	public DataRow HeaderStyle
	{
		get
		{
			if (dtHeaderStyle != null)
			{
				return dtHeaderStyle.Rows[0];
			}
			return null;
		}
	}

	public DataRow GroupHeaderItemStyle
	{
		get
		{
			if (dtGroupHeaderItemStyle != null)
			{
				return dtGroupHeaderItemStyle.Rows[0];
			}
			return null;
		}
	}

	public DataRow HighLightStyle
	{
		get
		{
			if (dtHighLightStyle != null)
			{
				return dtHighLightStyle.Rows[0];
			}
			return null;
		}
	}

	public DataRow PagerStyle
	{
		get
		{
			if (dtPagerStyle != null)
			{
				return dtPagerStyle.Rows[0];
			}
			return null;
		}
	}

	public DataRow RowStyle
	{
		get
		{
			if (dtRowStyle != null)
			{
				return dtRowStyle.Rows[0];
			}
			return null;
		}
	}

	public DataRow SelectedRowStyle
	{
		get
		{
			if (dtSelectedRowStyle != null)
			{
				return dtSelectedRowStyle.Rows[0];
			}
			return null;
		}
	}

	public DataRow AlternatingRowStyle
	{
		get
		{
			if (dtAlternatingRowStyle != null)
			{
				return dtAlternatingRowStyle.Rows[0];
			}
			return null;
		}
	}

	public DataTable AllGrdStylesetTable => dtAllGrdStyleset;

	public string WhereAggiuntiva
	{
		get
		{
			return _WhereAggiuntiva;
		}
		set
		{
			_WhereAggiuntiva = value;
		}
	}

	public string WhereAggiuntivaReadable
	{
		get
		{
			return _WhereAggiuntivaReadable;
		}
		set
		{
			_WhereAggiuntivaReadable = value;
		}
	}

	public sqlSelect SqlOriginalStatement => _SqlOriginalStatement;

	public sqlSelect SqlStatement => _sqlStatement;

	public sqlSelect SqlExportStatement => _SqlExportStatement;

	public string[] GetKeyArray
	{
		get
		{
			string[] array = new string[1] { "" };
			int num = 0;
			checked
			{
				foreach (DataRow row in dtTabGrd.Rows)
				{
					if (Operators.CompareString(row["ISKEY"].ToString(), "S", false) == 0)
					{
						array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
						array[num] = row["NOMCAM"].ToString();
						num++;
					}
				}
				return array;
			}
		}
	}

	public bool FixedLayout => Operators.CompareString(AllGrd["FixedLayout"].ToString(), "S", false) == 0;

	public string TipoGriglia => dtAllgrd.Rows[0]["TipoGriglia"].ToString();

	public bool ColumnResize => Operators.CompareString(AllGrd["ColumnResize"].ToString(), "S", false) == 0;

	public int ScrollHeight => Conversions.ToInteger(AllGrd["ScrollHeight"]);

	public bool? WFI_AllGrd_UserFilter_Exists => _WFI_AllGrd_UserFilter_Exists;

	public IboGridInfo(string vsNomRif, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		_NomRif = "";
		_Utente = "";
		_ObjectManagerName = "";
		_objGridConfig = null;
		dtAllgrd = null;
		dtTabGrd = null;
		dtHeaderStyle = null;
		dtHighLightStyle = null;
		dtPagerStyle = null;
		dtRowStyle = null;
		dtAlternatingRowStyle = null;
		dtSelectedRowStyle = null;
		dtAllGrdStyleset = null;
		_dtGridFilter = null;
		_dtUserFilter = null;
		dtGroupHeaderItemStyle = null;
		_WhereAggiuntiva = "";
		_WhereAggiuntivaReadable = "";
		disposedValue = false;
		_CampoAttivo = "";
		_CampoAttivoDescrizione = "";
		_AutoUpdate = false;
		_AutoUpdateVisible = false;
		_TopClauseUI = -1;
		kMsg0001 = "";
		kMsg0002 = "";
		_NomRif = vsNomRif;
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_dbMain = rObjDbMain;
		_ObjWebUserInfo = rObjWebUserInfo;
		_Translator = rObjTranslator;
		kMsg0001 = rObjTranslator.TranslateMessage("XXX", "Non esiste la configurazione per la griglia {0} nella tabella ALLGRD", new string[1] { _NomRif });
		kMsg0002 = rObjTranslator.TranslateMessage("XXX", "Non esiste la configurazione per la griglia {0}-{1} nella tabella TABGRD", new string[2] { _NomRif, _Utente });
	}

	public FXRETURN Init(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = Init_AllGrd(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = Init_TabGrd(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = Init_SqlSelect(ref rsMess);
					val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN ReInit(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			_SqlOriginalStatement = null;
			_SqlExportStatement = null;
			_sqlStatement = null;
			val2 = Init(ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN Init_AllGrd(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Invalid comparison between Unknown and I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Invalid comparison between Unknown and I4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Invalid comparison between Unknown and I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Invalid comparison between Unknown and I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Invalid comparison between Unknown and I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Invalid comparison between Unknown and I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Invalid comparison between Unknown and I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Invalid comparison between Unknown and I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Invalid comparison between Unknown and I4
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Invalid comparison between Unknown and I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Invalid comparison between Unknown and I4
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			text = (((int)_dbMain.ServerTypeConnection != 0) ? "SELECT T1.*, " : "SELECT TOP 1 T1.*, ");
			text += "CASE WHEN (T2.TIPO='U' AND T2.CODICE<>'XXX') THEN 1 ";
			text += "WHEN (T2.TIPO='G' AND T2.CODICE<>'XXX') THEN 2 ";
			text += "WHEN (T2.TIPO='O' AND T2.CODICE<>'XXX') THEN 3 ";
			text += "WHEN (T2.TIPO='T' AND T2.CODICE<>'XXX') THEN 4 ";
			text += "ELSE 5 END PESO ";
			text += "FROM WFI_ALLGRD T1 ";
			text += "LEFT JOIN WFI_UTENTI T2 ON T1.UTENTE=T2.CODICE ";
			text = text + "WHERE T1.NomRif = " + _dbMain.SQLFormatString(_NomRif) + " ";
			text += "AND T1.UTENTE IN (<%XXX%>, <%UTENTE%>, <%GRUPPO%>, <%ORGANIZZAZIONE%>, <%TIPOORGANIZZAZIONE%>) ";
			if ((int)_dbMain.ServerTypeConnection == 1)
			{
				text += " AND ROWNUM<=1 ";
			}
			text += "ORDER BY PESO";
			text = text.Replace("<%UTENTE%>", _dbMain.SQLFormatString(_ObjWebUserInfo.Codice));
			text = text.Replace("<%GRUPPO%>", _dbMain.SQLFormatString(_ObjWebUserInfo.Gruppo));
			text = text.Replace("<%ORGANIZZAZIONE%>", _dbMain.SQLFormatString(_ObjWebUserInfo.Organizzazione));
			text = text.Replace("<%TIPOORGANIZZAZIONE%>", _dbMain.SQLFormatString(_ObjWebUserInfo.OrganizzazioneTipoSoggetto));
			text = ((Operators.CompareString(_ObjWebUserInfo.OrganizzazioneInternaEsterna, "I", false) != 0) ? text.Replace("<%XXX%>", _dbMain.SQLFormatString("YYY")) : text.Replace("<%XXX%>", _dbMain.SQLFormatString("XXX")));
			val2 = _dbMain.OpenDataTable(text, ref dtAllgrd, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dtAllgrd.Rows.Count == 0)
			{
				rsMess = kMsg0001;
			}
			else
			{
				_Utente = dtAllgrd.Rows[0]["Utente"].ToString();
				_ObjectManagerName = dtAllgrd.Rows[0]["ObjectManagerName"].ToString();
				val2 = Init_StyleSet(dtAllgrd.Rows[0]["HeaderStyle"].ToString(), ref dtHeaderStyle, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = Init_StyleSet(dtAllgrd.Rows[0]["PagerStyle"].ToString(), ref dtPagerStyle, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = Init_StyleSet(dtAllgrd.Rows[0]["RowStyle"].ToString(), ref dtRowStyle, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							val2 = Init_StyleSet(dtAllgrd.Rows[0]["SelectedRowStyle"].ToString(), ref dtSelectedRowStyle, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								val2 = Init_StyleSet(dtAllgrd.Rows[0]["AlternatingRowStyle"].ToString(), ref dtAlternatingRowStyle, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else
								{
									val2 = Init_StyleSet(dtAllgrd.Rows[0]["HIGHLIGHTEDROWSTYLE"].ToString(), ref dtHighLightStyle, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else
									{
										val2 = Init_StyleSet(dtAllgrd.Rows[0]["GroupHeaderItemStyle"].ToString(), ref dtGroupHeaderItemStyle, ref rsMess);
										if ((int)val2 > 0)
										{
											val = val2;
										}
										else
										{
											_AutoUpdate = Conversions.ToInteger(dtAllgrd.Rows[0]["TIMERUPDATE"]) > 0;
											_AutoUpdateVisible = Operators.CompareString(dtAllgrd.Rows[0]["AUTOUPDATEVISIBLE"].ToString(), "S", false) == 0;
											val2 = Init_AllgrdStyleSet(ref dtAllGrdStyleset, ref rsMess);
											if ((int)val2 > 0)
											{
												val = val2;
											}
											else
											{
												val2 = Init_StaticFilter(ref rsMess);
												if ((int)val2 > 0)
												{
													val = val2;
												}
												else
												{
													val2 = Init_UserFilter(ref rsMess);
													val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
												}
											}
										}
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
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN Init_StyleSet(string sStyleName, ref DataTable dtStyle, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(sStyleName.Trim(), "", false) == 0)
			{
				goto IL_00b2;
			}
			text = "SELECT * FROM WFI_TABSTYLESET WHERE STYLENAME=" + _dbMain.SQLFormatString(sStyleName.Trim());
			val2 = _dbMain.OpenDataTable(text, ref dtStyle, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dtStyle.Rows.Count != 0)
				{
					goto IL_00b2;
				}
				rsMess = _Translator.TranslateMessage("XXX", "Non esiste la configurazione per lo stile {0} nella tabella degli stili", new string[1] { sStyleName.Trim() });
			}
			goto end_IL_000b;
			IL_00b2:
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN Init_AllgrdStyleSet(ref DataTable dtStyle, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			text = "SELECT T2.*, T1.Descrizione DescrizioneStato ";
			text += "FROM WFI_ALLGRD_STYLESET T1 INNER JOIN WFI_TABSTYLESET T2 ON T1.STYLENAME=T2.STYLENAME ";
			text = text + "WHERE T1.NOMRIF=" + _dbMain.SQLFormatString(_NomRif.ToUpper()) + " ";
			text = text + "AND T1.UTENTE=" + _dbMain.SQLFormatString(_Utente.ToUpper()) + " ";
			val2 = _dbMain.OpenDataTable(text, ref dtAllGrdStyleset, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN Init_StaticFilter(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM WFI_ALLGRD_Filter WHERE Utente=" + _dbMain.SQLFormatString(_Utente) + " ";
			text = text + "AND NomRif=" + _dbMain.SQLFormatString(_NomRif) + " ";
			val2 = _dbMain.OpenDataTable(text, ref _dtGridFilter, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Update_UserFilter(ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return Init_UserFilter(ref rsMess);
	}

	protected virtual FXRETURN Init_UserFilter(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between Unknown and I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (!_WFI_AllGrd_UserFilter_Exists.HasValue)
			{
				bool value = false;
				DBConnection dbMain = _dbMain;
				string text2 = "";
				dbMain.TableOrViewExists("WFI_Allgrd_UserFilter", ref value, ref text2);
				_WFI_AllGrd_UserFilter_Exists = value;
			}
			if (!_WFI_AllGrd_UserFilter_Exists.GetValueOrDefault())
			{
				goto IL_01ae;
			}
			text = "SELECT F.* FROM WFI_ALLGRD_UserFilter F WHERE F.Attivo='S' AND Utente IN (<%XXX%>, <%UTENTE%>, <%GRUPPO%>, <%ORGANIZZAZIONE%>, <%TIPOORGANIZZAZIONE%>) ";
			text = text + "AND NomRif=" + _dbMain.SQLFormatString(_NomRif) + " ";
			text += "ORDER BY Descrizione";
			text = text.Replace("<%UTENTE%>", _dbMain.SQLFormatString(_ObjWebUserInfo.Codice));
			text = text.Replace("<%GRUPPO%>", _dbMain.SQLFormatString(_ObjWebUserInfo.Gruppo));
			text = text.Replace("<%ORGANIZZAZIONE%>", _dbMain.SQLFormatString(_ObjWebUserInfo.Organizzazione));
			text = text.Replace("<%TIPOORGANIZZAZIONE%>", _dbMain.SQLFormatString(_ObjWebUserInfo.OrganizzazioneTipoSoggetto));
			text = ((Operators.CompareString(_ObjWebUserInfo.OrganizzazioneInternaEsterna, "I", false) != 0) ? text.Replace("<%XXX%>", _dbMain.SQLFormatString("YYY")) : text.Replace("<%XXX%>", _dbMain.SQLFormatString("XXX")));
			val2 = _dbMain.OpenDataTable(text, ref _dtUserFilter, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_01ae;
			}
			val = val2;
			goto end_IL_000b;
			IL_01ae:
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN Complete_Init_TabGrd(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between Unknown and I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		checked
		{
			FXRETURN result;
			try
			{
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				if (dtTabGrd.Columns.Contains("INTERNAL_USE_DATATYPE"))
				{
					goto IL_037f;
				}
				int i = default(int);
				if (!((Operators.CompareString(dtAllgrd.Rows[0]["TipoGriglia"].ToString(), "I", false) != 0) & (Operators.CompareString(dtAllgrd.Rows[0]["TipoGriglia"].ToString(), "C", false) != 0)))
				{
					if (GridConfig != null && GridConfig.DataTableSource != null)
					{
						dtTabGrd.Columns.Add(new DataColumn("INTERNAL_USE_DATATYPE", typeof(string)));
						for (; i < dtTabGrd.Rows.Count; i++)
						{
							dtTabGrd.Rows[i]["INTERNAL_USE_DATATYPE"] = "UNKNOWN";
							int num = GridConfig.DataTableSource.Columns.Count - 1;
							for (int j = 0; j <= num; j++)
							{
								if (Operators.CompareString(GridConfig.DataTableSource.Columns[j].ColumnName.ToUpper(), dtTabGrd.Rows[i]["NOMCAM"].ToString().ToUpper(), false) == 0)
								{
									dtTabGrd.Rows[i]["INTERNAL_USE_DATATYPE"] = GridConfig.DataTableSource.Columns[j].DataType.Name;
									break;
								}
							}
						}
					}
					goto IL_0372;
				}
				dtTabGrd.Columns.Add(new DataColumn("INTERNAL_USE_DATATYPE", typeof(string)));
				sqlSelect sqlSelect2 = new sqlSelect(_dbMain.ServerTypeConnection);
				sqlSelect2.SqlFromClause = dtAllgrd.Rows[0]["NomTab"].ToString();
				int num2 = dtTabGrd.Rows.Count - 1;
				for (int k = 0; k <= num2; k++)
				{
					sqlSelect obj = sqlSelect2;
					string vsFieldName = dtTabGrd.Rows[k]["NOMCAM"].ToString();
					obj.AddSelectField(ref vsFieldName, dtTabGrd.Rows[k]["NOMCAM"].ToString());
				}
				sqlSelect2.AddWhere("'A'='B'");
				text = sqlSelect2.ToString();
				val2 = _dbMain.OpenDataTable(text, ref dataTable, ref rsMess);
				if (unchecked((int)val2) <= 0)
				{
					for (; i < dataTable.Columns.Count; i++)
					{
						dtTabGrd.Rows[i]["INTERNAL_USE_DATATYPE"] = dataTable.Columns[i].DataType.Name;
					}
					goto IL_0372;
				}
				val = val2;
				goto end_IL_000e;
				IL_037f:
				val = (FXRETURN)0;
				goto end_IL_000e;
				IL_0372:
				dtTabGrd.AcceptChanges();
				goto IL_037f;
				end_IL_000e:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				sqlSelect sqlSelect2 = null;
				if (dataTable != null)
				{
					dataTable.Dispose();
					dataTable = null;
				}
				_ObjCallStackHandler.CallStackRemove();
				result = val;
			}
			return result;
		}
	}

	protected FXRETURN Init_TabGrd(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		StringBuilder stringBuilder = new StringBuilder();
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_WFI_Tabgrd, "", false) != 0)
			{
				goto IL_0080;
			}
			bool flag = default(bool);
			val2 = _dbMain.TableOrViewExists("VWCST_WFI_TABGRD", ref flag, ref rsMess);
			if ((int)val2 <= 0)
			{
				if (flag)
				{
					_WFI_Tabgrd = "VWCST_WFI_TABGRD";
				}
				else
				{
					_WFI_Tabgrd = "VW_WFI_TABGRD";
				}
				goto IL_0080;
			}
			val = val2;
			goto end_IL_000b;
			IL_0080:
			stringBuilder.Append("SELECT GRD.* FROM ");
			stringBuilder.Append(_WFI_Tabgrd);
			stringBuilder.Append(" GRD WHERE GRD.NomRif=" + _dbMain.SQLFormatString(_NomRif));
			stringBuilder.Append(" AND GRD.UTENTE = " + _dbMain.SQLFormatString(_Utente));
			stringBuilder.Append(" ORDER BY GRD.PRORIG");
			val2 = _dbMain.OpenDataTable(stringBuilder.ToString(), ref dtTabGrd, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dtTabGrd.Rows.Count == 0)
			{
				rsMess = kMsg0002;
			}
			else
			{
				val2 = Complete_Init_TabGrd(ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN Init_SqlSelect(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		checked
		{
			FXRETURN result;
			try
			{
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				_SqlOriginalStatement = new sqlSelect(_dbMain.ServerTypeConnection);
				_SqlExportStatement = new sqlSelect(_dbMain.ServerTypeConnection);
				_SqlOriginalStatement.SqlFromClause = dtAllgrd.Rows[0]["NomTab"].ToString();
				_SqlExportStatement.SqlFromClause = dtAllgrd.Rows[0]["NomTab"].ToString();
				if (TopClause > 0)
				{
					_SqlOriginalStatement.SqlTopClause = TopClause;
					_SqlExportStatement.SqlTopClause = TopClause;
				}
				int num = dtTabGrd.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string vsFieldName;
					if (Operators.CompareString(dtTabGrd.Rows[i]["NOMCAMEXP"].ToString(), "", false) != 0)
					{
						sqlSelect sqlExportStatement = _SqlExportStatement;
						vsFieldName = dtTabGrd.Rows[i]["NOMCAMEXP"].ToString();
						sqlExportStatement.AddSelectField(ref vsFieldName, dtTabGrd.Rows[i]["NOMCAMEXP"].ToString());
						sqlSelect sqlOriginalStatement = _SqlOriginalStatement;
						vsFieldName = dtTabGrd.Rows[i]["NOMCAMEXP"].ToString();
						sqlOriginalStatement.AddSelectField(ref vsFieldName, dtTabGrd.Rows[i]["NOMCAMEXP"].ToString());
					}
					if (Operators.CompareString(dtTabGrd.Rows[i]["NOMCAMTOOLTIP"].ToString(), "", false) != 0)
					{
						if (dtTabGrd.Rows[i]["NOMCAMTOOLTIP"].ToString().StartsWith("AJAX:"))
						{
							string vsFieldName2 = Strings.Mid(dtTabGrd.Rows[i]["NOMCAMTOOLTIP"].ToString(), 6);
							_SqlOriginalStatement.AddSelectField(ref vsFieldName2, vsFieldName2);
						}
						else
						{
							sqlSelect sqlOriginalStatement2 = _SqlOriginalStatement;
							vsFieldName = dtTabGrd.Rows[i]["NOMCAMTOOLTIP"].ToString();
							sqlOriginalStatement2.AddSelectField(ref vsFieldName, dtTabGrd.Rows[i]["NOMCAMTOOLTIP"].ToString());
						}
					}
					sqlSelect sqlOriginalStatement3 = _SqlOriginalStatement;
					vsFieldName = dtTabGrd.Rows[i]["NOMCAM"].ToString();
					sqlOriginalStatement3.AddSelectField(ref vsFieldName, dtTabGrd.Rows[i]["NOMCAM"].ToString());
				}
				DataRow[] array = dtTabGrd.Select("ORDCAM > 0", "ORDCAM");
				CampiOrdinantiIniziali = "";
				CampiOrdinantiInizialiDirezione = "";
				if (array != null)
				{
					int upperBound = array.GetUpperBound(0);
					for (int j = 0; j <= upperBound; j++)
					{
						_SqlOriginalStatement.AddOrderByField(array[j]["NOMCAM"].ToString(), (sqlSelect.OrderBySortOrder)Interaction.IIf(Operators.CompareString(array[j]["ORDDIR"].ToString(), "DESC", false) == 0, (object)sqlSelect.OrderBySortOrder.Descending, (object)sqlSelect.OrderBySortOrder.Ascending));
						_SqlExportStatement.AddOrderByField(array[j]["NOMCAM"].ToString(), (sqlSelect.OrderBySortOrder)Interaction.IIf(Operators.CompareString(array[j]["ORDDIR"].ToString(), "DESC", false) == 0, (object)sqlSelect.OrderBySortOrder.Descending, (object)sqlSelect.OrderBySortOrder.Ascending));
						if (Operators.CompareString(CampiOrdinantiIniziali, "", false) != 0)
						{
							CampiOrdinantiIniziali += ",";
						}
						CampiOrdinantiIniziali += array[j]["NOMCAM"].ToString();
						if (Operators.CompareString(CampiOrdinantiInizialiDirezione, "", false) != 0)
						{
							CampiOrdinantiInizialiDirezione += ",";
						}
						CampiOrdinantiInizialiDirezione += array[j]["ORDDIR"].ToString();
					}
				}
				_SqlOriginalStatement.AddWhere(_WhereAggiuntiva, _WhereAggiuntivaReadable, vbCanBeDeleted: false, vbUserVisible: false);
				_SqlExportStatement.AddWhere(_WhereAggiuntiva, _WhereAggiuntivaReadable, vbCanBeDeleted: false, vbUserVisible: false);
				string text2 = dtAllgrd.Rows[0]["WHEREAGGIUNTIVA"].ToString();
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text2 = Strings.Replace(text2, "%USER%", _ObjWebUserInfo.Codice, 1, -1, (CompareMethod)0);
					text2 = Strings.Replace(text2, "%GROUP%", _ObjWebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
					text2 = Strings.Replace(text2, "%FILIALE%", _ObjWebUserInfo.Filiale, 1, -1, (CompareMethod)0);
					text2 = Strings.Replace(text2, "%ORGANIZZAZIONE%", _ObjWebUserInfo.Organizzazione, 1, -1, (CompareMethod)0);
				}
				_SqlOriginalStatement.AddWhere(text2, text2, vbCanBeDeleted: false);
				_SqlExportStatement.AddWhere(text2, text2, vbCanBeDeleted: false);
				_sqlStatement = _SqlOriginalStatement.Copy();
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				_ObjCallStackHandler.CallStackRemove();
				result = val;
			}
			return result;
		}
	}

	public FXRETURN Reset_SqlSelect(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_SqlOriginalStatement != null)
			{
				_sqlStatement = _SqlOriginalStatement.Copy();
				if (Operators.CompareString(_WhereAggiuntiva, "", false) != 0)
				{
					_sqlStatement.AddWhere(_WhereAggiuntiva, _WhereAggiuntivaReadable, vbCanBeDeleted: false, vbUserVisible: false);
				}
				_SqlExportStatement = _sqlStatement.Copy();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN Reset_SqlPrefilterOnly(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_SqlOriginalStatement != null)
			{
				_SqlOriginalStatement.ClearDeletable();
				_sqlStatement = _SqlOriginalStatement.Copy();
				if (Operators.CompareString(_WhereAggiuntiva, "", false) != 0)
				{
					_sqlStatement.AddWhere(_WhereAggiuntiva, _WhereAggiuntivaReadable, vbCanBeDeleted: false, vbUserVisible: false);
				}
			}
			if (_SqlExportStatement != null)
			{
				_SqlExportStatement.ClearDeletable();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
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

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			_ObjCallStackHandler = null;
			_ObjIboAppLogHandling = null;
			dtAllgrd = null;
			dtTabGrd = null;
			dtHeaderStyle = null;
			dtPagerStyle = null;
			dtRowStyle = null;
			dtAlternatingRowStyle = null;
			dtSelectedRowStyle = null;
			_dbMain = null;
			_SqlOriginalStatement = null;
			_SqlExportStatement = null;
			_sqlStatement = null;
			_Translator = null;
			_ObjWebUserInfo = null;
		}
		disposedValue = true;
	}
}
