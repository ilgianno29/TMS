<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFiltroSpedizioni.aspx.vb" Inherits="Incasbo.Web.GDO.WFFiltroSpedizioni" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../css/WFFiltroSpedizioni.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="770px" DefaultButton="btnConferma">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="padding-top: 10px; padding-bottom: 10px;">
                                    <table class="DetailFormSectionTable2Fixed" style="margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblUnibol" runat="server" Text="Id spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebTextBox runat="server" ID="txtUnibol" Width="100px" CampoDescrizione="Id spedizione" IncasTag="UNIBOL=<#VALUE#>;Id spedizione=<#VALUE#>"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoServizio" runat="server" Text="Tipo Servizio:" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebComboTlk ID="cmbTipoServizio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiServizi" Width="190px" FieldDescription="Tipo servizio" IncasTag="TipoServizio=<#VALUE#>;Tipo servizio=<#VALUE#>"
                                                    FieldName="TipoServizio" DropDownWidth="300px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px">
                                                <iwc:IboWebLabel ID="lblStato" runat="server" Text="Stato:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 160px">
                                                <iwc:IboDropDownList ID="cmbStato" runat="server" SqlQuery="SELECT * FROM CBO_DOC_Spedizioni_Stato" SqlQueryWhere="Codice>=30 AND Codice<90" IncasTag="Stato=<#VALUE#>;Stato=<#VALUE#>" 
                                                    Width="150px" FieldName="Stato">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNumeroBolla" runat="server" Text="Numero DDT:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebTextBox runat="server" ID="txtNumeroBolla" Width="100px" FieldName="NumeroBolla" CampoDescrizione="Numero DDT" IncasTag="NumeroBolla like '%<#NO_SQL_VALUE#>%';Numero DDT simile a '<#NO_SQL_VALUE#>'"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed" style="margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDaData" runat="server" IncasTag="" Text="Da Data DDT:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebDate runat="server" ID="DaDataDDT" ControlType="DateOnly" FieldDescription="Da Data DDT" IncasTag="DATABOLLA>=<#VALUE#>;DATA DDT>=<#VALUE#>" FieldName="DATABOLLA" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAData" runat="server" IncasTag="" Text="A Data DDT:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px;">
                                                <iwc:IboWebDate runat="server" ID="ADataDDT" ControlType="DateOnly" FieldDescription="A Data DDT" IncasTag="DATABOLLA<=<#VALUE#>;DATA DDT<=<#VALUE#>" FieldName="DATABOLLA" />
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNumeroOrdine" runat="server" Text="Numero Ordine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebTextBox runat="server" ID="txtNumeroOrdine" Width="100px" FieldName="NumeroOrdine" CampoDescrizione="Numero Ordine" IncasTag="NumeroOrdine like '%<#NO_SQL_VALUE#>%';Numero Ordine simile a '<#NO_SQL_VALUE#>'"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed" style="margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDaDataOrdine" runat="server" IncasTag="" Text="Da Data Ordine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px;">
                                                <iwc:IboWebDate runat="server" ID="txtDaDataOrdine" ControlType="DateOnly" FieldDescription="Da Data Ordine"
                                                    IncasTag="DATAORDINE>=<#VALUE#>;DATA ORDINE>=<#VALUE#>" FieldName="DATAORDINE" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblaDataOrdine" runat="server" IncasTag="" Text="A Data Ordine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px;">
                                                <iwc:IboWebDate runat="server" ID="txtaDataOrdine" ControlType="DateOnly" FieldDescription="A Data Ordine"
                                                    IncasTag="DATAORDINE<=<#VALUE#>;DATA ORDINE<=<#VALUE#>" FieldName="DATAORDINE" />
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 5px; margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 510px">
                                                <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" Width="500px" AutoLoadOnDemand="true" IncasTag="CLIENTE=<#VALUE#>;CLIENTE=<#VALUE#>"
                                                    FieldName="CLIENTE">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 510px">
                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiSpedizione" Width="500px" AutoLoadOnDemand="true" IncasTag="TIPOSPEDIZIONE=<#VALUE#>;TIPO SPEDIZIONE=<#VALUE#>"
                                                    FieldName="TIPOSPEDIZIONE">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 5px; margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPartenza" runat="server" Text="Deposito partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 510px">
                                                <iwc:IboWebComboTlk ID="cmbPcsPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza" Width="500px" AutoLoadOnDemand="true" IncasTag="PCSPARTENZA=<#VALUE#>;DEP.PARTENZA=<#VALUE#>"
                                                    FieldName="PCSPARTENZA">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPcsDestinazione" runat="server" Text="Destinazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbPcsDestinazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" AutoLoadOnDemand="true" IncasTag="PCSDESTINAZIONE=<#VALUE#>;DESTINAZIONE=<#VALUE#>"
                                                    FieldName="PCSDESTINAZIONE" DropDownWidth="820px" SqlQueryWhere="PUNTODIDESTINO = 'S'">
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
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblProvincia" runat="server" Text="Provincia:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbProvincia" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Province" Width="300px" AutoLoadOnDemand="true" IncasTag="PCSDESTINAZIONE_PROVINCIA=<#VALUE#>;PROVINCIA=<#VALUE#>"
                                                    FieldName="PCSDESTINAZIONE_PROVINCIA">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 5px; margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 510px">
                                                <iwc:IboWebComboTlk ID="cmbCorrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Corrispondenti" Width="500px" AutoLoadOnDemand="true" IncasTag="CORRISPONDENTE=<#VALUE#>;CORRISPONDENTE=<#VALUE#>"
                                                    FieldName="CORRISPONDENTE">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblIdViaggio" runat="server" Text="Id Viaggio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 510px">
                                                <iwc:IboWebTextBox runat="server" ID="txtIdViaggio" Width="100px" CampoDescrizione="Id Viaggio" IncasTag="IdViaggio=<#VALUE#>;Id Viaggio=<#VALUE#>"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title"
                                    Collapsed="False" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="false" ExpandControlID="cpInfoGen_Title" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image" TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <iwc:IboWebButton ID="btnSvuotaFiltro" runat="server" Text="Svuota filtro" CssClass="DetailFormButton_SvuotaFiltro" /></td>
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
