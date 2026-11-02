<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFTPAgentFolders.aspx.vb" Inherits="Incasbo.Web.CFG.WFFTPAgentFolders" %>

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
                                    <div runat="server" style="min-height: 155px;">
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
                                        <asp:UpdatePanel ID="upnlTipo" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblTipo" runat="server" Text="Tipo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 125px;">
                                                            <iwc:IboDropDownList ID="cmbTipo" runat="server" Required="true" Width="120px" AutoPostBack="true" >
                                                                <asp:ListItem Value="F" Text="FTP Server"></asp:ListItem>
                                                                <asp:ListItem Value="R" Text="Rete"></asp:ListItem>
                                                            </iwc:IboDropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <asp:Panel runat="server" ID="pnlLocalPath">
                                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblLocalPath" runat="server" Text="Path locale:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 372px;">
                                                                <iwc:IboWebTextBox ID="txtLocalPath" runat="server" MaxLength="255" Width="367px" ToolTip="Percorso di rete associato" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlFTPServer">
                                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblFTPServer" runat="server" Text="FTP Server:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 160px;">
                                                                <iwc:IboWebTextBox ID="txtFTPServer" runat="server" MaxLength="100" Width="165px" CharacterCase="None" ToolTip="Nome o indirizzo IP del server FTP"></iwc:IboWebTextBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 53px;">
                                                                <iwc:IboWebLabel ID="lblFTPPorta" runat="server" Text="Porta:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 55px;">
                                                                <iwc:IboWebNumericTlk ID="txtFTPPorta" runat="server" Width="50px" MinValue="0" DecimalDigits="0" ToolTip="Porta del server FTP " Required="true" FieldDescription="Porta">
                                                                </iwc:IboWebNumericTlk>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 94px">
                                                                <iwc:IboWebLabel ID="lblFTPUseSSL" runat="server" Text="SSL:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 10px">
                                                                <iwc:IboWebCheckBox ID="chkFTPUseSSL" runat="server" Checked="True" Value="S" ToolTip="Usa SSL"></iwc:IboWebCheckBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblFTPMode" runat="server" Text="Modalità:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 85px;">
                                                                <iwc:IboDropDownList ID="cmbFTPMode" runat="server" Width="80px">
                                                                    <asp:ListItem Value="A" Text="Attivo"></asp:ListItem>
                                                                    <asp:ListItem Value="P" Text="Passivo"></asp:ListItem>
                                                                </iwc:IboDropDownList>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblFTPUser" runat="server" Text="User:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 160px;">
                                                                <iwc:IboWebTextBox ID="txtFTPUser" runat="server" MaxLength="30" Width="165px" ToolTip="Username per il login sul server FTP" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 53px;">
                                                                <iwc:IboWebLabel ID="lblFTPPassword" runat="server" Text="Password:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 160px;">
                                                                <iwc:IboWebTextBox ID="txtFTPPassword" runat="server" MaxLength="30" Width="165px" ToolTip="Password per il login sul server FTP" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                <iwc:IboWebLabel ID="lblFTPBinary" runat="server" Text="Trasferimento:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 50px">
                                                                <iwc:IboWebRadioButtonList ID="optFTPBinary" runat="server" ToolTip="Modalità di trasferimento" RepeatDirection="Horizontal">
                                                                    <asp:ListItem Value="S" Text="Binary"></asp:ListItem>
                                                                    <asp:ListItem Value="N" Text="Ascii" Selected="True"></asp:ListItem>
                                                                </iwc:IboWebRadioButtonList>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table class="DetailFormSectionTable2Fixed">
                                                        <tr>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblFTPPath" runat="server" Text="Path FTP:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 403px;">
                                                                <iwc:IboWebTextBox ID="txtFTPPath" runat="server" MaxLength="255" Width="398px" ToolTip="Percorso di rete associato al server FTP" CharacterCase="None"></iwc:IboWebTextBox>
                                                            </td>
                                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                <iwc:IboWebLabel ID="lblFTPTimeout" runat="server" Text="Timeout:"></iwc:IboWebLabel>
                                                            </td>
                                                            <td class="DetailFormValueCell" style="width: 78px;">
                                                                <iwc:IboWebNumericTlk ID="txtFTPTimeout" runat="server" Width="73px" MinValue="0" DecimalDigits="0" ToolTip="Timeout per il trasferimento con il server FTP">
                                                                </iwc:IboWebNumericTlk>
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
