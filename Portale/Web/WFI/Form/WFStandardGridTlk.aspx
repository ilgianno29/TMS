<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFStandardGridTlk.aspx.vb"
    Inherits="Incasbo.Web.WFI.WFStandardGridTlk" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" media="print" href="../css/DataGridPrint.css?d=20180913" />
    <link rel="stylesheet" type="text/css" media="screen" href="../css/DataGridTlk-min.css?d=20180913" />
    <%--<link rel="stylesheet" type="text/css" media="screen" href="../css/DataGridTlk.css?d=20180913" />--%>
    <link rel="stylesheet" type="text/css" href='<%="../../" + Me.SessionEnvironment.AppApplicationName + "/css/AppDataGrid.css?d=" + Now.Date.ToString("yyyyMMdd")%>' />
    <link rel="stylesheet" type="text/css" href='<%="../../Custom/css/CustomDataGrid.css?d=" + Now.Date.ToString("yyyyMMdd")%>' />
    <link href="../Css/Grid.css?d=20180913" rel="stylesheet" type="text/css" />
    <%--<link href="../Css/GridTlk.Default.css?d=20180913" rel="stylesheet" type="text/css" />--%>
    <link href="../Css/GridTlk.Default-min.css?d=20180913" rel="stylesheet" type="text/css" />
    <script src="../../WFI/Scripts/StdGridTlk-min.js?d=20180913" type="text/javascript"></script>
    <script type="text/javascript">
        var SelectedArray = [];
        var gridId = "<%= Me.grdGriglia.ClientID%>";

        function _MyRowContextMenu(sender, eventArgs) {
            var menu = $find("<%=Me.MasterPage.ToolBarObject.ContextMenuTlk.ClientID %>");
            var evt = eventArgs.get_domEvent();
            if (evt.target.tagName == "INPUT" || evt.target.tagName == "A") {
                return;
            }
            var index = eventArgs.get_itemIndexHierarchical();
            sender.get_masterTableView().selectItem(sender.get_masterTableView().get_dataItems()[index].get_element(), true);
            menu.show(evt);
            evt.cancelBubble = true;
            evt.returnValue = false;
            if (evt.stopPropagation) {
                evt.stopPropagation();
                evt.preventDefault();
            }
        }
        function rowContextMenu(sender, eventArgs) {
            _MyRowContextMenu(sender, eventArgs);
        }
        var ContentUpdatePanelId = "<%= Me.MasterPage.ContentUpdatePanel.ClientID%>";
        function showMenuAt(e) {
            var contextMenu = $find("<%= Me.MasterPage.ToolBarObject.ContextMenuTlk.ClientID %>");
            $telerik.cancelRawEvent(e);
            if (contextMenuIsVisible) {
                contextMenu.hide();
                contextMenuIsVisible = false;
            }
            else {
                var pos = WFI.getPosition(e.currentTarget);
                pos.y = pos.y + e.currentTarget.height + 5;
                pos.x = pos.x - 2;
                if ((!e.relatedTarget) || (!$telerik.isDescendantOrSelf(contextMenu.get_element(), e.relatedTarget))) {
                    contextMenu.showAt(pos.x, pos.y);
                    contextMenuIsVisible = true;
                }
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="pnlMain" runat="server" HorizontalAlign="Left" ScrollBars="Auto" Width="100%" Style="clear: both;">
        <div id="divDataGridPrint">
            <asp:Panel ID="pnlDataGridPrint" runat="server" Visible="false">
                <iwc:IboWebButton ID="btnPrint" runat="server" Text="Stampa" CausesValidation="false" OnClientClick="javascript:window.print()"
                    UseSubmitBehavior="false" />
                &nbsp;<iwc:IboWebButton ID="btnClosePrintingMode" runat="server" Text="Chiudi Modalità Stampa" />
            </asp:Panel>
        </div>
        <asp:Panel runat="server" ID="pnlMainGrid_Intestazione" BorderStyle="None" BorderWidth="0" ScrollBars="None" CssClass="StdGridIntestazionePanel">
            <table id="IntestazioneTable">
                <tr id="IntestazioneTableR1">
                    <td id="IntestazioneTableR1C1">
                        <iwc:IboWebLabel ID="lblTitle" runat="server" Translate="false" CssClass="StdGridTitle"></iwc:IboWebLabel>
                    </td>
                    <td id="IntestazioneTableR1C2"></td>
                </tr>
                <tr id="IntestazioneTableR2">
                    <td id="IntestazioneTableR2C1">
                        <iwc:IboWebLabel ID="lblFilter" runat="server" CssClass="lblGridFilter" Translate="false"></iwc:IboWebLabel>
                    </td>
                    <td id="IntestazioneTableR2C2">
                        <iwc:IboWebLabel ID="lblNumeroRecordTotali" runat="server" Translate="False" IncasTag="" Text="Totali:10" Visible="false"
                            ClientIDMode="Static"></iwc:IboWebLabel>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlMainGrid_Griglia" BorderStyle="None" BorderWidth="0" ScrollBars="None">
            <div id="divGrdGrigliaContainer">
                <asp:Panel ID="pnlgrd" runat="server" CssClass="WFStandardGrid_pnlGrd">
                    <asp:Panel runat="server" ID="GridHeader" CssClass="GridHeader">
                        <asp:Table ID="GridHeaderTable" runat="server" CssClass="GridHeaderTable">
                            <asp:TableRow ID="GridHeaderTableRow" runat="server">
                                <asp:TableCell ID="GridHeaderCellTitle" runat="server" CssClass="GridHeaderCellTitle">
                                    <asp:ImageButton runat="server" ID="GridHeaderCellInfo" CssClass="GridHeaderCellAction" ImageUrl="~/WFI/Images/Toolbar/24/info.png"
                                        ImageAlign="AbsMiddle" ClientIDMode="Static" ToolTip="Info shortcut di tastiera (SHIFT-H)" Visible="false" OnClick="GridHeaderCellInfo_Click" />
                                    <asp:ImageButton runat="server" ID="GridHeaderCellAction" CssClass="GridHeaderCellAction" ImageUrl="~/WFI/Images/Toolbar/24/gear.png"
                                        ImageAlign="AbsMiddle" OnClientClick="showMenuAt(event);" />
                                    <asp:Panel runat="server" ID="GridHeaderCellLegendContainer" ClientIDMode="Static" Style="display: inline-block;">
                                        <asp:ImageButton runat="server" ID="GridHeaderCellLegend" CssClass="GridHeaderCellLegend" ImageUrl="~/WFI/Images/Toolbar/24/Legenda.png"
                                            ImageAlign="AbsMiddle" ClientIDMode="Static" OnClientClick="return false;" />
                                        <ajaxToolkit:HoverMenuExtender ID="hme_GridHeaderCellLegend" BehaviorID="hme_GridHeaderCellLegend" runat="Server" TargetControlID="GridHeaderCellLegend"
                                            PopupControlID="LegendPopupMenu" HoverCssClass="" PopupPosition="Center" OffsetX="-3" OffsetY="28" PopDelay="300" HoverDelay="300">
                                            <Animations>
                                            <OnShow>
                                            <Sequence>
                                            <HideAction Visible="true" />
                                            <FadeIn duration=".3" />
                                            </Sequence>
                                            </OnShow> 
                                            <OnHide>
                                            <Sequence>
                                            <HideAction Visible="false" />
                                            <FadeOut duration=".2" />
                                            <HideAction />                                            
                                            </Sequence>
                                            </OnHide>
                                            </Animations>
                                        </ajaxToolkit:HoverMenuExtender>
                                        <asp:Panel CssClass="LegendPopupMenu" ID="LegendPopupMenu" runat="server" ClientIDMode="Static" Style="display: none;">
                                            <div class="LegendCaption">
                                                <iwc:IboWebLabel runat="server" ID="LegendCaption" Text="Legenda"></iwc:IboWebLabel>
                                            </div>
                                            <asp:Panel CssClass="LegendContentPopupMenu" ID="LegendContentPopupMenu" runat="server" ClientIDMode="Static">
                                                <asp:Panel CssClass="LegendContentPopupMenu2" ID="LegendContentPopupMenu2" runat="server" ClientIDMode="Static">
                                                </asp:Panel>
                                            </asp:Panel>
                                        </asp:Panel>
                                    </asp:Panel>
                                    <iwc:IboWebLabel runat="server" ID="GridHeaderCaption" Text="" Style="margin-left: 2px;"></iwc:IboWebLabel>
                                </asp:TableCell>
                                <asp:TableCell ID="GridHeaderIdleCell" CssClass="GridHeaderIdleCell" runat="server">
                                    <asp:CheckBox ID="chkAutoUpdate" runat="server" Text="Auto Update" TextAlign="Left" AutoPostBack="true" Style="font-weight: bold;" />
                                </asp:TableCell>
                                <asp:TableCell ID="GridHeaderCellSearchText" CssClass="GridHeaderCellSearchText" runat="server">
                                    <asp:Panel ID="GridHeaderCellSearchTextPanel" runat="server" DefaultButton="btnPagerSearchText">
                                        <iwc:IboWebLabel ID="lblPagerSearchText" CssClass="lblPagerSearchText" runat="server" Text="Cerca:"></iwc:IboWebLabel>
                                        &nbsp;<iwc:IboWebTextBox ID="txtPagerSearchText" CssClass="GridHeaderCellSearchTextTxt" runat="server" CharacterCase="Uppercase"
                                            AutoPostBack="False">&nbsp;</iwc:IboWebTextBox><asp:ImageButton ID="btnPagerSearchText" runat="server" AlternateText="Cerca"
                                                OnClick="btnSearch_Click" ImageUrl="~/WFI/images/StdGrid/24/Search.png" ToolTip="Cerca su tutti i campi della griglia" ImageAlign="AbsMiddle" CssClass="btnPagerSearchText" />
                                        <asp:ImageButton ID="btnPagerSearchSvuotaFiltro" runat="server" AlternateText="Svuota filtro"
                                            OnClick="btnSvuotaFiltro_Click" ImageUrl="~/WFI/images/StdGrid/24/SvuotaFiltro.png" CssClass="btnPagerSearchSvuotaFiltro" ToolTip="Svuota filtro" ImageAlign="AbsMiddle"
                                            Visible="false" />
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                    <telerik:RadGrid ID="grdGriglia" runat="server" AllowPaging="True" AllowSorting="True" PageSize="20" AutoGenerateColumns="False"
                        EnableEmbeddedBaseStylesheet="False" EnableEmbeddedSkins="False" ShowGroupPanel="True">
                        <PagerStyle Mode="NextPrevAndNumeric" PagerTextFormat="{4}<span id='TotaleElementiTlk' Title=''><strong>{5}</strong> Elementi in <strong>{1}</strong> pagine</span>" />
                        <%--<ClientSettings AllowDragToGroup="false">
                            <Scrolling AllowScroll="True" UseStaticHeaders="true" SaveScrollPosition="true" ScrollHeight="350px"></Scrolling>
                            <Resizing  AllowColumnResize="true" EnableRealTimeResize="True" />
                        </ClientSettings>--%>
                        <ItemStyle CssClass="rgRow DataRow" />
                        <AlternatingItemStyle CssClass="rgAltRow DataRow" />
                        <MasterTableView AllowNaturalSort="false">
                            <NoRecordsTemplate>
                                <table id="EmptyDataTemplateContainerID" class="EmptyDataTemplateContainer">
                                    <tr>
                                        <td>
                                            <div id="EmptyDataTemplateContainerInternoID" class="EmptyDataTemplateContainerInterno">
                                                <iwc:IboWebLabel CssClass="lblEmptyDataTemplate" ID="lblEmptyDataTemplate" runat="server" Text="Nessun dato trovato"></iwc:IboWebLabel>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </NoRecordsTemplate>
                            <PagerTemplate>
                                <asp:Panel runat="server" ID="pnlPagerTemplate" CssClass="PagerTemplate">
                                    <asp:Table ID="pagerTemplateTable" runat="server" CssClass="IboWebGridView_PagerBottom">
                                        <asp:TableRow ID="PagerTemplateTableRow" runat="server">
                                            <asp:TableCell ID="PagerTemplateCellTitle" runat="server" CssClass="PagerTemplateCellTitle" Visible="false">
                                                <iwc:IboWebLabel runat="server" ID="PagerTemplateTitleGrid" Text=""></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell ID="TCIdleLeft" CssClass="TCIdleLeft" runat="server">
                                        
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellGotoFirst" CssClass="GotoFirst" runat="server">
                                                <asp:ImageButton ID="imgbtnFirst" runat="server" AlternateText="First" CommandArgument="First" CommandName="Page" ImageUrl="~/images/StdGrid/24/navigate_beginning2.png"
                                                    ToolTip="Goto First Page" />
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellGotoPrevious" CssClass="GotoPrevious" runat="server">
                                                <asp:ImageButton ID="imgBtnPrevious" runat="server" AlternateText="Previous" CommandArgument="Prev" CommandName="Page" ImageUrl="~/images/StdGrid/24/navigate_left2.png"
                                                    ToolTip="Goto Previous Page" />
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellGotoNext" CssClass="GotoNext" runat="server">
                                                <asp:ImageButton ID="ImgBtnNext" runat="server" AlternateText="Next" CommandArgument="Next" CommandName="Page" ImageUrl="~/images/StdGrid/24/navigate_right2.png"
                                                    ToolTip="Goto Next Page" />
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellGotoLast" CssClass="GotoLast" runat="server">
                                                <asp:ImageButton ID="ImgBtnLast" runat="server" AlternateText="Last" CommandArgument="Last" CommandName="Page" ImageUrl="~/images/StdGrid/24/navigate_end2.png"
                                                    ToolTip="Goto Last Page" />
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellNumberOfPage" CssClass="NumberOfPage" runat="server">
                                                <iwc:IboWebLabel ID="lblPagerNumberOfPage" runat="server" Translate="false" Text="Pagina:"></iwc:IboWebLabel>
                                                &nbsp;
                                                <iwc:IboDropDownList ID="ddlPagerNumberOfPage" runat="server" Width="50px" AutoPostBack="true" OnSelectedIndexChanged="ddlPagerNumberOfPage_SelectedIndexChanged">
                                                </iwc:IboDropDownList>
                                                &nbsp;
                                                <iwc:IboWebLabel ID="lblPagerNumberOfPageOf" runat="server" Text="di"></iwc:IboWebLabel>
                                                &nbsp;
                                                <iwc:IboWebLabel ID="lblPagerNumberOfPageTotalPage" runat="server" Translate="false" Text="xxx"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellMaxRecord" CssClass="MaxRecord" runat="server">
                                                <iwc:IboWebLabel ID="lblPagerMaxRecord" runat="server" Translate="false" Text="Max Record:"></iwc:IboWebLabel>
                                                &nbsp;
                                                <iwc:IboDropDownList ID="ddlPagerMaxRecord" runat="server" Width="70px" AutoPostBack="true" OnSelectedIndexChanged="ddlPagerMaxRecord_SelectedIndexChanged">
                                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                    <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                                    <asp:ListItem Text="200" Value="200"></asp:ListItem>
                                                    <asp:ListItem Text="500" Value="500"></asp:ListItem>
                                                    <asp:ListItem Text="1000" Value="1000"></asp:ListItem>
                                                    <asp:ListItem Text="2000" Value="2000"></asp:ListItem>
                                                    <asp:ListItem Text="5000" Value="5000"></asp:ListItem>
                                                    <asp:ListItem Text="10000" Value="10000"></asp:ListItem>
                                                    <asp:ListItem Text="50000" Value="50000"></asp:ListItem>
                                                    <asp:ListItem Text="All items" Value="0"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellSearchText" CssClass="PagerTemplateCellSearchText" runat="server">
                                                <asp:Panel ID="Panel1" runat="server" DefaultButton="btnPagerSearchText" Visible="false">
                                                    <iwc:IboWebLabel ID="lblPagerSearchText" CssClass="lblPagerSearchText" runat="server" Text="Cerca:"></iwc:IboWebLabel>
                                                    &nbsp;<iwc:IboWebTextBox ID="txtPagerSearchText" runat="server" Width="130px" CharacterCase="Uppercase" AutoPostBack="False">&nbsp;</iwc:IboWebTextBox>&nbsp;<asp:ImageButton
                                                        ID="btnPagerSearchText" runat="server" AlternateText="Cerca" OnClick="btnSearch_Click" ImageUrl="~/images/StdGrid/24/Search.png"
                                                        ToolTip="Cerca su tutti i campi della griglia" ImageAlign="AbsMiddle" />
                                                </asp:Panel>
                                            </asp:TableCell>
                                            <asp:TableCell ID="PagerTemplateCellTotalRecord" runat="server" CssClass="PagerTemplateCellTotalRecord">
                                                <iwc:IboWebLabel ID="lblPagerTotalRecord" runat="server" Text="Totali:10"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:Panel>
                            </PagerTemplate>
                        </MasterTableView>
                    </telerik:RadGrid>
                </asp:Panel>
            </div>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlCommands" CssClass="pnlCommands">
            <table id="tableButtons" class="tableButtons">
                <tr>
                    <td id="tableButtons_L" class="tableButtons_L">
                        <iwc:IboWebButton ID="btnSelezionaTutto" runat="server" Text="" CssClass="DetailFormButton_SelezionaTutto" ToolTip="Seleziona Tutto" OnClientClick="gridSelectAllRow();return false;" />
                        <iwc:IboWebButton ID="btnDeselezionaTutto" runat="server" Text="" CssClass="DetailFormButton_DeselezionaTutto" ToolTip="Deseleziona Tutto" OnClientClick="gridDeselectAllRow();return false;" />
                    </td>
                    <td id="tableButtons_C" class="tableButtons_C">
                        <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" /></td>
                    <td id="tableButtons_R" class="tableButtons_R">
                        <iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlBackButton" CssClass="pnlBackButton">
            <table id="tableBackButton" class="tableBackButton">
                <tr>
                    <td id="tableBackButton_L" class="tableBackButton_L"></td>
                    <td id="tableBackButton_C" class="tableBackButton_C"></td>
                    <td id="tableBackButton_R" class="tableBackButton_R">
                        <iwc:IboWebButton ID="btnButtonBack" runat="server" Text="Torna" CssClass="Button_Back" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </asp:Panel>
    <iwc:IboWebPanel ID="pnlFiltro" runat="server" CssClass="popupDiv" Style="display: none" EscButtonId="btnFiltroAnnulla">
        <asp:Panel ID="pnlFiltro1" runat="server" Visible="false">
            <div id="popupFilterTitleBar" class="popupDragBar">
                <iwc:IboWebLabel ID="lblFiltroTitolo" runat="server" IncasTag="" CssClass="popupTitle" Text="Impostazioni del Filtro"></iwc:IboWebLabel>
            </div>
            <asp:UpdatePanel ID="UPpnlFiltro" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="popupContent">
                        <table class="popupTable">
                            <tr>
                                <td>&nbsp;
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>
                                    <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroCampoDesc" ID="lblFiltroCampoDesc" Text="Campo" runat="server"></iwc:IboWebLabel>
                                </td>
                                <td>
                                    <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroCampo" ID="lblFiltroCampo" Text="Campo" runat="server" Translate="false"></iwc:IboWebLabel>
                                    <iwc:IboDropDownList CssClass="pnlFiltro_ddlFiltroCampo" ID="ddlFiltroCampo" runat="server" AutoPostBack="True">
                                    </iwc:IboDropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroOperatore" ID="lblFiltroOperatore" Text="Operatore" runat="server"></iwc:IboWebLabel>
                                </td>
                                <td>
                                    <iwc:IboDropDownList CssClass="pnlFiltro_ddlFiltroOperatore" ID="ddlFiltroOperatore" runat="server">
                                    </iwc:IboDropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroVal" ID="lblFiltroVal" runat="server" Text="Valore"></iwc:IboWebLabel>
                                </td>
                                <td>
                                    <asp:Panel ID="pnlAddCondition" runat="server" DefaultButton="btnFiltro_Aggiungi2">
                                        <table style="padding: 0px; margin: 0px; width: 370px; border-spacing: 0px;">
                                            <tr style="padding: 0px; margin: 0px;">
                                                <td style="padding: 0px; margin: 0px;">
                                                    <iwc:IboWebNumericTlk runat="server" ID="txtFiltroNumericVal" Required="false" Text="" CssClass="pnlFiltro_txtFiltroNumericVal" DecimalDigits="5">
                                                        <%--<NumberFormat GroupSeparator="" KeepTrailingZerosOnFocus="True" ZeroPattern="n" />--%>
                                                    </iwc:IboWebNumericTlk>
                                                    <iwc:IboWebDate2 CssClass="pnlFiltro_txtFiltroDateVal" ID="txtFiltroDateVal" runat="server" ContainerAlignement="Right" ContainerWidth="200"
                                                        Translate="false" Required="false" ControlType="DateAndTime" />
                                                    <iwc:IboWebTextBox CssClass="pnlFiltro_txtFiltroStringVal" ID="txtFiltroStringVal" runat="server" Translate="false" Required="false"></iwc:IboWebTextBox>
                                                </td>
                                                <td style="padding: 0px; padding-left: 10px; margin: 0px; text-align: right;">
                                                    <iwc:IboWebButton ID="btnFiltro_Aggiungi" CssClass="pnlFiltro_Aggiungi" Text="+" runat="server" Translate="false" />
                                                    <iwc:IboWebButton ID="btnFiltro_Aggiungi2" CssClass="pnlFiltro_Aggiungi" CommandArgument="CONFERMA" Text="" runat="server"
                                                        Translate="false" Style="width: 0px; height: 0px; border: 0px; position: absolute; top: 0px; left: 0px;" />
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroTot" ID="lblFiltroTot" runat="server" Text="Filtro"></iwc:IboWebLabel>
                                </td>
                                <td>
                                    <table style="padding: 0px; margin: 0px; width: 370px; border-spacing: 0px;">
                                        <tr style="padding: 0px; margin: 0px;">
                                            <td style="padding: 0px; margin: 0px;">
                                                <asp:ListBox ID="lstFiltroTot" CssClass="pnlFiltro_lstFiltroTot" runat="server" Rows="5"></asp:ListBox>
                                            </td>
                                            <td style="padding: 0px; padding-left: 10px; margin: 0px; text-align: right;">
                                                <iwc:IboWebButton ID="btnFiltro_Elimina" CssClass="pnlFiltro_Elimina" Text="-" runat="server" Translate="False" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="popupButtons">
                <table class="tableButtons">
                    <tr>
                        <td class="tableButtons_L">
                            <iwc:IboWebButton ID="Ibowebbutton1Idle" Text="Conferma" runat="server" Style="display: none;" />
                            <iwc:IboWebButton ID="btnFiltroAnnulla" CssClass="pnlFiltro_btnFiltroAnnulla" Text="Esci" runat="server" />
                        </td>
                        <td class="tableButtons_R">
                            <iwc:IboWebButton ID="btnFiltroConferma" CssClass="pnlFiltro_btnFiltroConferma" Text="Conferma" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
    </iwc:IboWebPanel>
    <ajaxToolkit:ModalPopupExtender runat="server" ID="popFiltro" TargetControlID="hiddenTargetControlForModalPopup" PopupControlID="pnlFiltro"
        BackgroundCssClass="popupBack" RepositionMode="RepositionOnWindowResize" Drag="True" PopupDragHandleControlID="popupFilterTitleBar"
        DropShadow="true">
    </ajaxToolkit:ModalPopupExtender>
    <iwc:IboWebPanel ID="pnlExport" runat="server" CssClass="popupDiv" Style="display: none" EscButtonId="btnExportAnnulla">
        <div id="popupExportTitleBar" class="popupDragBar">
            <iwc:IboWebLabel ID="lblExportTitle" runat="server" IncasTag="" CssClass="popupTitle" Text="Opzioni di Esportazione">
            </iwc:IboWebLabel>
        </div>
        <div class="popupContent">
            <table class="popupTable">
                <tr>
                    <td>
                        <iwc:IboWebRadioButtonList runat="server" ID="rdbExportFormat" CssClass="popupContentList" Translate="false">
                            <asp:ListItem Text="Esporta in un file XML" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Esporta in un file di testo (*.TXT)" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Esporta in un file di Excel (*.CSV)" Selected="True" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Esporta in un file DIF (*.DIF)" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Esporta in un file PDF (*.PDF)" Value="4"></asp:ListItem>
                            <asp:ListItem Text="Esporta in un file HTML (*.HTML)" Value="5"></asp:ListItem>
                            <asp:ListItem Text="Esporta in un file XLS (*.XLS)" Value="6"></asp:ListItem>
                            <asp:ListItem Text="Esporta in un file DOC (*.DOC)" Value="7"></asp:ListItem>
                        </iwc:IboWebRadioButtonList>
                    </td>
                </tr>
            </table>
        </div>
        <div class="popupButtons">
            <table class="tableButtons">
                <tr>
                    <td class="tableButtons_L">
                        <iwc:IboWebButton ID="btnExportAnnulla" CssClass="pnlExport_btnFiltroAnnulla" Text="Esci" runat="server" />
                    </td>
                    <td class="tableButtons_R">
                        <iwc:IboWebButton ID="btnExportConferma" CssClass="pnlExport_btnFiltroConferma" Text="Conferma" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </iwc:IboWebPanel>
    <ajaxToolkit:ModalPopupExtender runat="server" ID="popExport" TargetControlID="hiddenTargetControlForModalPopup2" PopupControlID="pnlExport"
        BackgroundCssClass="popupBack" RepositionMode="RepositionOnWindowResize" Drag="True" PopupDragHandleControlID="popupExportTitleBar"
        DropShadow="true">
    </ajaxToolkit:ModalPopupExtender>
    <asp:Button runat="server" ID="hiddenTargetControlForModalPopup" Style="display: none" />
    <asp:Button runat="server" ID="hiddenTargetControlForModalPopup2" Style="display: none" />
    <asp:HiddenField ID="hidToolbarVisible" runat="server" Value="True" />
    <asp:HiddenField ID="hdnShortCuts" runat="server" Value="A=AGGIORNA;E=EXPDATI;F=RICERCA;P=STAMPA;X=ANNULLAFILTRI;" ClientIDMode="Static" />
    <asp:HiddenField ID="hdnShortCutsWithCTRL" runat="server" ClientIDMode="Static" />
    <asp:Timer ID="tmrUpdate" runat="server" Enabled="False">
    </asp:Timer>
</asp:Content>
