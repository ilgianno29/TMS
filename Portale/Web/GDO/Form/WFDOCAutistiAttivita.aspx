<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCAutistiAttivita.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCAutistiAttivita" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1000px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblAutista" runat="server" Text="Autista:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbAutista" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Autisti" Width="350px" SqlQueryOrderBy="RagioneSociale"
                                                    CampoDescrizione="RagioneSociale" AutoLoadOnDemand="true" DropDownWidth="300px" MaxHeight="250px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblTipoAttivita" runat="server" Text="Attivita:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoAttivita" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Autisti_TipiAttivita" Width="350px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="300px" MaxHeight="250px">
                                                </iwc:IboWebComboTlk>
                                            </td>

                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblMotrice" runat="server" Text="Motrice:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbMotrice" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi" Width="350px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="300px" MaxHeight="250px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblIdViaggio" runat="server" Text="Id Viaggio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebTextBox ID="txtIdViaggio" runat="server" CharacterCase="Uppercase" Width="100px" Enabled="false"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblRimorchio1" runat="server" Text="Rimorchio1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbRimorchio1" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi" Width="350px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="300px" MaxHeight="250px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblRimorchio2" runat="server" Text="Rimorchio2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbRimorchio2" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi" Width="350px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="300px" MaxHeight="250px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblContenitore1" runat="server" Text="Contenitore1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbContenitore1" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi" Width="350px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="300px" MaxHeight="250px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblContenitore2" runat="server" Text="Contenitore2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbContenitore2" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Mezzi" Width="350px" SqlQueryOrderBy="Descrizione"
                                                    CampoDescrizione="Descrizione" AutoLoadOnDemand="true" DropDownWidth="300px" MaxHeight="250px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="Panel1" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="Label1" Text="Inizio" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="Panel2" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblDataInizio" runat="server" Text="Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebDate2 ID="txtDataInizio" runat="server" Width="80px" ControlType="DateAndTime" Tooltip="Ora di inizio attività" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblKmInizio" runat="server" Text="Km:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px">
                                                <iwc:IboWebNumericTlk ID="txtKmInizio" runat="server" Width="130px" ToolTip="Km manuali inizio attivita">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblIndirizzoInizio" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzoInizio" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                <iwc:IboWebLabel ID="lblLatitudineInizio" runat="server" Text="Lat:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLatitudineInizio" runat="server" Width="100px" Enabled="false" ToolTip="Latitudine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 80px;"></td>
                                            <td class="DetailFormValueCell" style="width: 620px;">
                                                <iwc:IboWebTextBox ID="txtCapInizio" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalitaInizio" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="494px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazioneInizio" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                <iwc:IboWebLabel ID="lblLongitudineInizio" runat="server" Text="Lon:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLongitudineInizio" runat="server" Width="100px" Enabled="false" ToolTip="Longitudine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="Panel3" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="Label2" Text="Fine" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="Panel4" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblDataFine" runat="server" Text="Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebDate2 ID="txtDataFine" runat="server" Width="80px" ControlType="DateAndTime" Tooltip="Ora di fine attività" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblKmFine" runat="server" Text="Km:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px">
                                                <iwc:IboWebNumericTlk ID="txtKmFine" runat="server" Width="130px" ToolTip="Km manuali fine attivita">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                        </tr>
                                    </table>

                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblIndirizzoFine" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 617px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzoFine" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="612px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                <iwc:IboWebLabel ID="lblLatitudineFine" runat="server" Text="Lat:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLatitudineFine" runat="server" Width="100px" Enabled="false" ToolTip="Latitudine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td style="width: 80px;"></td>
                                            <td class="DetailFormValueCell" style="width: 620px;">
                                                <iwc:IboWebTextBox ID="txtCapFine" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalitaFine" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="494px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazioneFine" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="40px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 79px;">
                                                <iwc:IboWebLabel ID="lblLongitudineFine" runat="server" Text="Lon:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebTextBox ID="txtLongitudineFine" runat="server" Width="100px" Enabled="false" ToolTip="Longitudine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <asp:Button ID="Button1_idle" runat="server" Text="" Style="display: none" />
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
