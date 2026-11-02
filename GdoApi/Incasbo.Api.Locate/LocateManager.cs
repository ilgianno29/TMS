using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Incasbo.xLocate;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Locate;

public class LocateManager : AppAbstractApi
{
	protected class Ricerca
	{
		public int Id { get; set; }

		public int CifreDelCap { get; set; }

		public bool UsaLocalita { get; set; }

		public bool UsaIndirizzo { get; set; }

		public bool UsaNazione { get; set; }

		public int Peso { get; set; }

		public ResultAddress[] ResultAddress { get; set; }

		public Ricerca()
		{
			Peso = 0;
		}
	}

	private SearchOption[] SearchOption;

	private ResultField[] resultFieldAddress;

	private CallerContext xLocateCallerContext;

	private int sogliaPunteggio;

	public List<LocateLocation> LocationsList { get; set; }

	public int IdRicerca { get; set; }

	public string SEARCH_BINARY { get; set; }

	public string SEARCH_PHONETIC { get; set; }

	public string SEARCH_FUZZY { get; set; }

	public string STREET_RETURNALLHNR { get; set; }

	public string CITY_RETURNALLCITY2 { get; set; }

	public string MULTIWORDINDEX_ENABLE { get; set; }

	public string POSTCODE_AGGREGATE { get; set; }

	public string INTERSECTIONS_ENABLE { get; set; }

	public string ASTERISKMODE { get; set; }

	public string COUNTRY_CODETYPE { get; set; }

	public string STREET_HNRPOSITION { get; set; }

	public string SWAPANDSPLITMODE { get; set; }

	public string HNR_OFFSET { get; set; }

	public string RESULT_LANGUAGE { get; set; }

	public string MAX_RESULT { get; set; }

	public string SINGLE_FIELD_SEPARATORS { get; set; }

	public string ENGINE_ADDRESSSEARCH_ENABLE { get; set; }

	public string ENGINE_COMBINEDTRANSPORTSEARCH_ENABLE { get; set; }

	public string COORDINATE_FORMAT { get; set; }

	public string PROFILE { get; set; }

	public string RESPONSE_GEOMETRY { get; set; }

	public string ConfigId { get; set; }

	public LocateLocation objLocation { get; set; }

	public LocateManager(AppApiContext objApiContext)
		: base(objApiContext)
	{
		IdRicerca = 0;
		SEARCH_BINARY = "1";
		SEARCH_PHONETIC = "1";
		SEARCH_FUZZY = "0";
		STREET_RETURNALLHNR = "0";
		CITY_RETURNALLCITY2 = "1";
		MULTIWORDINDEX_ENABLE = "1";
		POSTCODE_AGGREGATE = "1";
		INTERSECTIONS_ENABLE = "0";
		ASTERISKMODE = "0";
		COUNTRY_CODETYPE = "2";
		STREET_HNRPOSITION = "0";
		SWAPANDSPLITMODE = "1";
		HNR_OFFSET = "";
		RESULT_LANGUAGE = "DEF";
		MAX_RESULT = "20";
		SINGLE_FIELD_SEPARATORS = "";
		ENGINE_ADDRESSSEARCH_ENABLE = "1";
		ENGINE_COMBINEDTRANSPORTSEARCH_ENABLE = "1";
		COORDINATE_FORMAT = "OG_GEODECIMAL";
		PROFILE = "default";
		RESPONSE_GEOMETRY = "PLAIN";
		ConfigId = "STD";
		objLocation = null;
	}

