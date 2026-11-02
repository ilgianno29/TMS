<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCSpedizioni_Wizard.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCSpedizioni_Wizard" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180531" type="text/css" />
    <link href="../Css/WFDOCSpedizioni_Wizard.css" rel="stylesheet" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1000px">
                            <asp:Panel ID="PanelFasiDiv" runat="server" CssClass="WizardContainer">
                                <asp:Panel ID="PanelFasi" runat="server" CssClass="WizardFasi">
                                    <iwc:IboWebLabel runat="server" ID="Label1" Text="Riferimento Spedizione" CssClass="LabelAttivo"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel runat="server" ID="IboWebLabel5" Text="\"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel runat="server" ID="Label2" Text="PCS" CssClass="LabelNonAttivo"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel runat="server" ID="IboWebLabel8" Text="\"></iwc:IboWebLabel>
                                    <%-- <iwc:IboWebLabel runat="server" ID="Label3" Text="Date" CssClass="LabelNonAttivo"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel runat="server" ID="IboWebLabel1" Text="\"></iwc:IboWebLabel>--%>
                                    <iwc:IboWebLabel runat="server" ID="Label4" Text="Quantità" CssClass="LabelNonAttivo"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel runat="server" ID="IboWebLabel9" Text="\"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel runat="server" ID="Label5" Text="Riepilogo" CssClass="LabelNonAttivo"></iwc:IboWebLabel>
                                </asp:Panel>
                            </asp:Panel>
                            <asp:Panel runat="server" ID="cpInserimentoSpedizione_Body" CssClass="" ClientIDMode="Static">
                                <asp:MultiView ID="WizardInserimentoSpedizione" runat="server" ActiveViewIndex="0">
                                    <asp:View ID="WSRiferimentiSpedizione" runat="server">
                                        <asp:UpdatePanel runat="server" ID="up_1" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div>
                                                    <asp:Panel ID="WSRiferimentiSpedizioneContainerDiv" runat="server" CssClass="WizardContainer">
                                                        <asp:Panel ID="WSRiferimentiSpedizioneTitleDiv" runat="server" CssClass="WizardTitle">
                                                            <iwc:IboWebLabel runat="server" ID="WSRiferimentiSpedizioneTitle" Text="Riferimento Spedizione"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:Panel ID="WSRiferimentiSpedizioneBodyDiv" runat="server" CssClass="WizardBody">
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 555px">
                                                                        <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" SqlQueryOrderBy="DESCRIZIONE"
                                                                            Required="True" Width="550px" AutoPostBack="true" SqlQueryWhere="CLIENTEMITTENTE = 'C'" AutoLoadOnDemand ="true">
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 270px">
                                                                        <iwc:IboWebLabel ID="lblAttivazioneAutomatica" runat="server" Text="Attivazione automatica:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 40px">
                                                                        <iwc:IboWebCheckBox ID="chkAttivazioneAutomatica" runat="server" Checked="false" Value="N"></iwc:IboWebCheckBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblMittenteRagioneSociale" runat="server" Text="Mittente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 555px">
                                                                        <iwc:IboWebTextBox ID="txtMittenteRagioneSociale" runat="server" MaxLength="60" Width="550px"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblTipoServizio" runat="server" Text="Tipo Servizio:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 370px">
                                                                        <iwc:IboWebComboTlk ID="cmbTipoServizio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiServizi" SqlQueryWhere="Attivo='S'" Required="True" Width="363px">
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNumeroOrdine" runat="server" Text="Num. Ordine:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 155px">
                                                                        <iwc:IboWebTextBox ID="txtNumeroOrdine" runat="server" MaxLength="30" Width="150px"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                        <iwc:IboWebLabel ID="lblDataOrdine" runat="server" Text="Data Ordine:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataOrdine" ControlType="DateOnly" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNumeroBolla" runat="server" Text="Num. Bolla:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 155px">
                                                                        <iwc:IboWebTextBox ID="txtNumeroBolla" runat="server" MaxLength="30" Width="150px"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 90px">
                                                                        <iwc:IboWebLabel ID="lblDataBolla" runat="server" Text="Data Bolla:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataBolla" ControlType="DateOnly" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 555px">
                                                                        <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ClienteTipiSpedizione"
                                                                            Required="True" Width="550px" AutoPostBack="true" SqlQueryFilter="1=2">
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 555px">
                                                                        <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ClienteTSpedTMerce"
                                                                            Width="550px" SqlQueryFilter="1=2" AutoPostBack="true">
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 555px">
                                                                        <iwc:IboWebTextBox ID="txtNote" runat="server" MaxLength="1000" Width="550px" Rows="4" TextMode="MultiLine" Translate="True"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:View>
                                    <asp:View ID="WSPCS" runat="server">
                                        <asp:UpdatePanel runat="server" ID="up_35" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div>
                                                    <asp:Panel ID="WSPCSContainerDiv" runat="server" CssClass="WizardContainer">
                                                        <asp:Panel ID="WSPCSTitleDiv" runat="server" CssClass="WizardTitle">
                                                            <iwc:IboWebLabel runat="server" ID="WSPCSTitle" Text="PCS"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:Panel ID="WSPCSBodyDiv" runat="server" CssClass="WizardBody">
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebComboTlk ID="cmbPCSPArtenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                                            Required="false" AutoPostBack="True" Width="500px" AutoLoadOnDemand="True" SqlQueryWhere="PUNTODICARICO = 'S'"
                                                                            DropDownWidth="820px" FieldName="PCSPArtenza">
                                                                            <HeaderTemplate>
                                                                                <ul>
                                                                                    <li class="ComboCol" style="width: 80px; display: none;">
                                                                                        <iwc:IboWebLabel runat="server" ID="Col1" Text="Codice"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 250px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="Col2" Text="Ragione Sociale"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col3" Text="Indirizzo"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col4" Text="Localita"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col5" Text="Prov."></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col6" Text="Naz."></iwc:IboWebLabel></li>
                                                                                </ul>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <ul>
                                                                                    <li class="ComboCol" style="width: 80px; display: none;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Codice")%></li>
                                                                                    <li class="ComboCol" style="width: 250px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "RagioneSociale")%></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Indirizzo")%></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Localita")%></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Provincia")%></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Nazione")%></li>
                                                                                </ul>
                                                                            </ItemTemplate>
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSPartenzaZonaSpedizione" runat="server" Text="Zona Sped.:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 210px">
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaZonaSpedizione" runat="server" CharacterCase="Uppercase" Visible="false"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="PCSPartenzaZonaSpedizioneQL" runat="server" CharacterCase="Uppercase" Width="200px"
                                                                            Enabled="False" SqlQueryLookup="SELECT Descrizione FROM Zone WHERE CODICE='<#CONTROLS_RECORD.txtPartenzaZonaSpedizione#>'"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSPartenzaIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="490px" Enabled="False"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSPartenzaZonaTariffaAttiva" runat="server" Text="Zona Attiva:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 210px">
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaZonaTariffaAttiva" runat="server" CharacterCase="Uppercase" Visible="false"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="PCSPartenzaZonaTariffaAttivaQL" runat="server" CharacterCase="Uppercase" Width="200px"
                                                                            Enabled="False" SqlQueryLookup="SELECT Descrizione FROM Zone WHERE CODICE='<#CONTROLS_RECORD.txtPCSPartenzaZonaTariffaAttiva#>'"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px"></td>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="65px" Enabled="False"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="320px" Enabled="False"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaProvincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" Enabled="False"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="39px" Enabled="False"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSPartenzaZonaTariffaPassiva" runat="server" Text="Zona Passiva.:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 210px">
                                                                        <iwc:IboWebTextBox ID="txtPCSPartenzaZonaTariffaPassiva" runat="server" CharacterCase="Uppercase" Visible="false"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="PCSPartenzaZonaTariffaPassivaQL" runat="server" CharacterCase="Uppercase" Width="200px"
                                                                            Enabled="False" SqlQueryLookup="SELECT Descrizione FROM Zone WHERE CODICE='<#CONTROLS_RECORD.txtPCSPartenzaZonaTariffaPassiva#>'"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSDestinazione" runat="server" Text="Destinazione:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <%--<td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebComboTlk ID="cmbPCSDestinazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                                            Required="True" Width="500px" SqlQueryWhere="PUNTODIDESTINO = 'S'" AutoLoadOnDemand="true" AutoPostBack="true">
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>--%>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebComboTlk ID="cmbPCSDestinazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                                            Required="True" AutoPostBack="True" Width="500px" AutoLoadOnDemand="True" SqlQueryWhere="PUNTODIDESTINO = 'S'"
                                                                            DropDownWidth="820px" FieldName="PCSDestinazione">
                                                                            <HeaderTemplate>
                                                                                <ul>
                                                                                    <li class="ComboCol" style="width: 80px; display: none;">
                                                                                        <iwc:IboWebLabel runat="server" ID="Col1" Text="Codice"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 250px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="Col2" Text="Ragione Sociale"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col3" Text="Indirizzo"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col4" Text="Localita"></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col5" Text="Prov."></iwc:IboWebLabel></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <iwc:IboWebLabel runat="server" ID="col6" Text="Naz."></iwc:IboWebLabel></li>
                                                                                </ul>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <ul>
                                                                                    <li class="ComboCol" style="width: 80px; display: none;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Codice")%></li>
                                                                                    <li class="ComboCol" style="width: 250px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "RagioneSociale")%></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Indirizzo")%></li>
                                                                                    <li class="ComboCol" style="width: 200px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Localita")%></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Provincia")%></li>
                                                                                    <li class="ComboCol" style="width: 50px;">
                                                                                        <%# DataBinder.Eval(Container.DataItem, "Nazione")%></li>
                                                                                </ul>
                                                                            </ItemTemplate>
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSDestinazioneZonaSpedizione" runat="server" Text="Zona Sped.:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 210px">
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneZonaSpedizione" runat="server" CharacterCase="Uppercase" Visible="false"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="PCSDestinazioneZonaSpedizioneQL" runat="server" CharacterCase="Uppercase" Width="200px"
                                                                            Enabled="False" SqlQueryLookup="SELECT Descrizione FROM Zone WHERE CODICE='<#CONTROLS_RECORD.txtPCSDestinazioneZonaSpedizione#>'"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSDestinazioneIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="490px" Enabled="False"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSDestinazioneZonaTariffaAttiva" runat="server" Text="Zona Attiva:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 210px">
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneZonaTariffaAttiva" runat="server" CharacterCase="Uppercase" Visible="false"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="PCSDestinazioneZonaTariffaAttivaQL" runat="server" CharacterCase="Uppercase" Width="200px"
                                                                            Enabled="False" SqlQueryLookup="SELECT Descrizione FROM Zone WHERE CODICE='<#CONTROLS_RECORD.txtPCSDestinazioneZonaTariffaAttiva#>'"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px"></td>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="65px" Enabled="False"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="320px" Enabled="False"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneProvincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px" Enabled="False"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="39px" Enabled="False"></iwc:IboWebTextBox>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSDestinazioneZonaTariffaPassiva" runat="server" Text="Zona Passiva:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 210px">
                                                                        <iwc:IboWebTextBox ID="txtPCSDestinazioneZonaTariffaPassiva" runat="server" CharacterCase="Uppercase" Visible="false"></iwc:IboWebTextBox>
                                                                        <iwc:IboWebTextBox ID="PCSDestinazioneZonaTariffaPassivaQL" runat="server" CharacterCase="Uppercase" Width="200px" Enabled="False" SqlQueryLookup="SELECT Descrizione FROM Zone WHERE CODICE='<#CONTROLS_RECORD.txtPCSDestinazioneZonaTariffaPassiva#>'"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataRitiroPrevista1" runat="server" Text="Data Ritiro da:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataRitiroPrevista1" ControlType="DateOnly" />
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataRitiroPrevista2" runat="server" Text="Data Ritiro a:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataRitiroPrevista2" ControlType="DateOnly" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNoteRitiroPrevisto" runat="server" Text="Note Ritiro:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebTextBox ID="txtNoteRitiroPrevisto" runat="server" CharacterCase="Uppercase" MaxLength="225" Rows="3" TextMode="MultiLine"
                                                                            Width="500px"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataConsegnaPrevista1" runat="server" Text="Data Consegna da:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataConsegnaPrevista1" ControlType="DateOnly" />
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataConsegnaPrevista2" runat="server" Text="Data Consegna a:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 120px">
                                                                        <iwc:IboWebDate2 runat="server" ID="txtDataConsegnaPrevista2" ControlType="DateOnly" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNoteConsegnaPrevista" runat="server" Text="Note Consegna:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell" style="width: 500px">
                                                                        <iwc:IboWebTextBox ID="txtNoteConsegnaPrevista" runat="server" CharacterCase="Uppercase" MaxLength="225" Rows="3" TextMode="MultiLine"
                                                                            Width="500px"></iwc:IboWebTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCell">
                                                                        <iwc:IboWebComboTlk ID="cmbCorrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CORRISPONDENTI" Width="500px">
                                                                        </iwc:IboWebComboTlk>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:View>
                                    <asp:View ID="WSSpedizioneQuantita" runat="server">
                                        <asp:UpdatePanel runat="server" ID="up_5" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div>
                                                    <asp:Panel ID="WSSpedizioneQuantitaContainerDiv" runat="server" CssClass="WizardContainer">
                                                        <asp:Panel ID="WSSpedizioneQuantitaDiv" runat="server" CssClass="WizardTitle">
                                                            <iwc:IboWebLabel runat="server" ID="WSSpedizioneQuantitaTitle" Text="Quantità"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:Panel ID="WSSpedizioneQuantitaBodyDiv" runat="server" CssClass="WizardBody">
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td style="width: 100px;"></td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 200px; text-align: left; font: bold;">
                                                                        <iwc:IboWebLabel ID="lblTipoQuantita" runat="server" Text="Tipo"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px; text-align: right; font: bold;">
                                                                        <iwc:IboWebLabel ID="lblQuantita" runat="server" Text="Quantità"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                                <tr style="height: 10px;">
                                                                    <td colspan="3"></td>
                                                                </tr>
                                                                <asp:Repeater ID="RepeaterSpedizioneQuantita" runat="server">
                                                                    <ItemTemplate>
                                                                        <tr>
                                                                            <td style="width: 100px;"></td>
                                                                            <td class="DetailFormValueCell" style="width: 200px; text-align: left;">
                                                                                <iwc:IboWebTextBox ID="TipoQuantitaCodice" runat="server" Text="" CssClass="hidden" CharacterCase="None"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebLabel ID="TipoQuantitaDescrizione" runat="server" Text=""
                                                                                    Width="200px" CssClass="TipoImballoDescrizione"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebNumericTlk runat="server" ID="Quantita" Width="100px" Value="0" CssClass="TipoImballoQuantita" Required="true">
                                                                                </iwc:IboWebNumericTlk>
                                                                                <iwc:IboWebTextBox ID="TipologiaDato" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </ItemTemplate>
                                                                </asp:Repeater>
                                                            </table>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:View>
                                    <asp:View ID="WSRiepilogoSpedizione" runat="server">
                                        <asp:UpdatePanel runat="server" ID="up_6" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div>
                                                    <asp:Panel ID="WSRiepilogoSpedizioneContainerDiv" runat="server" CssClass="WizardContainer">
                                                        <asp:Panel ID="WSRiepilogoSpedizioneTitleDiv" runat="server" CssClass="WizardTitle">
                                                            <iwc:IboWebLabel runat="server" ID="WSRiepilogoSpedizioneTitle" Text="Riepilogo"></iwc:IboWebLabel>
                                                        </asp:Panel>
                                                        <asp:Panel ID="WSRiepilogoSpedizioneBodyDiv" runat="server" CssClass="WizardBody WSRiepilogoSpedizioneBodyDiv">
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lbClienteRiepilogo" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 530px">
                                                                        <iwc:IboWebLabel ID="lblClienteRiepilogoValue" runat="server" Text=""
                                                                            Translate="false">
                                                                        </iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell">
                                                                        <iwc:IboWebLabel ID="lblMittenteRiepilogo" runat="server" Text="Mittente:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblMittenteRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblTipoServizioRiepilogo" runat="server" Text="Tipo:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 200px">
                                                                        <iwc:IboWebLabel ID="lblTipoServizioRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNumeroOrdineRiepilogo" runat="server" Text="Num. Ordine:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNumeroOrdineRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                        <iwc:IboWebLabel ID="lblDataOrdineRiepilogo" runat="server" Text="Data Ordine:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 90px">
                                                                        <iwc:IboWebLabel ID="lblDataOrdineRiepilogoValue" runat="server" Text="" Translate="false" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                        <iwc:IboWebLabel ID="lblNumeroBollaRiepilogo" runat="server" Text="Num. Bolla:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNumeroBollaRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                        <iwc:IboWebLabel ID="lblDataBollaRiepilogo" runat="server" Text="Data Bolla:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 90px">
                                                                        <iwc:IboWebLabel ID="lblDataBollaRiepilogoValue" runat="server" Text="" Translate="false" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblTipoSpedizioneRiepilogo" runat="server" Text="Tipo Sped.:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 530px">
                                                                        <iwc:IboWebLabel ID="lblTipoSpedizioneRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell">
                                                                        <iwc:IboWebLabel ID="lblTipoMerceRiepilogo" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblTipoMerceRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblNoteRiepilogo" runat="server" Text="Note:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblNoteRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <hr />
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblPCSPartenzaRiepilogo" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 530px">
                                                                        <iwc:IboWebLabel ID="lblPCSPartenzaRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell">
                                                                        <iwc:IboWebLabel ID="lblPCSDestinazioneRiepilogo" runat="server" Text="Destinazione:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblPCSDestinazioneRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataRitiroPrevista1Riepilogo" runat="server" Text="Data Ritiro da:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                        <iwc:IboWebLabel ID="lblDataRitiroPrevista1RiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataRitiroPrevista2Riepilogo" runat="server" Text="Data Ritiro a:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblDataRitiroPrevista2RiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataConsegnaPrevista1Riepilogo" runat="server" Text="Data Cons. da:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 120px">
                                                                        <iwc:IboWebLabel ID="lblDataConsegnaPrevista1RiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                        <iwc:IboWebLabel ID="lblDataConsegnaPrevista2Riepilogo" runat="server" Text="Data Cons. a:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblDataConsegnaPrevista2RiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <hr />
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: top;">
                                                                        <iwc:IboWebLabel ID="lblTipiImballoRiepilogo" runat="server" Text="Quantità:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblTipiImballoRiepilogoValue" runat="server" Text="" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <hr />
                                                            <table class="DetailFormSectionTable2Fixed">
                                                                <tr>
                                                                    <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: top;">
                                                                        <iwc:IboWebLabel ID="lblAttivazioneAutomaticaRiepilogo" runat="server" Text="Attivazione auto:"></iwc:IboWebLabel>
                                                                    </td>
                                                                    <td class="DetailFormValueCellNoDataBounded">
                                                                        <iwc:IboWebLabel ID="lblAttivazioneAutomaticaRiepilogoValue" runat="server" Translate="false"></iwc:IboWebLabel>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:View>
                                </asp:MultiView>
                            </asp:Panel>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C"></td>
                                <td id="tableButtons_R" class="tableButtons_R" style="width: auto">
                                    <iwc:IboWebButton ID="btnIndietro" runat="server" Text="Indietro" CssClass="hidden" />
                                    &nbsp;<iwc:IboWebButton ID="btnAvanti" runat="server" Text="Avanti" CssClass="WizardForward" />
                                    &nbsp;<iwc:IboWebButton ID="btnConferma" runat="server" Text="Conferma" CssClass="hidden" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
