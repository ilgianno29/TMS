using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Zona_DeterminaCorrispondente : AppAbstractApi
{
	protected string _ZonaSpedizione;

	protected string _TipoSpedizione;

	protected string _TipoMerce;

	protected decimal _SogliaPeso;

	protected decimal _SogliaVolume;

	protected string _Corrispondente;

	public Zona_DeterminaCorrispondente(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ZonaSpedizione = "";
		_TipoSpedizione = "";
		_TipoMerce = "";
		_SogliaPeso = default(decimal);
		_SogliaVolume = default(decimal);
		_Corrispondente = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_ZonaSpedizione = ((AppAbstractApi)this).ParametersIn["ZonaSpedizione"].ToString();
			_TipoSpedizione = ((AppAbstractApi)this).ParametersIn["TipoSpedizione"].ToString();
			_TipoMerce = ((AppAbstractApi)this).ParametersIn["TipoMerce"].ToString();
			_SogliaPeso = Conversions.ToDecimal(((AppAbstractApi)this).ParametersIn["SogliaPeso"]);
			_SogliaVolume = Conversions.ToDecimal(((AppAbstractApi)this).ParametersIn["SogliaVolume"]);
			((AppAbstractApi)this).ParametersOut.Add("Corrispondente", "");
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "SELECT Corrispondente, SogliaPeso, SogliaVolume, Peso1+Peso2+Peso3 Peso FROM (";
			text += "SELECT Corrispondente, SogliaPeso, SogliaVolume, ";
			text += "CASE WHEN Zona<>'*ALL' THEN 1000 ELSE 0 END Peso1, ";
			text += "CASE WHEN TipoSpedizione<>'*ALL' THEN 100 ELSE 0 END Peso2, ";
			text += "CASE WHEN TipoMerce<>'*ALL' THEN 10 ELSE 0 END Peso3 ";
			text += "FROM ZoneCorrispondenti ZC INNER JOIN Corrispondenti PCS ON PCS.CODICE=ZC.Corrispondente ";
			text = text + "WHERE ZC.Zona IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaSpedizione) + ") ";
			text = text + "AND ZC.TipoSpedizione IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + ") ";
			text = text + "AND ZC.TipoMerce IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + ") ";
			text += "AND PCS.Attivo='S') T ";
			text += "ORDER BY Peso DESC";
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count > 0)
				{
					if (decimal.Compare(Conversions.ToDecimal(rObjDataTable.Rows[0]["SogliaPeso"]), 0m) > 0)
					{
						if (decimal.Compare(Conversions.ToDecimal(rObjDataTable.Rows[0]["SogliaPeso"]), _SogliaPeso) >= 0)
						{
							_Corrispondente = rObjDataTable.Rows[0]["Corrispondente"].ToString();
						}
					}
					else if (decimal.Compare(Conversions.ToDecimal(rObjDataTable.Rows[0]["SogliaVolume"]), 0m) > 0)
					{
						if (decimal.Compare(Conversions.ToDecimal(rObjDataTable.Rows[0]["SogliaVolume"]), _SogliaVolume) >= 0)
						{
							_Corrispondente = rObjDataTable.Rows[0]["Corrispondente"].ToString();
						}
					}
					else
					{
						_Corrispondente = rObjDataTable.Rows[0]["Corrispondente"].ToString();
					}
				}
				((AppAbstractApi)this).ParametersOut["Corrispondente"] = _Corrispondente;
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
}
