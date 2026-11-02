<%@ Page Title="Gestione tabella Allgrd" Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFAllGrd.aspx.vb" Inherits="Incasbo.Web.CFG.WFAllGrd" %>

<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="IboGridView" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/WFI/Componenti/IboWebDate.ascx" TagName="IboWebDate" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebNumeric.ascx" TagName="IboWebNumeric" TagPrefix="iwc" %>
<%@ Register Src="~/WFI/Componenti/IboWebToolbar.ascx" TagName="iboWebToolbar" TagPrefix="iwc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/DetailForm-min.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phPageContent" runat="server">
    <asp:Panel ID="DetailFormMainDiv" runat="server" align="center">
        <table class="DetailFormMainTable">
            <tr align="left">
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
            <tr align="left">
                <td>
                    <div class="DetailFormSectionDiv">
                        <asp:Panel runat="server" ID="pnlMain" Width="750px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblNomRif" runat="server" IncasTag="" Text="Rif. Griglia:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtNomRif" runat="server" CharacterCase="Uppercase"
                                                    MaxLength="30" Width="200px" Required="True"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDesTab" runat="server" IncasTag=""
                                                    Text="Descrizione griglia:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDesTab" runat="server" CharacterCase="Uppercase"
                                                    MaxLength="255" Width="600px" Required="True"></iwc:IboWebTextBox><br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNomTab" runat="server" IncasTag=""
                                                    Text="Nome Tabella/Vista:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbNomTab" runat="server" IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_ELENCOTABELLE" Width="410px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE" CampoDescrizione="DESCRIZIONE" AutoLoadOnDemand="true" Required="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblObjectManagerName" runat="server" IncasTag="" Text="Object Manager:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbObjectManagerName" runat="server"
                                                    AutoPostBack="False" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_OBJECTMANAGER"
                                                    Width="450px" Required="True" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE">
                                                </iwc:IboDropDownList>
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblMinFil" runat="server" IncasTag="" Text="Mini Filtro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optMinFil" runat="server"
                                                    RepeatDirection="Horizontal" Translate="False" IncasTag="" Height="25px">
                                                    <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCanSel" runat="server" IncasTag=""
                                                    Text="Attiva selezione riga:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optCanSel" runat="server"
                                                    RepeatDirection="Horizontal" Translate="False" IncasTag="" Height="25px">
                                                    <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblRowsPerPage" runat="server" IncasTag=""
                                                    Text="Righe per pagina:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtRowsPerPage" runat="server" Width="270" MaskType="IntegerMask" Mask="999" MaxValue="9999" MinValue="0"
                                                    ValidationErrorMessage="gggg" ValidationEmptyValueMessage="*"></iwc:IboWebNumeric>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFiltro" runat="server" IncasTag="" Text="Filtro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtFiltro" runat="server" CharacterCase="Uppercase"
                                                    MaxLength="255" Width="600px"></iwc:IboWebTextBox><br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFiltroUtenteObbligatorio" runat="server" IncasTag=""
                                                    Text="Italic:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optFiltroUtenteObbligatorio" runat="server"
                                                    RepeatDirection="Horizontal" Translate="False"
                                                    IncasTag="" Height="25px">
                                                    <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="No" Selected="True"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpInfoGen_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image"
                                    TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpFontColori_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpFontColori_Title_Caption" Text="Font e Colori" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpFontColori_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpFontColori_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblBackColor" runat="server" IncasTag="" Text="BackColor:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtBackColor" Color="" runat="server" AutoPostBack="False" PopupPosition="BottomRight" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblForColor" runat="server" IncasTag="" Text="ForeColor:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtForColor" Color="" runat="server" AutoPostBack="False" PopupPosition="BottomRight" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblBorderColor" runat="server" IncasTag="" Text="BorderColor:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtBorderColor" runat="server" AutoPostBack="False" Color="" PopupPosition="BottomRight" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblBold" runat="server" IncasTag="" Text="Grassetto:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optBold" runat="server" Height="25px" IncasTag="" RepeatDirection="Horizontal" Translate="False">
                                                    <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblItalic" runat="server" IncasTag="" Text="Italic:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optItalic" runat="server" RepeatDirection="Horizontal" Translate="False" IncasTag="" Height="25px">
                                                    <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFontSize" runat="server" IncasTag="" Text="Dimensione carattere:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtFontSize" runat="server" Mask="999" MaskType="IntegerMask" MaxValue="9999" MinValue="0" ValidationEmptyValueMessage="*"
                                                    ValidationErrorMessage="gggg" Width="270" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFontName" runat="server" IncasTag="" Text="Nome del font:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtFontName" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="300px"></iwc:IboWebTextBox>
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCaptionBackColor" runat="server" IncasTag="" Text="Caption BackColor:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtCaptionBackColor" runat="server" AutoPostBack="False" Color="" PopupPosition="BottomRight" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCaptionForColor" runat="server" IncasTag="" Text="Caption ForeColor:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtCaptionForColor" Color="" runat="server" AutoPostBack="False" PopupPosition="BottomRight" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCaptionBold" runat="server" IncasTag="" Text="Caption Grassetto:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optCaptionBold" runat="server" Height="25px" IncasTag="" RepeatDirection="Horizontal" Translate="False">
                                                    <asp:ListItem Selected="True" Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCaptionItalic" runat="server" IncasTag="" Text="Caption Italic:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optCaptionItalic" runat="server" RepeatDirection="Horizontal" Translate="False" IncasTag=""
                                                    Height="25px">
                                                    <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCaptionFontSize" runat="server" IncasTag="" Text="Dimensione carattere Caption:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtCaptionFontSize" runat="server" Mask="999" MaskType="IntegerMask" MaxValue="9999" MinValue="0"
                                                    ValidationEmptyValueMessage="*" ValidationErrorMessage="gggg" Width="270" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCaptionFontName" runat="server" IncasTag="" Text="Nome font della Caption:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtCaptionFontName" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="300px"></iwc:IboWebTextBox>
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPrefiltro" runat="server" IncasTag="" Text="Prefiltro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optPrefiltro" runat="server" Height="25px" IncasTag="" RepeatDirection="Horizontal" Translate="False">
                                                    <asp:ListItem Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Selected="True" Text="No" Value="N"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCanPage" runat="server" IncasTag="" Text="Paginazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optCanPage" runat="server" RepeatDirection="Horizontal" Translate="False" IncasTag="" Height="25px">
                                                    <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCanSort" runat="server" IncasTag="" Text="Colonne Ordinabili:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optCanSort" runat="server" RepeatDirection="Horizontal" Translate="False" IncasTag="" Height="25px">
                                                    <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpFontColori" runat="server" CollapseControlID="cpFontColori_Title" Collapsed="True"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpFontColori_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpFontColori_Title_Image"
                                    TargetControlID="cpFontColori_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpStili_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpStili_Title_Caption" Text="Stili grafici" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpStili_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpStili_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblHeaderStyle" runat="server" IncasTag="" Text="Stile intestazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbHeaderStyle" runat="server" AutoPostBack="True" CampoCodice="STYLENAME" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_TABSTYLESET" Width="500px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblPagerStyle" runat="server" IncasTag="" Text="Stile paginatore:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbPagerStyle" runat="server" AutoPostBack="True" CampoCodice="STYLENAME" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_TABSTYLESET" Width="500px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblRowStyle" runat="server" IncasTag="" Text="Stile Riga:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbRowStyle" runat="server" AutoPostBack="True" CampoCodice="STYLENAME" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_TABSTYLESET" Width="500px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblAlternatingRowStyle" runat="server" IncasTag="" Text="Stile Riga alternato:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbAlternatingRowStyle" runat="server" AutoPostBack="True" CampoCodice="STYLENAME" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_TABSTYLESET" Width="500px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblSelectedRowStyle" runat="server" IncasTag="" Text="Stile Riga selezionata:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbSelectedRowStyle" runat="server" AutoPostBack="True" CampoCodice="STYLENAME" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_TABSTYLESET" Width="500px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px">
                                                <iwc:IboWebLabel ID="lblHighLightedRowStyle" runat="server" IncasTag="" Text="Stile Riga selezionata:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbHighLightedRowStyle" runat="server" AutoPostBack="True" CampoCodice="STYLENAME" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_TABSTYLESET" Width="500px" SqlQueryFilter=""
                                                    SqlQueryOrderBy="DESCRIZIONE">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpStili" runat="server" CollapseControlID="cpStili_Title" Collapsed="True"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpStili_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpStili_Title_Image"
                                    TargetControlID="cpStili_Body">
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
