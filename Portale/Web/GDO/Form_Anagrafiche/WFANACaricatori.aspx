<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFANACaricatori.aspx.vb" Inherits="Incasbo.Web.GDO.WFANACaricatori" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
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
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1000px">

                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Anagrafica" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 105px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="100px" Required="true">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 260px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 123px">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblRagioneSociale" runat="server" Text="Ragione Sociale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtRagioneSociale" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblTelefono" runat="server" Text="Telefono:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 145px;">
                                                <iwc:IboWebTextBox ID="txtTelefono" runat="server" CharacterCase="Uppercase" MaxLength="15" FieldName="Telefono" Width="140px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblFax" runat="server" Text="Fax:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 145px;">
                                                <iwc:IboWebTextBox ID="txtFax" runat="server" CharacterCase="Uppercase" MaxLength="15" FieldName="Fax" Width="140px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 100px;"></td>
                                            <td class="DetailFormValueCell" style="width: 620px;">
                                                <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="452px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtProvincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" ToolTip="Provincia">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                <iwc:IboWebLabel ID="lblCodiceFiscale" runat="server" Text="Codice Fiscale:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 145px;">
                                                <iwc:IboWebTextBox ID="txtCodiceFiscale" runat="server" CharacterCase="Uppercase" MaxLength="16" FieldName="CodiceFiscale" Width="140px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblEmail" runat="server" Text="Email:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtEmail" runat="server" CharacterCase="None" MaxLength="255" FieldName="Email" ValidationRules="Email" Width="612px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblPartitaIva" runat="server" Text="Partita Iva:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 145px;">
                                                <iwc:IboWebTextBox ID="txtPartitaIva" runat="server" CharacterCase="Uppercase" MaxLength="16" FieldName="PartitaIva" Width="140px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 852px;">
                                                <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" MaxLength="255" Rows="3" TextMode="MultiLine" FieldName="Note" Width="847px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>

                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <asp:Button ID="Button1_idle" runat="server" Text="" Style="display: none" />
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <asp:HyperLink runat="server" ID="tst" Text="prova" target="_blank"  NavigateUrl ="~/GDO/Form/WFTest.aspx"></asp:HyperLink></td>
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
