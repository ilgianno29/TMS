<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFCFGUtenti_Organizzazioni2.aspx.vb" Inherits="Incasbo.Web.CFG.WFCFGUtenti_Organizzazioni2" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
    <link rel="stylesheet" href="../Css/WFUtenti.css" type="text/css" />
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
                        <asp:Panel runat="server" ID="pnlMain" Width="1000px">
                            <ajaxtoolkit:TabContainer ID="TcMain" runat="server" ActiveTabIndex="0" OnDemand="false" AutoPostBack="false"
                                TabStripPlacement="Top" CssClass="WFITab" ScrollBars="Auto" UseVerticalStripPlacement="true" VerticalStripWidth="100px">
                                <ajaxtoolkit:TabPanel ID="tpGen" runat="server" Enabled="true" ScrollBars="Auto">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpGenCaption" Text="Generale"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                                <table class="DetailFormSectionTable">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                            <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Organizzazione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 150px;">
                                                            <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Required="True"
                                                                FieldName="Codice"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell" style="width: 150px;">
                                                            <iwc:IboWebLabel ID="lblOrganizzazioneInternaEsterna" runat="server" IncasTag="" Text="Organizzazione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebRadioButtonList ID="optOrganizzazioneInternaEsterna" runat="server" AutoPostBack="True" RepeatDirection="Horizontal"
                                                                IncasTag="" FieldName="OrganizzazioneInternaEsterna">
                                                                <asp:ListItem Value="I" Text="Interna" Selected="True"></asp:ListItem>
                                                                <asp:ListItem Value="E" Text="Esterna"></asp:ListItem>
                                                            </iwc:IboWebRadioButtonList>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblAttivo" runat="server" IncasTag="" Text="Attivo:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebCheckBox ID="chkAttivo" runat="server" IncasTag="" Checked="True" Value="S" FieldName="Attivo">
                                                            </iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" colspan="3">
                                                            <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px"
                                                                Required="True" FieldName="Descrizione"></iwc:IboWebTextBox>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblFiltroUtente" runat="server" IncasTag="" Text="Filtro Utente:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebCheckBox ID="chkFiltroUtente" runat="server" IncasTag="" FieldName="FiltroUtente"></iwc:IboWebCheckBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblPeso" runat="server" Text="Peso:" IncasTag=""></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell">
                                                            <iwc:IboWebNumericTlk runat="server" ID="txtPeso" MaxValue="100" MinValue="0" Width="40px" DecimalDigits="0"
                                                                FieldName="Peso" Required="True" Value="0" WFIMaxValue="999999999" WFIMinValue="0" 
                                                                Culture="it-IT" DbValueFactor="1" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedSkins="False" 
                                                                EnableSingleInputRendering="False" LabelCssClass="" LabelWidth="">
                                                                <NumberFormat GroupSeparator="" KeepTrailingZerosOnFocus="True" ZeroPattern="n" />
                                                            </iwc:IboWebNumericTlk>
                                                        </td>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblLingua" runat="server" IncasTag="" Text="Lingua:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" colspan="3">
                                                            <iwc:IboDropDownList ID="cmbLingua" runat="server" CharacterCase="Uppercase" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_LINGUE"
                                                                Width="200px" Required="True" FieldName="Lingua" Translate="True">
                                                            </iwc:IboDropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblFiltro" runat="server" IncasTag="" Text="Filtro:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" colspan="5">
                                                            <iwc:IboWebTextBox ID="txtFiltro" runat="server" MaxLength="1024" TextMode="MultiLine" CharacterCase="Uppercase"
                                                                Width="600px" FieldName="Filtro" Rows="3"></iwc:IboWebTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell">
                                                            <iwc:IboWebLabel ID="lblOrganizzazioneTipoSoggetto" runat="server" IncasTag="" Text="Tipo Organizz.:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" colspan="5">
                                                            <iwc:IboDropDownList ID="cmbOrganizzazioneTipoSoggetto" runat="server" CharacterCase="Uppercase" IncasTag=""
                                                                SqlQuery="SELECT * FROM CBO_WFI_TIPIORGANIZZAZIONE" Width="400px" Required="True" FieldName="OrganizzazioneTipoSoggetto"
                                                                AutoPostBack="True" Enabled="False" Translate="True">
                                                            </iwc:IboDropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <iwc:IboWebTextBox ID="txtTipo" runat="server" CssClass="hidden" FieldName="Tipo" 
                                                    CharacterCase="Uppercase"></iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="Gruppo" runat="server" CssClass="hidden" CharacterCase="Uppercase" ></iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtPassword" runat="server" CssClass="hidden" FieldName="Password" 
                                                    Text="123456789" CharacterCase="Uppercase"></iwc:IboWebTextBox>
                                            </asp:Panel>
                                            <ajaxtoolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title"
                                                CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True"
                                                ExpandControlID="cpInfoGen_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details"
                                                ImageControlID="cpInfoGen_Title_Image" TargetControlID="cpInfoGen_Body">
                                            </ajaxtoolkit:CollapsiblePanelExtender>
                                            <asp:Panel runat="server" ID="cpSoggetti_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpSoggetti_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                <asp:Image runat="server" ID="cpSoggetti_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpSoggetti_Body" CssClass="CollapsiblePanelBody" Enabled="False">
                                                <table class="DetailFormSectionTable">
                                                    <tr>
                                                        <td class="DetailFormDescriptionCell" style="width: 150px;">
                                                            <iwc:IboWebLabel ID="lblSoggettoDestinazione" runat="server" IncasTag="" Text="Destinazione:" Visible="False"></iwc:IboWebLabel>
                                                            <iwc:IboWebLabel ID="lblSoggettoCliente" runat="server" IncasTag="" Text="Cliente:" Visible="False"></iwc:IboWebLabel>
                                                            <iwc:IboWebLabel ID="lblSoggettoTrasportatore" runat="server" IncasTag="" Text="Trasportatore:" Visible="False"></iwc:IboWebLabel>
                                                            <iwc:IboWebLabel ID="lblSoggetto" runat="server" IncasTag="" Text="Soggetto:"></iwc:IboWebLabel>
                                                        </td>
                                                        <td class="DetailFormValueCell" style="width: 610px;">
                                                            <iwc:IboWebComboTlk ID="Destinazione" runat="server" SqlQuery="SELECT * FROM CBO_WFI_DESTINATARI" Width="600px" AutoLoadOnDemand="True">
                                                            </iwc:IboWebComboTlk>
                                                            <iwc:IboWebComboTlk ID="Cliente" runat="server" SqlQuery="SELECT * FROM CBO_WFI_CLIENTI" Width="600px" Visible="False" AutoLoadOnDemand="True">
                                                            </iwc:IboWebComboTlk>
                                                            <iwc:IboWebComboTlk ID="Trasportatore" runat="server" SqlQuery="SELECT * FROM CBO_WFI_TRASPORTATORI" Width="600px" Visible="False" AutoLoadOnDemand="True" >
                                                            </iwc:IboWebComboTlk>
                                                        </td>
                                                        <td class="DetailFormBottonPlusCell" style="text-align: left;">                                                           
                                                            <iwc:IboWebButton ID="btnAggiungi" runat="server" CssClass="BottoneAggiungiSoggetto" IncasTag="" 
                                                            ToolTip="Aggiungi soggetto a organizzazione"/>                                                          
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <asp:Panel ID="pnlSoggettiDestinazione" runat="server">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <iwc:iboWebToolbar ID="tlbgrdDestinazioni" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            <asp:Panel ID="pnlDestinazioni" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                                <iwc:IboGridView ID="grdDestinazioni" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                                    HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True" FieldSortingDirection="">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </asp:Panel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                            <asp:Panel ID="pnlSoggettiClienti" Visible="False" runat="server">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <iwc:iboWebToolbar ID="tlbgrdClienti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            <asp:Panel ID="pnlClienti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                                <iwc:IboGridView ID="grdClienti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                                    HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True" FieldSortingDirection="">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </asp:Panel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                            <asp:Panel ID="pnlSoggettiTrasportatori" Visible="False" runat="server">
                                                                <table class="tableGridContainer">
                                                                    <tr>
                                                                        <td>
                                                                            <iwc:iboWebToolbar ID="tlbgrdTrasportatori" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                                            <asp:Panel ID="pnlTrasportatori" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                                <iwc:IboGridView ID="grdTrasportatori" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                                    HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True" FieldSortingDirection="">
                                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                                    <PagerStyle Font-Size="Small" />
                                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                                </iwc:IboGridView>
                                                                            </asp:Panel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <ajaxtoolkit:CollapsiblePanelExtender ID="cpSoggetti" runat="server" CollapseControlID="cpSoggetti_Title"
                                                CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True"
                                                ExpandControlID="cpSoggetti_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details"
                                                ImageControlID="cpSoggetti_Title_Image" TargetControlID="cpSoggetti_Body">
                                            </ajaxtoolkit:CollapsiblePanelExtender>
                                        </div>
                                    </ContentTemplate>
                                </ajaxtoolkit:TabPanel>
                                <ajaxtoolkit:TabPanel ID="tpDoc" runat="server" Enabled="true" ScrollBars="Auto">
                                    <HeaderTemplate>
                                        <iwc:IboWebLabel runat="server" ID="tpDocCaption" Text="Utenti"></iwc:IboWebLabel>
                                    </HeaderTemplate>
                                    <ContentTemplate>
                                        <div class="DetailFormContainerDivCollapsiblePanel">
                                            <asp:Panel runat="server" ID="cpGruppi_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpGruppi_Title_Caption" Text="Gruppi" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                <asp:Image runat="server" ID="cpGruppi_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpGruppi_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdGruppi" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <asp:Panel ID="pnlGruppi" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                <iwc:IboGridView ID="grdGruppi" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                                                                    BorderColor="#7A7A7A" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Top" CellPadding="2" ColumnsResizable="False"
                                                                    HorizontalAlign="Left" PageSize="20" Width="100%" EnableSelectionAutoPostBack="True">
                                                                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                                                                    <PagerStyle Font-Size="Small" />
                                                                    <RowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="20px" HorizontalAlign="Left" />
                                                                </iwc:IboGridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                            <ajaxtoolkit:CollapsiblePanelExtender ID="cpGruppi" runat="server" CollapseControlID="cpGruppi_Title"
                                                Collapsed="false" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                                Enabled="True" ExpandControlID="cpGruppi_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                                ExpandedText="Hide Details" ImageControlID="cpGruppi_Title_Image" TargetControlID="cpGruppi_Body">
                                            </ajaxtoolkit:CollapsiblePanelExtender>
                                            <asp:Panel runat="server" ID="cpUtenti_Title" CssClass="CollapsiblePanelTitle">
                                                <asp:Label runat="server" ID="cpUtenti_Title_Caption" Text="Utenti" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                                <asp:Image runat="server" ID="cpUtenti_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                            </asp:Panel>
                                            <asp:Panel runat="server" ID="cpUtenti_Body" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                                <table class="tableGridContainer">
                                                    <tr>
                                                        <td>
                                                            <iwc:iboWebToolbar ID="tlbgrdUtenti" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15"
                                                                SeparatorHeight="24" CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                            <asp:Panel ID="pnlUtenti" runat="server" CssClass="DetailFormGridContainerDiv">
                                                                <iwc:IboGridView ID="grdUtenti" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                            <ajaxtoolkit:CollapsiblePanelExtender ID="cpUtenti" runat="server" CollapseControlID="cpUtenti_Title"
                                                Collapsed="false" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                                Enabled="True" ExpandControlID="cpUtenti_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                                ExpandedText="Hide Details" ImageControlID="cpUtenti_Title_Image" TargetControlID="cpUtenti_Body">
                                            </ajaxtoolkit:CollapsiblePanelExtender>
                                        </div>
                                    </ContentTemplate>
                                </ajaxtoolkit:TabPanel>
                            </ajaxtoolkit:TabContainer>
                        </asp:Panel>
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel" style="margin-left: 100px;">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:IboWebButton ID="btnAnnulla" runat="server" Text="Esci" CssClass="DetailFormButton_Cancel" CausesValidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C">
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
