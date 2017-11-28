<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWork.Calc.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 23px;
        }
        .auto-style3 {
            width: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="103px"></asp:TextBox>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="7" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="8" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="9" />
                </td>
                <td>
                    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="+" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="4" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="5" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="6" />
                </td>
                <td>
                    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="-" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="1" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="2" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="3" />
                </td>
                <td>
                    <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="*" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="0" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="C" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="=" />
                </td>
                <td>
                    <asp:Button ID="Button20" runat="server" OnClick="Button20_Click" Text="/" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
