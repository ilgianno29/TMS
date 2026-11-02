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

public class Spedizioni_DeterminaCorrispondenteMigliore_Invoker : Api_Invoker
{
	protected static Spedizioni_DeterminaCorrispondenteMigliore_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizioni_DeterminaCorrispondenteMigliore_Invoker Instance
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
					_instance = new Spedizioni_DeterminaCorrispondenteMigliore_Invoker();
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

	protected Spedizioni_DeterminaCorrispondenteMigliore_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, StringCollection ListOfCorrispondenti, bool doUpdate, ref string CorrispondenteMigliore, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizioni_DeterminaCorrispondenteMigliore spedizioni_DeterminaCorrispondenteMigliore = (Spedizioni_DeterminaCorrispondenteMigliore)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizioni_DeterminaCorrispondenteMigliore).ParametersIn.Add("ListOfCorrispondenti", ListOfCorrispondenti);
			((AppAbstractApi)spedizioni_DeterminaCorrispondenteMigliore).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)spedizioni_DeterminaCorrispondenteMigliore).ParametersIn.Add("doUpdate", doUpdate);
			val = ((AppAbstractApi)spedizioni_DeterminaCorrispondenteMigliore).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				CorrispondenteMigliore = ((AppAbstractApi)spedizioni_DeterminaCorrispondenteMigliore).ParametersOut["CorrispondenteMigliore"].ToString();
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
