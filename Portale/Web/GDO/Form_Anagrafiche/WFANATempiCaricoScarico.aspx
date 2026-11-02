<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANATempiCaricoScarico.aspx.vb" Inherits="Incasbo.Web.GDO.WFANATempiCaricoScarico" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="800px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 65px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" MaxLength="6" Width="60px" Required="True" ValidationRules="IntegerNumber" FieldDescription="Codice"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 250px">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="50" Width="245px" Required="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 75px">
                                                <iwc:IboWebLabel ID="lblIsDefault" runat="server" Text="IsDefault:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 75px">
                                                <iwc:IboWebCheckBox ID="chkIsDefault" runat="server" IncasTag="IsDefault=S" Checked="True" Value="N" FieldName="IsDefault"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblTempoFisso" runat="server" Text="Tempo fisso:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 65px">
                                                <iwc:IboWebDate2 ID="txtTempoFisso" runat="server" ControlType="TimeOnly" Width="60px" Tooltip="Tempo fisso" FieldDescription="Tempo fisso" Text="00:00:00" Required="true" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblTempoVariabile" runat="server" Text="Tempo variabile:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 65px">
                                                <iwc:IboWebDate2 ID="txtTempoVariabile" runat="server" ControlType="TimeOnly" Width="60px" Tooltip="Tempo che verrà moltiplicato per la quantità" FieldDescription="Tempo fisso" Text="00:00:00" Required="true" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCodiceUDM" runat="server" Text="Unità di misura:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 255px">
                                                <iwc:IboWebComboTlk ID="cmbCodiceUDM" runat="server" SqlQuery="SELECT * FROM CBO_ANA_UnitaDiMisura" Width="250px" ToolTip="L'unità di misura a cui fa riferimento la quantità">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px">
                                                <iwc:IboWebLabel ID="lblQuantita" runat="server" Text="Quantità:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 75px">
                                                <iwc:IboWebNumericTlk ID="txtQuantita" runat="server" Width="70px" ToolTip="Specifica la quantità relativa all'unità di controllo" Value="00" Required="true">
                                                </iwc:IboWebNumericTlk>
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