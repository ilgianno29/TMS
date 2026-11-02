using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Simulation_ViaggiAgganciaTariffaPassiva : AppAbstractApi
{
	protected string _IdViaggio;

	protected StringCollection _ListOfVettori;

	protected Simulation_TariffeEngine _TariffaEngine;

	protected Dictionary<string, Simulation_Result> _ListOfSimulationResult;

	public Simulation_ViaggiAgganciaTariffaPassiva(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_TariffaEngine = null;
		_ListOfSimulationResult = new Dictionary<string, Simulation_Result>();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_ListOfVettori = (StringCollection)((AppAbstractApi)this).ParametersIn["ListOfVettori"];
			((AppAbstractApi)this).ParametersOut.Add("SimulationResult", _ListOfSimulationResult);
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
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN nRes = (FXRETURN)3;
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			IboWebParam parametrica = this._Parametrica;
			string rsMess = "";
			double num = Conversions.ToDouble(parametrica.ValoreParametro("PARAMS.VIAGGI.SOGLIA_VETTORI_MIGLIORI", ref nRes, ref rsMess));
			StringEnumerator enumerator = _ListOfVettori.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string Warning = "";
				string rsmess2 = "";
				_TariffaEngine = new Simulation_TariffeTrasportoPassiveViaggioEngine(this._ApiContext, _IdViaggio, current);
				_TariffaEngine.TransactionManage = ((AppAbstractApi)this).TransactionManage;
				nRes = _TariffaEngine.Run(ref Warning, ref rsmess2);
				if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
				{
					base._Warning += this.TranslateMessage("XXX", "Id viaggio: {0} Vettore: {1}", new string[2] { _IdViaggio, current });
				}
				if (Operators.CompareString(Warning, "", false) != 0)
				{
					ref string warning = ref base._Warning;
					warning = warning + Warning + " ";
				}
				if (Operators.CompareString(rsmess2, "", false) != 0)
				{
					base._Warning += rsmess2;
				}
				if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
				{
					base._Warning += "\r\n";
				}
				Simulation_Result simulation_Result = new Simulation_Result();
				simulation_Result.Vettore = current;
				simulation_Result.IdDocumento = _IdViaggio;
				simulation_Result.Costi = _TariffaEngine.Costi;
				simulation_Result.Errore = rsmess2;
				simulation_Result.Warning = Warning;
				decimal num2 = default(decimal);
				foreach (Costo item in simulation_Result.Costi)
				{
					num2 = decimal.Add(num2, item.ImportoArrotondato);
				}
				if (Convert.ToDouble(num2) >= num)
				{
					_ListOfSimulationResult.Add(current, simulation_Result);
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}
}
