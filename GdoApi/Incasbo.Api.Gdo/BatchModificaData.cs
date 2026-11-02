using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class BatchModificaData : AppAbstractApi
{
	protected string _BatchId;

	protected DateTime _DataSpedizione;

	public BatchModificaData(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_BatchId = null;
		_DataSpedizione = DateTime.MinValue;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!base._ParametersIn.ContainsKey("BatchId"))
			{
				rsmess = this.TranslateMessage("XXX", "Parametro BatchId obbligatorio.");
				val2 = (FXRETURN)4;
			}
			else
			{
				_BatchId = base._ParametersIn["BatchId"].ToString();
				if (!base._ParametersIn.ContainsKey("DataSpedizione"))
				{
					rsmess = this.TranslateMessage("XXX", "Parametro Data Spedizione obbligatorio.");
					val2 = (FXRETURN)4;
				}
				else
				{
					_DataSpedizione = Conversions.ToDate(base._ParametersIn["DataSpedizione"]);
					string sSql = "SELECT COUNT(*) FROM Spedizioni_Batch WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatString(_BatchId);
					object objRes = null;
					val = ((AppBaseClass)this).DbConn.DoSql(sSql, ref objRes, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else if (Conversions.ToInteger(objRes) != 1)
					{
						rsmess = this.TranslateMessage("XXX", "Batch ID {0} non trovato.", new string[1] { _BatchId });
						val2 = (FXRETURN)14;
					}
					else
					{
						sSql = "SELECT Stato, Tipo FROM Spedizioni_Batch WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatString(_BatchId);
						DataTable rObjDataTable = null;
						val = ((AppBaseClass)this).DbConn.OpenDataTable(sSql, ref rObjDataTable, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else if (rObjDataTable.Rows.Count == 0)
						{
							rsmess = this.TranslateMessage("XXX", "Batch ID {0} non trovato.", new string[1] { _BatchId });
						}
						else if (Operators.CompareString(rObjDataTable.Rows[0]["Tipo"].ToString(), "D", false) == 0)
						{
							if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) == 25)
							{
								goto IL_0283;
							}
							rsmess = this.TranslateMessage("XXX", "Batch ID {0}. Lo stato del batch non permette la modifica della data", new string[1] { _BatchId });
							val2 = (FXRETURN)4;
						}
						else
						{
							if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) < 30)
							{
								goto IL_0283;
							}
							rsmess = this.TranslateMessage("XXX", "Batch ID {0}. Lo stato del batch non permette la modifica della data", new string[1] { _BatchId });
							val2 = (FXRETURN)4;
						}
					}
				}
			}
			goto end_IL_0005;
			IL_0283:
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "UPDATE Spedizioni_Batch SET Data=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataSpedizione) + " WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatString(_BatchId) + ";";
			text = text + "UPDATE Spedizioni SET DataSpedizione=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataSpedizione) + " WHERE BatchId=" + ((AppBaseClass)this).DbConn.SQLFormatString(_BatchId) + ";";
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
