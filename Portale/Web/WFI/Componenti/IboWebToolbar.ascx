<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="IboWebToolbar.ascx.vb" Inherits="Incasbo.Web.Components.IboWebToolbar" %>
<%@ Register Assembly="ContextMenu" Namespace="Msdn" TagPrefix="cc1" %>
<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Panel ID="pnlToolbar" runat="server" Visible="False">
    <asp:Table ID="tblToolbar" runat="server">
    </asp:Table>
    <cc1:ContextMenu ID="ToolbarContextMenu" runat="server" BorderColor="#AAAAAA" BorderStyle="Solid" BorderWidth="1px" AutoHide="true" CellPadding="3"
        ForeColor="#333333" BackColor="#EEEEEE" Font-Names="Segoe-UI" CssClass="" RolloverColor="#BBBBBB" Font-Size="12px">
    </cc1:ContextMenu>
    <telerik:RadContextMenu ID="ToolbarContextMenuTlk" runat="server" EnableEmbeddedBaseStylesheet="false" EnableEmbeddedSkins="false" Skin="Incas">
    </telerik:RadContextMenu>    
</asp:Panel>