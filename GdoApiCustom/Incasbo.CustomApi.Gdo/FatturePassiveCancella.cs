using System;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.CustomApi.Gdo;

public class FatturePassiveCancella : Incasbo.Api.Gdo.FatturePassiveCancella
{
	public FatturePassiveCancella(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (!((AppAbstractApi)this).ParametersIn.ContainsKey("IdFattura"))
			{
				rsMess = this._Translator.TranslateMessage("XXX", "Id Fattura non specificato", new string[0]);
			}
			else
			{
				_IdFattura = Convert.ToInt64(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["IdFattura"]));
				DataTable rObjDataTable = null;
				string vsSQLClause = "SELECT * FROM FATTURE_PASSIVE_TESTATA WHERE IdFattura=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = this.TranslateMessage("xxx", "Fattura {0} inesistente.", new string[1] { _IdFattura.ToString() });
					val2 = (FXRETURN)5;
				}
				else if ((Operators.CompareString(rObjDataTable.Rows[0]["Numero"].ToString(), "0", false) != 0) & (Operators.CompareString(rObjDataTable.Rows[0]["Contabilizzata"].ToString(), "S", false) == 0))
				{
					rsMess = this.TranslateMessage("xxx", "Fattura {0} già contabilizzata.", new string[1] { _IdFattura.ToString() });
					val2 = (FXRETURN)5;
				}
				else
				{
					val2 = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
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
