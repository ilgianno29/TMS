using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_GeneraPdf : GdoAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected string _ReportName;

	protected string _NomeFileCompletoGenerato;

	protected string _FileNameOutput;

	public Spedizione_GeneraPdf(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizione = null;
		_ReportName = "";
		_NomeFileCompletoGenerato = "";
		_FileNameOutput = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			this._ParametersOut.Add("FileNameOutput", "");
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			val = CheckSpedizione(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			object objRes = null;
			text = "SELECT NOMTAB FROM WFI_TabRep WHERE NOMREP=" + ((AppBaseClass)this).DbConn.SQLFormatString(_ReportName);
			val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text2 = objRes.ToString();
				if (Operators.CompareString(text2, "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Impossibile determinare la vista sorgente del report {0}.", new string[1] { _ReportName });
				}
				else
				{
					IboCRW val3 = new IboCRW(ref this._ApiContext);
					string text3 = "DDT" + _Unibol + "_" + this._User + "_*.PDF";
					string fileNameOutput = "";
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					string reportName = _ReportName;
					string text4 = "{" + text2 + ".UNIBOL}=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
					string text5 = "UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
					bool flag = false;
					val = val3.CrystalReportToPDF(reportName, text3, text4, text5, dictionary, ref fileNameOutput, ref flag, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						_FileNameOutput = fileNameOutput;
						this._ParametersOut["FileNameOutput"] = _FileNameOutput;
						val2 = (FXRETURN)0;
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Unibol, "", false) == 0)
			{
				goto IL_01a0;
			}
			text = "SELECT S.Unibol, S.Cliente, C.StampaBolla, C.RagioneSociale Cliente_RagioneSociale, ReportBolle ";
			text = text + "FROM Spedizioni S INNER JOIN Clienti C ON C.Codice=S.Cliente WHERE S.Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
			}
			else
			{
				if (Operators.CompareString(_dtSpedizione.Rows[0]["StampaBolla"].ToString(), "N", false) != 0)
				{
					if (Operators.CompareString(_dtSpedizione.Rows[0]["ReportBolle"].ToString(), "", false) == 0)
					{
						_ReportName = "RPT_DDT.rpt";
					}
					else
					{
						_ReportName = _dtSpedizione.Rows[0]["ReportBolle"].ToString();
					}
					goto IL_01a0;
				}
				rsmess = this.TranslateMessage("XXX", "Il cliente {0} non prevede la stampa del DDT", new string[1] { _dtSpedizione.Rows[0]["Cliente_RagioneSociale"].ToString() });
			}
			goto end_IL_000b;
			IL_01a0:
			val2 = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}
}
