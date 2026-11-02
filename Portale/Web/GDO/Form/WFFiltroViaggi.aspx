<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFiltroViaggi.aspx.vb" Inherits="Incasbo.Web.GDO.WFFiltroViaggi" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../css/WFFiltroViaggi.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px" DefaultButton="btnConferma">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="padding-top: 10px; padding-bottom: 10px;">
                                    <table class="DetailFormSectionTable2Fixed" style="margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblIdViaggio" runat="server" Text="Id Viaggio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px">
                                                <iwc:IboWebTextBox runat="server" ID="txtIdViaggio" Width="100px" FieldDescription="Id Viaggio" IncasTag="IdViaggio=<#VALUE#>;Id Viaggio=<#VALUE#>"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblIdViaggioHost" runat="server" Text="Id viaggio Host:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebTextBox runat="server" ID="txtIdViaggioHost" Width="100px" FieldName="IdViaggioHost" FieldDescription ="Id Viaggio Host" IncasTag="IdViaggioHost like '%<#NO_SQL_VALUE#>%';IdViaggioHost simile a '<#NO_SQL_VALUE#>'"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />                                    
                                    <table class="DetailFormSectionTable2Fixed" style="margin-bottom: 5px;margin-top: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDaData" runat="server" IncasTag="" Text="Da Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px;">
                                                <iwc:IboWebDate runat="server" ID="DaDataViaggio" ControlType="DateOnly" FieldDescription="Da Data Viaggio" IncasTag="DATAVIAGGIO>=<#VALUE#>;DATA VIAGGIO>=<#VALUE#>" FieldName="DATAVIAGGIO" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAData" runat="server" IncasTag="" Text="A Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px;">
                                                <iwc:IboWebDate runat="server" ID="ADataViaggio" ControlType="DateOnly" FieldDescription="A Data Viaggio" IncasTag="DATAVIAGGIO<=<#VALUE#>;Data Viaggio<=<#VALUE#>" FieldName="DATAVIAGGIO" />
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
                                                <iwc:IboWebLabel ID="lblVettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 510px">
                                                <iwc:IboWebComboTlk ID="cmbVettore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="500px" AutoLoadOnDemand="true" IncasTag="VETTORE=<#VALUE#>;VETTORE=<#VALUE#>"
                                                    FieldName="VETTORE">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>                                                                        
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 5px; margin-bottom: 5px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPartenza" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 510px">
                                                <iwc:IboWebComboTlk ID="cmbPcsPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza" Width="500px" AutoLoadOnDemand="true" IncasTag="PCSPARTENZA=<#VALUE#>;PARTENZA=<#VALUE#>"
                                                    FieldName="PCSPARTENZA">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblArrivo" runat="server" Text="Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbPcsArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" AutoLoadOnDemand="true" IncasTag="PCSARRIVO=<#VALUE#>;ARRIVO=<#VALUE#>"
                                                    FieldName="PCSARRIVO">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>                                        
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" Text="Zona arrivo passiva:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbZonaArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneTariffaPassiva" Width="500px" AutoLoadOnDemand="true" IncasTag="ZONAARRIVO=<#VALUE#>;ZONA ARRIVO=<#VALUE#>"
                                                    FieldName="ZONAARRIVO">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>                               
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 5px; margin-bottom: 5px;">
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
