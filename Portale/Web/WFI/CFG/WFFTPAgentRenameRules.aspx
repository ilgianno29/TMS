<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFTPAgentRenameRules.aspx.vb" Inherits="Incasbo.Web.CFG.WFFTPAgentRenameRules" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <div id="Div1" runat="server" style="min-height: 150px;">
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                    <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 118px;">
                                                    <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="30" Required="true" Width="113px"></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormDescriptionCell" style="width: 465px">
                                                    <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 20px">
                                                    <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                    <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 605px;">
                                                    <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="600px" Required="true"></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:UpdatePanel ID="upnlRename" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblChkFullRename" runat="server" Text="Full rename:" FieldName=""></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 20px">
                                                            <iwc:IboWebCheckBox ID="chkFullRename" runat="server" Checked="True" Value="S" FieldName="" AutoPostBack="true"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <asp:Panel runat="server" ID="pnlFullRename">
                                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblFullRename" runat="server" Text="Full Rename:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 605px;">
                                                                <iwc:IboWebTextBox ID="txtFullRename" runat="server" CharacterCase="None" MaxLength="30" Width="600px"></iwc:IboWebTextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlPartialRename">
                                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblRenameStringFrom01" runat="server" Text="Rinomina da:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 255px;">
                                                                <iwc:IboWebTextBox ID="txtRenameStringFrom01" runat="server" MaxLength="30" Width="250px" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 85px;">
                                                                <iwc:IboWebLabel ID="lblRenameStringTo01" runat="server" Text="Rinomina a:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 255px;">
                                                                <iwc:IboWebTextBox ID="txtRenameStringTo01" runat="server" MaxLength="30" Width="250px" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblRenameStringFrom02" runat="server" Text="Rinomina da:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 255px;">
                                                                <iwc:IboWebTextBox ID="txtRenameStringFrom02" runat="server" MaxLength="30" Width="250px" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 85px;">
                                                                <iwc:IboWebLabel ID="lblRenameStringTo02" runat="server" Text="Rinomina a:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 255px;">
                                                                <iwc:IboWebTextBox ID="txtRenameStringTo02" runat="server" MaxLength="30" Width="250px" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblRenameStringFrom03" runat="server" Text="Rinomina da:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 255px;">
                                                                <iwc:IboWebTextBox ID="txtRenameStringFrom03" runat="server" MaxLength="30" Width="250px" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 85px;">
                                                                <iwc:IboWebLabel ID="lblRenameStringTo03" runat="server" Text="Rinomina a:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 255px;">
                                                                <iwc:IboWebTextBox ID="txtRenameStringTo03" runat="server" MaxLength="30" Width="250px" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
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
