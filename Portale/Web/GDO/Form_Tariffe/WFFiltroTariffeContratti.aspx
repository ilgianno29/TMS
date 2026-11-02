<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFiltroTariffeContratti.aspx.vb" Inherits="Incasbo.Web.GDO.WFFiltroTariffeContratti" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="500px" DefaultButton="btnConferma">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td colspan="2"></td>
                                        </tr>
                                        <tr>
                                            <%-- style="width: 180px; padding-top: 20px; padding-bottom: 20px"--%>
                                            <td class="DetailFormDescriptionCell" style="width: 180px;">
                                                <iwc:IboWebLabel ID="lblDaData" runat="server" IncasTag="" Text="Valide il:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebDate2 runat="server" ID="daData" Width="90px" ControlType="DateOnly" FieldDescription="Data validità"
                                                    IncasTag="DATAINIZIOVALIDITA <=<#VALUE#> ;DATA >=<#VALUE#>" FieldName="DATAINIZIOVALIDITA" />
                                            </td>
                                        </tr>
                                        <tr style="height: 10px;">
                                            <td colspan="2"></td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblContrattoAttivoPassivo" runat="server" IncasTag="" Text="Attivo/Passivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="TipoContratto" runat="server" CharacterCase="Uppercase" SqlQuery="SELECT * FROM CBO_DOC_TipoContratto"
                                                    Width="140px" Required="True" Translate="True">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr style="height: 10px;">
                                            <td colspan="2"></td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblContrattoTrasportoGiacenza" runat="server" IncasTag="" Text="Trasporto/Giacenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="ContrattoTrasportoGiacenza" runat="server" Width="140px" CharacterCase="Uppercase" Required="True" Translate="True">
                                                    <asp:ListItem Text="TUTTI" Value="*ALL"></asp:ListItem>
                                                    <asp:ListItem Text="TRASPORTO" Value="T"></asp:ListItem>
                                                    <asp:ListItem Text="GIACENZA" Value="G"></asp:ListItem>                                                    
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr style="height: 20px;">
                                            <td colspan="2"></td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebDate2 runat="server" ID="aData" Width="90px" ControlType="DateOnly" FieldDescription="Data validità" Visible="false"
                                        IncasTag="DATAFINEVALIDITA >=<#VALUE#> ;DATA >=<#VALUE#>" FieldName="DATAFINEVALIDITA" />
                                    <iwc:IboWebTextBox ID="AttivaPassiva" runat="server" IncasTag="ATTIVAPASSIVA =<#VALUE#> ;ATTIVA PASSIVA =<#VALUE#>" Visible="false" FieldName="AttivaPassiva"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="ContrattoTrasporto" runat="server" IncasTag="CONTRATTOTRASPORTO=<#VALUE#> ;TRASPORTO=<#VALUE#>" Visible="false" FieldName="ContrattoTrasporto"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox ID="ContrattoGiacenza" runat="server" IncasTag="CONTRATTOGIACENZA=<#VALUE#> ;GIACENZA=<#VALUE#>" Visible="false" FieldName="ContrattoGiacenza"></iwc:IboWebTextBox>
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
