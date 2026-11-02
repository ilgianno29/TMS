<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="idlePage.aspx.vb" Inherits="Incasbo.idlePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        var WFI = new WFICore();
        function get_WFIinstance() {
            return WFI;
        }
        function WFICore() {
            var _CanIClose = true;
            this.CanIClose = function () {
                return _CanIClose;
            }
        }
    </script>
</head>
<body style="background-color:#f7f7f7;">
    <form id="form1" runat="server">
        <div style="text-align: center; left: 34%; top: 48%; width: 30%; font-size: 14pt; font-style: italic; position: absolute;">
            Wait ...
        </div>
    </form>
</body>
</html>
