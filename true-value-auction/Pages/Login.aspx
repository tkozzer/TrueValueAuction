<%@ Page Language="C#" CodeBehind="Login.aspx.cs" Inherits="truevalueauction.Pages.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 370px;
            margin-top: 0px;
        }
        .auto-style4 {
            height: 73px;
            width: 417px;
        }
        .auto-style5 {
            height: 73px;
        }
        .auto-style6 {
            width: 711px;
            height: 73px;
        }
        .auto-style12 {
            width: 711px;
        }
        .auto-style13 {
            width: 417px;
        }
        .auto-style26 {
            height: 28px;
            width: 417px;
        }
        .auto-style28 {
            width: 711px;
            height: 28px;
        }
        .auto-style29 {
            height: 73px;
            text-align: center;
        }
        .auto-style30 {
            height: 28px;
        }
        .auto-style32 {
            height: 4px;
            width: 417px;
        }
        .auto-style33 {
            height: 4px;
        }
        .auto-style34 {
            width: 711px;
            height: 4px;
        }
    </style>
</head>
<body style="height: 376px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style29">
                    True Value Auctions</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <p>User Login</p>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style32"></td>
                <td class="auto-style33">
                    Username:
                </td>
                <td class="auto-style34">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:Label ID="lblUserNameError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style26"></td>
                <td class="auto-style30">
                    Password:
                </td>
                <td class="auto-style28">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="lblPasswordError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="100px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="btnRegister" runat="server" Text="Sign Up!" Width="100px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
