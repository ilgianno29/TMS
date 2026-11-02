<%@ Page Title="Gestione tabella Allgrd" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFCFGSqlInsert.aspx.vb" Inherits="Incasbo.Web.CFG.WFCFGSqlInsert" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <link href="../Css/WFCFGSqlInsert.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" align="center">
        <table class="DetailFormMainTable">
            <tr align="left" style="display: none;">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" IncasTag=""></iwc:IboWebLabel>
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
            <tr align="left">
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1050px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="false" AutoPostBack="true" TabStripPlacement="Top" CssClass="WFITab"
                                ScrollBars="Auto" UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpTabella" runat="server" Enabled="true" ScrollBars="Auto">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpTabellaCaption" Text="Per tabella"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Sql Inserts Generator" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                                <asp:Panel runat="server" ID="pnlTables" ClientIDMode="Static">
                                                    <asp:Panel runat="server" ID="pnlElencoTabelleDisponibili" ClientIDMode="Static" DefaultButton="btnFiltro">
                                                        <iwc:IboWebLabel runat="server" ID="lblElencoTabelleDisponibili" Text="Elenco Tabelle disponibili"></iwc:IboWebLabel><br />
                                                        <iwc:IboWebTextBox runat="server" ID="ElencoTabelleFiltro" ClientIDMode="Static" ToolTip="Filtro"></iwc:IboWebTextBox>
                                                        <iwc:IboWebButton runat="server" ID="btnFiltro" Text="Filtra" ClientIDMode="Static" /><br />
                                                        <asp:ListBox runat="server" ID="ElencoTabelle" ClientIDMode="Static" SelectionMode="Multiple"></asp:ListBox>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlSposta" ClientIDMode="Static">
                                                        <iwc:IboWebButton runat="server" ID="btnAggiungi" Text="Aggiungi" ClientIDMode="Static" /><br />
                                                        <iwc:IboWebButton runat="server" ID="btnTogli" Text="Togli" ClientIDMode="Static" /><br />
                                                        <iwc:IboWebButton runat="server" ID="btnSpostaSu" Text="Sposta su" ClientIDMode="Static" /><br />
                                                        <iwc:IboWebButton runat="server" ID="btnSpostaGiu" Text="Sposta giu" ClientIDMode="Static" />
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlServerType" ClientIDMode="Static">
                                                        <iwc:IboWebRadioButtonList runat="server" ID="ServerType" RepeatDirection="Horizontal">
                                                            <asp:ListItem Value="SQL" Text="Sql Server"></asp:ListItem>
                                                            <asp:ListItem Value="ORACLE" Text="Oracle"></asp:ListItem>
                                                            <asp:ListItem Value="BOTH" Text="Entrambi"></asp:ListItem>
                                                        </iwc:IboWebRadioButtonList>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlElencoTabelleDaEsportare" ClientIDMode="Static">
                                                        <iwc:IboWebLabel runat="server" ID="lblElencoTabelleSelezionate" Text="Elenco Tabelle selezionate"></iwc:IboWebLabel><br />
                                                        <asp:ListBox runat="server" ID="ElencoTabelleDaEsportare" ClientIDMode="Static" SelectionMode="Multiple"></asp:ListBox>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlComandi" ClientIDMode="Static">
                                                        <iwc:IboWebButton runat="server" ID="btnGo" Text="Run query" ClientIDMode="Static" />
                                                    </asp:Panel>
                                                </asp:Panel>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpQuery" runat="server" Enabled="true" ScrollBars="Auto">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpQueryCaption" Text="Per Query"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpByQuery_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpByQuery_Title_Caption" Text="Sql Inserts Generator" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                <asp:Image runat="server" ID="cpByQuery_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpByQuery_Body" CssClass="CollapsiblePanelBody">
                                                <asp:Panel runat="server" ID="pnlQueryText" ClientIDMode="Static">
                                                    <iwc:IboWebTextBox runat="server" ID="QueryText" ClientIDMode="Static" Rows="6" TextMode="MultiLine" MaxLength="4000"></iwc:IboWebTextBox>
                                                    <asp:Panel runat="server" ID="pnlQueryServerType" ClientIDMode="Static">
                                                        <iwc:IboWebRadioButtonList runat="server" ID="QueryServerType" RepeatDirection="Vertical">
                                                            <asp:ListItem Value="SQL" Text="Sql Server"></asp:ListItem>
                                                            <asp:ListItem Value="ORACLE" Text="Oracle"></asp:ListItem>
                                                            <asp:ListItem Value="BOTH" Text="Entrambi"></asp:ListItem>
                                                        </iwc:IboWebRadioButtonList>
                                                    </asp:Panel>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlQuery" ClientIDMode="Static">
                                                    <asp:Panel runat="server" ID="pnlElencoQueryDisponibili" ClientIDMode="Static">
                                                        <asp:ListBox runat="server" ID="ElencoQuery" ClientIDMode="Static" SelectionMode="Multiple"></asp:ListBox>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlQuerySposta" ClientIDMode="Static">
                                                        <iwc:IboWebButton runat="server" ID="btnAggiungiQuery" Text="Aggiungi" ClientIDMode="Static" /><br />
                                                        <iwc:IboWebButton runat="server" ID="btnTogliQuery" Text="Togli" ClientIDMode="Static" /><br />
                                                        <iwc:IboWebButton runat="server" ID="btnSpostaSuQuery" Text="Sposta su" ClientIDMode="Static" /><br />
                                                        <iwc:IboWebButton runat="server" ID="btnSpostaGiuQuery" Text="Sposta giu" ClientIDMode="Static" />
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlQueryComandi" ClientIDMode="Static">
                                                        <iwc:IboWebButton runat="server" ID="btnQueryGo" Text="Run query" ClientIDMode="Static" />
                                                    </asp:Panel>
                                                </asp:Panel>
                                            </asp:Panel>
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
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <iwc:IboWebButton runat="server" ID="btnEsportaWFI" Text="Esporta tutto il WFI" ClientIDMode="Static" />
                                    <iwc:IboWebButton runat="server" ID="btnEsportaTutto" Text="Esporta tutta la config." ClientIDMode="Static" />
                                </td>
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
