<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAPCSGeocodifica.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAPCSGeocodifica" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFANAPCSGeocodifica.css?20161219" type="text/css" />
     <script type="text/javascript">
        var xMapServer = "<%= xMap_Server %>";                      // indirizzo xMapServer per visualizzazione dei Truck Attributes su mappa
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <script type="text/javascript" src="../Scripts/mapGenericsFuncs.js"></script>
    <script type="text/javascript" src="../Scripts/mapDrawFuncs.js"></script>
    <script type="text/javascript" src="../Scripts/mapDrawMapObject.js"></script>
    <script type="text/javascript" src="../Scripts/WFANAPCSGeocodifica.js">
    </script>
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv" DefaultButton="btnConferma">
        <table class="DetailFormMainTable">
            <tr>
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form">
                                    </iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text="Modalità">
                                    </iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <table>
                                    <tr>
                                        <td style="width: 500px; height: 100px; vertical-align: top;">
                                            <asp:Panel runat="server" ID="cpIndOrig_Title" CssClass="CollapsiblePanelTitle" Width="500">
                                                <asp:Label runat="server" ID="cpIndOrig_Title_Caption" Text="Indirizzo originale"
                                                    CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpIndOrig_Body" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormValueCell" style="width: 150px">
                                                            <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" ReadOnly="true" Width="150px" ToolTip="Codice anagrafica" Style="margin-right: 5px;">
                                                            </iwc:IboWebTextBox>

                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2">
                                                    <tr>
                                                        <td class="DetailFormValueCell" style="width: 486px">
                                                            <iwc:IboWebTextBox ID="RagioneSociale" runat="server" CharacterCase="Uppercase" ReadOnly="true" Width="99%" ToolTip="Ragione sociale" Style="margin-right: 5px;">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormValueCell" style="width: 486px">
                                                            <iwc:IboWebTextBox ID="Indirizzo" runat="server" CharacterCase="Uppercase" ReadOnly="true" Width="99%" ToolTip="Indirizzo (via, piazza, ...)" Style="margin-right: 5px;">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormValueCell" style="width: 486px">
                                                            <iwc:IboWebTextBox ID="Cap" runat="server" CharacterCase="Uppercase" ReadOnly="true" MaxLength="10" Width="44px" ToolTip="Cap">
                                                            </iwc:IboWebTextBox>
                                                            <iwc:IboWebTextBox ID="Localita" runat="server" CharacterCase="Uppercase" ReadOnly="true" MaxLength="60" Width="355px" ToolTip="Località">
                                                            </iwc:IboWebTextBox>
                                                            <iwc:IboWebTextBox ID="Provincia" runat="server" CharacterCase="Uppercase" ReadOnly="true" MaxLength="3" Width="27px" ToolTip="Provincia">
                                                            </iwc:IboWebTextBox>
                                                            <iwc:IboWebTextBox ID="Nazione" runat="server" CharacterCase="Uppercase" ReadOnly="true" MaxLength="6" Width="25px" ToolTip="Nazione">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </asp:Panel>
                                        </td>
                                        <td rowspan="4" style="width: 800px;">
                                            <asp:Panel runat="server" ID="cpMap_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpMap_Title_Caption" Text="Mappa" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpMap_Body" CssClass="CollapsiblePanelBody">
                                                <asp:UpdatePanel runat="server" ID="upMap" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <asp:panel runat="server" id="mapContainer"  ClientIDMode="Static" cssclass="MapContainerDivClass" style="height:calc(100vh - 300px);min-height:500px;width:calc(100vw - 600px);min-width:500px;">
                                                        </asp:panel>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                                <asp:Panel runat="server" id="NoGeocodingExist" ClientIDMode="Static" cssclass="NoGeocodingExistDivClass" style="height:calc(100vh - 300px);min-height:500px;width:calc(100vw - 600px);min-width:500px;">
                                                    <asp:Label runat="server" ID="lblNoGeocodingExist" Text="Punto non geolocalizzato" CssClass="NoGeocodingExistLabelClass"></asp:Label>
                                                </asp:Panel>
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 500px; height: 100px; vertical-align: top;">
                                            <asp:Panel runat="server" ID="cpIndNorm_Title" CssClass="CollapsiblePanelTitle" Width="500">
                                                <asp:Label runat="server" ID="cpIndNorm_Title_Caption" Text="Indirizzo geolocalizzato"
                                                    CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:UpdatePanel runat="server" ID="upIndNorm" UpdateMode="Conditional" ChildrenAsTriggers="true">
                                                <ContentTemplate>
                                                    <asp:Panel runat="server" ID="cpIndNorm_Body" CssClass="CollapsiblePanelBody" Width="500">
                                                        <asp:HiddenField ID="HFLatitudine" runat="server" ClientIDMode="Static" />
                                                        <asp:HiddenField ID="HFLongitudine" runat="server" ClientIDMode="Static" />
                                                        <asp:HiddenField ID="HFReverseGeocodingNeeded" runat="server" ClientIDMode="Static" />
                                                        <iwc:IboWebButton ID="btnReverseGeocoding" runat="server" Text="" ClientIDMode="Static" Style="position: absolute; left: -1000px; width: 0px; height: 0px;" />
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormValueCell" colspan="5" style="width: 435px">
                                                                    <iwc:IboWebTextBox ID="txtIndirizzoNormalizzato" runat="server" CharacterCase="Uppercase" Width="432px" ReadOnly="true" ToolTip="Indirizzo (via, piazza, ...)" Style="margin-right: 5px;">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 50px">
                                                                    <iwc:IboWebTextBox ID="txtNumeroCivicoNormalizzato" runat="server" CharacterCase="Uppercase" Width="40px" ReadOnly="true" ToolTip="Numero civico">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormValueCell" style="width: 337px">
                                                                    <iwc:IboWebTextBox ID="txtLocalitaNormalizzata" runat="server" CharacterCase="Uppercase" Width="332px" ReadOnly="true" ToolTip="Località">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px">
                                                                    <iwc:IboWebTextBox ID="txtQuartiereNormalizzato" runat="server" CharacterCase="Uppercase" Width="145px" ReadOnly="true" ToolTip="Quartiere, frazione, ecc.">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormValueCell" style="width: 75px">
                                                                    <iwc:IboWebTextBox ID="txtCapNormalizzato" runat="server" ReadOnly="true" CharacterCase="Uppercase" Width="70px" ToolTip="Cap">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 50px">
                                                                    <iwc:IboWebTextBox ID="txtProvinciaNormalizzata" runat="server" ReadOnly="true" CharacterCase="Uppercase" Width="45px" ToolTip="Provincia">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 75px">
                                                                    <iwc:IboWebTextBox ID="txtNazioneNormalizzata" runat="server" ReadOnly="true" CharacterCase="Uppercase" Width="70px" ToolTip="Nazione">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormValueCell" style="height: 10px">
                                                                    <iwc:IboWebTextBox ID="txtFormatoCoordinate" runat="server" CharacterCase="Uppercase" Width="92%" ReadOnly="true" Visible="false" Style="margin-right: 5px;">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormValueCell" style="width: 75px">
                                                                    <iwc:IboWebTextBox ID="txtLatitudine" runat="server" CharacterCase="Uppercase" Width="70px" ReadOnly="true" ToolTip="Latitudine" ClientIDMode="Static">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 75px">
                                                                    <iwc:IboWebTextBox ID="txtLongitudine" runat="server" CharacterCase="Uppercase" Width="70px" ReadOnly="true" ToolTip="Longitudine" ClientIDMode="Static">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 130px">
                                                                    <iwc:IboWebTextBox ID="DescrizioneTipoGeocodifica" runat="server" CharacterCase="Uppercase" SqlQueryLookup="SELECT Descrizione FROM TipiGeocodifica WHERE Codice='<#MASTER_RECORD.TipoGeocodifica#>'" ReadOnly="true" Width="125px" ToolTip="Tipo di geocodifica (manuale, automatica, ecc.)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <iwc:IboWebHidden runat="server" ID="hdnConfigId" FieldName="TipoGeocodifica" />
                                                        <iwc:IboWebHidden runat="server" ID="hdnIdRicerca" FieldName="IdRicerca" />
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 500px; height: 100px; vertical-align: bottom;">
                                            <asp:Panel runat="server" ID="cpRate_Title" CssClass="CollapsiblePanelTitle" Width="500">
                                                <asp:Label runat="server" ID="cpRate_Title_Caption" Text="Ricerca e Punteggio" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:UpdatePanel runat="server" ID="upRate" UpdateMode="Conditional" ChildrenAsTriggers="true">
                                                <ContentTemplate>
                                                    <asp:Panel runat="server" ID="cpRate_Body" CssClass="CollapsiblePanelBody">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Width="50px" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 322px">
                                                                    <iwc:IboWebTextBox ID="txtIndirizzoRicerca" runat="server" Width="317px" ReadOnly="true" ToolTip="Indirizzo utilizzato per la ricerca">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblCap" runat="server" Width="50px" Text="CAP:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 45px;">
                                                                    <iwc:IboWebTextBox ID="txtCapRicerca" runat="server" Width="40px" ReadOnly="true" ToolTip="CAP utilizzato per la ricerca">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblLocalita" runat="server" Width="50px" Text="Località:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 322px">
                                                                    <iwc:IboWebTextBox ID="txtLocalitaRicerca" runat="server" Width="317px" ReadOnly="true" ToolTip="Località utilizzata per la ricerca">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblNazione" runat="server" Width="50px" Text="Nazione:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 45px">
                                                                    <iwc:IboWebTextBox ID="txtNazioneRicerca" runat="server" Width="40px" ReadOnly="true" ToolTip="Nazione utilizzata per la ricerca">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr style="height: 15px">
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 51px">
                                                                    <iwc:IboWebLabel ID="lblPunteggioTotale" runat="server" Width="51px" Text="Totale:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebTextBox ID="txtPunteggioTotale" runat="server" Width="20px" ReadOnly="true" ToolTip="Punteggio totale della geocodifica (0-100)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 350px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneIndirizzo" runat="server" Display="false" CharacterCase="None">
                                                                    </iwc:IboWebTextBox>
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneIndDescrizione" runat="server" Display="false" CharacterCase="None">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr style="display: none;">
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblClassificazione" runat="server" Width="50px" Text="Classificazione:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazione" runat="server" Width="20px" CharacterCase="None" ReadOnly="true" ToolTip="Classificazione numerica del risultato basata sulla qualità del match (0-5)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 135px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneDescrizione" runat="server" Width="130px" CharacterCase="None" ReadOnly="true" ToolTip="Descrizione della classificazione del risultato (NOT_CLASSIFIED - LOW - MEDIUM - HIGH - EXACT - UNIQUE)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr style="display: none;">
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblLivelloDettaglio" runat="server" Width="50px" Text="Liv. dettaglio:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebTextBox ID="txtLivelloDettaglio" runat="server" Width="20px" CharacterCase="None" ReadOnly="true" ToolTip="Informazione numerica che fornisce informazioni sul livello di dati su cui è stato fatto il match (0-11)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 135px">
                                                                    <iwc:IboWebTextBox ID="txtLivelloDettaglioDescrizione" runat="server" Width="130px" CharacterCase="None" ReadOnly="true" ToolTip="Descrizione dell livello di dettaglio (COUNTRY - STATE - EXTPOSTCODE - CITY - CITY2 - POSTCODE - STREET - HNRSECTION - HNRLINK - HNRINTERPOLATED - HNREXACT - INTERSECTION)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblClassificazioneVia" runat="server" Width="50px" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneVia" runat="server" Width="20px" CharacterCase="None" ReadOnly="true" ToolTip="Classificazione numerica del campo Indirizzo del risultato basata sulla qualità del match">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneViaDescrizione" runat="server" Width="145px" CharacterCase="None" FieldName="" ReadOnly="true" ToolTip="Descrizione della classificazione dell'indirizzo (EXACT - PARTIALLY EXACT - HIGH - MEDIUM - LOW - NOINPUT - NORESULT)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                    <iwc:IboWebLabel ID="lblClassificazioneCivico" runat="server" Width="55px" Text="Nr. Civico:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneCivico" runat="server" Width="20px" CharacterCase="None" ReadOnly="true" ToolTip="Classificazione numerica del campo Numero Civico del risultato basata sulla qualità del match">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneCivicoDescrizione" runat="server" Width="145px" CharacterCase="None" FieldName="" ReadOnly="true" ToolTip="Descrizione della classificazione del numero civico (EXACT - PARTIALLY EXACT - HIGH - MEDIUM - LOW - NOINPUT - NORESULT)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 55px">
                                                                    <iwc:IboWebLabel ID="lblClassificazioneLocalita" runat="server" Width="50px" Text="Località:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneLocalita" runat="server" Width="20px" CharacterCase="None" ReadOnly="true" ToolTip="Classificazione numerica dei campi Località e Quartiere del risultato basata sulla qualità del match">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneLocalitaDescrizione" runat="server" Width="145px" CharacterCase="None" FieldName="" ReadOnly="true" ToolTip="Descrizione della classificazione della località (EXACT - PARTIALLY EXACT - HIGH - MEDIUM - LOW - NOINPUT - NORESULT)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 60px">
                                                                    <iwc:IboWebLabel ID="lblClassificazioneCAP" runat="server" Width="55px" Text="CAP:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneCAP" runat="server" Width="20px" CharacterCase="None" ReadOnly="true" ToolTip="Classificazione numerica del campo CAP del risultato basata sulla qualità del match">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 150px">
                                                                    <iwc:IboWebTextBox ID="txtClassificazioneCAPDescrizione" runat="server" Width="145px" CharacterCase="None" FieldName="" ReadOnly="true" ToolTip="Descrizione della classificazione del CAP (EXACT - PARTIALLY EXACT - HIGH - MEDIUM - LOW - NOINPUT - NORESULT)">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                    <tr><td></td></tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="Td1" class="tableButtons_C">
                                    <asp:UpdatePanel runat="server" ID="upButtonGeocodifica" UpdateMode="Conditional" ChildrenAsTriggers="true">
                                        <ContentTemplate>
                                            <iwc:IboWebButton ID="btnGeocodifica" runat="server" Text="Cerca" CssClass="BtnGeocodifica" Visible="true" />
                                            <iwc:IboWebButton ID="btnConfermaPosizione" runat="server" Text="Conferma posizione" CssClass="btnConfermaPosizione" Visible="true" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    
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
    <asp:UpdatePanel runat="server" ID="UPPopupFormGlobalContainer" ChildrenAsTriggers="true" UpdateMode="Conditional" Visible="true">
        <ContentTemplate>
            <asp:Panel ID="PopupFormGlobalContainer" runat="server" Visible="false">
                <asp:Panel ID="PopupFormContainer" runat="server" CssClass="MapGeocodingPopupFormContainer" Style="display: none;">
                    <asp:Panel ID="PopupFormTitleBar" runat="server" CssClass="PopupFormTitleBar">
                        <iwc:IboWebLabel ID="PopupFormCaption" runat="server" Text="..." CssClass="PopupFormCaption">
                        </iwc:IboWebLabel>
                    </asp:Panel>
                    <asp:UpdatePanel runat="server" ID="UPPopupForm" ChildrenAsTriggers="true" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Panel ID="PopupFormBody" runat="server" CssClass="PopupFormBody">
                                <asp:Panel ID="ElencoLocalitaMappa" runat="server" Visible="false" Style="height: 400px; overflow: auto;" DefaultButton="btnGeocodificaPopup">
                                    <table style="width: 100%">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                <iwc:IboWebLabel ID="lblIndirizzoMappa" runat="server" Text="Indirizzo:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzoMappa" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="100%" FieldName="" ToolTip="Indirizzo e numero civico">
                                                </iwc:IboWebTextBox>
                                                <%-- <iwc:IboWebTextBox ID="txtCivicoMappa" runat="server" FieldName="" Visible="false">
                                                </iwc:IboWebTextBox>--%>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="IboWebLabel1" runat="server" Text="">
                                                </iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblCapMappa" runat="server" Text="Cap:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="txtCapMappa" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="100%" ToolTip="Cap" FieldName="">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td style="width: 100px;"></td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebHidden runat="server" ID="hdnConfigIdMappa" FieldName="" />
                                                <iwc:IboWebHidden runat="server" ID="hdnIdRicercaMappa" FieldName="" />
                                            </td>
                                            <td></td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                <iwc:IboWebLabel ID="lblLocalitaMappa" runat="server" Text="Località:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtLocalitaMappa" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="100%" ToolTip="Località" FieldName="">
                                                </iwc:IboWebTextBox>
                                                <%--<iwc:IboWebTextBox ID="txtQuartiereMappa" runat="server" FieldName="" Visible="false">
                                                </iwc:IboWebTextBox>--%>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="IboWebLabel2" runat="server" Text="">
                                                </iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblNazioneMappa" runat="server" Text="Nazione:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="txtNazioneMappa" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="100%" ToolTip="Nazione" FieldName="">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td style="width: 100px;"></td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebButton ID="btnGeocodificaPopup" runat="server" Text="Cerca" CssClass="BtnGeocodifica" />
                                            </td>
                                            <td></td>
                                        </tr>
                                        <tr>
                                            <td colspan="7">
                                                <hr />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="7">
                                                <asp:GridView ID="grdElencoLocalitaMappa" runat="server" CaptionAlign="Left" AutoGenerateColumns="False" PageSize="9999" BorderStyle="None" Width="100%" EmptyDataText="No record found" Enabled="True" ShowHeaderWhenEmpty="True">
                                                    <HeaderStyle BackColor="#FF9900" BorderColor="#ADADAD" BorderStyle="Solid" BorderWidth="1px" CssClass="HeaderStyle" />
                                                    <RowStyle BackColor="#FFFFDD" BorderStyle="Solid" BorderColor="#CDCDCD" BorderWidth="1px" CssClass="RowStyle" />
                                                    <SelectedRowStyle BackColor="#FF7D7D" BorderColor="#CDCDCD" BorderStyle="Solid" BorderWidth="1px" />
                                                    <AlternatingRowStyle BorderColor="#CDCDCD" BorderStyle="Solid" BorderWidth="1px" BackColor="#FFFFBB" CssClass="AlternateStyle" />
                                                    <Columns>
                                                        <asp:CommandField ButtonType="Image" SelectImageUrl="~/images/Select-icon.png" ShowSelectButton="True">
                                                            <ItemStyle CssClass="BtnSeleziona" Width="5px" />
                                                        </asp:CommandField>
                                                        <asp:BoundField DataField="Cap" HeaderText="Cap">
                                                            <HeaderStyle Width="5px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Localita" HeaderText="Località">
                                                            <HeaderStyle Width="200px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Localita2" HeaderText="Quartiere">
                                                            <HeaderStyle Width="200px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Via" HeaderText="Via">
                                                            <HeaderStyle Width="200px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Civico" HeaderText="Civ.">
                                                            <HeaderStyle Width="10px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Nazione" HeaderText="Naz.">
                                                            <HeaderStyle Width="5px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Latitudine" HeaderText="Lat.">
                                                            <HeaderStyle Width="5px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Longitudine" HeaderText="Long.">
                                                            <HeaderStyle Width="5px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="PunteggioTotale" HeaderText="Punteggio Totale">
                                                            <HeaderStyle Width="5px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="Classificazione" HeaderText="Classific." Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="ClassificazioneDescrizione" HeaderText="Descr. Classific." Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="LivelloDettaglio" HeaderText="Liv. Dettaglio" Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="LivelloDettaglioDescrizione" HeaderText="Descr. Livello Dettaglio" Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="ClassificazioneIndirizzo" HeaderText="Classific. Indirizzo" Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="ClassificazioneIndirizzoDescrizione" HeaderText="Descr. Classific. Indirizzo" Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="ClassificazioneCAP" HeaderText="Classific. CAP" Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="ClassificazioneLocalita" HeaderText="Classific. Località" Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="ClassificazioneVia" HeaderText="Classific. Via" Visible="false"></asp:BoundField>
                                                        <asp:BoundField DataField="ClassificazioneCivico" HeaderText="Classific. Civico" Visible="false"></asp:BoundField>
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Panel ID="PopupFormButtons" runat="server" CssClass="PopupFormButtons">
                        <table class="tableButtons">
                            <tr>
                                <td class="tableButtons_L">
                                    <iwc:IboWebButton ID="PopupForm_cmdAnnulla" CssClass="PopupForm_cmdAnnulla" runat="server" Text="Esci" CausesValidation="False" ClientIDMode="Static" />
                                </td>

                                <td class="tableButtons_R">
                                    <iwc:IboWebButton ID="PopupForm_cmdOk" CssClass="PopupForm_cmdOk" runat="server" Text="Conferma" ClientIDMode="Static" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </asp:Panel>
                <asp:Button runat="server" ID="hiddenTargetControlForPopupForm" Style="display: none" />
                <ajaxToolkit:ModalPopupExtender runat="server" ID="PopupForm" TargetControlID="hiddenTargetControlForPopupForm"
                    PopupControlID="PopupFormContainer" BackgroundCssClass="PopupFormBackground"
                    RepositionMode="RepositionOnWindowResize" Drag="True" PopupDragHandleControlID="PopupFormTitleBar"
                    DropShadow="True" CancelControlID="" OkControlID="">
                </ajaxToolkit:ModalPopupExtender>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
