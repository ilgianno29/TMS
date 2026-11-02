using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_Riapri : AppAbstractApi
{
	protected string _IdViaggio;

	protected DateTime? _DataEvento;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	public Viaggio_Riapri(AppApiContext objApiContext)
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
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_DataEvento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataEvento"];
			if (!_DataEvento.HasValue)
			{
				_DataEvento = DateAndTime.Now;
			}
			val = CheckViaggio(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckSpedizioni(ref rsmess);
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
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Invalid comparison between Unknown and I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Invalid comparison between Unknown and I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Invalid comparison between Unknown and I4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Invalid comparison between Unknown and I4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Invalid comparison between Unknown and I4
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Invalid comparison between Unknown and I4
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Invalid comparison between Unknown and I4
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = text + "UPDATE Viaggi SET Stato=10 WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
			string text2 = "";
			foreach (DataRow row in _dtSpedizioni.Rows)
			{
				text = text + "UPDATE Spedizioni SET Stato=20 WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Unibol"].ToString()) + ";";
				text2 = "";
				val = EventoSpedizione_Ripianifica.RunProc(this._ApiContext, row["Unibol"].ToString(), _DataEvento, this._User, ApplyQuery: false, ref text2, ref rsmess);
				if ((int)val <= 0)
				{
					text += text2;
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			text2 = "";
			val = EventoViaggio_Riapri.RunProc(this._ApiContext, _IdViaggio, _DataEvento, this._User, ApplyQuery: false, ref text2, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += text2;
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_0188;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0188;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_0188:
			val = WMS_Viaggio_Riapri_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text3 = "N";
				DataTable rObjDataTable = null;
				string text4 = "";
				string vsStringa = "";
				decimal pNumero = default(decimal);
				string text5 = "";
				text4 = "SELECT C.RAGIONESOCIALE FROM VIAGGI V INNER JOIN SPEDIZIONI S ON V.IDVIAGGIO = S.IDVIAGGIO INNER JOIN CORRISPONDENTI C ON C.CODICE = S.CORRISPONDENTE ";
				text4 = text4 + "WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text4, ref rObjDataTable, ref rsmess);
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
					text4 = "";
					text4 = "SELECT PORTATAPALLET FROM VIAGGI V INNER JOIN MEZZI M ON V.MOTRICEPIANIFICATA = M.CODICE WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text4, ref rObjDataTable, ref rsmess);
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
						text4 = "";
						text4 = text4 + "Select DataPartenzaPianificata from Viaggi inner join Spedizioni on Viaggi.IdViaggio = Spedizioni.IdViaggio WHERE Viaggi.IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
						val = ((AppBaseClass)this).DbConn.OpenDataTable(text4, ref rObjDataTable, ref rsmess);
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
							string text6 = "";
							int num = 0;
							text4 = "";
							text4 = "SELECT * FROM CST_LUC_HSTSTATOVIAGGITX WHERE HStaVia_Luc_NumViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ORDER BY HST_DATAINSERIMENTO DESC";
							val = ((AppBaseClass)this).DbConn.OpenDataTable(text4, ref rObjDataTable, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else if (rObjDataTable.Rows.Count > 0)
							{
								minValue = Conversions.ToDate(rObjDataTable.Rows[0]["HST_DATAINSERIMENTO"]);
								text6 = Conversions.ToString(rObjDataTable.Rows[0]["HStaVia_Luc_StatoViaggioDelsy"]);
								num = Conversions.ToInteger(rObjDataTable.Rows[0]["HSt_Id"]);
								DateTime now = DateAndTime.Now;
								if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, now, minValue, (FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 5)
								{
									text5 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
									text5 = text5 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text3) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
									text5 = text5 + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
									val = ((AppBaseClass)this).DbConn.SqlExec(text5, ref rsmess);
									if ((int)val <= 0)
									{
										goto IL_0671;
									}
									val2 = val;
								}
								else
								{
									if (Operators.CompareString(text3, text6, false) == 0)
									{
										goto IL_0671;
									}
									text5 = "UPDATE CST_LUC_HSTSTATOVIAGGITX SET HStaVia_Luc_StatoViaggioDelsy = " + ((AppBaseClass)this).DbConn.SQLFormatString(text3) + ", Hst_Tag = '' ";
									text5 = text5 + "WHERE HSt_Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num);
									val = ((AppBaseClass)this).DbConn.SqlExec(text5, ref rsmess);
									if ((int)val <= 0)
									{
										goto IL_0671;
									}
									val2 = val;
								}
							}
							else
							{
								text5 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
								text5 = text5 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text3) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
								text5 = text5 + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
								val = ((AppBaseClass)this).DbConn.SqlExec(text5, ref rsmess);
								if ((int)val <= 0)
								{
									goto IL_0671;
								}
								val2 = val;
							}
						}
					}
				}
			}
			goto end_IL_000b;
			IL_0671:
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
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
			text = "SELECT * FROM Viaggi WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non esiste", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) != 20)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non risulta chiuso", new string[1] { _IdViaggio });
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

	protected virtual FXRETURN CheckSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Unibol, NumeroBolla FROM Spedizioni WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
				}
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
