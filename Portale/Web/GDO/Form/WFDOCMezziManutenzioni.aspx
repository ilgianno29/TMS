<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCMezziManutenzioni.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCMezziManutenzioni" %>

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
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebTextBox ID="txtDescrizione" Required="True" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="500px" FieldName="Descrizione"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCommessa" runat="server" IncasTag="" Text="Commessa:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px">
                                                <iwc:IboWebComboTlk ID="CmbIdCommessa" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_MezziManutenz_Commesse" Width="300px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppo" runat="server" IncasTag="" Text="Gruppo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px">
                                                <iwc:IboWebComboTlk ID="CmbGruppo" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_ANA_MezziManutenz_Gruppi" Width="300px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblOfficinaInterna" runat="server" Text="OfficinaInterna:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px">
                                                <iwc:IboWebCheckBox ID="chkOfficinaInterna" runat="server" Checked="True" Value="S" AutoPostBack="true"></iwc:IboWebCheckBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblFornitore" runat="server" Text="Fornitore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px">
                                                <iwc:IboWebTextBox ID="txtFornitore" Required="false" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="492px" FieldName="Fornitore">
                                                </iwc:IboWebTextBox>
                                            </td>

                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNumeroFatturaFornitore" runat="server" Text="N. Fattura Fornitore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px">
                                                <iwc:IboWebTextBox ID="txtNumeroFatturaFornitore" Required="false" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="250px" FieldName="NumeroFatturaFornitore">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataFatturaFornitore" runat="server" Text="Data Fattura Fornitore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 95px">
                                                <iwc:IboWebDate ID="txtDataFatturaFornitore" runat="server" Width="70px" ControlType="DateOnly" Tooltip="Data Fattura Fornitore" Required="false" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataInizio" runat="server" Text="Data Inizio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 95px">
                                                <iwc:IboWebDate ID="txtDataInizio" runat="server" Width="70px" ControlType="DateOnly" Tooltip="Data Inizio" Required="true" />
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataFine" runat="server" Text="Data Fine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 95px">
                                                <iwc:IboWebDate ID="txtDataFine" runat="server" Width="70px" ControlType="DateOnly" Tooltip="Data Fine" Required="false" />
                                            </td>
                                        </tr>
                                    </table>
                                    <%-- Note --%>
                                    <table class="DetailFormSectionTable2Fixed" >
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote1" runat="server" Text="Note1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebTextBox ID="txtNote1" runat="server" CharacterCase="Uppercase" MaxLength="1000" Rows="4" TextMode="MultiLine" FieldName="Note1" Width="700px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote2" runat="server" Text="Note2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebTextBox ID="txtNote2" runat="server" CharacterCase="Uppercase" MaxLength="1000" Rows="4" TextMode="MultiLine" FieldName="Note2" Width="700px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote3" runat="server" Text="Note3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebTextBox ID="txtNote3" runat="server" CharacterCase="Uppercase" MaxLength="1000" Rows="4" TextMode="MultiLine" FieldName="Note3" Width="700px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>

                                    </table>

                                    <iwc:IboWebTextBox runat="server" ID="txtId" Visible="false" IncasTag="IsIdentity=S"></iwc:IboWebTextBox>

                                </asp:Panel>
                                <asp:Panel ID="cpLocalitaZone_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpLocalitaZone_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Dettaglio Manutenzioni"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel ID="cpMezziManutenzioniDett_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <table class="tableGridContainer">
                                        <tr>
                                            <td>
                                                <iwc:iboWebToolbar ID="tlbgrdMezziManutenzioniDett" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                    SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                <asp:Panel ID="pnlLocalitaZone" runat="server" CssClass="DetailFormGridContainerDiv">
                                                    <iwc:IboGridView ID="grdMezziManutenzioniDett" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                        BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                        HorizontalAlign="Left" PageSize="20" Width="100%">
                                                        <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                        <PagerStyle Font-Size="Small" />
                                                        <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                    </iwc:IboGridView>
                                                </asp:Panel>
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
                                <iwc:IboWebButton ID="btnInserimento" runat="server" Text="Inserisci" CssClass="hidden" />
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
