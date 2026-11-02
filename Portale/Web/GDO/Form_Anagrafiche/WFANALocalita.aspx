<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFANALocalita.aspx.vb" Inherits="Incasbo.Web.GDO.WFANALocalita" %>

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
                                <iwc:IboWebTextBox runat="server" ID="txtId" IncasTag="IsIdentity=S" CssClass="hidden"></iwc:IboWebTextBox>
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body_Localita" CssClass="CollapsiblePanelBody" Visible="false">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="loc_lblLocalita" runat="server" Text="Localita:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebTextBox ID="Loc_Localita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="Loc_lblCap" runat="server" Text="Cap:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 55px;">
                                                <iwc:IboWebTextBox ID="Loc_Cap" runat="server" CssClass="WFIAutoComplete" autocomplete-tag="Cap" CharacterCase="Uppercase"
                                                    MaxLength="10" Width="55px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="Loc_lblRegione" runat="server" Text="Regione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Loc_Regione" runat="server" CssClass="WFIAutoComplete" autocomplete-tag="Regioni" autocomplete-minLength="2" CharacterCase="Uppercase" MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="Loc_lblProvincia" runat="server" Text="Provincia:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 30px;">
                                                <iwc:IboWebTextBox ID="Loc_Provincia" runat="server" CssClass="WFIAutoComplete" autocomplete-tag="Province" CharacterCase="Uppercase" MaxLength="3"
                                                    Width="30px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="Loc_lblNazione" runat="server" Text="Nazione:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Loc_Nazione" runat="server" CssClass="WFIAutoComplete" autocomplete-tag="Nazioni" autocomplete-minLength="1" CharacterCase="Uppercase"
                                                    MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body_Provincia" CssClass="CollapsiblePanelBody" Visible="false">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="Prv_lblProvincia" runat="server" Text="Provincia:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 30px;">
                                                <iwc:IboWebTextBox ID="Prv_Provincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="30px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="Prv_lblRegione" runat="server" Text="Regione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Prv_Regione" runat="server" CssClass="WFIAutoComplete" autocomplete-serverfunc="GetRegionNames" autocomplete-minLength="2" CharacterCase="Uppercase" MaxLength="6"
                                                    Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="Prv_lblNazione" runat="server" Text="Nazione:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Prv_Nazione" runat="server" CssClass="WFIAutoComplete" autocomplete-serverfunc="GetCountryNames" autocomplete-minLength="1" CharacterCase="Uppercase"
                                                    MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="prv_lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebTextBox ID="Prv_Descrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body_Regione" CssClass="CollapsiblePanelBody" Visible="false">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="Reg_lblRegione" runat="server" Text="Regione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Reg_Regione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 150px;">
                                                <iwc:IboWebLabel ID="Reg_lblNazione" runat="server" Text="Nazione:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Reg_Nazione" runat="server" CssClass="autocompleteCountry" CharacterCase="Uppercase" MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="Reg_lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebTextBox ID="Reg_Descrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body_Nazione" CssClass="CollapsiblePanelBody" Visible="false">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 70px;">
                                                <iwc:IboWebLabel ID="Naz_lblNazione" runat="server" Text="Nazione:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Naz_Nazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="Naz_lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebTextBox ID="Naz_Descrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body_Cap" CssClass="CollapsiblePanelBody" Visible="false">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="Cap_lblCap" runat="server" Text="Cap:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Cap_Cap" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 150px;">
                                                <iwc:IboWebLabel ID="Cap_lblNazione" runat="server" Text="Nazione:">
                                                </iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 60px;">
                                                <iwc:IboWebTextBox ID="Cap_Nazione" runat="server" CssClass="WFIAutoComplete" autocomplete-serverfunc="GetCountryNames" CharacterCase="Uppercase" MaxLength="6" Width="60px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="Cap_lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:IboWebTextBox ID="Cap_Descrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel ID="cpLocalitaZone_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpLocalitaZone_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Tipi Merce - Zone"></iwc:IboWebLabel>
                                </asp:Panel>
                                <asp:Panel ID="cpLocalitaZone_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <table class="tableGridContainer">
                                        <tr>
                                            <td>
                                                <iwc:iboWebToolbar ID="tlbgrdLocalitaZone" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                    SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                <asp:Panel ID="pnlLocalitaZone" runat="server" CssClass="DetailFormGridContainerDiv">
                                                    <iwc:IboGridView ID="grdLocalitaZone" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
