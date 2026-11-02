<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFANAVociApplicabilita.aspx.vb" Inherits="Incasbo.Web.GDO.WFANAVociApplicabilita" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="850px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <%--   <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />--%>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Codice:" Width="100px" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 500px">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="100px"
                                                    Required="True" ></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 80px">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" IncasTag="" Text="Attivo:" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" IncasTag="" Checked="True" Value="S" ></iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione:" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >
                                                <iwc:IboWebTextBox ID="txtDescrizione" Required="True" runat="server" CharacterCase="Uppercase" MaxLength="60"
                                                    Width="600px" ></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="IblTabella" runat="server" IncasTag="" Text="Tabella:" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >                                                
                                                <iwc:IboWebComboTlk ID="cmbTabella" runat="server" Required="false" SqlQuery="SELECT * FROM CBO_ANA_ELENCOTABELLEVOCIAPP" Width="607px" AutoPostBack="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="IblCampoOperatore" runat="server" IncasTag="" Text="Campo/Operatore:" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:IboWebComboTlk ID="cmbCampo" runat="server" Required="true" SqlQuery="SELECT * FROM CBO_ANA_ELENCOCAMPITABELLA1"
                                                    Width="395px" SqlQueryWhere ="1=2" AutoPostBack="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 210px">                                                
                                                <iwc:IboWebComboTlk ID="cmbOperatore" runat="server" Required="false" SqlQuery="SELECT * FROM CBO_ANA_OPERATORI"
                                                    Width="203px" >
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="IblValore" runat="server" IncasTag="" Text="Valore:" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >
                                                <iwc:IboWebTextBox ID="txtValore" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="600px"
                                                    ></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipoRaggruppamento" runat="server" IncasTag="" Text="Tipo Raggr.:" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >
                                                <iwc:IboWebRadioButtonList ID="optTipoApplicabilita" runat="server" IncasTag="" RepeatDirection="Horizontal"
                                                    Required="True">
                                                    <asp:ListItem Selected="True" Text="Condizione verificata per TUTTI gli elementi" Value="1"></asp:ListItem>
                                                    <asp:ListItem Text="Condizione verificata per ALMENO un elemento" Value="2"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblTipocampo" runat="server" IncasTag="" Text="Tipo Campo:" Width="100px" ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >
                                                <iwc:IboWebTextBox ID="txtTipoCampo" runat="server" CharacterCase="Uppercase" MaxLength="6" Width="100px"
                                                    Required="True"  Enabled="False"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                               <%-- <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title"
                                    Collapsed="False" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="True" ExpandControlID="cpInfoGen_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image" TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>--%>
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
