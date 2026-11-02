<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFSMLFiltroSessione.aspx.vb" Inherits="Incasbo.Web.GDO.WFSMLFiltroSessione" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../Css/WFSMLFiltroSessione.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <%-- <tr>
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
            </tr>--%>
            <tr>
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpByQuery_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpByQuery_Title_Caption" Text="Filtro Genera Sessione" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="pnlInfo" CssClass="CollapsiblePanelBody" ClientIDMode="Static">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblData" runat="server" Text="Data della sessione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px;">
                                                <iwc:IboWebDate2 ID="Data" runat="server" Width="90px" ControlType="DateOnly" TimeControlWidth="80px" Required="true" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 470px;">
                                                <iwc:IboWebLabel ID="lblDispDaOra" runat="server" Text="Disp. da:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 70px;">
                                                <iwc:IboWebDate2 ID="DispDaOra" runat="server" Width="90px" ControlType="TimeOnly" TimeControlWidth="55px" FormatoOra="HH:mm" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblDispaOra" runat="server" Text="Disp. a:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebDate2 ID="DispaOra" runat="server" Width="90px" ControlType="TimeOnly" TimeControlWidth="55px" FormatoOra="HH:mm" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 555px;">
                                                <iwc:IboWebTextBox ID="Descrizione" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="500px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpByQuery_Body" CssClass="CollapsiblePanelBody" Style="overflow: auto;">
                                    <asp:UpdatePanel ID="up_pnlSimulazione" ChildrenAsTriggers="true" UpdateMode="Conditional" runat="server">
                                        <ContentTemplate>
                                            <asp:Panel runat="server" ID="pnlSimulazione" ClientIDMode="Static">
                                                <asp:Panel runat="server" ID="pnlElencoGiri" ClientIDMode="Static">
                                                    <iwc:IboWebLabel runat="server" ID="lblElencoGiri" Text="Elenco Giri Selezionati"></iwc:IboWebLabel><br />
                                                    <asp:ListBox runat="server" ID="ElencoGiri" ClientIDMode="Static" SelectionMode="Multiple"></asp:ListBox>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlComandiGiri" ClientIDMode="Static">
                                                    <iwc:IboWebButton runat="server" ID="btnAggiungiGiri" Text="Aggiungi" ClientIDMode="Static" /><br />
                                                    <iwc:IboWebButton runat="server" ID="btnTogliGiri" Text="Elimina" ClientIDMode="Static" />
                                                    <br />
                                                    <iwc:IboWebButton runat="server" ID="btnSvuotaGiri" Text="Svuota" ClientIDMode="Static" />
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlElencoPCS" ClientIDMode="Static">
                                                    <iwc:IboWebLabel runat="server" ID="lblElencoPCS" Text="Elenco PCS Selezionati"></iwc:IboWebLabel><br />
                                                    <asp:ListBox runat="server" ID="ElencoPCS" ClientIDMode="Static" SelectionMode="Multiple"></asp:ListBox>
                                                </asp:Panel>
                                                <asp:Panel runat="server" ID="pnlComandiPCS" ClientIDMode="Static">
                                                    <iwc:IboWebButton runat="server" ID="btnAggiungiPCS" Text="Aggiungi" ClientIDMode="Static" /><br />
                                                    <iwc:IboWebButton runat="server" ID="btnTogliPCS" Text="Elimina" ClientIDMode="Static" />
                                                    <br />
                                                    <iwc:IboWebButton runat="server" ID="btnSvuotaPCS" Text="Svuota" ClientIDMode="Static" />
                                                </asp:Panel>
                                            </asp:Panel>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                                    <iwc:IboWebButton ID="btnConferma" runat="server" Text="Crea Sessione" CssClass="DetailFormButton_Ok" ClientIDMode="Static" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
<asp:Content ID="MasterPopupFormContent" ContentPlaceHolderID="phMasterPopupForm" runat="server">
    <asp:Panel ID="pnlFiltro" runat="server" Visible="false" Style="width: 650px; height: 200px;">
        <table class="DetailFormSectionTable2Fixed">
            <tr class="LineaVuota">
                <td style="width: 200px"></td>
            </tr>
        </table>
        <table class="DetailFormSectionTable2Fixed">
            <tr>
                <td class="DetailFormDescriptionCell" style="width: 120px;">
                    <iwc:IboWebLabel ID="lblTipoViaggio" runat="server" Text="Tipo Viaggio:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="cmbTipoViaggio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_VIAGGI_TIPIVIAGGIO" Width="400px" DropDownWidth="400px">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblMacrozona" runat="server" Text="Macro Zona:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="cmbMacrozona" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZoneMacro" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblZonaSpedizione" runat="server" Text="Zona Spedizione:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="cmbZonaSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_ZONESPEDIZIONE" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblTipoMezzo" runat="server" Text="Tipo Mezzo:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="cmbTipoMezzo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMEZZO" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblDepositoPartenza" runat="server" Text="Dep. Partenza:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="cmbDepositoPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIPARTENZA" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
            <tr>
                <td class="DetailFormDescriptionCell">
                    <iwc:IboWebLabel ID="lblDepositoArrivo" runat="server" Text="Dep. Arrivo:"></iwc:IboWebLabel>
                </td>
                <td class="DetailFormValueCell">
                    <iwc:IboWebComboTlk ID="cmbDepositoArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PUNTIARRIVO" Width="400px" DropDownWidth="500px" AutoLoadOnDemand="true"
                        MaxHeight="300">
                    </iwc:IboWebComboTlk>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
