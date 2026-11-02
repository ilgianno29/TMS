using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Giacenza_Crea : GiacenzeAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected DateTime? _dataApertura;

	protected string _Note1;

	protected string _Note2;

	protected string _Note3;

	protected Giacenza _Giacenza;

	protected bool _ApplyQuery;

	public Giacenza_Crea(AppApiContext objApiContext)
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
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Invalid comparison between Unknown and I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataApertura"))
			{
				_dataApertura = (DateTime?)((AppAbstractApi)this).ParametersIn["DataApertura"];
			}
			if (!_dataApertura.HasValue)
			{
				_dataApertura = DateAndTime.Now;
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Giacenza"))
			{
				_Giacenza = (Giacenza)((AppAbstractApi)this).ParametersIn["Giacenza"];
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
				((AppAbstractApi)this).ParametersOut.Add("IdGiacenza", null);
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
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = CreazioneGiacenza(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_Giacenza == null)
				{
					goto IL_014e;
				}
				string sQuery = "";
				val = CreateQueryINSERT(_Giacenza, ref sQuery, ref rsmess);
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
						sQuery = "";
						val = EventoSpedizione_CreaGiacenza.RunProc(this._ApiContext, _Unibol, _dataApertura, _Giacenza.Id.ToString(), this._User, ApplyQuery: false, ref sQuery, ref rsmess);
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
								goto IL_012b;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
							if ((int)val <= 0)
							{
								goto IL_012b;
							}
							val2 = val;
						}
					}
				}
			}
			goto end_IL_000b;
			IL_012b:
			((AppAbstractApi)this).ParametersOut["IDGiacenza"] = _Giacenza.Id;
			goto IL_014e;
			IL_014e:
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
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.*, TS.CreaGiacenza, T.FatturaA TrasportatoreFatturazione, V.Vettore VettoreCodice, T2.FatturaA VettoreFatturazione ";
			text += "FROM VW_Spedizioni S INNER JOIN TipiServizi TS ON S.TipoServizio=TS.Codice ";
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
				if ((Conversions.ToInteger(dataRow["Stato"]) <= 40) | (Conversions.ToInteger(dataRow["Stato"]) >= 60))
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permette la creazione di una giacenza. La spedizione deve essere esitata o arrivata a TP.", new string[1] { _Unibol });
				}
				else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), "", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} ha già associato un documento di giacenza.", new string[1] { _Unibol });
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

	protected virtual FXRETURN CreazioneGiacenza(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			bool flag = false;
			if (Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), "", false) != 0 || Operators.CompareString(_dtSpedizione.Rows[0]["CreaGiacenza"].ToString().ToUpper(), "S", false) != 0 || !((Operators.CompareString(_dtSpedizione.Rows[0]["Evento_CreaGiacenza"].ToString().ToUpper(), "S", false) == 0) | (Operators.CompareString(_dtSpedizione.Rows[0]["Evento_CreaGiacenza"].ToString().ToUpper(), "A", false) == 0)))
			{
				goto IL_0392;
			}
			if (_Giacenza == null)
			{
				_Giacenza = new Giacenza();
			}
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.GIACENZE.ID", ref rlReturnValue, ref rsmess);
			if ((int)val <= 0)
			{
				_Giacenza.Id = checked((int)rlReturnValue);
				_Giacenza.Stato = 10;
				_Giacenza.UnibolMaster = _dtSpedizione.Rows[0]["UnibolMaster"].ToString();
				_Giacenza.UnibolApertura = _Unibol;
				_Giacenza.ProgressivoApertura = Conversions.ToInteger(_dtSpedizione.Rows[0]["ProgressivoConsegna"]);
				_Giacenza.DataApertura = _dataApertura.Value;
				_Giacenza.Cliente = _dtSpedizione.Rows[0]["Cliente"].ToString();
				_Giacenza.ClienteFatturazione = _dtSpedizione.Rows[0]["ClienteFatturazione"].ToString();
				_Giacenza.Corrispondente = _dtSpedizione.Rows[0]["Corrispondente"].ToString();
				_Giacenza.Trasportatore = _dtSpedizione.Rows[0]["Trasportatore"].ToString();
				if (Operators.CompareString(_Giacenza.Corrispondente, "", false) == 0)
				{
					_Giacenza.Trasportatore = _dtSpedizione.Rows[0]["VettoreCodice"].ToString();
					_Giacenza.TrasportatoreFatturazione = _dtSpedizione.Rows[0]["VettoreFatturazione"].ToString();
				}
				else
				{
					_Giacenza.TrasportatoreFatturazione = _dtSpedizione.Rows[0]["TrasportatoreFatturazione"].ToString();
				}
				_Giacenza.Note1 = _Note1;
				_Giacenza.Note2 = _Note2;
				_Giacenza.Note3 = _Note3;
				_Giacenza.UteAgg = this._User;
				_Giacenza.UteIns = this._User;
				flag = true;
				goto IL_0392;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0392:
			if (!flag)
			{
				_Giacenza = null;
			}
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
			Giacenza giacenza;
			int pNumero = (giacenza = _Giacenza).Id;
			string text = dbConn.SQLFormatNumber(ref pNumero);
			giacenza.Id = pNumero;
			sQuery = "UPDATE Spedizioni SET IdGiacenza=" + text + " ";
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
