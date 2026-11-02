<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFiltroStampaAutistaAssenze.aspx.vb" Inherits="Incasbo.Web.GDO.WFFiltroStampaAutistaAssenze" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="600px" DefaultButton="btnConferma">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblAutista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebComboTlk ID="cmbAutista" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Autisti" Width="400px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" IncasTag="{%RPT_VIEW%.AUTISTA}=<#VALUE#>; AUTISTA=<#VALUE#>"
                                                    Required="true" FieldDescription="Autista">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed" style="margin-bottom: 10px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblDaData" runat="server" Text="Da Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebDate runat="server" ID="txtDaData" Width="90px" ControlType="DateOnly" FieldDescription="Da Data"
                                                    IncasTag="{%RPT_VIEW%.DATA}>=<#VALUE#>; DATA >=<#VALUE#>" Required="true" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblAData" runat="server" Text="A Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebDate runat="server" ID="txtAData" Width="90px" ControlType="DateOnly" FieldDescription="A Data"
                                                    IncasTag="{%RPT_VIEW%.DATA}<=<#VALUE#>; DATA <=<#VALUE#>" Required="true" />
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
