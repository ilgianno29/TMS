<%@ Page Title="Gestione tabella Allgrd" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFCFGDoQuery.aspx.vb" Inherits="Incasbo.Web.CFG.WFCFGDoQuery" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <style type="text/css">
        .ResultGridContainer
        {
            margin-top: 2px;
            margin-bottom: 2px;
            overflow: auto;
            max-height: 350px;
            border: 1px solid #cccccc;
        }

        .grdDati
        {
            border: 1px solid #dddddd;
        }

            .grdDati td, .grdDati th
            {
                padding: 1px 2px 1px 2px;
            }

            .grdDati .PagerStyle table td
            {
                padding: 0px;
            }

            .grdDati .RowStyle, .grdDati .AlternatingRowStyle
            {
                border: 1px solid #dddddd;
            }

                .grdDati .RowStyle td, .grdDati .AlternatingRowStyle td
                {
                    border: 1px solid #dddddd;
                }

            .grdDati .HeaderStyle th
            {
                border: 1px solid #dddddd;
            }

        #btnGo, #btnSvuota
        {
            width: 100px;
            height: 30px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" align="center">
        <table class="DetailFormMainTable">
            <tr align="left" style="display: none;">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" IncasTag=""></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c3">
                                <div class="DetailFormModeImageDiv">
                                    <asp:Image ID="imgModalita" runat="server" />
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr align="left">
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1300px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Query Manager" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <asp:Panel runat="server" ID="pnlQuery">
                                        <iwc:IboWebLabel runat="server" ID="lblQuery" Text="Query" ClientIDMode="Static"></iwc:IboWebLabel><br />
                                        <iwc:IboWebTextBox runat="server" ID="Query" Text="" Rows="10" TextMode="MultiLine" Style="width: 1100px;" ClientIDMode="Static"
                                            MaxLength="4000"></iwc:IboWebTextBox>
                                        <iwc:IboWebButton runat="server" ID="btnGo" Text="Run query" ClientIDMode="Static" />
                                        <iwc:IboWebButton runat="server" ID="btnSvuota" Text="Svuota" ClientIDMode="Static" />
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="pnlResultContainer">
                                        <asp:UpdatePanel runat="server" ID="upDati1" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <iwc:IboWebPanel MaintainScrollPositionOnPostBack="true" runat="server" ID="pnlDati1" Width="100%" CssClass="ResultGridContainer" Visible="false">
                                                    <asp:GridView runat="server" ID="grdDati1" AllowPaging="true" EmptyDataText="No record found" PagerSettings-Mode="NumericFirstLast"
                                                        PagerSettings-NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PagerSettings-LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                        PagerSettings-FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" PagerSettings-PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png"
                                                        PageSize="50" CellPadding="3" ForeColor="#333333" GridLines="None" CssClass="grdDati" BorderColor="#DDDDDD">
                                                        <RowStyle Font-Size="7" CssClass="RowStyle" BackColor="#FFFBD6" ForeColor="#333333" />
                                                        <AlternatingRowStyle BackColor="White" Font-Size="7" CssClass="AlternatingRowStyle" />
                                                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Font-Size="7" CssClass="FooterStyle" />
                                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Height="20" Font-Size="7" CssClass="HeaderStyle" />
                                                        <PagerSettings FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                            NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png" />
                                                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" CssClass="PagerStyle" />
                                                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                                        <SortedDescendingHeaderStyle BackColor="#820000" />
                                                    </asp:GridView>
                                                </iwc:IboWebPanel>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:UpdatePanel runat="server" ID="upDati2" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Panel runat="server" ID="pnlDati2" Width="100%" CssClass="ResultGridContainer" Visible="false">
                                                    <asp:GridView runat="server" ID="grdDati2" AllowPaging="true" EmptyDataText="No record found" PagerSettings-Mode="NumericFirstLast"
                                                        PagerSettings-NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PagerSettings-LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                        PagerSettings-FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" PagerSettings-PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png"
                                                        PageSize="50" CellPadding="4" ForeColor="#333333" GridLines="both" CssClass="grdDati">
                                                        <RowStyle Font-Size="7" CssClass="RowStyle" BackColor="#FFFBD6" ForeColor="#333333" />
                                                        <AlternatingRowStyle BackColor="White" Font-Size="7" CssClass="AlternatingRowStyle" />
                                                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Font-Size="7" CssClass="FooterStyle" />
                                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Height="20" Font-Size="7" CssClass="HeaderStyle" />
                                                        <PagerSettings FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                            NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png" />
                                                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" CssClass="PagerStyle" />
                                                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                                        <SortedDescendingHeaderStyle BackColor="#820000" />
                                                    </asp:GridView>
                                                </asp:Panel>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:UpdatePanel runat="server" ID="upDati3" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Panel runat="server" ID="pnlDati3" Width="100%" CssClass="ResultGridContainer" Visible="false" >
                                                    <asp:GridView runat="server" ID="grdDati3" AllowPaging="true" EmptyDataText="No record found" PagerSettings-Mode="NumericFirstLast"
                                                        PagerSettings-NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PagerSettings-LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                        PagerSettings-FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" PagerSettings-PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png"
                                                        PageSize="50" CellPadding="4" ForeColor="#333333" GridLines="both" CssClass="grdDati">
                                                        <RowStyle Font-Size="7" CssClass="RowStyle" BackColor="#FFFBD6" ForeColor="#333333" />
                                                        <AlternatingRowStyle BackColor="White" Font-Size="7" CssClass="AlternatingRowStyle" />
                                                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Font-Size="7" CssClass="FooterStyle" />
                                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Height="20" Font-Size="7" CssClass="HeaderStyle" />
                                                        <PagerSettings FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                            NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png" />
                                                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" CssClass="PagerStyle" />
                                                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                                        <SortedDescendingHeaderStyle BackColor="#820000" />
                                                    </asp:GridView>
                                                </asp:Panel>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:UpdatePanel runat="server" ID="upDati4" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Panel runat="server" ID="pnlDati4" Width="100%" CssClass="ResultGridContainer" Visible="false">
                                                    <asp:GridView runat="server" ID="grdDati4" AllowPaging="true" EmptyDataText="No record found" PagerSettings-Mode="NumericFirstLast"
                                                        PagerSettings-NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PagerSettings-LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                        PagerSettings-FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" PagerSettings-PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png"
                                                        PageSize="50" CellPadding="4" ForeColor="#333333" GridLines="both" CssClass="grdDati">
                                                        <RowStyle Font-Size="7" CssClass="RowStyle" BackColor="#FFFBD6" ForeColor="#333333" />
                                                        <AlternatingRowStyle BackColor="White" Font-Size="7" CssClass="AlternatingRowStyle" />
                                                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Font-Size="7" CssClass="FooterStyle" />
                                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Height="20" Font-Size="7" CssClass="HeaderStyle" />
                                                        <PagerSettings FirstPageImageUrl="~/WFI/Images/StdGrid/24/navigate_beginning2.png" LastPageImageUrl="~/WFI/Images/StdGrid/24/navigate_end2.png"
                                                            NextPageImageUrl="~/WFI/Images/StdGrid/24/navigate_right2.png" PreviousPageImageUrl="~/WFI/Images/StdGrid/24/navigate_left2.png" />
                                                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" CssClass="PagerStyle" />
                                                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                                        <SortedDescendingHeaderStyle BackColor="#820000" />
                                                    </asp:GridView>
                                                </asp:Panel>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:Panel>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpInfoGen_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image"
                                    TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
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
