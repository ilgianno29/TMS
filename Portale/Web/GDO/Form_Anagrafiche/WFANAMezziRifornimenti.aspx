<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAMezziRifornimenti.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAMezziRifornimenti" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="900px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoCaption" runat="server" Text="Codice Soggetto:"></iwc:IboWebLabel>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoValue" runat="server" Translate="False" ></iwc:IboWebLabel>
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
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAutista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px" colspan="3">
                                                <iwc:IboWebComboTlk ID="cmbAutista" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Autisti" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" FieldDescription="Punto partenza" Width="400px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblIdViaggio" runat="server" Text="Id Viaggio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebTextBox ID="txtIdViaggio" runat="server" CharacterCase="Uppercase" Width="100px" Enabled="false"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoRifornimento" runat="server" Text="Tipo Rifor.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px" colspan="3">
                                                <iwc:IboWebComboTlk ID="cmbTipoRifornimento" runat="server" SqlQuery="SELECT * FROM CBO_ANA_MEZZI_TIPIRIFOR" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" FieldDescription="Tipologia Rifornimento" Required="true" Width="400px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataOra" runat="server" Text="Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px">
                                                <iwc:IboWebDate2 ID="txtDataOra" runat="server" Width="100px" ControlType="DateAndTime" Required="true" Tooltip="Ora Rifornimento" />
                                            </td>

                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblLitri" runat="server" Text="Litri(Lt):"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebNumericTlk ID="txtLitri" runat="server" Width="55px" ToolTip="Litri Rifornimento" Required="true">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 95px;">
                                                <iwc:IboWebLabel ID="lblLitriAdditivo" runat="server" Text="Additivo(Lt):"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebNumericTlk ID="txtLitriAdditivo" runat="server" Width="55px" ToolTip="Litri Additivo" Required="true">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="lblKm" runat="server" Text="Km Mezzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebNumericTlk ID="txtKm" runat="server" Width="55px" ToolTip="Km Mezzo" Required="true">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 550px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="550px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                <iwc:IboWebLabel ID="lblLatitudine" runat="server" Text="Lat:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLatitudine" runat="server" Width="100px" Enabled="false" ToolTip="Latitudine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 100px;"></td>
                                            <td class="DetailFormValueCell" style="width: 550px;">
                                                <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="431px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                <iwc:IboWebLabel ID="lblLongitudine" runat="server" Text="Lon:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLongitudine" runat="server" Width="100px" Enabled="false" ToolTip="Longitudine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox ID="txtMezzo" runat="server" Style="display: none;"></iwc:IboWebTextBox>
                                    <%--<iwc:IboWebTextBox ID="IdViaggio" runat="server" Style="display: none;" FieldName="IdViaggio"></iwc:IboWebTextBox>--%>
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
