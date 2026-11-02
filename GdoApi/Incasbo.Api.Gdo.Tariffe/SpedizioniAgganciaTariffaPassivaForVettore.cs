using System;
using System.Collections.Specialized;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class SpedizioniAgganciaTariffaPassivaForVettore : GdoAbstractApi
{
	protected StringCollection _ListOfUnibol;

	protected TariffeEngine _TariffaEngine;

	public SpedizioniAgganciaTariffaPassivaForVettore(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TariffaEngine = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_ListOfUnibol = (StringCollection)((AppAbstractApi)this).ParametersIn["ListOfUnibol"];
			val2 = (FXRETURN)0;
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

	protected override void BeginTransaction()
	{
	}

	protected override void CommitTransaction()
	{
	}

	protected override void RollbackTransaction()
	{
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (base.ApplicationParams.AbilitaTariffeDiSpedizioneSulVettore())
			{
				StringEnumerator enumerator = _ListOfUnibol.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					string Warning = "";
					string rsmess2 = "";
					_TariffaEngine = new TariffeTrasportoPassiveSpedizioniEngine2(this._ApiContext, current);
					_TariffaEngine.TransactionManage = ((AppAbstractApi)this).TransactionManage;
					val = _TariffaEngine.Run(ref Warning, ref rsmess2);
					if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
					{
						this._Warning += this.TranslateMessage("XXX", "Id spedizione {0}: ", new string[1] { current });
					}
					if (Operators.CompareString(Warning, "", false) != 0)
					{
						ref string warning = ref this._Warning;
						warning = warning + Warning + " ";
					}
					if (Operators.CompareString(rsmess2, "", false) != 0)
					{
						this._Warning += rsmess2;
					}
					if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
					{
						this._Warning += "\r\n";
					}
				}
			}
			val2 = (FXRETURN)0;
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
