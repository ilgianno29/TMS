using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFCFGUtenti_OrganizzazioniWizard2 : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("optOrganizzazioneInternaEsterna")]
	private IboWebRadioButtonList _optOrganizzazioneInternaEsterna;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbOrganizzazioneTipoSoggetto")]
	private IboDropDownList _cmbOrganizzazioneTipoSoggetto;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGeneraPassword")]
	private IboWebButton _btnGeneraPassword;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAggiungi")]
	private IboWebButton _btnAggiungi;

	private const string kTipoSoggettoOrganizzazioneInterna = "XXX";

	private DateTime dDataScadenzaPassword;

	private const int iLunghezzaPasswordAutomatica = 8;

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

	[field: AccessedThroughProperty("lblCodice")]
	protected virtual IboWebLabel lblCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodice")]
	protected virtual IboWebTextBox txtCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrganizzazioneInternaEsterna")]
	protected virtual IboWebLabel lblOrganizzazioneInternaEsterna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebRadioButtonList optOrganizzazioneInternaEsterna
	{
		[CompilerGenerated]
		get
		{
			return _optOrganizzazioneInternaEsterna;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = optOrganizzazioneInternaEsterna_SelectedIndexChanged;
			IboWebRadioButtonList val = _optOrganizzazioneInternaEsterna;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_optOrganizzazioneInternaEsterna = value;
			val = _optOrganizzazioneInternaEsterna;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblAttivo")]
	protected virtual IboWebLabel lblAttivo
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

	[field: AccessedThroughProperty("lblFiltroUtente")]
	protected virtual IboWebLabel lblFiltroUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFiltroUtente")]
	protected virtual IboWebCheckBox chkFiltroUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPeso")]
	protected virtual IboWebLabel lblPeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPeso")]
	protected virtual IboWebNumericTlk txtPeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLingua")]
	protected virtual IboWebLabel lblLingua
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbLingua")]
	protected virtual IboDropDownList cmbLingua
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltro")]
	protected virtual IboWebLabel lblFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltro")]
	protected virtual IboWebTextBox txtFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrganizzazioneTipoSoggetto")]
	protected virtual IboWebLabel lblOrganizzazioneTipoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList cmbOrganizzazioneTipoSoggetto
	{
		[CompilerGenerated]
		get
		{
			return _cmbOrganizzazioneTipoSoggetto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmbOrganizzazioneTipoSoggetto_SelectedIndexChanged;
			IboDropDownList val = _cmbOrganizzazioneTipoSoggetto;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_cmbOrganizzazioneTipoSoggetto = value;
			val = _cmbOrganizzazioneTipoSoggetto;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("txtPassword")]
	protected virtual IboWebTextBox txtPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipo")]
	protected virtual IboWebTextBox txtTipo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Gruppo")]
	protected virtual IboWebTextBox Gruppo
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

	[field: AccessedThroughProperty("cpUtenti_Title")]
	protected virtual Panel cpUtenti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpUtenti_Title_Caption")]
	protected virtual Label cpUtenti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpUtenti_Title_Image")]
	protected virtual Image cpUtenti_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpUtenti_Body")]
	protected virtual Panel cpUtenti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceUtente")]
	protected virtual IboWebLabel lblCodiceUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CodiceUtente")]
	protected virtual IboWebTextBox CodiceUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPassword")]
	protected virtual IboWebLabel lblPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordUtente")]
	protected virtual IboWebTextBox PasswordUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGeneraPassword
	{
		[CompilerGenerated]
		get
		{
			return _btnGeneraPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGeneraPassword_Click;
			IboWebButton val = _btnGeneraPassword;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGeneraPassword = value;
			val = _btnGeneraPassword;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblDescrizioneUtente")]
	protected virtual IboWebLabel lblDescrizioneUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DescrizioneUtente")]
	protected virtual IboWebTextBox DescrizioneUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpUtenti")]
	protected virtual CollapsiblePanelExtender cpUtenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSoggetti_Title")]
	protected virtual Panel cpSoggetti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSoggetti_Title_Caption")]
	protected virtual Label cpSoggetti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSoggetti_Title_Image")]
	protected virtual Image cpSoggetti_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSoggetti_Body")]
	protected virtual Panel cpSoggetti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSoggettoDestinazione")]
	protected virtual IboWebLabel lblSoggettoDestinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSoggettoCliente")]
	protected virtual IboWebLabel lblSoggettoCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSoggettoTrasportatore")]
	protected virtual IboWebLabel lblSoggettoTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSoggetto")]
	protected virtual IboWebLabel lblSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Destinazione")]
	protected virtual IboWebComboTlk Destinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cliente")]
	protected virtual IboWebComboTlk Cliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Trasportatore")]
	protected virtual IboWebComboTlk Trasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnAggiungi
	{
		[CompilerGenerated]
		get
		{
			return _btnAggiungi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAggiungi_Click;
			IboWebButton val = _btnAggiungi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAggiungi = value;
			val = _btnAggiungi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlSoggettiDestinazione")]
	protected virtual Panel pnlSoggettiDestinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdDestinazioni")]
	protected virtual IboWebToolbar tlbgrdDestinazioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDestinazioni")]
	protected virtual Panel pnlDestinazioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdDestinazioni")]
	protected virtual IboGridView grdDestinazioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSoggettiClienti")]
	protected virtual Panel pnlSoggettiClienti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdClienti")]
	protected virtual IboWebToolbar tlbgrdClienti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClienti")]
	protected virtual Panel pnlClienti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdClienti")]
	protected virtual IboGridView grdClienti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSoggettiTrasportatori")]
	protected virtual Panel pnlSoggettiTrasportatori
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdTrasportatori")]
	protected virtual IboWebToolbar tlbgrdTrasportatori
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTrasportatori")]
	protected virtual Panel pnlTrasportatori
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdTrasportatori")]
	protected virtual IboGridView grdTrasportatori
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSoggetti")]
	protected virtual CollapsiblePanelExtender cpSoggetti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFCFGUtenti_OrganizzazioniWizard2()
	{
		dDataScadenzaPassword = new DateTime(2000, 1, 1);
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.PROF.ORGANIZZAZIONI#WIZARD";
		_Title = base.Translator.Translate("XXX", "Wizard Utenti", new string[0]);
		_objFunctionArguments.Name = "INSERIMENTO";
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.InitializeInternalGrid(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig2 = iboInternalGridConfig;
				StateBag myViewState = base.MyViewState;
				IboGridView objGridView = grdDestinazioni;
				iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
				grdDestinazioni = objGridView;
				iboInternalGridConfig.Build("WFI.PROF.ORG.DESTINATARI", "SELECT * FROM GRD_DESTINATARI_ORGANIZ WHERE UTENTE='<%CODICE%>'", "", "", ((Control)grdDestinazioni).ID, ((Control)tlbgrdDestinazioni).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				iboInternalGridConfig.Attivo = false;
				IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
				StateBag myViewState2 = base.MyViewState;
				objGridView = grdClienti;
				iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
				grdClienti = objGridView;
				iboInternalGridConfig.Build("WFI.PROF.ORG.CLIENTI", "SELECT * FROM GRD_CLIENTI_ORGANIZ WHERE UTENTE='<%CODICE%>'", "", "", ((Control)grdClienti).ID, ((Control)tlbgrdClienti).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				iboInternalGridConfig.Attivo = false;
				IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
				StateBag myViewState3 = base.MyViewState;
				objGridView = grdTrasportatori;
				iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
				grdTrasportatori = objGridView;
				iboInternalGridConfig.Build("WFI.PROF.ORG.TRASPORTATORI", "SELECT * FROM GRD_TRASPORTATORI_ORGANIZ WHERE UTENTE='<%CODICE%>'", "", "", ((Control)grdTrasportatori).ID, ((Control)tlbgrdTrasportatori).ID);
				GridConfigList.Add(iboInternalGridConfig);
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0)
				{
					goto IL_0171;
				}
				text2 = "SELECT COUNT(*) FROM WFI_UTENTI WHERE CODICE = " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
				val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Conversions.ToInteger(obj) > 0)
				{
					rsMess = TranslateMessage("XXX", "Codice Organizzazione " + txtCodice.ObjValue.ToString() + " già presente a sistema");
				}
				else
				{
					text2 = "SELECT COUNT(*) FROM WFI_UTENTI WHERE CODICE = " + base.DbConn.SQLFormatString(CodiceUtente.ObjValue.ToString());
					val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) <= 0)
						{
							goto IL_0171;
						}
						rsMess = TranslateMessage("XXX", "Codice Utente " + CodiceUtente.ObjValue.ToString() + " già presente a sistema");
					}
				}
			}
			goto end_IL_0015;
			IL_0171:
			val = (FXRETURN)0;
			end_IL_0015:;
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
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
				{
					IboDropDownList objCombo = cmbOrganizzazioneTipoSoggetto;
					string rsMess2 = "";
					ComboSelectedItem((IIboDropdownList)(object)objCombo, "XXX", ref rsMess2);
					txtTipo.ObjValue = "O";
					txtPeso.ObjValue = 99;
					cmbLingua.ObjValue = "IT";
				}
				else if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
					optOrganizzazioneInternaEsterna.Enabled = false;
					cmbOrganizzazioneTipoSoggetto.Enabled = false;
					if ((Operators.CompareString(optOrganizzazioneInternaEsterna.ObjValue.ToString(), "E", false) == 0) & !((Page)this).IsPostBack)
					{
						AggiornaPannelloSoggetti();
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
			result = val;
		}
		return result;
	}

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Invalid comparison between Unknown and I4
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Invalid comparison between Unknown and I4
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0)
				{
					goto IL_06ec;
				}
				text2 = "INSERT INTO WFI_UTENTI (CODICE,DESCRIZIONE,Organizzazione,ATTIVO,PASSWORD,TIPO,PESO,LINGUA,DATINS,DATAGG,UTEINS,UTEAGG) ";
				text2 += " VALUES( ";
				text2 = text2 + base.DbConn.SQLFormatString("G." + txtCodice.ObjValue.ToString()) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(txtDescrizione.ObjValue.ToString()) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(chkAttivo.ObjValue.ToString()) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(txtPassword.ObjValue.ToString()) + ",";
				text2 += "'G',";
				string text5 = text2;
				DBConnection dbConn = base.DbConn;
				string text6 = txtPeso.ObjValue.ToString();
				text2 = text5 + dbConn.SQLFormatNumber(ref text6) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(cmbLingua.ObjValue.ToString()) + ",";
				text2 += "GETDATE(), GETDATE(), ";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ");\r\n";
				text2 += "INSERT INTO WFI_UTENTI (CODICE,DESCRIZIONE,GRUPPO,ATTIVO,TIPO,PESO,LINGUA,PASSWORD,SCADENZAPASSWORD,DATINS,DATAGG,UTEINS,UTEAGG) ";
				text2 += " VALUES( ";
				text2 = ((Operators.CompareString(CodiceUtente.ObjValue.ToString(), "", false) == 0) ? (text2 + base.DbConn.SQLFormatString("U." + txtCodice.ObjValue.ToString()) + ",") : (text2 + base.DbConn.SQLFormatString(CodiceUtente.ObjValue.ToString()) + ","));
				text2 = ((Operators.CompareString(DescrizioneUtente.ObjValue.ToString(), "", false) == 0) ? (text2 + base.DbConn.SQLFormatString(txtDescrizione.ObjValue.ToString()) + ",") : (text2 + base.DbConn.SQLFormatString(DescrizioneUtente.ObjValue.ToString()) + ","));
				text2 = text2 + base.DbConn.SQLFormatString("G." + txtCodice.ObjValue.ToString()) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(chkAttivo.ObjValue.ToString()) + ",";
				text2 += "'U',";
				string text7 = text2;
				DBConnection dbConn2 = base.DbConn;
				text6 = txtPeso.ObjValue.ToString();
				text2 = text7 + dbConn2.SQLFormatNumber(ref text6) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(cmbLingua.ObjValue.ToString()) + ",";
				if (Operators.CompareString(PasswordUtente.ObjValue.ToString(), "", false) != 0)
				{
					text2 = text2 + base.DbConn.SQLFormatString(PasswordUtente.ObjValue.ToString()) + ",";
				}
				else
				{
					text6 = "";
					text4 = GeneraPswCasuale(8, ref text6);
					text2 = text2 + base.DbConn.SQLFormatString(text4) + ",";
				}
				text2 = text2 + base.DbConn.SQLFormatDate((eTipoData)1, dDataScadenzaPassword) + ",";
				text2 = text2 + base.DbConn.GetDate() + ", ";
				text2 = text2 + base.DbConn.GetDate() + ", ";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ");\r\n";
				text3 = "SELECT CODICE FROM WFI_FILIALI WHERE ISDEFAULT='S'";
				val2 = base.DbConn.DoSql(text3, (object)"", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(Conversions.ToString(obj), "", false) != 0)
					{
						text2 += "INSERT INTO WFI_UtentiFiliali (UTENTE,FILIALE,ISDEFAULT,DATINS,DATAGG,UTEINS,UTEAGG) VALUES (";
						text2 = ((Operators.CompareString(CodiceUtente.ObjValue.ToString(), "", false) == 0) ? (text2 + base.DbConn.SQLFormatString("U." + txtCodice.ObjValue.ToString()) + ",") : (text2 + base.DbConn.SQLFormatString(CodiceUtente.ObjValue.ToString()) + ","));
						text2 = text2 + base.DbConn.SQLFormatString(Conversions.ToString(obj)) + ",";
						text2 += "'S',";
						text2 = text2 + base.DbConn.GetDate() + ", ";
						text2 = text2 + base.DbConn.GetDate() + ", ";
						text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
						text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ")";
					}
					val2 = base.DbConn.SqlExec(text2, ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_06ec;
					}
					val = val2;
				}
			}
			goto end_IL_0023;
			IL_06ec:
			val = (FXRETURN)0;
			end_IL_0023:;
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

	private void optOrganizzazioneInternaEsterna_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		IboInternalGridConfig iboInternalGridConfig = null;
		try
		{
			if (Operators.CompareString(optOrganizzazioneInternaEsterna.ObjValue.ToString(), "I", false) == 0)
			{
				IboDropDownList objCombo = cmbOrganizzazioneTipoSoggetto;
				string rsMess = "";
				ComboSetFilter((IIboDropdownList)(object)objCombo, "", "XXX", ref rsMess);
				cmbOrganizzazioneTipoSoggetto.Enabled = false;
				cmbOrganizzazioneTipoSoggetto.ReadOnly = true;
				((WebControl)cpSoggetti_Body).Enabled = false;
				lblSoggetto.Visible = true;
				lblSoggettoDestinazione.Visible = false;
				lblSoggettoTrasportatore.Visible = false;
				lblSoggettoCliente.Visible = false;
				IboWebComboTlk destinazione = Destinazione;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)destinazione, "", ref rsMess);
				Destinazione.Visible = true;
				Trasportatore.Visible = false;
				Cliente.Visible = false;
				iboInternalGridConfig = GridConfigList[((Control)grdDestinazioni).ID];
				iboInternalGridConfig.Attivo = false;
				iboInternalGridConfig = GridConfigList[((Control)grdClienti).ID];
				iboInternalGridConfig.Attivo = false;
				iboInternalGridConfig = GridConfigList[((Control)grdTrasportatori).ID];
				iboInternalGridConfig.Attivo = false;
				((Control)pnlSoggettiDestinazione).Visible = true;
				((Control)pnlSoggettiClienti).Visible = false;
				((Control)pnlSoggettiTrasportatori).Visible = false;
			}
			else
			{
				IboDropDownList objCombo2 = cmbOrganizzazioneTipoSoggetto;
				string sFilter = "CODICE <> " + base.DbConn.SQLFormatString("XXX");
				string rsMess = "";
				ComboSetFilter((IIboDropdownList)(object)objCombo2, sFilter, ref rsMess);
				cmbOrganizzazioneTipoSoggetto.Enabled = true;
				cmbOrganizzazioneTipoSoggetto.ReadOnly = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void cmbOrganizzazioneTipoSoggetto_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(optOrganizzazioneInternaEsterna.ObjValue.ToString(), "E", false) == 0)
			{
				lblSoggetto.Visible = false;
				AggiornaPannelloSoggetti();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected void btnAggiungi_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Invalid comparison between Unknown and I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Invalid comparison between Unknown and I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboInternalGridConfig objInternalGridConfig = null;
		string rsMess = "";
		string text = "";
		string text2 = "";
		object obj = null;
		try
		{
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
			{
				_objFunctionArguments.Parameters["SilentAutoSave"] = "S";
				val2 = SavingProcess(vbReload: true, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
			}
			switch (cmbOrganizzazioneTipoSoggetto.ObjValue.ToString())
			{
			case "TO.CLIENTI":
				if (Operators.CompareString(Cliente.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire il cliente");
					return;
				}
				text2 = Cliente.ObjValue.ToString();
				objInternalGridConfig = GridConfigList[((Control)grdClienti).ID];
				break;
			case "TO.DESTINATARI":
				if (Operators.CompareString(Destinazione.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire il destinatario");
					return;
				}
				text2 = Destinazione.ObjValue.ToString();
				objInternalGridConfig = GridConfigList[((Control)grdDestinazioni).ID];
				break;
			case "TO.TRASP":
				if (Operators.CompareString(Trasportatore.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire il trasportatore");
					return;
				}
				text2 = Trasportatore.ObjValue.ToString();
				objInternalGridConfig = GridConfigList[((Control)grdTrasportatori).ID];
				break;
			}
			text = "SELECT COUNT(*) FROM WFI_Utenti_Soggetti WHERE ";
			text = text + "UTENTE = " + base.DbConn.SQLFormatString(txtCodice.Text) + " ";
			text = text + "AND CODICESOGGETTO = " + base.DbConn.SQLFormatString(text2);
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (Conversions.ToInteger(obj) > 0)
			{
				rsMess = TranslateMessage("XXX", "Soggetto " + text2 + " già associato all'organizzazione " + txtDescrizione.Text);
				return;
			}
			text = "INSERT INTO WFI_Utenti_Soggetti (UTENTE, CODICESOGGETTO) VALUES (";
			text = text + base.DbConn.SQLFormatString(txtCodice.Text) + ",";
			text = text + base.DbConn.SQLFormatString(text2) + ")";
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			string rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
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
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void btnGeneraPassword_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			string rsMess2 = "";
			text = GeneraPswCasuale(8, ref rsMess2);
			PasswordUtente.ObjValue = text;
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
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected override FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Invalid comparison between Unknown and I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(e.CommandName.ToUpper(), "ELIMIASOGGETTO", false) != 0)
				{
					goto IL_014f;
				}
				checked
				{
					if (funcArg.Data.Count > 0)
					{
						int num4 = funcArg.Data[0].FieldValuesCount - 1;
						for (int i = 0; i <= num4; i++)
						{
							text += "DELETE FROM WFI_Utenti_Soggetti WHERE ";
							text = text + "UTENTE = " + base.DbConn.SQLFormatString(txtCodice.Text) + " ";
							text = text + "AND CODICESOGGETTO = " + base.DbConn.SQLFormatString(funcArg.Data.Item("Codice").get_FieldValues(i).ToString()) + ";\r\n";
						}
					}
					val2 = base.DbConn.SqlExec(text, ref rsMess);
				}
				if ((int)val2 <= 0)
				{
					string rsMess2 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
					goto IL_014f;
				}
				val = val2;
			}
			goto end_IL_001e;
			IL_014f:
			val = (FXRETURN)0;
			end_IL_001e:;
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

	protected override FXRETURN InternalGridAggiorna(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridAggiorna(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	private void AggiornaPannelloSoggetti()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		IboInternalGridConfig objInternalGridConfig = null;
		try
		{
			lblSoggetto.Visible = false;
			((WebControl)cpSoggetti_Body).Enabled = true;
			string rsMess;
			switch (cmbOrganizzazioneTipoSoggetto.ObjValue.ToString())
			{
			case "TO.CLIENTI":
			{
				lblSoggettoDestinazione.Visible = false;
				lblSoggettoTrasportatore.Visible = false;
				lblSoggettoCliente.Visible = true;
				IboWebComboTlk destinazione3 = Destinazione;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)destinazione3, "", ref rsMess);
				IboWebComboTlk trasportatore3 = Trasportatore;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)trasportatore3, "", ref rsMess);
				IboWebComboTlk cliente3 = Cliente;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)cliente3, "", ref rsMess);
				Destinazione.Visible = false;
				Trasportatore.Visible = false;
				Cliente.Visible = true;
				((Control)pnlSoggettiDestinazione).Visible = false;
				((Control)pnlSoggettiClienti).Visible = true;
				((Control)pnlSoggettiTrasportatori).Visible = false;
				objInternalGridConfig = GridConfigList[((Control)grdDestinazioni).ID];
				objInternalGridConfig.Attivo = false;
				objInternalGridConfig = GridConfigList[((Control)grdTrasportatori).ID];
				objInternalGridConfig.Attivo = false;
				objInternalGridConfig = GridConfigList[((Control)grdClienti).ID];
				objInternalGridConfig.Attivo = true;
				break;
			}
			case "TO.DESTINATARI":
			{
				lblSoggettoDestinazione.Visible = true;
				lblSoggettoTrasportatore.Visible = false;
				lblSoggettoCliente.Visible = false;
				IboWebComboTlk destinazione2 = Destinazione;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)destinazione2, "", ref rsMess);
				IboWebComboTlk trasportatore2 = Trasportatore;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)trasportatore2, "", ref rsMess);
				IboWebComboTlk cliente2 = Cliente;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)cliente2, "", ref rsMess);
				Destinazione.Visible = true;
				Trasportatore.Visible = false;
				Cliente.Visible = false;
				((Control)pnlSoggettiDestinazione).Visible = true;
				((Control)pnlSoggettiClienti).Visible = false;
				((Control)pnlSoggettiTrasportatori).Visible = false;
				objInternalGridConfig = GridConfigList[((Control)grdClienti).ID];
				objInternalGridConfig.Attivo = false;
				objInternalGridConfig = GridConfigList[((Control)grdTrasportatori).ID];
				objInternalGridConfig.Attivo = false;
				objInternalGridConfig = GridConfigList[((Control)grdDestinazioni).ID];
				objInternalGridConfig.Attivo = true;
				break;
			}
			case "TO.TRASP":
			{
				lblSoggettoDestinazione.Visible = false;
				lblSoggettoTrasportatore.Visible = true;
				lblSoggettoCliente.Visible = false;
				IboWebComboTlk destinazione = Destinazione;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)destinazione, "", ref rsMess);
				IboWebComboTlk trasportatore = Trasportatore;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)trasportatore, "", ref rsMess);
				IboWebComboTlk cliente = Cliente;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)cliente, "", ref rsMess);
				Destinazione.Visible = false;
				Trasportatore.Visible = true;
				Cliente.Visible = false;
				((Control)pnlSoggettiDestinazione).Visible = false;
				((Control)pnlSoggettiClienti).Visible = false;
				((Control)pnlSoggettiTrasportatori).Visible = true;
				objInternalGridConfig = GridConfigList[((Control)grdDestinazioni).ID];
				objInternalGridConfig.Attivo = false;
				objInternalGridConfig = GridConfigList[((Control)grdClienti).ID];
				objInternalGridConfig.Attivo = false;
				objInternalGridConfig = GridConfigList[((Control)grdTrasportatori).ID];
				objInternalGridConfig.Attivo = true;
				break;
			}
			}
			rsMess = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private string GeneraPswCasuale(int Lunghezza, ref string rsMess)
	{
		RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		byte[] array = new byte[1];
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		string text = "";
		string result;
		try
		{
			rsMess = "";
			while (text.Length < Lunghezza)
			{
				randomNumberGenerator.GetBytes(array);
				string @string = aSCIIEncoding.GetString(array);
				if (char.IsLetterOrDigit(@string[0]))
				{
					text += Conversions.ToString(@string[0]);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
		}
		return result;
	}
}
