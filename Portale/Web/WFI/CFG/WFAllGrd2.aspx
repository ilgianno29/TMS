<%@ Page Title="Gestione tabella Allgrd" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFAllGrd2.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFAllGrd2" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <style type="text/css">
        #PulsantiLeftSite {
            width: 560px;
            float: left;
            border: 1px solid #cccccc;
            height: auto;
            margin: 3px;
            border-top-left-radius: 5px;
            border-top-right-radius: 5px;
        }

        #PulsantiRightSite {
            width: 560px;
            float: left;
            margin: 3px;
            border: 1px solid #cccccc;
            height: auto;
            border-top-left-radius: 5px;
            border-top-right-radius: 5px;
        }

        .DetailFormGridContainerDiv.pnlTabbot, .DetailFormGridContainerDiv.pnlTabbot2 {
            height: 415px;
            overflow: auto;
        }

        input.ButtonFilterText {
            width: 100px;
        }

        input.ButtonFilterConferma {
            width: 27px;
            height: 22px;
        }

        input.ButtonFilterReset {
            width: 50px;
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" align="center">
        <table class="DetailFormMainTable">
            <tr>
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag=""></iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1250px">
                            <ajaxToolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="false" AutoPostBack="false" TabStripPlacement="Top" CssClass="WFITab"
                                ScrollBars="Auto" UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxToolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px">
                                                            <iwc:IboWebLabel ID="lblNomRif" runat="server" Text="Rif. Griglia:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 605px">
                                                            <iwc:IboWebTextBox ID="txtNomRif" runat="server" MaxLength="30" Width="300px" Required="True" FieldName="NomRif"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblUtente" runat="server" Text="Utente:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebTextBox ID="txtUtente" runat="server" MaxLength="15" Width="130px" Required="True" ReadOnly="True" FieldName="Utente"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblDesTab" runat="server" Text="Descrizione griglia:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebTextBox ID="txtDesTab" runat="server" MaxLength="255" Width="600px" Required="True" FieldName="DesTab" CharacterCase="None"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblNomTab" runat="server" Text="Nome tabella:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebComboTlk ID="cmbNomTab" runat="server" SqlQuery="SELECT * FROM CBO_WFI_ELENCOTABELLE" Width="410px" AutoLoadOnDemand="true" Required="True" FieldName="NomTab">
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblFiltro" runat="server" Text="Filtro:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebTextBox ID="txtFiltro" runat="server" MaxLength="255" Width="600px" FieldName="Filtro"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblCansel" runat="server" Text="Selezione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebRadioButtonList ID="optCanSel" runat="server" RepeatDirection="Horizontal" Height="25px" FieldName="CanSel">
                                                                <asp:ListItem Value="S" Text="Singola" Selected="True"></asp:ListItem>
                                                                <asp:ListItem Value="N" Text="Nessuna"></asp:ListItem>
                                                                <asp:ListItem Value="M" Text="Multipla semplice"></asp:ListItem>
                                                                <asp:ListItem Value="C" Text="Multipla composta"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <asp:UpdatePanel runat="server" ID="up_CanPage" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <table class="DetailFormSectionTable2Fixed">
                                                            <tr>
                                                                <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                                    <iwc:IboWebLabel ID="lblCanPage" runat="server" Text="Paginazione attivata:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 80px;">
                                                                    <iwc:IboWebRadioButtonList ID="optCanPage" runat="server" RepeatDirection="Horizontal" Height="25px" AutoPostBack="True">
                                                                        <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                                        <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                                    </iwc:IboWebRadioButtonList>
                                                                </td>
                                                                <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                                    <iwc:IboWebLabel ID="lblRowsPerPage" runat="server" Text="Righe per pagina:"></iwc:IboWebLabel>
                                                                </td>
                                                                <td class="DetailFormValueCell" style="width: 70px;">
                                                                    <iwc:IboWebNumericTlk runat="server" ID="txtRowsPerPage" Width="60" DecimalDigits="0" Value="20" WFIMaxValue="9999" WFIMinValue="0"></iwc:IboWebNumericTlk>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                            <iwc:IboWebLabel ID="lblCanSort" runat="server" Text="Ordinamento attivato:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebRadioButtonList ID="optCanSort" runat="server" RepeatDirection="Horizontal" Height="25px">
                                                                <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                            <iwc:IboWebLabel ID="lblSelColVisible" runat="server" Text="Colonna di selezione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebRadioButtonList ID="optSelColVisible" runat="server" RepeatDirection="Horizontal" Height="25px">
                                                                <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                            <iwc:IboWebLabel ID="lblFastFilterType" runat="server" Text="Filtro immediato:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebRadioButtonList ID="optFastFilterType" runat="server" RepeatDirection="Horizontal" Height="25px">
                                                                <asp:ListItem Value="A" Text="Attivo su tutte le colonne" Selected="True"></asp:ListItem>
                                                                <asp:ListItem Value="S" Text="Attivo solo sulla colonna selezionata" Selected="True"></asp:ListItem>
                                                                <asp:ListItem Value="N" Text="Non attivo"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                            <iwc:IboWebLabel ID="lblFontSize" runat="server" Text="Dimensione font:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 85px;">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtFontSize" MinValue="0" MaxValue="99" Width="40px" MaxLength="2" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                            <iwc:IboWebLabel ID="lblBold" runat="server" Text="Grassetto:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 50px;">
                                                            <iwc:IboWebCheckBox runat="server" ID="chkBold" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                            <iwc:IboWebLabel ID="lblItalic" runat="server" Text="Corsivo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 45px;">
                                                            <iwc:IboWebCheckBox runat="server" ID="chkItalic" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                            <iwc:IboWebLabel ID="lblTimerUpdate" runat="server" Text="Timer update:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 85px;">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtTimerUpdate" MinValue="0" MaxValue="99" Width="40px" MaxLength="3" DecimalDigits="0" AutoPostBack="true" ToolTip="Con un timer>0 si abilita anche il check di AutoUpdateVisible">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                            <iwc:IboWebLabel ID="lblAutoUpdateVisible" runat="server" Text="Auto Update Visible:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 50px;">
                                                            <iwc:IboWebCheckBox runat="server" ID="chkAutoUpdateVisible" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                            <iwc:IboWebLabel ID="lblWidth" runat="server" Text="Larghezza:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 85px;">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtWidth" MinValue="0" MaxValue="9999" Width="40px" MaxLength="4" DecimalDigits="0" ToolTip="0 è il valore di default e significa larghezza automatica">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                            <iwc:IboWebLabel ID="lblScrollHeight" runat="server" Text="Scroll Height:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 50px;">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtScrollHeight" MinValue="0" MaxValue="9999" Width="40px" MaxLength="4" DecimalDigits="0" ToolTip="Altezza utile della griglia. Fissa la riga delle intestazioni e la riga del footer.<br />0 è il valore di default e disattiva la funzionalità. 9999 significa altezza automatica a tutto schermo.">
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                            <iwc:IboWebLabel ID="lblFixedLayout" runat="server" Text="Fixed Layout:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 45px;">
                                                            <iwc:IboWebCheckBox runat="server" ID="chkFixedLayout" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="DetailFormSectionTable2Fixed">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                            <iwc:IboWebLabel ID="lblMaxRecord" runat="server" Text="Num. max record:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 85px;">
                                                            <iwc:IboDropDownList ID="cmbMaxRecord" runat="server" Width="80px" FieldName="MaxRecord">
                                                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                                <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                                                <asp:ListItem Text="200" Value="200"></asp:ListItem>
                                                                <asp:ListItem Text="500" Value="500"></asp:ListItem>
                                                                <asp:ListItem Text="1000" Value="1000"></asp:ListItem>
                                                                <asp:ListItem Text="2000" Value="2000"></asp:ListItem>
                                                                <asp:ListItem Text="5000" Value="5000"></asp:ListItem>
                                                                <asp:ListItem Text="10000" Value="10000"></asp:ListItem>
                                                                <asp:ListItem Text="50000" Value="50000"></asp:ListItem>
                                                                <asp:ListItem Text="All items" Value="0"></asp:ListItem>
                                                            </iwc:IboDropDownList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                            <iwc:IboWebLabel ID="lblMaxRecordVisible" runat="server" Text="Max Record Visible:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 50px;">
                                                            <iwc:IboWebCheckBox runat="server" ID="chkMaxRecordVisible" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                            <iwc:IboWebLabel ID="lblShowFooter" runat="server" Text="Mostra footer:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 45px;">
                                                            <iwc:IboWebCheckBox runat="server" ID="chkShowFooter" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpDoc" runat="server" Enabled="true" ScrollBars="Auto">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDocCaption" Text="Campi"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel ID="cpTabgrd_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                <iwc:IboWebLabel ID="cpTabgrd_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Elenco Campi"></iwc:IboWebLabel>
                                            </asp:Panel>
                                            <asp:Panel ID="cpTabgrd_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                <asp:UpdatePanel ID="UPTreeViewContent" runat="server" UpdateMode="Conditional" ClientIDMode="Static">
                                                    <ContentTemplate>
                                                        <asp:Panel ID="cpTabgrd_Body_Grid" runat="server" CssClass="CollapsiblePanelBodyGrid">
                                                            <table class="tableGridContainer">
                                                                <tr>
                                                                    <td>
                                                                        <iwc:iboWebToolbar ID="tlbgrdTabgrd" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                            CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                        <iwc:IboWebPanel ID="pnlTabgrd" runat="server" CssClass="DetailFormGridContainerDiv" Style="height: 460px;" MaintainScrollPositionOnPostBack="True"
                                                                            ScrollBars="Auto">
                                                                            <iwc:IboGridView ID="grdTabgrd" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" PageSize="20"
                                                                                Width="100%">
                                                                                <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                <PagerStyle Font-Size="Small" />
                                                                                <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                            </iwc:IboGridView>
                                                                        </iwc:IboWebPanel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                        <br />
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </asp:Panel>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                                <ajaxToolkit:TabPanel ID="tpButtons" runat="server" Enabled="true" ScrollBars="Auto">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="IboWebLabel2" Text="Pulsanti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <div id="PulsantiLeftSite">
                                                <asp:Panel ID="cpTabbot_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                    <iwc:IboWebLabel ID="cpTabbot_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Elenco Pulsanti configurati"></iwc:IboWebLabel>
                                                </asp:Panel>
                                                <asp:Panel ID="cpTabbot_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                    <asp:UpdatePanel ID="upTabbot" runat="server" UpdateMode="Conditional" ClientIDMode="Static">
                                                        <ContentTemplate>
                                                            <asp:Panel ID="cpTabbot_Body_Grid" runat="server" CssClass="CollapsiblePanelBodyGrid">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <iwc:iboWebToolbar ID="tlbgrdTabbot" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                                CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            <iwc:IboWebPanel ID="pnlTabbot" runat="server" CssClass="DetailFormGridContainerDiv pnlTabbot" MaintainScrollPositionOnPostBack="True"
                                                                                ScrollBars="Auto">
                                                                                <iwc:IboGridView ID="grdTabbot" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                    BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" PageSize="20"
                                                                                    Width="100%">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </iwc:IboWebPanel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </asp:Panel>
                                            </div>
                                            <div id="PulsantiRightSite">
                                                <asp:Panel ID="cpTabbot2_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                                    <iwc:IboWebLabel ID="cpTabbot2_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Elenco Pulsanti disponibili"></iwc:IboWebLabel>
                                                </asp:Panel>
                                                <asp:Panel ID="cpTabbot2_Body" runat="server" CssClass="CollapsiblePanelBody">
                                                    <asp:UpdatePanel ID="upTabbot2" runat="server" UpdateMode="Conditional" ClientIDMode="Static">
                                                        <ContentTemplate>
                                                            <asp:Panel ID="cpTabbot2_Body_Grid" runat="server" CssClass="CollapsiblePanelBodyGrid">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <div style="width: calc(100% - 210px); float: left;">
                                                                                <iwc:iboWebToolbar ID="tlbgrdTabbot2" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24" CssClassButton="ToolbarButton"
                                                                                    CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            </div>
                                                                            <asp:Panel runat="server" ID="pnlButtonFilter" Style="float: left; width: 210px;" DefaultButton="ButtonFilterConferma">
                                                                                <iwc:IboWebTextBox runat="server" ID="ButtonFilterText" CharacterCase="Uppercase" CssClass="ButtonFilterText"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebButton runat="server" ID="ButtonFilterConferma" CssClass="ButtonFilterConferma" Text="Ok" />
                                                                                <iwc:IboWebButton runat="server" ID="ButtonFilterReset" CssClass="ButtonFilterReset" Text="Reset" />
                                                                            </asp:Panel>
                                                                            <iwc:IboWebPanel ID="pnlTabbot2" runat="server" CssClass="DetailFormGridContainerDiv pnlTabbot2" MaintainScrollPositionOnPostBack="True"
                                                                                ScrollBars="Auto" Style="clear: both;">
                                                                                <iwc:IboGridView ID="grdTabbot2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A" BorderStyle="Solid"
                                                                                    BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left" PageSize="20"
                                                                                    Width="100%">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </iwc:IboWebPanel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </asp:Panel>
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </ajaxToolkit:TabPanel>
                            </ajaxToolkit:TabContainer>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel" style="margin-left: 100px;">
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
    <asp:Panel ID="PopupFormGlobalContainer" runat="server" Visible="false">
        <asp:Panel ID="PopupFormContainer" runat="server" CssClass="PopupFormContainer" Style="display: none;">
            <asp:Panel ID="PopupFormTitleBar" runat="server" CssClass="PopupFormTitleBar">
                <iwc:IboWebLabel ID="PopupFormCaption" runat="server" Text="..." CssClass="PopupFormCaption" Translate="false"></iwc:IboWebLabel>
            </asp:Panel>
            <asp:UpdatePanel runat="server" ID="UPPopupForm" ChildrenAsTriggers="True" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Panel ID="PopupFormBody" runat="server" CssClass="PopupFormBody">
                        <iwc:IboWebDetailPanel runat="server" ID="cpTabgrd_Body_Detail" CssClass="CollapsiblePanelBodyDetail" TableName="WFI_Tabgrd" CancelButtonId=""
                            OkButtonId="" AutoViewDetail="false" Title="Dettaglio di campo" Style="width: 750px; padding-top: 10px; padding-bottom: 10px;">
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblNomCam" runat="server" Text="Nome:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 285px;">
                                        <iwc:IboWebComboTlk ID="cmbNomCam" runat="server" SqlQuery="SELECT * FROM CBO_WFI_ELENCOCAMPITABELLA1" Width="280px" Required="True" ReadOnly="true" AutoPostBack="true"
                                            FieldDescription="Nome">
                                        </iwc:IboWebComboTlk>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 120px;">
                                        <iwc:IboWebLabel ID="lblDettCanSort" runat="server" Text="Ordinamento attivato:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 78px;">
                                        <iwc:IboWebRadioButtonList ID="optDetCanSort" runat="server" RepeatDirection="Horizontal" Height="25px" FieldName="CanSort">
                                            <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                        </iwc:IboWebRadioButtonList>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 95px;">
                                        <iwc:IboWebLabel ID="lblHtmlEncode" runat="server" Text="Interpreta Html:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 30px;">
                                        <iwc:IboWebCheckBox ID="chkHtmlEncode" runat="server" ValueIfNotChecked="S" ValueIfChecked="N" Value="S"></iwc:IboWebCheckBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblDesCam" runat="server" Text="Descr. breve:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 285px;">
                                        <iwc:IboWebTextBox ID="txtDesCam" runat="server" CharacterCase="None" MaxLength="255" Width="275px" Required="true" FieldDescription="Descr. breve"></iwc:IboWebTextBox>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 120px;">
                                        <iwc:IboWebLabel ID="lblVisible" runat="server" Text="Visibile:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 78px;">
                                        <iwc:IboDropDownList ID="cmbFieldVisibile" runat="server" Width="75px" FieldName="Visibile">
                                            <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                            <asp:ListItem Value="H" Text="Nascosto"></asp:ListItem>
                                        </iwc:IboDropDownList>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 95px;">
                                        <iwc:IboWebLabel ID="lblVisibleInFilter" runat="server" Text="Visibile nel filtro:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 30px;">
                                        <iwc:IboWebCheckBox ID="chkVisibleInFilter" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblExtendedDesCam" runat="server" Text="Tooltip:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 285px;">
                                        <iwc:IboWebTextBox ID="txtExtendedDesCam" runat="server" CharacterCase="None" MaxLength="255" Width="275px"></iwc:IboWebTextBox>
                                    </td>

                                    <td class="DetailFormDescriptionCell" style="width: 120px;">
                                        <iwc:IboWebLabel ID="lblVisibleInExp" runat="server" Text="Visibile in Exp:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 100px;">
                                        <iwc:IboDropDownList ID="cmbFieldVisibileInExp" runat="server" Width="95px" FieldName="VisibleInExp" Required="true">
                                            <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                            <asp:ListItem Value="X" Text="Non definito"></asp:ListItem>
                                        </iwc:IboDropDownList>
                                    </td>
                                </tr>
                            </table>
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblProRig" runat="server" Text="Sequenza:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 205px;">
                                        <iwc:IboWebNumericTlk runat="server" ID="txtProrig" MaxValue="9999" Width="70px" MaxLength="4" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                        <iwc:IboWebHidden runat="server" ID="Tabgrd_NomRif" FieldName="NomRif" />
                                        <iwc:IboWebHidden runat="server" ID="Tabgrd_Utente" FieldName="Utente" />
                                        <iwc:IboWebHidden runat="server" ID="Tabgrd_NomTab" FieldName="NomTab" />
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblLarCam" runat="server" Text="Larghezza (px):"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 75px;">
                                        <iwc:IboWebNumericTlk runat="server" ID="txtLarCam" MaxValue="9999" Width="70px" MaxLength="4" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 120px;">
                                        <iwc:IboWebLabel ID="lblIsKey" runat="server" Text="Chiave:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 75px;">
                                        <iwc:IboWebCheckBox ID="chkIsKey" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblHorizontalAlign" runat="server" Text="Allineamento Orizz.:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 205px;">
                                        <iwc:IboWebComboTlk ID="cmbHorizontalAlign" runat="server" SqlQuery="SELECT * FROM CBO_WFI_HorizontalAlign" Width="200px" Required="True" FieldDescription="Allineamento Orizz.">
                                        </iwc:IboWebComboTlk>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblForCam" runat="server" Text="Formato:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 300px;">
                                        <iwc:IboWebComboTlk ID="FormattazioneDatetime" runat="server" SqlQuery="SELECT * FROM CBO_WFI_FORMATTAZIONE_DATE" Width="295px" FieldName=""></iwc:IboWebComboTlk>
                                        <iwc:IboWebTextBox ID="Formattazione" runat="server" CharacterCase="Uppercase" MaxLength="50" Width="288px" FieldName="" ReadOnly="true"></iwc:IboWebTextBox>
                                        <iwc:IboWebNumericTlk ID="NumeroDecimali" runat="server" MaxValue="6" Width="20px" MaxLength="1" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                        <iwc:IboWebHidden ID="tabgrd_verticalAlign" runat="server" FieldName="VerticalAlign" Value="Middle" />
                                    </td>
                                </tr>
                            </table>
                            <table class="DetailFormSectionTable2Fixed">
                                <tr style="height: 28px;">
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblOrdCam" runat="server" Text="Pos.Ordinamento:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 205px;">
                                        <iwc:IboDropDownList runat="server" ID="cmbOrdCam" Width="50px" AutoPostBack="true" Required="true" FieldDescription="Ordinamento">
                                            <asp:ListItem Text="0" Value="0" Selected="True"></asp:ListItem>
                                            <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                            <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                            <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                            <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                            <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                            <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                            <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                            <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                        </iwc:IboDropDownList>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblOrdDir" runat="server" Text="Direz. ord.:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell">
                                        <iwc:IboWebRadioButtonList ID="optOrdDir" runat="server" RepeatDirection="Horizontal" Height="25px">
                                            <asp:ListItem Value="" Text="Nessuno" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="ASC" Text="Ascendente"></asp:ListItem>
                                            <asp:ListItem Value="DESC" Text="Discendente"></asp:ListItem>
                                        </iwc:IboWebRadioButtonList>
                                    </td>
                                </tr>
                            </table>
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblWrapCol" runat="server" Text="WrapCol:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 205px;">
                                        <iwc:IboWebRadioButtonList ID="optWrapCol" runat="server" RepeatDirection="Horizontal" Height="25px">
                                            <asp:ListItem Value="" Text="Non definito" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                        </iwc:IboWebRadioButtonList>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblMaxChar" runat="server" Text="Max char:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 75px;">
                                        <iwc:IboWebNumericTlk ID="txtMaxChar" runat="server" Width="70px" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                    </td>
                                </tr>
                            </table>
                            <table class="DetailFormSectionTable2Fixed">
                                <tr>
                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                        <iwc:IboWebLabel ID="lblCssClass" runat="server" Text="Classe CSS:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell" style="width: 205px;">
                                        <iwc:IboWebTextBox ID="txtCssClass" runat="server" CharacterCase="None" MaxLength="60" Width="200px"></iwc:IboWebTextBox>
                                    </td>
                                    <td class="DetailFormDescriptionCell" style="width: 98px;">
                                        <iwc:IboWebLabel ID="lblFunzioneRaggruppamento" runat="server" Text="Funz.Raggr:"></iwc:IboWebLabel>
                                    </td>
                                    <td class="DetailFormValueCell">
                                        <iwc:IboDropDownList runat="server" ID="cmbAggregateFunc" Width="200px">
                                            <asp:ListItem Text="Somma" Value="Sum"></asp:ListItem>
                                            <asp:ListItem Text="Massimo" Value="Max"></asp:ListItem>
                                            <asp:ListItem Text="Minimo" Value="Min"></asp:ListItem>
                                            <asp:ListItem Text="Media" Value="Avg"></asp:ListItem>
                                            <asp:ListItem Text="" Value="" Selected="true"></asp:ListItem>
                                        </iwc:IboDropDownList>
                                    </td>
                                </tr>
                            </table>
                            <iwc:IboWebTextBox ID="ProRigOriginale" runat="server" Style="display: none;"></iwc:IboWebTextBox>
                            <iwc:IboWebTextBox ID="FormattazioneNum" runat="server" Style="display: none;"></iwc:IboWebTextBox>
                        </iwc:IboWebDetailPanel>
                        <iwc:IboWebDetailPanel runat="server" ID="cpTabbot_Body_Detail" CssClass="CollapsiblePanelBodyDetail" TableName="WFI_Tabbot" CancelButtonId=""
                            OkButtonId="" AutoViewDetail="false" Title="Elenco pulsanti associati a griglia" Style="width: 500px;">
                            <div style="margin: 5px;">
                                <table class="DetailFormSectionTable2">
                                    <tr>
                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                            <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                        </td>
                                        <td class="DetailFormValueCell">
                                            <iwc:IboWebTextBox runat="server" ID="DescrizionePulsante" FieldName="" ReadOnly="true" SqlQueryLookup="SELECT DESBOT FROM WFI_ALLBTN WHERE NUMBOT='<#CONTROLS_RECORD.Numbot#>'"
                                                Width="360px"></iwc:IboWebTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="DetailFormDescriptionCell">
                                            <iwc:IboWebLabel ID="lblPesBot" runat="server" Text="Peso"></iwc:IboWebLabel>
                                        </td>
                                        <td class="DetailFormValueCell">
                                            <iwc:IboWebNumericTlk runat="server" ID="txtPesbot" MaxValue="9999" Width="50px" MaxLength="2" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="DetailFormDescriptionCell">
                                            <iwc:IboWebLabel ID="lblOrdinamento" runat="server" Text="Peso"></iwc:IboWebLabel>
                                        </td>
                                        <td class="DetailFormValueCell">
                                            <iwc:IboWebNumericTlk runat="server" ID="txtOrdinamento" MaxValue="9999" Width="50px" MaxLength="4" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="DetailFormDescriptionCell">
                                            <iwc:IboWebLabel ID="lblShowCaption" runat="server" Text="Mostra caption:"></iwc:IboWebLabel>
                                        </td>
                                        <td class="DetailFormValueCell">
                                            <iwc:IboWebCheckBox ID="chkShowCaption" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="DetailFormDescriptionCell">
                                            <iwc:IboWebLabel ID="lblShowImage" runat="server" Text="Mostra immagine:"></iwc:IboWebLabel>
                                        </td>
                                        <td class="DetailFormValueCell">
                                            <iwc:IboWebCheckBox ID="chkShowImage" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="DetailFormDescriptionCell">
                                            <iwc:IboWebLabel ID="lblVisibile2" runat="server" Text="Visibile:"></iwc:IboWebLabel>
                                        </td>
                                        <td class="DetailFormValueCell">
                                            <iwc:IboWebCheckBox ID="chkVisibile2" runat="server" Checked="True" Value="S" FieldName="Visibile"></iwc:IboWebCheckBox>
                                        </td>
                                    </tr>
                                </table>
                            </div>

                            <iwc:IboWebTextBox runat="server" ID="Utente" FieldName="Utente" Display="false"></iwc:IboWebTextBox>
                            <iwc:IboWebTextBox runat="server" ID="NomRif" FieldName="NomRif" Display="false"></iwc:IboWebTextBox>
                            <iwc:IboWebTextBox runat="server" ID="Numbot" FieldName="NumBot" Display="false"></iwc:IboWebTextBox>
                        </iwc:IboWebDetailPanel>
                    </asp:Panel>
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
                </ContentTemplate>
            </asp:UpdatePanel>
        </asp:Panel>
        <asp:Button runat="server" ID="hiddenTargetControlForPopupForm" Style="display: none" />
        <ajaxToolkit:ModalPopupExtender runat="server" ID="PopupForm" TargetControlID="hiddenTargetControlForPopupForm" PopupControlID="PopupFormContainer"
            BackgroundCssClass="PopupFormBackground" RepositionMode="RepositionOnWindowResize" Drag="True" PopupDragHandleControlID="PopupFormTitleBar"
            DropShadow="True" CancelControlID="" OkControlID="">
        </ajaxToolkit:ModalPopupExtender>
    </asp:Panel>
</asp:Content>
<asp:Content ID="MasterPopupFormContent" ContentPlaceHolderID="phMasterPopupForm" runat="server">
    <asp:Panel ID="pnlTabgrdForSorting" runat="server" Visible="false" Style="width: 1240px; height: 550px;">
        <table class="tableGridContainer">
            <tr>
                <td>
                    <asp:Panel ID="pnlTabgrdForSortingDD" runat="server" CssClass="DetailFormGridContainerDiv pnlTabgrdForSortingDD">
                        <iwc:IboGridView ID="grdTabgrdForSortingDD" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                            BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                            HorizontalAlign="Left" PageSize="20" Width="100%" EnableMultiSelection="false">
                            <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                            <PagerStyle Font-Size="Small" />
                            <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                        </iwc:IboGridView>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
