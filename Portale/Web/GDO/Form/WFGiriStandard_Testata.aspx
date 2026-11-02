<%@ Page Title="Gestione Giri Standard" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFGiriStandard_Testata.aspx.vb" Inherits="Incasbo.Web.GDO.WFGiriStandard" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/Css/checkedDropDownList-min.css?d=20161114" />    
    <link rel="stylesheet" href="../../WFI/css/DetailForm.css?d=20161114" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFGiriStandard_Testata.css?d=20161114" />
    <script src="../../WFI/scripts/ui.dropdownchecklist-min.js?d=20161114"></script>    
    <script src="../Scripts/WFGiriStandard_Testata.js?d=20161114"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server">
        <table class="DetailFormMainTable">
            <tr style="display: none">
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
                                <%--<div class="DetailFormModeImageDiv">
                                    <asp:Image ID="imgModalita" runat="server" />
                                </div>--%>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1200px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle" Style="position: relative;">                                    
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <div class="DetailFormModeImageDiv">
                                        <asp:Image ID="imgModalita" runat="server" />
                                    </div>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblIdGiro" runat="server" Text="Codice Giro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" MaxLength="20" CharacterCase="Uppercase" Width="100px" Required="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 555px;">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="550px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 50px;">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblRiferimentoEsterno" runat="server" Text="Riferimento esterno:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <iwc:IboWebTextBox ID="txtRiferimentoEsterno" runat="server" MaxLength="20" CharacterCase="Uppercase" Width="100px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblSettimane" runat="server" Text="Settimane:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <asp:ListBox runat="server" ID="lbSettimane" SelectionMode="Multiple" Width="100px" ClientIDMode="Static" CssClass="WFICheckedDropDownList">
                                                    <asp:ListItem Value="ALL" Text="(All)"></asp:ListItem>
                                                    <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                                    <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                                    <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                                    <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                                    <asp:ListItem Value="5" Text="5"></asp:ListItem>
                                                    <asp:ListItem Value="6" Text="6"></asp:ListItem>
                                                    <asp:ListItem Value="7" Text="7"></asp:ListItem>
                                                    <asp:ListItem Value="8" Text="8"></asp:ListItem>
                                                    <asp:ListItem Value="9" Text="9"></asp:ListItem>
                                                    <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                                    <asp:ListItem Value="11" Text="11"></asp:ListItem>
                                                    <asp:ListItem Value="12" Text="12"></asp:ListItem>
                                                    <asp:ListItem Value="13" Text="13"></asp:ListItem>
                                                    <asp:ListItem Value="14" Text="14"></asp:ListItem>
                                                    <asp:ListItem Value="15" Text="15"></asp:ListItem>
                                                    <asp:ListItem Value="16" Text="16"></asp:ListItem>
                                                    <asp:ListItem Value="17" Text="17"></asp:ListItem>
                                                    <asp:ListItem Value="18" Text="18"></asp:ListItem>
                                                    <asp:ListItem Value="19" Text="19"></asp:ListItem>
                                                    <asp:ListItem Value="20" Text="20"></asp:ListItem>
                                                    <asp:ListItem Value="21" Text="21"></asp:ListItem>
                                                    <asp:ListItem Value="22" Text="22"></asp:ListItem>
                                                    <asp:ListItem Value="23" Text="23"></asp:ListItem>
                                                    <asp:ListItem Value="24" Text="24"></asp:ListItem>
                                                    <asp:ListItem Value="25" Text="25"></asp:ListItem>
                                                    <asp:ListItem Value="26" Text="26"></asp:ListItem>
                                                    <asp:ListItem Value="27" Text="27"></asp:ListItem>
                                                    <asp:ListItem Value="28" Text="28"></asp:ListItem>
                                                    <asp:ListItem Value="29" Text="29"></asp:ListItem>
                                                    <asp:ListItem Value="30" Text="30"></asp:ListItem>
                                                    <asp:ListItem Value="31" Text="31"></asp:ListItem>
                                                    <asp:ListItem Value="32" Text="32"></asp:ListItem>
                                                    <asp:ListItem Value="33" Text="33"></asp:ListItem>
                                                    <asp:ListItem Value="34" Text="34"></asp:ListItem>
                                                    <asp:ListItem Value="35" Text="35"></asp:ListItem>
                                                    <asp:ListItem Value="36" Text="36"></asp:ListItem>
                                                    <asp:ListItem Value="37" Text="37"></asp:ListItem>
                                                    <asp:ListItem Value="38" Text="38"></asp:ListItem>
                                                    <asp:ListItem Value="39" Text="39"></asp:ListItem>
                                                    <asp:ListItem Value="40" Text="40"></asp:ListItem>
                                                    <asp:ListItem Value="41" Text="41"></asp:ListItem>
                                                    <asp:ListItem Value="42" Text="42"></asp:ListItem>
                                                    <asp:ListItem Value="43" Text="43"></asp:ListItem>
                                                    <asp:ListItem Value="44" Text="44"></asp:ListItem>
                                                    <asp:ListItem Value="45" Text="45"></asp:ListItem>
                                                    <asp:ListItem Value="46" Text="46"></asp:ListItem>
                                                    <asp:ListItem Value="47" Text="47"></asp:ListItem>
                                                    <asp:ListItem Value="48" Text="48"></asp:ListItem>
                                                    <asp:ListItem Value="49" Text="49"></asp:ListItem>
                                                    <asp:ListItem Value="50" Text="50"></asp:ListItem>
                                                    <asp:ListItem Value="51" Text="51"></asp:ListItem>
                                                    <asp:ListItem Value="52" Text="52"></asp:ListItem>
                                                    <asp:ListItem Value="53" Text="53"></asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:Panel ID="pnlIniziale" runat="server" CssClass="pnlIniziale">
                                        <asp:Panel runat="server" ID="pnlPartenza" CssClass="pnlPartenza">

                                            <iwc:IboWebLabel ID="lblPartenzaCaption" runat="server" Text="Partenza" CssClass="lblPartenzaCaption"></iwc:IboWebLabel>

                                            <table class="DetailFormSectionTable2Fixed PartenzaTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                        <iwc:IboWebLabel ID="lblGiorno" runat="server" Text="Giorno:">  </iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbGiornoPartenza" runat="server" SqlQuery="SELECT * FROM CBO_GIORNO_SETTIMANA" Width="90px"
                                                            ToolTip="Descrizione giorno settimana Partenza" Required="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                        <iwc:IboWebLabel ID="lblOraPartenza" runat="server" Text="Ora:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebDate2 ID="txtOraPartenza" runat="server" Width="90px" ControlType="TimeOnly" Tooltip="OraPartenza" FormatoOra="HH:mm"
                                                            TimeControlWidth="67px" FieldName="OraPartenza" Required="true" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="pnlCutOff" CssClass="pnlCutOff">

                                            <iwc:IboWebLabel ID="lblCutOffCaption" runat="server" Text="CutOff" CssClass="lblCutOffCaption"></iwc:IboWebLabel>

                                            <table class="DetailFormSectionTable2Fixed CutOffTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                        <iwc:IboWebLabel ID="lblGiornoCutoff" runat="server" Text="Giorno:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbGiornoCutoff" runat="server" SqlQuery="SELECT * FROM CBO_GIORNO_SETTIMANA" Width="90px"
                                                            Required="true" ToolTip="Descrizione giorno settimana CutOff">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                        <iwc:IboWebLabel ID="lblOraCutOff" runat="server" Text="Ora:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebDate2 ID="txtOraCutOff" runat="server" Width="90px" ControlType="TimeOnly" Tooltip="Ora CutOff" FormatoOra="HH:mm"
                                                            TimeControlWidth="67px" FieldName="OraCutOff" Required="true" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="PanelZone" CssClass="pnlZone">

                                            <iwc:IboWebLabel ID="lblZoneCaption" runat="server" Text="Zone" CssClass="lblZoneCaption"></iwc:IboWebLabel>

                                            <table class="DetailFormSectionTable2Fixed ZoneTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 105px;">
                                                        <iwc:IboWebLabel ID="lblZonaSpedizione" runat="server" Text="Zona Spedizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONESPEDIZIONE" Style="width: 250px;" DropDownWidth="300px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" >
                                                        <iwc:IboWebLabel ID="lblZonaTariffaAttiva" runat="server" Text="Zona Tariffa Attiva:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbZonaTariffaAttiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONETARIFFAATTIVA" Style="width: 250px;" DropDownWidth="300px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" >
                                                        <iwc:IboWebLabel ID="lblZonaTariffaPassiva" runat="server" Text="Zona Tariffa Passiva:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbZonaTariffaPassiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONETARIFFAPASSIVA" Style="width: 250px;" DropDownWidth="300px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="PanelDepositi" CssClass="pnlDepositi">

                                            <iwc:IboWebLabel ID="lblDepositi" runat="server" Text="Depositi" CssClass="lblDepositiCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed DepositiTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                        <iwc:IboWebLabel ID="lblDepositoPartenza" runat="server" Text="Dep. Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbDepositoPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIPARTENZA" Style="width: 350px;" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblDepositoArrivo" runat="server" Text="Dep. Arrivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbDepositoArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIARRIVO" Style="width: 350px;" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlIniziale1" runat="server" CssClass="pnlIniziale1">
                                        <asp:Panel runat="server" ID="PanelTipo" CssClass="pnlTipo">
                                            <iwc:IboWebLabel ID="lblTipoCaption" runat="server" Text="Tipi" CssClass="lblTipiCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed TipiTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                        <iwc:IboWebLabel ID="lblTipoViaggio" runat="server" Text="Tipo Viaggio:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoViaggio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_VIAGGI_TIPIVIAGGIO" Style="width: 260px;" DropDownWidth="300px">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                        <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoMezzo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMEZZO" Style="width: 260px;" DropDownWidth="300px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" >
                                                        <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Style="width: 260px;" DropDownWidth="300px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" >
                                                        <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE" Style="width: 260px;" DropDownWidth="300px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="Panel1" CssClass="pnlInfoAggiuntive">
                                            <iwc:IboWebLabel ID="IboWebLabel1" runat="server" Text="Info Aggiuntive" CssClass="lblInfoCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed InfoTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                        <iwc:IboWebLabel ID="lblMezzo" runat="server" Text="Mezzo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbMezzo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_MEZZI" Style="width: 350px;" DropDownWidth="400px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" >
                                                        <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TRASPORTATORI" Style="width: 350px;" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" >
                                                        <iwc:IboWebLabel ID="lblAutista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbAutista" runat="server" SqlQuery="SELECT * FROM CBO_ANA_AUTISTI" Style="width: 350px;" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
                                    <asp:Panel ID="Panel3" runat="server" CssClass="pnlIniziale2">
                                        <asp:Panel runat="server" ID="pnlNota" CssClass="pnlNotaCaption">
                                            <iwc:IboWebLabel ID="lblNota" runat="server" Text="Altro" CssClass="lblNotaCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed NoteTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 95px;">
                                                        <iwc:IboWebLabel ID="IboWebLabel4" runat="server" Text="Nota:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 930px;">
                                                        <iwc:IboWebTextBox ID="txtNota" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="950px"></iwc:IboWebTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpDettagli_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpDettagli_Title_Caption" Text="Dettagli" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpDettagli_Body" CssClass="CollapsiblePanelBody">
                                    <asp:UpdatePanel ID="UPTreeViewContent" runat="server" UpdateMode="Conditional" ClientIDMode="Static">
                                        <ContentTemplate>
                                            <asp:Panel ID="cpGiriStandard_Dettagli_Grid" runat="server" CssClass="CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgiristandard_dettagli" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                                CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <iwc:IboWebPanel ID="pnlgiristandard_dettagli" runat="server" CssClass="DetailFormGridContainerDiv pnlgiristandard_dettagli" MaintainScrollPositionOnPostBack="True"
                                                                ScrollBars="Auto">
                                                                <iwc:IboGridView ID="grdgiristandard_dettagli" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" Width="100%" EnableSelectionAutoPostBack="false">
                                                                    <%--<PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                    <PagerStyle Font-Size="Small" />--%>
                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                </iwc:IboGridView>
                                                            </iwc:IboWebPanel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
<asp:Content ID="MasterPopupFormContent" ContentPlaceHolderID="phMasterPopupForm" runat="server">
   <asp:Panel ID="pnlCorrispondente" runat="server" Visible="false" Style="width: 600px; height: 60px;">
        <div style="margin: 7px;margin-bottom:22px;text-align:left;">
            <iwc:IboWebLabel ID="lblCorrispIstruzioni" runat="server" Text="Scegliere il corrispondente che si vuole associare alle spedizioni selezionate. Lasciare vuota la combo nel caso in cui si desideri fare la spedizione in diretta."></iwc:IboWebLabel>
        </div>
        <table style="width: 100%" class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 450px">
                    <iwc:IboWebComboTlk ID="Corrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CORRISPONDENTI" Width="440px" AutoLoadOnDemand="false">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>