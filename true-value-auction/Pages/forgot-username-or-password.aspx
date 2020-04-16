<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot-username-or-password.aspx.cs" Inherits="truevalueauction.Pages.forgot_username_or_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/Theme/login.css" type="text/css"/>
    <title>Forgot Username/Password</title>
</head>
<body>
    <form class="main" style="height: 300px" runat="server">
        <div>
            <br />
            <br />
            <br />
            <div style="text-align:center"><h3>Please enter your email address</h3></div>
        </div>
        <div style="text-align:center">
            <asp:TextBox ID="txtEmail" runat="server" CssClass="un" style="width:75%"></asp:TextBox>
        </div>
        <div style="text-align:center">
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="submit" style="width:50%"/>
        </div>
    </form>
</body>
</html>
