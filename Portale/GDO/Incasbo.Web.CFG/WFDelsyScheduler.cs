using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.CFG;

public class WFDelsyScheduler : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTask")]
	private IboWebComboTlk _cmbTask;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SchedulazioneTipo")]
	private IboWebComboTlk _SchedulazioneTipo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GiorniSettimana")]
	private IboDropDownList _GiorniSettimana;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReset")]
	private IboWebButton _btnReset;

	protected string _Applicazione;

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

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtProgressivo")]
	protected virtual IboWebHidden txtProgressivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIstanza")]
	protected virtual IboWebLabel lblIstanza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIstanza")]
	protected virtual IboWebTextBox txtIstanza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSecondiDedicati")]
	protected virtual IboWebLabel lblSecondiDedicati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SecondiDedicati")]
	protected virtual IboWebNumericTlk SecondiDedicati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("td_lblAttivo")]
	protected virtual HtmlTableCell td_lblAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgAttenzione")]
	protected virtual Image imgAttenzione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttivo")]
	protected virtual IboWebLabel lblAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("td_chkAttivo")]
	protected virtual HtmlTableCell td_chkAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAttivo")]
	protected virtual IboWebCheckBox chkAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblApplicazioneDesc")]
	protected virtual IboWebLabel lblApplicazioneDesc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblApplicazione")]
	protected virtual IboWebLabel lblApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTask")]
	protected virtual IboWebLabel lblTask
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbTask
	{
		[CompilerGenerated]
		get
		{
			return _cmbTask;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbTask_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbTask;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbTask = value;
			val2 = _cmbTask;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblDescrizione")]
	protected virtual IboWebLabel lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDescrizione")]
	protected virtual IboWebTextBox txtDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblArgomenti")]
	protected virtual IboWebLabel lblArgomenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtArgomenti")]
	protected virtual IboWebTextBox txtArgomenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpScheduler_Title")]
	protected virtual Panel cpScheduler_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpScheduler_Title_Caption")]
	protected virtual Label cpScheduler_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpScheduler_Body")]
	protected virtual Panel cpScheduler_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSchedulazioneTipo")]
	protected virtual IboWebLabel lblSchedulazioneTipo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk SchedulazioneTipo
	{
		[CompilerGenerated]
		get
		{
			return _SchedulazioneTipo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(SchedulazioneTipo_SelectedIndexChanged);
			IboWebComboTlk schedulazioneTipo = _SchedulazioneTipo;
			if (schedulazioneTipo != null)
			{
				((RadComboBox)schedulazioneTipo).SelectedIndexChanged -= val;
			}
			_SchedulazioneTipo = value;
			schedulazioneTipo = _SchedulazioneTipo;
			if (schedulazioneTipo != null)
			{
				((RadComboBox)schedulazioneTipo).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblSchedulazioneArgomento")]
	protected virtual IboWebLabel lblSchedulazioneArgomento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tempo")]
	protected virtual IboWebNumericTlk Tempo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList GiorniSettimana
	{
		[CompilerGenerated]
		get
		{
			return _GiorniSettimana;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = GiorniSettimana_SelectedIndexChanged;
			IboDropDownList giorniSettimana = _GiorniSettimana;
			if (giorniSettimana != null)
			{
				((ListControl)giorniSettimana).SelectedIndexChanged -= eventHandler;
			}
			_GiorniSettimana = value;
			giorniSettimana = _GiorniSettimana;
			if (giorniSettimana != null)
			{
				((ListControl)giorniSettimana).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("PrimoUltimo")]
	protected virtual IboWebTextBox PrimoUltimo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel1")]
	protected virtual IboWebLabel IboWebLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInizioData")]
	protected virtual IboWebLabel lblInizioData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InizioData")]
	protected virtual IboWebDate InizioData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFineData")]
	protected virtual IboWebLabel lblFineData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FineData")]
	protected virtual IboWebDate FineData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInizioOra")]
	protected virtual IboWebLabel lblInizioOra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InizioOra")]
	protected virtual IboWebDate InizioOra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFineOra")]
	protected virtual IboWebLabel lblFineOra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FineOra")]
	protected virtual IboWebDate FineOra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfEsec_Title")]
	protected virtual Panel cpInfEsec_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfEsec_Title_Caption")]
	protected virtual Label cpInfEsec_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfEsec_Body")]
	protected virtual Panel cpInfEsec_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUltimaEsecuzioneInizioDesc2")]
	protected virtual IboWebLabel lblUltimaEsecuzioneInizioDesc2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUltimaEsecuzioneInizio")]
	protected virtual IboWebLabel lblUltimaEsecuzioneInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroEsecuzioniDesc")]
	protected virtual IboWebLabel lblNumeroEsecuzioniDesc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroEsecuzioni")]
	protected virtual IboWebLabel lblNumeroEsecuzioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUltimaEsecuzioneFineDesc")]
	protected virtual IboWebLabel lblUltimaEsecuzioneFineDesc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUltimaEsecuzioneFine")]
	protected virtual IboWebLabel lblUltimaEsecuzioneFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroErroriDesc")]
	protected virtual IboWebLabel lblNumeroErroriDesc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroErrori")]
	protected virtual IboWebLabel lblNumeroErrori
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnReset
	{
		[CompilerGenerated]
		get
		{
			return _btnReset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnReset_Click;
			IboWebButton val = _btnReset;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnReset = value;
			val = _btnReset;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("txtInizioData")]
	protected virtual IboWebTextBox txtInizioData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFineData")]
	protected virtual IboWebTextBox txtFineData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtInizioOra")]
	protected virtual IboWebTextBox txtInizioOra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFineOra")]
	protected virtual IboWebTextBox txtFineOra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSchedulazioneTipo")]
	protected virtual IboWebTextBox txtSchedulazioneTipo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSchedulazioneArgomento")]
	protected virtual IboWebTextBox txtSchedulazioneArgomento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFDelsyScheduler()
	{
		_Applicazione = "";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.CFG.SCHEDULER";
		_Title = base.Translator.Translate("XXX", "Scheduler", new string[0]);
		_Applicazione = ((Page)this).Request.QueryString["APP"];
		if ((_Applicazione == null) | (Operators.CompareString(_Applicazione, "", false) == 0))
		{
			_Applicazione = "DSI";
		}
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Invalid comparison between Unknown and I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
				{
					lblApplicazione.ObjValue = _Applicazione;
				}
				cmbTask.SqlQueryWhere = "APPLICAZIONE = " + base.DbConn.SQLFormatString(lblApplicazione.ObjValue.ToString());
				if ((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0))
				{
					IboWebComboTlk val3;
					(val3 = cmbTask).SqlQueryWhere = val3.SqlQueryWhere + " AND Attivo='S'";
				}
				TipoSchedulazione(txtSchedulazioneTipo.Text);
				CampiValiditaCaricamento();
				((Control)imgAttenzione).Visible = false;
				if (!((Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
				{
					goto IL_021e;
				}
				string text2 = "SELECT Attivo FROM DelsyTasks WHERE CODICE=" + base.DbConn.SQLFormatString(cmbTask.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Operators.CompareString(obj.ToString(), "S", false) != 0)
					{
						chkAttivo.Enabled = false;
						((Control)imgAttenzione).Visible = true;
						((WebControl)imgAttenzione).ToolTip = TranslateMessage("XXX", "La schedulazione non è attivabile in quanto il task risulta disattivato.{0}E' necessario procedere prima all'attivazione del relativo task.", "<br />");
					}
					goto IL_021e;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_021e:
			if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
			{
				btnReset_Click(btnReset, new EventArgs());
			}
			val = (FXRETURN)0;
			end_IL_000b:;
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
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
			val2 = base.AfterSaveData(ref rsMess);
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

	protected override FXRETURN BeforeLoadData(ref string rsMess)
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
			val2 = base.BeforeLoadData(ref rsMess);
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

	protected override FXRETURN LoadPage(ref string rsMess)
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
			val2 = base.LoadPage(ref rsMess);
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			CampiValiditaSalvataggio();
			SchedulazioneArgomentoSalvataggio();
			val2 = base.CheckData(ref rsMess);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected void cmbTask_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		string text = "";
		try
		{
			if (Operators.CompareString(txtDescrizione.Text, "", false) == 0)
			{
				txtDescrizione.Text = cmbTask.Text;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val == 0)
			{
				base.MasterPage.MasterUpdatePanel.Update();
			}
		}
	}

	protected void GiorniSettimana_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		try
		{
			txtSchedulazioneArgomento.Text = GiorniSettimana.ObjValue.ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}

	protected void SchedulazioneTipo_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		string text = "";
		string text2 = "";
		try
		{
			txtSchedulazioneArgomento.Text = "";
			text2 = SchedulazioneTipo.ObjValue.ToString();
			lblNumeroEsecuzioni.ObjValue = 0;
			lblNumeroErrori.ObjValue = 0;
			lblUltimaEsecuzioneInizio.Text = "";
			lblUltimaEsecuzioneFine.Text = "";
			TipoSchedulazione(text2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val == 0)
			{
				base.MasterPage.MasterUpdatePanel.Update();
			}
		}
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		try
		{
			lblUltimaEsecuzioneInizio.ObjValue = "";
			lblNumeroEsecuzioni.ObjValue = "0";
			lblUltimaEsecuzioneFine.ObjValue = "";
			lblNumeroErrori.ObjValue = "0";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void TipoSchedulazione(string vsTipo)
	{
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		try
		{
			text = vsTipo;
			switch (vsTipo)
			{
			case "0":
			case "1":
			case "Z":
			case "X":
			case "Z0":
			case "Z1":
			case "X0":
			case "X1":
				Tempo.Visible = false;
				Tempo.Required = false;
				GiorniSettimana.Visible = false;
				GiorniSettimana.Required = false;
				PrimoUltimo.Visible = false;
				GiorniSettimana.Required = false;
				lblSchedulazioneArgomento.Visible = false;
				break;
			case "D":
			case "H":
			case "M":
			case "N":
			case "S":
			case "Y":
				Tempo.Visible = true;
				Tempo.Required = true;
				GiorniSettimana.Visible = false;
				GiorniSettimana.Required = false;
				PrimoUltimo.Visible = false;
				GiorniSettimana.Required = false;
				lblSchedulazioneArgomento.Visible = true;
				break;
			}
			switch (vsTipo)
			{
			case "0":
			case "1":
				txtSchedulazioneArgomento.Text = "0";
				break;
			case "Z":
				vsTipo = ((Operators.CompareString(txtSchedulazioneArgomento.Text, "0", false) != 0) ? "Z1" : "Z0");
				break;
			case "X0":
				txtSchedulazioneArgomento.Text = "0";
				text = "X";
				break;
			case "X1":
				txtSchedulazioneArgomento.Text = "1";
				text = "X";
				break;
			case "Z0":
				txtSchedulazioneArgomento.Text = "0";
				text = "Z";
				break;
			case "Z1":
				txtSchedulazioneArgomento.Text = "1";
				text = "Z";
				break;
			case "X":
				vsTipo = ((Operators.CompareString(txtSchedulazioneArgomento.Text, "0", false) != 0) ? "X1" : "X0");
				break;
			case "W":
			{
				Tempo.Visible = false;
				GiorniSettimana.Visible = true;
				GiorniSettimana.Required = true;
				PrimoUltimo.Visible = false;
				GiorniSettimana.Required = true;
				lblSchedulazioneArgomento.Visible = true;
				lblSchedulazioneArgomento.Text = "Giorno:";
				IboDropDownList giorniSettimana = GiorniSettimana;
				string text2 = txtSchedulazioneArgomento.Text;
				string rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)giorniSettimana, text2, ref rsMess);
				break;
			}
			case "D":
				lblSchedulazioneArgomento.Text = "Giorni:";
				Tempo.Text = txtSchedulazioneArgomento.Text;
				Tempo.FieldDescription = "Numero Giorni";
				break;
			case "H":
				lblSchedulazioneArgomento.Text = "Ore:";
				Tempo.FieldDescription = "Numero Ore";
				Tempo.Text = txtSchedulazioneArgomento.Text;
				break;
			case "M":
				lblSchedulazioneArgomento.Text = "Mesi:";
				Tempo.FieldDescription = "Numero Mesi";
				Tempo.Text = txtSchedulazioneArgomento.Text;
				break;
			case "N":
				lblSchedulazioneArgomento.Text = "Minuti:";
				Tempo.FieldDescription = "Numero Minuti";
				Tempo.Text = txtSchedulazioneArgomento.Text;
				break;
			case "S":
				lblSchedulazioneArgomento.Text = "Secondi:";
				Tempo.FieldDescription = "Numero Secondi";
				Tempo.Text = txtSchedulazioneArgomento.Text;
				break;
			case "Y":
				lblSchedulazioneArgomento.Text = "Anni:";
				Tempo.FieldDescription = "Numero Anni";
				Tempo.Text = txtSchedulazioneArgomento.Text;
				break;
			default:
				Tempo.Visible = false;
				GiorniSettimana.Visible = false;
				GiorniSettimana.Required = false;
				PrimoUltimo.Visible = false;
				GiorniSettimana.Required = false;
				lblSchedulazioneArgomento.Visible = false;
				break;
			}
			SchedulazioneTipo.ObjValue = vsTipo;
			txtSchedulazioneTipo.Text = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void CampiValiditaSalvataggio()
	{
		try
		{
			txtInizioData.ObjValue = "";
			if (Operators.CompareString(InizioData.Text, "", false) != 0)
			{
				txtInizioData.ObjValue = Strings.Format((object)InizioData.getDateValue, "yyyyMMdd");
			}
			txtFineData.ObjValue = "";
			if (Operators.CompareString(FineData.Text, "", false) != 0)
			{
				txtFineData.ObjValue = Strings.Format((object)FineData.getDateValue, "yyyyMMdd");
			}
			if (Operators.CompareString(InizioOra.Text, "", false) != 0)
			{
				txtInizioOra.Text = InizioOra.Text.Replace(":", "");
			}
			else
			{
				txtInizioOra.Text = "000000";
			}
			if (Operators.CompareString(FineOra.Text, "", false) != 0)
			{
				txtFineOra.Text = FineOra.Text.Replace(":", "");
			}
			else
			{
				txtFineOra.Text = "235959";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void CampiValiditaCaricamento()
	{
		if (Operators.CompareString(txtInizioData.ObjValue.ToString(), "", false) != 0)
		{
			try
			{
				DateTime dateTime = new DateTime(Conversions.ToInteger(txtInizioData.Text.Substring(0, 4)), Conversions.ToInteger(txtInizioData.Text.Substring(4, 2)), Conversions.ToInteger(txtInizioData.Text.Substring(6, 2)));
				InizioData.ObjValue = dateTime;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(txtFineData.ObjValue.ToString(), "", false) != 0)
		{
			try
			{
				DateTime dateTime = new DateTime(Conversions.ToInteger(txtFineData.Text.Substring(0, 4)), Conversions.ToInteger(txtFineData.Text.Substring(4, 2)), Conversions.ToInteger(txtFineData.Text.Substring(6, 2)));
				FineData.ObjValue = dateTime;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			DateTime dateTime = new DateTime(1900, 1, 1, Conversions.ToInteger(txtInizioOra.Text.Substring(0, 2)), Conversions.ToInteger(txtInizioOra.Text.Substring(2, 2)), Conversions.ToInteger(txtInizioOra.Text.Substring(4, 2)));
			InizioOra.ObjValue = dateTime;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		try
		{
			DateTime dateTime = new DateTime(1900, 1, 1, Conversions.ToInteger(txtFineOra.Text.Substring(0, 2)), Conversions.ToInteger(txtFineOra.Text.Substring(2, 2)), Conversions.ToInteger(txtFineOra.Text.Substring(4, 2)));
			FineOra.ObjValue = dateTime;
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
	}

	private void SchedulazioneArgomentoSalvataggio()
	{
		switch (txtSchedulazioneTipo.Text)
		{
		case "D":
		case "H":
		case "M":
		case "N":
		case "S":
		case "Y":
			txtSchedulazioneArgomento.Text = Tempo.Text;
			break;
		}
	}
}
