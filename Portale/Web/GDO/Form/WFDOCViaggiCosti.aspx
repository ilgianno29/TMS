<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCViaggiCosti.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCViaggiCosti" %>

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
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr>
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Translate="True" Text="Titolo Form" IncasTag=""></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Translate="True" Text="Modalità"></iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="800px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpTestata_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpTestata_Title_Caption" Text="Testata Viaggio"
                                        CssClass="CollapsiblePanelTitleCaption"></asp:Label>

                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpTestata_Body" CssClass="CollapsiblePanelBody" Style="line-height: 18px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblViaggio" runat="server" IncasTag="" Text="Viaggio:"></iwc:IboWebLabel>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblViaggioValue" runat="server" IncasTag="" Text="" Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblVettore2" runat="server" IncasTag="" Text="Vettore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblVettoreValue" runat="server" IncasTag="" Text="" Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblMezzo" runat="server" IncasTag="" Text="Mezzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblMezzoValue" runat="server" IncasTag="" Text="" Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblRimorchio" runat="server" IncasTag="" Text="Rimorchio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblRimorchioValue" runat="server" IncasTag="" Text="" Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAutista1" runat="server" IncasTag="" Text="Autista 1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblAutista1Value" runat="server" IncasTag="" Text="" Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAutista2" runat="server" IncasTag="" Text="Autista 2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblAutista2Value" runat="server" IncasTag="" Text="" Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <asp:UpdatePanel runat="server" ID="up_cpCosti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblVoce" runat="server" IncasTag="" Text="Voce:" Translate="True"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 565px">
                                                        <iwc:IboWebComboTlk ID="cmbVoce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_VOCI" Required="true" Width="562px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTrasportatore" runat="server" IncasTag="" Text="Vettore:" Translate="True"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 565px">
                                                        <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TRASPORTATORI" Width="562px" AutoLoadOnDemand="true" Required="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblQuantitaOriginale" runat="server" IncasTag="" Text="Quantita Originale:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtQuantitaTassata" Width="100px" DecimalDigits="5" AutoPostBack="true" Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblImportoUnitario" runat="server" IncasTag="" Text="Importo Unitario:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtImportoUnitario" Width="100px" DecimalDigits="5" AutoPostBack="true" Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblImportoTotale" runat="server" IncasTag="" Text="Importo Totale:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                        <iwc:IboWebNumericTlk runat="server" ID="txtImportoArrotondato" Width="100px" ReadOnly="true" Required="true">
                                                        </iwc:IboWebNumericTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <iwc:IboWebTextBox ID="txtId" CssClass="hidden" runat="server" IncasTag="IsIdentity=S"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="IdViaggio" runat="server" CssClass="hidden" FieldName="IdViaggio"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtRecordZZ" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtTipoCalcolo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtIdRaggruppamento" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtCampoCalcolo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtUtenteForzatura" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtEstremiTariffa" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtNote" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebNumericTlk runat="server" ID="txtQuantitaArrotondata" CssClass="hidden" />
                                    <iwc:IboWebNumericTlk runat="server" ID="txtQuantitaOriginale" CssClass="hidden" />
                                    <iwc:IboWebNumericTlk runat="server" ID="txtImportoOriginale" CssClass="hidden" />
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
