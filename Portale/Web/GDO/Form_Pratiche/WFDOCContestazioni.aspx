<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCContestazioni.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCContestazioni" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../GDO/css/WFDOCContestazioni.css" type="text/css" />
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c3">
                                <div class="DetailFormModeImageDiv">
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1150px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="false" AutoPostBack="false"
                                TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto" UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Testata"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="pnlTestataBody" CssClass="" ClientIDMode="Static">
                                                <asp:Panel runat="server" ID="cpTestata_Title" CssClass="CollapsiblePanelTitle" Style="position: relative;">
                                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                                    <div class="DetailFormModeImageDiv">
                                                        <asp:Image ID="imgModalita" runat="server" />
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="cpTestata_Body" CssClass="CollapsiblePanelBody">
                                                    <asp:Panel runat="server" ID="pnlTestataBodyLeft" ClientIDMode="Static">
                                                        <asp:Panel runat="server" ID="pnlEstremiSpedizioneTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblEstremiSpedizioneTitle" runat="server" Text="Estremi della contestazione"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_EstremiSpedizione" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlEstremiSpedizioneBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebLabel ID="lblId" runat="server" Text="Id:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 70px">
                                                                                <iwc:IboWebTextBox runat="server" ID="txtId" IncasTag="IdentityCounterName=COUNTERS.CONTESTAZIONI.ID" Width="80px"></iwc:IboWebTextBox>
                                                                            </td>

                                                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                                <iwc:IboWebLabel ID="lblStato" runat="server" Text="Stato:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded">
                                                                                <iwc:IboWebRadioButtonList ID="optStato" runat="server" RepeatDirection="Horizontal" Required="True" Width="170px" AutoPostBack="True">
                                                                                    <asp:ListItem Selected="True" Text="In corso" Value="10"></asp:ListItem>
                                                                                    <asp:ListItem Text="Chiusa" Value="20"></asp:ListItem>
                                                                                    <asp:ListItem Text="Annullata" Value="99"></asp:ListItem>
                                                                                </iwc:IboWebRadioButtonList>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 116px">
                                                                                <iwc:IboWebLabel ID="lblDataApertura" runat="server" Text="Data apertura:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px;">
                                                                                <iwc:IboWebLabel ID="DataApertura" runat="server" FieldName="DataApertura" FieldDataType="Date" FormatString="{0:dd/MM/yyyy HH:mm}"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                                                <iwc:IboWebLabel ID="lblDataChiusura" runat="server" Text="Data chiusura:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px;">
                                                                                <iwc:IboWebLabel ID="DataChiusura" runat="server" FieldName="DataChiusura" FieldDataType="Date" FormatString="{0:dd/MM/yyyy HH:mm}"></iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                            <iwc:IboWebLabel ID="lblTipoContestazione" runat="server" Text="Tipo contestazione:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCellNoDataBounded">
                                                                            <iwc:IboWebComboTlk ID="cmbTipoContestazione" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_CONTESTAZIONITIPI" Width="420px" AutoLoadOnDemand="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                    </table>
                                                                    <hr class="WFIHRSeparatore" />
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebLabel ID="lblUnibol" runat="server" Text="Id spedizione:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                                                <iwc:IboWebTextBox ID="txtUnibol" runat="server" Width="80px"></iwc:IboWebTextBox>
                                                                            </td>
                                                                            <td>
                                                                                <iwc:IboWebButton ID="btnCheckSpedizione" runat="server" CssClass="checkSpedizione" Text="Verifica"></iwc:IboWebButton>
                                                                                <iwc:IboWebButton ID="btnVediSpedizione" runat="server" CssClass="vediSpedizione" Text="Vedi"></iwc:IboWebButton>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebLabel ID="lblRiferimento1" runat="server" Text="Riferimento1:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                                                <iwc:IboWebTextBox ID="txtRiferimento1" runat="server" Width="80px" MaxLength="15"></iwc:IboWebTextBox>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                                                <iwc:IboWebLabel ID="lblDataRiferimento1" runat="server" Text="Data Riferimento1:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                                                <iwc:IboWebDate2 ID="txtDataRiferimento1" runat="server" />
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                                                <iwc:IboWebLabel ID="lblNoteRiferimento1" runat="server" Text="Note Riferimento1:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td>
                                                                                <iwc:IboWebTextBox ID="txtNoteRiferimento1" runat="server" Width="400px" MaxLength="255"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebLabel ID="lblRiferimento2" runat="server" Text="Riferimento2:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                                                <iwc:IboWebTextBox ID="txtRiferimento2" runat="server" Width="80px" MaxLength="15"></iwc:IboWebTextBox>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                                                <iwc:IboWebLabel ID="lblDataRiferimento2" runat="server" Text="Data Riferimento2:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                                                <iwc:IboWebDate2 ID="txtDataRiferimento2" runat="server" />
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                                                <iwc:IboWebLabel ID="lblNoteRiferimento2" runat="server" Text="Note Riferimento2:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td>
                                                                                <iwc:IboWebTextBox ID="txtNoteRiferimento2" runat="server" Width="400px" MaxLength="255"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlSoggettoBody" CssClass="" ClientIDMode="Static">
                                                        <asp:Panel runat="server" ID="pnlSoggettoBodyInternal" ClientIDMode="Static">
                                                            <asp:Panel runat="server" ID="pnlDatiSoggettoTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                                <iwc:IboWebLabel ID="lblDatiSoggetto" runat="server" Text="Dati della controparte"></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                            <asp:UpdatePanel ID="up_DatiSoggetto" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                                <ContentTemplate>
                                                                    <asp:Panel runat="server" ID="pnlDatiMittenteBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                        <table class="DetailFormSectionTable2Fixed">
                                                                            <tr>
                                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                    <iwc:IboWebLabel ID="lblTipoSoggetto" runat="server" Text="Tipo Soggetto:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 105px">
                                                                                    <iwc:IboDropDownList runat="server" ID="cmbTipoSoggetto" Width="300px" Required="true" AutoPostBack="true">
                                                                                        <asp:ListItem Text="CLIENTE" Value="C"></asp:ListItem>
                                                                                        <asp:ListItem Text="CARICATORE" Value="M"></asp:ListItem>
                                                                                        <asp:ListItem Text="CORRISPONDENTE" Value="H"></asp:ListItem>
                                                                                        <asp:ListItem Text="DESTINATARIO" Value="D"></asp:ListItem>
                                                                                        <asp:ListItem Text="VETTORE" Value="V"></asp:ListItem>
                                                                                        <asp:ListItem Text="NON IN ANAGRAFICA" Value="*"></asp:ListItem>
                                                                                        <asp:ListItem Text="NON DEFINITO" Value="X"></asp:ListItem>
                                                                                        <asp:ListItem Text="" Value=""></asp:ListItem>
                                                                                    </iwc:IboDropDownList>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <table class="DetailFormSectionTable2Fixed">
                                                                            <tr>
                                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                    <iwc:IboWebLabel ID="lblSoggetto_Codice" runat="server" Text="Soggetto:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded">
                                                                                    <iwc:IboWebHidden runat="server" ID="hdnSoggetto_Codice" FieldName="Soggetto_Codice" />
                                                                                    <iwc:IboWebComboTlk ID="Soggetto_Codice" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CONTESTAZIONI_SOGGETTI WHERE 1=2"
                                                                                        Width="457px" AutoLoadOnDemand="True" DropDownWidth="820px" AutoPostBack="true">
                                                                                        <HeaderTemplate>
                                                                                            <ul>
                                                                                                <li class="ComboCol" style="width: 80px; display: none;">
                                                                                                    <iwc:IboWebLabel runat="server" ID="Col1" Text="Codice"></iwc:IboWebLabel></li>
                                                                                                <li class="ComboCol" style="width: 250px;">
                                                                                                    <iwc:IboWebLabel runat="server" ID="Col2" Text="Ragione Sociale"></iwc:IboWebLabel></li>
                                                                                                <li class="ComboCol" style="width: 200px;">
                                                                                                    <iwc:IboWebLabel runat="server" ID="col3" Text="Indirizzo"></iwc:IboWebLabel></li>
                                                                                                <li class="ComboCol" style="width: 200px;">
                                                                                                    <iwc:IboWebLabel runat="server" ID="col4" Text="Localita"></iwc:IboWebLabel></li>
                                                                                                <li class="ComboCol" style="width: 50px;">
                                                                                                    <iwc:IboWebLabel runat="server" ID="col5" Text="Prov."></iwc:IboWebLabel></li>
                                                                                                <li class="ComboCol" style="width: 50px;">
                                                                                                    <iwc:IboWebLabel runat="server" ID="col6" Text="Naz."></iwc:IboWebLabel></li>
                                                                                            </ul>
                                                                                        </HeaderTemplate>
                                                                                        <ItemTemplate>
                                                                                            <ul>
                                                                                                <li class="ComboCol" style="width: 80px; display: none;">
                                                                                                    <%# DataBinder.Eval(Container.DataItem, "Codice")%></li>
                                                                                                <li class="ComboCol" style="width: 250px;">
                                                                                                    <%# DataBinder.Eval(Container.DataItem, "RagioneSociale")%></li>
                                                                                                <li class="ComboCol" style="width: 200px;">
                                                                                                    <%# DataBinder.Eval(Container.DataItem, "Indirizzo")%></li>
                                                                                                <li class="ComboCol" style="width: 200px;">
                                                                                                    <%# DataBinder.Eval(Container.DataItem, "Localita")%></li>
                                                                                                <li class="ComboCol" style="width: 50px;">
                                                                                                    <%# DataBinder.Eval(Container.DataItem, "Provincia")%></li>
                                                                                                <li class="ComboCol" style="width: 50px;">
                                                                                                    <%# DataBinder.Eval(Container.DataItem, "Nazione")%></li>
                                                                                            </ul>
                                                                                        </ItemTemplate>
                                                                                    </iwc:IboWebComboTlk>
                                                                                </td>
                                                                                <td>
                                                                                    <iwc:IboWebComboTlk ID="IboWebComboTlk1" runat="server" ClientVisibility="false" Width="1px">
                                                                                    </iwc:IboWebComboTlk>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <table class="DetailFormSectionTable2Fixed">
                                                                            <tr>
                                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                    <iwc:IboWebLabel ID="lblSoggetto_RagioneSociale" runat="server" Text="Ragione sociale:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded">
                                                                                    <iwc:IboWebTextBox ID="txtSoggetto_RagioneSociale" runat="server" Width="450px" MaxLength="60"></iwc:IboWebTextBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <table class="DetailFormSectionTable2Fixed">
                                                                            <tr>
                                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                    <iwc:IboWebLabel ID="lblSoggetto_Indirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded">
                                                                                    <iwc:IboWebTextBox ID="txtSoggetto_Indirizzo" runat="server" Width="450px" MaxLength="60"></iwc:IboWebTextBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <table class="DetailFormSectionTable2Fixed">
                                                                            <tr>
                                                                                <td class="DetailFormDescriptionCell" style="width: 100px;"></td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 70px;">
                                                                                    <iwc:IboWebTextBox ID="txtSoggetto_Cap" runat="server" Width="60px"></iwc:IboWebTextBox>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 307px;">
                                                                                    <iwc:IboWebTextBox ID="txtSoggetto_Localita" runat="server" Width="301px" MaxLength="60"></iwc:IboWebTextBox>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 35px;">
                                                                                    <iwc:IboWebTextBox ID="txtSoggetto_Provincia" runat="server" Width="25px" MaxLength="3"></iwc:IboWebTextBox>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 35px;">
                                                                                    <iwc:IboWebTextBox ID="txtSoggetto_Nazione" runat="server" Width="25px" MaxLength="3"></iwc:IboWebTextBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </asp:Panel>
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </asp:Panel>
                                                        <asp:Panel runat="server" ID="pnlNoteBodyInternal" ClientIDMode="Static">
                                                            <asp:Panel runat="server" ID="pnlDatiNoteTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                                <iwc:IboWebLabel ID="lblDatiNote" runat="server" Text="Note di pratica"></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                            <asp:Panel runat="server" ID="pnlDatiNoteBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                            <iwc:IboWebLabel ID="lblNote1" runat="server" Text="Note 1:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell">
                                                                            <iwc:IboWebTextBox runat="server" ID="txtnote1" Width="370px" Rows="4" TextMode="MultiLine" MaxLength="1000"></iwc:IboWebTextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                            <iwc:IboWebLabel ID="lblNote2" runat="server" Text="Note 2:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell">
                                                                            <iwc:IboWebTextBox runat="server" ID="txtNote2" Width="370px" Rows="4" TextMode="MultiLine" MaxLength="1000"></iwc:IboWebTextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                            <iwc:IboWebLabel ID="lblNote3" runat="server" Text="Note 3:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell">
                                                                            <iwc:IboWebTextBox runat="server" ID="txtNote3" Width="370px" Rows="4" TextMode="MultiLine" MaxLength="1000"></iwc:IboWebTextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </asp:Panel>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpNote" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpRicaviCaption" Text="Iter"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpEventi_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpEventi_Title_Caption" Text="Iter della pratica" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpEventi_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpEventi_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <asp:Panel ID="tlbgrdEventiDiv" CssClass="tlbgrdEventiDiv" runat="server">
                                                                        <iwc:iboWebToolbar ID="tlbgrdEventi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    </asp:Panel>
                                                                    <iwc:IboWebPanel ID="pnlEventi" runat="server" CssClass="DetailFormGridContainerDiv pnlEventi" MaintainScrollPositionOnPostBack="True">
                                                                        <iwc:IboGridView ID="grdEventi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </iwc:IboWebPanel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpDocumenti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDocumentiCaption" Text="Documenti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpDocumenti_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpDocumenti_Title_Caption" Text="Documenti" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel ID="up_Documenti" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <table class="tableGridContainer">
                                                        <tr>
                                                            <td>
                                                                <asp:Panel ID="tlbgrdDocumentiDiv" CssClass="tlbgrdDocumentiDiv" runat="server">
                                                                    <iwc:iboWebToolbar ID="tlbgrdDocumenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                </asp:Panel>
                                                                <iwc:IboWebPanel ID="pnlDocumenti" runat="server" CssClass="DetailFormGridContainerDiv pnlDocumenti" MaintainScrollPositionOnPostBack="true">
                                                                    <iwc:IboGridView ID="grdDocumenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                        BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                        HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </iwc:IboWebPanel>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpNotePratica" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpNotePraticaCaption" Text="Note"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpNotePratica_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpNotePratica_Title_Caption" Text="Note" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel ID="up_NotePratica" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <table class="tableGridContainer">
                                                        <tr>
                                                            <td>
                                                                <asp:Panel ID="tlbgrdNotePraticaDiv" CssClass="tlbgrdDocumentiDiv" runat="server">
                                                                    <iwc:iboWebToolbar ID="tlbgrdNotePratica" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                </asp:Panel>
                                                                <iwc:IboWebPanel ID="pnlNotePratica" runat="server" CssClass="DetailFormGridContainerDiv pnlDocumenti" MaintainScrollPositionOnPostBack="true">
                                                                    <iwc:IboGridView ID="grdNotePratica" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                        BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                        HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </iwc:IboWebPanel>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
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
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
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
