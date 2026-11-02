using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class TempiResa_CalcolaDate_Invoker : Api_Invoker
{
	protected static TempiResa_CalcolaDate_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static TempiResa_CalcolaDate_Invoker Instance
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
					_instance = new TempiResa_CalcolaDate_Invoker();
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

	protected TempiResa_CalcolaDate_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Cliente, string TipoServizio, string TipoSpedizione, string TipoMerce, string PCSPartenza, string ZonaSpedizione, DateTime? DataRiferimento, ref DateTime DataConsegnaDa, ref DateTime DataConsegnaA, ref DateTime DataUscitaMagazzino, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			TempiResa_CalcolaDate tempiResa_CalcolaDate = (TempiResa_CalcolaDate)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)tempiResa_CalcolaDate).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)tempiResa_CalcolaDate).ParametersIn.Add("TipoServizio", TipoServizio);
			((AppAbstractApi)tempiResa_CalcolaDate).ParametersIn.Add("TipoSpedizione", TipoSpedizione);
			((AppAbstractApi)tempiResa_CalcolaDate).ParametersIn.Add("TipoMerce", TipoMerce);
			((AppAbstractApi)tempiResa_CalcolaDate).ParametersIn.Add("PCSPartenza", PCSPartenza);
			((AppAbstractApi)tempiResa_CalcolaDate).ParametersIn.Add("ZonaSpedizione", ZonaSpedizione);
			((AppAbstractApi)tempiResa_CalcolaDate).ParametersIn.Add("DataRiferimento", DataRiferimento);
			val = ((AppAbstractApi)tempiResa_CalcolaDate).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				DataConsegnaDa = Conversions.ToDate(((AppAbstractApi)tempiResa_CalcolaDate).ParametersOut["DataConsegnaDa"]);
				DataConsegnaA = Conversions.ToDate(((AppAbstractApi)tempiResa_CalcolaDate).ParametersOut["DataConsegnaA"]);
				DataUscitaMagazzino = Conversions.ToDate(((AppAbstractApi)tempiResa_CalcolaDate).ParametersOut["DataUscitaMagazzino"]);
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
}
