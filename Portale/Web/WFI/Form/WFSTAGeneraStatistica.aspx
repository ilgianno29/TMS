<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFSTAGeneraStatistica.aspx.vb" Inherits="Incasbo.Web.WFI.WFSTAGeneraStatistica" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <link rel="stylesheet" href="../Css/WFSTAGeneraStatistica.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1250px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="pnlElencoStatistiche" ClientIDMode="Static">
                                    <asp:Panel runat="server" ID="cpElencoStatistiche_Title" CssClass="CollapsiblePanelTitle">
                                        <iwc:IboWebLabel ID="cpElencoStatistiche_Caption" runat="server" Text="Elenco Statistiche" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="cpElencoStatistiche_Body" CssClass="CollapsiblePanelBody ElencoStatistiche">
                                        <asp:UpdatePanel runat="server" ID="up_ElencoStatistiche" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdStatistiche" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                CssClassPanel="ToolbarPanel"
                                                                CssClassTable="ToolbarTable" />
                                                            <asp:Panel ID="pnlGridStatistiche" runat="server" CssClass="DetailFormGridContainerDiv" ClientIDMode="Static">
                                                                <iwc:IboGridView ID="grdStatistiche" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True">
                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                    <PagerStyle Font-Size="Small" />
                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                </iwc:IboGridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:Panel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="pnlElencoFiltri" ClientIDMode="Static">
                                    <asp:Panel runat="server" ID="cpElencoFiltri_Title" CssClass="CollapsiblePanelTitle">
                                        <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="cpElencoFiltri_Body" CssClass="CollapsiblePanelBody ElencoFiltri">
                                        <asp:UpdatePanel runat="server" ID="up_ElencoFiltri" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Table runat="server" ID="Filtri" CssClass="DetailFormSectionTable2Fixed">
                                                    <asp:TableRow ID="row_txtDaData">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtDaData" runat="server" IncasTag="" Text="Da Data:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebDate2 ID="txtDaData" runat="server" Width="80px" ControlType="DateOnly" FieldName="DaData" IncasTag="MAGGIORE_UGUALE" />
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtAData">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtAData" runat="server" IncasTag="" Text="A Data:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebDate2 ID="txtAData" runat="server" Width="80px" ControlType="DateOnly" FieldName="AData" IncasTag="MINORE_UGUALE" />
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtInData">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtInData" runat="server" IncasTag="" Text="A Data:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebDate2 ID="txtInData" runat="server" Width="80px" ControlType="DateOnly" FieldName="InData" IncasTag="UGUALE" />
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbCliente">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbCliente" runat="server" IncasTag="" Text="Cliente:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" FieldName="Cliente" Width="500px" AutoLoadOnDemand="true" SqlQueryWhere="Codice<>'*ALL'"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbPCSPartenza">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbPCSPartenza" runat="server" IncasTag="" Text="Partenza:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbPCSPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza" FieldName="PCSPartenza" Width="500px" AutoLoadOnDemand="true"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbPCSDestinazione">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbPCSDestinazione" runat="server" IncasTag="" Text="Destinazione:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbPCSDestinazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIDIDESTINO" FieldName="PCSDestinazione" Width="500px" AutoLoadOnDemand="true"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbMittente">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbMittente" runat="server" IncasTag="" Text="Mittente:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbMittente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mittenti" FieldName="Mittente" Width="500px" AutoLoadOnDemand="true"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbVettore">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbVettore" runat="server" IncasTag="" Text="Vettore:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbVettore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" FieldName="Vettore" Width="500px" AutoLoadOnDemand="true"
                                                                SqlQueryWhere="Codice<>'*ALL'" IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbCorrispondente">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbCorrispondente" runat="server" IncasTag="" Text="Corrispondente:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbCorrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Corrispondenti" FieldName="Corrispondente" Width="500px" AutoLoadOnDemand="true"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbMacroZona">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbMacroZona" runat="server" IncasTag="" Text="Macro Zona:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbMacroZona" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneMacro" FieldName="MacroZona" Width="500px" AutoLoadOnDemand="true"
                                                                SqlQueryWhere="Codice<>'*ALL'" IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbZonaSpedizione">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbZonaSpedizione" runat="server" IncasTag="" Text="Zona:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneSpedizione" FieldName="ZonaSpedizione" Width="500px" AutoLoadOnDemand="true"
                                                                SqlQueryWhere="Codice<>'*ALL'" IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbZonaArrivoTariffaPassiva">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbZonaArrivoTariffaPassiva" runat="server" IncasTag="" Text="Zona Passiva:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbZonaArrivoTariffaPassiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaPassiva" FieldName="ZonaArrivoTariffaPassiva" Width="500px" AutoLoadOnDemand="true"
                                                                SqlQueryWhere="Codice<>'*ALL'" IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbNazione">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbNazione" runat="server" IncasTag="" Text="Nazione:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbNazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Nazioni" FieldName="Nazione" Width="500px" AutoLoadOnDemand="true"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbRegione">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbRegione" runat="server" IncasTag="" Text="Regione:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbRegione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Regioni" FieldName="Regione" Width="500px" AutoLoadOnDemand="true"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbProvincia">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbProvincia" runat="server" IncasTag="" Text="Provincia:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbProvincia" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Province" FieldName="Provincia" Width="500px" AutoLoadOnDemand="true"
                                                                IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbFree1">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbFree1" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbFree1" runat="server" SqlQuery="" FieldName="" Width="500px" AutoLoadOnDemand="true" IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbFree2">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbFree2" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbFree2" runat="server" SqlQuery="" FieldName="" Width="500px" AutoLoadOnDemand="true" IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_cmbFree3">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblcmbFree3" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbFree3" runat="server" SqlQuery="" FieldName="" Width="500px" AutoLoadOnDemand="true" IncasTag="UGUALE">
                                                            </iwc:IboWebComboTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtTesto1">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtTesto1" runat="server" IncasTag="" Text="Testo1:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebTextBox runat="server" ID="txtTesto1" Width="200px" IncasTag="LIKE"></iwc:IboWebTextBox>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtTesto2">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtTesto2" runat="server" IncasTag="" Text="Testo2:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebTextBox runat="server" ID="txtTesto2" Width="200px" IncasTag="LIKE"></iwc:IboWebTextBox>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtTesto3">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtTesto3" runat="server" IncasTag="" Text="Testo3:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebTextBox runat="server" ID="txtTesto3" Width="200px" IncasTag="LIKE"></iwc:IboWebTextBox>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtNumero1">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtNumero1" runat="server" IncasTag="" Text="Numero1:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtNumero1" Width="70px" DecimalDigits="2"></iwc:IboWebNumericTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtNumero2">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtNumero2" runat="server" IncasTag="" Text="Numero2:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtNumero2" Width="70px" DecimalDigits="2"></iwc:IboWebNumericTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                    <asp:TableRow ID="row_txtNumero3">
                                                        <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                            <iwc:IboWebLabel ID="lbltxtNumero3" runat="server" IncasTag="" Text="Numero3:"></iwc:IboWebLabel>
                                                        </asp:TableCell>
                                                        <asp:TableCell CssClass="DetailFormValueCell">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtNumero3" Width="70px" DecimalDigits="2"></iwc:IboWebNumericTlk>
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                </asp:Table>
                                                <iwc:IboWebHidden runat="server" ID="HiddenField1" Value="" />
                                                <iwc:IboWebHidden runat="server" ID="HiddenField2" Value="" />
                                                <iwc:IboWebHidden runat="server" ID="HiddenField3" Value="" />
                                                <iwc:IboWebHidden runat="server" ID="HiddenField4" Value="" />
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:Panel>
                                </asp:Panel>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C"></td>
                                <td id="tableButtons_R" class="tableButtons_R">
                                    <asp:UpdatePanel runat="server" ID="up_btnConferma" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
