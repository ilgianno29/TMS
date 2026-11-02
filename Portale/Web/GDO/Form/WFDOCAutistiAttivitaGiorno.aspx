<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCAutistiAttivitaGiorno.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCAutistiAttivitaGiorno" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFDOCAutistiAttivitaGiorno.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1200px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblAutista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 85px">
                                                <iwc:IboWebTextBox ID="txtAutista" runat="server" Width="80px" ReadOnly="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebTextBox ID="AutistaDescrizione" runat="server" Width="395px" SqlQueryLookup="SELECT RagioneSociale FROM Autisti WHERE CODICE='<#MASTER_RECORD.Autista#>'"
                                                    ReadOnly="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 75px">
                                                <iwc:IboWebLabel ID="lblData" runat="server" Text="Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 70px">
                                                <iwc:IboWebTextBox ID="txtDataStringa" runat="server" Visible="false"></iwc:IboWebTextBox>
                                                <%--  <iwc:IboWebDate2 runat="server" ID="txtData" ControlType="DateOnly" CalendarVisibleIfDisabled="false" Enabled="false" Width="65px" />--%>
                                                <iwc:IboWebTextBox ID="txtData" runat="server" ReadOnly="true" FormatString="{0:dd/MM/yyyy}" Width="65px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblMotrice" runat="server" Text="Motrice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 85px">
                                                <iwc:IboWebTextBox ID="txtMotrice" runat="server" Width="80px" ReadOnly="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebTextBox ID="MotriceDescrizione" runat="server" Width="395px" SqlQueryLookup="SELECT TARGA + '  (' + Descrizione + ')' FROM Mezzi WHERE CODICE='<#MASTER_RECORD.Motrice#>'"
                                                    ReadOnly="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 75px">
                                                <iwc:IboWebLabel ID="lblRimorchio" runat="server" Text="Rimorchio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 70px">
                                                <iwc:IboWebTextBox ID="txtRimorchio1" runat="server" Width="65px" ReadOnly="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebTextBox ID="RimorchioDescrizione" runat="server" Width="395px" SqlQueryLookup="SELECT TARGA + '  (' + Descrizione + ')' FROM Mezzi WHERE CODICE='<#MASTER_RECORD.Rimorchio1#>'"
                                                    ReadOnly="true"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpPartenza_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpPartenza_Title_Caption" Text="Partenza" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpPartenza_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblIndirizzoInizio" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <%-- <td class="DetailFormValueCell" style="width: 567px;">
                                                <iwc:IboWebTextBox ID="IndirizzoInizio" runat="server" CharacterCase="Uppercase" ReadOnly="true" Width="562px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                <iwc:IboWebLabel ID="lblLatitudineInizio" runat="server" Text="Lat:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLatitudineInizio" runat="server" Width="100px" ReadOnly="true" ToolTip="Latitudine"></iwc:IboWebTextBox>
                                            </td>--%>
                                            <td class="DetailFormValueCell" style="width: 450px;">
                                                <iwc:IboWebTextBox ID="LocalitaInizio" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="412px" ToolTip="Località" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="ProvinciaInizio" runat="server" CharacterCase="Uppercase" MaxLength="5" Width="20px" ToolTip="Provincia" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                <iwc:IboWebLabel ID="lblKmInizio" runat="server" Text="Km:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <%-- <iwc:IboWebNumericTlk runat="server" ID="KmInizio" Width="120px" DecimalDigits="0" ReadOnly="true">
                                                </iwc:IboWebNumericTlk>--%>
                                                <iwc:IboWebTextBox ID="KmInizio" runat="server" Width="80px" ReadOnly="true" ToolTip="Km Inizio" FormatString="{0:#,#}"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                <iwc:IboWebLabel ID="lblDataInizio" runat="server" Text="Ora:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <iwc:IboWebTextBox ID="DataInizio" runat="server" Width="80px" ReadOnly="true" FormatString="{0:HH:mm}"></iwc:IboWebTextBox>
                                                <iwc:IboWebDate2 runat="server" ID="DataInizio2" ControlType="DateAndTime" CalendarVisibleIfDisabled="false" Visible="false" />
                                            </td>
                                        </tr>
                                    </table>
                                    <%-- <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 80px;"></td>
                                            <td class="DetailFormValueCell" style="width: 570px;">
                                                <iwc:IboWebTextBox ID="CapInizio" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                               
                                                <iwc:IboWebTextBox ID="NazioneInizio" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 39px;">
                                                <iwc:IboWebLabel ID="lblLongitudineInizio" runat="server" Text="Lon:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLongitudineInizio" runat="server" Width="100px" ReadOnly="true" ToolTip="Longitudine"></iwc:IboWebTextBox>
                                            </td>
                                           
                                        </tr>
                                    </table>--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpAttivita_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpAttivita_Title_Caption" Text="Attività" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpAttivita_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblTipoAttivitaRA" runat="server" Text="Tipo"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 200px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblLocalitaInizioRA" runat="server" IncasTag="" Text="Local. Inizio"></iwc:IboWebLabel>
                                            </td>
                                             <td class="DetailFormDescriptionCell" style="width: 20px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblProvinciaInizioRA" runat="server" IncasTag="" Text="Pr"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblDataInizioRA" runat="server" Text="Inizio"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblKmInizioRA" runat="server" Text="Km Inizio"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 200px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblLocalitaFineRA" runat="server" IncasTag="" Text="Local. Fine"></iwc:IboWebLabel>
                                            </td>
                                             <td class="DetailFormDescriptionCell" style="width: 20px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblProvinciaFineRA" runat="server" IncasTag="" Text="Pr"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblDataFineRA" runat="server" Text="Fine"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblKmFineRA" runat="server" Text="Km Fine"></iwc:IboWebLabel>
                                            </td>

                                            <%--  <td style="width: 20px;"></td>--%>

                                            <td class="DetailFormDescriptionCell" style="width: 200px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblRagioneSocialeRA" runat="server" IncasTag="" Text="Ragione Sociale"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblNumeroOrdineRA" runat="server" IncasTag="" Text="Num.Ord."></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                <iwc:IboWebLabel ID="lblQuantitaRA" runat="server" IncasTag="" Text="Quantita"></iwc:IboWebLabel>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: right; font: bold;">
                                                <iwc:IboWebLabel ID="lblKmTotRA" runat="server" Text="Km Tot"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: right; font: bold;">
                                                <iwc:IboWebLabel ID="lblTempoTotRA" runat="server" Text="Durata"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 30px;"></td>
                                        </tr>
                                        <tr style="height: 10px;">
                                            <td colspan="10"></td>
                                        </tr>
                                        <asp:Repeater ID="RepeaterAttivita" runat="server">
                                            <ItemTemplate>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="TipoAttivita" runat="server"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 200px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="LocalitaInizio" runat="server" IncasTag=""></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 20px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="ProvinciaInizio" runat="server" IncasTag=""></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="DataInizio" runat="server" FormatString="{0:HH:mm}"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px; text-align: right; font: bold;">
                                                        <iwc:IboWebLabel ID="KmInizio" runat="server" FormatString="{0:#,#}" Width="45px"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 200px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="LocalitaFine" runat="server" IncasTag=""></iwc:IboWebLabel>
                                                    </td>
                                                     <td class="DetailFormDescriptionCell" style="width: 20px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="ProvinciaFine" runat="server" IncasTag=""></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="DataFine" runat="server" FormatString="{0:HH:mm}"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px; text-align: right; font: bold;">
                                                        <iwc:IboWebLabel ID="KmFine" runat="server" FormatString="{0:#,#}" Width="45px"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 200px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="RagioneSociale" runat="server" IncasTag=""></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 70px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="NumeroOrdine" runat="server" IncasTag=""></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left; font: bold;">
                                                        <iwc:IboWebLabel ID="Quantita" runat="server" IncasTag=""></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px; text-align: right; font: bold;">
                                                        <iwc:IboWebLabel ID="KmTot" runat="server" FormatString="{0:F0}"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 50px; text-align: right; font: bold;">
                                                        <iwc:IboWebLabel ID="TempoTot" runat="server"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 30px;">
                                                        <%--<iwc:IboWebButton ID="btnInserisciAttivita" runat="server" Text="I" />--%>
                                                        <iwc:IboWebButton ID="btnModificaAttivita" runat="server" CssClass="btnModifica" />
                                                        <%--<iwc:IboWebButton ID="btnCancellaAttivita" runat="server" Text="C" />--%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                     <td class="DetailFormDescriptionCell" style="width: 250px; text-align: left; font: bold;" colspan="14">
                                                        <iwc:IboWebLabel ID="CambioMotriceDescrizione" runat="server"   Visible="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 250px; text-align: left; font: bold;" >
                                                        <iwc:IboWebLabel ID="CambioMotrice" runat="server" Visible="false"></iwc:IboWebLabel>
                                                    </td>
                                                  <%--  <td class="DetailFormDescriptionCell" style="width: 250px; text-align: left; font: bold;" colspan="5">
                                                        <iwc:IboWebLabel ID="CambioRimorchio" runat="server" Visible="false"></iwc:IboWebLabel>
                                                    </td>--%>
                                                </tr>

                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpArrivo_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpArrivo_Title_Caption" Text="Arrivo" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpArrivo_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblIndirizzoFine" runat="server" Text="Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <%-- <td class="DetailFormValueCell" style="width: 567px;">
                                                <iwc:IboWebTextBox ID="IndirizzoFine" runat="server" CharacterCase="Uppercase" ReadOnly="true" MaxLength="60" Width="562px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                <iwc:IboWebLabel ID="lblLatitudineFine" runat="server" Text="Lat:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLatitudineFine" runat="server" Width="100px" ReadOnly="true" ToolTip="Latitudine"></iwc:IboWebTextBox>
                                            </td>--%>
                                            <td class="DetailFormValueCell" style="width: 450px;">
                                                <iwc:IboWebTextBox ID="LocalitaFine" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="412px" ToolTip="Località" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="ProvinciaFine" runat="server" CharacterCase="Uppercase" MaxLength="5" Width="20px" ToolTip="Provincia" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                <iwc:IboWebLabel ID="lblKmFine" runat="server" Text="Km:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <%-- <iwc:IboWebNumericTlk runat="server" ID="KmFine" Width="120px" DecimalDigits="0" ReadOnly="true">
                                                </iwc:IboWebNumericTlk>--%>
                                                <iwc:IboWebTextBox ID="KmFine" runat="server" Width="80px" ReadOnly="true" ToolTip="Km Fine" FormatString="{0:#,#}"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 40px;">
                                                <iwc:IboWebLabel ID="lblDataFine" runat="server" Text="Ora:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <iwc:IboWebTextBox ID="DataFine" runat="server" Width="80px" ReadOnly="true" FormatString="{0:HH:mm}"></iwc:IboWebTextBox>
                                                <iwc:IboWebDate2 runat="server" ID="DataFine2" ControlType="DateAndTime" CalendarVisibleIfDisabled="false" Visible="false" />
                                            </td>
                                        </tr>
                                    </table>
                                    <%-- <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 80px;"></td>
                                            <td class="DetailFormValueCell" style="width: 570px;">
                                                <iwc:IboWebTextBox ID="CapFine" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                               
                                                <iwc:IboWebTextBox ID="NazioneFine" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione" ReadOnly="true">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 39px;">
                                                <iwc:IboWebLabel ID="lblLongitudineFine" runat="server" Text="Lon:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLongitudineFine" runat="server" Width="100px" ReadOnly="true" ToolTip="Longitudine"></iwc:IboWebTextBox>
                                            </td>
                                            
                                        </tr>
                                    </table>--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpTotali_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpTotali_Title_Caption" Text="Totali" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpTotali_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <%--<td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblTempoTotaleGuida" runat="server" Text="Guida:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="txtTempoGuida" runat="server" Visible="false"></iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="TempoGuida" runat="server" Width="40px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                <iwc:IboWebLabel ID="lblTempoPausa" runat="server" Text="Pausa:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="txtTempoPausa" runat="server" Visible="false"></iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="TempoPausa" runat="server" Width="40px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                <iwc:IboWebLabel ID="lblTempoCarico" runat="server" Text="Carico:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="txtTempoCarico" runat="server" Visible="false"></iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="TempoCarico" runat="server" Width="40px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                <iwc:IboWebLabel ID="lblTempoScarico" runat="server" Text="Scarico:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="txtTempoScarico" runat="server" Visible="false"></iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="TempoScarico" runat="server" Width="40px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                <iwc:IboWebLabel ID="lblTempoExtra" runat="server" Text="Extra:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="txtTempoExtra" runat="server" Visible="false"></iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="TempoExtra" runat="server" Width="40px"></iwc:IboWebTextBox>
                                            </td>--%>
                                            <td class="DetailFormDescriptionCell" style="width: 600px;">
                                                <iwc:IboWebLabel ID="lblTempoTotaleGG" runat="server" Text="Tempo Totale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebTextBox ID="TempoTotaleGG" runat="server" Width="40px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblKmTotaleGG" runat="server" Text="Km Totali:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="KmTotaleGG" Width="50px" DecimalDigits="0" ReadOnly="true">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblCarichiScarichiTotaleGG" runat="server" Text="Carichi\Scarichi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="CarichiScarichiTotaleGG" Width="50px" DecimalDigits="0" ReadOnly="true">
                                                </iwc:IboWebNumericTlk>
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
<asp:Content ID="MasterPopupFormContent" ContentPlaceHolderID="phMasterPopupForm" runat="server">
    <asp:Panel ID="pnlModificaAttivita" runat="server" Visible="false" Style="width: 650px; height: 100px;">
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 70px;">
                    <iwc:IboWebLabel ID="lblNuovaTipoAttivita" runat="server" Text="Attivita:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 450px;">
                    <iwc:IboWebLabel ID="NuovaTipoAttivita" runat="server"></iwc:IboWebLabel>
                </td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 70px">
                    <iwc:IboWebLabel ID="lblNuovaDatainizio" runat="server" IncasTag="" Text="Inizio:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 110px">
                    <iwc:IboWebDate2 runat="server" ID="NuovaDatainizio" CssClass="NuovaDataInizio" Width="110px" ControlType="DateAndTime" FormatoOra="HH:mm" />
                </td>
                <td class="DetailFormDescriptionCell" style="width: 100px">
                    <iwc:IboWebLabel ID="lblNuovaKmInizio" runat="server" IncasTag="" Text="Km Inizio:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 130px">
                    <iwc:IboWebNumericTlk ID="NuovaKmInizio" runat="server" Width="60px" ToolTip="Km manuali inizio attivita" DecimalDigits="0">
                    </iwc:IboWebNumericTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 70px">
                    <iwc:IboWebLabel ID="lblNuovaDataFine" runat="server" IncasTag="" Text="Fine:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 110px">
                    <iwc:IboWebDate2 runat="server" ID="NuovaDataFine" Width="110px" ControlType="DateAndTime" CssClass="NuovaDataFine" FormatoOra="HH:mm" />
                </td>
                <td class="DetailFormDescriptionCell" style="width: 100px">
                    <iwc:IboWebLabel ID="lblNuovaKmFine" runat="server" IncasTag="" Text="Km Fine:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 130px">
                    <iwc:IboWebNumericTlk ID="NuovaKmFine" runat="server" Width="60px" ToolTip="Km manuali Fine attivita" DecimalDigits="0">
                    </iwc:IboWebNumericTlk>
                </td>

            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 70px">
                    <iwc:IboWebLabel ID="lblNuovaLocalitaInizio" runat="server" IncasTag="" Text="Loc. Inizio:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 485px">
                    <iwc:IboWebTextBox ID="NuovaLocalitaInizio" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="484px" ToolTip="Località" ReadOnly="true">
                    </iwc:IboWebTextBox>
                </td>
                <td style="width: 20px">
                    <asp:UpdatePanel runat="server" ID="upButtonGeocodifica" UpdateMode="Conditional" ChildrenAsTriggers="true">
                        <ContentTemplate>
                            <iwc:IboWebButton ID="btnGeocodificaInizio" runat="server" Text="G" Visible="true" />
                            <%--  CssClass="BtnGeocodifica"--%>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td style="width: 70px"></td>
                <td class="DetailFormValueCell" style="width: 510px;">
                    <iwc:IboWebTextBox ID="NuovaCapInizio" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap" ReadOnly="true">
                    </iwc:IboWebTextBox>
                    <iwc:IboWebTextBox ID="NuovaProvinciaInizio" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" ToolTip="Provincia" ReadOnly="true">
                    </iwc:IboWebTextBox>
                    <iwc:IboWebTextBox ID="NuovaIndirizzoInizio" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="324px" ToolTip="Indirizzo" ReadOnly="true">
                    </iwc:IboWebTextBox>
                    <iwc:IboWebTextBox ID="NuovaNazioneInizio" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione" ReadOnly="true">
                    </iwc:IboWebTextBox>
                </td>
                <td style="width: 20px"></td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 70px">
                    <iwc:IboWebLabel ID="lblNuovaLocalitaFine" runat="server" IncasTag="" Text="Loc. Fine:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 485px">
                    <iwc:IboWebTextBox ID="NuovaLocalitaFine" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="484px" ToolTip="Località" ReadOnly="true">
                    </iwc:IboWebTextBox>
                </td>
                <td style="width: 20px">
                    <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional" ChildrenAsTriggers="true">
                        <ContentTemplate>
                            <iwc:IboWebButton ID="btnGeocodificaFine" runat="server" Text="G" Visible="true" />
                            <%--  CssClass="BtnGeocodifica"--%>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td style="width: 70px"></td>
                <td class="DetailFormValueCell" style="width: 470px;">
                    <iwc:IboWebTextBox ID="NuovaCapFine" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap" ReadOnly="true">
                    </iwc:IboWebTextBox>
                    <iwc:IboWebTextBox ID="NuovaProvinciaFine" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" ToolTip="Provincia" ReadOnly="true">
                    </iwc:IboWebTextBox>
                    <iwc:IboWebTextBox ID="NuovaIndirizzoFine" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="324px" ToolTip="Indirizzo" ReadOnly="true">
                    </iwc:IboWebTextBox>
                    <iwc:IboWebTextBox ID="NuovaNazioneFine" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione" ReadOnly="true">
                    </iwc:IboWebTextBox>
                </td>
                <td style="width: 20px"></td>
            </tr>
        </table>
    </asp:Panel>
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
                    <iwc:IboWebButton ID="btnGeocodificaPopup" runat="server" Text="Geocodifica" CssClass="BtnGeocodifica" />
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
</asp:Content>
