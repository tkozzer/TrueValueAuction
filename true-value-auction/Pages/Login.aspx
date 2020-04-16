<%@ Page Language="C#" CodeBehind="Login.aspx.cs" Inherits="truevalueauction.Pages.Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/Theme/login.css" type="text/css">
    <title>Login</title>
</head>
<body style="height: 376px">
    <form class="main" runat="server">
        <table class="auto-style34">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style47"><h1>TrueValue Auction</h1><h3>Login</h3></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style36">
                    <table class="auto-style35">
                        <tr>
                            <td class="auto-style42"></td>
                            <td class="auto-style43">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="un" placeholder="Username"></asp:TextBox>
                            </td>
                            <td class="auto-style44">
                    <asp:Label ID="lblUserNameError" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style45"></td>
                            <td class="auto-style46">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="un" placeholder="Password"></asp:TextBox>
                            </td>
                            <td>
                    <asp:Label ID="lblPasswordError" ForeColor="Crimson" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style36">
                    <table class="auto-style48">
                        <tr>
                            <td class="auto-style51">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style51">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="submit" />
                            </td>
                            <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Sign Up!" CssClass="signup" OnClick="btnRegister_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style51">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

