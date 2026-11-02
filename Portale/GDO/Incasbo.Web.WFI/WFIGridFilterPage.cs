using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIGridFilterPage : WFIDialogPage
{
	protected string _sNomRif;

	protected string _sCapt;

	protected bool _bAlmenoUno;

	protected string _MSGrid;

	protected string _TlkGrid;

	protected string _SelectedFormulaFixed;

	public override string ResourceName => "SYSTEM." + base.SessionEnvironment.WebApplicationName.ToUpper() + ".FORMS." + Strings.UCase(Strings.Replace(PageName.ToUpper(), ".ASPX", "", 1, -1, (CompareMethod)0));

	public WFIGridFilterPage()
	{
		_sNomRif = "";
		_sCapt = "";
		_bAlmenoUno = false;
		_MSGrid = "WFStandardGrid.aspx".ToUpper();
		_TlkGrid = "WFStandardGridTlk.aspx".ToUpper();
		_SelectedFormulaFixed = "";
	}

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboResourceManager iboResourceManager = new IboResourceManager();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_sNomRif = ((Page)this).Request.QueryString["NomRif"].ToString();
			if (((Page)this).Request.QueryString["Capt"] != null)
			{
				_sCapt = ((Page)this).Request.QueryString["Capt"].ToString();
			}
			else
			{
				_sCapt = "";
			}
			if (((Page)this).Request.QueryString["AlmenoUno"] != null)
			{
				_bAlmenoUno = Operators.CompareString(((Page)this).Request.QueryString["AlmenoUno"].ToString().ToUpper(), "S", false) == 0;
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
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_Context = "GRIDFILTER";
			_IsSessionVariablePersistent = true;
			val = base.InitializedPage(ref rsMess);
			_ReturnToCallerAfterConfirm = false;
			_objFunctionArguments.CallerPath = "";
			_objFunctionArguments.CallerQueryString = "";
			_SelectedFormulaFixed = _objFunctionArguments.Argomento3.ToString();
			if (_IsInIFrame | _IsAllreadyInIFrame)
			{
				_IsInIFrame = true;
			}
			val2 = (FXRETURN)0;
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
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsSelectionFormula = "";
		string rsHumanFilter = "";
		string text = "";
		string mSGrid = _MSGrid;
		string tlkGrid = _TlkGrid;
		string rsTopValue = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = GetFilter(ref rsTopValue, ref rsSelectionFormula, ref rsHumanFilter, ref rsMess);
			if ((int)val2 <= 0)
			{
				text = ((Operators.CompareString(_objFunctionArguments.Argomento1.ToString(), "TLK", false) != 0) ? ("~/WFI/Form/" + mSGrid + "?NomRif=" + _sNomRif) : ("~/WFI/Form/" + tlkGrid + "?NomRif=" + _sNomRif));
				if (rsSelectionFormula.Length > 0)
				{
					if (rsSelectionFormula.Length > 4000)
					{
						string text2 = "";
						text2 = ((Operators.CompareString(_objFunctionArguments.Argomento1.ToString(), "TLK", false) != 0) ? ("WFStandardGrid.aspx".ToUpper() + "." + _sNomRif.ToUpper()) : ("WFStandardGridTlk.aspx".ToUpper() + "." + _sNomRif.ToUpper()));
						base.SessionEnvironment.SessionVariables.Remove(text2);
						base.SessionEnvironment.SessionVariables.Add(text2, new IboDictionaryCollection<string, object>());
						base.SessionEnvironment.SessionVariables[text2]["WA"] = (object)rsSelectionFormula;
					}
					else
					{
						text = text + "&WA=" + HttpUtility.UrlEncode(rsSelectionFormula);
						text = text + "&DESC=" + HttpUtility.UrlEncode(rsHumanFilter);
					}
				}
				else
				{
					text = text + "&WA=" + rsSelectionFormula;
					text = text + "&DESC=" + rsHumanFilter;
				}
				if (Operators.CompareString(rsTopValue, "", false) != 0 && Versioned.IsNumeric((object)rsTopValue))
				{
					text = text + "&TOP=" + rsTopValue;
				}
				text = text + "&CAPT=" + _sCapt;
				if (_objFunctionArguments.Argomento2 != null)
				{
					NameValueCollection nameValueCollection = (NameValueCollection)_objFunctionArguments.Argomento2;
					if (Operators.CompareString(nameValueCollection["GridMode"] ?? "", "", false) != 0)
					{
						text = text + "&GridMode=" + (nameValueCollection["GridMode"] ?? "").ToUpper();
					}
					if (Operators.CompareString(nameValueCollection["IsInIFrameBodyClass"] ?? "", "", false) != 0)
					{
						text = string.Concat(text, "&IsInIFrameBodyClass=" + nameValueCollection["IsInIFrameBodyClass"]);
					}
				}
				text += "&Returning=True";
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref text);
				val = (FXRETURN)0;
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

	protected virtual FXRETURN GetFilter(ref string rsTopValue, ref string rsSelectionFormula, ref string rsHumanFilter, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Invalid comparison between Unknown and I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Invalid comparison between Unknown and I4
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
							text2 += " AND ";
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
							text2 += " AND ";
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
							text2 += " AND ";
						}
						text += text3.Replace("<#VALUE#>", base.DbConn.SQLFormatDate((eTipoData)1, Conversions.ToDate(val3.ObjValue)));
						text2 += text4.Replace("<#VALUE#>", val3.ObjValue.ToString());
					}
				}
				else if ((int)val3.FieldDataType != 3)
				{
				}
			}
			if (Operators.CompareString(_SelectedFormulaFixed, "", false) != 0)
			{
				text = ((Operators.CompareString(text, "", false) == 0) ? _SelectedFormulaFixed : ("(" + text + ") AND (" + _SelectedFormulaFixed + ")"));
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
				if (_bAlmenoUno && !flag)
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

	protected override FXRETURN BeforeAnnullaClick(ref string rsMess)
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
			val = base.BeforeAnnullaClick(ref rsMess);
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

	public override void ReturnFromIFrame(object objTag1)
	{
		if (objTag1 == null)
		{
			IframeInfo iframeInfo = base.SessionEnvironment.IframeInfoList.GetIFrameInfoByUrl(PageName);
			if (iframeInfo == null)
			{
				iframeInfo = base.SessionEnvironment.IframeInfoList[base.SessionEnvironment.IframeInfoList.Keys.ElementAtOrDefault(0)];
			}
			base.SessionEnvironment.IFrameObjTag = RuntimeHelpers.GetObjectValue(objTag1);
			iframeInfo.IFrameObjectReturn = RuntimeHelpers.GetObjectValue(base.SessionEnvironment.IFrameObjTag);
			iframeInfo.IFrameClosed = true;
		}
		else
		{
			base.ReturnFromIFrame(RuntimeHelpers.GetObjectValue(objTag1));
		}
	}
}
