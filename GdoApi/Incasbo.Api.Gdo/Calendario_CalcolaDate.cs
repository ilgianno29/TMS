using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Calendario_CalcolaDate : AppAbstractApi
{
	protected DateTime _DataRiferimento;

	protected int _GiorniDaAggiungere;

	protected DateTime _DataCalcolata;

	public Calendario_CalcolaDate(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_GiorniDaAggiungere = 0;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_DataRiferimento = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["DataRiferimento"]);
			_GiorniDaAggiungere = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["GiorniDaAggiungere"]);
			((AppAbstractApi)this).ParametersOut.Add("DataCalcolata", _DataCalcolata);
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
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			DataTable rObjDataTable = null;
			if (((AppBaseClass)this).DbConn.ServerType == DBFormatFunctions.eServerType.SQL)
			{
				text = "SELECT TOP %N% Data FROM Calendario ";
				text += "WHERE Data >= dbo.trunc(%DATA%) AND flag='L' ";
				text += "ORDER BY Data";
			}
			else if (((AppBaseClass)this).DbConn.ServerType == DBFormatFunctions.eServerType.Oracle)
			{
				text = "SELECT DATA FROM (";
				text += "SELECT Data FROM Calendario ";
				text += "WHERE Data >= %DATA% AND Flag='L' ";
				text += "ORDER BY DATA) WHERE ROWNUM <= %N%";
			}
			text = text.Replace("%N%", checked(_GiorniDaAggiungere + 1).ToString());
			text = text.Replace("%DATA%", ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataRiferimento));
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count == 0)
				{
					_DataCalcolata = DateAndTime.DateAdd((DateInterval)4, (double)_GiorniDaAggiungere, DateAndTime.Now.Date);
				}
				else
				{
					_DataCalcolata = Conversions.ToDate(rObjDataTable.Rows[checked(rObjDataTable.Rows.Count - 1)]["Data"]);
				}
				((AppAbstractApi)this).ParametersOut["DataCalcolata"] = _DataCalcolata;
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
