<%@ Page Title="Gestione Giri Standard" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFSMLGiriTestata.aspx.vb" Inherits="Incasbo.Web.GDO.WFSMLGiriTestata" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/Css/checkedDropDownList-min.css?d=20161114" />
    <link rel="stylesheet" href="../../WFI/css/DetailForm.css?d=20161114" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFSMLGiriTestata.css?d=20172703" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server">
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
                                <%--<div class="DetailFormModeImageDiv">
                                    <asp:Image ID="imgModalita" runat="server" />
                                </div>--%>
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
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle" Style="position: relative;">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <div class="DetailFormModeImageDiv">
                                        <asp:Image ID="imgModalita" runat="server" />
                                    </div>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <asp:Panel ID="pnlIniziale1" runat="server" CssClass="pnlIniziale1">
                                        <asp:Panel runat="server" ID="pnlRiferimenti" CssClass="pnlRiferimentiCaption">
                                            <iwc:IboWebLabel ID="lblRiferimenti" runat="server" Text="Riferimenti" CssClass="lblRiferimentiCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed RiferimentiTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                        <iwc:IboWebLabel ID="lblIdGiro" runat="server" Text="Codice Giro:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 130px;">
                                                        <iwc:IboWebTextBox ID="txtCodice" runat="server" MaxLength="20" CharacterCase="Uppercase" Width="100px" Required="true"></iwc:IboWebTextBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                        <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 555px;">
                                                        <iwc:IboWebTextBox ID="txtDescrizione" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="550px"></iwc:IboWebTextBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                        <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 50px;">
                                                        <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                        <iwc:IboWebLabel ID="lblRiferimentoEsterno" runat="server" Text="Riferimento esterno:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 130px;">
                                                        <iwc:IboWebTextBox ID="txtRiferimentoEsterno" runat="server" MaxLength="20" CharacterCase="Uppercase" Width="100px"></iwc:IboWebTextBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                        <iwc:IboWebLabel ID="lblOraPartenza" runat="server" Text="Ora partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebDate2 ID="txtOraPartenza" runat="server" Width="90px" ControlType="TimeOnly" FormatoOra="HH:mm"
                                                            TimeControlWidth="60px" FieldName="OraPartenza" Required="true" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlIniziale2" runat="server" CssClass="pnlIniziale2">
                                        <asp:Panel runat="server" ID="PanelEstremi" CssClass="pnlEstremi">
                                            <iwc:IboWebLabel ID="lblEstremiCaption" runat="server" Text="Estremi" CssClass="lblEstremiCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed EstremiTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                        <iwc:IboWebLabel ID="lblTipoViaggio" runat="server" Text="Tipo Viaggio:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoViaggio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_VIAGGI_TIPIVIAGGIO" Width="400px" DropDownWidth="500px">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 105px;">
                                                        <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TRASPORTATORI" Style="width: 400px;" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoMezzo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMEZZO" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true" Required="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblMezzo" runat="server" Text="Mezzo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebTextBox ID="txtMezzo" runat="server" MaxLength="6" CharacterCase="Uppercase" Width="393px"></iwc:IboWebTextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                        <iwc:IboWebLabel ID="lblAutista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebTextBox ID="tztAutista" runat="server" MaxLength="15" CharacterCase="Uppercase" Width="393px"></iwc:IboWebTextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true" Required="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed EstremiTable2">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true" Required="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblDepositoPartenza" runat="server" Text="Dep. Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbDepositoPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIPARTENZA" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true" Required="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblDepositoArrivo" runat="server" Text="Dep. Arrivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbDepositoArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIARRIVO" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblMacrozona" runat="server" Text="Macro Zona:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbMacrozona" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneMacro" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblZonaSpedizione" runat="server" Text="Zona Spedizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONESPEDIZIONE" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlIniziale3" runat="server" CssClass="pnlIniziale3">
                                        <asp:Panel runat="server" ID="pnlNota" CssClass="pnlNotaCaption">
                                            <iwc:IboWebLabel ID="lblNota" runat="server" Text="Altro" CssClass="lblNotaCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed NoteTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                        <iwc:IboWebLabel ID="IboWebLabel4" runat="server" Text="Nota:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 900px;" colspan="9">
                                                        <iwc:IboWebTextBox ID="txtNota" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="831px"></iwc:IboWebTextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                        <iwc:IboWebLabel ID="lblFiller1" runat="server" Text="Filler1:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 160px;">
                                                        <iwc:IboWebTextBox ID="txtFiller1" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="150px"></iwc:IboWebTextBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                        <iwc:IboWebLabel ID="lblFiller2" runat="server" Text="Filler2:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 60px;">
                                                        <iwc:IboWebTextBox ID="txtFiller2" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="150px"></iwc:IboWebTextBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                        <iwc:IboWebLabel ID="lblFiller3" runat="server" Text="Filler3:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 160px;">
                                                        <iwc:IboWebTextBox ID="txtFiller3" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="150px"></iwc:IboWebTextBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                        <iwc:IboWebLabel ID="lblFiller4" runat="server" Text="Filler4:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 160px;">
                                                        <iwc:IboWebTextBox ID="txtFiller4" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="150px"></iwc:IboWebTextBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                        <iwc:IboWebLabel ID="lblFiller5" runat="server" Text="Filler5:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 160px;">
                                                        <iwc:IboWebTextBox ID="txtFiller5" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="150px"></iwc:IboWebTextBox>
                                                    </td>
                                                </tr>
                                            </table>                                            
                                        </asp:Panel>
                                    </asp:Panel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpDettagli_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpDettagli_Title_Caption" Text="Dettagli" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpDettagli_Body" CssClass="CollapsiblePanelBody">
                                    <asp:UpdatePanel ID="UPTreeViewContent" runat="server" UpdateMode="Conditional" ClientIDMode="Static">
                                        <ContentTemplate>
                                            <asp:Panel ID="cpGiriDettagli_Grid" runat="server" CssClass="CollapsiblePanelBodyGrid" style="padding:0px;">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbGiriDettagli" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                                CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <iwc:IboWebPanel ID="pnlGiriDettagli" runat="server" CssClass="DetailFormGridContainerDiv pnlGiriDettagli" MaintainScrollPositionOnPostBack="True"
                                                                ScrollBars="Auto">
                                                                <iwc:IboGridView ID="grdGiriDettagli" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" Width="100%" EnableSelectionAutoPostBack="false">
                                                                    <%--<PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                    <PagerStyle Font-Size="Small" />--%>
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
    <asp:Panel ID="pnlCorrispondente" runat="server" Visible="false" Style="width: 600px; height: 60px;">
        <div style="margin: 7px; margin-bottom: 22px; text-align: left;">
            <iwc:IboWebLabel ID="lblCorrispIstruzioni" runat="server" Text="Scegliere il corrispondente che si vuole associare alle spedizioni selezionate. Lasciare vuota la combo nel caso in cui si desideri fare la spedizione in diretta."></iwc:IboWebLabel>
        </div>
        <table style="width: 100%" class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 90px">
                    <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell" style="width: 450px">
                    <iwc:IboWebComboTlk ID="Corrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CORRISPONDENTI" Width="440px" AutoLoadOnDemand="false">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
