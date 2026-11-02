<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANATrasportatori.aspx.vb" Inherits="Incasbo.Web.GDO.WFANATrasportatori" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv WFANATrasportatori">
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="true" AutoPostBack="false" TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto"
                                UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                            <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Anagrafica" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody DetailFormSectionDivControlContainer" Style="padding-top: 10px; padding-bottom: 10px;">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"> </iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 105px">
                                                            <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Required="True" Width="100px"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 385px">
                                                            <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 20px">
                                                            <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
                                                            <iwc:IboWebLabel ID="lblIsDefault" runat="server" Text="Default:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 40px">
                                                            <iwc:IboWebCheckBox ID="chkIsDefault" runat="server" Checked="False" Value="N" IncasTag="IsDefault=S"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodiceContabile" runat="server" Text="Codice Contabile:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 105px">
                                                            <iwc:IboWebTextBox ID="txtCodiceContabile" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="100px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblRagioneSociale" runat="server" Text="Ragione Sociale:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 617px;">
                                                            <iwc:IboWebTextBox ID="txtRagioneSociale" runat="server" Required="true" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                            <iwc:IboWebLabel ID="lblTelefono" runat="server" Text="Telefono:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 145px;">
                                                            <iwc:IboWebTextBox ID="txtTelefono" runat="server" CharacterCase="Uppercase" MaxLength="15" FieldName="Telefono" Width="140px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 617px;">
                                                            <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px" ToolTip="Indirizzo (via, piazza, ...)">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                            <iwc:IboWebLabel ID="lblFax" runat="server" Text="Fax:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 145px;">
                                                            <iwc:IboWebTextBox ID="txtFax" runat="server" CharacterCase="Uppercase" MaxLength="15" FieldName="Fax" Width="140px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td style="width: 100px;"></td>
                                                        <td class="DetailFormValueCell" style="width: 620px;">
                                                            <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                            </iwc:IboWebTextBox>
                                                            <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="452px" ToolTip="Località">
                                                            </iwc:IboWebTextBox>
                                                            <iwc:IboWebTextBox ID="txtProvincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" ToolTip="Provincia">
                                                            </iwc:IboWebTextBox>
                                                            <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                            <iwc:IboWebLabel ID="lblCodiceFiscale" runat="server" Text="Codice Fiscale:">
                                                            </iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 145px;">
                                                            <iwc:IboWebTextBox ID="txtCodiceFiscale" runat="server" CharacterCase="Uppercase" MaxLength="16" FieldName="CodiceFiscale" Width="140px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblEmail" runat="server" Text="Email:">
                                                            </iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 617px;">
                                                            <iwc:IboWebTextBox ID="txtEmail" runat="server" CharacterCase="None" MaxLength="255" FieldName="Email" ValidationRules="Email" Width="612px"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                            <iwc:IboWebLabel ID="lblPartitaIva" runat="server" Text="Partita Iva:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 145px;">
                                                            <iwc:IboWebTextBox ID="txtPartitaIva" runat="server" CharacterCase="Uppercase" MaxLength="16" FieldName="PartitaIva" Width="140px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblRiferimento" runat="server" Text="Riferimento:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 617px;">
                                                            <iwc:IboWebTextBox ID="txtRiferimento" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="612px" ToolTip="Persona di riferimento"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblZonaPartenza" runat="server" Text="Zona Partenza:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 617px;">
                                                            <iwc:IboWebComboTlk ID="cmbZonaPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaPassiva" Width="300px" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                AutoLoadOnDemand="true" DropDownWidth="400px">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 852px;">
                                                            <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" MaxLength="255" Rows="3" TextMode="MultiLine" FieldName="Note" Width="847px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <asp:Panel ID="cpFiller_Title" runat="server" Visible="True" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpFiller_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Campi Aggiuntivi"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpFiller_Body" runat="server" CssClass="CollapsiblePanelBody" Style="padding-top: 10px; padding-bottom: 10px;">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa1" runat="server" IncasTag="" Text="Filler 1:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa1" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa2" runat="server" IncasTag="" Text="Filler 2:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa2" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa3" runat="server" IncasTag="" Text="Filler 3:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa3" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa4" runat="server" IncasTag="" Text="Filler 4:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa4" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa5" runat="server" IncasTag="" Text="Filler 5:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa5" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa6" runat="server" IncasTag="" Text="Filler 6:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa6" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa7" runat="server" IncasTag="" Text="Filler 7:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa7" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa8" runat="server" IncasTag="" Text="Filler 8:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa8" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa9" runat="server" IncasTag="" Text="Filler 9:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa9" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFillerAlfa10" runat="server" IncasTag="" Text="Filler 10:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 200px">
                                                            <iwc:IboWebTextBox ID="txtFillerAlfa10" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="190px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpAmministrazione" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpAmministrazioneCaption" Text="Amministr."></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                            <asp:Panel ID="cpAmministrazione_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpAmministrazione_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Amministrazione/Gestione"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpAmministrazione_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid" Style="padding-top: 10px; padding-bottom: 10px;">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblFatturaA" runat="server" Text="Trasp. di Fatturaz.:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 555px">
                                                            <iwc:IboWebComboTlk ID="cmbFatturaA" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="550px"
                                                                AutoLoadOnDemand="true" AutoPostBack="True" ToolTip="Trasportatore (se diverso) al quale fatturare gli addebiti intestatati a questa anagrafica">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblAlboTrasportatori" runat="server" Text="Albo Trasportatori:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 160px">
                                                            <iwc:IboWebTextBox ID="txtAlboTrasportatori" runat="server" MaxLength="60" CharacterCase="Uppercase" Width="155px"></iwc:IboWebTextBox>
                                                        </td>                                                        
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblZonaSpedizione" runat="server" Text="Zona Spedizione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 555px">
                                                            <iwc:IboWebComboTlk ID="cmbZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneSpedizione" Width="550px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblEsportazioneBolle" runat="server" Text="Export ddt stampati:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 160px">
                                                            <iwc:IboWebRadioButtonList ID="optEsportazioneBolle" runat="server" RepeatDirection="Horizontal" Required="True">
                                                                <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                                <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodiceIva" runat="server" Text="Esenzione Iva:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 555px">
                                                            <iwc:IboWebComboTlk ID="cmbCodiceIva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CodiciIvaEsenzione" Width="550px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" ToolTip="Codice esenzione IVA (solo per clienti in esenzione)">
                                                            </iwc:IboWebComboTlk>
                                                        </td>                                                        
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblCodicePagamento" runat="server" Text="Pagamento:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 555px">
                                                            <iwc:IboWebComboTlk ID="cmbCodicePagamento" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CodiciPagamento" Width="550px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblReportBordero" runat="server" Text="Report Bordero:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 210px;">
                                                            <iwc:IboWebTextBox ID="txtReportBordero" runat="server" CharacterCase="Uppercase" MaxLength="30" Width="200px" ToolTip="Nome del file (.rpt) per il report dei viaggi"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 104px;">
                                                            <iwc:IboWebLabel ID="lblReportFattura" runat="server" Text="Report Fatture:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 210px;">
                                                            <iwc:IboWebTextBox ID="txtReportFattura" runat="server" CharacterCase="Uppercase" MaxLength="30" Width="200px" ToolTip="Nome del file (.rpt) per il report delle fatture"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblDatFat" runat="server" Text="Data fatt. spediz.:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 168px">
                                                            <iwc:IboDropDownList ID="cmbDataPerFatturazione" runat="server" SqlQuery="SELECT * FROM CBO_DataFatturazione" Width="167px" ToolTip="Data da utilizzare per la ricerca delle tariffe a listino e la selezione in fase di fatturazione relativamente alle spedizioni"></iwc:IboDropDownList>
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
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblDatFatViaggi" runat="server" Text="Data fatt. viaggi.:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboDropDownList ID="cmbDataPerFatturazioneViaggi" runat="server" SqlQuery="SELECT * FROM CBO_DataFatturazioneViaggi" Width="167px" ToolTip="Data da utilizzare per la ricerca delle tariffe a listino e la selezione in fase di fatturazione relativamente ai Viaggi"></iwc:IboDropDownList>
                                                        </td>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpContatti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpContattiCaption" Text="Contatti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpContatti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                                    <asp:Panel ID="cpContatti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpContatti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Contatti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpContatti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdTrasportatoriContatti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlTrasportatoriContatti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdTrasportatoriContatti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpDocumenti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDocumentiCaption" Text="Documenti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpDocumenti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                                    <asp:Panel ID="cpDocumenti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpDocumenti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Documenti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpDocumenti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdTrasportatoriDocumenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlTrasportatoriDocumenti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdTrasportatoriDocumenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpClassi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpClassiCaption" Text="Classi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                            <asp:Panel ID="cpClassi_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpClassi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Classi"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpClassi_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:IboWebCheckBoxList runat="server" ID="TrasportatoriClassi" SqlQuery="SELECT * FROM CHK_ANA_TRASPORTATORI_CLASSI" SqlQueryFilter="TRASPORTATORE='<#MASTER_RECORD.CODICE#>'"
                                                                FieldName1="TRASPORTATORE" FieldName2="CLASSE" TableName="TrasportatoriClassi">
                                                            </iwc:IboWebCheckBoxList>
                                                        </td>
                                                        <td>
                                                            <iwc:IboWebButton ID="btnTuttiClassi" runat="server" Text="Tutti" CssClass="Button_CheckAll" />
                                                            <br />
                                                            <iwc:IboWebButton ID="btnNessunoClassi" runat="server" Text="Nessuno" CssClass="Button_UncheckAll" CausesValidation="False" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpInfoAgg" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpInfoAggCaption" Text="Info"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpInfoAgg" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                                    <asp:Panel ID="cpInfoAgg_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpInfoAgg_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Informazioni aggiuntive"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpInfoAgg_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdTrasportatoriInfoAggiuntive" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlTrasportatoriInfoAggiuntive" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdTrasportatoriInfoAggiuntive" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpEventi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpEventiCaption" Text="Eventi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpEventi" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                                    <asp:Panel ID="cpEventi_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpEventi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Scambio Dati"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpEventi_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdTraportatoriEventi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                                        CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlTraportatoriEventi" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdTraportatoriEventi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpTipiMezzo" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpTipiMezzoCaption" Text="Tipi mezzo"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpTipiMezzo" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 270px;">
                                                    <asp:Panel ID="Panel1" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="IboWebLabel1" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Tipi mezzo"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="Panel2" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdTraportatoriTipiMezzo" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                                        CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="Panel3" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdTraportatoriTipiMezzo" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
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
