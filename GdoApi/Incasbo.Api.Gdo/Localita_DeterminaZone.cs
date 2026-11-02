using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Localita_DeterminaZone : GdoAbstractApi
{
	protected string _Localita;

	protected string _Cap;

	protected string _Provincia;

	protected string _Nazione;

	protected string _TipoMerce;

	protected string _ZonaSpedizione;

	protected string _ZonaTariffaAttiva;

	protected string _ZonaTariffaPassiva;

	protected const string _STAR_ALL = "*ALL";

	public Localita_DeterminaZone(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Localita = "";
		_Cap = "";
		_Provincia = "";
		_Nazione = "";
		_TipoMerce = "";
		_ZonaSpedizione = "";
		_ZonaTariffaAttiva = "";
		_ZonaTariffaPassiva = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (this._ParametersIn.ContainsKey("TipoMerce"))
			{
				_TipoMerce = this._ParametersIn["TipoMerce"].ToString();
			}
			if (Operators.CompareString(_TipoMerce, "", false) == 0)
			{
				_TipoMerce = base.ApplicationDefault.TipoMerceDefault();
			}
			if (Operators.CompareString(_TipoMerce, "", false) == 0)
			{
				_TipoMerce = "*ALL";
			}
			if (this._ParametersIn.ContainsKey("Localita"))
			{
				_Localita = this._ParametersIn["Localita"].ToString();
			}
			if (this._ParametersIn.ContainsKey("Cap"))
			{
				_Cap = this._ParametersIn["Cap"].ToString();
			}
			if (this._ParametersIn.ContainsKey("Provincia"))
			{
				_Provincia = this._ParametersIn["Provincia"].ToString();
			}
			if (this._ParametersIn.ContainsKey("Nazione"))
			{
				_Nazione = this._ParametersIn["Nazione"].ToString();
			}
			if (Operators.CompareString(_TipoMerce, "", false) == 0)
			{
				_TipoMerce = "*ALL";
			}
			this._ParametersOut.Add("ZonaSpedizione", "");
			this._ParametersOut.Add("ZonaTariffaAttiva", "");
			this._ParametersOut.Add("ZonaTariffaPassiva", "");
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = DeterminaZone(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				this._ParametersOut["ZonaSpedizione"] = _ZonaSpedizione;
				this._ParametersOut["ZonaTariffaAttiva"] = _ZonaTariffaAttiva;
				this._ParametersOut["ZonaTariffaPassiva"] = _ZonaTariffaPassiva;
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

	private string GeoProp(string FieldName)
	{
		string result = "";
		string text = FieldName.ToUpper();
		if (Operators.CompareString(text, "Cap".ToUpper(), false) == 0)
		{
			if (Operators.CompareString(_Cap, "", false) != 0)
			{
				result = ((AppBaseClass)this).DbConn.SQLFormatString(_Cap);
			}
		}
		else if (Operators.CompareString(text, "Localita".ToUpper(), false) == 0)
		{
			if (Operators.CompareString(_Localita, "", false) != 0)
			{
				result = ((AppBaseClass)this).DbConn.SQLFormatString(_Localita);
			}
		}
		else if (Operators.CompareString(text, "Provincia".ToUpper(), false) == 0)
		{
			if (Operators.CompareString(_Provincia, "", false) != 0)
			{
				result = ((AppBaseClass)this).DbConn.SQLFormatString(_Provincia);
			}
		}
		else if (Operators.CompareString(text, "Regione".ToUpper(), false) == 0)
		{
			if ((Operators.CompareString(_Provincia, "", false) != 0) & (Operators.CompareString(_Nazione, "", false) != 0))
			{
				result = "(SELECT Regione FROM Localita WHERE Localita IS NULL AND Cap IS NULL AND ";
				result = result + "Provincia = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Provincia) + " AND ";
				result = result + "Nazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Nazione) + ")";
			}
		}
		else if (Operators.CompareString(text, "Nazione".ToUpper(), false) == 0 && Operators.CompareString(_Nazione, "", false) != 0)
		{
			result = ((AppBaseClass)this).DbConn.SQLFormatString(_Nazione);
		}
		return result;
	}

	protected FXRETURN DeterminaZone(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Invalid comparison between Unknown and I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string zonaSpedizione = base.ApplicationDefault.ZonaSpedizioneDefault();
			string zonaTariffaAttiva = base.ApplicationDefault.ZonaTariffaAttivaDefault();
			string zonaTariffaPassiva = base.ApplicationDefault.ZonaTariffaPassivaDefault();
			text = "SELECT Cap, Localita, Provincia, Regione, Nazione, Tabella FROM ZoneRicerca WHERE Attivo = 'S' ORDER BY Id";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text2 = "";
				string text3 = "";
				for (int i = 0; i < rObjDataTable.Rows.Count; i = checked(i + 1))
				{
					text3 = "";
					foreach (DataColumn column in rObjDataTable.Columns)
					{
						if (Operators.CompareString(column.ColumnName.ToUpper(), "TABELLA", false) == 0 || Operators.CompareString(rObjDataTable.Rows[i][column.ColumnName].ToString(), "S", false) != 0)
						{
							continue;
						}
						string text4 = GeoProp(column.ColumnName);
						if (text4 == null)
						{
							text3 = "";
							break;
						}
						if (Operators.CompareString(text4, "", false) != 0)
						{
							if (text3.Length > 0)
							{
								text3 += " AND ";
							}
							text3 = text3 + "L." + column.ColumnName + " = " + text4;
						}
					}
					if (text3.Length > 0)
					{
						if (text2.Length > 0)
						{
							text2 += " UNION ";
						}
						text2 += "SELECT LZ.ZonaSpedizione, LZ.ZonaTariffaAttiva, LZ.ZonaTariffaPassiva, ";
						text2 = text2 + i + " AS Ordinamento ";
						text2 += "FROM %TABELLA% L INNER JOIN LocalitaZone LZ ON LZ.IdLocalita = L.Id WHERE ";
						text2 = text2 + text3 + " AND LZ.TipoMerce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce);
						text2 = text2.Replace("%TABELLA%", rObjDataTable.Rows[i]["TABELLA"].ToString());
					}
				}
				text = ((((AppBaseClass)this).DbConn.ServerType != DBFormatFunctions.eServerType.Oracle) ? ("SELECT TOP(1) * FROM (" + text2 + ") T ORDER BY Ordinamento") : ("SELECT * FROM (SELECT * FROM (" + text2 + ") ORDER BY Ordinamento) WHERE ROWNUM<=1"));
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (rObjDataTable.Rows.Count == 1)
					{
						_ZonaSpedizione = rObjDataTable.Rows[0]["ZonaSpedizione"].ToString();
						_ZonaTariffaAttiva = rObjDataTable.Rows[0]["ZonaTariffaAttiva"].ToString();
						_ZonaTariffaPassiva = rObjDataTable.Rows[0]["ZonaTariffaPassiva"].ToString();
					}
					else
					{
						_ZonaSpedizione = zonaSpedizione;
						_ZonaTariffaAttiva = zonaTariffaAttiva;
						_ZonaTariffaPassiva = zonaTariffaPassiva;
					}
					if (Operators.CompareString(_ZonaSpedizione, "", false) == 0)
					{
						_ZonaSpedizione = "*ALL";
					}
					if (Operators.CompareString(_ZonaTariffaAttiva, "", false) == 0)
					{
						_ZonaTariffaAttiva = "*ALL";
					}
					if (Operators.CompareString(_ZonaTariffaPassiva, "", false) == 0)
					{
						_ZonaTariffaPassiva = "*ALL";
					}
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
