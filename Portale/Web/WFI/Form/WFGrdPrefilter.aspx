<%@ Page Title="Prefiltro" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFGrdPrefilter.aspx.vb"
    Inherits="Incasbo.Web.WFI.WFGrdPrefilter" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../WFI/css/WFIGrdPrefilter.css?d=20180913" type="text/css" />
    <script type="text/javascript">
        $(function () {
            //
            // gestione del pulsante di default
            //
            $("body").keydown(function (event) {
                if (event.keyCode == 13) {
                    // premuto enter
                    event.preventDefault();
                    $("input.DetailFormButton_Ok").click();
                } else if (event.keyCode == 27) {
                    // premuto ESC
                    event.preventDefault();
                    $("input.DetailFormButton_Cancel").click();
                }
            });

            $("div.ImageLink").click(function (event) {
                $("div.ItemContainer").removeClass("ItemSelected");
                $(this).parent().addClass("ItemSelected");
                $("div.ItemContainer").redraw();
            });            
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text="Modalità" Visible="false"></iwc:IboWebLabel>
                            <asp:Image ID="imgModalita" runat="server" />
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" IncasTag="" CssClass="CollapsiblePanelTitleCaption" Translate="false"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="../images/toolbar/24/filtra2.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <asp:Panel ID="pnlListPrefilter" runat="server" CssClass="pnlListPrefilter">
                                        <asp:HiddenField runat="server" ID="IdFilterChoice" Value="" />
                                        <asp:Repeater runat="server" ID="ListRepeater">
                                            <ItemTemplate>
                                                <asp:HiddenField runat="server" ID="FilterDefault" Value='<%# Eval("IsDefault") %>' />
                                                <asp:LinkButton runat="server" ID="ItemLink" CommandArgument='<%# Eval("IdFilter") %>' CommandName="S" CssClass="ItemLink">
                                                    <asp:Panel ID="ItemContainer" runat="server" CssClass="ItemContainer">
                                                        <asp:Panel ID="ItemValue" runat="server" CssClass="ItemValue">
                                                            <%# Eval("Descrizione")%>
                                                        </asp:Panel>
                                                        <asp:Panel ID="pnlImageLink" runat="server" CssClass="ImageLink">
                                                            <asp:ImageButton runat="server" ID="imageLink" CommandArgument='<%# Eval("IdFilter") %>' CommandName="L" ImageUrl="~/WFI/Images/Toolbar/24/navigate_right2.png"></asp:ImageButton>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </asp:Panel>
                                </asp:Panel>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
                                    <iwc:IboWebButton ID="IboWebButton1" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" Visible="false" />
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
