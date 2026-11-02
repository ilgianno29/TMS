<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFUtentiAdmin.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFUtentiAdmin" %>

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
    <asp:Panel ID="DetailFormMainDiv" runat="server" CssClass="DetailFormMainDiv">
        <table class="DetailFormMainTable">
            <tr>
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
            <tr>
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
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblCodice" runat="server" IncasTag="" Text="Codice Utente:"
                                                     ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtCodice" runat="server" CharacterCase="Uppercase"
                                                    MaxLength="15" Required="true" ></iwc:IboWebTextBox>
                                            </td>
                                             <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblAttivo" runat="server" IncasTag="" 
                                                    Text="Attivo:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">                                               
                                                <iwc:IboWebCheckBox ID="chkAttivo" runat="server" IncasTag="" Checked="True" Value="S" FieldName="Attivo"
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebCheckBox>                                           
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Descrizione Utente:"
                                                     ></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebTextBox ID="txtDescrizione" runat="server" CharacterCase="Uppercase"
                                                    MaxLength="60" Width="600px" Required="true"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>                                                                              
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblTipo" runat="server" IncasTag="" 
                                                    Text="Tipo:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebRadioButtonList ID="optTipo" runat="server" RepeatDirection="Horizontal"
                                                    IncasTag="" FocusedBackColor="" 
                                                    ValidationRules="None">
                                                    <asp:ListItem Value="U" Text="Utente" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="G" Text="Gruppo"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblGruppo" runat="server" IncasTag="" 
                                                    Text="Gruppo:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboDropDownList ID="cmbGruppo" runat="server" CharacterCase="Uppercase" IncasTag=""
                                                    SqlQuery="SELECT * FROM CBO_WFI_GRUPPI" Width="600px" SqlQueryFilter="" FocusedBackColor=""
                                                    ValidationRules="None"  >
                                                </iwc:IboDropDownList>                                              
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPeso" runat="server" Text="Peso:" IncasTag="" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtPeso" runat="server"  MaskType="FreeMask" 
                                                        MinValue="0"  MaxValue="100"  Required="True" Mask="999" Width="30px"/>                                               
                                            </td>                                        
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblLingua" runat="server" IncasTag="" 
                                                    Text="Lingua:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                               <iwc:IboDropDownList ID="cmbLingua" runat="server" CharacterCase="Uppercase"  IncasTag=""
                                                    SqlQuery="SELECT * FROM CBO_WFI_LINGUE"  Width="200px" SqlQueryFilter="" FocusedBackColor=""
                                                    ValidationRules="None" Required="true"  >
                                                </iwc:IboDropDownList>                                                
                                            </td>
                                        </tr> 
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPassword" runat="server" IncasTag="" 
                                                    Text="Password:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" >
                                                <iwc:IboWebTextBox ID="txtPassword" runat="server" MaxLength="15" Width="150px" 
                                                    CharacterCase="Uppercase" FocusedBackColor="" 
                                                    FieldName="Password" ValidationRules="None" Required="True"></iwc:IboWebTextBox>
                                            </td>                                       
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblGiorniValiditaPwd" runat="server" IncasTag=""
                                                    Text="Giorni Validità Password:" FocusedBackColor="" 
                                                    ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                 <iwc:IboWebNumeric ID="txtGiorniValiditaPwd" runat="server"  MaskType="FreeMask" 
                                                        MinValue="0"  MaxValue="9999"  Required="True" Mask="9999" Width="50px"/>   
                                            </td>                         
                                        </tr>
                                      <%--  <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblScadenzaPwd" runat="server" IncasTag=""
                                                    Text="Scadenza Password:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            
                                        </tr>--%>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblFiltro" runat="server" IncasTag="" 
                                                    Text="Filtro:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebTextBox ID="txtFiltro" runat="server"  MaxLength="1024"
                                                    TextMode="MultiLine" CharacterCase="Uppercase" Width="600px" 
                                                    FocusedBackColor="" FieldName="Filtro" ValidationRules="None" Rows="3"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPaginaIniziale" runat="server" IncasTag=""
                                                    Text="Pagina Iniziale:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebTextBox ID="txtPaginaIniziale" runat="server" MaxLength="255" 
                                                    CharacterCase="Uppercase" Width="600px" FocusedBackColor="" 
                                                    FieldName="PaginaIniziale" ValidationRules="None"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>                                       
                                    </table>                                  
                                    <iwc:IboWebDate ID="txtScadenzaPassword" runat="server" Width="90px" 
                                        Display="False"></iwc:IboWebDate>                                   
                                </asp:Panel>
                                <ajaxtoolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title" Collapsed="False"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpInfoGen_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image"
                                    TargetControlID="cpInfoGen_Body">
                                </ajaxtoolkit:CollapsiblePanelExtender>        
                                
                                                                  
                                <asp:Panel runat="server" ID="cpInfoUte_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoUte_Title_Caption" Text="Informazioni Utente" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpInfoUte_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoUte_Body" CssClass="CollapsiblePanelBody"> 
                                    <table class="DetailFormSectionTable">        
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:IboWebLabel ID="lblNome" runat="server" IncasTag=""   Text="Nome:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtNome" runat="server" MaxLength="60" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCognome" runat="server" IncasTag=""   Text="Cognome:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtCognome" runat="server" MaxLength="60" Width="600px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" >
                                                <iwc:IboWebLabel ID="lblIndirizzo" runat="server" IncasTag="" Text="Indirizzo:"
                                                      FocusedBackColor=""></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtIndirizzo" runat="server" CharacterCase="Uppercase"
                                                    FocusedBackColor="" MaxLength="60" ValidationRules="None" Width="600px" ToolTip="Indirizzo (via, piazza, ...)">
                                                </iwc:IboWebTextBox>                                                
                                            </td>                                           
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtCap" runat="server" CharacterCase="Uppercase"
                                                    FocusedBackColor="" MaxLength="10" Width="55px" ToolTip="Cap">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtLocalita" runat="server" CharacterCase="Uppercase"
                                                    FocusedBackColor="" MaxLength="60" Width="450px" ToolTip="Località" >
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtProvincia" runat="server" CharacterCase="Uppercase"
                                                    FocusedBackColor="" MaxLength="3" Width="30px" ToolTip="Provincia">
                                                </iwc:IboWebTextBox>
                                                <iwc:IboWebTextBox ID="txtNazione" runat="server" CharacterCase="Uppercase"
                                                    FocusedBackColor="" MaxLength="6" Width="40px" ToolTip="Nazione" >
                                                </iwc:IboWebTextBox>
                                            </td>                                           
                                        </tr>   
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblTelefono" runat="server" IncasTag=""   Text="Telefono:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtTelefono" runat="server" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>                                       
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCellulare" runat="server" IncasTag=""   Text="Cellulare:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="5">
                                                <iwc:IboWebTextBox ID="txtCellulare" runat="server" MaxLength="15" Width="150px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblMail" runat="server" IncasTag=""   Text="E-Mail:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="7">
                                                <iwc:IboWebTextBox ID="txtEMail" runat="server" MaxLength="255" CharacterCase="None" Width="600px" ValidationRules="Email"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table> 
                                </asp:Panel>
                                <ajaxtoolkit:CollapsiblePanelExtender ID="cpInfoUte" runat="server" CollapseControlID="cpInfoUte_Title" Collapsed="True"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpInfoUte_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpInfoUte_Title_Image"
                                    TargetControlID="cpInfoUte_Body">
                                </ajaxtoolkit:CollapsiblePanelExtender>  

                                <asp:Panel ID="cpFiliali_Title" runat="server" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel ID="cpFiliali_Title_Caption" runat="server" CssClass="CollapsiblePanelTitleCaption" Text="Filiali"></iwc:IboWebLabel>
                                    <asp:Image ID="cpFiliali_Title_Image" runat="server" CssClass="CollapsiblePanelTitleImage" ImageUrl="~/images/collapse.png" />
                                </asp:Panel>
                                <asp:Panel ID="cpFiliali_Body" runat="server" CssClass="CollapsiblePanelBody CollapsiblePanelBodyGrid">
                                    <table class="tableGridContainer">
                                        <tr>
                                            <td>
                                                <iwc:iboWebToolbar ID="tlbgrdUtentiFiliali" runat="server" ButtonHeight="24" ButtonWidth="24" SeparatorWidth="15" SeparatorHeight="24"
                                                    CssClassButton="ToolbarButton" CssClassPanel="ToolbarPanel" CssClassTable="ToolbarTable" />
                                                <asp:Panel ID="pnlUtentiFiliali" runat="server" CssClass="DetailFormGridContainerDiv">
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
                                <ajaxtoolkit:CollapsiblePanelExtender ID="cpFiliali" runat="server" CollapseControlID="cpFiliali_Title" Collapsed="true"
                                    CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..." Enabled="True" ExpandControlID="cpFiliali_Title"
                                    ExpandedImage="~/images/collapse.png" ExpandedSize="0" ExpandedText="Hide Details" ImageControlID="cpFiliali_Title_Image"
                                    TargetControlID="cpFiliali_Body">
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
