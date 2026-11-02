<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFPIAPianificazioneLinea.aspx.vb" Inherits="Incasbo.Web.GDO.WFPIAPianificazioneLinea" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFPIAPianificazioneLinea.css?d=20150130" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="pnlMainContainer" CssClass="pnlMainContainer" runat="server">
        <asp:Panel runat="server" ID="pnlMainBody" CssClass="pnlMainBody">
            <table class="DetailFormMainTable">
                <tr>
                    <td>
                        <div class="DetailFormSectionDiv">
                            <asp:Panel runat="server" ID="pnlMain">
                                <asp:Panel runat="server" ID="Bottoni">
                                    <asp:UpdatePanel runat="server" ID="upButton" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="DetailFormSectionTable2">
                                                <tr>
                                                    <td style="text-align: left; width: auto;">
                                                        <div id="ToolbarContainer">
                                                            <div id="ToolbarSessione" class="PlanToolbar">
                                                                <iwc:IboWebButton runat="server" ID="btnAnnulla" ToolTip="Esci" CssClass="PlanToolbarButton DetailFormButton_Cancel" />
                                                            </div>
                                                            <div id="ToolbarOrdini" class="PlanToolbar">
                                                                <iwc:IboWebButton runat="server" ID="btnAggiorna" ToolTip="Aggiorna" CssClass="PlanToolbarButton Aggiorna" />
                                                                <iwc:IboWebButton runat="server" ID="btnCambiaDataSpedizione" ToolTip="Cambia Data di partenza della linea" CssClass="PlanToolbarButton CambiaDataSpedizione" />
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td></td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="lblDataSpedizione" runat="server" Text="Data partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 95px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="Linea_DataPartenzaPianificata" runat="server" Width="90px" CssClass="WFIGrassetto"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 67px; vertical-align: middle; position: relative;">
                                                        <iwc:IboWebButton runat="server" ID="btnGotoPreviousDate" ToolTip="Va alla data precedente" CssClass="PlanToolbarButton GotoPreviousDate" />
                                                        <iwc:IboWebButton runat="server" ID="btnGotoNextDate" ToolTip="Va alla data successiva" CssClass="PlanToolbarButton GotoNextDate" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body">
                                    <asp:Panel runat="server" ID="pnlSplitter" ClientIDMode="Static">
                                        <telerik:RadSplitter ID="MainBodySplitter1" runat="server" CssClass="PianificazioneSplitter" ClientIDMode="Static" Width="100%" Height="100%" BorderSize="0" Orientation="Horizontal"
                                            ResizeMode="AdjacentPane">
                                            <telerik:RadPane ID="MainBodySplitterBottom" runat="server" Width="100%" Height="33%" Scrolling="None">
                                                <telerik:RadSplitter ID="MainBodySplitter3" runat="server" CssClass="PianificazioneSplitter" Width="100%" BorderSize="0" Orientation="Vertical">
                                                    <telerik:RadPane ID="MainBodySplitterBottom1" runat="server" Width="40%" Scrolling="None" CssClass="PannelloEsternoGrigliaZone">
                                                        <asp:UpdatePanel runat="server" ID="upElencoZone" UpdateMode="Conditional" RenderMode="Inline">
                                                            <ContentTemplate>
                                                                <div id="DivGrdElencoZone">
                                                                    <iwc:IboWebPanel ID="cpGrdElencoZone" runat="server" MaintainScrollPositionOnPostBack="True" CssClass="cpGrdElencoZone">
                                                                        <table class="tableGridContainerPia">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Panel ID="pnlElencoZone" runat="server" CssClass="DetailFormGridContainerDivPia">
                                                                                        <iwc:IboGridView ID="grdElencoZone" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                            BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                            <PagerStyle Font-Size="Small" />
                                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                        </iwc:IboGridView>
                                                                                    </asp:Panel>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </iwc:IboWebPanel>
                                                                    <asp:Panel ID="footerGrdElencoZone" runat="server" CssClass="footerGrdElencoZone">
                                                                        <iwc:IboWebLabel ID="footerZone_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerZone_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerZone_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Pallet:" CssClass="footerZone_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerZone_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Volume_Caption" runat="server" ClientIDMode="Static" Text="Volume:" CssClass="footerZone_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerZone_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerZone_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerZone_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Spedizioni:" CssClass="footerZone_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerZone_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerZone_Value"></iwc:IboWebLabel>
                                                                    </asp:Panel>
                                                                </div>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </telerik:RadPane>
                                                    <telerik:RadSplitBar ID="RadSplitBar3" runat="server" CollapseMode="None">
                                                    </telerik:RadSplitBar>
                                                    <telerik:RadPane ID="MainBodySplitterBottom2" runat="server" Width="60%" Height="100%" Scrolling="None" CssClass="PannelloEsternoGrigliaLinee">
                                                        <asp:UpdatePanel runat="server" ID="upElencoLinee" UpdateMode="Conditional" RenderMode="Inline">
                                                            <ContentTemplate>
                                                                <div id="DivGrdElencoLinee">
                                                                    <asp:Panel ID="cpGrdElencoLinee" runat="server" CssClass="cpGrdElencoLinee">
                                                                        <table class="tableGridContainerPia">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Panel ID="pnlElencoLinee" runat="server" CssClass="DetailFormGridContainerDivPia">
                                                                                        <iwc:IboGridView ID="grdElencoLinee" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                            BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                            <PagerStyle Font-Size="Small" />
                                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                        </iwc:IboGridView>
                                                                                    </asp:Panel>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </asp:Panel>
                                                                    <asp:Panel ID="footerElencoLinee" runat="server" CssClass="footerElencoLinee">
                                                                        <iwc:IboWebLabel ID="footerLinee_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerLinee_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerLinee_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Pallet:" CssClass="footerLinee_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerLinee_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Volume_Caption" runat="server" ClientIDMode="Static" Text="Volume:" CssClass="footerLinee_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerLinee_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerLinee_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerLinee_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Spedizioni:" CssClass="footerLinee_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerLinee_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerLinee_Value"></iwc:IboWebLabel>
                                                                    </asp:Panel>
                                                                </div>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </telerik:RadPane>
                                                </telerik:RadSplitter>
                                            </telerik:RadPane>
                                            <telerik:RadSplitBar ID="MainBodySplitterBar1" runat="server" CollapseMode="None">
                                            </telerik:RadSplitBar>
                                            <telerik:RadPane ID="MainBodySplitterTop" runat="server" Scrolling="None" ClientIDMode="Static" Height="66%" CssClass="PannelloEsternoGrigliaSpedizioni">
                                                <asp:UpdatePanel runat="server" ID="upElencoSpedizioni" UpdateMode="Conditional" ChildrenAsTriggers="true" style="height: 100%;" Visible="true">
                                                    <ContentTemplate>
                                                        <asp:Panel ID="DivGrdElencoSpedizioni" runat="server" ClientIDMode="Static" Visible="true">
                                                            <div id="HeaderElencoSpedizioni" class="HeaderElencoSpedizioni">
                                                                <iwc:iboWebToolbar ID="tlbElencoSpedizioni" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                    CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                <div class="DivFiltroSpedizioni">
                                                                    <asp:Panel runat="server" ID="gridFilterPanel" CssClass="PanelFiltroSpedizioni"
                                                                        ClientIDMode="Static" DefaultButton="btnFilterOk">
                                                                        <div style="position: absolute; top: 4px; left: 2px; width: 95px; font-size: 8pt; font-size: 8pt">
                                                                            <iwc:IboWebLabel runat="server" ID="lblFilterActiveField" Text="" Style="position: absolute; top: 0px; left: 0px; width: 95px; text-align: right;"></iwc:IboWebLabel>
                                                                        </div>
                                                                        <div style="position: absolute; top: 2px; left: 105px; width: 100px; font-size: 8pt">
                                                                            <iwc:IboDropDownList runat="server" ID="ddlFilterOperator" Style="width: 100px; height: 19px; font-size: 8pt">
                                                                                <asp:ListItem Text="Contiene" Value="LIKE" Selected="True"></asp:ListItem>
                                                                                <asp:ListItem Text="Uguale" Value="="></asp:ListItem>
                                                                                <asp:ListItem Text="Diverso" Value="!="></asp:ListItem>
                                                                                <asp:ListItem Text="Maggiore o Uguale" Value="gt="></asp:ListItem>
                                                                                <asp:ListItem Text="Maggiore" Value="gt"></asp:ListItem>
                                                                                <asp:ListItem Text="Minore o uguale" Value="lt="></asp:ListItem>
                                                                                <asp:ListItem Text="Minore" Value="lt"></asp:ListItem>
                                                                                <asp:ListItem Text="E' vuoto" Value="ISNULL"></asp:ListItem>
                                                                                <asp:ListItem Text="Non è vuoto" Value="ISNOTNULL"></asp:ListItem>
                                                                                <asp:ListItem Text="Inizia per" Value="BEGIN"></asp:ListItem>
                                                                                <asp:ListItem Text="Non inizia per" Value="NOTBEGIN"></asp:ListItem>
                                                                                <asp:ListItem Text="Finisce per" Value="END"></asp:ListItem>
                                                                                <asp:ListItem Text="Non finisce per" Value="NOTEND"></asp:ListItem>
                                                                            </iwc:IboDropDownList>
                                                                        </div>
                                                                        <div style="position: absolute; top: 2px; left: 210px; width: 115px; font-size: 8pt">
                                                                            <iwc:IboWebTextBox runat="server" ID="FilterText" Style="width: 115px; height: 13px; font-size: 8pt" ClientIDMode="Static"></iwc:IboWebTextBox>
                                                                            <iwc:IboWebDate2 runat="server" ID="FilterDate" ControlType="DateOnly" Visible="false" ClientIDMode="Static" CssClass="FilterDate" />
                                                                            <iwc:IboWebNumericTlk ID="FilterNumber" runat="server" CssClass="FilterNumber" Visible="false" Width="100px" ClientIDMode="Static"
                                                                                Value="0" Text="0">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </div>
                                                                        <div id="btnFilterOkContainer">
                                                                            <asp:ImageButton ID="btnFilterOk" runat="server" AlternateText="Cerca" ImageUrl="~/images/StdGrid/24/Search.png"
                                                                                ToolTip="Cerca sul campo attuale della griglia" OnClick="GridSearch" ImageAlign="AbsMiddle" />
                                                                        </div>
                                                                        <div id="btnFilterResetContainer">
                                                                            <asp:ImageButton ID="btnFilterReset" runat="server" AlternateText="Cerca" ImageUrl="~/images/Toolbar/24/Elimina.png"
                                                                                ToolTip="Svuota il filtro attuale" ImageAlign="AbsMiddle" OnClick="GridFilterReset" ClientIDMode="Static" />
                                                                        </div>
                                                                    </asp:Panel>
                                                                </div>
                                                            </div>
                                                            <asp:Panel ID="cpGrdElencoSpedizioni" runat="server" CssClass="cpGrdElencoSpedizioni">
                                                                <asp:Panel ID="pnlElencoSpedizioni" runat="server" CssClass="DetailFormGridContainerDiv GrigliaSelezione">
                                                                    <iwc:IboGridView ID="grdSpedizioni" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                        BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </asp:Panel>
                                                            </asp:Panel>
                                                            <asp:Panel ID="footerElencoSpedizioni" runat="server" CssClass="footerElencoSpedizioni">
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Pallet:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Volume_Caption" runat="server" ClientIDMode="Static" Text="Volume:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Spedizioni:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                        </asp:Panel>
                                                        <asp:Panel ID="DivGrdElencoSpedizioniRaggru" runat="server" Visible="false" ClientIDMode="Static">
                                                            <div id="HeaderElencoSpedizioniRaggru" class="HeaderElencoSpedizioni">
                                                                <iwc:iboWebToolbar ID="tlbElencoSpedizioniRaggru" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                    CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                <div class="DivFiltroSpedizioniRaggru">
                                                                    <asp:Panel runat="server" ID="gridFilterPanelRaggru" CssClass="PanelFiltroSpedizioniRaggru"
                                                                        ClientIDMode="Static" DefaultButton="btnFilterOkRaggru">
                                                                        <div style="position: absolute; top: 4px; left: 2px; width: 95px; font-size: 8pt; font-size: 8pt">
                                                                            <iwc:IboWebLabel runat="server" ID="lblFilterActiveFieldRaggru" Text="" Style="position: absolute; top: 0px; left: 0px; width: 95px; text-align: right;"></iwc:IboWebLabel>
                                                                        </div>
                                                                        <div style="position: absolute; top: 2px; left: 105px; width: 100px; font-size: 8pt">
                                                                            <iwc:IboDropDownList runat="server" ID="ddlFilterOperatorRaggru" Style="width: 100px; height: 19px; font-size: 8pt">
                                                                                <asp:ListItem Text="Contiene" Value="LIKE" Selected="True"></asp:ListItem>
                                                                                <asp:ListItem Text="Uguale" Value="="></asp:ListItem>
                                                                                <asp:ListItem Text="Diverso" Value="!="></asp:ListItem>
                                                                                <asp:ListItem Text="Maggiore o Uguale" Value="gt="></asp:ListItem>
                                                                                <asp:ListItem Text="Maggiore" Value="gt"></asp:ListItem>
                                                                                <asp:ListItem Text="Minore o uguale" Value="lt="></asp:ListItem>
                                                                                <asp:ListItem Text="Minore" Value="lt"></asp:ListItem>
                                                                                <asp:ListItem Text="E' vuoto" Value="ISNULL"></asp:ListItem>
                                                                                <asp:ListItem Text="Non è vuoto" Value="ISNOTNULL"></asp:ListItem>
                                                                                <asp:ListItem Text="Inizia per" Value="BEGIN"></asp:ListItem>
                                                                                <asp:ListItem Text="Non inizia per" Value="NOTBEGIN"></asp:ListItem>
                                                                                <asp:ListItem Text="Finisce per" Value="END"></asp:ListItem>
                                                                                <asp:ListItem Text="Non finisce per" Value="NOTEND"></asp:ListItem>
                                                                            </iwc:IboDropDownList>
                                                                        </div>
                                                                        <div style="position: absolute; top: 2px; left: 210px; width: 115px; font-size: 8pt">
                                                                            <iwc:IboWebTextBox runat="server" ID="FilterTextRaggru" Style="width: 115px; height: 13px; font-size: 8pt" ClientIDMode="Static"></iwc:IboWebTextBox>
                                                                            <iwc:IboWebDate2 runat="server" ID="FilterDateRaggru" ControlType="DateOnly" Visible="false" ClientIDMode="Static" CssClass="FilterDate" />
                                                                            <iwc:IboWebNumericTlk ID="FilterNumberRaggru" runat="server" CssClass="FilterNumber" Visible="false" Width="100px" ClientIDMode="Static"
                                                                                Value="0" Text="0">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </div>
                                                                        <div id="btnFilterOkContainerRaggru">
                                                                            <asp:ImageButton ID="btnFilterOkRaggru" runat="server" AlternateText="Cerca" ImageUrl="~/images/StdGrid/24/Search.png"
                                                                                ToolTip="Cerca sul campo attuale della griglia" OnClick="GridSearchRaggru" ImageAlign="AbsMiddle" />
                                                                        </div>
                                                                        <div id="btnFilterResetContainerRaggru">
                                                                            <asp:ImageButton ID="btnFilterResetRaggru" runat="server" AlternateText="Cerca" ImageUrl="~/images/Toolbar/24/Elimina.png"
                                                                                ToolTip="Svuota il filtro attuale" ImageAlign="AbsMiddle" OnClick="GridFilterResetRaggru" ClientIDMode="Static" />
                                                                        </div>
                                                                    </asp:Panel>
                                                                </div>
                                                            </div>
                                                            <asp:Panel ID="cpGrdElencoSpedizioniRaggru" runat="server" CssClass="cpGrdElencoSpedizioniRaggru">
                                                                <asp:Panel ID="pnlElencoSpedizioniRaggru" runat="server" CssClass="DetailFormGridContainerDiv GrigliaSelezione">
                                                                    <iwc:IboGridView ID="grdSpedizioniRaggru" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                        BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </asp:Panel>
                                                            </asp:Panel>
                                                            <asp:Panel ID="footerElencoSpedizioniRaggru" runat="server" CssClass="footerElencoSpedizioniRaggru">
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Pallet:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Volume_Caption" runat="server" ClientIDMode="Static" Text="Volume:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Spedizioni:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                        </asp:Panel>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </telerik:RadPane>
                                        </telerik:RadSplitter>
                                    </asp:Panel>
                                </asp:Panel>
                            </asp:Panel>
                        </div>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
