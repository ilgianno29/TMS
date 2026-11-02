using System;
using System.IO;
using System.ServiceModel;
using Incasbo.Web.Library;
using Incasbo.Web.WSCWCF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

[ServiceBehavior(/*Could not decode attribute arguments.*/)]
public class TMSServiceForMap : IncasWCFStandardAuth, ITMSServiceForMap
{
	public TMSServiceForMap()
	{
		_WSDBConfigFile = "WCFDBConfig_TMSServiceForMap.ini";
		_WSAppConfigFile = "WSCWCFConfig_TMSServiceForMap.ini";
	}

	public override string GetVersion()
	{
		return base.GetVersion();
	}

	string ITMSServiceForMap.GetVersion()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetVersion
		return this.GetVersion();
	}

	public override bool TestDBConnection(ref string rsMess)
	{
		return base.TestDBConnection(ref rsMess);
	}

	bool ITMSServiceForMap.TestDBConnection(ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestDBConnection
		return this.TestDBConnection(ref rsMess);
	}

	public override string TestPing(string sStringa)
	{
		return base.TestPing(sStringa);
	}

	string ITMSServiceForMap.TestPing(string sStringa)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestPing
		return this.TestPing(sStringa);
	}

	public Result CalcoloKmETempi(Sender sender, CalcoloKmETempiArgsIn InArg, ref CalcoloKmETempiArgsOut OutArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string rsmess2 = "";
				LogEventiMem("CALCOLO KM E TEMPI", "", "", ref rsmess2);
				val2 = ReadConfigIniFile(ref InArg, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote = rsmess;
					rsmess2 = "";
					LogEventiMem("CALCOLO KM E TEMPI", "", sNote, ref rsmess2);
					val = val2;
				}
				else
				{
					val2 = _CalcoloKmETempi(InArg, ref OutArg, ref rsmess);
					if ((int)val2 != 0)
					{
						string sNote2 = rsmess;
						rsmess2 = "";
						LogEventiMem("CALCOLO KM E TEMPI", "", sNote2, ref rsmess2);
						val = val2;
					}
					else
					{
						val = (FXRETURN)0;
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSServiceForMap.CalcoloKmETempi(Sender sender, CalcoloKmETempiArgsIn InArg, ref CalcoloKmETempiArgsOut OutArg)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalcoloKmETempi
		return this.CalcoloKmETempi(sender, InArg, ref OutArg);
	}

	public Result CalcoloOttimizzatoKmETempi_DEPOT(Sender sender, CalcoloOttimizzatoKmETempiArgsIn InArg, ref CalcoloOttimizzatoKmETempiArgsOut OutArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string rsmess2 = "";
				LogEventiMem("CALCOLO KM E TEMPI OTTIMIZZATO (VERSIONE DEPOT)", "", "", ref rsmess2);
				val2 = _CalcoloOttmizzatoKmETempi(InArg, ref OutArg, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote = rsmess;
					rsmess2 = "";
					LogEventiMem("CALCOLO KM E TEMPI", "", sNote, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSServiceForMap.CalcoloOttimizzatoKmETempi_DEPOT(Sender sender, CalcoloOttimizzatoKmETempiArgsIn InArg, ref CalcoloOttimizzatoKmETempiArgsOut OutArg)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalcoloOttimizzatoKmETempi_DEPOT
		return this.CalcoloOttimizzatoKmETempi_DEPOT(sender, InArg, ref OutArg);
	}

	protected FXRETURN _CalcoloKmETempi(CalcoloKmETempiArgsIn InArg, ref CalcoloKmETempiArgsOut OutArg, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val2 = GdoWsc_CalcoloKmETempi.RunProc(CreateApiContext(), InArg, ref OutArg, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _CalcoloOttmizzatoKmETempi(CalcoloOttimizzatoKmETempiArgsIn InArg, ref CalcoloOttimizzatoKmETempiArgsOut OutArg, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val2 = GdoWsc_CalcoloOttimizzatoKmETempi_DEPOT.RunProc(CreateApiContext(), InArg, ref OutArg, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ReadConfigIniFile(ref CalcoloKmETempiArgsIn InArg, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			string text = "";
			string text2 = WSApplicationIniConfigDir + _WSAppConfigFile;
			if (Information.IsNothing((object)InArg.RoutingOptions))
			{
				InArg.RoutingOptions = new Map_RoutingOptions();
			}
			if (File.Exists(text2))
			{
				IniFile val3 = new IniFile();
				val3.Load(text2, false);
				if (Information.IsNothing((object)InArg.RoutingOptions.Optimization))
				{
					text = val3.GetKeyValue("RoutingOptions", "Optimization");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Optimization = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_TollRoads))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_TollRoads");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_TollRoads = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_Highways))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_Highways");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_Highways = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_Ferries))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_Ferries");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_Ferries = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_Residents_Only))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_Residents_Only");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_Residents_Only = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_Urban_Areas))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_Urban_Areas");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_Urban_Areas = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_Ramps))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_Ramps");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_Ramps = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_VignetteRoads))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_VignetteRoads");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_VignetteRoads = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.Avoid_Low_Emission_Zones))
				{
					text = val3.GetKeyValue("RoutingOptions", "Avoid_Low_Emission_Zones");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.Avoid_Low_Emission_Zones = Conversions.ToInteger(text.Trim());
					}
				}
				if (Operators.CompareString(InArg.RoutingOptions.Route_Language, "", false) == 0)
				{
					text = val3.GetKeyValue("RoutingOptions", "Route_Language");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
					{
						InArg.RoutingOptions.Route_Language = text.Trim();
					}
				}
				if (Operators.CompareString(InArg.RoutingOptions.Speed_Profile, "", false) == 0)
				{
					text = val3.GetKeyValue("RoutingOptions", "Speed_Profile");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
					{
						InArg.RoutingOptions.Speed_Profile = text.Trim();
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.TempoCaricoScarico))
				{
					text = val3.GetKeyValue("RoutingOptions", "TempoCaricoScarico");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.TempoCaricoScarico = Conversions.ToInteger(text.Trim());
					}
				}
				if (Information.IsNothing((object)InArg.RoutingOptions.MaximumDistanceToSegment))
				{
					text = val3.GetKeyValue("RoutingOptions", "MaximumDistanceToSegment");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
					{
						InArg.RoutingOptions.MaximumDistanceToSegment = Conversions.ToInteger(text.Trim());
					}
				}
				val2 = (FXRETURN)0;
			}
			else
			{
				rsmess = TranslateMessage("XXX", "Manca il file di configurazione " + text2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}
}
