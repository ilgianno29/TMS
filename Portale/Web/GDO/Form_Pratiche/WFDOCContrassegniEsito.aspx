<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCContrassegniEsito.aspx.vb"
    Inherits="Incasbo.Web.GDO.WFDOCContrassegniEsito" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../css/WFDOCSpedizioniEsito.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv" DefaultButton="btnConferma">
        <table class="DetailFormMainTable">
            <tr style="display: none;">
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
                        <asp:Panel runat="server" ID="pnlMain" Width="700px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpEstremi_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpEstremi_Title_Caption" Text="Contrassegni" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="Panel1" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed RiepilogoContrassegni">
                                        <tr>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblNumeroContrassegni" runat="server" IncasTag="" Text="Numero Contrassegni Selezionati:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 50px;">
                                                <iwc:IboWebLabel ID="NumeroContrassegni" runat="server" IncasTag="" Text="" Translate="false">                                                 
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td style="width: 320px;"></td>
                                            <td style="width: 40px;">
                                                <iwc:IboWebButton ID="btnVisualizza" runat="server" Text="" CssClass="btnVisualizza" ToolTip="Vedi dettagli dei Contrassegni selezionate" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpEsitazione_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpEsitazione_Title_Caption" Text="Esito" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpEstremi_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDataEsito" runat="server" IncasTag="" Text="Data Esito:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 200px;">
                                                <iwc:IboWebDate2 ID="DataEsito" runat="server" Width="70px" ControlType="DateAndTime" FormatoOra="HH:mm" TimeControlWidth="35px" Required="true" ShowTodayButton="true" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblEvento" runat="server" IncasTag="" Text="Evento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 500px;">
                                                <iwc:IboDropDownList ID="Evento" runat="server" CharacterCase="Uppercase" IncasTag="" Required="True" AutoPostBack="true"
                                                    SqlQuery="SELECT * FROM CBO_ANA_Eventi" Width="500px" SqlQueryWhere="TipoEvento='CONTRASSEGNO.INCASSATO' OR TipoEvento='CONTRASSEGNO.NON_INCASSATO'">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 500px;">
                                                <iwc:IboWebTextBox ID="NoteEsito" runat="server" CharacterCase="Uppercase" MaxLength="255" Rows="4" TextMode="MultiLine" FieldName="NoteEsito" Width="493px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpTipoIncasso_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpTipoIncasso_Title_Caption" Text="Tipo Incasso" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpTipoIncasso_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoIncasso" runat="server" Text="Tipo Incasso:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoIncasso" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TipiIncasso" Required="true" Width="500px" SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE"
                                                    MaxHeight="250px" SqlQueryFilter="ATTIVO='S'">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNoteIncasso" runat="server" Text="Note Incasso:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 500px;">
                                                <iwc:IboWebTextBox ID="txtNoteIncasso" runat="server" CharacterCase="Uppercase" MaxLength="255" Rows="4" TextMode="MultiLine" FieldName="NoteIncasso" Width="493px"></iwc:IboWebTextBox>
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
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" />
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
