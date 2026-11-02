using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.TMSServiceForMap;
using Incasbo.Web.Library;
using Incasbo.xRoute;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class ViaggioRicalcolaKmETempi_GDOWSC : GdoAbstractApi
{
	protected class GPSPoint
	{
		public string Latitudine { get; set; }

		public string Longitudine { get; set; }

		public string Codice { get; set; }

		public string IdOrdine { get; set; }

		public decimal Km { get; set; }

		public DateTime? DataPartenza { get; set; }

		public DateTime? DataArrivo { get; set; }

		public int SecondiCaricoScarico { get; set; }

		public string Descrizione { get; set; }

		public GPSPoint()
		{
			Latitudine = "";
			Longitudine = "";
			Codice = "";
			IdOrdine = "";
			Km = 0m;
			SecondiCaricoScarico = 0;
			Descrizione = "";
		}
	}

	protected class GPSPoints : List<GPSPoint>
	{
		public GPSPoint GetPointById(string Id)
		{
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GPSPoint current = enumerator.Current;
					if (Operators.CompareString(current.IdOrdine, Id, false) == 0)
					{
						return current;
					}
				}
			}
			return null;
		}
	}

	protected class Punto
	{
		public decimal Longitudine { get; set; }

		public decimal Latitudine { get; set; }

		public Punto(decimal longitudine, decimal latitudine)
		{
			Longitudine = longitudine;
			Latitudine = latitudine;
		}
	}

	protected GPSPoints _GPSPoints;

	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected DataTable _dtViaggioEventi;

	protected decimal _KmViaggio;

	protected int _DurataSecondiViaggio;

	protected DateTime _DataPartenzaViaggio;

	protected DateTime? _DataArrivoViaggio;

	protected string _Algorithm;

	protected int _StatoViaggio;

	protected Dictionary<string, string> _RoutingOptions;

	protected int _DurataSecondiGuidaViaggio;

	protected int _TempoCaricoScarico;

	protected CalcoloKmETempiArgsIn _CalcoloKmETempiArgsIn;

	protected CalcoloKmETempiArgsOut _CalcoloKmETempiArgsOut;

	protected string _ServiceUser;

	protected string _ServicePassword;

	protected string _Speed_Profile;

	public ViaggioRicalcolaKmETempi_GDOWSC(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtViaggioEventi = null;
		_KmViaggio = default(decimal);
		_DurataSecondiViaggio = 0;
		_Algorithm = "DEFAULT";
		_StatoViaggio = 0;
		_RoutingOptions = null;
		_DurataSecondiGuidaViaggio = 0;
		_TempoCaricoScarico = 0;
		_CalcoloKmETempiArgsIn = new CalcoloKmETempiArgsIn();
		_CalcoloKmETempiArgsOut = new CalcoloKmETempiArgsOut();
		_ServiceUser = "";
		_ServicePassword = "";
		_Speed_Profile = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between Unknown and I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Invalid comparison between Unknown and I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(base.ApplicationParams.UsexRoute(), "S", false) == 0)
			{
				if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["ServiceUser"].ToString(), "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Obbligatorio specificare l'utente di esecuzione del servizio");
				}
				else
				{
					_ServiceUser = ((AppAbstractApi)this).ParametersIn["ServiceUser"].ToString();
					if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["ServicePassword"].ToString(), "", false) == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Obbligatorio specificare la password associata all'utente di esecuzione del servizio");
					}
					else
					{
						_ServicePassword = ((AppAbstractApi)this).ParametersIn["ServicePassword"].ToString();
						if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString(), "", false) == 0)
						{
							rsmess = this.TranslateMessage("XXX", "Obbligatorio inserire Id Viaggio");
						}
						else
						{
							_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
							if (((AppAbstractApi)this).ParametersIn.ContainsKey("RoutingOptions"))
							{
								_RoutingOptions = (Dictionary<string, string>)((AppAbstractApi)this).ParametersIn["RoutingOptions"];
							}
							else
							{
								_RoutingOptions = new Dictionary<string, string>();
							}
							if (((AppAbstractApi)this).ParametersIn.ContainsKey("Algoritmo") && Operators.CompareString(((AppAbstractApi)this).ParametersIn["Algoritmo"].ToString().Trim(), "", false) != 0)
							{
								_Algorithm = ((AppAbstractApi)this).ParametersIn["Algoritmo"].ToString().Trim().ToUpper();
							}
							if (((AppAbstractApi)this).ParametersIn.ContainsKey("TempoCaricoScarico"))
							{
								_TempoCaricoScarico = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["TempoCaricoScarico"]);
							}
							string vsSQLClause = "SELECT * FROM VIAGGI WHERE IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
							val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtViaggio, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else if (_dtViaggio.Rows.Count == 0)
							{
								rsmess = this.TranslateMessage("XXX", "Il Viaggio {0} non esiste.", new string[1] { _IdViaggio });
							}
							else
							{
								if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtViaggio.Rows[0]["DataPartenzaEffettiva"])))
								{
									if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtViaggio.Rows[0]["DataPartenzaPianificata"])))
									{
										_DataPartenzaViaggio = DateAndTime.Now;
									}
									else
									{
										_DataPartenzaViaggio = Conversions.ToDate(_dtViaggio.Rows[0]["DataPartenzaPianificata"]);
									}
								}
								else
								{
									_DataPartenzaViaggio = Conversions.ToDate(_dtViaggio.Rows[0]["DataPartenzaEffettiva"]);
								}
								_StatoViaggio = Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]);
								if ((Operators.CompareString(_dtViaggio.Rows[0]["PCSPartenza"].ToString(), "", false) == 0) & (Operators.CompareString(_dtViaggio.Rows[0]["PCSPartenzaEffettivo"].ToString(), "", false) == 0))
								{
									rsmess = this.TranslateMessage("XXX", "Il Viaggio {0} non ha valorizzato né il punto di partenza pianificato nè l'effettivo.", new string[1] { _IdViaggio });
								}
								else
								{
									vsSQLClause = "SELECT * FROM VIAGGI_EVENTI WHERE IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ORDER BY DATAORAEVENTO, ID";
									val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtViaggioEventi, ref rsmess);
									if ((int)val > 0)
									{
										val2 = val;
									}
									else
									{
										if (_dtViaggioEventi.Rows.Count == 0)
										{
										}
										val2 = (FXRETURN)0;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				rsmess = this.TranslateMessage("XXX", "Impossibile eseguire il calcolo. La configurazione dell'applicazione non permette di utilizzare il servizio di routing.");
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
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = CreateGPSPointsList(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = PrepareArgIn(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = WSCall(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = ElaboraRisultato(ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = SalvaKm(ref rsmess);
							val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
						}
					}
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

	protected FXRETURN CreateGPSPointsList(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_Algorithm, "DEFAULT", false) != 0)
			{
				if (Operators.CompareString(_Algorithm, "ALTRO", false) != 0)
				{
				}
				goto IL_0061;
			}
			val2 = _CreateGPSPointsList_Default(ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0061;
			}
			val = val2;
			goto end_IL_0005;
			IL_0061:
			val = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN _CreateGPSPointsList_Default(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Invalid comparison between Unknown and I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Invalid comparison between Unknown and I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Invalid comparison between Unknown and I4
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			DataTable rObjDataTable2 = null;
			if (_StatoViaggio >= 40)
			{
				text = "SELECT S.*, SE.CODICEEVENTO, E.TentativoEffettuato, ";
				text += "CASE WHEN S.SequenzaEffettiva=0 THEN S.SequenzaPianificata ELSE S.SequenzaEffettiva END AS Sequenza ";
				text += "FROM Spedizioni S LEFT JOIN VW_SPEDIZIONI_ESITO SE ON S.UniBol=SE.UNIBOL ";
				text += "LEFT JOIN Eventi E ON SE.CODICEEVENTO=E.Codice ";
				text = text + "WHERE S.IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
				text += "AND (E.TentativoEffettuato='S' OR E.TentativoEffettuato IS NULL) ";
				text += "ORDER BY Sequenza ";
			}
			else
			{
				text = "SELECT S.* ";
				text += "FROM Spedizioni S ";
				text = text + "WHERE S.IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
				text += "ORDER BY S.SequenzaPianificata ";
			}
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsMess);
			string text2;
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (rObjDataTable2.Rows.Count == 0)
			{
				rsMess = this.TranslateMessage("XXX", "Il viaggio {0} non ha spedizioni", new string[1] { _IdViaggio });
			}
			else
			{
				_GPSPoints = new GPSPoints();
				text2 = "";
				if (_StatoViaggio >= 40)
				{
					if (Operators.CompareString(_dtViaggio.Rows[0]["PCSPartenzaEffettivo"].ToString(), "", false) != 0)
					{
						text2 = _dtViaggio.Rows[0]["PCSPartenzaEffettivo"].ToString();
						goto IL_0266;
					}
					rsMess = this.TranslateMessage("XXX", "Il punto di partenza effettivo del viaggio {1} non è valorizzato.", new string[1] { _IdViaggio });
				}
				else
				{
					if (Operators.CompareString(_dtViaggio.Rows[0]["PCSPartenza"].ToString(), "", false) != 0)
					{
						text2 = _dtViaggio.Rows[0]["PCSPartenza"].ToString();
						goto IL_0266;
					}
					rsMess = this.TranslateMessage("XXX", "Il punto di partenza pianificato del viaggio {1} non è valorizzato.", new string[1] { _IdViaggio });
				}
			}
			goto end_IL_000e;
			IL_0266:
			text = "SELECT G.*, PCS.RagioneSociale, PCS.Localita, PCS.Provincia  ";
			text += "FROM PCS PCS ";
			text += "INNER JOIN PCS_Geocodifica G ON PCS.Codice=G.Codice ";
			text = text + "WHERE PCS.Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2);
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsMess = this.TranslateMessage("XXX", "Il punto di partenza {0} del viaggio {1} non è geolocalizzato.", new string[2] { text2, _IdViaggio });
			}
			else
			{
				GPSPoint gPSPoint = new GPSPoint();
				gPSPoint.Latitudine = rObjDataTable.Rows[0]["Latitudine"].ToString();
				gPSPoint.Longitudine = rObjDataTable.Rows[0]["Longitudine"].ToString();
				gPSPoint.Descrizione = rObjDataTable.Rows[0]["RagioneSociale"].ToString() + " - " + rObjDataTable.Rows[0]["Localita"].ToString() + " - " + rObjDataTable.Rows[0]["Provincia"].ToString();
				gPSPoint.Codice = text2;
				gPSPoint.SecondiCaricoScarico = 0;
				gPSPoint.DataPartenza = _DataPartenzaViaggio;
				_GPSPoints.Add(gPSPoint);
				string text3 = "";
				foreach (DataRow row in rObjDataTable2.Rows)
				{
					string text4 = row["PCSDestinazione"].ToString();
					text = "SELECT G.*, PCS.RagioneSociale, PCS.Localita, PCS.Provincia  ";
					text += "FROM PCS PCS ";
					text += "INNER JOIN PCS_Geocodifica G ON PCS.Codice=G.Codice ";
					text = text + "WHERE PCS.Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(text4);
					val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (rObjDataTable.Rows.Count != 0)
						{
							gPSPoint = new GPSPoint();
							gPSPoint.Latitudine = rObjDataTable.Rows[0]["Latitudine"].ToString();
							gPSPoint.Longitudine = rObjDataTable.Rows[0]["Longitudine"].ToString();
							gPSPoint.Descrizione = rObjDataTable.Rows[0]["RagioneSociale"].ToString() + " - " + rObjDataTable.Rows[0]["Localita"].ToString() + " - " + rObjDataTable.Rows[0]["Provincia"].ToString();
							gPSPoint.Codice = text4;
							gPSPoint.IdOrdine = row["Unibol"].ToString();
							if (Operators.CompareString(text4, text3, false) != 0)
							{
								gPSPoint.SecondiCaricoScarico = _TempoCaricoScarico;
							}
							else
							{
								gPSPoint.SecondiCaricoScarico = 0;
							}
							text3 = text4;
							_GPSPoints.Add(gPSPoint);
							continue;
						}
						rsMess = this.TranslateMessage("XXX", "Il punto di carico/scarico {0} del viaggio {1} non è geolocalizzato.", new string[2] { text4, _IdViaggio });
					}
					goto end_IL_000e;
				}
				string text5 = "";
				if (_StatoViaggio >= 40)
				{
					if (Operators.CompareString(_dtViaggio.Rows[0]["PCSArrivoEffettivo"].ToString(), "", false) != 0)
					{
						text5 = _dtViaggio.Rows[0]["PCSArrivoEffettivo"].ToString();
					}
				}
				else if (Operators.CompareString(_dtViaggio.Rows[0]["PCSArrivo"].ToString(), "", false) != 0)
				{
					text5 = _dtViaggio.Rows[0]["PCSArrivo"].ToString();
				}
				if (Operators.CompareString(text5, "", false) == 0)
				{
					goto IL_0881;
				}
				text = "SELECT G.*, PCS.RagioneSociale, PCS.Localita, PCS.Provincia  ";
				text += "FROM PCS PCS ";
				text += "INNER JOIN PCS_Geocodifica G ON PCS.Codice=G.Codice ";
				text = text + "WHERE PCS.Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(text5);
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (rObjDataTable.Rows.Count == 1)
					{
						gPSPoint = new GPSPoint();
						gPSPoint.Latitudine = rObjDataTable.Rows[0]["Latitudine"].ToString();
						gPSPoint.Longitudine = rObjDataTable.Rows[0]["Longitudine"].ToString();
						gPSPoint.Descrizione = rObjDataTable.Rows[0]["RagioneSociale"].ToString() + " - " + rObjDataTable.Rows[0]["Localita"].ToString() + " - " + rObjDataTable.Rows[0]["Provincia"].ToString();
						gPSPoint.Codice = text5;
						gPSPoint.SecondiCaricoScarico = 0;
						_GPSPoints.Add(gPSPoint);
					}
					goto IL_0881;
				}
				val = val2;
			}
			goto end_IL_000e;
			IL_0881:
			val = (FXRETURN)0;
			end_IL_000e:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN PrepareArgIn(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			_CalcoloKmETempiArgsIn.GPSPoints = new Map_GPSPoint[checked(_GPSPoints.Count - 1 + 1)];
			if (_GPSPoints.Count < 2)
			{
				rsMess = this.TranslateMessage("XXX", "Errore: per calcolare i km sono necessari almeno due punti");
			}
			else
			{
				int num = 0;
				foreach (GPSPoint gPSPoint in _GPSPoints)
				{
					Map_GPSPoint map_GPSPoint = new Map_GPSPoint();
					map_GPSPoint.Codice = gPSPoint.Codice;
					map_GPSPoint.Descrizione = gPSPoint.Descrizione;
					map_GPSPoint.Latitudine = gPSPoint.Latitudine;
					map_GPSPoint.Longitudine = gPSPoint.Longitudine;
					map_GPSPoint.DataPartenza = gPSPoint.DataPartenza;
					map_GPSPoint.DataArrivo = gPSPoint.DataArrivo;
					map_GPSPoint.IdOrdine = gPSPoint.IdOrdine;
					map_GPSPoint.Km = gPSPoint.Km;
					map_GPSPoint.SecondiCaricoScarico = gPSPoint.SecondiCaricoScarico;
					_CalcoloKmETempiArgsIn.GPSPoints[num] = map_GPSPoint;
					num = checked(num + 1);
				}
				string text = "";
				text = "SELECT * ";
				text += "FROM VW_VIAGGIO_MEZZI_TA X ";
				text = text + "WHERE X.IDVIAGGIO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
				DataTable rObjDataTable = new DataTable();
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (rObjDataTable.Rows.Count != 1)
				{
					rsMess = this.TranslateMessage("XXX", "Errore nell'estrazione delle caratteristiche del mezzo");
				}
				else
				{
					_Speed_Profile = rObjDataTable.Rows[0]["SuffissoFileTrattore"].ToString();
					_CalcoloKmETempiArgsIn.RoutingOptions = new Map_RoutingOptions();
					CalcoloKmETempiArgsIn calcoloKmETempiArgsIn;
					Map_RoutingOptions RoutingOptions = (calcoloKmETempiArgsIn = _CalcoloKmETempiArgsIn).RoutingOptions;
					SetRoutingOptions(ref RoutingOptions);
					calcoloKmETempiArgsIn.RoutingOptions = RoutingOptions;
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN WSCall(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		TMSServiceForMapClient tMSServiceForMapClient = new TMSServiceForMapClient();
		Sender sender = new Sender();
		FXRETURN result2;
		try
		{
			rsMess = "";
			this.CallStackAdd();
			sender.Name = _ServiceUser;
			sender.Password = _ServicePassword;
			Result result = new Result();
			result = tMSServiceForMapClient.CalcoloKmETempi(sender, _CalcoloKmETempiArgsIn, ref _CalcoloKmETempiArgsOut);
			if (!result.Good)
			{
				rsMess = this.TranslateMessage("XXX", result.Reason);
			}
			else
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result2 = val;
		}
		return result2;
	}

	protected void SetRoutingOptions(ref Map_RoutingOptions RoutingOptions)
	{
		RoutingOption routingOption = null;
		if (!Information.IsNothing((object)_RoutingOptions))
		{
			if (_RoutingOptions.ContainsKey("OPTIMIZATION"))
			{
				RoutingOptions.Optimization = Conversions.ToInteger(_RoutingOptions["OPTIMIZATION"]);
			}
			if (_RoutingOptions.ContainsKey("AVOID_TOLLROADS"))
			{
				RoutingOptions.Avoid_TollRoads = Conversions.ToInteger(_RoutingOptions["AVOID_TOLLROADS"]);
				RoutingOptions.Avoid_VignetteRoads = Conversions.ToInteger(_RoutingOptions["AVOID_VIGNETTEROADS"]);
			}
			if (_RoutingOptions.ContainsKey("AVOID_HIGHWAYS"))
			{
				RoutingOptions.Avoid_Highways = Conversions.ToInteger(_RoutingOptions["AVOID_HIGHWAYS"]);
			}
			if (_RoutingOptions.ContainsKey("AVOID_FERRIES"))
			{
				RoutingOptions.Avoid_Ferries = Conversions.ToInteger(_RoutingOptions["AVOID_FERRIES"]);
			}
			if (_RoutingOptions.ContainsKey("AVOID_RESIDENTS_ONLY"))
			{
				RoutingOptions.Avoid_Residents_Only = Conversions.ToInteger(_RoutingOptions["AVOID_RESIDENTS_ONLY"]);
			}
			if (_RoutingOptions.ContainsKey("AVOID_URBAN_AREAS"))
			{
				RoutingOptions.Avoid_Urban_Areas = Conversions.ToInteger(_RoutingOptions["AVOID_URBAN_AREAS"]);
			}
			if (_RoutingOptions.ContainsKey("AVOID_RAMPS"))
			{
				RoutingOptions.Avoid_Ramps = Conversions.ToInteger(_RoutingOptions["AVOID_RAMPS"]);
			}
			if (_RoutingOptions.ContainsKey("AVOID_LOW_EMISSION_ZONES"))
			{
				RoutingOptions.Avoid_Low_Emission_Zones = Conversions.ToInteger(_RoutingOptions["AVOID_LOW_EMISSION_ZONES"]);
			}
			if (_RoutingOptions.ContainsKey("ROUTE_LANGUAGE"))
			{
				RoutingOptions.Route_Language = _RoutingOptions["ROUTE_LANGUAGE"].ToString();
			}
			else
			{
				RoutingOptions.Route_Language = "IT";
			}
			if (_RoutingOptions.ContainsKey("MAXIMUMDISTANCETOSEGMENT") && Versioned.IsNumeric((object)_RoutingOptions["MAXIMUMDISTANCETOSEGMENT"]))
			{
				RoutingOptions.MaximumDistanceToSegment = Conversions.ToInteger(_RoutingOptions["MAXIMUMDISTANCETOSEGMENT"]);
			}
			if (_TempoCaricoScarico != 0)
			{
				RoutingOptions.TempoCaricoScarico = _TempoCaricoScarico;
			}
			if (Operators.CompareString(_Speed_Profile, "", false) != 0)
			{
				RoutingOptions.Speed_Profile = _Speed_Profile;
			}
		}
	}

	protected FXRETURN ElaboraRisultato(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int num = 0;
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				this.CallStackAdd();
				_DurataSecondiViaggio = _CalcoloKmETempiArgsOut.TotalInfo.DurataTotale.Value;
				_KmViaggio = _CalcoloKmETempiArgsOut.TotalInfo.KmTotali.Value;
				_DurataSecondiGuidaViaggio = _CalcoloKmETempiArgsOut.TotalInfo.DurataGuida.Value;
				Map_GPSPoint[] gPSPoints = _CalcoloKmETempiArgsOut.GPSPoints;
				foreach (Map_GPSPoint map_GPSPoint in gPSPoints)
				{
					DateTime dateTime = DateAndTime.DateAdd((DateInterval)9, (double)_DurataSecondiViaggio, _DataPartenzaViaggio);
					DateTime dateTime2 = DateAndTime.DateAdd((DateInterval)9, (double)_GPSPoints[num].SecondiCaricoScarico, dateTime);
					_GPSPoints[num].Km = map_GPSPoint.Km;
					_GPSPoints[num].DataArrivo = map_GPSPoint.DataArrivo;
					_GPSPoints[num].DataPartenza = map_GPSPoint.DataPartenza;
					if (num == _GPSPoints.Count - 1)
					{
						_DataArrivoViaggio = DateAndTime.DateAdd((DateInterval)9, (double)(_DurataSecondiViaggio - _GPSPoints[num].SecondiCaricoScarico), _DataPartenzaViaggio);
					}
					num++;
				}
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				rsMess = ex2.Message;
				ProjectData.ClearProjectError();
			}
			finally
			{
				this.CallStackRemove();
				result = val;
			}
			return result;
		}
	}

	protected FXRETURN SalvaKm(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			this.CallStackAdd();
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			decimal pNumero = Math.Round(_KmViaggio);
			text = "UPDATE Viaggi SET <%V.Km%>=" + dbConn.SQLFormatNumber(ref pNumero);
			text = text + ", <%V.DataPartenza%>=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _DataPartenzaViaggio);
			text = text + ", <%V.DataArrivo%>=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _DataArrivoViaggio) + " ";
			string text2 = text;
			DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
			double pNumero2 = Math.Round((double)_DurataSecondiGuidaViaggio / 60.0);
			text = text2 + ", <%V.MinutiGuida%>=" + dbConn2.SQLFormatNumber(ref pNumero2) + " ";
			text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
			foreach (GPSPoint gPSPoint in _GPSPoints)
			{
				if (Operators.CompareString(gPSPoint.IdOrdine, "", false) != 0)
				{
					string text3 = text;
					DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
					pNumero = Math.Round(gPSPoint.Km);
					text = text3 + "UPDATE Spedizioni SET <%S.Km%>=" + dbConn3.SQLFormatNumber(ref pNumero);
					text = text + ", <%S.DataPartenza%>=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, gPSPoint.DataPartenza);
					text = text + ", <%S.DataArrivo%>=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, gPSPoint.DataArrivo) + " ";
					text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
					text = text + "AND Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(gPSPoint.IdOrdine) + ";";
				}
			}
			if (_StatoViaggio >= 40)
			{
				text = text.Replace("<%V.Km%>", "KmRicalcolati").Replace("<%V.DataPartenza%>", "DataPartenzaRicalcolata").Replace("<%V.DataArrivo%>", "DataArrivoRicalcolata")
					.Replace("<%V.MinutiGuida%>", "MinutiGuidaRicalcolati");
				text = text.Replace("<%S.Km%>", "KmRicalcolati").Replace("<%S.DataPartenza%>", "DataOraPartenzaRicalcolata").Replace("<%S.DataArrivo%>", "DataOraArrivoRicalcolata");
			}
			else
			{
				text = text.Replace("<%V.Km%>", "KmPianificati").Replace("<%V.DataPartenza%>", "DataPartenzaPianificata").Replace("<%V.DataArrivo%>", "DataArrivoPianificata")
					.Replace("<%V.MinutiGuida%>", "MinutiGuidaPianificati");
				text = text.Replace("<%S.Km%>", "KmPianificati").Replace("<%S.DataPartenza%>", "DataOraPartenzaPianificata").Replace("<%S.DataArrivo%>", "DataOraArrivoPianificata");
			}
			val2 = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}
}
