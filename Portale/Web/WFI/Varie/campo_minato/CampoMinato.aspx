<%@ Page Title="Javascript CampoMinato" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="CampoMinato.aspx.vb"
    Inherits="Incasbo.Web.WFI.CampoMinato" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="../../../WFI/scripts/jquery-2.0.3.min.js" type="text/javascript"></script>
    <script src="../../../WFI/scripts/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../../../WFI/scripts/WFIPlugin.js?d=20140210"></script>    

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel runat="server" ID="pnlMainContent" CssClass="pnlMainContent">
        <div id="CampoMinato">
            <iframe runat ="server"  id="IFrameCampoMinato" src="campoMinato.html" style="width:800px; height:500px;" scrolling="auto" frameborder="0"></iframe>
        </div>
    </asp:Panel>
    
</asp:Content>