<asp:Content ID="MasterPopupFormContent" ContentPlaceHolderID="phMasterPopupForm" runat="server">
    <asp:Panel ID="pnlCambiaData" runat="server" Visible="false" CssClass="PannelloPopup PannelloPopupCambioData">
        <table class="DetailFormSectionTable2Fixed">
            <tr class="LineaVuota">
                <td style="width: 90px"></td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 150px">
                    <iwc:IboWebLabel ID="lblDataSpedizioneCambia" runat="server" Text="Data partenza:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebDate2 ID="DataPartenzaCambia" runat="server" Width="90px" ControlType="DateOnly" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlZonaSpedizione" runat="server" Visible="false" CssClass="PannelloPopup PannelloPopupZona">
        <table class="DetailFormSectionTable2Fixed">
            <tr class="LineaVuota">
                <td style="width: 90px"></td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblZona" runat="server" Text="Zona Spedizione:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="ZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONESPEDIZIONE" Width="500px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="true"
                        MaxHeight="250px">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlCorrispondente" runat="server" Visible="false" CssClass="PannelloPopup PannelloPopupCorrispondente">
        <table class="DetailFormSectionTable2Fixed">
            <tr class="LineaVuota">
                <td style="width: 90px"></td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Transit Point:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="Corrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TransitPoint" Width="500px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="true"
                        MaxHeight="250px">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlViaggio" runat="server" Visible="false" CssClass="PannelloPopup PannelloPopupCreaViaggio">
        <table class="DetailFormSectionTable2Fixed">
            <tr class="LineaVuota">
                <td style="width: 90px"></td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="IboWebLabel1" runat="server" Text="Data partenza:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebDate2 ID="DataPartenzaPianificata" runat="server" Width="70px" ControlType="DateAndTime" FormatoOra="HH:mm" TimeControlWidth="40px" />
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblVettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="Vettore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TRASPORTATORI"
                        Width="500px" AutoLoadOnDemand="false" MaxHeight="250px">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="PCSPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="True" MaxHeight="250px"
                        SqlQueryWhere="PUNTODICARICO='S' OR PUNTODIPARCOVEICOLARE='S'">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" Text="Arrivo:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="PCSArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" AutoLoadOnDemand="true" MaxHeight="250px" SqlQueryWhere="PUNTODICARICO='S' OR PUNTODIPARCOVEICOLARE='S'">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlAssociaViaggio" runat="server" Visible="false" CssClass="PannelloPopup PannelloPopupAssociaViaggio">
        <table class="DetailFormSectionTable2Fixed">
            <tr class="LineaVuota">
                <td style="width: 90px"></td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblAnnbor" runat="server" Text="Id Viaggio:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="AssociaViaggio_IdViaggio" runat="server" SqlQuery="SELECT * FROM CBO_VIAGGI" Width="500px" AutoLoadOnDemand="true" MaxHeight="250px"
                        SqlQueryWhere="Stato=10" NoWrap="true" DropDownWidth="700px">
                        <%--<ItemTemplate>
                            <div><%# Eval("DescrizioneHtml")%></div>
                        </ItemTemplate>--%>
                        <HeaderTemplate>
                            <ul style="font-weight: bold;">
                                <li class="ComboCol ComboHeader" style="width: 60px;">
                                    <iwc:IboWebLabel runat="server" ID="Col1" Text="Id"></iwc:IboWebLabel></li>
                                <li class="ComboCol ComboHeader" style="width: 100px;">
                                    <iwc:IboWebLabel runat="server" ID="Col2" Text="Data"></iwc:IboWebLabel></li>
                                <li class="ComboCol ComboHeader" style="width: 280px;">
                                    <iwc:IboWebLabel runat="server" ID="col3" Text="Vettore"></iwc:IboWebLabel></li>
                                <li class="ComboCol ComboHeader" style="width: 80px;">
                                    <iwc:IboWebLabel runat="server" ID="col4" Text="Partenza"></iwc:IboWebLabel></li>
                                <li class="ComboCol ComboHeader" style="width: 80px;">
                                    <iwc:IboWebLabel runat="server" ID="col5" Text="Arrivo"></iwc:IboWebLabel></li>
                            </ul>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <ul>
                                <li class="ComboCol" style="width: 60px;">
                                    <%# DataBinder.Eval(Container.DataItem, "IdViaggio")%></li>
                                <li class="ComboCol" style="width: 100px;">
                                    <%# DataBinder.Eval(Container.DataItem, "Data")%></li>
                                <li class="ComboCol" style="width: 280px;">
                                    <%# DataBinder.Eval(Container.DataItem, "Vettore_RagioneSociale")%></li>
                                <li class="ComboCol" style="width: 80px;">
                                    <%# DataBinder.Eval(Container.DataItem, "PCSPartenza")%></li>
                                <li class="ComboCol" style="width: 80px;">
                                    <%# DataBinder.Eval(Container.DataItem, "PCSArrivo")%></li>
                            </ul>
                        </ItemTemplate>
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
