<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFTARTariffeAttiveTestata2.aspx.vb" Inherits="Incasbo.Web.GDO.WFTARTariffeAttiveTestata2" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../Css/WFTARTariffeAttiveTestata.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <asp:MultiView ID="MultiViewContainer" runat="server" ActiveViewIndex="0">
            <asp:View runat="server" ID="TariffeAttiveTestata">
                <table class="DetailFormMainTable">
                    <tr>
                        <td>
                            <table class="DetailFormHeaderTable">
                                <tr class="DetailFormHeaderTable_r1">
                                    <td class="DetailFormHeaderTable_c1">
                                        <div class="DetailFormTitleDiv">
                                            <iwc:IboWebLabel ID="lblTitle_TariffeAttiveTestata" runat="server" Text="Tariffe Attive"></iwc:IboWebLabel>
                                        </div>
                                    </td>
                                    <td class="DetailFormHeaderTable_c2">
                                        <div class="DetailFormModeDiv">
                                            <iwc:IboWebLabel ID="lblDataAccessMode_TariffeAttiveTestata" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                        </div>
                                    </td>
                                    <td class="DetailFormHeaderTable_c3">
                                        <div class="DetailFormModeImageDiv">
                                            <asp:Image ID="imgModalita_TariffeAttiveTestata" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="DetailFormSectionDiv">
                                <asp:Panel runat="server" ID="pnlMain_TariffeAttiveTestata" Width="1200px">
                                    <div class="DetailFormContainerDivCollapsiblePanel">
                                        <asp:Panel runat="server" ID="cpTestata_Title_TariffeAttiveTestata" CssClass="CollapsiblePanelTitle">
                                            <asp:Label runat="server" ID="cpTestata_Title_Caption_TariffeAttiveTestata" Text="Testata Tariffaria"
                                                CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                        </asp:Panel>
                                        <asp:UpdatePanel runat="server" ID="UPcpTestata_Body_TariffeAttiveTestata" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Panel runat="server" ID="cpTestata_Body_TariffeAttiveTestata" CssClass="CollapsiblePanelBody">
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblContrattoTestata" runat="server" Text="Contratto:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="font-weight: bold; line-height: 22px;">
                                                                <iwc:IboWebLabel ID="Contratto" runat="server" Text="" FieldName="Contratto"></iwc:IboWebLabel>
                                                                - 
                                                                <iwc:IboWebLabel ID="ContrattoDescrizione" runat="server" Text=""></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="ContrattoTrasporto" runat="server" Text="" Visible="false"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="ContrattoGiacenza" runat="server" Text="" Visible="false"></iwc:IboWebLabel>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="TipoDocumento" runat="server" Text="Tipo Documento:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbTipoDocumento" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TARIFFETIPIDOCUMENTO"
                                                                Required="true" Width="450px" SqlQueryFilter="ATTIVO='S' AND TARIFFAATTIVA='S'" SqlQueryOrderBy="DESCRIZIONE">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo spedizione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE"
                                                                AutoLoadOnDemand="true">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell">
                                                                <iwc:IboWebComboTlk ID="cmbTipoMezzo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMEZZO" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblGruppoTariffarioPartenza" runat="server" Text="Gruppo Tar. Par.:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbGruppoTariffarioPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI"
                                                                    Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="PCS Partenza:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbPCSPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="true"
                                                                    SqlQueryWhere="PUNTODICARICO = 'S'" DropDownWidth="600px">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblMacroZonaArrivo" runat="server" Text="Macro Zona Arrivo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbMacroZonaArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneMacro" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbZonaArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblGruppoTariffarioArrivo" runat="server" Text="Gruppo Tar. Arr.:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbGruppoTariffarioArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbPCSArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Required="true" Width="450px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="true"
                                                                    SqlQueryWhere="PUNTODIDESTINO = 'S'" DropDownWidth="600px">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblRapportoPv" runat="server" Text="Rapporto PV:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 100px">
                                                                <iwc:IboWebNumericTlk runat="server" ID="txtRapportoPV" text="" DecimalDigits="0" Width="80px">
                                                                </iwc:IboWebNumericTlk>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <iwc:IboWebTextBox runat="server" ID="txtIdTariffa" Width="100px" IncasTag="IdentityCounterName=COUNTERS.TRA.TARIFFEATTIVE.TESTATA"
                                                        CssClass="hidden"></iwc:IboWebTextBox>
                                                    <iwc:IboWebTextBox runat="server" ID="txtCliente" CssClass="hidden "></iwc:IboWebTextBox>
                                                </asp:Panel>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:Panel ID="cpVoci_Title_TariffeAttiveTestata" runat="server" CssClass="CollapsiblePanelTitle">
                                            <iwc:IboWebLabel ID="cpVoci_Title_Caption_TariffeAttiveTestata" runat="server" CssClass="CollapsiblePanelTitleCaption"
                                                Text="Voci"></iwc:IboWebLabel>
                                        </asp:Panel>
                                        <asp:Panel ID="cpVoci_Body_TariffeAttiveTestata" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                            <table class="tableGridContainer">
                                                <tr>
                                                    <td>
                                                        <iwc:iboWebToolbar ID="tlbgrdTestataVoci" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                        <asp:Panel ID="pnlTestataVoci" runat="server" CssClass="DetailFormGridContainerDiv">
                                                            <iwc:IboGridView ID="grdTestataVoci" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                HorizontalAlign="Left" PageSize="20" EnableSelectionAutoPostBack="True" Width="100%" AllowEditing="True">
                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                <PagerStyle Font-Size="Small" />
                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                <EmptyDataTemplate>
                                                                    Nessun Dato Trovato
                                                                </EmptyDataTemplate>
                                                            </iwc:IboGridView>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:Panel ID="cpFasce_Title_TariffeAttiveTestata" runat="server" CssClass="CollapsiblePanelTitle">
                                            <iwc:IboWebLabel ID="cpFasce_Title_Caption_TariffeAttiveTestata" runat="server" CssClass="CollapsiblePanelTitleCaption"
                                                Text="Fasce"></iwc:IboWebLabel>
                                        </asp:Panel>
                                        <asp:Panel ID="cpFasce_Body_TariffeAttiveTestata" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                            <table class="tableGridContainer">
                                                <tr>
                                                    <td>
                                                        <iwc:iboWebToolbar ID="tlbgrdTestataFasce" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                        <asp:Panel ID="pnlTestataFasce" runat="server" CssClass="DetailFormGridContainerDiv">
                                                            <iwc:IboGridView ID="grdTestataFasce" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                HorizontalAlign="Left" PageSize="20" Width="100%" AllowEditing="True">
                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                <PagerStyle Font-Size="Small" />
                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                <EmptyDataTemplate>
                                                                    Nessun Dato Trovato
                                                                </EmptyDataTemplate>
                                                            </iwc:IboGridView>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </div>
                                </asp:Panel>
                                <%--<iwc:IboWebTextBox ID="IdTariffaVoce" runat="server" Text="" Translate="false" Style="display: none;" CharacterCase="None"></iwc:IboWebTextBox>--%>
                            </div>
                            <div class="DetailFormCommandsDivCollapsiblePanel">
                                <table id="tableButtons_TariffeAttiveTestata" class="tableButtons">
                                    <tr>
                                        <td id="tableButtons_L_TariffeAttiveTestata" class="tableButtons_L">
                                            <iwc:IboWebButton ID="btnAnnulla_TariffeAttiveTestata" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel"
                                                CausesValidation="False" />
                                        </td>
                                        <td id="tableButtons_C_TariffeAttiveTestata" class="tableButtons_C"></td>
                                        <td id="tableButtons_R_TariffeAttiveTestata" class="tableButtons_R">
                                            <iwc:IboWebButton ID="btnConferma_TariffeAttiveTestata" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View runat="server" ID="TariffeAttiveVoci">
                <table class="DetailFormMainTable">
                    <tr>
                        <td>
                            <table class="DetailFormHeaderTable">
                                <tr class="DetailFormHeaderTable_r1">
                                    <td class="DetailFormHeaderTable_c1">
                                        <div class="DetailFormTitleDiv">
                                            <iwc:IboWebLabel ID="lblTitle_TariffeAttiveVoci" runat="server" Text="Voce Tariffaria"></iwc:IboWebLabel>
                                        </div>
                                    </td>
                                    <td class="DetailFormHeaderTable_c2">
                                        <div class="DetailFormModeDiv">
                                            <iwc:IboWebLabel ID="lblDataAccessMode_TariffeAttiveVoci" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                        </div>
                                    </td>
                                    <td class="DetailFormHeaderTable_c3">
                                        <div class="DetailFormModeImageDiv">
                                            <asp:Image ID="imgModalita_TariffeAttiveVoci" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="DetailFormSectionDiv">
                                <asp:Panel runat="server" ID="pnlMain_TariffeAttiveVoci" Width="1150px">
                                    <div class="DetailFormContainerDivCollapsiblePanel">
                                        <asp:Panel runat="server" ID="cpTestata_Title_TariffeAttiveVoci" CssClass="CollapsiblePanelTitle">
                                            <asp:Label runat="server" ID="cpTestata_Title_Caption_TariffeAttiveVoci" Text="Testata Tariffaria" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="cpTestata_Body_TariffeAttiveVoci" CssClass="CollapsiblePanelBody VociCollapsiblePanelBodyTestata">
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblContrattoTariffeAttiveTestata" runat="server" Text="Contratto:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblContrattoTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTipoSpedizioneTariffeAttiveTestata" runat="server" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblTipoSpedizioneTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTipoMerceTariffeAttiveTestata" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblTipoMerceTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTipoMezzoTariffeAttiveTestata" runat="server" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblTipoMezzoTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioPartenzaTariffeAttiveTestata" runat="server" Text="Gruppo Tar.Par.:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioPartenzaTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblPCSPartenzaTariffeAttiveTestata" runat="server" Text="PCS Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblPCSPartenzaTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblMacroZonaArrivoTariffeAttiveTestata" runat="server" Text="Macro Zona Arrivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblMacroZonaArrivoTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblZonaArrivoTariffeAttiveTestata" runat="server" Text="Zona arrivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblZonaArrivoTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioArrivoTariffeAttiveTestata" runat="server" Text="Gruppo Tar.Arr.:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioArrivoTariffeAttiveTestataValue" runat="server" Text=""
                                                            Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblPCSArrivoTariffeAttiveTestata" runat="server" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblPCSArrivoTariffeAttiveTestataValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="cpVoci_Title_TariffeAttiveVoci" CssClass="CollapsiblePanelTitle">
                                            <asp:Label runat="server" ID="cpVoci_Title_Caption_TariffeAttiveVoci" Text="Voce" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="cpVoci_Body_TariffeAttiveVoci" CssClass="CollapsiblePanelBody VociCollapsiblePanelBodyVoci">
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblVoce" runat="server" Text="Voce:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 275px">
                                                        <iwc:IboWebComboTlk ID="cmbVoce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_VOCI" Required="true" Width="270px" DropDownWidth="350px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblCampoCalcolo" runat="server" Text="Campo di calcolo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 200px;">
                                                        <iwc:IboWebComboTlk ID="cmbCampoCalcolo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CAMPICALCOLO"
                                                            Required="true" Width="200px" SqlQueryWhere="1=2" AutoLoadOnDemand="false">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 70px">
                                                        <iwc:IboWebLabel ID="lblArrCampoCalcolo" runat="server" Text="Arrotond.:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 80px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtArrCampoCalcolo" Width="70px" MaxValue="999999999" Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 70px">
                                                        <iwc:IboWebLabel ID="lblArrCampoCalcoloLimite" runat="server" Text="Arr.Limite:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 75px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtArrCampoCalcoloLimite" Width="70px" MaxValue="999999999"
                                                            Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 70px">
                                                        <iwc:IboWebLabel ID="lblFranchigia" runat="server" Text="Franchigia:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 40px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtFranchigia" Width="30px" MaxValue="999999999" Text="" DecimalDigits="0" ToolTip="La franchigia è espressa in giorni e se è valorizzata allora la voce di tariffa è considerata a giornata (valida solo per le tariffe di giacenza).">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblApplicabilita" runat="server" Text="Applicabilità:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 275px">
                                                        <iwc:IboWebComboTlk ID="cmbApplicabilita" runat="server" SqlQuery="SELECT * FROM CBO_ANA_VOCIAPPLICABILITA" FieldName="Applicabilita" Width="270px" DropDownWidth="400px"
                                                            SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblFlgEccedenza" runat="server" Text="Modalità di Calcolo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 200px;">
                                                        <iwc:IboDropDownList ID="cmbflgEccedenza" runat="server" CharacterCase="Uppercase" Required="True"
                                                            SqlQuery="SELECT * FROM CBO_ANA_FLGECCEDENZA" Width="200px">
                                                        </iwc:IboDropDownList>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 70px">
                                                        <iwc:IboWebLabel ID="lblArrCampoCalcoloOltre" runat="server" Text="Arr.Oltre:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 80px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtArrCampoCalcoloOltre" Width="70px" MaxValue="999999999"
                                                            Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                        <iwc:IboWebLabel ID="lblArrImporto" runat="server" Text="Arr.Importo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 75px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtArrImporto" Width="70px" MaxValue="999999999" Required="true"
                                                            DecimalDigits="5">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <iwc:IboWebTextBox runat="server" ID="txtIdVoce" IncasTag="IdentityCounterName=COUNTERS.TRA.TARIFFEATTIVE.VOCI"
                                                CssClass="hidden"></iwc:IboWebTextBox>
                                            <iwc:IboWebTextBox runat="server" ID="IdVoceInserimento" CssClass="hidden"></iwc:IboWebTextBox>
                                            <iwc:IboWebTextBox runat="server" ID="txtIdTariffaTestata" Enabled="false" FieldName="IdTariffa" CssClass="hidden"></iwc:IboWebTextBox>
                                        </asp:Panel>
                                        <asp:Panel ID="cpFasce_Title_TariffeAttiveVoci" runat="server" CssClass="CollapsiblePanelTitle">
                                            <iwc:IboWebLabel ID="cpFasce_Title_Caption_TariffeAttiveVoci" runat="server" CssClass="CollapsiblePanelTitleCaption"
                                                Text="Fasce"></iwc:IboWebLabel>
                                        </asp:Panel>
                                        <asp:Panel ID="cpFasce_Body_TariffeAttiveVoci" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid VociCollapsiblePanelBodyFasce" >
                                            <asp:UpdatePanel runat="server" ID="up_cpFasce_Body_TariffeAttiveVoci" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <table class="tableGridContainer" style="width: auto;">
                                                        <tr style="height: 15px;">
                                                            <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left; font-weight: bold;">
                                                                <iwc:IboWebLabel ID="lblFasciaInferiore" runat="server" Text="Da (quantità):"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left; font-weight: bold;">
                                                                <iwc:IboWebLabel ID="lblFasciaSuperiore" runat="server" Text="A (quantità):"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 20px"></td>
                                                            <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left; font-weight: bold;">
                                                                <iwc:IboWebLabel ID="lblFisso" runat="server" Text="Importo Fisso"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left; font-weight: bold;">
                                                                <iwc:IboWebLabel ID="lblVariabile" runat="server" Text="Importo variabile"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left; font-weight: bold;">
                                                                <iwc:IboWebLabel ID="lblPercentuale" runat="server" Text="Importo percentuale"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 70px;"></td>
                                                            <td class="DetailFormDescriptionCell" style="width: 110px;">
                                                                <iwc:IboWebLabel ID="lblNuovoLimite" runat="server" Text="Nuovo Limite (A)" Visible="false" Style="font-weight: bold;"></iwc:IboWebLabel>
                                                            </td>
                                                            <td style="width: auto;"></td>
                                                            <td style="width: auto;"></td>
                                                        </tr>
                                                        <asp:Repeater ID="RepeaterFasce" runat="server">
                                                            <ItemTemplate>
                                                                <tr>
                                                                    <td class="DetailFormValueCell" style="width: 110px">
                                                                        <iwc:IboWebNumericTlk runat="server" ID="FasciaInferiore" Width="100px" MaxValue="999999999" Required="true" DecimalDigits="3"
                                                                            ReadOnly="true">
                                                                        </iwc:IboWebNumericTlk>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 110px">
                                                                        <iwc:IboWebNumericTlk runat="server" ID="FasciaSuperiore" Width="100px" MaxValue="999999999" Required="true" DecimalDigits="3"
                                                                            ReadOnly="true" FieldDescription="Fascia Superiore">
                                                                        </iwc:IboWebNumericTlk>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 20px">
                                                                        <iwc:IboWebLabel ID="lblErrore" runat="server" Text="*" Visible="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 110px">
                                                                        <iwc:IboWebNumericTlk runat="server" ID="Fisso" Width="100px" MaxValue="999999999" Required="true" DecimalDigits="4" FieldDescription="Fisso">
                                                                        </iwc:IboWebNumericTlk>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 110px">
                                                                        <%--<iwc:IboWebNumeric ID="Variabile" runat="server" Mask="999999999.99999" MaskType="FreeMask"
                                                                    MaxValue="999999999" MinValue="0" Width="100px" />--%>
                                                                        <iwc:IboWebNumericTlk runat="server" ID="Variabile" Width="100px" MaxValue="999999999" MaxLength="14" Required="true" DecimalDigits="4"
                                                                            FieldDescription="Variabile">
                                                                        </iwc:IboWebNumericTlk>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 110px">
                                                                        <iwc:IboWebNumericTlk runat="server" ID="Percentuale" Width="80px" MaxValue="999999999" MaxLength="12" Required="true" FieldDescription="Percentuale">
                                                                        </iwc:IboWebNumericTlk>
                                                                    </td>
                                                                    <td class="DetailFormCommandCell" style="width: 70px;">
                                                                        <iwc:IboWebButton ID="FasciaAggiungi" CommandName="FasciaAggiungi" runat="server" Text="+" Style="width: 30px; height: 23px;"
                                                                            ToolTip="Aggiungi fascia" />
                                                                        <iwc:IboWebButton ID="FasciaTogli" CommandName="FasciaTogli" runat="server" Text="-" Style="width: 30px; height: 23px;" ToolTip="Elimina fascia" />
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 100px;">
                                                                        <iwc:IboWebNumericTlk runat="server" ID="NuovoLimite" Width="100px" MaxValue="999999999" MaxLength="12" Visible="false" FieldDescription="Nuovo Limite">
                                                                        </iwc:IboWebNumericTlk>
                                                                    </td>
                                                                    <td class="DetailFormCommandCell" style="width: auto;">
                                                                        <iwc:IboWebButton ID="FasciaConferma" CommandName="FasciaConferma" runat="server" Text="Ok" Style="width: 35px; height: 23px;"
                                                                            Visible="false" />
                                                                    </td>
                                                                    <td style="width: auto;">
                                                                        <iwc:IboWebTextBox runat="server" ID="IdFascia" IncasTag="IdentityCounterName=COUNTERS.TRA.TARIFFEATTIVE.FASCE" Style="display: none; width: 10px;"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="IdVoceFasce" runat="server" Enabled="False" Style="display: none; width: 10px;"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="_ROWID" runat="server" Enabled="False" Style="display: none; width: 10px;"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                    </table>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </asp:Panel>
                                    </div>
                                </asp:Panel>
                            </div>
                            <div class="DetailFormCommandsDivCollapsiblePanel">
                                <table id="tableButtons_TariffeAttiveVoci" class="tableButtons">
                                    <tr>
                                        <td id="tableButtons_L_TariffeAttiveVoci" class="tableButtons_L">
                                            <iwc:IboWebButton ID="btnAnnulla_TariffeAttiveVoci" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel"
                                                CausesValidation="False" />
                                        </td>
                                        <td id="tableButtons_C_TariffeAttiveVoci" class="tableButtons_C"></td>
                                        <td id="tableButtons_R_TariffeAttiveVoci" class="tableButtons_R">
                                            <iwc:IboWebButton ID="btnConferma_TariffeAttiveVoci" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View runat="server" ID="TariffeAttiveFasce">
            </asp:View>
        </asp:MultiView>
    </asp:Panel>
</asp:Content>
