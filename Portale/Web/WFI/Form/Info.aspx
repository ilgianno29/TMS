<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="Info.aspx.vb"
    Inherits="Incasbo.Web.WFI.Info" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/InfoPage.css" type="text/css" />
    <link rel="stylesheet" href="../css/FilterForm.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel runat="server" ID="pnlMainContent" CssClass="pnlMainContent">
        <table id="MainTable">
            <tr>
                <td>
                    <asp:Image ID="imgLogoApplicazione" runat="server" CssClass="imgLogoApplicazione"/>
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <table id="InnerTable">
                                    <tr>
                                        <td colspan="2" class="InfoTitoloApplicazione">
                                            <iwc:IboWebLabel ID="lblTitoloApplicazione" runat="server" IncasTag="" Text="Titolo Applicazione"  ></iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" class="InfoTitoloModuloSoftware">
                                            <iwc:IboWebLabel ID="lblTitoloModuloSoftware" runat="server" IncasTag="" Text="Titolo modulo software"  ></iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" class="InfoVersione">
                                            <iwc:IboWebLabel ID="txtVersione" runat="server" Text="Versione: "></iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" class="InfoIncas">
                                            <iwc:IboWebLabel ID="txtIncas" runat="server" IncasTag=""   Visible="False">sss</iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="FilterContentTableDescCell">
                                            <iwc:IboWebLabel ID="lblSessioniAperte" runat="server" IncasTag=""   Visible="False">Sessioni Aperte:</iwc:IboWebLabel>
                                        </td>
                                        <td class="FilterContentTableValueCell">
                                            <iwc:IboWebLabel ID="txtSessioniAperte" runat="server" IncasTag=""   Visible="False">sss</iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="FilterContentTableDescCell">
                                            <iwc:IboWebLabel ID="lblSessioniChiuse" runat="server" IncasTag=""   Visible="False">Sessioni Chiuse:</iwc:IboWebLabel>
                                        </td>
                                        <td class="FilterContentTableValueCell">
                                            <iwc:IboWebLabel ID="txtSessioniChiuse" runat="server" IncasTag=""   Visible="False"></iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="FilterContentTableDescCell">
                                            <iwc:IboWebLabel ID="lblSessioniCorrenti" runat="server" IncasTag=""   Visible="False">Sessioni Correnti:</iwc:IboWebLabel>
                                        </td>
                                        <td class="FilterContentTableValueCell">
                                            <iwc:IboWebLabel ID="txtSessioniCorrenti" runat="server" IncasTag=""   Visible="False"></iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="FilterContentTableDescCell">
                                            <iwc:IboWebLabel ID="lblConteggioRichieste" runat="server" IncasTag=""   Visible="False">Conteggio Richieste:</iwc:IboWebLabel>
                                        </td>
                                        <td class="FilterContentTableValueCell">
                                            <iwc:IboWebLabel ID="txtConteggioRichieste" runat="server" IncasTag=""   Visible="False"></iwc:IboWebLabel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="text-align: right;">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: left;">
                                            <asp:Image ID="imgLogoDitta" runat="server" />
                                        </td>
                                        <td style="text-align: right;">
                                            <asp:Image ID="imgLogoIncas" runat="server" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
