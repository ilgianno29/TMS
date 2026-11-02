<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFGMBInserimentoMovimenti.aspx.vb" Inherits="Incasbo.Web.GDO.WFGMBInserimentoMovimenti" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link href="../Css/WFGMBInserimentoMovimenti.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c11">
                                <div class="DetailFormTitleDiv">
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c12">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode1" runat="server" Text="Modalità"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c13">
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
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <asp:Panel runat="server" ID="PanelDati" CssClass="PanelDati">
                                        <table class="DetailFormSectionTable2Fixed DetailFormSectionTable2FixedTitle" >
                                            <tr>
                                                <td class="DetailFormDescriptionCell PrimoSoggetto" style="width: 130px">
                                                    <iwc:IboWebLabel ID="lblGenerale" runat="server" IncasTag="" Text="Generale" Font-Bold="true"></iwc:IboWebLabel>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblCausale" runat="server" IncasTag="" Text="Causale Bancale:" Width="90px"> </iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtCausale" runat="server" CharacterCase="Uppercase" Width="120px" ReadOnly="true"></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" Width="300px" ReadOnly="true"></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormDescriptionCell" style="width: 65px">
                                                    <iwc:IboWebLabel ID="lblDataMovimento" runat="server" IncasTag="" Text="Data Mov:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebDate ID="txtDataMovimento" runat="server" CharacterCase="Uppercase" IncasTag="" ControlType="DateOnly" Required="true" >
                                                    </iwc:IboWebDate>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblRiferimento1" runat="server" IncasTag="" Text="Rif. Documento 1:" Width="90px"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtRiferimento1" runat="server" Width="120px" CharacterCase="Uppercase"></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormDescriptionCell" style="width: 50px">
                                                    <iwc:IboWebLabel ID="lblDataRiferimento1" runat="server" IncasTag="" Text="Del:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebDate ID="txtDataRiferimento1" runat="server" ControlType="DateOnly"></iwc:IboWebDate>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblRifeimento2" runat="server" IncasTag="" Text="Rif. Documento 2:" Width="90px"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtRiferimento2" runat="server" Width="120px" CharacterCase="Uppercase"></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormDescriptionCell" style="width: 50px">
                                                    <iwc:IboWebLabel ID="lblDataRiferimento2" runat="server" IncasTag="" Text="Del:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebDate ID="txtDataRiferimento2" runat="server" ControlType="DateOnly"></iwc:IboWebDate>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblBuono" runat="server" IncasTag="" Text="Buono:" Width="90px"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtBuono" runat="server" CharacterCase="Uppercase" Width="120px"></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblNote" runat="server" IncasTag="" Width="90px" Text="Note:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtNote" runat="server" CharacterCase="Uppercase" Width="612px" FieldName="Note"></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblfiller1" runat="server" IncasTag="" Width="90px" Text="Filler1:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 200px">
                                                    <iwc:IboWebTextBox ID="txtFiller1" runat="server" CharacterCase="Uppercase" Width="250px" FieldName="Filler1"></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormDescriptionCell" style="width: 97px">
                                                    <iwc:IboWebLabel ID="lblfiller2" runat="server" IncasTag="" Text="Filler2:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 200px">
                                                    <iwc:IboWebTextBox ID="txtfiller2" runat="server" CharacterCase="Uppercase" Width="250px" FieldName="Filler2"></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                    <iwc:IboWebLabel ID="lblfiller3" runat="server" IncasTag="" Text="Filler3:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 200px">
                                                    <iwc:IboWebTextBox ID="txtfiller3" runat="server" CharacterCase="Uppercase" Width="250px" FieldName="Filler3"></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormDescriptionCell" style="width: 97px">
                                                    <iwc:IboWebLabel ID="lblfiller4" runat="server" IncasTag="" Text="Filler4:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 200px">
                                                    <iwc:IboWebTextBox ID="txtfiller4" runat="server" CharacterCase="Uppercase" Width="250px" FieldName="Filler4"></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                    <iwc:IboWebLabel ID="lblfiller5" runat="server" IncasTag="" Text="Filler5:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 200px">
                                                    <iwc:IboWebTextBox ID="txtfiller5" runat="server" CharacterCase="Uppercase" Width="250px" FieldName="Filler5"></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                            <tr style="height: 10px">
                                                <td></td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="pnlPrimoSoggetto" CssClass="pnlPrimoSoggetto">
                                        <table class="DetailFormSectionTable2Fixed DetailFormSectionTable2FixedTitle">
                                            <tr>
                                                <td class="DetailFormDescriptionCell PrimoSoggetto" style="width: 130px">
                                                    <iwc:IboWebLabel ID="lblPrimoSoggetto" runat="server" IncasTag="" Text="Primo soggetto" Font-Bold="true"></iwc:IboWebLabel>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                    <iwc:IboWebLabel ID="lblTipoPrimoSoggetto" runat="server" IncasTag="" Text="Tipo:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtTipoSoggetto1Descrizione" runat="server" CharacterCase="Uppercase" Width="400px" ReadOnly="true"></iwc:IboWebTextBox>
                                                    <iwc:IboWebTextBox ID="txtTipoSoggetto1" runat="server" Visible="false" ></iwc:IboWebTextBox>
                                                    <iwc:IboWebTextBox ID="txtSegno1" runat="server" Visible="false" ></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 200px"></td>
                                                <td class="DetailFormValueCell" rowspan="2">
                                                    <asp:Image runat="server" ID="imgPlus" ImageUrl="~/images/Toolbar/48/textplusicon.png" CssClass="imgPlus" />
                                                    <asp:Image runat="server" ID="imgMinus" ImageUrl="~/images/Toolbar/48/textminusicon.png" CssClass="imgMinus" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                    <iwc:IboWebLabel ID="lblPrimoSoggetto1" runat="server" IncasTag="" Text="Soggetto:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebComboTlk ID="cmbPrimoSoggetto" runat="server" SqlQuery="SELECT * FROM CBO_GMB_SOGGETTI" Width="408px" AutoLoadOnDemand="true" AutoPostBack="True" Required="true">
                                                    </iwc:IboWebComboTlk>
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr style="height: 10px">
                                                <td></td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="pnlSecondoSoggetto" CssClass="pnlSecondoSoggetto">
                                        <table class="DetailFormSectionTable2Fixed DetailFormSectionTable2FixedTitle">
                                            <tr>
                                                <td class="DetailFormDescriptionCell PrimoSoggetto" style="width: 130px">
                                                    <iwc:IboWebLabel ID="lblSecondoSoggetto" runat="server" IncasTag="" Text="Secondo soggetto" Font-Bold="true"></iwc:IboWebLabel>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                    <iwc:IboWebLabel ID="lblTipoSecondoSoggetto" runat="server" IncasTag="" Text="Tipo:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtTipoSoggetto2Descrizione" runat="server" CharacterCase="Uppercase" Width="400px" ReadOnly="true"></iwc:IboWebTextBox>
                                                    <iwc:IboWebTextBox ID="txtTipoSoggetto2" runat="server" Visible="false" ></iwc:IboWebTextBox>
                                                    <iwc:IboWebTextBox ID="txtSegno2" runat="server" Visible="false" ></iwc:IboWebTextBox>
                                                </td>
                                                <td class="DetailFormValueCell" style="width: 200px"></td>
                                                <td class="DetailFormValueCell" rowspan="2">
                                                    <asp:Image runat="server" ID="imgPlus1" ImageUrl="~/images/Toolbar/48/textplusicon.png" CssClass="imgPlus" />
                                                    <asp:Image runat="server" ID="imgMinus1" ImageUrl="~/images/Toolbar/48/textminusicon.png" CssClass="imgMinus" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="DetailFormDescriptionCell" style="width: 90px">
                                                    <iwc:IboWebLabel ID="lblSecondoSoggetto2" runat="server" IncasTag="" Text="Soggetto:"></iwc:IboWebLabel>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebComboTlk ID="cmbSecondoSoggetto" runat="server" SqlQuery="SELECT * FROM CBO_GMB_SOGGETTI" Width="408px" AutoLoadOnDemand="true" AutoPostBack="True" Required="true">
                                                    </iwc:IboWebComboTlk>
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr style="height: 10px">
                                                <td></td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel runat="server" ID="DettaglioBancali" CssClass="DettaglioBancali">
                                        <table class="DetailFormSectionTable2Fixed">
                                            <tr>
                                                <td class="DetailFormDescriptionCell PrimoSoggetto" style="width: 130px">
                                                    <iwc:IboWebLabel ID="IboWebLabel1" runat="server" IncasTag="" Text="Dettaglio bancali" Font-Bold="true"></iwc:IboWebLabel>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:Panel runat="server" ID="DettaglioBancaliContent" CssClass="DettaglioBancaliContent">
                                            <table class="noBorderTable DettaglioBancaliTable">
                                                <tr class="Intestazione">
                                                    <td style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblDettaglioBancaliCodice" runat="server" Text="Codice"></iwc:IboWebLabel>
                                                    </td>
                                                    <td style="width: auto;">
                                                        <iwc:IboWebLabel ID="lblDettaglioBancaliDescrizione" runat="server" Text="Descrizione"></iwc:IboWebLabel></td>
                                                    <td style="width: 150px;">
                                                        <iwc:IboWebLabel ID="lblDettaglioBancaliQta" runat="server" Text="Quantità"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                                <asp:Repeater runat="server" ID="rpDettaglioBancali">
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td>
                                                                <iwc:IboWebLabel ID="lblTipoBancaleCodice" runat="server" Text='<%# Bind("Codice")%>'></iwc:IboWebLabel></td>
                                                            <td>
                                                                <iwc:IboWebLabel ID="lblTipoBancaleDescrizione" runat="server" Text='<%# Bind("Descrizione")%>'></iwc:IboWebLabel></td>
                                                            <td>
                                                                <iwc:IboWebNumericTlk ID="txtTipoBancaleQta" runat="server" Width="80px" DecimalDigits="0"></iwc:IboWebNumericTlk>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </table>
                                        </asp:Panel>
                                    </asp:Panel>
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
