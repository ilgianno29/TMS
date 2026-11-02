<%@ Page Title="WFI Desktop" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFIDesktop.aspx.vb"
    Inherits="Incasbo.Web.WFI.WFIDesktop" Strict="false" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/Desktop.css?d=20161215" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel runat="server" ID="pnlMainContent" CssClass="pnlMainContent">
        <asp:Panel runat="server" ID="DesktopContainer" CssClass="DesktopContainer">
            <asp:DataList ID="dlDesktop" runat="server" CellSpacing="5" RepeatDirection="Horizontal" RepeatColumns="6" CssClass="dlDesktop">
                <HeaderTemplate>
                    <asp:Panel ID="TitleContainer" runat="server" CssClass="TitleContainer">
                        <table style="width: 100%;">
                            <tr>
                                <td style="width: 80%;">
                                    <asp:Label runat="server" ID="TitleText1" CssClass="TitleText1" Text="My Desktop"></asp:Label>
                                    <br />
                                    <div class="LinkPath">
                                        <asp:LinkButton runat="server" ID="LinkPath1" Text="" CommandArgument="0" OnClick="LinkPath_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="LinkPath2" Text="" CommandArgument="1" OnClick="LinkPath_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="LinkPath3" Text="" CommandArgument="2" OnClick="LinkPath_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="LinkPath4" Text="" CommandArgument="3" OnClick="LinkPath_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="LinkPath5" Text="" CommandArgument="4" OnClick="LinkPath_Click"></asp:LinkButton>
                                    </div>
                                </td>
                                <td style="text-align: right;">
                                    <a href="WFIDesktop.aspx">
                                        <img src="../../images/Toolbar/96/GoToHome.png" alt="Go to home" class="GoToHome" /></a>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="ItemLink" runat="server" CssClass="ItemLink">
                        <asp:Panel ID="ItemContainer" runat="server" CssClass='<%# iif(Container.DataItem("Funzione").tostring="IDLE","ItemContainerInvisible", "ItemContainer").tostring & " ItemTipoNodo_" & Container.DataItem("TipoNodo").tostring & " " & replace(Container.DataItem("CodiceVoce").tostring,".","_") %>'>
                            <asp:Panel ID="ItemImagePanel" runat="server" CssClass="ItemImagePanel">
                                <asp:Image ID="ItemImage" runat="server" CssClass="ItemImage" ImageUrl='<%# Container.DataItem("ImageUrl").tostring%>' />
                            </asp:Panel>
                            <asp:Panel ID="ItemTopRightPanel" runat="server" CssClass="ItemTopRightPanel" Visible="false" >
                                <asp:Panel ID="ItemTopRightValue" runat="server" CssClass="ItemTopRightValue">
                                    <asp:Literal ID="ltItemTopRightValue" runat="server" Text=""></asp:Literal>
                                </asp:Panel>
                            </asp:Panel>
                            <asp:Panel ID="ItemTopLeftPanel" runat="server" CssClass="ItemTopLeftPanel" Visible="false" >
                                <asp:Panel ID="ItemTopLeftValue" runat="server" CssClass="ItemTopLeftValue">
                                    <asp:Literal ID="ltItemTopLeftValue" runat="server" Text=""></asp:Literal>
                                </asp:Panel>
                            </asp:Panel>
                            <asp:Panel ID="ItemTextPanel" runat="server" CssClass="ItemTextPanel">
                                <asp:Label runat="server" ID="ItemText" CssClass="ItemText" Text='<%# Container.DataItem("Text").tostring%>'></asp:Label>
                                <br />
                                <asp:Label runat="server" ID="ItemAdditionalText" CssClass="ItemAdditionalText" Text='<%# Container.DataItem("AdditionalText").tostring%>'></asp:Label>
                            </asp:Panel>
                        </asp:Panel>
                    </asp:LinkButton>
                    <asp:HiddenField ID="HFTipoNodo" runat="server" Value='<%# Container.DataItem("TipoNodo").tostring%>' />
                    <asp:HiddenField ID="HFFunzione" runat="server" Value='<%# Container.DataItem("Funzione").tostring%>' />
                    <asp:HiddenField ID="HFCodiceVoce" runat="server" Value='<%# Container.DataItem("CodiceVoce").tostring%>' />
                    <asp:HiddenField ID="HFLevel" runat="server" Value='<%# Container.DataItem("Level").tostring%>' />
                </ItemTemplate>
            </asp:DataList>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
