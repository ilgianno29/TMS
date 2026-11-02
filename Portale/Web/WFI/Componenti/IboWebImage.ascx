<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="IboWebImage.ascx.vb" Inherits="Incasbo.Web.Components.IboWebImage" %>
<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<asp:UpdatePanel runat="server" ID="pnlUP">
    <contenttemplate>
        <asp:Panel runat="server" ID="pnl">
            <asp:Table runat="server" ID="Main">
                <asp:TableRow ID="TrImg" runat="server">
                    <asp:TableCell ColumnSpan="2">
                        <div class="IboWebImage_ImgContainer">
                            <asp:HyperLink ID="HL" runat="server" ToolTip="Ingradisci immagine">
                                <asp:Image ID="Img" runat="server" /></asp:HyperLink>
                            <asp:panel id="IboWebImage_MsgDiv" class="IboWebImage_MsgDiv" runat="server">
                                <iwc:IboWebLabel ID="Mess" runat="server" Text="Inserire immagine" Visible="false" CssClass="IboWebImage_Messaggio"></iwc:IboWebLabel>
                            </asp:panel>                             
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="cmd1" runat="server">
                    <asp:TableCell>
                        <iwc:IboWebButton runat="server" ID="Canc" Text="Cancella" CssClass="IboWebImage_btnCancella" />
                    </asp:TableCell>
                    <asp:tableCell>
                        <iwc:IboWebButton runat="server" ID="mod" Text="" CssClass="IboWebImage_btnModifica" />
                        <label class="fileContainer">Scegli file<asp:FileUpload ID="FU" runat="server" CssClass="IboWebImage_btnBrowse" /></label>
                    </asp:tableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ID="cmd2" runat="server" ColumnSpan="2">                        
                        
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Panel>
    </contenttemplate>
    <triggers>
        <asp:PostBackTrigger ControlID="mod" />
    </triggers>
</asp:UpdatePanel>
