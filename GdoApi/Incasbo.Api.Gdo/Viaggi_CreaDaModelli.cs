using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggi_CreaDaModelli : GdoAbstractApi
{
	protected DateTime _DaData;

	protected DateTime _aData;

	protected string _Filtro;

	protected DataTable _dtViaggiModelli;

	protected Dictionary<DateTime, int> _ViaggiCreati;

	public Viaggi_CreaDaModelli(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_dtViaggiModelli = null;
		_ViaggiCreati = new Dictionary<DateTime, int>();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
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
			_Filtro = ((AppAbstractApi)this).ParametersIn["Filtro"].ToString();
			((AppAbstractApi)this).ParametersOut.Add("ViaggiCreati", _ViaggiCreati);
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
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Invalid comparison between Unknown and I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
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
					text = "SELECT * FROM Viaggi_ModelloSettimanale WHERE (" + text2 + "='S') AND (Attivo='S') ";
					if (Operators.CompareString(_Filtro, "", false) != 0)
					{
						text = text + "AND (" + _Filtro + ")";
					}
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggiModelli, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					foreach (DataRow row in _dtViaggiModelli.Rows)
					{
						DateTime dataPartenzaPrevista = dateTime;
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row[text2 + "OraPartenza"])))
						{
							dataPartenzaPrevista = dataPartenzaPrevista.AddHours(Conversions.ToDate(row[text2 + "OraPartenza"]).Hour).AddMinutes(Conversions.ToDate(row[text2 + "OraPartenza"]).Minute);
						}
						val = Viaggio_CreaDaModello_Invoker.Instance.RunProc(this._ApiContext, row["Id"].ToString(), dataPartenzaPrevista, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
							goto end_IL_0249;
						}
					}
					_ViaggiCreati.Add(dateTime, _dtViaggiModelli.Rows.Count);
					dateTime = DateAndTime.DateAdd((DateInterval)4, 1.0, dateTime);
					continue;
				}
				((AppAbstractApi)this).ParametersOut["ViaggiCreati"] = _ViaggiCreati;
				val2 = (FXRETURN)0;
				break;
				continue;
				end_IL_0249:
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
