using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_AggiungiTransitPoint : AppAbstractApi
{
	protected string _TransitPoint;

	protected List<string> _ListOfUnibol;

	protected DataTable _dtSpedizioni;

	protected string _Trasportatore;

	protected string _IsFiliale;

	public Spedizione_AggiungiTransitPoint(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TransitPoint = "";
		_dtSpedizioni = null;
		_Trasportatore = "";
		_IsFiliale = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_TransitPoint = ((AppAbstractApi)this).ParametersIn["TransitPoint"].ToString();
			_ListOfUnibol = (List<string>)((AppAbstractApi)this).ParametersIn["ListOfUnibol"];
			val = CheckSpedizioni(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckTransitPoint(ref rsmess);
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
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Invalid comparison between Unknown and I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Invalid comparison between Unknown and I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			foreach (string item in _ListOfUnibol)
			{
				text = text + "UPDATE Spedizioni SET CORRISPONDENTE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TransitPoint) + ", ";
				text = ((Operators.CompareString(_IsFiliale, "S", false) != 0) ? (text + "TRASPORTATORE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore) + " ") : (text + "TRASPORTATORE = NULL "));
				text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ";";
				string RetQueryToApply = "";
				val = EventoSpedizione_AggiungiCorrispondente.RunProc(this._ApiContext, item, _TransitPoint, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val <= 0)
				{
					text += RetQueryToApply;
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_015a;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_015a;
			}
			val2 = val;
			goto end_IL_000b;
			IL_015a:
			StringCollection stringCollection = new StringCollection();
			foreach (string item2 in _ListOfUnibol)
			{
				DataRow[] array = _dtSpedizioni.Select("UNIBOL='" + item2 + "'");
				if (Operators.CompareString(array[0]["IdViaggio"].ToString(), "", false) == 0 || stringCollection.Contains(array[0]["IdViaggio"].ToString()))
				{
					continue;
				}
				string RetQueryToApply2 = "";
				val = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance.RunProc(this._ApiContext, array[0]["IdViaggio"].ToString(), ApplyQuery: false, ref RetQueryToApply2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(RetQueryToApply2, "", false) == 0)
					{
						goto IL_0261;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(RetQueryToApply2, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_0261;
					}
					val2 = val;
				}
				goto end_IL_000b;
				IL_0261:
				stringCollection.Add(array[0]["IdViaggio"].ToString());
			}
			val2 = (FXRETURN)0;
			end_IL_000b:;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, List<string> ListOfUnibol, string TransitPoint, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Spedizione_AggiungiTransitPoint spedizione_AggiungiTransitPoint = new Spedizione_AggiungiTransitPoint(objApiContext);
			((AppAbstractApi)spedizione_AggiungiTransitPoint).ParametersIn.Add("ListOfUnibol", ListOfUnibol);
			((AppAbstractApi)spedizione_AggiungiTransitPoint).ParametersIn.Add("TransitPoint", TransitPoint);
			val = ((AppAbstractApi)spedizione_AggiungiTransitPoint).Run(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
			result = val2;
		}
		return result;
	}

	protected FXRETURN CheckTransitPoint(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT ISFILIALE,CODICETRASPORTATORE FROM PCS WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TransitPoint);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il Transit Point con codice {0} non esiste", new string[1] { _TransitPoint });
			}
			else
			{
				_Trasportatore = rObjDataTable.Rows[0]["CODICETRASPORTATORE"].ToString();
				_IsFiliale = rObjDataTable.Rows[0]["ISFILIALE"].ToString();
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

	protected FXRETURN CheckSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_ListOfUnibol.Count <= 0)
			{
				goto IL_01b6;
			}
			string text2 = "";
			foreach (string item in _ListOfUnibol)
			{
				text2 = text2 + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ",";
			}
			text2 = Strings.Left(text2, checked(Strings.Len(text2) - 1));
			text = "SELECT Unibol,Stato,IdViaggio FROM Spedizioni WHERE Unibol IN (" + text2 + ")";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val <= 0)
			{
				foreach (string item2 in _ListOfUnibol)
				{
					DataRow[] array = _dtSpedizioni.Select("UNIBOL='" + item2 + "'");
					if (array.Count() == 0)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { item2 });
					}
					else
					{
						if (Conversions.ToInteger(array[0]["Stato"]) <= 30)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permetta l'associazione ad un corrispondente (Stato attuale della spedizione={1})", new string[2]
						{
							item2,
							array[0]["Stato"].ToString()
						});
					}
					goto end_IL_000b;
				}
				goto IL_01b6;
			}
			val2 = val;
			goto end_IL_000b;
			IL_01b6:
			val2 = (FXRETURN)0;
			end_IL_000b:;
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
