using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.TMSServiceForMap;
using Incasbo.Web.Library;
using Incasbo.xRoute;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_DeterminaPCSPiuLontano : GdoAbstractApi
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

	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected DataTable _dtPCS;

	protected GPSPoints _GPSPoints;

	protected string _CurrentPCS;

	protected string _Speed_Profile;

	protected Dictionary<string, string> _RoutingOptions;

	protected CalcoloKmETempiArgsIn _CalcoloKmETempiArgsIn;

	protected CalcoloKmETempiArgsOut _CalcoloKmETempiArgsOut;

	protected string _ServiceUser;

	protected string _ServicePassword;

	protected decimal _KmMax;

	protected string _PCSPiuLontano;

	public Viaggio_DeterminaPCSPiuLontano(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtPCS = null;
		_CurrentPCS = "";
		_Speed_Profile = "";
		_RoutingOptions = null;
		_CalcoloKmETempiArgsIn = new CalcoloKmETempiArgsIn();
		_CalcoloKmETempiArgsOut = new CalcoloKmETempiArgsOut();
		_ServiceUser = "";
		_ServicePassword = "";
		_KmMax = default(decimal);
		_PCSPiuLontano = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(base.ApplicationParams.UsexRoute(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Impossibile eseguire il calcolo del PCS più lontano. La configurazione dell'applicazione non permette di utilizzare il servizio di routing.");
			}
			else if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["ServiceUser"].ToString(), "", false) == 0)
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
						val = CheckViaggio(ref rsmess);
						val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = GetPCS(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in _dtPCS.Rows)
				{
					_CurrentPCS = row["PCS"].ToString();
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
								if ((int)val <= 0)
								{
									continue;
								}
								val2 = val;
							}
						}
					}
					goto end_IL_0005;
				}
				val = AggiornaViaggio(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Stato, PCSPartenza, ZonaArrivo, ZonaArrivoTariffaAttiva, TipoMerce FROM VIAGGI WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} non esiste", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) > 20)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} non è in uno stato che permetta il calcolo del PCS più lontano", new string[1] { _IdViaggio });
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

	protected virtual FXRETURN GetPCS(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT ISNULL(Corrispondente, PCSDestinazione) AS PCS FROM Spedizioni WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
			text += "GROUP BY ISNULL(Corrispondente, PCSDestinazione) ";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtPCS, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtPCS.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Non è stato possibile recuperare i PCS/Corrispondenti per il viaggio ", new string[1] { _IdViaggio });
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

	protected FXRETURN CreateGPSPointsList(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between Unknown and I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			_GPSPoints = new GPSPoints();
			string text2 = "";
			if (Operators.CompareString(_dtViaggio.Rows[0]["PCSPartenza"].ToString(), "", false) == 0)
			{
				rsMess = this.TranslateMessage("XXX", "Il punto di partenza pianificato del viaggio {0} non è valorizzato.", new string[1] { _IdViaggio });
			}
			else
			{
				text2 = _dtViaggio.Rows[0]["PCSPartenza"].ToString();
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
					_GPSPoints.Add(gPSPoint);
					text = "SELECT G.*, PCS.RagioneSociale, PCS.Localita, PCS.Provincia  ";
					text += "FROM PCS PCS ";
					text += "INNER JOIN PCS_Geocodifica G ON PCS.Codice=G.Codice ";
					text = text + "WHERE PCS.Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_CurrentPCS);
					val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else if (rObjDataTable.Rows.Count == 0)
					{
						rsMess = this.TranslateMessage("XXX", "Il PCS/Corrispondente {0} del viaggio {1} non è geolocalizzato.", new string[2] { _CurrentPCS, _IdViaggio });
					}
					else
					{
						gPSPoint = new GPSPoint();
						gPSPoint.Latitudine = rObjDataTable.Rows[0]["Latitudine"].ToString();
						gPSPoint.Longitudine = rObjDataTable.Rows[0]["Longitudine"].ToString();
						gPSPoint.Descrizione = rObjDataTable.Rows[0]["RagioneSociale"].ToString() + " - " + rObjDataTable.Rows[0]["Localita"].ToString() + " - " + rObjDataTable.Rows[0]["Provincia"].ToString();
						gPSPoint.Codice = _CurrentPCS;
						_GPSPoints.Add(gPSPoint);
						val = (FXRETURN)0;
					}
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
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int num = 0;
		FXRETURN result;
		try
		{
			rsMess = "";
			this.CallStackAdd();
			decimal num2 = default(decimal);
			if (_CalcoloKmETempiArgsOut.TotalInfo.KmTotali.HasValue)
			{
				num2 = _CalcoloKmETempiArgsOut.TotalInfo.KmTotali.Value;
			}
			if (decimal.Compare(num2, _KmMax) > 0)
			{
				_KmMax = num2;
				_PCSPiuLontano = _CurrentPCS;
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

	protected FXRETURN CheckPCS(ref string ZonaArrivo, ref string ZonaArrivoTariffaAttiva, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string pCSPiuLontano = _PCSPiuLontano;
			string text = _dtViaggio.Rows[0]["ZonaArrivo"].ToString();
			string text2 = _dtViaggio.Rows[0]["ZonaArrivoTariffaAttiva"].ToString();
			string tipoMerce = _dtViaggio.Rows[0]["TipoMerce"].ToString();
			if (!((Operators.CompareString(text, "", false) == 0) | (Operators.CompareString(text2, "", false) == 0)) || Operators.CompareString(pCSPiuLontano, "", false) == 0)
			{
				goto IL_00ea;
			}
			AppApiContext apiContext = this._ApiContext;
			string ZonaSpedizione = "";
			val = PCS_DeterminaZone.RunProc(apiContext, pCSPiuLontano, tipoMerce, ref ZonaSpedizione, ref ZonaArrivoTariffaAttiva, ref ZonaArrivo, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_00ea;
			}
			val2 = val;
			goto end_IL_0005;
			IL_00ea:
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

	protected FXRETURN AggiornaViaggio(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			this.CallStackAdd();
			if (Operators.CompareString(_PCSPiuLontano, "", false) == 0)
			{
				goto IL_0130;
			}
			text = "UPDATE Viaggi SET PCSArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCSPiuLontano) + " ";
			string ZonaArrivo = "";
			string ZonaArrivoTariffaAttiva = "";
			val2 = CheckPCS(ref ZonaArrivo, ref ZonaArrivoTariffaAttiva, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(ZonaArrivo, "", false) != 0)
				{
					text = text + ", ZonaArrivo=" + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaArrivo) + " ";
				}
				if (Operators.CompareString(ZonaArrivoTariffaAttiva, "", false) != 0)
				{
					text = text + ", ZonaArrivoTariffaAttiva=" + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaArrivoTariffaAttiva) + " ";
				}
				text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
				val2 = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0130;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_0130:
			val = (FXRETURN)0;
			end_IL_000b:;
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
