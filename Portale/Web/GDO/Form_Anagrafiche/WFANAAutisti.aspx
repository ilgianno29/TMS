<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAAutisti.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAAutisti" %>

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
    <link rel="stylesheet" href="../../GDO/Css/WFANAAutisti.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="true" AutoPostBack="false"
                                TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto" UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel ID="up_tpGen" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel">
                                                    <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                                        <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Anagrafica" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 105px">
                                                                    <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="100px" Required="true">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px;">
                                                                    <iwc:IboWebLabel ID="lblMatricola" runat="server" Text="Matricola:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 105px">
                                                                    <iwc:IboWebTextBox ID="txtMatricola" runat="server" CharacterCase="Uppercase" MaxLength="30" Width="100px" Required="true">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblDataAssunzione" runat="server" Text="Assunto:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 100px">
                                                                    <iwc:IboWebDate2 ID="txtDataAssunzione" runat="server" Width="70px" ControlType="DateOnly" Tooltip="Data assunzione" />
                                                                </td>

                                                                <td class="DetailFormDescriptionCell" style="width: 70px">
                                                                    <iwc:IboWebLabel ID="lblDataFineRapporto" runat="server" Text="Fine rapporto:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 100px">
                                                                    <iwc:IboWebDate2 ID="txtDataFineRapporto" runat="server" Width="70px" ControlType="DateOnly" Tooltip="Data fine rapporto" />
                                                                </td>

                                                                <td class="DetailFormDescriptionCell" style="width: 77px">
                                                                    <iwc:IboWebLabel ID="lblDipendente" runat="server" Text="Dipendente:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 35px">
                                                                    <iwc:IboWebCheckBox ID="chkDipendente" runat="server" AutoPostBack="True" />
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 50px">
                                                                    <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 50px">
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
                                                                    <iwc:IboWebTextBox ID="txtRagioneSociale" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                                    <iwc:IboWebLabel ID="lblTelefono" runat="server" Text="Telefono:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 145px;">
                                                                    <iwc:IboWebTextBox ID="txtTelefono" runat="server" MaxLength="15" Width="140px" ValidationRules="GenericPhoneNumber"></iwc:IboWebTextBox>
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
                                                                    <iwc:IboWebLabel ID="lblCellulare" runat="server" Text="Cellulare:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 145px;">
                                                                    <iwc:IboWebTextBox ID="txtCellulare" runat="server" MaxLength="15" Width="140px" ValidationRules="GenericPhoneNumber"></iwc:IboWebTextBox>
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
                                                                    <iwc:IboWebLabel ID="lblFax" runat="server" Text="Fax:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 145px;">
                                                                    <iwc:IboWebTextBox ID="txtFax" runat="server" CharacterCase="Uppercase" MaxLength="15" FieldName="Fax" Width="140px"></iwc:IboWebTextBox>
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
                                                                    <iwc:IboWebLabel ID="lblLuogoNascita" runat="server" Text="Luogo di nascita:">
                                                                    </iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 617px;">
                                                                    <iwc:IboWebTextBox ID="txtLuogoNascita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                                    <iwc:IboWebLabel ID="lblDataNascita" runat="server" Text="Data di nascita:">
                                                                    </iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 145px;">
                                                                    <iwc:IboWebDate2 ID="txtDataNascita" runat="server" Width="70px" ControlType="DateOnly" Tooltip="Data di nascita" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 625px;">
                                                                    <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" Required="False" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="620px" SqlQueryOrderBy="RAGIONESOCIALE"
                                                                        CampoDescrizione="RAGIONESOCIALE" AutoLoadOnDemand="true" MaxHeight="250px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>

                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblMezzoCategoria" runat="server" Text="Categoria mezzo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 625px;">
                                                                    <iwc:IboWebComboTlk ID="cmbMezzoCategoria" runat="server" Required="False" SqlQuery="SELECT * FROM CBO_ANA_MezziCategorie" Width="620px" SqlQueryOrderBy="DESCRIZIONE"
                                                                        CampoDescrizione="DESCRIZIONE" AutoLoadOnDemand="true" MaxHeight="250px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>

                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblPianificatore" runat="server" Text="Pianificatore:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 625px;">
                                                                    <iwc:IboWebComboTlk ID="cmbPianificatore" runat="server" Required="False" SqlQuery="SELECT * FROM CBO_FGL_PIANIFICATORI" Width="620px"
                                                                        AutoLoadOnDemand="false" MaxHeight="250px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>

                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblTipoContratto" runat="server" Text="Tipo contratto:">
                                                                    </iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 617px;">
                                                                    <iwc:IboWebTextBox ID="txtTipoContratto" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblLivello" runat="server" Text="Livello:">
                                                                    </iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 617px;">
                                                                    <iwc:IboWebTextBox ID="txtLivello" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
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
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpImmagini" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpImmaginiCaption" Text="Foto"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel ID="up_tpImmagini" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 220px;">
                                                    <asp:Panel ID="cpFoto_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpFoto_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Foto"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpFoto_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormValueCell" colspan="3">
                                                                    <iwc:IboWebImage runat="server" ID="imgImmagine1" FieldName="Immagine1" FieldNameExtension="Immagine1Tipo" />
                                                                </td>
                                                                <td class="DetailFormValueCell" colspan="3">
                                                                    <iwc:IboWebImage runat="server" ID="imgImmagine2" FieldName="Immagine2" FieldNameExtension="Immagine2Tipo" />
                                                                </td>
                                                                <td class="DetailFormValueCell" colspan="3">
                                                                    <iwc:IboWebImage runat="server" ID="imgImmagine3" FieldName="Immagine3" FieldNameExtension="Immagine3Tipo" />
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
                                        <asp:UpdatePanel ID="up_tpContatti" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 220px;">
                                                    <asp:Panel ID="cpContatti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpContatti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Contatti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpContatti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdAutistiContatti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlAutistiContatti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdAutistiContatti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                        <asp:UpdatePanel ID="up_tpDocumenti" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 220px;">
                                                    <asp:Panel ID="cpDocumenti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpDocumenti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Documenti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpDocumenti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdAutistiDocumenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlAutistiDocumenti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdAutistiDocumenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                        <asp:UpdatePanel ID="up_tpInfoAgg" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 220px;">
                                                    <asp:Panel ID="cpInfoAgg_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpInfoAgg_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Informazioni aggiuntive"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpInfoAgg_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdAutistiInfoAggiuntive" runat="server" ButtonHeight="24" ButtonWidth="24"
                                                                        SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel"
                                                                        CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlAutistiInfoAggiuntive" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdAutistiInfoAggiuntive" runat="server" AllowPaging="True" AllowSorting="True"
                                                                            AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top"
                                                                            CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" PageSize="20" Width="100%">
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
                                        <asp:UpdatePanel ID="up_tpClassi" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 220px;">
                                                    <asp:Panel ID="cpClassi_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpClassi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Classi"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpClassi_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:IboWebCheckBoxList runat="server" ID="AutistiClassi" SqlQuery="SELECT * FROM CHK_ANA_AUTISTI_CLASSI"
                                                                        SqlQueryFilter="AUTISTA='<#MASTER_RECORD.CODICE#>'" FieldName1="AUTISTA" FieldName2="CLASSE" TableName="AutistiClassi">
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
