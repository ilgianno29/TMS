<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFTARTariffeImporti.aspx.vb"
    Inherits="Incasbo.Web.GDO.WFTARTariffeImporti" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../css/WFTarTariffeImporti.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" ClientIDMode="Static">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpEstremi_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpEstremi_Title_Caption" Text="Estremi" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpEstremi_Body" CssClass="CollapsiblePanelBody cpEstremi_Body">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 10px">
                                        </tr>
                                    </table>
                                    <asp:Panel runat="server" ID="pnlDescrizione" Style="padding: 10px; margin-bottom: 20px;">
                                        <iwc:IboWebLabel runat="server" ID="lblDescrizioneAzione1" Text="Questa procedura consente di revisionare gli importi di tutte le tariffe comprese nella selezione."></iwc:IboWebLabel>
                                        <br />
                                        <iwc:IboWebLabel runat="server" ID="lblDescrizioneAzione2" Text=""></iwc:IboWebLabel>
                                    </asp:Panel>
                                    <hr class="WFIHRSeparatore " />
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 10px">
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblTipoVariazione" runat="server" IncasTag="" Text="Tipo Variazione:"></iwc:IboWebLabel>
                                            </td>

                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboDropDownList ID="TipoVariazione" runat="server" CharacterCase="Uppercase" IncasTag="" Required="True"
                                                    SqlQuery="SELECT * FROM CBO_TAR_TIPOVARIAZIONE" Width="200px">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblApplica" runat="server" IncasTag="" Text="Applica:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 10px">
                                                <iwc:IboWebCheckBox ID="Fisso" runat="server" IncasTag="" Checked="false" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left">
                                                <iwc:IboWebLabel ID="lblFisso" runat="server" IncasTag="" Text="Fisso"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 10px">
                                                <iwc:IboWebCheckBox ID="Variabile" runat="server" IncasTag="" Checked="false" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left">
                                                <iwc:IboWebLabel ID="lblVariabile" runat="server" IncasTag="" Text="Variabile"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 10px">
                                                <iwc:IboWebCheckBox ID="Percentuale" runat="server" IncasTag="" Checked="false" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px; text-align: left">
                                                <iwc:IboWebLabel ID="lblPercentuale" runat="server" IncasTag="" Text="Percentuale"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblVariazione" runat="server" IncasTag="" Text="Variazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboDropDownList ID="Variazione" runat="server" CharacterCase="Uppercase" IncasTag="" Required="True"
                                                    SqlQuery="SELECT * FROM CBO_TAR_VARIAZIONE" Width="200px">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblValore" runat="server" IncasTag="" Text="Valore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboWebNumericTlk runat="server" ID="Valore" Required="true" Width="80px" DecimalDigits="3">
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
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
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
