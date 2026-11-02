<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAVoci.aspx.vb" Inherits="Incasbo.Web.GDO.WFAnaVoci" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../Gdo/css/WFAnaVoci.css" type="text/css" />
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
                                    <iwc:IboWebLabel runat="server" Translate="true" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="line-height: 20px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Codice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 90px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="80px" Required="True" FieldName="Codice"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblViaggio" runat="server" Text="Viaggio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkViaggio" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblSpedizione" runat="server" Text="Spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkSpedizione" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblGiacenza" runat="server" Text="Giacenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkGiacenza" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblContrassegno" runat="server" Text="Contrass:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkContrassegno" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 90px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 610px">
                                                <iwc:IboWebTextBox ID="txtDescrizione" Required="True" runat="server" MaxLength="60" Width="605px" FieldName="Descrizione"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblCodiceIva" runat="server" IncasTag="" Text="Codice Iva:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 610px">
                                                <iwc:IboWebComboTlk ID="cmbCodiceIva" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CodiciIva" Width="500px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblFlagNolo" runat="server" IncasTag="" Text="Flag nolo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px">
                                                <iwc:IboWebCheckBox ID="chkFlagNolo" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblRiconsegna" runat="server" IncasTag="" Text="Riconsegna:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebRadioButtonList ID="optRiconsegna" runat="server" RepeatDirection="Horizontal" Required="True">
                                                    <asp:ListItem Selected="True" Text="Riapplica al 100%" Value="T"></asp:ListItem>
                                                    <asp:ListItem Text="Riapplica con abbattimento" Value="P"></asp:ListItem>
                                                    <asp:ListItem Text="Non riapplicare" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblReso" runat="server" IncasTag="" Text="Reso:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebRadioButtonList ID="optReso" runat="server" RepeatDirection="Horizontal" Required="True">
                                                    <asp:ListItem Selected="True" Text="Riapplica al 100%" Value="T"></asp:ListItem>
                                                    <asp:ListItem Text="Riapplica con abbattimento" Value="P"></asp:ListItem>
                                                    <asp:ListItem Text="Non riapplicare" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblTipoVoce" runat="server" IncasTag="" Text="Tipo voce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebRadioButtonList ID="optTipoVoce" runat="server" RepeatDirection="Horizontal" Required="True">
                                                    <asp:ListItem Selected="True" Text="Addebito" Value="A"></asp:ListItem>
                                                    <asp:ListItem Text="Sconto" Value="S"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblApplicabilita" runat="server" IncasTag="" Text="Applicabilità:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebComboTlk runat="server" ID="cmbApplicabilita" SqlQuery="SELECT * FROM CBO_ANA_VociApplicabilita" Width="500px" AutoLoadOnDemand="True"></iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblContropartita" runat="server" IncasTag="" Text="Contropartita:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtContropartita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="160px"></iwc:IboWebTextBox>
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
