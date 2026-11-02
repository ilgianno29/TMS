using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Viaggi_DeterminaVettoreMigliore : GdoAbstractApi
{
	protected string _IdViaggio;

	protected StringCollection _ListOfVettori;

	protected string _VettoreMigliore;

	protected bool _doUpdate;

	public Viaggi_DeterminaVettoreMigliore(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_VettoreMigliore = "";
		_doUpdate = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_ListOfVettori = (StringCollection)((AppAbstractApi)this).ParametersIn["ListOfVettori"];
			_doUpdate = (bool)((AppAbstractApi)this).ParametersIn["doUpdate"];
			DataTable rObjDataTable = null;
			string vsSQLClause = "SELECT IdViaggio, Stato, Vettore FROM VIAGGI WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} non esiste", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) >= 30)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} risulta già partito", new string[1] { _IdViaggio });
			}
			else if (Operators.CompareString(rObjDataTable.Rows[0]["Vettore"].ToString(), "", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} risulta già assegnato al vettore {1}", new string[2]
				{
					_IdViaggio,
					rObjDataTable.Rows[0]["Vettore"].ToString()
				});
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("VettoreMigliore", "");
				((AppAbstractApi)this).ParametersOut.Add("ListOfVettoriMigliori", new List<Simulation_Result>());
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
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Invalid comparison between Unknown and I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Dictionary<string, Simulation_Result> SimulationResult = null;
			string Warning = "";
			val = Simulation_ViaggiAgganciaTariffaPassiva_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, _ListOfVettori, ref SimulationResult, ref Warning, ref rsmess);
			List<Simulation_Result> list;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				decimal d = decimal.MaxValue;
				StringEnumerator enumerator = _ListOfVettori.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!SimulationResult.ContainsKey(current))
					{
						continue;
					}
					Simulation_Result simulation_Result = SimulationResult[current];
					if (Operators.CompareString(simulation_Result.Errore, "", false) != 0)
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
					simulation_Result.TotaleCosto = num;
					if (decimal.Compare(num, d) < 0)
					{
						d = num;
					}
				}
				IEnumerable<KeyValuePair<string, Simulation_Result>> enumerable = (from res in SimulationResult
					where (Operators.CompareString(res.Value.Errore, "", false) == 0) & (decimal.Compare(res.Value.TotaleCosto, 0m) > 0)
					orderby res.Value.TotaleCosto
					select res).Take(base.ApplicationParams.NumRisultatiVettoriMigliori());
				if (enumerable.Count() > 0)
				{
					_VettoreMigliore = enumerable.ElementAtOrDefault(0).Value.Vettore;
				}
				list = new List<Simulation_Result>();
				foreach (KeyValuePair<string, Simulation_Result> item2 in enumerable)
				{
					list.Add(item2.Value);
				}
				if (Operators.CompareString(_VettoreMigliore, "", false) == 0 || !_doUpdate)
				{
					goto IL_0311;
				}
				string text = "UPDATE Viaggi SET Vettore=" + ((AppBaseClass)this).DbConn.SQLFormatString(_VettoreMigliore) + ", ";
				text = text + "DatAgg=" + this.DbConn.GetDate() + ", UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
				text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdViaggio) + ";";
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0311;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_0311:
			((AppAbstractApi)this).ParametersOut["ListOfVettoriMigliori"] = list;
			((AppAbstractApi)this).ParametersOut["VettoreMigliore"] = _VettoreMigliore;
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
