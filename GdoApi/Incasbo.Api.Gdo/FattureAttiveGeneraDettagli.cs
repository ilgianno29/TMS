using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureAttiveGeneraDettagli : AppAbstractApiObservable
{
	protected long _IdFattura;

	protected DateTime _DaData;

	protected DateTime _AData;

	protected string _FatturaViaggi;

	protected string _FatturaSpedizioni;

	protected string _FatturaContrassegni;

	protected string _FatturaGiacenze;

	protected string _ClienteOperativo;

	protected string _Mittente;

	protected string _TipoSpedizione;

	protected string _TipoMerce;

	protected string _ZonaArrivo;

	protected string _PCSPartenza;

	protected string _PCSArrivo;

	protected string _FiltriAggiuntivi;

	protected string _ClienteFatturazione;

	protected List<string> _speOk;

	protected List<string> _speKo;

	protected List<string> _viaOk;

	protected List<string> _viaKo;

	protected List<string> _ContraOk;

	protected List<string> _ContraKo;

	protected List<string> _GiacenzaOk;

	protected List<string> _GiacenzaKo;

	protected List<string> _Clienti;

	protected const string _CampoDataSpedizione1 = "DataBolla";

	protected const string _CampoDataSpedizione2 = "Datins";

	public FattureAttiveGeneraDettagli(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_FatturaViaggi = "";
		_FatturaSpedizioni = "";
		_FatturaContrassegni = "";
		_FatturaGiacenze = "";
		_ClienteOperativo = "";
		_Mittente = "";
		_TipoSpedizione = "";
		_TipoMerce = "";
		_ZonaArrivo = "";
		_PCSPartenza = "";
		_PCSArrivo = "";
		_FiltriAggiuntivi = "";
		_ClienteFatturazione = "";
		_speOk = new List<string>();
		_speKo = new List<string>();
		_viaOk = new List<string>();
		_viaKo = new List<string>();
		_ContraOk = new List<string>();
		_ContraKo = new List<string>();
		_GiacenzaOk = new List<string>();
		_GiacenzaKo = new List<string>();
		_Clienti = new List<string>();
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (!((AppAbstractApi)this).ParametersIn.ContainsKey("IdFattura"))
			{
				rsMess = this._Translator.TranslateMessage("XXX", "IdFattura non specificato", new string[0]);
			}
			else
			{
				_IdFattura = Convert.ToInt64(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["IdFattura"]));
				if (!((AppAbstractApi)this).ParametersIn.ContainsKey("DaData"))
				{
					rsMess = this._Translator.TranslateMessage("XXX", "Data iniziale non specificata", new string[0]);
				}
				else
				{
					_DaData = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["DaData"]);
					if (!((AppAbstractApi)this).ParametersIn.ContainsKey("AData"))
					{
						rsMess = this._Translator.TranslateMessage("XXX", "Data finale non specificata", new string[0]);
					}
					else
					{
						_AData = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["AData"]);
						if (!((AppAbstractApi)this).ParametersIn.ContainsKey("FatturaViaggi"))
						{
							rsMess = this._Translator.TranslateMessage("XXX", "Fattura Viaggi non specificato", new string[0]);
						}
						else
						{
							_FatturaViaggi = ((AppAbstractApi)this).ParametersIn["FatturaViaggi"].ToString();
							if (!((AppAbstractApi)this).ParametersIn.ContainsKey("FatturaSpedizioni"))
							{
								rsMess = this._Translator.TranslateMessage("XXX", "Fattura Spedizioni non specificato", new string[0]);
							}
							else
							{
								_FatturaSpedizioni = ((AppAbstractApi)this).ParametersIn["FatturaSpedizioni"].ToString();
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("FatturaContrassegni"))
								{
									_FatturaContrassegni = ((AppAbstractApi)this).ParametersIn["FatturaContrassegni"].ToString();
								}
								else
								{
									_FatturaContrassegni = "S";
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("FatturaGiacenze"))
								{
									_FatturaGiacenze = ((AppAbstractApi)this).ParametersIn["FatturaGiacenze"].ToString();
								}
								else
								{
									_FatturaGiacenze = "S";
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("ClienteOperativo"))
								{
									_ClienteOperativo = ((AppAbstractApi)this).ParametersIn["ClienteOperativo"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("Mittente"))
								{
									_Mittente = ((AppAbstractApi)this).ParametersIn["Mittente"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoSpedizione"))
								{
									_TipoSpedizione = ((AppAbstractApi)this).ParametersIn["TipoSpedizione"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoMerce"))
								{
									_TipoMerce = ((AppAbstractApi)this).ParametersIn["TipoMerce"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("ZonaArrivo"))
								{
									_ZonaArrivo = ((AppAbstractApi)this).ParametersIn["ZonaArrivo"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("PCSPartenza"))
								{
									_PCSPartenza = ((AppAbstractApi)this).ParametersIn["PCSPartenza"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("PCSArrivo"))
								{
									_PCSArrivo = ((AppAbstractApi)this).ParametersIn["PCSArrivo"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("FiltriAggiuntivi"))
								{
									_FiltriAggiuntivi = ((AppAbstractApi)this).ParametersIn["FiltriAggiuntivi"].ToString();
								}
								val2 = (FXRETURN)0;
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
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Invalid comparison between Unknown and I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Invalid comparison between Unknown and I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Invalid comparison between Unknown and I4
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Invalid comparison between Unknown and I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Invalid comparison between Unknown and I4
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		bool flag = false;
		string rsMess2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			val = CheckTestata(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Info, "Inizio", ref rsMess);
				if (Operators.CompareString(_FatturaSpedizioni, "S", false) != 0)
				{
					goto IL_008c;
				}
				val = RicalcoloSpedizioni(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_008c;
				}
				val2 = val;
			}
			goto end_IL_0015;
			IL_00c2:
			if (Operators.CompareString(_FatturaContrassegni, "S", false) != 0)
			{
				goto IL_00f8;
			}
			val = RicalcoloContrassegni(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_00f8;
			}
			val2 = val;
			goto end_IL_0015;
			IL_00f8:
			if (Operators.CompareString(_FatturaGiacenze, "S", false) != 0)
			{
				goto IL_012e;
			}
			val = RicalcoloGiacenze(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_012e;
			}
			val2 = val;
			goto end_IL_0015;
			IL_008c:
			if (Operators.CompareString(_FatturaViaggi, "S", false) != 0)
			{
				goto IL_00c2;
			}
			val = RicalcoloViaggi(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_00c2;
			}
			val2 = val;
			goto end_IL_0015;
			IL_012e:
			((AppBaseClass)this).DbConn.BeginTransaction();
			if (Operators.CompareString(_FatturaSpedizioni, "S", false) == 0)
			{
				val = SelezioneRigheSpedizioni(ref rsMess2);
				if ((int)val == 0)
				{
					val = BloccoSpedizioniFatturate(ref rsMess2);
					if ((int)val > 0)
					{
						FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco spedizioni da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per spedizioni: {0}", new string[1] { rsMess2 }), ref rsMess);
					flag = true;
				}
			}
			if (Operators.CompareString(_FatturaViaggi, "S", false) == 0)
			{
				rsMess2 = "";
				val = SelezioneRigheViaggi(ref rsMess2);
				if ((int)val == 0)
				{
					val = BloccoViaggiFatturati(ref rsMess2);
					if ((int)val > 0)
					{
						FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco viaggi da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per viaggi: {0}", new string[1] { rsMess2 }), ref rsMess);
					flag = true;
				}
			}
			if (Operators.CompareString(_FatturaContrassegni, "S", false) == 0)
			{
				rsMess2 = "";
				val = SelezioneRigheContrassegni(ref rsMess2);
				if ((int)val == 0)
				{
					val = BloccoContrassegniFatturati(ref rsMess2);
					if ((int)val > 0)
					{
						FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco Contrassegni da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per contrassegni: {0}", new string[1] { rsMess2 }), ref rsMess);
					flag = true;
				}
			}
			if (Operators.CompareString(_FatturaGiacenze, "S", false) == 0)
			{
				rsMess2 = "";
				val = SelezioneRigheGiacenze(ref rsMess2);
				if ((int)val == 0)
				{
					val = BloccoGiacenzeFatturate(ref rsMess2);
					if ((int)val > 0)
					{
						FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco Giacenze da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per giacenze: {0}", new string[1] { rsMess2 }), ref rsMess);
					flag = true;
				}
			}
			if (flag)
			{
				((AppBaseClass)this).DbConn.RollbackTransaction();
				val2 = (FXRETURN)4;
				FattureAttiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli: {0}", new string[1] { rsMess2 }), ref rsMess);
				rsMess = this.TranslateMessage("XXX", "Riscontrati errori. Consultare i messaggi di fatturazione.");
			}
			else
			{
				val = FattureAttiveCalcoloIva_Invoker.Instance.RunProc(this._ApiContext, _IdFattura, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					((AppBaseClass)this).DbConn.CommitTransaction();
					val2 = (FXRETURN)0;
				}
			}
			end_IL_0015:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((AppBaseClass)this).DbConn.RollbackTransaction();
			string rsMess3;
			if ((int)val2 > 0)
			{
				long idFattura = Convert.ToInt64(_IdFattura);
				string messaggio = rsMess;
				rsMess3 = "";
				FattureAttiveMessaggiScrivi(idFattura, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Info, messaggio, ref rsMess3);
			}
			long idFattura2 = Convert.ToInt64(_IdFattura);
			rsMess3 = "";
			FattureAttiveMessaggiScrivi(idFattura2, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Info, "Fine", ref rsMess3);
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected void FattureAttiveMessaggiScrivi(long IdFattura, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio TipoMessaggio, string Messaggio, ref string rsMess)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		FattureAttiveMessaggi.RunProc(this._ApiContext, IdFattura, TipoMessaggio, Messaggio, ref rsMess);
	}

	protected virtual FXRETURN CheckTestata(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM FATTURE_ATTIVE_TESTATA WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = this.TranslateMessage("XXX", "Documento inesistente.");
					val2 = (FXRETURN)5;
				}
				string text2 = "";
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[0]["Numero"])))
				{
					text2 = rObjDataTable.Rows[0]["Numero"].ToString();
				}
				if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text2, "0", false) != 0))
				{
					rsMess = this.TranslateMessage("xxx", "Impossibile aggiungere righe ad un documento confermato.");
					val2 = (FXRETURN)4;
				}
				_ClienteFatturazione = rObjDataTable.Rows[0]["Cliente"].ToString();
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN RicalcoloSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Invalid comparison between Unknown and I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string SQLQuery = "";
		DataTable rObjDataTable = null;
		string text = "";
		string Warning = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			val = GeneraQueryPerSelezioneSpedizioni(ref SQLQuery, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ((AppBaseClass)this).DbConn.OpenDataTable(SQLQuery, ref rObjDataTable, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					StringCollection stringCollection = new StringCollection();
					int num = default(int);
					foreach (DataRow row in rObjDataTable.Rows)
					{
						num = checked(num + 1);
						if (Operators.CompareString(_ClienteOperativo, "", false) == 0 && !_Clienti.Contains(row["Cliente"].ToString()))
						{
							_Clienti.Add(row["Cliente"].ToString());
						}
						text = row["Unibol"].ToString();
						val = SpedizioniAgganciaTariffaAttiva_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsMess);
						if (((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0))
						{
							_speOk.Add(text);
							if (row.Table.Columns.Contains("IdViaggio") && Operators.CompareString(row["IdViaggio"].ToString(), "", false) != 0 && !stringCollection.Contains(row["IdViaggio"].ToString()))
							{
								stringCollection.Add(row["IdViaggio"].ToString());
							}
						}
						else
						{
							_speKo.Add(text);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO SPEDIZIONI - {0}", new string[1] { Strings.Trim(rsMess + Warning) });
							string rsMess2 = "";
							FattureAttiveMessaggiScrivi(idFattura, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						((AppAbstractApiObservable)this).NotifyObservers((object)"");
					}
					StringEnumerator enumerator2 = stringCollection.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string current = enumerator2.Current;
						val = SpedizioniAgganciaTariffaAttivaRaggruppata_Invoker.Instance.RunProc(this._ApiContext, current, ref Warning, ref rsMess);
						if (!(((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0)))
						{
							long idFattura2 = _IdFattura;
							string messaggio2 = this.TranslateMessage("XXX", "RICALCOLO RAGGRUPPAMENTO ATTIVO PER LE SPEDIZIONI DEL VIAGGIO {0} - {1}", new string[2]
							{
								current,
								Strings.Trim(rsMess + Warning)
							});
							string rsMess2 = "";
							FattureAttiveMessaggiScrivi(idFattura2, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, messaggio2, ref rsMess2);
						}
						((AppAbstractApiObservable)this).NotifyObservers((object)"");
					}
					val2 = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN GeneraQueryPerSelezioneSpedizioni(ref string SQLQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlQuery = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			SQLQuery = "";
			text = "SELECT UNIBOL,CLIENTE,Idviaggio FROM SPEDIZIONI S WHERE ";
			text += "IdFatturaAttiva IS NULL AND ";
			text = text + "Stato < 90 AND Stato >= (SELECT %ISNULL%(StatoMinimoSpedizioniFatt, 40) FROM Clienti WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + ") AND ";
			text = text + "ISNULL(DataCompetenzaAttiva, ISNULL(DataBolla," + ((AppBaseClass)this).DbConn.DateTrunc("Datins") + ")) >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
			text = text + "ISNULL(DataCompetenzaAttiva,ISNULL(DataBolla," + ((AppBaseClass)this).DbConn.DateTrunc("Datins") + ")) <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			text = text + "ClienteFatturazione= " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
			if (Operators.CompareString(_ClienteOperativo, "", false) != 0)
			{
				text = text + "AND Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteOperativo) + " ";
				_Clienti.Add(_ClienteOperativo);
			}
			if (Operators.CompareString(_Mittente, "", false) != 0)
			{
				text = text + "AND Mittente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Mittente) + " ";
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text = text + "AND TipoSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + " ";
			}
			if (Operators.CompareString(_TipoMerce, "", false) != 0)
			{
				text = text + "AND TipoMerce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + " ";
			}
			if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
			{
				text = text + "AND ZonaArrivoTariffaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + " ";
			}
			if (Operators.CompareString(_PCSPartenza, "", false) != 0)
			{
				text = text + "AND PCSPartenza = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + " ";
			}
			if (Operators.CompareString(_PCSArrivo, "", false) != 0)
			{
				text = text + "AND PCSDestinazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + " ";
			}
			if (Operators.CompareString(_FiltriAggiuntivi, "", false) == 0)
			{
				goto IL_033b;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "S", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_033b;
			}
			val2 = val;
			goto end_IL_0012;
			IL_033b:
			SQLQuery = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			val2 = (FXRETURN)0;
			end_IL_0012:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN RicalcoloViaggi(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string SQLQuery = "";
		DataTable rObjDataTable = null;
		string text = "";
		string Warning = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			val = GeneraQueryPerRicalcoloViaggi(ref SQLQuery, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ((AppBaseClass)this).DbConn.OpenDataTable(SQLQuery, ref rObjDataTable, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					int num = default(int);
					foreach (DataRow row in rObjDataTable.Rows)
					{
						num = checked(num + 1);
						if (Operators.CompareString(_ClienteOperativo, "", false) == 0 && !_Clienti.Contains(row["Cliente"].ToString()))
						{
							_Clienti.Add(row["Cliente"].ToString());
						}
						text = row["IdViaggio"].ToString();
						val = ViaggiAgganciaTariffaAttiva_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsMess);
						if (((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0))
						{
							_viaOk.Add(text);
						}
						else
						{
							_viaKo.Add(text);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO VIAGGIO {0} - {1}", new string[2]
							{
								text,
								Strings.Trim(rsMess + Warning)
							});
							string rsMess2 = "";
							FattureAttiveMessaggiScrivi(idFattura, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						((AppAbstractApiObservable)this).NotifyObservers((object)"");
					}
					val2 = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN GeneraQueryPerRicalcoloViaggi(ref string SQLQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Invalid comparison between Unknown and I4
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlQuery = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			SQLQuery = "";
			text = "SELECT IDVIAGGIO, CLIENTE FROM VIAGGI V INNER JOIN CLIENTI C ON V.CLIENTE = C.CODICE WHERE ";
			text += "IdFatturaAttiva IS NULL AND ";
			text = text + "Stato < 90 AND Stato >= (SELECT %ISNULL%(StatoMinimoViaggiFatt, 30) FROM Clienti WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + ") AND ";
			text = text + "ISNULL(DataPartenzaEffettiva, DataPartenzaPianificata) >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
			text = text + "ISNULL(DataPartenzaEffettiva, DataPartenzaPianificata) <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			text = text + "C.FATTURAA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
			if (Operators.CompareString(_ClienteOperativo, "", false) != 0)
			{
				text = text + "AND Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteOperativo) + " ";
				_Clienti.Add(_ClienteOperativo);
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text = text + "AND TipoSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + " ";
			}
			if (Operators.CompareString(_TipoMerce, "", false) != 0)
			{
				text = text + "AND TipoMerce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + " ";
			}
			if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
			{
				text = text + "AND ZonaArrivoTariffaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + " ";
			}
			if (Operators.CompareString(_PCSPartenza, "", false) != 0)
			{
				text = text + "AND ISNULL(PCSPartenzaEffettivo,PCSPartenza) = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + " ";
			}
			if (Operators.CompareString(_PCSArrivo, "", false) != 0)
			{
				text = text + "AND ISNULL(PCSArrivoEffettivo,PCSArrivo) = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + " ";
			}
			if (Operators.CompareString(_FiltriAggiuntivi, "", false) == 0)
			{
				goto IL_02a3;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "V", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_02a3;
			}
			val2 = val;
			goto end_IL_0012;
			IL_02a3:
			SQLQuery = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			val2 = (FXRETURN)0;
			end_IL_0012:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN SelezioneRigheSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Invalid comparison between Unknown and I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Invalid comparison between Unknown and I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable rObjDataTable = null;
		string text3 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Attive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				int pNumero = Conversions.ToInteger(objRes);
				StringCollection stringCollection = new StringCollection();
				int num = 0;
				foreach (string item in _speOk)
				{
					text = "SELECT R.* ";
					text += "FROM SPEDIZIONI_RICAVI R ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = R.VOCE ";
					text += "WHERE R.ImportoArrotondato <> 0 AND ";
					text = text + "R.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(item);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						checked
						{
							foreach (DataRow row in rObjDataTable.Rows)
							{
								pNumero += 10;
								text = "INSERT INTO Fatture_Attive_Dettaglio (";
								text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
								text += "Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
								text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
								text += "ImportoArrotondato, ImportoUnitario, IdRaggruppamentoSpedizioni, CodiceIva, UteIns, UteAgg) SELECT ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
								text += "'S' AS TipoRiga, SR.Voce, V.Descrizione, SR.Unibol, RecordZZ, TipoCalcolo, ";
								text += "CampoCalcolo, QuantitaOriginale,QuantitaArrotondata, QuantitaTassata, ";
								text += "ImportoOriginale, ImportoArrotondato,ImportoUnitario, IdRaggruppamento, ";
								text += "ISNULL(C.codiceIva,V.CodiceIva)  CodiceIva, ";
								text = text + this.DbConn.SQLFormatString(this._User) + ", ";
								text = text + this.DbConn.SQLFormatString(this._User) + " ";
								text += "FROM SPEDIZIONI_RICAVI SR ";
								text += "INNER JOIN SPEDIZIONI S ON S.UNIBOL = SR.UNIBOL ";
								text += "INNER JOIN Voci V ON V.CODICE = SR.VOCE ";
								text = text + "INNER JOIN CLIENTI C ON C.CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
								text += "WHERE ";
								text += "SR.ImportoArrotondato <> 0 AND ";
								text = text + "SR.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " AND ";
								text = text + "SR.Voce = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["Voce"].ToString()) + " AND ";
								text = text + "SR.RecordZZ = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["RecordZZ"].ToString());
								text += ";";
								stringCollection.Add(text);
							}
							num++;
							((AppAbstractApiObservable)this).NotifyObservers((object)"");
							continue;
						}
					}
					val2 = val;
					goto end_IL_001c;
				}
				if (stringCollection.Count > 0)
				{
					int num2 = 1;
					int num3 = 0;
					StringBuilder stringBuilder = new StringBuilder();
					StringEnumerator enumerator3 = stringCollection.GetEnumerator();
					while (true)
					{
						if (enumerator3.MoveNext())
						{
							string current2 = enumerator3.Current;
							stringBuilder.Append(current2);
							if (num2 != 10)
							{
								goto IL_03c2;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								stringBuilder = new StringBuilder();
								num2 = 0;
								num3 = checked(num3 + 1);
								goto IL_03c2;
							}
							val2 = val;
						}
						else
						{
							if (Operators.CompareString(stringBuilder.ToString(), "", false) == 0)
							{
								break;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								break;
							}
							val2 = val;
						}
						goto end_IL_001c;
						IL_03c2:
						num2 = checked(num2 + 1);
					}
				}
				val2 = (FXRETURN)0;
			}
			end_IL_001c:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN SelezioneRigheViaggi(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Invalid comparison between Unknown and I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Invalid comparison between Unknown and I4
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Attive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				int pNumero = Conversions.ToInteger(objRes);
				StringCollection stringCollection = new StringCollection();
				int num = 0;
				foreach (string item in _viaOk)
				{
					text = "SELECT R.* ";
					text += "FROM VIAGGI_RICAVI R ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = R.VOCE ";
					text += "WHERE R.ImportoArrotondato <> 0 AND ";
					text = text + "R.IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(item);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						checked
						{
							foreach (DataRow row in rObjDataTable.Rows)
							{
								pNumero += 10;
								text = "INSERT INTO Fatture_Attive_Dettaglio (";
								text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
								text += "IdViaggio, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
								text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
								text += "ImportoArrotondato, ImportoUnitario, IdRaggruppamentoViaggi, CodiceIva, UteIns, UteAgg) SELECT ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
								text += "'V' AS TipoRiga, VR.Voce, VO.Descrizione, VR.IdViaggio, RecordZZ, TipoCalcolo, ";
								text += "CampoCalcolo, QuantitaOriginale,QuantitaArrotondata, QuantitaTassata, ";
								text += "ImportoOriginale, ImportoArrotondato,ImportoUnitario, IdRaggruppamento, ";
								text += "ISNULL(C.codiceIva,VO.CodiceIva) CodiceIva, ";
								text = text + this.DbConn.SQLFormatString(this._User) + ", ";
								text = text + this.DbConn.SQLFormatString(this._User) + " ";
								text += "FROM VIAGGI_RICAVI VR ";
								text += "INNER JOIN VIAGGI V ON V.IDVIAGGIO = VR.IDVIAGGIO ";
								text += "INNER JOIN Voci VO ON VO.CODICE = VR.VOCE ";
								text = text + "INNER JOIN CLIENTI C ON C.CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
								text += "WHERE ";
								text += "VR.ImportoArrotondato <> 0 AND ";
								text = text + "VR.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " AND ";
								text = text + "VR.Voce = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["Voce"].ToString()) + " AND ";
								text = text + "VR.RecordZZ = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["RecordZZ"].ToString());
								text += ";";
								stringCollection.Add(text);
							}
							num++;
							((AppAbstractApiObservable)this).NotifyObservers((object)"");
							continue;
						}
					}
					val2 = val;
					goto end_IL_0015;
				}
				if (stringCollection.Count > 0)
				{
					int num2 = 1;
					int num3 = 0;
					StringBuilder stringBuilder = new StringBuilder();
					StringEnumerator enumerator3 = stringCollection.GetEnumerator();
					while (true)
					{
						if (enumerator3.MoveNext())
						{
							string current2 = enumerator3.Current;
							stringBuilder.Append(current2);
							if (num2 != 10)
							{
								goto IL_03bb;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								stringBuilder = new StringBuilder();
								num2 = 0;
								num3 = checked(num3 + 1);
								goto IL_03bb;
							}
							val2 = val;
						}
						else
						{
							if (Operators.CompareString(stringBuilder.ToString(), "", false) == 0)
							{
								break;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								break;
							}
							val2 = val;
						}
						goto end_IL_0015;
						IL_03bb:
						num2 = checked(num2 + 1);
					}
				}
				val2 = (FXRETURN)0;
			}
			end_IL_0015:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN BloccoSpedizioniFatturate(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Invalid comparison between Unknown and I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Invalid comparison between Unknown and I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			StringCollection stringCollection = new StringCollection();
			foreach (string item in _speOk)
			{
				string pNumero = item;
				string text = "";
				text = "UPDATE SPEDIZIONI SET IdFatturaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
				text = text + "WHERE Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
				text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Attive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
				stringCollection.Add(text);
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					stringBuilder.Append(current);
					if (num == 10)
					{
						if (stringBuilder.Length > 0)
						{
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
						}
						num = 0;
						stringBuilder = new StringBuilder();
					}
					num = checked(num + 1);
					continue;
				}
				if (stringBuilder.Length > 0)
				{
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
				}
				val2 = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN BloccoViaggiFatturati(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Invalid comparison between Unknown and I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Invalid comparison between Unknown and I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			StringCollection stringCollection = new StringCollection();
			foreach (string item in _viaOk)
			{
				string pNumero = item;
				string text = "";
				text = "UPDATE VIAGGI SET IdFatturaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
				text = text + "WHERE IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
				text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Attive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
				stringCollection.Add(text);
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					stringBuilder.Append(current);
					if (num == 10)
					{
						if (stringBuilder.Length > 0)
						{
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
						}
						num = 0;
						stringBuilder = new StringBuilder();
					}
					num = checked(num + 1);
					continue;
				}
				if (stringBuilder.Length > 0)
				{
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
				}
				val2 = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN RicalcoloContrassegni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string SQLQuery = "";
		DataTable rObjDataTable = null;
		string Warning = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			val = GeneraQueryPerRicalcoloContrassegni(ref SQLQuery, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ((AppBaseClass)this).DbConn.OpenDataTable(SQLQuery, ref rObjDataTable, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					int num = default(int);
					foreach (DataRow row in rObjDataTable.Rows)
					{
						num = checked(num + 1);
						if (Operators.CompareString(_ClienteOperativo, "", false) == 0 && !_Clienti.Contains(row["Cliente"].ToString()))
						{
							_Clienti.Add(row["Cliente"].ToString());
						}
						string text = row["Id"].ToString();
						val = ContrassegniAgganciaTariffaAttiva_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsMess);
						if (((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0))
						{
							_ContraOk.Add(text);
						}
						else
						{
							_ContraKo.Add(text);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO CONTRASSEGNO {0} - {1}", new string[2]
							{
								text,
								Strings.Trim(rsMess + Warning)
							});
							string rsMess2 = "";
							FattureAttiveMessaggiScrivi(idFattura, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						((AppAbstractApiObservable)this).NotifyObservers((object)"");
					}
					val2 = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN RicalcoloGiacenze(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string SQLQuery = "";
		DataTable rObjDataTable = null;
		string Warning = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			val = GeneraQueryPerRicalcoloGiacenze(ref SQLQuery, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ((AppBaseClass)this).DbConn.OpenDataTable(SQLQuery, ref rObjDataTable, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					int num = default(int);
					foreach (DataRow row in rObjDataTable.Rows)
					{
						num = checked(num + 1);
						if (Operators.CompareString(_ClienteOperativo, "", false) == 0 && !_Clienti.Contains(row["Cliente"].ToString()))
						{
							_Clienti.Add(row["Cliente"].ToString());
						}
						string text = row["Id"].ToString();
						val = GiacenzeAgganciaTariffaAttiva_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsMess);
						if (((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0))
						{
							_GiacenzaOk.Add(text);
						}
						else
						{
							_GiacenzaKo.Add(text);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO GIACENZA {0} - {1}", new string[2]
							{
								text,
								Strings.Trim(rsMess + Warning)
							});
							string rsMess2 = "";
							FattureAttiveMessaggiScrivi(idFattura, FattureAttiveMessaggi.FattureAttiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						((AppAbstractApiObservable)this).NotifyObservers((object)"");
					}
					val2 = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN GeneraQueryPerRicalcoloContrassegni(ref string SQLQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Invalid comparison between Unknown and I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlQuery = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			SQLQuery = "";
			text = "SELECT C.ID, C.CLIENTE, C.ClienteFatturazione FROM CONTRASSEGNI C INNER JOIN Spedizioni S ON S.UNIBOL=C.UnibolMaster ";
			text += "WHERE C.IdFatturaAttiva IS NULL AND ";
			text += "C.Stato IN (30,40) AND ";
			text = text + "C.DataIncasso >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
			text = text + "C.DataIncasso <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			text = text + "C.ClienteFatturazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
			if (Operators.CompareString(_ClienteOperativo, "", false) != 0)
			{
				text = text + "AND C.Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteOperativo) + " ";
				_Clienti.Add(_ClienteOperativo);
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text = text + "AND S.TipoSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + " ";
			}
			if (Operators.CompareString(_TipoMerce, "", false) != 0)
			{
				text = text + "AND S.TipoMerce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + " ";
			}
			if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
			{
				text = text + "AND S.ZonaArrivoTariffaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + " ";
			}
			if (Operators.CompareString(_PCSPartenza, "", false) != 0)
			{
				text = text + "AND S.PCSPartenza = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + " ";
			}
			if (Operators.CompareString(_PCSArrivo, "", false) != 0)
			{
				text = text + "AND S.PCSDestinazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + " ";
			}
			if (Operators.CompareString(_FiltriAggiuntivi, "", false) == 0)
			{
				goto IL_028d;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "C", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_028d;
			}
			val2 = val;
			goto end_IL_0012;
			IL_028d:
			SQLQuery = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			val2 = (FXRETURN)0;
			end_IL_0012:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN GeneraQueryPerRicalcoloGiacenze(ref string SQLQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Invalid comparison between Unknown and I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlQuery = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			SQLQuery = "";
			text = "SELECT G.ID, G.CLIENTE, G.ClienteFatturazione FROM GIACENZE G INNER JOIN Spedizioni S ON S.UNIBOL=G.UnibolApertura ";
			text += "WHERE G.IdFatturaAttiva IS NULL AND G.STATO=20 AND ";
			text = text + "G.DataCompetenzaAttiva >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
			text = text + "G.DataCompetenzaAttiva <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			text = text + "G.ClienteFatturazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
			if (Operators.CompareString(_ClienteOperativo, "", false) != 0)
			{
				text = text + "AND G.Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteOperativo) + " ";
				_Clienti.Add(_ClienteOperativo);
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text = text + "AND S.TipoSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + " ";
			}
			if (Operators.CompareString(_TipoMerce, "", false) != 0)
			{
				text = text + "AND S.TipoMerce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + " ";
			}
			if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
			{
				text = text + "AND S.ZonaArrivoTariffaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + " ";
			}
			if (Operators.CompareString(_PCSPartenza, "", false) != 0)
			{
				text = text + "AND S.PCSPartenza = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + " ";
			}
			if (Operators.CompareString(_PCSArrivo, "", false) != 0)
			{
				text = text + "AND S.PCSDestinazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + " ";
			}
			if (Operators.CompareString(_FiltriAggiuntivi, "", false) == 0)
			{
				goto IL_0281;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "G", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_0281;
			}
			val2 = val;
			goto end_IL_0012;
			IL_0281:
			SQLQuery = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			val2 = (FXRETURN)0;
			end_IL_0012:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN SelezioneRigheContrassegni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Invalid comparison between Unknown and I4
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Invalid comparison between Unknown and I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Attive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				int pNumero = Conversions.ToInteger(objRes);
				StringCollection stringCollection = new StringCollection();
				int num = 0;
				foreach (string item in _ContraOk)
				{
					text = "SELECT R.* ";
					text += "FROM CONTRASSEGNI_RICAVI R ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = R.VOCE ";
					text += "WHERE R.ImportoArrotondato <> 0 AND ";
					string text3 = text;
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					int pNumero2 = Conversions.ToInteger(item);
					text = text3 + "R.IdContrassegno = " + dbConn.SQLFormatNumber(ref pNumero2);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						checked
						{
							foreach (DataRow row in rObjDataTable.Rows)
							{
								pNumero += 10;
								text = "INSERT INTO Fatture_Attive_Dettaglio (";
								text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
								text += "IdContrassegno, Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
								text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
								text += "ImportoArrotondato, ImportoUnitario, CodiceIva, UteIns, UteAgg) SELECT ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
								text += "'C' AS TipoRiga, CR.Voce, VO.Descrizione, CR.IdContrassegno, C.UnibolMaster, RecordZZ, TipoCalcolo, ";
								text += "CampoCalcolo, QuantitaOriginale,QuantitaArrotondata, QuantitaTassata, ";
								text += "ImportoOriginale, ImportoArrotondato,ImportoUnitario, ";
								text += "ISNULL(CL.codiceIva,VO.CodiceIva) CodiceIva, ";
								text = text + this.DbConn.SQLFormatString(this._User) + ", ";
								text = text + this.DbConn.SQLFormatString(this._User) + " ";
								text += "FROM CONTRASSEGNI_RICAVI CR ";
								text += "INNER JOIN CONTRASSEGNI C ON C.ID = CR.IDCONTRASSEGNO ";
								text += "INNER JOIN Voci VO ON VO.CODICE = CR.VOCE ";
								text = text + "INNER JOIN CLIENTI CL ON CL.CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
								text += "WHERE ";
								text += "CR.ImportoArrotondato <> 0 AND ";
								text = text + "CR.IDCONTRASSEGNO = " + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " AND ";
								text = text + "CR.Voce = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["Voce"].ToString()) + " AND ";
								text = text + "CR.RecordZZ = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["RecordZZ"].ToString());
								text += ";";
								stringCollection.Add(text);
							}
							num++;
							((AppAbstractApiObservable)this).NotifyObservers((object)"");
							continue;
						}
					}
					val2 = val;
					goto end_IL_0015;
				}
				if (stringCollection.Count > 0)
				{
					int num2 = 1;
					int num3 = 0;
					StringBuilder stringBuilder = new StringBuilder();
					StringEnumerator enumerator3 = stringCollection.GetEnumerator();
					while (true)
					{
						if (enumerator3.MoveNext())
						{
							string current2 = enumerator3.Current;
							stringBuilder.Append(current2);
							if (num2 != 10)
							{
								goto IL_03c4;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								stringBuilder = new StringBuilder();
								num2 = 0;
								num3 = checked(num3 + 1);
								goto IL_03c4;
							}
							val2 = val;
						}
						else
						{
							if (Operators.CompareString(stringBuilder.ToString(), "", false) == 0)
							{
								break;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								break;
							}
							val2 = val;
						}
						goto end_IL_0015;
						IL_03c4:
						num2 = checked(num2 + 1);
					}
				}
				val2 = (FXRETURN)0;
			}
			end_IL_0015:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN SelezioneRigheGiacenze(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Invalid comparison between Unknown and I4
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Invalid comparison between Unknown and I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Attive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				int pNumero = Conversions.ToInteger(objRes);
				StringCollection stringCollection = new StringCollection();
				int num = 0;
				foreach (string item in _GiacenzaOk)
				{
					text = "SELECT R.* ";
					text += "FROM GIACENZE_RICAVI R ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = R.VOCE ";
					text += "WHERE R.ImportoArrotondato <> 0 AND ";
					string text3 = text;
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					int pNumero2 = Conversions.ToInteger(item);
					text = text3 + "R.IdGiacenza = " + dbConn.SQLFormatNumber(ref pNumero2);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						checked
						{
							foreach (DataRow row in rObjDataTable.Rows)
							{
								pNumero += 10;
								text = "INSERT INTO Fatture_Attive_Dettaglio (";
								text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
								text += "IdGiacenza, Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
								text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
								text += "ImportoArrotondato, ImportoUnitario, GiorniTassati, CodiceIva, UteIns, UteAgg) SELECT ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
								text += "'G' AS TipoRiga, GR.Voce, VO.Descrizione, GR.IdGiacenza, C.UnibolApertura, RecordZZ, TipoCalcolo, ";
								text += "CampoCalcolo, QuantitaOriginale,QuantitaArrotondata, QuantitaTassata, ";
								text += "ImportoOriginale, ImportoArrotondato, ImportoUnitario, GiorniTassati,";
								text += "ISNULL(CL.codiceIva,VO.CodiceIva) CodiceIva, ";
								text = text + this.DbConn.SQLFormatString(this._User) + ", ";
								text = text + this.DbConn.SQLFormatString(this._User) + " ";
								text += "FROM GIACENZE_RICAVI GR ";
								text += "INNER JOIN GIACENZE G ON G.ID = GR.IDGIACENZA ";
								text += "INNER JOIN Voci VO ON VO.CODICE = GR.VOCE ";
								text = text + "INNER JOIN CLIENTI CL ON CL.CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ClienteFatturazione) + " ";
								text += "WHERE ";
								text += "GR.ImportoArrotondato <> 0 AND ";
								text = text + "GR.IdGiacenza = " + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " AND ";
								text = text + "GR.Voce = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["Voce"].ToString()) + " AND ";
								text = text + "GR.RecordZZ = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["RecordZZ"].ToString());
								text += ";";
								stringCollection.Add(text);
							}
							num++;
							((AppAbstractApiObservable)this).NotifyObservers((object)"");
							continue;
						}
					}
					val2 = val;
					goto end_IL_0015;
				}
				if (stringCollection.Count > 0)
				{
					int num2 = 1;
					int num3 = 0;
					StringBuilder stringBuilder = new StringBuilder();
					StringEnumerator enumerator3 = stringCollection.GetEnumerator();
					while (true)
					{
						if (enumerator3.MoveNext())
						{
							string current2 = enumerator3.Current;
							stringBuilder.Append(current2);
							if (num2 != 10)
							{
								goto IL_03c4;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								stringBuilder = new StringBuilder();
								num2 = 0;
								num3 = checked(num3 + 1);
								goto IL_03c4;
							}
							val2 = val;
						}
						else
						{
							if (Operators.CompareString(stringBuilder.ToString(), "", false) == 0)
							{
								break;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								break;
							}
							val2 = val;
						}
						goto end_IL_0015;
						IL_03c4:
						num2 = checked(num2 + 1);
					}
				}
				val2 = (FXRETURN)0;
			}
			end_IL_0015:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN BloccoContrassegniFatturati(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			StringCollection stringCollection = new StringCollection();
			foreach (string item in _ContraOk)
			{
				string pNumero = item;
				string text = "";
				text = "UPDATE Contrassegni SET IdFatturaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
				string text2 = text;
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				int pNumero2 = Conversions.ToInteger(pNumero);
				text = text2 + "WHERE Id = " + dbConn.SQLFormatNumber(ref pNumero2) + " ";
				text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Attive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND IdContrassegno = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
				stringCollection.Add(text);
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					stringBuilder.Append(current);
					if (num == 10)
					{
						if (stringBuilder.Length > 0)
						{
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
						}
						num = 0;
						stringBuilder = new StringBuilder();
					}
					num = checked(num + 1);
					continue;
				}
				if (stringBuilder.Length > 0)
				{
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
				}
				val2 = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN BloccoGiacenzeFatturate(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			StringCollection stringCollection = new StringCollection();
			foreach (string item in _GiacenzaOk)
			{
				string pNumero = item;
				string text = "";
				text = "UPDATE Giacenze SET IdFatturaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
				string text2 = text;
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				int pNumero2 = Conversions.ToInteger(pNumero);
				text = text2 + "WHERE Id = " + dbConn.SQLFormatNumber(ref pNumero2) + " ";
				text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Attive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND IdGiacenza = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
				stringCollection.Add(text);
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					stringBuilder.Append(current);
					if (num == 10)
					{
						if (stringBuilder.Length > 0)
						{
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
						}
						num = 0;
						stringBuilder = new StringBuilder();
					}
					num = checked(num + 1);
					continue;
				}
				if (stringBuilder.Length > 0)
				{
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
				}
				val2 = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN SetFiltriAggiuntivi(string FiltriAggiuntivi, ref string ssqlQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string[] array = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			ssqlQuery = "";
			array = FiltriAggiuntivi.Split(new char[1] { ';' });
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				ssqlQuery = ssqlQuery + "AND " + text2.Trim() + " ";
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
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
