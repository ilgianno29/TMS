using System;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class BatchAggiuntaSpedizione : AppAbstractApi
{
	protected string _Unibol;

	protected string _Batch;

	protected DataTable _dtBatch;

	protected DataTable _dtSpedizione;

	protected bool _doit;

	public BatchAggiuntaSpedizione(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtBatch = null;
		_dtSpedizione = null;
		_doit = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = base._ParametersIn["Unibol"].ToString();
			_Batch = base._ParametersIn["Batch"].ToString();
			val = CheckBatch(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckSpedizione(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!_doit)
			{
				goto IL_014c;
			}
			string vsSQLClause = "UPDATE Spedizioni SET BatchId = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Batch) + " WHERE Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.SqlExec(vsSQLClause, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_dtBatch.Rows[0]["Tipo"].ToString(), "X", false) == 0)
				{
					goto IL_014c;
				}
				val = WMS_Batch_AssociaSpedizione_Invoker.Instance.RunProc(this._ApiContext, _Batch, _Unibol, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_014c;
				}
				if (rsmess.Contains("BATCH INESISTENTE"))
				{
					val = WMS_Batch_Crea_Invoker.Instance.RunProc(this._ApiContext, _Batch.ToString(), ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = WMS_Batch_AssociaSpedizione_Invoker.Instance.RunProc(this._ApiContext, _Batch, _Unibol, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_014c;
						}
						val2 = val;
					}
				}
				else
				{
					val2 = val;
				}
			}
			goto end_IL_0005;
			IL_014c:
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

	protected virtual FXRETURN CheckBatch(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string vsSQLClause = "SELECT * FROM Spedizioni_Batch WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Batch);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtBatch, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtBatch.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Batch {0} inesistente", new string[1] { _Batch });
				val2 = (FXRETURN)4;
			}
			else if (Operators.CompareString(_dtBatch.Rows[0]["Tipo"].ToString(), "X", false) == 0)
			{
				if (Conversions.ToInteger(_dtBatch.Rows[0]["Stato"]) < 30)
				{
					goto IL_0177;
				}
				rsmess = this.TranslateMessage("XXX", "Lo stato del batch {0} di tipo 'X' non consente l'operazione richiesta.", new string[1] { _Batch });
				val2 = (FXRETURN)4;
			}
			else
			{
				if (Conversions.ToInteger(_dtBatch.Rows[0]["Stato"]) <= 10)
				{
					goto IL_0177;
				}
				rsmess = this.TranslateMessage("XXX", "Lo stato del batch {0} di tipo 'D' o 'T' non consente l'operazione richiesta.", new string[1] { _Batch });
				val2 = (FXRETURN)4;
			}
			goto end_IL_0005;
			IL_0177:
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string vsSQLClause = "SELECT * FROM Spedizioni WHERE Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Spedizione {0} inesistente", new string[1] { _Unibol });
				val2 = (FXRETURN)4;
			}
			else if (Conversions.ToInteger(_dtSpedizione.Rows[0]["Stato"]) >= 30)
			{
				rsmess = this.TranslateMessage("XXX", "Lo stato della spedizione {0} non consente l'operazione richiesta.", new string[1] { _Unibol });
				val2 = (FXRETURN)4;
			}
			else if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0]["BatchId"])))
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} risulta già associata al batch {1}.", new string[2]
				{
					_Unibol,
					_dtBatch.Rows[0]["BatchId"].ToString()
				});
				val2 = (FXRETURN)4;
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["DataSpedizione"].ToString(), _dtBatch.Rows[0]["Data"].ToString(), false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Date differenti tra spedizione {0} e batch {1}.", new string[2] { _Unibol, _Batch });
				val2 = (FXRETURN)4;
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["ZonaSpedizione"].ToString(), _dtBatch.Rows[0]["ZonaSpedizione"].ToString(), false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Zone di spedizione differenti tra spedizione {0} e batch {1}.", new string[2] { _Unibol, _Batch });
				val2 = (FXRETURN)4;
			}
			else
			{
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
}
