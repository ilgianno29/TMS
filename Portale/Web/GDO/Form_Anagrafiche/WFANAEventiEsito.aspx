<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANAEventiEsito.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAEventiEsito" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <style type="text/css">
        .DetailFormSectionTable2Fixed tr {
            height: 25px !important;
        }

        select.cmbGeneraRiconsegna option, select.cmbCreaGiacenza option, select.cmbCreaContestazione option {
            font-size: 12pt;
            background-color: #ffffff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
                <td>
                    <table class="DetailFormHeaderTable">
                        <tr class="DetailFormHeaderTable_r1">
                            <td class="DetailFormHeaderTable_c1">
                                <div class="DetailFormTitleDiv">
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
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text="Titolo Form" IncasTag="" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Codice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 485px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="120px" Required="True"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 605px">
                                                <iwc:IboWebTextBox ID="txtDescrizione" Required="True" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <asp:UpdatePanel runat="server" ID="up_BuonFine" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <tr style="height: 20px;">
                                                    <td class="DetailFormDescriptionCell" style="width: 120px">
                                                        <iwc:IboWebLabel ID="lblBuonFine" runat="server" Text="Buon Fine:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboDropDownList runat="server" ID="cmbBuonFine" Width="100px" AutoPostBack="true">
                                                            <asp:ListItem Text="Si" Value="S" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                            <asp:ListItem Text="Parziale" Value="P"></asp:ListItem>
                                                        </iwc:IboDropDownList>
                                                    </td>
                                                    <iwc:IboWebHidden runat="server" ID="hdnTipoEvento" FieldName="TipoEvento" />
                                                    <td class="DetailFormDescriptionCell" style="width: 150px">
                                                        <iwc:IboWebLabel ID="lblTentativoEffettuato" runat="server" Text="Tentativo effettuato:" Visible="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebCheckBox ID="chkTentativoEffettuato" runat="server" Checked="True" Value="S" Visible="false"></iwc:IboWebCheckBox>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px">
                                                        <iwc:IboWebLabel ID="lblAnnullamento" runat="server" Text="Annullamento:" Visible="false"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCell">
                                                        <iwc:IboWebCheckBox ID="chkAnnullamento" runat="server" Checked="False" Value="N" Visible="false"></iwc:IboWebCheckBox>
                                                    </td>
                                                </tr>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </table>                                    
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblGeneraRiconsegna" runat="server" Text="Genera Riconsegna:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList runat="server" ID="cmbGeneraRiconsegna" Width="250px" CssClass="cmbGeneraRiconsegna">
                                                    <asp:ListItem Text="Si - Automatica all'esito" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="Si - Manuale" Value="M"></asp:ListItem>
                                                    <asp:ListItem Text="No - Nessuna riconsegna" Value="N" Selected="True"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblCreaGiacenza" runat="server" Text="Crea Giacenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="padding-top: 4px;">
                                                <iwc:IboDropDownList runat="server" ID="cmbCreaGiacenza" Width="250px" CssClass="cmbCreaGiacenza">
                                                    <asp:ListItem Text="Si - Automatica all'esito" Value="A"></asp:ListItem>
                                                    <asp:ListItem Text="Si - Manuale" Value="S"></asp:ListItem>
                                                    <asp:ListItem Selected="True" Text="No - Nessuna giacenza" Value="N"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblCreaContestazione" runat="server" Text="Crea Contestazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="padding-top: 4px;">
                                                <iwc:IboDropDownList runat="server" ID="cmbCreaContestazione" Width="250px" CssClass="cmbCreaContestazione">
                                                    <asp:ListItem Text="Si - Automatica all'esito" Value="S"></asp:ListItem>
                                                    <asp:ListItem Selected="True" Text="No - Nessun automatismo all'esito" Value="N"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblAddebitaRicavi" runat="server" Text="Addebita Ricavi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optAddebitaRicavi" runat="server" RepeatDirection="Horizontal" Required="True">
                                                    <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>

                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblAccreditaCosti" runat="server" Text="Accredita Costi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optAccreditaCosti" runat="server" RepeatDirection="Horizontal" Required="True">
                                                    <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblVisibile" runat="server" Text="Visibile:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="padding-top: 4px;">
                                                <iwc:IboWebRadioButtonList ID="optVisibile" runat="server" RepeatDirection="Horizontal" Required="True">
                                                    <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr style="height: 20px;">
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblEventoDefault" runat="server" Text="Default:" ToolTip="Imposta l'evento corrente come default per il tipo evento corrispondente"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="padding-top: 4px;">
                                                <iwc:IboWebRadioButtonList ID="EventoDefault" runat="server" RepeatDirection="Horizontal" Required="True">
                                                    <asp:ListItem Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="N" Selected="True"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
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
