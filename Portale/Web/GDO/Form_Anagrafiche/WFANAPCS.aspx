<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAPCS.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAPCS" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <script>
        function WFIpageLoad() {
            document.getElementById("txtLocalita").WFIautocompleteselect = function (event, ui) {
                if (ui.item) {
                    var ArrVal = ui.item.value.split(";");
                    try { this.value = ArrVal[0]; } catch (e) { }
                    try { document.getElementById("txtProvincia").value = ArrVal[1]; } catch (e) { }
                    try { document.getElementById("txtNazione").value = ArrVal[2]; } catch (e) { }
                    try {
                        if (document.getElementById("txtCap").value == '') {
                            document.getElementById("txtCap").value = ArrVal[3];
                        }
                    } catch (e) { }
                }
            }
        }
    </script>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1120px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="true" AutoPostBack="false" TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto"
                                UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpGen" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 420px;">
                                                    <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                                        <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Anagrafica" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px">
                                                                   <%-- IncasTag="IdentityCounterName=COUNTERS.PCS"--%>
                                                                    <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="150px" Required="true" >
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                                    <iwc:IboWebLabel ID="lblCodiceContabile" runat="server" Text="Codice Contabile:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px">
                                                                    <iwc:IboWebTextBox ID="txtCodiceContabile" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="150px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <%-- <iwc:IboWebLabel ID="lblIsDefault" runat="server" Text="Default:"></iwc:IboWebLabel>--%>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 40px">
                                                                    <%-- <iwc:IboWebCheckBox ID="chkIsDefault" runat="server" IncasTag="IsDefault=S"
                                                                        Checked="False" Value="N"></iwc:IboWebCheckBox>--%>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 108px">
                                                                    <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 145px">
                                                                    <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblRagioneSociale" runat="server" Text="Ragione Sociale:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 617px;">
                                                                    <iwc:IboWebTextBox ID="txtRagioneSociale" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px" Required="true"></iwc:IboWebTextBox>
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
                                                                    <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px" ToolTip="Indirizzo (via, piazza, ...)" Required="true">
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
                                                                    <iwc:IboWebTextBox ID="txtCap" runat="server" CssClass="WFIAutoComplete" autocomplete-tag="ACV_CAP" autocomplete-minLength="2" autocomplete-serverfunc="GetAutocompleteItems2"
                                                                        CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap" ClientIDMode="Static">
                                                                    </iwc:IboWebTextBox>
                                                                    <iwc:IboWebTextBox ID="txtLocalita" runat="server" CssClass="WFIAutoComplete" autocomplete-tag="ACV_LOCALITA" autocomplete-minLength="2" autocomplete-serverfunc="GetAutocompleteItems2"
                                                                        CharacterCase="Uppercase" ClientIDMode="Static" MaxLength="60" Width="452px" ToolTip="Località" Required="true">
                                                                    </iwc:IboWebTextBox>
                                                                    <iwc:IboWebTextBox ID="txtProvincia" ClientIDMode="Static" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" ToolTip="Provincia">
                                                                    </iwc:IboWebTextBox>
                                                                    <iwc:IboWebTextBox ID="txtNazione" ClientIDMode="Static" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione" Required="true">
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
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpRiferimenti_Title" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel runat="server" ID="cpRiferimenti_Title_Caption" Text="Tipologia PCS" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpRiferimenti_Body" CssClass="CollapsiblePanelBody">
                                                        <iwc:IboWebHidden ID="PuntoDiSimulazione" runat="server" Value="" FieldName="PuntoDiSimulazione"></iwc:IboWebHidden>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblPuntoDiDestino" runat="server" IncasTag="" Text="Pt. Di Destino:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 40px">
                                                                    <iwc:IboWebCheckBox ID="chkPuntoDiDestino" runat="server" IncasTag="" Checked="true" Width="40px"></iwc:IboWebCheckBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblPuntoDiCarico" runat="server" IncasTag="" Text="Pt. Di Carico:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 40px">
                                                                    <iwc:IboWebCheckBox ID="chkPuntoDiCarico" runat="server" IncasTag="" Checked="true" Width="40px"></iwc:IboWebCheckBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblPuntoDiParcoVeicolare" runat="server" IncasTag="" Text="Pt. Di Parco Veicolare:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 40px">
                                                                    <iwc:IboWebCheckBox ID="chkPuntoDiParcoVeicolare" runat="server" IncasTag="" Width="40px"></iwc:IboWebCheckBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblPuntoDiDeposito" runat="server" IncasTag="" Text="Pt. Di Deposito:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 40px">
                                                                    <iwc:IboWebCheckBox ID="chkPuntoDiDeposito" runat="server" IncasTag="" Width="40px" AutoPostBack="true"></iwc:IboWebCheckBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                    <iwc:IboWebLabel ID="lblIsFiliale" runat="server" IncasTag="" Text="Filiale:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 40px">
                                                                    <iwc:IboWebCheckBox ID="chkIsFiliale" runat="server" IncasTag="" Width="40px" AutoPostBack="true"></iwc:IboWebCheckBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblDestinatario" runat="server" IncasTag="" Text="Destinatario:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 40px">
                                                                    <iwc:IboWebCheckBox ID="chkDestinatario" runat="server" Checked="true" IncasTag="" Width="40px"></iwc:IboWebCheckBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblCodiceTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbCodiceTrasportatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="370px"
                                                                        AutoLoadOnDemand="true" FieldDescription="Trasportatore" DropDownWidth="500px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblCodiceCaricatore" runat="server" Text="Caricatore:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbCodiceCaricatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Caricatori" Width="370px"
                                                                        AutoLoadOnDemand="true" FieldDescription="Caricatore" DropDownWidth="500px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblCodiceDestinatario" runat="server" Text="Destinatario:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbCodiceDestinatario" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="370px" DropDownWidth="500px"
                                                                        AutoLoadOnDemand="true">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpInfoExtra_Title" CssClass="CollapsiblePanelTitle">
                                                        <asp:Label runat="server" ID="cpInfoExtra_Title_Caption" Text="Dati aggiuntivi" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpInfoExtra_Body" CssClass="CollapsiblePanelBody">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblPuntoRitiro1" runat="server" Text="Punto Ritiro1:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbPuntoRitiro1" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIPARTENZA" Width="370px" DropDownWidth="500px"
                                                                        AutoLoadOnDemand="true">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblPuntoRitiro2" runat="server" Text="Punto Ritiro2:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbPuntoRitiro2" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIPARTENZA" Width="370px" DropDownWidth="500px"
                                                                        AutoLoadOnDemand="true">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblPuntoRitiro3" runat="server" Text="Punto Ritiro3:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbPuntoRitiro3" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIPARTENZA" Width="370px" DropDownWidth="500px"
                                                                        AutoLoadOnDemand="true">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblGruppoTariffa" runat="server" Text="Gruppo Tariffario:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbGruppoTariffa" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI" Width="370px" DropDownWidth="500px"
                                                                        AutoLoadOnDemand="true">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblCEDI" runat="server" Text="CEDI:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 370px">
                                                                    <iwc:IboWebComboTlk ID="cmbCEDI" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIDIDESTINO" Width="370px" DropDownWidth="500px"
                                                                        AutoLoadOnDemand="true">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpAltriDati" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpAltriDatiCaption" Text="Note"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpAltriDati" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 420px;">
                                                    <asp:Panel ID="cpAltriDati_Title" runat="server" Visible="True" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpEquipaggiamento_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Note PCS"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpAltriDati_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 805px;">
                                                                    <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" MaxLength="1000" Rows="4" TextMode="MultiLine" FieldName="Note" Width="800px"></iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblNotePerUfficio" runat="server" Text="Note Ufficio:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 805px;">
                                                                    <iwc:IboWebTextBox ID="txtNotePerUfficio" runat="server" CharacterCase="Uppercase" MaxLength="1000" Rows="4" TextMode="MultiLine" FieldName="NotePerUfficio" Width="800px"></iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblNotePerAutista" runat="server" Text="Note Autista:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 805px;">
                                                                    <iwc:IboWebTextBox ID="cmbNotePerAutista" runat="server" CharacterCase="Uppercase" MaxLength="1000" Rows="4" TextMode="MultiLine" FieldName="NotePerAutista" Width="800px"></iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpFiller_Title" runat="server" Visible="True" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpFiller_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Campi Aggiuntivi"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpFiller_Body" runat="server" CssClass="CollapsiblePanelBody">
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
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpContatti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpContattiCaption" Text="Contatti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpContatti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpContatti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpContatti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Contatti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpContatti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSContatti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSContatti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSContatti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpDocumenti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpDocumenti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Documenti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpDocumenti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSDocumenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSDocumenti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSDocumenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpZone" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpZoneCaption" Text="Zone"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpZone" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpZone_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpZone_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Zone"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpZone_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSZone" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSZone" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSZone" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpOrariVisita" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpOrariVisitaCaption" Text="Orari Visita"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpOrariVisita" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpOrariVisita_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpOrariVisita_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Orari di Visita"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpOrariVisita_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSOrariVisita" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSOrariVisita" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSOrariVisita" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpClassiGrandezza" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpClassiGrandezzaCaption" Text="Access."></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpClassiGrandezza" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpClassiGrandezza_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpClassiGrandezza_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Tipi Merce - Classi Grandezza"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpClassiGrandezza_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSClassiGrandezza" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSClassiGrandezza" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSClassiGrandezza" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpEquipaggiamenti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpEquipaggiamentiCaption" Text="Equipagg."></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpEquipaggiamenti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpEquipaggiamenti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpEquipaggiamenti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Equipaggiamenti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpEquipaggiamenti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSEquipaggiamenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSEquipaggiamenti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSEquipaggiamenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpGeocodifica" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGeocodificaCaption" Text="Geocodifica"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpGeocodifica" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpGeocodifica_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpGeocodifica_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Geocodifica"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpGeocodifica_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSGeocodifica" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSGeocodifica" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSGeocodifica" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpInfoAgg" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpInfoAggCaption" Text="Info"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpInfoAgg" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpInfoAgg_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpInfoAgg_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Informazioni aggiuntive"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpInfoAgg_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSInfoAggiuntive" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSInfoAggiuntive" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSInfoAggiuntive" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                            <asp:Panel ID="cpClassi_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpClassi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Classi"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpClassi_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:IboWebCheckBoxList runat="server" ID="PCSClassi" SqlQuery="SELECT * FROM CHK_ANA_PCS_Classi" SqlQueryFilter="PCS='<#MASTER_RECORD.CODICE#>'"
                                                                FieldName1="PCS" FieldName2="Classe" TableName="PCS_Classi">
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
                                <ajaxToolkit:TabPanel ID="tpAcquisiti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpAcquisitiCaption" Text="Cod.Clienti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpAcquisiti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 450px;">
                                                    <asp:Panel ID="cpAcquisiti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpAcquisiti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Acquisiti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpAcquisiti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdPCSAcquisiti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlPCSAcquisiti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdPCSAcquisiti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                        <asp:Button ID="Button1_idle" runat="server" Text="" Style="display: none" />
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
