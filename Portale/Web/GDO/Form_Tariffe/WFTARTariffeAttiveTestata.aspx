<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFTARTariffeAttiveTestata.aspx.vb" Inherits="Incasbo.Web.GDO.WFTARTariffeAttiveTestata" %>

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
                                            <iwc:IboWebLabel ID="lblTitle_TariffeAttiveTestata" runat="server" Text="Tariffe Attive" IncasTag=""></iwc:IboWebLabel>
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
                                <asp:Panel runat="server" ID="pnlMain_TariffeAttiveTestata" Width="1150px">
                                    <div class="DetailFormContainerDivCollapsiblePanel">
                                        <asp:Panel runat="server" ID="cpTestata_Title_TariffeAttiveTestata" CssClass="CollapsiblePanelTitle">
                                            <asp:Label runat="server" ID="cpTestata_Title_Caption_TariffeAttiveTestata" Text="Testata Tariffaria"
                                                CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                        </asp:Panel>
                                        <asp:UpdatePanel runat="server" ID="UPcpTestata_Body_TariffeAttiveTestata" ChildrenAsTriggers="true"
                                            UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Panel runat="server" ID="cpTestata_Body_TariffeAttiveTestata" CssClass="CollapsiblePanelBody">
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblContrattoTestata" runat="server" IncasTag="" Text="Contratto:"
                                                                    ValidationRules="None"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell">
                                                                <iwc:IboWebComboTlk ID="cmbContratto" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_TAR_CONTRATTI"
                                                                    Required="true" Width="450px" SqlQueryWhere="ContrattoTrasporto='S' AND AttivaPassiva = 'A'"
                                                                    CampoDescrizione="DESCRIZIONE" AutoLoadOnDemand="true" >
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" IncasTag="" Text="Tipo spedizione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE"
                                                                Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                AutoLoadOnDemand="true">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" IncasTag="" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell"  style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" IncasTag="" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell">
                                                                <iwc:IboWebComboTlk ID="cmbTipoMezzo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPIMEZZO"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>                                                  
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblGruppoTariffarioPartenza" runat="server" IncasTag="" Text="Gruppo Tar. Par.:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbGruppoTariffarioPartenza" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                             <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" IncasTag="" Text="PCS Partenza:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbPCSPartenza" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true" SqlQueryWhere="PUNTODICARICO = 'S'" DropDownWidth="600px">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>                                                  
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblMacroZonaArrivo" runat="server" IncasTag="" Text="Macro Zona Arrivo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbMacroZonaArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_ZoneMacro"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" IncasTag="" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbZonaArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>                                                   
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblGruppoTariffarioArrivo" runat="server" IncasTag="" Text="Gruppo Tar. Arr.:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbGruppoTariffarioArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true">
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" IncasTag="" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                <iwc:IboWebComboTlk ID="cmbPCSArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                                    Required="true" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                                    AutoLoadOnDemand="true" SqlQueryWhere="PUNTODIDESTINO = 'S'" DropDownWidth="600px" >
                                                                </iwc:IboWebComboTlk>
                                                            </td>
                                                        </tr>
                                                    </table>                                                   
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblRapportoPv" runat="server" IncasTag="" Text="Rapporto PV:"
                                                                    ValidationRules="None"></iwc:IboWebLabel>
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
                                                Text="Voci" IncasTag="" ValidationRules="None"></iwc:IboWebLabel>
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
                                                Text="Fasce" IncasTag=""></iwc:IboWebLabel>
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
                                            <iwc:IboWebLabel ID="lblTitle_TariffeAttiveVoci" runat="server" Text="Voce Tariffaria" IncasTag=""></iwc:IboWebLabel>
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
                                            <asp:Label runat="server" ID="cpTestata_Title_Caption_TariffeAttiveVoci" Text="Testata Tariffaria"
                                                CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="cpTestata_Body_TariffeAttiveVoci" CssClass="CollapsiblePanelBody">
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblContrattoTariffeAttiveTestata" runat="server" IncasTag="" Text="Contratto:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblContrattoTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTipoSpedizioneTariffeAttiveTestata" runat="server" IncasTag="" Text="Tipo Spedizione:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblTipoSpedizioneTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTipoMerceTariffeAttiveTestata" runat="server" IncasTag="" Text="Tipo Merce:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblTipoMerceTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTipoMezzoTariffeAttiveTestata" runat="server" IncasTag="" Text="Tipo Mezzo:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblTipoMezzoTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioPartenzaTariffeAttiveTestata" runat="server" IncasTag="" Text="Gruppo Tar.Par.:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioPartenzaTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblPCSPartenzaTariffeAttiveTestata" runat="server" IncasTag="" Text="PCS Partenza:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblPCSPartenzaTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblMacroZonaArrivoTariffeAttiveTestata" runat="server" IncasTag="" Text="Macro Zona Arrivo:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblMacroZonaArrivoTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblZonaArrivoTariffeAttiveTestata" runat="server" IncasTag="" Text="Zona arrivo:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblZonaArrivoTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioArrivoTariffeAttiveTestata" runat="server" IncasTag="" Text="Gruppo Tar.Arr.:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblGruppoTariffarioArrivoTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblPCSArrivoTariffeAttiveTestata" runat="server" IncasTag="" Text="PCS Arrivo:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                        <iwc:IboWebLabel ID="lblPCSArrivoTariffeAttiveTestataValue" runat="server" IncasTag="" Text=""
                                                            ValidationRules="None" Translate="false"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="cpVoci_Title_TariffeAttiveVoci" CssClass="CollapsiblePanelTitle">
                                            <asp:Label runat="server" ID="cpVoci_Title_Caption_TariffeAttiveVoci" Text="Voce" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="cpVoci_Body_TariffeAttiveVoci" CssClass="CollapsiblePanelBody">
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblVoce" runat="server" IncasTag="" Text="Voce:" ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 350px">
                                                        <iwc:IboWebComboTlk ID="cmbVoce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_VOCI" Required="true"
                                                            Width="350px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE" AutoLoadOnDemand="FALSE">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblCampoCalcolo" runat="server" IncasTag="" Text="Campo di calcolo:" ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 200px;">
                                                        <iwc:IboWebComboTlk ID="cmbCampoCalcolo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_CAMPICALCOLO"
                                                            Required="true" Width="200px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                            AutoLoadOnDemand="false">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                     <td class="DetailFormDescriptionCell" style="width: 80px">
                                                        <iwc:IboWebLabel ID="lblArrCampoCalcolo" runat="server" IncasTag="" Text="Arrotond.:"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 80px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtArrCampoCalcolo" Width="70px" MaxValue="999999999" Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 90px">
                                                        <iwc:IboWebLabel ID="lblArrCampoCalcoloLimite" runat="server" IncasTag="" Text="Arrotond. Limite:" ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 80px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtArrCampoCalcoloLimite" Width="70px" MaxValue="999999999"
                                                            Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblApplicabilita" runat="server" IncasTag="" Text="Applicabilità:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 350px">
                                                        <iwc:IboWebComboTlk ID="cmbApplicabilita" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_VOCIAPPLICABILITA"
                                                            FieldName="Applicabilita" Width="350px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                            AutoLoadOnDemand="false">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                     <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblFlgEccedenza" runat="server" IncasTag="" Text="Modalità di Calcolo:" ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 200px;">
                                                        <%-- <iwc:IboWebComboTlk ID="cmbflgEccedenza" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_FLGECCEDENZA"
                                                           Required="True" Width="250px" SqlQueryFilter="" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>--%>
                                                        <iwc:IboDropDownList ID="cmbflgEccedenza" runat="server" CharacterCase="Uppercase" IncasTag="" Required="True"
                                                            SqlQuery="SELECT * FROM CBO_ANA_FLGECCEDENZA" Width="200px">
                                                        </iwc:IboDropDownList>
                                                    </td>
                                                     <td class="DetailFormDescriptionCell" style="width: 80px">
                                                        <iwc:IboWebLabel ID="lblArrCampoCalcoloOltre" runat="server" IncasTag="" Text="Arrotond. Oltre:" ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 80px;">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtArrCampoCalcoloOltre" Width="70px" MaxValue="999999999"
                                                            Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                        <iwc:IboWebLabel ID="lblArrImporto" runat="server" IncasTag="" Text="Arrotond. Importo:" ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 80px;">
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
                                            <%-- <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_TIPIMERCE"
                                                Required="false" Width="600px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                AutoLoadOnDemand="true" CssClass="hidden">
                                            </iwc:IboWebComboTlk>       --%>
                                        </asp:Panel>
                                        <asp:Panel ID="cpFasce_Title_TariffeAttiveVoci" runat="server" CssClass="CollapsiblePanelTitle">
                                            <iwc:IboWebLabel ID="cpFasce_Title_Caption_TariffeAttiveVoci" runat="server" CssClass="CollapsiblePanelTitleCaption"
                                                Text="Fasce" IncasTag="" ValidationRules="None"></iwc:IboWebLabel>

                                        </asp:Panel>
                                        <asp:Panel ID="cpFasce_Body_TariffeAttiveVoci" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                            <table class="DetailFormSectionTable2Fixed" style="margin-left:10px;">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px; text-align: left;">
                                                        <%-- <iwc:IboWebLabel ID="lblFasciaInferiore" runat="server" FocusedBackColor="" IncasTag="" Text="Da (quantità):"
                                                            ValidationRules="None"></iwc:IboWebLabel>--%>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left;">
                                                        <iwc:IboWebLabel ID="lblFasciaSuperiore" runat="server" IncasTag="" Text="A (quantità):"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 20px"></td>
                                                    <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left;">
                                                        <iwc:IboWebLabel ID="lblFisso" runat="server" IncasTag="" Text="Importo Fisso" ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left;">
                                                        <iwc:IboWebLabel ID="lblVariabile" runat="server" IncasTag="" Text="Importo variabile"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 110px; text-align: left;">
                                                        <iwc:IboWebLabel ID="lblPercentuale" runat="server" IncasTag="" Text="Importo percentuale"
                                                            ValidationRules="None"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 20px;"></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;"></td>
                                                    <td style="width: auto;"></td>
                                                </tr>
                                                <asp:Repeater ID="RepeaterFasce" runat="server">
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td class="DetailFormValueCell" style="width: 100px">
                                                                <iwc:IboWebNumericTlk runat="server" ID="FasciaInferiore" Width="100px" MaxValue="999999999" ReadOnly="true"
                                                                    DecimalDigits="0" CssClass="hidden">
                                                                </iwc:IboWebNumericTlk>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 110px">
                                                                <iwc:IboWebNumericTlk runat="server" ID="FasciaSuperiore" Width="100px" MaxValue="999999999">
                                                                </iwc:IboWebNumericTlk>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 20px">
                                                                <iwc:IboWebLabel ID="lblErrore" runat="server" IncasTag="" Text="*" Visible="false" ValidationRules="None"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 110px">
                                                                <iwc:IboWebNumericTlk runat="server" ID="Fisso" Width="100px" MaxValue="999999999" DecimalDigits="4"
                                                                    FieldDescription="Fisso">
                                                                </iwc:IboWebNumericTlk>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 110px">
                                                                <iwc:IboWebNumericTlk runat="server" ID="Variabile" Width="100px" MaxValue="999999999" DecimalDigits="4"
                                                                    FieldDescription="Variabile">
                                                                </iwc:IboWebNumericTlk>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 110px">
                                                                <iwc:IboWebNumericTlk runat="server" ID="Percentuale" Width="80px" MaxValue="999999999" FieldDescription="Percentuale">
                                                                </iwc:IboWebNumericTlk>
                                                            </td>
                                                            <td style="width: 20px;"></td>
                                                            <td class="DetailFormCommandCell" style="width: 40px;">
                                                                <%--<iwc:IboWebButton ID="FasciaAggiungi" CommandName="FasciaAggiungi" runat="server" Text="+" Style="width: 30px;
                                                                    height: 23px;" ToolTip="Aggiungi fascia" />--%>
                                                                <iwc:IboWebButton ID="FasciaAggiungi" CommandName="FasciaAggiungi" runat="server" CssClass="BottoneAggiungiFascia"
                                                                    ToolTip="Aggiungi fascia" />
                                                            </td>
                                                            <td class="DetailFormCommandCell" style="width: 40px;">
                                                                <%--iwc:IboWebButton ID="FasciaTogli" CommandName="FasciaTogli" runat="server" Text="-" Style="width: 30px;
                                                                    height: 23px;" ToolTip="Elimina fascia" />--%>
                                                                <iwc:IboWebButton ID="FasciaTogli" CommandName="FasciaTogli" runat="server" CssClass="BottoneEliminaFascia"
                                                                    ToolTip="Elimina fascia" />
                                                            </td>
                                                            <td class="DetailFormCommandCell" style="width: 100px;"></td>
                                                            <td style="width: auto;">
                                                                <iwc:IboWebTextBox runat="server" ID="IdFascia" IncasTag="IdentityCounterName=COUNTERS.TARIFFEPASS.FASCE"
                                                                    Style="display: none; width: 10px;"></iwc:IboWebTextBox>
                                                                <iwc:IboWebTextBox ID="IdVoceFasce" runat="server" Enabled="False" IncasTag="" Style="display: none; width: 10px;"></iwc:IboWebTextBox>
                                                                <iwc:IboWebTextBox ID="_ROWID" runat="server" Enabled="False" IncasTag="" Style="display: none; width: 10px;"></iwc:IboWebTextBox>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </table>
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
