using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.TMSServiceForMap;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class ViaggioCalcoloOttimizzatoKmETempi_GDOWSC : GdoAbstractApi
{
	protected internal class GPSPoint
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

	protected internal class GPSPoints : List<GPSPoint>
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

	[CompilerGenerated]
	internal sealed class _Closure_0024__28_002D0
	{
		public Map_GPSPoint _0024VB_0024Local_p;

		public _Closure_0024__28_002D0(_Closure_0024__28_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_p = arg0._0024VB_0024Local_p;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__0(GPSPoint t)
		{
			return Operators.CompareString(t.IdOrdine, _0024VB_0024Local_p.IdOrdine, false) == 0;
		}
	}

	protected GPSPoints _GPSPoints;

	protected GPSPoint _GPSPoint_Partenza;

	protected GPSPoint _GPSPoint_Arrivo;

	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected DataTable _dtViaggioEventi;

	protected decimal _KmViaggio;

	protected int _DurataSecondiViaggio;

	protected DateTime _DataPartenzaViaggio;

	protected DateTime? _DataArrivoViaggio;

	protected string _Algorithm;

	protected int _StatoViaggio;

	protected int _DurataSecondiGuidaViaggio;

	protected int _TempoCaricoScarico;

	protected CalcoloOttimizzatoKmETempiArgsIn _CalcoloOttimizzatoKmETempiArgsIn;

	protected CalcoloOttimizzatoKmETempiArgsOut _CalcoloOttimizzatoKmETempiArgsOut;

	protected string _ServiceUser;

	protected string _ServicePassword;

	public ViaggioCalcoloOttimizzatoKmETempi_GDOWSC(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtViaggioEventi = null;
		_KmViaggio = default(decimal);
		_DurataSecondiViaggio = 0;
		_Algorithm = "DEFAULT";
		_StatoViaggio = 0;
		_DurataSecondiGuidaViaggio = 0;
		_TempoCaricoScarico = 0;
		_CalcoloOttimizzatoKmETempiArgsIn = new CalcoloOttimizzatoKmETempiArgsIn();
		_CalcoloOttimizzatoKmETempiArgsOut = new CalcoloOttimizzatoKmETempiArgsOut();
		_ServiceUser = "";
		_ServicePassword = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Invalid comparison between Unknown and I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Invalid comparison between Unknown and I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (base.ApplicationParams.UsexTour())
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
				rsmess = this.TranslateMessage("XXX", "Impossibile eseguire il calcolo. La configurazione dell'applicazione non permette di utilizzare il servizio di ottimizzazione consegne.");
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
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Invalid comparison between Unknown and I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Invalid comparison between Unknown and I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Invalid comparison between Unknown and I4
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
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
				_GPSPoint_Partenza = new GPSPoint();
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
				_GPSPoint_Partenza.Latitudine = rObjDataTable.Rows[0]["Latitudine"].ToString();
				_GPSPoint_Partenza.Longitudine = rObjDataTable.Rows[0]["Longitudine"].ToString();
				_GPSPoint_Partenza.Descrizione = rObjDataTable.Rows[0]["RagioneSociale"].ToString() + " - " + rObjDataTable.Rows[0]["Localita"].ToString() + " - " + rObjDataTable.Rows[0]["Provincia"].ToString();
				_GPSPoint_Partenza.Codice = text2;
				_GPSPoint_Partenza.SecondiCaricoScarico = _TempoCaricoScarico;
				_GPSPoint_Partenza.DataPartenza = _DataPartenzaViaggio;
				_GPSPoints = new GPSPoints();
				foreach (DataRow row in rObjDataTable2.Rows)
				{
					string text3 = row["PCSDestinazione"].ToString();
					text = "SELECT G.*, PCS.RagioneSociale, PCS.Localita, PCS.Provincia  ";
					text += "FROM PCS PCS ";
					text += "INNER JOIN PCS_Geocodifica G ON PCS.Codice=G.Codice ";
					text = text + "WHERE PCS.Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(text3);
					val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (rObjDataTable.Rows.Count != 0)
						{
							GPSPoint gPSPoint = new GPSPoint();
							gPSPoint.Latitudine = rObjDataTable.Rows[0]["Latitudine"].ToString();
							gPSPoint.Longitudine = rObjDataTable.Rows[0]["Longitudine"].ToString();
							gPSPoint.Descrizione = rObjDataTable.Rows[0]["RagioneSociale"].ToString() + " - " + rObjDataTable.Rows[0]["Localita"].ToString() + " - " + rObjDataTable.Rows[0]["Provincia"].ToString();
							gPSPoint.Codice = text3;
							gPSPoint.SecondiCaricoScarico = _TempoCaricoScarico;
							gPSPoint.IdOrdine = row["Unibol"].ToString();
							_GPSPoints.Add(gPSPoint);
							continue;
						}
						rsMess = this.TranslateMessage("XXX", "Il punto di carico/scarico {0} del viaggio {1} non è geolocalizzato.", new string[2] { text3, _IdViaggio });
					}
					goto end_IL_000e;
				}
				string text4 = "";
				if (_StatoViaggio >= 40)
				{
					if (Operators.CompareString(_dtViaggio.Rows[0]["PCSArrivoEffettivo"].ToString(), "", false) != 0)
					{
						text4 = _dtViaggio.Rows[0]["PCSArrivoEffettivo"].ToString();
					}
				}
				else if (Operators.CompareString(_dtViaggio.Rows[0]["PCSArrivo"].ToString(), "", false) != 0)
				{
					text4 = _dtViaggio.Rows[0]["PCSArrivo"].ToString();
				}
				if (Operators.CompareString(text4, "", false) == 0)
				{
					goto IL_0872;
				}
				text = "SELECT G.*, PCS.RagioneSociale, PCS.Localita, PCS.Provincia  ";
				text += "FROM PCS PCS ";
				text += "INNER JOIN PCS_Geocodifica G ON PCS.Codice=G.Codice ";
				text = text + "WHERE PCS.Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(text4);
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (rObjDataTable.Rows.Count == 1)
					{
						_GPSPoint_Arrivo = new GPSPoint();
						_GPSPoint_Arrivo.Latitudine = rObjDataTable.Rows[0]["Latitudine"].ToString();
						_GPSPoint_Arrivo.Longitudine = rObjDataTable.Rows[0]["Longitudine"].ToString();
						_GPSPoint_Arrivo.Descrizione = rObjDataTable.Rows[0]["RagioneSociale"].ToString() + " - " + rObjDataTable.Rows[0]["Localita"].ToString() + " - " + rObjDataTable.Rows[0]["Provincia"].ToString();
						_GPSPoint_Arrivo.Codice = text4;
						_GPSPoint_Arrivo.SecondiCaricoScarico = 0;
					}
					goto IL_0872;
				}
				val = val2;
			}
			goto end_IL_000e;
			IL_0872:
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
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Invalid comparison between Unknown and I4
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			_CalcoloOttimizzatoKmETempiArgsIn.IdViaggio = Conversions.ToInteger(_IdViaggio);
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza = new Map_GPSPoint();
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.Codice = _GPSPoint_Partenza.Codice;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.DataArrivo = _GPSPoint_Partenza.DataArrivo;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.DataPartenza = _GPSPoint_Partenza.DataPartenza;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.Descrizione = _GPSPoint_Partenza.Descrizione;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.IdOrdine = _GPSPoint_Partenza.IdOrdine;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.Km = _GPSPoint_Partenza.Km;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.Latitudine = _GPSPoint_Partenza.Latitudine;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.Longitudine = _GPSPoint_Partenza.Longitudine;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Partenza.SecondiCaricoScarico = _GPSPoint_Partenza.SecondiCaricoScarico;
			_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints = new Map_GPSPoint[checked(_GPSPoints.Count - 1 + 1)];
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
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints[num] = map_GPSPoint;
					num = checked(num + 1);
				}
				if (_GPSPoint_Arrivo != null)
				{
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo = new Map_GPSPoint();
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.Codice = _GPSPoint_Arrivo.Codice;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.DataArrivo = _GPSPoint_Arrivo.DataArrivo;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.DataPartenza = _GPSPoint_Arrivo.DataPartenza;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.Descrizione = _GPSPoint_Arrivo.Descrizione;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.IdOrdine = _GPSPoint_Arrivo.IdOrdine;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.Km = _GPSPoint_Arrivo.Km;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.Latitudine = _GPSPoint_Arrivo.Latitudine;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.Longitudine = _GPSPoint_Arrivo.Longitudine;
					_CalcoloOttimizzatoKmETempiArgsIn.GPSPoints_Arrivo.SecondiCaricoScarico = _GPSPoint_Arrivo.SecondiCaricoScarico;
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
					_CalcoloOttimizzatoKmETempiArgsIn.Veicolo = new Map_Mezzo();
					_CalcoloOttimizzatoKmETempiArgsIn.Veicolo.ProfiloVelocita = rObjDataTable.Rows[0]["SuffissoFileTrattore"].ToString();
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
			result = tMSServiceForMapClient.CalcoloOttimizzatoKmETempi_DEPOT(sender, _CalcoloOttimizzatoKmETempiArgsIn, ref _CalcoloOttimizzatoKmETempiArgsOut);
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

	protected FXRETURN ElaboraRisultato(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
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
				_DurataSecondiViaggio = _CalcoloOttimizzatoKmETempiArgsOut.TotalInfo.DurataTotale.Value;
				_KmViaggio = _CalcoloOttimizzatoKmETempiArgsOut.TotalInfo.KmTotali.Value;
				_DurataSecondiGuidaViaggio = _CalcoloOttimizzatoKmETempiArgsOut.TotalInfo.DurataGuida.Value;
				_GPSPoint_Partenza.Km = _CalcoloOttimizzatoKmETempiArgsOut.GPSPoints_Partenza.Km;
				_GPSPoint_Partenza.DataArrivo = _CalcoloOttimizzatoKmETempiArgsOut.GPSPoints_Partenza.DataArrivo;
				_GPSPoint_Partenza.DataPartenza = _CalcoloOttimizzatoKmETempiArgsOut.GPSPoints_Partenza.DataPartenza;
				Map_GPSPoint[] gPSPoints = _CalcoloOttimizzatoKmETempiArgsOut.GPSPoints;
				_Closure_0024__28_002D0 closure_0024__28_002D = default(_Closure_0024__28_002D0);
				for (int i = 0; i < gPSPoints.Length; i++)
				{
					closure_0024__28_002D = new _Closure_0024__28_002D0(closure_0024__28_002D);
					closure_0024__28_002D._0024VB_0024Local_p = gPSPoints[i];
					IEnumerable<GPSPoint> source = _GPSPoints.Where(closure_0024__28_002D._Lambda_0024__0);
					GPSPoint gPSPoint = source.ElementAtOrDefault(0);
					gPSPoint.Km = closure_0024__28_002D._0024VB_0024Local_p.Km;
					gPSPoint.DataArrivo = closure_0024__28_002D._0024VB_0024Local_p.DataArrivo;
					gPSPoint.DataPartenza = closure_0024__28_002D._0024VB_0024Local_p.DataPartenza;
					DateTime dateTime = DateAndTime.DateAdd((DateInterval)9, (double)_DurataSecondiViaggio, _DataPartenzaViaggio);
					DateTime dateTime2 = DateAndTime.DateAdd((DateInterval)9, (double)_GPSPoints[num].SecondiCaricoScarico, dateTime);
					if (num == _GPSPoints.Count - 1)
					{
						_DataArrivoViaggio = DateAndTime.DateAdd((DateInterval)9, (double)_DurataSecondiViaggio, _DataPartenzaViaggio);
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
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Invalid comparison between Unknown and I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
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
			int pNumero3 = 10;
			Map_GPSPoint[] gPSPoints = _CalcoloOttimizzatoKmETempiArgsOut.GPSPoints;
			foreach (Map_GPSPoint map_GPSPoint in gPSPoints)
			{
				if (Operators.CompareString(map_GPSPoint.IdOrdine, "", false) != 0)
				{
					string text3 = text;
					DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
					pNumero = Math.Round(map_GPSPoint.Km);
					text = text3 + "UPDATE Spedizioni SET <%S.Km%>=" + dbConn3.SQLFormatNumber(ref pNumero);
					text = text + ", <%S.DataPartenza%>=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, map_GPSPoint.DataPartenza);
					text = text + ", <%S.DataArrivo%>=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, map_GPSPoint.DataArrivo) + " ";
					text = text + ", <%S.Sequenza%>=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero3) + " ";
					text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
					text = text + "AND Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(map_GPSPoint.IdOrdine) + ";";
					pNumero3 = checked(pNumero3 + 10);
				}
			}
			if (_StatoViaggio >= 40)
			{
				text = text.Replace("<%V.Km%>", "KmRicalcolati").Replace("<%V.DataPartenza%>", "DataPartenzaRicalcolata").Replace("<%V.DataArrivo%>", "DataArrivoRicalcolata")
					.Replace("<%V.MinutiGuida%>", "MinutiGuidaRicalcolati");
				text = text.Replace("<%S.Km%>", "KmRicalcolati").Replace("<%S.DataPartenza%>", "DataOraPartenzaRicalcolata").Replace("<%S.DataArrivo%>", "DataOraArrivoRicalcolata")
					.Replace("<%S.Sequenza%>", "SequenzaEffettiva");
			}
			else
			{
				text = text.Replace("<%V.Km%>", "KmPianificati").Replace("<%V.DataPartenza%>", "DataPartenzaPianificata").Replace("<%V.DataArrivo%>", "DataArrivoPianificata")
					.Replace("<%V.MinutiGuida%>", "MinutiGuidaPianificati");
				text = text.Replace("<%S.Km%>", "KmPianificati").Replace("<%S.DataPartenza%>", "DataOraPartenzaPianificata").Replace("<%S.DataArrivo%>", "DataOraArrivoPianificata")
					.Replace("<%S.Sequenza%>", "SequenzaPianificata");
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
