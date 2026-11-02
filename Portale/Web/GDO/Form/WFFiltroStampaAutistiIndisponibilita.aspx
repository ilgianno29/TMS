<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFFiltroStampaAutistiIndisponibilita.aspx.vb" Inherits="Incasbo.Web.GDO.WFFiltroStampaAutistiIndisponibilita" %>

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
                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                <iwc:IboWebLabel ID="lblMese" runat="server" Text="Mese:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 105px">
                                                <iwc:IboDropDownList runat="server" ID="cmbMese" Width="100px" Required="true" IncasTag="{%RPT_VIEW%.Mese}=<#VALUE#>;Mese=<#VALUE#>" FieldDataType="Number">
                                                    <asp:ListItem Text="Gennaio" Value="1"></asp:ListItem>
                                                    <asp:ListItem Text="Febbraio" Value="2"></asp:ListItem>
                                                    <asp:ListItem Text="Marzo" Value="3"></asp:ListItem>
                                                    <asp:ListItem Text="Aprile" Value="4"></asp:ListItem>
                                                    <asp:ListItem Text="Maggio" Value="5"></asp:ListItem>
                                                    <asp:ListItem Text="Giugno" Value="6"></asp:ListItem>
                                                    <asp:ListItem Text="Luglio" Value="7"></asp:ListItem>
                                                    <asp:ListItem Text="Agosto" Value="8"></asp:ListItem>
                                                    <asp:ListItem Text="Settembre" Value="9"></asp:ListItem>
                                                    <asp:ListItem Text="Ottobre" Value="10"></asp:ListItem>
                                                    <asp:ListItem Text="Novembre" Value="11"></asp:ListItem>
                                                    <asp:ListItem Text="Dicembre" Value="12"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                <iwc:IboWebLabel ID="lblAnno" runat="server" Text="Anno:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 45px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtAnno" Required="true" MaxValue="2030" Width="40px" DecimalDigits="0" IncasTag="{%RPT_VIEW%.Anno}=<#VALUE#>;Anno=<#VALUE#>">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 110px">
                                                <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 355px">
                                                <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="405px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" SqlQueryFilter="CODICE <> '*ALL'" IncasTag="{%RPT_VIEW%.Trasportatore}=<#VALUE#>;Trasportatore=<#VALUE#>">
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
