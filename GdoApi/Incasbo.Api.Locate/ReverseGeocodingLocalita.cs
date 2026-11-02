using System;
using System.Collections.Generic;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Locate;

public class ReverseGeocodingLocalita : AppAbstractApi
{
	protected string _Latitudine;

	protected string _Longitudine;

	public ReverseGeocodingLocalita(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Latitudine = "";
		_Longitudine = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (base._ParametersIn.ContainsKey("Latitudine"))
			{
				_Latitudine = base._ParametersIn["Latitudine"].ToString();
			}
			if (Operators.CompareString(_Latitudine, "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Latitudine non impostata");
			}
			else
			{
				if (base._ParametersIn.ContainsKey("Longitudine"))
				{
					_Longitudine = base._ParametersIn["Longitudine"].ToString();
				}
				if (Operators.CompareString(_Longitudine, "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Longitudine non impostata");
				}
				else
				{
					_Latitudine = _Latitudine.Replace(',', '.');
					_Longitudine = _Longitudine.Replace(',', '.');
					base._ParametersOut.Add("Location", null);
					val2 = (FXRETURN)0;
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
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ReverseGeocodingManager reverseGeocodingManager = new ReverseGeocodingManager(this._ApiContext);
			reverseGeocodingManager.Latitude = _Latitudine;
			reverseGeocodingManager.Longitude = _Longitudine;
			val = ((AppAbstractApi)reverseGeocodingManager).Run(ref rsmess);
			LocateLocation locateLocation;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				List<LocateLocation> locationsList = reverseGeocodingManager.LocationsList;
				if (locationsList.Count <= 0)
				{
					goto IL_012c;
				}
				locateLocation = locationsList[0];
				if (Operators.CompareString(locateLocation.Cap, "", false) == 0)
				{
					goto IL_0117;
				}
				text = "SELECT TOP(1) PROVINCIA FROM LOCALITA WHERE CAP = " + ((AppBaseClass)this).DbConn.SQLFormatString(locateLocation.Cap) + " ";
				text = text + "OR CAP LIKE '" + locateLocation.Cap.Substring(0, 3) + "%' ";
				val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
				if ((int)val <= 0)
				{
					locateLocation.Provincia = Conversions.ToString(objRes);
					goto IL_0117;
				}
				val2 = val;
			}
			goto end_IL_000e;
			IL_012c:
			val2 = (FXRETURN)0;
			goto end_IL_000e;
			IL_0117:
			base._ParametersOut["Location"] = locateLocation;
			goto IL_012c;
			end_IL_000e:;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Latitudine, string Longitudine, ref LocateLocation Location, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		ReverseGeocodingLocalita reverseGeocodingLocalita = new ReverseGeocodingLocalita(objApiContext);
		((AppAbstractApi)reverseGeocodingLocalita).ParametersIn.Add("Latitudine", Latitudine);
		((AppAbstractApi)reverseGeocodingLocalita).ParametersIn.Add("Longitudine", Longitudine);
		val = ((AppAbstractApi)reverseGeocodingLocalita).Run(ref rsmess);
		Location = (LocateLocation)((AppAbstractApi)reverseGeocodingLocalita).ParametersOut["Location"];
		return val;
	}
}
