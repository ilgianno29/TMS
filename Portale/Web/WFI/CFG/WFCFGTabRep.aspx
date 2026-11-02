<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFCFGTabRep.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFCFGTabRep" %>

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
                                    <iwc:IboWebLabel ID="lblTitle" runat="server"   Text="Titolo Form" IncasTag=""></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:IboWebLabel ID="lblDataAccessMode" runat="server"   Text="Modalità"></iwc:IboWebLabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c3">
                               <div class="DetailFormModeImageDiv">
                                    <asp:Image ID="imgModalita" runat="server"/>
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
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNomRep" runat="server" IncasTag="" Text="Nome Report:"  
                                                    Width="100px" FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtNomRep" runat="server" CharacterCase="Uppercase" MaxLength="30"
                                                    Required="True" Width="400px" FocusedBackColor=""></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDesRep" runat="server" IncasTag="" Text="Descrizione:" 
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDesRep" runat="server" CharacterCase="Uppercase" MaxLength="255"
                                                    Width="600px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCapRep" runat="server" IncasTag="" Text="Caption:" 
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtCapRep" runat="server" CharacterCase="None" MaxLength="255"
                                                    Width="600px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNomTab" runat="server" IncasTag="" Text="Tabella:" 
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbNomTab" runat="server" AutoPostBack="True" CharacterCase="Uppercase"
                                                     IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_ELENCOTABELLE WHERE DESCRIZIONE LIKE 'RPT%'"
                                                    Width="500px" Required="True" SqlQueryFilter="" 
                                                    SqlQueryOrderBy="DESCRIZIONE" FocusedBackColor=""></iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPagOrn" runat="server" IncasTag="" Text="Orientamento:" 
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtPagOrn" runat="server" CharacterCase="Uppercase" MaxLength="1"
                                                    Width="100px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPagDim" runat="server" IncasTag="" Text="Dimensione:" 
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtPagDim" runat="server" CharacterCase="Uppercase" MaxLength="60"
                                                    Width="400px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblProgramma" runat="server" IncasTag="" Text="Programma:" 
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtProgramma" runat="server" CharacterCase="Uppercase" MaxLength="3"
                                                    Width="100px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblSelezioneDefault" runat="server" IncasTag="" Text="Selezione:"
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtSelezioneDefault" runat="server" CharacterCase="Uppercase"
                                                    MaxLength="256" Width="600px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPagAltezza" runat="server" IncasTag="" Text="Altezza:" 
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtPagAltezza" runat="server" Mask="9999" MaskType="IntegerMask"
                                                    MaxValue="9999" MinValue="0" Required="True" Width="270" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPagLarghezza" runat="server" IncasTag="" 
                                                    Text="Larghezza:"   FocusedBackColor=""/>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtPagLarghezza" runat="server" Mask="9999" MaskType="IntegerMask"
                                                    MaxValue="9999" MinValue="0" Required="True" Width="270" />
                                            </td>
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblFiltroGriglia" runat="server" IncasTag="" 
                                                        Text="Filtro:"   FocusedBackColor=""/>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtFiltroGriglia" runat="server" 
                                                        CharacterCase="Uppercase" MaxLength="1"
                                                        Width="100px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="DetailFormDescriptionCell">
                                                    <iwc:IboWebLabel ID="lblReportSelectionFormula" runat="server" IncasTag="" 
                                                        Text="Formula:"   FocusedBackColor=""/>
                                                </td>
                                                <td class="DetailFormValueCell">
                                                    <iwc:IboWebTextBox ID="txtReportSelectionFormula" runat="server" 
                                                        CharacterCase="Uppercase" MaxLength="256"
                                                        Width="600px" Required="True" FocusedBackColor=""></iwc:IboWebTextBox>
                                                </td>
                                            </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxtoolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpInfoGen_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image"
                                    TargetControlID="cpInfoGen_Body">
                                </ajaxtoolkit:CollapsiblePanelExtender>
                            </div>                              
                        </asp:Panel>   
                    </div>
                    <div class="DetailFormCommandsDivCollapsiblePanel">
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
