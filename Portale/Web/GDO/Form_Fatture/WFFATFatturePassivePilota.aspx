<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFFATFatturePassivePilota.aspx.vb" Inherits="Incasbo.Web.GDO.WFFATFatturePassivePilota" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/Css/WFFATFatturePassivePilota.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr>
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag=""></iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1150px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpByQuery_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpByQuery_Title_Caption" Text="Trasportatori" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpByQuery_Body" CssClass="CollapsiblePanelBody">
                                    <asp:UpdatePanel ID="UP_pnlTrasportatori" ChildrenAsTriggers="true" UpdateMode="Conditional" runat="server">
                                        <ContentTemplate>
                                            <asp:Panel runat="server" ID="pnlTrasportatori" ClientIDMode="Static">
                                                <asp:Panel runat="server" ID="pnlTrasportatoriDisponibili" ClientIDMode="Static" DefaultButton="btnFiltro">
                                                    <iwc:IboWebLabel runat="server" ID="lblTrasportatoriDisponibili" Text="Elenco Trasportatori"></iwc:IboWebLabel>
                                                    <iwc:IboWebTextBox runat="server" ID="ElencoTrasportatoriFiltro" ClientIDMode="Static" ToolTip="Filtro"></iwc:IboWebTextBox>
                                                    <iwc:IboWebButton runat="server" ID="btnFiltro" Text="Filtra" ClientIDMode="Static" /><br />
                                                    <asp:ListBox runat="server" ID="ElencoTrasportatori" ClientIDMode="Static" SelectionMode="Multiple"></asp:ListBox>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlSposta" ClientIDMode="Static">
                                                    <iwc:IboWebButton runat="server" ID="btnAggiungi" Text="Aggiungi" ClientIDMode="Static" /><br />
                                                    <iwc:IboWebButton runat="server" ID="btnTogli" Text="Togli" ClientIDMode="Static" />
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlElencoTrasportatoriDaFatturare" ClientIDMode="Static">
                                                    <iwc:IboWebLabel runat="server" ID="lblElencoTrasportatoriSelezionati" Text="Elenco Trasportatori Selezionati"></iwc:IboWebLabel><br />
                                                    <asp:ListBox runat="server" ID="ElencoTrasportatoriDaFatturare" ClientIDMode="Static" SelectionMode="Multiple"></asp:ListBox>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlComandi" ClientIDMode="Static">
                                                </asp:Panel>
                                            </asp:Panel>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Filtri" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataInizio" runat="server" Text="Da Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebDate runat="server" ID="txtDataInizio" Width="80px" ControlType="DateOnly" Required="true" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblDataFine" runat="server" Text="A Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 252px">
                                                <iwc:IboWebDate runat="server" ID="txtDataFine" Width="80px" ControlType="DateOnly" Required="true" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblFatturaViaggi" runat="server" Text="Fattura Viaggi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 30px">
                                                <iwc:IboWebCheckBox ID="chkFatturaViaggi" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblFatturaSpedizioni" runat="server" Text="Fattura Spedizioni:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 30px">
                                                <iwc:IboWebCheckBox ID="chkFatturaSpedizioni" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                <iwc:IboWebLabel ID="lblFatturaContrassegni" runat="server" Text="Fattura contrassegni:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 30px">
                                                <iwc:IboWebCheckBox ID="chkFatturaContrassegni" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 98px">
                                                <iwc:IboWebLabel ID="lblFatturaGiacenze" runat="server" Text="Fattura giacenze:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 30px">
                                                <iwc:IboWebCheckBox ID="chkFatturaGiacenze" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDataDocumento" runat="server" IncasTag="" Text="Data Documento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebDate runat="server" ID="txtDataDocumento" Width="80px" ControlType="DateOnly" Required="true" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                <iwc:IboWebLabel ID="lblSezionale" runat="server" IncasTag="" Text="Sezionale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 252px;">
                                                <iwc:IboWebComboTlk ID="cmbSezionale" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_SEZIONALI" Width="247px" Required="true" SqlQueryFilter="AttivoPassivo='P'">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoPagamento" runat="server" IncasTag="" Text="Tipo Pagamento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 440px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoPagamento" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_CODICIPAGAMENTO"
                                                    Width="435px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblClienteOperativo" runat="server" IncasTag="" Text="Cliente Operativo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 440px;">
                                                <iwc:IboWebComboTlk ID="cmbClienteOperativo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori_ALL"
                                                    Width="435px" AutoLoadOnDemand="True" DropDownWidth="820px">
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

                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" IncasTag="" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 440px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE" Width="435px" AutoLoadOnDemand="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" IncasTag="" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 440px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Width="435px" AutoLoadOnDemand="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" IncasTag="" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 440px;">
                                                <iwc:IboWebComboTlk ID="cmbZonaArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_ZONESPEDIZIONE" Width="435px" AutoLoadOnDemand="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" IncasTag="" Text="PCS Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 440px;">
                                                <iwc:IboWebComboTlk ID="cmbPCSPartenza" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza"
                                                    Width="435px" AutoLoadOnDemand="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" IncasTag="" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 440px;">
                                                <iwc:IboWebComboTlk ID="cmbPCSArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PuntiArrivo" Width="435px" AutoLoadOnDemand="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <%-- <iwc:IboWebTextBox ID="txtDataOraInizioEsecuzione" runat="server" CssClass="hidden"></iwc:IboWebTextBox>--%>
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
