using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFANAPCS : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkPuntoDiDeposito")]
	private IboWebCheckBox _chkPuntoDiDeposito;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkIsFiliale")]
	private IboWebCheckBox _chkIsFiliale;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnTuttiClassi")]
	private IboWebButton _btnTuttiClassi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnNessunoClassi")]
	private IboWebButton _btnNessunoClassi;

	private bool _InsertIntoPCSZone;

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

	[field: AccessedThroughProperty("TcMain")]
	protected virtual TabContainer TcMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpGen")]
	protected virtual TabPanel tpGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpGenCaption")]
	protected virtual IboWebLabel tpGenCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpGen")]
	protected virtual UpdatePanel up_tpGen
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

	[field: AccessedThroughProperty("lblCodiceContabile")]
	protected virtual IboWebLabel lblCodiceContabile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodiceContabile")]
	protected virtual IboWebTextBox txtCodiceContabile
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

	[field: AccessedThroughProperty("chkAttivo")]
	protected virtual IboWebCheckBox chkAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRagioneSociale")]
	protected virtual IboWebLabel lblRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRagioneSociale")]
	protected virtual IboWebTextBox txtRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTelefono")]
	protected virtual IboWebLabel lblTelefono
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTelefono")]
	protected virtual IboWebTextBox txtTelefono
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIndirizzo")]
	protected virtual IboWebLabel lblIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIndirizzo")]
	protected virtual IboWebTextBox txtIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFax")]
	protected virtual IboWebLabel lblFax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFax")]
	protected virtual IboWebTextBox txtFax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCap")]
	protected virtual IboWebTextBox txtCap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLocalita")]
	protected virtual IboWebTextBox txtLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtProvincia")]
	protected virtual IboWebTextBox txtProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNazione")]
	protected virtual IboWebTextBox txtNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceFiscale")]
	protected virtual IboWebLabel lblCodiceFiscale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodiceFiscale")]
	protected virtual IboWebTextBox txtCodiceFiscale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEmail")]
	protected virtual IboWebLabel lblEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEmail")]
	protected virtual IboWebTextBox txtEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartitaIva")]
	protected virtual IboWebLabel lblPartitaIva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPartitaIva")]
	protected virtual IboWebTextBox txtPartitaIva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimento")]
	protected virtual IboWebLabel lblRiferimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimento")]
	protected virtual IboWebTextBox txtRiferimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRiferimenti_Title")]
	protected virtual Panel cpRiferimenti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRiferimenti_Title_Caption")]
	protected virtual IboWebLabel cpRiferimenti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRiferimenti_Body")]
	protected virtual Panel cpRiferimenti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PuntoDiSimulazione")]
	protected virtual IboWebHidden PuntoDiSimulazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoDiDestino")]
	protected virtual IboWebLabel lblPuntoDiDestino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPuntoDiDestino")]
	protected virtual IboWebCheckBox chkPuntoDiDestino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoDiCarico")]
	protected virtual IboWebLabel lblPuntoDiCarico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPuntoDiCarico")]
	protected virtual IboWebCheckBox chkPuntoDiCarico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoDiParcoVeicolare")]
	protected virtual IboWebLabel lblPuntoDiParcoVeicolare
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPuntoDiParcoVeicolare")]
	protected virtual IboWebCheckBox chkPuntoDiParcoVeicolare
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoDiDeposito")]
	protected virtual IboWebLabel lblPuntoDiDeposito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox chkPuntoDiDeposito
	{
		[CompilerGenerated]
		get
		{
			return _chkPuntoDiDeposito;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = chkIsFilialeDeposito_CheckedChanged;
			IboWebCheckBox val = _chkPuntoDiDeposito;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged -= eventHandler;
			}
			_chkPuntoDiDeposito = value;
			val = _chkPuntoDiDeposito;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblIsFiliale")]
	protected virtual IboWebLabel lblIsFiliale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox chkIsFiliale
	{
		[CompilerGenerated]
		get
		{
			return _chkIsFiliale;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = chkIsFilialeDeposito_CheckedChanged;
			IboWebCheckBox val = _chkIsFiliale;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged -= eventHandler;
			}
			_chkIsFiliale = value;
			val = _chkIsFiliale;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblDestinatario")]
	protected virtual IboWebLabel lblDestinatario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkDestinatario")]
	protected virtual IboWebCheckBox chkDestinatario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceTrasportatore")]
	protected virtual IboWebLabel lblCodiceTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCodiceTrasportatore")]
	protected virtual IboWebComboTlk cmbCodiceTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceCaricatore")]
	protected virtual IboWebLabel lblCodiceCaricatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCodiceCaricatore")]
	protected virtual IboWebComboTlk cmbCodiceCaricatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceDestinatario")]
	protected virtual IboWebLabel lblCodiceDestinatario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCodiceDestinatario")]
	protected virtual IboWebComboTlk cmbCodiceDestinatario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoExtra_Title")]
	protected virtual Panel cpInfoExtra_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoExtra_Title_Caption")]
	protected virtual Label cpInfoExtra_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoExtra_Body")]
	protected virtual Panel cpInfoExtra_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoRitiro1")]
	protected virtual IboWebLabel lblPuntoRitiro1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPuntoRitiro1")]
	protected virtual IboWebComboTlk cmbPuntoRitiro1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoRitiro2")]
	protected virtual IboWebLabel lblPuntoRitiro2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPuntoRitiro2")]
	protected virtual IboWebComboTlk cmbPuntoRitiro2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoRitiro3")]
	protected virtual IboWebLabel lblPuntoRitiro3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPuntoRitiro3")]
	protected virtual IboWebComboTlk cmbPuntoRitiro3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGruppoTariffa")]
	protected virtual IboWebLabel lblGruppoTariffa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbGruppoTariffa")]
	protected virtual IboWebComboTlk cmbGruppoTariffa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCEDI")]
	protected virtual IboWebLabel lblCEDI
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCEDI")]
	protected virtual IboWebComboTlk cmbCEDI
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpAltriDati")]
	protected virtual TabPanel tpAltriDati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpAltriDatiCaption")]
	protected virtual IboWebLabel tpAltriDatiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpAltriDati")]
	protected virtual UpdatePanel up_tpAltriDati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAltriDati_Title")]
	protected virtual Panel cpAltriDati_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEquipaggiamento_Title_Caption")]
	protected virtual IboWebLabel cpEquipaggiamento_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAltriDati_Body")]
	protected virtual Panel cpAltriDati_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNote")]
	protected virtual IboWebLabel lblNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote")]
	protected virtual IboWebTextBox txtNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNotePerUfficio")]
	protected virtual IboWebLabel lblNotePerUfficio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNotePerUfficio")]
	protected virtual IboWebTextBox txtNotePerUfficio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNotePerAutista")]
	protected virtual IboWebLabel lblNotePerAutista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbNotePerAutista")]
	protected virtual IboWebTextBox cmbNotePerAutista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFiller_Title")]
	protected virtual Panel cpFiller_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFiller_Title_Caption")]
	protected virtual IboWebLabel cpFiller_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFiller_Body")]
	protected virtual Panel cpFiller_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa1")]
	protected virtual IboWebLabel lblFillerAlfa1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa1")]
	protected virtual IboWebTextBox txtFillerAlfa1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa2")]
	protected virtual IboWebLabel lblFillerAlfa2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa2")]
	protected virtual IboWebTextBox txtFillerAlfa2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa3")]
	protected virtual IboWebLabel lblFillerAlfa3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa3")]
	protected virtual IboWebTextBox txtFillerAlfa3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa4")]
	protected virtual IboWebLabel lblFillerAlfa4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa4")]
	protected virtual IboWebTextBox txtFillerAlfa4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa5")]
	protected virtual IboWebLabel lblFillerAlfa5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa5")]
	protected virtual IboWebTextBox txtFillerAlfa5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa6")]
	protected virtual IboWebLabel lblFillerAlfa6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa6")]
	protected virtual IboWebTextBox txtFillerAlfa6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa7")]
	protected virtual IboWebLabel lblFillerAlfa7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa7")]
	protected virtual IboWebTextBox txtFillerAlfa7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa8")]
	protected virtual IboWebLabel lblFillerAlfa8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa8")]
	protected virtual IboWebTextBox txtFillerAlfa8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa9")]
	protected virtual IboWebLabel lblFillerAlfa9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa9")]
	protected virtual IboWebTextBox txtFillerAlfa9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa10")]
	protected virtual IboWebLabel lblFillerAlfa10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa10")]
	protected virtual IboWebTextBox txtFillerAlfa10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpContatti")]
	protected virtual TabPanel tpContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpContattiCaption")]
	protected virtual IboWebLabel tpContattiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpContatti")]
	protected virtual UpdatePanel up_tpContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpContatti_Title")]
	protected virtual Panel cpContatti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpContatti_Title_Caption")]
	protected virtual IboWebLabel cpContatti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpContatti_Body")]
	protected virtual Panel cpContatti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSContatti")]
	protected virtual IboWebToolbar tlbgrdPCSContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSContatti")]
	protected virtual Panel pnlPCSContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSContatti")]
	protected virtual IboGridView grdPCSContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDocumenti")]
	protected virtual TabPanel tpDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDocumentiCaption")]
	protected virtual IboWebLabel tpDocumentiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpDocumenti")]
	protected virtual UpdatePanel up_tpDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDocumenti_Title")]
	protected virtual Panel cpDocumenti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDocumenti_Title_Caption")]
	protected virtual IboWebLabel cpDocumenti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDocumenti_Body")]
	protected virtual Panel cpDocumenti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSDocumenti")]
	protected virtual IboWebToolbar tlbgrdPCSDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSDocumenti")]
	protected virtual Panel pnlPCSDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSDocumenti")]
	protected virtual IboGridView grdPCSDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpZone")]
	protected virtual TabPanel tpZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpZoneCaption")]
	protected virtual IboWebLabel tpZoneCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpZone")]
	protected virtual UpdatePanel up_tpZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpZone_Title")]
	protected virtual Panel cpZone_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpZone_Title_Caption")]
	protected virtual IboWebLabel cpZone_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpZone_Body")]
	protected virtual Panel cpZone_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSZone")]
	protected virtual IboWebToolbar tlbgrdPCSZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSZone")]
	protected virtual Panel pnlPCSZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSZone")]
	protected virtual IboGridView grdPCSZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpOrariVisita")]
	protected virtual TabPanel tpOrariVisita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpOrariVisitaCaption")]
	protected virtual IboWebLabel tpOrariVisitaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpOrariVisita")]
	protected virtual UpdatePanel up_tpOrariVisita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOrariVisita_Title")]
	protected virtual Panel cpOrariVisita_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOrariVisita_Title_Caption")]
	protected virtual IboWebLabel cpOrariVisita_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOrariVisita_Body")]
	protected virtual Panel cpOrariVisita_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSOrariVisita")]
	protected virtual IboWebToolbar tlbgrdPCSOrariVisita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSOrariVisita")]
	protected virtual Panel pnlPCSOrariVisita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSOrariVisita")]
	protected virtual IboGridView grdPCSOrariVisita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpClassiGrandezza")]
	protected virtual TabPanel tpClassiGrandezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpClassiGrandezzaCaption")]
	protected virtual IboWebLabel tpClassiGrandezzaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpClassiGrandezza")]
	protected virtual UpdatePanel up_tpClassiGrandezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassiGrandezza_Title")]
	protected virtual Panel cpClassiGrandezza_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassiGrandezza_Title_Caption")]
	protected virtual IboWebLabel cpClassiGrandezza_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassiGrandezza_Body")]
	protected virtual Panel cpClassiGrandezza_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSClassiGrandezza")]
	protected virtual IboWebToolbar tlbgrdPCSClassiGrandezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSClassiGrandezza")]
	protected virtual Panel pnlPCSClassiGrandezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSClassiGrandezza")]
	protected virtual IboGridView grdPCSClassiGrandezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpEquipaggiamenti")]
	protected virtual TabPanel tpEquipaggiamenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpEquipaggiamentiCaption")]
	protected virtual IboWebLabel tpEquipaggiamentiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpEquipaggiamenti")]
	protected virtual UpdatePanel up_tpEquipaggiamenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEquipaggiamenti_Title")]
	protected virtual Panel cpEquipaggiamenti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEquipaggiamenti_Title_Caption")]
	protected virtual IboWebLabel cpEquipaggiamenti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEquipaggiamenti_Body")]
	protected virtual Panel cpEquipaggiamenti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSEquipaggiamenti")]
	protected virtual IboWebToolbar tlbgrdPCSEquipaggiamenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSEquipaggiamenti")]
	protected virtual Panel pnlPCSEquipaggiamenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSEquipaggiamenti")]
	protected virtual IboGridView grdPCSEquipaggiamenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpGeocodifica")]
	protected virtual TabPanel tpGeocodifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpGeocodificaCaption")]
	protected virtual IboWebLabel tpGeocodificaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpGeocodifica")]
	protected virtual UpdatePanel up_tpGeocodifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGeocodifica_Title")]
	protected virtual Panel cpGeocodifica_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGeocodifica_Title_Caption")]
	protected virtual IboWebLabel cpGeocodifica_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGeocodifica_Body")]
	protected virtual Panel cpGeocodifica_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSGeocodifica")]
	protected virtual IboWebToolbar tlbgrdPCSGeocodifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSGeocodifica")]
	protected virtual Panel pnlPCSGeocodifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSGeocodifica")]
	protected virtual IboGridView grdPCSGeocodifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpInfoAgg")]
	protected virtual TabPanel tpInfoAgg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpInfoAggCaption")]
	protected virtual IboWebLabel tpInfoAggCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpInfoAgg")]
	protected virtual UpdatePanel up_tpInfoAgg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoAgg_Title")]
	protected virtual Panel cpInfoAgg_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoAgg_Title_Caption")]
	protected virtual IboWebLabel cpInfoAgg_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoAgg_Body")]
	protected virtual Panel cpInfoAgg_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSInfoAggiuntive")]
	protected virtual IboWebToolbar tlbgrdPCSInfoAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSInfoAggiuntive")]
	protected virtual Panel pnlPCSInfoAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSInfoAggiuntive")]
	protected virtual IboGridView grdPCSInfoAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpClassi")]
	protected virtual TabPanel tpClassi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpClassiCaption")]
	protected virtual IboWebLabel tpClassiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassi_Title")]
	protected virtual Panel cpClassi_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassi_Title_Caption")]
	protected virtual IboWebLabel cpClassi_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassi_Body")]
	protected virtual Panel cpClassi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSClassi")]
	protected virtual IboWebCheckBoxList PCSClassi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnTuttiClassi
	{
		[CompilerGenerated]
		get
		{
			return _btnTuttiClassi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnTuttiClassi_Click;
			IboWebButton val = _btnTuttiClassi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnTuttiClassi = value;
			val = _btnTuttiClassi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnNessunoClassi
	{
		[CompilerGenerated]
		get
		{
			return _btnNessunoClassi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnNessunoClassi_Click;
			IboWebButton val = _btnNessunoClassi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnNessunoClassi = value;
			val = _btnNessunoClassi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("tpAcquisiti")]
	protected virtual TabPanel tpAcquisiti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpAcquisitiCaption")]
	protected virtual IboWebLabel tpAcquisitiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpAcquisiti")]
	protected virtual UpdatePanel up_tpAcquisiti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAcquisiti_Title")]
	protected virtual Panel cpAcquisiti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAcquisiti_Title_Caption")]
	protected virtual IboWebLabel cpAcquisiti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAcquisiti_Body")]
	protected virtual Panel cpAcquisiti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdPCSAcquisiti")]
	protected virtual IboWebToolbar tlbgrdPCSAcquisiti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPCSAcquisiti")]
	protected virtual Panel pnlPCSAcquisiti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdPCSAcquisiti")]
	protected virtual IboGridView grdPCSAcquisiti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1_idle")]
	protected virtual Button Button1_idle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFANAPCS()
	{
		_InsertIntoPCSZone = false;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.ANA.PCS";
		if (Operators.CompareString(((Page)this).Request.QueryString["PuntoDiSimulazione"] ?? "", "S", false) == 0)
		{
			_Title = base.Translator.Translate("XXX", "Punto Carico\\Scarico (Simulazione)", new string[0]);
		}
		else
		{
			_Title = base.Translator.Translate("XXX", "Punto Carico\\Scarico", new string[0]);
		}
		FXRETURN result = base.InitializedPage(ref rsMess);
		if (Operators.CompareString(_objFunctionArguments.Context.ToUpper(), "DM.ANA.PCS#CORRISPONDENTI", false) == 0)
		{
			((CheckBox)chkIsFiliale).Checked = false;
			chkIsFiliale.Enabled = false;
			((CheckBox)chkPuntoDiDeposito).Checked = true;
			chkPuntoDiDeposito.Enabled = false;
			cmbCodiceTrasportatore.Required = true;
		}
		if (!((Page)this).IsPostBack)
		{
			lblFillerAlfa1.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA1", lblFillerAlfa1.ObjValue.ToString());
			lblFillerAlfa2.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA2", lblFillerAlfa2.ObjValue.ToString());
			lblFillerAlfa3.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA3", lblFillerAlfa3.ObjValue.ToString());
			lblFillerAlfa4.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA4", lblFillerAlfa4.ObjValue.ToString());
			lblFillerAlfa5.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA5", lblFillerAlfa5.ObjValue.ToString());
			lblFillerAlfa6.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA6", lblFillerAlfa6.ObjValue.ToString());
			lblFillerAlfa7.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA7", lblFillerAlfa7.ObjValue.ToString());
			lblFillerAlfa8.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA8", lblFillerAlfa8.ObjValue.ToString());
			lblFillerAlfa9.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA9", lblFillerAlfa9.ObjValue.ToString());
			lblFillerAlfa10.ObjValue = base.SessionEnvironment.ApplicationParams.PCS_GetFieldText("FILLERALFA10", lblFillerAlfa10.ObjValue.ToString());
		}
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Invalid comparison between Unknown and I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig2 = iboInternalGridConfig;
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdPCSContatti;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdPCSContatti = objGridView;
			iboInternalGridConfig.Build("DM.ANA.CONTATTI#PCS", "SELECT * FROM GRD_ANA_PCS_Contatti WHERE CodicePCS='<%CODICE%>'", "", "", ((Control)grdPCSContatti).ID, ((Control)tlbgrdPCSContatti).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdPCSInfoAggiuntive;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdPCSInfoAggiuntive = objGridView;
			iboInternalGridConfig.Build("DM.ANA.INFOAGGANAGRAFICHE#PCS", "SELECT * FROM GRD_ANA_PCS_InfoAgg WHERE CodicePCS='<%CODICE%>'", "", "", ((Control)grdPCSInfoAggiuntive).ID, ((Control)tlbgrdPCSInfoAggiuntive).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdPCSDocumenti;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdPCSDocumenti = objGridView;
			iboInternalGridConfig.Build("DM.ANA.DOCUMENTIANA#PCS", "SELECT * FROM GRD_ANA_PCS_Documenti WHERE CodicePCS='<%CODICE%>'", "", "", ((Control)grdPCSDocumenti).ID, ((Control)tlbgrdPCSDocumenti).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
			StateBag myViewState4 = base.MyViewState;
			objGridView = grdPCSClassiGrandezza;
			iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
			grdPCSClassiGrandezza = objGridView;
			iboInternalGridConfig.Build("DM.ANA.PCS.CLASSIGRANDEZZA", "SELECT * FROM GRD_ANA_PCS_ClassiGrandezza WHERE PCS ='<%CODICE%>'", "", "", ((Control)grdPCSClassiGrandezza).ID, ((Control)tlbgrdPCSClassiGrandezza).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig6 = iboInternalGridConfig;
			StateBag myViewState5 = base.MyViewState;
			objGridView = grdPCSZone;
			iboInternalGridConfig6.InitUi(myViewState5, ref objGridView);
			grdPCSZone = objGridView;
			iboInternalGridConfig.Build("DM.ANA.PCS.ZONE", "SELECT * FROM GRD_ANA_PCS_Zone WHERE PCS='<%CODICE%>'", "", "", ((Control)grdPCSZone).ID, ((Control)tlbgrdPCSZone).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig7 = iboInternalGridConfig;
			StateBag myViewState6 = base.MyViewState;
			objGridView = grdPCSEquipaggiamenti;
			iboInternalGridConfig7.InitUi(myViewState6, ref objGridView);
			grdPCSEquipaggiamenti = objGridView;
			iboInternalGridConfig.Build("DM.ANA.PCS.EQUIPAGGIAMENTI", "SELECT * FROM GRD_ANA_PCS_Equipaggiamenti WHERE PCS='<%CODICE%>'", "", "", ((Control)grdPCSEquipaggiamenti).ID, ((Control)tlbgrdPCSEquipaggiamenti).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig8 = iboInternalGridConfig;
			StateBag myViewState7 = base.MyViewState;
			objGridView = grdPCSAcquisiti;
			iboInternalGridConfig8.InitUi(myViewState7, ref objGridView);
			grdPCSAcquisiti = objGridView;
			iboInternalGridConfig.Build("DM.ANA.PCS.ACQUISITI", "SELECT * FROM GRD_ANA_PCS_Acquisiti WHERE CODICEINTERNO='<%CODICE%>'", "", "", ((Control)grdPCSAcquisiti).ID, ((Control)tlbgrdPCSAcquisiti).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig9 = iboInternalGridConfig;
			StateBag myViewState8 = base.MyViewState;
			objGridView = grdPCSGeocodifica;
			iboInternalGridConfig9.InitUi(myViewState8, ref objGridView);
			grdPCSGeocodifica = objGridView;
			iboInternalGridConfig.Build("DM.ANA.PCS.GEOCODIFICA", "SELECT * FROM GRD_ANA_PCS_Geocodifica WHERE CODICE='<%CODICE%>'", "", "", ((Control)grdPCSGeocodifica).ID, ((Control)tlbgrdPCSGeocodifica).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig10 = iboInternalGridConfig;
			StateBag myViewState9 = base.MyViewState;
			objGridView = grdPCSOrariVisita;
			iboInternalGridConfig10.InitUi(myViewState9, ref objGridView);
			grdPCSOrariVisita = objGridView;
			iboInternalGridConfig.Build("DM.ANA.PCS.ORARIVISITA", "SELECT * FROM GRD_ANA_PCS_OrariVisita WHERE PCS='<%CODICE%>'", "", "", ((Control)grdPCSOrariVisita).ID, ((Control)tlbgrdPCSOrariVisita).ID);
			GridConfigList.Add(iboInternalGridConfig);
			val = base.InitializeInternalGrid(ref rsMess);
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

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
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
				if (!(((CheckBox)chkIsFiliale).Checked | ((CheckBox)chkPuntoDiDeposito).Checked))
				{
					cmbCodiceTrasportatore.Enabled = false;
					cmbCodiceCaricatore.Enabled = false;
				}
				else
				{
					cmbCodiceTrasportatore.Enabled = true;
					cmbCodiceCaricatore.Enabled = true;
				}
				if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
				{
					PuntoDiSimulazione.ObjValue = "N";
					if (Operators.CompareString(((Page)this).Request.QueryString["PuntoDiSimulazione"] ?? "", "S", false) == 0)
					{
						PuntoDiSimulazione.ObjValue = "S";
						chkPuntoDiCarico.ObjValue = "N";
						chkPuntoDiDestino.ObjValue = "N";
						chkPuntoDiParcoVeicolare.ObjValue = "N";
						chkPuntoDiDeposito.ObjValue = "N";
						chkDestinatario.ObjValue = "N";
						((Control)cpRiferimenti_Title).Visible = false;
						((Control)cpRiferimenti_Body).Visible = false;
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(txtNazione.ObjValue.ToString(), "", false) == 0)
			{
				txtNazione.ObjValue = base.ApplicationDefault.NazioneDefault();
			}
			if (!(((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) & (Operators.CompareString(txtCodice.ObjValue.ToString(), "", false) == 0)))
			{
				goto IL_00e2;
			}
			long num = 0L;
			val2 = base.Parametrica.LeggiContatore("COUNTERS.PCS", ref num, ref rsMess);
			if ((int)val2 <= 0)
			{
				txtCodice.ObjValue = num;
				goto IL_00e2;
			}
			val = val2;
			goto end_IL_0005;
			IL_00e2:
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
			}
			end_IL_0005:;
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((!((CheckBox)chkIsFiliale).Checked & ((CheckBox)chkPuntoDiDeposito).Checked) && Operators.CompareString(cmbCodiceTrasportatore.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Obbligatorio definire il trasportatore per un corrispondente");
			}
			else
			{
				string text = "SELECT COUNT(*) FROM NAZIONI WHERE NAZIONE=" + base.DbConn.SQLFormatString(txtNazione.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text, (object)0, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Conversions.ToInteger(obj) == 0)
				{
					rsMess = TranslateMessage("XXX", "Nazione {0} non definita nel sistema", txtNazione.ObjValue.ToString());
				}
				else
				{
					val2 = base.AfterCheckData(ref rsMess);
					if ((int)val2 <= 0)
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
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
				if (!((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) || !_InsertIntoPCSZone)
				{
					goto IL_023c;
				}
				text = "SELECT COUNT(*) FROM PCS_ZONE WHERE PCS=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					string ZonaSpedizione = "";
					string ZonaTariffaAttiva = "";
					string ZonaTariffaPassiva = "";
					if (Conversions.ToInteger(obj) != 0)
					{
						goto IL_023c;
					}
					val2 = Localita_DeterminaZone_Invoker.Instance.RunProc(CreateApiContext(), "", txtLocalita.ObjValue.ToString(), txtProvincia.ObjValue.ToString(), txtCap.ObjValue.ToString(), txtNazione.ObjValue.ToString(), ref ZonaSpedizione, ref ZonaTariffaAttiva, ref ZonaTariffaPassiva, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						text = "INSERT INTO PCS_ZONE (Pcs, TipoMerce, ZonaSpedizione, ZonaTariffaAttiva, ZonaTariffaPassiva, Attivo) VALUES (";
						text = text + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + ",";
						text = text + base.DbConn.SQLFormatString("*ALL") + ",";
						text = text + base.DbConn.SQLFormatString(ZonaSpedizione) + ",";
						text = text + base.DbConn.SQLFormatString(ZonaTariffaAttiva) + ",";
						text = text + base.DbConn.SQLFormatString(ZonaTariffaPassiva) + ",";
						text += "'S')";
						val2 = base.DbConn.SqlExec(text, ref rsMess);
						if ((int)val2 <= 0)
						{
							goto IL_023c;
						}
						val = val2;
					}
				}
			}
			goto end_IL_000b;
			IL_023c:
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Page)this).Request.QueryString["PuntoDiSimulazione"] ?? "", "S", false) == 0) & (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0))
			{
				if ((Operators.CompareString(PuntoDiSimulazione.ObjValue.ToString(), "S", false) == 0) & (Operators.CompareString(chkPuntoDiCarico.ObjValue.ToString(), "N", false) == 0) & (Operators.CompareString(chkPuntoDiDeposito.ObjValue.ToString(), "N", false) == 0) & (Operators.CompareString(chkPuntoDiDestino.ObjValue.ToString(), "N", false) == 0) & (Operators.CompareString(chkPuntoDiParcoVeicolare.ObjValue.ToString(), "N", false) == 0) & (Operators.CompareString(chkDestinatario.ObjValue.ToString(), "N", false) == 0))
				{
					val2 = base.SaveData(ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_01ed;
					}
					val = val2;
				}
				else
				{
					text = "UPDATE PCS SET PuntoDiSimulazione='N', UteAgg=" + base.DbConn.SQLFormatString(base.WFIUser) + ", DatAgg=" + base.DbConn.SQLFormatDate((eTipoData)2, DateAndTime.Now) + " WHERE CODICE=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
					val2 = base.DbConn.SqlExec(text, ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_01ed;
					}
					val = val2;
				}
			}
			else
			{
				val2 = base.SaveData(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_01ed;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_01ed:
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

	protected override FXRETURN ConfermaClick(ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		_InsertIntoPCSZone = true;
		return base.ConfermaClick(ref rsMess);
	}

	private void btnTuttiClassi_Click(object sender, EventArgs e)
	{
		PCSClassi.SelectAll();
	}

	private void btnNessunoClassi_Click(object sender, EventArgs e)
	{
		PCSClassi.UnselectAll();
	}

	private void chkIsFilialeDeposito_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (!(((CheckBox)chkIsFiliale).Checked | ((CheckBox)chkPuntoDiDeposito).Checked))
		{
			IboWebComboTlk objCombo = cmbCodiceTrasportatore;
			string rsMess = "";
			ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess);
			IboWebComboTlk objCombo2 = cmbCodiceCaricatore;
			rsMess = "";
			ComboSelectedItem((IIboDropdownList)(object)objCombo2, "", ref rsMess);
			cmbCodiceTrasportatore.Enabled = false;
			cmbCodiceCaricatore.Enabled = false;
		}
		else
		{
			cmbCodiceTrasportatore.Enabled = true;
			cmbCodiceCaricatore.Enabled = true;
		}
	}

	protected override FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSContatti).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSInfoAggiuntive).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSDocumenti).ID, false) == 0))
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
				PropertyValue = RuntimeHelpers.GetObjectValue(txtRagioneSociale.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			}
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "PCS";
			SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
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
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSGeocodifica).ID, false) != 0)
				{
					object PropertyValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
					SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
					PropertyValue = RuntimeHelpers.GetObjectValue(txtRagioneSociale.ObjValue);
					SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
					string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
					object PropertyValue2 = "PCS";
					SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
					goto IL_017b;
				}
				string text = "SELECT COUNT(*) FROM PCS_Geocodifica WHERE Codice=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Conversions.ToInteger(obj) == 0)
					{
						object PropertyValue3 = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
						SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtCodice", "Text", ref PropertyValue3);
						goto IL_017b;
					}
					rsMess = TranslateMessage("XXX", "Non è possibile inserire più di una geocodifica.");
				}
			}
			goto end_IL_0005;
			IL_017b:
			val = (FXRETURN)0;
			end_IL_0005:;
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
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSContatti).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSInfoAggiuntive).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSDocumenti).ID, false) == 0))
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
				PropertyValue = RuntimeHelpers.GetObjectValue(txtRagioneSociale.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			}
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "PCS";
			SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
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
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSContatti).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSInfoAggiuntive).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdPCSDocumenti).ID, false) == 0))
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
				PropertyValue = RuntimeHelpers.GetObjectValue(txtRagioneSociale.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			}
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "PCS";
			SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
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
			val2 = base.InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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
}
