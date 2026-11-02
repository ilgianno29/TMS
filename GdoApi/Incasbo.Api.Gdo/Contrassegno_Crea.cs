using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_Crea : ContrassegniAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected DateTime? _data;

	protected string _Note1;

	protected string _Note2;

	protected string _Note3;

	protected Contrassegno _contrassegno;

	protected bool _ApplyQuery;

	public Contrassegno_Crea(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizione = null;
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Data"))
			{
				_data = (DateTime?)((AppAbstractApi)this).ParametersIn["Data"];
			}
			if (!_data.HasValue)
			{
				_data = DateAndTime.Now;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note1"))
			{
				_Note1 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note1"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note2"))
			{
				_Note2 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note2"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note3"))
			{
				_Note3 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note3"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			val = CheckSpedizione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("IdContrassegno", null);
				((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = CreazioneContrassegno(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_contrassegno == null)
				{
					goto IL_00f6;
				}
				string sQuery = "";
				val = CreateQueryINSERT(_contrassegno, ref sQuery, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text = sQuery;
					val = AggiornamentoSpedizione(ref sQuery, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += sQuery;
						((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
						if (!_ApplyQuery)
						{
							goto IL_00d3;
						}
						val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_00d3;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_000b;
			IL_00f6:
			val2 = (FXRETURN)0;
			goto end_IL_000b;
			IL_00d3:
			((AppAbstractApi)this).ParametersOut["IdContrassegno"] = _contrassegno.Id;
			goto IL_00f6;
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
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.*, TS.CreaContrassegno, T.FatturaA TrasportatoreFatturazione, V.Vettore VettoreCodice, T2.FatturaA VettoreFatturazione ";
			text += "FROM Spedizioni S INNER JOIN TipiServizi TS ON S.TipoServizio=TS.Codice ";
			text += "LEFT JOIN Trasportatori T ON T.Codice=S.Trasportatore ";
			text += "LEFT JOIN Viaggi V ON V.IdViaggio=S.IdViaggio ";
			text += "LEFT JOIN Trasportatori T2 ON T2.Codice=V.Vettore ";
			text = text + "WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
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
				DataRow dataRow = _dtSpedizione.Rows[0];
				if ((Conversions.ToInteger(dataRow["Stato"]) < 30) | (Conversions.ToInteger(dataRow["Stato"]) >= 90))
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permette la creazione di un contrassegno", new string[1] { _Unibol });
				}
				else
				{
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

	protected virtual FXRETURN CreazioneContrassegno(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!((decimal.Compare(Conversions.ToDecimal(_dtSpedizione.Rows[0]["Contrassegno"]), 0m) > 0) & (Operators.CompareString(_dtSpedizione.Rows[0]["IdContrassegno"].ToString(), "", false) == 0)) || Operators.CompareString(_dtSpedizione.Rows[0]["CreaContrassegno"].ToString().ToUpper(), "S", false) != 0)
			{
				goto IL_0337;
			}
			_contrassegno = new Contrassegno();
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.CONTRASSEGNI.ID", ref rlReturnValue, ref rsmess);
			if ((int)val <= 0)
			{
				_contrassegno.Id = checked((int)rlReturnValue);
				_contrassegno.Stato = 10;
				_contrassegno.UnibolMaster = _dtSpedizione.Rows[0]["UnibolMaster"].ToString();
				_contrassegno.UnibolApertura = _Unibol;
				_contrassegno.DataCreazione = _data.Value;
				_contrassegno.Cliente = _dtSpedizione.Rows[0]["Cliente"].ToString();
				_contrassegno.ClienteFatturazione = _dtSpedizione.Rows[0]["ClienteFatturazione"].ToString();
				_contrassegno.Corrispondente = _dtSpedizione.Rows[0]["Corrispondente"].ToString();
				_contrassegno.Trasportatore = _dtSpedizione.Rows[0]["Trasportatore"].ToString();
				if (Operators.CompareString(_contrassegno.Corrispondente, "", false) == 0)
				{
					_contrassegno.Trasportatore = _dtSpedizione.Rows[0]["VettoreCodice"].ToString();
					_contrassegno.TrasportatoreFatturazione = _dtSpedizione.Rows[0]["VettoreFatturazione"].ToString();
				}
				else
				{
					_contrassegno.TrasportatoreFatturazione = _dtSpedizione.Rows[0]["TrasportatoreFatturazione"].ToString();
				}
				_contrassegno.ImportoContrassegno = Conversions.ToDecimal(_dtSpedizione.Rows[0]["Contrassegno"]);
				_contrassegno.Note1 = _Note1;
				_contrassegno.Note2 = _Note2;
				_contrassegno.Note3 = _Note3;
				_contrassegno.UteAgg = this._User;
				_contrassegno.UteIns = this._User;
				goto IL_0337;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0337:
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

	protected virtual FXRETURN AggiornamentoSpedizione(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			Contrassegno contrassegno;
			int pNumero = (contrassegno = _contrassegno).Id;
			string text = dbConn.SQLFormatNumber(ref pNumero);
			contrassegno.Id = pNumero;
			sQuery = "UPDATE Spedizioni SET IdContrassegno=" + text + " ";
			sQuery = sQuery + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			val2 = (FXRETURN)0;
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
