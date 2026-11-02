<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFTARVociIntegrativeVisualizza.aspx.vb"
    Inherits="Incasbo.Web.GDO.WFTARVociIntegrativeVisualizza" %>

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
    <style type="text/css">
        .CollapsiblePanelBody.cpVociTariffa_Body
        {
            padding: 0px;
        }
            .CollapsiblePanelBody.cpVociTariffa_Body .DetailFormGridContainerDiv.pnlVociTariffa
            {
                margin-left:-1px;
                margin-right:-1px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv" DefaultButton="btnConferma">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form"></iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1190px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpEstremi_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpEstremi_Title_Caption" Text="Estremi" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpEstremi_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblContratto" runat="server" IncasTag="" Text="Contratto:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblContrattoValue" runat="server" IncasTag="" Text="" Translate="false"
                                                    SqlQueryLookup="SELECT  Descrizione FROM TariffeContratti WHERE CODICE='<#CONTROLS_RECORD.Contratto#>'">
                                                </iwc:IboWebLabel>
                                            </td>                                           
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>                                            
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" IncasTag="" Text="Tipo Spedizione:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizioneValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM TipiSpedizione WHERE CODICE='<#CONTROLS_RECORD.TipoSpedizione#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoDocumento" runat="server" IncasTag="" Text="Tipo Documento:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 180px">
                                                <iwc:IboWebLabel ID="TipoDocumentoDescrizione" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT Descrizione FROM TariffeTipiDocumento WHERE CODICE='<#CONTROLS_RECORD.TipoDocumento#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" IncasTag="" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblTipoMerceValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM TipiMerce WHERE CODICE='<#CONTROLS_RECORD.TipoMerce#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" IncasTag="" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblTipoMezzoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM TipiMezzo WHERE CODICE='<#CONTROLS_RECORD.TipoMezzo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </table>
                                    <asp:Table runat="server" ID="ClienteVisualizza" CssClass="DetailFormSectionTable2Fixed">
                                        <asp:TableRow>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" IncasTag="" Text="Cliente:"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 320px">
                                                <iwc:IboWebLabel ID="lblClienteValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  RagioneSociale FROM Clienti WHERE CODICE='<#CONTROLS_RECORD.Cliente#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioPartenza" runat="server" IncasTag="" Text="Gruppo Tar.Par.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioPartenzaValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM PCS_GruppiTariffari WHERE CODICE='<#CONTROLS_RECORD.GruppoTariffarioPartenza#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" IncasTag="" Text="PCS Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblPCSPartenzaValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  RagioneSociale FROM PCS WHERE CODICE='<#CONTROLS_RECORD.PCSPartenza#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblMacroZonaArrivo" runat="server" IncasTag="" Text="Macro Zona Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblMacroZonaArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM ZONEMACRO WHERE CODICE='<#CONTROLS_RECORD.MacroZonaArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" IncasTag="" Text="Zona arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblZonaArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM ZONE WHERE CODICE='<#CONTROLS_RECORD.ZonaArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioArrivo" runat="server" IncasTag="" Text="Gruppo Tar.Arr.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM PCS_GruppiTariffari WHERE CODICE='<#CONTROLS_RECORD.GruppoTariffarioArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" IncasTag="" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 320px">
                                                <iwc:IboWebLabel ID="lblPCSArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  RagioneSociale FROM PCS WHERE CODICE='<#CONTROLS_RECORD.PCSArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox ID="Contratto" runat="server" CssClass="hidden"></iwc:IboWebTextBox>                                    
                                    <iwc:IboWebTextBox ID="TipoSpedizione" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="TipoDocumento" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="TipoMerce" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="TipoMezzo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="Cliente" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="GruppoTariffarioPartenza" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="PCSPartenza" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="MacroZonaArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="ZonaArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="GruppoTariffarioArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="PCSArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpVociTariffa_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpVociTariffa_Title_Caption" Text="Voci" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpVociTariffa_Body" CssClass="CollapsiblePanelBody cpVociTariffa_Body" Style="min-height: 200px; max-height: 400px">
                                    <asp:UpdatePanel runat="server" ID="upVociTariffa" UpdateMode="Conditional" RenderMode="Inline">
                                        <ContentTemplate>
                                            <table class="tableGridContainer">
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="pnlVociTariffa" runat="server" CssClass="DetailFormGridContainerDiv pnlVociTariffa">
                                                            <iwc:IboGridView ID="grdVociTariffa" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C"></td>
                                <td id="tableButtons_R" class="tableButtons_R">
                                    <iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="hidden" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
