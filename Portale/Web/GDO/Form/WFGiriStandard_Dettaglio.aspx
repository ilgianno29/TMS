<%@ Page Title="Gestione Giri Standard Dettaglio" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFGiriStandard_Dettaglio.aspx.vb" Inherits="Incasbo.Web.GDO.WFGiriStandard_Dettaglio" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/css/WFGiriStandard_Dettaglio.css?d=20131111" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
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
                        <asp:Panel runat="server" ID="pnlMain_Dettaglio" Width="1000px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle" style="position: relative;">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <div class="DetailFormModeImageDiv">
                                        <asp:Image ID="imgModalita" runat="server" />
                                    </div>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblIdGiro" runat="server" IncasTag="" Text="Codice Giro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" MaxLength="20" Width="100px" ReadOnly="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px;">
                                                <iwc:IboWebHidden ID="txtId" runat="server" FieldName="Id" IncasTag="IsIdentity=S"></iwc:IboWebHidden>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:Panel ID="pnlIniziale" runat="server" CssClass="pnlIniziale">
                                        <asp:Panel runat="server" ID="pnlDatiTestata" CssClass="pnlDatiTestata">
                                            <iwc:IboWebLabel ID="lblDatiTestataCaption" runat="server" IncasTag="" Text="Dati Testata Giro" CssClass="lblDatiTestataCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed DatiTestataTable">
                                                <tr style="height: 25px">
                                                    <td class="DetailFormDescriptionCell" style="width: 110px;">
                                                        <iwc:IboWebLabel ID="lblRiferimentoEsterno1" runat="server" IncasTag="" Text="Riferimento esterno:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 365px;">
                                                        <iwc:IboWebLabel ID="lblRiferimentoEsterno" runat="server" Width="360px" Font-Bold="true"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 110px;">
                                                        <iwc:IboWebLabel ID="lblDescrizione1" runat="server" IncasTag="" Text="Descrizione giro:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 365px;">
                                                        <iwc:IboWebLabel ID="lblDescrizione" runat="server" Font-Bold="true" Width="360px"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                                <tr style="height: 25px">
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblDescGiornoPartenza1" runat="server" IncasTag="" Text="Giorno Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded">
                                                        <iwc:IboWebLabel ID="lblDescGiornoPartenza" runat="server" Width="360px" Font-Bold="true"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblDescGiornoCutOff1" runat="server" IncasTag="" Text="Giorno CutOff:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded">
                                                        <iwc:IboWebLabel ID="lblDescGiornoCutOff" runat="server" Width="360px" Font-Bold="true"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                                <tr style="height: 25px">
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblTipoMerce1" runat="server" IncasTag="" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded">
                                                        <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Width="360px" Font-Bold="true" SqlQueryLookup="select isnull(TM.descrizione, '') from GiriStandard_Testata T LEFT JOIN TipiMerce TM ON TM.CODICE=T.TipoMerce where T.Codice='<#CONTROLS_RECORD.txtCodice#>'"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblTipoSpedizione1" runat="server" IncasTag="" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded">
                                                        <iwc:IboWebLabel ID="lblTipoSpedizione" ViewStateMode="Enabled" runat="server" Width="360px" Font-Bold="true" SqlQueryLookup="select isnull(TS.descrizione, '') from GiriStandard_Testata T LEFT JOIN TipiSpedizione TS ON TS.CODICE=T.TipoSpedizione where T.Codice='<#CONTROLS_RECORD.txtCodice#>'"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                                <tr style="height: 25px">
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblDepositoPartenza1" runat="server" IncasTag="" Text="Deposito Partenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded">
                                                        <%--<iwc:IboWebLabel ID="lblDepositoPartenza" runat="server" Width="400px" Font-Bold="true" SqlQueryLookup="select isnull(P.ragionesociale, '') + ' - ' + isnull(P.localita, '') from GiriStandard_Testata T LEFT JOIN PCS P ON P.CODICE=T.DepositoPartenza where T.Codice='<#CONTROLS_RECORD.txtCodice#>'"></iwc:IboWebLabel>--%>
                                                        <iwc:IboWebLabel ID="lblDepositoPartenza" runat="server" Width="360px" Font-Bold="true"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell">
                                                        <iwc:IboWebLabel ID="lblDepositoArrivo1" runat="server" IncasTag="" Text="Deposito Arrivo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded">
                                                        <%--<iwc:IboWebLabel ID="lblDepositoArrivo" runat="server" Width="400px" Font-Bold="true" SqlQueryLookup="select isnull(P.ragionesociale, '') + ' - ' + isnull(P.localita, '') from GiriStandard_Testata T LEFT JOIN PCS P ON P.CODICE=T.DepositoArrivo where T.Codice='<#CONTROLS_RECORD.txtCodice#>'"></iwc:IboWebLabel>--%>
                                                        <iwc:IboWebLabel ID="lblDepositoArrivo" runat="server" Width="360px" Font-Bold="true"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlIniziale1" runat="server" CssClass="pnlIniziale1">
                                        <asp:Panel runat="server" ID="pnlDatiDettaglio" CssClass="pnlDatiDettaglio">
                                            <iwc:IboWebLabel ID="lblDatiDettaglioCaption" runat="server" IncasTag="" Text="Dati Dettaglio Giro" CssClass="lblDatiDettaglioCaption"></iwc:IboWebLabel>
                                            <table class="DetailFormSectionTable2Fixed DatiDettaglioTable">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblPcs" runat="server" Text="Destinatario:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbPcs" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="600px" AutoLoadOnDemand="true"></iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed DatiDettaglioTable1">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblOraConsegna" runat="server" IncasTag="" Text="Ora Consegna:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebDate2 ID="txtOraConsegna" runat="server" Width="70px" ControlType="TimeOnly" Tooltip="OraConsegna" FormatoOra="HH:mm"
                                                            TimeControlWidth="70px" FieldName="OraConsegna" Required="true" />
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblSequenza" runat="server" IncasTag="" Text="Sequenza:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebTextBox ID="txtSequenza" runat="server" Width="100px" Required="True" ValidationRules="IntegerNumber"></iwc:IboWebTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed DatiDettaglioTable2">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblCorrispondente" runat="server" IncasTag="" Text="Corrispondente:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                        <iwc:IboWebComboTlk ID="cmbCorrispondente" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_Corrispondenti"
                                                            Width="600px" CampoDescrizione="DESCRIZIONE" AutoLoadOnDemand="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
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
