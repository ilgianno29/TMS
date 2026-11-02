using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

public class GdoWsc_ImportSpedizioni : GdoWscAbstractApi
{
	protected bool _ImpPcsPartenza;

	protected bool _ImpPcsDestinazione;

	protected DataRow _CurrentRow;

	protected string _NewUnibol;

	protected Api_SpedizioneImportArgs _Spedizione;

	[SpecialName]
	private bool _0024STATIC_0024ImportazioneConsentita_0024201111510E_0024LastAllowImport;

	[SpecialName]
	private long _0024STATIC_0024ImportazioneConsentita_0024201111510E_0024LastRecordId;

	public GdoWsc_ImportSpedizioni(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ImpPcsPartenza = false;
		_ImpPcsDestinazione = false;
	}

	protected string IFDBNullString(object obj)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
		{
			return null;
		}
		return obj.ToString();
	}

	protected DateTime? IFDBNullDate(object obj)
	{
		DateTime? result = default(DateTime?);
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
		{
			return result;
		}
		return Conversions.ToDate(obj);
	}

	protected decimal? IFDBNullDecimal(object obj)
	{
		decimal? result = default(decimal?);
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
		{
			return result;
		}
		return Conversions.ToDecimal(obj);
	}

	protected object IsNull(object obj1, object obj2)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj1)))
		{
			return obj2;
		}
		return obj1;
	}

	protected FXRETURN ImportazioneConsentita(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		object objRes = null;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (_0024STATIC_0024ImportazioneConsentita_0024201111510E_0024LastRecordId == Conversions.ToLong(_CurrentRow["Id"]))
			{
				goto IL_0107;
			}
			_0024STATIC_0024ImportazioneConsentita_0024201111510E_0024LastRecordId = Conversions.ToLong(_CurrentRow["Id"]);
			text = "SELECT Importazione FROM Clienti WHERE Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["Cliente"].ToString());
			val2 = ((AppBaseClass)this).DbConn.DoSql(text, "*", ref objRes, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				_0024STATIC_0024ImportazioneConsentita_0024201111510E_0024LastAllowImport = Operators.CompareString(objRes.ToString(), "S", false) == 0;
				if (Operators.CompareString(objRes.ToString(), "*", false) != 0)
				{
					goto IL_0107;
				}
				rsMess = this.TranslateMessage("XXX", "Il Cliente {0} non esiste.", new string[1] { _CurrentRow["Cliente"].ToString() });
			}
			goto end_IL_000d;
			IL_0107:
			if (!_0024STATIC_0024ImportazioneConsentita_0024201111510E_0024LastAllowImport)
			{
				rsMess = this.TranslateMessage("XXX", "Importazione non consentita per il cliente {0}.", new string[1] { _CurrentRow["Cliente"].ToString() });
			}
			else
			{
				val = (FXRETURN)0;
			}
			end_IL_000d:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			this.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN VerificaEsistenzaSpedizione(string TransitoDeposito, DataRow CurrentRow, ref string Unibol, ref int Stato, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Unibol = "";
			Stato = 0;
			if (Operators.CompareString(TransitoDeposito, "D", false) == 0)
			{
				val2 = VerificaEsistenzaSpedizioneDiDeposito(CurrentRow["Cliente"].ToString(), CurrentRow["NumeroOrdine"].ToString(), IFDBNullDate(RuntimeHelpers.GetObjectValue(CurrentRow["DataOrdine"])), ref Unibol, ref Stato, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_00c0;
				}
				val = val2;
			}
			else
			{
				val2 = VerificaEsistenzaSpedizioneDiTransito(CurrentRow["Cliente"].ToString(), CurrentRow["NumeroBolla"].ToString(), IFDBNullDate(RuntimeHelpers.GetObjectValue(CurrentRow["DataBolla"])), ref Unibol, ref Stato, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_00c0;
				}
				val = val2;
			}
			goto end_IL_0004;
			IL_00c0:
			val = (FXRETURN)0;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN VerificaEsistenzaSpedizioneDiDeposito(string Cliente, string NumeroOrdine, DateTime? DataOrdine, ref string Unibol, ref int Stato, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Unibol = "";
			Stato = 0;
			string text = "SELECT Unibol, Stato FROM Spedizioni WHERE ";
			text = text + "Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(Cliente) + " AND ";
			text = text + "NumeroOrdine = " + ((AppBaseClass)this).DbConn.SQLFormatString(NumeroOrdine) + " AND ";
			text = ((!DataOrdine.HasValue) ? (text + "YEAR(DataOrdine) = YEAR(GETDATE()) AND ") : (text + "DataOrdine = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DataOrdine) + " AND "));
			text += "ProgressivoConsegna=0 AND Stato <>99";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (rObjDataTable.Rows.Count >= 1)
				{
					Unibol = rObjDataTable.Rows[0]["Unibol"].ToString();
					Stato = Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN VerificaEsistenzaSpedizioneDiTransito(string Cliente, string NumeroDDT, DateTime? DataDDT, ref string Unibol, ref int Stato, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Unibol = "";
			Stato = 0;
			string text = "SELECT Unibol, Stato FROM Spedizioni WHERE ";
			text = text + "Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(Cliente) + " AND ";
			text = text + "NumeroBolla = " + ((AppBaseClass)this).DbConn.SQLFormatString(NumeroDDT) + " AND ";
			text = ((!DataDDT.HasValue) ? (text + "YEAR(DataBolla) = YEAR(GETDATE()) AND ") : (text + "DataBolla = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DataDDT) + " AND "));
			text += "ProgressivoConsegna=0 AND Stato <>99";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (rObjDataTable.Rows.Count >= 1)
				{
					Unibol = rObjDataTable.Rows[0]["Unibol"].ToString();
					Stato = Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN ImportaSpedizione(ref string Warning, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_17df: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Invalid comparison between Unknown and I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Invalid comparison between Unknown and I4
		//IL_17b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Invalid comparison between Unknown and I4
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Invalid comparison between Unknown and I4
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Invalid comparison between Unknown and I4
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Invalid comparison between Unknown and I4
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1797: Unknown result type (might be due to invalid IL or missing references)
		//IL_179c: Unknown result type (might be due to invalid IL or missing references)
		//IL_179e: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a1: Invalid comparison between Unknown and I4
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable rObjDataTable = null;
		string text = "";
		DataTable rObjDataTable2 = null;
		string text2 = "";
		DataTable rObjDataTable3 = null;
		string text3 = "";
		int num = 0;
		string transitoDeposito = "T";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			Warning = "";
			val2 = ImportazioneConsentita(ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				text3 = "SELECT ConMagazzino, FlgTra FROM Clienti WHERE Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["Cliente"].ToString());
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable3, ref rsMess);
				if ((int)val2 == 0)
				{
					if (rObjDataTable3.Rows.Count != 1)
					{
						goto IL_0258;
					}
					if (!((Operators.CompareString(rObjDataTable3.Rows[0]["ConMagazzino"].ToString(), "S", false) == 0) & (Operators.CompareString(rObjDataTable3.Rows[0]["FlgTra"].ToString(), "S", false) == 0)))
					{
						if (Operators.CompareString(rObjDataTable3.Rows[0]["FlgTra"].ToString(), "S", false) == 0)
						{
							num = 99;
							transitoDeposito = "T";
						}
						else if (Operators.CompareString(rObjDataTable3.Rows[0]["ConMagazzino"].ToString(), "S", false) == 0)
						{
							num = 10;
							transitoDeposito = "D";
						}
						goto IL_0258;
					}
					object objRes = null;
					text3 = "SELECT TransitoDeposito FROM TipiServizi WHERE ";
					text3 = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["TipoServizio"])) ? (text3 + "IsDefault = 'S'") : (text3 + "Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["TipoServizio"].ToString())));
					val2 = ((AppBaseClass)this).DbConn.DoSql(text3, "T", ref objRes, ref rsMess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						if (Operators.CompareString(objRes.ToString(), "T", false) == 0)
						{
							num = 99;
							transitoDeposito = "T";
							goto IL_0258;
						}
						if (Operators.CompareString(objRes.ToString(), "X", false) != 0)
						{
							num = 10;
							transitoDeposito = "D";
							goto IL_0258;
						}
						rsMess = this.TranslateMessage("XXX", "Impossibile determinare se la spedizione sia di transito o di deposito in quanto sia la configurazione del cliente sia quella del Tipo servizio prevedono entrambe le tipologie");
					}
				}
			}
			goto end_IL_002b;
			IL_17b6:
			val = (FXRETURN)0;
			goto end_IL_002b;
			IL_05aa:
			string Unibol;
			if (Operators.CompareString(Unibol, "", false) != 0)
			{
				goto IL_17b6;
			}
			text3 = "SELECT P.Codice, P.RagioneSociale, P.Indirizzo, P.Cap, P.Localita, P.Provincia, P.Nazione, P.PuntoDiDeposito, P.Attivo ";
			text3 += "FROM PCS P ";
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza"])))
			{
				text3 = text3 + "WHERE Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["PCSPartenza"].ToString());
				text = this.TranslateMessage("XXX", "Codice {0}", new string[1] { _CurrentRow["PCSPartenza"].ToString() });
				goto IL_07ba;
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenzaEsterno"])))
			{
				text3 += "INNER JOIN PCS_Acquisiti PA ON PA.CodiceInterno = P.Codice ";
				text3 = text3 + "WHERE PA.Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["Cliente"].ToString()) + " AND ";
				text3 = text3 + "PA.CodiceEsterno = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["PCSPartenzaEsterno"].ToString());
				text = this.TranslateMessage("XXX", "Cliente {0} - Codice Esterno {1}", new string[2]
				{
					_CurrentRow["Cliente"].ToString(),
					_CurrentRow["PCSPartenzaEsterno"].ToString()
				});
				goto IL_07ba;
			}
			if (Operators.CompareString(ApplicationDefault.PCS_Partenza_Default(), "", false) != 0)
			{
				text3 = text3 + "WHERE Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(ApplicationDefault.PCS_Partenza_Default());
				text = this.TranslateMessage("XXX", "Codice {0}", new string[1] { ApplicationDefault.PCS_Partenza_Default() });
				goto IL_07ba;
			}
			rsMess = this.TranslateMessage("XXX", "Il PCS di Partenza di default non è stato trovato");
			val = (FXRETURN)14;
			goto end_IL_002b;
			IL_0258:
			if (_CurrentRow.Table.Columns.Contains("StatoWMS") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["StatoWMS"])))
			{
				num = Conversions.ToInteger(_CurrentRow["StatoWMS"]);
			}
			Unibol = "";
			int Stato = default(int);
			val2 = VerificaEsistenzaSpedizione(transitoDeposito, _CurrentRow, ref Unibol, ref Stato, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(Unibol, "", false) == 0)
				{
					goto IL_05aa;
				}
				if (num == 10)
				{
					if (Stato < 30)
					{
						Dictionary<string, object> dictionary = null;
						Dictionary<string, object> dictionary2 = null;
						string text4 = _CurrentRow["Cliente"].ToString();
						string text5 = _CurrentRow["NumeroOrdine"].ToString();
						DateTime dateTime = Conversions.ToDate(_CurrentRow["DataOrdine"]);
						decimal? pNumero = default(decimal?);
						if (dictionary2.ContainsKey("Peso"))
						{
							pNumero = (decimal?)dictionary2["Peso"];
						}
						decimal? pNumero2 = default(decimal?);
						if (dictionary2.ContainsKey("Volume"))
						{
							pNumero2 = (decimal?)dictionary2["Volume"];
						}
						int? pNumero3 = default(int?);
						if (dictionary2.ContainsKey("Colli"))
						{
							pNumero3 = (int?)dictionary2["Colli"];
						}
						int? pNumero4 = default(int?);
						if (dictionary2.ContainsKey("Pallet"))
						{
							pNumero4 = (int?)dictionary2["Pallet"];
						}
						text3 = "UPDATE Spedizioni SET DatAgg=" + this.DbConn.GetDate() + ",UteAgg=" + this.DbConn.SQLFormatString(this._User) + ",";
						text3 = text3 + "BloccoAmministrativo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["BloccoAmministrativo"].ToString());
						if (pNumero.HasValue)
						{
							text3 = text3 + ",Peso=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero);
						}
						if (pNumero2.HasValue)
						{
							text3 = text3 + ",Volume=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2);
						}
						if (pNumero3.HasValue)
						{
							text3 = text3 + ",Colli=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero3);
						}
						if (pNumero4.HasValue)
						{
							text3 = text3 + ",Pallet=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero4);
						}
						text3 = text3 + " WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(Unibol);
						val2 = ((AppBaseClass)this).DbConn.SqlExec(text3, ref rsMess);
						if ((int)val2 == 0)
						{
							goto IL_05aa;
						}
						val = val2;
					}
					else
					{
						Warning = this.TranslateMessage("XXX", "La spedizione esiste già");
						val = (FXRETURN)0;
					}
				}
				else
				{
					if (!(num == 0 || num == 99))
					{
						goto IL_05aa;
					}
					if (Stato == 10)
					{
						val2 = Spedizione_Annulla_Invoker.Instance.RunProc(this._ApiContext, Unibol, this.TranslateMessage("XXX", "Annullamento a causa di un aggiornamento della spedizione"), ref rsMess);
						if ((int)val2 == 0)
						{
							Unibol = "";
							Stato = 0;
							goto IL_05aa;
						}
						val = val2;
					}
					else
					{
						Warning = this.TranslateMessage("XXX", "La spedizione esiste già");
						val = (FXRETURN)0;
					}
				}
			}
			goto end_IL_002b;
			IL_07ba:
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsMess);
			if ((int)val2 == 0)
			{
				if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = this.TranslateMessage("XXX", "Partenza non trovata: {0}.", new string[1] { text });
					val = (FXRETURN)4;
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) != 0)
				{
					rsMess = this.TranslateMessage("XXX", "Partenza non attiva: {0}.", new string[1] { text });
					val = (FXRETURN)4;
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["PuntoDiDeposito"].ToString(), "S", false) != 0)
				{
					rsMess = this.TranslateMessage("XXX", "Il punto indicato per la partenza non è un punto di deposito: {0}.", new string[1] { text });
					val = (FXRETURN)4;
				}
				else
				{
					text3 = "SELECT P.Codice, P.RagioneSociale, P.Indirizzo, P.Cap, P.Localita, P.Provincia, P.Nazione, P.PuntoDiDestino, P.Attivo ";
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione"])))
					{
						text3 += "FROM PCS P ";
						text3 = text3 + "WHERE Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["PCSDestinazione"].ToString());
						text2 = this.TranslateMessage("XXX", "Codice {0}", new string[1] { _CurrentRow["PCSDestinazione"].ToString() });
					}
					else
					{
						text3 += "FROM PCS P INNER JOIN PCS_Acquisiti PA ON PA.CodiceInterno = P.Codice ";
						text3 = text3 + "WHERE PA.Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["Cliente"].ToString()) + " AND ";
						text3 = text3 + "PA.CodiceEsterno = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentRow["PCSDestinazioneEsterno"].ToString());
						text2 = this.TranslateMessage("XXX", "Cliente {0} - Codice Esterno {1}", new string[2]
						{
							_CurrentRow["Cliente"].ToString(),
							_CurrentRow["PCSDestinazioneEsterno"].ToString()
						});
					}
					val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable2, ref rsMess);
					if ((int)val2 == 0)
					{
						if (rObjDataTable2.Rows.Count == 0)
						{
							rsMess = this.TranslateMessage("XXX", "Destinazione non trovata: {0}.", new string[1] { text2 });
							val = (FXRETURN)4;
						}
						else if (Operators.CompareString(rObjDataTable2.Rows[0]["Attivo"].ToString(), "S", false) != 0)
						{
							rsMess = this.TranslateMessage("XXX", "Destinazione non attiva: {0}.", new string[1] { text2 });
							val = (FXRETURN)4;
						}
						else if (Operators.CompareString(rObjDataTable2.Rows[0]["PuntoDiDestino"].ToString(), "S", false) != 0)
						{
							rsMess = this.TranslateMessage("XXX", "Il punto indicato per la destinazione non è un punto di destino: {0}.", new string[1] { text2 });
							val = (FXRETURN)4;
						}
						else
						{
							Spedizione Spedizione = new Spedizione();
							Spedizione.NumeroOrdine = _CurrentRow["NumeroOrdine"].ToString();
							Spedizione.DataOrdine = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataOrdine"]));
							Spedizione.NumeroBolla = _CurrentRow["NumeroBolla"].ToString();
							Spedizione.DataBolla = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataBolla"]));
							Spedizione.NumeroOrdineCliente = _CurrentRow["NumeroOrdineCliente"].ToString();
							Spedizione.DataOrdineCliente = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataOrdineCliente"]));
							Spedizione.TipoServizio = _CurrentRow["TipoServizio"].ToString();
							Spedizione.Cliente = _CurrentRow["Cliente"].ToString();
							Spedizione.Mittente = _CurrentRow["Mittente"].ToString();
							Spedizione.MittenteRagioneSociale = _CurrentRow["MittenteRagioneSociale"].ToString();
							Spedizione.TipoSpedizione = _CurrentRow["TipoSpedizione"].ToString();
							Spedizione.TipoSpedizionePassivo = _CurrentRow["TipoSpedizionePassivo"].ToString();
							Spedizione.TipoMerce = _CurrentRow["TipoMerce"].ToString();
							Spedizione.Prebolla = "S";
							if (_CurrentRow.Table.Columns.Contains("Prebolla") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["Prebolla"])))
							{
								Spedizione.Prebolla = _CurrentRow["Prebolla"].ToString();
							}
							Spedizione.PCSPartenza = rObjDataTable.Rows[0]["Codice"].ToString();
							Spedizione.PCSPartenza_RagSoc = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza_RagSoc"]), RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[0]["RagioneSociale"])).ToString();
							Spedizione.PCSPartenza_Indirizzo = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza_Indirizzo"]), RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[0]["Indirizzo"])).ToString();
							Spedizione.PCSPartenza_Cap = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza_Cap"]), RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[0]["Cap"])).ToString();
							Spedizione.PCSPartenza_Localita = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza_Localita"]), RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[0]["Localita"])).ToString();
							Spedizione.PCSPartenza_Provincia = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza_Provincia"]), RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[0]["Provincia"])).ToString();
							Spedizione.PCSPartenza_Nazione = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza_Nazione"]), RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[0]["Nazione"])).ToString();
							Spedizione.PCSDestinazione = rObjDataTable2.Rows[0]["Codice"].ToString();
							Spedizione.PCSDestinazione_Indirizzo = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Indirizzo"]), RuntimeHelpers.GetObjectValue(rObjDataTable2.Rows[0]["Indirizzo"])).ToString();
							Spedizione.PCSDestinazione_Cap = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Cap"]), RuntimeHelpers.GetObjectValue(rObjDataTable2.Rows[0]["Cap"])).ToString();
							Spedizione.PCSDestinazione_Localita = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Localita"]), RuntimeHelpers.GetObjectValue(rObjDataTable2.Rows[0]["Localita"])).ToString();
							Spedizione.PCSDestinazione_Provincia = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Provincia"]), RuntimeHelpers.GetObjectValue(rObjDataTable2.Rows[0]["Provincia"])).ToString();
							Spedizione.PCSDestinazione_Nazione = IsNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Nazione"]), RuntimeHelpers.GetObjectValue(rObjDataTable2.Rows[0]["Nazione"])).ToString();
							if (Operators.CompareString(_CurrentRow["PCSDestinazioneEsterno"].ToString(), "", false) != 0)
							{
								Spedizione.DestinazioneCliente = _CurrentRow["PCSDestinazioneEsterno"].ToString();
							}
							Spedizione.Destinatario = _CurrentRow["Destinatario"].ToString();
							Spedizione.DestinatarioCliente = _CurrentRow["DestinatarioCliente"].ToString();
							Spedizione.ZonaSpedizione = _CurrentRow["ZonaSpedizione"].ToString();
							Spedizione.ZonaPartenzaTariffaAttiva = _CurrentRow["ZonaPartenzaTariffaAttiva"].ToString();
							Spedizione.ZonaArrivoTariffaAttiva = _CurrentRow["ZonaArrivoTariffaAttiva"].ToString();
							Spedizione.ZonaPartenzaTariffaPassiva = _CurrentRow["ZonaPartenzaTariffaPassiva"].ToString();
							Spedizione.ZonaArrivoTariffaPassiva = _CurrentRow["ZonaArrivoTariffaPassiva"].ToString();
							Spedizione.DataConsegnaPrevista1 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataConsegnaPrevista1"]));
							Spedizione.DataConsegnaPrevista2 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataConsegnaPrevista2"]));
							Spedizione.NoteConsegnaPrevista = _CurrentRow["NoteConsegnaPrevista"].ToString();
							Spedizione.DataRitiroPrevista1 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataRitiroPrevista1"]));
							Spedizione.DataRitiroPrevista2 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataRitiroPrevista2"]));
							Spedizione.NoteRitiroPrevisto = _CurrentRow["NoteRitiroPrevisto"].ToString();
							Spedizione.Corrispondente = _CurrentRow["Corrispondente"].ToString();
							Spedizione.Trasportatore = _CurrentRow["Trasportatore"].ToString();
							Spedizione.Peso = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["Peso"]));
							Spedizione.Colli = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["Colli"]));
							Spedizione.Pallet = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["Pallet"]));
							Spedizione.Volume = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["Volume"]));
							Spedizione.CampoCalcolo1 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo1"]));
							Spedizione.CampoCalcolo2 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo2"]));
							Spedizione.CampoCalcolo3 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo3"]));
							Spedizione.CampoCalcolo4 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo4"]));
							Spedizione.CampoCalcolo5 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo5"]));
							Spedizione.CampoCalcolo6 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo6"]));
							Spedizione.CampoCalcolo7 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo7"]));
							Spedizione.CampoCalcolo8 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo8"]));
							Spedizione.CampoCalcolo9 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo9"]));
							Spedizione.CampoCalcolo10 = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["CampoCalcolo10"]));
							Spedizione.Flag1 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag1"]));
							Spedizione.Flag2 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag2"]));
							Spedizione.Flag3 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag3"]));
							Spedizione.Flag4 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag4"]));
							Spedizione.Flag5 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag5"]));
							Spedizione.Flag6 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag6"]));
							Spedizione.Flag7 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag7"]));
							Spedizione.Flag8 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag8"]));
							Spedizione.Flag9 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag9"]));
							Spedizione.Flag10 = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["Flag10"]));
							Spedizione.BloccoAmministrativo = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["BloccoAmministrativo"]));
							Spedizione.Contrassegno = IFDBNullDecimal(RuntimeHelpers.GetObjectValue(_CurrentRow["Contrassegno"]));
							Spedizione.Note = _CurrentRow["Note"].ToString();
							Spedizione.FillerAlfa1 = _CurrentRow["FillerAlfa1"].ToString();
							Spedizione.FillerAlfa2 = _CurrentRow["FillerAlfa2"].ToString();
							Spedizione.FillerAlfa3 = _CurrentRow["FillerAlfa3"].ToString();
							Spedizione.FillerAlfa4 = _CurrentRow["FillerAlfa4"].ToString();
							Spedizione.FillerAlfa5 = _CurrentRow["FillerAlfa5"].ToString();
							Spedizione.FillerAlfa6 = _CurrentRow["FillerAlfa6"].ToString();
							Spedizione.FillerAlfa7 = _CurrentRow["FillerAlfa7"].ToString();
							Spedizione.FillerAlfa8 = _CurrentRow["FillerAlfa8"].ToString();
							Spedizione.FillerAlfa9 = _CurrentRow["FillerAlfa9"].ToString();
							Spedizione.FillerAlfa10 = _CurrentRow["FillerAlfa10"].ToString();
							Spedizione.FillerData1 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["FillerData1"]));
							Spedizione.FillerData2 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["FillerData2"]));
							Spedizione.FillerData3 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["FillerData3"]));
							Spedizione.FillerData4 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["FillerData4"]));
							Spedizione.FillerData5 = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["FillerData5"]));
							Spedizione.DataSpedizione = IFDBNullDate(RuntimeHelpers.GetObjectValue(_CurrentRow["DataSpedizione"]));
							Spedizione.StatoWms = num;
							Spedizione.TransitoDeposito = transitoDeposito;
							val2 = Spedizione_Inserisci_Invoker.Instance.RunProc(this._ApiContext, ref Spedizione, ref rsMess);
							if ((int)val2 == 0)
							{
								_NewUnibol = Spedizione.UniBol;
								goto IL_17b6;
							}
							val = val2;
						}
					}
				}
			}
			end_IL_002b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			this.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ImportaPCSPartenza(ref string Warning, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Invalid comparison between Unknown and I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			Warning = "";
			if ((int)ImportazioneConsentita(ref rsMess) == 0)
			{
				PCS PCS = new PCS();
				PCS.Cliente = _CurrentRow["Cliente"].ToString();
				PCS.Codice = _CurrentRow["PCSPartenza"].ToString();
				PCS.CodiceEsterno = _CurrentRow["PCSPartenzaEsterno"].ToString();
				PCS.RagioneSociale = _CurrentRow["PCSPartenza_RagSoc"].ToString();
				PCS.Indirizzo = IFDBNullString(_CurrentRow["PCSPartenza_Indirizzo"].ToString());
				PCS.Cap = IFDBNullString(_CurrentRow["PCSPartenza_Cap"].ToString());
				PCS.Localita = IFDBNullString(_CurrentRow["PCSPartenza_Localita"].ToString());
				PCS.Provincia = IFDBNullString(_CurrentRow["PCSPartenza_Provincia"].ToString());
				PCS.Nazione = IFDBNullString(_CurrentRow["PCSPartenza_Nazione"].ToString());
				PCS.PuntoDiDeposito = "S";
				PCS.PuntoDiCarico = "S";
				val2 = PCS_InserisciModifica_Invoker.Instance.RunProc(this._ApiContext, ref PCS, ref Warning, ref rsMess);
				val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			this.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ImportaPCSDestinazione(ref string Warning, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			Warning = "";
			if ((int)ImportazioneConsentita(ref rsMess) == 0)
			{
				PCS PCS = new PCS();
				PCS.Cliente = _CurrentRow["Cliente"].ToString();
				PCS.Codice = _CurrentRow["PCSDestinazione"].ToString();
				PCS.CodiceEsterno = _CurrentRow["PCSDestinazioneEsterno"].ToString();
				PCS.RagioneSociale = _CurrentRow["PCSDestinazione_RagSoc"].ToString();
				PCS.Indirizzo = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Indirizzo"]));
				PCS.Cap = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Cap"]));
				PCS.Localita = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Localita"]));
				PCS.Provincia = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Provincia"]));
				PCS.Nazione = IFDBNullString(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_Nazione"]));
				PCS.PuntoDiDestino = "S";
				val2 = PCS_InserisciModifica_Invoker.Instance.RunProc(this._ApiContext, ref PCS, ref Warning, ref rsMess);
				val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			this.CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (this._ParametersIn.ContainsKey("ImportaPCSPartenza"))
			{
				_ImpPcsPartenza = Conversions.ToBoolean(this._ParametersIn["ImportaPCSPartenza"]);
			}
			else
			{
				_ImpPcsPartenza = false;
			}
			if (this._ParametersIn.ContainsKey("ImportaPCSDestino"))
			{
				_ImpPcsDestinazione = Conversions.ToBoolean(this._ParametersIn["ImportaPCSDestino"]);
			}
			else
			{
				_ImpPcsDestinazione = false;
			}
			_Spedizione = (Api_SpedizioneImportArgs)this._ParametersIn["Spedizione"];
			((AppAbstractApi)this).ParametersOut.Add("Unibol", "");
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			this.CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			List<Api_SpedizioneImportArgs> list = new List<Api_SpedizioneImportArgs>();
			list.Add(_Spedizione);
			DataTable dataTable = modGeneral.ConvertListToDataTable<Api_SpedizioneImportArgs>((IList<Api_SpedizioneImportArgs>)list);
			string Warning;
			if (dataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Errore nella conversione della struttura dati di input.");
			}
			else
			{
				_CurrentRow = dataTable.Rows[0];
				Warning = "";
				string Warning2 = "";
				if (!_ImpPcsPartenza || Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSPartenza_RagSoc"])))
				{
					goto IL_00b4;
				}
				val2 = ImportaPCSPartenza(ref Warning2, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_00b4;
				}
				val = val2;
			}
			goto end_IL_000a;
			IL_00b4:
			if (!_ImpPcsDestinazione || Information.IsDBNull(RuntimeHelpers.GetObjectValue(_CurrentRow["PCSDestinazione_RagSoc"])))
			{
				goto IL_00ea;
			}
			val2 = ImportaPCSDestinazione(ref Warning, ref rsmess);
			if ((int)val2 == 0)
			{
				goto IL_00ea;
			}
			val = val2;
			goto end_IL_000a;
			IL_00ea:
			val2 = ImportaSpedizione(ref Warning, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				((AppAbstractApi)this).ParametersOut["Unibol"] = _NewUnibol;
				val = (FXRETURN)0;
			}
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((AppBaseClass)this).DbConn.RollbackTransaction();
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			this.CallStackRemove();
		}
		return result;
	}

	public static FXRETURN RunProc(AppApiContext objApiContext, Api_SpedizioneImportArgs Spedizione, bool ImportaPCSPartenza, bool ImportaPCSDestino, ref string Unibol, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			GdoWsc_ImportSpedizioni gdoWsc_ImportSpedizioni = new GdoWsc_ImportSpedizioni(objApiContext);
			((AppAbstractApi)gdoWsc_ImportSpedizioni).ParametersIn.Add("Spedizione", Spedizione);
			((AppAbstractApi)gdoWsc_ImportSpedizioni).ParametersIn.Add("ImportaPCSPartenza", ImportaPCSPartenza);
			((AppAbstractApi)gdoWsc_ImportSpedizioni).ParametersIn.Add("ImportaPCSDestino", ImportaPCSDestino);
			val = ((AppAbstractApi)gdoWsc_ImportSpedizioni).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				Unibol = ((AppAbstractApi)gdoWsc_ImportSpedizioni).ParametersOut["Unibol"].ToString();
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}
}
