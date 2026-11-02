using System;
using System.Data;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebToolbarInfo : IDisposable
{
	private bool disposedValue;

	protected string _NomRif;

	protected string _Utente;

	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IboWebUserInfo _ObjWebUserInfo;

	protected IncasTranslator _Translator;

	protected DBConnection _dbMain;

	protected DataTable _dtBottoniFissi;

	protected DataTable _dtBottoniDinamici;

	protected bool _OnlyEnabledButtons;

	public DataTable BottoniFissi => _dtBottoniFissi;

	public DataRow get_BottoneFisso(int Index) => _dtBottoniFissi.Rows[Index];

	public int BottoniFissiCount => _dtBottoniFissi.Rows.Count;

	public DataTable BottoniDinamici => _dtBottoniDinamici;

	public DataRow get_BottoneDinamico(int Index) => _dtBottoniDinamici.Rows[Index];

	public int BottoniDinamiciCount => _dtBottoniDinamici.Rows.Count;

	public IboWebToolbarInfo(string vsNomRif, string vsUtente, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		disposedValue = false;
		_NomRif = "";
		_Utente = "";
		_OnlyEnabledButtons = false;
		_NomRif = vsNomRif;
		_Utente = vsUtente;
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_dbMain = rObjDbMain;
		_ObjWebUserInfo = rObjWebUserInfo;
		_Translator = rObjTranslator;
		_OnlyEnabledButtons = false;
	}

	public FXRETURN Init(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if ((int)LoadStructure(ref rsMess) <= 0)
			{
				val = (FXRETURN)0;
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

	public FXRETURN Reset(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
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

	private FXRETURN LoadStructure(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Invalid comparison between Unknown and I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			text = "SELECT WFI_AllBtn.*, ";
			text += "WFI_TABBOT.NOMRIF TABBOT_NOMRIF, ";
			text += "WFI_TABBOT.NUMBOT TABBOT_NUMBOT, ";
			text += "WFI_TABBOT.PESBOT TABBOT_PESBOT, ";
			text += "WFI_TABBOT.ShowCaption TABBOT_ShowCaption, ";
			text += "WFI_TABBOT.ShowImage TABBOT_ShowImage, ";
			text += "WFI_TABBOT.CaptionBot TABBOT_CaptionBot, ";
			text += "WFI_TABBOT.TooltipBot TABBOT_TooltipBot, ";
			text += "WFI_TABBOT.NumBot_Parent TABBOT_NumBot_Parent, ";
			text += "WFI_TABBot.Ordinamento WFI_TABBot_Ordinamento ";
			text += "FROM WFI_AllBtn LEFT JOIN WFI_TABBot ";
			text += "ON WFI_AllBtn.NumBot = WFI_TABBot.NumBot ";
			if (!_OnlyEnabledButtons)
			{
				text = text + "AND WFI_TABBot.NomRif = " + _dbMain.SQLFormatString(_NomRif) + " ";
				text = text + "AND WFI_TABBot.Utente = " + _dbMain.SQLFormatString(_Utente) + " ";
			}
			text += "WHERE WFI_AllBtn.Fisso = 'S' ";
			text += "AND WFI_AllBtn.Visibile = 'S' ";
			text += "AND %ISNULL%(WFI_Tabbot.Visibile,'S') = 'S' ";
			if (_OnlyEnabledButtons)
			{
				text = text + "AND WFI_TABBot.NomRif = " + _dbMain.SQLFormatString(_NomRif) + " ";
				text = text + "AND WFI_TABBot.NomRif = " + _dbMain.SQLFormatString(_Utente) + " ";
			}
			text += "ORDER BY %ISNULL%(WFI_TABBot.Ordinamento,0), WFI_AllBtn.NumBot ";
			text = _dbMain.SqlConvertForServer(text);
			val2 = _dbMain.OpenDataTable(text, ref _dtBottoniFissi, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (!_dtBottoniFissi.Columns.Contains("Shortcut"))
				{
					DataColumn dataColumn = new DataColumn("Shortcut", typeof(string));
					dataColumn.DefaultValue = "";
					_dtBottoniFissi.Columns.Add(dataColumn);
				}
				text = "SELECT WFI_AllBtn.*, ";
				text += "WFI_TABBOT.NOMRIF TABBOT_NOMRIF, ";
				text += "WFI_TABBOT.NUMBOT TABBOT_NUMBOT, ";
				text += "WFI_TABBOT.PESBOT TABBOT_PESBOT, ";
				text += "WFI_TABBOT.ShowCaption TABBOT_ShowCaption, ";
				text += "WFI_TABBOT.ShowImage TABBOT_ShowImage, ";
				text += "WFI_TABBOT.CaptionBot TABBOT_CaptionBot, ";
				text += "WFI_TABBOT.TooltipBot TABBOT_TooltipBot, ";
				text += "WFI_TABBOT.NumBot_Parent TABBOT_NumBot_Parent, ";
				text += "WFI_TABBot.Ordinamento WFI_TABBot_Ordinamento ";
				text += "FROM WFI_AllBtn INNER JOIN WFI_TABBot ON ";
				text += "WFI_AllBtn.NumBot = WFI_TABBot.NumBot ";
				text = text + "WHERE WFI_TABBot.NomRif = " + _dbMain.SQLFormatString(_NomRif) + "  ";
				text += "AND WFI_AllBtn.Visibile = 'S' ";
				text += "AND %ISNULL%(WFI_Tabbot.Visibile,'S') = 'S' ";
				text = text + "AND WFI_TABBot.Utente = " + _dbMain.SQLFormatString(_Utente) + " ";
				text += "AND WFI_AllBtn.Fisso = 'N' ";
				text += "ORDER BY %ISNULL%(WFI_TABBot.Ordinamento,0), WFI_AllBtn.NumBot ";
				text = _dbMain.SqlConvertForServer(text);
				val2 = _dbMain.OpenDataTable(text, ref _dtBottoniDinamici, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (!_dtBottoniDinamici.Columns.Contains("Shortcut"))
					{
						DataColumn dataColumn2 = new DataColumn("Shortcut", typeof(string));
						dataColumn2.DefaultValue = "";
						_dtBottoniDinamici.Columns.Add(dataColumn2);
					}
					val = (FXRETURN)0;
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

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			_ObjCallStackHandler = null;
			_ObjIboAppLogHandling = null;
			_dbMain = null;
			_ObjWebUserInfo = null;
			_Translator = null;
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
