<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCGestioneSequenza.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCGestioneSequenza" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../css/WFDOCGestioneSequenza.css?d=20180411" type="text/css" />
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
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c3">
                                <div class="DetailFormModeImageDiv">
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Style="width: 1282px; height: 580px;">
                            <div class="DetailFormContainerDivCollapsiblePanel">                                
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="cpInfoGen_Body" Style="height: 570px;">
                                    <iwc:IboWebTextBox runat="server" ID="txtIdViaggio" Width="100px" Display="false"></iwc:IboWebTextBox>
                                    <asp:Panel ID="pnlOrdinaSpedizioni" runat="server">
                                        <table class="tableGridContainer">
                                            <tr>
                                                <td>
                                                    <iwc:IboWebPanel ID="pnlViaggiSpedizioniRaggruForDD" runat="server" CssClass="DetailFormGridContainerDiv pnlViaggiSpedizioni" MaintainScrollPositionOnPostBack="True">
                                                        <iwc:IboGridView ID="grdViaggiSpedizioniRaggruForDD" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                    </asp:Panel>
                                </asp:Panel>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="ButtonsPanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C"></td>
                                <td id="tableButtons_R" class="tableButtons_R">
                                    <iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="DetailFormButton_Ok" Display="false"  />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

