using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Incasbo.xTour;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

public class GdoWsc_CalcoloOttimizzatoKmETempi_DEPOT : GdoWscAbstractApi
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
			string latitudine = "";
			Latitudine = latitudine;
			latitudine = "";
			Longitudine = latitudine;
			latitudine = "";
			Codice = latitudine;
			latitudine = "";
			IdOrdine = latitudine;
			Km = default(decimal);
			int secondiCaricoScarico = 0;
			SecondiCaricoScarico = secondiCaricoScarico;
			latitudine = "";
			Descrizione = latitudine;
		}
	}

	protected class GPSPoints : List<GPSPoint>
	{
	}

	protected class Mezzo
	{
		public string ProfiloVelocita { get; set; }

		public int IdDima { get; set; }
	}

	[CompilerGenerated]
	internal class _Closure_0024__1
	{
		public SequencingTourPoint _0024VB_0024Local_tourPoint;

		public _Closure_0024__1(_Closure_0024__1 other)
		{
			if (other != null)
			{
				_0024VB_0024Local_tourPoint = other._0024VB_0024Local_tourPoint;
			}
		}

		// Ricostruito dall'IL (il decompilatore non l'aveva generato)
		internal bool _Lambda_0024__1(Map_GPSPoint t)
		{
			return Operators.CompareString(t.IdOrdine, _0024VB_0024Local_tourPoint.id.ToString(), false) == 0;
		}
	}

	protected CalcoloOttimizzatoKmETempiArgsIn _InArgs;

	protected CalcoloOttimizzatoKmETempiArgsOut _OutArgs;

	protected GPSPoint _GPSPoint_PartenzaIn;

	protected GPSPoint _GPSPoint_ArrivoIn;

	protected GPSPoints _GPSPointsIn;

	protected Mezzo _VeicoloIn;

	protected SequencingPlan _outPlan;

	protected DateTime _DataPartenzaViaggio;

	protected const int kDEPOTID = 1000;

	protected const string kDRIVING = "DRIVING";

	public GdoWsc_CalcoloOttimizzatoKmETempi_DEPOT(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_OutArgs = new CalcoloOttimizzatoKmETempiArgsOut();
		_GPSPoint_PartenzaIn = new GPSPoint();
		_GPSPoint_ArrivoIn = null;
		_GPSPointsIn = new GPSPoints();
		_VeicoloIn = new Mezzo();
		_outPlan = new SequencingPlan();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["InArgs"])))
			{
				rsmess = this.TranslateMessage("XXX", "Nessun parametro passato in input.");
			}
			else
			{
				_InArgs = (CalcoloOttimizzatoKmETempiArgsIn)((AppAbstractApi)this).ParametersIn["InArgs"];
				_OutArgs = (CalcoloOttimizzatoKmETempiArgsOut)((AppAbstractApi)this).ParametersIn["OutArgs"];
				if (Information.IsNothing((object)_InArgs.GPSPoints_Partenza))
				{
					rsmess = this.TranslateMessage("XXX", "Nessun punto di partenza passato in input. Il punto di partenza è obbligatorio");
				}
				else if (!Information.IsNothing((object)_InArgs.GPSPoints_Arrivo) && Operators.CompareString(_InArgs.GPSPoints_Partenza.Codice, _InArgs.GPSPoints_Arrivo.Codice, false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Se viene specificato, il punto di arrivo deve essere uguale a quello di partenza");
				}
				else if (Information.IsNothing((object)_InArgs.GPSPoints) || _InArgs.GPSPoints.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Nessun punto passato in input.");
				}
				else if (_InArgs.GPSPoints.Count < 2)
				{
					rsmess = this.TranslateMessage("XXX", "Servono almeno due punti in input.");
				}
				else
				{
					_DataPartenzaViaggio = ((!Information.IsNothing((object)_InArgs.GPSPoints_Partenza.DataPartenza)) ? _InArgs.GPSPoints_Partenza.DataPartenza.Value : DateAndTime.Now);
					if (Information.IsNothing((object)_InArgs.Veicolo))
					{
						rsmess = this.TranslateMessage("XXX", "Nessun veicolo passato in input. Il veicolo è obbligatorio");
					}
					else
					{
						_VeicoloIn.IdDima = _InArgs.Veicolo.IdDima;
						_VeicoloIn.ProfiloVelocita = _InArgs.Veicolo.ProfiloVelocita;
						((AppAbstractApi)this).ParametersOut.Add("OutArgs", "");
						val2 = (FXRETURN)0;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = CreateGPSPointsList(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				val = CalculateTour(_DataPartenzaViaggio, ref rsmess);
				if ((int)val != 0)
				{
					val2 = val;
				}
				else
				{
					val = ElaboraRisultato(ref rsmess);
					if ((int)val != 0)
					{
						val2 = val;
					}
					else
					{
						((AppAbstractApi)this).ParametersOut["OutArgs"] = _OutArgs;
						val2 = (FXRETURN)0;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, CalcoloOttimizzatoKmETempiArgsIn InArgs, ref CalcoloOttimizzatoKmETempiArgsOut OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			GdoWsc_CalcoloOttimizzatoKmETempi_DEPOT gdoWsc_CalcoloOttimizzatoKmETempi_DEPOT = new GdoWsc_CalcoloOttimizzatoKmETempi_DEPOT(objApiContext);
			((AppAbstractApi)gdoWsc_CalcoloOttimizzatoKmETempi_DEPOT).ParametersIn.Add("InArgs", InArgs);
			((AppAbstractApi)gdoWsc_CalcoloOttimizzatoKmETempi_DEPOT).ParametersIn.Add("OutArgs", OutArgs);
			val = ((AppAbstractApi)gdoWsc_CalcoloOttimizzatoKmETempi_DEPOT).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				OutArgs = (CalcoloOttimizzatoKmETempiArgsOut)((AppAbstractApi)gdoWsc_CalcoloOttimizzatoKmETempi_DEPOT).ParametersOut["OutArgs"];
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}

	protected FXRETURN CreateGPSPointsList(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			_GPSPoint_PartenzaIn.Latitudine = _InArgs.GPSPoints_Partenza.Latitudine;
			_GPSPoint_PartenzaIn.Longitudine = _InArgs.GPSPoints_Partenza.Longitudine;
			_GPSPoint_PartenzaIn.Codice = _InArgs.GPSPoints_Partenza.Codice;
			_GPSPoint_PartenzaIn.IdOrdine = _InArgs.GPSPoints_Partenza.IdOrdine;
			_GPSPoint_PartenzaIn.Km = _InArgs.GPSPoints_Partenza.Km;
			_GPSPoint_PartenzaIn.DataPartenza = _InArgs.GPSPoints_Partenza.DataPartenza;
			_GPSPoint_PartenzaIn.DataArrivo = _InArgs.GPSPoints_Partenza.DataArrivo;
			_GPSPoint_PartenzaIn.SecondiCaricoScarico = _InArgs.GPSPoints_Partenza.SecondiCaricoScarico;
			_GPSPoint_PartenzaIn.Descrizione = _InArgs.GPSPoints_Partenza.Descrizione;
			foreach (Map_GPSPoint gPSPoint2 in _InArgs.GPSPoints)
			{
				GPSPoint gPSPoint = new GPSPoint();
				gPSPoint.Latitudine = gPSPoint2.Latitudine;
				gPSPoint.Longitudine = gPSPoint2.Longitudine;
				gPSPoint.Codice = gPSPoint2.Codice;
				gPSPoint.IdOrdine = gPSPoint2.IdOrdine;
				gPSPoint.Km = gPSPoint2.Km;
				gPSPoint.DataPartenza = gPSPoint2.DataPartenza;
				gPSPoint.DataArrivo = gPSPoint2.DataArrivo;
				gPSPoint.SecondiCaricoScarico = gPSPoint2.SecondiCaricoScarico;
				gPSPoint.Descrizione = gPSPoint2.Descrizione;
				_GPSPointsIn.Add(gPSPoint);
			}
			if (!Information.IsNothing((object)_InArgs.GPSPoints_Arrivo))
			{
				_GPSPoint_ArrivoIn = new GPSPoint();
				_GPSPoint_ArrivoIn.Latitudine = _InArgs.GPSPoints_Arrivo.Latitudine;
				_GPSPoint_ArrivoIn.Longitudine = _InArgs.GPSPoints_Arrivo.Longitudine;
				_GPSPoint_ArrivoIn.Codice = _InArgs.GPSPoints_Arrivo.Codice;
				_GPSPoint_ArrivoIn.IdOrdine = _InArgs.GPSPoints_Arrivo.IdOrdine;
				_GPSPoint_ArrivoIn.Km = _InArgs.GPSPoints_Arrivo.Km;
				_GPSPoint_ArrivoIn.DataPartenza = _InArgs.GPSPoints_Arrivo.DataPartenza;
				_GPSPoint_ArrivoIn.DataArrivo = _InArgs.GPSPoints_Arrivo.DataArrivo;
				_GPSPoint_ArrivoIn.SecondiCaricoScarico = _InArgs.GPSPoints_Arrivo.SecondiCaricoScarico;
				_GPSPoint_ArrivoIn.Descrizione = _InArgs.GPSPoints_Arrivo.Descrizione;
			}
			val = (FXRETURN)0;
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
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		XTourWSClient xTourWSClient = new XTourWSClient();
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				this.CallStackAdd();
				Depot[] array = null;
				Depot depot = new Depot();
				depot.id = 1000;
				depot.description = _GPSPoint_PartenzaIn.Codice;
				depot.location = new Point();
				depot.location.point = new PlainPoint();
				depot.location.point.x = Conversions.ToDouble(_GPSPoint_PartenzaIn.Longitudine.Replace(".", ","));
				depot.location.point.y = Conversions.ToDouble(_GPSPoint_PartenzaIn.Latitudine.Replace(".", ","));
				if (Information.IsNothing((object)_GPSPoint_ArrivoIn) || Operators.CompareString(_GPSPoint_PartenzaIn.Codice, _GPSPoint_ArrivoIn.Codice, false) == 0)
				{
					array = new Depot[1] { depot };
				}
				SequencingTransportOrder[] array2 = new SequencingTransportOrder[_GPSPointsIn.Count - 1 + 1];
				int num = _GPSPointsIn.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					TransportPoint transportPoint = new TransportPoint();
					transportPoint.id = Conversions.ToInteger(_GPSPointsIn[i].IdOrdine);
					transportPoint.description = _GPSPointsIn[i].Codice;
					transportPoint.location = new Point();
					transportPoint.location.point = new PlainPoint();
					transportPoint.location.point.x = Conversions.ToDouble(_GPSPointsIn[i].Longitudine.Replace(".", ","));
					transportPoint.location.point.y = Conversions.ToDouble(_GPSPointsIn[i].Latitudine.Replace(".", ","));
					transportPoint.servicePeriod = _GPSPointsIn[i].SecondiCaricoScarico;
					SequencingTransportDepot sequencingTransportDepot = new SequencingTransportDepot();
					sequencingTransportDepot.transportPoint = transportPoint;
					sequencingTransportDepot.id = Conversions.ToInteger(_GPSPointsIn[i].IdOrdine);
					array2[i] = sequencingTransportDepot;
				}
				SequencingParams sequencingParams = new SequencingParams();
				DistanceMatrixByRoad distanceMatrixByRoad = new DistanceMatrixByRoad();
				distanceMatrixByRoad.dimaId = _InArgs.IdViaggio;
				distanceMatrixByRoad.profileName = "dima" + _VeicoloIn.ProfiloVelocita;
				distanceMatrixByRoad.deleteBeforeUsage = true;
				distanceMatrixByRoad.deleteAfterUsage = true;
				DistanceMatrixByRoad[] wrappedDistanceMatrixCalculation = new DistanceMatrixByRoad[1] { distanceMatrixByRoad };
				sequencingParams.wrappedDistanceMatrixCalculation = wrappedDistanceMatrixCalculation;
				sequencingParams.maximumNumberOfUnscheduledOrdersToBeAnalyzed = _InArgs.GPSPoints.Count;
				sequencingParams.maximumNumberOfUnscheduledOrdersToBeAnalyzedSpecified = true;
				CallerContextProperty callerContextProperty = new CallerContextProperty();
				callerContextProperty.key = "CoordFormat";
				callerContextProperty.value = "OG_GEODECIMAL";
				CallerContext callerContext = new CallerContext();
				callerContext.wrappedProperties = new CallerContextProperty[1] { callerContextProperty };
				SequencingVehicle sequencingVehicle = new SequencingVehicle();
				sequencingVehicle.dimaId = _InArgs.IdViaggio;
				sequencingVehicle.dimaIdSpecified = true;
				sequencingVehicle.depotIdStart = array[0].id;
				sequencingVehicle.departureTimeFixed = (int)Math.Round(startTime.TimeOfDay.TotalSeconds);
				sequencingVehicle.departureTimeFixedSpecified = true;
				if (Information.IsNothing((object)_GPSPoint_ArrivoIn))
				{
					sequencingVehicle.depotIdEnd = -1;
				}
				else if (array.Count() == 1)
				{
					sequencingVehicle.depotIdEnd = array[0].id;
				}
				_outPlan = xTourWSClient.planSequence(array2, array, sequencingVehicle, sequencingParams, null, callerContext);
				val = (FXRETURN)0;
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

	protected FXRETURN ElaboraRisultato(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
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
				_OutArgs.IdViaggio = _InArgs.IdViaggio;
				_OutArgs.TotalInfo = new Map_TotalInfo();
				_OutArgs.TotalInfo.DurataTotale = _outPlan.tour.result.period;
				_OutArgs.TotalInfo.KmTotali = decimal.Divide(new decimal(_outPlan.tour.result.distance), 1000m);
				_OutArgs.TotalInfo.DurataGuida = _outPlan.tour.result.drivingPeriod;
				_OutArgs.GPSPoints = new List<Map_GPSPoint>();
				if (!Information.IsNothing((object)_outPlan.tour.wrappedTourPoints))
				{
					SequencingTourPoint[] wrappedTourPoints = _outPlan.tour.wrappedTourPoints;
					_Closure_0024__1 closure_0024__ = default(_Closure_0024__1);
					for (int i = 0; i < wrappedTourPoints.Length; i++)
					{
						closure_0024__ = new _Closure_0024__1(closure_0024__);
						closure_0024__._0024VB_0024Local_tourPoint = wrappedTourPoints[i];
						if (closure_0024__._0024VB_0024Local_tourPoint.type == TourPointType.DEPOT)
						{
							if (num == 0)
							{
								_InArgs.GPSPoints_Partenza.Km = new decimal((double)closure_0024__._0024VB_0024Local_tourPoint.result.startDistance / 1000.0);
								_InArgs.GPSPoints_Partenza.DataArrivo = _DataPartenzaViaggio.Date.AddSeconds(closure_0024__._0024VB_0024Local_tourPoint.result.arrivalTime);
								_InArgs.GPSPoints_Partenza.DataPartenza = _DataPartenzaViaggio.Date.AddSeconds(closure_0024__._0024VB_0024Local_tourPoint.result.departureTime);
								_OutArgs.GPSPoints_Partenza = new Map_GPSPoint();
								_OutArgs.GPSPoints_Partenza.Codice = _InArgs.GPSPoints_Partenza.Codice;
								_OutArgs.GPSPoints_Partenza.Descrizione = _InArgs.GPSPoints_Partenza.Descrizione;
								_OutArgs.GPSPoints_Partenza.IdOrdine = _InArgs.GPSPoints_Partenza.IdOrdine;
								_OutArgs.GPSPoints_Partenza.Latitudine = _InArgs.GPSPoints_Partenza.Latitudine;
								_OutArgs.GPSPoints_Partenza.Longitudine = _InArgs.GPSPoints_Partenza.Longitudine;
								_OutArgs.GPSPoints_Partenza.SecondiCaricoScarico = _InArgs.GPSPoints_Partenza.SecondiCaricoScarico;
								_OutArgs.GPSPoints_Partenza.Km = _InArgs.GPSPoints_Partenza.Km;
								_OutArgs.GPSPoints_Partenza.DataArrivo = _InArgs.GPSPoints_Partenza.DataArrivo;
								_OutArgs.GPSPoints_Partenza.DataPartenza = _InArgs.GPSPoints_Partenza.DataPartenza;
							}
							else if (num == _outPlan.tour.wrappedTourPoints.Count() - 1)
							{
								_InArgs.GPSPoints_Arrivo.Km = new decimal((double)closure_0024__._0024VB_0024Local_tourPoint.result.startDistance / 1000.0);
								_InArgs.GPSPoints_Arrivo.DataArrivo = _DataPartenzaViaggio.Date.AddSeconds(closure_0024__._0024VB_0024Local_tourPoint.result.arrivalTime);
								_InArgs.GPSPoints_Arrivo.DataPartenza = _DataPartenzaViaggio.Date.AddSeconds(closure_0024__._0024VB_0024Local_tourPoint.result.departureTime);
								_OutArgs.GPSPoints_Arrivo = new Map_GPSPoint();
								_OutArgs.GPSPoints_Arrivo.Codice = _InArgs.GPSPoints_Arrivo.Codice;
								_OutArgs.GPSPoints_Arrivo.Descrizione = _InArgs.GPSPoints_Arrivo.Descrizione;
								_OutArgs.GPSPoints_Arrivo.IdOrdine = _InArgs.GPSPoints_Arrivo.IdOrdine;
								_OutArgs.GPSPoints_Arrivo.Latitudine = _InArgs.GPSPoints_Arrivo.Latitudine;
								_OutArgs.GPSPoints_Arrivo.Longitudine = _InArgs.GPSPoints_Arrivo.Longitudine;
								_OutArgs.GPSPoints_Arrivo.SecondiCaricoScarico = _InArgs.GPSPoints_Arrivo.SecondiCaricoScarico;
								_OutArgs.GPSPoints_Arrivo.Km = _InArgs.GPSPoints_Arrivo.Km;
								_OutArgs.GPSPoints_Arrivo.DataArrivo = _InArgs.GPSPoints_Arrivo.DataArrivo;
								_OutArgs.GPSPoints_Arrivo.DataPartenza = _InArgs.GPSPoints_Arrivo.DataPartenza;
							}
						}
						else if (closure_0024__._0024VB_0024Local_tourPoint.type == TourPointType.TRANSPORT_POINT)
						{
							IEnumerable<Map_GPSPoint> source = _InArgs.GPSPoints.Where(closure_0024__._Lambda_0024__1);
							Map_GPSPoint map_GPSPoint = source.ElementAtOrDefault(0);
							map_GPSPoint.Km = new decimal((double)closure_0024__._0024VB_0024Local_tourPoint.result.startDistance / 1000.0);
							map_GPSPoint.DataArrivo = _DataPartenzaViaggio.Date.AddSeconds(closure_0024__._0024VB_0024Local_tourPoint.result.arrivalTime);
							map_GPSPoint.DataPartenza = _DataPartenzaViaggio.Date.AddSeconds(closure_0024__._0024VB_0024Local_tourPoint.result.departureTime);
							_OutArgs.GPSPoints.Add(map_GPSPoint);
						}
						num++;
					}
				}
				_OutArgs.Veicolo = _InArgs.Veicolo;
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
}
