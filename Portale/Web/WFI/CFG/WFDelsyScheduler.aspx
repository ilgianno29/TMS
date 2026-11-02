<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDelsyScheduler.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFDelsyScheduler" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../WFI/css/WFCFGDelsyScheduler.css" type="text/css" />
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
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text=""></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server" Text=""></iwc:IboWebLabel>
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
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="padding: 7px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebHidden runat="server" ID="txtProgressivo" IncasTag="IsIdentity=S" />
                                                <iwc:IboWebLabel ID="lblIstanza" runat="server" Text="Istanza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtIstanza" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="140px" Required="True"
                                                    FieldName="Istanza"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 175px">
                                                <iwc:IboWebLabel ID="lblSecondiDedicati" runat="server" Text="Max SecondiDedicati:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumericTlk runat="server" ID="SecondiDedicati" MaxValue="999999999" Width="100px" DecimalDigits="0">
                                                </iwc:IboWebNumericTlk>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 150px" runat="server" id="td_lblAttivo">
                                                <asp:Image runat="server" ID="imgAttenzione" ImageUrl="~/WFI/Images/Exclamation-mark-icon.png" ImageAlign="AbsMiddle" />
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" runat="server" id="td_chkAttivo">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="True" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblApplicazioneDesc" runat="server" Text="Applicazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebLabel ID="lblApplicazione" FieldName="Applicazione" runat="server" Text="Applicazione:"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblTask" runat="server" Text="Task:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTask" runat="server" SqlQuery="SELECT * FROM CBO_WFI_DELSYTASKS" Width="610px" AutoLoadOnDemand="true" Required="true" AutoPostBack="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:" FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="600px" FieldName="Descrizione"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblArgomenti" runat="server" Text="Argomenti:" FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtArgomenti" runat="server" MaxLength="255" Width="600px" FieldName="Argomenti"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpScheduler_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpScheduler_Title_Caption" Text="Schedulazione" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpScheduler_Body" CssClass="CollapsiblePanelBody" Style="padding: 7px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblSchedulazioneTipo" runat="server" Text="Tipo Schedulazione:" FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="SchedulazioneTipo" runat="server" SqlQuery="SELECT * FROM CBO_WFI_TIPOSCHEDULAZIONE"
                                                    Width="300px" AutoLoadOnDemand="true" Required="true" AutoPostBack="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 192px">
                                                <iwc:IboWebLabel ID="lblSchedulazioneArgomento" runat="server" Text="" Visible="false"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumericTlk runat="server" ID="Tempo" MaxValue="999999999" Width="100px" DecimalDigits="0" Visible="false">
                                                </iwc:IboWebNumericTlk>
                                                <iwc:IboDropDownList ID="GiorniSettimana" runat="server" SqlQuery="SELECT * FROM CBO_WFI_GIORNISETTIMANA" Width="107px"
                                                    Visible="false" AutoPostBack="true" FieldDescription="Giorno della Settimana">
                                                </iwc:IboDropDownList>
                                                <iwc:IboWebTextBox ID="PrimoUltimo" runat="server" CharacterCase="Uppercase" Text="" Visible="false"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">

                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="IboWebLabel1" runat="server" Text="" Display="false" ></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblInizioData" runat="server" Text="Dalla Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebDate runat="server" ID="InizioData" Width="80px" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 180px">
                                                <iwc:IboWebLabel ID="lblFineData" runat="server" Text="Alla Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebDate runat="server" ID="FineData" Width="80px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblInizioOra" runat="server" Text="Dalle Ore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebDate runat="server" ID="InizioOra" Width="80px" ControlType="TimeOnly" />
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFineOra" runat="server" Text="Alle Ore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebDate runat="server" ID="FineOra" Width="80px" ControlType="TimeOnly" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfEsec_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfEsec_Title_Caption" Text="Informazioni di esecuzione" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfEsec_Body" CssClass="CollapsiblePanelBody" Style="height: 50px; padding: 7px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblUltimaEsecuzioneInizioDesc2" runat="server" Text="Ultima Esecuzione Inizio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 160px">
                                                <iwc:IboWebLabel ID="lblUltimaEsecuzioneInizio" runat="server" FieldName="UltimaEsecuzioneInizio"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblNumeroEsecuzioniDesc" runat="server" Text="Numero Esecuzioni:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblNumeroEsecuzioni" runat="server" FieldName="NumeroEsecuzioni"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblUltimaEsecuzioneFineDesc" runat="server" Text="Ultima Esecuzione Fine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 160px">
                                                <iwc:IboWebLabel ID="lblUltimaEsecuzioneFine" FieldName="UltimaEsecuzioneFine" runat="server"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 140px">
                                                <iwc:IboWebLabel ID="lblNumeroErroriDesc" runat="server" Text="Numero Errori:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblNumeroErrori" runat="server" FieldName="NumeroErrori"></iwc:IboWebLabel>
                                            </td>
                                            <td>
                                                <iwc:IboWebButton ID="btnReset" runat="server" Text="Reset" CssClass="DetailFormButton" />
                                            </td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox runat="server" ID="txtInizioData" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox runat="server" ID="txtFineData" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox runat="server" ID="txtInizioOra" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox runat="server" ID="txtFineOra" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox runat="server" ID="txtSchedulazioneTipo" Required="true" CssClass="hidden"></iwc:IboWebTextBox>
                                    <iwc:IboWebTextBox runat="server" ID="txtSchedulazioneArgomento" Required="true" CssClass="hidden"></iwc:IboWebTextBox>
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
