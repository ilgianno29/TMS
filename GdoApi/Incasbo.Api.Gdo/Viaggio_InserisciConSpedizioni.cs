using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_InserisciConSpedizioni : AppAbstractApi
{
	protected Viaggio _Viaggio;

	protected List<string> _ListOfUnibol;

	protected string _IdViaggioLinea;

	protected DateTime? _DataEvento;

	public Viaggio_InserisciConSpedizioni(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ListOfUnibol = null;
		_IdViaggioLinea = "";
		_DataEvento = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Viaggio = (Viaggio)base._ParametersIn["Viaggio"];
			base._ParametersOut.Add("Viaggio", _Viaggio);
			if (base._ParametersIn.ContainsKey("IdViaggioLinea"))
			{
				_IdViaggioLinea = base._ParametersIn["IdViaggioLinea"].ToString();
			}
			if (base._ParametersIn.ContainsKey("DataEvento"))
			{
				_DataEvento = (DateTime?)base._ParametersIn["DataEvento"];
			}
			_ListOfUnibol = (List<string>)base._ParametersIn["ElencoUnibol"];
			if (_ListOfUnibol.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Nessuna spedizione da associare al viaggio");
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Invalid comparison between Unknown and I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Invalid comparison between Unknown and I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Invalid comparison between Unknown and I4
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Invalid comparison between Unknown and I4
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Invalid comparison between Unknown and I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = Viaggio_Inserisci_Invoker.Instance.RunProc(this._ApiContext, _IdViaggioLinea, ref _Viaggio, _DataEvento, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(this._ApiContext, _ListOfUnibol, _Viaggio.IdViaggio, _DataEvento, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					string text = "N";
					DataTable rObjDataTable = null;
					string text2 = "";
					string vsStringa = "";
					decimal pNumero = default(decimal);
					string text3 = "";
					text2 = "SELECT C.RAGIONESOCIALE FROM VIAGGI V INNER JOIN SPEDIZIONI S ON V.IDVIAGGIO = S.IDVIAGGIO INNER JOIN CORRISPONDENTI C ON C.CODICE = S.CORRISPONDENTE ";
					text2 = text2 + "WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.IdViaggio);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (rObjDataTable.Rows.Count > 0)
						{
							vsStringa = rObjDataTable.Rows[0]["RAGIONESOCIALE"].ToString();
						}
						rObjDataTable = null;
						text2 = "";
						text2 = "SELECT PORTATAPALLET FROM VIAGGI V INNER JOIN MEZZI M ON V.MOTRICEPIANIFICATA = M.CODICE WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.IdViaggio);
						val = ((AppBaseClass)this).DbConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							if (rObjDataTable.Rows.Count > 0)
							{
								pNumero = Conversions.ToDecimal(rObjDataTable.Rows[0]["PORTATAPALLET"]);
							}
							rObjDataTable = null;
							text2 = "";
							text2 = text2 + "Select DataPartenzaPianificata from Viaggi inner join Spedizioni on Viaggi.IdViaggio = Spedizioni.IdViaggio WHERE Viaggi.IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.IdViaggio) + ";";
							val = ((AppBaseClass)this).DbConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								DateTime vsData = default(DateTime);
								if (rObjDataTable.Rows.Count > 0)
								{
									vsData = Conversions.ToDate(rObjDataTable.Rows[0]["DataPartenzaPianificata"]);
								}
								rObjDataTable = null;
								DateTime minValue = DateTime.MinValue;
								string text4 = "";
								int num = 0;
								text2 = "";
								text2 = "SELECT * FROM CST_LUC_HSTSTATOVIAGGITX WHERE HStaVia_Luc_NumViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.IdViaggio) + " ORDER BY HST_DATAINSERIMENTO DESC";
								val = ((AppBaseClass)this).DbConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else if (rObjDataTable.Rows.Count > 0)
								{
									minValue = Conversions.ToDate(rObjDataTable.Rows[0]["HST_DATAINSERIMENTO"]);
									text4 = Conversions.ToString(rObjDataTable.Rows[0]["HStaVia_Luc_StatoViaggioDelsy"]);
									num = Conversions.ToInteger(rObjDataTable.Rows[0]["HSt_Id"]);
									DateTime now = DateAndTime.Now;
									if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, now, minValue, (FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 5)
									{
										text3 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
										text3 = text3 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
										text3 = text3 + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
										val = ((AppBaseClass)this).DbConn.SqlExec(text3, ref rsmess);
										if ((int)val <= 0)
										{
											goto IL_055e;
										}
										val2 = val;
									}
									else
									{
										if (Operators.CompareString(text, text4, false) == 0)
										{
											goto IL_055e;
										}
										text3 = "UPDATE CST_LUC_HSTSTATOVIAGGITX SET HStaVia_Luc_StatoViaggioDelsy = " + ((AppBaseClass)this).DbConn.SQLFormatString(text) + ", Hst_Tag = '' ";
										text3 = text3 + "WHERE HSt_Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num);
										val = ((AppBaseClass)this).DbConn.SqlExec(text3, ref rsmess);
										if ((int)val <= 0)
										{
											goto IL_055e;
										}
										val2 = val;
									}
								}
								else
								{
									text3 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
									text3 = text3 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
									text3 = text3 + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
									val = ((AppBaseClass)this).DbConn.SqlExec(text3, ref rsmess);
									if ((int)val <= 0)
									{
										goto IL_055e;
									}
									val2 = val;
								}
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_055e:
			val2 = (FXRETURN)0;
			end_IL_0005:;
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
