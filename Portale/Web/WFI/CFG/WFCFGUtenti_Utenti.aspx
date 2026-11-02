<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFCFGUtenti_Utenti.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFCFGUtenti_Utenti" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="1100px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <%-- <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" Text="Utente:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 125px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="15" Width="120px" Required="true"></iwc:IboWebTextBox>
                                            </td>

                                            <td class="DetailFormDescriptionCell" style="width: 380px">
                                                <iwc:IboWebLabel ID="lblPeso" runat="server" Text="Peso:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 40px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtPeso" MaxValue="100" MinValue="0" DecimalDigits="0" FieldName="Peso" Required="True"
                                                    Value="0" WFIMaxValue="999999999" WFIMinValue="0" Width="35px">
                                                    <NumberFormat GroupSeparator="" KeepTrailingZerosOnFocus="True" ZeroPattern="n" />
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 60px">
                                                <iwc:IboWebLabel ID="lblLingua" runat="server" Text="Lingua:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 150px">
                                                <iwc:IboDropDownList ID="cmbLingua" runat="server" CharacterCase="Uppercase" SqlQuery="SELECT * FROM CBO_WFI_LINGUE"
                                                    Width="145px" Required="true">
                                                </iwc:IboDropDownList>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 55px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" Text="Attivo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 82px">
                                                <%--<iwc:IboWebCheckBox ID="chkAttivo" runat="server"  Checked="True" Value="S" FieldName="Attivo"></iwc:IboWebCheckBox>--%>
                                                <iwc:IboDropDownList runat="server" ID="cbmAttivo" Width="77px" FieldName="Attivo" Required="true">
                                                    <asp:ListItem Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                    <asp:ListItem Text="Bloccato" Value="B"></asp:ListItem>
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="10">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="400px" Required="true"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblGruppo" runat="server" Text="Gruppo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebComboTlk ID="cmbGruppo" runat="server" SqlQuery="SELECT * FROM CBO_WFI_GRUPPI" Width="100%" Culture="it-IT" CharacterCase="Uppercase" Required="true">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblMenuProfileId" runat="server" Text="Menu:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 407px">
                                                <iwc:IboWebComboTlk ID="cmbMenuProfileId" runat="server" SqlQuery="SELECT * FROM CBO_WFI_Config_Profiles" Width="407px"
                                                    DropDownWidth="550px" FieldDescription="Menù" AutoLoadOnDemand="false">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDesktopProfileId" runat="server" Text="Desktop:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 405px">
                                                <iwc:IboWebComboTlk ID="cmbDesktopProfileId" runat="server" SqlQuery="SELECT * FROM CBO_WFI_Config_Profiles"
                                                    Width="400px" FieldDescription="Desktop" AutoLoadOnDemand="false" DropDownWidth="550px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblPassword" runat="server" Text="Password:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="IboWebLabel2" runat="server" Text="*********"></iwc:IboWebLabel>
                                                <iwc:IboWebTextBox ID="txtPassword" runat="server" MaxLength="15" Visible="False" CharacterCase="None"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormBottonPlusCell" style="text-align: left; width: 30px;">
                                                <%--<iwc:IboWebButton ID="btnGeneraPassword" runat="server" CssClass="BottoneGeneraPassword" ToolTip="Generazione Automatica Password" />--%>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 343px;">
                                                <iwc:IboWebLabel ID="IboWebLabel1" runat="server" Display="false"></iwc:IboWebLabel>
                                                <iwc:IboWebLabel ID="lblGiorniValiditaPwd" runat="server" Text="Giorni di validità:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 55px">
                                                <iwc:IboWebNumericTlk runat="server" ID="txtGiorniValiditaPwd" MaxValue="9999" MinValue="0" Width="50px" DecimalDigits="0"
                                                    FieldName="GiorniValiditaPwd" Required="True" Value="0" WFIMaxValue="999999999" AutoPostBack="true" WFIMinValue="0">
                                                    <NumberFormat GroupSeparator="" KeepTrailingZerosOnFocus="True" ZeroPattern="n" />
                                                </iwc:IboWebNumericTlk>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 70px">
                                                <iwc:IboWebLabel ID="lblScadenzaPassword" runat="server" Text="Scadenza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 120px">
                                                <iwc:IboWebDate ID="txtScadenzaPassword" runat="server" Width="90px" ControlType="DateOnly"></iwc:IboWebDate>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed ">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: top;">
                                                <iwc:IboWebLabel ID="lblFiltro" runat="server" Text="Filtro Manuale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 407px">
                                                <iwc:IboWebTextBox ID="txtFiltro" runat="server" MaxLength="1024" TextMode="MultiLine" CharacterCase="Uppercase" Width="400px"
                                                    FieldName="Filtro" Rows="3"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 100px; vertical-align: top;">
                                                <iwc:IboWebLabel ID="lblPaginaIniziale" runat="server" Text="Pagina Iniziale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 405px; vertical-align: top;">
                                                <iwc:IboWebTextBox ID="txtPaginaIniziale" runat="server" MaxLength="255" CharacterCase="Uppercase" Width="400px" FieldName="PaginaIniziale"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <iwc:IboWebTextBox ID="txtTipo" runat="server" CssClass="hidden" FieldName="Tipo"></iwc:IboWebTextBox>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="false" ExpandControlID="cpInfoGen_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image"
                                    TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpInfoUte_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpInfoUte_Title_Caption" Text="Informazioni Utente" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <%-- <asp:Image runat="server" ID="cpInfoUte_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoUte_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNome" runat="server" Text="Nome:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 165px">
                                                <iwc:IboWebTextBox ID="txtNome" runat="server" MaxLength="60" Width="160px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 65px">
                                                <iwc:IboWebLabel ID="lblCognome" runat="server" Text="Cognome:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 165px">
                                                <iwc:IboWebTextBox ID="txtCognome" runat="server" MaxLength="60" Width="160px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 98px">
                                                <iwc:IboWebLabel ID="lblTelefono" runat="server" Text="Telefono:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 155px">
                                                <iwc:IboWebTextBox ID="txtTelefono" runat="server" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 85px">
                                                <iwc:IboWebLabel ID="lblCellulare" runat="server" Text="Cellulare:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 155px">
                                                <iwc:IboWebTextBox ID="txtCellulare" runat="server" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:IboWebLabel ID="lblIndirizzo" runat="server" Text="Indirizzo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 405px;">
                                                <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="400px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 98px;">
                                                <iwc:IboWebLabel ID="lblMail" runat="server" Text="E-Mail:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 405px;">
                                                <iwc:IboWebTextBox ID="txtEMail" runat="server" MaxLength="255" CharacterCase="None" Width="400px" ValidationRules="Email"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="260px" ToolTip="Località">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtProvincia" runat="server" CharacterCase="Uppercase" MaxLength="3" Width="25px" ToolTip="Provincia">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="25px" ToolTip="Nazione">
                                                </iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoUte" runat="server" CollapseControlID="cpInfoUte_Title" Collapsed="True"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="false" ExpandControlID="cpInfoUte_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoUte_Title_Image"
                                    TargetControlID="cpInfoUte_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel ID="cpFiliali_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpFiliali_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Filiali"></iwc:IboWebLabel>
                                    <%-- <asp:Image ID="cpFiliali_Title_Image" runat="server" CssClass="CollapsiblePanelTitleImage" ImageUrl="~/images/collapse.png" />--%>
                                </asp:Panel>
                                <asp:Panel ID="cpFiliali_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <table class="tableGridContainer">
                                        <tr>
                                            <td>
                                                <iwc:iboWebToolbar ID="tlbgrdUtentiFiliali" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                    CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                <asp:Panel ID="pnlUtentiFiliali" runat="server" CssClass="DetailFormGridContainerDiv" Style="min-height: 100px; max-height: 200px;">
                                                    <iwc:IboGridView ID="grdUtentiFiliali" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
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
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpFiliali" runat="server" CollapseControlID="cpFiliali_Title" Collapsed="true"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="false" ExpandControlID="cpFiliali_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpFiliali_Title_Image"
                                    TargetControlID="cpFiliali_Body">
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
