<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFPIAPianificazioneViaggi.aspx.vb" Inherits="Incasbo.Web.GDO.WFPIAPianificazioneViaggi" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm.css?d=20180123" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFPIAPianificazioneViaggi.css?d=20180123" type="text/css" />
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
                                                            <div id="Toolbar1" class="PlanToolbar">
                                                                <iwc:IboWebButton runat="server" ID="btnAnnulla" Text="Esci" CssClass="PlanToolbarButton DetailFormButton_Cancel" />
                                                            </div>
                                                            <div id="Toolbar2" class="PlanToolbar">
                                                                <iwc:IboWebButton runat="server" ID="btnAggiorna" Text="Aggiorna" CssClass="PlanToolbarButton Aggiorna" />
                                                                <iwc:IboWebButton runat="server" ID="btnCambiaDataSpedizione" Text="Cambia date" CssClass="PlanToolbarButton CambiaDate" />
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td></td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="lblDataViaggio" runat="server" Text="Data Viaggio:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 120px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="DataViaggio" runat="server" Width="115px" CssClass="WFIGrassetto"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 67px; vertical-align: middle; position: relative;">
                                                        <iwc:IboWebButton runat="server" ID="btnGotoPreviousDateViaggio" ToolTip="Va alla data precedente" CssClass="PlanToolbarButton GotoPreviousDate" />
                                                        <iwc:IboWebButton runat="server" ID="btnGotoNextDateViaggio" ToolTip="Va alla data successiva" CssClass="PlanToolbarButton GotoNextDate" />
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="lblDataSpedizione" runat="server" Text="Data Spedizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 20px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="lblDataSpedizioneDaCaption" runat="server" Text="da"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 95px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="DataSpedizioneDa" runat="server" Width="90px" CssClass="WFIGrassetto"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 67px; vertical-align: middle; position: relative;">
                                                        <iwc:IboWebButton runat="server" ID="btnGotoPreviousDateDa" ToolTip="Va alla data precedente" CssClass="PlanToolbarButton GotoPreviousDate" />
                                                        <iwc:IboWebButton runat="server" ID="btnGotoNextDateDa" ToolTip="Va alla data successiva" CssClass="PlanToolbarButton GotoNextDate" />
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 20px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="IboWebLabel2" runat="server" Text="a"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 95px; vertical-align: middle">
                                                        <iwc:IboWebLabel ID="DataSpedizioneA" runat="server" Width="90px" CssClass="WFIGrassetto"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 67px; vertical-align: middle; position: relative;">
                                                        <iwc:IboWebButton runat="server" ID="btnGotoPreviousDateA" ToolTip="Va alla data precedente" CssClass="PlanToolbarButton GotoPreviousDate" />
                                                        <iwc:IboWebButton runat="server" ID="btnGotoNextDateA" ToolTip="Va alla data successiva" CssClass="PlanToolbarButton GotoNextDate" />
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
                                                    <telerik:RadPane ID="MainBodySplitterBottom1" runat="server" Width="45%" Scrolling="None" CssClass="PannelloEsternoGrigliaViaggi" MinWidth="640" MaxWidth="1000">
                                                        <asp:UpdatePanel runat="server" ID="upElencoViaggi" UpdateMode="Conditional" RenderMode="Inline">
                                                            <ContentTemplate>
                                                                <%--<div id="DivGrdElencoViaggi">--%>
                                                                <asp:Panel ID="DivGrdElencoViaggi" runat="server" ClientIDMode="Static" Visible="true">
                                                                    <div id="HeaderElencoViaggi" class="HeaderElencoViaggi">
                                                                        <div id="ViaggiCaptionContainer">
                                                                            <iwc:IboWebLabel ID="lblViaggiCaption" runat="server" Text="Viaggi attivi" Translate="true"></iwc:IboWebLabel>
                                                                        </div>
                                                                        <iwc:iboWebToolbar ID="tlbElencoViaggi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                            CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <div class="DivFiltroViaggi">
                                                                            <asp:Panel runat="server" ID="gridFilterPanelViaggi" CssClass="PanelFiltroViaggi" ClientIDMode="Static" DefaultButton="btnFilterOkViaggi">
                                                                                <div style="position: absolute; top: 4px; left: 12px; width: 95px; font-size: 8pt; font-size: 8pt">
                                                                                    <iwc:IboWebLabel runat="server" ID="lblFilterActiveFieldViaggi" Text="" Style="position: absolute; top: 0px; left: 0px; width: 95px; text-align: right;"></iwc:IboWebLabel>
                                                                                </div>
                                                                                <div style="position: absolute; top: 2px; left: 115px; width: 100px; font-size: 8pt">
                                                                                    <iwc:IboDropDownList runat="server" ID="ddlFilterOperatorViaggi" Style="width: 100px; height: 19px; font-size: 8pt">
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
                                                                                <div style="position: absolute; top: 2px; left: 220px; width: 107px; font-size: 8pt">
                                                                                    <iwc:IboWebTextBox runat="server" ID="FilterTextViaggi" Style="width: 100px; height: 13px; font-size: 8pt" ClientIDMode="Static"></iwc:IboWebTextBox>
                                                                                    <iwc:IboWebDate2 runat="server" ID="FilterDateViaggi" ControlType="DateOnly" Visible="false" ClientIDMode="Static" CssClass="FilterDate" />
                                                                                    <iwc:IboWebNumericTlk ID="FilterNumberViaggi" runat="server" CssClass="FilterNumber" Visible="false" Width="100px" ClientIDMode="Static"
                                                                                        Value="0" Text="0">
                                                                                    </iwc:IboWebNumericTlk>
                                                                                </div>
                                                                                <div id="btnFilterOkContainerViaggi">
                                                                                    <asp:ImageButton ID="btnFilterOkViaggi" runat="server" AlternateText="Cerca" ImageUrl="~/images/StdGrid/24/Search.png"
                                                                                        ToolTip="Cerca sul campo attuale della griglia" OnClick="GridSearchViaggi" ImageAlign="AbsMiddle" />
                                                                                </div>
                                                                                <div id="btnFilterResetContainerViaggi">
                                                                                    <asp:ImageButton ID="btnFilterResetViaggi" runat="server" AlternateText="Cerca" ImageUrl="~/images/Toolbar/24/Elimina.png"
                                                                                        ToolTip="Svuota il filtro attuale" ImageAlign="AbsMiddle" OnClick="GridFilterResetViaggi" ClientIDMode="Static" />
                                                                                </div>
                                                                            </asp:Panel>
                                                                        </div>
                                                                    </div>
                                                                    <iwc:IboWebPanel ID="cpGrdElencoViaggi" runat="server" MaintainScrollPositionOnPostBack="True" CssClass="cpGrdElencoViaggi">
                                                                        <iwc:IboWebPanel ID="pnlElencoViaggi" runat="server" CssClass="DetailFormGridContainerDivPia" MaintainScrollPositionOnPostBack="true">
                                                                            <asp:HiddenField runat="server" ID="hdnIdViaggioSelezionato" />
                                                                            <iwc:IboGridView ID="grdViaggi" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                <PagerStyle Font-Size="Small" />
                                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                            </iwc:IboGridView>
                                                                        </iwc:IboWebPanel>
                                                                    </iwc:IboWebPanel>
                                                                    <%--  </div>--%>
                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </telerik:RadPane>
                                                    <telerik:RadSplitBar ID="RadSplitBar3" runat="server" CollapseMode="None">
                                                    </telerik:RadSplitBar>
                                                    <telerik:RadPane ID="MainBodySplitterBottom2" runat="server" Width="55%" Height="100%" Scrolling="None" CssClass="PannelloEsternoGrigliaSpedizioniViaggio">
                                                        <asp:UpdatePanel runat="server" ID="upElencoSpedizioniViaggio" UpdateMode="Conditional" RenderMode="Inline">
                                                            <ContentTemplate>
                                                                <asp:Panel ID="DivGrdElencoSpedizioniViaggio" runat="server" ClientIDMode="Static" Visible="true">
                                                                    <div id="HeaderElencoSpedizioniViaggio" class="HeaderElencoSpedizioniViaggio">
                                                                        <div id="ElencoSpedizioniViaggioContainer">
                                                                            <iwc:IboWebLinkButton ID="lnkElencoSpedizioniViaggioCaption" CssClass="lnkElencoSpedizioniViaggioCaption" Enabled="false" runat="server" Text="Spedizioni" Translate="true"></iwc:IboWebLinkButton>
                                                                            <iwc:IboWebLinkButton ID="lnkElencoConsengeViaggioCaption" runat="server" Text="Consegne" CssClass="lnkElencoConsengeViaggioCaption" Translate="true"></iwc:IboWebLinkButton>
                                                                        </div>
                                                                        <iwc:iboWebToolbar ID="tlbElencoSpedizioniViaggio" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                            CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <iwc:iboWebToolbar ID="tlbElencoSpedizioniRaggruViaggio" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                            CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" Visible="false" />
                                                                    </div>
                                                                    <iwc:IboWebPanel ID="cpGrdElencoSpedizioniViaggio" runat="server" MaintainScrollPositionOnPostBack="True" CssClass="cpGrdElencoSpedizioniViaggio">
                                                                        <iwc:IboWebPanel ID="pnlElencoSpedizioniViaggio" runat="server" CssClass="DetailFormGridContainerDivPia" MaintainScrollPositionOnPostBack="true">
                                                                            <iwc:IboGridView ID="grdSpedizioniViaggio" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="true">
                                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                <PagerStyle Font-Size="Small" />
                                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                            </iwc:IboGridView>
                                                                        </iwc:IboWebPanel>
                                                                    </iwc:IboWebPanel>
                                                                    <iwc:IboWebPanel ID="cpGrdElencoSpedizioniRaggruViaggio" runat="server" MaintainScrollPositionOnPostBack="True" CssClass="cpGrdElencoSpedizioniViaggio" Visible="False">
                                                                        <iwc:IboWebPanel ID="pnlElencoSpedizioniRaggruViaggio" runat="server" CssClass="DetailFormGridContainerDivPia" MaintainScrollPositionOnPostBack="true">
                                                                            <iwc:IboGridView ID="grdSpedizioniRaggruViaggio" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="true">
                                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                <PagerStyle Font-Size="Small" />
                                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                            </iwc:IboGridView>
                                                                        </iwc:IboWebPanel>
                                                                    </iwc:IboWebPanel>
                                                                    <asp:Panel ID="footerElencoSpedizioniViaggio" runat="server" CssClass="footerElencoSpedizioniViaggio">
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Plt:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Volume_Caption" runat="server" ClientIDMode="Static" Text="Vol:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo1_Caption" runat="server" ClientIDMode="Static" Text="CC1:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo1_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo2_Caption" runat="server" ClientIDMode="Static" Text="CC2:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo2_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo3_Caption" runat="server" ClientIDMode="Static" Text="CC3:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo3_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo4_Caption" runat="server" ClientIDMode="Static" Text="CC4:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo4_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo5_Caption" runat="server" ClientIDMode="Static" Text="CC5:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo5_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo6_Caption" runat="server" ClientIDMode="Static" Text="CC6:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo6_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo7_Caption" runat="server" ClientIDMode="Static" Text="CC7:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo7_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo8_Caption" runat="server" ClientIDMode="Static" Text="CC8:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo8_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo9_Caption" runat="server" ClientIDMode="Static" Text="CC9:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo9_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo10_Caption" runat="server" ClientIDMode="Static" Text="CC10:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_CampoCalcolo10_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Sped:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_TotSpedizioni_Caption" runat="server" Style="position: absolute; right: 60px;" ClientIDMode="Static" Text="Tot. Sped:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniViaggio_TotSpedizioni_Value" runat="server" Style="position: absolute; right: 5px;" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                    </asp:Panel>
                                                                    <asp:Panel ID="footerElencoSpedizioniRaggruViaggio" runat="server" CssClass="footerElencoSpedizioniViaggio" Visible="false">
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Plt:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Volume_Caption" runat="server" ClientIDMode="Static" Text="Vol:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo1_Caption" runat="server" ClientIDMode="Static" Text="CC1:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo1_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo2_Caption" runat="server" ClientIDMode="Static" Text="CC2:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo2_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo3_Caption" runat="server" ClientIDMode="Static" Text="CC3:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo3_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo4_Caption" runat="server" ClientIDMode="Static" Text="CC4:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo4_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo5_Caption" runat="server" ClientIDMode="Static" Text="CC5:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo5_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo6_Caption" runat="server" ClientIDMode="Static" Text="CC6:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo6_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo7_Caption" runat="server" ClientIDMode="Static" Text="CC7:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo7_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo8_Caption" runat="server" ClientIDMode="Static" Text="CC8:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo8_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo9_Caption" runat="server" ClientIDMode="Static" Text="CC9:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo9_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo10_Caption" runat="server" ClientIDMode="Static" Text="CC10:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_CampoCalcolo10_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Cons:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_TotSpedizioni_Caption" runat="server" Style="position: absolute; right: 60px;" ClientIDMode="Static" Text="Tot. Cons:" CssClass="footerSpedizioniViaggio_Caption"></iwc:IboWebLabel>
                                                                        <iwc:IboWebLabel ID="footerSpedizioniRaggruViaggio_TotSpedizioni_Value" runat="server" Style="position: absolute; right: 5px;" ClientIDMode="Static" Text="0" CssClass="footerSpedizioniViaggio_Value"></iwc:IboWebLabel>
                                                                    </asp:Panel>
                                                                </asp:Panel>
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
                                                                <div id="ElencoSpedizioniContainer">
                                                                    <iwc:IboWebLabel ID="lblElencoSpedizioniCaption" runat="server" Text="Sped. Libere" CssClass="lblElencoSpedizioniCaption" Translate="true"></iwc:IboWebLabel>
                                                                    <iwc:IboWebLinkButton ID="lnkElencoConsegneCaption" CssClass="lnkElencoConsegneCaption" runat="server" Text="Consegne" CommandArgument="CONSEGNE" Translate="true"></iwc:IboWebLinkButton>
                                                                    <iwc:IboWebLinkButton ID="lnkElencoDestinazioniCaption" CssClass="lnkElencoDestinazioniCaption" runat="server" Text="Destinazioni" CommandArgument="DESTINAZIONI" Translate="true"></iwc:IboWebLinkButton>
                                                                </div>
                                                                <iwc:iboWebToolbar ID="tlbElencoSpedizioni" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                    CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />

                                                                <div class="DivFiltroSpedizioni">
                                                                    <asp:Panel runat="server" ID="gridFilterPanel" CssClass="PanelFiltroSpedizioni" ClientIDMode="Static" DefaultButton="btnFilterOk">
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
                                                            <iwc:IboWebPanel ID="cpGrdElencoSpedizioni" runat="server" CssClass="cpGrdElencoSpedizioni" MaintainScrollPositionOnPostBack="true">
                                                                <iwc:IboWebPanel ID="pnlElencoSpedizioni" runat="server" CssClass="DetailFormGridContainerDiv GrigliaSelezione">
                                                                    <iwc:IboGridView ID="grdSpedizioni" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                        BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="top" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </iwc:IboWebPanel>
                                                            </iwc:IboWebPanel>
                                                            <asp:Panel ID="footerElencoSpedizioni" runat="server" CssClass="footerElencoSpedizioni">
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Pallet:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Volume_Caption" runat="server" ClientIDMode="Static" Text="Volume:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo1_Caption" runat="server" ClientIDMode="Static" Text="CC1:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo1_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo2_Caption" runat="server" ClientIDMode="Static" Text="CC2:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo2_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo3_Caption" runat="server" ClientIDMode="Static" Text="CC3:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo3_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo4_Caption" runat="server" ClientIDMode="Static" Text="CC4:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo4_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo5_Caption" runat="server" ClientIDMode="Static" Text="CC5:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo5_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo6_Caption" runat="server" ClientIDMode="Static" Text="CC6:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo6_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo7_Caption" runat="server" ClientIDMode="Static" Text="CC7:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo7_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo8_Caption" runat="server" ClientIDMode="Static" Text="CC8:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo8_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo9_Caption" runat="server" ClientIDMode="Static" Text="CC9:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo9_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo10_Caption" runat="server" ClientIDMode="Static" Text="CC10:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_CampoCalcolo10_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Spedizioni:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_TotSpedizioni_Caption" runat="server" Style="position: absolute; right: 80px;" ClientIDMode="Static" Text="Totale Spedizioni:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioni_TotSpedizioni_Value" runat="server" Style="position: absolute; right: 5px;" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                        </asp:Panel>
                                                        <asp:Panel ID="DivGrdElencoSpedizioniRaggru" runat="server" Visible="false" ClientIDMode="Static">
                                                            <div id="HeaderElencoSpedizioniRaggru" class="HeaderElencoSpedizioni">
                                                                <div id="ElencoSpedizioniContainer2">
                                                                    <iwc:IboWebLinkButton ID="lnkElencoSpedizioniCaption" CssClass="lnkElencoSpedizioniCaption" runat="server" CommandArgument="SPEDIZIONI" Text="Sped. Libere" Translate="true"></iwc:IboWebLinkButton>
                                                                    <iwc:IboWebLabel ID="lblElencoConsegneCaption" runat="server" Text="Consegne" CssClass="lblElencoSpedizioniCaption" Translate="true"></iwc:IboWebLabel>
                                                                    <iwc:IboWebLinkButton ID="lnkElencoDestinazioniCaption2" CssClass="lnkElencoDestinazioniCaption" runat="server" Text="Destinazioni" CommandArgument="DESTINAZIONI" Translate="true"></iwc:IboWebLinkButton>
                                                                </div>
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
                                                            <iwc:IboWebPanel ID="cpGrdElencoSpedizioniRaggru" runat="server" CssClass="cpGrdElencoSpedizioniRaggru" MaintainScrollPositionOnPostBack="true">
                                                                <asp:Panel ID="pnlElencoSpedizioniRaggru" runat="server" CssClass="DetailFormGridContainerDiv GrigliaSelezione">
                                                                    <iwc:IboGridView ID="grdSpedizioniRaggru" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                        BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="top" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </asp:Panel>
                                                            </iwc:IboWebPanel>
                                                            <asp:Panel ID="footerElencoSpedizioniRaggru" runat="server" CssClass="footerElencoSpedizioniRaggru">
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Pallet:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Volume_Caption" runat="server" ClientIDMode="Static" Text="Volume:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>

                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo1_Caption" runat="server" ClientIDMode="Static" Text="CC1:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo1_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo2_Caption" runat="server" ClientIDMode="Static" Text="CC2:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo2_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo3_Caption" runat="server" ClientIDMode="Static" Text="CC3:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo3_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo4_Caption" runat="server" ClientIDMode="Static" Text="CC4:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo4_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo5_Caption" runat="server" ClientIDMode="Static" Text="CC5:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo5_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo6_Caption" runat="server" ClientIDMode="Static" Text="CC6:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo6_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo7_Caption" runat="server" ClientIDMode="Static" Text="CC7:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo7_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo8_Caption" runat="server" ClientIDMode="Static" Text="CC8:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo8_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo9_Caption" runat="server" ClientIDMode="Static" Text="CC9:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo9_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo10_Caption" runat="server" ClientIDMode="Static" Text="CC10:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_CampoCalcolo10_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>

                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Spedizioni:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_TotConsegne_Caption" runat="server" Style="position: absolute; right: 90px;" ClientIDMode="Static" Text="Totale consegne:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru_TotConsegne_Value" runat="server" Style="position: absolute; right: 5px;" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                        </asp:Panel>
                                                        <asp:Panel ID="DivGrdElencoSpedizioniRaggru2" runat="server" Visible="false" ClientIDMode="Static">
                                                            <div id="HeaderElencoSpedizioniRaggru2" class="HeaderElencoSpedizioni">
                                                                <div id="ElencoSpedizioniContainer3">
                                                                    <iwc:IboWebLinkButton ID="lnkElencoSpedizioniCaption2" CssClass="lnkElencoSpedizioniCaption" runat="server" Text="Sped. Libere" Translate="true" CommandArgument="SPEDIZIONI"></iwc:IboWebLinkButton>
                                                                    <iwc:IboWebLinkButton ID="lnkElencoConsegneCaption2" CssClass="lnkElencoConsegneCaption" runat="server" Text="Consegne" Translate="true" CommandArgument="CONSEGNE"></iwc:IboWebLinkButton>
                                                                    <iwc:IboWebLabel ID="lblElencoDestinazioniCaption" runat="server" Text="Destinazioni" CssClass="lblElencoDestinazioniCaption" Translate="true"></iwc:IboWebLabel>
                                                                </div>
                                                                <iwc:iboWebToolbar ID="tlbElencoSpedizioniRaggru2" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                    CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                <div class="DivFiltroSpedizioniRaggru2">
                                                                    <asp:Panel runat="server" ID="gridFilterPanelRaggru2" CssClass="PanelFiltroSpedizioniRaggru" ClientIDMode="Static" DefaultButton="btnFilterOkRaggru2">
                                                                        <div style="position: absolute; top: 4px; left: 2px; width: 95px; font-size: 8pt; font-size: 8pt">
                                                                            <iwc:IboWebLabel runat="server" ID="lblFilterActiveFieldRaggru2" Text="" Style="position: absolute; top: 0px; left: 0px; width: 95px; text-align: right;"></iwc:IboWebLabel>
                                                                        </div>
                                                                        <div style="position: absolute; top: 2px; left: 105px; width: 100px; font-size: 8pt">
                                                                            <iwc:IboDropDownList runat="server" ID="ddlFilterOperatorRaggru2" Style="width: 100px; height: 19px; font-size: 8pt">
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
                                                                            <iwc:IboWebTextBox runat="server" ID="FilterTextRaggru2" Style="width: 115px; height: 13px; font-size: 8pt" ClientIDMode="Static"></iwc:IboWebTextBox>
                                                                            <iwc:IboWebDate2 runat="server" ID="FilterDateRaggru2" ControlType="DateOnly" Visible="false" ClientIDMode="Static" CssClass="FilterDate" />
                                                                            <iwc:IboWebNumericTlk ID="FilterNumberRaggru2" runat="server" CssClass="FilterNumber" Visible="false" Width="100px" ClientIDMode="Static"
                                                                                Value="0" Text="0">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </div>
                                                                        <div id="btnFilterOkContainerRaggru2">
                                                                            <asp:ImageButton ID="btnFilterOkRaggru2" runat="server" AlternateText="Cerca" ImageUrl="~/images/StdGrid/24/Search.png"
                                                                                ToolTip="Cerca sul campo attuale della griglia" OnClick="GridSearchRaggru2" ImageAlign="AbsMiddle" />
                                                                        </div>
                                                                        <div id="btnFilterResetContainerRaggru2">
                                                                            <asp:ImageButton ID="btnFilterResetRaggru2" runat="server" AlternateText="Cerca" ImageUrl="~/images/Toolbar/24/Elimina.png"
                                                                                ToolTip="Svuota il filtro attuale" ImageAlign="AbsMiddle" OnClick="GridFilterResetRaggru2" ClientIDMode="Static" />
                                                                        </div>
                                                                    </asp:Panel>
                                                                </div>
                                                            </div>
                                                            <iwc:IboWebPanel ID="cpGrdElencoSpedizioniRaggru2" runat="server" CssClass="cpGrdElencoSpedizioniRaggru2" MaintainScrollPositionOnPostBack="true">
                                                                <asp:Panel ID="pnlElencoSpedizioniRaggru2" runat="server" CssClass="DetailFormGridContainerDiv GrigliaSelezione">
                                                                    <iwc:IboGridView ID="grdSpedizioniRaggru2" runat="server" AllowPaging="false" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                        BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" Width="100%" PageSize="20" EnableSelectionAutoPostBack="True">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="top" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </asp:Panel>
                                                            </iwc:IboWebPanel>
                                                            <asp:Panel ID="footerElencoSpedizioniRaggru2" runat="server" CssClass="footerElencoSpedizioniRaggru">
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Colli_Caption" runat="server" ClientIDMode="Static" Text="Colli:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Colli_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Pallet_Caption" runat="server" ClientIDMode="Static" Text="Pallet:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Pallet_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Volume_Caption" runat="server" ClientIDMode="Static" Text="Volume:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Volume_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Peso_Caption" runat="server" ClientIDMode="Static" Text="Peso:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Peso_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>

                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo1_Caption" runat="server" ClientIDMode="Static" Text="CC1:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo1_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo2_Caption" runat="server" ClientIDMode="Static" Text="CC2:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo2_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo3_Caption" runat="server" ClientIDMode="Static" Text="CC3:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo3_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo4_Caption" runat="server" ClientIDMode="Static" Text="CC4:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo4_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo5_Caption" runat="server" ClientIDMode="Static" Text="CC5:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo5_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo6_Caption" runat="server" ClientIDMode="Static" Text="CC6:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo6_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo7_Caption" runat="server" ClientIDMode="Static" Text="CC7:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo7_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo8_Caption" runat="server" ClientIDMode="Static" Text="CC8:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo8_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo9_Caption" runat="server" ClientIDMode="Static" Text="CC9:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo9_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo10_Caption" runat="server" ClientIDMode="Static" Text="CC10:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_CampoCalcolo10_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>

                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Spedizioni_Caption" runat="server" ClientIDMode="Static" Text="Spedizioni:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_Spedizioni_Value" runat="server" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_TotDestinazioni_Caption" runat="server" Style="position: absolute; right: 90px;" ClientIDMode="Static" Text="Totale destinazioni:" CssClass="footerSpedizioni_Caption"></iwc:IboWebLabel>
                                                                <iwc:IboWebLabel ID="footerSpedizioniRaggru2_TotDestinazioni_Value" runat="server" Style="position: absolute; right: 5px;" ClientIDMode="Static" Text="0" CssClass="footerSpedizioni_Value"></iwc:IboWebLabel>
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
                    <iwc:IboWebLabel ID="lblDataViaggioCambia" runat="server" Text="Data Viaggio:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 200px">
                    <iwc:IboWebDate2 ID="DataViaggioCambia" runat="server" Width="90px" ControlType="DateOnly" />
                </td>
            </tr>
        </table>
        <hr class="WFIHRSeparatore" />
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 150px">
                    <iwc:IboWebLabel ID="lblDataSpedizioneCambiaDa" runat="server" Text="Da Data Spedizione:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 200px">
                    <iwc:IboWebDate2 ID="DataSpedizioneCambiaDa" runat="server" Width="90px" ControlType="DateOnly" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 150px">
                    <iwc:IboWebLabel ID="lblDataSpedizioneCambiaA" runat="server" Text="A Data Spedizione:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 200px">
                    <iwc:IboWebDate2 ID="DataSpedizioneCambiaA" runat="server" Width="90px" ControlType="DateOnly" />
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
                    <iwc:IboWebComboTlk ID="Corrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TransitPoint" Width="500px" AutoLoadOnDemand="true"
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
                    <iwc:IboWebLabel ID="lblTipoViaggio" runat="server" Text="Tipo Viaggio:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="TipoViaggio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Viaggi_TipiViaggio" Width="500px" MaxHeight="250px" SqlQueryWhere="Attivo='S' AND InsertableFromUI='S'" AutoLoadOnDemand ="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo spedizione:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="TipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiSpedizione" Width="500px" MaxHeight="250px" SqlQueryFilter="ATTIVO = 'S'" AutoLoadOnDemand ="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo merce:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="TipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce" Width="500px" MaxHeight="250px" SqlQueryFilter="ATTIVO = 'S'" AutoLoadOnDemand ="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblVettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="Vettore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TRASPORTATORI" Width="500px" AutoLoadOnDemand="true" MaxHeight="250px" SqlQueryWhere="Attivo='S'">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="PCSPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" AutoLoadOnDemand="true" MaxHeight="250px"
                        SqlQueryWhere="PUNTODICARICO='S' OR PUNTODIPARCOVEICOLARE='S' AND Attivo='S'">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" Text="Arrivo:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="PCSArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" AutoLoadOnDemand="true" MaxHeight="250px" SqlQueryWhere="PUNTODICARICO='S' OR PUNTODIPARCOVEICOLARE='S' AND Attivo='S'">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblMotricePianificata" runat="server" Text="Motrice:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="MotricePianificata" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Motrici" Width="500px" AutoLoadOnDemand="true" MaxHeight="250px"
                        DropDownWidth="500px" SqlQueryFilter="ATTIVO = 'S'">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblContenitore1Pianificato" runat="server" Text="Contenitore:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="Contenitore1Pianificato" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Tank" Width="500px" AutoLoadOnDemand="true" MaxHeight="250px"
                        SqlQueryFilter="ATTIVO = 'S'">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>   
</asp:Content>
