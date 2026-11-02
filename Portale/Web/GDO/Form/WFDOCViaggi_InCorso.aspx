<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCViaggi_InCorso.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCViaggi_InCorso" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/Css/WFDocViaggi_InCorso.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr style="display: none">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c3">
                                <div class="DetailFormModeImageDiv">
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1335px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="false" AutoPostBack="false" TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto"
                                UseVerticalStripPlacement="true" VerticalStripWidth="85px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel ID="up_tpGen" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel">
                                                    <asp:UpdatePanel runat="server" ID="up_ViaggioInfoGen" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                        <ContentTemplate>
                                                            <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle" Style="position: relative;">
                                                                <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                                                <div class="DetailFormModeImageDiv">
                                                                    <asp:Image ID="imgModalita" runat="server" />
                                                                </div>
                                                            </asp:Panel>
                                                            <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblIdViaggio" runat="server" Text="Viaggio:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 80px">
                                                                            <iwc:IboWebTextBox ID="txtIdViaggio" runat="server" CharacterCase="Uppercase" IncasTag="IdentityCounterName=COUNTERS.VIAGGI" Width="75px" Required="true" Enabled="false">
                                                                            </iwc:IboWebTextBox>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                                            <iwc:IboWebLabel ID="lblTipoViaggio" runat="server" Text="Tipo viaggio:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 190px;">
                                                                            <iwc:IboWebComboTlk ID="cmbTipoViaggio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Viaggi_TipiViaggio" Width="190px" ReadOnly="true" Required="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>

                                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                            <iwc:IboWebLabel ID="lblDataPartenzaEffettiva" runat="server" Text="Par. Eff:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 130px">
                                                                            <iwc:IboWebDate2 ID="txtDataPartenzaEffettiva" runat="server" Width="70px" ControlType="DateAndTime" Tooltip="Data Partenza Effettiva del Viaggio" FormatoOra="HH:mm"
                                                                                TimeControlWidth="35px" />
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 54px">
                                                                            <iwc:IboWebLabel ID="lblDataArrivoPrevista" runat="server" Text="Arr. Prev:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 130px">
                                                                            <iwc:IboWebDate2 ID="txtDataArrivoPianificata" runat="server" Width="70px" ControlType="DateAndTime" Tooltip="Data Arrivo Prevista del Viaggio" FormatoOra="HH:mm"
                                                                                TimeControlWidth="35px" />
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px;">
                                                                            <iwc:IboWebLabel ID="lblStato" runat="server" Text="Stato:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 200px; font-weight: bold;">
                                                                            <iwc:IboWebLabel runat="server" ID="lblStatoDescrizione" Width="200px" ReadOnly="true" SqlQueryLookup="SELECT Descrizione FROM CBO_DOC_Viaggi_Stato WHERE Codice='<#MASTER_RECORD.Stato#>'"></iwc:IboWebLabel>
                                                                            <iwc:IboWebLabel runat="server" ID="lblStatoValue" Width="200px" FieldName="Stato" ReadOnly="true" Visible="false"></iwc:IboWebLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblVettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbVettore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" DropDownWidth="500px" MaxHeight="250px" AutoLoadOnDemand="true" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" MaxHeight="250px" DropDownWidth="500px" SqlQueryFilter="ATTIVO = 'S'" AutoLoadOnDemand="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px">
                                                                            <iwc:IboWebLabel ID="lblPeso" runat="server" IncasTag="" Text="Peso (Kg):"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="Peso" Required="True" Width="70px" ReadOnly="true" DecimalDigits="3">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                                            <iwc:IboWebLabel ID="lblRicavi" runat="server" IncasTag="" Text="Ricavi:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="Ricavi" Width="70px" ReadOnly="true" DecimalDigits="2">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                            <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Sped.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px">
                                                                            <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiSpedizione" Width="350px" MaxHeight="250px" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                            <iwc:IboWebLabel ID="lblTipoMErce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px">
                                                                            <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce" Width="350px" MaxHeight="250px" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px">
                                                                            <iwc:IboWebLabel ID="lblColli" runat="server" IncasTag="" Text="Colli:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="Colli" Required="True" Width="70px" DecimalDigits="0" ReadOnly="true">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                                            <iwc:IboWebLabel ID="lblCostiPrimari" runat="server" IncasTag="" Text="Costi Prim.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="CostiPrimari" Width="70px" ReadOnly="true" DecimalDigits="2">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblMotriceEffettiva" runat="server" Text="Mezzo:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbMotriceEffettiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Motrici" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" MaxHeight="250px" FieldDescription="Mezzo" DropDownWidth="500px" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblAutista1Effettivo" runat="server" Text="Autista Eff:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbAutista1Effettivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Autisti" Width="175px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="500px" MaxHeight="250px" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                            <iwc:IboWebComboTlk ID="cmbAutista2Effettivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Autisti" Width="170px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="500px" MaxHeight="250px" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px">
                                                                            <iwc:IboWebLabel ID="lblPallet" runat="server" IncasTag="" Text="Pallet:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="Pallet" Required="True" Width="70px" DecimalDigits="0" ReadOnly="true">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                                            <iwc:IboWebLabel ID="lblCostiSecondari" runat="server" IncasTag="" Text="Costi Sec.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="CostiSecondari" Width="70px" ReadOnly="true" DecimalDigits="2">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblRimorchioEffettivo1" runat="server" Text="Rimorchio1 Eff:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbRimorchio1Effettivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Rimorchi" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" MaxHeight="250px" DropDownWidth="500px" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblContenitore1Effettivo" runat="server" Text="Contenitore1 Eff:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbContenitore1Effettivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Tank" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" MaxHeight="250px" DropDownWidth="500px" SqlQueryFilter="ATTIVO = 'S'">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px">
                                                                            <iwc:IboWebLabel ID="lblVolume" runat="server" IncasTag="" Text="Volume (Mc):"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="Volume" Required="True" Width="70px" DecimalDigits="5" ReadOnly="true">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                                            <iwc:IboWebLabel ID="lblMargine" runat="server" IncasTag="" Text="Margine:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="Margine" Width="70px" ReadOnly="true" DecimalDigits="2" WFIMinValue="-9999999">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblRimorchio2Effettivo" runat="server" Text="Rimorchio2 Eff:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbRimorchio2Effettivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Rimorchi" SqlQueryFilter="ATTIVO = 'S'" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" MaxHeight="250px" DropDownWidth="500px">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblContenitore2Effettivo" runat="server" Text="Contenitore2 Eff:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbContenitore2Effettivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi_Tank" SqlQueryFilter="ATTIVO = 'S'" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                                CampoDescrizione="Descrizione" AutoLoadOnDemand="true" MaxHeight="250px" DropDownWidth="500px">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px">
                                                                            <iwc:IboWebLabel ID="lblContrassegno" runat="server" Text="Contrass.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="Contrassegno" Required="True" Width="70px" DecimalDigits="2" ReadOnly="true" Value="0" ToolTip="Contrassegno">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" rowspan="3" style="width: 70px"></td>
                                                                        <td class="DetailFormValueCell" rowspan="3" style="width: 80px">
                                                                            <asp:Image runat="server" ID="Immagine" Visible="false" ImageUrl="../../images/Toolbar/24/check_old.png" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblPCSPartenzaEff" runat="server" Text="PCS Partenza Eff:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbPCSPartenzaEffettivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza" Width="350px" AutoLoadOnDemand="true" MaxHeight="250px"
                                                                                DropDownWidth="500px" AutoPostBack="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                                            <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                                            <iwc:IboWebComboTlk ID="cmbPCSArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="350px" AutoLoadOnDemand="true" MaxHeight="250px" DropDownWidth="500px"
                                                                                AutoPostBack="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px">
                                                                            <iwc:IboWebLabel ID="lblNumSpedizioni" runat="server" Text="Sped./Cons.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk runat="server" ID="NumSpedizioni" Width="30px" DecimalDigits="0" ReadOnly="true" ToolTip="Numero spedizioni" FieldName="">
                                                                            </iwc:IboWebNumericTlk>
                                                                            <iwc:IboWebNumericTlk runat="server" ID="NumConsegne" Width="28px" DecimalDigits="0" ReadOnly="true" ToolTip="Numero consegne" FieldName="">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                            <iwc:IboWebLabel ID="lblZonaPartenza" runat="server" Text="Zona Partenza:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px">
                                                                            <iwc:IboWebComboTlk ID="cmbZonaPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva" Width="350px" AutoLoadOnDemand="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                            <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px">
                                                                            <iwc:IboWebComboTlk ID="cmbZonaArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva" Width="350px" AutoLoadOnDemand="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px;">
                                                                            <iwc:IboWebLabel ID="lblKmManuali" runat="server" Text="Km Manuali:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                                            <iwc:IboWebNumericTlk ID="txtKmManuali" runat="server" Width="70px" FieldDescription="Km Manuali" DecimalDigits="0">
                                                                            </iwc:IboWebNumericTlk>
                                                                            <iwc:IboWebNumericTlk ID="txtKmPianificati" runat="server" Width="70px" ToolTip="Km Pianificati" FieldDescription="Km Pianificati" ReadOnly="true" DecimalDigits="0"
                                                                                Visible="false">
                                                                            </iwc:IboWebNumericTlk>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                            <iwc:IboWebLabel ID="lblZonaPartenzaTariffaAttiva" runat="server" Text="Zona Par. Attiva:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px">
                                                                            <iwc:IboWebComboTlk ID="cmbZonaPartenzaTariffaAttiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva" Width="350px"
                                                                                AutoLoadOnDemand="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                            <iwc:IboWebLabel ID="lblZonaArrivoTariffaAttiva" runat="server" Text="Zona Arr. Attiva:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 350px">
                                                                            <iwc:IboWebComboTlk ID="cmbZonaArrivoTariffaAttiva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaAttiva" Width="350px"
                                                                                AutoLoadOnDemand="true">
                                                                            </iwc:IboWebComboTlk>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 75px;">
                                                                            <iwc:IboWebLabel ID="lblTempoGuidaPianif" runat="server" Text="T. guida pian.:" Visible="false"></iwc:IboWebLabel>
                                                                            <iwc:IboWebLabel ID="lblTerminale" runat="server" Text="Term.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 80px;">
                                                                            <iwc:IboWebTextBox runat="server" ID="MinutiGuidaPianificati" Width="70px" FieldName="MinutiGuidaPianificati" Visible="false"></iwc:IboWebTextBox>
                                                                            <iwc:IboWebTextBox runat="server" ID="TempoGuidaPianif" ClientIDMode="Static" Width="70px" FieldName="" ToolTip="Tempo di guida pianificato (hh:mm)" ReadOnly="true"
                                                                                Visible="false"></iwc:IboWebTextBox>
                                                                            <iwc:IboWebLabel ID="lblTerminaleValue" runat="server" FieldName="Terminale" ReadOnly="true" Font-Bold="true"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 70px">
                                                                            <iwc:IboWebLabel ID="lblOpenPopup" runat="server" Text="C. Calcolo:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 75px;">
                                                                            <asp:UpdatePanel runat="server" ID="up_btnOpenPopup" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                                                <ContentTemplate>
                                                                                    <iwc:IboWebButton ID="btnOpenPopup" runat="server" CssClass="DetailFormButton btnOpenPopup" ToolTip="Apre popup per gestione campi calcolo" />
                                                                                </ContentTemplate>
                                                                            </asp:UpdatePanel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table class="DetailFormSectionTable2Fixed">
                                                                    <tr>
                                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                            <iwc:IboWebLabel ID="lblFillerAlfa9" runat="server" IncasTag="" Text="Sub Vettore:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 460px">
                                                                            <iwc:IboWebTextBox ID="txtFillerAlfa9" FieldName="FillerAlfa9" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="450px"></iwc:IboWebTextBox>
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                            <iwc:IboWebLabel runat="server" ID="IboWebLabel1" Text="Ritardo Trasport.:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 20px; padding-left: 2px;">
                                                                            <iwc:IboWebCheckBox runat="server" FieldName="Flag8" ID="IboWebCheckBox1" />
                                                                        </td>
                                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                            <iwc:IboWebLabel ID="IboWebLabel2" runat="server" IncasTag="" Text="Motivo:"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell" style="width: 460px">
                                                                            <iwc:IboWebTextBox ID="IboWebTextBox2" FieldName="FillerAlfa8" runat="server" CharacterCase="Uppercase" MaxLength="225" Width="450px"></iwc:IboWebTextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <iwc:IboWebLabel ID="txtIdViaggioOBC" runat="server" CssClass="hidden "></iwc:IboWebLabel>
                                                            </asp:Panel>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                    <asp:UpdatePanel runat="server" ID="up_cpspedizioni" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                        <ContentTemplate>
                                                            <asp:Panel ID="cpSpedizioni_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                                <iwc:IboWebLinkButton ID="cpSpedizioni_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption SpedizioniTitle" Text="Spedizioni" Enabled="false"></iwc:IboWebLinkButton>
                                                                <iwc:IboWebLinkButton ID="cpSpedizioni_Title_Caption_Raggru" runat="server" CssClass="CollapsiblePanelTitleCaption ConsegneTitle" Text="Consegne" ToolTip="Numero di scarichi del viaggio"
                                                                    Enabled="true"></iwc:IboWebLinkButton>
                                                                <iwc:IboWebLinkButton ID="cpEventi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption EventiTitle" Text="Eventi" ToolTip="Eventi del viaggio"
                                                                    Enabled="true"></iwc:IboWebLinkButton>
                                                            </asp:Panel>
                                                            <asp:Panel ID="cpSpedizioni_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <iwc:iboWebToolbar ID="tlbgrdViaggiSpedizioni" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            <asp:Panel ID="pnlViaggiSpedizioni" runat="server" CssClass="DetailFormGridContainerDiv pnlViaggiSpedizioni">
                                                                                <iwc:IboGridView ID="grdViaggiSpedizioni" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                                    HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </asp:Panel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                            <asp:Panel ID="cpSpedizioni_Body_Raggru" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid" Visible="false">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <iwc:iboWebToolbar ID="tlbgrdViaggiSpedizioniRaggru" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            <asp:Panel ID="pnlViaggiSpedizioniRaggru" runat="server" CssClass="DetailFormGridContainerDiv pnlViaggiSpedizioni">
                                                                                <iwc:IboGridView ID="grdViaggiSpedizioniRaggru" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                                    HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </asp:Panel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                            <asp:Panel ID="cpEventi_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid" Visible="false">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <iwc:iboWebToolbar ID="tlbgrdViaggiEventi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            <asp:Panel ID="pnlViaggiEventi" runat="server" CssClass="DetailFormGridContainerDiv pnlViaggiEventi">
                                                                                <iwc:IboGridView ID="grdViaggiEventi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                                    HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </asp:Panel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpCosti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpCostiCaption" Text="Costi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpCosti_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpCosti_Title_Caption" Text="Costi di Trasporto" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel runat="server" ID="up_tp_Costi_InfoTestata" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <asp:Panel runat="server" ID="cpCosti_Header" CssClass="CollapsiblePanelBody">
                                                        <div class="DivCostiRicavi">
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_Vettore" Text="Vettore:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_Vettore_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_Trasportatori WHERE Codice='<#MASTER_RECORD.Vettore#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_TipoSpedizione" Text="Tipo Sped.:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_TipoSpedizione_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_TipiSpedizione WHERE Codice='<#MASTER_RECORD.TipoSpedizione#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_TipoMerce" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 205px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_TipoMerce_Descrizione" Width="200px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_TipiMerce WHERE Codice='<#MASTER_RECORD.TipoMerce#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_PCSPartenza" Text="PCS Partenza:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_PCSPartenza_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_PCS WHERE Codice='<#MASTER_RECORD.PCSPartenza#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_PCSArrivo" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_PCSArrivo_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_PCS WHERE Codice='<#MASTER_RECORD.PCSArrivo#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_ZonaArrivo" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 340px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblCosti_ZonaArrivo_Descrizione" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_ZoneTariffaAttiva WHERE Codice='<#MASTER_RECORD.ZonaArrivo#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                            <asp:Panel runat="server" ID="cpCosti_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpCosti_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <div class="tlbgrdCostiDiv">
                                                                        <iwc:iboWebToolbar ID="tlbgrdCosti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <div class="DivPnlChkBloccaCosti">
                                                                            <asp:Panel runat="server" ID="pnlChkBloccaCosti">
                                                                                <table class="DetailFormSectionTable2Fixed">
                                                                                    <tr style="height: 25px;">
                                                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                            <iwc:IboWebLabel runat="server" ID="lblBloccaCosti" Text="Blocca Costi:"></iwc:IboWebLabel>
                                                                                        </td>
                                                                                        <td class="DetailFormValueCell" style="width: 20px; padding-left: 2px;">
                                                                                            <iwc:IboWebCheckBox runat="server" ID="chkBloccaCosti" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </asp:Panel>
                                                                        </div>
                                                                    </div>
                                                                    <asp:Panel ID="pnlCosti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdCosti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </asp:Panel>
                                            <ajaxToolkit:CollapsiblePanelExtender ID="cpCosti" runat="server" CollapseControlID="cpCosti_Title" Collapsed="false" CollapsedImage="~/images/expand.png" CollapsedSize="0"
                                                CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpCosti_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details"
                                                ImageControlID="cpCosti_Title_Image" TargetControlID="cpCosti_Body">
                                            </ajaxToolkit:CollapsiblePanelExtender>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="TpRicavi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="Always">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="TpRicaviCaption" Text="Ricavi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpRicavi_Title" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel runat="server" ID="cpRicavi_Title_Caption" Text="Ricavi di Trasporto" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:UpdatePanel runat="server" ID="up_tp_Ricavi_InfoTestata" UpdateMode="Conditional">
                                                <ContentTemplate>
                                                    <asp:Panel runat="server" ID="cpRicavi_Header" CssClass="CollapsiblePanelBody">
                                                        <div class="DivCostiRicavi">
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_Cliente" Text="Cliente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_Cliente_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_Clienti WHERE Codice='<#MASTER_RECORD.Cliente#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_TipoSpedizione" Text="Tipo Sped.:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_TipoSpedizione_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_TipiSpedizione WHERE Codice='<#MASTER_RECORD.TipoSpedizione#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_TipoMerce" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 205px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_TipoMerce_Descrizione" Width="200px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_TipiMerce WHERE Codice='<#MASTER_RECORD.TipoMerce#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_PCSPartenza" Text="PCS Partenza:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_PCSPartenza_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_PCS WHERE Codice='<#MASTER_RECORD.PCSPartenza#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr class="TrCostiRicavi">
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_PCSArrivo" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 645px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_PCSArrivo_Descrizione" Width="640px" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_PCS WHERE Codice='<#MASTER_RECORD.PCSArrivo#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_ZonaArrivo" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 340px; font-weight: bold">
                                                                        <iwc:IboWebLabel runat="server" ID="lblRicavi_ZonaArrivo_Descrizione" FieldName="" SqlQueryLookup="SELECT Descrizione FROM CBO_ANA_ZoneTariffaAttiva WHERE Codice='<#MASTER_RECORD.ZonaArrivoTariffaAttiva#>'"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                            <asp:Panel runat="server" ID="cpRicavi_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <asp:UpdatePanel runat="server" ID="up_cpRicavi_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <div class="tlbgrdRicaviDiv">
                                                                        <iwc:iboWebToolbar ID="tlbgrdRicavi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                            SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <div class="DivPnlChkBloccaRicavi">
                                                                            <asp:Panel runat="server" ID="pnlChkBloccaRicavi">
                                                                                <table class="DetailFormSectionTable2Fixed">
                                                                                    <tr style="height: 25px;">
                                                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                            <iwc:IboWebLabel runat="server" ID="lblBloccaRicavi" Text="Blocca Ricavi:"></iwc:IboWebLabel>
                                                                                        </td>
                                                                                        <td class="DetailFormValueCell" style="width: 20px; padding-left: 2px;">
                                                                                            <iwc:IboWebCheckBox runat="server" ID="chkBloccaRicavi" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </asp:Panel>
                                                                        </div>
                                                                    </div>
                                                                    <asp:Panel ID="pnlRicavi" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdRicavi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </asp:Panel>
                                            <ajaxToolkit:CollapsiblePanelExtender ID="cpRicavi" runat="server" CollapseControlID="cpRicavi_Title" Collapsed="false" CollapsedImage="~/images/expand.png" CollapsedSize="0"
                                                CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpRicavi_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details"
                                                ImageControlID="cpRicavi_Title_Image" TargetControlID="cpRicavi_Body">
                                            </ajaxToolkit:CollapsiblePanelExtender>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpIstruzioni" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpIstruzioniCaption" Text="Istruzioni"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpIstruzioni" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel">
                                                    <asp:Panel runat="server" ID="cpInfoExtra_Title" CssClass="CollapsiblePanelTitle">
                                                        <asp:Label runat="server" ID="cpInfoExtra_Title_Caption" Text="Dati aggiuntivi" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                    </asp:Panel>
                                                    <asp:Panel runat="server" ID="cpInfoExtra_Body" CssClass="CollapsiblePanelBody">
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblNote1" runat="server" Text="Note1:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 340px;">
                                                                    <iwc:IboWebTextBox ID="txtNote1" runat="server" CharacterCase="Uppercase" MaxLength="255" Rows="4" TextMode="MultiLine" FieldName="Note1" Width="330px"></iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblNote2" runat="server" Text="Note2:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 340px">
                                                                    <iwc:IboWebTextBox ID="txtNote2" runat="server" CharacterCase="Uppercase" MaxLength="255" Rows="4" TextMode="MultiLine" FieldName="Note2" Width="330px"></iwc:IboWebTextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpIstruzioni_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpIstruzioni_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Istruzioni"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpIstruzioni_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdViaggiIstruzioni" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlViaggiIstruzioni" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdViaggiIstruzioni" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                            HorizontalAlign="Left" PageSize="20" Width="100%">
                                                                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                            <PagerStyle Font-Size="Small" />
                                                                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                        </iwc:IboGridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                            </ajaxToolkit:TabContainer>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel" style="margin-left: 85px;">
                        <asp:Button ID="Button1_idle" runat="server" Text="" Style="display: none" />
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <iwc:IboWebButton ID="btnCalcola" runat="server" Text="Costi/Ricavi" CssClass="DetailFormButton btnCalcola" />
                                    <iwc:IboWebButton ID="btnCalcolaKmETempi" runat="server" Text="Km/Tempi" ToolTip="Calcola i km e i tempi del viaggio" CssClass="DetailFormButton btnCalcolaKmETempi" />
                                    <iwc:IboWebButton ID="btnOttimizzazione" runat="server" Text="Ottimizz." ToolTip="Calcola i km e i tempi ottimizzati del viaggio" CssClass="DetailFormButton btnOttimizzazione" Visible="false"  />
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
<asp:Content ID="MasterPopupFormContent" ContentPlaceHolderID="phMasterPopupForm" runat="server">
    <asp:Panel ID="pnlCorrispondente" runat="server" Visible="false" Style="width: 600px; height: 60px;">
        <table style="width: 100%" class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 450px">
                    <iwc:IboWebComboTlk ID="Corrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CORRISPONDENTI" Width="440px" AutoLoadOnDemand="True">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlFiltro" runat="server" Visible="false" Style="width: 560px; height: 60px;">
        <table class="DetailFormSectionTable2Fixed">
            <tr class="LineaVuota">
                <td style="width: 200px"></td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblClienteSpe" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 450px">
                    <iwc:IboWebComboTlk ID="Cliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" Width="440px" AutoLoadOnDemand="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblZona" runat="server" Text="Zona:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 450px">
                    <iwc:IboWebComboTlk ID="ZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONESPEDIZIONE" Width="440px" AutoLoadOnDemand="True">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblNumeroOrdine" runat="server" Text="N° Ordine:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 160px">
                    <iwc:IboWebTextBox runat="server" ID="NumeroOrdine" Width="100px"></iwc:IboWebTextBox>
                </td>
                <td class="DetailFormDescriptionCell" style="width: 50px">
                    <iwc:IboWebLabel ID="lblDataOrdine" runat="server" Text="Data Ordine:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 130px">
                    <iwc:IboWebDate2 ID="DataOrdine" runat="server" Width="75px" ControlType="DateOnly" Tooltip="Data Ordine" />
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblBolla" runat="server" Text="N° DDT:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebTextBox runat="server" ID="NumeroBolla" Width="100px"></iwc:IboWebTextBox>
                </td>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblDataBolla" runat="server" Text="Data DDT:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebDate2 ID="DataBolla" runat="server" Width="75px" ControlType="DateOnly" />
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblDataConsegna" runat="server" Text="Data consegna:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebDate2 ID="DataConsegna" runat="server" Width="75px" ControlType="DateOnly" />
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlOrdinaSpedizioni" runat="server" Visible="false" Style="width: 1200px; height: 500px;">
        <table class="tableGridContainer">
            <tr>
                <td>
                    <asp:Panel ID="pnlViaggiSpedizioniRaggruForDD" runat="server" CssClass="DetailFormGridContainerDiv pnlViaggiSpedizioni">
                        <iwc:IboGridView ID="grdViaggiSpedizioniRaggruForDD" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                            HorizontalAlign="Left" PageSize="20" Width="100%">
                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                            <PagerStyle Font-Size="Small" />
                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                        </iwc:IboGridView>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlQuantita" runat="server" Visible="false" Style="width: 800px;">
        <asp:Panel runat="server" ID="cpQuantita_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyBorderTop" Style="height: auto;">
            <div class="FrameContainer">
                <div class="FrameTitle">
                    <iwc:IboWebLabel runat="server" ID="CampiCalcoloSpedizioniTitle" Text="Campi calcolo delle spedizioni"></iwc:IboWebLabel>
                </div>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo1" runat="server" IncasTag="" Text="Campo Calcolo 1"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo1" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo2" runat="server" IncasTag="" Text="Campo Calcolo 2"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo2" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo3" runat="server" IncasTag="" Text="Campo Calcolo 3"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo3" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo4" runat="server" IncasTag="" Text="Campo Calcolo 4"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo4" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>

                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo5" runat="server" IncasTag="" Text="Campo Calcolo 5"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo5" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo6" runat="server" IncasTag="" Text="Campo Calcolo 6"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo6" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo7" runat="server" IncasTag="" Text="Campo Calcolo 7"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo7" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo8" runat="server" IncasTag="" Text="CampoCalcolo8"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo8" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>

                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo9" runat="server" IncasTag="" Text="Campo Calcolo 9"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo9" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo10" runat="server" IncasTag="" Text="Campo Calcolo 10"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="CampoCalcolo10" Required="True" Width="80px" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblTassatoAttivo" runat="server" IncasTag="" Text="Tassato attivo:"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtTassatoAttivo" Required="False" Width="80px" Value="0" DecimalDigits="3" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblTassatoPassivo" runat="server" IncasTag="" Text="Tassato passivo:"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtTassatoPassivo" Required="False" Width="80px" Value="0" DecimalDigits="3" ReadOnly="true">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="FrameContainer">
                <div class="FrameTitle">
                    <iwc:IboWebLabel runat="server" ID="CampiCalcoloAttiviTitle" Text="Campi calcolo attivi di viaggio"></iwc:IboWebLabel>
                </div>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo1Attivo" runat="server" IncasTag="" Text="Campo Calcolo 1"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo1Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo2Attivo" runat="server" IncasTag="" Text="Campo Calcolo 2"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo2Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo3Attivo" runat="server" IncasTag="" Text="Campo Calcolo 3"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo3Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo4Attivo" runat="server" IncasTag="" Text="Campo Calcolo 4"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo4Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>

                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo5Attivo" runat="server" IncasTag="" Text="Campo Calcolo 5"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo5Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo6Attivo" runat="server" IncasTag="" Text="Campo Calcolo 6"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo6Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo7Attivo" runat="server" IncasTag="" Text="Campo Calcolo 7"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo7Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo8Attivo" runat="server" IncasTag="" Text="Campo Calcolo 8"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo8Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>

                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo9Attivo" runat="server" IncasTag="" Text="Campo Calcolo 9"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo9Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo10Attivo" runat="server" IncasTag="" Text="Campo Calcolo 10"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo10Attivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="FrameContainer">
                <div class="FrameTitle">
                    <iwc:IboWebLabel runat="server" ID="CampiCalcoloPassiviTitle" Text="Campi calcolo passivi di viaggio"></iwc:IboWebLabel>
                </div>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo1Passivo" runat="server" IncasTag="" Text="Campo Calcolo 1"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo1Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo2Passivo" runat="server" IncasTag="" Text="Campo Calcolo 2"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo2Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo3Passivo" runat="server" IncasTag="" Text="Campo Calcolo 3"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo3Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo4Passivo" runat="server" IncasTag="" Text="CampoCalcolo4"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo4Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>

                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo5Passivo" runat="server" IncasTag="" Text="Campo Calcolo 5"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo5Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo6Passivo" runat="server" IncasTag="" Text="Campo Calcolo 6"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo6Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo7Passivo" runat="server" IncasTag="" Text="Campo Calcolo 7"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo7Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo8Passivo" runat="server" IncasTag="" Text="Campo Calcolo 8"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo8Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
                <table class="DetailFormSectionTable2Fixed">
                    <tr>

                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo9Passivo" runat="server" IncasTag="" Text="Campo Calcolo 9"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo9Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                        <td class="DetailFormDescriptionCell" style="width: 90px">
                            <iwc:IboWebLabel ID="lblCampoCalcolo10Passivo" runat="server" IncasTag="" Text="Campo Calcolo 10"></iwc:IboWebLabel>
                        </td>
                        <td class="DetailFormValueCell" style="width: 90px">
                            <iwc:IboWebNumericTlk runat="server" ID="txtCampoCalcolo10Passivo" Width="80px">
                            </iwc:IboWebNumericTlk>
                        </td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
