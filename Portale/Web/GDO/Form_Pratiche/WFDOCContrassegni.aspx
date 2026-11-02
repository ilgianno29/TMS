<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCContrassegni.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCContrassegni" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../GDO/css/WFDOCContrassegni.css" type="text/css" />
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
                                            <asp:Panel runat="server" ID="pnlTestataBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                <asp:Panel runat="server" ID="cpTestata_Title" CssClass="CollapsiblePanelTitle">
                                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="cpTestata_Body" CssClass="CollapsiblePanelBody">
                                                    <asp:Panel runat="server" ID="pnlTestataBodyLeft" ClientIDMode="Static">
                                                        <asp:Panel runat="server" ID="pnlEstremiSpedizioneTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblEstremiSpedizioneTitle" runat="server" Text="Estremi del Contrassegno"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_EstremiSpedizione" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlEstremiSpedizioneBody" CssClass="VbFrameBody" ClientIDMode="Static">
                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblId" runat="server" Text="Id:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 70px">
                                                                                <iwc:IboWebLabel ID="IdContrassegno" runat="server" FieldName="Id"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                <iwc:IboWebLabel ID="lblDataCreazione" runat="server" Text="Data Creazione:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 70px;">
                                                                                <iwc:IboWebLabel ID="DataCreazione" runat="server" FieldName="DataCreazione" FieldDataType="Date" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                                <iwc:IboWebLabel ID="lblStato" runat="server" Text="Stato:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded">
                                                                                <iwc:IboWebHidden runat="server" ID="txtStato" FieldName="Stato" />
                                                                                <iwc:IboWebLabel ID="Stato" runat="server" Style="color: #FF3333;"
                                                                                    SqlQueryLookup="SELECT Descrizione FROM VW_DOC_Contrassegni_Stati WHERE  CODICE='<#CONTROLS_RECORD.txtStato#>'">
                                                                                </iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                                <iwc:IboWebLabel ID="lblUnibol" runat="server" Text="Master:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 70px">
                                                                                <iwc:IboWebLabel ID="UnibolMAster" runat="server" FieldName="UnibolMAster"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                <iwc:IboWebLabel ID="lblUnibolApertura" runat="server" Text="Apertura:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded" style="width: 70px">
                                                                                <iwc:IboWebLabel ID="UnibolApertura" runat="server" FieldName="UnibolApertura"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                                <iwc:IboWebLabel ID="lblUnibolChiusura" runat="server" Text="Chiusura:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCellNoDataBounded">
                                                                                <iwc:IboWebLabel ID="UnibolChiusura" runat="server" FieldName="UnibolChiusura"></iwc:IboWebLabel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>

                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="pnlTestataBodyRight" ClientIDMode="Static">
                                                        <asp:Panel runat="server" ID="pnlImportoTitle" CssClass="VbFrameTitle" ClientIDMode="Static">
                                                            <iwc:IboWebLabel ID="lblImportoTitle" runat="server" Text="Importo del Contrassegno"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:UpdatePanel ID="up_Importo" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                                                <asp:Panel runat="server" ID="pnlImportoBody" CssClass="VbFrameBody" ClientIDMode="Static">

                                                                    <table class="DetailFormSectionTable2Fixed">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                                <iwc:IboWebLabel ID="lblContrassegno" runat="server" Text="Importo:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="txtContrassegno" Required="True" Width="120px" Font-Size="20px" Font-Bold="true"
                                                                                    DecimalDigits="2" FieldName="Contrassegno" Value="0" CssClass="Importo">
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
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                                            <iwc:IboWebHidden runat="server" ID="txtCliente" FieldName="Cliente" />
                                                                            <iwc:IboWebLabel ID="Cliente" runat="server"
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
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                                            <iwc:IboWebHidden runat="server" ID="txtClienteFatturazione" FieldName="ClienteFatturazione" />
                                                                            <iwc:IboWebLabel ID="ClienteFatturazione" runat="server"
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
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                                            <iwc:IboWebLabel ID="PCSDEstinazione_RagioneSociale" runat="server" Width="440px" ToolTip="Ragione Sociale"
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
                                                                            <iwc:IboWebLabel ID="PCSDestinazione_Indirizzo" runat="server" Width="440px" ToolTip="Indirizzo (via, piazza, ...)"
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
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 462px">
                                                                            <iwc:IboWebHidden runat="server" ID="txtCorrispondente" FieldName="Corrispondente" />
                                                                            <iwc:IboWebLabel ID="Corrispondente" runat="server" SqlQueryLookup="SELECT RagioneSociale FROM Corrispondenti WHERE CODICE='<#CONTROLS_RECORD.txtCorrispondente#>'"></iwc:IboWebLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                            <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 462px">
                                                                            <iwc:IboWebHidden runat="server" ID="txtTrasportatore" FieldName="Trasportatore" />
                                                                            <iwc:IboWebLabel ID="Trasportatore" runat="server" SqlQueryLookup="SELECT RagioneSociale FROM Trasportatori WHERE CODICE='<#CONTROLS_RECORD.txtTrasportatore#>'"></iwc:IboWebLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                            <iwc:IboWebLabel ID="lblTrasportatoreFatturazione" runat="server" Text="Trasp. di Fatt.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 462px;">
                                                                            <iwc:IboWebHidden runat="server" ID="txtTrasportatoreFatturazione" FieldName="TrasportatoreFatturazione" />
                                                                            <iwc:IboWebLabel ID="IboWebLabel1" runat="server" SqlQueryLookup="SELECT RagioneSociale FROM Trasportatori WHERE CODICE= '<#CONTROLS_RECORD.txtTrasportatoreFatturazione#>'"></iwc:IboWebLabel>
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
                                                                            <iwc:IboWebLabel ID="lblCausaleEsito" runat="server" Text="Esito:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 462px">
                                                                            <iwc:IboWebHidden runat="server" ID="txtCausaleEsito" FieldName="CausaleEsito" />
                                                                            <iwc:IboWebLabel ID="CausaleEsito" runat="server" SqlQueryLookup="SELECT Descrizione FROM Eventi WHERE CODICE='<#CONTROLS_RECORD.txtCausaleEsito#>'"></iwc:IboWebLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                            <iwc:IboWebLabel ID="lblDataEsito" runat="server" Text="Data Esito:" IncasTag=""></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 462px">
                                                                            <iwc:IboWebLabel ID="DataEsito" runat="server" FieldName="DataEsito" FieldDataType="Date" FormatString="{0:dd/MM/yyyy HH:mm}"></iwc:IboWebLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                            <iwc:IboWebLabel ID="lblNoteEsito" runat="server" Text="Note Esito:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 462px">
                                                                            <iwc:IboWebTextBox ID="txtNoteEsito" runat="server" MaxLength="255" Width="440px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                            <iwc:IboWebLabel ID="lblDataIncasso" runat="server" Text="Data Incasso:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 462px">
                                                                            <iwc:IboWebLabel ID="DataIncasso" runat="server" FieldName="DataIncasso" FieldDataType="Date" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                            <iwc:IboWebLabel ID="lblNoteIncasso" runat="server" Text="Note Incasso:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 462px">
                                                                            <iwc:IboWebTextBox ID="txtNoteIncasso" runat="server" MaxLength="255" Width="440px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                            <iwc:IboWebLabel ID="lblTipoIncasso" runat="server" Text="Tipo Incasso:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCellNoDataBounded" style="width: 462px">
                                                                            <iwc:IboWebHidden runat="server" ID="txtTipoIncasso" FieldName="TipoIncasso" />
                                                                            <iwc:IboWebLabel ID="TipoIncasso" runat="server" SqlQueryLookup="SELECT Descrizione FROM TipiIncasso WHERE CODICE='<#CONTROLS_RECORD.txtTipoIncasso#>'"></iwc:IboWebLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>

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
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr style="height: 20px;">
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCellTop" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblDoc1" runat="server" Text="Documento 1:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 310px">
                                                                <iwc:IboWebImage runat="server" ID="imgDoc1" FieldName="Doc1" FieldNameExtension="Doc1Tipo" />
                                                            </td>
                                                            <td class="DetailFormDescriptionCellTop" style="width: 72px;">
                                                                <iwc:IboWebLabel ID="lblDoc2" runat="server" Text="Documento 2:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 310px">
                                                                <iwc:IboWebImage runat="server" ID="imgDoc2" FieldName="Doc2" FieldNameExtension="Doc2Tipo" />
                                                            </td>
                                                            <td class="DetailFormDescriptionCellTop" style="width: 72px;">
                                                                <iwc:IboWebLabel ID="lblDoc3" runat="server" Text="Documento 3:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 305px">
                                                                <iwc:IboWebImage runat="server" ID="imgDoc3" FieldName="Doc3" FieldNameExtension="Doc3Tipo" />
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
                                    <iwc:IboWebButton ID="btnIncassato" runat="server" Text="Incassato" CssClass="DetailFormButton btnIncassato" />
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
