<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFTARTariffeDuplica.aspx.vb"
    Inherits="Incasbo.Web.GDO.WFTARTariffeDuplica" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../css/WFPIARilascioDisponibilita.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv" DefaultButton="btnConferma">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1180px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpEstremi_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpEstremi_Title_Caption" Text="Estremi di Duplicazione" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpEstremi_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 150px;"></td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblSorgente" runat="server" IncasTag="" Text="Sorgente" CssClass="WFIGrassetto"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblDestinazione" runat="server" IncasTag="" Text="Destinazione" CssClass="WFIGrassetto"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore"/>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px"></td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoDocumento" runat="server" IncasTag="" Text="Tipo Documento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblTipoDocumentoValue" runat="server" IncasTag="" Text="" Translate="false"
                                                    SqlQueryLookup="SELECT Descrizione FROM TARIFFETIPIDOCUMENTO WHERE CODICE='<#MASTER_RECORD.TipoDocumento#>'">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell"></td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px"></td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblContratto" runat="server" IncasTag="" Text="Contratto:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblContrattoValue" runat="server" IncasTag="" Text="" Translate="false"
                                                    SqlQueryLookup="SELECT Descrizione FROM TariffeContratti WHERE CODICE='<#MASTER_RECORD.Contratto#>'">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="Contratto" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_TAR_CONTRATTI"
                                                    Width="450px" SqlQueryWhere="ATTIVO = 'S' AND CONTRATTOTRASPORTO = 'S'"
                                                    SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE" AutoLoadOnDemand="true" AutoPostBack="true" MaxHeight="170px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelTipoSpedizione" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" IncasTag="" Text="Tipo spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizioneValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT Descrizione FROM TipiSpedizione WHERE CODICE='<#MASTER_RECORD.TipoSpedizione#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="TipoSpedizione" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="170px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelTipoMerce" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" IncasTag="" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblTipoMerceValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM TipiMerce WHERE CODICE='<#MASTER_RECORD.TipoMerce#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="TipoMerce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="140px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelTipoMezzo" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" IncasTag="" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblTipoMezzoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM TipiMezzo WHERE CODICE='<#MASTER_RECORD.TipoMezzo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="TipoMezzo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_TIPIMEZZO"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="140px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:Table runat="server" ID="ClienteModifica" CssClass="DetailFormSectionTable2Fixed">
                                        <asp:TableRow>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelCliente" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" IncasTag="" Text="Cliente:"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormValueCellNoDataBounded" Style="width: 450px">
                                                <iwc:IboWebLabel ID="lblClienteValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT RagioneSociale FROM Clienti WHERE CODICE='<#MASTER_RECORD.Cliente#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </asp:TableCell>
                                            <asp:TableCell CssClass="DetailFormDescriptionCell" Style="width: 450px">
                                                <iwc:IboWebComboTlk ID="Cliente" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="140px">
                                                </iwc:IboWebComboTlk>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelGruppoTariffarioPartenza" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioPartenza" runat="server" IncasTag="" Text="Gruppo Tar. Par.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioPartenzaValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM PCS_GruppiTariffari WHERE CODICE='<#MASTER_RECORD.GruppoTariffarioPartenza#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="GruppoTariffarioPartenza" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="140px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelPCSPartenza" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" IncasTag="" Text="PCS Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblPCSPartenzaValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  RagioneSociale FROM PCS WHERE CODICE='<#MASTER_RECORD.PCSPartenza#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="PCSPartenza" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" SqlQueryWhere="PUNTODICARICO = 'S'" DropDownWidth="600px" MaxHeight="140px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelMacroZonaArrivo" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblMacroZonaArrivo" runat="server" IncasTag="" Text="Macro Zona Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblMacroZonaArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT  Descrizione FROM ZONEMACRO WHERE CODICE='<#MASTER_RECORD.MacroZonaArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="MacroZonaArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_ZoneMacro" Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE"
                                                    CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="170px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelZonaArrivo" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" IncasTag="" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblZonaArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT Codice Descrizione FROM ZONE WHERE CODICE='<#MASTER_RECORD.ZonaArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="ZonaArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffa"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="170px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelGruppoTariffarioArrivo" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioArrivo" runat="server" IncasTag="" Text="Gruppo Tar. Arr.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT Descrizione FROM PCS_GruppiTariffari WHERE CODICE='<#MASTER_RECORD.GruppoTariffarioArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="GruppoTariffarioArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" MaxHeight="200px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormValueCell" style="width: 50px; text-align: center;">
                                                <iwc:IboWebCheckBox ID="SelPCSArrivo" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" IncasTag="" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 450px">
                                                <iwc:IboWebLabel ID="lblPCSArrivoValue" runat="server" IncasTag="" Text="" SqlQueryLookup="SELECT RagioneSociale FROM PCS WHERE CODICE='<#MASTER_RECORD.PCSArrivo#>'"
                                                    Translate="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="PCSArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                    Width="450px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" SqlQueryWhere="PUNTODIDESTINO = 'S'" DropDownWidth="600px" MaxHeight="200px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox ID="txtContratto" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtTipoDocumento" runat="server" CssClass="hidden "></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtTipoSpedizione" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtTipoMerce" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtTipoMezzo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtCliente" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtGruppoTariffarioPartenza" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtPCSPartenza" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtMacroZonaArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtZonaArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtGruppoTariffarioArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="txtPCSArrivo" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                </asp:Panel>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <iwc:IboWebButton ID="btnCopiaTutto" runat="server" Text="Copia tutto" CssClass="DetailFormButton" />
                                    <iwc:IboWebButton ID="btnSvuota" runat="server" Text="Svuota" CssClass="DetailFormButton" />
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
