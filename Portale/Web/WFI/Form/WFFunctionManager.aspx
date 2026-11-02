<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFunctionManager.aspx.vb"
    Inherits="Incasbo.Web.WFI.WFFunctionManager" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/WFFunctionManager.css?d=20150316" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Timer ID="tmrReturnToCaller" runat="server" Enabled="False" Interval="100"></asp:Timer>
    <asp:Panel ID="DetailFormMainDiv" runat="server" align="center">
        <asp:Panel ID="pnlDetailFormMainTable" runat="server" align="center">
            <table class="DetailFormMainTable">
                <tr>
                    <td>
                        <table class="DetailFormHeaderTable">
                            <tr>
                                <td align="left">
                                    <div class="DetailFormTitleDiv">
                                        <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo messaggio" IncasTag=""></iwc:IboWebLabel>
                                    </div>
                                </td>
                                <td align="right"></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="DetailFormSectionDiv">
                            <div class="DetailFormContainer">
                                <iwc:IboWebLabel ID="lblMessaggioConferma" runat="server" Font-Size="16pt" IncasTag="" Text="Messaggio di Conferma1"
                                    Width="600px" Style="text-align: left">
                                </iwc:IboWebLabel>
                                <br />
                                <br />
                                <iwc:IboWebLabel ID="lblMessaggioConferma2" runat="server" Font-Size="16pt" IncasTag="" Text="Messaggio di Conferma2"
                                    Width="600px" Style="text-align: left">
                                </iwc:IboWebLabel>
                                <asp:HiddenField ID="HFFuncToCall" runat="server" />
                            </div>
                        </div>
                        <div class="DetailFormCommandsDiv">
                            <iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="DetailFormButton" />
                            &nbsp;<iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton" />
                        </div>
                    </td>
                </tr>
            </table>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
