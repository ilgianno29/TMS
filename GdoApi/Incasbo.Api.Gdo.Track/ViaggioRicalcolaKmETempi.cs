using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Incasbo.xRoute;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class ViaggioRicalcolaKmETempi : GdoAbstractApi
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

	protected AdvancedTour _tour;

	protected decimal _KmViaggio;

	protected int _DurataSecondiViaggio;

	protected DateTime _DataPartenzaViaggio;

	protected DateTime? _DataArrivoViaggio;

	protected string _Algorithm;

	protected int _StatoViaggio;

	protected Dictionary<string, string> _RoutingOptions;

	protected int _DurataSecondiGuidaViaggio;

	protected int _TempoCaricoScarico;

	protected int _MaximumDistanceToSegment;

	protected const string kDRIVING = "DRIVING";

	public ViaggioRicalcolaKmETempi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtViaggioEventi = null;
		_tour = null;
		_KmViaggio = default(decimal);
		_DurataSecondiViaggio = 0;
		_Algorithm = "DEFAULT";
		_StatoViaggio = 0;
		_RoutingOptions = null;
		_DurataSecondiGuidaViaggio = 0;
		_TempoCaricoScarico = 0;
		_MaximumDistanceToSegment = 0;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Invalid comparison between Unknown and I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Invalid comparison between Unknown and I4
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(base.ApplicationParams.UsexRoute(), "S", false) == 0)
			{
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
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Invalid comparison between Unknown and I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Invalid comparison between Unknown and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
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
				val = CalculateTour(_DataPartenzaViaggio, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0258;
				}
				string text2 = "concerning leg".ToUpper();
				string value = "LINKING TO WAYPOINT";
				string text3 = "ZERO-BASED INDEX LIST: ";
				checked
				{
					if (rsmess.ToUpper().Contains("Cannot calculate route".ToUpper()) & rsmess.ToUpper().Contains(text2))
					{
						string text4 = Strings.Mid(rsmess, rsmess.ToUpper().IndexOf(text2) + Strings.Len(text2) + 1);
						text4 = text4.Replace(")", "").Replace(" ", "");
						string text5 = "";
						string text6 = "";
						text6 = _GPSPoints[Conversions.ToInteger(text4)].Descrizione;
						text5 = text6;
						if (Conversions.ToInteger(text4) > 0)
						{
							text5 = _GPSPoints[Conversions.ToInteger(text4) - 1].Descrizione;
						}
						string text7 = this.TranslateMessage("XXX", "Impossibile calcolare la tratta compresa tra {0} e {1}", new string[2] { text5, text6 });
						rsmess = text7;
						val2 = val;
					}
					else
					{
						if (!(rsmess.ToUpper().Contains(value) & rsmess.ToUpper().Contains("FAILED")))
						{
							goto IL_0258;
						}
						string text8 = rsmess.Substring(rsmess.ToUpper().IndexOf(text3) + text3.Length, rsmess.ToUpper().IndexOf(")") - rsmess.ToUpper().IndexOf(text3) - text3.Length);
						string[] array = text8.Split(new char[1] { ',' });
						int num = 0;
						if (num >= array.Length)
						{
							goto IL_0258;
						}
						string text9 = array[num];
						if (Versioned.IsNumeric((object)text9))
						{
							rsmess = this.TranslateMessage("XXX", "Impossibile calcolare il percorso del viaggio a causa del punto con codice " + _GPSPoints[Conversions.ToInteger(text9)].Codice);
							val2 = val;
						}
						else
						{
							rsmess = this.TranslateMessage("XXX", "Impossibile calcolare il percorso del viaggio a causa di un punto errato.");
							val2 = val;
						}
					}
				}
			}
			goto end_IL_000b;
			IL_0258:
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
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Invalid comparison between Unknown and I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Invalid comparison between Unknown and I4
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Invalid comparison between Unknown and I4
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
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
				text += "ORDER BY Sequenza";
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
							gPSPoint.SecondiCaricoScarico = _TempoCaricoScarico;
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
					goto IL_087c;
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
					goto IL_087c;
				}
				val = val2;
			}
			goto end_IL_000e;
			IL_087c:
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

	protected FXRETURN CalculateTour(DateTime startTime, ref string rsMess)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Invalid comparison between Unknown and I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		XRouteWSClient xRouteWSClient = new XRouteWSClient();
		ResultListOptions resultListOptions = new ResultListOptions();
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		WaypointDesc waypointDesc = null;
		List<Punto> list = new List<Punto>();
		int num = 0;
		Punto punto = null;
		CallerContext callerContext = new CallerContext();
		RoutingOption[] array = new RoutingOption[0];
		ExceptionPath[] array2 = new ExceptionPath[0];
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				this.CallStackAdd();
				WaypointDesc[] array3 = new WaypointDesc[_GPSPoints.Count - 1 + 1];
				if (_GPSPoints.Count < 2)
				{
					rsMess = "Errore: per calcolare i km sono necessari almeno due punti";
				}
				else
				{
					foreach (GPSPoint gPSPoint in _GPSPoints)
					{
						waypointDesc = new TourPointDesc();
						waypointDesc.wrappedCoords = new Point[1]
						{
							new Point()
						};
						waypointDesc.wrappedCoords[0].point = new PlainPoint();
						if (Operators.CompareString(gPSPoint.Longitudine, "", false) != 0)
						{
							waypointDesc.wrappedCoords[0].point.x = Conversions.ToDouble(gPSPoint.Longitudine.Replace(".", ",")) * 100000.0;
							waypointDesc.wrappedCoords[0].point.y = Conversions.ToDouble(gPSPoint.Latitudine.Replace(".", ",")) * 100000.0;
							waypointDesc.linkType = LinkType.AUTO_LINKING;
							((TourPointDesc)waypointDesc).servicePeriod = gPSPoint.SecondiCaricoScarico;
							array3[num] = waypointDesc;
							num++;
							continue;
						}
						rsMess = "Il punto di carico/scarico con codice " + gPSPoint.Codice + " non risulta geolocalizzato";
						goto end_IL_0039;
					}
					resultListOptions.manoeuvres = false;
					resultListOptions.manoeuvreGroups = false;
					resultListOptions.texts = false;
					resultListOptions.segments = false;
					resultListOptions.polygon = false;
					resultListOptions.speedLimits = false;
					resultListOptions.detailLevel = DetailLevel.ALL;
					resultListOptions.segmentAttributes = false;
					TourOptions tourOptions_ = new TourOptions();
					RoutingOption[] array4 = null;
					List<RoutingOption> RoutingOptionList = new List<RoutingOption>();
					SetRoutingOptions(ref RoutingOptionList);
					RoutingOption routingOption = new RoutingOption();
					routingOption.parameter = RoutingParameter.START_TIME;
					routingOption.value = startTime.ToString("o");
					RoutingOptionList.Add(routingOption);
					array4 = RoutingOptionList.ToArray();
					string text = "";
					text = "SELECT * ";
					text += "FROM VW_VIAGGIO_MEZZI_TA X ";
					text = text + "WHERE X.IDVIAGGIO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
					DataTable rObjDataTable = new DataTable();
					val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if (unchecked((int)val2) > 0)
					{
						val = val2;
					}
					else if (rObjDataTable.Rows.Count != 1)
					{
						rsMess = this.TranslateMessage("XXX", "Errore nell'estrazione delle caratteristiche del mezzo");
					}
					else
					{
						decimal d = default(decimal);
						decimal d2 = default(decimal);
						decimal d3 = default(decimal);
						int num2 = 0;
						int num3 = 0;
						string value = rObjDataTable.Rows[0]["SuffissoFileTrattore"].ToString();
						string tipoADR = ((Operators.CompareString(rObjDataTable.Rows[0]["ADR"].ToString(), "", false) == 0) ? "NONE" : rObjDataTable.Rows[0]["ADR"].ToString());
						string text2 = rObjDataTable.Rows[0]["Contenitore"].ToString();
						decimal val3 = ((Operators.CompareString(rObjDataTable.Rows[0]["LarghezzaContenitore"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LarghezzaContenitore"]));
						decimal num4 = ((Operators.CompareString(rObjDataTable.Rows[0]["LunghezzaContenitore"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LunghezzaContenitore"]));
						decimal num5 = ((Operators.CompareString(rObjDataTable.Rows[0]["AltezzaContenitore"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["AltezzaContenitore"]));
						int num6 = ((Operators.CompareString(rObjDataTable.Rows[0]["TaraContenitore"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["TaraContenitore"]) : 0);
						int num7 = ((Operators.CompareString(rObjDataTable.Rows[0]["PortataPesoContenitore"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["PortataPesoContenitore"]) : 0);
						string text3 = rObjDataTable.Rows[0]["Trattore"].ToString();
						decimal num8 = ((Operators.CompareString(rObjDataTable.Rows[0]["LarghezzaTrattore"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LarghezzaTrattore"]));
						decimal num9 = ((Operators.CompareString(rObjDataTable.Rows[0]["LunghezzaTrattore"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LunghezzaTrattore"]));
						decimal num10 = ((Operators.CompareString(rObjDataTable.Rows[0]["AltezzaTrattore"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["AltezzaTrattore"]));
						int num11 = ((Operators.CompareString(rObjDataTable.Rows[0]["TaraTrattore"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["TaraTrattore"]) : 0);
						int num12 = ((Operators.CompareString(rObjDataTable.Rows[0]["PortataPesoTrattore"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["PortataPesoTrattore"]) : 0);
						string text4 = rObjDataTable.Rows[0]["Semirimorchio"].ToString();
						decimal val4 = ((Operators.CompareString(rObjDataTable.Rows[0]["LarghezzaSemirimorchio"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LarghezzaSemirimorchio"]));
						decimal d4 = ((Operators.CompareString(rObjDataTable.Rows[0]["LunghezzaSemirimorchio"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LunghezzaSemirimorchio"]));
						decimal num13 = ((Operators.CompareString(rObjDataTable.Rows[0]["AltezzaSemirimorchio"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["AltezzaSemirimorchio"]));
						int num14 = ((Operators.CompareString(rObjDataTable.Rows[0]["TaraSemirimorchio"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["TaraSemirimorchio"]) : 0);
						int num15 = ((Operators.CompareString(rObjDataTable.Rows[0]["PortataPesoSemirimorchio"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["PortataPesoSemirimorchio"]) : 0);
						if ((Operators.CompareString(text2, text3, false) == 0) & (Operators.CompareString(text4, "", false) == 0))
						{
							d = num8;
							d2 = num9;
							d3 = num10;
							num2 = num11;
							num3 = num12;
						}
						else if ((Operators.CompareString(text2, text4, false) == 0) & (Operators.CompareString(text3, text4, false) != 0))
						{
							d = Math.Max(num8, val4);
							d2 = decimal.Add(num9, d4);
							d3 = Math.Max(num10, num13);
							num2 = num11 + num14;
							num3 = num12 + num15;
						}
						else if ((Operators.CompareString(text2, text3, false) != 0) & (Operators.CompareString(text3, text4, false) != 0) & (Operators.CompareString(text3, text2, false) != 0))
						{
							d = Math.Max(Math.Max(num8, val4), val3);
							d2 = decimal.Add(num9, d4);
							d3 = Math.Max(num10, decimal.Add(num13, num5));
							num2 = num11 + num14 + num6;
							num3 = num12 + num7 + num15;
						}
						else if ((Operators.CompareString(text3, text4, false) == 0) & (Operators.CompareString(text3, text2, false) != 0))
						{
							d = Math.Max(num8, val3);
							d2 = num9;
							d3 = Math.Max(num10, num5);
							num2 = num11 + num6;
							num3 = num7;
						}
						bool flag = base.ApplicationParams.RoutingUseTrackAttributes();
						int num16 = ((!(flag | (_MaximumDistanceToSegment > 0))) ? 1 : 2);
						callerContext.wrappedProperties = new CallerContextProperty[num16 + 1];
						callerContext.wrappedProperties[0] = new CallerContextProperty();
						callerContext.wrappedProperties[0].key = "CoordFormat";
						callerContext.wrappedProperties[0].value = "PTV_GEODECIMAL";
						callerContext.wrappedProperties[1] = new CallerContextProperty();
						callerContext.wrappedProperties[1].key = "Profile";
						callerContext.wrappedProperties[1].value = value;
						if (flag | (_MaximumDistanceToSegment > 0))
						{
							bool enableRoadEditor = base.ApplicationParams.EnabledRoadEditor();
							string XmlSnippet = "";
							TruckAttributes(flag ? Convert.ToInt32(decimal.Multiply(d, 100m)) : 0, flag ? Convert.ToInt32(decimal.Multiply(d2, 100m)) : 0, flag ? Convert.ToInt32(decimal.Multiply(d3, 100m)) : 0, flag ? num2 : 0, flag ? num3 : 0, tipoADR, enableRoadEditor, _MaximumDistanceToSegment, ref XmlSnippet);
							callerContext.wrappedProperties[2] = new CallerContextProperty();
							callerContext.wrappedProperties[2].key = "ProfileXMLSnippet";
							callerContext.wrappedProperties[2].value = XmlSnippet;
						}
						_tour = xRouteWSClient.calculateAdvancedTour(array3, tourOptions_, array4, null, resultListOptions, null, callerContext);
						val = (FXRETURN)0;
					}
				}
				end_IL_0039:;
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
	}

	protected void TruckAttributes(int Larghezza, int Lunghezza, int Altezza, int Tara, int PortataPeso, string TipoADR, bool EnableRoadEditor, int MaximumDistanceToSegment, ref string XmlSnippet)
	{
		XmlSnippet = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>";
		XmlSnippet += "<Profile>";
		XmlSnippet += "<Routing majorVersion=\"2\" minorVersion=\"0\">";
		if (MaximumDistanceToSegment > 0)
		{
			XmlSnippet += "<Waypoint maximumDistanceToSegment=\"__MAXIMUMDISTANCETOSEGMENT\"/>";
		}
		if (Larghezza > 0 || Lunghezza > 0 || Altezza > 0 || Tara > 0 || PortataPeso > 0)
		{
			XmlSnippet += "<Vehicle>";
			XmlSnippet += "<Physical>";
			if (Larghezza > 0 || Lunghezza > 0 || Altezza > 0)
			{
				XmlSnippet += "<Dimension height=\"__ALTEZZA\" length=\"__LUNGHEZZA\" width=\"__LARGHEZZA\"/>";
			}
			if (Tara > 0 || PortataPeso > 0)
			{
				XmlSnippet += "<Weight emptyWeight=\"__TARA\" loadWeight=\"__PORTATAPESO\"/>";
			}
			XmlSnippet += "</Physical>";
			XmlSnippet += "<Load loadType=\"GOODS\" hazardousGoodsType=\"__TIPOADR\"/>";
			XmlSnippet += "</Vehicle>";
		}
		XmlSnippet += "<Course>";
		if (EnableRoadEditor)
		{
			XmlSnippet += "<AdditionalDataRules enabled=\"true\" layerName=\"RoadEditor\">";
		}
		else
		{
			XmlSnippet += "<AdditionalDataRules enabled=\"true\" layerName=\"Truckattributes\">";
		}
		if (Operators.CompareString(TipoADR, "", false) != 0)
		{
			XmlSnippet += "<VehicleSpecific enabled=\"true\">";
			XmlSnippet += "<Malus hazardousGoods=\"2501\" hazardousToWaters=\"2501\" vehiclesWithTrailer=\"2501\" residential=\"2500\" delivery=\"2500\" preferredForHazardousGoods=\"-99\" preferredForTrucks=\"-99\"/>";
			XmlSnippet += "</VehicleSpecific>";
		}
		XmlSnippet += "</AdditionalDataRules>";
		XmlSnippet += "</Course>";
		XmlSnippet += "</Routing>";
		XmlSnippet += "</Profile>";
		XmlSnippet = XmlSnippet.Replace("__ALTEZZA", Altezza.ToString());
		XmlSnippet = XmlSnippet.Replace("__LUNGHEZZA", Lunghezza.ToString());
		XmlSnippet = XmlSnippet.Replace("__LARGHEZZA", Larghezza.ToString());
		XmlSnippet = XmlSnippet.Replace("__TARA", Tara.ToString());
		XmlSnippet = XmlSnippet.Replace("__PORTATAPESO", PortataPeso.ToString());
		XmlSnippet = XmlSnippet.Replace("__TIPOADR", TipoADR.ToLower());
		XmlSnippet = XmlSnippet.Replace("__MAXIMUMDISTANCETOSEGMENT", MaximumDistanceToSegment.ToString());
	}

	protected void SetRoutingOptions(ref List<RoutingOption> RoutingOptionList)
	{
		RoutingOption routingOption = null;
		if (!Information.IsNothing((object)_RoutingOptions))
		{
			if (_RoutingOptions.ContainsKey("OPTIMIZATION"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.OPTIMIZATION;
				routingOption.value = _RoutingOptions["OPTIMIZATION"];
				RoutingOptionList.Add(routingOption);
			}
			if (_RoutingOptions.ContainsKey("AVOID_TOLLROADS"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_TOLLROADS;
				routingOption.value = _RoutingOptions["AVOID_TOLLROADS"];
				RoutingOptionList.Add(routingOption);
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_VIGNETTEROADS;
				routingOption.value = _RoutingOptions["AVOID_VIGNETTEROADS"];
				RoutingOptionList.Add(routingOption);
			}
			if (_RoutingOptions.ContainsKey("AVOID_HIGHWAYS"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_HIGHWAYS;
				routingOption.value = _RoutingOptions["AVOID_HIGHWAYS"];
				RoutingOptionList.Add(routingOption);
			}
			if (_RoutingOptions.ContainsKey("AVOID_FERRIES"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_FERRIES;
				routingOption.value = _RoutingOptions["AVOID_FERRIES"];
				RoutingOptionList.Add(routingOption);
			}
			if (_RoutingOptions.ContainsKey("AVOID_RESIDENTS_ONLY"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_RESIDENTS_ONLY;
				routingOption.value = _RoutingOptions["AVOID_RESIDENTS_ONLY"];
				RoutingOptionList.Add(routingOption);
			}
			if (_RoutingOptions.ContainsKey("AVOID_URBAN_AREAS"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_URBAN_AREAS;
				routingOption.value = _RoutingOptions["AVOID_URBAN_AREAS"];
				RoutingOptionList.Add(routingOption);
			}
			if (_RoutingOptions.ContainsKey("AVOID_RAMPS"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_RAMPS;
				routingOption.value = _RoutingOptions["AVOID_RAMPS"];
				RoutingOptionList.Add(routingOption);
			}
			if (_RoutingOptions.ContainsKey("AVOID_LOW_EMISSION_ZONES"))
			{
				routingOption = new RoutingOption();
				routingOption.parameter = RoutingParameter.AVOID_LOW_EMISSION_ZONES;
				routingOption.value = _RoutingOptions["AVOID_LOW_EMISSION_ZONES"];
				RoutingOptionList.Add(routingOption);
			}
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.ROUTE_LANGUAGE;
			if (_RoutingOptions.ContainsKey("ROUTE_LANGUAGE"))
			{
				routingOption.value = _RoutingOptions["ROUTE_LANGUAGE"];
			}
			else
			{
				routingOption.value = "IT";
			}
			RoutingOptionList.Add(routingOption);
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.ALLOW_SEGMENT_VIOLATIONS;
			routingOption.value = "true";
			RoutingOptionList.Add(routingOption);
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.COST_OF_SEGMENT_VIOLATIONS;
			routingOption.value = "100";
			RoutingOptionList.Add(routingOption);
			if (_RoutingOptions.ContainsKey("MAXIMUMDISTANCETOSEGMENT") && Versioned.IsNumeric((object)_RoutingOptions["MAXIMUMDISTANCETOSEGMENT"]))
			{
				_MaximumDistanceToSegment = Conversions.ToInteger(_RoutingOptions["MAXIMUMDISTANCETOSEGMENT"]);
			}
		}
	}

	protected FXRETURN ElaboraRisultato(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
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
				decimal d = default(decimal);
				int num2 = 0;
				DateTime dataPartenzaViaggio = _DataPartenzaViaggio;
				int num3 = 0;
				_DurataSecondiViaggio = _tour.tourPeriod;
				_KmViaggio = decimal.Divide(new decimal(_tour.route.info.distance), 1000m);
				if (!Information.IsNothing((object)_tour.route.wrappedStations))
				{
					WayPoint[] wrappedStations = _tour.route.wrappedStations;
					foreach (WayPoint wayPoint in wrappedStations)
					{
						int accTime = wayPoint.accTime;
						decimal num4 = decimal.Divide(new decimal(wayPoint.accDist), 1000m);
						decimal num5 = default(decimal);
						decimal num6 = default(decimal);
						num3 += _GPSPoints[num].SecondiCaricoScarico;
						num5 = decimal.Subtract(num4, d);
						num6 = new decimal(accTime - num2);
						d = num4;
						num2 = accTime;
						DateTime dateTime = DateAndTime.DateAdd((DateInterval)9, (double)accTime, _DataPartenzaViaggio);
						DateTime dateTime2 = DateAndTime.DateAdd((DateInterval)9, (double)_GPSPoints[num].SecondiCaricoScarico, dateTime);
						dataPartenzaViaggio = dateTime2;
						_GPSPoints[num].Km = num4;
						_GPSPoints[num].DataArrivo = dateTime;
						_GPSPoints[num].DataPartenza = dateTime2;
						if (num == _GPSPoints.Count - 1)
						{
							_DataArrivoViaggio = DateAndTime.DateAdd((DateInterval)9, (double)(accTime - num3), _DataPartenzaViaggio);
						}
						num++;
					}
				}
				if (!Information.IsNothing((object)_tour.wrappedTourEvents))
				{
					TourEvent[] wrappedTourEvents = _tour.wrappedTourEvents;
					foreach (TourEvent tourEvent in wrappedTourEvents)
					{
						if (Information.IsNothing((object)tourEvent.wrappedDescriptions))
						{
							continue;
						}
						string[] wrappedDescriptions = tourEvent.wrappedDescriptions;
						foreach (string text in wrappedDescriptions)
						{
							if (Operators.CompareString(text, "DRIVING", false) == 0)
							{
								_DurataSecondiGuidaViaggio += tourEvent.period;
							}
						}
					}
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
