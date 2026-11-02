<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFANADocumentiAnagrafiche.aspx.vb" Inherits="Incasbo.Web.GDO.WFANADocumentiAnagrafiche" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/Css/WFAnaDocumenti.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1220px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpGeneralita_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpGeneralita_Title_Caption" Text="Generalità del documento" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpGeneralita_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoCaption" runat="server" Text="Cod. Soggetto:"></iwc:IboWebLabel>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 305px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoValue" runat="server" Translate="False" Width="300px"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 72px">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoCaption" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoValue" runat="server" Translate="False"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <%--<td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblId" runat="server" Text="Id:"></iwc:IboWebLabel>
                                            </td>--%>
                                            <td class="DetailFormValueCell" style="width: 135px;">
                                                <iwc:IboWebTextBox ID="txtId" runat="server" MaxLength="10" Width="130px" Required="True" IncasTag="IdentityCounterName=COUNTERS.DOCUMENTIANA" Visible="false"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNumero2" runat="server" Text="x" Display="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblNumero" runat="server" Text="Num. documento:"></iwc:IboWebLabel>

                                            </td>
                                            <td class="DetailFormValueCell" style="width: 305px;">
                                                <iwc:IboWebTextBox ID="txtNumero" runat="server" CharacterCase="Uppercase" MaxLength="30" Width="195px" Required="True"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 73px;">
                                                <iwc:IboWebLabel ID="lblDataRilascio" runat="server" Text="Data Rilascio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 70px;">
                                                <iwc:IboWebDate ID="txtDataRilascio" runat="server" Width="65px" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 111px;">
                                                <iwc:IboWebLabel ID="lblDataInizioValidita" runat="server" Text="Inizio Validità:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 70px;">
                                                <iwc:IboWebDate ID="txtDataInizioValidita" runat="server" Width="65px" Tooltip="Data Inizio Validità" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 67px;">
                                                <iwc:IboWebLabel ID="lblDataFineValidita" runat="server" Text="Fine Validità:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 70px;">
                                                <iwc:IboWebDate ID="txtDataFineValidita" runat="server" Width="65px" Tooltip="Data Fine Validità:" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoDocumento" runat="server" Text="Tipo documento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 700px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoDocumento" runat="server" CharacterCase="Uppercase" SqlQuery="SELECT * FROM CBO_ANA_TipiDocAnagrafiche" Width="695px" AutoPostBack="true" Required="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo1" runat="server" Text="Attributo1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo1" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo2" runat="server" Text="Attributo2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo2" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo3" runat="server" Text="Attributo3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo3" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>                                            
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo4" runat="server" Text="Attributo4:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo4" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo5" runat="server" Text="Attributo5:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo5" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo6" runat="server" Text="Attributo6:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo6" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>                                            
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo7" runat="server" Text="Attributo7:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo7" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo8" runat="server" Text="Attributo8:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo8" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo9" runat="server" Text="Attributo9:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo9" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>                                            
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAttributo10" runat="server" Text="Attributo10:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 280px;">
                                                <iwc:IboWebTextBox ID="txtAttributo10" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="270px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 1080px;">
                                                <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="1075px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpFoto_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpFoto_Title_Caption" Text="Foto documento" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpFoto_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblImmagine1" runat="server" Text="Immagine 1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 310px">
                                                <iwc:IboWebImage runat="server" ID="imgImmagine1" FieldName="Immagine1" FieldNameExtension="Immagine1Tipo" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 72px;">
                                                <iwc:IboWebLabel ID="lblImmagine2" runat="server" Text="Immagine 2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 310px">
                                                <iwc:IboWebImage runat="server" ID="imgImmagine2" FieldName="Immagine2" FieldNameExtension="Immagine2Tipo" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 72px;">
                                                <iwc:IboWebLabel ID="lblImmagine3" runat="server" Text="Immagine 3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 305px">
                                                <iwc:IboWebImage runat="server" ID="imgImmagine3" FieldName="Immagine3" FieldNameExtension="Immagine3Tipo" />
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
