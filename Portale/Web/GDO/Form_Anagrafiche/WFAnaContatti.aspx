<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFAnaContatti.aspx.vb" Inherits="Incasbo.Web.GDO.WFAnaContatti" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cp01_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cp01_Title_Caption" Text="Generalità del contatto" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cp01_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoCaption" runat="server" Text="Codice Soggetto:"></iwc:IboWebLabel>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoValue" runat="server" Translate="False"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoCaption" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoValue" runat="server" Translate="False"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <%--<td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblId" runat="server" Text="Id:"></iwc:IboWebLabel>
                                            </td>--%>
                                            <td class="DetailFormValueCell" style="width: 135px;">
                                                <iwc:IboWebTextBox ID="txtId" runat="server" MaxLength="10" Width="130px" Required="True" IncasTag="IdentityCounterName=COUNTERS.CONTATTI" Visible="false"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDescrizione2" runat="server" Text="x" Display="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 605px;">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="600px" Required="True"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoContatto" runat="server" Text="Tipo Contatto:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 612px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoContatto" runat="server"  SqlQuery="SELECT * FROM CBO_ANA_TipiContatto" Width="607px" Required="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTelefono" runat="server" Text="Telefono:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 155px">
                                                <iwc:IboWebTextBox ID="txtTelefono" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                <iwc:IboWebLabel ID="lblCellulare" runat="server" Text="Cellulare:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 155px">
                                                <iwc:IboWebTextBox ID="txtCellulare" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                <iwc:IboWebLabel ID="lblFax" runat="server" Text="Fax:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 155px">
                                                <iwc:IboWebTextBox ID="txtFax" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblEmail" runat="server" Text="E-Mail:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 605px;">
                                                <iwc:IboWebTextBox ID="txtEmail" runat="server" CharacterCase="None" MaxLength="255" Width="600px" ValidationRules="Email"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 605px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="548px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="TxtNumeroCivico" runat="server" Width="40px" CharacterCase="Uppercase" MaxLength="10" ToolTip="Numero civico">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 100px;"></td>
                                            <td class="DetailFormValueCell" style="width: 605px;">
                                                <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="440px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtProvincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" ToolTip="Provincia">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAltro" runat="server" Text="Altro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 605px;">
                                                <iwc:IboWebTextBox ID="txtAltro" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 605px;">
                                                <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="600px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
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
