using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI.ObjectManager;

public abstract class GenericObjectManager : AbstractObjectManager
{
	protected string _ObjectManagerName;

	protected string _RedirectTo;

	protected string _RedirectToIns;

	protected string _RedirectToMod;

	protected string _RedirectToDup;

	protected string _RedirectToDel;

	protected string _RedirectToVis;

	protected string _ObjectTableName;

	protected string _FilterPage;

	protected string _FilterPageParameters;

	protected string _Description;

	protected string _EntityName;

	protected string _Options;

	protected Hashtable _OptionsCollection;

	protected DataTable _dtObjectManagerConditions;

	public override string RedirectTo => FindFormDir(_RedirectTo);

	public override string RedirectToIns
	{
		get
		{
			if (Operators.CompareString(_RedirectToIns, "", false) != 0)
			{
				return FindFormDir(_RedirectToIns);
			}
			return "";
		}
	}

	public override string RedirectToMod
	{
		get
		{
			if (Operators.CompareString(_RedirectToMod, "", false) != 0)
			{
				return FindFormDir(_RedirectToMod);
			}
			return "";
		}
	}

	public override string RedirectToDel
	{
		get
		{
			if (Operators.CompareString(_RedirectToDel, "", false) != 0)
			{
				return FindFormDir(_RedirectToDel);
			}
			return "";
		}
	}

	public override string RedirectToDup
	{
		get
		{
			if (Operators.CompareString(_RedirectToDup, "", false) != 0)
			{
				return FindFormDir(_RedirectToDup);
			}
			return "";
		}
	}

	public override string RedirectToVis
	{
		get
		{
			if (Operators.CompareString(_RedirectToVis, "", false) != 0)
			{
				return FindFormDir(_RedirectToVis);
			}
			return "";
		}
	}

	public override string FilterPage => _FilterPage;

	public override string FilterPageParameters => _FilterPageParameters;

	public override string ObjectTableName => _ObjectTableName;

	public override string ObjectManagerName => _ObjectManagerName;

	public virtual string Description => _Description;

	public override string EntityName => _EntityName;

	protected GenericObjectManager()
	{
		_ObjectManagerName = "";
		_RedirectTo = "";
		_RedirectToIns = "";
		_RedirectToMod = "";
		_RedirectToDup = "";
		_RedirectToDel = "";
		_RedirectToVis = "";
		_ObjectTableName = "";
		_FilterPage = "";
		_FilterPageParameters = "";
		_Description = "";
		_EntityName = "";
		_Options = "";
		_OptionsCollection = new Hashtable();
		_dtObjectManagerConditions = null;
	}

	public override FXRETURN CallFunction(ref FunctionArguments robjFunctionArguments, IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		IboGridInfo objGridInfo = null;
		return CallFunction(ref objGridInfo, ref robjFunctionArguments, e, ref rsMess);
	}

