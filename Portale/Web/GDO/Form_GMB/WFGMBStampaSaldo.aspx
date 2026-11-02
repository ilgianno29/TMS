<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFGMBStampaSaldo.aspx.vb" Inherits="Incasbo.Web.GDO.WFGMBStampaSaldo" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="700px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpInfoGen_Title_Caption" Text="Selezione intervallo di date" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <iwc:IboWebHidden runat="server" ID="MyGuid" FieldName="GUID" IncasTag="{%RPT_VIEW%.GUID}=<#VALUE#>;GUID=<#VALUE#>" />
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDaData" runat="server" IncasTag="" Text="Dalla data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebDate2 runat="server" ID="txtdaData" Width="90px" FieldName="Data" ControlType="DateOnly" FieldDescription="dalla data" Required="true" IncasTag="{%RPT_VIEW%.Data}>=<#VALUE#>;Data>=<#VALUE#>" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblAData" runat="server" IncasTag="" Text="alla data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebDate2 runat="server" ID="txtAData" Width="90px" ControlType="DateOnly" FieldName="Data" FieldDescription="alla data" Required="true" IncasTag="{%RPT_VIEW%.Data}<=<#VALUE#>;Data<=<#VALUE#>" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoSoggetto_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpInfoSoggetto_Title_Caption" Text="Soggetto" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoSoggetto_Body" CssClass="CollapsiblePanelBody">
                                    <asp:UpdatePanel runat="server" ID="up_cpInfoSoggetto_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblTipoSoggetto" runat="server" IncasTag="" Text="Tipo Soggetto"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbTipoSoggetto" runat="server" SqlQuery="SELECT * FROM CBO_ANA_SOGGETTO_MOVBANC" Width="350px" Required="true" AutoPostBack="True" IncasTag="{%RPT_VIEW%.TipoSoggetto}=<#VALUE#>;Tipo Soggetto=<#VALUE#>"
                                                            ShowDropDownOnTextboxClick="true">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblSoggetto" runat="server" IncasTag="" Text="Soggetto:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebComboTlk ID="cmbSoggetto" runat="server" SqlQuery="SELECT * FROM CBO_GMB_SOGGETTI" SqlQueryWhere="1=2" Width="500px" AutoLoadOnDemand="true" Required="true"
                                                            IncasTag="{%RPT_VIEW%.Soggetto}=<#VALUE#>;Soggetto=<#VALUE#>">
                                                        </iwc:IboWebComboTlk>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                            </div>
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpImpostazioni_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpImpostazioni_Title_Caption" Text="Impostazioni" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpImpostazioni_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblDettaglioTipoBancale" runat="server" IncasTag="" Text="Dettaglio per tipo bancale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList runat="server" ID="ccmbRagguppamento" Width="300px">
                                                    <asp:ListItem Value="1" Text="Raggruppa per data"></asp:ListItem>
                                                    <asp:ListItem Value="2" Text="Raggruppa per data e tipo bancale"></asp:ListItem>
                                                    <asp:ListItem Value="3" Text="Nessun raggruppamento" Selected="True"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblStampaSuGriglia" runat="server" IncasTag="" Text="Stampa su griglia:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="StampaSuGriglia" runat="server" Checked="false" Value="N"></iwc:IboWebCheckBox>
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
