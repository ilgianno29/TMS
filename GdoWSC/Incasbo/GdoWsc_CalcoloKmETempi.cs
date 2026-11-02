using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Incasbo.xRoute;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

public class GdoWsc_CalcoloKmETempi : GdoWscAbstractApi
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

	protected CalcoloKmETempiArgsIn _InArgs;

	protected CalcoloKmETempiArgsOut _OutArgs;

	protected GPSPoints _GPSPointsIn;

	protected AdvancedTour _tour;

	protected DateTime _DataPartenzaViaggio;

	protected const string kDRIVING = "DRIVING";

	protected int? _Optimization;

	protected int? _Avoid_TollRoads;

	protected int? _Avoid_Highways;

	protected int? _Avoid_Ferries;

	protected int? _Avoid_Residents_Only;

	protected int? _Avoid_Urban_Areas;

	protected int? _Avoid_Ramps;

	protected int? _Avoid_VignetteRoads;

	protected int? _Avoid_Low_Emission_Zones;

	protected string _Route_Language;

	protected string _Speed_Profile;

	protected int _MaximumDistanceToSegment;

	public GdoWsc_CalcoloKmETempi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_OutArgs = new CalcoloKmETempiArgsOut();
		_GPSPointsIn = new GPSPoints();
		_tour = null;
		_Route_Language = "";
		_Speed_Profile = "";
		_MaximumDistanceToSegment = 0;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(ApplicationParams.UsexRoute(), "S", false) == 0)
			{
				if (Information.IsNothing(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["InArgs"])))
				{
					rsmess = this.TranslateMessage("XXX", "Nessun parametro passato in input.");
				}
				else
				{
					_InArgs = (CalcoloKmETempiArgsIn)((AppAbstractApi)this).ParametersIn["InArgs"];
					_OutArgs = (CalcoloKmETempiArgsOut)((AppAbstractApi)this).ParametersIn["OutArgs"];
					if (Information.IsNothing((object)_InArgs.GPSPoints) || _InArgs.GPSPoints.Count == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Nessun punto passato in input.");
					}
					else if (_InArgs.GPSPoints.Count < 2)
					{
						rsmess = this.TranslateMessage("XXX", "Servono almeno due punti in input.");
					}
					else
					{
						_DataPartenzaViaggio = ((!Information.IsNothing((object)_InArgs.GPSPoints[0].DataPartenza)) ? _InArgs.GPSPoints[0].DataPartenza.Value : DateAndTime.Now);
						if (Information.IsNothing((object)_InArgs.RoutingOptions))
						{
							_Route_Language = "IT";
							_Speed_Profile = "default";
							goto IL_076d;
						}
						if (Information.IsNothing((object)_InArgs.RoutingOptions.Optimization))
						{
							goto IL_01e2;
						}
						if (!((_InArgs.RoutingOptions.Optimization.Value < 0) | (_InArgs.RoutingOptions.Optimization.Value > 100)))
						{
							_Optimization = _InArgs.RoutingOptions.Optimization.Value;
							goto IL_01e2;
						}
						rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro OPTIMIZATION (da 0 a 100).");
					}
				}
			}
			else
			{
				rsmess = this.TranslateMessage("XXX", "Impossibile eseguire il calcolo. La configurazione dell'applicazione non permette di utilizzare il servizio di routing.");
			}
			goto end_IL_0004;
			IL_0499:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_Ramps))
			{
				goto IL_0524;
			}
			if (!((_InArgs.RoutingOptions.Avoid_Ramps.Value < -99) | (_InArgs.RoutingOptions.Avoid_Ramps.Value > 2501)))
			{
				_Avoid_Ramps = _InArgs.RoutingOptions.Avoid_Ramps.Value;
				goto IL_0524;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_RAMPS (da -99 a 2501).");
			goto end_IL_0004;
			IL_0383:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_Residents_Only))
			{
				goto IL_040e;
			}
			if (!((_InArgs.RoutingOptions.Avoid_Residents_Only.Value < -99) | (_InArgs.RoutingOptions.Avoid_Residents_Only.Value > 2501)))
			{
				_Avoid_Residents_Only = _InArgs.RoutingOptions.Avoid_Residents_Only.Value;
				goto IL_040e;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_RESIDENTS_ONLY (da -99 a 2501).");
			goto end_IL_0004;
			IL_01e2:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_TollRoads))
			{
				goto IL_026d;
			}
			if (!((_InArgs.RoutingOptions.Avoid_TollRoads.Value < -99) | (_InArgs.RoutingOptions.Avoid_TollRoads.Value > 2501)))
			{
				_Avoid_TollRoads = _InArgs.RoutingOptions.Avoid_TollRoads.Value;
				goto IL_026d;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_TOLLROADS (da -99 a 2501).");
			goto end_IL_0004;
			IL_05af:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_Low_Emission_Zones))
			{
				goto IL_063a;
			}
			if (!((_InArgs.RoutingOptions.Avoid_Low_Emission_Zones.Value < -99) | (_InArgs.RoutingOptions.Avoid_Low_Emission_Zones.Value > 2501)))
			{
				_Avoid_Low_Emission_Zones = _InArgs.RoutingOptions.Avoid_Low_Emission_Zones.Value;
				goto IL_063a;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_LOW_EMISSION_ZONES (da -99 a 2501).");
			goto end_IL_0004;
			IL_026d:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_Highways))
			{
				goto IL_02f8;
			}
			if (!((_InArgs.RoutingOptions.Avoid_Highways.Value < -99) | (_InArgs.RoutingOptions.Avoid_Highways.Value > 2501)))
			{
				_Avoid_Highways = _InArgs.RoutingOptions.Avoid_Highways.Value;
				goto IL_02f8;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_HIGHWAYS (da -99 a 2501).");
			goto end_IL_0004;
			IL_0524:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_VignetteRoads))
			{
				goto IL_05af;
			}
			if (!((_InArgs.RoutingOptions.Avoid_VignetteRoads.Value < -99) | (_InArgs.RoutingOptions.Avoid_VignetteRoads.Value > 2501)))
			{
				_Avoid_VignetteRoads = _InArgs.RoutingOptions.Avoid_VignetteRoads.Value;
				goto IL_05af;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_VIGNETTEROADS (da -99 a 2501).");
			goto end_IL_0004;
			IL_063a:
			if (Operators.CompareString(_InArgs.RoutingOptions.Route_Language, "", false) != 0)
			{
				_Route_Language = _InArgs.RoutingOptions.Route_Language;
			}
			else
			{
				_Route_Language = "IT";
			}
			if (Operators.CompareString(_InArgs.RoutingOptions.Speed_Profile, "", false) != 0)
			{
				_Speed_Profile = _InArgs.RoutingOptions.Speed_Profile;
			}
			else
			{
				_Speed_Profile = "default";
			}
			if (!Information.IsNothing((object)_InArgs.RoutingOptions.MaximumDistanceToSegment))
			{
				int num = 0;
				int? maximumDistanceToSegment = _InArgs.RoutingOptions.MaximumDistanceToSegment;
				bool? obj;
				if (!maximumDistanceToSegment.HasValue)
				{
					obj = null;
				}
				else
				{
					bool? flag = maximumDistanceToSegment.GetValueOrDefault() > num;
					obj = flag;
				}
				bool? flag2 = obj;
				if (flag2.GetValueOrDefault())
				{
					_MaximumDistanceToSegment = _InArgs.RoutingOptions.MaximumDistanceToSegment.Value;
				}
			}
			goto IL_076d;
			IL_040e:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_Urban_Areas))
			{
				goto IL_0499;
			}
			if (!((_InArgs.RoutingOptions.Avoid_Urban_Areas.Value < -99) | (_InArgs.RoutingOptions.Avoid_Urban_Areas.Value > 2501)))
			{
				_Avoid_Urban_Areas = _InArgs.RoutingOptions.Avoid_Urban_Areas.Value;
				goto IL_0499;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_URBAN_AREAS (da -99 a 2501).");
			goto end_IL_0004;
			IL_02f8:
			if (Information.IsNothing((object)_InArgs.RoutingOptions.Avoid_Ferries))
			{
				goto IL_0383;
			}
			if (!((_InArgs.RoutingOptions.Avoid_Ferries.Value < -99) | (_InArgs.RoutingOptions.Avoid_Ferries.Value > 2501)))
			{
				_Avoid_Ferries = _InArgs.RoutingOptions.Avoid_Ferries.Value;
				goto IL_0383;
			}
			rsmess = this.TranslateMessage("XXX", "Valore non corretto per il parametro AVOID_FERRIES (da -99 a 2501).");
			goto end_IL_0004;
			IL_076d:
			((AppAbstractApi)this).ParametersOut.Add("OutArgs", "");
			val2 = (FXRETURN)0;
			end_IL_0004:;
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
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Invalid comparison between Unknown and I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
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
				if ((int)val == 0)
				{
					goto IL_0233;
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
						text6 = _GPSPointsIn[Conversions.ToInteger(text4)].Descrizione;
						text5 = text6;
						if (Conversions.ToInteger(text4) > 0)
						{
							text5 = _GPSPointsIn[Conversions.ToInteger(text4) - 1].Descrizione;
						}
						string text7 = this.TranslateMessage("XXX", "Impossibile calcolare la tratta compresa tra {0} e {1}", new string[2] { text5, text6 });
						rsmess = text7;
						val2 = val;
					}
					else
					{
						if (!(rsmess.ToUpper().Contains(value) & rsmess.ToUpper().Contains("FAILED")))
						{
							goto IL_0233;
						}
						string text8 = rsmess.Substring(rsmess.ToUpper().IndexOf(text3) + text3.Length, rsmess.ToUpper().IndexOf(")") - rsmess.ToUpper().IndexOf(text3) - text3.Length);
						string[] array = text8.Split(new char[1] { ',' });
						int num = 0;
						if (num >= array.Length)
						{
							goto IL_0233;
						}
						string text9 = array[num];
						if (Versioned.IsNumeric((object)text9))
						{
							rsmess = this.TranslateMessage("XXX", "Impossibile calcolare il percorso del viaggio a causa del punto con codice " + _GPSPointsIn[Conversions.ToInteger(text9)].Codice);
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
			goto end_IL_000a;
			IL_0233:
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
			end_IL_000a:;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, CalcoloKmETempiArgsIn InArgs, ref CalcoloKmETempiArgsOut OutArgs, ref string rsmess)
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
			GdoWsc_CalcoloKmETempi gdoWsc_CalcoloKmETempi = new GdoWsc_CalcoloKmETempi(objApiContext);
			((AppAbstractApi)gdoWsc_CalcoloKmETempi).ParametersIn.Add("InArgs", InArgs);
			((AppAbstractApi)gdoWsc_CalcoloKmETempi).ParametersIn.Add("OutArgs", OutArgs);
			val = ((AppAbstractApi)gdoWsc_CalcoloKmETempi).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				OutArgs = (CalcoloKmETempiArgsOut)((AppAbstractApi)gdoWsc_CalcoloKmETempi).ParametersOut["OutArgs"];
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
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		XRouteWSClient xRouteWSClient = new XRouteWSClient();
		ResultListOptions resultListOptions = new ResultListOptions();
		WaypointDesc waypointDesc = null;
		CallerContext callerContext = new CallerContext();
		RoutingOption[] array = new RoutingOption[0];
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				this.CallStackAdd();
				WaypointDesc[] array2 = new WaypointDesc[_GPSPointsIn.Count - 1 + 1];
				if (_GPSPointsIn.Count < 2)
				{
					rsMess = "Errore: per calcolare i km sono necessari almeno due punti";
				}
				else
				{
					int num = 0;
					foreach (GPSPoint item in _GPSPointsIn)
					{
						waypointDesc = new TourPointDesc();
						waypointDesc.wrappedCoords = new Point[1]
						{
							new Point()
						};
						waypointDesc.wrappedCoords[0].point = new PlainPoint();
						if (Operators.CompareString(item.Longitudine, "", false) != 0)
						{
							waypointDesc.wrappedCoords[0].point.x = Conversions.ToDouble(item.Longitudine.Replace(".", ",")) * 100000.0;
							waypointDesc.wrappedCoords[0].point.y = Conversions.ToDouble(item.Latitudine.Replace(".", ",")) * 100000.0;
							waypointDesc.linkType = LinkType.AUTO_LINKING;
							((TourPointDesc)waypointDesc).servicePeriod = item.SecondiCaricoScarico;
							array2[num] = waypointDesc;
							num++;
							continue;
						}
						rsMess = "Il punto di carico/scarico con codice " + item.Codice + " non risulta geolocalizzato";
						goto end_IL_0023;
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
					RoutingOption[] array3 = null;
					List<RoutingOption> RoutingOptionList = new List<RoutingOption>();
					SetRoutingOptions(ref RoutingOptionList);
					RoutingOption routingOption = new RoutingOption();
					routingOption.parameter = RoutingParameter.START_TIME;
					routingOption.value = startTime.ToString("o");
					RoutingOptionList.Add(routingOption);
					array3 = RoutingOptionList.ToArray();
					int num2 = ((_MaximumDistanceToSegment <= 0) ? 1 : 2);
					callerContext.wrappedProperties = new CallerContextProperty[num2 + 1];
					callerContext.wrappedProperties[0] = new CallerContextProperty();
					callerContext.wrappedProperties[0].key = "CoordFormat";
					callerContext.wrappedProperties[0].value = "PTV_GEODECIMAL";
					callerContext.wrappedProperties[1] = new CallerContextProperty();
					callerContext.wrappedProperties[1].key = "Profile";
					callerContext.wrappedProperties[1].value = _Speed_Profile;
					if (_MaximumDistanceToSegment > 0)
					{
						bool flag = ApplicationParams.EnabledRoadEditor();
						string XmlSnippet = "";
						TruckAttributes(0, 0, 0, 0, 0, "", EnableRoadEditor: false, _MaximumDistanceToSegment, ref XmlSnippet);
						callerContext.wrappedProperties[2] = new CallerContextProperty();
						callerContext.wrappedProperties[2].key = "ProfileXMLSnippet";
						callerContext.wrappedProperties[2].value = XmlSnippet;
					}
					_tour = xRouteWSClient.calculateAdvancedTour(array2, tourOptions_, array3, null, resultListOptions, null, callerContext);
					val = (FXRETURN)0;
				}
				end_IL_0023:;
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

	protected void SetRoutingOptions(ref List<RoutingOption> RoutingOptionList)
	{
		RoutingOption routingOption = null;
		if (!Information.IsNothing((object)_Optimization))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.OPTIMIZATION;
			routingOption.value = _Optimization.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_TollRoads))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_TOLLROADS;
			routingOption.value = _Avoid_TollRoads.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_Highways))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_HIGHWAYS;
			routingOption.value = _Avoid_Highways.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_Ferries))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_FERRIES;
			routingOption.value = _Avoid_Ferries.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_Residents_Only))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_RESIDENTS_ONLY;
			routingOption.value = _Avoid_Residents_Only.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_Urban_Areas))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_URBAN_AREAS;
			routingOption.value = _Avoid_Urban_Areas.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_Ramps))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_RAMPS;
			routingOption.value = _Avoid_Ramps.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_VignetteRoads))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_VIGNETTEROADS;
			routingOption.value = _Avoid_VignetteRoads.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		if (!Information.IsNothing((object)_Avoid_Low_Emission_Zones))
		{
			routingOption = new RoutingOption();
			routingOption.parameter = RoutingParameter.AVOID_LOW_EMISSION_ZONES;
			routingOption.value = _Avoid_Low_Emission_Zones.Value.ToString();
			RoutingOptionList.Add(routingOption);
		}
		routingOption = new RoutingOption();
		routingOption.parameter = RoutingParameter.ROUTE_LANGUAGE;
		if (Operators.CompareString(_Route_Language, "", false) != 0)
		{
			routingOption.value = _Route_Language;
		}
		else
		{
			routingOption.value = "IT";
		}
		RoutingOptionList.Add(routingOption);
		if (!Information.IsNothing((object)_MaximumDistanceToSegment))
		{
			_MaximumDistanceToSegment = _MaximumDistanceToSegment;
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
			if (Operators.CompareString(TipoADR, "", false) != 0)
			{
				XmlSnippet += "<Load loadType=\"GOODS\" hazardousGoodsType=\"__TIPOADR\"/>";
			}
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

	protected FXRETURN ElaboraRisultato(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
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
				_OutArgs.TotalInfo = new Map_TotalInfo();
				_OutArgs.TotalInfo.DurataTotale = _tour.tourPeriod;
				_OutArgs.TotalInfo.KmTotali = decimal.Divide(new decimal(_tour.route.info.distance), 1000m);
				_OutArgs.TotalInfo.DurataGuida = 0;
				if (!Information.IsNothing((object)_tour.route.wrappedStations))
				{
					WayPoint[] wrappedStations = _tour.route.wrappedStations;
					foreach (WayPoint wayPoint in wrappedStations)
					{
						int accTime = wayPoint.accTime;
						decimal num3 = decimal.Divide(new decimal(wayPoint.accDist), 1000m);
						decimal num4 = default(decimal);
						decimal num5 = default(decimal);
						num4 = decimal.Subtract(num3, d);
						num5 = new decimal(accTime - num2);
						d = num3;
						num2 = accTime;
						DateTime dateTime = DateAndTime.DateAdd((DateInterval)9, (double)accTime, _DataPartenzaViaggio);
						DateTime dateTime2 = DateAndTime.DateAdd((DateInterval)9, (double)_GPSPointsIn[num].SecondiCaricoScarico, dateTime);
						dataPartenzaViaggio = dateTime2;
						_InArgs.GPSPoints[num].Km = num3;
						_InArgs.GPSPoints[num].DataArrivo = dateTime;
						_InArgs.GPSPoints[num].DataPartenza = dateTime2;
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
							if (Operators.CompareString(text, "DRIVING", false) != 0)
							{
								continue;
							}
							if (Information.IsNothing((object)_OutArgs.TotalInfo.DurataGuida))
							{
								_OutArgs.TotalInfo.DurataGuida = tourEvent.period;
								continue;
							}
							Map_TotalInfo totalInfo = _OutArgs.TotalInfo;
							int period = tourEvent.period;
							int? durataGuida = totalInfo.DurataGuida;
							int? durataGuida2;
							if (!durataGuida.HasValue)
							{
								durataGuida2 = null;
							}
							else
							{
								int? num6 = durataGuida.GetValueOrDefault() + period;
								durataGuida2 = num6;
							}
							totalInfo.DurataGuida = durataGuida2;
						}
					}
				}
				_OutArgs.GPSPoints = _InArgs.GPSPoints;
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
