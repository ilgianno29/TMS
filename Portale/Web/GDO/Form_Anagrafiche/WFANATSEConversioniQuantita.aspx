<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANATSEConversioniQuantita.aspx.vb" Inherits="Incasbo.Web.GDO.WFANATSEConversioniQuantita" %>

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
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 505px">
                                                <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Clienti" SqlQueryOrderBy="DESCRIZIONE"
                                                    Required="True" Width="500px" SqlQueryWhere="CLIENTEMITTENTE = 'C'">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo Merce:" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 505px">
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiMerce"
                                                    Width="500px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblUnitaMisura" runat="server" Text="Unita Misura:" IncasTag=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 505px">
                                                <iwc:IboWebComboTlk ID="cmbUnitaMisura" runat="server" SqlQuery="SELECT * FROM CBO_ANA_UnitaDiMisura"
                                                    Width="500px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCoefficienteKG" runat="server" IncasTag="" Text="Coeff.KG"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 110px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtCoefficienteKG" Required="True" Width="100px">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblCoefficienteMC" runat="server" IncasTag="" Text="Coeff.MC"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 110px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtCoefficienteMC" Required="True" Width="100px">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblCoefficienteLT" runat="server" IncasTag="" Text="Coeff.LT"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 110px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtCoefficienteLT" Required="True" Width="100px">
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
