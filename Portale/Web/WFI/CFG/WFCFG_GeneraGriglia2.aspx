<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master"
    CodeBehind="WFCFG_GeneraGriglia2.aspx.vb" Inherits="Incasbo.Web.CFG.WFCFG_GeneraGriglia2" %>

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
                        <asp:Panel runat="server" ID="pnlMain" Width="800px">
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpInfoGen_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px;">
                                                <iwc:IboWebLabel ID="lblNomRif" runat="server" IncasTag="" Text="Id Griglia:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox runat="server" CharacterCase="Uppercase" Required="True" MaxLength="30" Width="250px"
                                                    ID="txtNomRif" FieldName="NomRif"></iwc:IboWebTextBox>
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblInternalGrid" runat="server" IncasTag="" Text="Tipo di griglia:" Width="150px"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optTipoGriglia" runat="server" RepeatDirection="Horizontal"
                                                    IncasTag="" Height="25px" FieldName="TipoGriglia" AutoPostBack="true">
                                                    <asp:ListItem Value="S" Text="Standard" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="I" Text="Interna"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDescrizione" runat="server" IncasTag="" Text="Titolo:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebTextBox ID="txtDesTab" runat="server" MaxLength="255" Required="True" Width="550px"
                                                    CharacterCase="None" FieldName="DesTab"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblVistaDiRiferimento" runat="server" IncasTag="" Text="Vista di riferimento:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebComboTlk ID="cmbNomTab" runat="server" SqlQuery="SELECT * FROM CBO_WFI_ELENCOTABELLE" AutoPostBack="True" Required="True" Width="550px" AutoLoadOnDemand="True">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblWhereAggiuntiva" runat="server" IncasTag="" Text="Filtro Iniziale:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebTextBox ID="txtWhereAggiuntiva" runat="server" CharacterCase="Uppercase" MaxLength="255" Width="550px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblCansel" runat="server" IncasTag="" Text="Selezione"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell" colspan="3">
                                                <iwc:IboWebRadioButtonList ID="optCanSel" runat="server" RepeatDirection="Horizontal"
                                                    IncasTag="" Height="25px">
                                                    <asp:ListItem Value="S" Text="Singola" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="Nessuna"></asp:ListItem>
                                                    <asp:ListItem Value="M" Text="Multipla"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpInfoGen" runat="server" CollapseControlID="cpInfoGen_Title"
                                    Collapsed="False" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="True" ExpandControlID="cpInfoGen_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpInfoGen_Title_Image" TargetControlID="cpInfoGen_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpObjectManager_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpObjectManager_Title_Caption" Text="Object Manager" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpObjectManager_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpObjectManager_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 150px;">
                                                <iwc:IboWebLabel ID="lblTipoObjectManager" runat="server" IncasTag="" Text="Tipo ObjectManager" Width="150px"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebRadioButtonList ID="optTipoObjectManager" runat="server" RepeatDirection="Horizontal"
                                                    IncasTag="" Height="25px" AutoPostBack="true">
                                                    <asp:ListItem Value="E" Text="Esistente" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="N" Text="Nuovo"></asp:ListItem>
                                                    <asp:ListItem Value="X" Text="Nessuno"></asp:ListItem>
                                                </iwc:IboWebRadioButtonList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblObjectManager" runat="server" IncasTag="" Text="Form Dettaglio:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebComboTlk ID="cmbObjectManager" runat="server" SqlQuery="SELECT * FROM CBO_WFI_OBJECTMANAGER" AutoPostBack="True" Width="550px" AutoLoadOnDemand="True"
                                                    Height="0px" MaxHeight="500px">
                                                </iwc:IboWebComboTlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDescrizioneObjectManager" runat="server" IncasTag="" Text="Descrizione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDescrizioneObjectManager" runat="server" CharacterCase="Uppercase" MaxLength="255"
                                                    Width="550px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblTabellaObjectManager" runat="server" IncasTag="" Text="Tabella:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtTabellaObjectManager" runat="server" CharacterCase="Uppercase" MaxLength="255"
                                                    Width="550px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblRedirectToObjectManager" runat="server" IncasTag="" Text="Redirect To:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtRedirectToObjectManager" runat="server" CharacterCase="Uppercase" MaxLength="255"
                                                    Width="550px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpObjectManager" runat="server" CollapseControlID="cpObjectManager_Title"
                                    Collapsed="False" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="True" ExpandControlID="cpObjectManager_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpObjectManager_Title_Image" TargetControlID="cpObjectManager_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpElencoPulsanti_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpElencoPulsanti_Title_Caption" Text="Opzioni Pulsanti" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpElencoPulsanti_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpElencoPulsanti_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblPulsanteFiltro" runat="server" IncasTag="" Text="Pulsante Filtro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteFiltro" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteFiltro" />
                                            </td>
                                            <td class="DetailFormDescriptionCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblPulsanteModifica" runat="server" IncasTag="" Text="Pulsante Modifica:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteModifica" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteModifica" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteAggiorna" runat="server" IncasTag="" Text="Pulsante Aggiorna:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteAggiorna" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteAggiorna" />
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteCancella" runat="server" IncasTag="" Text="Pulsante Cancella:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteCancella" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteCancella" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteAnnullaFiltro" runat="server" IncasTag="" Text="Pulsante Annulla Filtro:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteAnnullaFiltro" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteAnnullaFiltro" />
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteDuplica" runat="server" IncasTag="" Text="Pulsante Duplica:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteDuplica" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteDuplica" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteVisualizza" runat="server" IncasTag="" Text="Pulsante Visualizza:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteVisualizza" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteVisualizza" />
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteStampa" runat="server" IncasTag="" Text="Pulsante Stampa:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteStampa" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteStampa" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteInserisci" runat="server" IncasTag="" Text="Pulsante Inserisci:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteInserisci" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteInserisci" />
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblPulsanteEsporta" runat="server" IncasTag="" Text="Pulsante Esporta:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkPulsanteEsporta" runat="server" IncasTag="" Checked="True"
                                                    Value="S" FieldName="PulsanteEsporta" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="4">
                                                <hr />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblShowCaption" runat="server" IncasTag="" Text="Mostra Caption:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkShowCaption" runat="server" IncasTag="" Checked="false"
                                                    Value="N" FieldName="" />
                                            </td>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblShowImage" runat="server" IncasTag="" Text="Mostra Immagine:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkShowImage" runat="server" IncasTag="" Checked="True" Value="S" FieldName="" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpElencoPulsanti" runat="server" CollapseControlID="cpElencoPulsanti_Title"
                                    Collapsed="False" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="True" ExpandControlID="cpElencoPulsanti_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpElencoPulsanti_Title_Image" TargetControlID="cpElencoPulsanti_Body">
                                </ajaxToolkit:CollapsiblePanelExtender>
                                <asp:Panel runat="server" ID="cpOpzioniAggiuntive_Title" CssClass="CollapsiblePanelTitle">
                                    <iwc:IboWebLabel runat="server" ID="cpOpzioniAggiuntive_Title_Caption" Text="Opzioni aggiuntive" CssClass="CollapsiblePanelTitleCaption"></iwc:IboWebLabel>
                                    <asp:Image runat="server" ID="cpOpzioniAggiuntive_Title_Image" ImageUrl="~/images/collapse.png" CssClass="CollapsiblePanelTitleImage" />
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpOpzioniAggiuntive_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 200px;">
                                                <iwc:IboWebLabel ID="lblSovrascriviConfigurazione" runat="server" IncasTag="" Text="Sovrascrivi configurazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkSovrascriviConfigurazione" runat="server" IncasTag="" FieldName="SovrascriviConfigurazione" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblVoce" runat="server" IncasTag="" Text="Crea voce di menu:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtVoce" runat="server" CharacterCase="Uppercase" MaxLength="60" Width="400px"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblDescrizioneVoce" runat="server" IncasTag="" Text="Descrizione voce:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebTextBox ID="txtDescrizioneVoce" runat="server" MaxLength="255" Required="False" Width="400px" CharacterCase="None"></iwc:IboWebTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell">
                                                <iwc:IboWebLabel ID="lblTest" runat="server" IncasTag="" Text="Lancia test al termine della creazione:"></iwc:IboWebLabel>
                                            </td>
                                            <td class="DetailFormValueCell">
                                                <iwc:IboWebCheckBox ID="chkTest" runat="server" IncasTag="" Checked="True" Value="S"
                                                    FieldName="Test" />
                                            </td>
                                        </tr>
                                        <tr>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <ajaxToolkit:CollapsiblePanelExtender ID="cpOpzioniAggiuntive" runat="server" CollapseControlID="cpOpzioniAggiuntive_Title"
                                    Collapsed="False" CollapsedImage="~/images/expand.png" CollapsedSize="0" CollapsedText="Show Details..."
                                    Enabled="True" ExpandControlID="cpOpzioniAggiuntive_Title" ExpandedImage="~/images/collapse.png" ExpandedSize="0"
                                    ExpandedText="Hide Details" ImageControlID="cpOpzioniAggiuntive_Title_Image" TargetControlID="cpOpzioniAggiuntive_Body">
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
