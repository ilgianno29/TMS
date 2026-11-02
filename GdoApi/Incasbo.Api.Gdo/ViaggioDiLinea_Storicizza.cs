using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class ViaggioDiLinea_Storicizza : GdoAbstractApi
{
	protected int _IdViaggioDiLinea;

	public ViaggioDiLinea_Storicizza(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggioDiLinea = Conversions.ToInteger(this._ParametersIn["IdViaggioDiLinea"]);
			DataTable rObjDataTable = null;
			text = "SELECT Stato, Id FROM Viaggi_Linea WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdViaggioDiLinea);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Viaggio di linea con ID {0} non trovato", new string[1] { _IdViaggioDiLinea.ToString() });
			}
			else if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) != 20)
			{
				rsmess = this.TranslateMessage("XXX", "Il Viaggio di linea con ID {0} risulta già chiuso", new string[1] { _IdViaggioDiLinea.ToString() });
			}
			else
			{
				obj = null;
				text = "SELECT COUNT(*) FROM Spedizioni WHERE IdViaggioLinea=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdViaggioDiLinea) + " AND IdViaggio IS NULL";
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref obj, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (Conversions.ToInteger(obj) > 0)
				{
					rsmess = this.TranslateMessage("XXX", "Viaggio di linea con ID {0} non storicizzabile. Esistono delle spedizioni non associate ad alcun viaggio", new string[1] { _IdViaggioDiLinea.ToString() });
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "UPDATE Viaggi_Linea SET Stato=30, DataStoricizzazione=GETDATE(), DatAgg=GETDATE(), ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._ApiContext.User) + " WHERE Id=" + this.DbConn.SQLFormatNumber(ref _IdViaggioDiLinea);
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
