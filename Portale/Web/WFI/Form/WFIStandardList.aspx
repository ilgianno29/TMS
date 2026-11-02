<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFIStandardList.aspx.vb"
    Inherits="Incasbo.Web.WFI.WFIStandardList" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" media="screen" href="~/WFI/css/DataList.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="pnlMain" CssClass="pnlMain" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=SBODEV03\SQL2K8R2;Initial Catalog=DELSY8;Persist Security Info=True;User ID=sa;Password=;Application Name=Test"
            ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [GdoTariffeContratti]"></asp:SqlDataSource>
        <asp:Panel ID="pnlListViewContainer" CssClass="pnlListViewContainer" runat="server">
            <asp:Panel ID="pnlListViewTitle" CssClass="pnlListViewTitle" runat="server">
                <iwc:IboWebLabel runat="server" ID="lblListViewTitle" Text="Titolo"  ></iwc:IboWebLabel>
            </asp:Panel>
            <asp:Panel ID="pnlListViewFilter" CssClass="pnlListViewFilter" runat="server" DefaultButton="btnListViewFiltro">
                <iwc:IboWebLabel runat="server" ID="lblListViewFilter" Text="Filtro:"  ></iwc:IboWebLabel>
                &nbsp;<iwc:IboWebTextBox runat="server" ID="txtListViewFiltro" Text="" CharacterCase="Uppercase" Width="100px"></iwc:IboWebTextBox>
                <asp:ImageButton ID="btnListViewFiltro" runat="server" AlternateText="Cerca" ImageUrl="~/images/StdGrid/24/Search.png" ToolTip="Cerca su tutti i campi della lista"
                    ImageAlign="AbsMiddle" />
                &nbsp;
                <asp:ImageButton ID="btnListViewAggiorna" runat="server" AlternateText="Refresh" ImageUrl="~/images/Toolbar/24/AGGIORNA.png"
                    ToolTip="Aggiorna i dati in lista" ImageAlign="AbsMiddle" />
            </asp:Panel>
            <asp:Panel ID="pnlListViewBody" CssClass="pnlListViewBody" runat="server">
                <asp:UpdatePanel ID="lvPanelUpdate" runat="server">
                    <ContentTemplate>
                        <asp:ListView ID="lvContratti" runat="server" DataKeyNames="CODICE">
                            <AlternatingItemTemplate>
                                <div class="ListViewAlternateItemContainer" onmouseover="this.className='ListViewItemContainerOnMouseOver';" onmouseout="this.className='ListViewAlternateItemContainer';">
                                    <table class="ListViewAlternateItemTable">
                                        <tr>
                                            <td rowspan="4">
                                                <asp:ImageButton ID="lnkSelect" Text="" CommandName="Select" runat="server" ImageUrl="~/images/Toolbar/16/selection.png" />
                                            </td>
                                            <td class="ListViewAlternateItemTabletd1">
                                                <asp:Label ID="FieldDescriptionCodice" runat="server" Text="Codice:" />
                                            </td>
                                            <td class="ListViewAlternateItemTabletd2">
                                                <asp:Label ID="FieldValueCodice" runat="server" Text='<%# Eval("CODICE") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewAlternateItemTabletd1">
                                                <asp:Label ID="FieldDescriptionAttivaPassiva" runat="server" Text="Att/Pass:" />
                                            </td>
                                            <td class="ListViewAlternateItemTabletd2">
                                                <asp:Label ID="FieldValueAttivaPassiva" runat="server" Text='<%# Eval("ATTIVAPASSIVA") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewAlternateItemTabletd1">
                                                <asp:Label ID="FieldDescriptionTipoContratto" runat="server" Text="Tipo Contratto:" />
                                            </td>
                                            <td class="ListViewAlternateItemTabletd2">
                                                <asp:Label ID="FieldValueTipoContratto" runat="server" Text='<%# Eval("TIPOCONTRATTO") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewAlternateItemTabletd1">
                                                <asp:Label ID="FieldDescriptionDescrizione" runat="server" Text="Descrizione:" />
                                            </td>
                                            <td class="ListViewAlternateItemTabletd2">
                                                <asp:Label ID="FieldValuesDescrizione" runat="server" Text='<%# Eval("DESCRIZIONE") %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </AlternatingItemTemplate>
                            <EmptyDataTemplate>
                                <span>Non è stato restituito alcun dato.</span>
                            </EmptyDataTemplate>
                            <ItemTemplate>
                                <div class="ListViewItemContainer" onmouseover="this.className='ListViewItemContainerOnMouseOver';" onmouseout="this.className='ListViewItemContainer';">
                                    <table class="ListViewItemTable">
                                        <tr>
                                            <td rowspan="4">
                                                <asp:ImageButton ID="lnkSelect" Text="" CommandName="Select" runat="server" ImageUrl="~/images/Toolbar/16/selection.png" />
                                            </td>
                                            <td class="ListViewItemTabletd1">
                                                <asp:Label ID="FieldDescriptionCodice" runat="server" Text="Codice:" />
                                            </td>
                                            <td class="ListViewItemTabletd2">
                                                <asp:Label ID="FieldValueCodice" runat="server" Text='<%# Eval("CODICE") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewItemTabletd1">
                                                <asp:Label ID="FieldDescriptionAttivaPassiva" runat="server" Text="Att/Pass:" />
                                            </td>
                                            <td class="ListViewItemTabletd2">
                                                <asp:Label ID="FieldValueAttivaPassiva" runat="server" Text='<%# Eval("ATTIVAPASSIVA") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewItemTabletd1">
                                                <asp:Label ID="FieldDescriptionTipoContratto" runat="server" Text="Tipo Contratto:" />
                                            </td>
                                            <td class="ListViewItemTabletd2">
                                                <asp:Label ID="FieldValueTipoContratto" runat="server" Text='<%# Eval("TIPOCONTRATTO") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewItemTabletd1">
                                                <asp:Label ID="FieldDescriptionDescrizione" runat="server" Text="Descrizione:" />
                                            </td>
                                            <td class="ListViewItemTabletd2">
                                                <asp:Label ID="FieldValuesDescrizione" runat="server" Text='<%# Eval("DESCRIZIONE") %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </ItemTemplate>
                            <LayoutTemplate>
                                <div id="itemPlaceholderContainer" runat="server" style="">
                                    <span runat="server" id="itemPlaceholder" />
                                </div>                                
                            </LayoutTemplate>
                            <SelectedItemTemplate>
                                <div class="ListViewSelectedItemContainer" onmouseover="this.className='ListViewItemContainerOnMouseOver';" onmouseout="this.className='ListViewSelectedItemContainer';">
                                    <table class="ListViewSelectedItemTable">
                                        <tr>
                                            <td rowspan="4">
                                                <asp:ImageButton ID="lnkSelect" Text="" CommandName="Select" runat="server" ImageUrl="~/images/Toolbar/16/selection_delete.png" />
                                            </td>
                                            <td class="ListViewSelectedItemTabletd1">
                                                <asp:Label ID="FieldDescriptionCodice" runat="server" Text="Codice:" />
                                            </td>
                                            <td class="ListViewSelectedItemTabletd2">
                                                <asp:Label ID="FieldValueCodice" runat="server" Text='<%# Eval("CODICE") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewSelectedItemTabletd1">
                                                <asp:Label ID="FieldDescriptionAttivaPassiva" runat="server" Text="Att/Pass:" />
                                            </td>
                                            <td class="ListViewSelectedItemTabletd2">
                                                <asp:Label ID="FieldValueAttivaPassiva" runat="server" Text='<%# Eval("ATTIVAPASSIVA") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewSelectedItemTabletd1">
                                                <asp:Label ID="FieldDescriptionTipoContratto" runat="server" Text="Tipo Contratto:" />
                                            </td>
                                            <td class="ListViewSelectedItemTabletd2">
                                                <asp:Label ID="FieldValueTipoContratto" runat="server" Text='<%# Eval("TIPOCONTRATTO") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="ListViewSelectedItemTabletd1">
                                                <asp:Label ID="FieldDescriptionDescrizione" runat="server" Text="Descrizione:" />
                                            </td>
                                            <td class="ListViewSelectedItemTabletd2">
                                                <asp:Label ID="FieldValuesDescrizione" runat="server" Text='<%# Eval("DESCRIZIONE") %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </SelectedItemTemplate>
                        </asp:ListView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="pnlListViewContent" CssClass="pnlListViewContent" runat="server">
            <asp:Panel ID="pnlListViewContentTop" CssClass="pnlListViewContentTop" runat="server">
                <table id="table1" class="tableGridContainer">
                    <tr>
                        <td class="TableCaption_td">
                            <iwc:IboWebLabel ID="lblFilialiRiferimento" runat="server" class="lblTestataCaption" IncasTag="" Text="Filiali di Riferimento"
                                  FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <iwc:iboWebToolbar ID="tlbgrdTrasportatoriFiliali" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                            <asp:Panel ID="pnlTrasportatoriFiliali" runat="server" CssClass="DetailFormContainerDiv">
                                <iwc:IboGridView ID="grdTrasportatoriFiliali" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
            <asp:Panel ID="pnlListViewContentCenter" CssClass="pnlListViewContentCenter" runat="server">
                <table id="table2" class="tableGridContainer">
                    <tr>
                        <td class="TableCaption_td">
                            <iwc:IboWebLabel ID="IboWebLabel1" runat="server" class="lblTestataCaption" IncasTag="" Text="Filiali di Riferimento"  
                                FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <iwc:iboWebToolbar ID="IboWebToolbar1" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                            <asp:Panel ID="Panel1" runat="server" CssClass="DetailFormContainerDiv">
                                <iwc:IboGridView ID="IboGridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A"
                                    BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left"
                                    PageSize="20" Width="100%">
                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                    <PagerStyle Font-Size="Small" />
                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                </iwc:IboGridView>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="pnlListViewContentBottom" CssClass="pnlListViewContentBottom" runat="server">
                <table id="table3" class="tableGridContainer">
                    <tr>
                        <td class="TableCaption_td">
                            <iwc:IboWebLabel ID="IboWebLabel2" runat="server" class="lblTestataCaption" IncasTag="" Text="Filiali di Riferimento"  
                                FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <iwc:iboWebToolbar ID="IboWebToolbar2" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                            <asp:Panel ID="Panel2" runat="server" CssClass="DetailFormContainerDiv">
                                <iwc:IboGridView ID="IboGridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#7A7A7A"
                                    BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False" HorizontalAlign="Left"
                                    PageSize="20" Width="100%">
                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                    <PagerStyle Font-Size="Small" />
                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                </iwc:IboGridView>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="pnlFiltro" runat="server" CssClass="popupDiv" Style="display: none">
        <div id="popupFilterTitleBar" class="popupDragBar">
            <iwc:IboWebLabel ID="lblFiltroTitolo" runat="server" IncasTag=""   CssClass="popupTitle" Text="Impostazioni del Filtro"></iwc:IboWebLabel>
        </div>
        <div class="popupContent">
            <table class="popupTable">
                <tr>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroCampoDesc" ID="lblFiltroCampoDesc" Text="Campo" runat="server"></iwc:IboWebLabel>
                    </td>
                    <td>
                        <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroCampo" ID="lblFiltroCampo" Text="Campo" runat="server" Translate="false"></iwc:IboWebLabel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroOperatore" ID="lblFiltroOperatore" Text="Operatore" runat="server"></iwc:IboWebLabel>
                    </td>
                    <td>
                        <asp:DropDownList CssClass="pnlFiltro_ddlFiltroOperatore" ID="ddlFiltroOperatore" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <iwc:IboWebLabel CssClass="pnlFiltro_lblFiltroVal" ID="lblFiltroVal" runat="server" Text="Valore"></iwc:IboWebLabel>
                    </td>
                    <td>
                        <%--<iwc:IboWebNumeric CssClass="pnlFiltro_txtFiltroNumericVal" ID="txtFiltroNumericVal" runat="server" Mask="9999.9" MaskType="FreeMask"
                            Translate="false" Required="false" />--%>
                         <iwc:IboWebNumericTlk runat="server" CssClass="pnlFiltro_txtFiltroNumericVal" ID="txtFiltroNumericVal" Width="100px" MaxValue="99999" MaxLength="7"
                            Required="false" DecimalDigits="1" >
                        </iwc:IboWebNumericTlk>
                        <iwc:IboWebDate CssClass="pnlFiltro_txtFiltroDateVal" ID="txtFiltroDateVal" runat="server" ContainerAlignement="Right" ContainerWidth="450"
                            Translate="false" Required="false" />
                        <iwc:IboWebTextBox CssClass="pnlFiltro_txtFiltroStringVal" ID="txtFiltroStringVal" runat="server" Translate="false" Required="false"></iwc:IboWebTextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div class="popupButtons">
            <iwc:IboWebButton ID="Ibowebbutton1Idle" Text="Conferma" runat="server" Style="display: none;" />
            <iwc:IboWebButton ID="btnFiltroConferma" CssClass="pnlFiltro_btnFiltroConferma" Text="Conferma" runat="server" />
            <iwc:IboWebButton ID="btnFiltroAnnulla" CssClass="pnlFiltro_btnFiltroAnnulla" Text="Esci" runat="server" />
        </div>
    </asp:Panel>
    <ajaxtoolkit:ModalPopupExtender runat="server" ID="popFiltro" TargetControlID="hiddenTargetControlForModalPopup" PopupControlID="pnlFiltro"
        BackgroundCssClass="popupBack" RepositionMode="RepositionOnWindowResize" Drag="True" PopupDragHandleControlID="popupFilterTitleBar">
    </ajaxtoolkit:ModalPopupExtender>
    <!-- Componente invisibile per la gestione del popup -->
    <asp:Button runat="server" ID="hiddenTargetControlForModalPopup" Style="display: none" />
    <!-- Stato visibilità della toolbar proveniente dalla master page -->
    <asp:HiddenField ID="hidToolbarVisible" runat="server" Value="True" />
</asp:Content>
