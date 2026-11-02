<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAMezzi.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAMezzi" %>

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
                                            <asp:UpdatePanel ID="up_tpGen" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                <ContentTemplate>
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
                                                                <td class="DetailFormDescriptionCell" style="width: 55px;">
                                                                    <iwc:IboWebLabel ID="lblMatricola" runat="server" Text="Matricola:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 105px">
                                                                    <iwc:IboWebTextBox ID="txtMatricola" runat="server" CharacterCase="Uppercase" MaxLength="30" Width="100px" Required="true">
                                                                    </iwc:IboWebTextBox>
                                                                </td>

                                                                <td class="DetailFormDescriptionCell" style="width: 82px">
                                                                    <iwc:IboWebLabel ID="lblDiProprieta" runat="server" Text="Di proprietà:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 25px">
                                                                    <iwc:IboWebCheckBox ID="chkDiProprieta" runat="server" Checked="True" Value="S" AutoPostBack="True"></iwc:IboWebCheckBox>
                                                                </td>

                                                                <td class="DetailFormDescriptionCell" style="width: 57px">
                                                                    <iwc:IboWebLabel ID="lblDispDalleOre" runat="server" Text="Dalle:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 65px">
                                                                    <iwc:IboWebDate2 ID="txtDispDalleOre" runat="server" Width="60px" ControlType="TimeOnly" Tooltip="Ora di inizio della disponibilità" />
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 30px">
                                                                    <iwc:IboWebLabel ID="lblDispAlleOre" runat="server" Text="alle:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 65px">
                                                                    <iwc:IboWebDate2 ID="txtDispAlleOre" runat="server" Width="60px" ControlType="TimeOnly" Tooltip="Ora di fine della disponibilità" />
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 155px">
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
                                                                <td class="DetailFormValueCell" style="width: 342px">
                                                                    <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="342px" Required="true">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 101px">
                                                                    <iwc:IboWebLabel ID="lblMarca" runat="server" Text="Marca:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 200px">
                                                                    <iwc:IboWebTextBox ID="txtMarca" runat="server" CharacterCase="Uppercase" MaxLength="30" Width="200px">
                                                                    </iwc:IboWebTextBox>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 59px;">
                                                                    <iwc:IboWebLabel ID="lblTarga" runat="server" Text="Targa:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 105px;">
                                                                    <iwc:IboWebTextBox ID="txtTarga" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="70px" Required="true">
                                                                    </iwc:IboWebTextBox>
                                                                </td>

                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" Text="Tipo mezzo:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 350px;">
                                                                    <iwc:IboWebComboTlk ID="cmbTipoMezzo" runat="server" Required="true" SqlQuery="SELECT * FROM CBO_ANA_TipiMezzo" Width="350px" SqlQueryOrderBy="Descrizione"
                                                                        CampoDescrizione="Descrizione" DropDownWidth="400px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 350px;">
                                                                    <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="350px" AutoLoadOnDemand="true" MaxHeight="250px" DropDownWidth="500px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 350px;">
                                                                    <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" Width="350px" AutoLoadOnDemand="true" DropDownWidth="500px" MaxHeight="250px"
                                                                        SqlQueryWhere="Codice<>'*ALL'">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                                    <iwc:IboWebLabel ID="lblAutista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 350px;">
                                                                    <iwc:IboWebComboTlk ID="cmbAutista" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Autisti" Width="350px" AutoLoadOnDemand="true" DropDownWidth="400px" MaxHeight="250px">
                                                                    </iwc:IboWebComboTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
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
                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
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
                                                        <td class="DetailFormDescriptionCell" style="width: 81px">
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
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneML" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto alla portata in metri lineari del mezzo"
                                                                DecimalDigits="0">
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
                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazioneColli" runat="server" Text="Satur. colli(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneColli" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al numero massimo di colli che può portare il mezzo"
                                                                DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblPortataPallet" runat="server" Text="Pallet(n):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 75px">
                                                            <iwc:IboWebNumericTlk ID="txtPortataPallet" runat="server" Width="70px" ToolTip="Portata massima espressa in numero pallet" DecimalDigits="0" FieldDescription="Pallet">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 81px">
                                                            <iwc:IboWebLabel ID="lblGradoSaturazionePallet" runat="server" Text="Satur. pallet(%):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazionePallet" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al numero massimo di pallet che può portare il mezzo"
                                                                DecimalDigits="0">
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
                                                            <iwc:IboWebNumericTlk ID="txtGradoSaturazioneRoll" runat="server" Width="25px" ToolTip="Grado di saturazione espresso in % rispetto al numero massimo di roll che può portare il mezzo"
                                                                DecimalDigits="0">
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
                                                        <td class="DetailFormDescriptionCell" style="width: 80px">
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
                                                        <td class="DetailFormDescriptionCell" style="width: 81px">
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
                                                        <td class="DetailFormValueCell" style="width: 232px;">
                                                            <iwc:IboWebComboTlk ID="cmbClasseDiGrandezza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_MezziClassiGrandezza" Width="227px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 230px;">
                                                            <iwc:IboWebLabel ID="lblLunghezzaPianale" runat="server" Text="Lungh. pianale(m):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtLunghezzaPianale" runat="server" Width="55px" ToolTip="Lunghezza del pianale espressa in metri" FieldDescription="Lunghezza pianale">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblLunghezza" runat="server" Text="Lunghezza(m):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtLunghezza" runat="server" Width="55px" ToolTip="Lunghezza del mezzo espressa in metri" FieldDescription="Lunghezza">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 95px;">
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
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtAssi" runat="server" Width="25px" ToolTip="Numero di assi del mezzo" FieldDescription="Assi" DecimalDigits="0">
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
                                                        <td class="DetailFormValueCell" style="width: 370px;">
                                                            <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce" Width="365px" SqlQueryOrderBy="Descrizione"
                                                                CampoDescrizione="Descrizione" FieldDescription="Tipo merce">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblNumMaxReimpieghi" runat="server" Text="Num. max. reimp.:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 30px">
                                                            <iwc:IboWebNumericTlk ID="txtNumMaxReimpieghi" runat="server" Width="25px" ToolTip="Numero max di reimpieghi del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 135px;">
                                                            <iwc:IboWebLabel ID="lblTempoReimpiego" runat="server" Text="Tempo reimpiego:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebDate2 ID="txtTempoReimpiego" runat="server" Width="55px" ControlType="TimeOnly" Tooltip="Tempo necessario per il reimpiego del mezzo" />
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblPuntoPartenza" runat="server" Text="Punto partenza:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 370px;">
                                                            <iwc:IboWebComboTlk ID="cmbPuntoPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza" Width="365px" Required="true" AutoLoadOnDemand="true" DropDownWidth="500px">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblPuntoArrivo" runat="server" Text="Punto arrivo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 370px;">
                                                            <iwc:IboWebComboTlk ID="cmbPuntoArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiArrivo" Width="365px" AutoLoadOnDemand="true" DropDownWidth="500px">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <asp:Panel ID="cpAltriDati_Title" runat="server" Visible="True" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpEquipaggiamento_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Altri dati caratteristici del mezzo"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpAltriDati_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblTelaio" runat="server" Text="Telaio:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 245px">
                                                            <iwc:IboWebTextBox ID="txtTelaio" runat="server" CharacterCase="Uppercase" MaxLength="30" Width="238px" ToolTip="Numero identificati del telaio del mezzo">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                            <iwc:IboWebLabel ID="lblAnnoImmatr" runat="server" Text="Anno immatr:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 40px">
                                                            <iwc:IboWebNumericTlk ID="txtAnnoImmatr" runat="server" Width="35px" ToolTip="Anna di immatrizolazione del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 115px;">
                                                            <iwc:IboWebLabel ID="lblKmInizio" runat="server" Text="Km iniziali:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtKmInizio" runat="server" Width="55px" ToolTip="Km iniziali del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                            <iwc:IboWebLabel ID="lblKmAttuali" runat="server" Text="Km attuali:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtKmAttuali" runat="server" Width="55px" ToolTip="Km attuali del mezzo" DecimalDigits="0">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px">
                                                            <iwc:IboWebLabel ID="lblDataAcquisto" runat="server" Text="Data acquisto:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 110px">
                                                            <iwc:IboWebDate2 ID="txtDataAcquisto" runat="server" Width="75px" ControlType="DateOnly" Tooltip="Data di acquisto del mezzo" />
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 65px;">
                                                            <iwc:IboWebLabel ID="lblValoreAcquisto" runat="server" Text="Val. acquisto:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtValoreAcquisto" runat="server" Width="55px" DecimalDigits="2">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 90px">
                                                            <iwc:IboWebLabel ID="lblDataAlienazione" runat="server" Text="Data alienazione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 110px">
                                                            <iwc:IboWebDate2 ID="txtDataAlienazione" runat="server" Width="75px" ControlType="DateOnly" />
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblCapacitaSerbatoio" runat="server" Text="Capac. serb.(l):"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 110px">
                                                            <iwc:IboWebNumericTlk ID="txtCapacitaSerbatoio" runat="server" Width="60px" DecimalDigits="0" ToolTip="Capacità del serbatoio espressa in litri">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 65px;">
                                                            <iwc:IboWebLabel ID="lblCavalliFiscali" runat="server" Text="Cavalli fiscali:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtCavalliFiscali" runat="server" Width="55px" DecimalDigits="0" ToolTip="Cavalli fiscali del mezzo">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                            <iwc:IboWebLabel ID="lblConsumoStandard" runat="server" Text="Consumo std:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 65px">
                                                            <iwc:IboWebNumericTlk ID="txtConsumoStandard" runat="server" Width="60px" DecimalDigits="2" ToolTip="Consumo standard del mezzo">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                            <iwc:IboWebLabel ID="lblEmissioneCO2" runat="server" Text="Emissione CO2:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 60px">
                                                            <iwc:IboWebNumericTlk ID="txtEmissioneCO2" runat="server" Width="55px">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td style="width: 60px"></td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebRadioButtonList ID="optNuovoUsato" runat="server" RepeatDirection="Horizontal">
                                                                <asp:ListItem Selected="True" Text="Nuovo" Value="N"></asp:ListItem>
                                                                <asp:ListItem Text="Usato" Value="U"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblDimensionePneumatici" runat="server" Text="Dim.Pneumatici:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 245px">
                                                            <iwc:IboWebTextBox ID="txtDimensionePneumatici" runat="server" CharacterCase="Uppercase" MaxLength="20" Width="238px">
                                                            </iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 90px;">
                                                            <iwc:IboWebLabel ID="lblTipoCerchione" runat="server" Text="Tipo Cerchione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 250px;">
                                                            <iwc:IboWebRadioButtonList ID="optTipoCerchione" runat="server" RepeatDirection="Horizontal">
                                                                <asp:ListItem Text="Dritto" Value="D"></asp:ListItem>
                                                                <asp:ListItem Text="Centrale" Value="C"></asp:ListItem>
                                                                <asp:ListItem Selected="True" Text="Non Specificato" Value="X"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblMaterialeCerchione" runat="server" Text="Mater. Cerchione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 170px;">
                                                            <iwc:IboWebRadioButtonList ID="optMaterialeCerchione" runat="server" RepeatDirection="Horizontal">
                                                                <asp:ListItem Selected="True" Text="Ferro" Value="F"></asp:ListItem>
                                                                <asp:ListItem Text="Lega" Value="L"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 805px;">
                                                            <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" MaxLength="255" Rows="3" TextMode="MultiLine" FieldName="Note" Width="800px"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpImmagini" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpImmaginiCaption" Text="Foto"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 350px;">
                                            <asp:Panel ID="cpFoto_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpFoto_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Foto"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpFoto_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormValueCell" colspan="3">
                                                            <iwc:IboWebImage runat="server" ID="imgImmagine1" FieldName="Immagine1" FieldNameExtension="Immagine1Tipo" />
                                                        </td>
                                                        <td class="DetailFormValueCell" colspan="3">
                                                            <iwc:IboWebImage runat="server" ID="imgImmagine2" FieldName="Immagine2" FieldNameExtension="Immagine2Tipo" />
                                                        </td>
                                                        <td class="DetailFormValueCell" colspan="3">
                                                            <iwc:IboWebImage runat="server" ID="imgImmagine3" FieldName="Immagine3" FieldNameExtension="Immagine3Tipo" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <%-- <ajaxToolkit:TabPanel ID="tpContatti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpContattiCaption" Text="Contatti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpContatti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 350px;">
                                                    <asp:Panel ID="cpContatti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpContatti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Contatti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpContatti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdMezziContatti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlMezziContatti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdMezziContatti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                </ajaxToolkit:TabPanel>--%>
                                <ajaxToolkit:TabPanel ID="tpDocumenti" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDocumentiCaption" Text="Documenti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpDocumenti" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 350px;">
                                                    <asp:Panel ID="cpDocumenti_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpDocumenti_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Documenti"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpDocumenti_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdMezziDocumenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlMezziDocumenti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdMezziDocumenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpInfoAgg" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpInfoAggCaption" Text="Info"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <asp:UpdatePanel runat="server" ID="up_tpInfoAgg" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 350px;">
                                                    <asp:Panel ID="cpInfoAgg_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                        <iwc:IboWebLabel ID="cpInfoAgg_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Informazioni aggiuntive"></iwc:IboWebLabel>
                                                    </asp:Panel>
                                                    <asp:Panel ID="cpInfoAgg_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                        <table class="tableGridContainer">
                                                            <tr>
                                                                <td>
                                                                    <iwc:iboWebToolbar ID="tlbgrdMezziInfoAggiuntive" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                        SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                    <asp:Panel ID="pnlMezziInfoAggiuntive" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                        <iwc:IboGridView ID="grdMezziInfoAggiuntive" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:TabPanel ID="tpClassi" runat="server" Enabled="true" ScrollBars="Auto" OnDemandMode="None">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpClassiCaption" Text="Classi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel" style="min-height: 350px;">
                                            <asp:Panel ID="cpClassi_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpClassi_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Classi"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpClassi_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:IboWebCheckBoxList runat="server" ID="MezziClassi" SqlQuery="SELECT * FROM CHK_ANA_Mezzi_Classi" SqlQueryFilter="Mezzo='<#MASTER_RECORD.CODICE#>'"
                                                                FieldName1="Mezzo" FieldName2="Classe" TableName="MezziClassi">
                                                            </iwc:IboWebCheckBoxList>
                                                        </td>
                                                        <td>
                                                            <iwc:IboWebButton ID="btnTuttiClassi" runat="server" Text="Tutti" CssClass="Button_CheckAll" />
                                                            <br />
                                                            <iwc:IboWebButton ID="btnNessunoClassi" runat="server" Text="Nessuno" CssClass="Button_UncheckAll" CausesValidation="False" />
                                                        </td>
                                                    </tr>
                                                </table>
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
