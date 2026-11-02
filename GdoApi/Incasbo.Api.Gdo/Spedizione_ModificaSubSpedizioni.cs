using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ModificaSubSpedizioni : GdoAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected DataTable _dtSubSpedizioni;

	protected List<Spedizione_Tratta> _Tratte;

	public Spedizione_ModificaSubSpedizioni(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizione = null;
		_dtSubSpedizioni = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_Tratte = (List<Spedizione_Tratta>)((AppAbstractApi)this).ParametersIn["Tratte"];
			val = CheckSpedizione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckSubSpedizioni(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (_Tratte.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Nessuna sub-spedizione definita");
				}
				else
				{
					DataTable rObjDataTable = null;
					text = "SELECT * FROM TipiServizi WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_dtSpedizione.Rows[0]["TipoServizio"].ToString());
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) != 0)
					{
						rsmess = this.TranslateMessage("XXX", "Il Tipo servizio {0} non è attivo", new string[1] { _dtSpedizione.Rows[0]["TipoServizio"].ToString() });
					}
					else if (Operators.CompareString(rObjDataTable.Rows[0]["SubSpedizioni_TipiServizio"].ToString(), "", false) == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Il Tipo servizio {0} non prevede la possibilità di avere sub-spedizioni", new string[1] { _dtSpedizione.Rows[0]["TipoServizio"].ToString() });
					}
					else
					{
						string[] source = rObjDataTable.Rows[0]["SubSpedizioni_TipiServizio"].ToString().Split(new char[1] { ',' });
						foreach (Spedizione_Tratta item in _Tratte)
						{
							if (source.Contains(item.TipoServizio))
							{
								continue;
							}
							rsmess = this.TranslateMessage("XXX", "Il Tipo servizio {0} non è tra quelli previsti per le sub-spedizioni", new string[1] { item.TipoServizio });
							goto end_IL_000b;
						}
						val2 = (FXRETURN)0;
					}
				}
			}
			end_IL_000b:;
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
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Invalid comparison between Unknown and I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Invalid comparison between Unknown and I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Invalid comparison between Unknown and I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Invalid comparison between Unknown and I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Invalid comparison between Unknown and I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string sQuery = "";
		bool flag = false;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			foreach (Spedizione_Tratta item in _Tratte)
			{
				DataRow dataRow = _dtSubSpedizioni.Select("Unibol=" + item.IdSubSpedizione)[0];
				SubSpedizione SubSpedizione = new SubSpedizione();
				SubSpedizione.Unibol = item.IdSubSpedizione;
				flag = false;
				if (!Information.IsNothing((object)item.DataConsegna))
				{
					DateTime? dataConsegna = item.DataConsegna;
					DateTime t = Conversions.ToDate(dataRow["DataConsegnaPrevista1"]);
					bool? flag2 = (dataConsegna.HasValue ? new bool?(DateTime.Compare(dataConsegna.GetValueOrDefault(), t) != 0) : null);
					dataConsegna = item.DataConsegna;
					t = Conversions.ToDate(dataRow["DataConsegnaPrevista2"]);
					bool? flag3 = (dataConsegna.HasValue ? new bool?(DateTime.Compare(dataConsegna.GetValueOrDefault(), t) != 0) : null);
					if ((((!flag2) ?? false) ? new bool?(false) : ((!flag3.HasValue) ? null : (flag3.GetValueOrDefault() & flag2))).GetValueOrDefault())
					{
						SubSpedizione.DataConsegnaPrevista1 = item.DataConsegna;
						SubSpedizione.DataConsegnaPrevista2 = item.DataConsegna;
						flag = true;
					}
				}
				if (Information.IsNothing((object)item.Partenza) || Operators.CompareString(item.Partenza, "", false) == 0 || Operators.CompareString(item.Partenza, dataRow["PCSPartenza"].ToString(), false) == 0)
				{
					goto IL_0219;
				}
				val = CheckPartenza(item.Partenza, ref SubSpedizione, ref rsmess);
				flag = true;
				if ((int)val <= 0)
				{
					goto IL_0219;
				}
				val2 = val;
				goto end_IL_0015;
				IL_0296:
				SubSpedizione.TipoMerce = dataRow["TipoMerce"].ToString();
				val = CheckZone(item.Corrispondente, dataRow["Corrispondente"].ToString(), ref SubSpedizione, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (!Information.IsNothing((object)SubSpedizione.Corrispondente))
					{
						flag = true;
					}
					if (!flag)
					{
						continue;
					}
					SubSpedizione.UteAgg = this._User;
					SubSpedizione.DatAgg = DateAndTime.Now;
					val = CreateQueryUPDATE(SubSpedizione, ref sQuery, ref rsmess);
					if ((int)val <= 0)
					{
						text += sQuery;
						continue;
					}
					val2 = val;
				}
				goto end_IL_0015;
				IL_0219:
				if (Information.IsNothing((object)item.Arrivo) || Operators.CompareString(item.Arrivo, "", false) == 0 || Operators.CompareString(item.Arrivo, dataRow["PCSDestinazione"].ToString(), false) == 0)
				{
					goto IL_0296;
				}
				val = CheckDestinazione(item.Arrivo, ref SubSpedizione, ref rsmess);
				flag = true;
				if ((int)val <= 0)
				{
					goto IL_0296;
				}
				val2 = val;
				goto end_IL_0015;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			end_IL_0015:;
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

	protected FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.* FROM VW_Spedizioni S WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
			}
			else if (Conversions.ToInteger(_dtSpedizione.Rows[0]["CountOfSubSpedizioni"]) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non possiede sub-spedizioni.", new string[1] { _Unibol });
			}
			else if (Conversions.ToInteger(_dtSpedizione.Rows[0]["Stato"]) != 20)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è attiva.", new string[1] { _Unibol });
			}
			else
			{
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

	protected FXRETURN CheckSubSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Conversions.ToInteger(_dtSpedizione.Rows[0]["CountOfSubSpedizioni"]) <= 0)
			{
				goto IL_017f;
			}
			text = "SELECT S.*, SS.Sequenza SS_Sequenza FROM Spedizioni S INNER JOIN Spedizioni_SubSpedizioni SS ON SS.Unibol_SubSpedizione=S.UNIBOL WHERE SS.Unibol_Spedizione=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ORDER BY SS.Sequenza";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSubSpedizioni, ref rsmess);
			if ((int)val <= 0)
			{
				foreach (DataRow row in _dtSubSpedizioni.Rows)
				{
					if (Conversions.ToInteger(row["Stato"]) != 20)
					{
						rsmess = this.TranslateMessage("XXX", "La sub-spedizione con Id {0} non è attiva. Impossibile eliminare le sub-spedizioni.", new string[1] { _Unibol });
					}
					else
					{
						if (Operators.CompareString(row["IdViaggio"].ToString(), "", false) == 0)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "La sub-spedizione con Id {0} appartiene al viaggio {1}. Liberare la sub-spedizione prima di procedere alla modifica. Impossibile modificare le sub-spedizioni.", new string[2]
						{
							_Unibol,
							row["IdViaggio"].ToString()
						});
					}
					goto end_IL_000b;
				}
				goto IL_017f;
			}
			val2 = val;
			goto end_IL_000b;
			IL_017f:
			val2 = (FXRETURN)0;
			end_IL_000b:;
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

	protected FXRETURN CreateQueryUPDATE(object obj, ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Invalid comparison between Unknown and I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties(RuntimeHelpers.GetObjectValue(obj));
			sQuery = "UPDATE %TABLENAME% SET ";
			PropertyInfo[] array = publicProperties;
			foreach (PropertyInfo propertyInfo in array)
			{
				Dictionary<string, object> customListAttributesForProperties = IncasReflection.GetCustomListAttributesForProperties(propertyInfo);
				bool flag = true;
				if (customListAttributesForProperties.ContainsKey("Bind"))
				{
					flag = Conversions.ToBoolean(customListAttributesForProperties["Bind"]);
				}
				if (!flag)
				{
					continue;
				}
				object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue != null)
				{
					sQuery = sQuery + propertyInfo.Name + "=";
					eTipoDati val3 = modGeneral.DataTypeToBaseType(objectValue.GetType());
					if ((int)val3 == 0)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue.ToString()) + ",";
					}
					else if ((int)val3 == 3)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(objectValue)) + ",";
					}
					else if ((int)val3 == 2 || (int)val3 == 1)
					{
						string obj2 = sQuery;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue);
						sQuery = obj2 + dbConn.SQLFormatNumber(ref pNumero) + ",";
					}
					else
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue.ToString()) + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1)) + " ";
			sQuery += "WHERE 1=1 ";
			Dictionary<string, object> customListAttributes = IncasReflection.GetCustomListAttributes(RuntimeHelpers.GetObjectValue(obj));
			if (customListAttributes.ContainsKey("TableName"))
			{
				sQuery = sQuery.Replace("%TABLENAME%", customListAttributes["TableName"].ToString());
			}
			if (customListAttributes.ContainsKey("Key"))
			{
				string[] array2 = (string[])customListAttributes["Key"];
				string[] array3 = array2;
				foreach (string text in array3)
				{
					sQuery = sQuery + " AND " + text + "=" + ((AppBaseClass)this).DbConn.SQLFormatString(IncasReflection.GetPropertyValue(RuntimeHelpers.GetObjectValue(obj), text).ToString()) + " ";
				}
			}
			sQuery += ";";
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

	protected FXRETURN CheckPartenza(string PCSPartenza, ref SubSpedizione SubSpedizione, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM PCS WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(PCSPartenza) + " AND PuntoDiCarico='S'";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Punto di carico {0} non esiste", new string[1] { PCSPartenza });
				val2 = (FXRETURN)14;
			}
			else if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Punto di carico {0} non è attivo", new string[1] { PCSPartenza });
				val2 = (FXRETURN)16;
			}
			else
			{
				if (Operators.CompareString(PCSPartenza, ((ApplicationDefault)(object)this._ApiContext.AppDefault).PCS_Generico_Default(), false) != 0)
				{
					SubSpedizione.PCSPartenza_RagSoc = rObjDataTable.Rows[0]["RagioneSociale"].ToString();
					SubSpedizione.PCSPartenza_Localita = rObjDataTable.Rows[0]["Localita"].ToString();
					SubSpedizione.PCSPartenza_Indirizzo = rObjDataTable.Rows[0]["Indirizzo"].ToString();
					SubSpedizione.PCSPartenza_Cap = rObjDataTable.Rows[0]["Cap"].ToString();
					SubSpedizione.PCSPartenza_Provincia = rObjDataTable.Rows[0]["Provincia"].ToString();
					SubSpedizione.PCSPartenza_Nazione = rObjDataTable.Rows[0]["Nazione"].ToString();
				}
				SubSpedizione.PCSPartenza = PCSPartenza;
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

	protected FXRETURN CheckDestinazione(string PCSDestinazione, ref SubSpedizione SubSpedizione, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Invalid comparison between Unknown and I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM PCS WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(PCSDestinazione);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il PCS {0} non esiste", new string[1] { PCSDestinazione });
				val2 = (FXRETURN)14;
			}
			else if (Operators.CompareString(rObjDataTable.Rows[0]["PuntoDiDestino"].ToString(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il PCS {0} non è definito come punto di destino", new string[1] { PCSDestinazione });
				val2 = (FXRETURN)16;
			}
			else if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Punto di destinazione {0} non è attivo", new string[1] { PCSDestinazione });
				val2 = (FXRETURN)16;
			}
			else
			{
				if (Operators.CompareString(rObjDataTable.Rows[0]["CEDI"].ToString(), "", false) == 0)
				{
					goto IL_02ac;
				}
				PCSDestinazione = rObjDataTable.Rows[0]["CEDI"].ToString();
				text = "SELECT * FROM PCS WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(PCSDestinazione);
				rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il PCS {0} non esiste", new string[1] { PCSDestinazione });
					val2 = (FXRETURN)14;
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["PuntoDiDestino"].ToString(), "S", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il PCS {0} non è definito come punto di destino", new string[1] { PCSDestinazione });
					val2 = (FXRETURN)16;
				}
				else
				{
					if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) == 0)
					{
						goto IL_02ac;
					}
					rsmess = this.TranslateMessage("XXX", "Il Punto di destinazione {0} non è attivo", new string[1] { PCSDestinazione });
					val2 = (FXRETURN)16;
				}
			}
			goto end_IL_000e;
			IL_02ac:
			if (Operators.CompareString(PCSDestinazione, ((ApplicationDefault)(object)this._ApiContext.AppDefault).PCS_Generico_Default(), false) != 0)
			{
				SubSpedizione.PCSDestinazione_RagSoc = rObjDataTable.Rows[0]["RagioneSociale"].ToString();
				SubSpedizione.PCSDestinazione_Localita = rObjDataTable.Rows[0]["Localita"].ToString();
				SubSpedizione.PCSDestinazione_Indirizzo = rObjDataTable.Rows[0]["Indirizzo"].ToString();
				SubSpedizione.PCSDestinazione_Cap = rObjDataTable.Rows[0]["Cap"].ToString();
				SubSpedizione.PCSDestinazione_Provincia = rObjDataTable.Rows[0]["Provincia"].ToString();
				SubSpedizione.PCSDestinazione_Nazione = rObjDataTable.Rows[0]["Nazione"].ToString();
			}
			SubSpedizione.PCSDestinazione = PCSDestinazione;
			val2 = (FXRETURN)0;
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

	protected FXRETURN CheckZone(string NewCorrispondente, string OldCorrispondente, ref SubSpedizione SubSpedizione, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Invalid comparison between Unknown and I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Information.IsNothing((object)SubSpedizione.PCSDestinazione))
			{
				goto IL_01ce;
			}
			text = "SELECT Z.*, CASE WHEN TipoMerce='*ALL' THEN 1 ELSE 10 END Peso ";
			text = text + "FROM pcs_zone Z WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(SubSpedizione.PCSDestinazione) + " ";
			text = text + "AND TipoMerce in (" + ((AppBaseClass)this).DbConn.SQLFormatString(SubSpedizione.TipoMerce) + ", '*ALL') ORDER By Peso DESC";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count != 0)
				{
					if (SubSpedizione.ZonaSpedizione == null || Operators.CompareString(SubSpedizione.ZonaSpedizione, "", false) == 0)
					{
						SubSpedizione.ZonaSpedizione = rObjDataTable.Rows[0]["ZonaSpedizione"].ToString();
					}
					if (SubSpedizione.ZonaArrivoTariffaAttiva == null || Operators.CompareString(SubSpedizione.ZonaArrivoTariffaAttiva, "", false) == 0)
					{
						SubSpedizione.ZonaArrivoTariffaAttiva = rObjDataTable.Rows[0]["ZonaTariffaAttiva"].ToString();
					}
					if (SubSpedizione.ZonaArrivoTariffaPassiva == null || Operators.CompareString(SubSpedizione.ZonaArrivoTariffaPassiva, "", false) == 0)
					{
						SubSpedizione.ZonaArrivoTariffaPassiva = rObjDataTable.Rows[0]["ZonaTariffaPassiva"].ToString();
					}
					goto IL_01ce;
				}
				rsmess = this.TranslateMessage("XXX", "Zone non configurate per la destinazione {0}", new string[1] { SubSpedizione.PCSDestinazione });
				val2 = (FXRETURN)14;
			}
			goto end_IL_000e;
			IL_02e5:
			if (!((Operators.CompareString(NewCorrispondente, "", false) != 0) & (Operators.CompareString(NewCorrispondente, OldCorrispondente, false) != 0)))
			{
				if ((Operators.CompareString(NewCorrispondente, "", false) == 0) & (Operators.CompareString(OldCorrispondente, "", false) != 0))
				{
					SubSpedizione.Corrispondente = "";
					SubSpedizione.ZonaPartenzaTariffaPassiva = "";
				}
				goto IL_0447;
			}
			text = "SELECT Z.*, CASE WHEN TipoMerce='*ALL' THEN 1 ELSE 10 END Peso ";
			text = text + "FROM PCS_ZONE Z WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(NewCorrispondente) + " ";
			text = text + "AND TipoMerce in (" + ((AppBaseClass)this).DbConn.SQLFormatString(SubSpedizione.TipoMerce) + ", '*ALL') ORDER By Peso DESC";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count != 0)
				{
					if (SubSpedizione.ZonaPartenzaTariffaPassiva == null || Operators.CompareString(SubSpedizione.ZonaPartenzaTariffaPassiva, "", false) == 0)
					{
						SubSpedizione.ZonaPartenzaTariffaPassiva = rObjDataTable.Rows[0]["ZonaTariffaPassiva"].ToString();
					}
					SubSpedizione.Corrispondente = NewCorrispondente;
					goto IL_0447;
				}
				rsmess = this.TranslateMessage("XXX", "Zone non configurate per il corrispondente {0}", new string[1] { NewCorrispondente });
				val2 = (FXRETURN)14;
			}
			goto end_IL_000e;
			IL_01ce:
			if (Information.IsNothing((object)SubSpedizione.PCSPartenza))
			{
				goto IL_02e5;
			}
			text = "SELECT Z.*, CASE WHEN TipoMerce='*ALL' THEN 1 ELSE 10 END Peso ";
			text = text + "FROM PCS_ZONE Z WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(SubSpedizione.PCSPartenza) + " ";
			text = text + "AND TipoMerce in (" + ((AppBaseClass)this).DbConn.SQLFormatString(SubSpedizione.TipoMerce) + ", '*ALL') ORDER By Peso DESC";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count != 0)
				{
					if (SubSpedizione.ZonaPartenzaTariffaAttiva == null || Operators.CompareString(SubSpedizione.ZonaPartenzaTariffaAttiva, "", false) == 0)
					{
						SubSpedizione.ZonaPartenzaTariffaAttiva = rObjDataTable.Rows[0]["ZonaTariffaAttiva"].ToString();
					}
					goto IL_02e5;
				}
				rsmess = this.TranslateMessage("XXX", "Zone non configurate per il punto di partenza {0}", new string[1] { SubSpedizione.PCSPartenza });
				val2 = (FXRETURN)14;
			}
			goto end_IL_000e;
			IL_0447:
			val2 = (FXRETURN)0;
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
}
