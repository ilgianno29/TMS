<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDLGTrovaViaggio.aspx.vb" Inherits="Incasbo.Web.GDO.WFDLGTrovaViaggio" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <script type="text/javascript">
        function WFIpageLoad() {
            $(function () {
                $("#tabs").tabs({
                    activate: function (event, ui) {
                        if (ui.newTab[0].id == "tabsCaption-1") {
                            $("#chkTab1")[0].checked = true;
                            $("#chkTab2")[0].checked = false;
                            $("#chkTab3")[0].checked = false;                            
                        }
                        if (ui.newTab[0].id == "tabsCaption-2") {
                            $("#chkTab1")[0].checked = false;
                            $("#chkTab2")[0].checked = true;
                            $("#chkTab3")[0].checked = false;
                        }
                        if (ui.newTab[0].id == "tabsCaption-3") {
                            $("#chkTab1")[0].checked = false;
                            $("#chkTab2")[0].checked = false;
                            $("#chkTab3")[0].checked = true;
                        }                        
                    }
                });
            });
            if ($("#chkTab1")[0].checked) {
                $("#tabs").tabs("option", "active", 0);
            }
            if ($("#chkTab2")[0].checked) {
                $("#tabs").tabs("option", "active", 1);
            }
            if ($("#chkTab3")[0].checked) {
                $("#tabs").tabs("option", "active", 2);
            }            
        }
    </script>
    <link href="../Css/WFDLGTrovaViaggio.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
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
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1280px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" style="overflow:hidden;">
                                    <div id="tabs" style="height:275px;">
                                        <ul>
                                            <li id="tabsCaption-1"><a href="#tabs-1">
                                                <iwc:IboWebLabel ID="lblTab1" runat="server" Text="Ricerca per Id"></iwc:IboWebLabel></a></li>
                                            <li id="tabsCaption-2"><a href="#tabs-2">
                                                <iwc:IboWebLabel ID="lblTab2" runat="server" Text="Ricerca per Vettore"></iwc:IboWebLabel></a></li>
                                            <li id="tabsCaption-3"><a href="#tabs-3">
                                                <iwc:IboWebLabel ID="lblTab3" runat="server" Text="Ricerca per Mezzo/Autista"></iwc:IboWebLabel></a></li>                                            
                                        </ul>
                                        <div id="tabs-1" class="MyTabsBody">
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 180px; padding-top: 10px; padding-bottom: 10px">
                                                        <asp:CheckBox ID="chkTab1" runat="server" ClientIDMode="Static" Style="display: none;" Checked="true" />
                                                        <iwc:IboWebLabel ID="lblTab1IdViaggio" runat="server" IncasTag="" Text="Id Viaggio:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebTextBox runat="server" ID="txtTab1IdViaggio" Width="100px" FieldDescription="Id Viaggio" MaxLength="10" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 180px; padding-top: 10px; padding-bottom: 10px">                                                        
                                                        <iwc:IboWebLabel ID="lblTab1IdViaggioHost" runat="server" IncasTag="" Text="Id Viaggio host:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebTextBox runat="server" ID="txtTab1IdViaggioHost" Width="100px" FieldDescription="Id Viaggio host" MaxLength="30" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div id="tabs-2" class="MyTabsBody">
                                            <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 180px; padding-top: 5px; padding-bottom: 5px">
                                                        <iwc:IboWebLabel ID="lblTab2DataPartenza" runat="server" IncasTag="" Text="Data Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebDate2 runat="server" ID="txtTab2DataPartenza" ControlType="DateOnly" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <asp:CheckBox ID="chkTab2" runat="server" ClientIDMode="Static" Style="display: none;" />
                                                        <iwc:IboWebLabel ID="lblTab2Vettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 600px">
                                                        <iwc:IboWebComboTlk ID="cmbTab2Vettore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="600px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTab2Partenza" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 600px">
                                                        <iwc:IboWebComboTlk ID="cmbTab2Partenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza" Width="600px" AutoLoadOnDemand="true" AutoPostBack="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div id="tabs-3" class="MyTabsBody">
                                            <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 180px; padding-top: 5px; padding-bottom: 5px">
                                                        <iwc:IboWebLabel ID="lblTab3DataPartenza" runat="server" IncasTag="" Text="Data Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebDate2 runat="server" ID="txtTab3DataPartenza" ControlType="DateOnly" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <asp:CheckBox ID="chkTab3" runat="server" ClientIDMode="Static" Style="display: none;" />
                                                        <iwc:IboWebLabel ID="lblTab3Motrice" runat="server" Text="Motrice:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 600px">
                                                        <iwc:IboWebComboTlk ID="cmbTab3Motrice" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Motrici" Width="600px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblTab3Autista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 600px">
                                                        <iwc:IboWebComboTlk ID="cmbTab3Autista" runat="server" SqlQuery="SELECT * FROM CBO_ANA_autisti" Width="600px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>                                       
                                    </div>
                                </asp:Panel>
                            </div>
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpResult_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpResult_Caption" runat="server" Text="Risultati" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpResult_Body" CssClass="CollapsiblePanelBody" ClientIDMode="Static">
                                    <asp:UpdatePanel runat="server" ID="up_GridResult" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="tableGridContainer">
                                                <tr>
                                                    <td>
                                                        <iwc:iboWebToolbar ID="tlbgrdResult" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel"
                                                            CssClassTable="ToolbarTable" />
                                                        <asp:Panel ID="pnlGridResult" runat="server" CssClass="DetailFormGridContainerDiv" ClientIDMode="Static">
                                                            <iwc:IboGridView ID="grdResult" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                <PagerStyle Font-Size="Small" />
                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                            </iwc:IboGridView>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
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
                                    <asp:UpdatePanel runat="server" ID="up_btnConferma" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <iwc:IboWebButton ID="btnConferma" runat="server" Text="Trova" CssClass="DetailFormButton_Ok" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
