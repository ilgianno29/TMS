using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Api.Params;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FatturePassiveGeneraDettagli : AppAbstractApiObservable
{
	protected long _IdFattura;

	protected string _Cliente;

	protected string _Corrispondente;

	protected string _Trasportatore;

	protected DateTime _DaData;

	protected DateTime _AData;

	protected string _FatturaSpedizioni;

	protected string _FatturaViaggi;

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

	protected string _TrasportatoreFatturazione;

	protected List<string> _speOk;

	protected List<string> _speKo;

	protected List<string> _Viaggi;

	protected List<string> _ViaggiKo;

	protected List<string> _ContraOk;

	protected List<string> _ContraKo;

	protected List<string> _GiacenzeOk;

	protected List<string> _GiacenzeKo;

	protected List<string> _CostiIds;

	protected List<string> _CostiViaggiIds;

	protected List<string> _Corrispondenti;

	protected List<string> _speForVettoreOk;

	protected const string _CampoDataSpedizione1 = "DataBolla";

	protected const string _CampoDataSpedizione2 = "DatIns";

	protected List<string> _IdViaggiDaFatturare;

	protected List<string> _IdSpedizioniDaFatturare;

	protected ApplicationDefault ApplicationDefault => (ApplicationDefault)(object)this._ApiContext.AppDefault;

	protected ApplicationParams ApplicationParams => (ApplicationParams)(object)this._ApiContext.AppParams;

	public FatturePassiveGeneraDettagli(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Cliente = "";
		_Corrispondente = "";
		_Trasportatore = "";
		_FatturaSpedizioni = "";
		_FatturaViaggi = "";
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
		_TrasportatoreFatturazione = "";
		_speOk = new List<string>();
		_speKo = new List<string>();
		_Viaggi = new List<string>();
		_ViaggiKo = new List<string>();
		_ContraOk = new List<string>();
		_ContraKo = new List<string>();
		_GiacenzeOk = new List<string>();
		_GiacenzeKo = new List<string>();
		_CostiIds = new List<string>();
		_CostiViaggiIds = new List<string>();
		_Corrispondenti = new List<string>();
		_speForVettoreOk = new List<string>();
		_IdSpedizioniDaFatturare = null;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
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
					_DaData = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["DaData"]));
					if (!((AppAbstractApi)this).ParametersIn.ContainsKey("AData"))
					{
						rsMess = this._Translator.TranslateMessage("XXX", "Data finale non specificata", new string[0]);
					}
					else
					{
						_AData = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["AData"]));
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
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("IdViaggi"))
								{
									_IdViaggiDaFatturare = (List<string>)((AppAbstractApi)this).ParametersIn["IdViaggi"];
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("IdSpedizioni"))
								{
									_IdSpedizioniDaFatturare = (List<string>)((AppAbstractApi)this).ParametersIn["IdSpedizioni"];
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("ClienteOperativo"))
								{
									_ClienteOperativo = ((AppAbstractApi)this).ParametersIn["ClienteOperativo"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("Corrispondente"))
								{
									_Corrispondente = ((AppAbstractApi)this).ParametersIn["Corrispondente"].ToString();
								}
								if (((AppAbstractApi)this).ParametersIn.ContainsKey("Trasportatore"))
								{
									_Trasportatore = ((AppAbstractApi)this).ParametersIn["Trasportatore"].ToString();
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
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Invalid comparison between Unknown and I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Invalid comparison between Unknown and I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Invalid comparison between Unknown and I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Invalid comparison between Unknown and I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Invalid comparison between Unknown and I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Invalid comparison between Unknown and I4
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Invalid comparison between Unknown and I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Invalid comparison between Unknown and I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Invalid comparison between Unknown and I4
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Invalid comparison between Unknown and I4
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		bool flag = false;
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
				FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Info, "Inizio", ref rsMess);
				if (Operators.CompareString(_FatturaSpedizioni, "S", false) != 0)
				{
					goto IL_00a2;
				}
				val = RicalcoloSpedizioni(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = RicalcoloSpedizioniPerVettore(ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_00a2;
					}
					val2 = val;
				}
			}
			goto end_IL_0011;
			IL_00d8:
			if (Operators.CompareString(_FatturaContrassegni, "S", false) != 0)
			{
				goto IL_010e;
			}
			val = RicalcoloContrassegni(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_010e;
			}
			val2 = val;
			goto end_IL_0011;
			IL_010e:
			if (Operators.CompareString(_FatturaGiacenze, "S", false) != 0)
			{
				goto IL_0144;
			}
			val = RicalcoloGiacenze(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_0144;
			}
			val2 = val;
			goto end_IL_0011;
			IL_0144:
			((AppBaseClass)this).DbConn.BeginTransaction();
			string rsMess2 = "";
			if (Operators.CompareString(_FatturaSpedizioni, "S", false) == 0)
			{
				val = SelezioneRigheSpedizioni(ref rsMess2);
				if ((int)val == 0)
				{
					val = BloccoSpedizioniFatturate(ref rsMess2);
					if ((int)val > 0)
					{
						FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco spedizioni da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per Spedizioni: {0}", new string[1] { rsMess2 }), ref rsMess);
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
						FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco viaggi da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per Viaggi: {0}", new string[1] { rsMess2 }), ref rsMess);
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
						FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco Contrassegni da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per contrassegni: {0}", new string[1] { rsMess2 }), ref rsMess);
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
						FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di blocco Giacenze da fatturare: {0}", new string[1] { rsMess2 }), ref rsMess);
						flag = true;
					}
				}
				else
				{
					FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli per giacenze: {0}", new string[1] { rsMess2 }), ref rsMess);
					flag = true;
				}
			}
			if (flag)
			{
				((AppBaseClass)this).DbConn.RollbackTransaction();
				val2 = (FXRETURN)4;
				FatturePassiveMessaggiScrivi(Convert.ToInt64(_IdFattura), FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, this.TranslateMessage("XXX", "Errore in fase di generazione tabella dettagli: {0}", new string[1] { rsMess2 }), ref rsMess);
				rsMess = this.TranslateMessage("XXX", "Riscontrati errori. Consultare i messaggi di fatturazione.");
			}
			else
			{
				val = FatturePassiveCalcoloIva.RunProc(this._ApiContext, _IdFattura, ref rsMess);
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
			goto end_IL_0011;
			IL_00a2:
			if (Operators.CompareString(_FatturaViaggi, "S", false) != 0)
			{
				goto IL_00d8;
			}
			val = RicalcoloViaggi(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_00d8;
			}
			val2 = val;
			end_IL_0011:;
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
				FatturePassiveMessaggiScrivi(idFattura, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Info, messaggio, ref rsMess3);
			}
			long idFattura2 = Convert.ToInt64(_IdFattura);
			rsMess3 = "";
			FatturePassiveMessaggiScrivi(idFattura2, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Info, "Fine", ref rsMess3);
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected void FatturePassiveMessaggiScrivi(long IdFattura, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio TipoMessaggio, string Messaggio, ref string rsMess)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		FatturePassiveMessaggi.RunProc(this._ApiContext, IdFattura, TipoMessaggio, Messaggio, ref rsMess);
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
			text = "SELECT * FROM FATTURE_PASSIVE_TESTATA WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = this.TranslateMessage("xxx", "Documento inesistente.");
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
				_TrasportatoreFatturazione = rObjDataTable.Rows[0]["Trasportatore"].ToString();
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

	protected virtual FXRETURN GeneraQueryPerSelezioneSpedizioni(ref string SQLQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Invalid comparison between Unknown and I4
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
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
			text = "SELECT S.UNIBOL, S.Corrispondente, S.IdViaggio ";
			text += "FROM SPEDIZIONI S ";
			text += "INNER JOIN Corrispondenti C ON S.Corrispondente = C.Codice ";
			text += "INNER JOIN Trasportatori TR ON C.CodiceTrasportatore = TR.Codice ";
			text += "WHERE S.IdFatturaPassiva IS NULL AND ";
			text = text + "S.Stato < 90 AND Stato >= (SELECT %ISNULL%(StatoMinimoSpedizioniFatt, 40) FROM Trasportatori WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione) + ") AND ";
			if (_IdSpedizioniDaFatturare != null)
			{
				text += "(";
				foreach (string item in _IdSpedizioniDaFatturare)
				{
					text = text + "S.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " OR ";
				}
				text += "1=2) AND ";
			}
			else
			{
				text = text + "%ISNULL%(S.DataCompetenzaPassiva, %ISNULL%(S.DataBolla, %TRUNC%(S.DatIns))) >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
				text = text + "%ISNULL%(S.DataCompetenzaPassiva, %ISNULL%(S.DataBolla, %TRUNC%(S.DatIns))) <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			}
			text = text + "TR.FatturaA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione) + " ";
			if (Operators.CompareString(_Cliente, "", false) != 0)
			{
				text = text + " AND S.Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente);
			}
			if (Operators.CompareString(_Corrispondente, "", false) != 0)
			{
				text = text + " AND S.Corrispondente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Corrispondente) + " ";
				_Corrispondenti.Add(_Corrispondente);
			}
			if (Operators.CompareString(_Trasportatore, "", false) != 0)
			{
				text = text + " AND S.Trasportatore = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore) + " ";
			}
			if (Operators.CompareString(_Mittente, "", false) != 0)
			{
				text = text + " AND S.Mittente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Mittente) + " ";
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text += " AND 1=2 ";
			}
			if (Operators.CompareString(_TipoMerce, "", false) != 0)
			{
				text = text + " AND TipoMerce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + " ";
			}
			if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
			{
				text = text + " AND ZonaArrivoTariffaAttiva = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + " ";
			}
			if (Operators.CompareString(_PCSPartenza, "", false) != 0)
			{
				text = text + " AND PCSPartenza = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + " ";
			}
			if (Operators.CompareString(_PCSArrivo, "", false) != 0)
			{
				text = text + " AND PCSDestinazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + " ";
			}
			if (Operators.CompareString(_FiltriAggiuntivi, "", false) == 0)
			{
				goto IL_03e7;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "S", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_03e7;
			}
			val2 = val;
			goto end_IL_0012;
			IL_03e7:
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

	protected virtual FXRETURN GeneraQueryPerSelezioneSpedizioniPerVettore(ref string SQLQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Invalid comparison between Unknown and I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
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
			text = "SELECT S.UNIBOL, S.IdViaggio ";
			text += "FROM SPEDIZIONI S ";
			text += "INNER JOIN Trasportatori TR ON S.Vettore = TR.Codice ";
			text += "WHERE S.IdFatturaPassiva IS NULL AND ";
			text += "S.Stato < 90 AND ";
			if (_IdSpedizioniDaFatturare != null)
			{
				text += "(";
				foreach (string item in _IdSpedizioniDaFatturare)
				{
					text = text + "S.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " OR ";
				}
				text += "1=2) AND ";
			}
			else
			{
				text = text + "%ISNULL%(S.DataCompetenzaPassiva, %ISNULL%(S.DataBolla, %TRUNC%(S.DatIns))) >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
				text = text + "%ISNULL%(S.DataCompetenzaPassiva, %ISNULL%(S.DataBolla, %TRUNC%(S.DatIns))) <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			}
			text = text + "TR.FatturaA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione) + " ";
			if (Operators.CompareString(_Cliente, "", false) != 0)
			{
				text = text + " AND S.Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente);
			}
			if (Operators.CompareString(_Corrispondente, "", false) != 0)
			{
				text += " AND  1=2 ";
			}
			if (Operators.CompareString(_Trasportatore, "", false) != 0)
			{
				text = text + " AND S.Vettore = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore);
			}
			if (Operators.CompareString(_Mittente, "", false) != 0)
			{
				text = text + " AND S.Mittente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Mittente) + " ";
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text += " AND 1=2 ";
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
				goto IL_0398;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "S", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_0398;
			}
			val2 = val;
			goto end_IL_0012;
			IL_0398:
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

	protected virtual FXRETURN RicalcoloSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Invalid comparison between Unknown and I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Invalid comparison between Unknown and I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string SQLQuery = "";
		DataTable rObjDataTable = null;
		string text = "";
		string text2 = "";
		string Warning = "";
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
						if (!_Corrispondenti.Contains(row["Corrispondente"].ToString()) && Operators.CompareString(row["Corrispondente"].ToString(), "", false) != 0)
						{
							_Corrispondenti.Add(row["Corrispondente"].ToString());
						}
						text = row["Unibol"].ToString();
						string rsmess = "";
						val = SpedizioniAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsmess);
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
							string text3 = Strings.Trim(rsmess + " " + Warning);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO CONSEGNE - {0}", new string[1] { text3 });
							string rsMess2 = "";
							FatturePassiveMessaggiScrivi(idFattura, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						if (num % 10 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("RICALCOLO SPEDIZIONI " + num + " su " + rObjDataTable.Rows.Count));
						}
					}
					num = 1;
					StringEnumerator enumerator2 = stringCollection.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string current = enumerator2.Current;
						val = SpedizioniAgganciaTariffaPassivaRaggruppata_Invoker.Instance.RunProc(this._ApiContext, current, ref Warning, ref rsMess);
						if (!(((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0)))
						{
							long idFattura2 = _IdFattura;
							string messaggio2 = this.TranslateMessage("XXX", "RICALCOLO RAGGRUPPAMENTO PASSIVO PER LE SPEDIZIONI DEL VIAGGIO {0} - {1}", new string[2]
							{
								current,
								Strings.Trim(rsMess + Warning)
							});
							string rsMess2 = "";
							FatturePassiveMessaggiScrivi(idFattura2, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, messaggio2, ref rsMess2);
						}
						if (num % 10 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("RICALCOLO RAGGRUPPAMENTO SPEDIZIONI " + num + " su " + stringCollection.Count));
						}
						num = checked(num + 1);
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

	protected virtual FXRETURN RicalcoloSpedizioniPerVettore(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string SQLQuery = "";
		DataTable rObjDataTable = null;
		string text = "";
		string text2 = "";
		string Warning = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (!ApplicationParams.AbilitaTariffeDiSpedizioneSulVettore())
			{
				goto IL_01be;
			}
			val = GeneraQueryPerSelezioneSpedizioniPerVettore(ref SQLQuery, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ((AppBaseClass)this).DbConn.OpenDataTable(SQLQuery, ref rObjDataTable, ref rsMess);
				if ((int)val <= 0)
				{
					int num = default(int);
					foreach (DataRow row in rObjDataTable.Rows)
					{
						num = checked(num + 1);
						text = row["Unibol"].ToString();
						string rsmess = "";
						val = SpedizioniAgganciaTariffaPassivaForVettore_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsmess);
						if (((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0))
						{
							_speForVettoreOk.Add(text);
						}
						else
						{
							string text3 = Strings.Trim(rsmess + " " + Warning);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO CONSEGNE PER VETTORE - {0}", new string[1] { text3 });
							string rsMess2 = "";
							FatturePassiveMessaggiScrivi(idFattura, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						if (num % 10 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("RICALCOLO SPEDIZIONI PER VETTORE" + num + " su " + rObjDataTable.Rows.Count));
						}
					}
					goto IL_01be;
				}
				val2 = val;
			}
			goto end_IL_0023;
			IL_01be:
			val2 = (FXRETURN)0;
			end_IL_0023:;
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

	protected virtual FXRETURN RicalcoloViaggi(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string SQLQuery = "";
		DataTable rObjDataTable = null;
		string text = "";
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
						string text2 = row["IdViaggio"].ToString();
						string Warning = "";
						val = ViaggiAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, text2, ref Warning, ref rsMess);
						if (((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0))
						{
							_Viaggi.Add(text2);
						}
						else
						{
							_ViaggiKo.Add(text2);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO VIAGGIO {0} - {1}", new string[2]
							{
								text2,
								Strings.Trim(rsMess + Warning)
							});
							string rsMess2 = "";
							FatturePassiveMessaggiScrivi(idFattura, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						if (num % 10 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("RICALCOLO VIAGGI " + num + " su " + rObjDataTable.Rows.Count));
						}
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
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Invalid comparison between Unknown and I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
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
			text = "SELECT V.IdViaggio, V.Vettore ";
			text += "FROM VIAGGI V INNER JOIN Trasportatori TR ON V.Vettore = TR.Codice ";
			text += "WHERE V.IdFatturaPassiva IS NULL ";
			text = text + "AND Stato < 90 AND Stato >= (SELECT %ISNULL%(StatoMinimoViaggiFatt, 30) FROM Trasportatori WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione) + ") ";
			if (_IdViaggiDaFatturare != null)
			{
				text += " AND (";
				foreach (string item in _IdViaggiDaFatturare)
				{
					text = text + "V.IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " OR ";
				}
				text += "1=2) ";
			}
			else
			{
				text = text + "AND " + ((AppBaseClass)this).DbConn.DateTrunc("%ISNULL%(V.DataPartenzaEffettiva, V.DataPartenzaPianificata)") + " >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " ";
				text = text + "AND " + ((AppBaseClass)this).DbConn.DateTrunc("%ISNULL%(V.DataPartenzaEffettiva, V.DataPartenzaPianificata)") + " <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " ";
			}
			text = text + " AND TR.FatturaA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione);
			if (Operators.CompareString(_Trasportatore, "", false) != 0)
			{
				text = text + " AND V.Vettore = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore);
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text = text + " AND V.TipoSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione);
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
				text += "AND 1=2 ";
			}
			if (Operators.CompareString(_FiltriAggiuntivi, "", false) == 0)
			{
				goto IL_0356;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "V", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_0356;
			}
			val2 = val;
			goto end_IL_0012;
			IL_0356:
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
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Invalid comparison between Unknown and I4
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Invalid comparison between Unknown and I4
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Invalid comparison between Unknown and I4
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Invalid comparison between Unknown and I4
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			int num = 0;
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Passive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				num = Conversions.ToInteger(objRes);
				StringCollection stringCollection = new StringCollection();
				int num2 = 0;
				foreach (string item in _speOk)
				{
					text = "SELECT Costi.* ";
					text += "FROM Spedizioni S ";
					text += "INNER JOIN Spedizioni_COSTI Costi ON S.Unibol=Costi.Unibol ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
					text += "WHERE Costi.ImportoArrotondato <> 0 ";
					text = text + "AND S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " ";
					text += "AND Costi.UtenteForzatura IS NULL ";
					text += "AND Costi.TipoCalcolo NOT IN ('MAN','VET')";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						foreach (DataRow row in rObjDataTable.Rows)
						{
							num = checked(num + 10);
							text = "INSERT INTO Fatture_Passive_Dettaglio (";
							text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
							text += "Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
							text += "ImportoArrotondato, ImportoUnitario, IdRaggruppamentoSpedizioni, CodiceIva, UteIns, UteAgg) SELECT ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num) + ", ";
							text += "'S' AS TipoRiga, Costi.Voce, Descrizione, ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ", ";
							text += "RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ImportoArrotondato, ";
							text += "ImportoUnitario, IdRaggruppamento, CodiceIva, ";
							text = text + this.DbConn.SQLFormatString(this._User) + ", ";
							text = text + this.DbConn.SQLFormatString(this._User) + " ";
							text += "FROM SPEDIZIONI_COSTI Costi ";
							text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
							text += "WHERE ";
							text += "Costi.ImportoArrotondato <> 0 AND ";
							string text2 = text;
							DBConnection dbConn = ((AppBaseClass)this).DbConn;
							string pNumero = row["Id"].ToString();
							text = text2 + "Costi.Id = " + dbConn.SQLFormatNumber(ref pNumero) + " ";
							text += ";";
							stringCollection.Add(text);
						}
						if (checked(num2 + 1) % 100 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("INSERIMENTO DETTAGLIO FATTURA DA SPEDIZIONI " + checked(num2 + 1) + " su " + _speOk.Count));
						}
						num2 = checked(num2 + 1);
						continue;
					}
					val2 = val;
					goto end_IL_000e;
				}
				text = "SELECT S.Unibol, Costi.* ";
				text += "FROM SPEDIZIONI S ";
				text += "INNER JOIN SPEDIZIONI_COSTI Costi ON Costi.Unibol=S.Unibol ";
				text += "INNER JOIN Trasportatori TR ON Costi.Trasportatore = TR.Codice ";
				text += "WHERE ";
				text += "Costi.IdFatturaPassiva IS NULL AND ";
				text += "Costi.UtenteForzatura IS NOT NULL AND ";
				if (_IdSpedizioniDaFatturare != null)
				{
					text += "(";
					foreach (string item2 in _IdSpedizioniDaFatturare)
					{
						text = text + "S.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(item2) + " OR ";
					}
					text += "1=2) AND ";
				}
				else
				{
					text = text + "%ISNULL%(S.DataCompetenzaPassiva, %ISNULL%(S.DataBolla, %TRUNC%(S.DatIns))) >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
					text = text + "%ISNULL%(S.DataCompetenzaPassiva, %ISNULL%(S.DataBolla, %TRUNC%(S.DatIns))) <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
				}
				if (Operators.CompareString(_Cliente, "", false) != 0)
				{
					text = text + "S.Cliente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + " AND ";
				}
				text = text + "TR.FatturaA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione);
				if (Operators.CompareString(_Mittente, "", false) != 0)
				{
					text = text + " AND S.Mittente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Mittente);
				}
				if (Operators.CompareString(_Corrispondente, "", false) != 0)
				{
					text = text + " AND S.Corrispondente = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Corrispondente);
				}
				if (Operators.CompareString(_Trasportatore, "", false) != 0)
				{
					text = text + " AND Costi.Trasportatore = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore);
				}
				if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				if (Operators.CompareString(_TipoMerce, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				if (Operators.CompareString(_PCSArrivo, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				if (Operators.CompareString(_PCSPartenza, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					num2 = 0;
					checked
					{
						foreach (DataRow row2 in rObjDataTable.Rows)
						{
							num += 10;
							text = "INSERT INTO Fatture_Passive_Dettaglio (";
							text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
							text += "Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
							text += "ImportoArrotondato, ImportoUnitario, IdRaggruppamentoSpedizioni, CodiceIva, UteIns, UteAgg) SELECT ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num) + ", ";
							text += "'M' AS TipoRiga, Costi.Voce, Descrizione, ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row2["Unibol"].ToString()) + ", ";
							text += "RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ImportoArrotondato, ";
							text += "ImportoUnitario, NULL, CodiceIva, ";
							text = text + this.DbConn.SQLFormatString(this._User) + ", ";
							text = text + this.DbConn.SQLFormatString(this._User) + " ";
							text += "FROM SPEDIZIONI_COSTI Costi ";
							text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
							text += "WHERE Costi.ImportoArrotondato <> 0 AND ";
							string text3 = text;
							DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
							string pNumero = row2["Id"].ToString();
							text = text3 + "Costi.Id = " + dbConn2.SQLFormatNumber(ref pNumero) + " ";
							text += ";\r\n";
							stringCollection.Add(text);
							List<string> costiIds = _CostiIds;
							DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
							pNumero = row2["Id"].ToString();
							costiIds.Add(dbConn3.SQLFormatNumber(ref pNumero));
							num2++;
						}
						foreach (string item3 in _speForVettoreOk)
						{
							text = "SELECT Costi.* ";
							text += "FROM Spedizioni S ";
							text += "INNER JOIN Spedizioni_COSTI Costi ON S.Unibol=Costi.Unibol ";
							text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
							text += "WHERE Costi.ImportoArrotondato <> 0 ";
							text = text + "AND S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(item3) + " ";
							text += "AND Costi.UtenteForzatura IS NULL ";
							text += "AND Costi.TipoCalcolo='VET' ";
							val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
							if (unchecked((int)val) <= 0)
							{
								foreach (DataRow row3 in rObjDataTable.Rows)
								{
									num += 10;
									text = "INSERT INTO Fatture_Passive_Dettaglio (";
									text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
									text += "Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
									text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
									text += "ImportoArrotondato, ImportoUnitario, IdRaggruppamentoSpedizioni, CodiceIva, UteIns, UteAgg) SELECT ";
									text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
									text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num) + ", ";
									text += "'S' AS TipoRiga, Costi.Voce, Descrizione, ";
									text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item3) + ", ";
									text += "RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
									text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ImportoArrotondato, ";
									text += "ImportoUnitario, IdRaggruppamento, CodiceIva, ";
									text = text + this.DbConn.SQLFormatString(this._User) + ", ";
									text = text + this.DbConn.SQLFormatString(this._User) + " ";
									text += "FROM SPEDIZIONI_COSTI Costi ";
									text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
									text += "WHERE ";
									text += "Costi.ImportoArrotondato <> 0 AND ";
									string text4 = text;
									DBConnection dbConn4 = ((AppBaseClass)this).DbConn;
									string pNumero = row3["Id"].ToString();
									text = text4 + "Costi.Id = " + dbConn4.SQLFormatNumber(ref pNumero) + " ";
									text += ";\r\n";
									stringCollection.Add(text);
								}
								((AppAbstractApiObservable)this).NotifyObservers((object)"");
								num2++;
								continue;
							}
							val2 = val;
							goto end_IL_000e;
						}
						if (stringCollection.Count > 0)
						{
							int num3 = 1;
							int num4 = 0;
							StringBuilder stringBuilder = new StringBuilder();
							StringEnumerator enumerator7 = stringCollection.GetEnumerator();
							while (true)
							{
								if (enumerator7.MoveNext())
								{
									string current4 = enumerator7.Current;
									stringBuilder.Append(current4);
									if (num3 != 10)
									{
										goto IL_0b5c;
									}
									val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
									if (unchecked((int)val) <= 0)
									{
										stringBuilder = new StringBuilder();
										num3 = 0;
										num4++;
										goto IL_0b5c;
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
									if (unchecked((int)val) <= 0)
									{
										break;
									}
									val2 = val;
								}
								goto end_IL_000e;
								IL_0b5c:
								num3++;
							}
						}
						val2 = (FXRETURN)0;
					}
				}
			}
			end_IL_000e:;
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
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Invalid comparison between Unknown and I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Invalid comparison between Unknown and I4
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Invalid comparison between Unknown and I4
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Passive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
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
				foreach (string item in _Viaggi)
				{
					string pNumero2 = item;
					text = "SELECT Costi.* ";
					text += "FROM VIAGGI V ";
					text += "INNER JOIN VIAGGI_COSTI Costi ON V.IdViaggio=Costi.IdViaggio ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
					text += "WHERE Costi.ImportoArrotondato <> 0 AND ";
					text = text + "V.IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + " AND ";
					text += "Costi.UtenteForzatura IS NULL";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						foreach (DataRow row in rObjDataTable.Rows)
						{
							pNumero = checked(pNumero + 10);
							text = "INSERT INTO Fatture_Passive_Dettaglio (";
							text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, IdViaggio, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ImportoArrotondato, ImportoUnitario, IdRaggruppamentoViaggi, CodiceIva, UteIns, UteAgg) SELECT ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
							text += "'V' AS TipoRiga, Costi.Voce, Descrizione, IdViaggio, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ImportoArrotondato, ImportoUnitario, NULL AS IdRaggruppamentoViaggi, CodiceIva, ";
							text = text + this.DbConn.SQLFormatString(this._User) + ", ";
							text = text + this.DbConn.SQLFormatString(this._User) + " ";
							text += "FROM VIAGGI_COSTI Costi INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
							text += "WHERE Costi.ImportoArrotondato <> 0 AND ";
							string text2 = text;
							DBConnection dbConn = ((AppBaseClass)this).DbConn;
							string pNumero3 = row["Id"].ToString();
							text = text2 + "Costi.Id = " + dbConn.SQLFormatNumber(ref pNumero3) + "; ";
							stringCollection.Add(text);
							List<string> costiViaggiIds = _CostiViaggiIds;
							DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
							pNumero3 = row["Id"].ToString();
							costiViaggiIds.Add(dbConn2.SQLFormatNumber(ref pNumero3));
						}
						if (checked(num + 1) % 100 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("INSERIMENTO DETTAGLIO FATTURA DA VIAGGI " + checked(num + 1) + " su " + _Viaggi.Count));
						}
						num = checked(num + 1);
						continue;
					}
					val2 = val;
					goto end_IL_000e;
				}
				text = "SELECT Costi.* ";
				text += "FROM VIAGGI V ";
				text += "INNER JOIN VIAGGI_COSTI Costi ON V.IdViaggio=Costi.IdViaggio ";
				text += "INNER JOIN Trasportatori TR ON Costi.Trasportatore = TR.Codice ";
				text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
				text += "WHERE Costi.IdFatturaPassiva IS NULL AND ";
				text += "Costi.ImportoArrotondato <> 0 AND ";
				text += "Costi.UtenteForzatura IS NOT NULL AND ";
				if (_IdViaggiDaFatturare != null)
				{
					text += "(";
					foreach (string item2 in _IdViaggiDaFatturare)
					{
						text = text + "V.IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(item2) + " OR ";
					}
					text += "1=2) AND ";
				}
				else
				{
					text = text + "V.DataPartenzaEffettiva >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
					text = text + "V.DataPartenzaEffettiva < " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData.AddDays(1.0)) + " AND ";
				}
				text = text + "TR.FatturaA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione) + " ";
				if (Operators.CompareString(_Trasportatore, "", false) != 0)
				{
					text = text + " AND Costi.Trasportatore = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore);
				}
				if (Operators.CompareString(_Mittente, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
				{
					text = text + " AND V.TipoSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione);
				}
				if (Operators.CompareString(_TipoMerce, "", false) != 0)
				{
					text = text + " AND V.TipoMerce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce);
				}
				if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				if (Operators.CompareString(_PCSPartenza, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				if (Operators.CompareString(_PCSArrivo, "", false) != 0)
				{
					text += " AND 1=2 ";
				}
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					num = 0;
					checked
					{
						foreach (DataRow row2 in rObjDataTable.Rows)
						{
							pNumero += 10;
							text = "INSERT INTO Fatture_Passive_Dettaglio (";
							text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
							text += "IDViaggio, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
							text += "ImportoArrotondato, ImportoUnitario, IdRaggruppamentoViaggi, CodiceIva, UteIns, UteAgg) SELECT ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
							text += "'M' AS TipoRiga, Costi.Voce, Descrizione, IdViaggio, ";
							text += "RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
							text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ImportoArrotondato, ";
							text += "ImportoUnitario, NULL AS IdRaggruppamentoViaggi, CodiceIva, ";
							text = text + this.DbConn.SQLFormatString(this._User) + ", ";
							text = text + this.DbConn.SQLFormatString(this._User) + " ";
							text += "FROM VIAGGI_COSTI Costi ";
							text += "INNER JOIN VOCI ON VOCI.CODICE = Costi.VOCE ";
							text += "WHERE Costi.ImportoArrotondato <> 0 AND ";
							string text3 = text;
							DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
							string pNumero3 = row2["Id"].ToString();
							text = text3 + "Costi.Id = " + dbConn3.SQLFormatNumber(ref pNumero3) + " ";
							text += ";";
							stringCollection.Add(text);
							List<string> costiViaggiIds2 = _CostiViaggiIds;
							DBConnection dbConn4 = ((AppBaseClass)this).DbConn;
							pNumero3 = row2["Id"].ToString();
							costiViaggiIds2.Add(dbConn4.SQLFormatNumber(ref pNumero3));
							num++;
						}
						if (stringCollection.Count > 0)
						{
							int num2 = 1;
							int num3 = 0;
							StringBuilder stringBuilder = new StringBuilder();
							StringEnumerator enumerator5 = stringCollection.GetEnumerator();
							while (true)
							{
								if (enumerator5.MoveNext())
								{
									string current2 = enumerator5.Current;
									stringBuilder.Append(current2);
									if (num2 != 10)
									{
										goto IL_07fb;
									}
									val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
									if (unchecked((int)val) <= 0)
									{
										stringBuilder = new StringBuilder();
										num2 = 0;
										num3++;
										goto IL_07fb;
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
									if (unchecked((int)val) <= 0)
									{
										break;
									}
									val2 = val;
								}
								goto end_IL_000e;
								IL_07fb:
								num2++;
							}
						}
						val2 = (FXRETURN)0;
					}
				}
			}
			end_IL_000e:;
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
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Invalid comparison between Unknown and I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Invalid comparison between Unknown and I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Invalid comparison between Unknown and I4
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			int i = 1;
			using (List<string>.Enumerator enumerator = _speOk.GetEnumerator())
			{
				for (; enumerator.MoveNext(); i = checked(i + 1))
				{
					string pNumero = enumerator.Current;
					string text = "UPDATE SPEDIZIONI ";
					text = text + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text = text + "WHERE Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(pNumero) + " ";
					text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Passive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
					stringBuilder.AppendLine(text);
					text = "UPDATE SPEDIZIONI_COSTI ";
					text = text + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text += "WHERE ImportoArrotondato <> 0 ";
					text = text + "AND Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(pNumero) + " ";
					text += "AND UtenteForzatura IS NULL ";
					text += "AND TipoCalcolo NOT IN ('MAN','VET');";
					stringBuilder.AppendLine(text);
					if (num != 50)
					{
						num = checked(num + 1);
						continue;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val <= 0)
					{
						num = 1;
						stringBuilder.Clear();
						((AppAbstractApiObservable)this).NotifyObservers((object)("BLOCCO SPEDIZIONI FATTURATE " + i + " su " + _speOk.Count));
						continue;
					}
					val2 = val;
					goto end_IL_0005;
				}
			}
			if (stringBuilder.Length <= 0)
			{
				goto IL_026d;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
			if ((int)val <= 0)
			{
				((AppAbstractApiObservable)this).NotifyObservers((object)("BLOCCO SPEDIZIONI FATTURATE " + _speOk.Count + " su " + _speOk.Count));
				goto IL_026d;
			}
			val2 = val;
			goto end_IL_0005;
			IL_044b:
			val2 = (FXRETURN)0;
			goto end_IL_0005;
			IL_026d:
			num = 1;
			i = 1;
			stringBuilder.Clear();
			using (List<string>.Enumerator enumerator2 = _CostiIds.GetEnumerator())
			{
				for (; enumerator2.MoveNext(); i = checked(i + 1))
				{
					string pNumero2 = enumerator2.Current;
					string text2 = "UPDATE SPEDIZIONI_COSTI ";
					text2 = text2 + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text2 = text2 + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + ";";
					stringBuilder.AppendLine(text2);
					text2 = "UPDATE SPEDIZIONI ";
					text2 = text2 + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text2 = text2 + "WHERE Unibol = (SELECT UNIBOL FROM SPEDIZIONI_COSTI WHERE ID=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + ") ";
					text2 += "AND IdFatturaPassiva IS NULL ";
					text2 = text2 + "AND NOT EXISTS (SELECT 1 FROM SPEDIZIONI_COSTI WHERE UNIBOL = (SELECT UNIBOL FROM SPEDIZIONI_COSTI WHERE ID=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + ") ";
					text2 += "AND TRASPORTATORE <> SPEDIZIONI.TRASPORTATORE); ";
					stringBuilder.AppendLine(text2);
					if (num != 50)
					{
						num = checked(num + 1);
						continue;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val <= 0)
					{
						num = 1;
						stringBuilder.Clear();
						((AppAbstractApiObservable)this).NotifyObservers((object)("BLOCCO SPEDIZIONI_COSTI FATTURATI " + i + " su " + _CostiIds.Count));
						continue;
					}
					val2 = val;
					goto end_IL_0005;
				}
			}
			if (stringBuilder.Length <= 0)
			{
				goto IL_044b;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_044b;
			}
			val2 = val;
			end_IL_0005:;
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
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Invalid comparison between Unknown and I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Invalid comparison between Unknown and I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Invalid comparison between Unknown and I4
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			int i = 1;
			using (List<string>.Enumerator enumerator = _Viaggi.GetEnumerator())
			{
				for (; enumerator.MoveNext(); i = checked(i + 1))
				{
					string pNumero = enumerator.Current;
					string text = "UPDATE VIAGGI ";
					text = text + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text = text + "WHERE IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(pNumero) + " ";
					text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Passive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
					stringBuilder.AppendLine(text);
					text = "UPDATE VIAGGI_COSTI ";
					text = text + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text += "WHERE ImportoArrotondato <> 0 ";
					text = text + "AND IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(pNumero) + " ";
					text += "AND UtenteForzatura IS NULL;";
					stringBuilder.AppendLine(text);
					if (num != 50)
					{
						num = checked(num + 1);
						continue;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val <= 0)
					{
						num = 1;
						stringBuilder.Clear();
						((AppAbstractApiObservable)this).NotifyObservers((object)("BLOCCO VIAGGI FATTURATI " + i + " su " + _Viaggi.Count));
						continue;
					}
					val2 = val;
					goto end_IL_0005;
				}
			}
			if (stringBuilder.Length <= 0)
			{
				goto IL_025f;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
			if ((int)val <= 0)
			{
				((AppAbstractApiObservable)this).NotifyObservers((object)("BLOCCO VIAGGI FATTURATI " + _Viaggi.Count + " su " + _Viaggi.Count));
				goto IL_025f;
			}
			val2 = val;
			goto end_IL_0005;
			IL_043d:
			val2 = (FXRETURN)0;
			goto end_IL_0005;
			IL_025f:
			stringBuilder.Clear();
			num = 1;
			i = 1;
			using (List<string>.Enumerator enumerator2 = _CostiViaggiIds.GetEnumerator())
			{
				for (; enumerator2.MoveNext(); i = checked(i + 1))
				{
					string pNumero2 = enumerator2.Current;
					string text2 = "UPDATE Viaggi_Costi ";
					text2 = text2 + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text2 = text2 + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + ";";
					stringBuilder.AppendLine(text2);
					text2 = "UPDATE VIAGGI ";
					text2 = text2 + "SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
					text2 = text2 + "WHERE IdViaggio = (SELECT IdViaggio FROM VIAGGI_COSTI WHERE ID=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + ") ";
					text2 += "AND IdFatturaPassiva IS NULL ";
					text2 = text2 + "AND NOT EXISTS (SELECT 1 FROM VIAGGI_COSTI WHERE IdViaggio = (SELECT IdViaggio FROM VIAGGI_COSTI WHERE ID=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + ") ";
					text2 += "AND TRASPORTATORE <> VIAGGI.VETTORE); ";
					stringBuilder.AppendLine(text2);
					if (num != 50)
					{
						num = checked(num + 1);
						continue;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val <= 0)
					{
						num = 1;
						stringBuilder.Clear();
						((AppAbstractApiObservable)this).NotifyObservers((object)("BLOCCO VIAGGI_COSTI FATTURATI " + i + " su " + _CostiViaggiIds.Count));
						continue;
					}
					val2 = val;
					goto end_IL_0005;
				}
			}
			if (stringBuilder.Length <= 0)
			{
				goto IL_043d;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_043d;
			}
			val2 = val;
			end_IL_0005:;
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
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
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
						string text = row["Id"].ToString();
						val = ContrassegniAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsMess);
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
							FatturePassiveMessaggiScrivi(idFattura, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						if (num % 10 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("RICALCOLO CONTRASSEGNI " + num + " su " + rObjDataTable.Rows.Count));
						}
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
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
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
						string text = row["Id"].ToString();
						val = GiacenzeAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, text, ref Warning, ref rsMess);
						if (((int)val == 0) & (Operators.CompareString(Warning, "", false) == 0))
						{
							_GiacenzeOk.Add(text);
						}
						else
						{
							_GiacenzeKo.Add(text);
							long idFattura = _IdFattura;
							string messaggio = this.TranslateMessage("XXX", "RICALCOLO GIACENZA {0} - {1}", new string[2]
							{
								text,
								Strings.Trim(rsMess + Warning)
							});
							string rsMess2 = "";
							FatturePassiveMessaggiScrivi(idFattura, FatturePassiveMessaggi.FatturePassiveLogTipoMessaggio.Errore, messaggio, ref rsMess2);
						}
						if (num % 10 == 0)
						{
							((AppAbstractApiObservable)this).NotifyObservers((object)("RICALCOLO GIACENZE " + num + " su " + rObjDataTable.Rows.Count));
						}
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
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Invalid comparison between Unknown and I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
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
			text = "SELECT C.ID, C.TRASPORTATORE, C.TrasportatoreFatturazione FROM CONTRASSEGNI C INNER JOIN Spedizioni S ON S.UNIBOL=C.UnibolMaster ";
			text += "WHERE C.IdFatturaPassiva IS NULL AND ";
			text += "C.Stato IN (30,40) AND ";
			if (_IdSpedizioniDaFatturare != null)
			{
				text += "(";
				foreach (string item in _IdSpedizioniDaFatturare)
				{
					text = text + "S.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " OR ";
				}
				text += "1=2) AND ";
			}
			else
			{
				text = text + "C.DataIncasso >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
				text = text + "C.DataIncasso <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			}
			text = text + "C.TrasportatoreFatturazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione) + " ";
			if (Operators.CompareString(_Trasportatore, "", false) != 0)
			{
				text = text + "AND C.Trasportatore = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore) + " ";
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
				goto IL_02fc;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "C", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_02fc;
			}
			val2 = val;
			goto end_IL_0012;
			IL_02fc:
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
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Invalid comparison between Unknown and I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
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
			text = "SELECT G.ID, G.TRASPORTATORE, G.TrasportatoreFatturazione FROM GIACENZE G INNER JOIN Spedizioni S ON S.UNIBOL=G.UnibolApertura ";
			text += "WHERE G.IdFatturaPassiva IS NULL AND G.STATO=20 AND ";
			if (_IdSpedizioniDaFatturare != null)
			{
				text += "(";
				foreach (string item in _IdSpedizioniDaFatturare)
				{
					text = text + "S.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " OR ";
				}
				text += "1=2) AND ";
			}
			else
			{
				text = text + "G.DataCompetenzaPassiva >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND ";
				text = text + "G.DataCompetenzaPassiva <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _AData) + " AND ";
			}
			text = text + "G.TrasportatoreFatturazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TrasportatoreFatturazione) + " ";
			if (Operators.CompareString(_Trasportatore, "", false) != 0)
			{
				text = text + "AND G.Trasportatore = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore) + " ";
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
				goto IL_02f0;
			}
			val = SetFiltriAggiuntivi(_FiltriAggiuntivi, ref ssqlQuery, ref rsMess);
			if ((int)val <= 0)
			{
				ssqlQuery = Strings.Replace(ssqlQuery, "%TAB%", "G", 1, -1, (CompareMethod)0);
				text += ssqlQuery;
				goto IL_02f0;
			}
			val2 = val;
			goto end_IL_0012;
			IL_02f0:
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
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Invalid comparison between Unknown and I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Invalid comparison between Unknown and I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
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
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Passive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
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
					text = "SELECT C.* ";
					text += "FROM CONTRASSEGNI_COSTI C ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = C.VOCE ";
					text += "WHERE C.ImportoArrotondato <> 0 AND ";
					string text3 = text;
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					int pNumero2 = Conversions.ToInteger(item);
					text = text3 + "C.IdContrassegno = " + dbConn.SQLFormatNumber(ref pNumero2);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						checked
						{
							foreach (DataRow row in rObjDataTable.Rows)
							{
								pNumero += 10;
								text = "INSERT INTO Fatture_Passive_Dettaglio (";
								text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
								text += "IdContrassegno, Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
								text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
								text += "ImportoArrotondato, ImportoUnitario, CodiceIva, UteIns, UteAgg) SELECT ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
								text += "'C' AS TipoRiga, CC.Voce, VO.Descrizione, CC.IdContrassegno, C.UnibolMaster, RecordZZ, TipoCalcolo, ";
								text += "CampoCalcolo, QuantitaOriginale,QuantitaArrotondata, QuantitaTassata, ";
								text += "ImportoOriginale, ImportoArrotondato,ImportoUnitario, CodiceIva, ";
								text = text + this.DbConn.SQLFormatString(this._User) + ", ";
								text = text + this.DbConn.SQLFormatString(this._User) + " ";
								text += "FROM CONTRASSEGNI_COSTI CC ";
								text += "INNER JOIN CONTRASSEGNI C ON C.ID = CC.IDCONTRASSEGNO ";
								text += "INNER JOIN Voci VO ON VO.CODICE = CC.VOCE ";
								text += "WHERE ";
								text += "CC.ImportoArrotondato <> 0 AND ";
								text = text + "CC.IDCONTRASSEGNO = " + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " AND ";
								text = text + "CC.Voce = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["Voce"].ToString()) + " AND ";
								text = text + "CC.RecordZZ = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["RecordZZ"].ToString());
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
								goto IL_0396;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								stringBuilder = new StringBuilder();
								num2 = 0;
								num3 = checked(num3 + 1);
								goto IL_0396;
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
						IL_0396:
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
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Invalid comparison between Unknown and I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Invalid comparison between Unknown and I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
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
			text = "SELECT ISNULL(MAX(Riga),0) FROM Fatture_Passive_Dettaglio WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
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
				foreach (string item in _GiacenzeOk)
				{
					text = "SELECT C.* ";
					text += "FROM GIACENZE_COSTI C ";
					text += "INNER JOIN VOCI ON VOCI.CODICE = C.VOCE ";
					text += "WHERE C.ImportoArrotondato <> 0 AND ";
					string text3 = text;
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					int pNumero2 = Conversions.ToInteger(item);
					text = text3 + "C.IdGiacenza = " + dbConn.SQLFormatNumber(ref pNumero2);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val <= 0)
					{
						checked
						{
							foreach (DataRow row in rObjDataTable.Rows)
							{
								pNumero += 10;
								text = "INSERT INTO Fatture_Passive_Dettaglio (";
								text += "IdFattura, Riga, TipoRiga, Voce, Descrizione, ";
								text += "IdGiacenza, Unibol, RecordZZ, TipoCalcolo, CampoCalcolo, QuantitaOriginale, ";
								text += "QuantitaArrotondata, QuantitaTassata, ImportoOriginale, ";
								text += "ImportoArrotondato, ImportoUnitario, GiorniTassati, CodiceIva, UteIns, UteAgg) SELECT ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
								text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
								text += "'G' AS TipoRiga, GC.Voce, VO.Descrizione, GC.IdGiacenza, C.UnibolMaster, RecordZZ, TipoCalcolo, ";
								text += "CampoCalcolo, QuantitaOriginale,QuantitaArrotondata, QuantitaTassata, ";
								text += "ImportoOriginale, ImportoArrotondato,ImportoUnitario, GiorniTassati, CodiceIva, ";
								text = text + this.DbConn.SQLFormatString(this._User) + ", ";
								text = text + this.DbConn.SQLFormatString(this._User) + " ";
								text += "FROM GIACENZE_COSTI GC ";
								text += "INNER JOIN GIACENZE C ON C.ID = GC.IDGIACENZA ";
								text += "INNER JOIN Voci VO ON VO.CODICE = GC.VOCE ";
								text += "WHERE ";
								text += "GC.ImportoArrotondato <> 0 AND ";
								text = text + "GC.IdGiacenza = " + ((AppBaseClass)this).DbConn.SQLFormatString(item) + " AND ";
								text = text + "GC.Voce = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["Voce"].ToString()) + " AND ";
								text = text + "GC.RecordZZ = " + ((AppBaseClass)this).DbConn.SQLFormatString(row["RecordZZ"].ToString());
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
								goto IL_0396;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val <= 0)
							{
								stringBuilder = new StringBuilder();
								num2 = 0;
								num3 = checked(num3 + 1);
								goto IL_0396;
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
						IL_0396:
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
				text = "UPDATE Contrassegni SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
				string text2 = text;
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				int pNumero2 = Conversions.ToInteger(pNumero);
				text = text2 + "WHERE Id = " + dbConn.SQLFormatNumber(ref pNumero2) + " ";
				text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Passive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND IdContrassegno = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
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
			foreach (string item in _GiacenzeOk)
			{
				string pNumero = item;
				string text = "";
				text = "UPDATE Giacenze SET IdFatturaPassiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
				string text2 = text;
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				int pNumero2 = Conversions.ToInteger(pNumero);
				text = text2 + "WHERE Id = " + dbConn.SQLFormatNumber(ref pNumero2) + " ";
				text = text + "AND (SELECT SUM(ImportoArrotondato) FROM Fatture_Passive_Dettaglio WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " AND IdGiacenza = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") > 0; ";
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
