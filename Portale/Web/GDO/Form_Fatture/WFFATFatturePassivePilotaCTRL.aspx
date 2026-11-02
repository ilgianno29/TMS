<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFFATFatturePassivePilotaCTRL.aspx.vb" Inherits="Incasbo.Web.GDO.WFFATFatturePassivePilotaCTRL" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link rel="stylesheet" href="../../GDO/Css/WFFATFatturePassivePilotaCTRL.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="800px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Dati per la generazione del controllo costi" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed" style="margin-top: 10px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebComboTlk ID="cmbTrasportatore" runat="server" Required="true" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="593px" SqlQueryWhere="CODICE IN (SELECT codice FROM VW_TRASPORTATORI_FATTURAZIONE)">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoPagamento" runat="server" Text="Tipo Pagamento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 250px;">
                                                <iwc:IboWebComboTlk ID="cmbTipoPagamento" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CODICIPAGAMENTO"
                                                    Width="430px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNumeroFatturaEsterno" runat="server" Text="Numero fattura:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebTextBox ID="NumeroFatturaEsterno" FieldDescription="Numero fattura del trasportatore" runat="server" Required="true" MaxLength="30" Width="100px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px;">
                                                <iwc:IboWebLabel ID="lblDataDocumento" runat="server" Text="Data fattura:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 100px;">
                                                <iwc:IboWebDate runat="server" ID="txtDataFattura" Width="80px" ControlType="DateOnly" Required="true"  FieldName="Data"  />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataInizio" runat="server" Text="Da Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebDate runat="server" ID="txtDataInizio" Width="80px" ControlType="DateOnly" Required="true"  FieldName="DAData"  />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblDataFine" runat="server" Text="A Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebDate runat="server" ID="txtDataFine" Width="80px" ControlType="DateOnly" Required="true" FieldName="AData" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblSezionale" runat="server" Text="Sezionale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 330px;">
                                                <iwc:IboWebComboTlk ID="cmbSezionale" runat="server" SqlQuery="SELECT * FROM CBO_ANA_SEZIONALI"
                                                    Width="316px" Required="true" SqlQueryFilter="AttivoPassivo='P'">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNota1" runat="server" Text="Nota 1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox runat="server" ID="txtNota1" Width="500px" FieldName="Note1"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNota2" runat="server" Text="Nota 2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox runat="server" ID="txtNota2" Width="500px" FieldName="Note2"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNota3" runat="server" Text="Nota 3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox runat="server" ID="txtNota3" Width="500px" FieldName="Note3"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <%--<table class="DetailFormSectionTable2Fixed" style="margin-bottom: 10px;">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblFatturaViaggi" runat="server"  Text="Fattura Viaggi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkFatturaViaggi" runat="server"  Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblFatturaSpedizioni" runat="server" Text="Fattura Spedizioni:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkFatturaSpedizioni" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblFatturaContrassegni" runat="server" Text="Fattura contrassegni:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkFatturaContrassegni" runat="server" Checked="True" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>--%>
                                    <hr class="WFIHRSeparatore" />
                                    <table class="DetailFormSectionTable2Fixed" style="margin-bottom: 10px;">
                                        <tr>
                                            <td>
                                                <asp:UpdatePanel ID="upUploadFile" runat="server">
                                                    <ContentTemplate>
                                                        <div class="FUContainer">
                                                            <iwc:IboWebButton runat="server" ID="btnUpload" Text="" ClientIDMode="Static" />
                                                            <label class="fileContainer">Scegli file<asp:FileUpload ID="FUFileFattura" runat="server" CssClass="btnBrowse" /></label>
                                                            <iwc:IboWebLabel runat="server" ID="lblNomeFile" Text="" ClientIDMode="Static"></iwc:IboWebLabel>
                                                            <iwc:IboWebLabel runat="server" ID="lblVediFile" Text="Vedi file" ClientIDMode="Static" Visible="false"></iwc:IboWebLabel>
                                                        </div>
                                                    </ContentTemplate>
                                                    <Triggers>
                                                        <asp:PostBackTrigger ControlID="btnUpload" />
                                                    </Triggers>
                                                </asp:UpdatePanel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <iwc:IboWebHidden runat="server" ID="IdFattura" FieldName="IdFattura" />
                                <iwc:IboWebHidden runat="server" ID="Id" FieldName="Id" />
                                <iwc:IboWebHidden runat="server" ID="StatoElaborazione" FieldName="StatoElaborazione" />
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
