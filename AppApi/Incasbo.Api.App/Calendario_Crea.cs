using System;
using System.Collections.Specialized;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class Calendario_Crea : AppAbstractApi
{
	protected int _Anno;

	protected int _GiorniAnno;

	protected StringCollection _Festivi;

	protected bool _SabatoFestivo;

	protected bool _DomenicaFestivo;

	public Calendario_Crea(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Anno = 0;
		_GiorniAnno = 0;
		_Festivi = new StringCollection();
		_SabatoFestivo = true;
		_DomenicaFestivo = true;
	}

	protected override modGeneral.FXRETURN CheckData(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			_Anno = Conversions.ToInteger(ParametersIn["Anno"]);
			DeterminaFestivita();
			fXRETURN2 = modGeneral.FXRETURN.OK;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	protected virtual void DeterminaFestivita()
	{
		_Festivi.Add("01/01/" + _Anno);
		_Festivi.Add("06/01/" + _Anno);
		_Festivi.Add("25/04/" + _Anno);
		_Festivi.Add("01/05/" + _Anno);
		_Festivi.Add("02/06/" + _Anno);
		_Festivi.Add("15/08/" + _Anno);
		_Festivi.Add("01/11/" + _Anno);
		_Festivi.Add("08/12/" + _Anno);
		_Festivi.Add("25/12/" + _Anno);
		_Festivi.Add("26/12/" + _Anno);
		_SabatoFestivo = true;
		_DomenicaFestivo = true;
	}

	protected override modGeneral.FXRETURN Core(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		string text = "";
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DateTime dateTime = new DateTime(_Anno, 1, 1);
			DateTime dateTime2 = new DateTime(_Anno, 12, 31);
			_GiorniAnno = checked((int)DateAndTime.DateDiff((DateInterval)4, dateTime, DateAndTime.DateAdd((DateInterval)4, 1.0, dateTime2), (FirstDayOfWeek)1, (FirstWeekOfYear)1));
			object objRes = null;
			text = "SELECT COUNT(*) FROM CALENDARIO WHERE DATA >= " + DbConn.SQLFormatDate(modGeneral.eTipoData.Data, dateTime) + " ";
			text = text + "AND DATA <= " + DbConn.SQLFormatDate(modGeneral.eTipoData.Data, dateTime2);
			fXRETURN = DbConn.DoSql(text, ref objRes, ref rsmess);
			if (fXRETURN != 0)
			{
				fXRETURN2 = fXRETURN;
			}
			else if (Conversions.ToInteger(objRes) == 0)
			{
				fXRETURN = CreaCalendario(_Anno, CheckGiorno: false, ref rsmess);
				if (fXRETURN == modGeneral.FXRETURN.OK)
				{
					goto IL_00f3;
				}
				fXRETURN2 = fXRETURN;
			}
			else
			{
				if (Conversions.ToInteger(objRes) == _GiorniAnno)
				{
					goto IL_00f3;
				}
				fXRETURN = CreaCalendario(_Anno, CheckGiorno: true, ref rsmess);
				if (fXRETURN == modGeneral.FXRETURN.OK)
				{
					goto IL_00f3;
				}
				fXRETURN2 = fXRETURN;
			}
			goto end_IL_000a;
			IL_00f3:
			fXRETURN2 = modGeneral.FXRETURN.OK;
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN CreaCalendario(int anno, bool CheckGiorno, ref string rsMess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		DateTime dateTime = new DateTime(anno, 1, 1);
		string text = "";
		string text2 = "";
		string text3 = "";
		object objRes = null;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			int giorniAnno = _GiorniAnno;
			int num = 1;
			while (true)
			{
				if (num <= giorniAnno)
				{
					bool flag = true;
					if (CheckGiorno)
					{
						text2 = "SELECT COUNT(*) FROM CALENDARIO WHERE DATA = " + DbConn.SQLFormatDate(modGeneral.eTipoData.Data, dateTime);
						fXRETURN = DbConn.DoSql(text2, ref objRes, ref rsMess);
						if (fXRETURN != 0)
						{
							fXRETURN2 = fXRETURN;
							break;
						}
						flag = Conversions.ToInteger(objRes) == 0;
					}
					if (flag)
					{
						text = ((!(((dateTime.DayOfWeek == DayOfWeek.Saturday) & _SabatoFestivo) | ((dateTime.DayOfWeek == DayOfWeek.Sunday) & _DomenicaFestivo))) ? "L" : "F");
						if (_Festivi.Contains(dateTime.ToString("dd/MM/yyyy")))
						{
							text = "F";
						}
						text3 += "INSERT INTO CALENDARIO (DATA, FLAG, UTEAGG, UTEINS) VALUES (";
						text3 = text3 + DbConn.SQLFormatDate(modGeneral.eTipoData.Data, dateTime) + ", ";
						text3 = text3 + DbConn.SQLFormatString(text) + ", 'DSI','DSI');";
					}
					dateTime = DateAndTime.DateAdd((DateInterval)4, 1.0, dateTime);
					num = checked(num + 1);
					continue;
				}
				if (Operators.CompareString(text3, "", false) != 0)
				{
					fXRETURN = DbConn.SqlExec(text3, ref rsMess);
					if (fXRETURN != 0)
					{
						fXRETURN2 = fXRETURN;
						break;
					}
				}
				fXRETURN2 = modGeneral.FXRETURN.OK;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, int Anno, ref string rsmess)
	{
		WriteDebugInfo writeDebugInfo = new WriteDebugInfo(objApiContext);
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			writeDebugInfo.ParametersIn.Add("Anno", Anno);
			fXRETURN = writeDebugInfo.Run(ref rsmess);
			fXRETURN2 = ((fXRETURN != 0) ? fXRETURN : modGeneral.FXRETURN.OK);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN2;
		}
		return result;
	}
}
