<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFDOCRimesse.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCRimesse" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1220px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpGeneralita_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpGeneralita_Title_Caption" Text="Generalità del documento" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpGeneralita_Body" CssClass="CollapsiblePanelBody">

                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblId" runat="server" Text="Id:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px;">
                                                <iwc:IboWebLabel ID="txtID" runat="server" FieldName="Id"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDataRimessa" runat="server" Text="Data Rimessa:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 70px;">                                               
                                                <iwc:IboWebLabel ID="DataRimessa" runat="server" FieldDataType="Date" FieldName="DataRimessa" FormatString="{0:dd/MM/yyyy}"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblImporto" runat="server" Text="Importo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 70px;">                                                
                                                <iwc:IboWebLabel ID="Importo" runat="server" FormatString="{0:f2}"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 200px;">
                                                
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 50px;">
                                                <iwc:IboWebLabel ID="lblStato" runat="server" Text="Stato:"></iwc:IboWebLabel>
                                                <iwc:IboWebHidden ID="HFStato" FieldName="Stato" runat="server"></iwc:IboWebHidden>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 120px;">                                                
                                                <iwc:IboWebLabel ID="lblStatoDescrizione" runat="server" Text=""></iwc:IboWebLabel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCliente" runat="server" Text="Cliente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblCodiceSoggettoValue" runat="server" Translate="False" FieldName="Cliente"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoCaption" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCellNoDataBounded" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblDescrizioneSoggettoValue" runat="server" Translate="False" SqlQueryLookup="SELECT * FROM Clienti WHERE CODICE='<#CONTROLS_RECORD.lblCodiceSoggettoValue#>'" SqlQueryLookupField="RagioneSociale"></iwc:IboWebLabel>
                                            </td>                                            
                                        </tr>
                                    </table>
                                    <hr class="WFIHRSeparatore"/>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblNote1" runat="server" Text="Note 1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtNote1" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="300px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                <iwc:IboWebLabel ID="lblNote2" runat="server" Text="Note 2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtNote2" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="300px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px;">
                                                <iwc:IboWebLabel ID="lblNote3" runat="server" Text="Note 3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 300px;">
                                                <iwc:IboWebTextBox ID="txtNote3" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="300px" Rows="4" TextMode="MultiLine"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel ID="cpContrassegni_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpContrassegni_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Contrassegni"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel ID="cpContrassegni_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <table class="tableGridContainer">
                                        <tr>
                                            <td>
                                                <iwc:iboWebToolbar ID="tlbgrdContrassegni" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                    CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                <asp:Panel ID="pnlContrassegni" runat="server" CssClass="DetailFormGridContainerDiv">
                                                    <iwc:IboGridView ID="grdContrassegni" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <asp:Panel runat="server" ID="cpFoto_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpFoto_Title_Caption" Text="Documenti" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpFoto_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblDoc1" runat="server" Text="Documento 1:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 310px">
                                                <iwc:IboWebImage runat="server" ID="imgDoc1" FieldName="Doc1" FieldNameExtension="Doc1Tipo" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 72px;">
                                                <iwc:IboWebLabel ID="lblDoc2" runat="server" Text="Documento 2:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 310px">
                                                <iwc:IboWebImage runat="server" ID="imgDoc2" FieldName="Doc2" FieldNameExtension="Doc2Tipo" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 72px;">
                                                <iwc:IboWebLabel ID="lblDoc3" runat="server" Text="Documento 3:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 305px">
                                                <iwc:IboWebImage runat="server" ID="imgDoc3" FieldName="Doc3" FieldNameExtension="Doc3Tipo" />
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
