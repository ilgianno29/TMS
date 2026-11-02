<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="IboWebDate2.ascx.vb" Inherits="Incasbo.Web.Components.IboWebDate2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>
<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<asp:Panel ID="pnlComponent" runat="server" CssClass="IboWebDate_Component">
    <asp:Panel ID="pnlContainer" runat="server" CssClass="IncasControl IboWebDate">
        <asp:UpdatePanel ID="UPIWD" runat="server" UpdateMode="Conditional">
            <contenttemplate>
                <table class="IboWebDate_Table">
                    <tr>
                        <td class="IboWebDate_DateCell">
                            <asp:Table runat="server" ID="DateTable" CssClass="IboWebDate_DateTable">
                                <asp:TableRow>
                                    <asp:TableCell ID="TableCell1">
                                        <iwc:IboWebTextBox ID="IboWebDate_txtInput" runat="server" Width="82px" MaxLength="1" Style="text-align: justify;" CssClass="IboWebDate_txtInput"
                                            ValidationGroup="MKE" />
                                        <act:MaskedEditExtender ID="meeInput" runat="server" TargetControlID="IboWebDate_txtInput" Mask="99/99/9999" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                                            OnInvalidCssClass="MaskedEditError" MaskType="Date" DisplayMoney="Left" AcceptNegative="Left" ErrorTooltipEnabled="True" />
                                        <act:MaskedEditValidator ID="mevInput" runat="server" ControlExtender="meeInput" ControlToValidate="IboWebDate_txtInput" EmptyValueMessage="Date is required"
                                            InvalidValueMessage="Date is invalid" Display="Dynamic" EmptyValueBlurredText="*" InvalidValueBlurredMessage="*" ValidationGroup="MKE" SetFocusOnError="True">*</act:MaskedEditValidator>
                                        <act:CalendarExtender ID="cexInput" runat="server" TargetControlID="IboWebDate_txtInput" PopupButtonID="imbCal" Format="dd/MM/yyyy" CssClass="IboWebDateCalendar"
                                            TodaysDateFormat="d MMMM yyyy" />
                                    </asp:TableCell>                                    
                                    <asp:TableCell ID="TableCell2">
                                        <asp:ImageButton ID="imbCal" runat="server" ImageUrl="~/images/calendar.png" CausesValidation="False" CssClass="IboWebDate_imgButton" />
                                    </asp:TableCell>
                                    <asp:TableCell ID="TableCell3">
                                        <asp:ImageButton ID="imgToday" runat="server" ImageUrl="~/images/Today.png" CausesValidation="False" CssClass="IboWebDate_imgButton" ToolTip="Set Date to Today" Visible="false" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </td>
                        <td class="IboWebDate_TimeCell">
                            <asp:Table runat="server" ID="TimeTable" Visible="false" CssClass="IboWebDate_TimeTable">
                                <asp:TableRow ID="AllTimeSection">
                                    <asp:TableCell ID="AllTimeSectionR1C1">
                                        <iwc:IboWebTextBox ID="IboWebTime_txtInput" runat="server" Width="60px" CssClass="IboWebTime_txtInput" ValidationGroup="MKE2" />
                                        <act:MaskedEditExtender ID="meeInputTime" runat="server" TargetControlID="IboWebTime_txtInput" Mask="99:99:99" AcceptAMPM="false" MaskType="Time"
                                            MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError" ErrorTooltipEnabled="True" AutoCompleteValue="00:00:00" UserTimeFormat="None" />
                                        <act:MaskedEditValidator ID="mevInputTime" runat="server" ControlExtender="meeInputTime" ControlToValidate="IboWebTime_txtInput" EmptyValueMessage="Time is required"
                                            InvalidValueMessage="Time is invalid" Display="Dynamic" EmptyValueBlurredText="*" InvalidValueBlurredMessage="*" ValidationGroup="MKE2" SetFocusOnError="True">*</act:MaskedEditValidator>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </td>
                    </tr>
                </table>
            </contenttemplate>
        </asp:UpdatePanel>
    </asp:Panel>
</asp:Panel>
