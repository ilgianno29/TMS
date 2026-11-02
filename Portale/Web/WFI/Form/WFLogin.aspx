<%@ Page Title="Login" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFLogin.aspx.vb" Inherits="Incasbo.Web.WFI.WFLogin" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/LoginPage2.css?d=20180913" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Button ID="Master_DummyButton" runat="server" Text="" Style="display: none" />
    <div class="Titolo">
    </div>
    <div class="Cornice" align="center">
        <table class="LoginTable">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblTitoloApplicazione" runat="server" Text="Titolo Applicazione" CssClass="TitoloApplicazione"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblTitoloModuloSoftware" runat="server" Text="Titolo Modulo Software" CssClass="TitoloModuloSoftware"></asp:Label>
                </td>
            </tr>
            <tr style="height: 40px;">
                <td colspan="2"></td>
            </tr>
            <tr>
                <td align="center" valign="middle">
                    <asp:Image ID="imgLogoApplicazione" runat="server" CssClass="imgLogoApplicazione" />
                </td>
                <td>
                    <asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnConferma">
                        <asp:Panel ID="pnlMessaggioErroreLogin" runat="server" ClientIDMode="Static" Visible="false">
                            <asp:Label ID="lblMessaggioErroreLogin" runat="server" ClientIDMode="Static"></asp:Label>
                        </asp:Panel>
                        <table class="LoginTable2">
                            <tr class="LoginTable2_Title">
                                <td colspan="2">
                                    <asp:Panel ID="pnlTitolo" runat="server" CssClass="Titolo">
                                        <asp:Label ID="lblTitoloLogin" runat="server" Text="Login"></asp:Label>
                                        <asp:Label ID="lblTitoloDBDescription" runat="server" Text="" CssClass="TitoloDBDescription"></asp:Label>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr class="MsgDescription">
                                <td colspan="2">
                                    <iwc:IboWebLabel ID="lblMsg" runat="server" IncasTag=""></iwc:IboWebLabel>
                                </td>
                            </tr>
                            <tr>
                                <td class="LoginDescriptionField">
                                    <iwc:IboWebLabel ID="lblSistema" runat="server" IncasTag="" CssClass="SystemFieldDescription" Visible="false" Text="Sistema:"></iwc:IboWebLabel>
                                </td>
                                <td class="LoginField">
                                    <iwc:IboDropDownList ID="ddlSistema" runat="server" CssClass="SystemField" Visible="false" Style="width: 300px; height: auto;"></iwc:IboDropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="LoginDescriptionField">
                                    <iwc:IboWebLabel ID="lblUser" runat="server" IncasTag="" CssClass="UserFieldDescription">Utente:</iwc:IboWebLabel>
                                </td>
                                <td class="LoginField">
                                    <iwc:IboWebTextBox ID="txtUser" runat="server" MaxLength="15" Width="200px" CssClass="UserField" ToolTip="Insert logon user"></iwc:IboWebTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="LoginDescriptionField">
                                    <iwc:IboWebLabel ID="lblPassword" runat="server" IncasTag="" CssClass="PasswordFieldDescription" Text="Password:"></iwc:IboWebLabel>
                                </td>
                                <td class="LoginField">
                                    <iwc:IboWebTextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="PasswordField" MaxLength="15" Width="200px" ToolTip="Insert password" CharacterCase="None"></iwc:IboWebTextBox>
                                </td>
                            </tr>
                            <tr runat="server" id="tr_IdentityUser">
                                <td class="LoginDescriptionField">
                                    <iwc:IboWebLabel ID="lblIdentityUser" runat="server" IncasTag="" CssClass="UserFieldDescription" Visible="false" Text="Utente assistito:"></iwc:IboWebLabel>
                                </td>
                                <td class="LoginField">
                                    <iwc:IboWebTextBox ID="txtIdentityUser" runat="server" MaxLength="15" Width="200px" CssClass="UserField" Visible="false"></iwc:IboWebTextBox>
                                </td>
                            </tr>
                            <tr runat="server" id="tr_RememberMe" class="tr_RememberMe">
                                <td class="LoginDescriptionField">
                                    <iwc:IboWebLabel ID="IboWebLabel1" runat="server" Style="display: none"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel ID="lblRicorda" runat="server" IncasTag="" CssClass="RicordamiFieldDescription" Visible="false" Text="Ricordami:"></iwc:IboWebLabel>
                                </td>
                                <td class="LoginField RicordamiField">
                                    <iwc:IboWebCheckBox  ID="RememberMe" runat="server" Visible="false" ></iwc:IboWebCheckBox>                                    
                                </td>
                            </tr>
                            <tr>
                                <td class="LoginDescriptionField">
                                    <iwc:IboWebLabel ID="IboWebLabel2" runat="server" Style="display: none"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel ID="lblInserisciPassword" runat="server" IncasTag="" CssClass="PasswordFieldDescription" Visible="False">Nuova password:</iwc:IboWebLabel>
                                </td>
                                <td class="LoginField">
                                    <iwc:IboWebTextBox ID="txtNuovaPassword1" runat="server" CssClass="PasswordField" TextMode="Password" MaxLength="15" Width="200px" Visible="False" CharacterCase="None"></iwc:IboWebTextBox>
                                    <asp:Image runat="server" ID="imageInfo" ImageUrl="~/WFI/Images/QuestionMark.png" ClientIDMode="Static" Visible="False" ImageAlign="AbsMiddle" />
                                </td>
                                <ajaxToolkit:PasswordStrength ID="PasswordStrength" runat="server"
                                    TargetControlID="txtNuovaPassword1"
                                    DisplayPosition="AboveLeft"
                                    StrengthIndicatorType="BarIndicator"
                                    PreferredPasswordLength="8"
                                    PrefixText="Strength:"
                                    TextCssClass="PasswordStrengthTextIndicator"
                                    MinimumNumericCharacters="1"
                                    MinimumSymbolCharacters="1"
                                    RequiresUpperAndLowerCaseCharacters="True"
                                    TextStrengthDescriptions="Very Poor;Weak;Average;Strong;Excellent"
                                    CalculationWeightings="50;15;15;20"
                                    MinimumUpperCaseCharacters="1"
                                    BarBorderCssClass="BarIndicatorBorder"
                                    StrengthStyles="BarIndicator_weak;BarIndicator_average;BarIndicator_good" MinimumLowerCaseCharacters="1" />
                            </tr>
                            <tr>
                                <td class="LoginDescriptionField">
                                    <iwc:IboWebLabel ID="lblConfermaPassword" runat="server" IncasTag="" CssClass="PasswordFieldDescription" Visible="false">Conferma password:</iwc:IboWebLabel>
                                </td>
                                <td class="LoginField">
                                    <iwc:IboWebTextBox ID="txtNuovaPassword2" runat="server" CssClass="PasswordField" TextMode="Password" MaxLength="15" Width="200px" Visible="False" CharacterCase="None"></iwc:IboWebTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Button ID="Button1" runat="server" Text="" Style="display: none" />
                                    <table class="tableLoginButtons">
                                        <tr>
                                            <td class="tableButtons_L">
                                                <iwc:IboWebButton ID="btnAnnulla" CssClass="btnAnnulla" runat="server" Text="Esci" ClientIDMode="Static" CausesValidation="False" />
                                                <iwc:IboWebButton ID="btnCambioPsw" CssClass="btnCambioPsw" runat="server" Text="Cambio Pwd" ClientIDMode="Static" CausesValidation="False" />
                                            </td>
                                            <td class="tableButtons_R">
                                                <iwc:IboWebButton ID="btnConferma" CssClass="btnConferma" runat="server" Text="Conferma" ClientIDMode="Static" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </div>
    <div class="Versione">
        <table class="VersioneTable">
            <tr>
                <td>
                    <asp:Label ID="lblVersione" runat="server" Text="Ver: "></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
