using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizioni_CreaDaModelli : GdoAbstractApi
{
	protected DateTime _DaData;

	protected DateTime _aData;

	protected DataTable _dtSpedizioneModelli;

	protected Dictionary<DateTime, int> _SpedizioniCreate;

	public Spedizioni_CreaDaModelli(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_dtSpedizioneModelli = null;
		_SpedizioniCreate = new Dictionary<DateTime, int>();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_DaData = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["DaData"]);
			_aData = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["aData"]);
			((AppAbstractApi)this).ParametersOut.Add("SpedizioniCreate", _SpedizioniCreate);
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
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			DateTime dateTime = _DaData;
			while (true)
			{
				if (DateTime.Compare(dateTime, _aData) <= 0)
				{
					string text2 = "";
					switch (dateTime.DayOfWeek)
					{
					case DayOfWeek.Monday:
						text2 = "LUNEDI";
						break;
					case DayOfWeek.Tuesday:
						text2 = "MARTEDI";
						break;
					case DayOfWeek.Wednesday:
						text2 = "MERCOLEDI";
						break;
					case DayOfWeek.Thursday:
						text2 = "GIOVEDI";
						break;
					case DayOfWeek.Friday:
						text2 = "VENERDI";
						break;
					case DayOfWeek.Saturday:
						text2 = "SABATO";
						break;
					case DayOfWeek.Sunday:
						text2 = "DOMENICA";
						break;
					}
					text = "SELECT * FROM Spedizioni_ModelloSettimanale WHERE " + text2 + "='S'";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioneModelli, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					foreach (DataRow row in _dtSpedizioneModelli.Rows)
					{
						val = Spedizione_CreaDaModello_Invoker.Instance.RunProc(this._ApiContext, row["Id"].ToString(), dateTime, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
							goto end_IL_018e;
						}
					}
					_SpedizioniCreate.Add(dateTime, _dtSpedizioneModelli.Rows.Count);
					dateTime = DateAndTime.DateAdd((DateInterval)4, 1.0, dateTime);
					continue;
				}
				((AppAbstractApi)this).ParametersOut["SpedizioniCreate"] = _SpedizioniCreate;
				val2 = (FXRETURN)0;
				break;
				continue;
				end_IL_018e:
				break;
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
