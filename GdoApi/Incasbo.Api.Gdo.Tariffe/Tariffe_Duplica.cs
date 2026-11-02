using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Tariffe_Duplica : AppAbstractApi
{
	protected string _Contratto;

	protected string _AttivaPassiva;

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

	protected string _ContrattoDuplica;

	protected string _TipoSpedizioneDuplica;

	protected string _TipoMerceDuplica;

	protected string _TipoMezzoDuplica;

	protected string _ClienteDuplica;

	protected string _GruppoTariffarioPartenzaDuplica;

	protected string _PCSPartenzaDuplica;

	protected string _MacroZonaArrivoDuplica;

	protected string _ZonaArrivoDuplica;

	protected string _GruppoTariffarioArrivoDuplica;

	protected string _PCSArrivoDuplica;

	protected string _ViewFasceTariffa;

	protected string _ViewVociTariffa;

	protected string _ViewTestataTariffa;

	public Tariffe_Duplica(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Contratto = "";
		_AttivaPassiva = "";
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
		_ContrattoDuplica = "";
		_TipoSpedizioneDuplica = "";
		_TipoMerceDuplica = "";
		_TipoMezzoDuplica = "";
		_ClienteDuplica = "";
		_GruppoTariffarioPartenzaDuplica = "";
		_PCSPartenzaDuplica = "";
		_MacroZonaArrivoDuplica = "";
		_ZonaArrivoDuplica = "";
		_GruppoTariffarioArrivoDuplica = "";
		_PCSArrivoDuplica = "";
		_ViewFasceTariffa = "";
		_ViewVociTariffa = "";
		_ViewTestataTariffa = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Contratto = base._ParametersIn["Contratto"].ToString();
			text = "SELECT ATTIVAPASSIVA FROM TARIFFECONTRATTI WHERE CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Contratto);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_AttivaPassiva = Conversions.ToString(objRes);
				if (Operators.CompareString(_AttivaPassiva, "A", false) == 0)
				{
					_ViewTestataTariffa = "TariffeAttiveTestata";
				}
				else
				{
					_ViewTestataTariffa = "TariffePassiveTestata";
				}
				_ContrattoDuplica = base._ParametersIn["ContrattoDuplica"].ToString();
				_TipoDocumento = base._ParametersIn["TipoDocumento"].ToString();
				_TipoSpedizione = base._ParametersIn["TipoSpedizione"].ToString();
				_TipoSpedizioneDuplica = base._ParametersIn["TipoSpedizioneDuplica"].ToString();
				_TipoMerce = base._ParametersIn["TipoMerce"].ToString();
				_TipoMerceDuplica = base._ParametersIn["TipoMerceDuplica"].ToString();
				_TipoMezzo = base._ParametersIn["TipoMezzo"].ToString();
				_TipoMezzoDuplica = base._ParametersIn["TipoMezzoDuplica"].ToString();
				_Cliente = base._ParametersIn["Cliente"].ToString();
				_ClienteDuplica = base._ParametersIn["ClienteDuplica"].ToString();
				_GruppoTariffarioPartenza = base._ParametersIn["GruppoTariffarioPartenza"].ToString();
				_GruppoTariffarioPartenzaDuplica = base._ParametersIn["GruppoTariffarioPartenzaDuplica"].ToString();
				_PCSPartenza = base._ParametersIn["PCSPartenza"].ToString();
				_PCSPartenzaDuplica = base._ParametersIn["PCSPartenzaDuplica"].ToString();
				_MacroZonaArrivo = base._ParametersIn["MacroZonaArrivo"].ToString();
				_MacroZonaArrivoDuplica = base._ParametersIn["MacroZonaArrivoDuplica"].ToString();
				_ZonaArrivo = base._ParametersIn["ZonaArrivo"].ToString();
				_ZonaArrivoDuplica = base._ParametersIn["ZonaArrivoDuplica"].ToString();
				_GruppoTariffarioArrivo = base._ParametersIn["GruppoTariffarioArrivo"].ToString();
				_GruppoTariffarioArrivoDuplica = base._ParametersIn["GruppoTariffarioArrivoDuplica"].ToString();
				_PCSArrivo = base._ParametersIn["PCSArrivo"].ToString();
				_PCSArrivoDuplica = base._ParametersIn["PCSArrivoDuplica"].ToString();
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
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dtTariffe = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = SearchTariffe(ref dtTariffe, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in dtTariffe.Rows)
				{
					val = Tariffe_DuplicaSingola.RunProc(this._ApiContext, row["IdTariffa"].ToString(), _AttivaPassiva, _ContrattoDuplica, _TipoDocumento, _TipoSpedizioneDuplica, _TipoMerceDuplica, _TipoMezzoDuplica, _ClienteDuplica, _GruppoTariffarioPartenzaDuplica, _PCSPartenzaDuplica, _MacroZonaArrivoDuplica, _ZonaArrivoDuplica, _GruppoTariffarioArrivoDuplica, _PCSArrivoDuplica, ref rsmess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
					goto end_IL_000e;
				}
				val2 = (FXRETURN)0;
			}
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Contratto, string TipoDocumento, string TipoSpedizione, string TipoMerce, string TipoMezzo, string Cliente, string GruppoTariffarioPartenza, string PCSPartenza, string MacroZonaArrivo, string ZonaArrivo, string GruppoTariffarioArrivo, string PCSArrivo, string ContrattoDuplica, string TipoSpedizioneDuplica, string TipoMerceDuplica, string TipoMezzoDuplica, string ClienteDuplica, string GruppoTariffarioPartenzaDuplica, string PCSPartenzaDuplica, string MacroZonaArrivoDuplica, string ZonaArrivoDuplica, string GruppoTariffarioArrivoDuplica, string PCSArrivoDuplica, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Invalid comparison between Unknown and I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Tariffe_Duplica tariffe_Duplica = new Tariffe_Duplica(objApiContext);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("Contratto", Contratto);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoSpedizione", TipoSpedizione);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMerce", TipoMerce);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMezzo", TipoMezzo);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioPartenza", GruppoTariffarioPartenza);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSPartenza", PCSPartenza);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("MacroZonaArrivo", MacroZonaArrivo);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ZonaArrivo", ZonaArrivo);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioArrivo", GruppoTariffarioArrivo);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSArrivo", PCSArrivo);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ContrattoDuplica", ContrattoDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoSpedizioneDuplica", TipoSpedizioneDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMerceDuplica", TipoMerceDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMezzoDuplica", TipoMezzoDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ClienteDuplica", ClienteDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioPartenzaDuplica", GruppoTariffarioPartenzaDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSPartenzaDuplica", PCSPartenzaDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("MacroZonaArrivoDuplica", MacroZonaArrivoDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ZonaArrivoDuplica", ZonaArrivoDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioArrivoDuplica", GruppoTariffarioArrivoDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSArrivoDuplica", PCSArrivoDuplica);
			val = ((AppAbstractApi)tariffe_Duplica).Run(ref rsmess);
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Contratto, string ContrattoDuplica, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Invalid comparison between Unknown and I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Tariffe_Duplica tariffe_Duplica = new Tariffe_Duplica(objApiContext);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("Contratto", Contratto);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoDocumento", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoSpedizione", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMerce", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMezzo", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("Cliente", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioPartenza", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSPartenza", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("MacroZonaArrivo", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ZonaArrivo", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioArrivo", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSArrivo", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ContrattoDuplica", ContrattoDuplica);
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoSpedizioneDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMerceDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("TipoMezzoDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ClienteDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioPartenzaDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSPartenzaDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("MacroZonaArrivoDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("ZonaArrivoDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("GruppoTariffarioArrivoDuplica", "");
			((AppAbstractApi)tariffe_Duplica).ParametersIn.Add("PCSArrivoDuplica", "");
			val = ((AppAbstractApi)tariffe_Duplica).Run(ref rsmess);
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

	private FXRETURN SearchTariffe(ref DataTable dtTariffe, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Invalid comparison between Unknown and I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT IDTARIFFA FROM " + _ViewTestataTariffa + " WHERE 1=1 ";
			if (Operators.CompareString(_Contratto, "", false) != 0)
			{
				text = text + " AND Contratto=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Contratto) + " ";
			}
			if (Operators.CompareString(_TipoDocumento, "", false) != 0)
			{
				text = text + " AND TipoDocumento=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento) + " ";
			}
			if (Operators.CompareString(_TipoSpedizione, "", false) != 0)
			{
				text = text + " AND TipoSpedizione=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + " ";
			}
			if (Operators.CompareString(_TipoMerce, "", false) != 0)
			{
				text = text + " AND TipoMerce=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + " ";
			}
			if (Operators.CompareString(_TipoMezzo, "", false) != 0)
			{
				text = text + " AND TipoMezzo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMezzo) + " ";
			}
			if (Operators.CompareString(_Cliente, "", false) != 0)
			{
				text = text + " AND Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + " ";
			}
			if (Operators.CompareString(_GruppoTariffarioPartenza, "", false) != 0)
			{
				text = text + " AND GruppoTariffarioPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioPartenza) + " ";
			}
			if (Operators.CompareString(_PCSPartenza, "", false) != 0)
			{
				text = text + " AND PCSPartenza=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + " ";
			}
			if (Operators.CompareString(_MacroZonaArrivo, "", false) != 0)
			{
				text = text + " AND MacroZonaArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_MacroZonaArrivo) + " ";
			}
			if (Operators.CompareString(_ZonaArrivo, "", false) != 0)
			{
				text = text + " AND ZonaArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + " ";
			}
			if (Operators.CompareString(_GruppoTariffarioArrivo, "", false) != 0)
			{
				text = text + " AND GruppoTariffarioArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioArrivo) + " ";
			}
			if (Operators.CompareString(_PCSArrivo, "", false) != 0)
			{
				text = text + " AND PCSArrivo =" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + " ";
			}
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dtTariffe, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dtTariffe.Rows.Count == 0)
			{
				rsMess = this.TranslateMessage("XXX", "Nessuna tariffa da duplicare");
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
}
