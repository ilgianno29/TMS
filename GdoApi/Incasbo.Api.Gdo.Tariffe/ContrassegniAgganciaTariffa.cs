using System;
using System.Collections.Specialized;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class ContrassegniAgganciaTariffa : GdoAbstractApi
{
	protected StringCollection _ListOfIdContrassegni;

	protected TariffeEngine _TariffaEngine;

	protected bool _TariffaAttiva;

	protected bool _TariffaPassiva;

	public ContrassegniAgganciaTariffa(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TariffaEngine = null;
		_TariffaAttiva = true;
		_TariffaPassiva = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_ListOfIdContrassegni = (StringCollection)((AppAbstractApi)this).ParametersIn["ListOfIdContrassegni"];
			_TariffaAttiva = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["TariffaAttiva"]);
			_TariffaPassiva = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["TariffaPassiva"]);
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
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			StringEnumerator enumerator = _ListOfIdContrassegni.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string Warning = "";
				string rsmess2 = "";
				if (_TariffaAttiva)
				{
					val = ContrassegniAgganciaTariffaAttiva_Invoker.Instance.RunProc(this._ApiContext, current, ref Warning, ref rsmess2);
					if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
					{
						this._Warning += this.TranslateMessage("XXX", "Calcolo Tariffa Attiva di contrassegno: ");
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
				}
				Warning = "";
				rsmess2 = "";
				if (_TariffaPassiva)
				{
					val = ContrassegniAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, current, ref Warning, ref rsmess2);
					if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
					{
						this._Warning += this.TranslateMessage("XXX", "Calcolo Tariffa passiva di contrassegno: ");
					}
					if (Operators.CompareString(Warning, "", false) != 0)
					{
						ref string warning2 = ref this._Warning;
						warning2 = warning2 + Warning + " ";
					}
					if (Operators.CompareString(rsmess2, "", false) != 0)
					{
						this._Warning += rsmess2;
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
