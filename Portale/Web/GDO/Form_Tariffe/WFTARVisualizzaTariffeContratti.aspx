<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFTARVisualizzaTariffeContratti.aspx.vb" Inherits="Incasbo.Web.GDO.WFTARVisualizzaTariffeContratti" %>

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
    <link rel="stylesheet" href="../../GDO/css/WFTARVisualizzaTariffeContratti.css?d=20170130" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="pnlMainContainer" CssClass="pnlMainContainer" runat="server">
        <asp:Panel runat="server" ID="pnlMainBody" CssClass="pnlMainBody">
            <table class="DetailFormMainTable" id="DetailFormMainTable">
                <tr>
                    <td>
                        <div class="DetailFormSectionDiv">
                            <asp:Panel runat="server" ID="pnlMain">
                                <asp:Panel runat="server" ID="Bottoni">
                                    <asp:UpdatePanel runat="server" ID="upButton" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="DetailFormSectionTable2">
                                                <tr>
                                                    <td style="text-align: left; width: auto; padding-left: 2px">
                                                        <div id="ToolbarContainer">
                                                            <div id="ToolbarSessione" class="PlanToolbar">
                                                                <iwc:IboWebButton runat="server" ID="btnAnnulla" ToolTip="Esci" Text="Esci" CssClass="PlanToolbarButton DetailFormButton_Cancel" />
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td></td>
                                                    <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                        <iwc:IboWebLabel ID="lblContratto" runat="server" Text="Contratto:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellMiddle" style="width: 310px; white-space: nowrap; overflow: hidden; text-overflow: ellipsis;">
                                                        <iwc:IboWebLabel ID="Descrizione" runat="server" Width="300px" CssClass="WFIGrassetto" FieldName="Descrizione"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                        <iwc:IboWebLabel ID="lblSoggetto" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellMiddle" style="width: 350px; white-space: nowrap; overflow: hidden; text-overflow: ellipsis;">
                                                        <iwc:IboWebLabel ID="Soggetto" runat="server" Width="350px" CssClass="WFIGrassetto"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                        <iwc:IboWebLabel ID="lblDataInizioValidita" runat="server" Text="Da:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellMiddle" style="width: 80px;">
                                                        <iwc:IboWebLabel ID="DataInizioValidita" runat="server" Width="90px" CssClass="WFIGrassetto" FieldDataType="Date" FieldName="DataInizioValidita" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 30px;">
                                                        <iwc:IboWebLabel ID="lblDataFineValidita" runat="server" Text="A:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellMiddle" style="width: 95px;">
                                                        <iwc:IboWebLabel ID="DataFineValidita" runat="server" Width="90px" CssClass="WFIGrassetto" FieldDataType="Date" FieldName="DataFineValidita" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                        <iwc:IboWebLabel ID="lblContrattoTrasporto" runat="server" Text="Trasporto:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellMiddle" style="width: 10px;">
                                                        <iwc:IboWebCheckBox ID="ContrattoTrasporto" runat="server" Enabled="false" FieldName="ContrattoTrasporto"></iwc:IboWebCheckBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                        <iwc:IboWebLabel ID="lblContrattoGiacenza" runat="server" Text="Giacenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellMiddle" style="width: 10px;">
                                                        <iwc:IboWebCheckBox ID="ContrattoGiacenza" runat="server" Enabled="false" FieldName="ContrattoGiacenza"></iwc:IboWebCheckBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                        <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellMiddle" style="width: 20px;">
                                                        <iwc:IboWebCheckBox ID="Attivo" runat="server" Enabled="false" FieldName="Attivo"></iwc:IboWebCheckBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body">
                                    <asp:Panel runat="server" ID="pnlSplitter" ClientIDMode="Static">
                                        <telerik:RadSplitter ID="MainBodySplitter1" runat="server" CssClass="TariffeContrattiSplitter" ClientIDMode="Static" Width="100%" Height="100%" BorderSize="0" Orientation="Horizontal"
                                            ResizeMode="AdjacentPane">
                                            <telerik:RadPane ID="MainBodySplitterTop" runat="server" Scrolling="None" ClientIDMode="Static" Height="66%" CssClass="PannelloEsternoGrigliaTestate">
                                                <asp:UpdatePanel runat="server" ID="upElencoTestate" UpdateMode="Conditional" ChildrenAsTriggers="true" RenderMode="Inline">
                                                    <ContentTemplate>
                                                        <div id="DivGrdElencoTestate">
                                                            <div id="HeaderElencoTestate" class="HeaderElencoTestate">
                                                                <iwc:iboWebToolbar ID="tlbElencoTestate" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                    CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                <div class="DivFiltroTariffe" style="float: right; padding-top: 5px">
                                                                    <asp:Panel runat="server" ID="gridFilterPanel" CssClass="PanelFiltroTariffe"
                                                                        ClientIDMode="Static" DefaultButton="btnFilterOk">
                                                                        <div style="position: absolute; top: 4px; left: 0px; width: 95px; font-size: 8pt; font-size: 8pt; margin-top: 2px;">
                                                                            <iwc:IboWebLabel runat="server" ID="lblFilterActiveField" Text="" Style="position: absolute; top: 0px; left: 0px; width: 95px; text-align: right;"></iwc:IboWebLabel>
                                                                        </div>
                                                                        <div style="position: absolute; top: 2px; left: 105px; width: 100px; font-size: 8pt; margin-top: 2px;">
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
                                                                        <div style="position: absolute; top: 2px; left: 210px; width: 115px; font-size: 8pt; margin-top: 2px;">
                                                                            <iwc:IboWebTextBox runat="server" ID="FilterText" Style="width: 115px; height: 13px; font-size: 8pt" ClientIDMode="Static"></iwc:IboWebTextBox>
                                                                            <iwc:IboWebDate2 runat="server" ID="FilterDate" ControlType="DateOnly" Visible="false" ClientIDMode="Static" CssClass="FilterDate" />
                                                                            <iwc:IboWebNumericTlk ID="FilterNumber" runat="server" CssClass="FilterNumber" Visible="false" Width="100px" ClientIDMode="Static"
                                                                                Value="0" Text="0">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </div>
                                                                        <div id="btnFilterOkContainer" style="position: absolute; top: 2px; text-align: right;">
                                                                            <asp:ImageButton ID="btnFilterOk" runat="server" AlternateText="Cerca" ImageUrl="~/images/StdGrid/24/Search.png"
                                                                                ToolTip="Cerca sul campo attuale della griglia" OnClick="GridSearch" ImageAlign="AbsMiddle" ClientIDMode="Static" />
                                                                        </div>
                                                                        <div id="btnFilterResetContainer" style="position: absolute; top: 2px; text-align: right">
                                                                            <asp:ImageButton ID="btnFilterReset" runat="server" AlternateText="Svuota filtro" ImageUrl="~/images/Toolbar/24/Elimina.png"
                                                                                ToolTip="Svuota il filtro attuale" ImageAlign="AbsMiddle" OnClick="GridFilterReset" ClientIDMode="Static" />
                                                                        </div>
                                                                    </asp:Panel>
                                                                </div>
                                                            </div>
                                                            <iwc:IboWebPanel ID="cpGrdElencoTestate" runat="server" MaintainScrollPositionOnPostBack="True" CssClass="cpGrdElencoTestate">
                                                                <table class="tableGridContainerTestate">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Panel ID="pnlElencoTestate" runat="server" CssClass="DetailFormGridContainerDivTestate">
                                                                                <iwc:IboGridView ID="grdElencoTestate" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
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
                                                        </div>
                                                        <asp:HiddenField ID="AttivoPassivo" runat="server" Value="" ClientIDMode="Static" />
                                                        <iwc:IboWebTextBox ID="Contratto" runat="server" CssClass="hidden" FieldName="Codice"></iwc:IboWebTextBox>
                                                        <iwc:IboWebTextBox ID="Cliente" runat="server" CssClass="hidden" FieldName="Cliente"></iwc:IboWebTextBox>
                                                        <iwc:IboWebTextBox ID="Trasportatore" runat="server" CssClass="hidden" FieldName="Trasportatore"></iwc:IboWebTextBox>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </telerik:RadPane>

                                            <telerik:RadSplitBar ID="MainBodySplitterBar1" runat="server" CollapseMode="None">
                                            </telerik:RadSplitBar>
                                            <telerik:RadPane ID="MainBodySplitterBottom" runat="server" Width="100%" Height="33%" Scrolling="None">
                                                <telerik:RadSplitter ID="MainBodySplitter3" runat="server" CssClass="TariffeContrattiSplitter" Width="100%" BorderSize="0" Orientation="Vertical">
                                                    <telerik:RadPane ID="MainBodySplitterBottom1" runat="server" Width="60%" Scrolling="None" CssClass="PannelloEsternoGrigliaVoci">
                                                        <asp:UpdatePanel runat="server" ID="upElencoVoci" UpdateMode="Conditional" RenderMode="Inline">
                                                            <ContentTemplate>
                                                                <div id="DivGrdElencoVoci">
                                                                    <asp:Panel ID="cpGrdElencoVoci" runat="server" CssClass="cpGrdElencoVoci">
                                                                        <table class="tableGridContainerTestate">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Panel ID="pnlElencoVoci" runat="server" CssClass="DetailFormGridContainerDivTestate">
                                                                                        <iwc:IboGridView ID="grdElencoVoci" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
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
                                                                </div>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </telerik:RadPane>
                                                    <telerik:RadSplitBar ID="RadSplitBar3" runat="server" CollapseMode="None">
                                                    </telerik:RadSplitBar>
                                                    <telerik:RadPane ID="MainBodySplitterBottom2" runat="server" Width="40%" Height="100%" Scrolling="None" CssClass="PannelloEsternoGrigliaFasce">
                                                        <asp:UpdatePanel runat="server" ID="upElencoFasce" UpdateMode="Conditional" RenderMode="Inline">
                                                            <ContentTemplate>
                                                                <div id="DivGrdElencoFasce">
                                                                    <asp:Panel ID="cpGrdElencoFasce" runat="server" CssClass="cpGrdElencoFasce">
                                                                        <table class="tableGridContainerTestate">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Panel ID="pnlElencoFasce" runat="server" CssClass="DetailFormGridContainerDivTestate">
                                                                                        <iwc:IboGridView ID="grdElencoFasce" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
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
                                                                </div>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </telerik:RadPane>
                                                </telerik:RadSplitter>
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
