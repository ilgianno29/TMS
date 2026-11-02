<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDocContestazioniDocumenti.aspx.vb" Inherits="Incasbo.Web.GDO.WFDocContestazioniDocumenti" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr style="display:none;">
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
                        <asp:Panel runat="server" ID="pnlMain" Width="950px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>                                    
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="line-height: 20px; height: 350px; clear: both;">
                                    <div style="float: left; width: 470px;">
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                    <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Id Contestazione:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 90px">
                                                    <iwc:IboWebHidden ID="hdnId" runat="server" FieldName="Id" IncasTag="IsIdentity=S"></iwc:IboWebHidden>
                                                    <iwc:IboWebTextBox ID="txtIdContestazione" runat="server" Width="80px" Required="True" ReadOnly="true"></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                    <iwc:IboWebLabel ID="lblData" runat="server" Text="Data documento:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebDate2 runat="server" ID="txtData" Required="true" />
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                    <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox runat="server" ID="txtNote" Required="true" Width="350px" MaxLength="1000" Rows="6" TextMode="MultiLine" />
                                                </td>
                                            </tr>
                                        </table>                                        
                                    </div>
                                    <div style="float: left;">
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCellTop" style="width: 100px;">
                                                    <iwc:IboWebLabel ID="lblDocumento" runat="server" Text="Documento:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebImage runat="server" ID="Documento" FieldName="documento" Required="true" FieldNameExtension="documentoEstensione" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
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
