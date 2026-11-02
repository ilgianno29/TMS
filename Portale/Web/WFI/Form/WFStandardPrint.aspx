<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFStandardPrint.aspx.vb"
    Inherits="Incasbo.Web.WFI.WFStandardPrint" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm.css" type="text/css" />
    <link rel="stylesheet" href="../css/DataGrid.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="pnlMain" runat="server" Width="100%">
        <asp:Panel ID="pnlReport" runat="server">
            <rsweb:ReportViewer ID="RPTViewer" runat="server" Height="600px" Width="100%">
            </rsweb:ReportViewer>
        </asp:Panel>
        <div align="center">
            <asp:Panel ID="pnlMessaggioErrore" runat="server" CssClass="popupDiv" Visible="False">
                <div id="popupFilterTitleBar" class="popupDragBar">
                    <asp:Label ID="lblErroreCaption" runat="server" Text="Attenzione" CssClass="popupTitle"></asp:Label>
                </div>
                <div class="popupContent">
                    <table class="popupTable" align="center">
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblMessaggio" runat="server">123456asdfasdfasdfasdf</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <br />
                                <hr />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="popupButtons">
                    <asp:Button ID="lblErroreOk" runat="server" Text="Ok" />
                </div>
            </asp:Panel>
        </div>
        <div align="center">
            <asp:Panel ID="pnlSceltaReport" runat="server" Visible="False" CssClass="popupDiv">
                <div id="popupFilterTitleBar1" class="popupDragBar">
                    <asp:Label ID="lblElencoReport" runat="server" Text="Elenco report configurati" CssClass="popupTitle"></asp:Label>
                </div>
                <div class="popupContent" align="center">
                    <table class="popupTable" align="center" width="100%">
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblSceltaReport" runat="server" Text="Scegliere il report da stampare:" CssClass="popupSubTitle"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:ListBox ID="lstReport" runat="server" CssClass="popupReportListBox" Rows="10"></asp:ListBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                                <hr />
                            </td>
                        </tr>
                    </table>
                    <div class="popupButtons">
                         <table class="tableButtons">
                            <tr>
                                <td class="tableButtons_L">
                                    <asp:Button ID="cmoSceltaReportAnnulla" runat="server" Text="Esci" />
                                </td>
                                <td class="tableButtons_R">
                                    <asp:Button ID="cmoSceltaReportOk" runat="server" Text="Conferma" />
                                </td>
                            </tr>
                        </table>   
                    </div>
                </div>
            </asp:Panel>
        </div>
        <asp:HiddenField ID="HFQueryStringChiamante" runat="server" />
        <asp:HiddenField ID="HFNomeReport" runat="server" />
        <asp:HiddenField ID="HFReportConfigurato" runat="server" Value="N" />
    </asp:Panel>
</asp:Content>
