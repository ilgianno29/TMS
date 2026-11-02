using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_GeneraSpedizionePerMerceNonCaricata : AppAbstractApi
{
	protected string _Unibol;

	protected bool _ApplyQuery;

	protected DataTable _dtSpedizione;

	protected DataTable _dtUds;

	public Spedizione_GeneraSpedizionePerMerceNonCaricata(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_ApplyQuery = true;
		_dtSpedizione = null;
		_dtUds = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlQuery = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string retUnibol = "";
			val = GeneraQueryPerSpedizione(ref ssqlQuery, ref retUnibol, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += ssqlQuery;
				val = GeneraQueryPerUds(retUnibol, ref ssqlQuery, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += ssqlQuery;
					if (!_ApplyQuery)
					{
						((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
						goto IL_00b3;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_00b3;
					}
					val2 = val;
				}
			}
			goto end_IL_0012;
			IL_00b3:
			val2 = (FXRETURN)0;
			end_IL_0012:;
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
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM Spedizioni WHERE Unibol =" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non è presente a sistema", new string[1] { _Unibol });
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["STATO"].ToString(), "30", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non risulta in stato 'pianificata'", new string[1] { _Unibol });
			}
			else
			{
				text = "SELECT Codice FROM SpedizioniUds WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND Esito IS NOT NULL AND Esito IN (SELECT CODICE FROM EVENTI WHERE TIPOEVENTO=" + ((AppBaseClass)this).DbConn.SQLFormatString(EventoSpedizioneTipo.UdsNonCaricata) + " AND GENERARICONSEGNA='S')";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtUds, ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	protected virtual FXRETURN GeneraQueryPerSpedizione(ref string ssqlQuery, ref string retUnibol, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FieldsDictionary val3 = new FieldsDictionary();
		StringCollection stringCollection = new StringCollection();
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ssqlQuery = "";
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.SPEDIZIONI", ref rlReturnValue, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				((Dictionary<string, string>)(object)val3).Add("UNIBOL", ((AppBaseClass)this).DbConn.SQLFormatString(rlReturnValue.ToString()));
				((Dictionary<string, string>)(object)val3).Add("UNIBOLPARENT", ((AppBaseClass)this).DbConn.SQLFormatString(rlReturnValue.ToString()));
				((Dictionary<string, string>)(object)val3).Add("PROGRESSIVOCONSEGNA", "0");
				((Dictionary<string, string>)(object)val3).Add("STATO", "10");
				((Dictionary<string, string>)(object)val3).Add("UTEINS", this.DbConn.SQLFormatString(this._User));
				((Dictionary<string, string>)(object)val3).Add("UTEAGG", this.DbConn.SQLFormatString(this._User));
				stringCollection.Add("IDVIAGGIO");
				stringCollection.Add("STATOWMS");
				stringCollection.Add("STATOSPUNTAUSCITA");
				stringCollection.Add("STATOOBC");
				stringCollection.Add("UNIBOLOBC");
				stringCollection.Add("DATAORAPARTENZAPIANIFICATA");
				stringCollection.Add("DATAORAARRIVOPIANIFICATA");
				stringCollection.Add("DATAORAPARTENZAEFFETTIVA");
				stringCollection.Add("DATAORAARRIVOEFFETTIVA");
				stringCollection.Add("KMPIANIFICATI");
				stringCollection.Add("KMRICALCOLATI");
				stringCollection.Add("KMGPS");
				stringCollection.Add("KMMANUALI");
				stringCollection.Add("SEQUENZAEFFETTIVA");
				stringCollection.Add("SEQUENZAPIANIFICATA");
				stringCollection.Add("IDFATTURAATTIVA");
				stringCollection.Add("IDFATTURAPASSIVA");
				stringCollection.Add("BLOCCACOSTI");
				stringCollection.Add("BLOCCARICAVI");
				stringCollection.Add("IDRAGGRUPPAMENTOATTIVO");
				stringCollection.Add("IDRAGGRUPPAMENTOPASSIVO");
				stringCollection.Add("TIPOCONTRATTOATTIVOAPPLICATO");
				stringCollection.Add("TIPOCONTRATTOPASSIVOAPPLICATO");
				stringCollection.Add("ERRORETARIFFAATTIVA");
				stringCollection.Add("ERRORETARIFFAPASSIVA");
				stringCollection.Add("DATINS");
				stringCollection.Add("DATAGG");
				stringCollection.Add("RicavoViaggioRipartito");
				stringCollection.Add("RicavoViaggioRipartitoNolo");
				stringCollection.Add("CostoViaggioRipartito");
				stringCollection.Add("CostoViaggioRipartitoNolo");
				stringCollection.Add("DataOraPartenzaRicalcolata");
				stringCollection.Add("DataOraArrivoRicalcolata");
				stringCollection.Add("DataEsportazioneVettore");
				stringCollection.Add("Vettore");
				string text2 = "UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
				val = CopiaRecord.RunProc(this._ApiContext, "SPEDIZIONI", "SPEDIZIONI", text2, ref val3, ref stringCollection, false, false, ref text, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					ssqlQuery = text;
					retUnibol = rlReturnValue.ToString();
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

	protected virtual FXRETURN GeneraQueryPerUds(string Unibol, ref string ssqlQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Invalid comparison between Unknown and I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FieldsDictionary val3 = new FieldsDictionary();
		StringCollection stringCollection = new StringCollection();
		FieldsDictionary val4 = new FieldsDictionary();
		StringCollection stringCollection2 = new StringCollection();
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ssqlQuery = "";
			if (_dtUds.Rows.Count > 0)
			{
				foreach (DataRow row in _dtUds.Rows)
				{
					((Dictionary<string, string>)(object)val3).Clear();
					stringCollection.Clear();
					((Dictionary<string, string>)(object)val3).Add("UNIBOL", ((AppBaseClass)this).DbConn.SQLFormatString(Unibol));
					((Dictionary<string, string>)(object)val3).Add("UTEINS", this.DbConn.SQLFormatString(this._User));
					((Dictionary<string, string>)(object)val3).Add("UTEAGG", this.DbConn.SQLFormatString(this._User));
					stringCollection.Add("ESITO");
					stringCollection.Add("DATAESITO");
					stringCollection.Add("NOTEESITO");
					stringCollection.Add("DATINS");
					stringCollection.Add("DATAGG");
					string text2 = "UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["CODICE"].ToString());
					string text3 = "";
					val = CopiaRecord.RunProc(this._ApiContext, "SPEDIZIONIUDS", "SPEDIZIONIUDS", text2, ref val3, ref stringCollection, false, false, ref text3, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += text3;
						((Dictionary<string, string>)(object)val4).Clear();
						stringCollection2.Clear();
						((Dictionary<string, string>)(object)val4).Add("UNIBOL", ((AppBaseClass)this).DbConn.SQLFormatString(Unibol));
						((Dictionary<string, string>)(object)val4).Add("UTEINS", this.DbConn.SQLFormatString(this._User));
						((Dictionary<string, string>)(object)val4).Add("UTEAGG", this.DbConn.SQLFormatString(this._User));
						stringCollection2.Add("DATINS");
						stringCollection2.Add("DATAGG");
						text2 = "UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND UDS = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["CODICE"].ToString()) + " ";
						text3 = "";
						val = CopiaRecord.RunProc(this._ApiContext, "SPEDIZIONIUDS_DETTAGLIO", "SPEDIZIONIUDS_DETTAGLIO", text2, ref val4, ref stringCollection2, false, false, ref text3, ref rsmess);
						if ((int)val <= 0)
						{
							text += text3;
							continue;
						}
						val2 = val;
					}
					goto end_IL_0027;
				}
			}
			ssqlQuery = text;
			val2 = (FXRETURN)0;
			end_IL_0027:;
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
