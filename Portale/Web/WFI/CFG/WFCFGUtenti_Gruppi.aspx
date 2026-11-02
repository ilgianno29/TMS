<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFCFGUtenti_Gruppi.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFCFGUtenti_Gruppi" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <link rel="stylesheet" href="../Css/WFUtenti.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="950px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>                                    
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" style="padding-top:10px;padding-bottom:10px;">
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Gruppo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Required="true" Width="90px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblOrganizzazione" runat="server" IncasTag="" Text="Organizzazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 405px">
                                                <iwc:IboDropDownList ID="cmbOrganizzazione" runat="server" CharacterCase="Uppercase" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_ORGANIZZAZIONI" Width="400px">
                                                </iwc:IboDropDownList>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" IncasTag="" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 30px;">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" IncasTag="" Checked="true" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 390px;">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="385px" Required="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 63px">
                                                <iwc:IboWebLabel ID="lblPeso" runat="server" Text="Peso:" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtPeso" MaxValue="100" MinValue="0" Width="40px" DecimalDigits="0" FieldName="Peso"
                                                    Required="True" Value="0" WFIMaxValue="999999999" WFIMinValue="0">
                                                    <NumberFormat GroupSeparator="" KeepTrailingZerosOnFocus="True" ZeroPattern="n" />
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblLingua" runat="server" IncasTag="" Text="Lingua:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 220px;">
                                                <iwc:IboDropDownList ID="cmbLingua" runat="server" CharacterCase="Uppercase" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_LINGUE"
                                                    Width="227px" SqlQueryFilter="" Required="true" ClientIDMode="Static">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblMenuProfileId" runat="server" IncasTag="" Text="Menu:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 390px;">
                                                <iwc:IboWebComboTlk ID="cmbMenuProfileId" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_Config_Profiles" Width="385px"
                                                    FieldDescription="Menù" AutoLoadOnDemand="false" DropDownWidth="500px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 65px;">
                                                <iwc:IboWebLabel ID="lblDesktopProfileId" runat="server" IncasTag="" Text="Desktop:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbDesktopProfileId" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_Config_Profiles"
                                                    Width="345px" FieldDescription="Desktop" AutoLoadOnDemand="false" DropDownWidth="500px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: top;">
                                                <iwc:IboWebLabel ID="lblFiltro" runat="server" IncasTag="" Text="Filtro Aggiuntivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="11">
                                                <iwc:IboWebTextBox ID="txtFiltro" runat="server" MaxLength="1024" TextMode="MultiLine" CharacterCase="Uppercase" Width="600px"
                                                    FieldName="Filtro" Rows="4"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox ID="txtTipo" runat="server" CssClass="hidden" FieldName="Tipo"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtPassword" runat="server" CssClass="hidden" FieldName="Password" Text="123456789"></iwc:IboWebTextBox>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="false" ExpandControlID="cpInfoGen_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image"
                                    TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel ID="cpUtenti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpUtenti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Utenti"></iwc:IboWebLabel>                                    
                                </asp:Panel>
                                <asp:Panel ID="cpUtenti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <table class="tableGridContainer">
                                        <tr>
                                            <td>
                                                <iwc:iboWebToolbar ID="tlbgrdUtenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                    CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                <asp:Panel ID="pnlUtenti" runat="server" CssClass="DetailFormGridContainerDiv" style="min-height:150px; max-height:300px;">
                                                    <iwc:IboGridView ID="grdUtenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A"
                                                        BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left"
                                                        PageSize="20" Width="100%">
                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                        <PagerStyle Font-Size="Small" />
                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                    </iwc:IboGridView>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                    </table>
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
