using System.Collections.Generic;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Library;

namespace Incasbo.CustomApi.Gdo;

public class _Spedizione_Attiva : Spedizione_Attiva
{
	public _Spedizione_Attiva(AppApiContext objApiContext)
		: base(objApiContext)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		((AppAbstractApi)this).AfterCheckDataEvent += new AfterCheckDataEventEventHandler(_Spedizione_Attiva_AfterCheckDataEvent);
		((AppAbstractApi)this).AfterRunEvent += new AfterRunEventEventHandler(_Spedizione_Attiva_AfterRunEvent);
		((AppAbstractApi)this).BeforeRunEvent += new BeforeRunEventEventHandler(_Spedizione_Attiva_BeforeRunEvent);
	}

	private void _Spedizione_Attiva_AfterCheckDataEvent(ref Dictionary<string, object> ParametersIn, ref Dictionary<string, object> ParametersOut, ref FXRETURN nRes, ref string rsmess)
	{
		nRes = (FXRETURN)0;
	}

	private void _Spedizione_Attiva_AfterRunEvent(ref Dictionary<string, object> ParametersIn, ref Dictionary<string, object> ParametersOut, ref FXRETURN nRes, ref string rsmess)
	{
		nRes = (FXRETURN)0;
	}

	private void _Spedizione_Attiva_BeforeRunEvent(ref Dictionary<string, object> ParametersIn, ref Dictionary<string, object> ParametersOut, ref FXRETURN nRes, ref string rsmess)
	{
		nRes = (FXRETURN)0;
	}
}
