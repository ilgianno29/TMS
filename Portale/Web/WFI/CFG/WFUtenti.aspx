<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFUtenti.aspx.vb" Inherits="Incasbo.Web.CFG.WFUtenti" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Codice Utente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 10px;">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Required="true" Width="100px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione Utente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px" Required="true"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNome" runat="server" IncasTag="" Text="Nome:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtNome" runat="server" MaxLength="60" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCognome" runat="server" IncasTag="" Text="Cognome:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtCognome" runat="server" MaxLength="60" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblIndirizzo" runat="server" IncasTag="" Text="Indirizzo:" FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" FocusedBackColor="" MaxLength="60" ValidationRules="None" Width="600px"
                                                    ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase" FocusedBackColor="" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase" FocusedBackColor="" MaxLength="60" Width="450px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtProvincia" runat="server" CharacterCase="Uppercase" FocusedBackColor="" MaxLength="3" Width="30px" ToolTip="Provincia">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase" FocusedBackColor="" MaxLength="6" Width="40px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblTelefono" runat="server" IncasTag="" Text="Telefono:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtTelefono" runat="server" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCellulare" runat="server" IncasTag="" Text="Cellulare:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="5">
                                                <iwc:IboWebTextBox ID="txtCellulare" runat="server" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblMail" runat="server" IncasTag="" Text="E-Mail:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtEMail" runat="server" MaxLength="255" CharacterCase="None" Width="600px" ValidationRules="Email"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False" CollapsedImage="~/images/expand.png"
                                    CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpInfoGen_Title" ExpandedImage="~/images/collapse.png"
                                    ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image" TargetControlID="cpInfoGen_Body">
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
                                    <iwc:IboWebButton ID="btnCambioPassword" runat="server" Text="Password" CssClass="FormButton_CambiaPassword" />
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
