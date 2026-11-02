<%@ Page Title="Gestione Fatture Attive Manuali" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFFATFattureAttiveManualiDettagli.aspx.vb" Inherits="Incasbo.Web.GDO.WFFATFattureAttiveManualiDettagli" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server">
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblIdFatturaCaption" runat="server" IncasTag="" Text="Id fattura:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px;">
                                                <%-- <iwc:IboWebTextBox ID="txtIdFattura" FieldName="IdFattura" runat="server"></iwc:IboWebTextBox>--%>
                                                <iwc:IboWebLabel ID="lblIdFattura" runat="server" IncasTag="" FieldName="IdFattura"></iwc:IboWebLabel>
                                            </td>
                                            <%-- <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblLabelData" runat="server" IncasTag="" Text="Data:"></iwc:IboWebLabel>
                                            </td>--%>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <%--<iwc:IboWebDate runat="server" ID="txtData" CalendarVisibleIfDisabled="false" Enabled="false"  />--%>
                                                <iwc:IboWebLabel ID="lblData" runat="server" IncasTag="" FieldName="Data" FormatString="{0:dd/MM/yyyy}" FieldDataType="Date"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblLabelCliente" runat="server" IncasTag="" Text="Cliente di fatturazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" IncasTag="" FieldName="Cliente"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblClienteRagioneSociale" runat="server" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblLabelTipoDocumento" runat="server" IncasTag="" Text="Tipo documento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoDocumento" runat="server" IncasTag="" FieldName="TipoDocumento"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblTipoDocumentoDescrizione" runat="server" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblLabelTipoPagamento" runat="server" IncasTag="" Text="Tipo pagamento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoPagamento" runat="server" IncasTag="" FieldName="TipoPagamento"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblTipoPagamentoDescrizione" runat="server" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                        </tr>

                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpDettagli_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpDettagli_Title_Caption" Text="Dettagli" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpDettagli_Body" CssClass="CollapsiblePanelBody">
                                    <asp:UpdatePanel ID="UPTreeViewContent" runat="server" UpdateMode="Conditional" ClientIDMode="Static">
                                        <ContentTemplate>
                                            <asp:Panel ID="cpFatt_Att_Dett_Body_Grid" runat="server" CssClass="CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdFatt_Att_Dett" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                                CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <iwc:IboWebPanel ID="pnlFatt_Att_Dett" runat="server" CssClass="DetailFormGridContainerDiv" Style="max-height: 400px; min-height: 200px;"
                                                                MaintainScrollPositionOnPostBack="True"
                                                                ScrollBars="Auto">
                                                                <iwc:IboGridView ID="grdFatt_Att_Dett" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="false">
                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                    <PagerStyle Font-Size="Small" />
                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                </iwc:IboGridView>
                                                            </iwc:IboWebPanel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="pnlDettaglio" Visible="false" Style="border: 1px solid #c0c0c0; margin: 4px; padding: 3px; line-height: 16px;">
                                                <table class="DetailFormSectionTable">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblRigaview" runat="server" IncasTag="" Text="Riga:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblRigaDescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblTipoRigaView" runat="server" IncasTag="" Text="Tipo Riga:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblTipoRigaDescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblVoceView" runat="server" IncasTag="" Text="Voce:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblVoceDescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblDescrizioneView" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblDescrizioneDescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblQuantitaView" runat="server" IncasTag="" Text="Quantita:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblQuantitaDescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblUnitarioView" runat="server" IncasTag="" Text="Unitario:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblUnitarioDescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblTotaleView" runat="server" IncasTag="" Text="Totale:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblTotaleDescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblCodiceIvaView" runat="server" IncasTag="" Text="Codice Iva:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td style="width: 10px;"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebLabel ID="lblCodiceIVADescrizione" runat="server" IncasTag="" Text=""></iwc:IboWebLabel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
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
    <asp:Panel ID="PopupFormGlobalContainer" runat="server" Visible="false">
        <asp:Panel ID="PopupFormContainer" runat="server" CssClass="PopupFormContainer" Style="display: none;" Width="620px">
            <asp:Panel ID="PopupFormTitleBar" runat="server" CssClass="PopupFormTitleBar">
                <iwc:IboWebLabel ID="PopupFormCaption" runat="server" Text="..." CssClass="PopupFormCaption"></iwc:IboWebLabel>
            </asp:Panel>
            <asp:UpdatePanel runat="server" ID="UPPopupForm" ChildrenAsTriggers="True" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Panel ID="PopupFormBody" runat="server" CssClass="PopupFormBody">
                        <iwc:IboWebDetailPanel runat="server" ID="cpFatt_Att_Dett_Body_Detail" CssClass="CollapsiblePanelBodyDetail" TableName="Fatture_Attive_Dettaglio"
                            CancelButtonId="" OkButtonId="" AutoViewDetail="false" Title="Dettaglio di riga">
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                        <iwc:IboWebLabel ID="lblRiga" runat="server" IncasTag="" Text="Numero Riga:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell">
                                        <iwc:IboWebNumericTlk runat="server" ID="txtRiga" MaxValue="9999" Width="60px" MaxLength="4" DecimalDigits="0" FieldName="Riga">
                                        </iwc:IboWebNumericTlk>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="DetailFormDescriptionCell">
                                        <iwc:IboWebLabel ID="lblTipo" runat="server" IncasTag="" Text="Tipo Riga:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell">
                                        <iwc:IboWebRadioButtonList ID="optTipoRiga" runat="server" FieldName="TipoRiga" Height="25px" IncasTag="" RepeatDirection="Horizontal"
                                            AutoPostBack="true">
                                            <asp:ListItem Selected="True" Text="Manuale" Value="M"></asp:ListItem>
                                            <asp:ListItem Text="Nota" Value="N"></asp:ListItem>
                                        </iwc:IboWebRadioButtonList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="DetailFormDescriptionCell">
                                        <iwc:IboWebLabel ID="lblVoce" runat="server" IncasTag="" Text="Voce:">
                                        </iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell">
                                        <iwc:IboWebComboTlk ID="cmbVoce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_VOCI" SqlQueryFilter="" Width="450px" AutoLoadOnDemand="true">
                                        </iwc:IboWebComboTlk>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="DetailFormDescriptionCell">
                                        <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:">
                                        </iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell">
                                        <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="450px"></iwc:IboWebTextBox>
                                    </td>
                                </tr>
                            </table>
                            <asp:UpdatePanel runat="server" ID="up1" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblQuantita" runat="server" IncasTag="" Text="Quantità:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtQuantitaTassata" Width="100px" Value="0" DecimalDigits="5" AutoPostBack="true">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblUnitario" runat="server" IncasTag="" Text="Unitario:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtImportoUnitario" Width="100px" Value="0" DecimalDigits="5" AutoPostBack="true">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblTotale" runat="server" IncasTag="" Text="Totale:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtImportoOriginale" Width="100px" Value="0" DecimalDigits="5" ReadOnly="True">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <iwc:IboWebTextBox ID="txtCodiceIva" runat="server" Style="display: none;"></iwc:IboWebTextBox>
                            <iwc:IboWebTextBox ID="txtTipoCalcolo" runat="server" Style="display: none;"></iwc:IboWebTextBox>
                            <iwc:IboWebNumericTlk ID="txtQuantitaArrotondata" runat="server" Style="display: none;"></iwc:IboWebNumericTlk>
                            <iwc:IboWebNumericTlk ID="txtQuantitaOriginale" runat="server" Style="display: none;"></iwc:IboWebNumericTlk>
                            <iwc:IboWebNumericTlk ID="txtImportoArrotondato" runat="server" Style="display: none;"></iwc:IboWebNumericTlk>
                            <iwc:IboWebTextBox ID="txtCampoCalcolo" runat="server" Style="display: none;"></iwc:IboWebTextBox>
                            <iwc:IboWebTextBox ID="txtIdFatturaPopUP" FieldName="IdFattura" CssClass="PresentationOnly" Visible="False" runat="server"
                                CharacterCase="Uppercase"></iwc:IboWebTextBox>
                        </iwc:IboWebDetailPanel>
                    </asp:Panel>
                    <asp:Panel ID="PopupFormButtons" runat="server" CssClass="PopupFormButtons">
                        <table class="tableButtons">
                            <tr>
                                <td class="tableButtons_L">
                                    <iwc:IboWebButton ID="PopupForm_cmdAnnulla" CssClass="PopupForm_cmdAnnulla" runat="server" Text="Esci" CausesValidation="False"
                                        ClientIDMode="Static" />
                                </td>
                                <td class="tableButtons_R">
                                    <iwc:IboWebButton ID="PopupForm_cmdOk" CssClass="PopupForm_cmdOk" runat="server" Text="Conferma" ClientIDMode="Static" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </asp:Panel>
        <asp:Button runat="server" ID="hiddenTargetControlForPopupForm" Style="display: none" />
        <ajaxToolkit:ModalPopupExtender runat="server" ID="PopupForm" TargetControlID="hiddenTargetControlForPopupForm" PopupControlID="PopupFormContainer"
            BackgroundCssClass="PopupFormBackground" RepositionMode="RepositionOnWindowResize" Drag="True" PopupDragHandleControlID="PopupFormTitleBar"
            DropShadow="True" CancelControlID="" OkControlID="">
        </ajaxToolkit:ModalPopupExtender>
    </asp:Panel>
</asp:Content>
