<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCSpedizioniModello.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCSpedizioniModello" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <iwc:IboWebTextBox ID="txtId" runat="server" CssClass="WFIHidden" IncasTag="IsIdentity=S"></iwc:IboWebTextBox>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoServizio" runat="server" Text="Tipo Servizio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbTipoServizio" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISERVIZI" Width="200px" Required="True">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbCliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" AutoPostBack="True"
                                                    Required="True" Width="500px" AutoLoadOnDemand="True">
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
                                                <iwc:IboWebComboTlk ID="cmbTipoSpedizione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPISPEDIZIONE " Required="True" Width="500px" SqlQueryOrderBy="DESCRIZIONE"
                                                    AutoPostBack="true">
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
                                                <iwc:IboWebComboTlk ID="cmbTipoMerce" runat="server" SqlQuery="SELECT * FROM CBO_ANA_TIPIMERCE" Width="500px" Required="true" >
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSPartenza" runat="server" Text="Partenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbPCSPArtenza" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Required="True" AutoPostBack="False" Width="500px" AutoLoadOnDemand="True"
                                                    SqlQueryWhere="PUNTODICARICO = 'S'" DropDownWidth="820px" FieldDescription="Partenza">
                                                    <HeaderTemplate>
                                                        <ul>
                                                            <li class="ComboCol" style="width: 80px; display: none;">
                                                                <iwc:IboWebLabel runat="server" ID="Col1" Text="Codice"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 250px;">
                                                                <iwc:IboWebLabel runat="server" ID="Col2" Text="Ragione Sociale"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <iwc:IboWebLabel runat="server" ID="col3" Text="Indirizzo"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <iwc:IboWebLabel runat="server" ID="col4" Text="Localita"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <iwc:IboWebLabel runat="server" ID="col5" Text="Prov."></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <iwc:IboWebLabel runat="server" ID="col6" Text="Naz."></iwc:IboWebLabel></li>
                                                        </ul>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <ul>
                                                            <li class="ComboCol" style="width: 80px; display: none;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Codice")%></li>
                                                            <li class="ComboCol" style="width: 250px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "RagioneSociale")%></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Indirizzo")%></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Localita")%></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Provincia")%></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Nazione")%></li>
                                                        </ul>
                                                    </ItemTemplate>
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPCSDestinazione" runat="server" Text="Destinazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbPCSDestinazione" runat="server" SqlQuery="SELECT * FROM CBO_ANA_PCS" Required="True" AutoPostBack="False" Width="500px" AutoLoadOnDemand="True"
                                                    SqlQueryWhere="PUNTODIDESTINO = 'S'" DropDownWidth="820px" FieldDescription="Destinazione">
                                                    <HeaderTemplate>
                                                        <ul>
                                                            <li class="ComboCol" style="width: 80px; display: none;">
                                                                <iwc:IboWebLabel runat="server" ID="Col1" Text="Codice"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 250px;">
                                                                <iwc:IboWebLabel runat="server" ID="Col2" Text="Ragione Sociale"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <iwc:IboWebLabel runat="server" ID="col3" Text="Indirizzo"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <iwc:IboWebLabel runat="server" ID="col4" Text="Localita"></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <iwc:IboWebLabel runat="server" ID="col5" Text="Prov."></iwc:IboWebLabel></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <iwc:IboWebLabel runat="server" ID="col6" Text="Naz."></iwc:IboWebLabel></li>
                                                        </ul>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <ul>
                                                            <li class="ComboCol" style="width: 80px; display: none;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Codice")%></li>
                                                            <li class="ComboCol" style="width: 250px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "RagioneSociale")%></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Indirizzo")%></li>
                                                            <li class="ComboCol" style="width: 200px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Localita")%></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Provincia")%></li>
                                                            <li class="ComboCol" style="width: 50px;">
                                                                <%# DataBinder.Eval(Container.DataItem, "Nazione")%></li>
                                                        </ul>
                                                    </ItemTemplate>
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>                                    
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCorrispondente" runat="server" Text="Corrispondente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbCorrispondente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CORRISPONDENTI" Width="500px" AutoLoadOnDemand="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNote" runat="server" Text="Note:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtNote" runat="server" Width="500px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpQta_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpQta_Title_Caption" Text="Quantità" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpQta_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPeso" runat="server" IncasTag="" Text="Peso:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 90px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtPeso" Required="True" Width="80px" FieldName="Peso" Value="0" DecimalDigits="3">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblColli" runat="server" IncasTag="" Text="Colli:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 90px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtColli" Required="True" Width="80px" DecimalDigits="0" FieldName="Colli">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblPallet" runat="server" IncasTag="" Text="Pallet:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 90px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtPallet" Required="True" Width="80px" DecimalDigits="0" FieldName="Pallet">
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblVolume" runat="server" IncasTag="" Text="Volume:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 90px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtVolume" Required="True" Width="80px" DecimalDigits="5" FieldName="Volume">
                                                </iwc:IboWebNumericTlk>
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
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkLunedi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblMartedi" runat="server" Text="Martedì:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkMartedi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblMercoledi" runat="server" Text="Mercoledi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkMercoledi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGiovedi" runat="server" Text="Giovedì:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkGiovedi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td></td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblVenerdi" runat="server" Text="Venerdì:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkVenerdi" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblSabato" runat="server" Text="Sabato:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkSabato" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDomenica" runat="server" Text="Domenica:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 50px">
                                                <iwc:IboWebCheckBox ID="chkDomenica" runat="server" Checked="False" Value="N"></iwc:IboWebCheckBox>
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
