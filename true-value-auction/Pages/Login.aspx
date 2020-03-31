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
            width: 768px;
        }
        .auto-style5 {
            width: 138px;
            height: 73px;
        }
        .auto-style6 {
            width: 711px;
            height: 73px;
        }
        .auto-style11 {
            width: 138px;
        }
        .auto-style12 {
            width: 711px;
        }
        .auto-style13 {
            width: 768px;
        }
        .auto-style14 {
            height: 94px;
        }
        .auto-style15 {
            width: 272px;
            height: 44px;
            font-size: xx-large;
            margin-left: 541px;
        }
        .auto-style16 {
            height: 40px;
            width: 768px;
        }
        .auto-style17 {
            width: 138px;
            height: 40px;
        }
        .auto-style18 {
            width: 711px;
            height: 40px;
        }
    </style>
</head>
<body style="height: 159px">
    <form id="form1" runat="server">
        <div class="auto-style14">
            <div class="auto-style15">
                True Value Auctions</div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <p>User Login</p>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style17">
                    <p>Username:</p>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:Label ID="lblUserNameError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style17">
                    <p>Password:</p>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="lblPasswordError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style11">
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
