using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_DeterminaSequenzaSpedizioni : GdoAbstractApi
{
	protected string _IdViaggio;

	protected bool _ApplyQuery;

	protected DataTable _dtViaggio;

	protected bool _ResetExistingSequence;

	protected bool _IgnoraErroreWMS;

	public Viaggio_DeterminaSequenzaSpedizioni(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_ApplyQuery = true;
		_dtViaggio = null;
		_ResetExistingSequence = false;
		_IgnoraErroreWMS = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("IgnoraErroreWMS"))
			{
				_IgnoraErroreWMS = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["IgnoraErroreWMS"]);
			}
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			val = CheckViaggio(ref rsmess);
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
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string retQuery = "";
			if (base.ApplicationParams.RaggruppaConPCSPartenza())
			{
				val = RaggruppaSequenzaConPcsPartenza(ref retQuery, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0066;
				}
				val2 = val;
			}
			else
			{
				val = RaggruppaSequenza(ref retQuery, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0066;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_0066:
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = retQuery;
			val2 = (FXRETURN)0;
			end_IL_0005:;
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

	protected virtual FXRETURN RaggruppaSequenza(ref string retQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Invalid comparison between Unknown and I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Invalid comparison between Unknown and I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Invalid comparison between Unknown and I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			retQuery = "";
			text = "SELECT CASE WHEN LEFT(F1,1)='#' THEN 'D' ELSE 'C' END Tipo,";
			text += "CASE WHEN LEFT(F1,1)='#' THEN SUBSTRING(F1,2,LEN(F1)-1) ELSE F1 END Codice,";
			text += "SequenzaPianificata FROM ( SELECT %TOP100PERCENT% * FROM (";
			text += "SELECT %ISNULL%(Corrispondente,'#' %+% PCSDestinazione) F1,";
			text += "MAX(SequenzaPianificata) SequenzaPianificata ";
			text = text + "FROM SPEDIZIONI WHERE STATO < 90 AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
			text += "GROUP BY %ISNULL%(corrispondente,'#' %+% PCSDestinazione) ) T1 ";
			if (!_ResetExistingSequence)
			{
				text += " ORDER BY CASE WHEN SequenzaPianificata=0 then 999999 ELSE SequenzaPianificata END";
				text += ") T2 ORDER BY CASE WHEN SequenzaPianificata=0 then 999999 ELSE SequenzaPianificata END";
			}
			else
			{
				text += ") T2 ORDER BY Tipo,Codice";
			}
			text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				int pNumero = 0;
				DataTable rObjDataTable2 = null;
				string vsSQLClause = "Select isnull(SEQUENZAPIANIFICATA, 0) as SEQUENZAPIANIFICATA FROM spedizioni WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " order by SEQUENZAPIANIFICATA desc";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (rObjDataTable2.Rows.Count > 0)
					{
						pNumero = Conversions.ToInteger(rObjDataTable2.Rows[0]["SEQUENZAPIANIFICATA"]);
						pNumero = checked(pNumero + 10);
					}
					foreach (DataRow row in rObjDataTable.Rows)
					{
						string text2 = "";
						if (Operators.CompareString(row["Tipo"].ToString(), "C", false) == 0)
						{
							text2 = "UPDATE Spedizioni SET SequenzaPianificata=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
							text2 = text2 + "WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
							text2 = text2 + "AND Corrispondente=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + "  AND SEQUENZAPIANIFICATA = 0;";
							goto IL_03f7;
						}
						if (Operators.CompareString(row["Tipo"].ToString(), "D", false) != 0)
						{
							goto IL_03f7;
						}
						DataTable rObjDataTable3 = null;
						string text3 = "Select PCSDestinazione, SequenzaPianificata FROM spedizioni WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
						text3 = text3 + "AND PCSDestinazione=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + " and SequenzaPianificata > 0 ";
						val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable3, ref rsmess);
						if ((int)val <= 0)
						{
							if (rObjDataTable3.Rows.Count > 0)
							{
								int pNumero2 = Conversions.ToInteger(rObjDataTable3.Rows[0]["SEQUENZAPIANIFICATA"]);
								text2 = "UPDATE Spedizioni SET SequenzaPianificata=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + " ";
								text2 = text2 + "WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
								text2 = text2 + "AND PCSDestinazione=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + " AND SEQUENZAPIANIFICATA = 0;";
							}
							else
							{
								text2 = "UPDATE Spedizioni SET SequenzaPianificata=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
								text2 = text2 + "WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
								text2 = text2 + "AND PCSDestinazione=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + " AND SEQUENZAPIANIFICATA = 0;";
							}
							goto IL_03f7;
						}
						val2 = val;
						goto end_IL_000b;
						IL_03f7:
						if (Operators.CompareString(text2, "", false) != 0)
						{
							retQuery += text2;
						}
						if (Conversions.ToInteger(row["SequenzaPianificata"]) == 0)
						{
							pNumero = checked(pNumero + 10);
						}
					}
					if (!_ApplyQuery || Operators.CompareString(retQuery, "", false) == 0)
					{
						goto IL_04aa;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(retQuery, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_04aa;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_04aa:
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

	protected virtual FXRETURN RaggruppaSequenzaConPcsPartenza(ref string retQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Invalid comparison between Unknown and I4
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Invalid comparison between Unknown and I4
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			retQuery = "";
			text = "SELECT CASE WHEN LEFT(F1,1)='#' THEN 'D' ELSE 'C' END Tipo,";
			text += "CASE WHEN LEFT(F1,1)='#' THEN SUBSTRING(F1,2,LEN(F1)-1) ELSE F1 END Codice,";
			text += "SequenzaPianificata, PCSPARTENZA FROM ( SELECT %TOP100PERCENT% * FROM (";
			text += "SELECT %ISNULL%(Corrispondente,'#' %+% PCSDestinazione) F1,";
			text += "MAX(SequenzaPianificata) SequenzaPianificata, ";
			text += "PCSPARTENZA ";
			text = text + "FROM SPEDIZIONI WHERE STATO < 90 AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
			text += "GROUP BY PCSPARTENZA, %ISNULL%(corrispondente,'#' %+% PCSDestinazione) ) T1 ";
			if (!_ResetExistingSequence)
			{
				text += " ORDER BY CASE WHEN SequenzaPianificata=0 then 999999 ELSE SequenzaPianificata END";
				text += ") T2 ORDER BY CASE WHEN SequenzaPianificata=0 then 999999 ELSE SequenzaPianificata END";
			}
			else
			{
				text += ") T2 ORDER BY PCSPartenza,Tipo,Codice";
			}
			text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				int pNumero = 0;
				foreach (DataRow row in rObjDataTable.Rows)
				{
					pNumero = checked(pNumero + 10);
					string text2 = "";
					if (Operators.CompareString(row["Tipo"].ToString(), "C", false) == 0)
					{
						text2 = "UPDATE Spedizioni SET SequenzaPianificata=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
						text2 = text2 + "WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
						text2 = text2 + "AND PCSPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["PCSPartenza"].ToString()) + " AND SEQUENZAPIANIFICATA = 0 ";
						text2 = text2 + "AND Corrispondente=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + ";";
						goto IL_045f;
					}
					if (Operators.CompareString(row["Tipo"].ToString(), "D", false) != 0)
					{
						goto IL_045f;
					}
					DataTable rObjDataTable2 = null;
					string text3 = "Select PCSDestinazione, SequenzaPianificata FROM spedizioni WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
					text3 = text3 + "AND PCSDestinazione=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + " and SequenzaPianificata > 0  ";
					text3 = text3 + "AND PCSPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["PCSPartenza"].ToString());
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable2, ref rsmess);
					if ((int)val <= 0)
					{
						if (rObjDataTable2.Rows.Count > 0)
						{
							int pNumero2 = Conversions.ToInteger(rObjDataTable2.Rows[0]["SEQUENZAPIANIFICATA"]);
							text2 = "UPDATE Spedizioni SET SequenzaPianificata=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + " ";
							text2 = text2 + "WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
							text2 = text2 + "AND PCSPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["PCSPartenza"].ToString()) + " AND SEQUENZAPIANIFICATA = 0 ";
							text2 += "AND Corrispondente IS NULL ";
							text2 = text2 + "AND PCSDestinazione=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + ";";
						}
						else
						{
							text2 = "UPDATE Spedizioni SET SequenzaPianificata=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
							text2 = text2 + "WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
							text2 = text2 + "AND PCSPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["PCSPartenza"].ToString()) + " AND SEQUENZAPIANIFICATA = 0 ";
							text2 += "AND Corrispondente IS NULL ";
							text2 = text2 + "AND PCSDestinazione=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + ";";
						}
						goto IL_045f;
					}
					val2 = val;
					goto end_IL_000b;
					IL_045f:
					if (Operators.CompareString(text2, "", false) != 0)
					{
						retQuery += text2;
					}
				}
				if (!_ApplyQuery || Operators.CompareString(retQuery, "", false) == 0)
				{
					goto IL_04ef;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(retQuery, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_04ef;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_04ef:
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Stato, IdViaggio FROM Viaggi WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non esiste", new string[1] { _IdViaggio });
			}
			else
			{
				val2 = (FXRETURN)0;
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
}
