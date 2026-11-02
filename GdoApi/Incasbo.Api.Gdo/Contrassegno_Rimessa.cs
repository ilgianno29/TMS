using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_Rimessa : ContrassegniAbstractApi
{
	protected List<int> _IdContrassegni;

	protected DateTime? _DataRimessa;

	protected string _Cliente;

	protected string _Note1;

	protected string _Note2;

	protected string _Note3;

	public Contrassegno_Rimessa(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Cliente = "";
		_Note1 = "";
		_Note2 = "";
		_Note3 = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Invalid comparison between Unknown and I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdContrassegni = (List<int>)((AppAbstractApi)this).ParametersIn["IdContrassegni"];
			_DataRimessa = (DateTime?)((AppAbstractApi)this).ParametersIn["DataRimessa"];
			if (!_DataRimessa.HasValue)
			{
				_DataRimessa = DateAndTime.Now.Date;
			}
			_Cliente = ((AppAbstractApi)this).ParametersIn["Cliente"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note1"))
			{
				_Note1 = ((AppAbstractApi)this).ParametersIn["Note1"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note2"))
			{
				_Note2 = ((AppAbstractApi)this).ParametersIn["Note2"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note3"))
			{
				_Note3 = ((AppAbstractApi)this).ParametersIn["Note3"].ToString();
			}
			val = CheckElencoContrassegni(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("IdRimessa", null);
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Invalid comparison between Unknown and I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.RIMESSE.ID", ref rlReturnValue, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "INSERT INTO Contrassegni_Rimesse (Id,DataRimessa,Cliente,Stato,Note1,Note2,Note3,UteAgg,UteIns) VALUES (";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref rlReturnValue) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataRimessa) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + ", ";
				text += "10, ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Note1) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Note2) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Note3) + ", ";
				text = text + this.DbConn.SQLFormatString(this._User) + ", ";
				text = text + this.DbConn.SQLFormatString(this._User) + "); ";
				foreach (int item in _IdContrassegni)
				{
					int pNumero = item;
					text = text + "UPDATE Contrassegni SET IdRimessa=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref rlReturnValue) + ", ";
					text += "Stato=40, ";
					text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
					text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
					text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + "; ";
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					int? num = checked((int)rlReturnValue);
					((AppAbstractApi)this).ParametersOut["IdRimessa"] = num;
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

	protected virtual FXRETURN CheckElencoContrassegni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			foreach (int item in _IdContrassegni)
			{
				int pNumero = item;
				DataTable rObjDataTable = null;
				string text = "SELECT Id, Cliente, Stato FROM Contrassegni ";
				text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + " ";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "La pratica di contrassegno con Id {0} non esiste", new string[1] { pNumero.ToString() });
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["Cliente"].ToString().ToUpper(), _Cliente.ToUpper(), false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "La pratica di contrassegno con Id {0} non è intestata al cliente {1}", new string[2]
					{
						pNumero.ToString(),
						rObjDataTable.Rows[0]["Cliente"].ToString()
					});
				}
				else
				{
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) == 30)
					{
						continue;
					}
					rsmess = this.TranslateMessage("XXX", "La pratica di contrassegno con Id {0} non è in uno stato che consente la rimessa al cliente", new string[1] { pNumero.ToString() });
				}
				goto end_IL_0005;
			}
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
