using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Simulation_SpedizioniAgganciaTariffaPassiva : AppAbstractApi
{
	protected string _Unibol;

	protected StringCollection _ListOfCorrispondenti;

	protected Simulation_TariffeEngine _TariffaEngine;

	protected Dictionary<string, Simulation_Result> _ListOfSimulationResult;

	public Simulation_SpedizioniAgganciaTariffaPassiva(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
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
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_ListOfCorrispondenti = (StringCollection)((AppAbstractApi)this).ParametersIn["ListOfCorrispondenti"];
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
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			StringEnumerator enumerator = _ListOfCorrispondenti.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string Warning = "";
				string rsmess2 = "";
				_TariffaEngine = new Simulation_TariffeTrasportoPassiveSpedizioniEngine(this._ApiContext, _Unibol, current);
				_TariffaEngine.TransactionManage = ((AppAbstractApi)this).TransactionManage;
				val = _TariffaEngine.Run(ref Warning, ref rsmess2);
				if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
				{
					base._Warning += this.TranslateMessage("XXX", "Id Spedizione: {0} Corrispondente: {1}", new string[2] { _Unibol, current });
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
				simulation_Result.Corrispondente = current;
				simulation_Result.IdDocumento = _Unibol;
				simulation_Result.Costi = _TariffaEngine.Costi;
				simulation_Result.Errore = rsmess2;
				simulation_Result.Warning = Warning;
				_ListOfSimulationResult.Add(current, simulation_Result);
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
