using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class ContrassegniAgganciaTariffa_Invoker : Api_Invoker
{
	protected static ContrassegniAgganciaTariffa_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static ContrassegniAgganciaTariffa_Invoker Instance
	{
		get
		{
			object @lock = _lock;
			ObjectFlowControl.CheckForSyncLockOnValueType(@lock);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(@lock, ref lockTaken);
				if (_instance == null)
				{
					_instance = new ContrassegniAgganciaTariffa_Invoker();
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(@lock);
				}
			}
			return _instance;
		}
	}

	protected ContrassegniAgganciaTariffa_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, StringCollection ListOfIdContrassegni, bool TariffaAttiva, bool TariffaPassiva, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			ContrassegniAgganciaTariffa contrassegniAgganciaTariffa = (ContrassegniAgganciaTariffa)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)contrassegniAgganciaTariffa).ParametersIn.Add("ListOfIdContrassegni", ListOfIdContrassegni);
			((AppAbstractApi)contrassegniAgganciaTariffa).ParametersIn.Add("TariffaAttiva", TariffaAttiva);
			((AppAbstractApi)contrassegniAgganciaTariffa).ParametersIn.Add("TariffaPassiva", TariffaPassiva);
			val = ((AppAbstractApi)contrassegniAgganciaTariffa).Run(ref rsmess);
			if (((AppAbstractApi)contrassegniAgganciaTariffa).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)contrassegniAgganciaTariffa).ParametersOut["_Warning"].ToString();
			}
			else
			{
				Warning = "";
			}
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string IdContrassegno, bool TariffaAttiva, bool TariffaPassiva, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			ContrassegniAgganciaTariffa contrassegniAgganciaTariffa = (ContrassegniAgganciaTariffa)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			StringCollection stringCollection = new StringCollection();
			stringCollection.Add(IdContrassegno);
			((AppAbstractApi)contrassegniAgganciaTariffa).ParametersIn.Add("ListOfIdContrassegni", stringCollection);
			((AppAbstractApi)contrassegniAgganciaTariffa).ParametersIn.Add("TariffaAttiva", TariffaAttiva);
			((AppAbstractApi)contrassegniAgganciaTariffa).ParametersIn.Add("TariffaPassiva", TariffaPassiva);
			val = ((AppAbstractApi)contrassegniAgganciaTariffa).Run(ref rsmess);
			if (((AppAbstractApi)contrassegniAgganciaTariffa).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)contrassegniAgganciaTariffa).ParametersOut["_Warning"].ToString();
			}
			else
			{
				Warning = "";
			}
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
}
