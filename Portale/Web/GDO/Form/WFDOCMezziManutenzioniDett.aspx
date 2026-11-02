<%@ Page Title=" " Language="vb" AutoEventWireup="false" MasterPageFile="~/WFI/Form/WFIMaster.Master" CodeBehind="WFDOCMezziManutenzioniDett.aspx.vb" Inherits="Incasbo.Web.GDO.WFDOCMezziManutenzioniDett" %>

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
                                    <iwc:iboweblabel id="lblTitle" runat="server" text="Titolo Form"></iwc:iboweblabel>
                                </div>
                            </td>
                            <td class="DetailFormHeaderTable_c2">
                                <div class="DetailFormModeDiv">
                                    <iwc:iboweblabel id="lblDataAccessMode" runat="server" text="Modalità"></iwc:iboweblabel>
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
                            <div class="DetailFormContainerDivCollapsiblePanel">
                                <asp:Panel runat="server" ID="cpInfoGen_Title" CssClass="CollapsiblePanelTitle">
                                    <asp:Label runat="server" ID="cpInfoGen_Title_Caption" Text="Generale" CssClass="CollapsiblePanelTitleCaption"></asp:Label>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="cpInfoGen_Body" CssClass="CollapsiblePanelBody">
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:iboweblabel id="lblControllo" runat="server" incastag="" text="Controllo:"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 400px">
                                                <iwc:ibowebcombotlk id="CmbControllo" runat="server" incastag="" sqlquery="SELECT * FROM CBO_ANA_MezziManu_Contr_Dett" width="400px" sqlqueryfilter=""
                                                    sqlqueryorderby="DESCRIZIONE" campodescrizione="DESCRIZIONE" required="false">
                                                </iwc:ibowebcombotlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:iboweblabel id="lblOreManodopera" runat="server" incastag="" text="Ore Manodopera"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 110px">
                                                <iwc:ibowebnumerictlk runat="server" id="OreManodopera" required="True" width="100px"
                                                    readonly="true">
                                                </iwc:ibowebnumerictlk>
                                            </td>
<%--                                        </tr>
                                        <tr>--%>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:iboweblabel id="lblCostoOrario" runat="server" incastag="" text="Costo Orario"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 110px">
                                                <iwc:ibowebnumerictlk runat="server" id="CostoOrario" required="True" width="100px"
                                                    readonly="true">
                                                </iwc:ibowebnumerictlk>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:iboweblabel id="lblCostoManodopera" runat="server" incastag="" text="Costo Manodopera"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 110px">
                                                <iwc:ibowebnumerictlk runat="server" id="CostoManodopera" required="True" width="100px"
                                                    readonly="true">
                                                </iwc:ibowebnumerictlk>
                                            </td>
<%--                                        </tr>

                                        <tr>--%>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:iboweblabel id="lblCostoRicambi" runat="server" incastag="" text="Costo Ricambi"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 110px">
                                                <iwc:ibowebnumerictlk runat="server" id="CostoRicambi" required="True" width="100px"
                                                    readonly="true">
                                                </iwc:ibowebnumerictlk>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px">
                                                <iwc:iboweblabel id="lblOperatore" runat="server" text="Operatore:"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:ibowebtextbox id="txtOperatore" required="True" runat="server" charactercase="Uppercase" maxlength="60" width="600px" fieldname="Operatore"></iwc:ibowebtextbox>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="DetailFormSectionTable2Fixed">
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:iboweblabel id="lblNote1" runat="server" text="Note1:"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px;">
                                                <iwc:ibowebtextbox id="txtNote1" runat="server" charactercase="Uppercase" maxlength="1000" rows="4" textmode="MultiLine" fieldname="Note1" width="600px"></iwc:ibowebtextbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:iboweblabel id="lblNote2" runat="server" text="Note2:"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:ibowebtextbox id="txtNote2" runat="server" charactercase="Uppercase" maxlength="1000" rows="4" textmode="MultiLine" fieldname="Note2" width="600px"></iwc:ibowebtextbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="DetailFormDescriptionCell" style="width: 100px;">
                                                <iwc:iboweblabel id="lblNote3" runat="server" text="Note3:"></iwc:iboweblabel>
                                            </td>
                                            <td class="DetailFormValueCell" style="width: 600px">
                                                <iwc:ibowebtextbox id="txtNote3" runat="server" charactercase="Uppercase" maxlength="1000" rows="4" textmode="MultiLine" fieldname="Note3" width="600px"></iwc:ibowebtextbox>
                                            </td>
                                        </tr>
                                    </table>

                                    <iwc:ibowebtextbox runat="server" id="txtIdManutenzione"  Visible="false" ></iwc:ibowebtextbox>

                                </asp:Panel>
                            </div>
                        </asp:Panel>
                    </div>

                    <div class="DetailFormCommandsDivCollapsiblePanel">
                        <table id="tableButtons" class="tableButtons">
                            <tr>
                                <td id="tableButtons_L" class="tableButtons_L">
                                    <iwc:ibowebbutton id="btnAnnulla" runat="server" text="Esci" cssclass="DetailFormButton_Cancel" causesvalidation="False" />
                                </td>
                                <td id="tableButtons_C" class="tableButtons_C"></td>
                                <iwc:ibowebbutton id="btnInserimento" runat="server" text="Inserisci" cssclass="hidden" />
                                <td id="tableButtons_R" class="tableButtons_R">
                                    <iwc:ibowebbutton id="btnConferma" runat="server" text="Conferma" cssclass="DetailFormButton_Ok" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
