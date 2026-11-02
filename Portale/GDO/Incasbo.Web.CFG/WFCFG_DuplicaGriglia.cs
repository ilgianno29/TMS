using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFCFG_DuplicaGriglia : WFIDBPage
{
	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
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

	[field: AccessedThroughProperty("imgModalita")]
	protected virtual Image imgModalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title")]
	protected virtual Panel cpInfoGen_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Caption")]
	protected virtual Label cpInfoGen_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Image")]
	protected virtual Image cpInfoGen_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNomRif")]
	protected virtual IboWebLabel lblNomRif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NomrifDescrizione")]
	protected virtual IboWebLabel NomrifDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUtente")]
	protected virtual IboWebLabel lblUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UtenteDescrizione")]
	protected virtual IboWebLabel UtenteDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTabella")]
	protected virtual IboWebLabel lblTabella
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabellaValore")]
	protected virtual IboWebLabel TabellaValore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNomrifNuovo")]
	protected virtual IboWebLabel lblNomrifNuovo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NomrifArrivo")]
	protected virtual IboWebTextBox NomrifArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUtenteArrivo")]
	protected virtual IboWebLabel lblUtenteArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UtenteArrivo")]
	protected virtual IboWebComboTlk UtenteArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaTabella")]
	protected virtual IboWebLabel lblNuovaTabella
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaTabella")]
	protected virtual IboWebComboTlk NuovaTabella
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNomRif")]
	protected virtual IboWebTextBox txtNomRif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUtente")]
	protected virtual IboWebTextBox txtUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen")]
	protected virtual CollapsiblePanelExtender cpInfoGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.ALLGRD";
		_Title = base.Translator.Translate("XXX", "Duplicazione Configurazione Griglia", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if ((Operators.CompareString(UtenteArrivo.CustomTag, UtenteArrivo.ObjValue.ToString(), false) == 0) & (Operators.CompareString(NomrifArrivo.Text, NomrifArrivo.CustomTag, false) == 0))
				{
					rsMess = TranslateMessage("XXX", "Impossibile procedere. Selezionare un utente diverso da quello di origine ({0}) oppure un riferimento diverso da quello di origine ({1})", txtUtente.Text, txtNomRif.Text);
				}
				else
				{
					text2 = "SELECT COUNT(*) FROM WFI_ALLGRD WHERE NOMRIF = " + base.DbConn.SQLFormatString(NomrifArrivo.Text) + " ";
					text2 = text2 + "AND UTENTE= " + base.DbConn.SQLFormatString(UtenteArrivo.ObjValue.ToString());
					val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else if (Conversions.ToInteger(obj) > 0)
					{
						rsMess = TranslateMessage("XXX", "Impossibile procedere. Griglia {0} già presente per l'utente {1}", NomrifArrivo.Text, UtenteArrivo.Text);
					}
					else
					{
						val = (FXRETURN)0;
					}
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				text2 = "SELECT DESCRIZIONE %+% ' (' %+% CASE WHEN TIPO='U' THEN 'UTENTE' ELSE 'GRUPPO' END %+% ')' DESCRIZIONE ";
				text2 = text2 + "FROM WFI_UTENTI WHERE CODICE = " + base.DbConn.SQLFormatString(txtUtente.Text);
				text2 = base.DbConn.SqlConvertForServer(text2);
				val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					NomrifDescrizione.Text = txtNomRif.Text;
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
					{
						UtenteDescrizione.Text = Conversions.ToString(obj);
					}
					NomrifArrivo.Text = txtNomRif.Text;
					NomrifArrivo.CustomTag = txtNomRif.Text;
					UtenteArrivo.ObjValue = txtUtente.Text;
					UtenteArrivo.CustomTag = txtUtente.Text;
					NuovaTabella.ObjValue = TabellaValore.ObjValue.ToString();
					NuovaTabella.CustomTag = TabellaValore.ObjValue.ToString();
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeSaveData(ref rsMess);
			if ((int)val2 <= 0)
			{
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
			result = val;
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = DuplicateGridConfiguration(txtNomRif.ObjValue.ToString(), txtUtente.ObjValue.ToString(), NomrifArrivo.ObjValue.ToString(), UtenteArrivo.ObjValue.ToString(), NuovaTabella.ObjValue.ToString(), ref rsMess);
			if ((int)val <= 0)
			{
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

	protected override FXRETURN SaveData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = SaveData(ref rsMess);
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

	protected FXRETURN DuplicateGridConfiguration(string sNomRifOrig, string sUtenteOrig, string sNomRifTarget, string sUtenteTarget, string sNuovaTabellaTarget, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Invalid comparison between Unknown and I4
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Invalid comparison between Unknown and I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Invalid comparison between Unknown and I4
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Invalid comparison between Unknown and I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		StringBuilder stringBuilder = new StringBuilder();
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			string[] array = new string[6]
			{
				"SELECT %%NOMRIF%% NOMRIF, %%UTENTE%% UTENTE, %%NOMTAB%% NOMTAB, DESTAB, OBJECTMANAGERNAME, MINFIL, CANSEL, ROWSPERPAGE, BACKCOLOR, FORCOLOR, BORDERCOLOR, HORIZONTALALIGN, BOLD, ITALIC, FONTSIZE, FONTNAME, FILTRO, FILTROUTENTEOBBLIGATORIO, HEADERSTYLE, PAGERSTYLE, ROWSTYLE, ALTERNATINGROWSTYLE, SELECTEDROWSTYLE, HIGHLIGHTEDROWSTYLE, WHEREAGGIUNTIVA, PREFILTRO, CANPAGE, CANSORT, CANEDIT, TIMERUPDATE, CAPTIONBACKCOLOR, CAPTIONFORCOLOR, CAPTIONBOLD, CAPTIONITALIC, CAPTIONFONTSIZE, CAPTIONFONTNAME, WIDTH, AUTOUPDATEVISIBLE, TIPOGRIGLIA, SELCOLVISIBLE, SHOWFOOTER, CANGROUP, GROUPHEADERITEMSTYLE, GROUPEXPANDED, SHOWGROUPFOOTER, MAXRECORD, MAXRECORDVISIBLE, FIXEDLAYOUT, SCROLLHEIGHT, COLUMNRESIZE, FASTFILTERTYPE FROM WFI_ALLGRD WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"SELECT %%NOMRIF%% NOMRIF, PRORIG, %%UTENTE%% UTENTE, %%NOMTAB%% NOMTAB, NOMCAM, DESCAM, LARCAM, HORIZONTALALIGN, VERTICALALIGN, FORCAM, ORDCAM, ORDDIR, VISIBILE, ISKEY, WRAPCOL, CANSORT, HTMLENCODE, NOMCAMEXP, NOMCAMTOOLTIP, CANEDIT, LARCAMEDIT, INNERSQL, GROUPFIELD, FOOTERTEXT, AGGREGATEFUNC, MAXCHAR, EXTENDEDDESCAM, CSSCLASS, VISIBLEINFILTER FROM WFI_TABGRD WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"SELECT %%NOMRIF%% NOMRIF, %%UTENTE%% UTENTE, NUMBOT, PESBOT, ShowCaption, ShowImage, Ordinamento, Visibile FROM WFI_TABBOT WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"SELECT %%NOMRIF%% NOMRIF, %%UTENTE%% UTENTE, Descrizione, SqlFilter, IsDefault FROM WFI_ALLGRD_FILTER WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"SELECT %%NOMRIF%% NOMRIF, %%UTENTE%% UTENTE, Descrizione, StyleName FROM WFI_ALLGRD_STYLESET WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"SELECT %%NOMRIF%% NOMRIF, %%UTENTE%% UTENTE, NomRep, Ordine, ReportSelectionFormula FROM WFI_ALLGRD_TABREP WHERE NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig)
			};
			string[] array2 = new string[6] { "WFI_ALLGRD", "WFI_TABGRD", "WFI_TABBOT", "WFI_ALLGRD_FILTER", "WFI_ALLGRD_STYLESET", "WFI_ALLGRD_TABREP" };
			string[] array3 = new string[6]
			{
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig),
				"NOMRIF=" + base.DbConn.SQLFormatString(sNomRifOrig) + " AND Utente=" + base.DbConn.SQLFormatString(sUtenteOrig)
			};
			int num = 0;
			string[] array4 = array;
			int num2 = 0;
			while (true)
			{
				if (num2 < array4.Length)
				{
					string text = array4[num2];
					dataTable = null;
					text = text.Replace("%%NOMRIF%%", base.DbConn.SQLFormatString(sNomRifTarget));
					text = text.Replace("%%UTENTE%%", base.DbConn.SQLFormatString(sUtenteTarget));
					text = text.Replace("%%NOMTAB%%", base.DbConn.SQLFormatString(sNuovaTabellaTarget));
					val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					StringCollection stringCollection = null;
					val2 = GenerateInserts.RunProc(CreateApiContext(), array2[num], text, dataTable, false, array3[num], base.DbConn.ServerType, ref stringCollection, ref rsmess);
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
					checked
					{
						num++;
						num2++;
						continue;
					}
				}
				base.DbConn.BeginTransaction();
				string text2 = stringBuilder.ToString();
				if ((int)base.DbConn.ServerType == 1)
				{
					text2 = "";
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("BEGIN ");
					string[] array5 = stringBuilder.ToString().Replace("\r\n", "\n").Split(new char[1] { '\n' });
					string[] array6 = array5;
					foreach (string text3 in array6)
					{
						if (!text3.Trim().StartsWith("--") & !text3.Trim().StartsWith("ALTER") & !text3.Trim().StartsWith("COMMIT"))
						{
							stringBuilder2.Append(text3 + " ");
						}
					}
					stringBuilder2.Append(" END;");
					text2 = stringBuilder2.ToString();
				}
				val2 = base.DbConn.SqlExec(text2, ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
					break;
				}
				base.DbConn.CommitTransaction();
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
			base.DbConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override void ReturnToCaller()
	{
		base.ReturnToCaller();
	}
}
