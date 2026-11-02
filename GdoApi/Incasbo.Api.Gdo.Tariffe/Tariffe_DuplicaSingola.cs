using System;
using System.Data;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Tariffe_DuplicaSingola : AppAbstractApi
{
	protected string _IdTariffa;

	protected string _AttivaPassiva;

	protected DataTable _dtTariffaPartenza;

	protected string _Contratto;

	protected string _TipoDocumento;

	protected string _TipoSpedizione;

	protected string _TipoMerce;

	protected string _TipoMezzo;

	protected string _Cliente;

	protected string _GruppoTariffarioPartenza;

	protected string _PCSPartenza;

	protected string _MacroZonaArrivo;

	protected string _ZonaArrivo;

	protected string _GruppoTariffarioArrivo;

	protected string _PCSArrivo;

	protected string _ViewFasceTariffa;

	protected string _ViewVociTariffa;

	protected string _ViewTestataTariffa;

	protected string _CounterFasceTariffa;

	protected string _CounterVociTariffa;

	protected string _CounterTestataTariffa;

	protected const string _STAR_ALL = "*ALL";

	public Tariffe_DuplicaSingola(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdTariffa = "";
		_AttivaPassiva = "";
		_dtTariffaPartenza = null;
		_Contratto = "";
		_TipoDocumento = "";
		_TipoSpedizione = "";
		_TipoMerce = "";
		_TipoMezzo = "";
		_Cliente = "";
		_GruppoTariffarioPartenza = "";
		_PCSPartenza = "";
		_MacroZonaArrivo = "";
		_ZonaArrivo = "";
		_GruppoTariffarioArrivo = "";
		_PCSArrivo = "";
		_ViewFasceTariffa = "";
		_ViewVociTariffa = "";
		_ViewTestataTariffa = "";
		_CounterFasceTariffa = "";
		_CounterVociTariffa = "";
		_CounterTestataTariffa = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Invalid comparison between Unknown and I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdTariffa = base._ParametersIn["IdTariffa"].ToString();
			_AttivaPassiva = base._ParametersIn["AttivaPassiva"].ToString();
			_Contratto = base._ParametersIn["Contratto"].ToString();
			val = CheckContratti(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_TipoDocumento = base._ParametersIn["TipoDocumento"].ToString();
				if (Operators.CompareString(_TipoDocumento, "", false) == 0)
				{
					_TipoDocumento = _dtTariffaPartenza.Rows[0]["TipoDocumento"].ToString();
				}
				_TipoSpedizione = base._ParametersIn["TipoSpedizione"].ToString();
				if (Operators.CompareString(_TipoSpedizione, "", false) == 0)
				{
					_TipoSpedizione = _dtTariffaPartenza.Rows[0]["TipoSpedizione"].ToString();
				}
				_TipoMerce = base._ParametersIn["TipoMerce"].ToString();
				if (Operators.CompareString(_TipoMerce, "", false) == 0)
				{
					_TipoMerce = _dtTariffaPartenza.Rows[0]["TipoMerce"].ToString();
				}
				_TipoMezzo = base._ParametersIn["TipoMezzo"].ToString();
				if (Operators.CompareString(_TipoMezzo, "", false) == 0)
				{
					_TipoMezzo = _dtTariffaPartenza.Rows[0]["TipoMezzo"].ToString();
				}
				_Cliente = base._ParametersIn["Cliente"].ToString();
				if (Operators.CompareString(_Cliente, "", false) == 0)
				{
					_Cliente = _dtTariffaPartenza.Rows[0]["Cliente"].ToString();
				}
				_GruppoTariffarioPartenza = base._ParametersIn["GruppoTariffarioPartenza"].ToString();
				if (Operators.CompareString(_GruppoTariffarioPartenza, "", false) == 0)
				{
					_GruppoTariffarioPartenza = _dtTariffaPartenza.Rows[0]["GruppoTariffarioPartenza"].ToString();
				}
				_PCSPartenza = base._ParametersIn["PCSPartenza"].ToString();
				if (Operators.CompareString(_PCSPartenza, "", false) == 0)
				{
					_PCSPartenza = _dtTariffaPartenza.Rows[0]["PCSPartenza"].ToString();
				}
				_MacroZonaArrivo = base._ParametersIn["MacroZonaArrivo"].ToString();
				if (Operators.CompareString(_MacroZonaArrivo, "", false) == 0)
				{
					_MacroZonaArrivo = _dtTariffaPartenza.Rows[0]["MacroZonaArrivo"].ToString();
				}
				_ZonaArrivo = base._ParametersIn["ZonaArrivo"].ToString();
				if (Operators.CompareString(_ZonaArrivo, "", false) == 0)
				{
					_ZonaArrivo = _dtTariffaPartenza.Rows[0]["ZonaArrivo"].ToString();
				}
				_GruppoTariffarioArrivo = base._ParametersIn["GruppoTariffarioArrivo"].ToString();
				if (Operators.CompareString(_GruppoTariffarioArrivo, "", false) == 0)
				{
					_GruppoTariffarioArrivo = _dtTariffaPartenza.Rows[0]["GruppoTariffarioArrivo"].ToString();
				}
				_PCSArrivo = base._ParametersIn["PCSArrivo"].ToString();
				if (Operators.CompareString(_PCSArrivo, "", false) == 0)
				{
					_PCSArrivo = _dtTariffaPartenza.Rows[0]["PCSArrivo"].ToString();
				}
				val = CheckDuplicazione(ref rsmess);
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
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = DuplicaTariffa(ref rsmess);
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string IdTariffa, string AttivaPassiva, string Contratto, string TipoDocumento, string TipoSpedizione, string TipoMerce, string TipoMezzo, string Cliente, string GruppoTariffarioPartenza, string PCSPartenza, string MacroZonaArrivo, string ZonaArrivo, string GruppoTariffarioArrivo, string PCSArrivo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Invalid comparison between Unknown and I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Tariffe_DuplicaSingola tariffe_DuplicaSingola = new Tariffe_DuplicaSingola(objApiContext);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("IdTariffa", IdTariffa);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("AttivaPassiva", AttivaPassiva);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("Contratto", Contratto);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("TipoSpedizione", TipoSpedizione);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("TipoMerce", TipoMerce);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("TipoMezzo", TipoMezzo);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("GruppoTariffarioPartenza", GruppoTariffarioPartenza);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("PCSPartenza", PCSPartenza);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("MacroZonaArrivo", MacroZonaArrivo);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("ZonaArrivo", ZonaArrivo);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("GruppoTariffarioArrivo", GruppoTariffarioArrivo);
			((AppAbstractApi)tariffe_DuplicaSingola).ParametersIn.Add("PCSArrivo", PCSArrivo);
			val = ((AppAbstractApi)tariffe_DuplicaSingola).Run(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	private FXRETURN CheckContratti(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_AttivaPassiva, "A", false) == 0)
			{
				_ViewTestataTariffa = "TariffeAttiveTestata";
				_ViewVociTariffa = "TariffeAttiveVoci";
				_ViewFasceTariffa = "TariffeAttiveFasce";
				_CounterTestataTariffa = "COUNTERS.TRA.TARIFFEATTIVE.TESTATA";
				_CounterVociTariffa = "COUNTERS.TRA.TARIFFEATTIVE.VOCI";
				_CounterFasceTariffa = "COUNTERS.TRA.TARIFFEATTIVE.FASCE";
			}
			else
			{
				_ViewTestataTariffa = "TariffePassiveTestata";
				_ViewVociTariffa = "TariffePassiveVoci";
				_ViewFasceTariffa = "TariffePassiveFasce";
				_CounterTestataTariffa = "COUNTERS.TRA.TARIFFEPASSIVE.TESTATA";
				_CounterVociTariffa = "COUNTERS.TRA.TARIFFEPASSIVE.VOCI";
				_CounterFasceTariffa = "COUNTERS.TRA.TARIFFEPASSIVE.FASCE";
			}
			text = "SELECT T.*, C.ATTIVAPASSIVA,C.CONTRATTOTRASPORTO,C.CONTRATTOGIACENZA,C.ATTIVO FROM " + _ViewTestataTariffa + " T INNER JOIN TARIFFECONTRATTI C ON C.CODICE = T.CONTRATTO ";
			text = text + "WHERE IDTARIFFA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdTariffa);
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtTariffaPartenza, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (_dtTariffaPartenza.Rows.Count == 0)
			{
				rsMess = this.TranslateMessage("XXX", "Tariffa con Id {0} non trovata", new string[1] { _IdTariffa });
			}
			else
			{
				text = "SELECT ATTIVAPASSIVA,CONTRATTOTRASPORTO,CONTRATTOGIACENZA,ATTIVO FROM TARIFFECONTRATTI WHERE CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Contratto);
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = this.TranslateMessage("XXX", "Contratto con codice {0} non trovato", new string[1] { _Contratto });
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["CONTRATTOTRASPORTO"].ToString(), _dtTariffaPartenza.Rows[0]["CONTRATTOTRASPORTO"].ToString(), false) != 0)
				{
					rsMess = this.TranslateMessage("XXX", "Il contratto sorgente e il contratto di destinazione non sono congruenti sulla tipologia 'Contratto di trasporto'");
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["CONTRATTOGIACENZA"].ToString(), _dtTariffaPartenza.Rows[0]["CONTRATTOGIACENZA"].ToString(), false) != 0)
				{
					rsMess = this.TranslateMessage("XXX", "Il contratto sorgente e il contratto di destinazione non sono congruenti sulla tipologia 'Contratto di giacenza'");
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["ATTIVAPASSIVA"].ToString(), _dtTariffaPartenza.Rows[0]["ATTIVAPASSIVA"].ToString(), false) != 0)
				{
					rsMess = this.TranslateMessage("XXX", "Il contratto sorgente e il contratto di destinazione non sono congruenti sulla tipologia 'Attiva/Passiva'");
				}
				else
				{
					val = (FXRETURN)0;
				}
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN CheckDuplicazione(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Invalid comparison between Unknown and I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT IdTariffa FROM " + _ViewTestataTariffa + " WHERE 1=1 ";
			text = text + " AND Contratto=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Contratto) + " ";
			text = text + " AND TipoDocumento=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento) + " ";
			text = text + " AND TipoSpedizione=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + " ";
			text = text + " AND TipoMerce=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + " ";
			text = text + " AND TipoMezzo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMezzo) + " ";
			text = text + " AND Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + " ";
			text = text + " AND GruppoTariffarioPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioPartenza) + " ";
			text = text + " AND PCSPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + " ";
			text = text + " AND MacroZonaArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_MacroZonaArrivo) + " ";
			text = text + " AND ZonaArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + " ";
			text = text + " AND GruppoTariffarioArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioArrivo) + " ";
			text = text + " AND PCSArrivo =" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + " ";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (rObjDataTable.Rows.Count > 0)
			{
				rsMess = this.TranslateMessage("XXX", "Tariffa già esistente. Id tariffa: {0}", new string[1] { rObjDataTable.Rows[0]["IdTariffa"].ToString() });
			}
			else
			{
				val = (FXRETURN)0;
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
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN DuplicaTariffa(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Invalid comparison between Unknown and I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Invalid comparison between Unknown and I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Invalid comparison between Unknown and I4
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Invalid comparison between Unknown and I4
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		StringBuilder stringBuilder = new StringBuilder();
		DataTable rObjDataTable = null;
		DataTable rObjDataTable2 = null;
		long rlReturnValue = 0L;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			val2 = ((AppBaseClass)this).Parametrica.LeggiContatore(_CounterTestataTariffa, vbStartTrans: false, ref rlReturnValue, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				text = "INSERT INTO " + _ViewTestataTariffa + "(IdTariffa, Contratto, TipoDocumento, TipoSpedizione, TipoMerce, TipoMezzo, ";
				text += "Cliente, GruppoTariffarioPartenza, PCSPartenza, MacroZonaArrivo, ZonaArrivo, GruppoTariffarioArrivo, PCSArrivo, ";
				text += "RapportoPV,UteIns,UteAgg) ";
				text += "SELECT ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref rlReturnValue) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Contratto) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMezzo) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioPartenza) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_MacroZonaArrivo) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioArrivo) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + ", ";
				text += "RapportoPV, ";
				text = text + this.DbConn.SQLFormatString(this._User) + ",";
				text = text + this.DbConn.SQLFormatString(this._User) + " ";
				text = text + "FROM " + _ViewTestataTariffa + " WHERE IDTARIFFA = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdTariffa) + ";";
				stringBuilder.Append(text);
				text = "SELECT * FROM " + _ViewVociTariffa + " WHERE IdTariffa=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdTariffa) + " ";
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					foreach (DataRow row in rObjDataTable.Rows)
					{
						long rlReturnValue2 = 0L;
						val2 = ((AppBaseClass)this).Parametrica.LeggiContatore(_CounterVociTariffa, vbStartTrans: false, ref rlReturnValue2, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							text = "INSERT INTO " + _ViewVociTariffa + " (IdVoce, IdTariffa, Voce, Applicabilita, CampoCalcolo, ";
							text += "ArrCampoCalcolo, ArrCampoCalcoloLimite, ArrCampoCalcoloOltre, ArrImporto, flgEccedenza, Franchigia, UteIns, UteAgg) VALUES (";
							string text2 = text;
							DBConnection dbConn = ((AppBaseClass)this).DbConn;
							string pNumero = rlReturnValue2.ToString();
							text = text2 + dbConn.SQLFormatNumber(ref pNumero) + ", ";
							string text3 = text;
							DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
							pNumero = rlReturnValue.ToString();
							text = text3 + dbConn2.SQLFormatNumber(ref pNumero) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row["Voce"].ToString()) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row["Applicabilita"].ToString()) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row["CampoCalcolo"].ToString()) + ", ";
							string text4 = text;
							DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
							pNumero = row["ArrCampoCalcolo"].ToString();
							text = text4 + dbConn3.SQLFormatNumber(ref pNumero) + ", ";
							string text5 = text;
							DBConnection dbConn4 = ((AppBaseClass)this).DbConn;
							pNumero = row["ArrCampoCalcoloLimite"].ToString();
							text = text5 + dbConn4.SQLFormatNumber(ref pNumero) + ", ";
							string text6 = text;
							DBConnection dbConn5 = ((AppBaseClass)this).DbConn;
							pNumero = row["ArrCampoCalcoloOltre"].ToString();
							text = text6 + dbConn5.SQLFormatNumber(ref pNumero) + ", ";
							string text7 = text;
							DBConnection dbConn6 = ((AppBaseClass)this).DbConn;
							pNumero = row["ArrImporto"].ToString();
							text = text7 + dbConn6.SQLFormatNumber(ref pNumero) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row["flgEccedenza"].ToString()) + ", ";
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row["Franchigia"].ToString()) + ", ";
							text = text + this.DbConn.SQLFormatString(this._User) + ", ";
							text = text + this.DbConn.SQLFormatString(this._User) + "); ";
							stringBuilder.Append(text);
							string[] obj = new string[5] { "SELECT * FROM  ", _ViewFasceTariffa, " WHERE IdVoce=", null, null };
							DBConnection dbConn7 = ((AppBaseClass)this).DbConn;
							pNumero = row["IdVoce"].ToString();
							obj[3] = dbConn7.SQLFormatNumber(ref pNumero);
							obj[4] = " ";
							text = string.Concat(obj);
							val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsMess);
							if ((int)val2 <= 0)
							{
								foreach (DataRow row2 in rObjDataTable2.Rows)
								{
									long rlReturnValue3 = 0L;
									val2 = ((AppBaseClass)this).Parametrica.LeggiContatore(_CounterFasceTariffa, vbStartTrans: false, ref rlReturnValue3, ref rsMess);
									if ((int)val2 <= 0)
									{
										text = "INSERT INTO  " + _ViewFasceTariffa + "  ( IdFascia, IdVoce, FasciaInferiore, FasciaSuperiore, Fisso, Variabile, Percentuale,";
										text += "UteAgg, UteIns) VALUES( ";
										string text8 = text;
										DBConnection dbConn8 = ((AppBaseClass)this).DbConn;
										pNumero = rlReturnValue3.ToString();
										text = text8 + dbConn8.SQLFormatNumber(ref pNumero) + ", ";
										string text9 = text;
										DBConnection dbConn9 = ((AppBaseClass)this).DbConn;
										pNumero = rlReturnValue2.ToString();
										text = text9 + dbConn9.SQLFormatNumber(ref pNumero) + ", ";
										string text10 = text;
										DBConnection dbConn10 = ((AppBaseClass)this).DbConn;
										pNumero = row2["FasciaInferiore"].ToString();
										text = text10 + dbConn10.SQLFormatNumber(ref pNumero) + ", ";
										string text11 = text;
										DBConnection dbConn11 = ((AppBaseClass)this).DbConn;
										pNumero = row2["FasciaSuperiore"].ToString();
										text = text11 + dbConn11.SQLFormatNumber(ref pNumero) + ", ";
										string text12 = text;
										DBConnection dbConn12 = ((AppBaseClass)this).DbConn;
										pNumero = row2["Fisso"].ToString();
										text = text12 + dbConn12.SQLFormatNumber(ref pNumero) + ", ";
										string text13 = text;
										DBConnection dbConn13 = ((AppBaseClass)this).DbConn;
										pNumero = row2["Variabile"].ToString();
										text = text13 + dbConn13.SQLFormatNumber(ref pNumero) + ", ";
										string text14 = text;
										DBConnection dbConn14 = ((AppBaseClass)this).DbConn;
										pNumero = row2["Percentuale"].ToString();
										text = text14 + dbConn14.SQLFormatNumber(ref pNumero) + ", ";
										text = text + this.DbConn.SQLFormatString(this._User) + ", ";
										text = text + this.DbConn.SQLFormatString(this._User) + "); ";
										stringBuilder.Append(text);
										continue;
									}
									val = val2;
									goto end_IL_001c;
								}
								continue;
							}
							val = val2;
						}
						goto end_IL_001c;
					}
					if (Operators.CompareString(stringBuilder.ToString(), "", false) == 0)
					{
						goto IL_083e;
					}
					val2 = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_083e;
					}
					val = val2;
				}
			}
			goto end_IL_001c;
			IL_083e:
			val = (FXRETURN)0;
			end_IL_001c:;
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
}
