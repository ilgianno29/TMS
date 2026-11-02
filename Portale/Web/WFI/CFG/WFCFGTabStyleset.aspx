<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFCFGTabStyleset.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFCFGTabStyleset" %>

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
                                    <table class="DetailFormSectionTable2">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 130px">
                                                <iwc:IboWebLabel ID="lblStylename" runat="server" IncasTag="" Text="Nome Stile:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtStylename" runat="server" CharacterCase="Uppercase" MaxLength="15"
                                                    Required="True" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase" MaxLength="255"
                                                    Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblBackColor" runat="server" IncasTag="" Text="Colore di Sfondo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtBackColor" Color="" runat="server" AutoPostBack="False"
                                                    PopupPosition="BottomRight"></iwc:IboWebColorPicker>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblBorderColor" runat="server" IncasTag="" Text="Colore dei Bordi:" />
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtBorderColor" Color="" runat="server" AutoPostBack="False"
                                                    PopupPosition="BottomRight" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCssClass" runat="server" IncasTag="" Text="CSS:" />
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtCssClass" runat="server" CharacterCase="Uppercase" MaxLength="30"
                                                    Width="200px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblBorderWidth" runat="server" IncasTag="" Text="Larghezza Bordi:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtBorderWidth" runat="server" MaskType="DoubleMask"
                                                    MaxValue="9999" MinValue="0" Width="80px"></iwc:IboWebNumeric>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFontBold" runat="server" IncasTag="" Text="Grassetto:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkFontBold" runat="server" IncasTag="" Translate="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFontItalic" runat="server" IncasTag="" Text="Italico:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkFontItalic" runat="server" IncasTag="" Translate="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFontName" runat="server" IncasTag="" Text="CSS:" />
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtFontName" runat="server" CharacterCase="Uppercase" MaxLength="60"
                                                    Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFontUnderline" runat="server" IncasTag="" Text="Italico:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkFontUnderline" runat="server" IncasTag="" Translate="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFontSize" runat="server" IncasTag="" Text="Dimensione carattere:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtFontSize" runat="server" MaskType="DoubleMask"
                                                    MaxValue="9999" MinValue="0" Width="80px"></iwc:IboWebNumeric>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblForColor" runat="server" IncasTag="" Text="Colore primo piano:" />
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebColorPicker ID="txtForColor" Color="" runat="server" AutoPostBack="False"
                                                    PopupPosition="BottomRight" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblHeight" runat="server" IncasTag="" Text="Altezza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtHeight" runat="server" MaskType="DoubleMask"
                                                    MaxValue="9999" MinValue="0" Width="80px"></iwc:IboWebNumeric>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblHorizontalAlign" runat="server" IncasTag="" Text="Allineamento Orizzontale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optHorizontalAlign" runat="server" RepeatDirection="Horizontal"
                                                    Translate="False" IncasTag="" Height="25px">
                                                    <asp:ListItem Value="Left" Text="Sinistra" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="Center" Text="Centrato"></asp:ListItem>
                                                    <asp:ListItem Value="Right" Text="Destra"></asp:ListItem>
                                                    <asp:ListItem Value="Justify" Text="Giustificato"></asp:ListItem>
                                                    <asp:ListItem Value="NotSet" Text="Nessuno"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblVerticalAlign" runat="server" IncasTag="" Text="Allineamento Verticale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optVerticalAlign" runat="server" RepeatDirection="Horizontal"
                                                    Translate="False" IncasTag="" Height="25px">
                                                    <asp:ListItem Value="Top" Text="In alto" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="Middle" Text="Centrato"></asp:ListItem>
                                                    <asp:ListItem Value="Bottom" Text="In basso"></asp:ListItem>
                                                    <asp:ListItem Value="NotSet" Text="Nessuno"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblWidth" runat="server" IncasTag="" Text="Larghezza:" />
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtWidth" runat="server" MaskType="DoubleMask"
                                                    MaxValue="9999" MinValue="0" Width="80px"></iwc:IboWebNumeric>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblWrap" runat="server" IncasTag="" Text="Visibile:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkWrap" runat="server" IncasTag="" Translate="False" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpInfoGen_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image"
                                    TargetControlID="cpInfoGen_Body">
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
