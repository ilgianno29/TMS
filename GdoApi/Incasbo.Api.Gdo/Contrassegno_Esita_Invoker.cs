using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_Esita_Invoker : Api_Invoker
{
	protected static Contrassegno_Esita_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Contrassegno_Esita_Invoker Instance
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
					_instance = new Contrassegno_Esita_Invoker();
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

	protected Contrassegno_Esita_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, int IdContrassegno, string CausaleEsito, DateTime? DataEsito, string NoteEsito, string TipoIncasso, string NoteIncasso, string Note1, string Note2, string Note3, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Contrassegno_Esita contrassegno_Esita = (Contrassegno_Esita)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("IdContrassegno", IdContrassegno);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("CausaleEsito", CausaleEsito);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("DataEsito", DataEsito);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("NoteEsito", NoteEsito);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("TipoIncasso", TipoIncasso);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("NoteIncasso", NoteIncasso);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("Note1", Note1);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("Note2", Note2);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("Note3", Note3);
			((AppAbstractApi)contrassegno_Esita).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)contrassegno_Esita).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)contrassegno_Esita).ParametersOut["RetQueryToApply"].ToString();
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
