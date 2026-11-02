using System;
using System.Collections.Specialized;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class SpedizioniAgganciaTariffa : GdoAbstractApi
{
	protected StringCollection _ListOfUnibol;

	protected TariffeEngine _TariffaEngine;

	protected bool _TariffaAttiva;

	protected bool _TariffaPassiva;

	protected bool _TariffaPassivaPerVettore;

	public SpedizioniAgganciaTariffa(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TariffaEngine = null;
		_TariffaAttiva = true;
		_TariffaPassiva = true;
		_TariffaPassivaPerVettore = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_ListOfUnibol = (StringCollection)((AppAbstractApi)this).ParametersIn["ListOfUnibol"];
			_TariffaAttiva = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["TariffaAttiva"]);
			_TariffaPassiva = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["TariffaPassiva"]);
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TariffaPassivaPerVettore"))
			{
				_TariffaPassivaPerVettore = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["TariffaPassivaPerVettore"]);
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
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			StringEnumerator enumerator = _ListOfUnibol.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string Warning = "";
				string rsmess2 = "";
				if (_TariffaAttiva)
				{
					val = SpedizioniAgganciaTariffaAttiva_Invoker.Instance.RunProc(this._ApiContext, current, ref Warning, ref rsmess2);
					if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
					{
						this._Warning += this.TranslateMessage("XXX", "Calcolo Tariffa Attiva di spedizione: ");
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
					val = SpedizioniAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, current, ref Warning, ref rsmess2);
					if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
					{
						this._Warning += this.TranslateMessage("XXX", "Calcolo Tariffa passiva di spedizione: ");
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
				if (_TariffaPassivaPerVettore & base.ApplicationParams.AbilitaTariffeDiSpedizioneSulVettore())
				{
					val = SpedizioniAgganciaTariffaPassivaForVettore_Invoker.Instance.RunProc(this._ApiContext, current, ref Warning, ref rsmess2);
					if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
					{
						this._Warning += this.TranslateMessage("XXX", "Calcolo Tariffa passiva di spedizione per il vettore: ");
					}
					if (Operators.CompareString(Warning, "", false) != 0)
					{
						ref string warning3 = ref this._Warning;
						warning3 = warning3 + Warning + " ";
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
