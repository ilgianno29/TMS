<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANABancaliCausali.aspx.vb" Inherits="Incasbo.Web.GDO.WFANABancaliCausali" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link href="../Css/WFAnaBancaliCausali.css" rel="stylesheet" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="800px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Codice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 90px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="80px" Required="True" FieldName="Codice"></iwc:IboWebTextBox>
                                            </td>
                                            <td style="width: 235px"></td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" IncasTag="" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 40px">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" IncasTag="" Checked="True" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblStampaBuonoBancali" runat="server" IncasTag="" Text="Stampa Buono Bancali:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 40px">
                                                <iwc:IboWebCheckBox ID="chkStampaBuonoBancali" runat="server" IncasTag="" Checked="True" Value="N" FieldName="StampaBuonoBancali"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebTextBox ID="txtDescrizione" Required="True" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px" FieldName="Descrizione"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblTipoCausale" runat="server" IncasTag="" Text="Tipo Causale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoCausale" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPOCAUSALE_MOVBANC" Width="250px" Required="true" AutoPostBack="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:Panel runat="server" ID="pnlPrimoSoggetto" CssClass="pnlPrimoSoggetto">
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 100px; text-align: left; font-weight: bold;">
                                                    <iwc:IboWebLabel ID="lblPrimoSoggetto" runat="server" IncasTag="" Text="Primo soggetto"></iwc:IboWebLabel>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 130px">
                                                    <iwc:IboWebLabel ID="lblSegno1" runat="server" IncasTag="" Text="Segno:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebComboTlk ID="cmbSegno1" runat="server" SqlQuery="SELECT * FROM CBO_ANA_SEGNO_MOVBANC" Width="250px" Required="true" AutoPostBack="True">
                                                    </iwc:IboWebComboTlk>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblTipoSoggetto1" runat="server" IncasTag="" Text="Tipo:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebComboTlk ID="cmbTipoSoggetto1" runat="server" SqlQuery="SELECT * FROM CBO_ANA_SOGGETTO_MOVBANC" Width="400px" Required="true">
                                                    </iwc:IboWebComboTlk>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="Vuoto" CssClass="pnlVuoto">
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="pnlSecondoSoggetto" CssClass="pnlSecondoSoggetto">
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 100px; text-align: left; font-weight: bold;">
                                                    <iwc:IboWebLabel ID="IboWebLabel1" runat="server" IncasTag="" Text="Secondo soggetto"></iwc:IboWebLabel>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 130px">
                                                    <iwc:IboWebLabel ID="lblSegno2" runat="server" IncasTag="" Text="Segno:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebComboTlk ID="cmbSegno2" runat="server" SqlQuery="SELECT * FROM CBO_ANA_SEGNO_MOVBANC" Width="250px" >
                                                    </iwc:IboWebComboTlk>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblTipoSoggetto2" runat="server" IncasTag="" Text="Tipo:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebComboTlk ID="cmbTipoSoggetto2" runat="server" SqlQuery="SELECT * FROM CBO_ANA_SOGGETTO_MOVBANC" Width="400px" >
                                                    </iwc:IboWebComboTlk>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <table>
                                        <tr>
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
