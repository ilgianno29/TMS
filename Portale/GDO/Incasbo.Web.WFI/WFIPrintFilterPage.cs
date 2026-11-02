using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIPrintFilterPage : WFIDialogPage
{
	protected string _NomRep;

	protected string _SelectedFormulaFixed;

	protected bool _AlmenoUno;

	protected string _ContextToHave;

	protected string _HumanReadableAnd;

	protected Dictionary<string, object> _ReportParams;

	public override string ResourceName => "SYSTEM." + base.SessionEnvironment.WebApplicationName.ToUpper() + ".FORMS." + Strings.UCase(Strings.Replace(PageName.ToUpper(), ".ASPX", "", 1, -1, (CompareMethod)0));

	public WFIPrintFilterPage()
	{
		_NomRep = "";
		_SelectedFormulaFixed = "";
		_AlmenoUno = false;
		_ContextToHave = "PRINTFILTER";
		_HumanReadableAnd = "e";
		_ReportParams = new Dictionary<string, object>();
	}

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboResourceManager iboResourceManager = new IboResourceManager();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_NomRep = ((Page)this).Request.QueryString["NomRep"].ToString();
			if (((Page)this).Request.QueryString["SelectedFormulaFixed"] != null)
			{
				_SelectedFormulaFixed = ((Page)this).Request.QueryString["SelectedFormulaFixed"].ToString();
			}
			if (((Page)this).Request.QueryString["AlmenoUno"] != null)
			{
				_AlmenoUno = Operators.CompareString(((Page)this).Request.QueryString["AlmenoUno"].ToString().ToUpper(), "S", false) == 0;
			}
			val = base.LoadPage(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_Context = _ContextToHave;
			_IsSessionVariablePersistent = true;
			base.TransactionManage = false;
			val = base.InitializedPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_ReturnToCallerAfterConfirm = false;
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_SessionVariable == null)
			{
				rsMess = TranslateMessage("XXX", "Il contesto della chiamata non è corretto(1). Chiamata non consentita.");
			}
			else if (!_SessionVariable.ContainsKey("CONTEXT"))
			{
				rsMess = TranslateMessage("XXX", "Il contesto della chiamata non è corretto(2). Chiamata non consentita.");
			}
			else
			{
				if (_objFunctionArguments == null)
				{
					_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
				}
				_objFunctionArguments.CallerPath = base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
				_objFunctionArguments.CallerQueryString = "";
				_objFunctionArguments.Context = _SessionVariable["CONTEXT"].ToString();
				if (_SessionVariable.ContainsKey("FORMMODE"))
				{
					_objFunctionArguments.Name = _SessionVariable["FORMMODE"].ToString();
				}
				if (Operators.CompareString(_objFunctionArguments.Context.ToUpper(), _Context.ToUpper(), false) != 0)
				{
					rsMess = TranslateMessage("XXX", "Il contesto della chiamata non è corretto(3). Chiamata non consentita.");
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
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN ContextGet(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Page)this).Request.QueryString["Returning"] != null && Operators.CompareString(((Page)this).Request.QueryString["Returning"].ToUpper(), "S", false) == 0)
			{
				_objFunctionArguments = (FunctionArguments)_SessionVariable["FunctionArgs"];
				goto IL_012a;
			}
			if (_SessionVariable["FunctionArgs"] != null)
			{
				_objFunctionArguments = (FunctionArguments)_SessionVariable["FunctionArgs"];
				goto IL_012a;
			}
			if (((Page)this).Session["FunctionArgs"] != null)
			{
				_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
				_SessionVariable.Remove("FunctionArgs");
				_SessionVariable.Add("FunctionArgs", _objFunctionArguments);
				goto IL_012a;
			}
			rsMess = TranslateMessage("XXX", "Errore nella lettura dei dati di funzione. Chiamata non consentita.");
			goto end_IL_0005;
			IL_012a:
			_objFormState = (Dictionary<string, Dictionary<string, object>>)_SessionVariable["FormState"];
			try
			{
				_Context = _objFunctionArguments.ObjectManager.ObjectManagerName;
				_Tabella = _objFunctionArguments.ObjectManager.ObjectTableName;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (!((Page)this).IsPostBack)
			{
				_ComboQueryCache = new ComboQueryCache();
				_SessionVariable.Add("ComboQueryCache", _ComboQueryCache);
				_ComboQueryCacheTop50 = new ComboQueryCache();
				_SessionVariable.Add("ComboQueryCacheTop50", _ComboQueryCacheTop50);
			}
			else
			{
				_ComboQueryCache = (ComboQueryCache)_SessionVariable["ComboQueryCache"];
				_ComboQueryCacheTop50 = (ComboQueryCache)_SessionVariable["ComboQueryCacheTop50"];
			}
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = Conferma(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN AssegnaWfiIdentity(Control Parent, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN Conferma(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsSelectionFormula = "";
		string rsHumanFilter = "";
		string text = "";
		string rsTopValue = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text2 = "SELECT * FROM WFI_TABREP WHERE NOMREP=" + base.DbConn.SQLFormatString(_NomRep);
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				string text3 = "PDF";
				string tabellaReport = "";
				if (dataTable.Rows.Count > 0)
				{
					text3 = dataTable.Rows[0]["Tipo"].ToString();
					tabellaReport = dataTable.Rows[0]["NomTab"].ToString();
				}
				val2 = GetFilter(tabellaReport, ref rsTopValue, ref rsSelectionFormula, ref rsHumanFilter, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					FunctionArguments functionArguments = new FunctionArguments("", "");
					functionArguments.Argomento2 = _NomRep;
					functionArguments.Argomento3 = text3.ToUpper();
					functionArguments.Argomento4 = rsSelectionFormula;
					functionArguments.Argomento5 = rsHumanFilter;
					functionArguments.Argomento7 = _ReportParams;
					((Page)this).Session.Add("FunctionArgsReportPage", (object)functionArguments);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					string sUrl = "~/WFI/Form/WFStandardReport.aspx";
					IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN GetFilter(string TabellaReport, ref string rsTopValue, ref string rsSelectionFormula, ref string rsHumanFilter, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Invalid comparison between Unknown and I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Invalid comparison between Unknown and I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			rsSelectionFormula = "";
			foreach (Control iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)this))
			{
				Control val2 = iIboWebComponentControl;
				IIboWebComponent val3 = (IIboWebComponent)val2;
				if (Operators.CompareString(val3.IncasTag, "<#TOPCLAUSE#>", false) == 0 && Operators.CompareString(rsTopValue, "", false) == 0 && Versioned.IsNumeric((object)val3.ObjValue.ToString()))
				{
					rsTopValue = val3.ObjValue.ToString();
				}
				if (Operators.CompareString(val3.FieldName, "", false) == 0 || Operators.CompareString(val3.IncasTag, "", false) == 0)
				{
					continue;
				}
				string[] array = Strings.Split(val3.IncasTag.ToString(), ";", -1, (CompareMethod)0);
				if (array.Count() > 0)
				{
					text3 = array[0];
					text4 = ((array.Count() <= 1) ? array[0] : array[1]);
				}
				if ((int)val3.FieldDataType == 0)
				{
					if (val3.ObjValue.ToString().Length > 0)
					{
						if (text.Length > 0)
						{
							text += " AND ";
						}
						if (text2.Length > 0)
						{
							text2 = text2 + " " + _HumanReadableAnd + " ";
						}
						text += text3.Replace("<#VALUE#>", base.DbConn.SQLFormatString(val3.ObjValue.ToString())).Replace("<#NO_SQL_VALUE#>", val3.ObjValue.ToString());
						text2 += text4.Replace("<#VALUE#>", base.DbConn.SQLFormatString(val3.ObjValue.ToString())).Replace("<#NO_SQL_VALUE#>", val3.ObjValue.ToString());
					}
				}
				else if ((int)val3.FieldDataType == 1)
				{
					if (val3.ObjValue.ToString().Length > 0)
					{
						if (text.Length > 0)
						{
							text += " AND ";
						}
						if (text2.Length > 0)
						{
							text2 = text2 + " " + _HumanReadableAnd + " ";
						}
						string text5 = text;
						string text6 = text3;
						DBConnection dbConn = base.DbConn;
						decimal num = Conversions.ToDecimal(val3.ObjValue);
						text = text5 + text6.Replace("<#VALUE#>", dbConn.SQLFormatNumber(ref num));
						text2 += text4.Replace("<#VALUE#>", val3.ObjValue.ToString());
					}
				}
				else if ((int)val3.FieldDataType == 2)
				{
					if (val3.ObjValue.ToString().Length != 0)
					{
						if (text.Length > 0)
						{
							text += " AND ";
						}
						if (text2.Length > 0)
						{
							text2 = text2 + " " + _HumanReadableAnd + " ";
						}
						DateTime dateTime = Conversions.ToDate(val3.ObjValue);
						text += text3.Replace("<#VALUE#>", "Date(" + DateAndTime.Year(dateTime) + "," + DateAndTime.Month(dateTime) + "," + DateAndTime.Day(dateTime) + ")");
						text2 += text4.Replace("<#VALUE#>", val3.ObjValue.ToString());
					}
				}
				else if ((int)val3.FieldDataType != 3)
				{
				}
			}
			if (Operators.CompareString(TabellaReport, "", false) != 0)
			{
				text = text.Replace("%RPT_VIEW%", TabellaReport);
			}
			if (Operators.CompareString(_SelectedFormulaFixed, "", false) != 0)
			{
				text = ((Operators.CompareString(text, "", false) == 0) ? _SelectedFormulaFixed : (text + " AND " + _SelectedFormulaFixed));
			}
			rsSelectionFormula = text;
			rsHumanFilter = text2;
			if (Operators.CompareString(rsTopValue, "0", false) == 0)
			{
				rsTopValue = "";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		bool flag = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				foreach (Control childControl in GetChildControls((Control)(object)this))
				{
					Control val3 = childControl;
					if (!(val3 is IboWebTextBox || val3 is IboDropDownList || val3 is IboWebDate || val3 is IboWebNumeric || val3 is IboWebComboTlk))
					{
						continue;
					}
					IIboWebComponent val4 = (IIboWebComponent)val3;
					text = Strings.Mid(val3.ID, 4);
					text2 = val4.Text.Trim();
					text3 = val4.FieldDescription;
					if (Operators.CompareString(text3, "", false) == 0)
					{
						text3 = val4.FieldName;
						if (Operators.CompareString(text3, "", false) == 0)
						{
							text3 = text;
						}
					}
					if (Operators.CompareString(text2, "", false) != 0)
					{
						flag = true;
						break;
					}
				}
				if (_AlmenoUno && !flag)
				{
					rsMess = TranslateMessage("XXX", "E' obbligatorio specificare il valore per almeno uno dei campi di filtro");
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}
}
