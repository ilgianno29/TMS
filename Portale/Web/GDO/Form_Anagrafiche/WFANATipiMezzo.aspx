<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANATipiMezzo.aspx.vb" Inherits="Incasbo.Web.GDO.WFANATipiMezzo" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="true" AutoPostBack="false" TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto"
                                UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
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
                                                            <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="100px" Required="true">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 347px">
                                                            <iwc:IboWebLabel ID="lblDispDalleOre" runat="server" Text="Dalle:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 65px">
                                                            <iwc:IboWebDate2 ID="txtDispDalleOre" runat="server" Width="60px" Required="true" ControlType="TimeOnly" Tooltip="Ora di inizio della disponibilità" />
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 14px">
                                                            <iwc:IboWebLabel ID="lblDispAlleOre" runat="server" Text="alle:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 65px">
                                                            <iwc:IboWebDate2 ID="txtDispAlleOre" runat="server" Width="60px" Required="true" ControlType="TimeOnly" Tooltip="Ora di fine della disponibilità" />
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 150px">
                                                            <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 25px">
                                                            <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                        </td>

                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 350px">
                                                            <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="350px" Required="true">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 98px;">
                                                            <iwc:IboWebLabel ID="lblCategoria" runat="server" Text="Categoria:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 400px;">
                                                            <iwc:IboWebComboTlk ID="cmbCategoria" runat="server" Required="true" SqlQuery="SELECT * FROM CBO_ANA_MezziCategorie" Width="400px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" DropDownWidth="400px">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpPortate_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpPortate_Title_Caption" Text="Portate" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpPortate_Body" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblPortataPeso" runat="server" Text="Peso(kg):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataPeso" runat="server" Width="70px" ToolTip="Portata massima espressa in kg" FieldDescription="Peso">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazionePeso" runat="server" Text="Satur. peso(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazionePeso" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al peso del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataVolume" runat="server" Text="Volume(m&amp;#179):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataVolume" runat="server" Width="70px" ToolTip="Portata massima espressa in metri cubi" FieldDescription="Volume">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneVolume" runat="server" Text="Satur. vol.(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneVolume" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al volume del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataMetriLineari" runat="server" Text="Metri lin.(m):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataMetriLineari" runat="server" Width="70px" ToolTip="Portata massima espressa in metri" FieldDescription="Metri lin.">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneML" runat="server" Text="Satur. metri lin.(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneML" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto alla portata in metri lineari del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataColli" runat="server" Text="Colli(n):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataColli" runat="server" Width="70px" ToolTip="Portata massima espressa in numero colli" FieldDescription="Colli" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneColli" runat="server" Text="Satur. colli(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneColli" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al numero massimo di colli che può portare il mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataPallet" runat="server" Text="Pallet(n):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataPallet" runat="server" Width="70px" ToolTip="Portata massima espressa in numero pallet" DecimalDigits="0" FieldDescription="Pallet">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazionePallet" runat="server" Text="Satur. pallet(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazionePallet" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al numero massimo di pallet che può portare il mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataRoll" runat="server" Text="Roll(n):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataRoll" runat="server" Width="70px" ToolTip="Portata massima espressa in numero roll" DecimalDigits="0" FieldDescription="Roll">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneRoll" runat="server" Text="Satur. roll(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneRoll" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al numero massimo di roll che può portare il mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataQ1" runat="server" Text="Q1:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataQ1" runat="server" Width="70px">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneQ1" runat="server" Text="Satur. Q1(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneQ1" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in %" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataQ2" runat="server" Text="Q2:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataQ2" runat="server" Width="70px">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneQ2" runat="server" Text="Satur. Q2(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneQ2" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in %" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataQ3" runat="server" Text="Q3:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataQ3" runat="server" Width="70px">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneQ3" runat="server" Text="Satur. Q3(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneQ3" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in %" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpDimensioni_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpDimensioni_Title_Caption" Text="Dimensioni" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpDimensioni_Body" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblClasseDiGrandezza" runat="server" Text="Classe grand:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 387px;">
                                                            <iwc:IboWebComboTlk ID="cmbClasseDiGrandezza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_MezziClassiGrandezza" Width="367px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" Required="true">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblLunghezza" runat="server" Text="Lunghezza(m):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtLunghezza" runat="server" Width="55px" ToolTip="Lunghezza del mezzo espressa in metri" FieldDescription="Lunghezza">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblLarghezza" runat="server" Text="Larghezza(m):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtLarghezza" runat="server" Width="55px" ToolTip="Larghezza del mezzo espressa in metri" FieldDescription="Larghezza">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblAltezza" runat="server" Text="Altezza(m):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtAltezza" runat="server" Width="55px" ToolTip="Altezza del mezzo espressa in metri" FieldDescription="Altezza">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 95px;">
                                                            <iwc:IboWebLabel ID="lblTara" runat="server" Text="Tara(kg):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtTara" runat="server" Width="55px" ToolTip="Tara del mezzo espressa in kg" FieldDescription="Tara">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                            <iwc:IboWebLabel ID="lblAssi" runat="server" Text="Assi(n.):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 55px">
                                                            <iwc:IboWebNumericTlk ID="txtAssi" runat="server" Width="50px" ToolTip="Numero di assi del mezzo" FieldDescription="Assi" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpInfoExtra_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpInfoExtra_Title_Caption" Text="Dati aggiuntivi" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpInfoExtra_Body" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo merce:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 387px;">
                                                            <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce" Width="367px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" FieldDescription="Tipo merce">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblProfiloVelocita" runat="server" Text="Profilo velocità:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 350px;">
                                                            <iwc:IboWebComboTlk ID="cmbProfiloVelocita" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ProfiliVelocita" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" Required="true" FieldDescription="Profilo velocità">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblNumMaxFermate" runat="server" Text="Num. max. fermate:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtNumMaxFermate" runat="server" Width="55px" ToolTip="Numero max di fermate che può effettuare il mezzo in un giro" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 95px;">
                                                            <iwc:IboWebLabel ID="lblNumMaxReimpieghi" runat="server" Text="Num. max. reimpieghi:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtNumMaxReimpieghi" runat="server" Width="55px" ToolTip="Numero max di reimpieghi del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 105px;">
                                                            <iwc:IboWebLabel ID="lblTempoReimpiego" runat="server" Text="Tempo reimpiego:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebDate2 ID="txtTempoReimpiego" runat="server" Width="55px" Required="true" ControlType="TimeOnly" Tooltip="Tempo necessario per il reimpiego del mezzo" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpEquipaggiamenti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpEquipaggiamentiCaption" Text="Equipagg."></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 350px;">
                                            <asp:Panel ID="cpEquipaggiamento_Title" runat="server" Visible="True" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpEquipaggiamento_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Equipaggiamenti abilitati per il tipo mezzo"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpEquipaggiamento_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <asp:Repeater ID="RepeaterEquipMezzo" runat="server">
                                                        <ItemTemplate>
                                                            <tr style="height: 25px">
                                                                <td class="DetailFormValueCell" style="width: 80px; vertical-align: middle; text-align: right; padding: 3px">
                                                                    <iwc:IboWebCheckBox ID="chkEquipaggiamento_0" runat="server" AutoPostBack="true" />
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 350px; text-align: left; vertical-align: middle; padding: 3px">
                                                                    <iwc:IboWebLabel ID="lblEquipaggiamento_0" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                                <td>
                                                                    <asp:HiddenField ID="codEquipaggiamento_0" runat="server" />
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 15px; vertical-align: middle; padding: 3px">
                                                                    <iwc:IboWebCheckBox ID="chkEquipaggiamento_1" runat="server" />
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 350px; text-align: left; vertical-align: middle; padding: 3px">
                                                                    <iwc:IboWebLabel ID="lblEquipaggiamento_1" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                                <td>
                                                                    <asp:HiddenField ID="codEquipaggiamento_1" runat="server" />
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 15px; vertical-align: middle; padding: 3px">
                                                                    <iwc:IboWebCheckBox ID="chkEquipaggiamento_2" runat="server" />
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px; text-align: left; vertical-align: middle; padding: 3px">
                                                                    <iwc:IboWebLabel ID="lblEquipaggiamento_2" runat="server"></iwc:IboWebLabel>
                                                                </td>
                                                                <td>
                                                                    <asp:HiddenField ID="codEquipaggiamento_2" runat="server" />
                                                                </td>
                                                            </tr>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </table>
                                                <iwc:IboWebLabel ID="lblNessunEquipaggiamento" runat="server" Text="Nessun equipaggiamento in anagrafica" Visible="false"></iwc:IboWebLabel>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                            </ajaxToolkit:TabContainer>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel" style="margin-left: 100px;">
                        <asp:Button ID="Button1_idle" runat="server" Text="" Style="display: none" />
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
