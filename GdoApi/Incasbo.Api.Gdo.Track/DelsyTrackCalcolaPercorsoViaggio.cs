using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Model.Map;
using Incasbo.Web.Library;
using Incasbo.xRoute;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class DelsyTrackCalcolaPercorsoViaggio : AppAbstractApi
{
	protected XRouteWSClient _inXRouteWS;

	protected Incasbo.Model.Map.Viaggio _inViaggio;

	protected string _Tipologia;

	protected bool _inCheckTruckAttributes;

	protected bool _inCheckEnableRoadEditor;

	public DelsyTrackCalcolaPercorsoViaggio(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Tipologia = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["inXRouteWS"])))
			{
				rsmess = this.TranslateMessage("XXX", "Obbligatorio passare il riferimento al Web Service");
			}
			else
			{
				_inXRouteWS = (XRouteWSClient)((AppAbstractApi)this).ParametersIn["inXRouteWS"];
				if (Information.IsNothing(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["inViaggio"])))
				{
					rsmess = this.TranslateMessage("XXX", "Obbligatorio inserire il viaggio");
				}
				else
				{
					_inViaggio = (Incasbo.Model.Map.Viaggio)((AppAbstractApi)this).ParametersIn["inViaggio"];
					if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["Tipologia"].ToString(), "", false) == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Obbligatorio specificare il tipo di viaggio (reale\\pianificato)");
					}
					else
					{
						_Tipologia = ((AppAbstractApi)this).ParametersIn["Tipologia"].ToString();
						if (Information.IsNothing(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["inCheckTruckAttributes"])))
						{
							_inCheckTruckAttributes = false;
						}
						_inCheckTruckAttributes = (bool)((AppAbstractApi)this).ParametersIn["inCheckTruckAttributes"];
						if (Information.IsNothing(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["inCheckEnableRoadEditor"])))
						{
							_inCheckEnableRoadEditor = true;
						}
						_inCheckEnableRoadEditor = (bool)((AppAbstractApi)this).ParametersIn["inCheckEnableRoadEditor"];
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Tipologia, "R", false) == 0)
			{
				if (!Information.IsNothing((object)_inViaggio.PuntiPercorsoReale))
				{
					goto IL_012a;
				}
				List<PuntoSuMappa> punti = _inViaggio.Punti;
				string iD = _inViaggio.ID;
				bool inCheckTruckAttributes = _inCheckTruckAttributes;
				bool inCheckEnableRoadEditor = _inCheckEnableRoadEditor;
				Incasbo.Model.Map.Viaggio inViaggio;
				List<Punto> ElencoPuntiPercorso = (inViaggio = _inViaggio).PuntiPercorsoReale;
				FXRETURN val3 = GeneraPercorso(punti, iD, inCheckTruckAttributes, inCheckEnableRoadEditor, ref ElencoPuntiPercorso, ref rsmess);
				inViaggio.PuntiPercorsoReale = ElencoPuntiPercorso;
				val = val3;
				if ((int)val <= 0)
				{
					goto IL_012a;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_Tipologia, "P", false) != 0 || !Information.IsNothing((object)_inViaggio.PuntiPercorsoPianificato))
				{
					goto IL_012a;
				}
				List<PuntoSuMappa> puntiPianificati = _inViaggio.PuntiPianificati;
				string iD2 = _inViaggio.ID;
				bool inCheckTruckAttributes2 = _inCheckTruckAttributes;
				bool inCheckEnableRoadEditor2 = _inCheckEnableRoadEditor;
				Incasbo.Model.Map.Viaggio inViaggio;
				List<Punto> ElencoPuntiPercorso = (inViaggio = _inViaggio).PuntiPercorsoPianificato;
				FXRETURN val4 = GeneraPercorso(puntiPianificati, iD2, inCheckTruckAttributes2, inCheckEnableRoadEditor2, ref ElencoPuntiPercorso, ref rsmess);
				inViaggio.PuntiPercorsoPianificato = ElencoPuntiPercorso;
				val = val4;
				if ((int)val <= 0)
				{
					goto IL_012a;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_012a:
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

	private FXRETURN _GeneraPercorso(List<PuntoSuMappa> ElencoPuntiViaggio, string IdViaggio, bool CheckTruckAttributes, bool EnableRoadEditor, ref List<Punto> ElencoPuntiPercorso, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Invalid comparison between Unknown and I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		WaypointDesc waypointDesc = null;
		int num = 0;
		Punto punto = null;
		checked
		{
			FXRETURN result;
			try
			{
				this.CallStackAdd();
				rsMess = "";
				WaypointDesc[] array = new WaypointDesc[ElencoPuntiViaggio.Count - 1 + 1];
				foreach (PuntoSuMappa item in ElencoPuntiViaggio)
				{
					waypointDesc = null;
					waypointDesc = new WaypointDesc();
					waypointDesc.wrappedCoords = new Point[1]
					{
						new Point()
					};
					waypointDesc.wrappedCoords[0].point = new PlainPoint();
					waypointDesc.wrappedCoords[0].point.x = Convert.ToDouble(item.Longitudine);
					waypointDesc.wrappedCoords[0].point.y = Convert.ToDouble(item.Latitudine);
					waypointDesc.linkType = LinkType.AUTO_LINKING;
					array[num] = waypointDesc;
					num++;
				}
				ResultListOptions resultListOptions = new ResultListOptions();
				resultListOptions.polygon = true;
				resultListOptions.totalRectangle = true;
				string text = "";
				text = "SELECT X.Mezzo Contenitore, X.CodiceTipoMezzo TipoMezzoContenitore, X.Larghezza LarghezzaContenitore, X.Lunghezza LunghezzaContenitore, X.Altezza AltezzaContenitore, X.Tara TaraContenitore, X.PortataPeso PortataPesoContenitore, ";
				text += "X.Trattore, M1.TipoMezzo TipoMezzoTrattore, %LARGHEZZA1% LarghezzaTrattore, %LUNGHEZZA1% LunghezzaTrattore, %ALTEZZA1% AltezzaTrattore, ISNULL(M1.Tara, 0) TaraTrattore, %PORTATAPESO1% PortataPesoTrattore, ";
				text += "X.Semirimorchio, M2.TipoMezzo TipoMezzoSemirimorchio, %LARGHEZZA2% LarghezzaSemirimorchio, %LUNGHEZZA2% LunghezzaSemirimorchio, %ALTEZZA2% AltezzaSemirimorchio, ISNULL(M2.Tara, 0) TaraSemirimorchio, %PORTATAPESO2% PortataPesoSemirimorchio, ";
				text += "X.SuffissoFile, T.ADR ";
				text += "FROM VW_VIAGGIO_MEZZI_TA X ";
				text += "INNER JOIN TipiMerce T ON X.TipoMerce=T.Codice ";
				text += "LEFT JOIN VW_MEZZI_TA M1 ON X.Trattore=M1.Codice ";
				text += "INNER JOIN TipiMezzo TM1 ON M1.TipoMezzo=TM1.Codice ";
				text += "LEFT JOIN VW_MEZZI_TA M2 ON X.Semirimorchio=M2.Codice ";
				text += "LEFT JOIN TipiMezzo TM2 ON M2.TipoMezzo=TM2.Codice ";
				text = text + "WHERE X.IDVIAGGIO=" + ((AppBaseClass)this).DbConn.SQLFormatString(IdViaggio);
				if (((AppBaseClass)this).DbConn.ServerType == DBFormatFunctions.eServerType.SQL)
				{
					text = text.Replace("%LARGHEZZA1%", "ISNULL(M1.Larghezza, TM1.Larghezza)");
					text = text.Replace("%LUNGHEZZA1%", "ISNULL(M1.Lunghezza, TM1.Lunghezza)");
					text = text.Replace("%ALTEZZA1%", "ISNULL(M1.Altezza, TM1.Altezza)");
					text = text.Replace("%PORTATAPESO1%", "ISNULL(M1.PortataPeso, TM1.PortataPeso)");
					text = text.Replace("%LARGHEZZA2%", "ISNULL(M2.Larghezza, TM2.Larghezza)");
					text = text.Replace("%LUNGHEZZA2%", "ISNULL(M2.Lunghezza, TM2.Lunghezza)");
					text = text.Replace("%ALTEZZA2%", "ISNULL(M2.Altezza, TM2.Altezza)");
					text = text.Replace("%PORTATAPESO2%", "ISNULL(M2.PortataPeso, TM2.PortataPeso)");
				}
				else if (((AppBaseClass)this).DbConn.ServerType == DBFormatFunctions.eServerType.Oracle)
				{
					text = text.Replace("%LARGHEZZA1%", "NVL(M1.Larghezza, TM1.Larghezza)");
					text = text.Replace("%LUNGHEZZA1%", "NVL(M1.Lunghezza, TM1.Lunghezza)");
					text = text.Replace("%ALTEZZA1%", "NVL(M1.Altezza, TM1.Altezza)");
					text = text.Replace("%PORTATAPESO1%", "NVL(M1.PortataPeso, TM1.PortataPeso)");
					text = text.Replace("%LARGHEZZA2%", "NVL(M2.Larghezza, TM2.Larghezza)");
					text = text.Replace("%LUNGHEZZA2%", "NVL(M2.Lunghezza, TM2.Lunghezza)");
					text = text.Replace("%ALTEZZA2%", "NVL(M2.Altezza, TM2.Altezza)");
					text = text.Replace("%PORTATAPESO2%", "NVL(M2.PortataPeso, TM2.PortataPeso)");
				}
				DataTable rObjDataTable = new DataTable();
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if (unchecked((int)val) > 0)
				{
					val2 = val;
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
					int tara = 0;
					int portataPeso = 0;
					string value = rObjDataTable.Rows[0]["SuffissoFile"].ToString();
					string tipoADR = ((Operators.CompareString(rObjDataTable.Rows[0]["ADR"].ToString(), "", false) == 0) ? "NONE" : rObjDataTable.Rows[0]["ADR"].ToString());
					string text2 = rObjDataTable.Rows[0]["Contenitore"].ToString();
					decimal val3 = Conversions.ToDecimal(rObjDataTable.Rows[0]["LarghezzaContenitore"]);
					decimal num2 = Conversions.ToDecimal(rObjDataTable.Rows[0]["LunghezzaContenitore"]);
					decimal num3 = Conversions.ToDecimal(rObjDataTable.Rows[0]["AltezzaContenitore"]);
					int num4 = Conversions.ToInteger(rObjDataTable.Rows[0]["TaraContenitore"]);
					int num5 = Conversions.ToInteger(rObjDataTable.Rows[0]["PortataPesoContenitore"]);
					string text3 = rObjDataTable.Rows[0]["Trattore"].ToString();
					decimal num6 = Conversions.ToDecimal(rObjDataTable.Rows[0]["LarghezzaTrattore"]);
					decimal num7 = Conversions.ToDecimal(rObjDataTable.Rows[0]["LunghezzaTrattore"]);
					decimal num8 = Conversions.ToDecimal(rObjDataTable.Rows[0]["AltezzaTrattore"]);
					int num9 = Conversions.ToInteger(rObjDataTable.Rows[0]["TaraTrattore"]);
					int num10 = Conversions.ToInteger(rObjDataTable.Rows[0]["PortataPesoTrattore"]);
					string text4 = rObjDataTable.Rows[0]["Semirimorchio"].ToString();
					decimal val4 = ((Operators.CompareString(rObjDataTable.Rows[0]["LarghezzaSemirimorchio"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LarghezzaSemirimorchio"]));
					decimal d4 = ((Operators.CompareString(rObjDataTable.Rows[0]["LunghezzaSemirimorchio"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["LunghezzaSemirimorchio"]));
					decimal num11 = ((Operators.CompareString(rObjDataTable.Rows[0]["AltezzaSemirimorchio"].ToString(), "", false) == 0) ? 0m : Conversions.ToDecimal(rObjDataTable.Rows[0]["AltezzaSemirimorchio"]));
					int num12 = ((Operators.CompareString(rObjDataTable.Rows[0]["TaraSemirimorchio"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["TaraSemirimorchio"]) : 0);
					int num13 = ((Operators.CompareString(rObjDataTable.Rows[0]["PortataPesoSemirimorchio"].ToString(), "", false) != 0) ? Conversions.ToInteger(rObjDataTable.Rows[0]["PortataPesoSemirimorchio"]) : 0);
					if ((Operators.CompareString(text2, text3, false) == 0) & (Operators.CompareString(text4, "", false) == 0))
					{
						d = num6;
						d2 = num7;
						d3 = num8;
						tara = num9;
						portataPeso = num10;
					}
					else if ((Operators.CompareString(text2, text4, false) == 0) & (Operators.CompareString(text3, text4, false) != 0))
					{
						d = Math.Max(num6, val4);
						d2 = decimal.Add(num7, d4);
						d3 = Math.Max(num8, num11);
						portataPeso = num5;
						portataPeso = num10 + num13;
					}
					else if ((Operators.CompareString(text2, text3, false) != 0) & (Operators.CompareString(text3, text4, false) != 0) & (Operators.CompareString(text3, text2, false) != 0))
					{
						d = Math.Max(Math.Max(num6, val4), val3);
						d2 = decimal.Add(num7, d4);
						d3 = Math.Max(num8, decimal.Add(num11, num3));
						tara = num9 + num12 + num4;
						portataPeso = num5;
					}
					else if ((Operators.CompareString(text3, text4, false) == 0) & (Operators.CompareString(text3, text2, false) != 0))
					{
						d = Math.Max(num6, val3);
						d2 = num7;
						d3 = Math.Max(num8, num3);
						tara = num9 + num4;
						portataPeso = num5;
					}
					ApplicationDefault applicationDefault = (ApplicationDefault)(object)this._ApiContext.AppDefault;
					int num14 = ((!CheckTruckAttributes) ? 1 : 2);
					CallerContext callerContext = new CallerContext();
					callerContext.wrappedProperties = new CallerContextProperty[num14 + 1];
					callerContext.wrappedProperties[0] = new CallerContextProperty();
					callerContext.wrappedProperties[0].key = "CoordFormat";
					callerContext.wrappedProperties[0].value = applicationDefault.XServerCoordFormatDefault();
					callerContext.wrappedProperties[1] = new CallerContextProperty();
					callerContext.wrappedProperties[1].key = "Profile";
					callerContext.wrappedProperties[1].value = value;
					RoutingOption[] array2 = new RoutingOption[0];
					RoutingOption routingOption = new RoutingOption();
					routingOption.parameter = RoutingParameter.ROUTE_LANGUAGE;
					routingOption.value = "IT";
					RoutingOption routingOption2 = new RoutingOption();
					routingOption2.parameter = RoutingParameter.AVOID_FERRIES;
					routingOption2.value = "2500";
					RoutingOption routingOption3 = new RoutingOption();
					routingOption3.parameter = RoutingParameter.ALLOW_SEGMENT_VIOLATIONS;
					routingOption3.value = "true";
					RoutingOption routingOption4 = new RoutingOption();
					routingOption4.parameter = RoutingParameter.COST_OF_SEGMENT_VIOLATIONS;
					routingOption4.value = "100";
					Array.Resize(ref array2, 4);
					array2 = new RoutingOption[4] { routingOption, routingOption2, routingOption3, routingOption4 };
					if (CheckTruckAttributes)
					{
						string XmlSnippet = "";
						TruckAttributes(Convert.ToInt32(decimal.Multiply(d, 100m)), Convert.ToInt32(decimal.Multiply(d2, 100m)), Convert.ToInt32(decimal.Multiply(d3, 100m)), tara, portataPeso, tipoADR, EnableRoadEditor, ref XmlSnippet);
						callerContext.wrappedProperties[2] = new CallerContextProperty();
						callerContext.wrappedProperties[2].key = "ProfileXMLSnippet";
						callerContext.wrappedProperties[2].value = XmlSnippet;
					}
					ExceptionPath[] arrayOfExceptionPath_ = new ExceptionPath[0];
					XRouteWSClient xRouteWSClient = new XRouteWSClient();
					Route route = xRouteWSClient.calculateRoute(array, array2, arrayOfExceptionPath_, resultListOptions, callerContext);
					if (!Information.IsNothing((object)route.polygon))
					{
						if (Information.IsNothing((object)ElencoPuntiPercorso))
						{
							ElencoPuntiPercorso = new List<Punto>();
						}
						PlainPoint[] wrappedPoints = route.polygon.lineString.wrappedPoints;
						foreach (PlainPoint plainPoint in wrappedPoints)
						{
							punto = new Punto(Convert.ToDecimal(plainPoint.x), Convert.ToDecimal(plainPoint.y));
							ElencoPuntiPercorso.Add(punto);
						}
						goto IL_0aef;
					}
					if (route.info.distance != 0)
					{
						goto IL_0aef;
					}
					rsMess = this.TranslateMessage("XXX", "Distanza totale viaggio pari a 0. Impossibile calcolare il percorso.");
				}
				goto end_IL_000d;
				IL_0aef:
				val2 = (FXRETURN)0;
				end_IL_000d:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val2 = this.HandleError(ref ex2, ref rsMess);
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

	private FXRETURN GeneraPercorso(List<PuntoSuMappa> ElencoPuntiViaggio, string IdViaggio, bool CheckTruckAttributes, bool EnableRoadEditor, ref List<Punto> ElencoPuntiPercorso, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "concerning leg".ToUpper();
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			val = _GeneraPercorso(ElencoPuntiViaggio, IdViaggio, CheckTruckAttributes, EnableRoadEditor, ref ElencoPuntiPercorso, ref rsMess);
			if ((int)val > 0)
			{
				checked
				{
					if (rsMess.ToUpper().Contains("Cannot calculate route".ToUpper()) & rsMess.ToUpper().Contains(text))
					{
						string text2 = Strings.Mid(rsMess, rsMess.ToUpper().IndexOf(text) + Strings.Len(text) + 1);
						text2 = text2.Replace(")", "").Replace(" ", "");
						string text3 = "";
						string text4 = "";
						text4 = ElencoPuntiViaggio[Conversions.ToInteger(text2)].Descrizione;
						text3 = text4;
						if (Conversions.ToInteger(text2) > 0)
						{
							text3 = ElencoPuntiViaggio[Conversions.ToInteger(text2) - 1].Descrizione;
						}
						rsMess = this.TranslateMessage("XXX", "Impossibile calcolare il percorso del viaggio a causa della tratta compresa tra <i>{0}</i> e <i><u>{1}</u></i>", new string[2] { text3, text4 });
					}
					val2 = val;
				}
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
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	private void TruckAttributes(int Larghezza, int Lunghezza, int Altezza, int Tara, int PortataPeso, string TipoADR, bool EnableRoadEditor, ref string XmlSnippet)
	{
		XmlSnippet = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>";
		XmlSnippet += "<Profile>";
		XmlSnippet += "<Routing majorVersion=\"2\" minorVersion=\"0\">";
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
	}

	private void TruckAttributesRoutingOptions(int Larghezza, int Lunghezza, int Altezza, int Tara, int PortataPeso, string TipoADR, ref RoutingOption[] xRoutingOption)
	{
		List<RoutingOption> list = new List<RoutingOption>();
		RoutingOption routingOption = new RoutingOption();
		routingOption.parameter = RoutingParameter.ENABLE_ROADEDITOR;
		routingOption.value = "true";
		list.Add(routingOption);
		RoutingOption routingOption2 = new RoutingOption();
		routingOption2.parameter = RoutingParameter.ROADEDITOR_LAYERNAME;
		routingOption2.value = "Truckattributes";
		list.Add(routingOption2);
		RoutingOption routingOption3 = new RoutingOption();
		if (Operators.CompareString(TipoADR, "NONE", false) != 0)
		{
			routingOption3.parameter = RoutingParameter.ROADEDITOR_ADDITIONAL_OPTIONS;
			switch (TipoADR)
			{
			case "HAZARDOUS":
				routingOption3.value = "HAZARDOUS_GOODS=1";
				break;
			case "HAZARDOUS_TO_WATER":
				routingOption3.value = "HAZARDOUS_TO_WATERS=1";
				break;
			case "COMBUSTIBLES":
				routingOption3.value = "COMBUSTIBLES=1";
				break;
			case "COMBUSTIBLES_ HAZARDOUS_TO_WATER":
				routingOption3.value = "COMBUSTIBLES=1";
				break;
			}
			list.Add(routingOption3);
		}
		RoutingOption routingOption4 = new RoutingOption();
		if (Tara > 0 || PortataPeso > 0)
		{
			routingOption4.parameter = RoutingParameter.ROADEDITOR_ADDITIONAL_OPTIONS;
			routingOption4.value = "MAX_WEIGHT=" + checked(Tara + PortataPeso);
			list.Add(routingOption4);
		}
		RoutingOption routingOption5 = new RoutingOption();
		if (Larghezza > 0)
		{
			routingOption5.parameter = RoutingParameter.ROADEDITOR_ADDITIONAL_OPTIONS;
			routingOption5.value = "MAX_WIDTH=" + Larghezza;
			list.Add(routingOption5);
		}
		RoutingOption routingOption6 = new RoutingOption();
		if (Lunghezza > 0)
		{
			routingOption6.parameter = RoutingParameter.ROADEDITOR_ADDITIONAL_OPTIONS;
			routingOption6.value = "MAX_LENGTH=" + Lunghezza;
			list.Add(routingOption6);
		}
		RoutingOption routingOption7 = new RoutingOption();
		if (Altezza > 0)
		{
			routingOption7.parameter = RoutingParameter.ROADEDITOR_ADDITIONAL_OPTIONS;
			routingOption7.value = "MAX_HEIGHT=" + Altezza;
			list.Add(routingOption7);
		}
		xRoutingOption = list.ToArray();
	}
}
