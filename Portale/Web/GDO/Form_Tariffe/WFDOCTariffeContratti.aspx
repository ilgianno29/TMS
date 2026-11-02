<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCTariffeContratti.aspx.vb"
    Inherits="Incasbo.Web.GDO.WFDOCTariffeContratti" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/Css/WFDOCTariffeContratti.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Codice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="120px" Required="True"
                                                    FieldName="Codice"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblContrattoTrasporto" runat="server" IncasTag="" Text="Contr. Trasp.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebCheckBox ID="chkContrattoTrasporto" runat="server" IncasTag="" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblContrattoGiacenza" runat="server" IncasTag="" Text="Contr. Giacen.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebCheckBox ID="chkContrattoGiacenza" runat="server" IncasTag="" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" IncasTag="" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" IncasTag="" Checked="True" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDescrizione" Required="True" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="700px"
                                                    FieldName="Descrizione"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblAttivaPassiva" runat="server" IncasTag="" Text="Attiva / Passiva:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 170px;">
                                                <iwc:IboDropDownList ID="cmbAttivaPassiva" runat="server" CharacterCase="Uppercase" IncasTag="" SqlQuery="SELECT * FROM CBO_DOC_TipoContratti"
                                                    Width="160px" SqlQueryFilter="" FieldName="AttivaPassiva" AutoPostBack="true" Required="True">
                                                </iwc:IboDropDownList>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="lblClienteTrasportatore" runat="server" IncasTag="" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 470px;">
                                                <iwc:IboWebComboTlk ID="cmbCliente" runat="server" IncasTag="" Required="False" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" Width="460px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                                <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" IncasTag="" Required="False" SqlQuery="SELECT * FROM CBO_ANA_TRASPORTATORI" Width="460px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblDataInizioValidita" runat="server" IncasTag="" Text="Data inizio validita:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebDate ID="txtDataInizioValidita" runat="server" Width="80px" Required="True" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblDataFineValidita" runat="server" IncasTag="" Text="Data fine validita:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebDate ID="txtDataFineValidita" runat="server" Width="80px" Required="True" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblTassazioneRiconsegne" runat="server" IncasTag="" Text="Tassazione Riconsegne:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebCheckBox ID="chkTassazioneRiconsegne" runat="server" IncasTag="" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblPercentualeRiconsegne" runat="server" IncasTag="" Text="Percentuale Riconsegne:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtPercentualeRiconsegne" Required="true" MaxValue="200" Width="50px" MaxLength="6">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblRapportoPV" runat="server" IncasTag="" Text="Rapporto Peso/Volume:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtRapportoPV" Required="true" Width="80px" MaxLength="9" DecimalDigits="0">
                                                </iwc:IboWebNumericTlk>
                                            </td>                                            
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblTassazioneResi" runat="server" IncasTag="" Text="Tassazione Resi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebCheckBox ID="chkTassazioneResi" runat="server" IncasTag="" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 120px;">
                                                <iwc:IboWebLabel ID="lblPercentualeResi" runat="server" IncasTag="" Text="Percentuale Resi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtPercentualeResi" Required="true" MaxValue="200" Width="50px" MaxLength="6">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblArrotondamentoImporti" runat="server" IncasTag="" Text="Arrot. Importi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtArrotondamentoImporti" Required="true" Width="80px" DecimalDigits="5">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpRaggruppamenti_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpRaggruppamenti_Title_Caption" Text="Raggruppamenti" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpRaggruppamenti_Body" CssClass="CollapsiblePanelBody">
                                    <asp:Table runat="server" ID="RaggruppamentoSpedizione" CssClass="DetailFormSectionTable2Fixed">
                                        <asp:TableRow>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 120px">
                                                <iwc:IboWebLabel ID="lblRaggruppamento" runat="server" IncasTag="" Text="Raggruppamento:"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormValueCell" Style="width: 30px">
                                                <iwc:IboWebCheckBox ID="chkRaggruppamento" runat="server" IncasTag="" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 80px" ID="labelIncludiMittente">
                                                <iwc:IboWebLabel ID="lblIncludiMittente" runat="server" IncasTag="" Text="Incl. Mittente:"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormValueCell" Style="width: 30px" ID="checkIncludiMittente">
                                                <iwc:IboWebCheckBox ID="chkIncludiMittente" runat="server" IncasTag="" Checked="false" Value="N"></iwc:IboWebCheckBox>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 80px" ID="labelIncludiCliente">
                                                <iwc:IboWebLabel ID="lblIncludiCliente" runat="server" IncasTag="" Text="Incl. Cliente:"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormValueCell" Style="width: 30px" ID="checkIncludiCliente">
                                                <iwc:IboWebCheckBox ID="chkIncludiCliente" runat="server" IncasTag="" Checked="true" Value="S"></iwc:IboWebCheckBox>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 80px" ID="labelIncludiPCSPartenza">
                                                <iwc:IboWebLabel ID="lblIncludiPCSPartenza" runat="server" IncasTag="" Text="Incl. PCS Partenza:"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormValueCell" Style="width: 30px" ID="checkIncludiPCSPartenza">
                                                <iwc:IboWebCheckBox ID="chkIncludiPCSPartenza" runat="server" IncasTag="" Checked="true" Value="S"></iwc:IboWebCheckBox>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpVoci_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpVoci_Title_Caption" Text="Voci per raggruppamenti" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpVoci_Body" CssClass="CollapsiblePanelBody">
                                    <iwc:IboWebPanel runat="server" ID="pnlVociContainer" ClientIDMode="Static" MaintainScrollPositionOnPostBack="true">
                                        <table class="noBorderTable">
                                            <tr>
                                                <td>
                                                    <table class="tableVoci">
                                                        <thead>
                                                            <tr class="Header">
                                                                <th style="width: 20px;">&nbsp;
                                                                </th>
                                                                <th class="DetailFormDescriptionCell" style="width: 500px; text-align: left; padding-bottom: 10px;">
                                                                    <iwc:IboWebLabel ID="lblDescrizioneVoce" runat="server" IncasTag="" Text="Voce" Width="290px"></iwc:IboWebLabel>
                                                                </th>
                                                                <th class="DetailFormDescriptionCell" style="width: 80px; text-align: left; padding-bottom: 10px;">
                                                                    <iwc:IboWebLabel ID="lblRaggruppaVoce" runat="server" IncasTag="" Text="Raggruppa"></iwc:IboWebLabel>
                                                                </th>
                                                                <th class="DetailFormDescriptionCell" style="width: 210px; text-align: left; padding-bottom: 10px;">
                                                                    <iwc:IboWebLabel ID="lblTipoRipartizione" runat="server" IncasTag="" Text="Tipo Ripartizione"></iwc:IboWebLabel>
                                                                </th>
                                                                <th style="width: auto;">&nbsp;
                                                                </th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <asp:Repeater ID="RepeaterVoci" runat="server">
                                                                <ItemTemplate>
                                                                    <tr class="Body">
                                                                        <td>&nbsp;
                                                                        </td>
                                                                        <td class="DetailFormValueCell">
                                                                            <iwc:IboWebLabel ID="VoceCodice" runat="server" IncasTag="" Text="" Translate="false" Display="false"></iwc:IboWebLabel>
                                                                            <iwc:IboWebLabel ID="VoceDescrizione" runat="server" IncasTag="" Text="" Translate="false"></iwc:IboWebLabel>
                                                                        </td>
                                                                        <td class="DetailFormValueCell">
                                                                            <iwc:IboWebCheckBox ID="RaggruppaVoce" runat="server" IncasTag="" AutoPostBack="True" OnCheckedChanged="RaggruppaVoce_CheckedChanged"></iwc:IboWebCheckBox>
                                                                        </td>
                                                                        <td class="DetailFormValueCell">
                                                                            <iwc:IboDropDownList ID="TipoRipartizione" runat="server" IncasTag="" Width="190px" Translate="False" SqlQuery="SELECT * FROM CBO_DOC_VociTipiRipartizione">
                                                                            </iwc:IboDropDownList>
                                                                            &nbsp;
                                                                        </td>
                                                                        <td>&nbsp;
                                                                        </td>
                                                                    </tr>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </tbody>
                                                    </table>
                                                </td>
                                                <td style="vertical-align: top;">
                                                    <iwc:IboWebPanel runat="server" ID="pnlVociCommands" ClientIDMode="Static">
                                                        <iwc:IboWebButton ID="btnTuttiVoci" runat="server" Text="Tutti" CssClass="Button_CheckAll" />
                                                        <br />
                                                        <iwc:IboWebButton ID="btnNessunoVoci" runat="server" Text="Nessuno" CssClass="Button_UncheckAll" />
                                                    </iwc:IboWebPanel>
                                                </td>
                                            </tr>
                                        </table>
                                    </iwc:IboWebPanel>
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
