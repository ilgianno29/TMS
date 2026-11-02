<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCSpedizioni.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCSpedizioni" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFDOCSpedizioni.css" type="text/css" />
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
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="false" AutoPostBack="false"
                                TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto" UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Testata"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpTestata_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpTestata_Body" CssClass="CollapsiblePanelBody">
                                                <asp:Panel runat="server" ID="pnlEstremiSpedizioneTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                    <iwc:IboWebLabel ID="lblEstremiSpedizioneTitle" runat="server" Text="Estremi della spedizione"></iwc:IboWebLabel>
                                                </asp:Panel>
                                                <asp:UpdatePanel ID="up_EstremiSpedizione" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <asp:Panel runat="server" ID="pnlEstremiSpedizioneBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                        <iwc:IboWebLabel ID="lblUnibol" runat="server" Text="Num. Sped.:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 130px">
                                                                        <iwc:IboWebTextBox ID="txtUnibol" runat="server" MaxLength="10" Width="123px" Required="True" IncasTag="IdentityCounterName=COUNTERS.SPEDIZIONI" FieldName="Unibol"
                                                                            Translate="True"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebHidden runat="server" ID="HFCountOfSubSpedizioni" />
                                                                        <iwc:IboWebHidden runat="server" ID="HFSpedizioneMadre" />
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 81px">
                                                                        <iwc:IboWebLabel ID="lblProgressivoConsegna" runat="server" Text="Consegna:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 40px">
                                                                        <iwc:IboWebNumericTlk runat="server" ID="ProgressivoConsegna" Required="True" Width="30px"
                                                                            ReadOnly="True" DecimalDigits="0" FieldName="ProgressivoConsegna">
                                                                        </iwc:IboWebNumericTlk>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 110px">
                                                                        <iwc:IboWebLabel ID="lblPreBolla" runat="server" Text="Pre-Bolla:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 80px">
                                                                        <iwc:IboWebRadioButtonList ID="optPreBolla" runat="server" RepeatDirection="Horizontal" Required="True"
                                                                            FieldName="PreBolla">
                                                                            <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                                            <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                                        </iwc:IboWebRadioButtonList>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 103px">
                                                                        <iwc:IboWebLabel ID="lblStato" runat="server" Text="Stato:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 200px">
                                                                        <iwc:IboDropDownList ID="cmbStato" runat="server" CharacterCase="Uppercase" SqlQuery="SELECT * FROM CBO_DOC_Spedizioni_Stato"
                                                                            Width="200px" Required="True" FieldName="Stato" Translate="True" ReadOnly="True">
                                                                        </iwc:IboDropDownList>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 105px">
                                                                        <iwc:IboWebLabel ID="lblDataSpedizione" runat="server" Text="Data spediz:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 110px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataSpedizione" Width="75px" FieldDescription="Data Spedizione" ControlType="DateOnly" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                        <iwc:IboWebLabel ID="lblNumeroBolla" runat="server" Text="Num. DDT:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 130px">
                                                                        <iwc:IboWebTextBox ID="txtNumeroBolla" runat="server" MaxLength="30" Width="123px"
                                                                            FieldName="NumeroBolla" FieldDescription="Numero DDT" Translate="True"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 81px">
                                                                        <iwc:IboWebLabel ID="lblDataBolla" runat="server" Text="Data DDT:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataBolla" Width="75px" FieldDescription="Data DDT" ControlType="DateOnly" />
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 221px">
                                                                        <iwc:IboWebLabel ID="lblTipoServizio" runat="server" Text="Tipo Servizio:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 200px">
                                                                        <iwc:IboDropDownList ID="cmbTipoServizio" runat="server" CharacterCase="Uppercase" SqlQuery="SELECT * FROM CBO_ANA_TIPISERVIZI"
                                                                            Width="200px" Required="True" Translate="True" FieldName="TipoServizio" ReadOnly="true">
                                                                        </iwc:IboDropDownList>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 105px">
                                                                        <iwc:IboWebLabel ID="lblNumeroOrdineCliente" runat="server" Text="Num. Ord. Cliente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebTextBox ID="txtNumeroOrdineCliente" runat="server" MaxLength="30"
                                                                            Width="123px" FieldName="NumeroOrdineCliente" Translate="True"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                        <iwc:IboWebLabel ID="lblNumeroOrdine" runat="server" Text="Num. Ordine:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 130px">
                                                                        <iwc:IboWebTextBox ID="txtNumeroOrdine" runat="server" MaxLength="30" Width="123px" FieldName="NumeroOrdine" Translate="True"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 81px">
                                                                        <iwc:IboWebLabel ID="lblDataOrdine" runat="server" Text="Data Ordine:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataOrdine" Width="75px" ControlType="DateOnly" />
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 221px">
                                                                        <iwc:IboWebLabel ID="lblStatoWMS" runat="server" Text="Stato WMS:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 200px">
                                                                        <iwc:IboDropDownList ID="cmbStatoWMS" runat="server" CharacterCase="Uppercase" SqlQuery="SELECT * FROM CBO_DOC_Spedizioni_StatoWMS"
                                                                            Width="200px" Required="True" Translate="True" FieldName="StatoWMS" ReadOnly="true">
                                                                        </iwc:IboDropDownList>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 105px">
                                                                        <iwc:IboWebLabel ID="lblDataOrdineCliente" runat="server" Text="Data Ord. Cliente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataOrdineCliente" Width="75px" ControlType="DateOnly" />
                                                                    </td>
                                                                </tr>
                                                            </table>

                                                        </asp:Panel>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                                <asp:Panel runat="server" ID="pnlIntestazioniBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                    <asp:Panel runat="server" ID="pnlIntestazioniBodyLeft" ClientIDMode="Static">
                                                        <asp:Panel runat="server" ID="pnlDatiMittenteTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblDatiMittente" runat="server" Text="Dati del Mittente"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_DatiMittente" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlDatiMittenteBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" AutoPostBack="True"
                                                                                    Required="True" Width="445px" AutoLoadOnDemand="True" FieldName="Cliente" DropDownWidth="820px">
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
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblClienteFatturazione" runat="server" Text="Cliente di Fatt.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebComboTlk ID="cmbClienteFatturazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" AutoPostBack="True"
                                                                                    Required="True" Width="445px" AutoLoadOnDemand="True" FieldName="ClienteFatturazione"
                                                                                    DropDownWidth="820px" Culture="it-IT">
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
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblMittente" runat="server" Text="Mittente:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebComboTlk ID="cmbMittente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_MITTENTI" AutoPostBack="True"
                                                                                    Width="445px" AutoLoadOnDemand="True" FieldName="Mittente" DropDownWidth="820px"
                                                                                    Culture="it-IT">
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
                                                                                <iwc:IboWebTextBox runat="server" ID="txtMittenteRagioneSociale" Display="false"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                        <asp:Panel runat="server" ID="pnlPartenzaDellaMerceTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblPartenzaDellaMerce" runat="server" Text="Luogo di partenza"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_PartenzaDellaMerce" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlPartenzaDellaMerceBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblPCSPArtenza" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebComboTlk ID="cmbPCSPArtenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                                                    Required="True" AutoPostBack="True" Width="447px" AutoLoadOnDemand="True" SqlQueryWhere="PUNTODICARICO = 'S'"
                                                                                    DropDownWidth="820px" Culture="it-IT" FieldName="PCSPArtenza">
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
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                                <iwc:IboWebLabel ID="lbPCSPArtenzalIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 449px;">
                                                                                <iwc:IboWebTextBox ID="txtPCSPartenza_Indirizzo" runat="server" MaxLength="60" Width="440px" ToolTip="Indirizzo (via, piazza, ...)" FieldName="PCSPartenza_Indirizzo"
                                                                                    ReadOnly="true"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td style="width: 90px;"></td>
                                                                            <td class="DetailFormValueCell" style="width: 450px;">
                                                                                <iwc:IboWebTextBox ID="txtPCSPartenza_Cap" runat="server" MaxLength="10" Width="45px" ToolTip="Cap" ReadOnly="true"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebTextBox ID="txtPCSPartenza_Localita" runat="server" MaxLength="60" Width="300px" ToolTip="Località" ReadOnly="true"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebTextBox ID="txtPCSPartenza_Provincia" runat="server" MaxLength="3" Width="30px" ToolTip="Provincia" ReadOnly="true"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebTextBox ID="txtPCSPartenza_Nazione" runat="server" MaxLength="6" Width="30px" ToolTip="Nazione" ReadOnly="true"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblDataRitiroPrevista1" runat="server" Text="Data Ritiro da:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 130px">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtDataRitiroPrevista1" Width="75px" ControlType="DateOnly" />
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblDataRitiroPrevista2" runat="server" Text="Data Ritiro a:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtDataRitiroPrevista2" Width="75px" ControlType="DateOnly" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblNoteRitiro" runat="server" Text="Note Ritiro:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebTextBox ID="txtNoteRitiroPrevisto" runat="server" MaxLength="255" Width="440px"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed" style="display: none;">
                                                                        <tr>

                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblOraRitiroConcordata1" runat="server" Text="da ora:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 130px">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtOraRitiroConcordata1" TimeControlWidth="40px" ControlType="TimeOnly" FormatoOra="HH:mm" />
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblOraRitiroConcordata2" runat="server" Text="a ora:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtOraRitiroConcordata2" TimeControlWidth="40px" ControlType="TimeOnly" FormatoOra="HH:mm" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed" style="display: none;">
                                                                        <tr>

                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblRiferimentoRitiroConcordata" runat="server" Text="Rif. Ritiro Conc.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebTextBox ID="txtRiferimentoRitiroConcordata" runat="server" MaxLength="255" Width="440px"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed" style="display: none;">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblNoteRitiroConcordata" runat="server" Text="Note Ritiro Conc.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebTextBox ID="txtNoteRitiroConcordata" runat="server" MaxLength="255" Width="440px"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                                <iwc:IboWebTextBox ID="PCSPartenza_RagSoc" runat="server" CssClass="hidden" FieldName="PCSPartenza_RagSoc"></iwc:IboWebTextBox>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                        <asp:Panel runat="server" ID="pnlDestinazioneMerceTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblDestinazioneMerceTitle" runat="server" Text="Destinazione della merce"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_DestinazioneMerce" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlDestinazioneMerceBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblPCSDEstinazione" runat="server" Text="Destinazione:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebComboTlk ID="cmbPCSDestinazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                                                    Required="True" AutoPostBack="True" Width="447px" AutoLoadOnDemand="True" SqlQueryWhere="PUNTODIDESTINO = 'S'"
                                                                                    DropDownWidth="820px" FieldName="PCSDestinazione">
                                                                                    <HeaderTemplate>
                                                                                        <ul>
                                                                                            <li class="ComboCol" style="width: 80px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="Col1" Text="Codice"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 245px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="Col2" Text="Ragione Sociale"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 180px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col3" Text="Indirizzo"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 180px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col4" Text="Localita"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 30px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col5" Text="Pr."></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 35px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col6" Text="Naz."></iwc:IboWebLabel></li>
                                                                                        </ul>
                                                                                    </HeaderTemplate>
                                                                                    <ItemTemplate>
                                                                                        <ul>
                                                                                            <li class="ComboCol" style="width: 80px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Codice")%></li>
                                                                                            <li class="ComboCol" style="width: 245px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "RagioneSociale")%></li>
                                                                                            <li class="ComboCol" style="width: 180px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Indirizzo")%></li>
                                                                                            <li class="ComboCol" style="width: 180px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Localita")%></li>
                                                                                            <li class="ComboCol" style="width: 30px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Provincia")%></li>
                                                                                            <li class="ComboCol" style="width: 35px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Nazione")%></li>
                                                                                        </ul>
                                                                                    </ItemTemplate>
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                                <iwc:IboWebLabel ID="lbPCSDestinazionelIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px;">
                                                                                <iwc:IboWebTextBox ID="txtPCSDestinazione_Indirizzo" runat="server" MaxLength="60" Width="440px" ToolTip="Indirizzo (via, piazza, ...)" FieldName="PCSDestinazione_Indirizzo"
                                                                                    ReadOnly="true"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td style="width: 90px;"></td>
                                                                            <td class="DetailFormValueCell" style="width: 450px;">
                                                                                <iwc:IboWebTextBox ID="txtPCSDestinazione_Cap" runat="server" MaxLength="10" Width="45px" ToolTip="Cap" ReadOnly="true"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebTextBox ID="txtPCSDestinazione_Localita" runat="server" MaxLength="60" Width="300px" ToolTip="Località" ReadOnly="true"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebTextBox ID="txtPCSDestinazione_Provincia" runat="server" MaxLength="3" Width="30px" ToolTip="Provincia" ReadOnly="true"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebTextBox ID="txtPCSDestinazione_Nazione" runat="server" MaxLength="6" Width="30px" ToolTip="Nazione" ReadOnly="true"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <hr class="Separatore" />
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblDataConsegnaPrevista1" runat="server" Text="Cons.Prev.da:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 130px">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtDataConsegnaPrevista1" Width="75px" ControlType="DateOnly" />
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblDataConsegnaPrevista2" runat="server" Text="Cons.Prev. a:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 110px">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtDataConsegnaPrevista2" Width="75px" ControlType="DateOnly" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblNoteConsegna" runat="server" Text="Note Consegna:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebTextBox ID="txtNoteConsegnaPrevista" runat="server" MaxLength="255" Width="440px"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <hr class="Separatore" />
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblDataConsegnaConcordata" runat="server" Text="Cons.Conc.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 130px">
                                                                                <iwc:IboWebDate runat="server" ID="txtDataConsegnaConcordata" Width="75px" ControlType="DateOnly" />
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblOraConsegnaConcordata1" runat="server" Text="dalle ore:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 60px">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtOraConsegnaConcordata1" TimeControlWidth="40px" ControlType="TimeOnly" FormatoOra="HH:mm" />
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 105px">
                                                                                <iwc:IboWebLabel ID="lblOraConsegnaConcordata2" runat="server" Text="alle ore:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 60px">
                                                                                <iwc:IboWebDate2 runat="server" ID="txtOraConsegnaConcordata2" TimeControlWidth="40px" ControlType="TimeOnly" FormatoOra="HH:mm" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblRiferimentoConsegnaConcordata" runat="server" Text="Rif.Cons. Conc.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebTextBox ID="txtRiferimentoConsegnaConcordata" runat="server" MaxLength="255" Width="440px"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblNoteConsegnaConcordata" runat="server" Text="Note Cons.Conc.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 450px">
                                                                                <iwc:IboWebTextBox ID="txtNoteConsegnaConcordata" runat="server" MaxLength="225" Width="440px"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                                <iwc:IboWebTextBox ID="PCSDestinazione_RagSoc" runat="server" CssClass="hidden" FieldName="PCSDestinazione_RagSoc"></iwc:IboWebTextBox>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlIntestazioniBodyRight" ClientIDMode="Static">
                                                        <asp:Panel runat="server" ID="pnlGestioneOperativaTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblGestioneOperativa" runat="server" Text="Gestione Operativa"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_GetioneOperativa" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlGestioneOperativaBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="T.Sped. Att/Pass:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 229px">
                                                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE "
                                                                                    Required="True" Width="223px" AutoPostBack="true" FieldName="TipoSpedizione">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 229px">
                                                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizionePassivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE "
                                                                                    Width="223px" FieldName="TipoSpedizionePassivo">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:" IncasTag=""></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 462px">
                                                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE"
                                                                                    Width="456px">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblZonaSpedizione" runat="server" Text="Zona di Sped.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 462px">
                                                                                <iwc:IboWebComboTlk ID="cmbZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONESPEDIZIONE"
                                                                                    Required="True" Width="456px" AutoLoadOnDemand="True" Culture="it-IT" FieldName="ZonaSpedizione">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblZonaPartenzaTariffaAttiva" runat="server" Text="Part/Arr Attiva:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 229px">
                                                                                <iwc:IboWebComboTlk ID="cmbZonaPartenzaTariffaAttiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONETARIFFAATTIVA"
                                                                                    Required="True" Width="223px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="True" FieldName="ZonaPartenzaTariffaAttiva">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 229px">
                                                                                <iwc:IboWebComboTlk ID="cmbZonaArrivoTariffaAttiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONETARIFFAATTIVA"
                                                                                    Required="True" Width="223px" AutoLoadOnDemand="True" FieldName="ZonaArrivoTariffaAttiva">
                                                                                </iwc:IboWebComboTlk>

                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblZonaArrivoTariffaAttiva" runat="server" Text="Part/Arr Passiva:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 229px">
                                                                                <iwc:IboWebComboTlk ID="cmbZonaPartenzaTariffaPassiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONETARIFFAPassiva"
                                                                                    Width="223px" AutoLoadOnDemand="True" FieldName="ZonaPartenzaTariffaPassiva">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 229px">
                                                                                <iwc:IboWebComboTlk ID="cmbZonaArrivoTariffaPassiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONETARIFFAPassiva"
                                                                                    Required="True" Width="223px" AutoLoadOnDemand="True" FieldName="ZonaArrivoTariffaPassiva">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                        <asp:Panel runat="server" ID="pnlCaratteristicheDellaMerceTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblCaratteristicheDellaMerce" runat="server" Text="Caratteristiche Della Merce"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_CaratteristicheDellaMerce" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlCaratteristicheDellaMerceBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblPeso" runat="server" IncasTag="" Text="Peso"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtPeso" Required="True" Width="80px"
                                                                                    FieldName="Peso" Value="0" DecimalDigits="3">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                                <iwc:IboWebLabel ID="lblColli" runat="server" IncasTag="" Text="Colli"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtColli" Required="True" Width="80px"
                                                                                    DecimalDigits="0" FieldName="Colli">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblPallet" runat="server" IncasTag="" Text="Pallet"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtPallet" Required="True" Width="80px"
                                                                                    DecimalDigits="0" FieldName="Pallet">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblVolume" runat="server" IncasTag="" Text="Volume"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtVolume" Required="True" Width="80px"
                                                                                    DecimalDigits="5" FieldName="Volume">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                                <iwc:IboWebLabel ID="lblContrassegno" runat="server" Text="Contrassegno"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtContrassegno" Required="True" Width="80px" DecimalDigits="2" FieldName="Contrassegno" Value="0">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <hr class="Separatore" />
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo1" runat="server" IncasTag="" Text="Campo Calcolo 1"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo1" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo1">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo2" runat="server" IncasTag="" Text="Campo Calcolo 2"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo2" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo2">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo3" runat="server" IncasTag="" Text="Campo Calcolo3"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo3" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo3">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo4" runat="server" IncasTag="" Text="Campo Calcolo4"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo4" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo4">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo5" runat="server" IncasTag="" Text="Campo Calcolo 5"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo5" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo5">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo6" runat="server" IncasTag="" Text="Campo Calcolo 6"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo6" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo6">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>

                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo7" runat="server" IncasTag="" Text="Campo Calcolo 7"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo7" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo7">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo8" runat="server" IncasTag="" Text="Campo Calcolo 8"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo8" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo8">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo9" runat="server" IncasTag="" Text="Campo Calcolo 9"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo9" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo9">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>

                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblCampoCalcolo10" runat="server" IncasTag="" Text="Campo Calcolo 10"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo10" Required="True" Width="80px"
                                                                                    FieldName="CampoCalcolo10">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                                <iwc:IboWebLabel ID="lblTassatoAttivo" runat="server" IncasTag="" Text="Tassato attivo"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtTassatoAttivo" Required="False" Width="80px" Value="0" DecimalDigits="3" ReadOnly="true">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblTassatoPassivo" runat="server" IncasTag="" Text="Tassato passivo"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 90px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtTassatoPassivo" Required="False" Width="80px" Value="0" DecimalDigits="3" ReadOnly="true">
                                                                                </iwc:IboWebNumericTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>


                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                        <asp:Panel runat="server" ID="pnlRiferimentiTrasportoTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblRiferimentiTrasportoTitle" runat="server" Text="Riferimenti del trasporto"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel runat="server" ID="up_corrispondente" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="Panel2" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 462px">
                                                                                <iwc:IboWebComboTlk ID="cmbCorrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CORRISPONDENTI" Width="456px" SqlQueryOrderBy="DESCRIZIONE" AutoLoadOnDemand="True"
                                                                                    AutoPostBack="true">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 462px">
                                                                                <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TRASPORTATORI" Width="456px" AutoLoadOnDemand="True" ReadOnly="true">
                                                                                </iwc:IboWebComboTlk>
                                                                                <iwc:IboWebHidden runat="server" ID="txtVettore" FieldName="Vettore" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblIdViaggio" runat="server" Text="IdViaggio:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 70px;">
                                                                                <iwc:IboWebTextBox ID="txtIdViaggio" runat="server" CharacterCase="Uppercase"
                                                                                    FieldName="idviaggio" ReadOnly="true" Width="65px">
                                                                                </iwc:IboWebTextBox>
                                                                                <%--<iwc:IboWebLabel ID="IdViaggioValue" runat="server" Translate="False" FieldName="idviaggio"></iwc:IboWebLabel>--%>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                                <iwc:IboWebLabel ID="lblVettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 313px;">
                                                                                <iwc:IboWebTextBox ID="Vettore" runat="server" CharacterCase="Uppercase"
                                                                                    ReadOnly="true" Width="308px" SqlQueryLookup="SELECT RagioneSociale FROM Trasportatori WHERE CODICE=(SELECT VETTORE FROM VIAGGI WHERE IDVIAGGIO='<#CONTROLS_RECORD.txtIdViaggio#>')">
                                                                                </iwc:IboWebTextBox>

                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </asp:Panel>
                                                </asp:Panel>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpRicavi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpRicaviCaption" Text="Ricavi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">

                                            <asp:Panel runat="server" ID="cpRicavi_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpRicavi_Title_Caption" Text="Ricavi di Trasporto" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpRicavi_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpRicavi_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 160px">
                                                                    <iwc:IboWebLabel ID="lblDataCompetenzaAttiva" runat="server" Text="Data Competenza Attiva:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 100px;">
                                                                    <iwc:IboWebTextBox ID="txtDataCompetenzaAttiva" runat="server" CharacterCase="Uppercase" FormatString="{0:dd/MM/yyyy}"
                                                                        FieldName="DataCompetenzaAttiva" ReadOnly="true" Width="80px" FieldDataType="Date">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblIdFatturaAttiva" runat="server" Text="IdFattura Attiva:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 80px;">
                                                                    <iwc:IboWebTextBox ID="txtIdFatturaAttiva" runat="server" CharacterCase="Uppercase"
                                                                        FieldName="IdFatturaAttiva" ReadOnly="true" Width="50px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 160px">
                                                                    <iwc:IboWebLabel ID="lblIdRaggruppamentoAttivo" runat="server" Text="IdRaggruppamento Attivo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 100px;">
                                                                    <iwc:IboWebTextBox ID="txtIdRaggruppamentoAttivo" runat="server" CharacterCase="Uppercase"
                                                                        FieldName="IdRaggruppamentoAttivo" ReadOnly="true" Width="90px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 160px">
                                                                    <iwc:IboWebLabel ID="lblRicavoViaggioRipartito" runat="server" Text="Ricavo Viaggio Ripartito:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px;">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="IboWebNumericTlk1" ReadOnly="true" Width="90px"
                                                                        FieldName="RicavoViaggioRipartito" DecimalDigits="3">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <hr class="Separatore" />
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <div class="tlbgrdRicaviDiv">
                                                                        <iwc:iboWebToolbar ID="tlbgrdRicavi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <div class="DivPnlChkBloccaRicavi">
                                                                            <asp:Panel runat="server" ID="pnlChkBloccaRicavi">
                                                                                <table class="DetailFormSectionTable2Fixed">
                                                                                    <tr style="height: 25px;">
                                                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                            <iwc:IboWebLabel runat="server" ID="lblBloccaRicavi" Text="Blocca Ricavi:"></iwc:IboWebLabel>
                                                                                        </td>
                                                                                        <td class="DetailFormValueCell" style="width: 20px; padding-left: 2px;">
                                                                                            <iwc:IboWebCheckBox runat="server" ID="chkBloccaRicavi" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </asp:Panel>
                                                                        </div>
                                                                    </div>
                                                                    <asp:Panel ID="pnlRicavi" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdRicavi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
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
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpCosti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpCostiCaption" Text="Costi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpCosti_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpCosti_Title_Caption" Text="Costi di distribuzione" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpCosti_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpCosti_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 160px">
                                                                    <iwc:IboWebLabel ID="lblDataCompetenzaPassiva" runat="server" Text="Data Competenza Passiva:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 100px;">
                                                                    <iwc:IboWebTextBox ID="txtDataCompetenzaPassiva" runat="server" CharacterCase="Uppercase" FormatString="{0:dd/MM/yyyy}"
                                                                        FieldName="DataCompetenzaPassiva" ReadOnly="true" Width="80px" FieldDataType="Date">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblIdFatturaPassiva" runat="server" Text="IdFattura Passiva:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 80px;">

                                                                    <iwc:IboWebTextBox ID="txtIdFatturaPassiva" runat="server" CharacterCase="Uppercase"
                                                                        FieldName="IdFatturaPassiva" ReadOnly="true" Width="50px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 160px">
                                                                    <iwc:IboWebLabel ID="lblIdRaggruppamentoPassivo" runat="server" Text="IdRaggruppamento Passivo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 100px;">
                                                                    <iwc:IboWebTextBox ID="txtIdRaggruppamentoPassivo" runat="server" CharacterCase="Uppercase"
                                                                        FieldName="IdRaggruppamentoPassivo" ReadOnly="true" Width="90px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 160px">
                                                                    <iwc:IboWebLabel ID="lblCostoViaggioRipartito" runat="server" Text="Costo Viaggio Ripartito:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px;">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCostoViaggioRipartito" ReadOnly="true" Width="90px"
                                                                        FieldName="CostoViaggioRipartito" DecimalDigits="3">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <hr class="Separatore" />
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <div class="tlbgrdCostiDiv">
                                                                        <iwc:iboWebToolbar ID="tlbgrdCosti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <div class="DivPnlChkBloccaCosti">
                                                                            <asp:Panel runat="server" ID="pnlChkBloccaCosti">
                                                                                <table class="DetailFormSectionTable2Fixed">
                                                                                    <tr style="height: 25px;">
                                                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                            <iwc:IboWebLabel runat="server" ID="lblBloccaCosti" Text="Blocca Costi:"></iwc:IboWebLabel>
                                                                                        </td>
                                                                                        <td class="DetailFormValueCell" style="width: 20px; padding-left: 2px;">
                                                                                            <iwc:IboWebCheckBox runat="server" ID="chkBloccaCosti" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </asp:Panel>
                                                                        </div>
                                                                    </div>
                                                                    <asp:Panel ID="pnlCosti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdCosti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
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
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpEventi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpEventiCaption" Text="Eventi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpEventi_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpEventi_Title_Caption" Text="Eventi" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpEventi_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpEventi_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <%--<div class="tlbgrdEventiDiv">
                                                                        <iwc:iboWebToolbar ID="tlbgrdEventi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />                                                                        
                                                                    </div>--%>
                                                                    <asp:Panel ID="pnlEventi" runat="server" CssClass="DetailFormGridContainerDiv" Style="max-height: 500px;">
                                                                        <iwc:IboGridView ID="grdEventi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
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
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpUds" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpUdsCaption" Text="Uds"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpUds_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpUds_Title_Caption" Text="Uds" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpUds_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpUds_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <div class="tlbgrdUdsDiv">
                                                                        <iwc:iboWebToolbar ID="tlbgrdUds" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    </div>
                                                                    <asp:Panel ID="pnlUds" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdUds" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
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
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpDoc" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpDocCaption" Text="Documenti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpDoc_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpDoc_Title_Caption" Text="Elenco Documenti" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpDoc_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpDoc_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <div class="tlbgrdDocDiv">
                                                                        <iwc:iboWebToolbar ID="tlbgrdDoc" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    </div>
                                                                    <asp:Panel ID="pnlDoc" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdDoc" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
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
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpDett" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDettCaption" Text="Altro"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpAltro_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpAltro_Title_Caption" Text="Altro" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:UpdatePanel ID="up_Altro" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <asp:Panel runat="server" ID="cpAltro_Body" CssClass="CollapsiblePanelBody">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa1" runat="server" IncasTag="" Text="Filler Alfa 1:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa1" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa6" runat="server" IncasTag="" Text="Filler Alfa 6:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa6" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa2" runat="server" IncasTag="" Text="Filler Alfa 2:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa2" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa7" runat="server" IncasTag="" Text="Filler Alfa 7:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa7" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa3" runat="server" IncasTag="" Text="Filler Alfa 3:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa3" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa8" runat="server" IncasTag="" Text="Filler Alfa 8:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa8" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa4" runat="server" IncasTag="" Text="Filler Alfa 4:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa4" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa9" runat="server" IncasTag="" Text="Filler Alfa 9:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa9" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>

                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">

                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa5" runat="server" IncasTag="" Text="Filler Alfa 5:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa5" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblFillerAlfa10" runat="server" IncasTag="" Text="Filler Alfa 10:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtFillerAlfa10" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <hr class="Separatore" />
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblNote" runat="server" IncasTag="" Text="Note:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblDataEsportazioneCorrispondente" runat="server" IncasTag="" Text="Data Esp. Corrisp.:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px;">
                                                                    <iwc:IboWebTextBox ID="DataEsportazioneCorrispondente" runat="server" ReadOnly="true" CharacterCase="Uppercase" FormatString="{0:dd/MM/yyyy HH:mm:ss}"
                                                                        FieldName="DataEsportazioneCorrispondente" Width="130px" FieldDataType="date">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblDataEsportazioneVettore" runat="server" IncasTag="" Text="Data Esp. Vettore.:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px;">
                                                                    <iwc:IboWebTextBox ID="DataEsportazioneVettore" runat="server" ReadOnly="true" CharacterCase="Uppercase" FormatString="{0:dd/MM/yyyy HH:mm:ss}"
                                                                        FieldName="DataEsportazioneVettore" Width="130px" FieldDataType="Date">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpSubSpedizioni" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpSubSpedizioniCaption" Text="Sub spedizioni"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpSubSpedizioni_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpSubSpedizioni_Title_Caption" Text="Sub-Spedizioni" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel ID="up_SubSpedizioni" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <table class="tableGridContainer">
                                                        <tr>
                                                            <td>
                                                                <div class="tlbgrdSubSpedizioniDiv">
                                                                    <iwc:iboWebToolbar ID="tlbgrdSubSpedizioni" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                </div>
                                                                <asp:Panel ID="Panel1" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                    <iwc:IboGridView ID="grdSubSpedizioni" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                        BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                        HorizontalAlign="Left" PageSize="20" Width="100%">
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
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <iwc:IboWebButton ID="btnCalcola" runat="server" Text="Calcola" CssClass="DetailFormButton btnCalcola" />
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
