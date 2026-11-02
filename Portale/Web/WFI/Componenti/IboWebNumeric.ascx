<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="IboWebNumeric.ascx.vb" Inherits="Incasbo.Web.Components.IboWebNumeric" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register Assembly="IboWebComponents" Namespace="Incasbo.Web.Components" TagPrefix="iwc" %>
<asp:Panel ID="pnlComponent" runat="server" >
    <%--<link href="~/WFI/css/WFIMaster.css" rel="stylesheet" type="text/css" />--%>
    <asp:Panel ID="pnlContainer" runat="server" CssClass="IncasControl IboWebNumeric">
        <table>
            <tr>
                <td>
                    <iwc:IboWebTextBox ID="iwnTxtInput" runat="server" MaxLength="0" Text="0,00" Width="100px"></iwc:IboWebTextBox>
                    <ajaxtoolkit:MaskedEditExtender ID="meeInput" runat="server" CultureName="it-IT" Enabled="True" InputDirection="RightToLeft" Mask="999999.99"
                        MaskType="Number" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError" 
                        TargetControlID="iwnTxtInput">
                    </ajaxtoolkit:MaskedEditExtender>
                </td>
                <td>
                    <ajaxtoolkit:MaskedEditValidator ID="mevInput" runat="server" ControlExtender="meeInput" 
                        ControlToValidate="iwnTxtInput" Display="Dynamic" 
                        EmptyValueMessage="Inserisci un numero" InvalidValueMessage="*" IsValidEmpty="False" MaximumValue="99999999" MinimumValue="0"
                        TooltipMessage="Inserisci un numero" ErrorMessage="*" InitialValue="0.00" SetFocusOnError="True" 
                        EmptyValueBlurredText="Inserisci un numero" InvalidValueBlurredMessage="*" MinimumValueBlurredText="*" 
                        MinimumValueMessage="*" MaximumValueMessage="*" MaximumValueBlurredMessage="*" ForeColor="Red"></ajaxtoolkit:MaskedEditValidator>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Panel>
