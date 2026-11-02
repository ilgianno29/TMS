<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFiltroTariffe.aspx.vb" Inherits="Incasbo.Web.GDO.WFFiltroTariffe" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="700px" DefaultButton="btnConferma">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDaData" runat="server" Text="Valide il:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebDate2 runat="server" ID="daData" Width="90px" ControlType="DateOnly" FieldDescription="Data validità"
                                                    IncasTag="DATAINIZIOVALIDITA <=<#VALUE#> ;DATA >=<#VALUE#>" FieldName="DATAINIZIOVALIDITA" Required="true" />
                                                <iwc:IboWebDate2 runat="server" ID="aData" Width="90px" ControlType="DateOnly" FieldDescription="Data validità" Visible="false"
                                                    IncasTag="DATAFINEVALIDITA >=<#VALUE#> ;DATA >=<#VALUE#>" FieldName="DATAFINEVALIDITA" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="500px" FieldDescription="Trasportatore"
                                                    AutoLoadOnDemand="true" IncasTag="TRASPORTATORE =<#VALUE#> ;TRASPORTATORE =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase1" />--%>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblClienteTestata" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbClienteTestata" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" Width="500px" FieldName="ClienteTestata" FieldDescription="Cliente"
                                                    AutoLoadOnDemand="true" IncasTag="CLIENTETESTATA =<#VALUE#> ;CLIENTE =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase2" />--%>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoDocumento" runat="server" Text="Tipo Documento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoDocumento" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TARIFFETIPIDOCUMENTO" Width="500px" FieldDescription="Tipo Documento"
                                                    AutoLoadOnDemand="true" IncasTag="TIPODOCUMENTO =<#VALUE#> ;TIPODOCUMENTO =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase3" />--%>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE" Width="500px" FieldDescription="Tipo Spedizione"
                                                    AutoLoadOnDemand="true" IncasTag="TIPOSPEDIZIONE =<#VALUE#> ;TIPOSPEDIZIONE =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase4" />--%>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Width="500px" Translate="True" FieldDescription="Tipo Merce"
                                                    AutoLoadOnDemand="true" IncasTag="TIPOMERCE =<#VALUE#> ;TIPOMERCE =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase5" />--%>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoMezzo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMEZZO" Width="500px" FieldDescription="Tipo Mezzo"
                                                    AutoLoadOnDemand="true" IncasTag="TIPOMEZZO =<#VALUE#> ;TIPOMEZZO =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase6" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 450px">
                                                <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" Width="500px" FieldDescription="Cliente"
                                                    AutoLoadOnDemand="true" IncasTag="CLIENTE =<#VALUE#> ;CLIENTE =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase7" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioPartenza" runat="server" Text="Gruppo Tar. Par.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbGruppoTariffarioPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI" Width="500px" FieldDescription="Gruppo Tar. Par."
                                                    AutoLoadOnDemand="true" IncasTag="GRUPPOTARIFFARIOPARTENZA =<#VALUE#> ;GRUPPOTARIFFARIOPARTENZA =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase8" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="PCS Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbPCSPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" FieldDescription="PCS Partenza"
                                                    SqlQueryWhere="PUNTODICARICO = 'S'" AutoLoadOnDemand="true" IncasTag="PCSPARTENZA =<#VALUE#> ;PCSPARTENZA =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase9" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblMacroZonaArrivo" runat="server" Text="Macro Zona Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbMacroZonaArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneMacro" Width="500px"
                                                    AutoLoadOnDemand="true" IncasTag="MACROZONAARRIVO =<#VALUE#> ;MACROZONAARRIVO =<#VALUE#>" FieldDescription="Macro Zona Arrivo">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase10" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblZonaArrivo" runat="server" Text="Zona Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbZonaArrivo" runat="server" Width="500px" IncasTag="ZONAARRIVO =<#VALUE#> ;ZONAARRIVO =<#VALUE#>"
                                                    AutoLoadOnDemand="true" FieldDescription="Zona Arrivo">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase11" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppoTariffarioArrivo" runat="server" Text="Gruppo Tar. Arr.:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbGruppoTariffarioArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS_GRUPPITARIFFARI" Width="500px" FieldDescription="Gruppo Tar. Arr."
                                                    AutoLoadOnDemand="true" IncasTag="GRUPPOTARIFFARIOARRIVO =<#VALUE#> ;GRUPPOTARIFFARIOARRIVO =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase12" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbPCSArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" FieldDescription="PCS Arrivo"
                                                    SqlQueryWhere="PUNTODIDESTINO = 'S'" AutoLoadOnDemand="true" IncasTag="PCSARRIVO =<#VALUE#> ;PCSARRIVO =<#VALUE#>">
                                                </iwc:IboWebComboTlk>
                                                <%--<iwc:IboWebHidden runat="server" ID="ServeAltrimentiLaLabelSuccessivaDiventaUpperCase13" />--%>
                                            </td>
                                        </tr>
                                    </table>
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
