using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using Incasbo.Api.App;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFStandardReport : WFIPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmdDownload")]
	private IboWebButton _cmdDownload;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmdEsci")]
	private IboWebButton _cmdEsci;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tmrClose")]
	private Timer _tmrClose;

	private string sPercorsoStampe;

	private string sPercorsoStampeCustom;

	private string sPercorsoStampeConfigurato;

	private FunctionArguments objFunctionArguments;

	private string sNomRif;

	private string _Utente;

	private string sNomeReport;

	private bool _ExportPDF;

	private bool _ExportXLS;

	private bool _ExportDOC;

	private bool _SendFileToClient;

	private string _sSelectionFormula;

	private string _sHumanReadableFormula;

	private bool _ShowMode;

	private const string kShowMode = "#SHOWMODE";

	private bool _StampaAsincrona;

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainTablePanel")]
	protected virtual Panel MainTablePanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlButtons")]
	protected virtual Panel pnlButtons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton cmdDownload
	{
		[CompilerGenerated]
		get
		{
			return _cmdDownload;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdDownload_Click;
			IboWebButton val = _cmdDownload;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_cmdDownload = value;
			val = _cmdDownload;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton cmdEsci
	{
		[CompilerGenerated]
		get
		{
			return _cmdEsci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdEsci_Click;
			IboWebButton val = _cmdEsci;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_cmdEsci = value;
			val = _cmdEsci;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlReport")]
	protected virtual Panel pnlReport
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("crvMain")]
	protected virtual CrystalReportViewer crvMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("crsMain")]
	protected virtual CrystalReportSource crsMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrame")]
	protected virtual HtmlGenericControl IFrame
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameUrl")]
	protected virtual HiddenField IFrameUrl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggioErrore")]
	protected virtual Panel pnlMessaggioErrore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblErroreCaption")]
	protected virtual Label lblErroreCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMessaggio")]
	protected virtual Label lblMessaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblErroreOk")]
	protected virtual Button lblErroreOk
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Timer tmrClose
	{
		[CompilerGenerated]
		get
		{
			return _tmrClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler<EventArgs> eventHandler = tmrClose_Tick;
			Timer val = _tmrClose;
			if (val != null)
			{
				val.Tick -= eventHandler;
			}
			_tmrClose = value;
			val = _tmrClose;
			if (val != null)
			{
				val.Tick += eventHandler;
			}
		}
	}

	public WFStandardReport()
	{
		((Control)this).Load += Page_Load;
		sPercorsoStampe = "";
		sPercorsoStampeCustom = "";
		sPercorsoStampeConfigurato = "";
		sNomRif = "";
		_Utente = "";
		sNomeReport = "";
		_ExportPDF = false;
		_ExportXLS = false;
		_ExportDOC = false;
		_SendFileToClient = false;
		_sSelectionFormula = "";
		_sHumanReadableFormula = "";
		_ShowMode = false;
		_StampaAsincrona = false;
	}

	public override void WriteErrorMessage(string vsMessaggio)
	{
		((Control)pnlMessaggioErrore).Visible = true;
		lblMessaggio.Text = vsMessaggio;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Invalid comparison between Unknown and I4
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Invalid comparison between Unknown and I4
		//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Invalid comparison between Unknown and I4
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Invalid comparison between Unknown and I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Invalid comparison between Unknown and I4
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Invalid comparison between Unknown and I4
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dtDati = null;
		Dictionary<string, object> reportParams = null;
		try
		{
			try
			{
				base.MasterPage.ScriptManager.RegisterPostBackControl((Control)(object)cmdDownload);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			((Control)IFrame).ClientIDMode = (ClientIDMode)3;
			objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgsReportPage"];
			sPercorsoStampe = base.SessionEnvironment.WebApplicationRoot + "\\Stampe\\";
			if ((int)base.DbConn.ServerType == 1)
			{
				sPercorsoStampe += "ORCL\\";
			}
			else if ((int)base.DbConn.ServerType == 0)
			{
				sPercorsoStampe += "SQL\\";
			}
			sPercorsoStampeCustom = base.SessionEnvironment.WebApplicationRoot + "\\Custom\\Stampe\\";
			if (objFunctionArguments.Argomento1 != null && Operators.CompareString(objFunctionArguments.Argomento1.ToString(), "", false) != 0)
			{
				if (Operators.CompareString(objFunctionArguments.Argomento1.ToString().ToUpper(), "#SHOWMODE", false) == 0)
				{
					_ShowMode = true;
				}
				else
				{
					string[] array = Strings.Split(objFunctionArguments.Argomento1.ToString(), "@", -1, (CompareMethod)0);
					sNomRif = array[0];
					_Utente = array[1];
				}
			}
			else
			{
				sNomRif = "";
				_Utente = base.SessionEnvironment.WebUser.WebUserInfo.Codice;
			}
			if (!_ShowMode)
			{
				if (objFunctionArguments.Argomento2 != null)
				{
					sNomeReport = objFunctionArguments.Argomento2.ToString();
				}
				else
				{
					sNomeReport = "";
				}
				if (objFunctionArguments.Argomento3 != null)
				{
					_ExportPDF = Operators.CompareString(Strings.Left(objFunctionArguments.Argomento3.ToString(), 3).ToUpper(), "PDF", false) == 0;
					_ExportXLS = Operators.CompareString(Strings.Left(objFunctionArguments.Argomento3.ToString(), 3).ToUpper(), "XLS", false) == 0;
					_ExportDOC = Operators.CompareString(Strings.Left(objFunctionArguments.Argomento3.ToString(), 3).ToUpper(), "DOC", false) == 0;
				}
				else
				{
					_ExportPDF = true;
				}
				if (_ExportPDF)
				{
					_SendFileToClient = Operators.CompareString(objFunctionArguments.Argomento3.ToString().ToUpper(), "PDFDWL", false) == 0;
				}
				if (_ExportXLS)
				{
					_SendFileToClient = Operators.CompareString(objFunctionArguments.Argomento3.ToString().ToUpper(), "XLSDWL", false) == 0;
				}
				if (_ExportDOC)
				{
					_SendFileToClient = Operators.CompareString(objFunctionArguments.Argomento3.ToString().ToUpper(), "DOCDWL", false) == 0;
				}
				if (objFunctionArguments.Argomento4 != null)
				{
					_sSelectionFormula = objFunctionArguments.Argomento4.ToString();
				}
				else
				{
					_sSelectionFormula = "";
				}
				if (objFunctionArguments.Argomento5 != null)
				{
					_sHumanReadableFormula = objFunctionArguments.Argomento5.ToString();
				}
				else
				{
					_sHumanReadableFormula = "";
				}
				if (objFunctionArguments.Argomento6 != null)
				{
					dtDati = (DataTable)objFunctionArguments.Argomento6;
					objFunctionArguments.Argomento6 = null;
				}
				if (objFunctionArguments.Argomento7 != null)
				{
					reportParams = (Dictionary<string, object>)objFunctionArguments.Argomento7;
					objFunctionArguments.Argomento7 = null;
				}
			}
			else
			{
				if (objFunctionArguments.Argomento2 != null)
				{
					sNomeReport = objFunctionArguments.Argomento2.ToString();
				}
				else
				{
					sNomeReport = "";
				}
				_SendFileToClient = Operators.CompareString(objFunctionArguments.Argomento3.ToString().ToUpper(), "PDFDWL", false) == 0;
			}
			if (Operators.CompareString(sNomeReport, "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Non è stato specificato il nome del report");
				return;
			}
			if (!((Control)this).Page.IsPostBack)
			{
				cmdDownload.Visible = false;
				((Button)cmdDownload).CommandArgument = "";
				if (!_ShowMode)
				{
					if (Operators.CompareString(sNomRif, "", false) != 0)
					{
						if (_ExportPDF)
						{
							IboSessionEnvironment robjSessionEnv = base.SessionEnvironment;
							IboWebCRW iboWebCRW = new IboWebCRW(ref robjSessionEnv);
							string text = Guid.NewGuid().ToString() + ".pdf";
							string rsNomeFileCompletoGenerato = "";
							val = iboWebCRW.CrystalReportToPDF(sNomRif, _Utente, objFunctionArguments, dtDati, sNomeReport, text, _sSelectionFormula, _sHumanReadableFormula, reportParams, "X", ref rsNomeFileCompletoGenerato, ref _StampaAsincrona, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
								return;
							}
							if (!_StampaAsincrona)
							{
								string text2 = "..\\..\\" + rsNomeFileCompletoGenerato.Replace(base.SessionEnvironment.WebApplicationRoot, "");
								if (_SendFileToClient)
								{
									string text3 = ((Page)this).Request.ApplicationPath + "/" + text2.Replace(((Page)this).Server.MapPath("~/"), "").Replace("\\", "/");
									text3 = text3.Replace("//", "/");
									WindowPopupProperties windowPopupProperties = new WindowPopupProperties();
									windowPopupProperties.Address = text3;
									windowPopupProperties.Height = 650;
									windowPopupProperties.Width = 800;
									windowPopupProperties.Top = 0;
									windowPopupProperties.Left = 0;
									Client_OpenWindowOnLoadPage(windowPopupProperties);
									tmrClose.Enabled = true;
									((Control)MainTablePanel).Visible = false;
								}
								else
								{
									((HtmlControl)IFrame).Attributes["src"] = Strings.Replace(text2, "\\", "/", 1, -1, (CompareMethod)0);
									IFrameUrl.Value = Strings.Replace(text2, "\\", "/", 1, -1, (CompareMethod)0);
									((Control)IFrame).Visible = true;
									((Control)crvMain).Visible = false;
									cmdDownload.Visible = true;
									((Button)cmdDownload).CommandArgument = rsNomeFileCompletoGenerato + ";" + text;
								}
							}
						}
						else if (_ExportXLS | _ExportDOC)
						{
							IboSessionEnvironment robjSessionEnv = base.SessionEnvironment;
							IboWebCRW iboWebCRW2 = new IboWebCRW(ref robjSessionEnv);
							string text4 = Guid.NewGuid().ToString() + (_ExportXLS ? ".xls" : ".doc");
							string rsNomeFileCompletoGenerato2 = "";
							val = iboWebCRW2.CrystalReportToFile(sNomRif, _Utente, objFunctionArguments, dtDati, sNomeReport, text4, _sSelectionFormula, _sHumanReadableFormula, reportParams, (IboCRW.IboExportFormatType)(_ExportXLS ? 2 : 4), ref rsNomeFileCompletoGenerato2, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
								return;
							}
							string text5 = "..\\..\\" + rsNomeFileCompletoGenerato2.Replace(base.SessionEnvironment.WebApplicationRoot, "");
							if (_SendFileToClient)
							{
								string text6 = ((Page)this).Request.ApplicationPath + "/" + text5.Replace(((Page)this).Server.MapPath("~/"), "").Replace("\\", "/");
								text6 = text6.Replace("//", "/");
								WindowPopupProperties windowPopupProperties2 = new WindowPopupProperties();
								windowPopupProperties2.Address = text6;
								windowPopupProperties2.Height = 650;
								windowPopupProperties2.Width = 800;
								windowPopupProperties2.Top = 0;
								windowPopupProperties2.Left = 0;
								Client_OpenWindowOnLoadPage(windowPopupProperties2);
								tmrClose.Enabled = true;
								((Control)MainTablePanel).Visible = false;
							}
							else
							{
								((HtmlControl)IFrame).Attributes["src"] = text5;
								IFrameUrl.Value = Strings.Replace(text5, "\\", "/", 1, -1, (CompareMethod)0);
								((Control)IFrame).Visible = true;
								((Control)crvMain).Visible = false;
								cmdDownload.Visible = true;
								((Button)cmdDownload).CommandArgument = rsNomeFileCompletoGenerato2 + ";" + text4;
							}
						}
						else
						{
							((Control)IFrame).Visible = false;
							((Control)crvMain).Visible = true;
							val = CaricaReport(sNomRif, sNomeReport, ref rsMess);
							if ((int)val > 0)
							{
								return;
							}
						}
					}
					else if (_ExportPDF)
					{
						IboSessionEnvironment robjSessionEnv = base.SessionEnvironment;
						IboWebCRW iboWebCRW3 = new IboWebCRW(ref robjSessionEnv);
						string text7 = Guid.NewGuid().ToString() + ".pdf";
						string rsNomeFileCompletoGenerato3 = "";
						val = iboWebCRW3.CrystalReportToPDF(sNomeReport, text7, _sSelectionFormula, _sHumanReadableFormula, reportParams, ref rsNomeFileCompletoGenerato3, ref _StampaAsincrona, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
							return;
						}
						if (!_StampaAsincrona)
						{
							string text8 = "..\\..\\" + rsNomeFileCompletoGenerato3.Replace(base.SessionEnvironment.WebApplicationRoot, "");
							if (_SendFileToClient)
							{
								string text9 = ((Page)this).Request.ApplicationPath + "/" + text8.Replace(((Page)this).Server.MapPath("~/"), "").Replace("\\", "/");
								text9 = text9.Replace("//", "/");
								WindowPopupProperties windowPopupProperties3 = new WindowPopupProperties();
								windowPopupProperties3.Address = text9;
								windowPopupProperties3.Height = 650;
								windowPopupProperties3.Width = 800;
								windowPopupProperties3.Top = 0;
								windowPopupProperties3.Left = 0;
								Client_OpenWindowOnLoadPage(windowPopupProperties3);
								tmrClose.Enabled = true;
								((Control)MainTablePanel).Visible = false;
							}
							else
							{
								((HtmlControl)IFrame).Attributes["src"] = text8;
								IFrameUrl.Value = Strings.Replace(text8, "\\", "/", 1, -1, (CompareMethod)0);
								((Control)IFrame).Visible = true;
								((Control)crvMain).Visible = false;
								cmdDownload.Visible = true;
								((Button)cmdDownload).CommandArgument = rsNomeFileCompletoGenerato3 + ";" + text7;
							}
						}
					}
					else if (_ExportXLS | _ExportDOC)
					{
						IboSessionEnvironment robjSessionEnv = base.SessionEnvironment;
						IboWebCRW iboWebCRW4 = new IboWebCRW(ref robjSessionEnv);
						string text10 = Guid.NewGuid().ToString() + (_ExportXLS ? ".xls" : ".doc");
						string rsNomeFileCompletoGenerato4 = "";
						val = iboWebCRW4.CrystalReportToFile(sNomeReport, text10, _sSelectionFormula, _sHumanReadableFormula, reportParams, (IboCRW.IboExportFormatType)(_ExportXLS ? 2 : 4), ref rsNomeFileCompletoGenerato4, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
							return;
						}
						string text11 = "..\\..\\" + rsNomeFileCompletoGenerato4.Replace(base.SessionEnvironment.WebApplicationRoot, "");
						if (_SendFileToClient)
						{
							string text12 = ((Page)this).Request.ApplicationPath + "/" + text11.Replace(((Page)this).Server.MapPath("~/"), "").Replace("\\", "/");
							text12 = text12.Replace("//", "/");
							WindowPopupProperties windowPopupProperties4 = new WindowPopupProperties();
							windowPopupProperties4.Address = text12;
							windowPopupProperties4.Height = 650;
							windowPopupProperties4.Width = 800;
							windowPopupProperties4.Top = 0;
							windowPopupProperties4.Left = 0;
							Client_OpenWindowOnLoadPage(windowPopupProperties4);
							tmrClose.Enabled = true;
							((Control)MainTablePanel).Visible = false;
						}
						else
						{
							((HtmlControl)IFrame).Attributes["src"] = text11;
							IFrameUrl.Value = Strings.Replace(text11, "\\", "/", 1, -1, (CompareMethod)0);
							((Control)IFrame).Visible = true;
							((Control)crvMain).Visible = false;
							cmdDownload.Visible = true;
							((Button)cmdDownload).CommandArgument = rsNomeFileCompletoGenerato4 + ";" + text10;
						}
					}
					else
					{
						((Control)IFrame).Visible = false;
						((Control)crvMain).Visible = true;
						val = CaricaReport(sNomeReport, ref rsMess);
						if ((int)val > 0)
						{
							return;
						}
					}
				}
				else
				{
					string text13 = sNomeReport;
					string fileName = Path.GetFileName(text13);
					string text14 = "..\\..\\" + text13.Replace(base.SessionEnvironment.WebApplicationRoot, "");
					if (_SendFileToClient)
					{
						string text15 = ((Page)this).Request.ApplicationPath + "/" + text14.Replace(((Page)this).Server.MapPath("~/"), "").Replace("\\", "/");
						text15 = text15.Replace("//", "/");
						WindowPopupProperties windowPopupProperties5 = new WindowPopupProperties();
						windowPopupProperties5.Address = text15;
						windowPopupProperties5.Height = 650;
						windowPopupProperties5.Width = 800;
						windowPopupProperties5.Top = 0;
						windowPopupProperties5.Left = 0;
						Client_OpenWindowOnLoadPage(windowPopupProperties5);
						tmrClose.Enabled = true;
						((Control)MainTablePanel).Visible = false;
					}
					else
					{
						((HtmlControl)IFrame).Attributes["src"] = Strings.Replace(text14, "\\", "/", 1, -1, (CompareMethod)0);
						IFrameUrl.Value = Strings.Replace(text14, "\\", "/", 1, -1, (CompareMethod)0);
						((Control)IFrame).Visible = true;
						((Control)crvMain).Visible = false;
						cmdDownload.Visible = true;
						((Button)cmdDownload).CommandArgument = text13 + ";" + fileName;
					}
				}
			}
			if (_StampaAsincrona)
			{
				cmdEsci_Click(cmdEsci, new EventArgs());
			}
			((HtmlControl)IFrame).Attributes.Add("style", checked("height:" + Conversions.ToString(base.SessionEnvironment.WindowHeight - 120) + "px; width:" + Conversions.ToString(base.SessionEnvironment.WindowWidth - 20)) + "px;");
			val2 = (FXRETURN)0;
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
			if (Operators.CompareString(rsMess, "", false) != 0)
			{
				WriteErrorMessageWithReturnToCaller("", "Si è verificato un errore in fase di caricamento del report", rsMess);
			}
		}
	}

	protected virtual FXRETURN CaricaReport(string sNomRif, string sNomeReport, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Invalid comparison between Unknown and I4
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Invalid comparison between Unknown and I4
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Invalid comparison between Unknown and I4
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		string selectionFormula = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			((Control)pnlMain).Visible = false;
			if (_sSelectionFormula.Length == 0)
			{
				text = "SELECT T2.*, T1.ReportSelectionFormula ReportSelectionFormula2 ";
				text += "FROM WFI_ALLGRD_TABREP T1 INNER JOIN WFI_TABREP T2 ";
				text += "ON T1.NOMREP=T2.NOMREP ";
				text = text + "WHERE T1.NomRif = " + base.DbConn.SQLFormatString(sNomRif) + " ";
				text = text + "AND T1.UTENTE = " + base.DbConn.SQLFormatString(_Utente) + " ";
				text = text + "AND T2.NOMREP = " + base.DbConn.SQLFormatString(sNomeReport);
			}
			else
			{
				text = "SELECT * FROM WFI_TABREP ";
				text += "WHERE ";
				text = text + "NOMREP = " + base.DbConn.SQLFormatString(sNomeReport);
			}
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(dataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
				{
					sPercorsoStampeConfigurato = base.SessionEnvironment.WebApplicationRoot + dataTable.Rows[0]["Percorso"].ToString();
				}
				if (Operators.CompareString(dataTable.Rows[0]["FiltroGriglia"].ToString(), "S", false) == 0)
				{
					if (objFunctionArguments.FieldValuesCount == 1)
					{
						goto IL_0243;
					}
					rsMess = TranslateMessage("XXX", "E' necessario selezionare un solo record");
				}
				else
				{
					if (Operators.CompareString(dataTable.Rows[0]["FiltroGriglia"].ToString(), "M", false) != 0 || objFunctionArguments.FieldValuesCount != 0)
					{
						goto IL_0243;
					}
					rsMess = TranslateMessage("XXX", "E' necessario selezionare almeno un record");
				}
			}
			goto end_IL_001c;
			IL_0243:
			string text3 = "";
			if (Operators.CompareString(sPercorsoStampeConfigurato, "", false) != 0)
			{
				text3 = (sPercorsoStampeConfigurato + sNomeReport).Replace("\\\\", "\\");
			}
			else
			{
				text3 = (sPercorsoStampeCustom + sNomeReport).Replace("\\\\", "\\");
				if (!File.Exists(text3))
				{
					text3 = (sPercorsoStampe + sNomeReport).Replace("\\\\", "\\");
				}
			}
			checked
			{
				if (!File.Exists(text3))
				{
					rsMess = TranslateMessage("XXX", "Il file del report {0} non esiste", sNomeReport);
				}
				else
				{
					crsMain.Report.FileName = text3;
					ReportDocument objRpt = crsMain.ReportDocument;
					objRpt.SetDatabaseLogon(base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database);
					foreach (CrystalDecisions.CrystalReports.Engine.Table item in (SCRCollection)objRpt.Database.Tables)
					{
						CrystalDecisions.CrystalReports.Engine.Table val3 = item;
						if (unchecked((int)base.DbConn.ServerType) == 1)
						{
							val3.LogOnInfo.ConnectionInfo.DatabaseName = "";
						}
						else
						{
							val3.LogOnInfo.ConnectionInfo.DatabaseName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database;
						}
						val3.LogOnInfo.ConnectionInfo.ServerName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server;
						val3.LogOnInfo.ConnectionInfo.Password = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password;
						val3.LogOnInfo.ConnectionInfo.UserID = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username;
						val3.LogOnInfo.ConnectionInfo.IntegratedSecurity = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_UseIntegratedSecurity;
						val3.ApplyLogOnInfo(val3.LogOnInfo);
						val3.Location = val3.Location.Substring(val3.Location.LastIndexOf(".") + 1);
					}
					objRpt.ReportOptions.EnableSaveDataWithReport = false;
					foreach (ReportDocument item2 in (ReadOnlyCollectionBase)(object)objRpt.Subreports)
					{
						ReportDocument val4 = item2;
						val4.SetDatabaseLogon(base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database);
						foreach (CrystalDecisions.CrystalReports.Engine.Table item3 in (SCRCollection)val4.Database.Tables)
						{
							CrystalDecisions.CrystalReports.Engine.Table val5 = item3;
							if (unchecked((int)base.DbConn.ServerType) == 1)
							{
								val5.LogOnInfo.ConnectionInfo.DatabaseName = "";
							}
							else
							{
								val5.LogOnInfo.ConnectionInfo.DatabaseName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database;
							}
							val5.LogOnInfo.ConnectionInfo.ServerName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server;
							val5.LogOnInfo.ConnectionInfo.Password = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password;
							val5.LogOnInfo.ConnectionInfo.UserID = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username;
							val5.LogOnInfo.ConnectionInfo.IntegratedSecurity = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_UseIntegratedSecurity;
							val5.ApplyLogOnInfo(val5.LogOnInfo);
							val5.Location = val5.Location.Substring(val5.Location.LastIndexOf(".") + 1);
						}
					}
					ParameterValues val6 = new ParameterValues();
					ParameterDiscreteValue val7 = new ParameterDiscreteValue();
					ParameterFieldDefinition val8 = CrystalReportGetParamDefinition("Caption", ref objRpt);
					if (val8 != null)
					{
						val7.Value = dataTable.Rows[0]["CapRep"].ToString();
						val6 = val8.CurrentValues;
						val6.Clear();
						val6.Add((ParameterValue)(object)val7);
						val8.ApplyCurrentValues(val6);
					}
					val8 = CrystalReportGetParamDefinition("HumanReadable", ref objRpt);
					if (val8 != null)
					{
						val7.Value = _sHumanReadableFormula;
						val6 = val8.CurrentValues;
						val6.Add((ParameterValue)(object)val7);
						val8.ApplyCurrentValues(val6);
					}
					if (_sSelectionFormula.Length == 0)
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ReportSelectionFormula"])))
						{
							int fieldValuesCount = objFunctionArguments.Data[0].FieldValuesCount;
							int count = objFunctionArguments.Data.Count;
							selectionFormula = "(";
							int i = default(int);
							for (; i < fieldValuesCount; i++)
							{
								if (i > 0)
								{
									selectionFormula += " OR ";
								}
								selectionFormula += "(";
								selectionFormula = ((Operators.CompareString(dataTable.Rows[0]["ReportSelectionFormula2"].ToString(), "", false) == 0) ? (selectionFormula + dataTable.Rows[0]["ReportSelectionFormula"].ToString().ToUpper()) : (selectionFormula + dataTable.Rows[0]["ReportSelectionFormula2"].ToString().ToUpper()));
								for (int j = 0; j < count; j++)
								{
									text2 = "";
									switch (objFunctionArguments.Data[j].FieldType)
									{
									case "String":
										text2 = "\"" + objFunctionArguments.Data[j].get_FieldValues(i).ToString() + "\"";
										break;
									case "Int16":
									case "Int32":
									case "Int64":
									case "Numeric":
									case "Decimal":
									case "Single":
										text2 = "tonumber(\"" + objFunctionArguments.Data[j].get_FieldValues(i).ToString() + "\")";
										break;
									case "DateTime":
										text2 = "";
										break;
									}
									selectionFormula = selectionFormula.Replace("<%" + objFunctionArguments.Data[j].FieldName.ToUpper() + "%>", text2);
								}
								selectionFormula += ")";
							}
							selectionFormula += ")";
						}
					}
					else
					{
						selectionFormula = _sSelectionFormula;
					}
					((Control)pnlMain).Visible = true;
					((CrystalReportViewerBase)crvMain).SelectionFormula = selectionFormula;
					crvMain.HasCrystalLogo = false;
					crvMain.HasExportButton = true;
					crvMain.HasDrillUpButton = false;
					crvMain.HasPrintButton = true;
					((Control)crvMain).Visible = true;
					crvMain.RefreshReport();
					((Control)pnlMessaggioErrore).Visible = false;
					val2 = (FXRETURN)0;
				}
			}
			end_IL_001c:;
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
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override void ReturnToCaller()
	{
		string text = "";
		((Page)this).Session["FunctionArgsReportPage"] = null;
		text = objFunctionArguments.CallerPath;
		if (objFunctionArguments.CallerQueryString.Length > 0)
		{
			text = text + "?" + objFunctionArguments.CallerQueryString;
		}
		IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
		IboResponseRedirect(ref robjCallStackHandler, ref text);
	}

	protected virtual FXRETURN CaricaReport(string sNomeReport, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Invalid comparison between Unknown and I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Invalid comparison between Unknown and I4
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			((Control)pnlMain).Visible = false;
			text = "SELECT * FROM WFI_TABREP ";
			text += "WHERE ";
			text = text + "NOMREP = " + base.DbConn.SQLFormatString(sNomeReport);
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(dataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
				{
					sPercorsoStampeConfigurato = base.SessionEnvironment.WebApplicationRoot + dataTable.Rows[0]["Percorso"].ToString();
				}
				string text3 = "";
				if (Operators.CompareString(sPercorsoStampeConfigurato, "", false) != 0)
				{
					text3 = (sPercorsoStampeConfigurato + sNomeReport).Replace("\\\\", "\\");
				}
				else
				{
					text3 = (sPercorsoStampeCustom + sNomeReport).Replace("\\\\", "\\");
					if (!File.Exists(text3))
					{
						text3 = (sPercorsoStampe + sNomeReport).Replace("\\\\", "\\");
					}
				}
				if (!File.Exists(text3))
				{
					rsMess = TranslateMessage("XXX", "Il file del report {0} non esiste", sNomeReport);
				}
				else
				{
					crsMain.Report.FileName = text3;
					ReportDocument objRpt = crsMain.ReportDocument;
					objRpt.SetDatabaseLogon(base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database);
					foreach (CrystalDecisions.CrystalReports.Engine.Table item in (SCRCollection)objRpt.Database.Tables)
					{
						CrystalDecisions.CrystalReports.Engine.Table val3 = item;
						if ((int)base.DbConn.ServerType == 1)
						{
							val3.LogOnInfo.ConnectionInfo.DatabaseName = "";
						}
						else
						{
							val3.LogOnInfo.ConnectionInfo.DatabaseName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database;
						}
						val3.LogOnInfo.ConnectionInfo.ServerName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server;
						val3.LogOnInfo.ConnectionInfo.Password = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password;
						val3.LogOnInfo.ConnectionInfo.UserID = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username;
						val3.LogOnInfo.ConnectionInfo.IntegratedSecurity = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_UseIntegratedSecurity;
						val3.ApplyLogOnInfo(val3.LogOnInfo);
					}
					objRpt.ReportOptions.EnableSaveDataWithReport = false;
					foreach (ReportDocument item2 in (ReadOnlyCollectionBase)(object)objRpt.Subreports)
					{
						ReportDocument val4 = item2;
						val4.SetDatabaseLogon(base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server, base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database);
						foreach (CrystalDecisions.CrystalReports.Engine.Table item3 in (SCRCollection)val4.Database.Tables)
						{
							CrystalDecisions.CrystalReports.Engine.Table val5 = item3;
							if ((int)base.DbConn.ServerType == 1)
							{
								val5.LogOnInfo.ConnectionInfo.DatabaseName = "";
							}
							else
							{
								val5.LogOnInfo.ConnectionInfo.DatabaseName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Database;
							}
							val5.LogOnInfo.ConnectionInfo.ServerName = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Server;
							val5.LogOnInfo.ConnectionInfo.Password = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Password;
							val5.LogOnInfo.ConnectionInfo.UserID = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Username;
							val5.LogOnInfo.ConnectionInfo.IntegratedSecurity = base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_UseIntegratedSecurity;
							val5.ApplyLogOnInfo(val5.LogOnInfo);
						}
					}
					ParameterValues val6 = new ParameterValues();
					ParameterDiscreteValue val7 = new ParameterDiscreteValue();
					ParameterFieldDefinition val8 = CrystalReportGetParamDefinition("Caption", ref objRpt);
					if (val8 != null)
					{
						val7.Value = dataTable.Rows[0]["CapRep"].ToString();
						val6 = val8.CurrentValues;
						val6.Clear();
						val6.Add((ParameterValue)(object)val7);
						val8.ApplyCurrentValues(val6);
					}
					val8 = CrystalReportGetParamDefinition("HumanReadable", ref objRpt);
					if (val8 != null)
					{
						val7.Value = _sHumanReadableFormula;
						val6 = val8.CurrentValues;
						val6.Add((ParameterValue)(object)val7);
						val8.ApplyCurrentValues(val6);
					}
					text2 = _sSelectionFormula;
					((Control)pnlMain).Visible = true;
					((CrystalReportViewerBase)crvMain).SelectionFormula = text2;
					crvMain.HasCrystalLogo = false;
					crvMain.HasExportButton = true;
					crvMain.HasDrillUpButton = false;
					crvMain.HasPrintButton = true;
					((Control)crvMain).Visible = true;
					crvMain.RefreshReport();
					((Control)pnlMessaggioErrore).Visible = false;
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
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected void cmdEsci_Click(object sender, EventArgs e)
	{
		ReturnToCaller();
	}

	private ParameterFieldDefinition CrystalReportGetParamDefinition(string vsParamName, ref ReportDocument objRpt)
	{
		ParameterFieldDefinition result = null;
		int i = default(int);
		for (ParameterFieldDefinitions parameterFields = objRpt.DataDefinition.ParameterFields; i < ((FieldDefinitions)parameterFields).Count; i = checked(i + 1))
		{
			if (Operators.CompareString(((FieldDefinition)parameterFields[i]).Name.ToUpper(), vsParamName.ToUpper(), false) == 0)
			{
				result = parameterFields[i];
				i = ((FieldDefinitions)parameterFields).Count;
			}
		}
		return result;
	}

	private void cmdDownload_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			if (Operators.CompareString(((Button)cmdDownload).CommandArgument, "", false) != 0)
			{
				string[] array = ((Button)cmdDownload).CommandArgument.Split(new char[1] { ';' });
				if (Operators.CompareString(Strings.Right(array[0], 5).ToUpper(), ".HTML", false) == 0)
				{
					array[1] = array[1].Replace(".HTML", ".XLS");
					array[1] = array[1].Replace(".html", ".XLS");
					if ((int)SendXLSFileToClient(array[0], array[1], bSegnaFileComeDaCancellare: false, ref rsMess) > 0)
					{
						return;
					}
				}
				else if ((int)SendPDFFileToClient(array[0], array[1], bSegnaFileComeDaCancellare: false, ref rsMess) > 0)
				{
					return;
				}
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
			if (Operators.CompareString(rsMess, "", false) != 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void tmrClose_Tick(object sender, EventArgs e)
	{
		try
		{
			tmrClose.Enabled = false;
			cmdEsci_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
