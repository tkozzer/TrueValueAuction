<%@ Page Language="C#" CodeBehind="Login.aspx.cs" Inherits="truevalueauction.Pages.Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/Theme/login.css" type="text/css"/>
    <title>Login</title>
    <style type="text/css">
        .auto-style54 {
            width: 241px;
        }
        .auto-style55 {
            height: 106px;
        }
        .auto-style56 {
            width: 473px;
            text-align: center;
            height: 106px;
        }
        .auto-style57 {
            width: 241px;
            height: 40px;
        }
        .auto-style58 {
            width: 99%;
            height: 76px;
            margin-right: 0px;
        }
        .auto-style59 {
            width: 761px;
            height: 40px;
        }
        .auto-style60 {
            width: 761px;
        }
        .auto-style61 {
            width: 666px;
            height: 40px;
        }
        .auto-style62 {
            width: 666px;
        }
        .auto-style63 {
            height: 106px;
            width: 10px;
        }
        .auto-style64 {
            width: 10px;
        }
    </style>
</head>
<body style="height: 376px">
    <form class="main" runat="server">
        <table class="auto-style34">
            <tr>
                <td class="auto-style55"></td>
                <td class="auto-style56"><h1>TrueValue Auction</h1><h3>Login</h3></td>
                <td class="auto-style63"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style36">
                    <table class="auto-style58">
                        <tr>
                            <td class="auto-style59">
                                &nbsp;</td>
                            <td class="auto-style57">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="un" placeholder="Username"></asp:TextBox>
                            </td>
                            <td class="auto-style61">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style60">
                                &nbsp;</td>
                            <td class="auto-style54">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="un" placeholder="Password"></asp:TextBox>
                            </td>
                            <td class="auto-style62">
                                &nbsp;</td>
                        </tr>
                    </table>
                    <div style="text-align:center">
                    <asp:Label ID="lblPasswordError" ForeColor="Crimson" runat="server"></asp:Label>
                    </div>
                </td>
                <td class="auto-style64">&nbsp;</td>
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
                    <div style="text-align:center"><asp:HyperLink ID="linkForgottenLogin" runat="server" CssClass="forgotLogin" NavigateUrl="~/Pages/forgot-username-or-password.aspx">Fogot Username/Password</asp:HyperLink></div>
                </td>
                <td class="auto-style64">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

