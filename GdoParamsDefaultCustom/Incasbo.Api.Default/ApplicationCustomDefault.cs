using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Default;

public class ApplicationCustomDefault : AppDefault
{
	protected string _Trasportatore_Dummy_Default;

	protected string _Voce_BestCarrier_Default;

	public ApplicationCustomDefault(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Trasportatore_Dummy_Default = "";
		_Voce_BestCarrier_Default = "";
	}

	public string Trasportatore_Dummy_Default()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		string text = "";
		string rsMess = "";
		FXRETURN rnRes = (FXRETURN)3;
		string result;
		try
		{
			if (Operators.CompareString(_Trasportatore_Dummy_Default, "", false) != 0)
			{
				goto IL_0058;
			}
			_Trasportatore_Dummy_Default = ((AppBaseClass)this).Parametrica.LeggiParametro("CST.DEFAULT.TRASPORTATORE.DUMMY", ref rnRes, ref rsMess);
			if ((int)rnRes <= 0)
			{
				goto IL_0058;
			}
			result = "";
			goto end_IL_000f;
			IL_0058:
			result = _Trasportatore_Dummy_Default;
			end_IL_000f:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Voce_BestCarrier_Default()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		string text = "";
		string rsMess = "";
		FXRETURN rnRes = (FXRETURN)3;
		string result;
		try
		{
			if (Operators.CompareString(_Voce_BestCarrier_Default, "", false) != 0)
			{
				goto IL_0058;
			}
			_Voce_BestCarrier_Default = ((AppBaseClass)this).Parametrica.LeggiParametro("CST.DEFAULT.VOCE.BESTCARRIER", ref rnRes, ref rsMess);
			if ((int)rnRes <= 0)
			{
				goto IL_0058;
			}
			result = "";
			goto end_IL_000f;
			IL_0058:
			result = _Voce_BestCarrier_Default;
			end_IL_000f:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void ResetDefault()
	{
		_Trasportatore_Dummy_Default = "";
		_Voce_BestCarrier_Default = "";
	}
}
