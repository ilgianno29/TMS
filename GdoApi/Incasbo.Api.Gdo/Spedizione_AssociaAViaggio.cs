using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_AssociaAViaggio : AppAbstractApi
{
	protected string _IdViaggio;

	protected DateTime? _DataEvento;

	protected List<string> _ListOfUnibol;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	public Spedizione_AssociaAViaggio(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_DataEvento = null;
		_dtViaggio = null;
		_dtSpedizioni = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_ListOfUnibol = (List<string>)((AppAbstractApi)this).ParametersIn["ListOfUnibol"];
			_DataEvento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataEvento"];
			if (!_DataEvento.HasValue)
			{
				_DataEvento = DateAndTime.Now;
			}
			val = CheckSpedizioni(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckViaggio(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Invalid comparison between Unknown and I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Invalid comparison between Unknown and I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Invalid comparison between Unknown and I4
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Invalid comparison between Unknown and I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Invalid comparison between Unknown and I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Invalid comparison between Unknown and I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Invalid comparison between Unknown and I4
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Invalid comparison between Unknown and I4
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Invalid comparison between Unknown and I4
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			foreach (string item in _ListOfUnibol)
			{
				text = text + "UPDATE Spedizioni SET IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", CostoViaggioRipartito=0, CostoViaggioRipartitoNolo=0, RicavoViaggioRipartito=0, RicavoViaggioRipartitoNolo=0, SequenzaPianificata=%ISNULL%(SequenzaOriginale,0) WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ";";
				string RetQueryToApply = "";
				val = EventoSpedizione_AssociaAViaggio.RunProc(this._ApiContext, item, _DataEvento, _IdViaggio, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val <= 0)
				{
					text += RetQueryToApply;
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_01ff;
			}
			text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string RetQueryToApply2 = "";
				val = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, ApplyQuery: false, ref RetQueryToApply2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(RetQueryToApply2, "", false) == 0)
					{
						goto IL_019b;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(RetQueryToApply2, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_019b;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_06f9:
			val2 = (FXRETURN)0;
			goto end_IL_000b;
			IL_019b:
			foreach (string item2 in _ListOfUnibol)
			{
				val = WMS_Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(this._ApiContext, item2, _IdViaggio, ref rsmess);
				if ((int)val <= 0)
				{
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			goto IL_01ff;
			IL_01ff:
			string text2 = "N";
			DataTable rObjDataTable = null;
			string text3 = "";
			string vsStringa = "";
			decimal pNumero = default(decimal);
			int num = 0;
			string text4 = "";
			text3 = "SELECT C.RAGIONESOCIALE, V.STATO FROM VIAGGI V LEFT JOIN SPEDIZIONI S ON V.IDVIAGGIO = S.IDVIAGGIO LEFT JOIN CORRISPONDENTI C ON C.CODICE = S.CORRISPONDENTE ";
			text3 = text3 + "WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count > 0)
				{
					vsStringa = rObjDataTable.Rows[0]["RAGIONESOCIALE"].ToString();
					num = Conversions.ToInteger(rObjDataTable.Rows[0]["STATO"].ToString());
					if (num > 10)
					{
						text2 = "Y";
					}
				}
				rObjDataTable = null;
				text3 = "";
				text3 = "SELECT PORTATAPALLET FROM VIAGGI V INNER JOIN MEZZI M ON V.MOTRICEPIANIFICATA = M.CODICE WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
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
					text3 = "";
					text3 = text3 + "Select DataPartenzaPianificata from Viaggi inner join Spedizioni on Viaggi.IdViaggio = Spedizioni.IdViaggio WHERE Viaggi.IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
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
						string text5 = "";
						int num2 = 0;
						text3 = "";
						text3 = "SELECT * FROM CST_LUC_HSTSTATOVIAGGITX WHERE HStaVia_Luc_NumViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ORDER BY HST_DATAINSERIMENTO DESC";
						val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else if (rObjDataTable.Rows.Count > 0)
						{
							minValue = Conversions.ToDate(rObjDataTable.Rows[0]["HST_DATAINSERIMENTO"]);
							text5 = Conversions.ToString(rObjDataTable.Rows[0]["HStaVia_Luc_StatoViaggioDelsy"]);
							num2 = Conversions.ToInteger(rObjDataTable.Rows[0]["HSt_Id"]);
							DateTime now = DateAndTime.Now;
							if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, now, minValue, (FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 5)
							{
								text4 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
								text4 = text4 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
								text4 = text4 + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
								val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
								if ((int)val <= 0)
								{
									goto IL_06f9;
								}
								val2 = val;
							}
							else
							{
								if (Operators.CompareString(text2, text5, false) == 0)
								{
									goto IL_06f9;
								}
								text4 = "UPDATE CST_LUC_HSTSTATOVIAGGITX SET HStaVia_Luc_StatoViaggioDelsy = " + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", Hst_Tag = '' ";
								text4 = text4 + "WHERE HSt_Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num2);
								val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
								if ((int)val <= 0)
								{
									goto IL_06f9;
								}
								val2 = val;
							}
						}
						else
						{
							text4 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
							text4 = text4 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
							text4 = text4 + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
							val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
							if ((int)val <= 0)
							{
								goto IL_06f9;
							}
							val2 = val;
						}
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

	protected FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT IdViaggio,Stato FROM Viaggi WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non esiste", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) != 10)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} risulta in uno stato che non permette l'associazione di una spedizione", new string[1] { _IdViaggio });
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

	protected FXRETURN CheckSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_ListOfUnibol.Count <= 0)
			{
				goto IL_0219;
			}
			string text2 = "";
			foreach (string item in _ListOfUnibol)
			{
				text2 = text2 + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ",";
			}
			text2 = Strings.Left(text2, checked(Strings.Len(text2) - 1));
			text = "SELECT Unibol,IdViaggio,Stato FROM Spedizioni WHERE Unibol IN (" + text2 + ")";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val <= 0)
			{
				foreach (string item2 in _ListOfUnibol)
				{
					DataRow[] array = _dtSpedizioni.Select("UNIBOL='" + item2 + "'");
					if (array.Count() == 0)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { item2 });
					}
					else if (Operators.CompareString(array[0]["IdViaggio"].ToString(), "", false) != 0)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} risulta già associata al viaggio {1}", new string[2]
						{
							item2,
							array[0]["IdViaggio"].ToString()
						});
					}
					else
					{
						if (Conversions.ToInteger(array[0]["Stato"]) == 20)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permetta l'associazione ad un viaggio (Stato attuale della spedizione={1})", new string[2]
						{
							item2,
							array[0]["Stato"].ToString()
						});
					}
					goto end_IL_000b;
				}
				goto IL_0219;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0219:
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
}
