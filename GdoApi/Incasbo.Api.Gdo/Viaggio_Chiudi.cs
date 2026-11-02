using System;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_Chiudi : GdoAbstractApi
{
	protected string _IdViaggio;

	protected DateTime? _DataEvento;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	protected bool _IgnoraErroreWMS;

	protected StringCollection _IdViaggiTrattaCompleta;

	public Viaggio_Chiudi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_DataEvento = null;
		_dtViaggio = null;
		_dtSpedizioni = null;
		_IgnoraErroreWMS = false;
		_IdViaggiTrattaCompleta = new StringCollection();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Invalid comparison between Unknown and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("IgnoraErroreWMS"))
			{
				_IgnoraErroreWMS = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["IgnoraErroreWMS"]);
			}
			val = CheckViaggio(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckSpedizioni(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = Viaggio_VerificaVincoliDiTipoViaggio_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, CheckCampiObbligatori: true, Operators.CompareString(_dtViaggio.Rows[0]["IdViaggioOBC"].ToString(), "", false) == 0, ref rsmess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Invalid comparison between Unknown and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Invalid comparison between Unknown and I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Invalid comparison between Unknown and I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Invalid comparison between Unknown and I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Invalid comparison between Unknown and I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Invalid comparison between Unknown and I4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Invalid comparison between Unknown and I4
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Invalid comparison between Unknown and I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Invalid comparison between Unknown and I4
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Invalid comparison between Unknown and I4
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Invalid comparison between Unknown and I4
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string RetQueryToApply = "";
			val = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, _IgnoraErroreWMS, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += RetQueryToApply;
				text = text + "UPDATE Viaggi SET Stato=20 WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
					text = text + "UPDATE Spedizioni SET Stato=30 WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Unibol"].ToString()) + ";";
					RetQueryToApply = "";
					val = EventoSpedizione_Pianificata.RunProc(this._ApiContext, row["Unibol"].ToString(), _DataEvento, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += RetQueryToApply;
						RetQueryToApply = "";
						val = AbilitaCalcoloVettoreSuSpedizione(row, ref RetQueryToApply, ref rsmess);
						if ((int)val <= 0)
						{
							text += RetQueryToApply;
							continue;
						}
						val2 = val;
					}
					goto end_IL_000b;
				}
				RetQueryToApply = "";
				val = EventoViaggio_Chiudi.RunProc(this._ApiContext, _IdViaggio, _DataEvento, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += RetQueryToApply;
					if (Operators.CompareString(text, "", false) == 0)
					{
						goto IL_01f2;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_01f2;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_01f2:
			val = WMS_Viaggio_CreaEAssocia_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				StringEnumerator enumerator2 = _IdViaggiTrattaCompleta.GetEnumerator();
				DateTime vsData = default(DateTime);
				while (true)
				{
					if (enumerator2.MoveNext())
					{
						string current = enumerator2.Current;
						val = Viaggio_Chiudi_Invoker.Instance.RunProc(this._ApiContext, current, _DataEvento, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
							break;
						}
						continue;
					}
					string text2 = "Y";
					DataTable rObjDataTable = null;
					string text3 = "";
					string text4 = "";
					string vsStringa = "";
					decimal pNumero = default(decimal);
					text3 = "SELECT C.RAGIONESOCIALE FROM VIAGGI V INNER JOIN SPEDIZIONI S ON V.IDVIAGGIO = S.IDVIAGGIO INNER JOIN CORRISPONDENTI C ON C.CODICE = S.CORRISPONDENTE ";
					text3 = text3 + "WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					if (rObjDataTable.Rows.Count > 0)
					{
						vsStringa = rObjDataTable.Rows[0]["RAGIONESOCIALE"].ToString();
					}
					rObjDataTable = null;
					text3 = "";
					text3 = "SELECT PORTATAPALLET FROM VIAGGI V INNER JOIN MEZZI M ON V.MOTRICEPIANIFICATA = M.CODICE WHERE V.IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					if (rObjDataTable.Rows.Count > 0)
					{
						pNumero = Conversions.ToDecimal(rObjDataTable.Rows[0]["PORTATAPALLET"]);
					}
					rObjDataTable = null;
					text3 = "";
					text3 = "Select DataPartenzaPianificata from Viaggi inner join Spedizioni on Viaggi.IdViaggio = Spedizioni.IdViaggio WHERE Viaggi.IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					if (rObjDataTable.Rows.Count > 0)
					{
						vsData = Conversions.ToDate(rObjDataTable.Rows[0]["DataPartenzaPianificata"]);
					}
					rObjDataTable = null;
					DateTime minValue = DateTime.MinValue;
					string text5 = "";
					int num = 0;
					text3 = "";
					text3 = "SELECT * FROM CST_LUC_HSTSTATOVIAGGITX WHERE HStaVia_Luc_NumViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ORDER BY HST_DATAINSERIMENTO DESC";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					if (rObjDataTable.Rows.Count > 0)
					{
						minValue = Conversions.ToDate(rObjDataTable.Rows[0]["HST_DATAINSERIMENTO"]);
						text5 = Conversions.ToString(rObjDataTable.Rows[0]["HStaVia_Luc_StatoViaggioDelsy"]);
						num = Conversions.ToInteger(rObjDataTable.Rows[0]["HSt_Id"]);
						DateTime now = DateAndTime.Now;
						if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, now, minValue, (FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 5)
						{
							text4 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
							text4 = text4 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
							text4 = text4 + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
							val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
						}
						else if (Operators.CompareString(text2, text5, false) != 0)
						{
							text4 = "UPDATE CST_LUC_HSTSTATOVIAGGITX SET HStaVia_Luc_StatoViaggioDelsy = " + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", Hst_Tag = '' ";
							text4 = text4 + "WHERE HSt_Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num);
							val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
						}
					}
					else
					{
						text4 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
						text4 = text4 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
						text4 = text4 + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
						val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
							break;
						}
					}
					val2 = (FXRETURN)0;
					break;
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
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
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) > 10)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} risulta già chiuso", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) < 10)
			{
				rsmess = this.TranslateMessage("XXX", "Impossibile chiudere il viaggio {0} nello stato {1}", new string[2]
				{
					_IdViaggio,
					_dtViaggio.Rows[0]["Stato"].ToString()
				});
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
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM VW_Spedizioni WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "";
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
					if (Operators.CompareString(row["UnibolSpedizioneCompleta"].ToString().Trim(), "", false) != 0)
					{
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row["UnibolSpedizioneCompleta"].ToString().Trim()) + ",";
					}
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_0232;
				}
				text += "'x'";
				text = "SELECT S.IDViaggio, V.Stato Viaggio_Stato FROM Spedizioni S INNER JOIN Viaggi V ON V.IdViaggio=S.IdViaggio WHERE S.UNIBOL IN (" + text + ")";
				DataTable rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val <= 0)
				{
					foreach (DataRow row2 in rObjDataTable.Rows)
					{
						if (Operators.CompareString(row2["IdViaggio"].ToString(), "", false) != 0 && Conversions.ToInteger(row2["Viaggio_Stato"]) == 10 && !_IdViaggiTrattaCompleta.Contains(row2["IdViaggio"].ToString()))
						{
							_IdViaggiTrattaCompleta.Add(row2["IdViaggio"].ToString());
						}
					}
					goto IL_0232;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_0232:
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

	protected virtual FXRETURN AbilitaCalcoloVettoreSuSpedizione(DataRow Spedizione, ref string ssql, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ssql = "";
			if (!base.ApplicationParams.AbilitaTariffeDiSpedizioneSulVettore())
			{
				goto IL_01aa;
			}
			object objRes = null;
			bool flag = true;
			ssql = "SELECT OpzioniAggiuntive FROM Viaggi_TipiViaggio WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_dtViaggio.Rows[0]["TipoViaggio"].ToString());
			val = ((AppBaseClass)this).DbConn.DoSql(ssql, ref objRes, ref rsmess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(objRes.ToString().Trim(), "", false) != 0)
				{
					StandardParser val3 = new StandardParser();
					val3.Parse(objRes.ToString());
					if (val3.Result.ContainsKey("AbilitaTariffeDiSpedizioneSulVettore"))
					{
						flag = Operators.CompareString(val3.Result["AbilitaTariffeDiSpedizioneSulVettore"], "S", false) == 0;
					}
				}
				if (flag)
				{
					ssql = "UPDATE Spedizioni SET Vettore=" + ((AppBaseClass)this).DbConn.SQLFormatString(_dtViaggio.Rows[0]["Vettore"].ToString()) + " WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(Spedizione["unibol"].ToString()) + ";";
				}
				else
				{
					ssql = "UPDATE Spedizioni SET Vettore=NULL WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(Spedizione["unibol"].ToString()) + ";";
				}
				goto IL_01aa;
			}
			val2 = val;
			goto end_IL_0005;
			IL_01aa:
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
