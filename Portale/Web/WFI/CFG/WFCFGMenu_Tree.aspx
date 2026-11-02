<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFCFGMenu_Tree.aspx.vb" Inherits="Incasbo.Web.CFG.WFCFGMenu_Tree" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <link href="../Css/WFCFGMenu_Tree.css" rel="stylesheet" />
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
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag=""></iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Configurazione Menù" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <%--<asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblConfigProfileId" runat="server" IncasTag="" Text="Profilo:" Width="100px"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="ConfigProfileId" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_Config_Profiles" Width="500px" AutoLoadOnDemand="false" FieldDescription="Profilo"
                                                    Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox ID="txtId" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="false"
                                    ExpandControlID="cpInfoGen_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details"
                                    ImageControlID="cpInfoGen_Title_Image" TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpNodiPrimoLivello_Title" CssClass="CollapsiblePanelTitle" Style="display: none;">
                                    <asp:Label runat="server" ID="cpNodiPrimoLivello_Title_Caption" Text="Primo Livello" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <%-- <asp:Image runat="server" ID="cpNodiPrimoLivello_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpNodiPrimoLivello_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <asp:UpdatePanel runat="server" ID="UP_cpNodiPrimoLivello_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="tableGridContainer" style="table-layout: fixed;">
                                                <tr>
                                                    <td class="td_verticale">
                                                        <iwc:IboWebLabel runat="server" ID="VertFirstLevel" Text="Primo livello" CssClass="verticale"></iwc:IboWebLabel>
                                                    </td>
                                                    <td>
                                                        <iwc:IboWebTextBox ID="IdPrimoLivello" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                                        <iwc:iboWebToolbar ID="tlbgrdNodiPrimoLivello" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                        <iwc:IboWebPanel ID="pnlNodiPrimoLivello" runat="server" CssClass="DetailFormGridContainerDiv" ClientIDMode="Static" MaintainScrollPositionOnPostBack="true" Style="overflow: auto;
                                                            max-height: 200px;">
                                                            <iwc:IboGridView ID="grdNodiPrimoLivello" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True">
                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                <PagerStyle Font-Size="Small" />
                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                            </iwc:IboGridView>
                                                        </iwc:IboWebPanel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpNodiPrimoLivello" runat="server" CollapseControlID="cpNodiPrimoLivello_Title"
                                    Collapsed="false" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="false" ExpandControlID="cpNodiPrimoLivello_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpNodiPrimoLivello_Title_Image" TargetControlID="cpNodiPrimoLivello_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpNodiSecondoLivello_Title" CssClass="CollapsiblePanelTitle" Style="display: none;">
                                    <asp:Label runat="server" ID="cpNodiSecondoLivello_Title_Caption" Text="Secondo Livello" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <%-- <asp:Image runat="server" ID="cpNodiSecondoLivello_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpNodiSecondoLivello_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <asp:UpdatePanel runat="server" ID="UP_cpNodiSecondoLivello_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="tableGridContainer" style="table-layout: fixed;">
                                                <tr>
                                                    <td class="td_verticale">
                                                        <iwc:IboWebLabel runat="server" ID="IboWebLabel1" Text="Secondo livello" CssClass="verticale"></iwc:IboWebLabel>
                                                    </td>
                                                    <td>
                                                        <iwc:IboWebTextBox ID="IdSecondoLivello" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                                        <iwc:iboWebToolbar ID="tlbgrdNodiSecondoLivello" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                        <iwc:IboWebPanel ID="pnlNodiSecondoLivello" runat="server" CssClass="DetailFormGridContainerDiv" ClientIDMode="Static" MaintainScrollPositionOnPostBack="true" Style="overflow: auto;
                                                            max-height: 200px;">
                                                            <iwc:IboGridView ID="grdNodiSecondoLivello" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True">
                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                <PagerStyle Font-Size="Small" />
                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                            </iwc:IboGridView>
                                                        </iwc:IboWebPanel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpNodiSecondoLivello" runat="server" CollapseControlID="cpNodiSecondoLivello_Title"
                                    Collapsed="false" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="false" ExpandControlID="cpNodiSecondoLivello_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpNodiSecondoLivello_Title_Image" TargetControlID="cpNodiSecondoLivello_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpNodiTerzoLivello_Title" CssClass="CollapsiblePanelTitle" Style="display: none;">
                                    <asp:Label runat="server" ID="cpNodiTerzoLivello_Title_Caption" Text="Terzo Livello" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <%-- <asp:Image runat="server" ID="cpNodiTerzoLivello_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpNodiTerzoLivello_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <asp:UpdatePanel runat="server" ID="UPcpNodiTerzoLivello_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="tableGridContainer" style="table-layout: fixed;">
                                                <tr>
                                                    <td class="td_verticale">
                                                        <iwc:IboWebLabel runat="server" ID="IboWebLabel2" Text="Terzo livello" CssClass="verticale"></iwc:IboWebLabel>
                                                    </td>
                                                    <td>
                                                        <iwc:IboWebTextBox ID="IdTerzoLivello" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                                        <iwc:iboWebToolbar ID="tlbgrdNodiTerzoLivello" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                        <iwc:IboWebPanel ID="pnlNodiTerzoLivello" runat="server" CssClass="DetailFormGridContainerDiv" ClientIDMode="Static" MaintainScrollPositionOnPostBack="true" Style="overflow: hidden;
                                                            max-height: 200px;">
                                                            <iwc:IboGridView ID="grdNodiTerzoLivello" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True">
                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                <PagerStyle Font-Size="Small" />
                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                            </iwc:IboGridView>
                                                        </iwc:IboWebPanel>

                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpNodiTerzoLivello" runat="server" CollapseControlID="cpNodiTerzoLivello_Title"
                                    Collapsed="false" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="false" ExpandControlID="cpNodiTerzoLivello_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpNodiTerzoLivello_Title_Image" TargetControlID="cpNodiTerzoLivello_Body">
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
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <iwc:IboWebButton ID="btnAggiungiVoce" runat="server" Text="Nuova Voce" CssClass="DetailFormButton btnAggiungiVoce" />
                                </td>
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
<asp:Content ID="MasterPopupFormContent" ContentPlaceHolderID="phMasterPopupForm" runat="server">
    <asp:Panel ID="pnlInserisci" runat="server" Visible="false" Style="width: 650px; overflow: auto;">
        <table class="DetailFormSectionTable2Fixed" style="margin: 7px;">
            <tr>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 100px;">
                    <iwc:IboWebLabel ID="lblVoce" runat="server" IncasTag="" Text="Voce di Menù:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 300px;">
                    <iwc:IboWebComboTlk ID="Voce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_MENU_VOCI" Width="300px" AutoLoadOnDemand="false">
                    </iwc:IboWebComboTlk>
                </td>
                <td class="DetailFormDescriptionCell" style="width: 80px">
                    <iwc:IboWebLabel ID="lblSepara" runat="server" IncasTag="" Text="Separa:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 30px">
                    <iwc:IboWebCheckBox ID="Separa" runat="server" IncasTag="" Checked="false" Value="N"></iwc:IboWebCheckBox>
                </td>
                <td class="DetailFormDescriptionCell" style="width: 80px">
                    <iwc:IboWebLabel ID="lblVisibile" runat="server" IncasTag="" Text="Visibile:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebCheckBox ID="Visibile" runat="server" IncasTag="" Checked="true" Value="S"></iwc:IboWebCheckBox>
                </td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed" style="margin: 7px;">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 100px;">
                    <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebTextBox ID="Descrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="500px">
                    </iwc:IboWebTextBox>
                </td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed" style="margin: 7px;">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 100px;">
                    <iwc:IboWebLabel ID="lblPeso" runat="server" IncasTag="" Text="Peso:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebNumericTlk ID="Peso" runat="server" Width="70px" MinValue="0" MaxValue="101" WFIMinValue="0" WFIMaxValue="101" DecimalDigits="0">
                    </iwc:IboWebNumericTlk>
                </td>
            </tr>
        </table>
        <iwc:IboWebTextBox ID="idMenuTree" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
    </asp:Panel>
    <asp:Panel ID="pnlInserisciVoce" runat="server" Visible="false" Style="width: 650px; overflow: auto;">
        <table class="DetailFormSectionTable2Fixed" style="margin: 7px;">
            <tr>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 100px;">
                    <iwc:IboWebLabel ID="lblCodiceVoce" runat="server" IncasTag="" Text="Codice:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebTextBox ID="CodiceVoce" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="500px">
                    </iwc:IboWebTextBox>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblTestoVoce" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebTextBox ID="TestoVoce" runat="server" CharacterCase="None" MaxLength="255" Width="500px">
                    </iwc:IboWebTextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2"></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
