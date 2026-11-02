<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFStandardReport.aspx.vb" Inherits="Incasbo.Web.WFI.WFStandardReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web"
    TagPrefix="CR" %>
<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/CRWPrintPage.css?d=20121114" type="text/css" />
    <script type="text/javascript">
        function cmdDownloadClick() {
            var IFr = document.getElementById('IFrame');
            IFr.src = '';
            IFr.src = document.getElementById('IFrameUrl').value;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="pnlMain" runat="server" CssClass="StandardReport_pnlMain">
        <asp:Panel ID="MainTablePanel" runat="server">
            <table id="MainTable">
                <tr id="MainTable_Buttons_tr">
                    <td id="MainTable_Buttons_td">
                        <asp:Panel ID="pnlButtons" runat="server" CssClass="WFStandardReport_pnlButtons">
                            <iwc:IboWebButton ID="cmdDownload" CssClass="cmdDownload" runat="server" Text="Download" Visible="false" OnClientClick="cmdDownloadClick();" />
                            &nbsp;<iwc:IboWebButton ID="cmdEsci" CssClass="cmdEsci" runat="server" Text="Esci" />
                        </asp:Panel>
                    </td>
                </tr>
                <tr id="MainTable_Report">
                    <td>
                        <asp:Panel ID="pnlReport" runat="server" CssClass="pnlReport">
                            <CR:CrystalReportViewer ID="crvMain" runat="server" AutoDataBind="true" ReportSourceID="crsMain" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False"
                                HasCrystalLogo="False" HasDrilldownTabs="False" HasDrillUpButton="False" HasToggleGroupTreeButton="False" HasToggleParameterPanelButton="False"
                                Height="1241px" ToolPanelView="None" Width="350px" Visible="false" />
                            <CR:CrystalReportSource ID="crsMain" runat="server" CacheDuration="120">
                            </CR:CrystalReportSource>
                            <iframe runat="server" id="IFrame" src="" scrolling="auto" frameborder="0" class="pdfIFrame" visible="false"></iframe>
                            <asp:HiddenField runat="server" ID="IFrameUrl" ClientIDMode="Static" />
                        </asp:Panel>
                    </td>
                </tr>                
            </table>
        </asp:Panel>
        <div align="center">
            <asp:Panel ID="pnlMessaggioErrore" runat="server" CssClass="popupDiv" Visible="False">
                <div id="popupFilterTitleBar" class="popupDragBar">
                    <asp:Label ID="lblErroreCaption" runat="server" Text="Attenzione" CssClass="popupTitle"></asp:Label>
                </div>
                <div class="popupContent">
                    <table class="popupTable" align="center">
                        <tr>
                            <td>&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblMessaggio" runat="server">messaggio</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <br />
                                <hr />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="popupButtons">
                    <asp:Button ID="lblErroreOk" runat="server" Text="Ok" />
                </div>
            </asp:Panel>
        </div>
        <asp:Timer ID="tmrClose" runat="server" Interval="2000" Enabled="false"></asp:Timer>
    </asp:Panel>
</asp:Content>
