using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_Partenza : GdoAbstractApi
{
	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	protected string _Autista;

	protected DateTime? _Data;

	protected string _Motrice;

	protected string _Rimorchio;

	protected string _Contenitore;

	protected string _Terminale;

	protected string _PCSPartenzaEffettivo;

	protected string _Latitudine;

	protected string _Longitudine;

	protected decimal? _KmGps;

	protected DateTime? _DataGPS;

	protected decimal? _KmManuali;

	protected string _Localita;

	protected string _Indirizzo;

	protected string _Cap;

	protected string _Provincia;

	protected string _Nazione;

	protected StringCollection _IdViaggiTrattaCompleta;

	protected StringCollection _SpedizioniDaDisassociare;

	protected StringCollection _SpedizioniDaDuplicarePerMerceNonCaricata;

	public Viaggio_Partenza(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtSpedizioni = null;
		_Autista = "";
		_Motrice = "";
		_Rimorchio = "";
		_Contenitore = "";
		_Terminale = "";
		_PCSPartenzaEffettivo = "";
		_Latitudine = "";
		_Longitudine = "";
		_Localita = "";
		_Indirizzo = "";
		_Cap = "";
		_Provincia = "";
		_Nazione = "";
		_IdViaggiTrattaCompleta = new StringCollection();
		_SpedizioniDaDisassociare = new StringCollection();
		_SpedizioniDaDuplicarePerMerceNonCaricata = new StringCollection();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Invalid comparison between Unknown and I4
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Invalid comparison between Unknown and I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Invalid comparison between Unknown and I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Invalid comparison between Unknown and I4
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Invalid comparison between Unknown and I4
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Invalid comparison between Unknown and I4
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Invalid comparison between Unknown and I4
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Invalid comparison between Unknown and I4
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Invalid comparison between Unknown and I4
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Invalid comparison between Unknown and I4
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_Data = (DateTime?)((AppAbstractApi)this).ParametersIn["Data"];
			if (!_Data.HasValue)
			{
				_Data = DateAndTime.Now;
			}
			_Autista = ((AppAbstractApi)this).ParametersIn["Autista"].ToString();
			_Motrice = ((AppAbstractApi)this).ParametersIn["Motrice"].ToString();
			_Rimorchio = ((AppAbstractApi)this).ParametersIn["Rimorchio"].ToString();
			_Contenitore = ((AppAbstractApi)this).ParametersIn["Contenitore"].ToString();
			_Terminale = ((AppAbstractApi)this).ParametersIn["Terminale"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("PCSPartenzaEffettivo"))
			{
				_PCSPartenzaEffettivo = ((AppAbstractApi)this).ParametersIn["PCSPartenzaEffettivo"].ToString();
			}
			_Latitudine = ((AppAbstractApi)this).ParametersIn["Latitudine"].ToString();
			_Longitudine = ((AppAbstractApi)this).ParametersIn["Longitudine"].ToString();
			_KmGps = (decimal?)((AppAbstractApi)this).ParametersIn["KmGps"];
			_DataGPS = (DateTime?)((AppAbstractApi)this).ParametersIn["DataGPS"];
			_KmManuali = (decimal?)((AppAbstractApi)this).ParametersIn["KmManuali"];
			_Localita = ((AppAbstractApi)this).ParametersIn["Localita"].ToString();
			_Indirizzo = ((AppAbstractApi)this).ParametersIn["Indirizzo"].ToString();
			_Cap = ((AppAbstractApi)this).ParametersIn["Cap"].ToString();
			_Provincia = ((AppAbstractApi)this).ParametersIn["Provincia"].ToString();
			_Nazione = ((AppAbstractApi)this).ParametersIn["Nazione"].ToString();
			val = CheckViaggio(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_PCSPartenzaEffettivo, "", false) == 0)
				{
					_PCSPartenzaEffettivo = _dtViaggio.Rows[0]["PCSPartenza"].ToString();
				}
				if (Operators.CompareString(_Motrice, "", false) == 0)
				{
					_Motrice = _dtViaggio.Rows[0]["MotricePianificata"].ToString();
				}
				if (Operators.CompareString(_Contenitore, "", false) == 0)
				{
					_Contenitore = _dtViaggio.Rows[0]["Contenitore1Pianificato"].ToString();
				}
				if (Operators.CompareString(_Rimorchio, "", false) == 0)
				{
					_Rimorchio = _dtViaggio.Rows[0]["Rimorchio1Pianificato"].ToString();
				}
				if (Operators.CompareString(_Autista, "", false) == 0)
				{
					_Autista = _dtViaggio.Rows[0]["Autista1Pianificato"].ToString();
				}
				val = CheckSpedizioni(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = Viaggio_VerificaVincoliDiTipoViaggio_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, CheckCampiObbligatori: true, Operators.CompareString(_dtViaggio.Rows[0]["IdViaggioOBC"].ToString(), "", false) == 0, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						string text2 = "N";
						DataTable rObjDataTable = null;
						string text3 = "";
						string vsStringa = "";
						decimal pNumero = default(decimal);
						string text4 = "";
						text3 = "SELECT C.RAGIONESOCIALE FROM VIAGGI V INNER JOIN SPEDIZIONI S ON V.IDVIAGGIO = S.IDVIAGGIO INNER JOIN CORRISPONDENTI C ON C.CODICE = S.CORRISPONDENTE ";
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
								text3 = "Select DataPartenzaPianificata from Viaggi inner join Spedizioni on Viaggi.IdViaggio = Spedizioni.IdViaggio WHERE Viaggi.IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
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
									int num = 0;
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
										num = Conversions.ToInteger(rObjDataTable.Rows[0]["HSt_Id"]);
										DateTime now = DateAndTime.Now;
										if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, now, minValue, (FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 5)
										{
											text4 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
											text4 = text4 + "VALUES (" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ", ";
											text4 = text4 + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", " + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + "," + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ") ";
											val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
											if ((int)val <= 0)
											{
												goto IL_08e6;
											}
											val2 = val;
										}
										else
										{
											if (Operators.CompareString(text2, text5, false) == 0)
											{
												goto IL_08e6;
											}
											text4 = "UPDATE CST_LUC_HSTSTATOVIAGGITX SET HStaVia_Luc_StatoViaggioDelsy = " + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", Hst_Tag = '' ";
											text4 = text4 + "WHERE HSt_Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref num);
											val = ((AppBaseClass)this).DbConn.SqlExec(text4, ref rsmess);
											if ((int)val <= 0)
											{
												goto IL_08e6;
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
											goto IL_08e6;
										}
										val2 = val;
									}
								}
							}
						}
					}
				}
			}
			goto end_IL_000b;
			IL_08e6:
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Invalid comparison between Unknown and I4
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Invalid comparison between Unknown and I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Invalid comparison between Unknown and I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Invalid comparison between Unknown and I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Invalid comparison between Unknown and I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string RetQueryToApply = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = DisassociaSpedizioni(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = GeneraSpedizioniPerMerceNonCaricata(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += RetQueryToApply;
						text += "UPDATE Viaggi SET Stato=CASE WHEN STATO>30 THEN STATO ELSE 30 END, ";
						text = text + "DataPartenzaEffettiva = %ISNULL%(DataPartenzaEffettiva," + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _Data) + "), ";
						text = text + "PCSPartenzaEffettivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPartenzaEffettivo) + ", ";
						text = text + "MotriceEffettiva=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Motrice) + ", ";
						text = text + "Rimorchio1Effettivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Rimorchio) + ", ";
						text = text + "Contenitore1Effettivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Contenitore) + ", ";
						text = text + "Autista1Effettivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Autista) + ", ";
						text += "Contenitore2Effettivo=Contenitore2Pianificato, ";
						text += "Rimorchio2Effettivo=Rimorchio2Pianificato, ";
						text += "Autista2Effettivo=Autista2Pianificato, ";
						text = text + "Terminale = %ISNULL%(Terminale," + ((AppBaseClass)this).DbConn.SQLFormatString(_Terminale) + ") ";
						text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
						text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
						val = EventoViaggio_InizioViaggio.RunProc(this._ApiContext, _IdViaggio, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
						text += RetQueryToApply;
						foreach (DataRow row in _dtSpedizioni.Rows)
						{
							if (_SpedizioniDaDisassociare.Contains(row["Unibol"].ToString()))
							{
								continue;
							}
							RetQueryToApply = "";
							RetQueryToApply = "UPDATE Spedizioni SET Stato=CASE WHEN STATO>40 THEN STATO ELSE 40 END ";
							RetQueryToApply = RetQueryToApply + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Unibol"].ToString()) + ";";
							text += RetQueryToApply;
							RetQueryToApply = "";
							val = EventoSpedizione_InConsegna.RunProc(this._ApiContext, row["Unibol"].ToString(), _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								text += RetQueryToApply;
								RetQueryToApply = "";
								val = AbilitaCalcoloVettoreSuSpedizione(row, ref RetQueryToApply, ref rsmess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									text += RetQueryToApply;
									if (decimal.Compare(Conversions.ToDecimal(row["Contrassegno"]), 0m) <= 0)
									{
										continue;
									}
									RetQueryToApply = "";
									Contrassegno_Crea_Invoker instance = Contrassegno_Crea_Invoker.Instance;
									AppApiContext apiContext = this._ApiContext;
									string? unibol = row["Unibol"].ToString();
									DateTime? data = _Data;
									int? IdContrassegno = null;
									val = instance.RunProc(apiContext, unibol, data, null, null, null, ApplyQuery: false, ref IdContrassegno, ref RetQueryToApply, ref rsmess);
									if ((int)val <= 0)
									{
										text += RetQueryToApply;
										continue;
									}
									val2 = val;
								}
							}
							goto end_IL_0012;
						}
						if (Operators.CompareString(text, "", false) == 0)
						{
							goto IL_049f;
						}
						val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_049f;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0012;
			IL_049f:
			StringEnumerator enumerator2 = _IdViaggiTrattaCompleta.GetEnumerator();
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					val = Viaggio_Partenza_Invoker.Instance.RunProc(this._ApiContext, current, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					continue;
				}
				((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = ((AppAbstractApi)this).ParametersOut["RetQueryToApply"].ToString() + text;
				val2 = (FXRETURN)0;
				break;
			}
			end_IL_0012:;
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
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) < 20)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non risulta chiuso", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) > 30)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} risulta in uno stato {1} troppo avanzato per consentirne la partenza (1)", new string[2]
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
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Invalid comparison between Unknown and I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.*, ";
			text += "(SELECT COUNT(*) FROM SpedizioniUDS U WHERE U.Unibol=S.UniBol) CountOfUds, ";
			text = text + "(SELECT COUNT(*) FROM SpedizioniUDS U WHERE U.Unibol=S.UniBol AND U.Esito IS NOT NULL AND U.Esito IN (SELECT E.Codice FROM EVENTI E WHERE TipoEvento='" + EventoSpedizioneTipo.UdsNonCaricata + "')) CountOfNotLoadedUds ";
			text = text + "FROM VW_Spedizioni S WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
					if (Conversions.ToInteger(row["STATO"].ToString()) < 30)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione {0} non risulta chiusa", new string[1] { row["UNIBOL"].ToString() });
					}
					else if (Conversions.ToInteger(row["STATO"].ToString()) > 40)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione {0} risulta in uno stato troppo avanzato per consentirne la partenza", new string[1] { row["UNIBOL"].ToString() });
					}
					else
					{
						if ((Conversions.ToInteger(row["CountOfUds"]) > 0) & (Conversions.ToInteger(row["CountOfNotLoadedUds"]) > 0))
						{
							if (Conversions.ToInteger(row["CountOfUds"]) == Conversions.ToInteger(row["CountOfNotLoadedUds"]))
							{
								_SpedizioniDaDisassociare.Add(row["UNIBOL"].ToString());
							}
							else
							{
								_SpedizioniDaDuplicarePerMerceNonCaricata.Add(row["UNIBOL"].ToString());
							}
						}
						if (Operators.CompareString(row["STATOWMS"].ToString(), "30", false) < 0)
						{
							rsmess = this.TranslateMessage("XXX", "La spedizione {0} non risulta tornata dal WMS", new string[1] { row["UNIBOL"].ToString() });
						}
						else
						{
							if (Operators.CompareString(row["PREBOLLA"].ToString(), "S", false) != 0)
							{
								continue;
							}
							rsmess = this.TranslateMessage("XXX", "La spedizione {0} risulta in stato di prebolla", new string[1] { row["UNIBOL"].ToString() });
						}
					}
					goto end_IL_000b;
				}
				text = "";
				foreach (DataRow row2 in _dtSpedizioni.Rows)
				{
					if (Operators.CompareString(row2["UnibolSpedizioneCompleta"].ToString().Trim(), "", false) != 0)
					{
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(row2["UnibolSpedizioneCompleta"].ToString().Trim()) + ",";
					}
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_0496;
				}
				text += "'x'";
				text = "SELECT S.IDViaggio, V.Stato Viaggio_Stato FROM Spedizioni S INNER JOIN Viaggi V ON V.IdViaggio=S.IdViaggio WHERE S.UNIBOL IN (" + text + ")";
				DataTable rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val <= 0)
				{
					foreach (DataRow row3 in rObjDataTable.Rows)
					{
						if (Operators.CompareString(row3["IdViaggio"].ToString(), "", false) != 0 && Conversions.ToInteger(row3["Viaggio_Stato"]) == 20 && !_IdViaggiTrattaCompleta.Contains(row3["IdViaggio"].ToString()))
						{
							_IdViaggiTrattaCompleta.Add(row3["IdViaggio"].ToString());
						}
					}
					goto IL_0496;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_0496:
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

	protected virtual FXRETURN DisassociaSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			StringEnumerator enumerator = _SpedizioniDaDisassociare.GetEnumerator();
			while (true)
			{
				if (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					val = Spedizione_DisassociaDaViaggioChiuso_Invoker.Instance.RunProc(this._ApiContext, new List<string>(new string[1] { current }), _IdViaggio, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					continue;
				}
				val2 = (FXRETURN)0;
				break;
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

	protected virtual FXRETURN GeneraSpedizioniPerMerceNonCaricata(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			StringEnumerator enumerator = _SpedizioniDaDuplicarePerMerceNonCaricata.GetEnumerator();
			while (true)
			{
				if (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					Spedizione_GeneraSpedizionePerMerceNonCaricata_Invoker instance = Spedizione_GeneraSpedizionePerMerceNonCaricata_Invoker.Instance;
					AppApiContext apiContext = this._ApiContext;
					string RetQueryToApply = "";
					val = instance.RunProc(apiContext, current, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					continue;
				}
				val2 = (FXRETURN)0;
				break;
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
