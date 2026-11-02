<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAPCSAcquisiti.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAPCSAcquisiti" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="850px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoCaption" runat="server" Text="Codice Soggetto:"></iwc:IboWebLabel>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoValue" runat="server" Translate="False" FieldName="CodiceInterno"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoCaption" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 400px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoValue" runat="server" Translate="False" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblCodiceSoggettoValue#>'" SqlQueryLookupField="RagioneSociale"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" Width="619px"
                                                    AutoLoadOnDemand="true" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodiceEsterno" runat="server" Text="Codice Esterno:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtCodiceEsterno" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblRagioneSociale" runat="server" Text="Ragione Sociale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtRagioneSociale" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 100px;"></td>
                                            <td class="DetailFormValueCell" style="width: 620px;">
                                                <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="452px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtProvincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" ToolTip="Provincia">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="39px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>                                    
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpFiller_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpFiller_Body" Text="Altre Info" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="Panel2" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblFiller1" runat="server" Text="Filler1:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller1" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>                                       
                                            <td class="DetailFormDescriptionCell" style="width: 70px">
                                                <iwc:IboWebLabel ID="lblFiller2" runat="server" Text="Filler2:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller2" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblFiller3" runat="server" Text="Filler3:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller3" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>                                       
                                            <td class="DetailFormDescriptionCell" style="width: 70px">
                                                <iwc:IboWebLabel ID="lblFiller4" runat="server" Text="Filler4:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller4" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblFiller5" runat="server" Text="Filler5:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller5" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>                                       
                                            <td class="DetailFormDescriptionCell" style="width: 70px">
                                                <iwc:IboWebLabel ID="lblFiller6" runat="server" Text="Filler6:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller6" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblFiller7" runat="server" Text="Filler7:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller7" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>                                       
                                            <td class="DetailFormDescriptionCell" style="width: 70px">
                                                <iwc:IboWebLabel ID="lblFiller8" runat="server" Text="Filler8:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller8" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblFiller9" runat="server" Text="Filler9:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller9" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>                                       
                                            <td class="DetailFormDescriptionCell" style="width: 70px">
                                                <iwc:IboWebLabel ID="lblFiller10" runat="server" Text="Filler10:"></iwc:IboWebLabel>
                                            </td>
                                           <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtFiller10" runat="server" CharacterCase="Uppercase" MaxLength="255" TextMode="MultiLine" Rows="3"  Width="300px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
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
