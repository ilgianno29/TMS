using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFFunctionManager : WFIPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tmrReturnToCaller")]
	private Timer _tmrReturnToCaller;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnConferma")]
	private IboWebButton _btnConferma;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAnnulla")]
	private IboWebButton _btnAnnulla;

	private FunctionArguments _objFunctionArguments;

	protected virtual Timer tmrReturnToCaller
	{
		[CompilerGenerated]
		get
		{
			return _tmrReturnToCaller;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler<EventArgs> eventHandler = tmpReturnToCaller_Tick;
			Timer val = _tmrReturnToCaller;
			if (val != null)
			{
				val.Tick -= eventHandler;
			}
			_tmrReturnToCaller = value;
			val = _tmrReturnToCaller;
			if (val != null)
			{
				val.Tick += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDetailFormMainTable")]
	protected virtual Panel pnlDetailFormMainTable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMessaggioConferma")]
	protected virtual IboWebLabel lblMessaggioConferma
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMessaggioConferma2")]
	protected virtual IboWebLabel lblMessaggioConferma2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFFuncToCall")]
	protected virtual HiddenField HFFuncToCall
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnConferma
	{
		[CompilerGenerated]
		get
		{
			return _btnConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnConferma_Click;
			IboWebButton val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnConferma = value;
			val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _btnAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAnnulla_Click;
			IboWebButton val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAnnulla = value;
			val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	public WFFunctionManager()
	{
		((Control)this).Load += Page_Load;
		_objFunctionArguments = null;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Invalid comparison between Unknown and I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "S";
		try
		{
			CallStackAdd();
			if (((Page)this).Session["FunctionArgs"] == null)
			{
				rsMess = TranslateMessage("XXX", "Errore nella lettura dei dati di funzione. Chiamata non consentita.");
				return;
			}
			_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
			if ((Operators.CompareString(_objFunctionArguments.Name, "CALLFUNC", false) != 0) & !_objFunctionArguments.Name.StartsWith("GOTOWITHMSG"))
			{
				rsMess = TranslateMessage("XXX", "Contesto non corretto. Chiamata non consentita.");
				return;
			}
			if (!((Control)this).Page.IsPostBack)
			{
				text3 = ((_objFunctionArguments.Argomento1 == null) ? "" : _objFunctionArguments.Argomento1.ToString());
				if (Operators.CompareString(text3, "", false) != 0)
				{
					text = ((_objFunctionArguments.Argomento2 == null) ? "" : _objFunctionArguments.Argomento2.ToString());
					text2 = ((_objFunctionArguments.Argomento3 == null) ? "" : _objFunctionArguments.Argomento3.ToString());
					text4 = ((_objFunctionArguments.Argomento4 == null) ? "-" : _objFunctionArguments.Argomento4.ToString());
					text5 = ((_objFunctionArguments.Argomento5 == null) ? "S" : _objFunctionArguments.Argomento5.ToString());
				}
				else
				{
					text = TranslateMessage("XXX", "Errore in fase di lancio della procedura");
					text2 = TranslateMessage("XXX", "La configurazione non è corretta. Non è stato specificato il nome della procedura da lanciare");
					text4 = "Errore";
				}
				_objFunctionArguments.Argomento5 = "";
				_objFunctionArguments.Argomento4 = "";
				_objFunctionArguments.Argomento3 = "";
				_objFunctionArguments.Argomento2 = "";
				_objFunctionArguments.Argomento1 = "";
				lblMessaggioConferma.Text = text;
				lblMessaggioConferma2.Text = text2;
				lblTitle.Text = text4;
				HFFuncToCall.Value = text3;
				if (Operators.CompareString(text5, "S", false) == 0)
				{
					((Control)btnAnnulla).Focus();
				}
				else
				{
					btnConferma_Click(btnConferma, new EventArgs());
				}
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
			if ((int)val > 0)
			{
				ErroreCaricamento(bWithReturnToCaller: true, rsMess);
			}
			CallStackRemove();
		}
	}

	protected override void ErroreCaricamento(bool bWithReturnToCaller, string sMess)
	{
		base.ErroreCaricamento(bWithReturnToCaller, sMess);
	}

	protected void btnAnnulla_Click(object sender, EventArgs e)
	{
		ReturnToCaller();
	}

	protected override void ReturnToCaller()
	{
		string text = "";
		text = _objFunctionArguments.CallerPath;
		if (_objFunctionArguments.CallerQueryString.Length > 0)
		{
			text = text + "?" + _objFunctionArguments.CallerQueryString;
		}
		IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
		IboResponseRedirect(ref robjCallStackHandler, ref text);
	}

	protected void btnConferma_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Invalid comparison between Unknown and I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Invalid comparison between Unknown and I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Invalid comparison between Unknown and I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Invalid comparison between Unknown and I4
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		string text = "";
		string rsWarning = "";
		string text2 = "";
		bool ReturnToCaller = default(bool);
		try
		{
			CallStackAdd();
			rsmess = "";
			switch (HFFuncToCall.Value.ToUpper())
			{
			case "GRID.TEST":
			{
				if (_objFunctionArguments.Data["NOMRIF"].FieldValuesCount == 0)
				{
					rsmess = TranslateMessage("XXX", "Nessun record selezionato");
					return;
				}
				text2 = "~/WFI/Form/WFStandardGrid.aspx?ForceResetFilter=S&GridMode=TEST&NomRif=" + _objFunctionArguments.Data["NOMRIF"].get_FieldValues(0).ToString();
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref text2, RegisterPageInQueue: false);
				break;
			}
			case "GRID.TEST.TLK":
			{
				if (_objFunctionArguments.Data["NOMRIF"].FieldValuesCount == 0)
				{
					rsmess = TranslateMessage("XXX", "Nessun record selezionato");
					return;
				}
				text2 = "~/WFI/Form/WFStandardGridTlk.aspx?ForceResetFilter=S&GridMode=TEST&NomRif=" + _objFunctionArguments.Data["NOMRIF"].get_FieldValues(0).ToString();
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref text2, RegisterPageInQueue: false);
				break;
			}
			case "STATISTIC.DOWNLOAD":
			{
				ReturnToCaller = false;
				if (_objFunctionArguments.Data.Count == 0)
				{
					rsmess = TranslateMessage("XXX", "Nessun record selezionato");
					return;
				}
				string id = _objFunctionArguments.Data["PROGRESSIVO"].get_FieldValues(0).ToString();
				val2 = StatisticDownload(id, ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				((Control)pnlDetailFormMainTable).Visible = false;
				tmrReturnToCaller.Enabled = true;
				break;
			}
			case "GRID.EXPSQL":
			{
				ReturnToCaller = false;
				if (_objFunctionArguments.Data.Count == 0)
				{
					rsmess = TranslateMessage("XXX", "Nessun record selezionato");
					return;
				}
				string sNomRif = _objFunctionArguments.Data["NOMRIF"].get_FieldValues(0).ToString();
				string sUtente = _objFunctionArguments.Data["UTENTE"].get_FieldValues(0).ToString();
				val2 = ExportGridToSqlInsert(sNomRif, sUtente, ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				((Control)pnlDetailFormMainTable).Visible = false;
				tmrReturnToCaller.Enabled = true;
				break;
			}
			default:
			{
				string text3 = "";
				string text4 = "";
				string text5 = "";
				IIboProxyApiFunctions iboProxyApiFunctions;
				if (HFFuncToCall.Value.Contains(","))
				{
					string[] array = HFFuncToCall.Value.Split(new char[1] { ',' });
					if (array.Count() == 3)
					{
						text4 = array[0];
						text3 = array[1];
						text5 = array[2];
					}
					else if (array.Count() == 2)
					{
						text3 = array[0];
						text5 = array[1];
					}
					iboProxyApiFunctions = ((Operators.CompareString(text4, "", false) == 0) ? ProxyApiFunctions.GetProxy(text3) : ProxyApiFunctions.GetProxy(text4 + ";" + text3));
				}
				else
				{
					text5 = HFFuncToCall.Value.ToUpper();
					iboProxyApiFunctions = ProxyApiFunctions.GetProxy("");
				}
				IIboProxyApiFunctions iboProxyApiFunctions2 = iboProxyApiFunctions;
				string sFunctionName = text5;
				ref FunctionArguments objFunctionArguments = ref _objFunctionArguments;
				IboSessionEnvironment rObjSessionEnvironment = base.SessionEnvironment;
				WFIPage _Page = this;
				val2 = iboProxyApiFunctions2.CallApiFunction(sFunctionName, ref objFunctionArguments, ref rObjSessionEnvironment, ref _Page, ref rsWarning, ref ReturnToCaller, ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				break;
			}
			}
			val = (FXRETURN)0;
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
			if (_objFunctionArguments.Parameters.ContainsKey("CallerPage"))
			{
				_objFunctionArguments.Parameters.Remove("CallerPage");
			}
			if ((int)val > 0)
			{
				WriteErrorMessageWithReturnToCaller(TranslateMessage("XXX", "Si è verificato un errore"), rsmess);
			}
			else if (Operators.CompareString(rsWarning, "", false) != 0)
			{
				WriteErrorMessageWithReturnToCaller(TranslateMessage("XXX", "Attenzione!"), Strings.Replace(rsWarning, "\r\n", "<br>", 1, -1, (CompareMethod)0));
			}
			else if (ReturnToCaller)
			{
				this.ReturnToCaller();
			}
			CallStackRemove();
		}
	}

	protected FXRETURN ExportGridToSqlInsert(string sNomRif, string sUtente, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Invalid comparison between Unknown and I4
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Invalid comparison between Unknown and I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Invalid comparison between Unknown and I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Invalid comparison between Unknown and I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		List<DataTable> list = new List<DataTable>();
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			string[] array = new string[7]
			{
				"SELECT * FROM WFI_OBJECTMANAGER WHERE CODICE=(SELECT OBJECTMANAGERNAME FROM WFI_ALLGRD WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente) + ")",
				"SELECT NOMRIF, UTENTE, NOMTAB, DESTAB, OBJECTMANAGERNAME, MINFIL, CANSEL, ROWSPERPAGE, BACKCOLOR, FORCOLOR, BORDERCOLOR, HORIZONTALALIGN, BOLD, ITALIC, FONTSIZE, FONTNAME, FILTRO, FILTROUTENTEOBBLIGATORIO, HEADERSTYLE, PAGERSTYLE, ROWSTYLE, ALTERNATINGROWSTYLE, SELECTEDROWSTYLE, HIGHLIGHTEDROWSTYLE, WHEREAGGIUNTIVA, PREFILTRO, CANPAGE, CANSORT, CANEDIT, TIMERUPDATE, CAPTIONBACKCOLOR, CAPTIONFORCOLOR, CAPTIONBOLD, CAPTIONITALIC, CAPTIONFONTSIZE, CAPTIONFONTNAME, WIDTH, AUTOUPDATEVISIBLE, TIPOGRIGLIA, SELCOLVISIBLE, SHOWFOOTER, CANGROUP, GROUPHEADERITEMSTYLE, GROUPEXPANDED, SHOWGROUPFOOTER, MAXRECORD, MAXRECORDVISIBLE, FIXEDLAYOUT, SCROLLHEIGHT, COLUMNRESIZE, FASTFILTERTYPE FROM WFI_ALLGRD WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"SELECT NOMRIF, PRORIG, UTENTE, NOMTAB, NOMCAM, DESCAM, LARCAM, HORIZONTALALIGN, VERTICALALIGN, FORCAM, ORDCAM, ORDDIR, VISIBILE, ISKEY, WRAPCOL, CANSORT, HTMLENCODE, NOMCAMEXP, NOMCAMTOOLTIP, CANEDIT, LARCAMEDIT, INNERSQL, GROUPFIELD, FOOTERTEXT, AGGREGATEFUNC, MAXCHAR, EXTENDEDDESCAM, CSSCLASS, VISIBLEINFILTER FROM WFI_TABGRD WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"SELECT * FROM WFI_TABBOT WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"SELECT * FROM WFI_ALLGRD_FILTER WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"SELECT * FROM WFI_ALLGRD_STYLESET WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"SELECT * FROM WFI_ALLGRD_TABREP WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente)
			};
			string[] array2 = new string[7] { "WFI_OBJECTMANAGER", "WFI_ALLGRD", "WFI_TABGRD", "WFI_TABBOT", "WFI_ALLGRD_FILTER", "WFI_ALLGRD_STYLESET", "WFI_ALLGRD_TABREP" };
			string[] array3 = new string[7]
			{
				"CODICE=(SELECT OBJECTMANAGERNAME FROM WFI_ALLGRD WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente) + ")",
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRif) + " AND Utente=" + base.DbConn.SQLFormatString(sUtente)
			};
			stringBuilder.AppendLine("-- **********************************************************************************");
			stringBuilder.AppendLine("-- ");
			stringBuilder.AppendLine("-- S Q L   S E R V E R");
			stringBuilder.AppendLine("-- ");
			stringBuilder.AppendLine("-- **********************************************************************************");
			stringBuilder2.AppendLine("");
			stringBuilder2.AppendLine("-- **********************************************************************************");
			stringBuilder2.AppendLine("-- ");
			stringBuilder2.AppendLine("-- O R A C L E");
			stringBuilder2.AppendLine("-- ");
			stringBuilder2.AppendLine("-- **********************************************************************************");
			int num = 0;
			string[] array4 = array;
			int num2 = 0;
			while (true)
			{
				if (num2 < array4.Length)
				{
					string text = array4[num2];
					dataTable = null;
					val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					StringCollection stringCollection = null;
					StringCollection stringCollection2 = null;
					val2 = GenerateInserts.RunProc(CreateApiContext(), array2[num], text, dataTable, true, array3[num], (eServerType)0, ref stringCollection, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					StringEnumerator enumerator = stringCollection.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						stringBuilder.Append(current + "\r\n");
					}
					stringBuilder.Append("\r\n");
					val2 = GenerateInserts.RunProc(CreateApiContext(), array2[num], text, dataTable, true, array3[num], (eServerType)1, ref stringCollection2, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					StringEnumerator enumerator2 = stringCollection2.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						stringBuilder2.Append(current2 + "\r\n");
					}
					stringBuilder2.Append("\r\n");
					checked
					{
						num++;
						num2++;
						continue;
					}
				}
				if (stringBuilder.Length > 0)
				{
					string text2 = GenerateTempFileName("GridScript_*.txt");
					string ZipFileName = "";
					File.WriteAllText(text2, stringBuilder.ToString());
					File.AppendAllText(text2, stringBuilder2.ToString());
					IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
					string rsMess = "";
					sessionEnvironment.AddFileToDelete(text2, ref rsMess);
					val2 = ZipFile(text2, ref ZipFileName, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
					string sNomeFile = ZipFileName;
					rsMess = "";
					sessionEnvironment2.AddFileToDelete(sNomeFile, ref rsMess);
					WindowPopupProperties windowPopupProperties = new WindowPopupProperties();
					FileInfo fileInfo = new FileInfo(ZipFileName);
					windowPopupProperties.Address = "../../Download/" + fileInfo.Name;
					windowPopupProperties.Address.Replace("\\", "/");
					((WFIPage)(object)((Control)this).Page).Client_OpenWindowOnLoadPage(windowPopupProperties);
				}
				val = (FXRETURN)0;
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

	protected FXRETURN StatisticDownload(string id, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DataTable dataTable = null;
			string text = "SELECT * FROM WFI_STATISTICHE_QUEUE WHERE Progressivo=" + base.DbConn.SQLFormatString(id);
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dataTable.Rows.Count <= 0)
				{
					goto IL_01bd;
				}
				byte[] bytes = (byte[])dataTable.Rows[0]["StatisticContent"];
				string text2 = base.SessionEnvironment.WebApplicationDownloadDir + dataTable.Rows[0]["StatisticFilename"].ToString() + "." + dataTable.Rows[0]["StatisticContentExtension"].ToString();
				string ZipFileName = base.SessionEnvironment.WebApplicationDownloadDir + dataTable.Rows[0]["StatisticFilename"].ToString() + ".zip";
				File.Delete(text2);
				File.WriteAllBytes(text2, bytes);
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string rsMess = "";
				sessionEnvironment.AddFileToDelete(text2, ref rsMess);
				File.Delete(ZipFileName);
				val2 = ZipFile(text2, ref ZipFileName, ref rsmess);
				if ((int)val2 <= 0)
				{
					IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
					string sNomeFile = ZipFileName;
					rsMess = "";
					sessionEnvironment2.AddFileToDelete(sNomeFile, ref rsMess);
					WindowPopupProperties windowPopupProperties = new WindowPopupProperties();
					FileInfo fileInfo = new FileInfo(ZipFileName);
					windowPopupProperties.Address = "../../Download/" + fileInfo.Name;
					windowPopupProperties.Address.Replace("\\", "/");
					((WFIPage)(object)((Control)this).Page).Client_OpenWindowOnLoadPage(windowPopupProperties);
					goto IL_01bd;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_01bd:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	private void tmpReturnToCaller_Tick(object sender, EventArgs e)
	{
		tmrReturnToCaller.Enabled = false;
		ReturnToCaller();
	}

	public override void OpenGridInPage(string NomRif, string title, string WhereAggiuntiva)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGrid.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?GridMode=DETAILS&NomRif=" + NomRif + "&ForceResetFilter=S", "~/", base.SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			base.SessionEnvironment.SessionVariables.Remove(key);
			base.SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			base.SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?GridMode=DETAILS&NomRif=" + NomRif + "&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", base.SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		if (Operators.CompareString(title, "", false) != 0)
		{
			text = text + "&CAPT=" + title;
		}
		IboAppCallStackHandling robjCallStackHandler = base.CallStackHandler;
		IboResponseRedirect(ref robjCallStackHandler, ref text, RegisterPageInQueue: false);
	}
}
