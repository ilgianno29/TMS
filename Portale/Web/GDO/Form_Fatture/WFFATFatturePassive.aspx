<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFFATFatturePassive.aspx.vb" Inherits="Incasbo.Web.GDO.WFFATFatturePassive" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate2.ascx" TagName="IboWebDate2" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebImage.ascx" TagName="IboWebImage" TagPrefix="iwc" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1200px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Testata" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblIdFattura" runat="server" Text="Num. Provvisorio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 50px">
                                                <iwc:IboWebLabel ID="lblIdFatturaValue" runat="server" Translate="False" Width="60px" FieldName="IdFattura"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblNumero" runat="server" Text="Num. Fattura:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 50px">
                                                <iwc:IboWebLabel ID="lblNumeroValue" runat="server" Translate="False" Width="80px" FieldName="Numero"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 40px">
                                                <iwc:IboWebLabel ID="lblData" runat="server" Text="Data:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDataValue" runat="server" Translate="False" Width="80px" FieldName="Data" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px"></td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCostiviaggi" runat="server" Text="Costi Viaggi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblCostiviaggiValue" runat="server" FormatString="{0:#,##0.#0}"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCostiSpedizioni" runat="server" Text="Costi Spedizioni:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblCostiSpedizioniValue" Translate="False" runat="server" FormatString="{0:#,##0.#0}"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCostiTotali" runat="server" Text="Costi Totali:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblCostiTotaliValue" Translate="False" runat="server" FormatString="{0:#,##0.#0}"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblTrasportatore" runat="server" Text="Trasportatore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTrasportatoreValue" runat="server" FieldName="Trasportatore"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="lblTrasportatoreRagioneSociale" runat="server"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 120px">
                                                <iwc:IboWebLabel ID="lblTipoPagamento" runat="server" Text="Tipo pagamento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px">
                                                <iwc:IboWebLabel ID="TipoPagamentoCodice" runat="server" FieldName="TipoPagamento"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded">
                                                <iwc:IboWebLabel ID="TipoPagamentoDescrizione" runat="server" SqlQueryLookup="SELECT DESCRIZIONE FROM CodiciPagamento WHERE CODICE='<#CONTROLS_RECORD.TipoPagamentoCodice#>'"></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpDettaglioFattura_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpDettaglioFattura_Title_Caption" Text="Dettaglio della fattura" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpDettaglioFattura_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpDettaglioFattura_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <asp:UpdatePanel runat="server" ID="up_cpDettaglioFattura_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="tableGridContainer">
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="pnlRigheFattura" runat="server" CssClass="DetailFormGridContainerDiv300">
                                                            <iwc:IboGridView ID="grdRigheFattura" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpDettaglioFattura" runat="server" CollapseControlID="cpDettaglioFattura_Title" Collapsed="false" CollapsedImage="~/images/expand.png"
                                    CollapsedSize="0"
                                    CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpDettaglioFattura_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details"
                                    ImageControlID="cpDettaglioFattura_Title_Image" TargetControlID="cpDettaglioFattura_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                            </div>
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpMessaggiFattura_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpMessaggiFattura_Title_Caption" Text="Messaggi di creazione fattura" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <iwc:IboWebLabel runat="server" ID="cpMessaggiFattura_Title_Caption2" CssClass="CollapsibleSubPanelTitleCaption"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpMessaggiFattura_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpMessaggiFattura_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <asp:UpdatePanel runat="server" ID="up_cpMessaggiFattura_Body" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <table class="tableGridContainer">
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="pnlMessaggiFattura" runat="server" CssClass="DetailFormGridContainerDiv250">
                                                            <iwc:IboGridView ID="grdMessaggiFattura" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpMessaggiFattura" runat="server" CollapseControlID="cpMessaggiFattura_Title" Collapsed="true" CollapsedImage="~/images/expand.png"
                                    CollapsedSize="0" CollapsedText="(Mostra)" Enabled="True" ExpandControlID="cpMessaggiFattura_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="(Nascondi)" ImageControlID="cpMessaggiFattura_Title_Image" TargetControlID="cpMessaggiFattura_Body" TextLabelID="cpMessaggiFattura_Title_Caption2">
                                </ajaxToolkit:CollapsiblePanelExtender>
                            </div>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
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
