using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_Inserisci : GdoAbstractApi
{
	protected Spedizione _Spedizione;

	protected DataTable _dtCliente;

	protected DataTable _dtMittente;

	protected DataTable _dtPCSPartenza;

	protected DataTable _dtPCSDestinazione;

	public Spedizione_Inserisci(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_dtCliente = null;
		_dtMittente = null;
		_dtPCSPartenza = null;
		_dtPCSDestinazione = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Invalid comparison between Unknown and I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Spedizione = (Spedizione)this._ParametersIn["Spedizione"];
			this._ParametersOut.Add("Spedizione", _Spedizione);
			val = CheckCliente(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckTipoServizio(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = CheckRiferimenti(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = CheckMittente(ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = CheckTipoSpedizione(ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = CheckTipoMerce(ref rsmess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									val = CheckPartenzaDestinazione(ref rsmess);
									if ((int)val > 0)
									{
										val2 = val;
									}
									else
									{
										val = CheckPartenza(ref rsmess);
										if ((int)val > 0)
										{
											val2 = val;
										}
										else
										{
											val = CheckDestinazione(ref rsmess);
											if ((int)val > 0)
											{
												val2 = val;
											}
											else
											{
												val = CheckZone(ref rsmess);
												if ((int)val > 0)
												{
													val2 = val;
												}
												else
												{
													_Spedizione.UteIns = this._User;
													_Spedizione.UteAgg = this._User;
													if (!_Spedizione.Stato.HasValue)
													{
														_Spedizione.Stato = 10;
													}
													if (!_Spedizione.DataConsegnaPrevista2.HasValue & _Spedizione.DataConsegnaPrevista1.HasValue)
													{
														_Spedizione.DataConsegnaPrevista2 = _Spedizione.DataConsegnaPrevista1;
													}
													else if (_Spedizione.DataConsegnaPrevista2.HasValue & !_Spedizione.DataConsegnaPrevista1.HasValue)
													{
														_Spedizione.DataConsegnaPrevista1 = _Spedizione.DataConsegnaPrevista2;
													}
													val2 = (FXRETURN)0;
												}
											}
										}
									}
								}
							}
						}
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Invalid comparison between Unknown and I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Invalid comparison between Unknown and I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Invalid comparison between Unknown and I4
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string sQuery = "";
			val = CreateQuery(_Spedizione, ref sQuery, ref rsmess);
			string RetQueryToApply;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				long rlReturnValue = default(long);
				val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.SPEDIZIONI", vbStartTrans: false, ref rlReturnValue, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					string text = ((ApplicationParams)(object)this._ApiContext.AppParams).Spedizioni_FormatoUnibol();
					string text2 = "";
					text2 = ((Operators.CompareString(text, "", false) == 0) ? rlReturnValue.ToString() : Strings.Format((object)rlReturnValue, text));
					sQuery = sQuery.Replace("%UNIBOL%", text2);
					_Spedizione.UniBol = _Spedizione.UniBol.Replace("%UNIBOL%", text2);
					_Spedizione.UniBolParent = _Spedizione.UniBolParent.Replace("%UNIBOL%", text2);
					_Spedizione.UniBolMaster = _Spedizione.UniBolMaster.Replace("%UNIBOL%", text2);
					_Spedizione.NumeroOrdine = _Spedizione.NumeroOrdine.Replace("%UNIBOL%", text2);
					_Spedizione.NumeroBolla = _Spedizione.NumeroBolla.Replace("%UNIBOL%", text2);
					RetQueryToApply = "";
					if (Operators.CompareString(this._User, "DSI", false) == 0)
					{
						val = EventoSpedizione_InserisciSpedizioneAuto.RunProc(this._ApiContext, _Spedizione.UniBol, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_01fe;
						}
						val2 = val;
					}
					else
					{
						val = EventoSpedizione_InserisciSpedizioneManuale.RunProc(this._ApiContext, _Spedizione.UniBol, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_01fe;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0005;
			IL_01fe:
			sQuery += RetQueryToApply;
			if (Operators.CompareString(_Spedizione.Corrispondente, "", false) != 0)
			{
				RetQueryToApply = "";
				val = EventoSpedizione_AggiungiCorrispondente.RunProc(this._ApiContext, _Spedizione.UniBol, _Spedizione.Corrispondente, this._User, "AGGIUNTO IL CORRISPONDENTE " + _Spedizione.Corrispondente + " IN FASE DI INSERIMENTO SPEDIZIONE", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				sQuery += RetQueryToApply;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(sQuery, ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	protected FXRETURN CheckCliente(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Spedizione.Cliente == null || Operators.CompareString(_Spedizione.Cliente, "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Non è stato specificato il cliente della spedizione");
			}
			else
			{
				text = "SELECT * FROM Clienti WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Cliente) + " AND ClienteMittente='C'";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtCliente, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (_dtCliente.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il Cliente {0} non esiste", new string[1] { _Spedizione.Cliente });
					val2 = (FXRETURN)14;
				}
				else if (Operators.CompareString(_dtCliente.Rows[0]["Attivo"].ToString(), "S", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il Cliente {0} non è attivo", new string[1] { _Spedizione.Cliente });
					val2 = (FXRETURN)16;
				}
				else
				{
					if (_Spedizione.ClienteFatturazione == null || Operators.CompareString(_Spedizione.ClienteFatturazione, "", false) == 0)
					{
						_Spedizione.ClienteFatturazione = _dtCliente.Rows[0]["FatturaA"].ToString();
					}
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

	protected FXRETURN CheckMittente(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Spedizione.Mittente == null || Operators.CompareString(_Spedizione.Mittente, "", false) == 0)
			{
				goto IL_016d;
			}
			text = "SELECT * FROM Clienti WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Mittente) + " AND ClienteMittente='M'";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtMittente, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtMittente.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Mittente {0} non esiste", new string[1] { _Spedizione.Mittente });
				val2 = (FXRETURN)14;
			}
			else
			{
				if (Operators.CompareString(_dtMittente.Rows[0]["Attivo"].ToString(), "S", false) == 0)
				{
					_Spedizione.MittenteRagioneSociale = _dtMittente.Rows[0]["RagioneSociale"].ToString();
					goto IL_016d;
				}
				rsmess = this.TranslateMessage("XXX", "Il Mittente {0} non è attivo", new string[1] { _Spedizione.Mittente });
				val2 = (FXRETURN)16;
			}
			goto end_IL_000b;
			IL_016d:
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

	protected FXRETURN CheckTipoSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Spedizione.TipoSpedizione == null || Operators.CompareString(_Spedizione.TipoSpedizione, "", false) == 0)
			{
				text = "SELECT TipoSpedizione FROM ClientiTipiSpedizione CTS INNER JOIN TipiSpedizione TS ON CTS.TipoSpedizione=TS.CODICE ";
				text = text + "WHERE CTS.Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Cliente) + " AND CTS.IsDefault='S' AND TS.Attivo='S'";
				object objRes = null;
				val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(objRes.ToString(), "", false) != 0)
					{
						_Spedizione.TipoSpedizione = objRes.ToString();
						goto IL_022a;
					}
					rsmess = this.TranslateMessage("XXX", "Impossibile determinare il tipo spedizione di default per il cliente {0}", new string[1] { _Spedizione.Cliente });
				}
			}
			else
			{
				text = "SELECT TS.CODICE, TS.Attivo FROM ClientiTipiSpedizione CTS INNER JOIN TipiSpedizione TS ON CTS.TipoSpedizione=TS.CODICE ";
				text = text + "WHERE CTS.Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Cliente) + " And CTS.TipoSpedizione=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoSpedizione);
				DataTable rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il tipo spedizione {0} non è configurato per il cliente {1}", new string[2] { _Spedizione.TipoSpedizione, _Spedizione.Cliente });
				}
				else
				{
					if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "N", false) != 0)
					{
						goto IL_022a;
					}
					rsmess = this.TranslateMessage("XXX", "Il tipo spedizione {0} non è attivo ", new string[1] { _Spedizione.TipoSpedizione });
				}
			}
			goto end_IL_000b;
			IL_022a:
			if (Operators.CompareString(_Spedizione.TipoSpedizionePassivo, "", false) == 0)
			{
				_Spedizione.TipoSpedizionePassivo = _Spedizione.TipoSpedizione;
			}
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

	protected FXRETURN CheckTipoServizio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Spedizione.TipoServizio != null && Operators.CompareString(_Spedizione.TipoServizio, "", false) != 0)
			{
				goto IL_0095;
			}
			_Spedizione.TipoServizio = base.ApplicationDefault.TipoServizioDefault();
			if (Operators.CompareString(_Spedizione.TipoServizio, "", false) != 0)
			{
				goto IL_0095;
			}
			rsmess = this.TranslateMessage("XXX", "Impossibile determinare il tipo di servizio di default per le spedizioni");
			goto end_IL_000b;
			IL_0095:
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

	protected FXRETURN CheckTipoMerce(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Spedizione.TipoMerce == null || Operators.CompareString(_Spedizione.TipoMerce, "", false) == 0)
			{
				text = "SELECT TipoMerce, Peso1+Peso2 Peso FROM (";
				text += "SELECT CTM.TipoMerce, CASE WHEN Cliente<>'*ALL' THEN 100 ELSE 0 END Peso1, ";
				text += "CASE WHEN TipoSpedizione<>'*ALL' THEN 10 ELSE 0 END Peso2 ";
				text += "FROM ClientiTipiSpedizioneTipiMerce CTM INNER JOIN TipiMerce TM ON TM.CODICE=CTM.TipoMerce ";
				text = text + "WHERE CTM.Cliente IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Cliente) + ") ";
				text = text + "AND CTM.TipoSpedizione IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoSpedizione) + ") ";
				text += "AND CTM.IsDefault='S' AND TM.Attivo='S') T ";
				text += "ORDER BY Peso DESC";
				DataTable rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (rObjDataTable.Rows.Count != 0)
					{
						_Spedizione.TipoMerce = rObjDataTable.Rows[0]["TipoMerce"].ToString();
						goto IL_028d;
					}
					rsmess = this.TranslateMessage("XXX", "Impossibile determinare il tipo merce di default per il cliente {0} e tipo spedizione {1}", new string[2] { _Spedizione.Cliente, _Spedizione.TipoSpedizione });
				}
			}
			else
			{
				text = "SELECT COUNT(*) ";
				text += "FROM ClientiTipiSpedizioneTipiMerce CTM INNER JOIN TipiMerce TM ON TM.CODICE=CTM.TipoMerce ";
				text = text + "WHERE CTM.Cliente IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Cliente) + ") ";
				text = text + "AND CTM.TipoSpedizione IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoSpedizione) + ") ";
				text = text + "AND CTM.TipoMerce=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoMerce) + " ";
				text += "AND TM.Attivo='S'";
				object objRes = null;
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Conversions.ToInteger(objRes) != 0)
					{
						goto IL_028d;
					}
					rsmess = this.TranslateMessage("XXX", "Il tipo merce {0} non è configurato per il cliente {1} e tipo spedizione {2} oppure il tipo merce {0} non attivo", new string[3] { _Spedizione.TipoMerce, _Spedizione.Cliente, _Spedizione.TipoSpedizione });
				}
			}
			goto end_IL_000b;
			IL_028d:
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

	protected FXRETURN CheckPartenzaDestinazione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if ((_Spedizione.PCSPartenza == null || Operators.CompareString(_Spedizione.PCSPartenza, "", false) == 0) && (_Spedizione.PCSDestinazione == null || Operators.CompareString(_Spedizione.PCSDestinazione, "", false) == 0))
			{
				rsmess = this.TranslateMessage("XXX", "Il punto di partenza e di destinazione per l'ordine {0} non sono stati specificati", new string[1] { _Spedizione.NumeroOrdine });
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

	protected FXRETURN CheckPartenza(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Spedizione.PCSPartenza != null && Operators.CompareString(_Spedizione.PCSPartenza, "", false) != 0)
			{
				goto IL_00a2;
			}
			_Spedizione.PCSPartenza = ((ApplicationDefault)(object)this._ApiContext.AppDefault).PCS_Partenza_Default();
			if (Operators.CompareString(_Spedizione.PCSPartenza, "", false) != 0)
			{
				goto IL_00a2;
			}
			rsmess = this.TranslateMessage("XXX", "Il default del Punto di carico non è stato configurato");
			goto end_IL_000b;
			IL_00a2:
			text = "SELECT * FROM PCS WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.PCSPartenza) + " AND PuntoDiCarico='S'";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtPCSPartenza, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtPCSPartenza.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Punto di carico {0} non esiste", new string[1] { _Spedizione.PCSPartenza });
				val2 = (FXRETURN)14;
			}
			else if (Operators.CompareString(_dtPCSPartenza.Rows[0]["Attivo"].ToString(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Punto di carico {0} non è attivo", new string[1] { _Spedizione.PCSPartenza });
				val2 = (FXRETURN)16;
			}
			else
			{
				if (Operators.CompareString(_Spedizione.PCSPartenza, ((ApplicationDefault)(object)this._ApiContext.AppDefault).PCS_Generico_Default(), false) != 0)
				{
					_Spedizione.PCSPartenza_RagSoc = _dtPCSPartenza.Rows[0]["RagioneSociale"].ToString();
					_Spedizione.PCSPartenza_Localita = _dtPCSPartenza.Rows[0]["Localita"].ToString();
					_Spedizione.PCSPartenza_Indirizzo = _dtPCSPartenza.Rows[0]["Indirizzo"].ToString();
					_Spedizione.PCSPartenza_Cap = _dtPCSPartenza.Rows[0]["Cap"].ToString();
					_Spedizione.PCSPartenza_Provincia = _dtPCSPartenza.Rows[0]["Provincia"].ToString();
					_Spedizione.PCSPartenza_Nazione = _dtPCSPartenza.Rows[0]["Nazione"].ToString();
				}
				val2 = (FXRETURN)0;
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

	protected FXRETURN CheckDestinazione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Invalid comparison between Unknown and I4
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Spedizione.PCSDestinazione != null && Operators.CompareString(_Spedizione.PCSDestinazione, "", false) != 0)
			{
				goto IL_00a2;
			}
			_Spedizione.PCSDestinazione = ((ApplicationDefault)(object)this._ApiContext.AppDefault).PCS_Destinazione_Default();
			if (Operators.CompareString(_Spedizione.PCSDestinazione, "", false) != 0)
			{
				goto IL_00a2;
			}
			rsmess = this.TranslateMessage("XXX", "Il default del Punto di Destinazione non è stato configurato");
			goto end_IL_000b;
			IL_03b8:
			if (Operators.CompareString(_Spedizione.PCSDestinazione, ((ApplicationDefault)(object)this._ApiContext.AppDefault).PCS_Generico_Default(), false) != 0)
			{
				_Spedizione.PCSDestinazione_RagSoc = _dtPCSDestinazione.Rows[0]["RagioneSociale"].ToString();
				_Spedizione.PCSDestinazione_Localita = _dtPCSDestinazione.Rows[0]["Localita"].ToString();
				_Spedizione.PCSDestinazione_Indirizzo = _dtPCSDestinazione.Rows[0]["Indirizzo"].ToString();
				_Spedizione.PCSDestinazione_Cap = _dtPCSDestinazione.Rows[0]["Cap"].ToString();
				_Spedizione.PCSDestinazione_Provincia = _dtPCSDestinazione.Rows[0]["Provincia"].ToString();
				_Spedizione.PCSDestinazione_Nazione = _dtPCSDestinazione.Rows[0]["Nazione"].ToString();
			}
			val2 = (FXRETURN)0;
			goto end_IL_000b;
			IL_00a2:
			text = "SELECT * FROM PCS WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.PCSDestinazione);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtPCSDestinazione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtPCSDestinazione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il PCS {0} non esiste", new string[1] { _Spedizione.PCSDestinazione });
				val2 = (FXRETURN)14;
			}
			else if (Operators.CompareString(_dtPCSDestinazione.Rows[0]["PuntoDiDestino"].ToString(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il PCS {0} non è definito come punto di destino", new string[1] { _Spedizione.PCSDestinazione });
				val2 = (FXRETURN)16;
			}
			else if (Operators.CompareString(_dtPCSDestinazione.Rows[0]["Attivo"].ToString(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Punto di destinazione {0} non è attivo", new string[1] { _Spedizione.PCSDestinazione });
				val2 = (FXRETURN)16;
			}
			else
			{
				if (Operators.CompareString(_dtPCSDestinazione.Rows[0]["CEDI"].ToString(), "", false) == 0)
				{
					goto IL_03b8;
				}
				_Spedizione.PCSDestinazione = _dtPCSDestinazione.Rows[0]["CEDI"].ToString();
				text = "SELECT * FROM PCS WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.PCSDestinazione);
				_dtPCSDestinazione = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtPCSDestinazione, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (_dtPCSDestinazione.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il PCS {0} non esiste", new string[1] { _Spedizione.PCSDestinazione });
					val2 = (FXRETURN)14;
				}
				else if (Operators.CompareString(_dtPCSDestinazione.Rows[0]["PuntoDiDestino"].ToString(), "S", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il PCS {0} non è definito come punto di destino", new string[1] { _Spedizione.PCSDestinazione });
					val2 = (FXRETURN)16;
				}
				else
				{
					if (Operators.CompareString(_dtPCSDestinazione.Rows[0]["Attivo"].ToString(), "S", false) == 0)
					{
						goto IL_03b8;
					}
					rsmess = this.TranslateMessage("XXX", "Il Punto di destinazione {0} non è attivo", new string[1] { _Spedizione.PCSDestinazione });
					val2 = (FXRETURN)16;
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

	protected FXRETURN CheckZone(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Invalid comparison between Unknown and I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Invalid comparison between Unknown and I4
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Invalid comparison between Unknown and I4
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Z.*, CASE WHEN TipoMerce='*ALL' THEN 1 ELSE 10 END Peso ";
			text = text + "FROM pcs_zone Z WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.PCSDestinazione) + " ";
			text = text + "AND TipoMerce in (" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoMerce) + ", '*ALL') ORDER By Peso DESC";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Zone non configurate per la destinazione {0}", new string[1] { _Spedizione.PCSDestinazione });
				val2 = (FXRETURN)14;
			}
			else
			{
				if (_Spedizione.ZonaSpedizione == null || Operators.CompareString(_Spedizione.ZonaSpedizione, "", false) == 0)
				{
					_Spedizione.ZonaSpedizione = rObjDataTable.Rows[0]["ZonaSpedizione"].ToString();
				}
				if (_Spedizione.ZonaArrivoTariffaAttiva == null || Operators.CompareString(_Spedizione.ZonaArrivoTariffaAttiva, "", false) == 0)
				{
					_Spedizione.ZonaArrivoTariffaAttiva = rObjDataTable.Rows[0]["ZonaTariffaAttiva"].ToString();
				}
				if (_Spedizione.ZonaArrivoTariffaPassiva == null || Operators.CompareString(_Spedizione.ZonaArrivoTariffaPassiva, "", false) == 0)
				{
					_Spedizione.ZonaArrivoTariffaPassiva = rObjDataTable.Rows[0]["ZonaTariffaPassiva"].ToString();
				}
				text = "SELECT Z.*, CASE WHEN TipoMerce='*ALL' THEN 1 ELSE 10 END Peso ";
				text = text + "FROM PCS_ZONE Z WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.PCSPartenza) + " ";
				text = text + "AND TipoMerce in (" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoMerce) + ", '*ALL') ORDER By Peso DESC";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Zone non configurate per il punto di partenza {0}", new string[1] { _Spedizione.PCSPartenza });
					val2 = (FXRETURN)14;
				}
				else
				{
					if (_Spedizione.ZonaPartenzaTariffaAttiva == null || Operators.CompareString(_Spedizione.ZonaPartenzaTariffaAttiva, "", false) == 0)
					{
						_Spedizione.ZonaPartenzaTariffaAttiva = rObjDataTable.Rows[0]["ZonaTariffaAttiva"].ToString();
					}
					val = CheckCorrispondente(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (Operators.CompareString(_Spedizione.Corrispondente, "", false) == 0)
						{
							goto IL_0445;
						}
						text = "SELECT Z.*, CASE WHEN TipoMerce='*ALL' THEN 1 ELSE 10 END Peso ";
						text = text + "FROM PCS_ZONE Z WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Corrispondente) + " ";
						text = text + "AND TipoMerce in (" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoMerce) + ", '*ALL') ORDER By Peso DESC";
						val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							if (rObjDataTable.Rows.Count != 0)
							{
								if (_Spedizione.ZonaPartenzaTariffaPassiva == null || Operators.CompareString(_Spedizione.ZonaPartenzaTariffaPassiva, "", false) == 0)
								{
									_Spedizione.ZonaPartenzaTariffaPassiva = rObjDataTable.Rows[0]["ZonaTariffaPassiva"].ToString();
								}
								goto IL_0445;
							}
							rsmess = this.TranslateMessage("XXX", "Zone non configurate per il corrispondente {0}", new string[1] { _Spedizione.Corrispondente });
							val2 = (FXRETURN)14;
						}
					}
				}
			}
			goto end_IL_000e;
			IL_0445:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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

	protected FXRETURN CheckRiferimenti(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Invalid comparison between Unknown and I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Spedizione.UniBol, "", false) == 0)
			{
				_Spedizione.UniBol = "%UNIBOL%";
			}
			if (Operators.CompareString(_Spedizione.UniBolParent, "", false) == 0)
			{
				_Spedizione.UniBolParent = _Spedizione.UniBol;
			}
			if (Operators.CompareString(_Spedizione.UniBolMaster, "", false) == 0)
			{
				_Spedizione.UniBolMaster = _Spedizione.UniBol;
			}
			if (_Spedizione.NumeroBolla == null)
			{
				_Spedizione.NumeroBolla = "";
			}
			if (_Spedizione.NumeroOrdine == null)
			{
				_Spedizione.NumeroOrdine = "";
			}
			if (Operators.CompareString(_Spedizione.TransitoDeposito, "", false) != 0)
			{
				goto IL_0319;
			}
			string transitoDeposito = "";
			int value = 0;
			if (!((Operators.CompareString(_dtCliente.Rows[0]["ConMagazzino"].ToString(), "S", false) == 0) & (Operators.CompareString(_dtCliente.Rows[0]["FlgTra"].ToString(), "S", false) == 0)))
			{
				if (Operators.CompareString(_dtCliente.Rows[0]["FlgTra"].ToString(), "S", false) == 0)
				{
					value = 99;
					transitoDeposito = "T";
				}
				else if (Operators.CompareString(_dtCliente.Rows[0]["ConMagazzino"].ToString(), "S", false) == 0)
				{
					value = 10;
					transitoDeposito = "D";
				}
				goto IL_02d8;
			}
			object objRes = null;
			string text = "";
			text = "SELECT TransitoDeposito FROM TipiServizi WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.TipoServizio);
			val = ((AppBaseClass)this).DbConn.DoSql(text, "T", ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(objRes.ToString(), "T", false) == 0)
				{
					value = 99;
					transitoDeposito = "T";
					goto IL_02d8;
				}
				if (Operators.CompareString(objRes.ToString(), "X", false) != 0)
				{
					value = 10;
					transitoDeposito = "D";
					goto IL_02d8;
				}
				rsmess = this.TranslateMessage("XXX", "Impossibile determinare se la spedizione sia di transito o di deposito in quanto sia la configurazione del cliente sia quella del Tipo servizio prevedono entrambe le tipologie");
			}
			goto end_IL_0005;
			IL_0319:
			if (Operators.CompareString(_Spedizione.TransitoDeposito, "D", false) == 0)
			{
				if (Operators.CompareString(_Spedizione.NumeroOrdine, "", false) != 0)
				{
					goto IL_03ca;
				}
				rsmess = this.TranslateMessage("XXX", "E' obbligatorio Specificare il numero dell'ordine di spedizione");
			}
			else
			{
				if (Operators.CompareString(_Spedizione.TransitoDeposito, "T", false) != 0 || Operators.CompareString(_Spedizione.NumeroBolla, "", false) != 0)
				{
					goto IL_03ca;
				}
				rsmess = this.TranslateMessage("XXX", "E' obbligatorio Specificare il numero della bolla di spedizione");
			}
			goto end_IL_0005;
			IL_03ca:
			if ((Operators.CompareString(_Spedizione.NumeroBolla, "", false) != 0) & !_Spedizione.DataBolla.HasValue)
			{
				_Spedizione.DataBolla = DateAndTime.Now.Date;
			}
			if ((Operators.CompareString(_Spedizione.NumeroOrdine, "", false) != 0) & !_Spedizione.DataOrdine.HasValue)
			{
				_Spedizione.DataOrdine = DateAndTime.Now.Date;
			}
			val2 = (FXRETURN)0;
			goto end_IL_0005;
			IL_02d8:
			_Spedizione.TransitoDeposito = transitoDeposito;
			if (!_Spedizione.StatoWms.HasValue)
			{
				_Spedizione.StatoWms = value;
			}
			goto IL_0319;
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

	protected FXRETURN CheckCorrispondente(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Invalid comparison between Unknown and I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Spedizione.Corrispondente, "", false) != 0 || !(_Spedizione.Peso.HasValue | _Spedizione.Volume.HasValue))
			{
				goto IL_0145;
			}
			string Corrispondente = "";
			decimal sogliaPeso = default(decimal);
			decimal sogliaVolume = default(decimal);
			if (_Spedizione.Peso.HasValue)
			{
				sogliaPeso = _Spedizione.Peso.Value;
			}
			if (_Spedizione.Volume.HasValue)
			{
				sogliaVolume = _Spedizione.Volume.Value;
			}
			val = Zona_DeterminaCorrispondente_Invoker.Instance.RunProc(this._ApiContext, _Spedizione.ZonaSpedizione, _Spedizione.TipoSpedizione, _Spedizione.TipoMerce, sogliaPeso, sogliaVolume, ref Corrispondente, ref rsmess);
			if ((int)val <= 0)
			{
				_Spedizione.Corrispondente = Corrispondente;
				goto IL_0145;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0271:
			val2 = (FXRETURN)0;
			goto end_IL_000b;
			IL_0145:
			if (Operators.CompareString(_Spedizione.Corrispondente, "", false) == 0)
			{
				goto IL_0271;
			}
			text = "SELECT Codice, CodiceTrasportatore, Attivo FROM Corrispondenti PCS WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Spedizione.Corrispondente);
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il corrispondente {0} non esiste", new string[1] { _Spedizione.Corrispondente });
			}
			else
			{
				if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) == 0)
				{
					_Spedizione.Trasportatore = rObjDataTable.Rows[0]["CodiceTrasportatore"].ToString();
					goto IL_0271;
				}
				rsmess = this.TranslateMessage("XXX", "Il corrispondente {0} non è attivo", new string[1] { _Spedizione.Corrispondente });
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

	protected FXRETURN CreateQuery(object obj, ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Invalid comparison between Unknown and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "INSERT INTO %TABLENAME% (";
			PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties(RuntimeHelpers.GetObjectValue(obj));
			PropertyInfo[] array = publicProperties;
			foreach (PropertyInfo propertyInfo in array)
			{
				Dictionary<string, object> customListAttributesForProperties = IncasReflection.GetCustomListAttributesForProperties(propertyInfo);
				bool flag = true;
				if (customListAttributesForProperties.ContainsKey("Bind"))
				{
					flag = Conversions.ToBoolean(customListAttributesForProperties["Bind"]);
				}
				if (flag)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
					if (objectValue != null)
					{
						sQuery = sQuery + propertyInfo.Name + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1));
			sQuery += ") VALUES (";
			PropertyInfo[] array2 = publicProperties;
			foreach (PropertyInfo propertyInfo2 in array2)
			{
				Dictionary<string, object> customListAttributesForProperties2 = IncasReflection.GetCustomListAttributesForProperties(propertyInfo2);
				bool flag2 = true;
				if (customListAttributesForProperties2.ContainsKey("Bind"))
				{
					flag2 = Conversions.ToBoolean(customListAttributesForProperties2["Bind"]);
				}
				if (!flag2)
				{
					continue;
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(propertyInfo2.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue2 != null)
				{
					eTipoDati val3 = modGeneral.DataTypeToBaseType(objectValue2.GetType());
					if ((int)val3 == 0)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
					else if ((int)val3 == 3)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(objectValue2)) + ",";
					}
					else if ((int)val3 == 2 || (int)val3 == 1)
					{
						string obj2 = sQuery;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue2);
						sQuery = obj2 + dbConn.SQLFormatNumber(ref pNumero) + ",";
					}
					else
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1)) + ")";
			Dictionary<string, object> customListAttributes = IncasReflection.GetCustomListAttributes(RuntimeHelpers.GetObjectValue(obj));
			if (customListAttributes.ContainsKey("TableName"))
			{
				sQuery = sQuery.Replace("%TABLENAME%", customListAttributes["TableName"].ToString());
			}
			sQuery += ";";
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
