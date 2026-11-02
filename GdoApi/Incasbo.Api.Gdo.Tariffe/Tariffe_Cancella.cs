using System;
using System.Data;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Tariffe_Cancella : AppAbstractApi
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

	protected string _ViewTestataTariffa;

	public Tariffe_Cancella(AppApiContext objApiContext)
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
		_ViewTestataTariffa = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
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
				_TipoDocumento = base._ParametersIn["TipoDocumento"].ToString();
				_TipoSpedizione = base._ParametersIn["TipoSpedizione"].ToString();
				_TipoMerce = base._ParametersIn["TipoMerce"].ToString();
				_TipoMezzo = base._ParametersIn["TipoMezzo"].ToString();
				_Cliente = base._ParametersIn["Cliente"].ToString();
				_GruppoTariffarioPartenza = base._ParametersIn["GruppoTariffarioPartenza"].ToString();
				_PCSPartenza = base._ParametersIn["PCSPartenza"].ToString();
				_MacroZonaArrivo = base._ParametersIn["MacroZonaArrivo"].ToString();
				_ZonaArrivo = base._ParametersIn["ZonaArrivo"].ToString();
				_GruppoTariffarioArrivo = base._ParametersIn["GruppoTariffarioArrivo"].ToString();
				_PCSArrivo = base._ParametersIn["PCSArrivo"].ToString();
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
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dtTariffe = null;
		string RetQueryToApply = "";
		StringBuilder stringBuilder = new StringBuilder();
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
					val = Tariffe_CancellaSingola.RunProc(this._ApiContext, row["IdTariffa"].ToString(), _AttivaPassiva, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val <= 0)
					{
						stringBuilder.Append(RetQueryToApply);
						continue;
					}
					val2 = val;
					goto end_IL_001c;
				}
				if (Operators.CompareString(stringBuilder.ToString(), "", false) == 0)
				{
					goto IL_010e;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_010e;
				}
				val2 = val;
			}
			goto end_IL_001c;
			IL_010e:
			val2 = (FXRETURN)0;
			end_IL_001c:;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Contratto, string TipoDocumento, string TipoSpedizione, string TipoMerce, string TipoMezzo, string Cliente, string GruppoTariffarioPartenza, string PCSPartenza, string MacroZonaArrivo, string ZonaArrivo, string GruppoTariffarioArrivo, string PCSArrivo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Tariffe_Cancella tariffe_Cancella = new Tariffe_Cancella(objApiContext);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("Contratto", Contratto);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("TipoSpedizione", TipoSpedizione);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("TipoMerce", TipoMerce);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("TipoMezzo", TipoMezzo);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("GruppoTariffarioPartenza", GruppoTariffarioPartenza);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("PCSPartenza", PCSPartenza);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("MacroZonaArrivo", MacroZonaArrivo);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("ZonaArrivo", ZonaArrivo);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("GruppoTariffarioArrivo", GruppoTariffarioArrivo);
			((AppAbstractApi)tariffe_Cancella).ParametersIn.Add("PCSArrivo", PCSArrivo);
			val = ((AppAbstractApi)tariffe_Cancella).Run(ref rsmess);
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
				rsMess = this.TranslateMessage("XXX", "Nessuna tariffa da cancelllare");
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
