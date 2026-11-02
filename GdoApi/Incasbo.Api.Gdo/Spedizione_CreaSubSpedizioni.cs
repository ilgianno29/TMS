using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_CreaSubSpedizioni : GdoAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected List<Spedizione_Tratta> _Tratte;

	public Spedizione_CreaSubSpedizioni(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizione = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_Tratte = (List<Spedizione_Tratta>)((AppAbstractApi)this).ParametersIn["Tratte"];
			val = CheckSpedizione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_Tratte.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Nessuna sub-spedizione definita");
			}
			else
			{
				DataTable rObjDataTable = null;
				text = "SELECT * FROM TipiServizi WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_dtSpedizione.Rows[0]["TipoServizio"].ToString());
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il Tipo servizio {0} non è attivo", new string[1] { _dtSpedizione.Rows[0]["TipoServizio"].ToString() });
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["SubSpedizioni_TipiServizio"].ToString(), "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il Tipo servizio {0} non prevede la possibilità di avere sub-spedizioni", new string[1] { _dtSpedizione.Rows[0]["TipoServizio"].ToString() });
				}
				else
				{
					string[] source = rObjDataTable.Rows[0]["SubSpedizioni_TipiServizio"].ToString().Split(new char[1] { ',' });
					foreach (Spedizione_Tratta item in _Tratte)
					{
						if (source.Contains(item.TipoServizio))
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "Il Tipo servizio {0} non è tra quelli previsti per le sub-spedizioni", new string[1] { item.TipoServizio });
						goto end_IL_000b;
					}
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Invalid comparison between Unknown and I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			foreach (Spedizione_Tratta item in _Tratte)
			{
				Spedizione_Tratta subsped = item;
				Spedizione sped = new Spedizione();
				val = GeneraStrutturaSpedizione(ref sped, ref subsped, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = Spedizione_Inserisci_Invoker.Instance.RunProc(this._ApiContext, ref sped, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						subsped.IdSubSpedizione = sped.UniBol;
						val = Spedizione_Attiva_Invoker.Instance.RunProc(this._ApiContext, subsped.IdSubSpedizione, "", ref rsmess);
						if ((int)val <= 0)
						{
							text = "INSERT INTO Spedizioni_SubSpedizioni (Unibol_Spedizione, Unibol_SubSpedizione, Sequenza) VALUES (";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(subsped.IdSubSpedizione) + ", ";
							string text3 = text;
							DBConnection dbConn = ((AppBaseClass)this).DbConn;
							Spedizione_Tratta spedizione_Tratta;
							int pNumero = (spedizione_Tratta = subsped).Sequenza;
							string text4 = dbConn.SQLFormatNumber(ref pNumero);
							spedizione_Tratta.Sequenza = pNumero;
							text = text3 + text4 + "); ";
							text2 += text;
							continue;
						}
						val2 = val;
					}
				}
				goto end_IL_0012;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text2, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Viaggio Viaggio = new Viaggio();
				if (Operators.CompareString(base.ApplicationDefault.TipoViaggio_ViaggioMultiTratta(), "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Tipo viaggio multi-tratta non configurato in Delsy o non attivo");
				}
				else
				{
					Viaggio.TipoViaggio = base.ApplicationDefault.TipoViaggio_ViaggioMultiTratta();
					Viaggio.DataPartenzaPianificata = DateAndTime.Now;
					List<string> ListOfUnibol = new List<string>();
					ListOfUnibol.Add(_Unibol);
					val = Viaggio_InserisciConSpedizioni_Invoker.Instance.RunProc(this._ApiContext, ref Viaggio, ref ListOfUnibol, ref rsmess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
			}
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
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.* FROM VW_Spedizioni S WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
			}
			else if (Conversions.ToInteger(_dtSpedizione.Rows[0]["CountOfSubSpedizioni"]) > 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} ha già subito il processo di creazione delle sub-spedizioni.", new string[1] { _Unibol });
			}
			else if (Conversions.ToInteger(_dtSpedizione.Rows[0]["Stato"]) != 20)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è attiva.", new string[1] { _Unibol });
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdViaggio"].ToString(), "", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} appartiene già ad un viaggio (Id={1}).", new string[2]
				{
					_Unibol,
					_dtSpedizione.Rows[0]["IdViaggio"].ToString()
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

	protected virtual FXRETURN GeneraStrutturaSpedizione(ref Spedizione sped, ref Spedizione_Tratta subsped, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (sped == null)
			{
				sped = new Spedizione();
			}
			Spedizione spedizione = sped;
			spedizione.TransitoDeposito = "T";
			spedizione.TipoServizio = subsped.TipoServizio;
			spedizione.Cliente = _dtSpedizione.Rows[0]["Cliente"].ToString();
			spedizione.Mittente = _dtSpedizione.Rows[0]["Mittente"].ToString();
			spedizione.MittenteRagioneSociale = _dtSpedizione.Rows[0]["MittenteRagioneSociale"].ToString();
			spedizione.ClienteFatturazione = _dtSpedizione.Rows[0]["ClienteFatturazione"].ToString();
			spedizione.NumeroBolla = _dtSpedizione.Rows[0]["NumeroBolla"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["DataBolla"])))
			{
				spedizione.DataBolla = Conversions.ToDate(_dtSpedizione.Rows[0]["DataBolla"]);
			}
			spedizione.NumeroOrdine = _dtSpedizione.Rows[0]["NumeroOrdine"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["DataOrdine"])))
			{
				spedizione.DataOrdine = Conversions.ToDate(_dtSpedizione.Rows[0]["DataOrdine"]);
			}
			spedizione.NumeroOrdineCliente = _dtSpedizione.Rows[0]["NumeroOrdineCliente"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["DataOrdineCliente"])))
			{
				spedizione.DataOrdineCliente = Conversions.ToDate(_dtSpedizione.Rows[0]["DataOrdineCliente"]);
			}
			spedizione.TipoSpedizione = _dtSpedizione.Rows[0]["TipoSpedizione"].ToString();
			spedizione.TipoSpedizionePassivo = _dtSpedizione.Rows[0]["TipoSpedizionePassivo"].ToString();
			spedizione.TipoMerce = _dtSpedizione.Rows[0]["TipoMerce"].ToString();
			spedizione.Prebolla = _dtSpedizione.Rows[0]["Prebolla"].ToString();
			spedizione.PCSPartenza = subsped.Partenza;
			spedizione.PCSDestinazione = subsped.Arrivo;
			spedizione.DataConsegnaPrevista1 = subsped.DataConsegna;
			spedizione.DataConsegnaPrevista2 = subsped.DataConsegna;
			spedizione.NoteConsegnaPrevista = "";
			if (subsped.Sequenza == subsped.TotaleTratte)
			{
				spedizione.Corrispondente = subsped.Corrispondente;
			}
			spedizione.Peso = Conversions.ToDecimal(_dtSpedizione.Rows[0]["Peso"]);
			spedizione.Colli = Conversions.ToDecimal(_dtSpedizione.Rows[0]["Colli"]);
			spedizione.Pallet = Conversions.ToDecimal(_dtSpedizione.Rows[0]["Pallet"]);
			spedizione.Volume = Conversions.ToDecimal(_dtSpedizione.Rows[0]["Volume"]);
			spedizione.CampoCalcolo1 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo1"]);
			spedizione.CampoCalcolo2 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo2"]);
			spedizione.CampoCalcolo3 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo3"]);
			spedizione.CampoCalcolo4 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo4"]);
			spedizione.CampoCalcolo5 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo5"]);
			spedizione.CampoCalcolo6 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo6"]);
			spedizione.CampoCalcolo7 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo7"]);
			spedizione.CampoCalcolo8 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo8"]);
			spedizione.CampoCalcolo9 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo9"]);
			spedizione.CampoCalcolo10 = Conversions.ToDecimal(_dtSpedizione.Rows[0]["CampoCalcolo10"]);
			spedizione.Flag1 = _dtSpedizione.Rows[0]["Flag1"].ToString();
			spedizione.Flag2 = _dtSpedizione.Rows[0]["Flag2"].ToString();
			spedizione.Flag3 = _dtSpedizione.Rows[0]["Flag3"].ToString();
			spedizione.Flag4 = _dtSpedizione.Rows[0]["Flag4"].ToString();
			spedizione.Flag5 = _dtSpedizione.Rows[0]["Flag5"].ToString();
			spedizione.Flag6 = _dtSpedizione.Rows[0]["Flag6"].ToString();
			spedizione.Flag7 = _dtSpedizione.Rows[0]["Flag7"].ToString();
			spedizione.Flag8 = _dtSpedizione.Rows[0]["Flag8"].ToString();
			spedizione.Flag9 = _dtSpedizione.Rows[0]["Flag9"].ToString();
			spedizione.Flag10 = _dtSpedizione.Rows[0]["Flag10"].ToString();
			spedizione.BloccoAmministrativo = "N";
			if (subsped.Sequenza == subsped.TotaleTratte)
			{
				spedizione.Contrassegno = Conversions.ToDecimal(_dtSpedizione.Rows[0]["Contrassegno"]);
			}
			else
			{
				spedizione.Contrassegno = 0m;
			}
			spedizione.Note = _dtSpedizione.Rows[0]["Note"].ToString();
			spedizione.FillerAlfa1 = _dtSpedizione.Rows[0]["FillerAlfa1"].ToString();
			spedizione.FillerAlfa2 = _dtSpedizione.Rows[0]["FillerAlfa2"].ToString();
			spedizione.FillerAlfa3 = _dtSpedizione.Rows[0]["FillerAlfa3"].ToString();
			spedizione.FillerAlfa4 = _dtSpedizione.Rows[0]["FillerAlfa4"].ToString();
			spedizione.FillerAlfa5 = _dtSpedizione.Rows[0]["FillerAlfa5"].ToString();
			spedizione.FillerAlfa6 = _dtSpedizione.Rows[0]["FillerAlfa6"].ToString();
			spedizione.FillerAlfa7 = _dtSpedizione.Rows[0]["FillerAlfa7"].ToString();
			spedizione.FillerAlfa8 = _dtSpedizione.Rows[0]["FillerAlfa8"].ToString();
			spedizione.FillerAlfa9 = _dtSpedizione.Rows[0]["FillerAlfa9"].ToString();
			spedizione.FillerAlfa10 = _dtSpedizione.Rows[0]["FillerAlfa10"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["FillerData1"])))
			{
				spedizione.FillerData1 = Conversions.ToDate(_dtSpedizione.Rows[0]["FillerData1"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["FillerData2"])))
			{
				spedizione.FillerData2 = Conversions.ToDate(_dtSpedizione.Rows[0]["FillerData2"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["FillerData3"])))
			{
				spedizione.FillerData3 = Conversions.ToDate(_dtSpedizione.Rows[0]["FillerData3"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["FillerData4"])))
			{
				spedizione.FillerData4 = Conversions.ToDate(_dtSpedizione.Rows[0]["FillerData4"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["FillerData5"])))
			{
				spedizione.FillerData5 = Conversions.ToDate(_dtSpedizione.Rows[0]["FillerData5"]);
			}
			spedizione.UteIns = "";
			spedizione.UteAgg = "";
			spedizione.StatoWms = 99;
			spedizione = null;
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
