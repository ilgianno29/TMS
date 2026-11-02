using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_Riconsegna : AppAbstractApi
{
	protected string _Unibol;

	protected bool _ApplyQuery;

	protected DataTable _dtSpedizione;

	protected DataTable _dtUds;

	protected bool _doIt;

	protected bool _Manuale;

	public Spedizione_Riconsegna(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_ApplyQuery = true;
		_dtSpedizione = null;
		_dtUds = null;
		_doIt = true;
		_Manuale = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Manuale"))
			{
				_Manuale = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["Manuale"]);
			}
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			val = CheckSpedizione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckEsistenzaRiconsegna(ref rsmess);
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlQuery = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!_doIt)
			{
				goto IL_00ee;
			}
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
					val = GeneraQueryPerEvento(retUnibol, ref ssqlQuery, ref rsmess);
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
							goto IL_00ee;
						}
						val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_00ee;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0012;
			IL_00ee:
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
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Invalid comparison between Unknown and I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.* FROM vw_Spedizioni S WHERE Unibol =" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non è presente a sistema", new string[1] { _Unibol });
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["STATO"].ToString(), "50", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non risulta consegnata", new string[1] { _Unibol });
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["Evento_BuonFine"].ToString(), "S", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta esitata con esito positivo. Impossibile generare la riconsegna", new string[1] { _Unibol });
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["Evento_GeneraRiconsegna"].ToString(), "N", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta esitata con un codice esito che non prevede la generazione della riconsegna. Impossibile generare la riconsegna.", new string[1] { _Unibol });
			}
			else
			{
				text = "SELECT Codice FROM SpedizioniUds WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND Esito IN (SELECT CODICE FROM EVENTI WHERE TIPOEVENTO=" + ((AppBaseClass)this).DbConn.SQLFormatString(EventoSpedizioneTipo.UdsEsitoKo) + " AND GENERARICONSEGNA='S')";
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

	protected virtual FXRETURN CheckEsistenzaRiconsegna(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string sSql = "SELECT unibol FROM Spedizioni WHERE UnibolParent <> Unibol AND Stato<90 AND UnibolParent = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND ProgressivoConsegna = " + Conversions.ToString(checked(Conversions.ToInteger(_dtSpedizione.Rows[0]["PROGRESSIVOCONSEGNA"].ToString()) + 1));
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(sSql, "", ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Operators.CompareString(objRes.ToString(), "", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "E' gia stata creata la riconsegna della spedizione con Id={0}. La riconsegna è presente a sistema con l'ID {1}", new string[2]
				{
					_Unibol,
					objRes.ToString()
				});
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

	protected virtual FXRETURN GeneraQueryPerSpedizione(ref string ssqlQuery, ref string retUnibol, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
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
				((Dictionary<string, string>)(object)val3).Add("UNIBOLPARENT", ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol));
				((Dictionary<string, string>)(object)val3).Add("PROGRESSIVOCONSEGNA", Conversions.ToString(checked(Conversions.ToInteger(_dtSpedizione.Rows[0]["PROGRESSIVOCONSEGNA"].ToString()) + 1)));
				((Dictionary<string, string>)(object)val3).Add("STATO", "10");
				((Dictionary<string, string>)(object)val3).Add("STATOWMS", "99");
				((Dictionary<string, string>)(object)val3).Add("UTEINS", this.DbConn.SQLFormatString(this._User));
				((Dictionary<string, string>)(object)val3).Add("UTEAGG", this.DbConn.SQLFormatString(this._User));
				stringCollection.Add("IDVIAGGIO");
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
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Invalid comparison between Unknown and I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
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

	protected virtual FXRETURN GeneraQueryPerEvento(string Unibol, ref string ssqlQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string RetQueryToApply = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ssqlQuery = "";
			val = EventoSpedizione_InserisciSpedizioneRiconsegna.RunProc(this._ApiContext, Unibol, "", _Manuale, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ssqlQuery = RetQueryToApply;
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
