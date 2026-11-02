<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFCSTVoci_CentriCosto.aspx.vb" Inherits="Incasbo.Web.GDO.Custom.WFCSTVoci_CentriCosto" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm.css" type="text/css" />
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
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" Required="True" SqlQuery="SELECT * FROM CBO_ANA_TipiSpedizione" Width="600px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" Required="True" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce" Width="600px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" IncasTag="" Text="PCS Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbPCSPartenza" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                    Required="true" Width="600px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" SqlQueryWhere="PUNTODICARICO = 'S'" DropDownWidth="600px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" IncasTag="" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbPCSArrivo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_PCS"
                                                    Required="true" Width="600px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    AutoLoadOnDemand="true" SqlQueryWhere="PUNTODIDESTINO = 'S'" DropDownWidth="600px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblVoce" runat="server" IncasTag="" Text="Voce:" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbVoce" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_VOCI" Required="true"
                                                    Width="600px" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE" AutoLoadOnDemand="FALSE">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCentroDiCosto" runat="server" IncasTag="" Text="Centro Di Costo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk ID="cmbCentroDiCosto" runat="server" SqlQuery="SELECT * FROM CST_CBO_CentriDiCosto"
                                                    Required="true" Width="600px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblVoceDiCosto" runat="server" IncasTag="" Text="Classe Coge:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtClasseCoge" runat="server" CharacterCase="Uppercase" MaxLength="50" Width="590px" Required="True"></iwc:IboWebTextBox>
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
