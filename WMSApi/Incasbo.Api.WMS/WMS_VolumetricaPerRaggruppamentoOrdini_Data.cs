using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

internal class WMS_VolumetricaPerRaggruppamentoOrdini_Data : AppAbstractApi
{
	protected Dictionary<string, object> _DataInfo;

	protected StringCollection _Unibols;

	protected string _Viaggio;

	protected string _CodiceRaggruppamento;

	public WMS_VolumetricaPerRaggruppamentoOrdini_Data(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_DataInfo = new Dictionary<string, object>();
		_Viaggio = "";
		_CodiceRaggruppamento = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			base._ParametersOut.Add("DataInfo", _DataInfo);
			_Unibols = (StringCollection)base._ParametersIn["Unibols"];
			_Viaggio = base._ParametersIn["Viaggio"].ToString();
			_CodiceRaggruppamento = base._ParametersIn["CodiceRaggruppamento"].ToString();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			object objRes = null;
			text = "SELECT %ISNULL%(M.Altezza,0) Altezza FROM Viaggi V LEFT JOIN Mezzi M ON ISNULL(V.Contenitore1Pianificato,V.MotricePianificata)=M.CODICE WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio);
			text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			val = ((AppBaseClass)this).DbConn.DoSql(text, 0, ref objRes, ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
				StringEnumerator enumerator = _Unibols.GetEnumerator();
				while (true)
				{
					if (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						text = "SELECT Unibol, Cliente, NumeroOrdine, DataOrdine FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(current);
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
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						DataRow dataRow = rObjDataTable.Rows[0];
						dictionary.Add("SpedizioneCommittente", dataRow["Cliente"].ToString());
						dictionary.Add("SpedizioneOrdine", dataRow["NumeroOrdine"].ToString());
						dictionary.Add("SpedizioneData", RuntimeHelpers.GetObjectValue(dataRow["DataOrdine"]));
						dataRow = null;
						list.Add(dictionary);
						continue;
					}
					_DataInfo.Add("OrdiniListObject", list);
					_DataInfo.Add("ViaggioCodice", _Viaggio);
					_DataInfo.Add("IdRaggruppamentoOrdini", _CodiceRaggruppamento);
					_DataInfo.Add("ViaggioAltezzaMezzo", Conversions.ToDecimal(objRes));
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Viaggio, StringCollection Unibols, string CodiceRaggruppamento, ref Dictionary<string, object> DataInfo, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			WMS_VolumetricaPerRaggruppamentoOrdini_Data wMS_VolumetricaPerRaggruppamentoOrdini_Data = new WMS_VolumetricaPerRaggruppamentoOrdini_Data(objApiContext);
			((AppAbstractApi)wMS_VolumetricaPerRaggruppamentoOrdini_Data).ParametersIn.Add("Unibols", Unibols);
			((AppAbstractApi)wMS_VolumetricaPerRaggruppamentoOrdini_Data).ParametersIn.Add("Viaggio", Viaggio);
			((AppAbstractApi)wMS_VolumetricaPerRaggruppamentoOrdini_Data).ParametersIn.Add("CodiceRaggruppamento", CodiceRaggruppamento);
			val = ((AppAbstractApi)wMS_VolumetricaPerRaggruppamentoOrdini_Data).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				DataInfo = (Dictionary<string, object>)((AppAbstractApi)wMS_VolumetricaPerRaggruppamentoOrdini_Data).ParametersOut["DataInfo"];
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
