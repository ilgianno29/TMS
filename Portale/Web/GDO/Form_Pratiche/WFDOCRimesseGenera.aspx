<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCRimesseGenera.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCRimesseGenera" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../WFI/css/DetailForm-min.css?d=20180913" type="text/css" />
    <link href="../Css/WFDOCRimesseGenera.css?20170511" rel="stylesheet" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="800px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody" Style="padding-top: 10px; padding-bottom: 10px;">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" IncasTag="" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 505px">
                                                <iwc:IboWebComboTlk ID="Cliente" runat="server" SqlQuery="SELECT * FROM CBO_ANA_CLIENTI" AutoPostBack="True"
                                                    Required="True" Width="500px" AutoLoadOnDemand="True" FieldName="Cliente" DropDownWidth="820px">
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
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblData" runat="server" IncasTag="" Text="Data rimessa:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebDate2 ID="Data" runat="server" Width="70px" ControlType="DateOnly" Required="true" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCellTop" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblNote1" runat="server" IncasTag="" Text="Note 1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebTextBox ID="txtNote1" runat="server" Width="500px" MaxLength="1000" Rows="3" TextMode="MultiLine" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCellTop" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblNote2" runat="server" IncasTag="" Text="Note 2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebTextBox ID="txtNote2" runat="server" Width="500px" MaxLength="1000" Rows="3" TextMode="MultiLine" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCellTop" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblNote3" runat="server" IncasTag="" Text="Note 3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:IboWebTextBox ID="txtNote3" runat="server" Width="500px" MaxLength="1000" Rows="3" TextMode="MultiLine" />
                                            </td>
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore" />
                                    <asp:UpdatePanel runat="server" ID="up_SommaContrassegni" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="DetailFormSectionTable2Fixed">
                                                <tr>
                                                    <td class="DetailFormDescriptionCell" style="width: 130px;">
                                                        <iwc:IboWebLabel ID="lblNumero" runat="server" Text="Contrassegni selezionati:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 70px;">
                                                        <iwc:IboWebLabel ID="Numero" runat="server" Text="0"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                        <iwc:IboWebLabel ID="lblImporto" runat="server" Text="Importo:"></iwc:IboWebLabel>
                                                    </td>
                                                    <td class="DetailFormValueCellNoDataBounded" style="width: 70px;">
                                                        <iwc:IboWebLabel ID="Importo" runat="server" FormatString="{0:f2}" Text="0"></iwc:IboWebLabel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
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
                                <td id="tableButtons_C" class="tableButtons_C">
                                    <iwc:IboWebButton ID="btnAssocia" runat="server" Text="Associa" CssClass="btnAssocia" />
                                </td>
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
