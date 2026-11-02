<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAClienti.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAClienti" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFANAClienti.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr>
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c3">
                                <div class="DetailFormModeImageDiv">
                                    <asp:Image ID="imgModalita" runat="server" />
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1140px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="true" AutoPostBack="false" TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto"
                                UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Anagrafica" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody DetailFormSectionDivControlContainer" Style="padding-top: 10px; padding-bottom: 10px;">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 108px">
                                                            <iwc:IboWebTextBox ID="txtCodice" runat="server" MaxLength="15" Required="True" Width="100px" FieldName="Codice"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodiceContabile" runat="server" Text="Codice Contabile:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 108px">
                                                            <iwc:IboWebTextBox ID="txtCodiceContabile" runat="server" MaxLength="15" Width="100px" FieldName="CodiceContabile"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                            <iwc:IboWebLabel ID="lblClienteMittente" runat="server" Text="Tipologia:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 160px">
                                                            <iwc:IboWebRadioButtonList ID="optClienteMittente" runat="server" RepeatDirection="Horizontal" Required="True">
                                                                <asp:ListItem Selected="True" Text="Cliente" Value="C"></asp:ListItem>
                                                                <asp:ListItem Text="Mittente" Value="M"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 20px">
                                                            <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblRagioneSociale" runat="server" Text="Ragione Sociale:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 500px;">
                                                            <iwc:IboWebTextBox ID="txtRagioneSociale" runat="server" MaxLength="60" Width="490px" FieldName="RagioneSociale" Required="true"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblTelefono" runat="server" Text="Telefono:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 118px;">
                                                            <iwc:IboWebTextBox ID="txtTelefono" runat="server" MaxLength="15" FieldName="Telefono" Width="110px"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblFax" runat="server" Text="Fax:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 118px;">
                                                            <iwc:IboWebTextBox ID="txtFax" runat="server" MaxLength="15" FieldName="Fax" Width="110px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 500px;">
                                                            <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" MaxLength="60" Width="490px" ToolTip="Indirizzo (via, piazza, ...)" FieldName="Indirizzo"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblCodiceFiscale" runat="server" Text="Cod.Fiscale:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 118px;">
                                                            <iwc:IboWebTextBox ID="txtCodiceFiscale" runat="server" MaxLength="16" FieldName="CodiceFiscale" ToolTip="Codice fiscale" Width="110px"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblPartitaIva" runat="server" Text="Partita Iva:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 118px;">
                                                            <iwc:IboWebTextBox ID="txtPartitaIva" runat="server" MaxLength="16" FieldName="PartitaIva" Width="110px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td style="width: 100px;"></td>
                                                        <td class="DetailFormValueCell" style="width: 63px;">
                                                            <iwc:IboWebTextBox ID="txtCap" runat="server" MaxLength="10" Width="55px" ToolTip="Cap" FieldName="Cap"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 357px;">
                                                            <iwc:IboWebTextBox ID="txtLocalita" runat="server" MaxLength="60" Width="349px" ToolTip="Località" FieldName="Localita"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 33px;">
                                                            <iwc:IboWebTextBox ID="txtProvincia" runat="server" MaxLength="3" Width="25px" ToolTip="Provincia" FieldName="Provincia"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 35px;">
                                                            <iwc:IboWebTextBox ID="txtNazione" runat="server" MaxLength="6" Width="25px" ToolTip="Nazione" FieldName="Nazione"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblEmail" runat="server" Text="Email:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 500px;">
                                                            <iwc:IboWebTextBox ID="txtEmail" runat="server" CharacterCase="None" MaxLength="255" FieldName="Email" ValidationRules="Email" Width="490px"></iwc:IboWebTextBox>
                                                        </td>

                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblRiferimento" runat="server" Text="Riferimento:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 500px;">
                                                            <iwc:IboWebTextBox ID="txtRiferimento" runat="server" MaxLength="255" Width="490px" ToolTip="Persona di riferimento" FieldName="Riferimento"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebTextBox ID="txtNote" runat="server" MaxLength="255" Rows="4" TextMode="MultiLine" FieldName="Note" Width="490px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <asp:Panel ID="cpAmministrazione_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpAmministrazione_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Amministrazione/Gestione"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpAmministrazione_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid" Style="padding-top: 10px; padding-bottom: 10px;">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFatturaA" runat="server" Text="Cliente Fatturaz.:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 500px">
                                                            <iwc:IboWebComboTlk ID="cmbFatturaA" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" Width="500px" AutoLoadOnDemand="true" AutoPostBack="True" FieldDescription="Cliente di fatturazione"
                                                                Required="true">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblConMagazzino" runat="server" Text="Con deposito:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 80px">
                                                            <iwc:IboWebRadioButtonList ID="optConMagazzino" runat="server" RepeatDirection="Horizontal" Required="True">
                                                                <asp:ListItem Text="Si" Value="S"></asp:ListItem>
                                                                <asp:ListItem Selected="True" Text="No" Value="N"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFlgTra" runat="server" Text="Con transito:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 80px">
                                                            <iwc:IboWebRadioButtonList ID="optFlgTra" runat="server" RepeatDirection="Horizontal" Required="True">
                                                                <asp:ListItem Text="Si" Value="S"></asp:ListItem>
                                                                <asp:ListItem Selected="True" Text="No" Value="N"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodiceIva" runat="server" Text="Esenzione Iva:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 500px">
                                                            <iwc:IboWebComboTlk ID="cmbCodiceIva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CodiciIvaEsenzione" Width="500px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" ToolTip="Codice esenzione IVA (solo per clienti in esenzione)">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblImportazione" runat="server" Text="Import Spedizioni:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 80px">
                                                            <iwc:IboWebRadioButtonList ID="optImportazione" runat="server" RepeatDirection="Horizontal" Required="True">
                                                                <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                                <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblStampaBolla" runat="server" Text="Genera DDT:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 80px">
                                                            <iwc:IboWebRadioButtonList ID="optStampaBolla" runat="server" RepeatDirection="Horizontal" Required="True">
                                                                <asp:ListItem Text="Si" Value="S"></asp:ListItem>
                                                                <asp:ListItem Selected="True" Text="No" Value="N"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodicePagamento" runat="server" Text="Pagamento:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 500px">
                                                            <iwc:IboWebComboTlk ID="cmbCodicePagamento" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CodiciPagamento" Width="500px" AutoLoadOnDemand="false">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblEsportazioneBolle" runat="server" Text="Export DDT:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 80px">
                                                            <iwc:IboWebRadioButtonList ID="optEsportazioneBolle" runat="server" RepeatDirection="Horizontal" Required="True">
                                                                <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                                <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblReportFatture" runat="server" Text="Report Fatture:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 138px;">
                                                            <iwc:IboWebTextBox ID="txtReportFatture" runat="server" MaxLength="30" Width="130px" ToolTip="Nome del file (.rpt) per il report delle fatture"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblReportBolle" runat="server" Text="Report DDT:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 138px;">
                                                            <iwc:IboWebTextBox ID="txtReportBolle" runat="server" MaxLength="30" Width="130px" ToolTip="Nome del file (.rpt) per il report dei DDT"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblNumeratoreBolle" runat="server" Text="Num. DDT:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 70px;">
                                                            <iwc:IboWebNumericTlk ID="txtNumeratoreBolle" runat="server" Width="60px" ToolTip="Numeratore DDT. Inserire -1 per usare il contatore generale di sistema" DecimalDigits="0" WFIMinValue="-1" MinValue="-1"></iwc:IboWebNumericTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblDatFat" runat="server" Text="Data per fatturaz.:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 138px">
                                                            <iwc:IboDropDownList ID="cmbDatFat" runat="server" SqlQuery="SELECT * FROM CBO_DataFatturazione" Width="137px" ToolTip="Data da utilizzare per la ricerca delle tariffe a listino e la selezione in fase di fatturazione"></iwc:IboDropDownList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                            <iwc:IboWebLabel ID="lblStatoMinimoSpedizioniFatt" runat="server" Text="St.M.Spediz:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 103px">
                                                            <iwc:IboDropDownList ID="cmbStatoMinimoSpedizioniFatt" runat="server"  Width="102px" ToolTip ="Stato minimo per la fatturazione delle spedizioni">
                                                                <asp:ListItem Text="" Value=""></asp:ListItem>
                                                                <asp:ListItem Text="ATTIVE" Value="20"></asp:ListItem>
                                                                <asp:ListItem Text="CHIUSE" Value="30"></asp:ListItem>
                                                                <asp:ListItem Text="PARTITE" Value="40"></asp:ListItem>
                                                                <asp:ListItem Text="ESITATE" Value="50"></asp:ListItem>
                                                                <asp:ListItem Text="CERTIFICATE" Value="60"></asp:ListItem>
                                                            </iwc:IboDropDownList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                            <iwc:IboWebLabel ID="lblStatoMinimoViaggiFatt" runat="server" Text="St.M.Viaggi:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 103px">
                                                            <iwc:IboDropDownList ID="cmbStatoMinimoViaggiFatt" runat="server"  Width="102px" ToolTip ="Stato minimo per la fatturazione dei viaggi">
                                                                <asp:ListItem Text="" Value=""></asp:ListItem>
                                                                <asp:ListItem Text="ATTIVI" Value="10"></asp:ListItem>
                                                                <asp:ListItem Text="CHIUSI" Value="20"></asp:ListItem>
                                                                <asp:ListItem Text="PARTITI" Value="30"></asp:ListItem>
                                                                <asp:ListItem Text="TERMINATI" Value="40"></asp:ListItem>
                                                                <asp:ListItem Text="CERTIFICATI" Value="50"></asp:ListItem>
                                                            </iwc:IboDropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpEventi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpEventiCaption" Text="Eventi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>

                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 250px;">
                                            <asp:UpdatePanel runat="server" ID="up_Eventi" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <asp:Panel ID="cpEventi_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpEventi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Eventi"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpEventi_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblEsportazioneEsiti" runat="server" Text="Export Eventi:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 80px">
                                                                    <iwc:IboWebCheckBox ID="chkEsportazioneEsiti" runat="server" Checked="True" Value="S" FieldName="EsportazioneEsiti" AutoPostBack="true"></iwc:IboWebCheckBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <hr class="Separatore" />
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdClientiEventiTipi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                                        CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlClientiEventiTipi" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdClientiEventiTipi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <pagersettings mode="NumericFirstLast" position="TopAndBottom" />
                                                                            <pagerstyle font-size="Small" />
                                                                            <rowstyle bordercolor="Black" borderstyle="Solid" borderwidth="1px" height="20px" horizontalalign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <hr class="Separatore" />
                                                        <asp:Panel ID="Panel1" runat="server" CssClass="CollapsiblePanelTitle">
                                                            <iwc:IboWebLabel ID="IboWebLabel1" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Clienti Eventi"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdClientiEventi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                                        CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlClientiEventi" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdClientiEventi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <pagersettings mode="NumericFirstLast" position="TopAndBottom" />
                                                                            <pagerstyle font-size="Small" />
                                                                            <rowstyle bordercolor="Black" borderstyle="Solid" borderwidth="1px" height="20px" horizontalalign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpContatti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpContattiCaption" Text="Contatti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 250px;">
                                            <asp:Panel ID="cpContatti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpContatti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Contatti"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpContatti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdClientiContatti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <asp:Panel ID="pnlClientiContatti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                <iwc:IboGridView ID="grdClientiContatti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                    <pagersettings mode="NumericFirstLast" position="TopAndBottom" />
                                                                    <pagerstyle font-size="Small" />
                                                                    <rowstyle bordercolor="Black" borderstyle="Solid" borderwidth="1px" height="20px" horizontalalign="Left" />
                                                                </iwc:IboGridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpClassi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpClassiCaption" Text="Classi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 250px;">
                                            <asp:Panel ID="cpClassi_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpClassi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Classi"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpClassi_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                <asp:UpdatePanel runat="server" ID="up_cpClassi_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="tableGridContainer" style="width: 800px;">
                                                            <tr>
                                                                <td style="width: 600px; min-height: 100px; border: solid 1px #cccccc;">
                                                                    <iwc:IboWebCheckBoxList runat="server" ID="ClientiClassi" SqlQuery="SELECT * FROM CHK_ANA_CLIENTI_CLASSI" SqlQueryFilter="CLIENTE='<#MASTER_RECORD.CODICE#>'"
                                                                        FieldName1="CLIENTE" FieldName2="CLASSE" TableName="ClientiClassi">
                                                                    </iwc:IboWebCheckBoxList>
                                                                </td>
                                                                <td style="vertical-align: top; padding-left: 5px;">
                                                                    <iwc:IboWebButton ID="btnTuttiClassi" runat="server" Text="Tutti" CssClass="Button_CheckAll" />
                                                                    <br />
                                                                    <iwc:IboWebButton ID="btnNessunoClassi" runat="server" Text="Nessuno" CssClass="Button_UncheckAll" Style="margin-top: 3px;" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpInfoAgg" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpInfoAggCaption" Text="Info"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 250px;">
                                            <asp:Panel ID="cpInfoAgg_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpInfoAgg_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Informazioni aggiuntive"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpInfoAgg_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdClientiInfoAggiuntive" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <asp:Panel ID="pnlClientiInfoAggiuntive" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                <iwc:IboGridView ID="grdClientiInfoAggiuntive" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                    <pagersettings mode="NumericFirstLast" position="TopAndBottom" />
                                                                    <pagerstyle font-size="Small" />
                                                                    <rowstyle bordercolor="Black" borderstyle="Solid" borderwidth="1px" height="20px" horizontalalign="Left" />
                                                                </iwc:IboGridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpDocumenti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDocumentiCaption" Text="Documenti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 250px;">
                                            <asp:Panel ID="cpDocumenti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpDocumenti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Documenti"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpDocumenti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdClientiDocumenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <asp:Panel ID="pnlClientiDocumenti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                <iwc:IboGridView ID="grdClientiDocumenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                    <pagersettings mode="NumericFirstLast" position="TopAndBottom" />
                                                                    <pagerstyle font-size="Small" />
                                                                    <rowstyle bordercolor="Black" borderstyle="Solid" borderwidth="1px" height="20px" horizontalalign="Left" />
                                                                </iwc:IboGridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpTipiSpedizione" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpTipiSpedizioneCaption" Text="Tipi Sped."></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 250px;">
                                            <asp:Panel ID="cpTipiSpedizione_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpTipiSpedizione_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Tipi Spedizione"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpTipiSpedizione_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdClientiTipiSpedizione" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <asp:Panel ID="pnlClientiTipiSpedizione" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                <iwc:IboGridView ID="grdClientiTipiSpedizione" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                    <pagersettings mode="NumericFirstLast" position="TopAndBottom" />
                                                                    <pagerstyle font-size="Small" />
                                                                    <rowstyle bordercolor="Black" borderstyle="Solid" borderwidth="1px" height="20px" horizontalalign="Left" />
                                                                </iwc:IboGridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                            </ajaxToolkit:TabContainer>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel" style="margin-left: 100px;">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C"></td>
                                <td id="tableButtons_R" class="tableButtons_R">
                                    <iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
