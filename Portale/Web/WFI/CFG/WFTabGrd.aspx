<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFTabGrd.aspx.vb"
    Inherits="Incasbo.Web.CFG.WFTabGrd" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="900px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable">
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNomRif" runat="server" IncasTag="" Text="ID Griglia:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbNomRif" runat="server" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_ALLGRD" Width="500px"
                                                    Required="True" SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE" 
                                                    FocusedBackColor="" FieldName="NomRif" ValidationRules="None">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblProRig" runat="server" IncasTag="" 
                                                    Text="Prog. Colonna:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtProRig" runat="server" Mask="9999" MaskType="IntegerMask"
                                                    MaxValue="9999" MinValue="0" Required="True" Width="270" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblUtente" runat="server" IncasTag="" Text="Utente:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbUtente" runat="server" AutoPostBack="True" CharacterCase="Uppercase"
                                                   IncasTag="" 
                                                    SqlQuery="SELECT * FROM CBO_WFI_UTENTI" 
                                                    Width="500px" Required="True" SqlQueryFilter="" 
                                                    SqlQueryOrderBy="DESCRIZIONE" FocusedBackColor="" FieldName="Utente" 
                                                    ValidationRules="None">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNomTab" runat="server" IncasTag="" Text="Nome Tabella:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbNomTab" runat="server" AutoPostBack="True" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_ELENCOTABELLE"
                                                    Width="500px" Required="True" SqlQueryFilter="" 
                                                    SqlQueryOrderBy="DESCRIZIONE" FocusedBackColor="" FieldName="NomTab" 
                                                    ValidationRules="None">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNomCam" runat="server" IncasTag="" Text="Nome Campo:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbNomCam" runat="server" AutoPostBack="True" CharacterCase="Uppercase"
                                                     IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_ELENCOCAMPITABELLA"
                                                    Width="500px" Required="True" SqlQueryFilter="" 
                                                    SqlQueryOrderBy="DESCRIZIONE" FocusedBackColor="" FieldName="NomCam" 
                                                    ValidationRules="None">
                                                </iwc:IboDropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDesCam" runat="server" IncasTag="" 
                                                    Text="Descrizione Campo:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDesCam" runat="server" CharacterCase="Uppercase" MaxLength="255"
                                                    Width="600px" FocusedBackColor="" FieldName="DesCam" 
                                                    ValidationRules="None"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    <%--</table>
                                </div>
                            </ContentTemplate>
                        </iwc:IboWebTabPanel>
                        <iwc:IboWebTabPanel runat="server" ID="tabImpostazioni" HeaderText="Impostazioni"
                             >
                            <HeaderTemplate>
                                Impostazioni
                            </HeaderTemplate>
                            <ContentTemplate>
                                <div class="DetailFormContainerDiv400">
                                    <table class="DetailFormSectionTable">--%>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblLarCam" runat="server" IncasTag="" 
                                                    Text="Larghezza (px):" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtLarCam" runat="server" Mask="9999" MaskType="FreeMask"
                                                    MaxValue="9999" MinValue="0" Required="False" Width="270"></iwc:IboWebNumeric>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblHorizontalAlign" runat="server" IncasTag="" 
                                                    Text="Allineamento Orizzontale:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optHorizontalAlign" runat="server" RepeatDirection="Horizontal"
                                                    IncasTag="" Height="25px" FocusedBackColor="" 
                                                    FieldName="HorizontalAlign" ValidationRules="None">
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
                                                <iwc:IboWebLabel ID="lblVerticalAlign" runat="server" IncasTag="" 
                                                    Text="Allineamento Verticale:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optVerticalAlign" runat="server" RepeatDirection="Horizontal"
                                                    IncasTag="" Height="25px" FocusedBackColor="" 
                                                    FieldName="VerticalAlign" ValidationRules="None">
                                                    <asp:ListItem Value="Top" Text="In alto" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="Middle" Text="Centrato"></asp:ListItem>
                                                    <asp:ListItem Value="Bottom" Text="In basso"></asp:ListItem>
                                                    <asp:ListItem Value="NotSet" Text="Nessuno"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblForCam" runat="server" IncasTag="" 
                                                    Text="Formato Campo:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtForCam" runat="server" CharacterCase="Uppercase" MaxLength="50"
                                                    Width="400px" FocusedBackColor="" FieldName="ForCam" 
                                                    ValidationRules="None"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblOrdCam" runat="server" IncasTag="" Text="Ordinamento:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebNumeric ID="txtOrdCam" runat="server" Mask="9999" MaskType="FreeMask"
                                                    MaxValue="9999" MinValue="0" Required="True" Width="270"></iwc:IboWebNumeric>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblOrdDir" runat="server" IncasTag="" 
                                                    Text="Tipo ordinamento:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optOrdDir" runat="server" RepeatDirection="Horizontal"
                                                     IncasTag="" Height="25px" FocusedBackColor="" 
                                                    FieldName="OrdDir" ValidationRules="None">
                                                    <asp:ListItem Value="" Text="Nessuno" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="ASC" Text="Ascendente"></asp:ListItem>
                                                    <asp:ListItem Value="DESC" Text="Discendente"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblVisibile" runat="server" IncasTag="" Text="Visibile:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">                                                
                                                <iwc:IboWebRadioButtonList ID="optVisibile" runat="server" RepeatDirection="Horizontal"
	                                                 IncasTag="" Height="25px" FocusedBackColor="" 
	                                                FieldName="Visibile" ValidationRules="None">
	                                                <asp:ListItem Value="S" Text="Si" Selected="True"></asp:ListItem>
	                                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
	                                                <asp:ListItem Value="H" Text="Hidden"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblIsKey" runat="server" IncasTag="" Text="Chiave:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optIsKey" runat="server" Height="25px" 
                                                    IncasTag="" RepeatDirection="Horizontal" Translate="False" 
                                                    FocusedBackColor="" FieldName="IsKey" ValidationRules="None">
                                                    <asp:ListItem Text="Si" Value="S"></asp:ListItem>
                                                    <asp:ListItem Text="Si (identity)" Value="X"></asp:ListItem>
                                                    <asp:ListItem Selected="True" Text="No" Value="N"></asp:ListItem>                                                        
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblWrapCol" runat="server" IncasTag="" Text="Wrap:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkWrapCol" runat="server" IncasTag="" 
                                                    Translate="False" FocusedBackColor="" FieldName="WrapCol" 
                                                    ValidationRules="None">
                                                </iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblHtmlEncode" runat="server" IncasTag="" 
                                                    Text="Html Encode:" FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkHtmlEncode" runat="server" IncasTag="" 
                                                    Translate="False" FocusedBackColor="" FieldName="HtmlEncode" 
                                                    ValidationRules="None">
                                                </iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCanSort" runat="server" IncasTag="" Text="Ordinabile:" 
                                                    FocusedBackColor="" ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkCanSort" runat="server" IncasTag="" 
                                                    Translate="False" FocusedBackColor="" FieldName="CanSort" 
                                                    ValidationRules="None">
                                                </iwc:IboWebCheckBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblNomCamExp" runat="server" IncasTag="" 
                                                    Text="Nome campo per esportazione:" Width="100px" FocusedBackColor="" 
                                                    ValidationRules="None"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboDropDownList ID="cmbNomCamExp" runat="server" AutoPostBack="True" CharacterCase="Uppercase"
                                                    IncasTag="" SqlQuery="SELECT * FROM CBO_WFI_ELENCOCAMPITABELLA"
                                                    SqlQueryFilter="" SqlQueryOrderBy="DESCRIZIONE"
                                                    Width="500px" FocusedBackColor="" FieldName="NomCamExp" 
                                                    ValidationRules="None">
                                                </iwc:IboDropDownList>
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
