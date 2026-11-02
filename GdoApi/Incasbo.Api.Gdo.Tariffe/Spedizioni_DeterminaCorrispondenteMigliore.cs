using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Spedizioni_DeterminaCorrispondenteMigliore : AppAbstractApi
{
	protected string _Unibol;

	protected StringCollection _ListOfCorrispondenti;

	protected string _CorrispondenteMigliore;

	protected bool _doUpdate;

	public Spedizioni_DeterminaCorrispondenteMigliore(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_CorrispondenteMigliore = "";
		_doUpdate = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_ListOfCorrispondenti = (StringCollection)((AppAbstractApi)this).ParametersIn["ListOfCorrispondenti"];
			_doUpdate = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["doUpdate"]);
			DataTable rObjDataTable = null;
			string vsSQLClause = "SELECT Unibol, Stato, Corrispondente FROM Spedizioni WHERE UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} non esiste", new string[1] { _Unibol });
			}
			else if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) >= 40)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} risulta già partita", new string[1] { _Unibol });
			}
			else if (Operators.CompareString(rObjDataTable.Rows[0]["Corrispondente"].ToString(), "", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} risulta già assegnata al corrispondente {1}", new string[2]
				{
					_Unibol,
					rObjDataTable.Rows[0]["Corrispondente"].ToString()
				});
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("CorrispondenteMigliore", "");
				val2 = (FXRETURN)0;
			}
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
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Dictionary<string, Simulation_Result> SimulationResult = null;
			string Warning = "";
			val = Simulation_SpedizioniAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, _Unibol, _ListOfCorrispondenti, ref SimulationResult, ref Warning, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text = "";
				string text2 = "";
				decimal d = decimal.MaxValue;
				StringEnumerator enumerator = _ListOfCorrispondenti.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!SimulationResult.ContainsKey(current))
					{
						continue;
					}
					Simulation_Result simulation_Result = SimulationResult[current];
					if (Operators.CompareString(simulation_Result.Errore, "", false) != 0 || simulation_Result.Costi.Count <= 0)
					{
						continue;
					}
					decimal num = default(decimal);
					foreach (Costo item in simulation_Result.Costi)
					{
						if (Operators.CompareString(item.RecordZZ, "N", false) == 0)
						{
							num = decimal.Add(num, item.ImportoArrotondato);
						}
					}
					if (decimal.Compare(num, d) < 0)
					{
						d = num;
						text = current;
					}
				}
				_CorrispondenteMigliore = text;
				if (Operators.CompareString(text, "", false) == 0 || !_doUpdate)
				{
					goto IL_0205;
				}
				List<string> list = new List<string>();
				list.Add(_Unibol);
				val = Spedizione_AggiungiTransitPoint.RunProc(this._ApiContext, list, text, ref rsmess);
				if ((int)val <= 0)
				{
					SpedizioniAgganciaTariffaPassiva_Invoker instance = SpedizioniAgganciaTariffaPassiva_Invoker.Instance;
					AppApiContext apiContext = this._ApiContext;
					string unibol = _Unibol;
					string Warning2 = "";
					string rsmess2 = "";
					instance.RunProc(apiContext, unibol, ref Warning2, ref rsmess2);
					goto IL_0205;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_0205:
			((AppAbstractApi)this).ParametersOut["CorrispondenteMigliore"] = _CorrispondenteMigliore;
			val2 = (FXRETURN)0;
			end_IL_0005:;
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
