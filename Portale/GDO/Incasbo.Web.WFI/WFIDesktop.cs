using System;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIDesktop : WFIPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dlDesktop")]
	private DataList _dlDesktop;

	private char kTipoNodoFunzione;

	private char kTipoNodoParent;

	private char kTipoNodoNavigate;

	private char kTipoNodoExtended;

	private char kTipoNodoCaption;

	private string sTitle;

	private int iLevel;

	private NameValueCollection SqlCollection;

	private StringCollection LinkCollection;

	private int kCacheTime;

	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesktopContainer")]
	protected virtual Panel DesktopContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual DataList dlDesktop
	{
		[CompilerGenerated]
		get
		{
			return _dlDesktop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			DataListCommandEventHandler val = new DataListCommandEventHandler(dlDesktop_ItemCommand);
			DataListItemEventHandler val2 = new DataListItemEventHandler(dlDesktop_ItemDataBound);
			DataList val3 = _dlDesktop;
			if (val3 != null)
			{
				val3.ItemCommand -= val;
				val3.ItemDataBound -= val2;
			}
			_dlDesktop = value;
			val3 = _dlDesktop;
			if (val3 != null)
			{
				val3.ItemCommand += val;
				val3.ItemDataBound += val2;
			}
		}
	}

	public WFIDesktop()
	{
		((Control)this).Load += Page_Load;
		kTipoNodoFunzione = 'F';
		kTipoNodoParent = 'P';
		kTipoNodoNavigate = 'N';
		kTipoNodoExtended = 'X';
		kTipoNodoCaption = 'C';
		sTitle = "";
		iLevel = 0;
		kCacheTime = 300;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				string text = "";
				string text2 = "";
				if (((Page)this).Request.QueryString["Parent"] != null)
				{
					text = ((Page)this).Request.QueryString["Parent"].ToString();
				}
				if (((Page)this).Request.QueryString["ParentPrevious"] != null)
				{
					text2 = ((Page)this).Request.QueryString["ParentPrevious"].ToString();
				}
				if (((Page)this).Request.QueryString["Title"] != null)
				{
					sTitle = ((Page)this).Request.QueryString["Title"].ToString();
				}
				else
				{
					sTitle = "HOME\\";
				}
				if (((Page)this).Request.QueryString["Level"] != null)
				{
					iLevel = Conversions.ToInteger(((Page)this).Request.QueryString["Level"]);
				}
				else
				{
					iLevel = 0;
				}
				if (_SessionVariable["LinkCollection"] == null)
				{
					LinkCollection = new StringCollection();
					_SessionVariable["LinkCollection"] = (object)LinkCollection;
				}
				else
				{
					LinkCollection = (StringCollection)_SessionVariable["LinkCollection"];
				}
				if (iLevel < LinkCollection.Count - 1)
				{
					while (iLevel < LinkCollection.Count - 1)
					{
						LinkCollection.RemoveAt(LinkCollection.Count - 1);
					}
				}
				else if (iLevel > LinkCollection.Count - 1)
				{
					while (iLevel > LinkCollection.Count - 1)
					{
						LinkCollection.Add(((Page)this).Request.Url.OriginalString);
					}
				}
				if (_SessionVariable["SqlCollection"] == null)
				{
					SqlCollection = new NameValueCollection();
					_SessionVariable["SqlCollection"] = (object)SqlCollection;
					_SessionVariable["DateTime"] = (object)DateTime.Now;
				}
				else
				{
					if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, Conversions.ToDate(_SessionVariable["DateTime"]), DateAndTime.Now, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1)) > kCacheTime)
					{
						SqlCollection = new NameValueCollection();
						_SessionVariable["SqlCollection"] = (object)SqlCollection;
						_SessionVariable["DateTime"] = (object)DateTime.Now;
					}
					SqlCollection = (NameValueCollection)_SessionVariable["SqlCollection"];
				}
				dlDesktop.RepeatColumns = base.SessionEnvironment.WFIConfig.MenuManagerConfig.DesktopRepeatColumns;
				((WebControl)DesktopContainer).CssClass = "DesktopContainer" + dlDesktop.RepeatColumns;
				if (((Page)this).IsPostBack)
				{
					return;
				}
				DataTable dtDesktopItem = null;
				DataTable dataTable = new DataTable("Desktop");
				dataTable.Columns.Add("MnuId", typeof(string));
				dataTable.Columns.Add("ImageUrl", typeof(string));
				dataTable.Columns.Add("Text", typeof(string));
				dataTable.Columns.Add("AdditionalText", typeof(string));
				dataTable.Columns.Add("Url", typeof(string));
				dataTable.Columns.Add("Funzione", typeof(string));
				dataTable.Columns.Add("TipoNodo", typeof(string));
				dataTable.Columns.Add("CodiceVoce", typeof(string));
				dataTable.Columns.Add("Level", typeof(int));
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string sParent = text;
				string rsMess = "";
				sessionEnvironment.BuildDesktop(sParent, ref dtDesktopItem, ref rsMess);
				if (Operators.CompareString(text, "", false) != 0)
				{
					dataTable.Rows.Add("-1", "~/images/Toolbar/96/backArrow.png", TranslateMessage("XXX", "Indietro"), TranslateMessage("XXX", "Menù Precedente"), "", "GOTLEV;" + ((TemplateControl)this).AppRelativeVirtualPath + "?Parent=" + text2, "N", "DesktopBack", Interaction.IIf(iLevel > 0, (object)(iLevel - 1), (object)iLevel));
				}
				foreach (DataRow row in dtDesktopItem.Rows)
				{
					string value = "";
					if (((Operators.CompareString(row["TIPONODO"].ToString(), Conversions.ToString(kTipoNodoNavigate), false) == 0) & (Operators.CompareString(row["FUNZIONE"].ToString(), "", false) == 0)) | (Operators.CompareString(row["TIPONODO"].ToString(), Conversions.ToString(kTipoNodoParent), false) == 0))
					{
						row["DesktopImage"] = base.SessionEnvironment.WFIConfig.MenuManagerConfig.FolderGenericIcon;
					}
					else
					{
						row["DesktopImage"] = base.SessionEnvironment.WFIConfig.MenuManagerConfig.DesktopGenericIcon;
					}
					DataRow dataRow2 = dataTable.Rows.Add(row["MnuId"].ToString(), row["DesktopImage"].ToString(), row["Text"].ToString(), row["AdditionalText"].ToString(), "", "", row["TipoNodo"].ToString(), row["MNUCODICE"].ToString(), iLevel + 1);
					string text3 = row["TIPONODO"].ToString();
					if (Operators.CompareString(text3, Conversions.ToString(kTipoNodoExtended), false) == 0)
					{
						value = row["FUNZIONE"].ToString();
					}
					else if (Operators.CompareString(text3, Conversions.ToString(kTipoNodoFunzione), false) == 0)
					{
						value = row["FUNZIONE"].ToString();
					}
					else if (Operators.CompareString(text3, Conversions.ToString(kTipoNodoCaption), false) == 0)
					{
						value = "";
					}
					else if (Operators.CompareString(text3, Conversions.ToString(kTipoNodoNavigate), false) == 0)
					{
						if (Operators.CompareString(row["FUNZIONE"].ToString(), "", false) != 0)
						{
							value = ((Operators.CompareString(Strings.Left(row["FUNZIONE"].ToString(), 6).ToUpper(), "GOTPAG", false) == 0) ? row["FUNZIONE"].ToString() : ("GOTLEV;" + row["FUNZIONE"].ToString()));
						}
						else
						{
							value = "GOTLEV;" + ((TemplateControl)this).AppRelativeVirtualPath + "?Parent=<%PARENT%>&ParentPrevious=" + text;
							value = ((Operators.CompareString(base.SessionEnvironment.WFIConfig.MenuManagerConfig.UseVersion, "1", false) != 0) ? value.Replace("<%PARENT%>", row["MNUID"].ToString()) : value.Replace("<%PARENT%>", row["MNUCODICE"].ToString()));
						}
					}
					else if (Operators.CompareString(text3, Conversions.ToString(kTipoNodoParent), false) == 0)
					{
						value = "GOTLEV;" + ((TemplateControl)this).AppRelativeVirtualPath + "?Parent=<%PARENT%>&ParentPrevious=" + text;
						value = ((Operators.CompareString(base.SessionEnvironment.WFIConfig.MenuManagerConfig.UseVersion, "1", false) != 0) ? value.Replace("<%PARENT%>", row["MNUID"].ToString()) : value.Replace("<%PARENT%>", row["MNUCODICE"].ToString()));
					}
					dataRow2["Funzione"] = value;
					if (Operators.CompareString(dataRow2["AdditionalText"].ToString(), "", false) != 0 || !((Operators.CompareString(row["TIPONODO"].ToString(), "N", false) == 0) | (Operators.CompareString(row["TIPONODO"].ToString(), "P", false) == 0)))
					{
						continue;
					}
					string text4 = row["AdditionalTextFormula"].ToString();
					text4 = text4.Replace("%USER%", base.SessionEnvironment.WebUser.WebUserInfo.Codice);
					text4 = text4.Replace("%UTENTE%", base.SessionEnvironment.WebUser.WebUserInfo.Codice);
					text4 = text4.Replace("%GROUP%", base.SessionEnvironment.WebUser.WebUserInfo.Gruppo);
					text4 = text4.Replace("%GRUPPO%", base.SessionEnvironment.WebUser.WebUserInfo.Gruppo);
					text4 = text4.Replace("%FILIALE%", base.SessionEnvironment.WebUser.WebUserInfo.Filiale);
					text4 = text4.Replace("%ORGANIZZAZIONE%", base.SessionEnvironment.WebUser.WebUserInfo.Organizzazione);
					text4 = text4.Replace("%ORGANIZATION%", base.SessionEnvironment.WebUser.WebUserInfo.Organizzazione);
					if (text4.Contains("%USER.FILTER%"))
					{
						text4 = ((Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.Filtro, "", false) == 0) ? (Strings.Replace(text4, "%USER.FILTER%", "1=1", 1, -1, (CompareMethod)0) + " ") : (Strings.Replace(text4, "%USER.FILTER%", base.SessionEnvironment.WebUser.WebUserInfo.Filtro, 1, -1, (CompareMethod)0) + " "));
					}
					if (Operators.CompareString(text4, "", false) != 0)
					{
						if (SqlCollection.AllKeys.Contains<string>(text4))
						{
							dataRow2["AdditionalText"] = SqlCollection[text4];
							continue;
						}
						object obj = "";
						DBConnection dbConn = base.DbConn;
						string text5 = text4;
						rsMess = "";
						dbConn.DoSql(text5, (object)"", ref obj, ref rsMess);
						dataRow2["AdditionalText"] = obj.ToString();
						SqlCollection.Add(text4, obj.ToString());
					}
				}
				if (dtDesktopItem.Rows.Count < 6)
				{
					int count = dtDesktopItem.Rows.Count;
					for (int i = count; i <= 6; i++)
					{
						string text6 = "";
						DataRow dataRow3 = dataTable.Rows.Add("", "", "", "", "", "", "I", "IDLE", iLevel + 1);
						dataRow3["Funzione"] = "IDLE";
					}
				}
				((BaseDataList)dlDesktop).DataSource = dataTable;
				((BaseDataList)dlDesktop).DataBind();
				if (dataTable.Rows.Count > 0)
				{
					string text7 = "Level" + dataTable.Rows[0]["Level"].ToString();
					Panel desktopContainer;
					((WebControl)(desktopContainer = DesktopContainer)).CssClass = ((WebControl)desktopContainer).CssClass + " " + text7;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void dlDesktop_ItemCommand(object source, DataListCommandEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Invalid comparison between Unknown and I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Invalid comparison between Unknown and I4
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		string text2 = "";
		string sRedirect = "";
		IboResourceManager iboResourceManager = new IboResourceManager();
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		int num = 0;
		try
		{
			CallStackAdd();
			text3 = ((HiddenField)GetControlByName((Control)(object)e.Item, "HFFunzione")).Value;
			text4 = ((HiddenField)GetControlByName((Control)(object)e.Item, "HFTipoNodo")).Value;
			text5 = ((HiddenField)GetControlByName((Control)(object)e.Item, "HFCodiceVoce")).Value;
			num = Conversions.ToInteger(((HiddenField)GetControlByName((Control)(object)e.Item, "HFLevel")).Value);
			text6 = ((Label)GetControlByName((Control)(object)e.Item, "ItemText")).Text;
			string[] array = sTitle.Split(new char[1] { '\\' });
			array = (string[])Utils.CopyArray((Array)array, (Array)new string[checked(iLevel + 1)]);
			string text7 = "";
			string[] array2 = array;
			foreach (string text8 in array2)
			{
				if (Operators.CompareString(text8, "", false) != 0)
				{
					text7 = text7 + text8 + "\\";
				}
			}
			val2 = iboResourceManager.Resource_Check(MenuResourceName + text5, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			checked
			{
				switch (Strings.Left(text3.ToUpper(), 6))
				{
				case "LOGOFF":
				{
					string sUrl = "";
					if (base.SessionEnvironment.Session["PageRedirectAfterLogOff"] != null)
					{
						sUrl = base.SessionEnvironment.Session["PageRedirectAfterLogOff"].ToString();
					}
					if (Operators.CompareString(sUrl, "", false) == 0)
					{
						sUrl = "~/WFI/Form/Redirector.aspx";
					}
					IboSessionEnvironment sessionEnvironment7 = base.SessionEnvironment;
					string sRisorsa = base.SessionEnvironment.WebApplicationName.ToUpper();
					string rsMess2 = "";
					sessionEnvironment7.LogRisorseAzioneInserisci(sRisorsa, "LOGOUT", "UI", "", "", ref rsMess2);
					LogOff();
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
					break;
				}
				case "CALFUN":
				{
					string vsFunction = Strings.Left(Strings.Mid(text3.ToUpper(), 8), 6);
					sRedirect = Strings.Mid(text3.ToUpper(), 15);
					FunctionArguments functionArguments2 = new FunctionArguments("CALLFUNC", vsFunction);
					((Page)this).Session["FunctionArgs"] = functionArguments2;
					IboSessionEnvironment sessionEnvironment3 = base.SessionEnvironment;
					string sVoceMenu3 = text5;
					string rsMess2 = "";
					sessionEnvironment3.UpdateMenuUsage(sVoceMenu3, ref rsMess2);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
				case "NEWGRD":
				{
					text = text3;
					val2 = NewGridParser(text, ref sRedirect, ref rsMess);
					if (unchecked((int)val2) > 0)
					{
						return;
					}
					IboSessionEnvironment sessionEnvironment4 = base.SessionEnvironment;
					string sVoceMenu4 = text5;
					string rsMess2 = "";
					sessionEnvironment4.UpdateMenuUsage(sVoceMenu4, ref rsMess2);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
				case "GOTLEV":
				{
					text3 = ((!text3.Contains("?")) ? (text3 + "?Title=" + text7 + text6) : (text3 + "&Title=" + text7 + text6));
					text3 = text3 + "&level=" + num;
					IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
					string sVoceMenu2 = text5;
					string rsMess2 = "";
					sessionEnvironment2.UpdateMenuUsage(sVoceMenu2, ref rsMess2);
					sRedirect = Strings.Mid(text3.ToUpper(), 8);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
				case "GOTPAG":
				{
					IboSessionEnvironment sessionEnvironment6 = base.SessionEnvironment;
					string sVoceMenu6 = text5;
					string rsMess2 = "";
					sessionEnvironment6.UpdateMenuUsage(sVoceMenu6, ref rsMess2);
					sRedirect = Strings.Mid(text3.ToUpper(), 8);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
				case "GOTOSF":
				{
					text = Strings.Mid(text3.ToUpper(), 8);
					string[] array3 = Strings.Split(text, ";", -1, (CompareMethod)0);
					string text10 = BaseFunctions.OnlyAspxPageName(array3[array3.Count() - 1].ToUpper()).ToUpper();
					text10 = text10.Split(new char[1] { '?' })[0];
					base.SessionEnvironment.SessionVariables.Remove(text10);
					base.SessionEnvironment.SessionVariables.Add(text10, new IboDictionaryCollection<string, object>());
					int num3 = array3.Count() - 2;
					for (int k = 0; k <= num3; k++)
					{
						string[] array4 = Strings.Split(array3[k], "=", -1, (CompareMethod)0);
						base.SessionEnvironment.SessionVariables[text10][array4[0].ToUpper()] = (object)array4[1];
					}
					FunctionArguments functionArguments3 = new FunctionArguments("", "");
					if (base.SessionEnvironment.SessionVariables[text10].ContainsKey("CONTEXT"))
					{
						functionArguments3.Context = base.SessionEnvironment.SessionVariables[text10]["CONTEXT"].ToString();
					}
					sRedirect = array3[array3.Count() - 1];
					((Page)this).Session.Add("FunctionArgs", (object)functionArguments3);
					IboSessionEnvironment sessionEnvironment5 = base.SessionEnvironment;
					string sVoceMenu5 = text5;
					string rsMess2 = "";
					sessionEnvironment5.UpdateMenuUsage(sVoceMenu5, ref rsMess2);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
				case "GOTOPF":
				{
					text = Strings.Mid(text3.ToUpper(), 8);
					string[] array3 = Strings.Split(text, ";", -1, (CompareMethod)0);
					string text9 = BaseFunctions.OnlyAspxPageName(array3[array3.Count() - 1].ToUpper()).ToUpper();
					text9 = text9.Split(new char[1] { '?' })[0];
					base.SessionEnvironment.SessionVariables.Remove(text9);
					base.SessionEnvironment.SessionVariables.Add(text9, new IboDictionaryCollection<string, object>());
					int num2 = array3.Count() - 2;
					for (int j = 0; j <= num2; j++)
					{
						string[] array4 = Strings.Split(array3[j], "=", -1, (CompareMethod)0);
						base.SessionEnvironment.SessionVariables[text9][array4[0].ToUpper()] = (object)array4[1];
					}
					FunctionArguments functionArguments = new FunctionArguments("", "");
					functionArguments.Context = "PRINTFILTER";
					if (base.SessionEnvironment.SessionVariables[text9].ContainsKey("CONTEXT"))
					{
						functionArguments.Context = base.SessionEnvironment.SessionVariables[text9]["CONTEXT"].ToString();
					}
					else
					{
						base.SessionEnvironment.SessionVariables[text9]["CONTEXT"] = (object)functionArguments.Context;
					}
					if (!base.SessionEnvironment.SessionVariables[text9].ContainsKey("FORMMODE"))
					{
						base.SessionEnvironment.SessionVariables[text9]["FORMMODE"] = (object)"";
					}
					sRedirect = array3[array3.Count() - 1];
					sRedirect = ((!sRedirect.Contains("?")) ? (sRedirect + "?NomRep=" + base.SessionEnvironment.SessionVariables[text9]["REPORT"].ToString()) : (sRedirect + "&NomRep=" + base.SessionEnvironment.SessionVariables[text9]["REPORT"].ToString()));
					((Page)this).Session.Add("FunctionArgs", (object)functionArguments);
					IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
					string sVoceMenu = text5;
					string rsMess2 = "";
					sessionEnvironment.UpdateMenuUsage(sVoceMenu, ref rsMess2);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
				}
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
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void dlDesktop_ItemDataBound(object sender, DataListItemEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		try
		{
			if ((int)e.Item.ItemType == 0)
			{
				string[] array = sTitle.Split(new char[1] { '\\' });
				checked
				{
					array = (string[])Utils.CopyArray((Array)array, (Array)new string[iLevel + 1]);
					sTitle = "";
					int num = 1;
					string[] array2 = array;
					foreach (string text in array2)
					{
						LinkButton val = (LinkButton)GetControlByName((Control)(object)dlDesktop, "LinkPath" + num);
						ref string reference = ref sTitle;
						reference = reference + text + "\\";
						val.Text = text + "\\";
						num++;
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected void LinkPath_Click(object sender, EventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int index = Conversions.ToInteger(((LinkButton)sender).CommandArgument);
			string sUrl = LinkCollection[index];
			IboResponseRedirect(ref sUrl);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
