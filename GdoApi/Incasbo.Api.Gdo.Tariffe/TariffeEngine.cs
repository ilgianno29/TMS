using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public abstract class TariffeEngine : AppBaseClass
{
	public enum TipoTariffeEngine
	{
		Attiva,
		Passiva
	}

	protected enum CancellazioneCostiRicaviModalita
	{
		Tutti,
		SoloCalcolati,
		AssenzaDelSoggetto
	}

	protected Costi _Costi;

	protected Ricavi _Ricavi;

	protected string _ViewContrattoTariffa;

	protected string _ViewTestataTariffa;

	protected string _ViewVociTariffa;

	protected string _ViewFasceTariffa;

	protected string _ViewSoggetto;

	protected string _TableCostiRicaviKeyName;

	protected TipoTariffeEngine _TipoTariffaEngine;

	protected string _ViewVociTariffaWhere;

	protected string _Soggetto;

	protected string _Contratto;

	protected string _TipoContrattoApplicato;

	protected string _TipoSpedizione;

	protected string _TipoMerce;

	protected string _TipoMezzo;

	protected string _Cliente;

	protected string _PCSPartenza;

	protected string _GruppoTariffarioPartenza;

	protected string _ZonaArrivo;

	protected string _ZonaArrivoMacro;

	protected string _PCSArrivo;

	protected string _GruppoTariffarioArrivo;

	protected DateTime _DataRiferimento;

	protected DataTable _dtContrattoTariffa;

	protected DataTable _dtTestataTariffa;

	protected DataTable _dtVociTariffa;

	protected DataTable _dtFasceTariffa;

	protected DataTable _dtSoggetto;

	protected StringCollection SqlElencoSave;

	protected bool _NoloRequired;

	protected bool _TariffaRaggruppata;

	protected decimal _Arrotondamento;

	protected bool _TassazioneRiconsegne;

	protected decimal _PercentualeRiconsegne;

	protected bool _TassazioneResi;

	protected decimal _PercentualeResi;

	protected bool _SimulationMode;

	protected string _TipoCalcolo;

	public virtual TransportDocument Document { get; set; }

	public virtual DocumentLoader DocLoader { get; set; }

	public virtual bool TransactionManage { get; set; }

	protected virtual string AttivaPassiva => Interaction.IIf(_TipoTariffaEngine == TipoTariffeEngine.Attiva, (object)this.TranslateMessage("XXX", "attiva"), (object)this.TranslateMessage("XXX", "passiva")).ToString();

	protected virtual string AttivoPassivo => Interaction.IIf(_TipoTariffaEngine == TipoTariffeEngine.Attiva, (object)this.TranslateMessage("XXX", "attivo"), (object)this.TranslateMessage("XXX", "passivo")).ToString();

	protected virtual bool TariffaRaggruppata => _TariffaRaggruppata;

	public TariffeEngine(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ViewContrattoTariffa = "";
		_ViewTestataTariffa = "TariffeContratti";
		_ViewVociTariffa = "";
		_ViewFasceTariffa = "";
		_ViewSoggetto = "";
		_TableCostiRicaviKeyName = "";
		_TipoTariffaEngine = TipoTariffeEngine.Attiva;
		_ViewVociTariffaWhere = "";
		_Soggetto = "";
		_Contratto = "";
		_TipoContrattoApplicato = "N";
		_TipoSpedizione = "";
		_TipoMerce = "";
		_TipoMezzo = "";
		_Cliente = "";
		_PCSPartenza = "";
		_GruppoTariffarioPartenza = "";
		_ZonaArrivo = "";
		_ZonaArrivoMacro = "";
		_PCSArrivo = "";
		_GruppoTariffarioArrivo = "";
		_dtContrattoTariffa = null;
		_dtTestataTariffa = null;
		_dtVociTariffa = null;
		_dtFasceTariffa = null;
		_dtSoggetto = null;
		SqlElencoSave = new StringCollection();
		_NoloRequired = true;
		_TariffaRaggruppata = false;
		_TassazioneRiconsegne = false;
		_PercentualeRiconsegne = default(decimal);
		_TassazioneResi = false;
		_PercentualeResi = default(decimal);
		_SimulationMode = false;
		_TipoCalcolo = "STD";
		Document = null;
		DocLoader = null;
		TransactionManage = false;
	}

	protected virtual FXRETURN InitEngine(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val2 = DocLoader.Load(ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				Document = DocLoader.Document;
				_Ricavi = Document.RicaviList;
				_Costi = Document.CostiList;
				if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
				{
					_Soggetto = Document.SoggettoAttivo;
					_TipoSpedizione = Document.TipoSpedizioneAttivo;
					_DataRiferimento = Document.DataCompentenzaAttiva.Value;
					_ZonaArrivo = Document.ZonaArrivoAttiva;
					_ZonaArrivoMacro = Document.ZonaArrivoAttivaMacro;
				}
				else
				{
					_Soggetto = Document.SoggettoPassivo;
					_TipoSpedizione = Document.TipoSpedizionePassivo;
					_DataRiferimento = Document.DataCompentenzaPassiva.Value;
					_ZonaArrivo = Document.ZonaArrivoPassiva;
					_ZonaArrivoMacro = Document.ZonaArrivoPassivaMacro;
				}
				_TipoMerce = Document.TipoMerce;
				_TipoMezzo = Document.TipoMezzo;
				_PCSPartenza = Document.PCSPartenza;
				_GruppoTariffarioPartenza = Document.GruppoTariffarioPartenza;
				_GruppoTariffarioArrivo = Document.GruppoTariffarioArrivo;
				_Cliente = Document.Cliente;
				_PCSArrivo = Document.PCSArrivo;
				_GruppoTariffarioArrivo = Document.GruppoTariffarioArrivo;
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

	protected virtual FXRETURN BeforeInit(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN AfterCalc(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN BeforeCalc(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN OnCalcExit(FXRETURN CalcResult, string ErrorMessage, string WarningMessage, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN AfterInit(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Soggetto, "", false) == 0)
			{
				goto IL_00c8;
			}
			text = "SELECT * FROM " + _ViewSoggetto + " WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Soggetto);
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSoggetto, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (_dtSoggetto.Rows.Count != 0)
				{
					goto IL_00c8;
				}
				rsmess = this.TranslateMessage("XXX", "Il soggetto con codice '{0}' non è stato trovato in anagrafica {1}", new string[2] { _Soggetto, _ViewSoggetto });
			}
			goto end_IL_000b;
			IL_00c8:
			val = (FXRETURN)0;
			end_IL_000b:;
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

	protected virtual FXRETURN Check(ref bool CanCalculate, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			CanCalculate = false;
			if (Operators.CompareString(_TipoSpedizione, "", false) == 0)
			{
				rsmess = base._Translator.TranslateMessage("XXX", "Tipo spedizione {0} non specificato per il documento con ID '{1}'", new string[2] { AttivoPassivo, Document.ID });
			}
			else if (Operators.CompareString(_TipoMerce, "", false) == 0)
			{
				rsmess = base._Translator.TranslateMessage("XXX", "Tipo merce non specificata per il documento con ID '{0}'", new string[1] { Document.ID });
			}
			else if (Operators.CompareString(_TipoMezzo, "", false) == 0)
			{
				rsmess = base._Translator.TranslateMessage("XXX", "Tipo mezzo non specificata per il documento con ID '{0}'", new string[1] { Document.ID });
			}
			else if (Operators.CompareString(_PCSPartenza, "", false) == 0)
			{
				rsmess = base._Translator.TranslateMessage("XXX", "PCS di partenza non specificato per il documento con ID '{0}'", new string[1] { Document.ID });
			}
			else if (Operators.CompareString(_ZonaArrivo, "", false) == 0)
			{
				rsmess = base._Translator.TranslateMessage("XXX", "Zona di arrivo {0} non specificata per il documento con ID {1}", new string[2] { AttivoPassivo, Document.ID });
			}
			else if (Operators.CompareString(_Cliente, "", false) == 0)
			{
				rsmess = base._Translator.TranslateMessage("XXX", "Cliente non specificato per il documento con ID {0}", new string[1] { Document.ID });
			}
			else if (_TariffaRaggruppata & !Document.AbilitaRaggruppamento)
			{
				val = (FXRETURN)0;
			}
			else
			{
				CanCalculate = true;
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

	protected virtual FXRETURN SearchContract(ref bool ContrattoTrovato, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Invalid comparison between Unknown and I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string vsStringa = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ContrattoTrovato = false;
			if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
			{
				vsStringa = Document.SoggettoFatturazioneAttiva;
				text2 = "CLIENTE";
			}
			else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
			{
				vsStringa = Document.SoggettoFatturazionePassiva;
				text2 = "TRASPORTATORE";
			}
			text = "SELECT * FROM (";
			text += "SELECT TC.*, ";
			text = text + "CASE WHEN " + text2 + " = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Soggetto) + " THEN 1 ";
			text = text + "WHEN " + text2 + " = " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + " THEN 2 ";
			text = text + "WHEN " + text2 + " = '*ALL' THEN 3 ";
			text += "END AS PESO ";
			text += "FROM TariffeContratti TC WHERE ";
			text = ((!Document.TipoDocumento.ToUpper().Contains("GIACENZA")) ? (text + "CONTRATTOTRASPORTO='S' ") : (text + "CONTRATTOGIACENZA='S' "));
			text += "AND ATTIVAPASSIVA = ";
			if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
			{
				text += "'A' ";
			}
			else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
			{
				text += "'P' ";
			}
			text = text + "AND DataInizioValidita <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataRiferimento) + " ";
			text = text + "AND DataFineValidita >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataRiferimento) + " ";
			text = text + "AND " + text2 + " IN (" + ((AppBaseClass)this).DbConn.SQLFormatString(_Soggetto) + "," + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + ", '*ALL') ";
			text += ") T ORDER BY PESO";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtContrattoTariffa, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (_dtContrattoTariffa.Rows.Count == 0)
			{
				ContrattoTrovato = false;
				rsmess = this.TranslateMessage("XXX", "Il contratto per il documento {0} non è stato trovato", new string[1] { Document.ID });
			}
			else
			{
				ContrattoTrovato = true;
				if (Operators.CompareString(_dtContrattoTariffa.Rows[0]["Attivo"].ToString(), "N", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il contratto {0} non risulta attivo", new string[1] { _dtContrattoTariffa.Rows[0]["Codice"].ToString() });
				}
				else
				{
					_Contratto = _dtContrattoTariffa.Rows[0]["Codice"].ToString();
					_TipoContrattoApplicato = _dtContrattoTariffa.Rows[0]["Peso"].ToString();
					val = (FXRETURN)0;
				}
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

	protected virtual FXRETURN Search(ref bool TariffaTrovata, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Invalid comparison between Unknown and I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Invalid comparison between Unknown and I4
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Invalid comparison between Unknown and I4
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Invalid comparison between Unknown and I4
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		StringCollection stringCollection = new StringCollection();
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			TariffaTrovata = false;
			string text2 = "";
			text2 = "SELECT Codice FROM TariffeTipiDocumento WHERE ";
			if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
			{
				text2 += " TariffaAttiva='S' ";
			}
			else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
			{
				text2 += " TariffaPassiva='S' ";
			}
			if (Document.TipoDocumento.ToUpper().Contains("SPEDIZIONE") | Document.TipoDocumento.ToUpper().Contains("SPEDIZIONI"))
			{
				text2 += " AND Spedizione='S' ";
			}
			else if (Document.TipoDocumento.ToUpper().Contains("VIAGGIO"))
			{
				text2 += " AND Viaggio='S' ";
			}
			else if (Document.TipoDocumento.ToUpper().Contains("CONTRASSEGN"))
			{
				text2 += " AND Contrassegno='S' ";
			}
			else if (Document.TipoDocumento.ToUpper().Contains("GIACENZA"))
			{
				text2 += " AND Giacenza='S' ";
			}
			text2 += " AND Attivo='S' ";
			text = "SELECT * FROM " + _ViewTestataTariffa + " WHERE ";
			text = text + "Contratto = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Contratto) + " ";
			text = text + "AND (TipoDocumento = '*ALL' OR TipoDocumento IN (" + text2 + ")) ";
			text = text + "AND TipoSpedizione IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + ") ";
			text = text + "AND TipoMerce IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + ") ";
			text = text + "AND TipoMezzo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMezzo) + ") ";
			text = text + "AND Cliente IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + ") ";
			text = text + "AND GruppoTariffarioPartenza IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioPartenza) + ") ";
			text = text + "AND PCSPartenza IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + ") ";
			text = text + "AND MacroZonaArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivoMacro) + ") ";
			text = text + "AND ZonaArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + ") ";
			text = text + "AND GruppoTariffarioArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioArrivo) + ") ";
			text = text + "AND PCSArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + ") ";
			text += "ORDER BY Peso DESC";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtTestataTariffa, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (_dtTestataTariffa.Rows.Count == 0)
			{
				rsmess = base._Translator.TranslateMessage("XXX", "Tariffa {0} non trovata per il documento {1}", new string[2] { AttivaPassiva, Document.ID });
				TariffaTrovata = false;
				val = (FXRETURN)0;
			}
			else
			{
				TariffaTrovata = true;
				_Arrotondamento = Conversions.ToDecimal(_dtTestataTariffa.Rows[0]["ArrotondamentoImporti"]);
				_TassazioneRiconsegne = Operators.CompareString(_dtTestataTariffa.Rows[0]["TassazioneRiconsegne"].ToString(), "S", false) == 0;
				if (_TassazioneRiconsegne)
				{
					_PercentualeRiconsegne = Conversions.ToDecimal(_dtTestataTariffa.Rows[0]["PercentualeRiconsegne"]);
					if (decimal.Compare(_PercentualeRiconsegne, 100m) > 0)
					{
						_PercentualeRiconsegne = 100m;
					}
				}
				else
				{
					_PercentualeRiconsegne = default(decimal);
				}
				_TassazioneResi = Operators.CompareString(_dtTestataTariffa.Rows[0]["TassazioneResi"].ToString(), "S", false) == 0;
				if (_TassazioneResi)
				{
					_PercentualeResi = Conversions.ToDecimal(_dtTestataTariffa.Rows[0]["PercentualeResi"]);
					if (decimal.Compare(_PercentualeResi, 100m) > 0)
					{
						_PercentualeResi = 100m;
					}
				}
				else
				{
					_PercentualeResi = default(decimal);
				}
				text = "SELECT * FROM " + _ViewVociTariffa + " WHERE IdTariffa IN (";
				int num = 1;
				foreach (DataRow row in _dtTestataTariffa.Rows)
				{
					text += ((AppBaseClass)this).DbConn.SQLFormatString(row["IdTariffa"].ToString());
					if (num < _dtTestataTariffa.Rows.Count)
					{
						text += ", ";
					}
					num = checked(num + 1);
				}
				text += ") ";
				if (Operators.CompareString(_ViewVociTariffaWhere, " ", false) != 0)
				{
					text = text + "AND " + _ViewVociTariffaWhere + " ";
				}
				text += "ORDER BY Peso DESC";
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (!TariffaRaggruppata && rObjDataTable.Rows.Count == 0)
				{
					rsmess = base._Translator.TranslateMessage("XXX", "Voci tariffarie della tariffa {0} non trovate per il documento {1}", new string[2] { AttivaPassiva, Document.ID });
				}
				else
				{
					_dtVociTariffa = rObjDataTable.Clone();
					foreach (DataRow row2 in rObjDataTable.Rows)
					{
						if (!stringCollection.Contains(row2["Voce"].ToString()))
						{
							stringCollection.Add(row2["Voce"].ToString());
							_dtVociTariffa.ImportRow(row2);
						}
					}
					_dtVociTariffa.AcceptChanges();
					text = "SELECT * FROM " + _ViewFasceTariffa + " WHERE IdVoce IN (-999";
					num = 1;
					foreach (DataRow row3 in _dtVociTariffa.Rows)
					{
						if (num == 1)
						{
							text += ", ";
						}
						text += ((AppBaseClass)this).DbConn.SQLFormatString(row3["IdVoce"].ToString());
						if (num < _dtVociTariffa.Rows.Count)
						{
							text += ", ";
						}
						num = checked(num + 1);
					}
					text += ")";
					val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtFasceTariffa, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else if ((_dtFasceTariffa.Rows.Count == 0) & (_dtVociTariffa.Rows.Count > 0))
					{
						rsmess = base._Translator.TranslateMessage("XXX", "Fasce tariffarie della tariffa {0} non trovate per il documento {0}", new string[2] { AttivaPassiva, Document.ID });
					}
					else
					{
						decimal val3 = decimal.Multiply(d2: (decimal.Compare(Conversions.ToDecimal(_dtTestataTariffa.Rows[0]["RapportoPV"]), 0m) == 0) ? 1m : Conversions.ToDecimal(_dtTestataTariffa.Rows[0]["RapportoPV"]), d1: Document.Volume);
						decimal num2 = Math.Max(Document.Peso, val3);
						if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
						{
							Document.TassatoAttivo = num2;
							Document.ItemDataRow["TassatoAttivo"] = num2;
						}
						else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
						{
							Document.TassatoPassivo = num2;
							Document.ItemDataRow["TassatoPassivo"] = num2;
						}
						Document.ItemDataTable.AcceptChanges();
						val2 = InitialUpdate(ref rsmess);
						val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
					}
				}
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

	protected virtual FXRETURN InitialUpdate(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			decimal pNumero = default(decimal);
			if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
			{
				pNumero = Conversions.ToDecimal(Document.ItemDataRow["TassatoAttivo"]);
			}
			else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
			{
				pNumero = Conversions.ToDecimal(Document.ItemDataRow["TassatoPassivo"]);
			}
			if (Operators.CompareString(Document.DocumentTable, "", false) != 0)
			{
				text = "UPDATE " + Document.DocumentTable + " ";
				if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
				{
					text = text + "SET TassatoAttivo=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
					text += ",IdRaggruppamentoAttivo=NULL ";
					text = text + ",TipoContrattoAttivoApplicato=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoContrattoApplicato) + " ";
					text += ",ErroreTariffaAttiva=NULL ";
				}
				else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
				{
					text = text + "SET TassatoPassivo=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
					text += ",IdRaggruppamentoPassivo=NULL ";
					text = text + ",TipoContrattoPassivoApplicato=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoContrattoApplicato) + " ";
					text += ",ErroreTariffaPassiva=NULL ";
				}
				if (Document.UpdateDataCompentenzaAttiva && Document.DataCompentenzaAttiva.HasValue)
				{
					text = text + ",DataCompetenzaAttiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Document.DataCompentenzaAttiva.Value);
				}
				if (Document.UpdateDataCompentenzaPassiva && Document.DataCompentenzaPassiva.HasValue)
				{
					text = text + ",DataCompetenzaPassiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Document.DataCompentenzaPassiva.Value);
				}
				text = text + " WHERE " + Document.KeyFieldName + " = " + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID);
				SqlElencoSave.Add(text);
			}
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN ApplicazioneVoci(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Invalid comparison between Unknown and I4
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Invalid comparison between Unknown and I4
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Invalid comparison between Unknown and I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string NoteDiCalcolo = "";
		int[] IdFasceElenco = new int[0];
		decimal num = default(decimal);
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			_dtVociTariffa.DefaultView.Sort = "Voce_FlagNolo DESC";
			_dtVociTariffa = _dtVociTariffa.DefaultView.ToTable();
			if (_dtVociTariffa.Rows.Count > 0 && _NoloRequired && Operators.CompareString(_dtVociTariffa.Rows[0]["Voce_FlagNolo"].ToString(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Voce di nolo non presente");
			}
			else
			{
				decimal QuantitaDaTariffareArrotondata = default(decimal);
				decimal QuantitaTassata = default(decimal);
				decimal ImportoOriginale = default(decimal);
				decimal ImportoArrotondato = default(decimal);
				decimal ImportoUnitario = default(decimal);
				foreach (DataRow row in _dtVociTariffa.Rows)
				{
					if (Operators.CompareString(row["Voce_FlagNolo"].ToString(), "S", false) != 0 && !Document.ItemDataTable.Columns.Contains("IMPORTONOLO"))
					{
						Document.ItemDataTable.Columns.Add("IMPORTONOLO", typeof(decimal));
						Document.ItemDataTable.Rows[0]["IMPORTONOLO"] = num;
					}
					DataRow dataRow2 = Document.ItemDataTable.Rows[0];
					if (!modGeneral.ExistsFieldInDatarow(ref dataRow2, row["CampoCalcolo"].ToString()))
					{
						rsmess = this.TranslateMessage("XXX", "Non esiste il campo di calcolo '{0}' sul documento {1} con id={2}", new string[3]
						{
							row["CampoCalcolo"].ToString(),
							Document.TipoDocumento,
							Document.ID
						});
					}
					else
					{
						decimal num2 = Conversions.ToDecimal(Document.ItemDataTable.Rows[0][row["CampoCalcolo"].ToString()]);
						bool bVoceApplicabile = false;
						val2 = VerificaFranchigiaVoce(row, ref bVoceApplicabile, ref rsmess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (!bVoceApplicabile)
							{
								continue;
							}
							val2 = VerificaApplicabilitaVoce(row, ref bVoceApplicabile, ref rsmess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								if (!bVoceApplicabile)
								{
									continue;
								}
								val2 = CalcoloTariffaFasce(row, num2, ref QuantitaDaTariffareArrotondata, ref QuantitaTassata, ref ImportoOriginale, ref ImportoArrotondato, ref ImportoUnitario, ref NoteDiCalcolo, ref IdFasceElenco, ref rsmess);
								if ((int)val2 <= 0)
								{
									if ((decimal.Compare(ImportoOriginale, 0m) > 0) & (Operators.CompareString(row["Voce_FlagNolo"].ToString(), "S", false) == 0))
									{
										num = decimal.Add(num, ImportoOriginale);
									}
									if (decimal.Compare(ImportoOriginale, 0m) == 0)
									{
										continue;
									}
									CostoRicavo costoRicavo;
									if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
									{
										if (_Ricavi.Contains(row["Voce"].ToString()))
										{
											_Ricavi.Remove(row["Voce"].ToString());
										}
										costoRicavo = new Ricavo();
										costoRicavo.Voce = row["Voce"].ToString();
										_Ricavi.Add((Ricavo)costoRicavo);
									}
									else
									{
										if (_Costi.Contains(row["Voce"].ToString()))
										{
											_Costi.Remove(row["Voce"].ToString());
										}
										costoRicavo = new Costo();
										costoRicavo.Voce = row["Voce"].ToString();
										_Costi.Add((Costo)costoRicavo);
									}
									costoRicavo.IdDocumento = Document.ID;
									costoRicavo.CampoCalcolo = row["CampoCalcolo"].ToString().ToUpper();
									costoRicavo.TipoCalcolo = _TipoCalcolo;
									costoRicavo.RecordZZ = "N";
									if (costoRicavo is Costo)
									{
										((Costo)costoRicavo).Fornitore = _Soggetto;
									}
									costoRicavo.QuantitaOriginale = num2;
									costoRicavo.QuantitaArrotondata = QuantitaDaTariffareArrotondata;
									costoRicavo.QuantitaTassata = QuantitaTassata;
									if (Document.DurataServizioAlNettoDellaFranchigia.HasValue)
									{
										ImportoUnitario = ImportoArrotondato;
										ImportoArrotondato = decimal.Multiply(ImportoArrotondato, new decimal(Document.DurataServizioAlNettoDellaFranchigia.Value));
										costoRicavo.GiorniTassati = Document.DurataServizioAlNettoDellaFranchigia.Value;
									}
									costoRicavo.ImportoUnitario = decimal.Multiply(ImportoUnitario, new decimal(Conversions.ToInteger(row["Voce_TipoVoceSegno"].ToString())));
									costoRicavo.ImportoOriginale = decimal.Multiply(ImportoOriginale, new decimal(Conversions.ToInteger(row["Voce_TipoVoceSegno"].ToString())));
									costoRicavo.ImportoArrotondato = decimal.Multiply(ImportoArrotondato, new decimal(Conversions.ToInteger(row["Voce_TipoVoceSegno"].ToString())));
									costoRicavo.UtenteForzatura = "";
									costoRicavo.IdRaggruppamento = Document.ID;
									costoRicavo.NoteDiCalcolo = NoteDiCalcolo;
									costoRicavo.IdFasceElenco = IdFasceElenco;
									costoRicavo.EstremiTariffa = "Contratto:" + row["Contratto"].ToString() + ";TipoSpedizione:" + row["TipoSpedizione"].ToString() + ";TipoMerce:" + row["TipoMerce"].ToString() + ";";
									CostoRicavo costoRicavo2;
									(costoRicavo2 = costoRicavo).EstremiTariffa = costoRicavo2.EstremiTariffa + "TipoMezzo:" + row["TipoMezzo"].ToString() + ";Cliente:" + row["Cliente"].ToString() + ";GruppoTariffarioPartenza:" + row["GruppoTariffarioPartenza"].ToString() + ";";
									(costoRicavo2 = costoRicavo).EstremiTariffa = costoRicavo2.EstremiTariffa + "PCSPartenza:" + row["PCSPartenza"].ToString() + ";MacroZonaArrivo:" + row["MacroZonaArrivo"].ToString() + ";ZonaArrivo:" + row["ZonaArrivo"].ToString() + ";";
									(costoRicavo2 = costoRicavo).EstremiTariffa = costoRicavo2.EstremiTariffa + "GruppoTariffarioArrivo:" + row["GruppoTariffarioArrivo"].ToString() + ";PCSArrivo:" + row["PCSArrivo"].ToString() + ";Voce:" + row["Voce"].ToString() + ";";
									costoRicavo.FlagNolo = row["Voce_TipoFlagNolo"].ToString();
									if ((Operators.CompareString(costoRicavo.CampoCalcolo, "FORFAIT", false) == 0) | (Operators.CompareString(costoRicavo.CampoCalcolo, "TASSATOATTIVO", false) == 0) | (Operators.CompareString(costoRicavo.CampoCalcolo, "TASSATOPASSIVO", false) == 0))
									{
										costoRicavo.TipoRipartizione = "N";
									}
									else
									{
										costoRicavo.TipoRipartizione = row["TipoRipartizione"].ToString();
									}
									costoRicavo.Riconsegna = row["Voce_Riconsegna"].ToString();
									costoRicavo.Reso = row["Voce_Reso"].ToString();
									continue;
								}
								val = val2;
							}
						}
					}
					goto end_IL_001c;
				}
				val = (FXRETURN)0;
			}
			end_IL_001c:;
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

	protected virtual FXRETURN ArrotondaQuantitaTariffa(decimal Quantita, decimal Soglia, decimal QtaInferiore, decimal QtaSuperiore, ref decimal QuantitaArrotondata, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			decimal num = ((decimal.Compare(Quantita, Soglia) <= 0) ? QtaInferiore : QtaSuperiore);
			decimal num2;
			if (decimal.Compare(num, 0m) == 0)
			{
				num2 = Quantita;
			}
			else
			{
				decimal num3 = decimal.Divide(Quantita, num);
				num2 = ((decimal.Compare(num3, Conversion.Int(num3)) <= 0) ? decimal.Multiply(num, Conversion.Int(num3)) : decimal.Multiply(num, decimal.Add(Conversion.Int(num3), 1m)));
			}
			QuantitaArrotondata = num2;
			val = (FXRETURN)0;
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN ArrotondaValore(decimal dValore, decimal dArrotondamento, ref decimal dValoreArrotondato, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (decimal.Compare(dArrotondamento, 0m) == 0)
			{
				dValoreArrotondato = dValore;
			}
			else
			{
				int value = 5;
				decimal d = decimal.Add(dValore, decimal.Multiply(decimal.Divide(dArrotondamento, 10m), new decimal(value)));
				d = decimal.Multiply(d, decimal.Divide(1m, dArrotondamento));
				d = Conversion.Int(d);
				d = decimal.Multiply(d, dArrotondamento);
				dValoreArrotondato = d;
			}
			val = (FXRETURN)0;
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual decimal ArrotondaValore(decimal dValore, decimal dArrotondamento)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		decimal dValoreArrotondato = default(decimal);
		val = ArrotondaValore(dValore, dArrotondamento, ref dValoreArrotondato, ref rsMess);
		if ((int)val > 0)
		{
			throw new ApplicationException(rsMess);
		}
		return dValoreArrotondato;
	}

	protected virtual FXRETURN CalcoloTariffaFasce(DataRow Voce, decimal QuantitaDaTariffareOriginale, ref decimal QuantitaDaTariffareArrotondata, ref decimal QuantitaTassata, ref decimal ImportoOriginale, ref decimal ImportoArrotondato, ref decimal ImportoUnitario, ref string NoteDiCalcolo, ref int[] IdFasceElenco, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Invalid comparison between Unknown and I4
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataRow[] array = null;
		DataRow dataRow = null;
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			ImportoOriginale = default(decimal);
			ImportoArrotondato = default(decimal);
			QuantitaTassata = default(decimal);
			QuantitaDaTariffareArrotondata = default(decimal);
			ImportoUnitario = default(decimal);
			rsMess = "";
			NoteDiCalcolo = "";
			IdFasceElenco = new int[0];
			text2 = Voce["flgEccedenza"].ToString();
			if (decimal.Compare(QuantitaDaTariffareOriginale, 0m) <= 0)
			{
				goto IL_0d55;
			}
			val2 = ArrotondaQuantitaTariffa(QuantitaDaTariffareOriginale, Conversions.ToDecimal(Voce["ArrCampoCalcoloLimite"]), Conversions.ToDecimal(Voce["ArrCampoCalcolo"]), Conversions.ToDecimal(Voce["ArrCampoCalcoloOltre"]), ref QuantitaDaTariffareArrotondata, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				NoteDiCalcolo = NoteDiCalcolo + "Qta Orig: " + QuantitaDaTariffareOriginale + "; Qta Arrot: " + QuantitaDaTariffareArrotondata + "\r\n";
				switch (text2)
				{
				case "S":
				{
					DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
					string pNumero = Voce["IdVoce"].ToString();
					text = " IdVoce=" + dbConn3.SQLFormatNumber(ref pNumero);
					text = text + " AND FasciaInferiore <= " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref QuantitaDaTariffareArrotondata);
					array = _dtFasceTariffa.Select(text, "FasciaInferiore DESC");
					break;
				}
				case "+":
				{
					DBConnection dbConn4 = ((AppBaseClass)this).DbConn;
					string pNumero = Voce["IdVoce"].ToString();
					text = " IdVoce=" + dbConn4.SQLFormatNumber(ref pNumero);
					text = text + " AND FasciaSuperiore >= " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref QuantitaDaTariffareArrotondata);
					array = _dtFasceTariffa.Select(text, "FasciaSuperiore ASC");
					if (array.Count() >= 2)
					{
						DataRow dataRow5 = array[0];
						DataRow dataRow6 = array[1];
						array = new DataRow[2] { dataRow5, dataRow6 };
					}
					else if (array.Count() == 1)
					{
						DataRow dataRow7 = array[0];
						array = new DataRow[2] { dataRow7, dataRow7 };
					}
					break;
				}
				case "-":
				{
					DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
					string pNumero = Voce["IdVoce"].ToString();
					text = " IdVoce=" + dbConn2.SQLFormatNumber(ref pNumero);
					text = text + " AND FasciaInferiore <= " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref QuantitaDaTariffareArrotondata);
					array = _dtFasceTariffa.Select(text, "FasciaInferiore DESC");
					if (array.Count() >= 2)
					{
						DataRow dataRow2 = array[0];
						DataRow dataRow3 = array[1];
						array = new DataRow[2] { dataRow2, dataRow3 };
					}
					else if (array.Count() == 1)
					{
						DataRow dataRow4 = array[0];
						array = new DataRow[2] { dataRow4, dataRow4 };
					}
					break;
				}
				default:
				{
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					string pNumero = Voce["IdVoce"].ToString();
					text = " IdVoce=" + dbConn.SQLFormatNumber(ref pNumero);
					text = text + " AND FasciaInferiore < " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref QuantitaDaTariffareArrotondata);
					text = text + " AND FasciaSuperiore >= " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref QuantitaDaTariffareArrotondata);
					array = _dtFasceTariffa.Select(text);
					break;
				}
				}
				if (array.Count() == 0)
				{
					rsMess = this.TranslateMessage("XXX", "Fascia tariffaria non definita per il documento con id='{0}'", new string[1] { Document.ID });
				}
				else
				{
					int i = 1;
					decimal num = default(decimal);
					decimal d = default(decimal);
					decimal d2 = default(decimal);
					decimal d3 = default(decimal);
					decimal num2 = default(decimal);
					decimal num3 = default(decimal);
					decimal num4 = default(decimal);
					decimal num5 = default(decimal);
					decimal num6 = default(decimal);
					decimal num7 = default(decimal);
					decimal d4 = QuantitaDaTariffareOriginale;
					DataRow[] array2 = array;
					checked
					{
						for (int j = 0; j < array2.Length; i++, j++)
						{
							dataRow = array2[j];
							QuantitaTassata = default(decimal);
							decimal num8;
							switch (text2)
							{
							case "S":
								num8 = decimal.Subtract(d4, Conversions.ToDecimal(dataRow["FasciaInferiore"]));
								d4 = Conversions.ToDecimal(dataRow["FasciaInferiore"]);
								break;
							case "+":
								num8 = ((i != 1) ? ((decimal.Compare(Conversions.ToDecimal(dataRow["FasciaInferiore"]), QuantitaDaTariffareArrotondata) < 0) ? QuantitaDaTariffareArrotondata : Conversions.ToDecimal(dataRow["FasciaInferiore"])) : QuantitaDaTariffareArrotondata);
								break;
							case "-":
								if (i == 1)
								{
									num8 = QuantitaDaTariffareArrotondata;
									break;
								}
								num8 = QuantitaDaTariffareArrotondata;
								num8 = ((decimal.Compare(Conversions.ToDecimal(dataRow["FasciaSuperiore"]), QuantitaDaTariffareArrotondata) > 0) ? QuantitaDaTariffareArrotondata : Conversions.ToDecimal(dataRow["FasciaSuperiore"]));
								break;
							default:
								num8 = QuantitaDaTariffareArrotondata;
								if (((decimal.Compare(Conversions.ToDecimal(dataRow["Fisso"]), 0m) != 0) & (decimal.Compare(Conversions.ToDecimal(dataRow["Variabile"]), 0m) != 0)) | ((decimal.Compare(Conversions.ToDecimal(dataRow["Fisso"]), 0m) != 0) & (decimal.Compare(Conversions.ToDecimal(dataRow["Percentuale"]), 0m) != 0)))
								{
									num8 = decimal.Subtract(num8, Conversions.ToDecimal(dataRow["FasciaInferiore"]));
								}
								break;
							}
							decimal num9 = default(decimal);
							decimal num10 = default(decimal);
							decimal num11 = default(decimal);
							IdFasceElenco = (int[])Utils.CopyArray((Array)IdFasceElenco, (Array)new int[IdFasceElenco.Count() + 1]);
							IdFasceElenco[IdFasceElenco.Count() - 1] = Conversions.ToInteger(dataRow["IdFascia"]);
							NoteDiCalcolo = NoteDiCalcolo + "IdFascia: " + Conversions.ToString(IdFasceElenco[IdFasceElenco.Count() - 1]) + "(" + dataRow["FasciaInferiore"].ToString() + "-" + dataRow["FasciaSuperiore"].ToString() + ")\r\n";
							if (decimal.Compare(Conversions.ToDecimal(dataRow["Fisso"]), 0m) != 0)
							{
								num9 = Math.Round(Conversions.ToDecimal(dataRow["Fisso"]), 5);
								if (decimal.Compare(Conversions.ToDecimal(dataRow["FasciaSuperiore"]), 999999999m) != 0)
								{
									QuantitaTassata = Conversions.ToDecimal(dataRow["FasciaSuperiore"]);
								}
								else
								{
									QuantitaTassata = num8;
								}
								NoteDiCalcolo = NoteDiCalcolo + "Fisso: " + Conversions.ToString(num9) + "; QtaTassata: " + Conversions.ToString(QuantitaTassata) + "\r\n";
							}
							if (decimal.Compare(Conversions.ToDecimal(dataRow["Variabile"]), 0m) != 0)
							{
								num10 = Math.Round(decimal.Multiply(Conversions.ToDecimal(dataRow["Variabile"]), num8), 5);
								QuantitaTassata = num8;
								NoteDiCalcolo = NoteDiCalcolo + "Var: " + dataRow["Variabile"].ToString() + "*" + num8 + "=" + Conversions.ToString(num10) + "; QtaTassata: " + Conversions.ToString(QuantitaTassata) + "\r\n";
							}
							if (decimal.Compare(Conversions.ToDecimal(dataRow["Percentuale"]), 0m) != 0)
							{
								num11 = Math.Round(decimal.Multiply(decimal.Divide(Conversions.ToDecimal(dataRow["Percentuale"]), 100m), num8), 5);
								QuantitaTassata = num8;
								NoteDiCalcolo = NoteDiCalcolo + "Perc: " + dataRow["Percentuale"].ToString() + "/100 *" + num8 + "=" + Conversions.ToString(num11) + "; QtaTassata: " + Conversions.ToString(QuantitaTassata) + "\r\n";
							}
							if (Operators.CompareString(text2, "S", false) == 0)
							{
								ImportoOriginale = decimal.Add(decimal.Add(decimal.Add(ImportoOriginale, num9), num10), num11);
								NoteDiCalcolo = NoteDiCalcolo + "ImpOriginale=ImpOriginale+ImpFisso+ImpVariabile+ImpPercentuale=" + ImportoOriginale + "\r\n";
								continue;
							}
							if ((Operators.CompareString(text2, "+", false) == 0) | (Operators.CompareString(text2, "-", false) == 0))
							{
								switch (i)
								{
								case 1:
									d = num9;
									d2 = num10;
									d3 = num11;
									num = decimal.Add(decimal.Add(num9, num10), num11);
									num6 = QuantitaTassata;
									NoteDiCalcolo = NoteDiCalcolo + "ImpOriginaleC1=ImpFisso+ImpVariabile+ImpPercentuale=" + num + "\r\n";
									continue;
								case 2:
									break;
								default:
									continue;
								}
								num3 = num9;
								num4 = num10;
								num5 = num11;
								num2 = decimal.Add(decimal.Add(num9, num10), num11);
								num7 = QuantitaTassata;
								if (Operators.CompareString(text2, "+", false) == 0)
								{
									if (decimal.Compare(num, num2) <= 0)
									{
										ImportoOriginale = num;
										QuantitaTassata = num6;
									}
									else
									{
										ImportoOriginale = num2;
										QuantitaTassata = num7;
									}
									NoteDiCalcolo = NoteDiCalcolo + "ImpOriginaleC2=ImpFisso+ImpVariabile+ImpPercentuale=" + num2 + "\r\n";
									NoteDiCalcolo = NoteDiCalcolo + "ImpOriginale=MIN(ImpOriginaleC1,ImpOriginaleC2)=" + ImportoOriginale + "\r\n";
								}
								else if ((decimal.Compare(d, 0m) > 0) & (decimal.Compare(d2, 0m) == 0) & (decimal.Compare(d3, 0m) == 0))
								{
									ImportoOriginale = num;
									QuantitaTassata = num6;
									NoteDiCalcolo = NoteDiCalcolo + "ImpOriginaleC2=ImpFisso+ImpVariabile+ImpPercentuale=" + num2 + "\r\n";
									NoteDiCalcolo = NoteDiCalcolo + "ImpOriginale=FIX(ImpOriginaleC1,ImpOriginaleC2)=" + ImportoOriginale + "\r\n";
								}
								else
								{
									if (decimal.Compare(num, num2) >= 0)
									{
										ImportoOriginale = num;
										QuantitaTassata = num6;
									}
									else
									{
										ImportoOriginale = num2;
										QuantitaTassata = num7;
									}
									NoteDiCalcolo = NoteDiCalcolo + "ImpOriginaleC2=ImpFisso+ImpVariabile+ImpPercentuale=" + num2 + "\r\n";
									NoteDiCalcolo = NoteDiCalcolo + "ImpOriginale=MAX(ImpOriginaleC1,ImpOriginaleC2)=" + ImportoOriginale + "\r\n";
								}
								break;
							}
							ImportoOriginale = decimal.Add(decimal.Add(num9, num10), num11);
							NoteDiCalcolo = NoteDiCalcolo + "ImpOriginale=ImpFisso+ImpVariabile+ImpPercentuale=" + ImportoOriginale + "\r\n";
						}
						val2 = ArrotondaValore(ImportoOriginale, Conversions.ToDecimal(Voce["ArrImporto"]), ref ImportoArrotondato, ref rsMess);
					}
					if ((int)val2 <= 0)
					{
						NoteDiCalcolo = NoteDiCalcolo + "ImpArrotondato: " + ImportoArrotondato + "\r\n";
						if (Operators.CompareString(text2, "S", false) == 0)
						{
							if (decimal.Compare(QuantitaDaTariffareArrotondata, 0m) != 0)
							{
								ImportoUnitario = decimal.Divide(ImportoArrotondato, QuantitaDaTariffareArrotondata);
							}
						}
						else if (decimal.Compare(QuantitaTassata, 0m) != 0)
						{
							ImportoUnitario = decimal.Divide(ImportoArrotondato, QuantitaTassata);
						}
						NoteDiCalcolo = NoteDiCalcolo + "ImpUnitario=ImpArrotondato/QtaTassata=" + ImportoUnitario + "\r\n";
						goto IL_0d55;
					}
					val = val2;
				}
			}
			goto end_IL_0018;
			IL_0d55:
			val = (FXRETURN)0;
			end_IL_0018:;
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN VerificaApplicabilitaVoce(DataRow Voce, ref bool bVoceApplicabile, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Invalid comparison between Unknown and I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			bVoceApplicabile = false;
			string text2 = Voce["Voce_Applicabilita"].ToString();
			string text3 = Voce["VoceApplicabilita_Descrizione"].ToString();
			string text4 = Voce["VoceApplicabilita_Tabella"].ToString();
			string text5 = Voce["VoceApplicabilita_Campo"].ToString();
			string tipoDato = Voce["VoceApplicabilita_TipoCampo"].ToString();
			string operatore = Voce["VoceApplicabilita_Operatore"].ToString();
			string valore = Voce["VoceApplicabilita_Valore"].ToString();
			string text6 = Voce["VoceApplicabilita_Tipo"].ToString();
			if (Operators.CompareString(text2, "", false) != 0)
			{
				List<TransportDocument> list = new List<TransportDocument>(Document.SubDocuments);
				if (list.Count == 0)
				{
					list.Add(Document);
				}
				bool CondizioneOk = default(bool);
				foreach (TransportDocument item in list)
				{
					if (Operators.CompareString(text6, "1", false) == 0)
					{
						bVoceApplicabile = true;
					}
					else
					{
						bVoceApplicabile = false;
					}
					DataRow dataRow = item.ItemDataTable.Rows[0];
					if (!modGeneral.ExistsFieldInDatarow(ref dataRow, text5))
					{
						rsMess = this.TranslateMessage("XXX", "Non esiste il campo '{0}' sul documento {1} con id={2}. Impossibile procedere alla verifica dell'applicabilità '{3}' per la voce '{4}'", new string[5]
						{
							text5,
							Document.TipoDocumento,
							Document.ID,
							text3,
							Voce["Voce"].ToString()
						});
					}
					else
					{
						val2 = VerificaCondizioneAppilicabilita(RuntimeHelpers.GetObjectValue(item.ItemDataTable.Rows[0][text5]), valore, tipoDato, operatore, ref CondizioneOk, ref rsMess);
						if ((int)val2 <= 0)
						{
							if (Operators.CompareString(text6, "1", false) == 0)
							{
								bVoceApplicabile &= CondizioneOk;
								if (!bVoceApplicabile)
								{
									break;
								}
							}
							else
							{
								bVoceApplicabile |= CondizioneOk;
							}
							continue;
						}
						val = val2;
					}
					goto end_IL_000b;
				}
			}
			else
			{
				bVoceApplicabile = true;
			}
			val = (FXRETURN)0;
			end_IL_000b:;
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN VerificaFranchigiaVoce(DataRow Voce, ref bool bVoceApplicabile, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			bVoceApplicabile = false;
			if (Voce.Table.Columns.Contains(""))
			{
				if (Operators.CompareString(Voce["Franchigia"].ToString(), "", false) == 0)
				{
					if (!Document.DurataServizio.HasValue)
					{
						bVoceApplicabile = true;
					}
					else if (Conversions.ToInteger(Voce["Franchigia"]) < Document.DurataServizio.Value)
					{
						Document.DurataServizioAlNettoDellaFranchigia = checked(Document.DurataServizio.Value - Conversions.ToInteger(Voce["Franchigia"]));
						bVoceApplicabile = true;
					}
					else
					{
						bVoceApplicabile = false;
					}
				}
				else
				{
					bVoceApplicabile = true;
				}
			}
			else
			{
				bVoceApplicabile = true;
			}
			val = (FXRETURN)0;
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN VerificaCondizioneAppilicabilita(object Valore1, object Valore2, string TipoDato, string Operatore, ref bool CondizioneOk, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Invalid comparison between Unknown and I4
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			bool flag = default(bool);
			if (Operators.CompareString(Operatore, "IS NULL", false) == 0)
			{
				flag = Operators.CompareString(Valore1.ToString(), "", false) == 0;
				goto IL_07a6;
			}
			if (Operators.CompareString(Operatore, "IS NOT NULL", false) == 0)
			{
				flag = Operators.CompareString(Valore1.ToString(), "", false) != 0;
				goto IL_07a6;
			}
			text = "SELECT '1' ";
			if (((AppBaseClass)this).DbConn.ServerType == DBFormatFunctions.eServerType.Oracle)
			{
				text += " FROM DUAL ";
			}
			text += " WHERE ";
			switch (TipoDato)
			{
			case "C":
				text = ((!((Operators.CompareString(Operatore, "=", false) == 0) | (Operators.CompareString(Operatore, ">", false) == 0) | (Operators.CompareString(Operatore, ">=", false) == 0) | (Operators.CompareString(Operatore, "<=", false) == 0) | (Operators.CompareString(Operatore, "<", false) == 0) | (Operators.CompareString(Operatore, "<>", false) == 0))) ? ((!((Operators.CompareString(Operatore, "IN", false) == 0) | (Operators.CompareString(Operatore, "NOT IN", false) == 0))) ? ((!((Operators.CompareString(Operatore, "LIKE", false) == 0) | (Operators.CompareString(Operatore, "NOT LIKE", false) == 0))) ? (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatString(Valore2.ToString())) : (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatString("%" + Valore2.ToString() + "%"))) : (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " (" + Valore2.ToString() + ")")) : (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatString(Valore2.ToString())));
				break;
			case "N":
				Valore1 = Conversions.ToDecimal(Valore1);
				Valore2 = Conversions.ToDecimal(Valore2);
				if ((Operators.CompareString(Operatore, "=", false) == 0) | (Operators.CompareString(Operatore, ">", false) == 0) | (Operators.CompareString(Operatore, ">=", false) == 0) | (Operators.CompareString(Operatore, "<=", false) == 0) | (Operators.CompareString(Operatore, "<", false) == 0) | (Operators.CompareString(Operatore, "<>", false) == 0))
				{
					string[] obj = new string[6] { text, null, null, null, null, null };
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					string pNumero = Valore1.ToString();
					obj[1] = dbConn.SQLFormatNumber(ref pNumero);
					obj[2] = " ";
					obj[3] = Operatore;
					obj[4] = " ";
					DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
					pNumero = Valore2.ToString();
					obj[5] = dbConn2.SQLFormatNumber(ref pNumero);
					text = string.Concat(obj);
				}
				else if ((Operators.CompareString(Operatore, "IN", false) == 0) | (Operators.CompareString(Operatore, "NOT IN", false) == 0))
				{
					string[] obj2 = new string[7] { text, null, null, null, null, null, null };
					DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
					string pNumero = Valore1.ToString();
					obj2[1] = dbConn3.SQLFormatNumber(ref pNumero);
					obj2[2] = " ";
					obj2[3] = Operatore;
					obj2[4] = " (";
					obj2[5] = Valore2.ToString();
					obj2[6] = ")";
					text = string.Concat(obj2);
				}
				else
				{
					text = ((!((Operators.CompareString(Operatore, "LIKE", false) == 0) | (Operators.CompareString(Operatore, "NOT LIKE", false) == 0))) ? (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatString(Valore2.ToString())) : (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatString("%" + Valore2.ToString() + "%")));
				}
				break;
			case "D":
				text = ((!((Operators.CompareString(Operatore, "=", false) == 0) | (Operators.CompareString(Operatore, ">", false) == 0) | (Operators.CompareString(Operatore, ">=", false) == 0) | (Operators.CompareString(Operatore, "<=", false) == 0) | (Operators.CompareString(Operatore, "<", false) == 0) | (Operators.CompareString(Operatore, "<>", false) == 0))) ? ((!((Operators.CompareString(Operatore, "IN", false) == 0) | (Operators.CompareString(Operatore, "NOT IN", false) == 0))) ? ((!((Operators.CompareString(Operatore, "LIKE", false) == 0) | (Operators.CompareString(Operatore, "NOT LIKE", false) == 0))) ? (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatString(Valore2.ToString())) : (text + ((AppBaseClass)this).DbConn.SQLFormatString(Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatString("%" + Valore2.ToString() + "%"))) : (text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Valore1.ToString()) + " " + Operatore + " (" + Valore2.ToString() + ")")) : (text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Valore1.ToString()) + " " + Operatore + " " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Valore2.ToString())));
				break;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_07a6;
			}
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(text, "0", ref objRes, ref rsMess);
			if ((int)val <= 0)
			{
				flag = Operators.CompareString(objRes.ToString(), "1", false) == 0;
				goto IL_07a6;
			}
			val2 = val;
			goto end_IL_000c;
			IL_07a6:
			CondizioneOk = flag;
			val2 = (FXRETURN)0;
			end_IL_000c:;
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

	protected virtual FXRETURN BeforeSave(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			CostiRicavi costiRicavi = ((_TipoTariffaEngine != 0) ? ((CostiRicavi)_Costi) : ((CostiRicavi)_Ricavi));
			text = "DELETE FROM " + costiRicavi.TableName + " ";
			text = text + "WHERE " + _TableCostiRicaviKeyName + " = " + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + " ";
			text += " AND UtenteForzatura IS NULL";
			AddQueryToApply(text);
			foreach (CostoRicavo item in costiRicavi)
			{
				if (Operators.CompareString(item.StatoRecord, "I", false) == 0 && decimal.Compare(item.ImportoArrotondato, 0m) > 0)
				{
					string text2 = "";
					text2 = Document.ID;
					text = "INSERT INTO " + costiRicavi.TableName + " (";
					text = text + _TableCostiRicaviKeyName + ",Voce,TipoCalcolo,CampoCalcolo,";
					if (costiRicavi is Costi)
					{
						text = text + ((Costi)costiRicavi).FornitoreFieldName + ",";
					}
					text += "QuantitaOriginale,QuantitaArrotondata,QuantitaTassata,";
					text += "ImportoOriginale,ImportoArrotondato,ImportoUnitario,";
					if (Document.DurataServizioAlNettoDellaFranchigia.HasValue)
					{
						text += "GiorniTassati,";
					}
					text += "IdRaggruppamento,EstremiTariffa,Note,";
					text += "DatIns,UteIns,DatAgg,UteAgg) SELECT ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.Voce) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.TipoCalcolo) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.CampoCalcolo) + ", ";
					if (costiRicavi is Costi)
					{
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((Costo)item).Fornitore) + ", ";
					}
					string text3 = text;
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					CostoRicavo costoRicavo;
					decimal pNumero = (costoRicavo = item).QuantitaOriginale;
					string text4 = dbConn.SQLFormatNumber(ref pNumero);
					costoRicavo.QuantitaOriginale = pNumero;
					text = text3 + text4 + ", ";
					string text5 = text;
					DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
					pNumero = (costoRicavo = item).QuantitaArrotondata;
					string text6 = dbConn2.SQLFormatNumber(ref pNumero);
					costoRicavo.QuantitaArrotondata = pNumero;
					text = text5 + text6 + ", ";
					string text7 = text;
					DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
					pNumero = (costoRicavo = item).QuantitaTassata;
					string text8 = dbConn3.SQLFormatNumber(ref pNumero);
					costoRicavo.QuantitaTassata = pNumero;
					text = text7 + text8 + ", ";
					string text9 = text;
					DBConnection dbConn4 = ((AppBaseClass)this).DbConn;
					pNumero = (costoRicavo = item).ImportoOriginale;
					string text10 = dbConn4.SQLFormatNumber(ref pNumero);
					costoRicavo.ImportoOriginale = pNumero;
					text = text9 + text10 + ", ";
					string text11 = text;
					DBConnection dbConn5 = ((AppBaseClass)this).DbConn;
					pNumero = ArrotondaValore(item.ImportoArrotondato, _Arrotondamento);
					text = text11 + dbConn5.SQLFormatNumber(ref pNumero) + ", ";
					string text12 = text;
					DBConnection dbConn6 = ((AppBaseClass)this).DbConn;
					pNumero = (costoRicavo = item).ImportoUnitario;
					string text13 = dbConn6.SQLFormatNumber(ref pNumero);
					costoRicavo.ImportoUnitario = pNumero;
					text = text12 + text13 + ", ";
					if (Document.DurataServizioAlNettoDellaFranchigia.HasValue)
					{
						string text14 = text;
						DBConnection dbConn7 = ((AppBaseClass)this).DbConn;
						int? pNumero2 = (costoRicavo = item).GiorniTassati;
						string text15 = dbConn7.SQLFormatNumber(ref pNumero2);
						costoRicavo.GiorniTassati = pNumero2;
						text = text14 + text15 + ", ";
					}
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.IdRaggruppamento) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.EstremiTariffa) + ", ";
					text = text + Strings.Replace(((AppBaseClass)this).DbConn.SQLFormatString(Strings.Left(item.NoteDiCalcolo, 512)), "\r\n", "' %+% %CHAR%(13) %+% %CHAR%(10) %+% '", 1, -1, (CompareMethod)0) + ", ";
					text = text + "GETDATE(), " + ((AppBaseClass)this).DbConn.SQLFormatString(base._User) + ", ";
					text = text + "GETDATE(), " + ((AppBaseClass)this).DbConn.SQLFormatString(base._User) + " ";
					text = text + ((AppBaseClass)this).DbConn.FromDual() + " ";
					text = text + "WHERE NOT EXISTS (SELECT 1 FROM " + costiRicavi.TableName + " WHERE " + _TableCostiRicaviKeyName + "=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + " ";
					text = text + "AND Voce=" + ((AppBaseClass)this).DbConn.SQLFormatString(item.Voce) + " ";
					if (costiRicavi is Costi)
					{
						text = text + "AND " + ((Costi)costiRicavi).FornitoreFieldName + "=" + ((AppBaseClass)this).DbConn.SQLFormatString(((Costo)item).Fornitore) + " ";
					}
					text += ")";
					text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
					AddQueryToApply(text);
				}
			}
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected void AddQueryToApply(string ssql)
	{
		if (!_SimulationMode)
		{
			SqlElencoSave.Add(ssql);
		}
	}

	protected virtual FXRETURN Save(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			if (TransactionManage)
			{
				((AppBaseClass)this).DbConn.BeginTransaction();
			}
			StringEnumerator enumerator = SqlElencoSave.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				text = text + current + ";\r\n";
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_0094;
			}
			val2 = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val2 <= 0)
			{
				goto IL_0094;
			}
			val = val2;
			goto end_IL_000b;
			IL_0094:
			val = (FXRETURN)0;
			end_IL_000b:;
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
			if ((int)val > 0 && TransactionManage)
			{
				((AppBaseClass)this).DbConn.RollbackTransaction();
			}
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN AfterSave(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			if (TransactionManage)
			{
				((AppBaseClass)this).DbConn.CommitTransaction();
			}
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN CancellaCostiRicavi(CancellazioneCostiRicaviModalita Modalita, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Run(ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Invalid comparison between Unknown and I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Invalid comparison between Unknown and I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Warning = "";
			val2 = BeforeInit(ref rsmess);
			bool ContrattoTrovato = default(bool);
			bool TariffaTrovata = default(bool);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = InitEngine(ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = AfterInit(ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = BeforeCalc(ref rsmess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else if (((_TipoTariffaEngine == TipoTariffeEngine.Attiva) & Document.CalcolaTariffaAttiva) | ((_TipoTariffaEngine == TipoTariffeEngine.Passiva) & Document.CalcolaTariffaPassiva))
						{
							if (Operators.CompareString(_Soggetto, "", false) != 0)
							{
								bool CanCalculate = default(bool);
								val2 = Check(ref CanCalculate, ref rsmess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else
								{
									if (!CanCalculate)
									{
										Warning = rsmess;
										rsmess = "";
										goto IL_028a;
									}
									val2 = SearchContract(ref ContrattoTrovato, ref rsmess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else
									{
										if (!ContrattoTrovato)
										{
											goto IL_013a;
										}
										val2 = Search(ref TariffaTrovata, ref rsmess);
										if ((int)val2 <= 0)
										{
											goto IL_013a;
										}
										val = val2;
									}
								}
							}
							else
							{
								val2 = CancellaCostiRicavi(CancellazioneCostiRicaviModalita.AssenzaDelSoggetto, ref rsmess);
								if ((int)val2 <= 0)
								{
									goto IL_028a;
								}
								val = val2;
							}
						}
						else
						{
							if (!(((_TipoTariffaEngine == TipoTariffeEngine.Attiva) & Document.CancellaRicavi) | ((_TipoTariffaEngine == TipoTariffeEngine.Passiva) & Document.CancellaCosti)))
							{
								goto IL_028a;
							}
							val2 = CancellaCostiRicavi((Operators.CompareString(_Soggetto, "", false) == 0) ? CancellazioneCostiRicaviModalita.AssenzaDelSoggetto : CancellazioneCostiRicaviModalita.Tutti, ref rsmess);
							if ((int)val2 <= 0)
							{
								goto IL_028a;
							}
							val = val2;
						}
					}
				}
			}
			goto end_IL_0005;
			IL_013a:
			if (!(TariffaTrovata && ContrattoTrovato))
			{
				string rsmess2 = "";
				val2 = CancellaCostiRicavi(CancellazioneCostiRicaviModalita.SoloCalcolati, ref rsmess2);
				if ((int)val2 <= 0)
				{
					Warning = rsmess;
					rsmess = "";
					goto IL_028a;
				}
				val = val2;
				rsmess = rsmess + "\r\n" + rsmess2;
			}
			else
			{
				val2 = ApplicazioneVoci(ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = BeforeSave(ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = Save(ref rsmess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							val2 = AfterSave(ref rsmess);
							if ((int)val2 <= 0)
							{
								goto IL_028a;
							}
							val = val2;
						}
					}
				}
			}
			goto end_IL_0005;
			IL_028a:
			val2 = AfterCalc(ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			end_IL_0005:;
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
			try
			{
				FXRETURN calcResult = val;
				string errorMessage = rsmess;
				string warningMessage = Warning;
				string rsmess3 = "";
				OnCalcExit(calcResult, errorMessage, warningMessage, ref rsmess3);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			this.CallStackRemove();
			result = val;
		}
		return result;
	}
}