	protected FXRETURN FindAddressList(ref LocateLocation objLocation, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			this.CallStackAdd();
			LocationsList = new List<LocateLocation>();
			XLocateWSClient xLocateWSClient = new XLocateWSClient("XLocateWSPort");
			SetXLocateCallerContext();
			AddressResponse addressResponse = null;
			ResultAddress[] array = null;
			Address address = new Address();
			CreateResultFieldAddress();
			SetSearchOptions();
			string vsSQLClause = "SELECT * FROM GeocodificheRicerche";
			DataTable rObjDataTable = null;
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				List<Ricerca> list = new List<Ricerca>();
				foreach (DataRow row in rObjDataTable.Rows)
				{
					Ricerca ricerca = new Ricerca();
					ricerca.Id = Conversions.ToInteger(row["Id"]);
					ricerca.CifreDelCap = Conversions.ToInteger(row["CifreDelCap"]);
					ricerca.UsaIndirizzo = Operators.CompareString(row["UsaIndirizzo"].ToString(), "S", false) == 0;
					ricerca.UsaLocalita = Operators.CompareString(row["UsaLocalita"].ToString(), "S", false) == 0;
					ricerca.UsaNazione = Operators.CompareString(row["UsaNazione"].ToString(), "S", false) == 0;
					list.Add(ricerca);
				}
				foreach (Ricerca item in list)
				{
					if (item.UsaNazione)
					{
						address.country = objLocation.Nazione;
					}
					address.state = "";
					address.postCode = Strings.Left(objLocation.Cap, item.CifreDelCap);
					if (item.UsaLocalita)
					{
						address.city = objLocation.Localita;
						address.city2 = objLocation.Localita2;
					}
					if (item.UsaIndirizzo)
					{
						address.street = objLocation.Via;
						address.houseNumber = objLocation.Civico;
					}
					if (Operators.CompareString(address.country.Trim(), "", false) == 0)
					{
						address.country = "ITA";
					}
					addressResponse = xLocateWSClient.findAddress(address, SearchOption, null, resultFieldAddress, xLocateCallerContext);
					if (addressResponse.errorCode == 0)
					{
						item.ResultAddress = addressResponse.wrappedResultList;
						if (item.ResultAddress.Count() > 0)
						{
							item.Peso = item.ResultAddress[0].totalScore;
						}
						continue;
					}
					rsmess = addressResponse.errorDescription;
					goto end_IL_0005;
				}
				int num = 0;
				foreach (Ricerca item2 in list)
				{
					if (item2.Peso > num)
					{
						array = item2.ResultAddress;
						num = item2.Peso;
						IdRicerca = item2.Id;
					}
				}
				if (array != null)
				{
					ResultAddress[] array2 = array;
					foreach (ResultAddress resultAddress in array2)
					{
						LocateLocation locateLocation = new LocateLocation();
						locateLocation.Nome = objLocation.Nome;
						locateLocation.Via = resultAddress.street;
						locateLocation.Civico = resultAddress.houseNumber;
						locateLocation.Cap = resultAddress.postCode;
						locateLocation.Localita = resultAddress.city;
						locateLocation.Localita2 = resultAddress.city2;
						locateLocation.Nazione = resultAddress.country;
						locateLocation.Latitudine = Strings.Format((object)resultAddress.coordinates.point.y, "0.00000").Replace(",", ".");
						locateLocation.Longitudine = Strings.Format((object)resultAddress.coordinates.point.x, "0.00000").Replace(",", ".");
						locateLocation.PunteggioTotale = resultAddress.totalScore.ToString();
						AdditionalField[] wrappedAdditionalFields = resultAddress.wrappedAdditionalFields;
						foreach (AdditionalField additionalField in wrappedAdditionalFields)
						{
							switch (additionalField.field)
							{
							case ResultField.CLASSIFICATION:
								locateLocation.Classificazione = additionalField.value;
								break;
							case ResultField.CLASSIFICATION_DESCRIPTION:
								locateLocation.ClassificazioneDescrizione = additionalField.value;
								break;
							case ResultField.DETAILLEVEL:
								locateLocation.LivelloDettaglio = additionalField.value;
								break;
							case ResultField.DETAILLEVEL_DESCRIPTION:
								locateLocation.LivelloDettaglioDescrizione = additionalField.value;
								break;
							case ResultField.ADDRESS_CLASSIFICATION:
								locateLocation.ClassificazioneIndirizzo = additionalField.value;
								break;
							case ResultField.ADDRESS_CLASSIFICATION_DESCRIPTION:
								locateLocation.ClassificazioneIndirizzoDescrizione = additionalField.value;
								break;
							case ResultField.POSTCODE_CLASSIFICATION:
								locateLocation.ClassificazioneCAP = additionalField.value;
								break;
							case ResultField.TOWN_CLASSIFICATION:
								locateLocation.ClassificazioneLocalita = additionalField.value;
								break;
							case ResultField.STREET_CLASSIFICATION:
								locateLocation.ClassificazioneVia = additionalField.value;
								break;
							case ResultField.HOUSENR_CLASSIFICATION:
								locateLocation.ClassificazioneCivico = additionalField.value;
								break;
							}
						}
						LocationsList.Add(locateLocation);
					}
				}
				val = (FXRETURN)0;
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
			result = val;
			this.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN LoadConfig(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string vsSQLClause = "SELECT * FROM GeocodificheOpzioni WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(ConfigId);
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count > 0)
				{
					DataRow dataRow = rObjDataTable.Rows[0];
					COUNTRY_CODETYPE = dataRow["CountryCodeType"].ToString();
					SEARCH_BINARY = Interaction.IIf(Operators.CompareString(dataRow["SearchBinary"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					SEARCH_PHONETIC = Interaction.IIf(Operators.CompareString(dataRow["SearchPhonetic"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					SEARCH_FUZZY = Interaction.IIf(Operators.CompareString(dataRow["SearchFuzzy"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					SWAPANDSPLITMODE = dataRow["SwapAndSplitMode"].ToString();
					STREET_HNRPOSITION = dataRow["StreetHNRPosition"].ToString();
					STREET_RETURNALLHNR = Interaction.IIf(Operators.CompareString(dataRow["StreetReturnAllHNR"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					RESULT_LANGUAGE = dataRow["ResultLanguage"].ToString();
					CITY_RETURNALLCITY2 = Interaction.IIf(Operators.CompareString(dataRow["CityReturnAllCity2"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					MULTIWORDINDEX_ENABLE = Interaction.IIf(Operators.CompareString(dataRow["MultiWordIndexEnable"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					POSTCODE_AGGREGATE = Interaction.IIf(Operators.CompareString(dataRow["PostCodeAggregate"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					ASTERISKMODE = dataRow["AsteriskMode"].ToString();
					INTERSECTIONS_ENABLE = Interaction.IIf(Operators.CompareString(dataRow["IntersectionsEnable"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HnrOffset"])))
					{
						HNR_OFFSET = dataRow["HnrOffset"].ToString();
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["MaxResult"])))
					{
						MAX_RESULT = dataRow["MaxResult"].ToString();
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SingleFieldSeparators"])))
					{
						SINGLE_FIELD_SEPARATORS = dataRow["SingleFieldSeparators"].ToString();
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["EngineAddressSearchEnable"])))
					{
						ENGINE_ADDRESSSEARCH_ENABLE = Interaction.IIf(Operators.CompareString(dataRow["EngineAddressSearchEnable"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["EngineCombTransSearchEnable"])))
					{
						ENGINE_COMBINEDTRANSPORTSEARCH_ENABLE = Interaction.IIf(Operators.CompareString(dataRow["EngineCombTransSearchEnable"].ToString(), "S", false) == 0, (object)"1", (object)"0").ToString();
					}
					dataRow = null;
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

	private SearchOption BuildSearchOption(SearchParameter argParameter, string argValue)
	{
		SearchOption searchOption = new SearchOption();
		searchOption.param = argParameter;
		searchOption.value = argValue;
		return searchOption;
	}

	private void CreateResultFieldAddress()
	{
		resultFieldAddress = new ResultField[55]
		{
			ResultField.COUNTRY,
			ResultField.STATE,
			ResultField.ADMINREGION,
			ResultField.CITY,
			ResultField.CITY2,
			ResultField.POSTCODE,
			ResultField.STREET,
			ResultField.HOUSENR,
			ResultField.COORDX,
			ResultField.COORDY,
			ResultField.DETAILLEVEL,
			ResultField.DETAILLEVEL_DESCRIPTION,
			ResultField.COUNTRY,
			ResultField.EXTENSIONCLASS,
			ResultField.LEVEL,
			ResultField.ISCITYDISTRICT,
			ResultField.COUNTRY_ISO2,
			ResultField.COUNTRY_ISO3,
			ResultField.COUNTRY_COUNTRYCODEPLATE,
			ResultField.COUNTRY_DIALINGCODE,
			ResultField.COUNTRY_CAPITAL,
			ResultField.COUNTRY_NAME,
			ResultField.HOUSENR_SIDE,
			ResultField.HOUSENR_STRUCTURE,
			ResultField.HOUSENR_STARTFORMAT,
			ResultField.HOUSENR_ENDFORMAT,
			ResultField.APPENDIX,
			ResultField.SCORE_TOTALSCORE,
			ResultField.SCORE_FINALPENALTY,
			ResultField.FOUNDBY_CITY,
			ResultField.FOUNDBY_CITY2,
			ResultField.FOUNDBY_POSTCODE,
			ResultField.FOUNDBY_STREET,
			ResultField.CLASSIFICATION,
			ResultField.CLASSIFICATION_DESCRIPTION,
			ResultField.SWAPANDSPLITMODE,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.COUNTRY,
			ResultField.ADDRESS_CLASSIFICATION,
			ResultField.ADDRESS_CLASSIFICATION_DESCRIPTION,
			ResultField.POSTCODE_CLASSIFICATION,
			ResultField.TOWN_CLASSIFICATION,
			ResultField.STREET_CLASSIFICATION,
			ResultField.HOUSENR_CLASSIFICATION
		};
	}

	private void SetXLocateCallerContext()
	{
		xLocateCallerContext = new CallerContext();
		CallerContextProperty callerContextProperty = new CallerContextProperty();
		callerContextProperty.key = "ResponseGeometry";
		callerContextProperty.value = RESPONSE_GEOMETRY;
		CallerContextProperty callerContextProperty2 = new CallerContextProperty();
		callerContextProperty2.key = "CoordFormat";
		callerContextProperty2.value = COORDINATE_FORMAT;
		CallerContextProperty callerContextProperty3 = new CallerContextProperty();
		callerContextProperty3.key = "Profile";
		callerContextProperty3.value = PROFILE;
		xLocateCallerContext.wrappedProperties = new CallerContextProperty[3] { callerContextProperty2, callerContextProperty3, callerContextProperty };
	}

	private void SetSearchOptions()
	{
		List<SearchOption> list = new List<SearchOption>();
		list.Add(BuildSearchOption(SearchParameter.SEARCH_BINARY, SEARCH_BINARY));
		list.Add(BuildSearchOption(SearchParameter.SEARCH_PHONETIC, SEARCH_PHONETIC));
		list.Add(BuildSearchOption(SearchParameter.SEARCH_FUZZY, SEARCH_FUZZY));
		list.Add(BuildSearchOption(SearchParameter.STREET_RETURNALLHNR, STREET_RETURNALLHNR));
		list.Add(BuildSearchOption(SearchParameter.CITY_RETURNALLCITY2, CITY_RETURNALLCITY2));
		list.Add(BuildSearchOption(SearchParameter.MULTIWORDINDEX_ENABLE, MULTIWORDINDEX_ENABLE));
		list.Add(BuildSearchOption(SearchParameter.POSTCODE_AGGREGATE, POSTCODE_AGGREGATE));
		list.Add(BuildSearchOption(SearchParameter.INTERSECTIONS_ENABLE, INTERSECTIONS_ENABLE));
		list.Add(BuildSearchOption(SearchParameter.ASTERISKMODE, ASTERISKMODE));
		list.Add(BuildSearchOption(SearchParameter.COUNTRY_CODETYPE, COUNTRY_CODETYPE));
		list.Add(BuildSearchOption(SearchParameter.STREET_HNRPOSITION, STREET_HNRPOSITION));
		list.Add(BuildSearchOption(SearchParameter.SWAPANDSPLITMODE, SWAPANDSPLITMODE));
		list.Add(BuildSearchOption(SearchParameter.HNR_OFFSET, HNR_OFFSET));
		list.Add(BuildSearchOption(SearchParameter.SINGLE_FIELD_SEPARATORS, SINGLE_FIELD_SEPARATORS));
		list.Add(BuildSearchOption(SearchParameter.ENGINE_ADDRESSSEARCH_ENABLE, ENGINE_ADDRESSSEARCH_ENABLE));
		list.Add(BuildSearchOption(SearchParameter.ENGINE_COMBINEDTRANSPORTSEARCH_ENABLE, ENGINE_COMBINEDTRANSPORTSEARCH_ENABLE));
		list.Add(BuildSearchOption(SearchParameter.RESULT_LANGUAGE, RESULT_LANGUAGE));
		list.Add(BuildSearchOption(SearchParameter.MAX_RESULT, MAX_RESULT));
		SearchOption = list.ToArray();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = LoadConfig(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			LocateLocation locateLocation = objLocation;
			FXRETURN val3 = FindAddressList(ref locateLocation, ref rsmess);
			objLocation = locateLocation;
			val = val3;
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
