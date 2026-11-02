<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAPCSOrariVisita.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAPCSOrariVisita" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link href="../../WFI/Css/jquery.multiselect.css" rel="stylesheet" />
    <script src="../../WFI/scripts/jquery.multiselect.js"></script>
    <script type="text/javascript">
        function WFIpageLoad() {
            $('select#GiorniValidita1,select#GiorniValidita2,select#GiorniValidita3,select#GiorniValidita4,select#GiorniValidita5').multiselect({
                width: '193px',
                cssClass: "giorniValidita",
                selectAll: true,
                updatePlaceholderText: "Val"
            });
        }
    </script>
    <style type="text/css">
        .giorniValidita.ms-options-wrap > button:focus, .ms-options-wrap > button {
            font-size: 12px;
        }

        .ms-options-wrap.giorniValidita {
            font-size: 11px;
        }
    </style>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="height: 300px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoCaption" runat="server" Text="Codice Soggetto:"></iwc:IboWebLabel>
                                                <asp:HiddenField runat="server" ID="TipoSoggetto" Value="" />
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 150px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoValue" runat="server" Translate="False" FieldName="PCS"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoCaption" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoValue" runat="server" Translate="False" SqlQueryLookup="SELECT * FROM PCS WHERE CODICE='<#CONTROLS_RECORD.lblCodiceSoggettoValue#>'" SqlQueryLookupField="RagioneSociale"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce" Width="600px"
                                                    AutoLoadOnDemand="true" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTempoCaricoScarico" runat="server" Text="Tempo Car\Scar:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbTempoCaricoScarico" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TempiCaricoScarico" Width="600px"
                                                    AutoLoadOnDemand="true" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblOrarioVisita1" runat="server" Text="Orario Visita1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px">
                                                <iwc:IboWebComboTlk ID="cmbOrarioVisita1" runat="server" SqlQuery="SELECT * FROM CBO_ANA_OrariVisita" Width="300px"
                                                    AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGiorniValidita1" runat="server" Text="GG. Validita1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 186px">
                                                <iwc:IboWebTextBox ID="txtGiorniValidita1" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="186px" Visible="false">
                                                </iwc:IboWebTextBox>
                                                <asp:ListBox ID="GiorniValidita1" runat="server" SelectionMode="Multiple" Rows="1" Width="186px" ClientIDMode="Static">
                                                    <asp:ListItem Value="1">Lunedì</asp:ListItem>
                                                    <asp:ListItem Value="2">Martedì</asp:ListItem>
                                                    <asp:ListItem Value="3">Mercoledì</asp:ListItem>
                                                    <asp:ListItem Value="4">Giovedì</asp:ListItem>
                                                    <asp:ListItem Value="5">Venerdì</asp:ListItem>
                                                    <asp:ListItem Value="6">Sabato</asp:ListItem>
                                                    <asp:ListItem Value="7">Domenica</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblOrarioVisita2" runat="server" Text="Orario Visita2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px">
                                                <iwc:IboWebComboTlk ID="cmbOrarioVisita2" runat="server" SqlQuery="SELECT * FROM CBO_ANA_OrariVisita" Width="300px"
                                                    AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGiorniValidita2" runat="server" Text="GG. Validita2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 186px">
                                                <iwc:IboWebTextBox ID="txtGiorniValidita2" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="186px" Visible="false">
                                                </iwc:IboWebTextBox>
                                                <asp:ListBox ID="GiorniValidita2" runat="server" SelectionMode="Multiple" Rows="1" Width="186px" ClientIDMode="Static">
                                                    <asp:ListItem Value="1">Lunedì</asp:ListItem>
                                                    <asp:ListItem Value="2">Martedì</asp:ListItem>
                                                    <asp:ListItem Value="3">Mercoledì</asp:ListItem>
                                                    <asp:ListItem Value="4">Giovedì</asp:ListItem>
                                                    <asp:ListItem Value="5">Venerdì</asp:ListItem>
                                                    <asp:ListItem Value="6">Sabato</asp:ListItem>
                                                    <asp:ListItem Value="7">Domenica</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblOrarioVisita3" runat="server" Text="Orario Visita3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px">
                                                <iwc:IboWebComboTlk ID="cmbOrarioVisita3" runat="server" SqlQuery="SELECT * FROM CBO_ANA_OrariVisita" Width="300px"
                                                    AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGiorniValidita3" runat="server" Text="GG. Validita3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 186px">
                                                <iwc:IboWebTextBox ID="txtGiorniValidita3" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="186px" Visible="false">
                                                </iwc:IboWebTextBox>
                                                <asp:ListBox ID="GiorniValidita3" runat="server" SelectionMode="Multiple" Rows="1" Width="186px" ClientIDMode="Static">
                                                    <asp:ListItem Value="1">Lunedì</asp:ListItem>
                                                    <asp:ListItem Value="2">Martedì</asp:ListItem>
                                                    <asp:ListItem Value="3">Mercoledì</asp:ListItem>
                                                    <asp:ListItem Value="4">Giovedì</asp:ListItem>
                                                    <asp:ListItem Value="5">Venerdì</asp:ListItem>
                                                    <asp:ListItem Value="6">Sabato</asp:ListItem>
                                                    <asp:ListItem Value="7">Domenica</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblOrarioVisita4" runat="server" Text="Orario Visita4:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px">
                                                <iwc:IboWebComboTlk ID="cmbOrarioVisita4" runat="server" SqlQuery="SELECT * FROM CBO_ANA_OrariVisita" Width="300px"
                                                    AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGiorniValidita4" runat="server" Text="GG. Validita4:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 186px">
                                                <iwc:IboWebTextBox ID="txtGiorniValidita4" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="186px" Visible="false">
                                                </iwc:IboWebTextBox>
                                                <asp:ListBox ID="GiorniValidita4" runat="server" SelectionMode="Multiple" Rows="1" Width="186px" ClientIDMode="Static">
                                                    <asp:ListItem Value="1">Lunedì</asp:ListItem>
                                                    <asp:ListItem Value="2">Martedì</asp:ListItem>
                                                    <asp:ListItem Value="3">Mercoledì</asp:ListItem>
                                                    <asp:ListItem Value="4">Giovedì</asp:ListItem>
                                                    <asp:ListItem Value="5">Venerdì</asp:ListItem>
                                                    <asp:ListItem Value="6">Sabato</asp:ListItem>
                                                    <asp:ListItem Value="7">Domenica</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblOrarioVisita5" runat="server" Text="Orario Visita5:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px">
                                                <iwc:IboWebComboTlk ID="cmbOrarioVisita5" runat="server" SqlQuery="SELECT * FROM CBO_ANA_OrariVisita" Width="300px"
                                                    AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGiorniValidita5" runat="server" Text="GG. Validita5:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 186px">
                                                <iwc:IboWebTextBox ID="txtGiorniValidita5" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="186px" Visible="false">
                                                </iwc:IboWebTextBox>
                                                <asp:ListBox ID="GiorniValidita5" runat="server" SelectionMode="Multiple" Rows="1" Width="186px" ClientIDMode="Static">
                                                    <asp:ListItem Value="1">Lunedì</asp:ListItem>
                                                    <asp:ListItem Value="2">Martedì</asp:ListItem>
                                                    <asp:ListItem Value="3">Mercoledì</asp:ListItem>
                                                    <asp:ListItem Value="4">Giovedì</asp:ListItem>
                                                    <asp:ListItem Value="5">Venerdì</asp:ListItem>
                                                    <asp:ListItem Value="6">Sabato</asp:ListItem>
                                                    <asp:ListItem Value="7">Domenica</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
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
