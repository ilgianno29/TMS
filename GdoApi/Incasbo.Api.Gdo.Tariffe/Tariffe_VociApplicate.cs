using System;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Tariffe_VociApplicate : AppAbstractApi
{
	protected string _Contratto;

	protected string _AttivoPassivo;

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

	protected string _ViewVociTariffa;

	protected string _ViewTestataTariffa;

	protected const string _STAR_ALL = "*ALL";

	protected const string _ViewTestataAttiva = "TAR_TariffeAttiveTestata";

	protected const string _ViewTestataPassiva = "TAR_TariffePassiveTestata";

	protected const string _ViewVociAttiva = "TAR_TariffeAttiveVoci";

	protected const string _ViewVociPassiva = "TAR_TariffePassiveVoci";

	public Tariffe_VociApplicate(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Contratto = "";
		_AttivoPassivo = "";
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
		_ViewVociTariffa = "";
		_ViewTestataTariffa = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
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
				_AttivoPassivo = Conversions.ToString(objRes);
				if (Operators.CompareString(_AttivoPassivo, "A", false) == 0)
				{
					_ViewTestataTariffa = "TAR_TariffeAttiveTestata";
					_ViewVociTariffa = "TAR_TariffeAttiveVoci";
				}
				else
				{
					_ViewTestataTariffa = "TAR_TariffePassiveTestata";
					_ViewVociTariffa = "TAR_TariffePassiveVoci";
				}
				if (base._ParametersIn.ContainsKey("TipoDocumento"))
				{
					_TipoDocumento = base._ParametersIn["TipoDocumento"].ToString();
				}
				if (Operators.CompareString(_TipoDocumento, "", false) == 0)
				{
					_TipoDocumento = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("TipoSpedizione"))
				{
					_TipoSpedizione = base._ParametersIn["TipoSpedizione"].ToString();
				}
				if (Operators.CompareString(_TipoSpedizione, "", false) == 0)
				{
					_TipoSpedizione = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("TipoMerce"))
				{
					_TipoMerce = base._ParametersIn["TipoMerce"].ToString();
				}
				if (Operators.CompareString(_TipoMerce, "", false) == 0)
				{
					_TipoMerce = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("TipoMezzo"))
				{
					_TipoMezzo = base._ParametersIn["TipoMezzo"].ToString();
				}
				if (Operators.CompareString(_TipoMezzo, "", false) == 0)
				{
					_TipoMezzo = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("Cliente"))
				{
					_Cliente = base._ParametersIn["Cliente"].ToString();
				}
				if (Operators.CompareString(_Cliente, "", false) == 0)
				{
					_Cliente = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("GruppoTariffarioPartenza"))
				{
					_GruppoTariffarioPartenza = base._ParametersIn["GruppoTariffarioPartenza"].ToString();
				}
				if (Operators.CompareString(_GruppoTariffarioPartenza, "", false) == 0)
				{
					_GruppoTariffarioPartenza = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("PCSPartenza"))
				{
					_PCSPartenza = base._ParametersIn["PCSPartenza"].ToString();
				}
				if (Operators.CompareString(_PCSPartenza, "", false) == 0)
				{
					_PCSPartenza = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("MacroZonaArrivo"))
				{
					_MacroZonaArrivo = base._ParametersIn["MacroZonaArrivo"].ToString();
				}
				if (Operators.CompareString(_MacroZonaArrivo, "", false) == 0)
				{
					_MacroZonaArrivo = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("ZonaArrivo"))
				{
					_ZonaArrivo = base._ParametersIn["ZonaArrivo"].ToString();
				}
				if (Operators.CompareString(_ZonaArrivo, "", false) == 0)
				{
					_ZonaArrivo = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("GruppoTariffarioArrivo"))
				{
					_GruppoTariffarioArrivo = base._ParametersIn["GruppoTariffarioArrivo"].ToString();
				}
				if (Operators.CompareString(_GruppoTariffarioArrivo, "", false) == 0)
				{
					_GruppoTariffarioArrivo = "*ALL";
				}
				if (base._ParametersIn.ContainsKey("PCSArrivo"))
				{
					_PCSArrivo = base._ParametersIn["PCSArrivo"].ToString();
				}
				if (Operators.CompareString(_PCSArrivo, "", false) == 0)
				{
					_PCSArrivo = "*ALL";
				}
				base._ParametersOut.Add("VociApplicate", null);
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
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Invalid comparison between Unknown and I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Invalid comparison between Unknown and I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		DataTable dataTable = null;
		DataTable rObjDataTable2 = null;
		StringCollection stringCollection = new StringCollection();
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM " + _ViewTestataTariffa + " WHERE ";
			text = text + "Contratto = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Contratto) + " ";
			text = text + "AND TipoDocumento IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento) + ") ";
			text = text + "AND TipoSpedizione IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + ") ";
			text = text + "AND TipoMerce IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + ") ";
			text = text + "AND TipoMezzo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMezzo) + ") ";
			text = text + "AND Cliente IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + ") ";
			text = text + "AND GruppoTariffarioPartenza IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioPartenza) + ") ";
			text = text + "AND PCSPartenza IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + ") ";
			text = text + "AND MacroZonaArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_MacroZonaArrivo) + ") ";
			text = text + "AND ZonaArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaArrivo) + ") ";
			text = text + "AND GruppoTariffarioArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_GruppoTariffarioArrivo) + ") ";
			text = text + "AND PCSArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSArrivo) + ") ";
			text += "ORDER BY Peso DESC";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Nessuna tariffa trovata");
			}
			else
			{
				text = "SELECT * FROM " + _ViewVociTariffa + " WHERE IdTariffa IN (";
				int num = 1;
				foreach (DataRow row in rObjDataTable.Rows)
				{
					text += ((AppBaseClass)this).DbConn.SQLFormatString(row["IdTariffa"].ToString());
					if (num < rObjDataTable.Rows.Count)
					{
						text += ", ";
					}
					num = checked(num + 1);
				}
				text += ") ";
				text += "ORDER BY Peso DESC";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					dataTable = rObjDataTable2.Clone();
					foreach (DataRow row2 in rObjDataTable2.Rows)
					{
						if (!stringCollection.Contains(row2["Voce"].ToString()))
						{
							stringCollection.Add(row2["Voce"].ToString());
							dataTable.ImportRow(row2);
						}
					}
					dataTable.AcceptChanges();
					base._ParametersOut["VociApplicate"] = dataTable;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Contratto, string TipoDocumento, string TipoSpedizione, string TipoMerce, string TipoMezzo, string Cliente, string GruppoTariffarioPartenza, string PCSPartenza, string MacroZonaArrivo, string ZonaArrivo, string GruppoTariffarioArrivo, string PCSArrivo, ref DataTable dtVociApplicate, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Tariffe_VociApplicate tariffe_VociApplicate = new Tariffe_VociApplicate(objApiContext);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("Contratto", Contratto);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("TipoSpedizione", TipoSpedizione);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("TipoMerce", TipoMerce);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("TipoMezzo", TipoMezzo);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("GruppoTariffarioPartenza", GruppoTariffarioPartenza);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("PCSPartenza", PCSPartenza);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("MacroZonaArrivo", MacroZonaArrivo);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("ZonaArrivo", ZonaArrivo);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("GruppoTariffarioArrivo", GruppoTariffarioArrivo);
			((AppAbstractApi)tariffe_VociApplicate).ParametersIn.Add("PCSArrivo", PCSArrivo);
			val = ((AppAbstractApi)tariffe_VociApplicate).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				dtVociApplicate = (DataTable)((AppAbstractApi)tariffe_VociApplicate).ParametersOut["VociApplicate"];
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
