<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="IboWebDate.ascx.vb" Inherits="Incasbo.Web.Components.IboWebDate" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>
<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<asp:Panel ID="pnlComponent" runat="server" CssClass="IboWebDate_Component">
    <asp:Panel ID="pnlContainer" runat="server" CssClass="IncasControl IboWebDate">
        <asp:UpdatePanel ID="UPIWD" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <table class="IboWebDate_Table">
                    <tr>
                        <td>
                            <asp:Table runat="server" ID="DateTable">
                                <asp:TableRow>
                                    <asp:TableCell ID="TableCell2">
                                        <iwc:IboWebTextBox ID="IboWebDate_txtInput" runat="server" Width="80px" MaxLength="1" Style="text-align: justify;" CssClass="IboWebDate_txtInput"
                                            ValidationGroup="MKE" />
                                        <act:MaskedEditExtender ID="meeInput" runat="server" TargetControlID="IboWebDate_txtInput" Mask="99/99/9999" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                                            OnInvalidCssClass="MaskedEditError" MaskType="Date" DisplayMoney="Left" AcceptNegative="Left" ErrorTooltipEnabled="True" />
                                        <act:MaskedEditValidator ID="mevInput" runat="server" ControlExtender="meeInput" ControlToValidate="IboWebDate_txtInput" EmptyValueMessage="Date is required"
                                            InvalidValueMessage="Date is invalid" Display="Dynamic" EmptyValueBlurredText="*" InvalidValueBlurredMessage="*" ValidationGroup="MKE" SetFocusOnError="True">*</act:MaskedEditValidator><act:CalendarExtender
                                                ID="cexInput" runat="server" TargetControlID="IboWebDate_txtInput" PopupButtonID="imbCal" Format="dd/MM/yyyy" CssClass="IboWebDateCalendar"
                                                TodaysDateFormat="d MMMM yyyy" />
                                    </asp:TableCell><asp:TableCell ID="TableCell1">
                                        <asp:ImageButton ID="imbCal" runat="server" ImageUrl="~/images/calendar.png" CausesValidation="False" CssClass="IboWebDate_imgButton" />
                                    </asp:TableCell><asp:TableCell ID="TableCell3">
                                        <asp:ImageButton ID="imgToday" runat="server" ImageUrl="~/images/Today.png" CausesValidation="False" CssClass="IboWebDate_imgButton" ToolTip="Set Date to Today"
                                            Visible="false" />
                                    </asp:TableCell></asp:TableRow>
                            </asp:Table>
                        </td>
                        <td>
                            <asp:Table runat="server" ID="TimeTable" Visible="false" CssClass="IboWebDate_Table">
                                <asp:TableRow ID="TimeSectionR1">
                                    <asp:TableCell ID="TimeSectionR1C1">
                                        <asp:DropDownList ID="Ore" runat="server" CssClass="IboWebDate_Ora">
                                            <asp:ListItem Text=""></asp:ListItem>
                                            <asp:ListItem Text="00"></asp:ListItem>
                                            <asp:ListItem Text="01"></asp:ListItem>
                                            <asp:ListItem Text="02"></asp:ListItem>
                                            <asp:ListItem Text="03"></asp:ListItem>
                                            <asp:ListItem Text="04"></asp:ListItem>
                                            <asp:ListItem Text="05"></asp:ListItem>
                                            <asp:ListItem Text="06"></asp:ListItem>
                                            <asp:ListItem Text="07"></asp:ListItem>
                                            <asp:ListItem Text="08"></asp:ListItem>
                                            <asp:ListItem Text="09"></asp:ListItem>
                                            <asp:ListItem Text="10"></asp:ListItem>
                                            <asp:ListItem Text="11"></asp:ListItem>
                                            <asp:ListItem Text="12"></asp:ListItem>
                                            <asp:ListItem Text="13"></asp:ListItem>
                                            <asp:ListItem Text="14"></asp:ListItem>
                                            <asp:ListItem Text="15"></asp:ListItem>
                                            <asp:ListItem Text="16"></asp:ListItem>
                                            <asp:ListItem Text="17"></asp:ListItem>
                                            <asp:ListItem Text="18"></asp:ListItem>
                                            <asp:ListItem Text="19"></asp:ListItem>
                                            <asp:ListItem Text="20"></asp:ListItem>
                                            <asp:ListItem Text="21"></asp:ListItem>
                                            <asp:ListItem Text="22"></asp:ListItem>
                                            <asp:ListItem Text="23"></asp:ListItem>
                                        </asp:DropDownList>
                                    </asp:TableCell><asp:TableCell ID="TimeSectionR1C2">
                                        <asp:DropDownList ID="Minuti" runat="server" CssClass="IboWebDate_Minuti">
                                            <asp:ListItem Text=""></asp:ListItem>
                                            <asp:ListItem Text="00"></asp:ListItem>
                                            <asp:ListItem Text="01"></asp:ListItem>
                                            <asp:ListItem Text="02"></asp:ListItem>
                                            <asp:ListItem Text="03"></asp:ListItem>
                                            <asp:ListItem Text="04"></asp:ListItem>
                                            <asp:ListItem Text="05"></asp:ListItem>
                                            <asp:ListItem Text="06"></asp:ListItem>
                                            <asp:ListItem Text="07"></asp:ListItem>
                                            <asp:ListItem Text="08"></asp:ListItem>
                                            <asp:ListItem Text="09"></asp:ListItem>
                                            <asp:ListItem Text="10"></asp:ListItem>
                                            <asp:ListItem Text="11"></asp:ListItem>
                                            <asp:ListItem Text="12"></asp:ListItem>
                                            <asp:ListItem Text="13"></asp:ListItem>
                                            <asp:ListItem Text="14"></asp:ListItem>
                                            <asp:ListItem Text="15"></asp:ListItem>
                                            <asp:ListItem Text="16"></asp:ListItem>
                                            <asp:ListItem Text="17"></asp:ListItem>
                                            <asp:ListItem Text="18"></asp:ListItem>
                                            <asp:ListItem Text="19"></asp:ListItem>
                                            <asp:ListItem Text="20"></asp:ListItem>
                                            <asp:ListItem Text="21"></asp:ListItem>
                                            <asp:ListItem Text="22"></asp:ListItem>
                                            <asp:ListItem Text="23"></asp:ListItem>
                                            <asp:ListItem Text="24"></asp:ListItem>
                                            <asp:ListItem Text="25"></asp:ListItem>
                                            <asp:ListItem Text="26"></asp:ListItem>
                                            <asp:ListItem Text="27"></asp:ListItem>
                                            <asp:ListItem Text="28"></asp:ListItem>
                                            <asp:ListItem Text="29"></asp:ListItem>
                                            <asp:ListItem Text="30"></asp:ListItem>
                                            <asp:ListItem Text="31"></asp:ListItem>
                                            <asp:ListItem Text="32"></asp:ListItem>
                                            <asp:ListItem Text="33"></asp:ListItem>
                                            <asp:ListItem Text="34"></asp:ListItem>
                                            <asp:ListItem Text="35"></asp:ListItem>
                                            <asp:ListItem Text="36"></asp:ListItem>
                                            <asp:ListItem Text="37"></asp:ListItem>
                                            <asp:ListItem Text="38"></asp:ListItem>
                                            <asp:ListItem Text="39"></asp:ListItem>
                                            <asp:ListItem Text="40"></asp:ListItem>
                                            <asp:ListItem Text="41"></asp:ListItem>
                                            <asp:ListItem Text="42"></asp:ListItem>
                                            <asp:ListItem Text="43"></asp:ListItem>
                                            <asp:ListItem Text="44"></asp:ListItem>
                                            <asp:ListItem Text="45"></asp:ListItem>
                                            <asp:ListItem Text="46"></asp:ListItem>
                                            <asp:ListItem Text="47"></asp:ListItem>
                                            <asp:ListItem Text="48"></asp:ListItem>
                                            <asp:ListItem Text="49"></asp:ListItem>
                                            <asp:ListItem Text="50"></asp:ListItem>
                                            <asp:ListItem Text="51"></asp:ListItem>
                                            <asp:ListItem Text="52"></asp:ListItem>
                                            <asp:ListItem Text="53"></asp:ListItem>
                                            <asp:ListItem Text="54"></asp:ListItem>
                                            <asp:ListItem Text="55"></asp:ListItem>
                                            <asp:ListItem Text="56"></asp:ListItem>
                                            <asp:ListItem Text="57"></asp:ListItem>
                                            <asp:ListItem Text="58"></asp:ListItem>
                                            <asp:ListItem Text="59"></asp:ListItem>
                                        </asp:DropDownList>
                                    </asp:TableCell><asp:TableCell ID="TimeSectionR1C3">
                                        <asp:DropDownList ID="Secondi" runat="server" CssClass="IboWebDate_Secondi">
                                            <asp:ListItem Text=""></asp:ListItem>
                                            <asp:ListItem Text="00"></asp:ListItem>
                                            <asp:ListItem Text="01"></asp:ListItem>
                                            <asp:ListItem Text="02"></asp:ListItem>
                                            <asp:ListItem Text="03"></asp:ListItem>
                                            <asp:ListItem Text="04"></asp:ListItem>
                                            <asp:ListItem Text="05"></asp:ListItem>
                                            <asp:ListItem Text="06"></asp:ListItem>
                                            <asp:ListItem Text="07"></asp:ListItem>
                                            <asp:ListItem Text="08"></asp:ListItem>
                                            <asp:ListItem Text="09"></asp:ListItem>
                                            <asp:ListItem Text="10"></asp:ListItem>
                                            <asp:ListItem Text="11"></asp:ListItem>
                                            <asp:ListItem Text="12"></asp:ListItem>
                                            <asp:ListItem Text="13"></asp:ListItem>
                                            <asp:ListItem Text="14"></asp:ListItem>
                                            <asp:ListItem Text="15"></asp:ListItem>
                                            <asp:ListItem Text="16"></asp:ListItem>
                                            <asp:ListItem Text="17"></asp:ListItem>
                                            <asp:ListItem Text="18"></asp:ListItem>
                                            <asp:ListItem Text="19"></asp:ListItem>
                                            <asp:ListItem Text="20"></asp:ListItem>
                                            <asp:ListItem Text="21"></asp:ListItem>
                                            <asp:ListItem Text="22"></asp:ListItem>
                                            <asp:ListItem Text="23"></asp:ListItem>
                                            <asp:ListItem Text="24"></asp:ListItem>
                                            <asp:ListItem Text="25"></asp:ListItem>
                                            <asp:ListItem Text="26"></asp:ListItem>
                                            <asp:ListItem Text="27"></asp:ListItem>
                                            <asp:ListItem Text="28"></asp:ListItem>
                                            <asp:ListItem Text="29"></asp:ListItem>
                                            <asp:ListItem Text="30"></asp:ListItem>
                                            <asp:ListItem Text="31"></asp:ListItem>
                                            <asp:ListItem Text="32"></asp:ListItem>
                                            <asp:ListItem Text="33"></asp:ListItem>
                                            <asp:ListItem Text="34"></asp:ListItem>
                                            <asp:ListItem Text="35"></asp:ListItem>
                                            <asp:ListItem Text="36"></asp:ListItem>
                                            <asp:ListItem Text="37"></asp:ListItem>
                                            <asp:ListItem Text="38"></asp:ListItem>
                                            <asp:ListItem Text="39"></asp:ListItem>
                                            <asp:ListItem Text="40"></asp:ListItem>
                                            <asp:ListItem Text="41"></asp:ListItem>
                                            <asp:ListItem Text="42"></asp:ListItem>
                                            <asp:ListItem Text="43"></asp:ListItem>
                                            <asp:ListItem Text="44"></asp:ListItem>
                                            <asp:ListItem Text="45"></asp:ListItem>
                                            <asp:ListItem Text="46"></asp:ListItem>
                                            <asp:ListItem Text="47"></asp:ListItem>
                                            <asp:ListItem Text="48"></asp:ListItem>
                                            <asp:ListItem Text="49"></asp:ListItem>
                                            <asp:ListItem Text="50"></asp:ListItem>
                                            <asp:ListItem Text="51"></asp:ListItem>
                                            <asp:ListItem Text="52"></asp:ListItem>
                                            <asp:ListItem Text="53"></asp:ListItem>
                                            <asp:ListItem Text="54"></asp:ListItem>
                                            <asp:ListItem Text="55"></asp:ListItem>
                                            <asp:ListItem Text="56"></asp:ListItem>
                                            <asp:ListItem Text="57"></asp:ListItem>
                                            <asp:ListItem Text="58"></asp:ListItem>
                                            <asp:ListItem Text="59"></asp:ListItem>
                                        </asp:DropDownList>
                                    </asp:TableCell></asp:TableRow>
                            </asp:Table>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
</asp:Panel>
