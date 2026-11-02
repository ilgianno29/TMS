<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCCreaSubSpedizioni.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCCreaSubSpedizioni" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <style type="text/css">
    </style>
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
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Translate="True" Text="Titolo Form" IncasTag=""></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Translate="True" Text="Modalità"></iwc:IboWebLabel>
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
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpTestata_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpTestata_Title_Caption" Text="Estremi della Spedizione" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpTestata_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblUnibol" runat="server" IncasTag="" Text="Id spedizione:"></iwc:IboWebLabel>
                                                <iwc:IboWebHidden ID="HF_TipoServizio" FieldName="TipoServizio" runat="server"></iwc:IboWebHidden>
                                                <iwc:IboWebHidden ID="HF_Corrispondente" FieldName="Corrispondente" runat="server"></iwc:IboWebHidden>
                                                <iwc:IboWebHidden runat="server" ID="HFCountOfSubSpedizioni" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblUnibolValue" runat="server" Translate="false" FieldName="unibol"></iwc:IboWebLabel>
                                            </td>

                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNumeroBollaCaption" runat="server" IncasTag="" Text="DDT:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblNumeroBollaValue" runat="server" Translate="false" FieldName="NumeroBolla"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataBollaCaption" runat="server" Text="Data DDT:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblDataBollaValue" runat="server" Translate="false" FieldName="DataBolla" FormatString="{0:dd/MM/yyyy}" FieldDataType="Date"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNumeroOrdineCaption" runat="server" IncasTag="" Text="Ordine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblNumeroOrdineValue" runat="server" Translate="false" FieldName="NumeroOrdine"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataOrdineCaption" runat="server" Text="Data Ordine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblDataOrdineValue" runat="server" Translate="false" FieldName="DataOrdine" FormatString="{0:dd/MM/yyyy}" FieldDataType="Date"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataConsegnaCaption" runat="server" Text="Data Consegna:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px">
                                                <iwc:IboWebHidden ID="HFDataConsegnaPrevista2" runat="server" Translate="false" FieldName="DataConsegnaPrevista2" FormatString="{0:dd/MM/yyyy}" FieldDataType="Date">
                                                </iwc:IboWebHidden>
                                                <iwc:IboWebHidden ID="HFDataConsegnaConcordata" runat="server" Translate="false" FieldName="DataConsegnaConcordata" FormatString="{0:dd/MM/yyyy}" FieldDataType="Date">
                                                </iwc:IboWebHidden>
                                                <iwc:IboWebLabel ID="lblDataConsegnaValue" runat="server" Translate="false"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" IncasTag="" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblClienteValue" runat="server" Translate="false" FieldName="Cliente"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel1" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblClienteRagioneSociale" runat="server" Translate="false" SqlQueryLookup="SELECT RagioneSociale FROM Clienti WHERE CODICE='<#CONTROLS_RECORD.lblClienteValue#>'"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 350px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizioneValue" runat="server" Translate="false" FieldName="TipoSpedizione" Visible="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblTipoSpedizioneDescrizione" runat="server" Translate="false" SqlQueryLookup="SELECT Descrizione FROM TipiSpedizione WHERE CODICE='<#CONTROLS_RECORD.lblTipoSpedizioneValue#>'"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 400px">
                                                <iwc:IboWebLabel ID="lblTipoMerceValue" runat="server" Translate="false" FieldName="TipoMerce" Visible="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblTipoMerceDescrizione" runat="server" Translate="false" SqlQueryLookup="SELECT Descrizione FROM TipiMerce WHERE CODICE='<#CONTROLS_RECORD.lblTipoMerceValue#>'"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPartenza" runat="server" IncasTag="" Text="Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 350px; max-width: 350px; overflow: hidden;">
                                                <iwc:IboWebLabel ID="lblPartenzaValue" runat="server" Translate="false" FieldName="PCSPartenza" Visible="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblPartenzaRagioneSociale" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblPartenzaValue#>'"
                                                    SqlQueryLookupField="RagioneSociale"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel16" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblPartenzaLocalita" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblPartenzaValue#>'"
                                                    SqlQueryLookupField="Localita"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel18" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblPartenzaProvincia" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblPartenzaValue#>'"
                                                    SqlQueryLookupField="Provincia"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel20" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblPartenzaNazione" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblPartenzaValue#>'"
                                                    SqlQueryLookupField="Nazione"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblDestinazione" runat="server" IncasTag="" Text="Destinazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 400px; max-width: 400px; overflow: hidden;">
                                                <iwc:IboWebLabel ID="lblDestinazioneValue" runat="server" Translate="false" FieldName="PCSDestinazione" Visible="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblPCSDestinazione_RagSoc" runat="server" Translate="false" FieldName="PCSDestinazione_RagSoc"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel6" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblPCSDestinazione_Localita" runat="server" Translate="false" FieldName="PCSDestinazione_Localita"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel10" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblPCSDestinazione_Provincia" runat="server" Translate="false" FieldName="PCSDestinazione_Provincia"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel11" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblPCSDestinazione_Nazione" runat="server" Translate="false" FieldName="PCSDestinazione_Nazione"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCorrispondente" runat="server" IncasTag="" Text="Corrispondente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 270px">
                                                <iwc:IboWebLabel ID="lblCorrispondenteValue" runat="server" Translate="false" FieldName="Corrispondente" Visible="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblCorrispondenteRagioneSociale" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblCorrispondenteValue#>'"
                                                    SqlQueryLookupField="RagioneSociale"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel2" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblCorrispondenteLocalita" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblCorrispondenteValue#>'"
                                                    SqlQueryLookupField="Localita"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel3" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblCorrispondenteProvincia" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblCorrispondenteValue#>'"
                                                    SqlQueryLookupField="Provincia"></iwc:IboWebLabel>
                                                &nbsp<iwc:IboWebLabel ID="IboWebLabel4" runat="server" Translate="false" Text="-"></iwc:IboWebLabel>&nbsp
                                                <iwc:IboWebLabel ID="lblCorrispondenteNazione" runat="server" Translate="false" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblCorrispondenteValue#>'"
                                                    SqlQueryLookupField="Nazione"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpGenerazioneTratte_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpGenerazioneTratte_Title_Caption" Text="Sub-spedizioni" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpGenerazioneTratte_Body" CssClass="CollapsiblePanelBody" Style="min-height: 100px;">
                                    <asp:Panel runat="server" ID="pnlNumeroSubSpedizioni">
                                        <table class="DetailFormSectionTable2Fixed ">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 350px">
                                                    <iwc:IboWebLabel ID="lblVoce" runat="server" IncasTag="" Text="Numero di Sub-spedizioni:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <asp:UpdatePanel runat="server" ID="up_NumeroSubSpedizioni" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                        <ContentTemplate>
                                                            <asp:DropDownList runat="server" ID="NumeroSubSpedizioni" Width="70px" AutoPostBack="True">
                                                                <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                                <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                                                <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                                                <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                                            </asp:DropDownList>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <hr class="WFIHRSeparatore" />
                                    <asp:UpdatePanel runat="server" ID="up_rp_Tratte" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:Repeater runat="server" ID="rp_Tratte">
                                                <ItemTemplate>
                                                    <asp:UpdatePanel runat="server" ID="up_rp_Tratta" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                                        <ContentTemplate>
                                                            <div class="WFIFrameContainer">
                                                                <div class="WFIFrameTitle">
                                                                    <iwc:IboWebLabel runat="server" ID="TrattaTitle" Text="Prima tratta"></iwc:IboWebLabel>
                                                                </div>
                                                                <div class="WFIFrameBody">
                                                                    <table class="DetailFormSectionTable2Fixed ">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebLabel ID="rp_TipoServizio_Caption" runat="server" IncasTag="" Text="Tipo servizio:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 370px">
                                                                                <iwc:IboWebComboTlk ID="rp_TipoServizio_value" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiServizi WHERE Attivo='S'" Width="365px">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                <iwc:IboWebLabel ID="rp_DataConsegna_Caption" runat="server" Text="Data cons:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 150px">
                                                                                <iwc:IboWebDate2 runat="server" ID="rp_DataConsegna_value" ControlType="DateOnly" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed ">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebLabel ID="rp_Partenza_Caption" runat="server" IncasTag="" Text="Partenza:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 370px">
                                                                                <iwc:IboWebTextBox ID="rp_Partenza_Value_ReadOnly" runat="server" Translate="false" Visible="false" Width="360px" ReadOnly="true"></iwc:IboWebTextBox>
                                                                            </td>
                                                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                                                <iwc:IboWebLabel ID="rp_Arrivo_Caption" runat="server" IncasTag="" Text="Arrivo:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 370px">
                                                                                <iwc:IboWebTextBox ID="rp_Arrivo_Value_ReadOnly" runat="server" Visible="false" Width="360px" ReadOnly="true"></iwc:IboWebTextBox>
                                                                                <iwc:IboWebComboTlk ID="rp_Arrivo_Value" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" AutoPostBack="True" Width="360px" AutoLoadOnDemand="True" SqlQueryWhere="PUNTODICARICO = 'S' AND PUNTODIDESTINO = 'S'"
                                                                                    DropDownWidth="820px" Visible="false" OnSelectedIndexChanged="rp_Arrivo_Value_SelectedIndexChanged">
                                                                                    <HeaderTemplate>
                                                                                        <ul>
                                                                                            <li class="ComboCol" style="width: 70px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="Col1" Text="Codice"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 245px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="Col2" Text="Ragione Sociale"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 190px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col3" Text="Indirizzo"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 180px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col4" Text="Localita"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 30px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col5" Text="Pr"></iwc:IboWebLabel></li>
                                                                                            <li class="ComboCol" style="width: 30px;">
                                                                                                <iwc:IboWebLabel runat="server" ID="col6" Text="Naz"></iwc:IboWebLabel></li>
                                                                                        </ul>
                                                                                    </HeaderTemplate>
                                                                                    <ItemTemplate>
                                                                                        <ul>
                                                                                            <li class="ComboCol" style="width: 70px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Codice")%></li>
                                                                                            <li class="ComboCol" style="width: 245px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "RagioneSociale")%></li>
                                                                                            <li class="ComboCol" style="width: 190px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Indirizzo")%></li>
                                                                                            <li class="ComboCol" style="width: 180px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Localita")%></li>
                                                                                            <li class="ComboCol" style="width: 30px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Provincia")%></li>
                                                                                            <li class="ComboCol" style="width: 30px;">
                                                                                                <%# DataBinder.Eval(Container.DataItem, "Nazione")%></li>
                                                                                        </ul>
                                                                                    </ItemTemplate>
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <table class="DetailFormSectionTable2Fixed ">
                                                                        <tr>
                                                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                                                <iwc:IboWebLabel ID="rp_Corrispondente_Caption" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                                                                            </td>
                                                                            <td class="DetailFormValueCell" style="width: 370px">
                                                                                <iwc:IboWebComboTlk ID="rp_Corrispondente_value" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CORRISPONDENTI" SqlQueryWhere="ATTIVO='S'" Width="365px" AutoLoadOnDemand="True"
                                                                                    Visible="false">
                                                                                </iwc:IboWebComboTlk>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </div>
                                                            </div>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </ItemTemplate>
                                            </asp:Repeater>
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
