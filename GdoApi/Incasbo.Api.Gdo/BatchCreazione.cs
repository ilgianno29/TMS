using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class BatchCreazione : AppAbstractApi
{
	protected DateTime _Data;

	protected string _ZonaSpedizione;

	protected string _Tipo;

	protected string _Note;

	public BatchCreazione(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ZonaSpedizione = "";
		_Tipo = "";
		_Note = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("Id", "");
			_Data = Conversions.ToDate(base._ParametersIn["Data"]);
			_ZonaSpedizione = base._ParametersIn["ZonaSpedizione"].ToString();
			_Tipo = base._ParametersIn["Tipo"].ToString();
			if (Operators.CompareString(_Tipo, "", false) == 0)
			{
				_Tipo = "D";
			}
			_Note = base._ParametersIn["Note"].ToString();
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Invalid comparison between Unknown and I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between Unknown and I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			int Count = default(int);
			val = BatchCountRead(ref Count, ref rsmess);
			long rlReturnValue = default(long);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Count > 0)
			{
				rsmess = this.TranslateMessage("XXX", "Esiste già un batch per la data {0} e la zona di spedizione {1}.", new string[2]
				{
					_Data.ToString("dd/MM/yyyy"),
					_ZonaSpedizione
				});
				val2 = (FXRETURN)4;
			}
			else
			{
				val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.BATCH", ref rlReturnValue, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					string text = "INSERT INTO Spedizioni_Batch (Id, Data, ZonaSpedizione, Tipo, Stato, Note, DataCreazione, UteIns, UteAgg, DatIns, DatAgg) VALUES (";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(rlReturnValue.ToString()) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Data) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaSpedizione) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Tipo) + ", ";
					text += "10, ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Note) + ", ";
					text = text + ((AppBaseClass)this).DbConn.GetDate() + ", ";
					text = text + this.DbConn.SQLFormatString(this._User) + ", ";
					text = text + this.DbConn.SQLFormatString(this._User) + ", ";
					text = text + ((AppBaseClass)this).DbConn.GetDate() + ", ";
					text = text + ((AppBaseClass)this).DbConn.GetDate() + ")";
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (Operators.CompareString(_Tipo, "X", false) != 0)
						{
							goto IL_0227;
						}
						val = BatchAttivazione_Invoker.Instance.RunProc(this._ApiContext, rlReturnValue.ToString(), ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_0227;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0005;
			IL_026b:
			((AppAbstractApi)this).ParametersOut["Id"] = rlReturnValue.ToString();
			val2 = (FXRETURN)0;
			goto end_IL_0005;
			IL_0227:
			if (Operators.CompareString(_Tipo, "X", false) == 0)
			{
				goto IL_026b;
			}
			val = WMS_Batch_Crea_Invoker.Instance.RunProc(this._ApiContext, rlReturnValue.ToString(), ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_026b;
			}
			val2 = val;
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

	protected FXRETURN BatchCountRead(ref int Count, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Invalid comparison between Unknown and I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Count = 0;
			if (Operators.CompareString(_Tipo, "D", false) == 0)
			{
				string text = "SELECT COUNT(*) FROM Spedizioni_Batch WHERE ";
				text = text + "Data = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Data) + " AND ";
				text = text + "ZonaSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaSpedizione) + " AND ";
				text = text + "Tipo = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Tipo) + " AND ";
				text += "Stato = 10";
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
				if ((int)val <= 0)
				{
					Count = Conversions.ToInteger(objRes);
					goto IL_01c0;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_Tipo, "T", false) == 0 || Operators.CompareString(_Tipo, "X", false) != 0)
				{
					goto IL_01c0;
				}
				string text = "SELECT COUNT(*) FROM Spedizioni_Batch WHERE ";
				text = text + "Data = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Data) + " AND ";
				text = text + "ZonaSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaSpedizione) + " AND ";
				text = text + "Tipo = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Tipo) + " AND ";
				text += "Stato < 30";
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
				if ((int)val <= 0)
				{
					Count = Conversions.ToInteger(objRes);
					goto IL_01c0;
				}
				val2 = val;
			}
			goto end_IL_0008;
			IL_01c0:
			val2 = (FXRETURN)0;
			end_IL_0008:;
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
