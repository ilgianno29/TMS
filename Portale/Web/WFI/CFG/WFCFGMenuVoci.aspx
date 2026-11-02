<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFCFGMenuVoci.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFCFGMenuVoci" %>

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
    <asp:Panel ID="DetailFormMainDiv" runat="server" align="center">
        <table class="DetailFormMainTable">
            <tr align="left">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form"></iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="padding: 10px;">
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblVoce" runat="server" Text="Voce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtVoce" runat="server" CharacterCase="Uppercase" MaxLength="60" Required="True" Width="250px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 328px;">
                                                <iwc:IboWebLabel ID="lblVisibile" runat="server" Text="Visibile:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkVisibile" runat="server" Translate="False" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" MaxLength="255" Required="True" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoNodo" runat="server" Text="Tipo nodo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbTipoNodo" runat="server" SqlQuery="" Required="true" Width="257px">
                                                    <asp:ListItem Text="Link" Value="N" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Text="Funzione" Value="F"></asp:ListItem>
                                                    <asp:ListItem Text="Nodo con figli" Value="P"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblFunzione" runat="server" Text="Funzione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtFunzione" runat="server" CharacterCase="None" MaxLength="255" Rows="4" Width="600px" TextMode="MultiLine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblText" runat="server" Text="Testo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtText" runat="server" CharacterCase="None" MaxLength="255" Width="300px" Required="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 125px;">
                                                <iwc:IboWebLabel ID="lblActionCode" runat="server" Text="Codice azione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtActionCode" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="160px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTooltip" runat="server" Text="Tooltip:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtTooltip" runat="server" CharacterCase="None" MaxLength="255" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblImmagine" runat="server" Text="Immagine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >
                                                <iwc:IboWebTextBox ID="txtImmagine" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDesktopImage" runat="server" Text="Desktop Immagine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >
                                                <iwc:IboWebTextBox ID="txtDesktopImage" runat="server" CharacterCase="none" MaxLength="255" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblSearchTag" runat="server" Text="Search Tag:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtSearchTag" runat="server" CharacterCase="Uppercase" MaxLength="255"
                                                    Width="300px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 125px;">
                                                <iwc:IboWebLabel ID="lblCssClass" runat="server" Text="Css:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtCssClass" runat="server" CharacterCase="None" MaxLength="30" Width="160px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
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