	public override FXRETURN CallFunction(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Invalid comparison between Unknown and I4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Invalid comparison between Unknown and I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Invalid comparison between Unknown and I4
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Invalid comparison between Unknown and I4
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Invalid comparison between Unknown and I4
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Invalid comparison between Unknown and I4
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Invalid comparison between Unknown and I4
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Invalid comparison between Unknown and I4
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Invalid comparison between Unknown and I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Invalid comparison between Unknown and I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Invalid comparison between Unknown and I4
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Invalid comparison between Unknown and I4
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string sRedirect = "";
		Hashtable sRetColl = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = e.CommandName;
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			string text2;
			if (e.CommandName.ToUpper().StartsWith("GOTOWITHMSG"))
			{
				sRedirect = "~/WFI/Form/WFFunctionManager.aspx";
				val2 = StandardParser(e.CommandArguments, ref sRetColl, ref rsMess);
				if ((int)val2 <= 0)
				{
					robjFunctionArguments.Argomento1 = sRetColl["Func"].ToString();
					robjFunctionArguments.Argomento2 = "";
					robjFunctionArguments.Argomento3 = "";
					robjFunctionArguments.Argomento4 = "";
					robjFunctionArguments.Argomento5 = "N";
					BaseFunctions.IboResponseRedirect(ref _ObjCallStackHandler, ref sRedirect);
					goto IL_0c39;
				}
				val = val2;
			}
			else if (e.CommandName.ToUpper().StartsWith("PRNETI"))
			{
				val2 = PrnEtiParser(e.CommandArguments, robjFunctionArguments, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0c39;
				}
			}
			else if (e.CommandName.ToUpper().StartsWith("GOTO"))
			{
				if (e.CommandName.ToUpper().StartsWith("GOTO;M"))
				{
					if (robjFunctionArguments.Data.Count > 0)
					{
						if (robjFunctionArguments.Data.Item(0).FieldValuesCount >= 2)
						{
							goto IL_0247;
						}
						rsMess = TranslateMessage("XXX", "Selezionare almeno due record");
					}
					else
					{
						rsMess = TranslateMessage("XXX", "Selezionare almeno due record");
					}
				}
				else
				{
					if (!e.CommandName.ToUpper().StartsWith("GOTO;S") || robjFunctionArguments.Data.Count != 0)
					{
						goto IL_0247;
					}
					rsMess = TranslateMessage("XXX", "Selezionare un record");
				}
			}
			else if (e.CommandName.ToUpper().StartsWith("OPENDBPAGE"))
			{
				val2 = StandardParser(e.CommandArguments, ref sRetColl, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					sRedirect = sRetColl["Page"].ToString();
					sRedirect = sRedirect.Replace("%EQ%", "=").Replace("%eq%", "=").Replace("%Eq%", "=");
					string text = sRetColl["SelectionMode"].ToString();
					text2 = sRetColl["FormMode"].ToString().ToUpper();
					if (Operators.CompareString(text, "M", false) == 0)
					{
						if (robjFunctionArguments.Data.Count > 0)
						{
							if (robjFunctionArguments.Data.Item(0).FieldValuesCount >= 2)
							{
								goto IL_03fa;
							}
							rsMess = TranslateMessage("XXX", "Selezionare almeno due record");
						}
						else
						{
							rsMess = TranslateMessage("XXX", "Selezionare almeno due record");
						}
					}
					else
					{
						if (Operators.CompareString(text, "S", false) != 0 || robjFunctionArguments.Data.Count != 0)
						{
							goto IL_03fa;
						}
						rsMess = TranslateMessage("XXX", "Selezionare un record");
					}
				}
			}
			else if (e.CommandName.ToUpper().StartsWith("OPENDIALOGPAGE"))
			{
				val2 = StandardParser(e.CommandArguments, ref sRetColl, ref rsMess);
				if ((int)val2 <= 0)
				{
					sRedirect = sRetColl["Page"].ToString();
					sRedirect = sRedirect.Replace("%EQ%", "=").Replace("%eq%", "=").Replace("%Eq%", "=");
					string context = sRetColl["CONTEXT"].ToString();
					string modalita = sRetColl["MODALITA"].ToString();
					string value = "";
					string value2 = "";
					string value3 = "";
					if (sRetColl.Contains("PARAMS1"))
					{
						value = sRetColl["PARAMS1"].ToString();
					}
					if (sRetColl.Contains("PARAMS2"))
					{
						value2 = sRetColl["PARAMS2"].ToString();
					}
					if (sRetColl.Contains("PARAMS3"))
					{
						value3 = sRetColl["PARAMS3"].ToString();
					}
					bool flag = false;
					if (sRetColl.Contains("ISINIFRAME"))
					{
						flag = Operators.CompareString(sRetColl["ISINIFRAME"].ToString(), "S", false) == 0;
					}
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("PARAMS1", value);
					dictionary.Add("PARAMS2", value2);
					dictionary.Add("PARAMS3", value3);
					dictionary.Add("PARAMS_FUNCARGS", robjFunctionArguments);
					if (!flag)
					{
						((WFIPage)robjFunctionArguments.Parameters["CallerPage"]).OpenDialogPage(sRedirect, context, modalita, dictionary, ResetSessionVariables: true);
					}
					else
					{
						string iFrameTag = "";
						if (sRetColl.Contains("IFRAMETAG"))
						{
							iFrameTag = sRetColl["IFRAMETAG"].ToString();
						}
						string iFrameTitle = " ";
						if (sRetColl.Contains("IFRAMETITLE"))
						{
							iFrameTitle = sRetColl["IFRAMETITLE"].ToString();
						}
						string text3 = "";
						if (sRetColl.Contains("IFRAMEDIMENSION"))
						{
							text3 = sRetColl["IFRAMEDIMENSION"].ToString();
						}
						string iFrameDimensionCustomCssClass = "";
						if (sRetColl.Contains("IFRAMEDIMENSIONCUSTOMCSSCLASS"))
						{
							iFrameDimensionCustomCssClass = sRetColl["IFRAMEDIMENSIONCUSTOMCSSCLASS"].ToString();
						}
						string iframeBodyClass = "";
						if (sRetColl.Contains("IFRAMEBODYCLASS"))
						{
							iframeBodyClass = sRetColl["IFRAMEBODYCLASS"].ToString();
						}
						bool automaticVerticalResizing = false;
						if (sRetColl.Contains("AUTOMATICVERTICALRESIZING"))
						{
							automaticVerticalResizing = Operators.CompareString(sRetColl["AUTOMATICVERTICALRESIZING"].ToString(), "S", false) == 0;
						}
						WFIMaster.IFrameDimension frameDimension = default(WFIMaster.IFrameDimension);
						((WFIPage)robjFunctionArguments.Parameters["CallerPage"]).OpenDialogPageInIFrame(sRedirect, context, modalita, dictionary, ResetSessionVariables: true, iFrameTag, iFrameTitle, (WFIMaster.IFrameDimension)(object)modGeneral.String2Enum(frameDimension.GetType(), text3), iFrameDimensionCustomCssClass, iframeBodyClass, automaticVerticalResizing, ref rsMess);
					}
					goto IL_0c39;
				}
				val = val2;
			}
			else if (Operators.CompareString(e.CommandName.ToUpper(), "CALLFUNC", false) == 0)
			{
				sRedirect = "~/WFI/Form/WFFunctionManager.aspx";
				val2 = StandardParser(e.CommandArguments, ref sRetColl, ref rsMess);
				if ((int)val2 <= 0)
				{
					robjFunctionArguments.Argomento1 = sRetColl["Func"].ToString();
					robjFunctionArguments.Argomento2 = sRetColl["Msg1"].ToString();
					robjFunctionArguments.Argomento3 = sRetColl["Msg2"].ToString();
					robjFunctionArguments.Argomento4 = sRetColl["Descrizione"].ToString();
					robjFunctionArguments.Argomento5 = sRetColl["ChiediConferma"].ToString();
					BaseFunctions.IboResponseRedirect(ref _ObjCallStackHandler, ref sRedirect);
					goto IL_0c39;
				}
				val = val2;
			}
			else if ((Operators.CompareString(e.CommandName.ToUpper(), "NEWGRD", false) == 0) | (Operators.CompareString(e.CommandName.ToUpper(), "NEWGRDTLK", false) == 0))
			{
				val2 = NewGridParser(e.CommandName, e.CommandArguments, robjFunctionArguments, ref sRedirect, ref rsMess);
				if ((int)val2 <= 0)
				{
					BaseFunctions.IboResponseRedirect(ref _ObjCallStackHandler, ref sRedirect);
					goto IL_0c39;
				}
			}
			else if (Operators.CompareString(e.CommandName.ToUpper(), "SQLEXEC", false) == 0)
			{
				StringCollection SQLCommand = null;
				string WarningMessage = "";
				val2 = SqlExecParser(e.CommandName, e.CommandArguments, robjFunctionArguments, ref SQLCommand, ref WarningMessage, ref rsMess);
				if ((int)val2 <= 0)
				{
					StringEnumerator enumerator = SQLCommand.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						SessionEnvironment().DbConn.BeginTransaction();
						val2 = SessionEnvironment().DbConn.SqlExec(current, ref rsMess);
						if ((int)val2 <= 0)
						{
							SessionEnvironment().DbConn.CommitTransaction();
							if (Operators.CompareString(WarningMessage, "", false) != 0)
							{
								if (robjFunctionArguments.Parameters.ContainsKey("_warningMessage"))
								{
									robjFunctionArguments.Parameters["_warningMessage"] = TranslateMessage("XXX", WarningMessage);
								}
								else
								{
									robjFunctionArguments.Parameters.Add("_warningMessage", TranslateMessage("XXX", WarningMessage));
								}
							}
							if (robjFunctionArguments.Parameters.ContainsKey("_RefreshGrid"))
							{
								robjFunctionArguments.Parameters["_RefreshGrid"] = "S";
							}
							else
							{
								robjFunctionArguments.Parameters.Add("_RefreshGrid", "S");
							}
							continue;
						}
						SessionEnvironment().DbConn.RollbackTransaction();
						val = val2;
						goto end_IL_000e;
					}
					goto IL_0c39;
				}
				val = val2;
			}
			else
			{
				rsMess = TranslateMessage("XXX", "Funzione non disponibile");
			}
			goto end_IL_000e;
			IL_0247:
			sRedirect = e.CommandArguments;
			SessionEnvironment().PersistentSessionVariables["ResetSessionVariableForActualPage"] = "S";
			sRedirect = FindFormDir(sRedirect);
			BaseFunctions.IboResponseRedirect(ref _ObjCallStackHandler, ref sRedirect);
			goto IL_0c39;
			IL_03fa:
			switch (text2)
			{
			case "MOD":
			{
				string redirectToMod = _RedirectToMod;
				_RedirectToMod = sRedirect;
				val = Modifica(ref robjFunctionArguments, ref rsMess);
				_RedirectToMod = redirectToMod;
				if ((int)val <= 0)
				{
					break;
				}
				val2 = val;
				goto end_IL_000e;
			}
			case "INSMOD":
			{
				string redirectToMod2 = _RedirectToMod;
				_RedirectToMod = sRedirect;
				robjFunctionArguments.Name = "INSERIMENTO_O_MODIFICA";
				val = Modifica(ref robjFunctionArguments, ref rsMess);
				_RedirectToMod = redirectToMod2;
				if ((int)val <= 0)
				{
					break;
				}
				val2 = val;
				goto end_IL_000e;
			}
			case "INS":
			{
				string redirectToIns = _RedirectToIns;
				_RedirectToIns = sRedirect;
				val = Inserisci(ref robjFunctionArguments, ref rsMess);
				_RedirectToIns = redirectToIns;
				if ((int)val <= 0)
				{
					break;
				}
				val2 = val;
				goto end_IL_000e;
			}
			case "DUP":
			{
				string redirectToDup = _RedirectToDup;
				_RedirectToDup = sRedirect;
				val = Duplica(ref robjFunctionArguments, ref rsMess);
				_RedirectToDup = redirectToDup;
				if ((int)val <= 0)
				{
					break;
				}
				val2 = val;
				goto end_IL_000e;
			}
			case "DEL":
			{
				string redirectToDel = _RedirectToDel;
				_RedirectToDel = sRedirect;
				val = Cancella(ref robjFunctionArguments, ref rsMess);
				_RedirectToDel = redirectToDel;
				if ((int)val <= 0)
				{
					break;
				}
				val2 = val;
				goto end_IL_000e;
			}
			case "VIS":
			{
				string redirectToVis = _RedirectToVis;
				_RedirectToVis = sRedirect;
				val = Visualizza(ref robjFunctionArguments, ref rsMess);
				_RedirectToVis = redirectToVis;
				if ((int)val <= 0)
				{
					break;
				}
				val2 = val;
				goto end_IL_000e;
			}
			}
			goto IL_0c39;
			IL_0c39:
			val = (FXRETURN)0;
			end_IL_000e:;
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

