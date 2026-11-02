<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCViaggiAssociaBC.aspx.vb"
    Inherits="Incasbo.Web.GDO.WFDOCViaggiAssociaBC" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/Css/WFDOCViaggiAssociaBC.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr style="display: none">
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1290px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel ID="cpViaggio_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpViaggio_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Viaggio"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel ID="cpViaggio_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid" Style="min-height: 65px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px">
                                            <td class="DetailFormDescriptionCell" style="width: 85px;">
                                                <iwc:IboWebLabel ID="lblIdViaggio" runat="server" Text="Viaggio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 80px">
                                                <iwc:IboWebTextBox ID="txtIdViaggio" runat="server" CharacterCase="Uppercase" IncasTag="IdentityCounterName=COUNTERS.VIAGGI"
                                                    Width="75px" Required="true" Enabled="false">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px">
                                            <td class="DetailFormDescriptionCell" style="width: 85px;">
                                                <iwc:IboWebLabel ID="lblVettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblVettoreCodice" CssClass="ReadOnlyFieldValue" runat="server" FieldName="Vettore"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblVettoreDescrizione" CssClass="ReadOnlyFieldValue" runat="server" SqlQueryLookup="SELECT RagioneSociale FROM Trasportatori WHERE Codice='<#CONTROLS_RECORD.lblVettoreCodice#>'"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 85px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Sped.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblTipoSpedizioneCodice" CssClass="ReadOnlyFieldValue" runat="server" FieldName="TipoSpedizione"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblTipoSpedizioneDescrizione" CssClass="ReadOnlyFieldValue" runat="server" SqlQueryLookup="SELECT Descrizione FROM TipiSpedizione WHERE Codice='<#CONTROLS_RECORD.lblTipoSpedizioneCodice#>'"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr style="height: 20px">
                                            <td class="DetailFormDescriptionCell" style="width: 85px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblTipoMerceCodice" CssClass="ReadOnlyFieldValue" runat="server" FieldName="TipoMerce"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblTipoMerceDescrizione" CssClass="ReadOnlyFieldValue" runat="server" SqlQueryLookup="SELECT Descrizione FROM TipiMerce WHERE Codice='<#CONTROLS_RECORD.lblTipoMerceCodice#>'"></iwc:IboWebLabel>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 85px">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="PCS Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblPCSPartenzaCodice" CssClass="ReadOnlyFieldValue" runat="server" FieldName="PCSPartenza"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblPCSPartenzaDescrizione" CssClass="ReadOnlyFieldValue" runat="server" SqlQueryLookup="SELECT RagioneSociale FROM PCS WHERE Codice='<#CONTROLS_RECORD.lblPCSPartenzaCodice#>'"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>
                            <asp:UpdatePanel runat="server" ID="up_Input" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <div class="DetailFormContainerDivCollapsiblePanel">
                                        <asp:Panel ID="cpViaggiInput_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                            <iwc:IboWebLabel ID="cpInput_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Input">
                                            </iwc:IboWebLabel>
                                        </asp:Panel>
                                        <asp:Panel ID="cpInput_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid" DefaultButton="InputConferma"
                                            Style="height: 90px;">
                                            <table>
                                                <tr>
                                                    <td>
                                                        <table class="DetailFormSectionTable2Fixed" style="top: 10px; position: relative;">
                                                            <tr>
                                                                <td style="width: 20px;"></td>
                                                                <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                                    <iwc:IboWebLabel ID="lblInputBarcode" runat="server" Text="Barcode:" CssClass="BarcodeDescriptionLabel"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 305px">
                                                                    <iwc:IboWebTextBox ID="InputBarcode" runat="server" Width="300px" CssClass="BarcodeInputBox">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td style="width: 20px;"></td>
                                                                <td class="DetailFormDescriptionCell" style="width: 85px;">
                                                                    <iwc:IboWebRadioButtonList ID="InputOptions" runat="server" IncasTag="" RepeatDirection="Horizontal" AutoPostBack="true">
                                                                        <asp:ListItem Selected="True" Text="Associa" Value="A"></asp:ListItem>
                                                                        <asp:ListItem Text="Disassocia" Value="D"></asp:ListItem>
                                                                    </iwc:IboWebRadioButtonList>
                                                                </td>
                                                                <td class="BarcodeErrorMessageCell" style="width: 320px">
                                                                    <iwc:IboWebLabel ID="InputErrorMessage" runat="server" Text="" CssClass="BarcodeErrorMessage" Width="315px" Visible="false"></iwc:IboWebLabel>
                                                                    <iwc:IboWebLabel ID="InputOkMessage" runat="server" Text="" CssClass="BarcodeOkMessage" Width="315px" Visible="false"></iwc:IboWebLabel>
                                                                </td>
                                                                <td style="display: none">
                                                                    <iwc:IboWebButton ID="InputConferma" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td style="width: 300px">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr style="height: 20px">
                                                                <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotPeso" runat="server" Text="Peso:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotPesoValue" CssClass="ReadOnlyFieldValue" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotColli" runat="server" Text="Colli:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotColliValue" CssClass="ReadOnlyFieldValue" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                            <tr style="height: 20px">
                                                                <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotVolume" runat="server" Text="Volume:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotVolumeValue" CssClass="ReadOnlyFieldValue" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotPallet" runat="server" Text="Pallet:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblTotPalletValue" CssClass="ReadOnlyFieldValue" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblNumDdt" runat="server" Text="Numero DDT:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 70px;">
                                                                    <iwc:IboWebLabel ID="lblNumDdtValue" CssClass="ReadOnlyFieldValue" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel runat="server" ID="up_Spedizioni" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <div class="DetailFormContainerDivCollapsiblePanel">
                                        <asp:Panel ID="cpViaggiSpedizioni_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                            <iwc:IboWebLabel ID="cpViaggiSpedizioni_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Spedizioni"></iwc:IboWebLabel>
                                        </asp:Panel>
                                        <asp:Panel ID="cpViaggiSpedizioni_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid" Style="height: 340px; overflow: auto;">
                                            <table class="tableGridContainer">
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="pnlViaggiSpedizioni" runat="server" CssClass="DetailFormGridContainerDiv">
                                                            <iwc:IboGridView ID="grdViaggiSpedizioni" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                        </asp:Panel>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
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
                                    <iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" Style="visibility: hidden"
                                        Enabled="false" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
