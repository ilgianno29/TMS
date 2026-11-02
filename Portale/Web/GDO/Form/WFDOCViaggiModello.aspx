<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCViaggiModello.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCViaggiModello" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
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
                                    <iwc:IboWebLabel ID="lblTitle" runat="server" Text=""></iwc:IboWebLabel>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="770px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <iwc:IboWebTextBox ID="txtId" runat="server" CssClass="WFIHidden" IncasTag="IsIdentity=S"></iwc:IboWebTextBox>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblTipoViaggio" runat="server" Text="Tipo viaggio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoViaggio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Viaggi_TipiViaggio" Width="200px" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 279px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" Checked="true" Value="S"></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblVettore" runat="server" Text="Vettore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbVettore" runat="server" SqlQuery="SELECT * FROM CBO_ANA_Trasportatori" Width="500px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>

                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoSpedizione" runat="server" Text="Tipo Spedizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE" Width="500px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoMerce" runat="server" Text="Tipo merce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Width="500px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="IboWebLabel1" runat="server" Text="Mezzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbMotricePianificata" runat="server" SqlQuery="SELECT * FROM CBO_ANA_MEZZI" Width="500px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="PCS Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 350px;">
                                                <iwc:IboWebComboTlk ID="cmbPCSPartenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PuntiPartenza" Width="500px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblPCSArrivo" runat="server" Text="PCS Arrivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbPCSArrivo" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Width="500px" AutoLoadOnDemand="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote1" runat="server" Text="Note 1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox runat="server" ID="txtNote1" MaxLength="1000" Width="550px" Rows="3" TextMode="MultiLine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote2" runat="server" Text="Note 2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox runat="server" ID="txtNote2" MaxLength="1000" Width="550px" Rows="3" TextMode="MultiLine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpProgrammazione_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpProgrammazione_Title_Caption" Text="Programmazione settimanale" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpProgrammazione_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblLunedi" runat="server" Text="Lunedì:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkLunedi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebDate2 ID="txtLunediOraPartenza" runat="server" TimeControlWidth="40px" ControlType="TimeOnly" Tooltip="Ora di partenza" FormatoOra="HH:mm" Text="" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblMartedi" runat="server" Text="Martedì:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkMartedi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebDate2 ID="txtMartediOraPartenza" runat="server" TimeControlWidth="40px" ControlType="TimeOnly" Tooltip="Ora di partenza" FormatoOra="HH:mm" Text="" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblMercoledi" runat="server" Text="Mercoledi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkMercoledi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebDate2 ID="txtMercolediOraPartenza" runat="server" TimeControlWidth="40px" ControlType="TimeOnly" Tooltip="Ora di partenza" FormatoOra="HH:mm" Text="" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblGiovedi" runat="server" Text="Giovedì:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkGiovedi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebDate2 ID="txtGiovediOraPartenza" runat="server" TimeControlWidth="40px" ControlType="TimeOnly" Tooltip="Ora di partenza" FormatoOra="HH:mm" Text="" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblVenerdi" runat="server" Text="Venerdì:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkVenerdi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebDate2 ID="txtVenerdiOraPartenza" runat="server" ControlType="TimeOnly" Tooltip="Ora di partenza" FormatoOra="HH:mm" Text="" TimeControlWidth="40px" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblSabato" runat="server" Text="Sabato:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkSabato" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebDate2 ID="txtSabatoOraPartenza" runat="server" TimeControlWidth="40px" ControlType="TimeOnly" Tooltip="Ora di partenza" FormatoOra="HH:mm" Text="" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblDomenica" runat="server" Text="Domenica:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 25px">
                                                <iwc:IboWebCheckBox ID="chkDomenica" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px">
                                                <iwc:IboWebDate2 ID="txtDomenicaOraPartenza" runat="server" TimeControlWidth="40px" ControlType="TimeOnly" Tooltip="Ora di partenza" FormatoOra="HH:mm" Text="" />
                                            </td>
                                            <td></td>
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
