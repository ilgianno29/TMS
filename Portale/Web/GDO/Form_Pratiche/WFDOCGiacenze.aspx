<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCGiacenze.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCGiacenze" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../GDO/css/WFDOCGiacenze.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />

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
                                            <div class="PanelGiacenza">
                                                <asp:Panel runat="server" ID="pnlTestataBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                    <asp:Panel runat="server" ID="cpTestata_Title" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpTestata_Body" CssClass="CollapsiblePanelBody">
                                                        <asp:Panel runat="server" ID="pnlTestataBody2" ClientIDMode="Static">
                                                            <asp:Panel runat="server" ID="pnlEstremiSpedizioneTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                                <iwc:IboWebLabel ID="lblEstremiSpedizioneTitle" runat="server" Text="Estremi della Giacenza"></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                            <asp:UpdatePanel ID="up_EstremiSpedizione" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                                <ContentTemplate>
                                                                    <asp:Panel runat="server" ID="pnlEstremiSpedizioneBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                         <table class="DetailFormSectionTable2Fixed">
                                                                            <tr>
                                                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                    <iwc:IboWebLabel ID="lblId" runat="server" Text="Id:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 90px">
                                                                                    <iwc:IboWebLabel ID="IdGiacenza" runat="server" FieldName="Id"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td style="width: 100px"></td>
                                                                                <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                    <iwc:IboWebLabel ID="lblDataApertura" runat="server" Text="Data Apertura:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 210px;">
                                                                                    <iwc:IboWebLabel ID="DataApertura" runat="server" FieldName="DataApertura" FieldDataType="Date" FormatString="{0:dd/MM/yyyy HH:mm}"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                    <iwc:IboWebLabel ID="lblDataChiusura" runat="server" Text="Data Chiusura:" IncasTag=""></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 194px">
                                                                                    <iwc:IboWebLabel ID="DataChiusura" runat="server" FieldName="DataChiusura" FieldDataType="Date" FormatString="{0:dd/MM/yyyy HH:mm}"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                                    <iwc:IboWebLabel ID="lblStato" runat="server" Text="Stato:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded">
                                                                                    <iwc:IboWebRadioButtonList ID="optStato" runat="server" RepeatDirection="Horizontal" Required="True" Width="170px" ReadOnly="true">
                                                                                        <asp:ListItem Selected="True" Text="In corso" Value="10"></asp:ListItem>
                                                                                        <asp:ListItem Text="Chiusa" Value="20"></asp:ListItem>
                                                                                    </iwc:IboWebRadioButtonList>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <table class="DetailFormSectionTable2Fixed">
                                                                            <tr>
                                                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                    <iwc:IboWebLabel ID="lblUnibol" runat="server" Text="Master:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 90px">
                                                                                    <iwc:IboWebLabel ID="UnibolMAster" runat="server" FieldName="UnibolMAster"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td style="width: 100px">
                                                                                    <iwc:IboWebButton ID="btnVediUnibolMaster" runat="server" CssClass="vediSpedizione" Text="Vedi"></iwc:IboWebButton>
                                                                                </td>
                                                                                <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                    <iwc:IboWebLabel ID="lblUnibolApertura" runat="server" Text="Id Apertura:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 90px">
                                                                                    <iwc:IboWebLabel ID="UnibolApertura" runat="server" FieldName="UnibolApertura"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td style="width: 117px">
                                                                                    <iwc:IboWebButton ID="btnVediUnibolApertura" runat="server" CssClass="vediSpedizione" Text="Vedi"></iwc:IboWebButton>
                                                                                </td>
                                                                                <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                    <iwc:IboWebLabel ID="lblUnibolChiusura" runat="server" Text="Id Chiusura:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 90px">
                                                                                    <iwc:IboWebLabel ID="UnibolChiusura" runat="server" FieldName="UnibolChiusura"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td style="width: 100px">
                                                                                    <iwc:IboWebButton ID="btnVediUnibolChiusura" runat="server" CssClass="vediSpedizione" Text="Vedi"></iwc:IboWebButton>
                                                                                </td>
                                                                                <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                                    <iwc:IboWebLabel ID="lblGiorniGiacenza" runat="server" Text="Giorni:"></iwc:IboWebLabel>
                                                                                </td>
                                                                                <td class="DetailFormValueCellNoDataBounded">
                                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtGiorniGiacenza" Width="40px"
                                                                                        DecimalDigits="0" FieldName="GiorniGiacenza" Required="true">
                                                                                    </iwc:IboWebNumericTlk>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </asp:Panel>
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlIntestazioniBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                    <asp:Panel runat="server" ID="pnlIntestazioniBodyLeft" ClientIDMode="Static">
                                                        <asp:Panel runat="server" ID="pnlDatiMittenteTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblDatiMittente" runat="server" Text="Dati del Cliente"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_DatiMittente" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlDatiMittenteBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                                                <iwc:IboWebLabel runat="server" ID="txtCliente" FieldName="Cliente" />
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 370px">
                                                                                <iwc:IboWebLabel ID="Cliente" runat="server" CssClass="MyEllipsis" style="width:360px;"
                                                                                    SqlQueryLookup="SELECT RagioneSociale FROM Clienti WHERE CODICE='<#CONTROLS_RECORD.txtCliente#>'">
                                                                                </iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblClienteFatturazione" runat="server" Text="Cliente di Fatt.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                                                <iwc:IboWebLabel runat="server" ID="txtClienteFatturazione" FieldName="ClienteFatturazione" />
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 370px">
                                                                                <iwc:IboWebLabel ID="ClienteFatturazione" runat="server" CssClass="MyEllipsis" style="width:360px;"
                                                                                    SqlQueryLookup="SELECT RagioneSociale FROM Clienti WHERE  CODICE='<#CONTROLS_RECORD.txtClienteFatturazione#>'">
                                                                                </iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
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
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                                                <iwc:IboWebLabel ID="PCSDEstinazione" runat="server" ToolTip="Codice" 
                                                                                    SqlQueryLookup="SELECT PCSDestinazione FROM Spedizioni WHERE UNIBOL='<#CONTROLS_RECORD.UnibolMaster#>'">
                                                                                </iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 370px">
                                                                                <iwc:IboWebLabel ID="PCSDEstinazione_RagioneSociale" runat="server" ToolTip="Ragione Sociale" CssClass="MyEllipsis" style="width:360px;"
                                                                                    SqlQueryLookup="SELECT PCSDestinazione_RagSoc FROM Spedizioni WHERE UNIBOL='<#CONTROLS_RECORD.UnibolMaster#>'">
                                                                                </iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                                <iwc:IboWebLabel ID="lbPCSDestinazionelIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px;">
                                                                                <iwc:IboWebLabel ID="PCSDestinazione_Indirizzo" runat="server" style="width:440px;" ToolTip="Indirizzo (via, piazza, ...)"
                                                                                    SqlQueryLookup="SELECT PCSDestinazione_Indirizzo FROM Spedizioni WHERE  UNIBOL='<#CONTROLS_RECORD.UnibolMaster#>'">
                                                                                </iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td style="width: 90px;"></td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px;">
                                                                                <iwc:IboWebLabel ID="PCSDestinazione_Cap" runat="server" ToolTip="Cap" Width="45px"
                                                                                    SqlQueryLookup="SELECT PCSDestinazione_CAP FROM Spedizioni WHERE  UNIBOL='<#CONTROLS_RECORD.txtUnibolMaster#>'">
                                                                                </iwc:IboWebLabel>
                                                                                <iwc:IboWebLabel ID="PCSDestinazione_Localita" runat="server" ToolTip="Località" Width="300px"
                                                                                    SqlQueryLookup="SELECT PCSDestinazione_Localita FROM Spedizioni WHERE  UNIBOL='<#CONTROLS_RECORD.UnibolMaster#>'">
                                                                                </iwc:IboWebLabel>
                                                                                <iwc:IboWebLabel ID="PCSDestinazione_Provincia" runat="server" ToolTip="Provincia" Width="30px"
                                                                                    SqlQueryLookup="SELECT PCSDestinazione_Provincia FROM Spedizioni WHERE  UNIBOL='<#CONTROLS_RECORD.UnibolMaster#>'">
                                                                                </iwc:IboWebLabel>
                                                                                <iwc:IboWebLabel ID="PCSDestinazione_Nazione" runat="server" ToolTip="Nazione" Width="30px"
                                                                                    SqlQueryLookup="SELECT PCSDestinazione_Nazione FROM Spedizioni WHERE  UNIBOL='<#CONTROLS_RECORD.UnibolMaster#>'">
                                                                                </iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
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
                                                                                <iwc:IboWebLabel ID="lblCausaleChiusura" runat="server" Text="Causale:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 462px">
                                                                                <iwc:IboWebHidden runat="server" ID="txtCausaleChiusura" FieldName="CausaleChiusura" />
                                                                                <iwc:IboWebLabel ID="CausaleChiusura" runat="server" SqlQueryLookup="SELECT Descrizione FROM Giacenze_CausaliChiusura WHERE CODICE='<#CONTROLS_RECORD.txtCausaleChiusura#>'"></iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                                <iwc:IboWebLabel ID="lblNoteChiusura" runat="server" Text="Note Chiusura:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 462px">
                                                                                <iwc:IboWebTextBox ID="txtNoteChiusura" runat="server" MaxLength="255" Width="440px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
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
                                                                <asp:Panel runat="server" ID="pnlRiferimentiTrasportoBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                                                <iwc:IboWebLabel runat="server" ID="txtCorrispondente" FieldName="Corrispondente" />
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 370px">

                                                                                <iwc:IboWebLabel ID="Corrispondente" runat="server" CssClass="MyEllipsis" style="width:360px;" SqlQueryLookup="SELECT RagioneSociale FROM Corrispondenti WHERE CODICE='<#CONTROLS_RECORD.txtCorrispondente#>'"></iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                                                <iwc:IboWebLabel runat="server" ID="txtTrasportatore" FieldName="Trasportatore" />
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 370px">

                                                                                <iwc:IboWebLabel ID="Trasportatore" runat="server" CssClass="MyEllipsis" style="width:360px;" SqlQueryLookup="SELECT RagioneSociale FROM Trasportatori WHERE CODICE='<#CONTROLS_RECORD.txtTrasportatore#>'"></iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblTrasportatoreFatturazione" runat="server" Text="Trasp. di Fatt.:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                                                <iwc:IboWebLabel runat="server" ID="txtTrasportatoreFatturazione" FieldName="TrasportatoreFatturazione" />
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 370px;">
                                                                                <iwc:IboWebLabel ID="TrasportatoreFatturazione" CssClass="MyEllipsis" style="width:360px;" runat="server" SqlQueryLookup="SELECT RagioneSociale FROM Trasportatori WHERE CODICE= '<#CONTROLS_RECORD.txtTrasportatoreFatturazione#>'"></iwc:IboWebLabel>
                                                                            </td>

                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </asp:Panel>
                                                </asp:Panel>
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpQuantita" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpQuantitaCaption" Text="Quantità"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="pnlQuantitaTitle" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="lblQuantita" runat="server" Text="Quantità" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel ID="up_Quantita" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <asp:Panel runat="server" ID="pnlQuantitaBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                    <iwc:IboWebLabel ID="lblPeso" runat="server" IncasTag="" Text="Peso"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtPeso" Width="80px" FieldName="Peso" DecimalDigits="3">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblPesoSpedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N3}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                    <iwc:IboWebLabel ID="lblColli" runat="server" IncasTag="" Text="Colli"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtColli" Width="80px" DecimalDigits="0" FieldName="Colli">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblColliSpedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N0}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                    <iwc:IboWebLabel ID="lblPallet" runat="server" IncasTag="" Text="Pallet"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtPallet" Width="80px" DecimalDigits="0" FieldName="Pallet">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" >
                                                                    <iwc:IboWebLabel ID="lblPalletSpedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N0}"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                    <iwc:IboWebLabel ID="lblVolume" runat="server" IncasTag="" Text="Volume"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtVolume" Width="80px"
                                                                        DecimalDigits="5" FieldName="Volume">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" >
                                                                    <iwc:IboWebLabel ID="lblVolumeSpedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N5}"></iwc:IboWebLabel>
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
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo1" Width="80px" FieldName="CampoCalcolo1">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo1Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo2" runat="server" IncasTag="" Text="Campo Calcolo 2"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo2" Width="80px" FieldName="CampoCalcolo2">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo2Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo3" runat="server" IncasTag="" Text="Campo Calcolo3"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo3" Width="80px" FieldName="CampoCalcolo3">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" >
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo3Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo4" runat="server" IncasTag="" Text="Campo Calcolo4"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo4" Width="80px" FieldName="CampoCalcolo4">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo4Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo5" runat="server" IncasTag="" Text="Campo Calcolo 5"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo5" Width="80px" FieldName="CampoCalcolo5">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo5Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo6" runat="server" IncasTag="" Text="Campo Calcolo 6"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo6" Width="80px"
                                                                        FieldName="CampoCalcolo6">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" >
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo6Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>

                                                                <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo7" runat="server" IncasTag="" Text="Campo Calcolo 7"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo7" Width="80px"
                                                                        FieldName="CampoCalcolo7">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo7Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 86px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo8" runat="server" IncasTag="" Text="Campo Calcolo 8"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo8" Width="80px"
                                                                        FieldName="CampoCalcolo8">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo8Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo9" runat="server" IncasTag="" Text="Campo Calcolo 9"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo9" Width="80px"
                                                                        FieldName="CampoCalcolo9">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" >
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo9Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo10" runat="server" IncasTag="" Text="Campo Calcolo 10"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 90px">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo10" Width="80px"
                                                                        FieldName="CampoCalcolo10">
                                                                    </iwc:IboWebNumericTlk>
                                                                </td>
                                                                <td class="DetailFormValueCellNoDataBounded" >
                                                                    <iwc:IboWebLabel ID="lblCampoCalcolo10Spedizione" runat="server" IncasTag="" FieldDataType="Number" FormatString="{0:N2}"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
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
                                                                <td class="DetailFormDescriptionCell" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblIdFatturaAttiva" runat="server" Text="IdFattura Attiva:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 80px;">
                                                                    <iwc:IboWebTextBox ID="txtIdFatturaAttiva" runat="server" CharacterCase="Uppercase"
                                                                        FieldName="IdFatturaAttiva" ReadOnly="true" Width="50px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <hr class="Separatore" />
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <asp:Panel ID="tlbgrdRicaviDiv" CssClass="tlbgrdRicaviDiv" runat="server">
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
                                                                    </asp:Panel>
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
                                                                <%-- <td class="DetailFormDescriptionCell" style="width: 160px">
                                                                    <iwc:IboWebLabel ID="lblDataCompetenzaPassiva" runat="server" Text="Data Competenza Passiva:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 100px;">
                                                                    <iwc:IboWebTextBox ID="txtDataCompetenzaPassiva" runat="server" CharacterCase="Uppercase" FormatString="{0:dd/MM/yyyy}"
                                                                        FieldName="DataCompetenzaPassiva" ReadOnly="true" Width="80px" FieldDataType="Date">
                                                                    </iwc:IboWebTextBox>
                                                                </td>--%>
                                                                <td class="DetailFormDescriptionCell" style="width: 120px">
                                                                    <iwc:IboWebLabel ID="lblIdFatturaPassiva" runat="server" Text="IdFattura Passiva:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 80px;">

                                                                    <iwc:IboWebTextBox ID="txtIdFatturaPassiva" runat="server" CharacterCase="Uppercase"
                                                                        FieldName="IdFatturaPassiva" ReadOnly="true" Width="50px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <hr class="Separatore" />
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <asp:Panel ID="tlbgrdCostiDiv" CssClass="tlbgrdCostiDiv" runat="server">
                                                                        <iwc:iboWebToolbar ID="tlbgrdCosti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <asp:Panel ID="DivPnlChkBloccaCosti" class="DivPnlChkBloccaCosti" runat="server">
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
                                                                        </asp:Panel>
                                                                    </asp:Panel>
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
                                                                    <iwc:IboWebLabel ID="lblNote1" runat="server" IncasTag="" Text="Note1:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtNote1" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblNote2" runat="server" IncasTag="" Text="Note2:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtNote2" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                    <iwc:IboWebLabel ID="lblNote3" runat="server" IncasTag="" Text="Note3:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 460px">
                                                                    <iwc:IboWebTextBox ID="txtNote3" runat="server" CharacterCase="Uppercase" MaxLength="225"
                                                                        Width="450px">
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
                                <ajaxToolkit:TabPanel ID="tpDocumenti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDocumentiCaption" Text="Documenti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpDocumenti_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpDocumenti_Title_Caption" Text="Documenti" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel ID="up_Documenti" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <table class="tableGridContainer">
                                                        <tr>
                                                            <td>
                                                                <asp:Panel ID="tlbgrdDocumentiDiv" CssClass="tlbgrdDocumentiDiv" runat="server">
                                                                    <iwc:iboWebToolbar ID="tlbgrdDocumenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                </asp:Panel>
                                                                <iwc:IboWebPanel ID="pnlDocumenti" runat="server" CssClass="DetailFormGridContainerDiv pnlDocumenti" MaintainScrollPositionOnPostBack="true">
                                                                    <iwc:IboGridView ID="grdDocumenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                        BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                        HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </iwc:IboWebPanel>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpNotePratica" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpNotePraticaCaption" Text="Note"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpNotePratica_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpNotePratica_Title_Caption" Text="Note" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel ID="up_NotePratica" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <table class="tableGridContainer">
                                                        <tr>
                                                            <td>
                                                                <asp:Panel ID="tlbgrdNotePraticaDiv" CssClass="tlbgrdDocumentiDiv" runat="server">
                                                                    <iwc:iboWebToolbar ID="tlbgrdNotePratica" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                </asp:Panel>
                                                                <iwc:IboWebPanel ID="pnlNotePratica" runat="server" CssClass="DetailFormGridContainerDiv pnlDocumenti" MaintainScrollPositionOnPostBack="true">
                                                                    <iwc:IboGridView ID="grdNotePratica" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                        BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                        HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                        <PagerStyle Font-Size="Small" />
                                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                    </iwc:IboGridView>
                                                                </iwc:IboWebPanel>
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
