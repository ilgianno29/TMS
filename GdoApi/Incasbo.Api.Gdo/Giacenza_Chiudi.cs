using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Giacenza_Chiudi : GiacenzeAbstractApi
{
	protected string _UnibolChiusura;

	protected int _IdGiacenza;

	protected DataTable _dtSpedizione;

	protected DataTable _dtGiacenza;

	protected DateTime? _dataChiusura;

	protected string _NoteChiusura;

	protected string _CausaleChiusura;

	protected int? _GiorniGiacenza;

	protected bool _ApplyQuery;

	public Giacenza_Chiudi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_UnibolChiusura = "";
		_dtSpedizione = null;
		_dtGiacenza = null;
		_NoteChiusura = "";
		_CausaleChiusura = "";
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Invalid comparison between Unknown and I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_UnibolChiusura = ((AppAbstractApi)this).ParametersIn["UnibolChiusura"].ToString();
			_IdGiacenza = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["IdGiacenza"]);
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataChiusura"))
			{
				_dataChiusura = (DateTime?)((AppAbstractApi)this).ParametersIn["DataChiusura"];
			}
			if (!_dataChiusura.HasValue)
			{
				_dataChiusura = DateAndTime.Now;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("NoteChiusura"))
			{
				_NoteChiusura = Conversions.ToString(((AppAbstractApi)this).ParametersIn["NoteChiusura"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("CausaleChiusura"))
			{
				_CausaleChiusura = Conversions.ToString(((AppAbstractApi)this).ParametersIn["CausaleChiusura"]);
			}
			if (Operators.CompareString(_CausaleChiusura, "", false) == 0)
			{
				_CausaleChiusura = base.ApplicationDefault.Giacenza_CausaleChiusura_Default();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("GiorniGiacenza"))
			{
				_GiorniGiacenza = (int?)((AppAbstractApi)this).ParametersIn["GiorniGiacenza"];
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			val = CheckGiacenza(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckSpedizione(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
					val2 = (FXRETURN)0;
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Invalid comparison between Unknown and I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Invalid comparison between Unknown and I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "UPDATE Giacenze SET Stato=20, DataChiusura=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _dataChiusura) + ", ";
			text = text + "DataCompetenzaAttiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _dataChiusura) + ", ";
			text = text + "DataCompetenzaPassiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _dataChiusura) + ", ";
			text = text + "GiorniGiacenza=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _GiorniGiacenza) + ", ";
			text = text + "UnibolChiusura=" + ((AppBaseClass)this).DbConn.SQLFormatString(_UnibolChiusura) + ", ";
			string text2 = text;
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			int pNumero = Conversions.ToInteger(_dtSpedizione.Rows[0]["ProgressivoConsegna"]);
			text = text2 + "ProgressivoChiusura=" + dbConn.SQLFormatNumber(ref pNumero) + ", ";
			text = text + "CausaleChiusura=" + ((AppBaseClass)this).DbConn.SQLFormatString(_CausaleChiusura) + ", ";
			text = text + "NoteChiusura=" + ((AppBaseClass)this).DbConn.SQLFormatString(_NoteChiusura) + ", ";
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdGiacenza) + "; ";
			string RetQueryToApply = "";
			val = EventoSpedizione_ChiudiGiacenza.RunProc(this._ApiContext, _UnibolChiusura, _dataChiusura, _IdGiacenza.ToString(), this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += RetQueryToApply;
				((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
				if (!_ApplyQuery)
				{
					goto IL_0232;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0232;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_0232:
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_UnibolChiusura, "", false) != 0)
			{
				goto IL_00d6;
			}
			object objRes = null;
			text = "SELECT UNIBOl FROM SPEDIZIONI WHERE Stato<90 AND IDGiacenza=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdGiacenza) + " ORDER BY ProgressivoConsegna DESC";
			val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_UnibolChiusura = objRes.ToString();
				if (Operators.CompareString(_UnibolChiusura, "", false) != 0)
				{
					goto IL_00d6;
				}
				rsmess = this.TranslateMessage("XXX", "Impossibile determinare l'Id spedizione di chiusura della giacenza", new string[1] { _IdGiacenza.ToString() });
			}
			goto end_IL_000b;
			IL_00d6:
			text = "SELECT S.* FROM VW_Spedizioni S WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_UnibolChiusura);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _UnibolChiusura });
			}
			else
			{
				DataRow dataRow = _dtSpedizione.Rows[0];
				if ((Conversions.ToInteger(dataRow["Stato"]) <= 40) | (Conversions.ToInteger(dataRow["Stato"]) >= 60))
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permette la chiusura di una giacenza. La spedizione deve essere esitata o arrivata a TP.", new string[1] { _UnibolChiusura });
				}
				else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non ha associato nessun documento di giacenza.", new string[1] { _UnibolChiusura });
				}
				else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), _IdGiacenza.ToString(), false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} ha associato un altro documento di giacenza.", new string[1] { _UnibolChiusura });
				}
				else
				{
					val2 = (FXRETURN)0;
				}
			}
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

	protected virtual FXRETURN CheckGiacenza(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "SELECT * FROM Giacenze ";
			text = text + "WHERE ID = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdGiacenza);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtGiacenza, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtGiacenza.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La giacenza con Id {0} non esiste", new string[1] { _IdGiacenza.ToString() });
			}
			else
			{
				DataRow dataRow = _dtGiacenza.Rows[0];
				if (Conversions.ToInteger(dataRow["Stato"]) > 10)
				{
					rsmess = this.TranslateMessage("XXX", "La giacenza con Id {0} risulta già chiusa", new string[1] { _IdGiacenza.ToString() });
				}
				else
				{
					DateTime? dataChiusura = _dataChiusura;
					DateTime t = Conversions.ToDate(dataRow["DataApertura"]);
					if ((dataChiusura.HasValue ? new bool?(DateTime.Compare(dataChiusura.GetValueOrDefault(), t) < 0) : null).GetValueOrDefault())
					{
						rsmess = this.TranslateMessage("XXX", "La data di chiusura della giacenza non può essere antecedente a quella di apertura della stessa giacenza");
					}
					else
					{
						if (!_GiorniGiacenza.HasValue)
						{
							_GiorniGiacenza = checked((int)DateAndTime.DateDiff((DateInterval)4, Conversions.ToDate(dataRow["DataApertura"]), _dataChiusura.Value, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						}
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
}
