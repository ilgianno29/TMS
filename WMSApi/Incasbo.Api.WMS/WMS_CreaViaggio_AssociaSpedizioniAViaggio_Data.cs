using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

internal class WMS_CreaViaggio_AssociaSpedizioniAViaggio_Data : AppAbstractApi
{
	protected Dictionary<string, object> _DataInfo;

	protected StringCollection _Unibols;

	protected string _Viaggio;

	public WMS_CreaViaggio_AssociaSpedizioniAViaggio_Data(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_DataInfo = new Dictionary<string, object>();
		_Viaggio = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			base._ParametersOut.Add("DataInfo", _DataInfo);
			if (!base._ParametersIn.ContainsKey("Unibols"))
			{
				rsmess = this.TranslateMessage("XXX", "Parametro Unibols non specificato.");
			}
			else
			{
				_Unibols = (StringCollection)base._ParametersIn["Unibols"];
				if (!base._ParametersIn.ContainsKey("Viaggio"))
				{
					rsmess = this.TranslateMessage("XXX", "Parametro Viaggio non specificato.");
				}
				else
				{
					_Viaggio = base._ParametersIn["Viaggio"].ToString();
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Invalid comparison between Unknown and I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM VW_WMS_VIAGGI ";
			string text2 = text;
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			int pNumero = Conversions.ToInteger(_Viaggio);
			text = text2 + "WHERE IdViaggio = " + dbConn.SQLFormatNumber(ref pNumero);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Viaggio {0} non trovato.", new string[1] { _Viaggio });
			}
			else
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				DataRow dataRow = rObjDataTable.Rows[0];
				dictionary.Add("ViaggioAltezzaMezzo", Conversions.ToInteger(dataRow["AltezzaMezzo"]));
				dictionary.Add("ViaggioCodice", _Viaggio);
				dictionary.Add("ViaggioDataRiferimento", Conversions.ToDate(dataRow["DataRiferimento"]));
				dictionary.Add("ViaggioVettore", dataRow["Vettore"].ToString());
				dataRow = null;
				_DataInfo.Add("OggettoViaggio", dictionary);
				List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
				StringEnumerator enumerator = _Unibols.GetEnumerator();
				while (true)
				{
					if (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						text = "SELECT Unibol, Cliente, NumeroOrdine, DataOrdine, SequenzaPianificata FROM Spedizioni WHERE Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(current);
						val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
						if ((int)val != 0)
						{
							val2 = val;
							break;
						}
						if (rObjDataTable.Rows.Count == 0)
						{
							rsmess = this.TranslateMessage("XXX", "Spedizione {0} non trovata.", new string[1] { current });
							break;
						}
						Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
						DataRow dataRow2 = rObjDataTable.Rows[0];
						dictionary2.Add("SpedizioneCommittente", dataRow2["Cliente"].ToString());
						dictionary2.Add("SpedizioneOrdine", dataRow2["NumeroOrdine"].ToString());
						dictionary2.Add("SpedizioneData", RuntimeHelpers.GetObjectValue(dataRow2["DataOrdine"]));
						dictionary2.Add("SequenzaConsegna", RuntimeHelpers.GetObjectValue(dataRow2["SequenzaPianificata"]));
						dataRow2 = null;
						list.Add(dictionary2);
						continue;
					}
					_DataInfo.Add("OrdiniListObject", list);
					val2 = (FXRETURN)0;
					break;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Viaggio, StringCollection Unibols, ref Dictionary<string, object> DataInfo, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			WMS_CreaViaggio_AssociaSpedizioniAViaggio_Data wMS_CreaViaggio_AssociaSpedizioniAViaggio_Data = new WMS_CreaViaggio_AssociaSpedizioniAViaggio_Data(objApiContext);
			((AppAbstractApi)wMS_CreaViaggio_AssociaSpedizioniAViaggio_Data).ParametersIn.Add("Unibols", Unibols);
			((AppAbstractApi)wMS_CreaViaggio_AssociaSpedizioniAViaggio_Data).ParametersIn.Add("Viaggio", Viaggio);
			val = ((AppAbstractApi)wMS_CreaViaggio_AssociaSpedizioniAViaggio_Data).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				DataInfo = (Dictionary<string, object>)((AppAbstractApi)wMS_CreaViaggio_AssociaSpedizioniAViaggio_Data).ParametersOut["DataInfo"];
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = (FXRETURN)3;
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
