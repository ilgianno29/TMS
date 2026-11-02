using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFCFG_GeneraGriglia2 : WFIDialogPage
{
	protected class Cfg_Campi
	{
		public string Name;

		public string Caption;

		public string Align;

		public int Width;

		public string Formattazione;

		public string WrapCol;

		public string Visible;

		public Cfg_Campi()
		{
			Name = "";
			Caption = "";
			Align = "";
			Width = 0;
			Formattazione = "";
			WrapCol = "";
			Visible = "S";
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("optTipoGriglia")]
	private IboWebRadioButtonList _optTipoGriglia;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("optTipoObjectManager")]
	private IboWebRadioButtonList _optTipoObjectManager;

	protected StringCollection _ListQuerySql;

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
	protected virtual IboWebLabel cpInfoGen_Title_Caption
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

	[field: AccessedThroughProperty("txtNomRif")]
	protected virtual IboWebTextBox txtNomRif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInternalGrid")]
	protected virtual IboWebLabel lblInternalGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebRadioButtonList optTipoGriglia
	{
		[CompilerGenerated]
		get
		{
			return _optTipoGriglia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = optTipoGriglia_SelectedIndexChanged;
			IboWebRadioButtonList val = _optTipoGriglia;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_optTipoGriglia = value;
			val = _optTipoGriglia;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblDescrizione")]
	protected virtual IboWebLabel lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDesTab")]
	protected virtual IboWebTextBox txtDesTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVistaDiRiferimento")]
	protected virtual IboWebLabel lblVistaDiRiferimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbNomTab")]
	protected virtual IboWebComboTlk cmbNomTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblWhereAggiuntiva")]
	protected virtual IboWebLabel lblWhereAggiuntiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWhereAggiuntiva")]
	protected virtual IboWebTextBox txtWhereAggiuntiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCansel")]
	protected virtual IboWebLabel lblCansel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optCanSel")]
	protected virtual IboWebRadioButtonList optCanSel
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

	[field: AccessedThroughProperty("cpObjectManager_Title")]
	protected virtual Panel cpObjectManager_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpObjectManager_Title_Caption")]
	protected virtual IboWebLabel cpObjectManager_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpObjectManager_Title_Image")]
	protected virtual Image cpObjectManager_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpObjectManager_Body")]
	protected virtual Panel cpObjectManager_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoObjectManager")]
	protected virtual IboWebLabel lblTipoObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebRadioButtonList optTipoObjectManager
	{
		[CompilerGenerated]
		get
		{
			return _optTipoObjectManager;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = optTipoObjectManager_SelectedIndexChanged;
			IboWebRadioButtonList val = _optTipoObjectManager;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_optTipoObjectManager = value;
			val = _optTipoObjectManager;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblObjectManager")]
	protected virtual IboWebLabel lblObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbObjectManager")]
	protected virtual IboWebComboTlk cmbObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneObjectManager")]
	protected virtual IboWebLabel lblDescrizioneObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDescrizioneObjectManager")]
	protected virtual IboWebTextBox txtDescrizioneObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTabellaObjectManager")]
	protected virtual IboWebLabel lblTabellaObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTabellaObjectManager")]
	protected virtual IboWebTextBox txtTabellaObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRedirectToObjectManager")]
	protected virtual IboWebLabel lblRedirectToObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRedirectToObjectManager")]
	protected virtual IboWebTextBox txtRedirectToObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpObjectManager")]
	protected virtual CollapsiblePanelExtender cpObjectManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoPulsanti_Title")]
	protected virtual Panel cpElencoPulsanti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoPulsanti_Title_Caption")]
	protected virtual IboWebLabel cpElencoPulsanti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoPulsanti_Title_Image")]
	protected virtual Image cpElencoPulsanti_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoPulsanti_Body")]
	protected virtual Panel cpElencoPulsanti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteFiltro")]
	protected virtual IboWebLabel lblPulsanteFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteFiltro")]
	protected virtual IboWebCheckBox chkPulsanteFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteModifica")]
	protected virtual IboWebLabel lblPulsanteModifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteModifica")]
	protected virtual IboWebCheckBox chkPulsanteModifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteAggiorna")]
	protected virtual IboWebLabel lblPulsanteAggiorna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteAggiorna")]
	protected virtual IboWebCheckBox chkPulsanteAggiorna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteCancella")]
	protected virtual IboWebLabel lblPulsanteCancella
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteCancella")]
	protected virtual IboWebCheckBox chkPulsanteCancella
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteAnnullaFiltro")]
	protected virtual IboWebLabel lblPulsanteAnnullaFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteAnnullaFiltro")]
	protected virtual IboWebCheckBox chkPulsanteAnnullaFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteDuplica")]
	protected virtual IboWebLabel lblPulsanteDuplica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteDuplica")]
	protected virtual IboWebCheckBox chkPulsanteDuplica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteVisualizza")]
	protected virtual IboWebLabel lblPulsanteVisualizza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteVisualizza")]
	protected virtual IboWebCheckBox chkPulsanteVisualizza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteStampa")]
	protected virtual IboWebLabel lblPulsanteStampa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteStampa")]
	protected virtual IboWebCheckBox chkPulsanteStampa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteInserisci")]
	protected virtual IboWebLabel lblPulsanteInserisci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteInserisci")]
	protected virtual IboWebCheckBox chkPulsanteInserisci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPulsanteEsporta")]
	protected virtual IboWebLabel lblPulsanteEsporta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPulsanteEsporta")]
	protected virtual IboWebCheckBox chkPulsanteEsporta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblShowCaption")]
	protected virtual IboWebLabel lblShowCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkShowCaption")]
	protected virtual IboWebCheckBox chkShowCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblShowImage")]
	protected virtual IboWebLabel lblShowImage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkShowImage")]
	protected virtual IboWebCheckBox chkShowImage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoPulsanti")]
	protected virtual CollapsiblePanelExtender cpElencoPulsanti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioniAggiuntive_Title")]
	protected virtual Panel cpOpzioniAggiuntive_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioniAggiuntive_Title_Caption")]
	protected virtual IboWebLabel cpOpzioniAggiuntive_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioniAggiuntive_Title_Image")]
	protected virtual Image cpOpzioniAggiuntive_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioniAggiuntive_Body")]
	protected virtual Panel cpOpzioniAggiuntive_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSovrascriviConfigurazione")]
	protected virtual IboWebLabel lblSovrascriviConfigurazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkSovrascriviConfigurazione")]
	protected virtual IboWebCheckBox chkSovrascriviConfigurazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVoce")]
	protected virtual IboWebLabel lblVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtVoce")]
	protected virtual IboWebTextBox txtVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneVoce")]
	protected virtual IboWebLabel lblDescrizioneVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDescrizioneVoce")]
	protected virtual IboWebTextBox txtDescrizioneVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTest")]
	protected virtual IboWebLabel lblTest
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkTest")]
	protected virtual IboWebCheckBox chkTest
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioniAggiuntive")]
	protected virtual CollapsiblePanelExtender cpOpzioniAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFCFG_GeneraGriglia2()
	{
		_ListQuerySql = new StringCollection();
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.CFG.GeneraGriglia";
		_Title = base.Translator.Translate("XXX", "Generazione Automatica Griglia", new string[0]);
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
			val2 = base.CheckData(ref rsMess);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
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
				optTipoGriglia_SelectedIndexChanged(optTipoGriglia, null);
				optTipoObjectManager_SelectedIndexChanged(optTipoObjectManager, null);
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
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_ListQuerySql.Clear();
			base.DbConn.BeginTransaction();
			val = EliminaConfigurazione(ref rsMess);
			if ((int)val <= 0)
			{
				val = SaveAllGrd(ref rsMess);
				if ((int)val <= 0)
				{
					val = SaveTabGrd(ref rsMess);
					if ((int)val <= 0)
					{
						val = SaveTabBot(ref rsMess);
						if ((int)val <= 0)
						{
							val = SaveVoceMenu(ref rsMess);
							if ((int)val <= 0)
							{
								val = ApplicoQuery(ref rsMess);
								if ((int)val <= 0)
								{
									base.DbConn.CommitTransaction();
									if (((CheckBox)chkTest).Checked & (Operators.CompareString(((ListControl)optTipoGriglia).SelectedValue, "S", false) == 0))
									{
										string sUrl = "~/WFI/Form/WFStandardGrid.aspx?ForceResetFilter=S&GridMode=DETAILS&NomRif=" + txtNomRif.Text;
										IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
										IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
										_ReturnToCallerAfterConfirm = false;
									}
									val2 = (FXRETURN)0;
								}
							}
						}
					}
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
			if (base.DbConn.TransactionOpen)
			{
				base.DbConn.RollbackTransaction();
			}
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	private FXRETURN EliminaConfigurazione(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((CheckBox)chkSovrascriviConfigurazione).Checked)
			{
				text = "DELETE FROM WFI_ALLGRD WHERE NomRif=" + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + " AND UTENTE='XXX';";
				_ListQuerySql.Add(text);
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

	private FXRETURN SaveAllGrd(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Invalid comparison between Unknown and I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text = "SELECT COUNT(*) FROM WFI_ALLGRD WHERE NOMRIF = " + base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString().ToUpper()) + " AND UTENTE='XXX'";
			val = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Conversions.ToInteger(obj) > 0)
			{
				rsMess = TranslateMessage("XXX", "Impossibile procedere presente una griglia con lo stesso Codice {0}", txtNomRif.ObjValue.ToString());
			}
			else
			{
				if (!((Operators.CompareString(optTipoGriglia.ObjValue.ToString(), "C", false) != 0) & (Operators.CompareString(optTipoObjectManager.ObjValue.ToString(), "N", false) == 0)))
				{
					goto IL_024a;
				}
				text = "SELECT COUNT(*) FROM WFI_OBJECTMANAGER WHERE CODICE = " + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper());
				val = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Conversions.ToInteger(obj) <= 0)
					{
						text = "INSERT INTO WFI_OBJECTMANAGER (Codice, Descrizione, TableName, Redirect_To) ";
						text += "VALUES( ";
						text = text + base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString().ToUpper()) + ", ";
						text = text + base.DbConn.SQLFormatString(txtDescrizioneObjectManager.ObjValue.ToString().ToUpper()) + ", ";
						text = text + base.DbConn.SQLFormatString(txtTabellaObjectManager.ObjValue.ToString().ToUpper()) + ", ";
						text = text + base.DbConn.SQLFormatString(txtRedirectToObjectManager.ObjValue.ToString().ToUpper()) + ");";
						_ListQuerySql.Add(text);
						goto IL_024a;
					}
					rsMess = TranslateMessage("XXX", "Impossibile procedere presente una ObjectManager con lo stesso Codice {0}", txtNomRif.Text);
				}
			}
			goto end_IL_000e;
			IL_024a:
			text = "INSERT INTO WFI_ALLGRD";
			text += "(NOMRIF,NOMTAB,DESTAB,OBJECTMANAGERNAME,MINFIL,CANSEL,ROWSPERPAGE,BORDERCOLOR";
			text += ",FONTSIZE,FONTNAME,HEADERSTYLE,PAGERSTYLE,ROWSTYLE,ALTERNATINGROWSTYLE";
			text += ",SELECTEDROWSTYLE,HIGHLIGHTEDROWSTYLE,WHEREAGGIUNTIVA,PREFILTRO,CANPAGE,CANSORT";
			text += ",UTEINS,UTEAGG,CAPTIONBACKCOLOR,CAPTIONFORCOLOR,CAPTIONBOLD,CAPTIONITALIC,CAPTIONFONTSIZE,CAPTIONFONTNAME,TIPOGRIGLIA)";
			text += "VALUES(";
			text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
			text = text + base.DbConn.SQLFormatString(cmbNomTab.SelectedValue.ToUpper()) + ", ";
			text = text + base.DbConn.SQLFormatString(txtDesTab.Text.ToUpper()) + ", ";
			text = ((Operators.CompareString(optTipoGriglia.ObjValue.ToString(), "C", false) == 0) ? (text + "NULL, ") : ((Operators.CompareString(optTipoObjectManager.ObjValue.ToString(), "N", false) == 0) ? (text + base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString().ToUpper()) + ", ") : ((Operators.CompareString(optTipoObjectManager.ObjValue.ToString(), "E", false) != 0) ? (text + base.DbConn.SQLFormatString("") + ", ") : (text + base.DbConn.SQLFormatString(cmbObjectManager.ObjValue.ToString().ToUpper()) + ", "))));
			text += "'N',";
			text = text + base.DbConn.SQLFormatString(((ListControl)optCanSel).SelectedValue.ToString()) + ", ";
			text += "25,";
			text += "'AAAAAA',";
			text += "0, ";
			text += "Null,";
			text += "'STDHEADER01', ";
			text += "'STDPAGER01', ";
			text += "'STDROW01', ";
			text += "'STDALTROW01', ";
			text += "'STDSELECTED01', ";
			text += "'STDHIGH01', ";
			text = text + base.DbConn.SQLFormatString(txtWhereAggiuntiva.Text) + ", ";
			text += "'N', ";
			text += "'S', ";
			text += "'S', ";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
			text += "NULL, NULL, 'S', 'S', 16, NULL, ";
			text += base.DbConn.SQLFormatString(((ListControl)optTipoGriglia).SelectedValue);
			text += ");";
			_ListQuerySql.Add(text);
			val2 = (FXRETURN)0;
			end_IL_000e:;
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

	private FXRETURN SaveTabGrd(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Invalid comparison between Unknown and I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		List<Cfg_Campi> list = new List<Cfg_Campi>();
		string text = "";
		DataTable dataTable = null;
		object obj = null;
		string[] array = null;
		object obj2 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM ElencoCampiTabella WHERE TABLE_NAME=" + base.DbConn.SQLFormatString(cmbNomTab.SelectedValue.ToUpper()) + " ORDER BY ORDINAL_POSITION";
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val <= 0)
			{
				checked
				{
					int num = dataTable.Rows.Count - 1;
					int num2 = 0;
					int num4 = default(int);
					while (true)
					{
						if (num2 <= num)
						{
							Cfg_Campi cfg_Campi = new Cfg_Campi();
							if (dataTable.Rows[num2]["COLUMN_NAME"].ToString().Contains(" "))
							{
								cfg_Campi.Name = "[" + dataTable.Rows[num2]["COLUMN_NAME"].ToString() + "]";
							}
							else
							{
								cfg_Campi.Name = dataTable.Rows[num2]["COLUMN_NAME"].ToString();
							}
							if (Operators.CompareString(cfg_Campi.Name, "WFI_Keys", false) == 0)
							{
								text = "SELECT WFI_Keys FROM " + cmbNomTab.SelectedValue.ToUpper();
								val = base.DbConn.DoSql(text, ref obj, ref rsMess);
								if (unchecked((int)val) > 0)
								{
									val2 = val;
									break;
								}
								array = Conversions.ToString(obj).Split(new char[1] { ',' });
							}
							cfg_Campi.Caption = base.BaseFunctions.StandardNameFilter(dataTable.Rows[num2]["COLUMN_NAME"].ToString());
							cfg_Campi.Formattazione = "";
							cfg_Campi.Visible = "S";
							cfg_Campi.Width = 0;
							if (Operators.CompareString(dataTable.Rows[num2]["WFI_DATA_TYPE"].ToString(), "NUMERIC", false) == 0)
							{
								cfg_Campi.Align = "Right";
								cfg_Campi.Width = 5;
								cfg_Campi.WrapCol = "N";
								if (Operators.CompareString(dataTable.Rows[num2]["NUMERIC_SCALE"].ToString(), "2", false) == 0)
								{
									cfg_Campi.Formattazione = "{0:F2}";
								}
								else if (Operators.CompareString(dataTable.Rows[num2]["NUMERIC_SCALE"].ToString(), "5", false) == 0)
								{
									cfg_Campi.Formattazione = "{0:F5}";
								}
							}
							else if (Operators.CompareString(dataTable.Rows[num2]["WFI_DATA_TYPE"].ToString(), "DATETIME", false) == 0)
							{
								cfg_Campi.Align = "Left";
								cfg_Campi.Width = 5;
								cfg_Campi.Formattazione = "{0:dd/MM/yyyy}";
								cfg_Campi.WrapCol = "N";
							}
							else
							{
								if (Operators.CompareString(dataTable.Rows[num2]["WFI_DATA_TYPE"].ToString(), "STRING", false) != 0)
								{
									goto IL_0408;
								}
								cfg_Campi.Align = "Left";
								int num3 = Conversions.ToInteger(dataTable.Rows[num2]["CHARACTER_MAXIMUM_LENGTH"]);
								if (num3 > 40)
								{
									cfg_Campi.Width = 0;
								}
								else
								{
									cfg_Campi.Width = 5;
									cfg_Campi.WrapCol = "N";
								}
								if (num3 == 1)
								{
									cfg_Campi.Align = "Center";
								}
							}
							if (Operators.CompareString(cfg_Campi.Name.ToUpper(), "STYLESET", false) == 0)
							{
								cfg_Campi.Visible = "N";
								cfg_Campi.Width = 0;
							}
							list.Add(cfg_Campi);
							goto IL_0408;
						}
						foreach (Cfg_Campi item in list)
						{
							text = "INSERT INTO WFI_TABGRD (NOMRIF,PRORIG,UTENTE,NOMTAB,NOMCAM,DESCAM,LARCAM,";
							text += "HORIZONTALALIGN,VERTICALALIGN,FORCAM,ORDCAM,ORDDIR,VISIBILE,ISKEY,";
							text += "WRAPCOL,DATINS,DATAGG,UTEINS,UTEAGG,HTMLENCODE,NOMCAMEXP) VALUES (";
							text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
							string text2 = text;
							DBConnection dbConn = base.DbConn;
							int num5 = (num4 + 1) * 10;
							text = text2 + dbConn.SQLFormatNumber(ref num5) + ", ";
							text = text + base.DbConn.SQLFormatString("XXX") + ", ";
							text = text + base.DbConn.SQLFormatString(cmbNomTab.SelectedValue.ToUpper()) + ", ";
							text = text + base.DbConn.SQLFormatString(item.Name) + ", ";
							text = text + base.DbConn.SQLFormatString(item.Caption) + ", ";
							text = text + base.DbConn.SQLFormatNumber(ref item.Width) + ", ";
							text = text + base.DbConn.SQLFormatString(item.Align) + ", ";
							text = text + base.DbConn.SQLFormatString("Middle") + ", ";
							text = text + base.DbConn.SQLFormatString(item.Formattazione) + ", ";
							if (num4 == 0)
							{
								string text3 = text;
								DBConnection dbConn2 = base.DbConn;
								num5 = 1;
								text = text3 + dbConn2.SQLFormatNumber(ref num5) + ", ";
								text = text + base.DbConn.SQLFormatString("ASC") + ", ";
							}
							else
							{
								text += "0, ";
								text += "NULL, ";
							}
							text = text + base.DbConn.SQLFormatString(item.Visible) + ", ";
							text = ((num4 == 0) ? (text + "'S', ") : (Information.IsNothing((object)array) ? (text + "'N', ") : ((!array.Contains<string>(item.Name, StringComparer.OrdinalIgnoreCase)) ? (text + "'N', ") : (text + "'S', "))));
							text = text + base.DbConn.SQLFormatString(item.WrapCol) + ", ";
							text = text + base.DbConn.GetDate() + ", ";
							text = text + base.DbConn.GetDate() + ", ";
							text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
							text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
							text += "'S', ";
							text += "NULL ";
							text += ");";
							if (Operators.CompareString(item.Name.ToUpper(), "WFI_KEYS", false) != 0)
							{
								_ListQuerySql.Add(text);
							}
							num4++;
						}
						val2 = (FXRETURN)0;
						break;
						IL_0408:
						num2++;
					}
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

	private FXRETURN SaveTabBot(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(((ListControl)optTipoGriglia).SelectedValue, "C", false) != 0)
			{
				if (((CheckBox)chkPulsanteFiltro).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "10, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteAggiorna).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "30, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteAnnullaFiltro).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "40, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteVisualizza).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "60, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteInserisci).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "70, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteModifica).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "80, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteCancella).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "90, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteDuplica).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "100, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteStampa).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "120, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
				}
				if (((CheckBox)chkPulsanteEsporta).Checked)
				{
					text = "INSERT INTO WFI_TABBOT (NOMRIF, NUMBOT, PESBOT,ShowCaption,ShowImage) VALUES (";
					text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
					text += "140, 5,";
					text = text + base.DbConn.SQLFormatString(chkShowCaption.ObjValue.ToString()) + ",";
					text = text + base.DbConn.SQLFormatString(chkShowImage.ObjValue.ToString()) + ");";
					_ListQuerySql.Add(text);
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	private FXRETURN SaveVoceMenu(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(txtVoce.ObjValue.ToString(), "", false) != 0 && Operators.CompareString(((ListControl)optTipoGriglia).SelectedValue, "S", false) == 0)
			{
				if (((CheckBox)chkSovrascriviConfigurazione).Checked)
				{
					text = "DELETE FROM WFI_MENU_VOCI WHERE VOCE=" + base.DbConn.SQLFormatString(txtVoce.ObjValue.ToString().ToUpper()) + " OR ";
					text = text + "VOCE = " + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ";";
					_ListQuerySql.Add(text);
				}
				text = "INSERT INTO WFI_MENU_VOCI ";
				text += "(VOCE,TIPONODO,DESCRIZIONE,TEXT,FUNZIONE,DESKTOPIMAGE,UTEINS,UTEAGG) VALUES( ";
				text = text + base.DbConn.SQLFormatString(txtVoce.ObjValue.ToString().ToUpper()) + ", ";
				text += "'N',";
				text = text + "'GRIGLIA " + txtNomRif.Text.ToUpper() + "', ";
				text = ((Operators.CompareString(txtDescrizioneVoce.ObjValue.ToString(), "", false) != 0) ? (text + base.DbConn.SQLFormatString(txtDescrizioneVoce.ObjValue.ToString()) + ", ") : (text + base.DbConn.SQLFormatString(txtDesTab.ObjValue.ToString()) + ", "));
				text = text + "'~/WFI/Form/WFStandardGrid.aspx?NomRif=" + txtNomRif.Text.ToUpper() + "', ";
				text += "'~/images/Toolbar/96/DesktopGenericIcon.png', ";
				text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
				text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ");";
				_ListQuerySql.Add(text);
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

	private FXRETURN ApplicoQuery(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			StringEnumerator enumerator = _ListQuerySql.GetEnumerator();
			while (true)
			{
				if (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					val = base.DbConn.SqlExec(current, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					continue;
				}
				val2 = (FXRETURN)0;
				break;
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

	protected override void ReturnToCaller()
	{
		base.ReturnToCaller();
	}

	private void optTipoGriglia_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (Operators.CompareString(((ListControl)optTipoGriglia).SelectedValue, "I", false) == 0)
			{
				((CheckBox)chkPulsanteAnnullaFiltro).Checked = false;
				chkPulsanteAnnullaFiltro.Enabled = false;
				((CheckBox)chkPulsanteEsporta).Checked = false;
				chkPulsanteEsporta.Enabled = false;
				((CheckBox)chkPulsanteStampa).Checked = false;
				chkPulsanteStampa.Enabled = false;
				((CheckBox)chkPulsanteFiltro).Checked = false;
				chkPulsanteFiltro.Enabled = false;
				((CheckBox)chkShowCaption).Checked = true;
				((CheckBox)chkShowImage).Checked = true;
			}
			else
			{
				chkPulsanteAnnullaFiltro.Enabled = true;
				chkPulsanteEsporta.Enabled = true;
				chkPulsanteStampa.Enabled = true;
				chkPulsanteFiltro.Enabled = true;
				((CheckBox)chkShowCaption).Checked = false;
				((CheckBox)chkShowImage).Checked = true;
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
				WriteErrorMessage(rsMess);
			}
			else
			{
				base.MasterPage.MasterUpdatePanel.Update();
			}
		}
	}

	private void optTipoObjectManager_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (Operators.CompareString(((ListControl)optTipoObjectManager).SelectedValue, "N", false) == 0)
			{
				cmbObjectManager.ReadOnly = true;
				txtDescrizioneObjectManager.Enabled = true;
				txtRedirectToObjectManager.Enabled = true;
				txtTabellaObjectManager.Enabled = true;
			}
			else if (Operators.CompareString(((ListControl)optTipoObjectManager).SelectedValue, "E", false) == 0)
			{
				cmbObjectManager.ReadOnly = false;
				txtDescrizioneObjectManager.Enabled = false;
				txtRedirectToObjectManager.Enabled = false;
				txtTabellaObjectManager.Enabled = false;
			}
			else
			{
				cmbObjectManager.ReadOnly = true;
				txtDescrizioneObjectManager.Enabled = false;
				txtRedirectToObjectManager.Enabled = false;
				txtTabellaObjectManager.Enabled = false;
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
				WriteErrorMessage(rsMess);
			}
			else
			{
				base.MasterPage.MasterUpdatePanel.Update();
			}
		}
	}

	protected override FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return (FXRETURN)0;
	}
}
