using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class TempiResa_CalcolaGiorni : AppAbstractApi
{
	protected string _Cliente;

	protected string _PCSPartenza;

	protected string _ZonaSpedizione;

	protected string _TipoSpedizione;

	protected string _TipoServizio;

	protected string _TipoMerce;

	protected DateTime? _DataRiferimento;

	protected int _GiorniDiConsegnaDa;

	protected int _GiorniDiConsegnaA;

	protected int _GiorniDiUscitaMagazzino;

	public TempiResa_CalcolaGiorni(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Cliente = "";
		_PCSPartenza = "*ALL";
		_ZonaSpedizione = "*ALL";
		_TipoSpedizione = "*ALL";
		_TipoServizio = "*ALL";
		_TipoMerce = "*ALL";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Cliente = ((AppAbstractApi)this).ParametersIn["Cliente"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("PCSPartenza"))
			{
				_PCSPartenza = ((AppAbstractApi)this).ParametersIn["PCSPartenza"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ZonaSpedizione"))
			{
				_ZonaSpedizione = ((AppAbstractApi)this).ParametersIn["ZonaSpedizione"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoSpedizione"))
			{
				_TipoSpedizione = ((AppAbstractApi)this).ParametersIn["TipoSpedizione"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoMerce"))
			{
				_TipoMerce = ((AppAbstractApi)this).ParametersIn["TipoMerce"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoServizio"))
			{
				_TipoServizio = ((AppAbstractApi)this).ParametersIn["TipoServizio"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataRiferimento"))
			{
				_DataRiferimento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataRiferimento"];
			}
			if (!_DataRiferimento.HasValue)
			{
				_DataRiferimento = DateAndTime.Now;
			}
			((AppAbstractApi)this).ParametersOut.Add("GiorniDiConsegnaDa", 0);
			((AppAbstractApi)this).ParametersOut.Add("GiorniDiConsegnaA", 0);
			((AppAbstractApi)this).ParametersOut.Add("GiorniDiUscitaMagazzino", 0);
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
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Invalid comparison between Unknown and I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "SELECT GiorniPrevistaConsegna, GiorniUscitaMagazzino, CutOff, Peso1+Peso2+Peso3+Peso4+Peso5+Peso6 Peso FROM (";
			text += "SELECT GiorniPrevistaConsegna, GiorniUscitaMagazzino, CutOff, ";
			text += "CASE WHEN Cliente<>'*ALL' THEN 100000 ELSE 0 END Peso1, ";
			text += "CASE WHEN TipoServizio<>'*ALL' THEN 10000 ELSE 0 END Peso2, ";
			text += "CASE WHEN TipoSpedizione<>'*ALL' THEN 1000 ELSE 0 END Peso3, ";
			text += "CASE WHEN TipoMerce<>'*ALL' THEN 100 ELSE 0 END Peso4, ";
			text += "CASE WHEN PCSPartenza<>'*ALL' THEN 10 ELSE 0 END Peso5, ";
			text += "CASE WHEN ZonaSpedizione<>'*ALL' THEN 1 ELSE 0 END Peso6 ";
			text += "FROM ClientiTempiResa CTR ";
			text += "WHERE CTR.Attivo='S' ";
			text = text + "AND CTR.Cliente IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + ") ";
			text = text + "AND CTR.TipoServizio IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoServizio) + ") ";
			text = text + "AND CTR.TipoSpedizione IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + ") ";
			text = text + "AND CTR.TipoMerce IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + ") ";
			text = text + "AND CTR.PCSPartenza IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenza) + ") ";
			text = text + "AND CTR.ZonaSpedizione IN ('*ALL'," + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaSpedizione) + ") ";
			text += "AND CTR.Attivo='S') T ";
			text += "ORDER BY Peso DESC";
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				checked
				{
					if (rObjDataTable.Rows.Count > 0)
					{
						_GiorniDiConsegnaDa = 0;
						_GiorniDiConsegnaA = Conversions.ToInteger(rObjDataTable.Rows[0]["GiorniPrevistaConsegna"]);
						_GiorniDiUscitaMagazzino = Conversions.ToInteger(rObjDataTable.Rows[0]["GiorniUscitaMagazzino"]);
						if (_DataRiferimento.Value.TimeOfDay > Conversions.ToDate(rObjDataTable.Rows[0]["CutOff"]).TimeOfDay)
						{
							_GiorniDiConsegnaDa++;
							_GiorniDiConsegnaA++;
							_GiorniDiUscitaMagazzino++;
						}
					}
					else
					{
						_GiorniDiConsegnaDa = 1;
						_GiorniDiConsegnaA = 1;
						_GiorniDiUscitaMagazzino = 1;
					}
					((AppAbstractApi)this).ParametersOut["GiorniDiConsegnaDa"] = _GiorniDiConsegnaDa;
					((AppAbstractApi)this).ParametersOut["GiorniDiConsegnaA"] = _GiorniDiConsegnaA;
					((AppAbstractApi)this).ParametersOut["GiorniDiUscitaMagazzino"] = _GiorniDiUscitaMagazzino;
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
}
