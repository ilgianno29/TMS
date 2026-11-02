<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFCFGUtenti_UtentiFiliali.aspx.vb" Inherits="Incasbo.Web.CFG.WFCFGUtenti_UtentiFiliali" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <link rel="stylesheet" href="../Css/WFUtenti.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpInfoGen_Title_Caption" Text="Utente" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblUtenteCaption" runat="server" IncasTag="" Text="Utente:" FocusedBackColor=""
                                                    ValidationRules="None"></iwc:IboWebLabel>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" colspan="3">
                                                <iwc:IboWebLabel ID="lblUtenteValue" runat="server" IncasTag="" Translate="False" FocusedBackColor=""
                                                    ValidationRules="None" ></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblGruppoCaption" runat="server" IncasTag="" Text="Gruppo:" FocusedBackColor=""
                                                    ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" colspan="3">
                                                <iwc:IboWebLabel ID="lblGruppoValue" runat="server" IncasTag="" Translate="False" FocusedBackColor=""
                                                    ValidationRules="None" ></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblOrganizzazioneCaption" runat="server" IncasTag="" Text="Organizzazione:" FocusedBackColor=""
                                                    ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" colspan="3">
                                                <iwc:IboWebLabel ID="lblOrganizzazioneValue" runat="server" IncasTag="" Translate="False" FocusedBackColor=""
                                                    ValidationRules="None" ></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                         <tr style="height:20px;">
                                            <td colspan="4">
                                              
                                            </td>                                           
                                        </tr>
                                        <tr >
                                            <td class="FilialeCaption" colspan="4">
                                               <%-- <iwc:IboWebLabel ID="lblTestata" runat="server" IncasTag="" Text="Filiale"></iwc:IboWebLabel>--%>
                                                <asp:Label runat="server" ID="Label1" Text="Filiale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                            </td>                                           
                                        </tr>
                                        <tr style="height:5px;">
                                            <td colspan="4">
                                              
                                            </td>                                           
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFiliale" runat="server" IncasTag="" Text="Filiale:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbFiliale" runat="server" SqlQuery="SELECT * FROM CBO_WFI_FILIALI" Width="500px"
                                                    Culture="it-IT" CharacterCase="Uppercase" Required="true" AutoLoadOnDemand="false">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblIsDefault" runat="server" IncasTag="" Text="Default:" FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkIsDefault" runat="server" IncasTag="IsDefault=S;IsDefault_Where=Utente%eq%<%Utente%>"
                                                    Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>                                      
                                    </table>
                                    <iwc:IboWebTextBox ID="txtUtente" runat="server" CssClass="hidden"></iwc:IboWebTextBox>
                                </asp:Panel>
                                <ajaxtoolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title"
                                    Collapsed="False" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="True" ExpandControlID="cpInfoGen_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image" TargetControlID="cpInfoGen_Body">
                                </ajaxtoolkit:CollapsiblePanelExtender>
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