	protected virtual IboSessionEnvironment SessionEnvironment()
	{
		return (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
	}

	protected FXRETURN NewGridParser(string sComando, string sComandoArgomenti, FunctionArguments robjFunctionArguments, ref string sRedirect, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		Hashtable sRetColl = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			DataRow[] array = SessionEnvironment().LastGridDataTable.Select("1=1 " + robjFunctionArguments.Data.GetFirstElementSqlWhere());
			if (array.Count() > 0)
			{
				val2 = StandardParser(sComandoArgomenti, ref sRetColl, ref rsmess);
				if ((int)val2 <= 0)
				{
					string text2 = "";
					sRedirect = "~/WFI/Form/<%GRIDNAME%>?GridMode=DETAILS&NomRif=" + sRetColl["NomRif"].ToString();
					if (Operators.CompareString(sComando.ToUpper(), "NEWGRDTLK", false) == 0)
					{
						sRedirect = sRedirect.Replace("<%GRIDNAME%>", "WFStandardGridTlk.aspx");
						text2 = "WFStandardGridTlk.aspx." + sRetColl["NomRif"].ToString();
						text2 = text2.ToUpper();
					}
					else
					{
						sRedirect = sRedirect.Replace("<%GRIDNAME%>", "WFStandardGrid.aspx");
						text2 = "WFStandardGrid.aspx." + sRetColl["NomRif"].ToString();
						text2 = text2.ToUpper();
					}
					SessionEnvironment().SessionVariables.Remove(text2);
					SessionEnvironment().SessionVariables.Add(text2, new IboDictionaryCollection<string, object>());
					SessionEnvironment().SessionVariables[text2].Add("PageToReturn", "");
					if (sRetColl.ContainsKey("Filtro"))
					{
						text = sRetColl["Filtro"].ToString();
						text = Strings.Replace(text, "%USER%", SessionEnvironment().WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%GROUP%", SessionEnvironment().WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%FILIALE%", SessionEnvironment().Filiale, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%EQ%", "=", 1, -1, (CompareMethod)0);
						sRedirect = sRedirect + "&WA=" + text;
					}
					if (sRetColl.ContainsKey("FiltroHR") | sRetColl.ContainsKey("Filtro"))
					{
						try
						{
							text = sRetColl["FiltroHR"].ToString();
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(text, "", false) == 0)
						{
							try
							{
								text = sRetColl["Filtro"].ToString();
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.ClearProjectError();
							}
						}
						text = Strings.Replace(text, "%USER%", SessionEnvironment().WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%GROUP%", SessionEnvironment().WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%FILIALE%", SessionEnvironment().Filiale, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%EQ%", "=", 1, -1, (CompareMethod)0);
						sRedirect = sRedirect + "&DESC=" + text;
					}
					if (sRetColl.ContainsKey("Caption"))
					{
						text = sRetColl["Caption"].ToString();
						text = Strings.Replace(text, "%USER%", SessionEnvironment().WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%GROUP%", SessionEnvironment().WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%FILIALE%", SessionEnvironment().Filiale, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%EQ%", "=", 1, -1, (CompareMethod)0);
						sRedirect = sRedirect + "&CAPT=" + text;
					}
					if (sRetColl.ContainsKey("ForceResetFilter"))
					{
						text = sRetColl["ForceResetFilter"].ToString();
						if (Operators.CompareString(text, "", false) != 0)
						{
							sRedirect = sRedirect + "&ForceResetFilter=" + text;
						}
					}
					checked
					{
						int num = SessionEnvironment().LastGridDataTable.Columns.Count - 1;
						int num2 = 0;
						while (true)
						{
							if (num2 <= num)
							{
								if (robjFunctionArguments.Data.Count == 0)
								{
									rsmess = TranslateMessage("XXX", "Nessun elemento selezionato");
									break;
								}
								if ((object)array[0][num2].GetType() == typeof(DateTime))
								{
									sRedirect = Strings.Replace(sRedirect, "<%" + SessionEnvironment().LastGridDataTable.Columns[num2].ColumnName + "%>", _ObjDbMain.SQLFormatDate((eTipoData)2, Conversions.ToDate(array[0][num2])), 1, -1, (CompareMethod)1);
								}
								else
								{
									sRedirect = Strings.Replace(sRedirect, "<%" + SessionEnvironment().LastGridDataTable.Columns[num2].ColumnName + "%>", _ObjDbMain.SQLFormatString(array[0][num2].ToString()), 1, -1, (CompareMethod)1);
								}
								num2++;
								continue;
							}
							sRedirect = Strings.Replace(sRedirect, "%", "%25", 1, -1, (CompareMethod)0);
							val = (FXRETURN)0;
							break;
						}
					}
				}
			}
			else
			{
				rsmess = TranslateMessage("XXX", "Errore in fase di individuazione del record corrente");
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN PrnEtiParser(string sComando, FunctionArguments robjFunctionArguments, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Invalid comparison between Unknown and I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		Hashtable sRetColl = null;
		string text4 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
			DataRow[] array = iboSessionEnvironment.LastGridDataTable.Select("1=1 " + robjFunctionArguments.Data.GetAllElementSqlWhere());
			if (array.Count() > 0)
			{
				val2 = StandardParser(sComando, ref sRetColl, ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					text4 = sRetColl["NomEti"].ToString();
					if (sRetColl.ContainsKey("Filtro"))
					{
						text = sRetColl["Filtro"].ToString();
						text = Strings.Replace(text, "%USER%", iboSessionEnvironment.WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%GROUP%", iboSessionEnvironment.WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%ORGANIZZAZIONE%", iboSessionEnvironment.WebUser.WebUserInfo.Organizzazione, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%FILIALE%", iboSessionEnvironment.Filiale, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%EQ%", "=", 1, -1, (CompareMethod)0);
					}
					text3 = "";
					DataRow[] array2 = array;
					checked
					{
						foreach (DataRow dataRow in array2)
						{
							text2 = text;
							int num = iboSessionEnvironment.LastGridDataTable.Columns.Count - 1;
							for (int j = 0; j <= num; j++)
							{
								text2 = (((object)dataRow[j].GetType() != typeof(DateTime)) ? Strings.Replace(text2, "<%" + iboSessionEnvironment.LastGridDataTable.Columns[j].ColumnName + "%>", _ObjDbMain.SQLFormatString(dataRow[j].ToString()), 1, -1, (CompareMethod)1) : Strings.Replace(text2, "<%" + iboSessionEnvironment.LastGridDataTable.Columns[j].ColumnName + "%>", _ObjDbMain.SQLFormatDate((eTipoData)2, Conversions.ToDate(dataRow[j])), 1, -1, (CompareMethod)1));
							}
							if (Operators.CompareString(text3, "", false) != 0)
							{
								text3 += " OR ";
							}
							text3 = text3 + " (" + text2 + ") ";
						}
						val2 = ((WFIPage)robjFunctionArguments.Parameters["CallerPage"]).StampaEtichetta(text4, text3, ref rsmess);
					}
					val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
				}
			}
			else
			{
				rsmess = TranslateMessage("XXX", "Errore in fase di individuazione del record corrente");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN SqlExecParser(string sComando, string sComandoArgomenti, FunctionArguments robjFunctionArguments, ref StringCollection SQLCommand, ref string WarningMessage, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		Hashtable sRetColl = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			WarningMessage = "";
			SQLCommand = new StringCollection();
			DataRow[] array = SessionEnvironment().LastGridDataTable.Select("1=1 " + robjFunctionArguments.Data.GetAllElementSqlWhereForDatatable());
			DataRow[] array2 = array;
			int num = 0;
			while (true)
			{
				if (num < array2.Length)
				{
					DataRow dataRow = array2[num];
					string text = "";
					val2 = StandardParser(sComandoArgomenti, ref sRetColl, ref rsmess);
					if ((int)val2 > 0)
					{
						break;
					}
					if (sRetColl.ContainsKey("SQL"))
					{
						text = sRetColl["SQL"].ToString();
						text = Strings.Replace(text, "%USER%", SessionEnvironment().WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%GROUP%", SessionEnvironment().WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%FILIALE%", SessionEnvironment().Filiale, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%EQ%", "=", 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%eq%", "=", 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "%;%", ";", 1, -1, (CompareMethod)0);
					}
					if (sRetColl.ContainsKey("WARNING"))
					{
						string text2 = "";
						text2 = sRetColl["WARNING"].ToString();
						WarningMessage = text2;
					}
					checked
					{
						int num2 = SessionEnvironment().LastGridDataTable.Columns.Count - 1;
						int num3 = 0;
						while (true)
						{
							if (num3 <= num2)
							{
								if (robjFunctionArguments.Data.Count == 0)
								{
									rsmess = TranslateMessage("XXX", "Nessun elemento selezionato");
									goto end_IL_02d4;
								}
								text = (((object)dataRow[num3].GetType() != typeof(DateTime)) ? Strings.Replace(text, "<%" + SessionEnvironment().LastGridDataTable.Columns[num3].ColumnName + "%>", _ObjDbMain.SQLFormatString(dataRow[num3].ToString()), 1, -1, (CompareMethod)1) : Strings.Replace(text, "<%" + SessionEnvironment().LastGridDataTable.Columns[num3].ColumnName + "%>", _ObjDbMain.SQLFormatDate((eTipoData)2, Conversions.ToDate(dataRow[num3])), 1, -1, (CompareMethod)1));
								num3++;
								continue;
							}
							if (Operators.CompareString(text, "", false) != 0)
							{
								SQLCommand.Add(text);
							}
							num++;
							break;
						}
						continue;
					}
				}
				val = (FXRETURN)0;
				break;
				continue;
				end_IL_02d4:
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN StandardParser(string sComando, ref Hashtable sRetColl, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		Hashtable hashtable = new Hashtable(StringComparer.InvariantCultureIgnoreCase);
		FXRETURN result;
		try
		{
			string[] array = Strings.Split(sComando, ";", -1, (CompareMethod)0);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					string[] array3 = Strings.Split(text, "=", -1, (CompareMethod)0);
					hashtable.Add(array3[0], array3[1]);
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			rsMess = TranslateMessage("Errore in fase di parsing: {0}", rsMess);
			hashtable = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			sRetColl = hashtable;
			result = val;
		}
		return result;
	}

	public override FXRETURN Cancella(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (robjFunctionArguments.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Dati insufficienti al completamento dell'operazione.");
			}
			else if (Operators.CompareString(_ObjectTableName, "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Tabella di riferimento non identificata per le operazioni di cancellazione.");
			}
			else
			{
				robjFunctionArguments.Context = _ObjectManagerName;
				robjFunctionArguments.Name = "CANCELLAZIONE";
				robjFunctionArguments.ObjectManager = this;
				HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
				string sUrl = RedirectToDel;
				if (Operators.CompareString(sUrl, "", false) != 0)
				{
					robjFunctionArguments.Target = sUrl;
					BaseFunctions.IboResponseRedirect(ref _ObjCallStackHandler, ref sUrl);
				}
				else
				{
					text = "DELETE FROM " + _ObjectTableName;
					text += " WHERE ";
					int fieldValuesCount = robjFunctionArguments.Data[0].FieldValuesCount;
					int count = robjFunctionArguments.Data.Count;
					int num = default(int);
					while (true)
					{
						checked
						{
							if (num < fieldValuesCount)
							{
								if (num > 0)
								{
									text += " OR ";
								}
								int num2 = 0;
								while (true)
								{
									if (num2 >= count)
									{
										num++;
										break;
									}
									if (num2 > 0)
									{
										text += " AND ";
									}
									text = text + robjFunctionArguments.Data[num2].FieldName + " = ";
									switch (robjFunctionArguments.Data[num2].FieldType)
									{
									case "String":
										text += _ObjDbMain.SQLFormatString(robjFunctionArguments.Data[num2].get_FieldValues(num).ToString());
										goto IL_03b5;
									case "Int16":
									case "Int32":
									case "Int64":
									case "Numeric":
									case "Decimal":
									case "Single":
									{
										string text2 = text;
										DBConnection objDbMain = _ObjDbMain;
										string text3 = robjFunctionArguments.Data[num2].get_FieldValues(num).ToString();
										text = text2 + objDbMain.SQLFormatNumber(ref text3);
										goto IL_03b5;
									}
									case "DateTime":
										text += _ObjDbMain.SQLFormatDate((eTipoData)2, robjFunctionArguments.Data[num2].get_FieldValues(num).ToString());
										goto IL_03b5;
									default:
										rsMess = TranslateMessage("XXX", "Tipo dato {0} non gestito per la colonna {1}.", robjFunctionArguments.Data[num2].FieldType, robjFunctionArguments.Data[num2].FieldName);
										break;
									}
									goto end_IL_0009;
									IL_03b5:
									num2++;
								}
								continue;
							}
						}
						if ((int)_ObjDbMain.SqlExec(text, ref rsMess) <= 0)
						{
							break;
						}
						goto end_IL_0009;
					}
				}
				val = (FXRETURN)0;
			}
			end_IL_0009:;
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

	public virtual FXRETURN GetSqlFilterFromFunctionArguments(ref FunctionArguments robjFunctionArguments, ref string rsSqlFilter, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				rsSqlFilter = "";
				if (robjFunctionArguments.Data.Count == 0)
				{
					val = (FXRETURN)0;
				}
				else
				{
					int fieldValuesCount = robjFunctionArguments.Data[0].FieldValuesCount;
					int count = robjFunctionArguments.Data.Count;
					int i = default(int);
					for (; i < fieldValuesCount; i++)
					{
						if (i > 0)
						{
							text += " OR ";
						}
						for (int j = 0; j < count; j++)
						{
							if (j > 0)
							{
								text += " AND ";
							}
							text = text + robjFunctionArguments.Data[j].FieldName + " = ";
							switch (robjFunctionArguments.Data[j].FieldType)
							{
							case "String":
								text += _ObjDbMain.SQLFormatString(robjFunctionArguments.Data[j].get_FieldValues(i).ToString());
								break;
							case "Int16":
							case "Int32":
							case "Int64":
							case "Numeric":
							case "Decimal":
							case "Single":
							{
								string text2 = text;
								DBConnection objDbMain = _ObjDbMain;
								string text3 = robjFunctionArguments.Data[j].get_FieldValues(i).ToString();
								text = text2 + objDbMain.SQLFormatNumber(ref text3);
								break;
							}
							case "DateTime":
								text += _ObjDbMain.SQLFormatDate((eTipoData)2, robjFunctionArguments.Data[j].get_FieldValues(i).ToString());
								break;
							default:
								text += _ObjDbMain.SQLFormatString(robjFunctionArguments.Data[j].get_FieldValues(i).ToString());
								break;
							}
						}
					}
					rsSqlFilter = text;
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
	}

	public override FXRETURN Duplica(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		IboGridInfo objGridInfo = null;
		return Duplica(ref objGridInfo, ref robjFunctionArguments, ref rsMess);
	}

	public override FXRETURN Duplica(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Invalid comparison between Unknown and I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = "DUPLICAZIONE";
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (_OptionsCollection.Count > 0)
			{
				if (_OptionsCollection.ContainsKey("OpenInIFrame"))
				{
					robjFunctionArguments.OpenInIFrame = Operators.CompareString(_OptionsCollection["OpenInIFrame"].ToString(), "S", false) == 0;
				}
				if (_OptionsCollection.ContainsKey("IFrameTitle"))
				{
					robjFunctionArguments.Argomento1 = _OptionsCollection["IFrameTitle"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimension"))
				{
					robjFunctionArguments.Argomento2 = _OptionsCollection["IFrameDimension"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimensionCustomCssClass"))
				{
					robjFunctionArguments.Argomento3 = _OptionsCollection["IFrameDimensionCustomCssClass"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IsInIFrameBodyClass"))
				{
					robjFunctionArguments.Argomento4 = _OptionsCollection["IsInIFrameBodyClass"].ToString();
				}
			}
			string RedirectToTmp = "";
			if (_dtObjectManagerConditions != null && _dtObjectManagerConditions.Rows.Count > 0)
			{
				foreach (DataRow row in _dtObjectManagerConditions.Rows)
				{
					string text = "1=1 " + robjFunctionArguments.Data.GetFirstElementSqlWhereForDatatable() + " ";
					text = text + "AND " + row["Condition"].ToString();
					DataRow[] source = objGridInfo.GridConfig.LastDataTableSource.Select(text);
					if (source.Count() > 0)
					{
						string redirectToDup = _RedirectToDup;
						_RedirectToDup = ((Operators.CompareString(row["Redirect_To_Dup"].ToString(), "", false) != 0) ? row["Redirect_To_Dup"].ToString() : row["Redirect_To"].ToString());
						RedirectToTmp = RedirectToDup;
						_RedirectToDup = redirectToDup;
						break;
					}
				}
			}
			if (Operators.CompareString(RedirectToTmp, "", false) == 0)
			{
				RedirectToTmp = RedirectToDup;
				if (Operators.CompareString(RedirectToTmp, "", false) == 0)
				{
					RedirectToTmp = RedirectTo;
				}
			}
			val2 = GestisciRedirect(ref RedirectToTmp, ref objGridInfo, ref robjFunctionArguments, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	public override FXRETURN Inserisci(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		IboGridInfo objGridInfo = null;
		return Inserisci(ref objGridInfo, ref robjFunctionArguments, ref rsMess);
	}

	public override FXRETURN Inserisci(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = "INSERIMENTO";
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (_OptionsCollection.Count > 0)
			{
				if (_OptionsCollection.ContainsKey("OpenInIFrame"))
				{
					robjFunctionArguments.OpenInIFrame = Operators.CompareString(_OptionsCollection["OpenInIFrame"].ToString(), "S", false) == 0;
				}
				if (_OptionsCollection.ContainsKey("IFrameTitle"))
				{
					robjFunctionArguments.Argomento1 = _OptionsCollection["IFrameTitle"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimension"))
				{
					robjFunctionArguments.Argomento2 = _OptionsCollection["IFrameDimension"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimensionCustomCssClass"))
				{
					robjFunctionArguments.Argomento3 = _OptionsCollection["IFrameDimensionCustomCssClass"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IsInIFrameBodyClass"))
				{
					robjFunctionArguments.Argomento4 = _OptionsCollection["IsInIFrameBodyClass"].ToString();
				}
			}
			string RedirectToTmp = RedirectToIns;
			if (Operators.CompareString(RedirectToTmp, "", false) == 0)
			{
				RedirectToTmp = RedirectTo;
			}
			val2 = GestisciRedirect(ref RedirectToTmp, ref objGridInfo, ref robjFunctionArguments, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	public override FXRETURN Modifica(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		IboGridInfo objGridInfo = null;
		return Modifica(ref objGridInfo, ref robjFunctionArguments, ref rsMess);
	}

	public override FXRETURN Modifica(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Invalid comparison between Unknown and I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			if (Operators.CompareString(robjFunctionArguments.Name, "INSERIMENTO_O_MODIFICA", false) != 0)
			{
				robjFunctionArguments.Name = "MODIFICA";
			}
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (_OptionsCollection.Count > 0)
			{
				if (_OptionsCollection.ContainsKey("OpenInIFrame"))
				{
					robjFunctionArguments.OpenInIFrame = Operators.CompareString(_OptionsCollection["OpenInIFrame"].ToString(), "S", false) == 0;
				}
				if (_OptionsCollection.ContainsKey("IFrameTitle"))
				{
					robjFunctionArguments.Argomento1 = _OptionsCollection["IFrameTitle"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimension"))
				{
					robjFunctionArguments.Argomento2 = _OptionsCollection["IFrameDimension"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimensionCustomCssClass"))
				{
					robjFunctionArguments.Argomento3 = _OptionsCollection["IFrameDimensionCustomCssClass"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IsInIFrameBodyClass"))
				{
					robjFunctionArguments.Argomento4 = _OptionsCollection["IsInIFrameBodyClass"].ToString();
				}
			}
			string RedirectToTmp = "";
			if (_dtObjectManagerConditions != null && _dtObjectManagerConditions.Rows.Count > 0)
			{
				foreach (DataRow row in _dtObjectManagerConditions.Rows)
				{
					string text = "1=1 " + robjFunctionArguments.Data.GetFirstElementSqlWhereForDatatable() + " ";
					text = text + "AND " + row["Condition"].ToString();
					DataRow[] source = objGridInfo.GridConfig.LastDataTableSource.Select(text);
					if (source.Count() > 0)
					{
						string redirectToMod = _RedirectToMod;
						_RedirectToMod = ((Operators.CompareString(row["Redirect_To_Mod"].ToString(), "", false) != 0) ? row["Redirect_To_Mod"].ToString() : row["Redirect_To"].ToString());
						RedirectToTmp = RedirectToMod;
						_RedirectToMod = redirectToMod;
						break;
					}
				}
			}
			if (Operators.CompareString(RedirectToTmp, "", false) == 0)
			{
				RedirectToTmp = RedirectToMod;
				if (Operators.CompareString(RedirectToTmp, "", false) == 0)
				{
					RedirectToTmp = RedirectTo;
				}
			}
			val2 = GestisciRedirect(ref RedirectToTmp, ref objGridInfo, ref robjFunctionArguments, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected FXRETURN GestisciRedirect(ref string RedirectToTmp, ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(RedirectToTmp, "", false) == 0)
			{
				RedirectToTmp = RedirectToMod;
				if (Operators.CompareString(RedirectToTmp, "", false) == 0)
				{
					RedirectToTmp = RedirectTo;
				}
			}
			if (Operators.CompareString(RedirectToTmp, "", false) != 0)
			{
				if (!robjFunctionArguments.OpenInIFrame)
				{
					robjFunctionArguments.Target = RedirectToTmp;
					BaseFunctions.IboResponseRedirect(ref _ObjCallStackHandler, ref RedirectToTmp);
				}
				else
				{
					if (Strings.InStr(RedirectToTmp, "?", (CompareMethod)0) > 0)
					{
						RedirectToTmp += "&IsInIFrame=S";
					}
					else
					{
						RedirectToTmp += "?IsInIFrame=S";
					}
					RedirectToTmp = Strings.Replace(RedirectToTmp, "~/", ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).AppApplicationRootUrl, 1, -1, (CompareMethod)0);
					string iFrameTitle = "";
					if (robjFunctionArguments.Argomento1 != null)
					{
						iFrameTitle = robjFunctionArguments.Argomento1.ToString();
						robjFunctionArguments.Argomento1 = null;
					}
					WFIMaster.IFrameDimension iFrameDimension = WFIMaster.IFrameDimension.Standard;
					if (robjFunctionArguments.Argomento2 != null)
					{
						iFrameDimension = (((object)robjFunctionArguments.Argomento2.GetType() != typeof(WFIMaster.IFrameDimension)) ? ((WFIMaster.IFrameDimension)Enum.Parse(typeof(WFIMaster.IFrameDimension), robjFunctionArguments.Argomento2.ToString())) : ((WFIMaster.IFrameDimension)robjFunctionArguments.Argomento2));
						robjFunctionArguments.Argomento2 = null;
					}
					string iFrameDimensionCustomCssClass = "";
					if (robjFunctionArguments.Argomento3 != null)
					{
						if (Operators.CompareString(robjFunctionArguments.Argomento3.ToString(), "", false) != 0)
						{
							iFrameDimensionCustomCssClass = robjFunctionArguments.Argomento3.ToString();
						}
						robjFunctionArguments.Argomento3 = null;
					}
					if (robjFunctionArguments.Argomento4 != null && Operators.CompareString(robjFunctionArguments.Argomento4.ToString(), "", false) != 0)
					{
						RedirectToTmp = RedirectToTmp + "&IsInIFrameBodyClass=" + robjFunctionArguments.Argomento4.ToString();
					}
					IframeInfo iframeInfo = new IframeInfo();
					iframeInfo.IFrameUrl = RedirectToTmp;
					iframeInfo.IFrameTitle = iFrameTitle;
					iframeInfo.IFrameDimension = iFrameDimension;
					iframeInfo.IFrameDimensionCustomCssClass = iFrameDimensionCustomCssClass;
					iframeInfo.AutomaticVerticalResizing = true;
					iframeInfo.Draggable = false;
					if (_OptionsCollection.ContainsKey("IFrameDraggable"))
					{
						iframeInfo.Draggable = Operators.CompareString(_OptionsCollection["IFrameDraggable"].ToString().ToUpper(), "S", false) == 0;
					}
					iframeInfo.IFrameTag = robjFunctionArguments.IFrameTag;
					if (Operators.CompareString(iframeInfo.IFrameTag, "", false) == 0)
					{
						iframeInfo.IFrameTag = robjFunctionArguments.Name;
					}
					iframeInfo.IFrameAlwaysRaiseCloseEvent = true;
					try
					{
						iframeInfo.IFrameCaller = robjFunctionArguments.WFIPage.EntryPoint;
						robjFunctionArguments.WFIPage.OpenIframe(iframeInfo);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						rsMess = "Errore interno dell'object Manager in fase di apertura dell'IFrame. Probabilmente non è stata passata la pagina WFI all'object Manager stesso.";
						ProjectData.ClearProjectError();
						goto end_IL_0003;
					}
					robjFunctionArguments.WFIPage = null;
				}
			}
			val = (FXRETURN)0;
			end_IL_0003:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	public override FXRETURN Stampa(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (robjFunctionArguments.Argomento2.ToString().ToLower().EndsWith(".rpt"))
			{
				val2 = StampaCRW(ref robjFunctionArguments, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
			else
			{
				rsMess = "Formato di stampa non riconosciuto";
				val = (FXRETURN)18;
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

	protected virtual FXRETURN StampaCRW(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			ref IboAppCallStackHandling objCallStackHandler = ref _ObjCallStackHandler;
			string sUrl = "~/WFI/Form/WFStandardReport.aspx";
			BaseFunctions.IboResponseRedirect(ref objCallStackHandler, ref sUrl);
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

	public override FXRETURN Visualizza(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		IboGridInfo objGridInfo = null;
		return Visualizza(ref objGridInfo, ref robjFunctionArguments, ref rsMess);
	}

	public override FXRETURN Visualizza(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Invalid comparison between Unknown and I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = "VISUALIZZAZIONE";
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (_OptionsCollection.Count > 0)
			{
				if (_OptionsCollection.ContainsKey("OpenInIFrame"))
				{
					robjFunctionArguments.OpenInIFrame = Operators.CompareString(_OptionsCollection["OpenInIFrame"].ToString(), "S", false) == 0;
				}
				if (_OptionsCollection.ContainsKey("IFrameTitle"))
				{
					robjFunctionArguments.Argomento1 = _OptionsCollection["IFrameTitle"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimension"))
				{
					robjFunctionArguments.Argomento2 = _OptionsCollection["IFrameDimension"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IFrameDimensionCustomCssClass"))
				{
					robjFunctionArguments.Argomento3 = _OptionsCollection["IFrameDimensionCustomCssClass"].ToString();
				}
				if (_OptionsCollection.ContainsKey("IsInIFrameBodyClass"))
				{
					robjFunctionArguments.Argomento4 = _OptionsCollection["IsInIFrameBodyClass"].ToString();
				}
			}
			string RedirectToTmp = "";
			if (_dtObjectManagerConditions != null && _dtObjectManagerConditions.Rows.Count > 0)
			{
				foreach (DataRow row in _dtObjectManagerConditions.Rows)
				{
					string text = "1=1 " + robjFunctionArguments.Data.GetFirstElementSqlWhereForDatatable() + " ";
					text = text + "AND " + row["Condition"].ToString();
					DataRow[] source = objGridInfo.GridConfig.LastDataTableSource.Select(text);
					if (source.Count() > 0)
					{
						string redirectToVis = _RedirectToVis;
						_RedirectToVis = ((Operators.CompareString(row["Redirect_To_Vis"].ToString(), "", false) != 0) ? row["Redirect_To_Vis"].ToString() : row["Redirect_To"].ToString());
						RedirectToTmp = RedirectToVis;
						_RedirectToVis = redirectToVis;
						break;
					}
				}
			}
			if (Operators.CompareString(RedirectToTmp, "", false) == 0)
			{
				RedirectToTmp = RedirectToVis;
				if (Operators.CompareString(RedirectToTmp, "", false) == 0)
				{
					RedirectToTmp = RedirectTo;
				}
			}
			val2 = GestisciRedirect(ref RedirectToTmp, ref objGridInfo, ref robjFunctionArguments, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected virtual string FindFormDir(string url)
	{
		if ((Operators.CompareString(Strings.Left(url, 1), "~", false) != 0) & (Operators.CompareString(url, "", false) != 0))
		{
			url = "~" + url;
		}
		string text = "";
		if (Operators.CompareString(url, "", false) == 0)
		{
			text = url;
		}
		else
		{
			url = Strings.Replace(url, "/Form/", "/FORM/", 1, -1, (CompareMethod)0).Replace("/form/", "/FORM/");
			string text2 = url;
			string text3 = text2.Replace("~/" + Assembly.GetExecutingAssembly().GetName().Name.ToUpper() + "/", "~/CUSTOM/");
			text3 = text3.Replace("~\\" + Assembly.GetExecutingAssembly().GetName().Name.ToUpper() + "\\", "~\\CUSTOM\\");
			if (File.Exists(HttpContext.Current.Server.MapPath(text3.Split(new char[1] { '?' })[0])))
			{
				text = text3;
			}
			else if (File.Exists(HttpContext.Current.Server.MapPath(text2.Split(new char[1] { '?' })[0])))
			{
				text = text2;
			}
			else
			{
				string text4 = text2;
				text4 = Strings.Left(text4, Strings.InStrRev(text4, "/", -1, (CompareMethod)0));
				text4 = HttpContext.Current.Server.MapPath(text4);
				text = text2;
				if (text4.Contains("\\FORM\\"))
				{
					text4 = text4.Replace("\\FORM\\", "\\");
					string[] directories = Directory.GetDirectories(text4, "FORM_*");
					string[] array = directories;
					foreach (string text5 in array)
					{
						string text6 = text2;
						text6 = text6.Replace("/FORM/", "/" + text5.Replace(text4, "") + "/");
						if (File.Exists(HttpContext.Current.Server.MapPath(text6.Split(new char[1] { '?' })[0])))
						{
							text = text6;
							break;
						}
					}
				}
			}
		}
		return text;
	}
}
