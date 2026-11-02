<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANALocalitaZone.aspx.vb" Inherits="Incasbo.Web.GDO.WFANALocalitaZone" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="800px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoCaption" runat="server" Text="Codice Soggetto:"></iwc:IboWebLabel>
                                                <%-- <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />--%>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoValue" runat="server" Translate="False"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoCaption" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoValue" runat="server" Translate="False"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 555px">
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce" Width="550px" 
                                                    AutoLoadOnDemand="true" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                     <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblZonaSpedizione" runat="server" Text="Zona Spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 555px">
                                                <iwc:IboWebComboTlk ID="cmbZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneSpedizione" Width="550px" 
                                                    AutoLoadOnDemand="true" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                     <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblZonaTariffaAttiva" runat="server" Text="Zona Tariffa Attiva:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 555px">
                                                <iwc:IboWebComboTlk ID="cmbZonaTariffaAttiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva" Width="550px" 
                                                    AutoLoadOnDemand="true" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                     <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblZonaTariffaPassiva" runat="server" Text="Zona Tariffa Passiva:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 555px">
                                                <iwc:IboWebComboTlk ID="cmbZonaTariffaPassiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaPassiva" Width="550px" 
                                                    AutoLoadOnDemand="true" Required="true" >
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                     <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblZonaPartenzaAttiva" runat="server" Text="Zona Partenza Attiva:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 555px">
                                                <iwc:IboWebComboTlk ID="cmbZonaPartenzaAttiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva" Width="550px" 
                                                    AutoLoadOnDemand="true" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox ID="txtIdLocalita" runat="server" Style="display: none;"></iwc:IboWebTextBox>
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
