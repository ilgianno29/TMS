using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class PCS_DeterminaZone : AppAbstractApi
{
	protected string _PCS;

	protected string _TipoMerce;

	protected const string _STAR_ALL = "*ALL";

	public PCS_DeterminaZone(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_PCS = "";
		_TipoMerce = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (base._ParametersIn.ContainsKey("PCS"))
			{
				_PCS = base._ParametersIn["PCS"].ToString();
			}
			if (Operators.CompareString(_PCS, "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "PCS non impostato");
			}
			else
			{
				if (base._ParametersIn.ContainsKey("TipoMerce"))
				{
					_TipoMerce = base._ParametersIn["TipoMerce"].ToString();
				}
				if (Operators.CompareString(_TipoMerce, "", false) == 0)
				{
					_TipoMerce = "*ALL";
				}
				base._ParametersOut.Add("ZonaSpedizione", "");
				base._ParametersOut.Add("ZonaTariffaAttiva", "");
				base._ParametersOut.Add("ZonaTariffaPassiva", "");
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
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT PCS_ZONE.*,CASE WHEN TIPOMERCE='*ALL' THEN 10 ELSE 1 END PESO ";
			text += "FROM PCS_ZONE ";
			text = text + "WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS) + " ";
			text = text + "AND TIPOMERCE IN (" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + "," + ((AppBaseClass)this).DbConn.SQLFormatString("*ALL") + ") ";
			text += "AND ATTIVO='S' ";
			text += "ORDER BY PESO";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count > 0)
			{
				base._ParametersOut["ZonaSpedizione"] = rObjDataTable.Rows[0]["ZonaSpedizione"].ToString();
				base._ParametersOut["ZonaTariffaAttiva"] = rObjDataTable.Rows[0]["ZonaTariffaAttiva"].ToString();
				base._ParametersOut["ZonaTariffaPassiva"] = rObjDataTable.Rows[0]["ZonaTariffaPassiva"].ToString();
				val2 = (FXRETURN)0;
			}
			else
			{
				rsmess = this.TranslateMessage("XXX", "Zone non definite per il PCS {0}", new string[1] { _PCS });
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string PCS, string TipoMerce, ref string ZonaSpedizione, ref string ZonaTariffaAttiva, ref string ZonaTariffaPassiva, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			PCS_DeterminaZone pCS_DeterminaZone = new PCS_DeterminaZone(objApiContext);
			((AppAbstractApi)pCS_DeterminaZone).ParametersIn.Add("PCS", PCS);
			((AppAbstractApi)pCS_DeterminaZone).ParametersIn.Add("TipoMerce", TipoMerce);
			val = ((AppAbstractApi)pCS_DeterminaZone).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ZonaSpedizione = ((AppAbstractApi)pCS_DeterminaZone).ParametersOut["ZonaSpedizione"].ToString();
				ZonaTariffaAttiva = ((AppAbstractApi)pCS_DeterminaZone).ParametersOut["ZonaTariffaAttiva"].ToString();
				ZonaTariffaPassiva = ((AppAbstractApi)pCS_DeterminaZone).ParametersOut["ZonaTariffaPassiva"].ToString();
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
